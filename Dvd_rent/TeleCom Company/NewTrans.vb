Public Class NewTransfX
    Dim BusD As Date
    Dim MClients As New DataTable
    Dim Drv As DataGridView
    Dim WDate As Date
    Dim Before_Bal As Double
    Dim MaxLen As Double
    Dim MaxID As Decimal
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
        Catch ex As Exception
            Epx()
        Finally
            Beep()
        End Try
    End Sub

    Private Sub NewTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Mob_Com' table. You can move, or remove it, as needed.
        'On Error Resume Next
        'AukF.SuggestListSourceAddGveMsg(Me.PCategoryID, Me.AukDatabaseDataSet, "Mob_Com", 0, 100)
        'Me.PDate.Text = Now.Date
        If TVer = True Then
            Msgx = "In trail version of CyberPack Pro you are not suppose to run this ""Mobile Recharge"" [Form] more than 300 minutes.If you want to buy please contact with the developer [01913 50863],0167 01013907,01711 334201(onRequest)"
            Dim P, N As Decimal
            'MsgBox(P, , My.Settings.MobileLastDate.ToString)
            If CStr(My.Settings.MobileLastDate) = "" Or CStr(My.Settings.MobileLastDate) = "12:00:00 AM" Then
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
        ToolStripLabel2_Click(sender, e)
        ADSRC.GRID_HEADERS(Me.COMMONADD_COMBO, Me.New_TransDataGridView, "0,3")
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
    End Sub

    Private Sub New_TransDataGridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles New_TransDataGridView.CellBeginEdit
        If e.ColumnIndex = 4 Then Before_Bal = AukF.GridT(sender, 4, -1, 0)
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
                AukF.Db_Load("CLIENT_CONTACTS,Client_Name", "Mob_Clients", MClients)
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
                MINUS_BLANCE()
                Me.New_TransDataGridView(8, Me.New_TransDataGridView.CurrentCell.RowIndex).Value = "SEND"
            ElseIf AukF.GridT(Drv, 8).ToString.ToUpper <> "UNSEND" Then
                PLUS_BLANCE(Before_Bal)
                MINUS_BLANCE()
            End If
        End If
        If AukF.GridT(Drv, 7) = "" Then Drv(7, e.RowIndex).Value = WDate
        Amt = AukF.GridT(Drv, 4, -1, 0)
        If Amt < Val(My.Settings.EXTRA_LESS) And My.Settings.EXTRA_M_TR = True Then
            Drv(5, e.RowIndex).Value = Val(My.Settings.EXTRA_MONEY_AM)
        Else
            Drv(5, e.RowIndex).Value = 0
        End If
        If My.Settings.DIRECT_SAVE = True Then New_TransBindingNavigatorSaveItem_Click(sender, e)
        BLANCE()
    End Sub
    Public Sub BusEnb()
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
        BusDisEnb()

    End Sub

    Private Sub DateBusiness_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateBusiness.KeyDown
        If e.KeyCode = Keys.Enter Then
            BusEnb()

        End If
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
        Dim M As New MobileReport
        Dim Lopt As New AukDatabaseDataSetTableAdapters.OptionsTableAdapter
        Lopt.Fill(Me.AukDatabaseDataSet.Options)
        Dim Lopt2 As New AukDatabaseDataSetTableAdapters.Mob_ComTableAdapter
        Lopt2.Fill(Me.AukDatabaseDataSet.Mob_Com)
        AukF.Prnt(M, Me.AukDatabaseDataSet, Me.New_TransBindingSource)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.New_TransDataGridView, My.Settings.CLIENTS_ID, 1)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.New_TransDataGridView, My.Settings.EXTRA_COLUMN, 5)
        If TVer = True Then
            Dim P As Decimal
            P = DateDiff(DateInterval.Minute, CDate(My.Settings.MobileLastDate), Now)
            If P < 0 Then P = P * -1
            If P >= 300 Then
                Warn.Msg = Msgx
                FrmL(Warn)
                Me.Close()
                Me.Timer1.Enabled = False
                Exit Sub
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

    Private Sub SET_STATUS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UNSENDToolStripMenuItem.Click, SENDUNPAIDToolStripMenuItem.Click, SENDToolStripMenuItem.Click, ToolStripMenuItem6.Click, ToolStripMenuItem5.Click, ToolStripMenuItem4.Click
        Dim STR1 As String = UCase(AukF.GridT(Drv, 8))
        Drv = Me.New_TransDataGridView
        S = UCase(sender.TEXT)
        'MsgBox(S)

        If STR1 = "" Then
            If S = "SEND" Then
                MINUS_BLANCE()
            End If
        ElseIf STR1 = "UNSEND" Then
            If S <> "UNSEND" Then
                MINUS_BLANCE()
                'MsgBox("DO MINUS")
            End If
        ElseIf STR1 = "SEND" Or STR1 = "SEND BUT NOT PAID YET" Then
            If S = "UNSEND" Then
                PLUS_BLANCE()
            End If
        End If
        BLANCE()
        Me.New_TransDataGridView(8, Me.New_TransDataGridView.CurrentCell.RowIndex).Value = sender.TEXT
    End Sub
    Public Function MINUS_BLANCE(Optional ByVal Amt As Double = -1)
        Drv = Me.New_TransDataGridView
        Dim RI As Integer
        Dim CTA As String = AukF.GridT(Drv, 3)
        If Amt = -1 Then Amt = Val(AukF.GridT(Drv, 4))
        Dim BEBAL As Double
        If AukF.BindFind(Me.MobComBindingSource, "CATEGORY_ID", CTA) = True Then
            'MsgBox("FOUND" & vbCrLf & BEBAL - AMT)
            BEBAL = Val(Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Our_Account").ToString)
            If (BEBAL - AMT) < 0 Then
                MsgBox("CURRENT(" & Amt & ") AMOUNT IS CROSSING YOUR (" & Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Company").ToString & ") BALANCE,WHICH IS " & BEBAL & ".", MsgBoxStyle.Critical)
                If AukF.MsgTr("Transfer " & BEBAL & " to him/her?", True) = True Then
                    Me.AukDatabaseDataSet.Mob_Com(ComRow).Our_Account = 0
                    Drv(4, Drv.CurrentCell.RowIndex).Value = BEBAL
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
        Dim RI As Integer
        Dim CTA As String = AukF.GridT(Drv, 3)
        If Amt = -1 Then Amt = AukF.GridT(Drv, 4)
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

    Private Sub INPUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INPUTToolStripMenuItem.Click, ToolStripMenuItem8.Click
        AukF.Grid_View_SetCommonItems(Me.New_TransDataGridView, Me.COMMON_ADD_TEXTBOX.Text, SoftIn.GetTableColumn_NameString(Me.AukDatabaseDataSet.New_Trans, Me.COMMONADD_COMBO.Text.Split(",").GetValue(1).ToString))

    End Sub

    Private Sub FIND_TWICE(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        ADSRC.TWICE_BINDFIND(Me.New_TransBindingSource, "CLIENTS_ID", "MOBILE_NUMBER", sender.TEXT)

    End Sub

    Private Sub LOAD_TWICE(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        ADSRC.TWICE_EXE(sender, e, Me.New_TransBindingSource, "CLIENTS_ID", "MOBILE_NUMBER")
    End Sub
    Private Sub REFRESHMOBILECOMPANYCHANGESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHMOBILECOMPANYCHANGESToolStripMenuItem.Click, ToolStripButton5.Click, ToolStripMenuItem16.Click
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

    End Sub

    Private Sub MobileReChargeSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MobileReChargeSettingsToolStripMenuItem.Click, ToolStripMenuItem14.Click, ToolStripButton6.Click
        FrmL(MSETTING)
    End Sub

    Private Sub LaodAndFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaodAndFilterToolStripMenuItem.Click
        SoftIn.QueryLink(Me.AukDatabaseDataSet.Mob_Com, "cOMPANY", Me.COMPANY_LOAD_COMBO.Text, Me.New_TransBindingSource, "CATAGORY_ID", "CATEGORY_ID", Me.New_TransBindingSource, False, 0, True, Val(My.Settings.MaximumData_load))
    End Sub

    Private Sub CreateANewCurrentClientByCurrentPositionClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateANewCurrentClientByCurrentPositionClientToolStripMenuItem.Click
        Dim Str1(3) As String
        address = InputBox("Please type client address to save in database,if you don't you can .", "Address", address)
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
        FrmL(MCompany)

    End Sub

    Private Sub New_TransDataGridView_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles New_TransDataGridView.CellEnter
        BLANCE()

    End Sub

    'Private Sub New_TransDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles New_TransDataGridView.KeyUp
    '    BLANCE()
    'End Sub
End Class