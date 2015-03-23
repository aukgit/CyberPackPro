Public Class NewTrans
    Dim BusD As Date
    Dim MClients As New DataTable
    Dim Drv As DataGridView
    Dim WDate As Date
    Dim Before_Bal As Double
    Dim MaxLen As Double
    Dim MaxID As Decimal
    Dim DuEc, LoSSC, BeneFITC As Decimal
    Public NeedToRe As Boolean = False
    Public Load_Sum As Boolean = False
    Private Sub New_TransBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles New_TransBindingNavigatorSaveItem.Click, SENDCURRENTBALANCEToolStripMenuItem.Click, ToolStripMenuItem1.Click
        SAVE_MOBS()
    End Sub
    Public Sub SAVE_MOBS()
        Try
            Me.Validate()
            Me.New_TransBindingSource.EndEdit()
            Me.New_TransTableAdapter.Update(Me.AukDatabaseDataSet.New_Trans)
            Me.MobComBindingSource.EndEdit()
            Me.Mob_ComTableAdapter.Update(Me.AukDatabaseDataSet.Mob_Com)
            If MCompany.Visible = True Then MCompany.NeedToRe = True
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub NewTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Mob_Com' table. You can move, or remove it, as needed.
        'On Error Resume Next
        'AukF.SuggestListSourceAddGveMsg(Me.PCategoryID, Me.AukDatabaseDataSet, "Mob_Com", 0, 100)
        'Me.PDate.Text = Now.Date
        'Me.New_TransDataGridView.GridColor = Color.BlueViolet
        Me.AukDatabaseDataSet.New_Trans.DiscountColumn.DefaultValue = 0
        Me.AukDatabaseDataSet.New_Trans.ExtraMoneyColumn.DefaultValue = 0
        Me.AukDatabaseDataSet.New_Trans.AmountColumn.DefaultValue = 0
        Me.AukDatabaseDataSet.New_Trans.BenefitColumn.DefaultValue = 0

        If TVer = True Then
            Msgx = "In trail version of CyberPack Pro you are not suppose to run this ""Mobile Recharge"" [Form] more than 300 minutes.If you want to buy please contact with the developer [01913 50863],0167 01013907,01711 334201(onRequest)"
            Dim P, N As Decimal
            'MsgBox(P, , My.Settings.MobileLastDate.ToString)
            If CStr(My.Settings.MobileLastDate) = "" Or CStr(My.Settings.MobileLastDate) = "12:00:00 AM" Or CStr(My.Settings.MobileLastDate) = "00:00:00" Then
                My.Settings.MobileLastDate = Now
            End If
            P = DateDiff(DateInterval.Minute, My.Settings.MobileLastDate, Now)
            N = DateDiff(DateInterval.Day, My.Settings.MobileLastDate, Now)
            'MsgBox(P, , My.Settings.CyberLastDate.ToString)
            If P < 0 Then P = P * -1
            If N < 0 Then
                SrGens.Make_Corrupt(1)
                SOFTCLOSE()
                Exit Sub
            ElseIf N <= TestDays And N > 0 Then
                My.Settings.MobileLastDate = Now
                My.Settings.Save()
                GoTo nextwork
            End If
            If P >= 300 Then
                Warn.Msg = Msgx
                FrmL(Warn)
                Me.Close()
                Exit Sub
            End If
            My.Settings.Save()
            Me.Timer1.Enabled = True
        End If
nextwork: Me.Mob_ComTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Com)
        Me.DateBusiness.Text = Now.Date
        If Load_Sum = False Then
            ToolStripLabel2_Click(sender, e)
        Else
            Load_Sum = True
        End If
        'ADSRC.GRID_HEADERS(Me.COMMONADD_COMBO, Me.New_TransDataGridView, "0,3")
        AukF.AukDataSourceSetObjectListOrComboType(Me.COMPANY_LOAD_COMBO, Me.MobComBindingSource, 1, True, True)
        MaxLen = Val(Me.AukDatabaseDataSet.New_Trans.Columns(1).MaxLength.ToString)
        a = Val(ADSRC.MAXIMUM_VALUE(Me.AukDatabaseDataSet.Mob_Clients.TableName, "Client_ID"))
        MaxID = a
        MaxID += 1

    End Sub

    Public Sub BLANCE()
        Drv = Me.New_TransDataGridView
        SQ = AukF.GridT(Drv, 3)
        If AukF.BindFind(Me.MobComBindingSource, "CATEGORY_id", SQ) = True Then
            Me.BLANCE_LABEL.Text = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Company").ToString & " " & Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Our_Account").ToString & " T.K."
        Else
            Me.BLANCE_LABEL.Text = "INFORMATION NOT FOUND"
        End If
        Me.Check_Due_Loss_BenefitC()
    End Sub

    Private Sub New_TransDataGridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles New_TransDataGridView.CellBeginEdit
        If e.ColumnIndex = 4 Then Before_Bal = AukF.GridT(sender, 4, -1, 0) 'so that i may minus this and add or minus the new amount
        'MsgBox(Before_Bal)

    End Sub

    Private Sub New_TransDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles New_TransDataGridView.CellClick
        BLANCE()
    End Sub
    Private Sub New_TransDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles New_TransDataGridView.CellEndEdit
        Dim Sn1, Sx1 As String
        Dim Amt As Double
        Drv = Me.New_TransDataGridView
        SoftIn.DataGrid_MasterID_ByDate(Drv)
        If e.ColumnIndex = 3 Then
            Sx1 = AukF.GridT(sender, 3)
            Sn1 = AukF.GridT(sender, 2)
            If Sn1 = "" Then
                If AukF.BindFind(Me.MobComBindingSource, "Category_ID", Sx1) = True Then
                    sender(2, e.RowIndex).value = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Digits").ToString
                End If
            End If
        End If
        If e.ColumnIndex = 1 Then
            Sn1 = AukF.GridT(sender, 1)
            If IsNumeric(Sn1) = True And Sn1 <> "" Then
                SFC("Client_ID")
                DTC("n")
                STC(Sn1)
                SnX("=")
                AukF.Db_Load("CLIENT_CONTACTS,Client_Name", "Mob_Clients", MClients, True)
            End If
            If MClients.Rows.Count = 1 Then
                sender(2, e.RowIndex).value = MClients.Rows(0).Item(0).ToString
                Sx1 = Mid(MClients.Rows(0).Item(0).ToString, 1, 3).ToString
                c_name = MClients.Rows(0).Item("Client_Name").ToString
                c_name = UCase(c_name & "(" & Sn1 & ")")
                If AukF.BindFind(Me.MobComBindingSource, "Digits", Sx1) = True Then
                    Me.New_TransDataGridView(3, e.RowIndex).Value = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Category_ID").ToString
                End If
                If Len(c_name) <= MaxLen Then
                    Drv(1, e.RowIndex).Value = c_name
                End If
                MClients.Clear()
            End If
        End If
        If e.ColumnIndex = 2 Then
            Sn1 = AukF.GridT(sender, 2)
            Sx1 = Mid(Sn1, 1, 3).ToString
            'MsgBox(Sx1)
            If AukF.BindFind(Me.MobComBindingSource, "Digits", Sx1) = True Then
                Me.New_TransDataGridView(3, e.RowIndex).Value = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Category_ID").ToString
            End If
        End If
        If e.ColumnIndex = 4 Then
            If AukF.GridT(Drv, 8) = "" Then
                'MINUS_BLANCE()
                'Me.New_TransDataGridView(8, Me.New_TransDataGridView.CurrentCell.RowIndex).Value = "SEND"
            ElseIf AukF.GridT(Drv, 8).ToString.ToUpper <> "UNSEND" Then
                PLUS_BLANCE(Before_Bal)
                MINUS_BLANCE()
            End If
        End If

        If e.ColumnIndex = 6 Then
            If AukF.GridT(Drv, 8) = "" Then
                Me.RECHARGE_NUMBER("SEND")
            End If
        End If
        If AukF.GridT(Drv, 7) = "" Then Drv(7, e.RowIndex).Value = WDate
        Amt = AukF.GridT(Drv, 4, -1, 0)
        If Amt < Val(My.Settings.EXTRA_LESS) And My.Settings.EXTRA_M_TR = True Then
            Drv(5, e.RowIndex).Value = Val(My.Settings.EXTRA_MONEY_AM)
        Else
            Drv(5, e.RowIndex).Value = 0
        End If
        If e.ColumnIndex = 9 Or e.ColumnIndex = 4 Or e.ColumnIndex = 6 Then 'eFFECT ON CURRENT BENEFT AFTER EDIT DISCOUNT
            Me.Set_Benefit_OnCurrent()
        End If
        If My.Settings.DIRECT_SAVE = True Then New_TransBindingNavigatorSaveItem_Click(sender, e)
        BLANCE()

    End Sub
    Public Sub Set_Benefit_OnCurrent()
        'STR1 = UCase(AukF.GridT(Drv, 8))
        'If STR1 = "SEND BUT NOT PAID YET" Then Drv(11, DRow).Value = 0 'beneft=0
        Dim S2 As String
        Dim Drv As DataGridView = Me.New_TransDataGridView
        Dim MBp As Decimal
        'TRY TO INSERT THE VALUE OF BENEFIT
        '11=BENEFIT,9=DISCOUNT,4=AMOUNT,5=EXTRA,12=CUR BAL.
        '11= (MBP/100)*[4] +[5]-[9]
        SQ = AukF.GridT(Drv, 3) 'GET CATEGORY
        S2 = UCase(AukF.GridT(Drv, 8).ToString) 'GETING STATUS=8
        If S2 <> "SEND" Then Drv(11, DRow).Value = 0
        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Mob_Com, SQ, 5) = True Then
            MBp = Val(WGeT) 'Cause Get Current Table Cl=3 means be%,get on wget if found.
        Else
            MBp = 0
            Drv(11, DRow).Value = 0 'bene=0
        End If
        '11=discount
        '9=DISCOUNT,4=AMOUNT,5=EXTRA,12=CUR BAL.
        '11= (MBP/100)*[4] +[5]-[9]
        BeneFITC = (MBp / 100) * Val(AukF.GridT(Drv, 4).ToString) + Val(AukF.GridT(Drv, 5).ToString) - Val(AukF.GridT(Drv, 9).ToString)
        'MsgBox(BeneFITC)
        Drv(11, DRow).Value = Format(BeneFITC, "0.##")
        'Me.New_TransDataGridView.EndEdit()
        Me.New_TransBindingSource.EndEdit()
        S2 = UCase(AukF.GridT(Drv, 8).ToString)
        If S2 <> "SEND" Then Drv(11, DRow).Value = 0

        If My.Settings.DIRECT_SAVE = True Then New_TransBindingNavigatorSaveItem_Click(sender, e)

    End Sub
    Public Sub BusEnb()
        Me.MonthCalendar1.Visible = False
        datex = Me.DateBusiness.Text
        If datex = "" Then datex = Now.Date : DateBusiness.Text = Now.Date
        Try
            WDate = CDate(Me.DateBusiness.Text)
            Me.New_TransDataGridView.ReadOnly = False
            Me.DateBusiness.Enabled = False
            SFC("Date_Business")
            STC(WDate)
            DTC("d")
            SnX("=")
            AukF.Db_Load("*", "New_Trans", Me.AukDatabaseDataSet)
            Me.New_TransDataGridView.AllowUserToAddRows = True
        Catch ex As Exception
            Epx()
            Me.DateBusiness.Focus()
        End Try
    End Sub
    Public Sub LOAD_CLIENTS_INFOR() 'BY CELL NUMBER
        Dim nUM As String
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If SavMsg("DO YOU WANT SAVE BEFORE LOAD TYPED CLIENT'S CELL NUM/ID ." & vbCrLf & "YES=SAVE AND LOAD FOR NEW DATE,NO=STOP SAVE AND DO FOR NEW DATE,CANCEL= CANCEL DOING ALL.") = 1 Then
                SAVE_MOBS()
                GoTo DOWOR
            ElseIf SavInt = 2 Then
                Exit Sub
            End If
        Else
            GoTo DOWOR
        End If
DOWOR:  Me.MonthCalendar1.Visible = False
        nUM = Me.DateBusiness.Text
        'If datex = "" Then datex = Now.Date : DateBusiness.Text = Now.Date
        Try
            Me.New_TransDataGridView.ReadOnly = False
            SFC("clients_id", "mobile_number")
            STC(nUM, nUM)
            SJOIN = "or"
            ExpreC("l*")
            'DTC("d")
            SnX("=")
            AukF.Db_Load("*", "New_Trans", Me.AukDatabaseDataSet, True)
            If New_TransBindingSource.Filter IsNot Nothing Then Me.New_TransBindingSource.RemoveFilter()
            If Me.AukDatabaseDataSet.New_Trans.Rows.Count > 0 Then
                Me.DateBusiness.BackColor = Color.Black
                Me.DateBusiness.ForeColor = Color.White
            Else
                Me.DateBusiness.BackColor = Color.White
                Me.DateBusiness.ForeColor = Color.Black
            End If
            'Me.New_TransDataGridView.AllowUserToAddRows = True
        Catch ex As Exception
            Epx()
            Me.DateBusiness.Focus()
        End Try
    End Sub
    Public Sub BusDisEnb()
        If Me.DateBusiness.Enabled = False Then
            If Me.AukDatabaseDataSet.HasChanges = True Then
                If SAVMSG("DO YOU WANT TO LOAD NEW IF YOU WANT THEN PLEASE CHOOSE THE OPTION FOR SAVE ." & vbCrLf & "YES=SAVE AND LOAD FOR NEW DATE,NO=STOP SAVE AND DO FOR NEW DATE,CANCEL= CANCEL DOING ALL.") = 1 Then
                    SAVE_MOBS()
                ElseIf SavInt = 2 Then
                    Exit Sub
                End If
            End If
            Try
                'Me.DateBusiness.Text = ""
                Me.DateBusiness.Focus()
                Me.New_TransDataGridView.ReadOnly = True
                Me.DateBusiness.Enabled = True
                'SFC("Date_Time")
                'STC("#" & BusD & "#")
                'EPC("=")
                'AukF.Db_Load("*", "New_Trans", Me.New_TransBindingSource)
                Me.AukDatabaseDataSet.New_Trans.Clear()
                Me.New_TransDataGridView.AllowUserToAddRows = False
            Catch ex As Exception
                Epx()
                Me.DateBusiness.Focus()
            End Try
        Else
            BusEnb()
        End If
    End Sub
  

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Dim DMD1 As Date
        Try
            DMD1 = CDate(Me.DateBusiness.Text)
            BusDisEnb()
        Catch ex As Exception
            LOAD_CLIENTS_INFOR()
        End Try
    End Sub

    Private Sub DateBusiness_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateBusiness.KeyDown
        If e.Control = True And e.KeyCode = Keys.I Then
            LOAD_CLIENTS_INFOR()
        ElseIf e.KeyCode = Keys.Enter Then
            Try
                dm = CDate(sender.text)
                BusEnb()
            Catch ex As Exception
                LOAD_CLIENTS_INFOR()
            End Try

        End If
    End Sub
    Private Sub DueCheck(ByVal Str1 As String)
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If AukF.MsgTr("DO YOU WANT TO SAVE THOSE EDITED INFORMATION?", False, MsgBoxStyle.Information) = 1 Then
                SAVE_MOBS()
                GoTo DOWORKD
            Else
                GoTo DOWORKD
            End If
        Else
            GoTo DOWORKD
        End If
        Exit Sub
DOWORKD:

        SFC("CLIENTS_ID", "MOBILE_NUMBER")
        SJOIN = "OR"
        STC(Str1, Str1, "SEND BUT NOT PAID YET")
        aBSql = AukSql.AukSql_Main()
        'MsgBox(BSql)
        SFC("", "", "STATUS")
        STC(Str1, Str1, "SEND BUT NOT PAID YET")
        bBSql = AukSql.AukSql_Main()
        'MsgBox(BSql)
        a = "(" & aBSql & ") And " & bBSql
        'ADSRC.QEnterTo_Query_FObject_and_Select_DataGridObject(sender, e, Me.AukDatabaseDataSet.New_Trans, Me.New_TransDataGridView, "Clients_ID,Mobile_Number,Transaction_number", 0, Nothing, Nothing, False)
        AukF.Db_LoadQ(Me.AukDatabaseDataSet.New_Trans, a, -1)
        'MsgBox(Sql)

    End Sub
    'Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.New_TransTableAdapter.FillBy(Me.AukDatabaseDataSet.New_Trans, New System.Nullable(Of Date)(CType(Date__TimeToolStripTextBox.Text, Date)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FrmL(Clients)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Hide()
    End Sub

    Private Sub PrintAllCompanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click, PRINTToolStripMenuItem.Click, ToolStripMenuItem2.Click
        Dim M As New MobileReport2
        Dim Lopt As New AukDatabaseDataSetTableAdapters.OptionsTableAdapter
        Lopt.Fill(Me.AukDatabaseDataSet.Options)
        Dim Lopt2 As New AukDatabaseDataSetTableAdapters.Mob_ComTableAdapter
        Lopt2.Fill(Me.AukDatabaseDataSet.Mob_Com)
        AukF.Prnt(M, Me.AukDatabaseDataSet, Me.New_TransBindingSource)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.New_TransDataGridView, My.Settings.CLIENTS_ID, 1)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.New_TransDataGridView, My.Settings.EXTRA_COLUMN, 5)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.New_TransDataGridView, My.Settings.BUSDATE_MOB, 7)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.New_TransDataGridView, My.Settings.TRANS_MOB, 6)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.New_TransDataGridView, My.Settings.MOBCOM_NAME_MOB, 3)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.New_TransDataGridView, My.Settings.DISCOUNT_MOB, 9)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.New_TransDataGridView, My.Settings.S_MSG_TIME_MOB, 10)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.New_TransDataGridView, My.Settings.BENEFIT_MOB, 11)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.New_TransDataGridView, My.Settings.CURRENT_BALANCE_MOB, 12)
        If My.Settings.mAKE_TRANS_bAL = True Then
            If Me.New_TransDataGridView.Columns(6).HeaderText = "TRANSACTION" Then
                Me.New_TransDataGridView.Columns(6).HeaderText = "CUR.BALANCE"
            End If
        Else
            If Me.New_TransDataGridView.Columns(6).HeaderText <> "TRANSACTION" Then
                Me.New_TransDataGridView.Columns(6).HeaderText = "TRANSACTION"
            End If
        End If
        If TVer = True Then
            Dim P As Decimal
            P = DateDiff(DateInterval.Minute, Dat(My.Settings.MobileLastDate), Now)
            If P < 0 Then P = P * -1
            If P >= 400 Then
                Warn.Msg = Msgx
                FrmL(Warn)
                Me.Close()
                Me.Timer1.Enabled = False
                Exit Sub
            End If
        End If
        If Me.New_TransBindingSource.Filter Is Nothing Then
            'If Me.FILTER_EXCHANGE.Image.Equals(My.Resources.VsImg.Filter2HS) = False Then
            If Me.FILTER_EXCHANGE.Text <> "FILTER" Then
                Me.FILTER_EXCHANGE.Image = My.Resources.VsImg.Filter2HS
                Me.FILTER_EXCHANGE.Text = "FILTER"
            End If
        Else
            If Me.FILTER_EXCHANGE.Text = "FILTER" Then
                Me.FILTER_EXCHANGE.Image = My.Resources.Small_imgs.AukWrong
                Me.FILTER_EXCHANGE.Text = "REMOVE FILTER"
            End If
        End If
        If My.Settings.NEXT_B_D_L_MOB = True Then
            If Me.New_Action_Tools.Visible = False Then
                Me.New_Action_Tools.Visible = True

            End If
        Else
            If Me.New_Action_Tools.Visible = True Then
                Me.New_Action_Tools.Visible = False

            End If
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click, SEARCHQUERYMANAGERToolStripMenuItem.Click, ToolStripMenuItem9.Click
        'AukQ.Bnp = Me.New_TransBindingSource
        'AukQ.dV = Me.New_TransDataGridView
        'FrmL(AukQ)
        DVDRENT.ShowQr_Product(AukQ, New_TransDataGridView, New_TransBindingSource)
    End Sub

    Private Sub REMOVEFILTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REMOVEFILTERToolStripMenuItem.Click, ToolStripMenuItem13.Click
        Me.New_TransBindingSource.RemoveFilter()

    End Sub
    Public Sub RECHARGE_NUMBER(Optional ByVal S As String = "SEND")
        On Error Resume Next
        Dim STR1 As String = UCase(AukF.GridT(Drv, 8))
        Dim Sq As String
        Drv = Me.New_TransDataGridView
        S = UCase(S)
        'MsgBox(S)
        Me.New_TransDataGridView(8, Me.New_TransDataGridView.CurrentCell.RowIndex).Value = S
        Me.New_TransDataGridView.EndEdit()
        'Me.New_TransBindingSource.EndEdit()

        If STR1 = "" Then
            If S = "SEND" Then
                MINUS_BLANCE()
                If AukF.GridT(Drv, 10) = "" Then Drv(10, DRow).Value = CStr(TimeOfDay) 'SET SEND TIME="",SEND
                'Me.New_TransDataGridView(8, Me.New_TransDataGridView.CurrentCell.RowIndex).Value = sender.TEXT ' insert ,button caption=send,unsend,send but...
                If My.Settings.mAKE_TRANS_bAL = True Then
                    Sq = AukF.GridT(Drv, 3)
                    If AukF.BindFind(Me.MobComBindingSource, "CATEGORY_id", SQ) = True Then
                        Me.BLANCE_LABEL.Text = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Company").ToString & " " & Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Our_Account").ToString & " T.K."
                        Drv(6, DRow).Value = Val(Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Our_Account").ToString)
                    Else
                        Drv(6, DRow).Value = 0
                    End If
                End If
                GoTo BENEFIT_WORK
            ElseIf S = "UNSEND" Then '
                Drv(10, DRow).Value = DBNull.Value  'MAKE SEND TIME="",UNSEND
                Drv(11, DRow).Value = 0 'BENEFIT=0 ,CAUSE DUE
                If My.Settings.mAKE_TRANS_bAL = True Then
                    Sq = AukF.GridT(Drv, 3)
                    Drv(6, DRow).Value = 0
                End If
            Else
                GoTo BENEFIT_WORK

            End If
        ElseIf STR1 = "UNSEND" Then 'IT MEANS CALLING DUE
            If S = "SEND" Then
                GoTo BENEFIT_WORK
            ElseIf S <> "UNSEND" Then ' CAUSE UNSEND IS STAYING AND WITHOUT UNSEND IT IS DUE
                MINUS_BLANCE()
                Drv(10, DRow).Value = DBNull.Value  'MAKE SEND TIME="",UNSEND
                Drv(11, DRow).Value = 0 'BENEFIT=0 ,CAUSE DUE
                'GoTo BENEFIT_WORK
                'MsgBox("DO MINUS")
            ElseIf S = "UNSEND" Then
                Drv(10, DRow).Value = DBNull.Value  'MAKE SEND TIME="",UNSEND
                Drv(11, DRow).Value = 0 'BENEFIT=0 ,CAUSE DUE
                'GoTo BENEFIT_WORK
            End If
            ElseIf STR1 = "SEND" Or STR1 = "SEND BUT NOT PAID YET" Then
                If S = "UNSEND" Then
                    PLUS_BLANCE()
                    Drv(10, DRow).Value = DBNull.Value  'MAKE SEND TIME="",UNSEND
                    Drv(11, DRow).Value = 0 'beneft=0
                    GoTo due_Loss_Chek
                ElseIf S = "SEND BUT NOT PAID YET" Then
                    Drv(11, DRow).Value = 0 'beneft=0
                    GoTo due_Loss_Chek
                ElseIf S = "SEND" Then
                    GoTo BENEFIT_WORK
                End If
            End If
            BLANCE()
            'Me.New_TransDataGridView(8, Me.New_TransDataGridView.CurrentCell.RowIndex).Value = sender.TEXT

            'DUE,BENFIT,LOSS REFRESH ON BOTTOM

            Exit Sub

BENEFIT_WORK:
            Me.Set_Benefit_OnCurrent()
due_Loss_Chek:
            Me.Check_Due_Loss_BenefitC()

    End Sub
    Private Sub SET_STATUS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UNSENDToolStripMenuItem.Click, SENDUNPAIDToolStripMenuItem.Click, SENDToolStripMenuItem.Click, ToolStripMenuItem6.Click, ToolStripMenuItem5.Click, ToolStripMenuItem4.Click
        RECHARGE_NUMBER(sender.TEXT)

    End Sub
    Private Sub Check_Due_Loss_BenefitC()
        On Error Resume Next
        Dim Benefit_p, BeneFit_, DisCount, Extra As Decimal
        Dim Sq As String 'sq=company id
        'Me.New_TransDataGridView(8, Me.New_TransDataGridView.CurrentCell.RowIndex).Value = sender.TEXT ' insert ,button caption=send,unsend,send but...
        'If Me.New_TransDataGridView.CurrentCell.RowIndex > Me.New_TransBindingSource.Count Then Exit Sub
        Sq = AukF.GridT(Drv, 3) 'get company id
        If My.Settings.REF_DUE_BENEFIT_MOB = False Then Exit Sub
        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Mob_Com, Sq) = False Then
            Me.DUE_TOTAL_LABEL.Text = "00"
            Me.LOSS_LABEL.Text = "00"
            Me.BENEFIT_TOTAL_LABEL.Text = "00"
            Me.LOSS_LABEL.ForeColor = Color.Black
            Me.ToolStripLabel5.Text = "BENEFIT:"
            Me.ToolStripLabel5.ForeColor = Color.Black
            Me.ToolStripLabel5.BackColor = Color.White
            Benefit_p = 0
            Exit Sub
        Else
            Benefit_p = CDec(Val(RowX.Item("Benefit_Percent").ToString))
            'MsgBox(Benefit_p)
        End If

        'Me.New_TransBindingSource.EndEdit()
        If My.Settings.REF_DUE_BENEFIT_MOB = True Then

            'MsgBox(BSql)
            'MsgBox(Me.AukDatabaseDataSet.New_Trans.Compute("SUM(AMOUNT)", BSql).ToString)
            Me.ToolStripLabel5.Text = UCase(SQ) & " BENEFIT:"
            Me.ToolStripLabel5.ForeColor = Color.Blue
            Me.ToolStripLabel5.BackColor = Color.Black
            Me.DUE_TOTAL_LABEL.Text = Format(Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID='" & SQ & "' and Status='SEND BUT NOT PAID YET'", "SUM", 4)), "0.##") 'AMOUNT
            'MsgBox(Me.DUE_TOTAL_LABEL.Text)
            BeneFit_ = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID='" & SQ & "' and Status='SEND'", "SUM", 4)) '11=benefit sum,4=amount
            Extra = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID='" & Sq & "'", "SUM", 8)) '8=EXTRA
            DisCount = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID='" & Sq & "'", "SUM", "Discount")) '8=EXTRA
            'MsgBox("A " & BeneFit_ & "E " & Extra & "D " & DisCount)

            'geting all amount in byx,Byx=Sum(Amount)
            'after that collect all due,unsend in Dyn,Dyn=Due+Unsends
            'In Benefit = % of benefit *(AMOUNT-DYN[DUE+UNSENDS])
            'UNSENDS = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID='" & SQ & "' AND STATUS='UNSEND'", "SUM", 4)) '11=benefit sum,4=amount
            'Dyn = Val(Me.DUE_TOTAL_LABEL.Text) + Val(UNSENDS)
            'BeneFit_ = Val(Byx) - Val(Dyn)
            Me.BENEFIT_TOTAL_LABEL.Text = Format(((Benefit_p / 100) * BeneFit_) + Val(Extra) - DisCount, "0.##")
            'MsgBox(extra)
            If Val(Me.BENEFIT_TOTAL_LABEL.Text) - Val(Me.DUE_TOTAL_LABEL.Text) < 0 Then
                Me.LOSS_LABEL.Text = ((Me.BENEFIT_TOTAL_LABEL.Text) - Val(Me.DUE_TOTAL_LABEL.Text)) * -1
                Me.LOSS_LABEL.ForeColor = Color.Red
            Else
                Me.LOSS_LABEL.Text = 0
                Me.LOSS_LABEL.ForeColor = Color.Black
            End If
        End If
    End Sub
    Public Function MINUS_BLANCE(Optional ByVal Amt As Double = -1)
        Drv = Me.New_TransDataGridView
        'Dim RI As Integer
        Dim CTA As String = AukF.GridT(Drv, 3)
        If Amt = -1 Then Amt = Val(AukF.GridT(Drv, 4))
        Dim BEBAL As Double
        If AukF.BindFind(Me.MobComBindingSource, "CATEGORY_ID", CTA) = True Then
            'MsgBox("FOUND" & vbCrLf & BEBAL - AMT)
            BEBAL = Val(Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Our_Account").ToString)
            If (BEBAL - AMT) < 0 Then
                MsgBox("CURRENT(" & Amt & ") AMOUNT IS CROSSING YOUR (" & Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Company").ToString & ") BALANCE,WHICH IS " & BEBAL & ".", MsgBoxStyle.Critical)
                If BEBAL > 0 Then
                    If AukF.MsgTr("Transfer " & BEBAL & " to him/her?", True) = True Then
                        Me.AukDatabaseDataSet.Mob_Com(ComRow).Our_Account = 0
                        Drv(4, Drv.CurrentCell.RowIndex).Value = BEBAL
                    Else
                        Drv(4, Drv.CurrentCell.RowIndex).Value = 0
                    End If
                Else
                    Drv(4, Drv.CurrentCell.RowIndex).Value = 0
                End If
             
            Else
                Me.AukDatabaseDataSet.Mob_Com(ComRow).Our_Account = BEBAL - Amt
            End If
            SAVE_BAL()
        End If
    End Function
    Public Function PLUS_BLANCE(Optional ByVal Amt As Double = -1)
        Drv = Me.New_TransDataGridView
        'Dim RI As Integer
        Dim CTA As String = AukF.GridT(Drv, 3)
        If Amt = -1 Then Amt = Val(AukF.GridT(Drv, 4))
        Dim BEBAL As Double
        If AukF.BindFind(Me.MobComBindingSource, "CATEGORY_ID", CTA) = True Then
            BEBAL = Val(Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Our_Account").ToString)
            Me.AukDatabaseDataSet.Mob_Com(ComRow).Our_Account = BEBAL + Amt
            SAVE_BAL()
        End If
    End Function
    Public Sub SAVE_BAL()
        Try
            Me.MobComBindingSource.EndEdit()
            Me.Mob_ComTableAdapter.Update(Me.AukDatabaseDataSet.Mob_Com)
        Catch ex As Exception
            Epx()
        End Try
    End Sub
    Private Sub FILTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTERToolStripMenuItem.Click, ToolStripMenuItem11.Click
        SoftIn.QueryLink_Direct(Me.AukDatabaseDataSet.Mob_Com, "cOMPANY", Me.COMPANY_LOAD_COMBO.Text, Me.New_TransBindingSource, "CATAGORY_ID", "CATEGORY_ID", Me.New_TransBindingSource, False, 0, False, Val(My.Settings.MaximumData_load))
    End Sub

    Private Sub FILTERSELECTEDITEMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTERSELECTEDITEMSToolStripMenuItem.Click, ToolStripMenuItem12.Click
        ADSRC.DATAGRID_ADVANCE_SELECTED_FILTER(Me.New_TransDataGridView, Me.New_TransBindingSource)

    End Sub

  

    Private Sub FIND_TWICE(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ADSRC.TWICE_BINDFIND(Me.New_TransBindingSource, "CLIENTS_ID", "MOBILE_NUMBER", sender.TEXT)

    End Sub

    Private Sub LOAD_TWICE(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ADSRC.TWICE_EXE(sender, e, Me.New_TransBindingSource, "CLIENTS_ID", "MOBILE_NUMBER")
    End Sub
    Private Sub REFRESHMOBILECOMPANYCHANGESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHMOBILECOMPANYCHANGESToolStripMenuItem.Click, ToolStripButton5.Click, ToolStripMenuItem16.Click
        Telecom_CompanyRefreshes()

    End Sub
    Public Sub Telecom_CompanyRefreshes()
        Me.Mob_ComTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Com)
    End Sub

    Private Sub NewTrans_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If My.Settings.Dont_RefreshData = True Then
            'MsgBox(TrTb.Rows(0).Item(0).ToString)
            If Me.AukDatabaseDataSet.New_Trans.Rows.Count >= 2500 Then
                e.Cancel = True
                Me.Hide()
                'Exit Sub
            End If
        End If
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If SAVMSG() = 1 Then
                New_TransBindingNavigatorSaveItem_Click(sender, e)
            ElseIf SavInt = 2 Then
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub New_TransDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles New_TransDataGridView.KeyDown
        BLANCE()
        'GRID_PRESS_ON_COMBO(sender, e, 3)
        'e.Handled = True
        'If e.KeyCode = Keys.Enter Then
        '    If Me.New_TransDataGridView.CurrentCell.ColumnIndex = 3 Then
        '        'SendKeys.Send("{F4}")
        '    End If
        'End If

        'e.Handled = False
    End Sub

    Private Sub MobileReChargeSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MobileReChargeSettingsToolStripMenuItem.Click, ToolStripMenuItem14.Click, ToolStripButton6.Click
        FrmL(MSETTING)
    End Sub

    Private Sub LaodAndFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaodAndFilterToolStripMenuItem.Click
        SoftIn.QueryLink(Me.AukDatabaseDataSet.Mob_Com, "cOMPANY", Me.COMPANY_LOAD_COMBO.Text, Me.New_TransBindingSource, "CATAGORY_ID", "CATEGORY_ID", Me.New_TransBindingSource, False, 0, True, Val(My.Settings.MaximumData_load))
    End Sub

    Private Sub CreateANewCurrentClientByCurrentPositionClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateANewCurrentClientByCurrentPositionClientToolStripMenuItem.Click
        Dim Str1(3) As String
        If My.Settings.ENTER_TOnEXT_MOB = True Then address = InputBox("Please type client address to save in database,if you don't you can .", "Address", address)
        Try
b1:
            Str1(0) = MaxID
            Str1(1) = AukF.GridT(Me.New_TransDataGridView, 1)
            Str1(3) = AukF.GridT(Me.New_TransDataGridView, 2)
            Str1(2) = address
            Me.AukDatabaseDataSet.Mob_Clients.Rows.Add(Str1)
            Me.Mob_ClientsTableAdapter1.Update(Me.AukDatabaseDataSet.Mob_Clients)
            Me.New_TransDataGridView(1, DRow).Value = AukF.GridT(Me.New_TransDataGridView, 1) & "(" & MaxID & ")"
            MaxID += 1
        Catch ex As Exception
            'Try
            '    MaxID = ADSRC.MAXIMUM_VALUE(Me.AukDatabaseDataSet.Mob_Clients.TableName, "Client_ID")
            '    MaxID += 1
            '    GoTo b1
            'Catch ex2 As Exception
            '    MaxID += 1
            '    GoTo b1
            'End Try  
            Epx()
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        On Error Resume Next
        FrmL(MCompany)

    End Sub

    Private Sub New_TransDataGridView_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles New_TransDataGridView.CellEnter
        BLANCE()

    End Sub

    'Private Sub New_TransDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles New_TransDataGridView.KeyUp
    '    BLANCE()
    'End Sub


    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        'MsgBox(Me.MonthCalendar1.BoldedDates. )
        Me.DateBusiness.Text = Me.MonthCalendar1.SelectionRange.Start.Date.Date
    End Sub

    Private Sub MonthCalendar1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthCalendar1.Validated
        Me.MonthCalendar1.Visible = False

    End Sub

    Private Sub DateBusiness_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateBusiness.DoubleClick
        Me.MonthCalendar1.Visible = Not Me.MonthCalendar1.Visible
    End Sub

    Private Sub ToolStripTextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox3.KeyDown

        ADSRC.QEnterTo_Query_FObject_and_Select_DataGridObject(sender, e, Me.AukDatabaseDataSet.New_Trans, Me.New_TransDataGridView, "Clients_ID,Mobile_Number,Transaction_number,Status", 0, Nothing, Nothing, False)

    End Sub

    Private Sub ToolStripTextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox3.TextChanged
        If ADSRC.TWICE_BINDFIND(Me.New_TransBindingSource, "Clients_ID", "Mobile_Number", sender.text, "Transaction_number") = True Then
            Me.ToolStripTextBox3.ForeColor = Color.White
            Me.ToolStripTextBox3.BackColor = Color.Black
        Else
            Me.ToolStripTextBox3.ForeColor = Color.Black
            Me.ToolStripTextBox3.BackColor = Color.White
        End If
    End Sub

    
 
    Private Sub BLANCE_LABEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLANCE_LABEL.Click
        Dim Inputx As String
        Drv = Me.New_TransDataGridView
        SQ = AukF.GridT(Drv, 3)
        If AukF.BindFind(Me.MobComBindingSource, "CATEGORY_id", SQ) = True Then
            cate = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Company").ToString
            Inputx = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Our_Account").ToString
            Inputx = InputBox("Please type the new amount of """ & cate & """ telecom company.", cate & " amount", Inputx)
            If Inputx = "" Then Exit Sub
            Try
                Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Our_Account") = Val(Inputx)
                Me.Mob_ComTableAdapter.Update(Me.AukDatabaseDataSet.Mob_Com(ComRow))
                BLANCE()

            Catch ex As Exception
                Epx()
            End Try
        Else
            MsgBox("Information no found; please Click when category found.", MsgBoxStyle.Information)
        End If
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CHECK_DUE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DueCheck(sender.TEXT)
        End If

    End Sub

    Private Sub DUEbY_DAY(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If AukF.MsgTr("DO YOU WANT TO SAVE THOSE EDITED INFORMATION?", False, MsgBoxStyle.Information) = 1 Then
                SAVE_MOBS()
                GoTo DOWORKD
            Else
                GoTo DOWORKD
            End If
        Else
            GoTo DOWORKD
        End If
        Exit Sub
DOWORKD:
        SFC("Date_Business", "STATUS")
        STC(CDate(Now.Date), "SEND BUT NOT PAID YET")
        DTC("d")
        SnX("=")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.New_Trans, -1, "", True)

    End Sub

    Private Sub DUEbY_MONTH(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If AukF.MsgTr("DO YOU WANT TO SAVE THOSE EDITED INFORMATION?", False, MsgBoxStyle.Information) = 1 Then
                SAVE_MOBS()
                GoTo DOWORKD
            Else
                GoTo DOWORKD
            End If
        Else
            GoTo DOWORKD
        End If
        Exit Sub
DOWORKD:
        'Sql = "MONTHS_BETWEEN(" & Dat2(1 & "/" & Now.Date.Month & "/" & Now.Year) & ",DATE_BUSINESS" & ")=0"
        SFC("Date_Business", "Date_Business", "STATUS")
        'n = Dat2(Now.Date)
        'AukF.DivideIn_To_2(N, "/")
        STC(Val(Now.Month), Val(Now.Year), "SEND BUT NOT PAID YET")
        'ExpreC("l3") 'like3
        SumC("month", "Year")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.New_Trans, -1)
        'MsgBox(Sql)
    End Sub

    Private Sub OpenWholeDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenWholeDatabaseToolStripMenuItem.Click
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If AukF.MsgTr("DO YOU WANT TO SAVE THOSE EDITED INFORMATION?", False, MsgBoxStyle.Information) = 1 Then
                SAVE_MOBS()
                GoTo DOWORKD
            Else
                GoTo DOWORKD
            End If
        Else
            GoTo DOWORKD
        End If
        Exit Sub
DOWORKD:
        'Sql = "MONTHS_BETWEEN(" & Dat2(1 & "/" & Now.Date.Month & "/" & Now.Year) & ",DATE_BUSINESS" & ")=0"
        'SFC("Date_Business", "STATUS")
        'n = Dat2(Now.Date)
        'STC(Mid(n, 3, Len(n)), "SEND BUT NOT PAID YET")
        'ExpreC("l3") 'like3
        AukF.Db_LoadN(Me.AukDatabaseDataSet.New_Trans, -1)
        'MsgBox(Sql)
    End Sub

    Private Sub ClearDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearDatabaseToolStripMenuItem.Click
        SAVE_MOBS()
        Me.AukDatabaseDataSet.New_Trans.Clear()
        'GoTo DOWORKD
    End Sub

    Private Sub FILTER_EXCHANGE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTER_EXCHANGE.Click
        If Me.New_TransBindingSource.Filter Is Nothing Then
            FILTERSELECTEDITEMSToolStripMenuItem_Click(sender, e)
        Else
            Me.New_TransBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub ToolStripTextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox4.TextChanged
        If Me.FILTER_CHECKED_BUT.Checked = True Then AukF.BindFilter(Me.New_TransBindingSource, "mOBILE_NUMBER", sender.TEXT, 1)

    End Sub

    Private Sub ToolStripTextBox4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox4.KeyDown
        AukF.BindFilter(Me.New_TransBindingSource, "mOBILE_NUMBER", sender.TEXT, 1)

    End Sub

    Private Sub FILTER_CHECKED_BUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTER_CHECKED_BUT.Click
        AukF.BindFilter(Me.New_TransBindingSource, "mOBILE_NUMBER", ToolStripTextBox4.Text, 1)
    End Sub
    Public Sub Get_All_Benefit_in_their_Field() 'Sending Benefit
        Dim S2 As String
        Dim Drv As DataGridView = Me.New_TransDataGridView
        Dim MBp As Decimal
        'TRY TO INSERT THE VALUE OF BENEFIT
        '11=BENEFIT,9=DISCOUNT,4=AMOUNT,5=EXTRA,12=CUR BAL.
        '11= (MBP/100)*[4] +[5]-[9]
        '11=discount
        '9=DISCOUNT,4=AMOUNT,5=EXTRA,12=CUR BAL.
        '11= (MBP/100)*[4] +[5]-[9]
        BeneFITC = (MBp / 100) * Val(AukF.GridT(Drv, 4).ToString) + Val(AukF.GridT(Drv, 5).ToString) - Val(AukF.GridT(Drv, 9).ToString)
        'MsgBox(BeneFITC)
        Drv(11, DRow).Value = Format(BeneFITC, "0.##")
        'Me.New_TransDataGridView.EndEdit()
        Me.New_TransBindingSource.EndEdit()
        S2 = UCase(AukF.GridT(Drv, 8).ToString)
        If S2 <> "SEND" Then Drv(11, DRow).Value = 0
        New_TransDataGridView.Visible = False
        Me.New_TransDataGridView.Enabled = False
        If Me.AukDatabaseDataSet.New_Trans.Rows.Count < (Val(My.Settings.MaximumData_load)) Then
            Me.Prog.Visible = True
            Prog.Value = 0
            For k As Integer = 0 To Me.AukDatabaseDataSet.Mob_Com.Rows.Count - 1
                Dim Rnx(), Rm1 As DataRow
                Dim Bpp, BENEfit, DIScOUNT, eXTRA, AMT As Decimal
                Dim CiD As String = Me.AukDatabaseDataSet.Mob_Com(k).Item(0).ToString 'CATEGORY ID GET
                Dim sT As String 'FOR STATSUS
                Rnx = Me.AukDatabaseDataSet.New_Trans.Select("CATAGORY_id='" & CiD & "'")
                Bpp = Val(Me.AukDatabaseDataSet.Mob_Com(k).Item("Benefit_Percent").ToString)
                Bpp = Bpp / 100 'GETING %,CAUSE 1%=1/100
                Prog.Value = 0
                Prog.Maximum = Rnx.GetUpperBound(0) + 1
                Me.COMPANY_NAMES_DIS.Visible = True
                COMPANY_NAMES_DIS.Text = ""
                For M As Integer = 0 To Rnx.GetUpperBound(0)
                    Rm1 = Rnx(M)
                    sT = UCase(Rm1.Item("STATUS").ToString)
                    If sT = "SEND" Then
                        eXTRA = Val(Rm1.Item("EXTRAmONEY").ToString)
                        DIScOUNT = Val(Rm1.Item("DISCOUNT").ToString)
                        AMT = Val(Rm1.Item("AMOUNT").ToString)
                        BENEfit = AMT * Bpp + eXTRA - DIScOUNT
                        Rm1.Item("BENEFIT") = Format(Val(BENEfit), "0.##")
                    Else
                        Rm1.Item("BENEFIT") = 0
                        Rm1.Item("EXTRAmONEY") = 0
                        Rm1.Item("DISCOUNT") = 0
                    End If
                    COMPANY_NAMES_DIS.Text = CiD
                    If My.Settings.DIRECT_SAVE = True Then SAVE_MOBS()
                    Prog.Value = Prog.Value + 1
                Next
                'WHEN A COMPANY IS COMPLETED THEN IT SAVE
                COMPANY_NAMES_DIS.Text = ""
                COMPANY_NAMES_DIS.Visible = False
                If My.Settings.DIRECT_SAVE = True Then SAVE_MOBS()
            Next
            Prog.Value = 0
            Prog.Visible = False
        End If
        New_TransDataGridView.Visible = True
        Me.New_TransDataGridView.Enabled = True


     

    End Sub
    Private Sub Refre_Due_Loss_BenefitC(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOSS_LABEL.Click, DUE_TOTAL_LABEL.Click, BENEFIT_TOTAL_LABEL.Click
        Get_All_Benefit_in_their_Field()
        Check_Due_Loss_BenefitC()
    End Sub

    Private Sub ToolStripLabel8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel8.Click
        SFC("Catagory_ID", "Status")
        SQ = AukF.GridT(Me.New_TransDataGridView, 3) 'get company id
        STC(sq, "SEND BUT NOT PAID YET")
        AukSql.AukSql_Main()
        AukF.BindFilter(Me.New_TransBindingSource, BSql)
    End Sub

    Private Sub TodayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Summary_Query_Mob.OpenByDate(Dat2(Now.Date), Summary_Query_Mob.FILTER_DUE_cHECKED.Checked)
    End Sub
    Private Sub YesterdayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Summary_Query_Mob.OpenByDate(Dat2(Now.Date).AddMonths(-1), Summary_Query_Mob.FILTER_DUE_cHECKED.Checked)
    End Sub

    Private Sub TheDayAfterYesterdayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Summary_Query_Mob.OpenByDate(Dat2(CDate(Now.Date)).AddMonths(-2), Summary_Query_Mob.FILTER_DUE_cHECKED.Checked)
    End Sub

    Private Sub CurrentMonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Summary_Query_Mob.OpenByMonth(CDate(Now.Date))
    End Sub


    Private Sub ToolStripTextBox5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then Summary_Query_Mob.OpenByMonth(sender.text, Summary_Query_Mob.FILTER_DUE_cHECKED.Checked)
    End Sub

    Private Sub DATE_LOAD_FOR_DUES(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox8.KeyDown, ToolStripTextBox5.KeyDown
        If e.Control = True And e.KeyCode = Keys.Enter Then
            DUE_LOAD_BY_DATE_IN_A_FORMAT(sender.TEXT, True)
        ElseIf e.KeyCode = Keys.Enter Then
            DUE_LOAD_BY_DATE_IN_A_FORMAT(sender.TEXT, False)
        End If
    End Sub
    Public Sub DUE_LOAD_BY_DATE_IN_A_FORMAT(ByVal C As String, ByVal CTRLx As Boolean)
        'Dim C As String = sender.TEXT
        Dim A As Array
        Dim D1 As Date
        If CTRLx = False Then
            If InStr(C, ",") = 0 Then
                MsgBox("PLEASE TYPE FORMAT AS (CELL NUMBER/CLIENT ID/CLIENT NAME,DATE) OR (CELL NUM/CLIENT ID/CLIENT NAME,NUMBER) " & vbCrLf & "NUMBER =DAY NUMBER. " & vbCrLf & "NUMBER=0=TODAY,NUM=-1=YESTERDAY,NUM=-2=DAY AFTER YESTERDAY,NUM=1=TOMORROW." & vbCrLf & "TYPE ONLY (CELL NUMBER/CLIENT ID) AND PRESS (CTRL+ENTER) TO GET TODAYS CURRENT CLIENT DUE.", MsgBoxStyle.Information)
                'Exit Sub
            End If
        Else
            If InStr(C, ",") = 0 Then
                C = C & "," & NDate()
            Else
                C = C & NDate()
            End If
        End If
        A = Split(C, ",")
        W = ArV(A, 0).ToString
        W2 = ArV(A, 1).ToString
        Try
            If IsNumeric(W2) = True Then
                D1 = (Dat2(Now.Date)).AddDays(Val(W2))
            Else
                D1 = Dat2(W2)
            End If
            Me.DATEINFOR.Text = SoftIn.AukDateGet(D1)
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
            Exit Sub
            'D1 = W2
        End Try
        SFC("MOBILE_NUMBER", "CLIENTS_ID")
        STC(W, "(" & W & ")")
        'DTC("", "D")
        SJOIN = "OR"
        ExpreC("", "F2") 'ANYWHERE FIND
        AukSql.AukSql_Main("*", "NEW_TRANS")
        S1 = BSql
        SFC("DATE_BUSINESS", "STATUS")
        STC(D1, "SEND BUT NOT PAID YET")
        DTC("D")
        AukSql.AukSql_Main("*", "NEW_TRANS")
        S2 = BSql
        S3 = "(" & S1 & ") AND (" & S2 & ")"
        'S = AukSql.AukSql_Main("*", "NEW_TRANS")
        AukF.Db_LoadQ(Me.AukDatabaseDataSet.New_Trans, S3, -1, False)
        'MsgBox(BSql)
        AukF.BindFilter(Me.New_TransBindingSource, BSql)

    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        FrmL(Summary_Query_Mob)
        Summary_Query_Mob.TODAY_SUMMARY()
    End Sub

    Private Sub NewTrans_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If NeedToRe = True Then
            Me.Mob_ComTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Com)
            NeedToRe = False
        End If
    End Sub

    Private Sub HELP_MOB(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        AukF.OExe(AppPath & "\HELPS\MOBILE RECHARGE.PDF", Me)
        'MsgBox(AppPath & "\HELPS\MOBILE RECHARGE.PDF")
    End Sub

    Private Sub openDueByMonth(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.AukDatabaseDataSet.HasChanges = True Then
                If AukF.MsgTr("DO YOU WANT TO SAVE THOSE EDITED INFORMATION?", False, MsgBoxStyle.Information) = 1 Then
                    SAVE_MOBS()
                    GoTo DOWORKD
                Else
                    GoTo DOWORKD
                End If
            Else
                GoTo DOWORKD
            End If
            Exit Sub
DOWORKD:
            Dim W2 As String
            Dim D1 As Date
            W2 = sender.text
            Try
                If IsNumeric(W2) = True Then
                    D1 = (Dat2(Now.Date)).AddDays(Val(W2))
                Else
                    D1 = Dat2(W2)
                End If
                Me.DATEINFOR.Text = SoftIn.AukDateGet(D1)
            Catch ex As Exception
                MsgBox("Please Insert a Valid Date.To Get Month From It.", MsgBoxStyle.Information)
                Exit Sub
                'D1 = W2
            End Try

            'Sql = "MONTHS_BETWEEN(" & Dat2(1 & "/" & Now.Date.Month & "/" & Now.Year) & ",DATE_BUSINESS" & ")=0"
            SFC("Date_Business", "Date_Business", "STATUS")
            'n = Dat2(Now.Date)
            'AukF.DivideIn_To_2(N, "/")
            STC(Val(D1.Month), Val(D1.Year), "SEND BUT NOT PAID YET")
            'ExpreC("l3") 'like3
            SumC("month", "Year")
            AukF.Db_LoadN(Me.AukDatabaseDataSet.New_Trans, -1)
        End If
    End Sub

    
    Private Sub SHOW_UNWELL_REC(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENONLYCURRENTMONTHRECORDToolStripMenuItem.Click

        If Me.AukDatabaseDataSet.HasChanges = True Then
            If AukF.MsgTr("DO YOU WANT TO SAVE THOSE EDITED INFORMATION?", False, MsgBoxStyle.Information) = 1 Then
                SAVE_MOBS()
                GoTo DOWORKD
            Else
                GoTo DOWORKD
            End If
        Else
            GoTo DOWORKD
        End If
        Exit Sub
DOWORKD:
        SFC("CATAGORY_ID", "DATE_BUSINESS", "STATUS")
        ExpreC("NULL", "NULL", "NULL")
        SJOIN = "OR"
        AukSql.AukSql_Main("*", "New_Trans")
        x1 = BSql
        SFC("STATUS", "STATUS")
        STC("SEND BUT NOT PAID YET", "UNSEND")
        'ExpreC("NULL", "NULL", "NULL")
        SJOIN = "OR"
        AukSql.AukSql_Main("*", "New_Trans")
        x2 = BSql
        SFC("discount", "extraMONEY", "bENEFIT")
        STC("0", "0", "0")
        DTC("n", "n", "N")
        SnX(">", ">", ">")
        'ExpreC("NULL", "NULL", "NULL")
        SJOIN = "OR"
        AukSql.AukSql_Main("*", "New_Trans")
        X2 = Replace(X2, "(", "")
        X2 = Replace(X2, ")", "")
        x3 = BSql
        X3 = Replace(X3, "(", "")
        X3 = Replace(X3, ")", "")
        a1 = "(" & x1 & ") OR (  (" & X2 & " )  AND (" & x3 & ")   )"
        'MsgBox(a1)
        AukF.Db_LoadQ(Me.AukDatabaseDataSet.New_Trans, a1, -1, True)
        'MsgBox(Sql)
    End Sub
End Class