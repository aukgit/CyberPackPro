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
    Public NeedTO_INFOR_FONT_CHG As Boolean = False
    Public NeedToStockRe As Boolean = False
    Dim CSold As String = "CARD SOLD"
    Dim DueStr As String = "SEND BUT NOT PAID YET"
    Dim Snd As String = "SEND"
    Dim Und As String = "UNSEND"
    Dim BCardCate As Integer
    Dim BCID As String
    Dim F1x As String = "0.##"
    Dim F2x As String = "0.#"


    Private Sub New_TransBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles New_TransBindingNavigatorSaveItem.Click, SENDCURRENTBALANCEToolStripMenuItem.Click, ToolStripMenuItem1.Click
        SAVE_MOBS()
    End Sub
    Public Sub SAVE_MOBS()
        'Try
        On Error GoTo b
        Me.Validate()
        Me.New_TransBindingSource.EndEdit()
        Me.New_TransTableAdapter.Update(Me.AukDatabaseDataSet.New_Trans)
        Me.MobComBindingSource.EndEdit()
        Me.Mob_ComTableAdapter.Update(Me.AukDatabaseDataSet.Mob_Com)
        Me.Mob_CardsTableAdapter1.Update(Me.AukDatabaseDataSet.Mob_Cards)
        Me.DaY_Sold_InfoBindingSource.EndEdit()
        Me.DaY_Sold_InfoTableAdapter.Update(Me.AukDatabaseDataSet.DaY_Sold_Info)
        If StockI_mob.Visible = True Then StockI_mob.NeedToRe = True
        If MCompany.Visible = True Then MCompany.NeedToRe = True
        Exit Sub
b:
        Epx() : Resume Next
        'Catch ex As Exception
        '    Epx()
        'End Try
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
        Me.AukDatabaseDataSet.New_Trans.Due_CardsColumn.DefaultValue = 0

        NeedTO_INFOR_FONT_CHG = True
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
nextwork:
        Me.Mob_ComTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Com)
        Me.Mob_CardsTableAdapter1.Fill(Me.AukDatabaseDataSet.Mob_Cards)
        Me.DateBusiness.Text = Now.Date
        If Load_Sum = False Then
            ToolStripLabel2_Click(sender, e)
        Else
            Load_Sum = True
        End If
        Refresh_Stock_info_tab() 'took stock information is ena
        ADSRC.GRID_HEADERS(Me.COMMONADD_COMBO, Me.New_TransDataGridView, "0,3") 'ADDING GRID HEADERS IN COMMONADD COMBO
        AukF.AukDataSourceSetObjectListOrComboType(Me.COMPANY_LOAD_COMBO, Me.MobComBindingSource, 1, True, True)
        MaxLen = Val(Me.AukDatabaseDataSet.New_Trans.Columns(1).MaxLength.ToString)
        a = Val(ADSRC.MAXIMUM_VALUE(Me.AukDatabaseDataSet.Mob_Clients.TableName, "Client_ID"))
        MaxID = a
        MaxID += 1
        Me.EFFECT_ON_INFORMATION_TEXT_VIEW() 'effect on information label
    End Sub
    Public Sub Refresh_Stock_info_tab(Optional ByVal CheckNeed As Boolean = False)
        If My.Settings.TOOK_WHOL_INFO_MOB = True Then
            'took stock information is ena
            If CheckNeed = False Then
                GoTo startRe
            Else
                If NeedToStockRe = True Then
                    GoTo startRe
                Else
                    Exit Sub
                End If
            End If
startRe:    SFC("Date_info")
            STC(Dat2(NDate))
            DTC("d")
            AukF.Db_LoadN(Me.AukDatabaseDataSet.DaY_Sold_Info, -1, "", False)
            Try
                If AukF.BindFind(Me.DaY_Sold_InfoBindingSource, "Date_info", NDate, True) = False Then
                    RowX = Me.AukDatabaseDataSet.DaY_Sold_Info.NewRow
                    RowX(0) = NDate()
                    RowX(1) = 0
                    RowX(2) = 0
                    RowX(3) = 0
                    RowX(4) = 0
                    Me.AukDatabaseDataSet.DaY_Sold_Info.Rows.Add(RowX)
                    Me.DaY_Sold_InfoTableAdapter.Update(Me.AukDatabaseDataSet.DaY_Sold_Info)
                End If
            Catch ex As Exception
                Epx()
            End Try
        End If
    End Sub
    Public Sub BLANCE()
        On Error Resume Next
        Dim ShowT, Cell, BaL As String
        Dim Status, CellField As String
        Drv = Me.New_TransDataGridView
        SQ = AukF.GridT(Drv, 3)
        ShowT = ""
        Status = AukF.GridT(Me.New_TransDataGridView, 8) '8=status
        CellField = AukF.GridT(Me.New_TransDataGridView, 2).ToString
        If Status <> CSold And UCase(CellField) <> "CARD SELLING" Then
            If AukF.BindFind(Me.MobComBindingSource, "CATEGORY_id", SQ) = True Then
                Me.BLANCE_LABEL.Text = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Company").ToString & " " & Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Our_Account").ToString & " T.K."
            Else
                Me.BLANCE_LABEL.Text = "INFORMATION NOT FOUND"
            End If
            Me.BLANCE_LABEL.Tag = "m"
        ElseIf Status = CSold Or UCase(CellField) = "CARD SELLING" Or UCase(CellField) = "CARDSELLING" Then 'cards information
            Me.BLANCE_LABEL.Tag = "c"
            Dim Rx1() As DataRow
            TCom = AukF.GridT(Drv, 3).ToString 'geting com id
            CardCate = AukF.GridT(Drv, 4).ToString 'geting the value of amount field
            If tcom Is Nothing Or cardcate Is Nothing Then GoTo innotfound
            Rx1 = SoftIn.Rows_Select(Me.AukDatabaseDataSet.Mob_Cards, "category_id='" & TCom & "' and Card_Category=" & CardCate)
            If Rx1 IsNot Nothing Then
                RowX = ArV2(Rx1, 0) 'a row of mob cards
                CardsInt = Val(RowX.Item("cards_instock").ToString)
                Me.BLANCE_LABEL.Text = "TOTAL CARDS INSTOCK  " & CardsInt   'inserting card into stock becase before status =card sold
                'MsgBox(Me.BLANCE_LABEL.Text)
            Else
innotfound:     Me.BLANCE_LABEL.Text = "CARD INFORMATION NOT FOUND"
            End If
        End If

        'NO()
        'SHOW(ID,CELL,CURRENT BALANCE)
        'Show(ID, CELL)
        If My.Settings.CUR_INFO_SHOW = "NO" Then
            Me.iNFOR.Visible = False
        ElseIf My.Settings.CUR_INFO_SHOW = "SHOW(ID,CELL,CURRENT BALANCE)" Then
            X = AukF.GridT(Drv, 1) 'CLIENTS ID OR NAME
            Cell = CELL_NUMB_GET()
            If My.Settings.mAKE_TRANS_bAL = True Then
                BaL = AukF.GridT(Drv, 6)
            Else
                If Me.BLANCE_LABEL.Text <> "INFORMATION NOT FOUND" Then
                    BaL = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Our_Account").ToString
                End If
            End If
            If Trim(CStr(X)) <> "" Then
                ShowT = "ID: " & X & " , "
            End If
            If BaL <> "" Then
                BaL = " , BAL:" & BaL
            Else
                BaL = ""
            End If
            ShowT = ShowT & "CELL: " & Cell & BaL
        Else 'ONLY ID,CELL
            X = AukF.GridT(Drv, 1) 'CLIENTS ID OR NAME
            Cell = CELL_NUMB_GET()
            If Trim(CStr(X)) <> "" Then
                ShowT = "ID: " & X & " , "
            End If
            ShowT = ShowT & "CELL: " & Cell
        End If
        If iNFOR.Visible = True Then
            iNFOR.Text = ShowT
            If NeedTO_INFOR_FONT_CHG = True Then
                Dim F As New FontConverter
                Me.iNFOR.Font = F.ConvertFromString(My.Settings.FONT_INFO_MOB.ToString)
                Me.iNFOR.Height = Val(My.Settings.INFOR_HEIGHT_MOB)
                NeedTO_INFOR_FONT_CHG = False
            End If
        End If

        Me.Check_Due_Loss_BenefitC()
    End Sub
    Public Sub EFFECT_ON_INFORMATION_TEXT_VIEW()
        If My.Settings.CUR_INFO_SHOW = "NO" Then
            Me.iNFOR.Visible = False
        Else
            Me.iNFOR.Visible = True
        End If
        If Me.iNFOR.Visible = True Then
            Dim F As New FontConverter
            Me.iNFOR.Font = F.ConvertFromString(My.Settings.FONT_INFO_MOB.ToString)
            Me.iNFOR.Height = Val(My.Settings.INFOR_HEIGHT_MOB)
        End If
    End Sub
    Public Function CELL_NUMB_GET() As String
        Cell = AukF.GridT(Drv, 2).ToString.Replace(" ", "") 'MOB NUM
        If Trim(CELL) = "" Then Cell = "NO NUMBER" : Return CELL
        Cell = Replace(Cell, "-", "")
        C1 = Mid(Cell, 1, 4)
        C2 = Mid(Cell, 5, Len(Cell))
        Cell = C1 & "-" & C2
        Return CELL
    End Function
    Public Function CID_GET() As String
        X = AukF.GridT(Drv, 1) 'CLIENTS ID OR NAME
        If Trim(CStr(X)) <> "" Then
            Return "CLIENT ID: " & X & " , "
        Else
            Return ""
        End If
    End Function
    Private Sub New_TransDataGridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles New_TransDataGridView.CellBeginEdit
        If e.ColumnIndex = 4 Then
            Before_Bal = AukF.GridT(sender, 4, -1, 0) 'so that i may minus this and add or minus the new amount
            BCardCate = Before_Bal
            BCID = AukF.GridT(sender, 3, -1, "")
        End If

    End Sub
    Private Sub New_TransDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles New_TransDataGridView.CellClick
        BLANCE()
    End Sub
    Public Sub Multi_Cards_Selling(ByVal HowMany As Integer)
        HowMany = HowMany - 1 'BECAUSE USER FORGOT THE INSERTED CARD NUMBER
        If HowMany <= 0 Then Exit Sub
        Dim Drv As DataGridView = Me.New_TransDataGridView
        Dim CurId As String = AukF.GridT(Drv, 0)
        Dim Cid As String
        Dim CCate As Integer
        Dim Rx1(), Rx2(), TransR As DataRow
        If CurId <> "" Then
            Rx2 = SoftIn.Rows_Select(Me.AukDatabaseDataSet.New_Trans, "id='" & CurId & "'")
            If Rx2 IsNot Nothing Then 'THEN WE TRY TO SELL CARDS
                Me.New_TransBindingSource.EndEdit() 'MAKING VALID FIELD
                TransR = ArV2(Rx2, 0) 'newtrans row get by the id
                Cid = AukF.GridT(Drv, 3).ToString 'com id
                CCate = Val(AukF.GridT(Drv, 4).ToString) 'amt = card category
                If Cid IsNot Nothing Then Rx1 = SoftIn.Rows_Select(Me.AukDatabaseDataSet.Mob_Cards, "category_id='" & Cid & "' and Card_Category=" & CCate) 'cards row get by the id
                If Rx1 IsNot Nothing Then
                    Dim StockCards As Integer
                    Dim R As DataRow
                    Me.RECHARGE_NUMBER(CSold) 'make current card sold,if before no efftect
                    'rx1=mob_CardsRow
                    R = Rx1.GetValue(0)
                    StockCards = Val(ArV2(R.ItemArray, 4, 0).ToString) 'before remove from,checking stock cards
                    If StockCards >= HowMany Then
                        SoftIn.Same_Input_New(TransR, HowMany, 0, "", "", "", 9)
                        Me.CARDS_SELLING(Cid, CCate, False, False, HowMany)
                    Else
                        MsgBox("Please type a Number value which is less than your stock cards number.", MsgBoxStyle.Exclamation)
                    End If
                
                    If My.Settings.DIRECT_SAVE = True Then Me.SAVE_MOBS()
                    Me.BaLance()
                Else
                    MsgBox("This Card is not Created Yet.Please Create to Sell.You can't make it perform as MultiCard Selling Command.", MsgBoxStyle.Information)
                    MBp = 0
                End If
            Else
                MsgBox("Current Row is not Valid ,Please Save to make it valid.You can't make it perform as MultiCard Selling Command.", MsgBoxStyle.Information)
                MBp = 0
            End If
        End If
    End Sub
    Private Sub New_TransDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles New_TransDataGridView.CellEndEdit
        Dim Sn1, Sx1 As String
        Dim Amt As Double
        On Error Resume Next
        Drv = Me.New_TransDataGridView
        'SoftIn.DataGrid_MasterID_ByDate(Drv) 'inputting Serail
        'master id input on
        Master_ID_String(Drv, 11)
        '----
        If e.ColumnIndex = 1 Then 'Client ID EDIT
            SXZ = AukF.GridT(sender, 1)

            If Trim(SXZ) <> "" Then Drv(1, DRow).Value = UCase(SXZ) Else Drv(1, DRow).Value = DBNull.Value
        End If
        If e.ColumnIndex = 3 Then 'CATEGORY ID EDIT
            Sx1 = AukF.GridT(sender, 3)
            Sn1 = AukF.GridT(sender, 2)
            If Sn1 = "" Then
                'If AukF.BindFind(Me.MobComBindingSource, "Category_ID", Sx1) = True Then
                '    sender(2, e.RowIndex).value = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Digits").ToString
                'End If
                sender(2, e.RowIndex).value = "CARD SELLING"
            End If
        End If
        If e.ColumnIndex = 1 Then 'CID EDITED
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
        If e.ColumnIndex = 2 Then 'CELL NUMBER EDITED'2=cell number
            Sn1 = AukF.GridT(sender, 2) 'cell number
            Sx1 = Mid(Sn1, 1, 3).ToString 'cell number 3 digit

            If Sn1 <> "CARD SELLING" Then 'if not card selling
                'try to insert num with ou space and -
                Sn1 = Replace(Sn1, "-", "")
                Sn1 = Replace(Sn1, " ", "")
                If DRow > -1 Then Drv(2, DRow).Value = Sn1
                '----
                If AukF.BindFind(Me.MobComBindingSource, "Digits", Sx1) = True Then
                    Me.New_TransDataGridView(3, e.RowIndex).Value = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Category_ID").ToString
                End If
            End If
        End If
        If e.ColumnIndex = 4 Then 'AMOUNT EDITED
            mxd1 = AukF.GridT(Drv, 8).ToString.ToUpper
            If AukF.GridT(Drv, 8) = CSold Then 'ON STATS=CSOLD
                Me.CARDS_SELLING(BCID, BCardCate, True, True) 'first adding on stock 
                '3=tcom,4=amt
                Me.CARDS_SELLING(AukF.GridT(sender, 3).ToString, Val(AukF.GridT(sender, 4).ToString), False, True) 'then sold the new one
                'MINUS_BLANCE()
                'Me.New_TransDataGridView(8, Me.New_TransDataGridView.CurrentCell.RowIndex).Value = "SEND"
            ElseIf (mxd1 = Snd) Or (mxd1 = DueStr) Then
                PLUS_BLANCE(Before_Bal)
                MINUS_BLANCE()
            End If
        End If

        If e.ColumnIndex = 6 Then 'TRANS/CUR BAL EDIT
            If AukF.GridT(Drv, 8) = "" Then
                Me.RECHARGE_NUMBER("SEND")
            End If
        End If
        If AukF.GridT(Drv, 7) = "" Then Drv(7, e.RowIndex).Value = WDate
        If Drv.CurrentCell IsNot Nothing Then Amt = AukF.GridT(Drv, 4, -1, 0) Else Amt = 0
        'extra on
        If My.Settings.EXTRA_M_TR = True Or (My.Settings.EXTRA_EFF2_MOB.ToString <> "" Or My.Settings.EXTRA_EFF2_MOB.ToString <> "NO EFFECT,0") Then 'extra on
            If (AukF.GridT(Drv, 8).ToString = CSold Or AukF.GridT(Drv, 2).ToString = "CARD SELLING") And (My.Settings.EXTRA_EFF2_MOB.ToString <> "" Or My.Settings.EXTRA_EFF2_MOB.ToString <> "NO EFFECT,0") Then 'getin gfrom status/celll num  & for Extra on Cards
                'IF ANY FIELDED THEN IF LOGIC MATCHS THEN IT WILL WORK
                Dim Nm1 As String
                Dim Ua As Array
                Dim Index1, Ext As Integer
                'Dim Amtx As Decimal
                Nm1 = My.Settings.EXTRA_EFF2_MOB.ToString
                Ext = -1
                If Nm1 <> "" Then
                    Ua = Split(Nm1, ",")
                    Index1 = Val(ArV(Ua, 2).ToString)
                    'Amtx = Val(AukF.GridT(Drv, 4).ToString)
                    If Index1 = 1 And Amt <= 50 Then Ext = 1 : GoTo WORKSX
                    If Index1 = 2 And Amt <= 30 Then Ext = 1 : GoTo WORKSX
                    If Index1 = 3 And Amt <= 20 Then Ext = 1 : GoTo WORKSX
                    If Index1 = 4 And Amt <= 50 Then Ext = 2 : GoTo WORKSX
                    If Index1 = 5 And Amt <= 30 Then Ext = 2 : GoTo WORKSX
                    If Index1 = 6 And Amt <= 20 Then Ext = 2 : GoTo WORKSX
WORKSX:             If DRow > -1 And Ext > -1 Then Drv(5, DRow).Value = Ext Else Drv(5, DRow).Value = 0
                End If
            Else 'eslse to goto recharge extra effect.
                If Amt < Val(My.Settings.EXTRA_LESS) And My.Settings.EXTRA_M_TR = True Then 'effect by eftra commands
                    Drv(5, e.RowIndex).Value = Val(My.Settings.EXTRA_MONEY_AM)
                Else
                    'not making it 0 because some wants to enter something
                    Drv(5, e.RowIndex).Value = 0
                End If
            End If
        End If

        If e.ColumnIndex = 9 Or e.ColumnIndex = 4 Or e.ColumnIndex = 6 Then 'eFFECT ON CURRENT BENEFT AFTER EDIT DISCOUNT
            Me.Set_Benefit_OnCurrent()
        End If
        If My.Settings.DIRECT_SAVE = True Then Me.SAVE_MOBS()

        BLANCE()

    End Sub
    Public Sub Set_Benefit_OnCurrent()
        'STR1 = UCase(AukF.GridT(Drv, 8))
        'If STR1 = "SEND BUT NOT PAID YET" Then Drv(11, DRow).Value = 0 'beneft=0
        Dim S2, TCom, CardCate As String
        Dim Drv As DataGridView = Me.New_TransDataGridView
        Dim MBp, Amt, Extra, Discount As Decimal
        Dim DueCard As Boolean
        'TRY TO INSERT THE VALUE OF BENEFIT
        '11=BENEFIT,9=DISCOUNT,4=AMOUNT,5=EXTRA,12=CUR BAL.
        '11= (MBP/100)*[4] +[5]-[9]
        SQx = AukF.GridT(Drv, 3) 'GET CATEGORY
        S2 = UCase(AukF.GridT(Drv, 8).ToString) 'GETING STATUS=8
        If S2 <> "SEND" Then 'if unsend then close
            If S2 = CSold Then
                GoTo workon 'cause csold=true
            End If
            If DRow > -1 Then Drv(11, DRow).Value = 0 'benefit=0
            If My.Settings.DIRECT_SAVE = True Then Me.SAVE_MOBS()
            Exit Sub
        End If
workon:
        If S2 = Snd Then
            'normal mob benefit % geting
            If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Mob_Com, SQx, 5) = True Then
                MBp = Val(WGeT) 'Cause Get Current Table Cl=3 means be%,get on wget if found.
            Else
                MBp = 0
                If DRow > -1 Then Drv(11, DRow).Value = 0 'bene=0
            End If
        ElseIf S2 = CSold Then
            Dim Rx1() As DataRow
            TCom = AukF.GridT(Drv, 3).ToString 'geting com id
            CardCate = AukF.GridT(Drv, 4).ToString 'geting the value of amount field
            Rx1 = SoftIn.Rows_Select(Me.AukDatabaseDataSet.Mob_Cards, "category_id='" & TCom & "' and Card_Category=" & CardCate)
            If Rx1 IsNot Nothing Then
                RowX = ArV2(Rx1, 0) 'a row of mob cards
                MBp = Val(RowX.Item("CArd_Benefit_Percent").ToString)
            Else
                MsgBox("This Card is not Created Yet.Please Create to Sell.", MsgBoxStyle.Information)
                MBp = 0
            End If
        End If
        '11=discount
        '9=DISCOUNT,4=AMOUNT,5=EXTRA,12=CUR BAL.
        '11= (MBP/100)*[4] +[5]-[9]
        Amt = CDec(Val(AukF.GridT(Drv, 4).ToString))
        Extra = CDec(Val(AukF.GridT(Drv, 5).ToString))
        Discount = CDec(Val(AukF.GridT(Drv, 9).ToString))
        BeneFITC = RBenefit(Amt, Extra, Discount, MBp)
        DueCard = SoftIn.Boolean_get(AukF.GridT(Drv, 12).ToString) '12=due
        If DueCard = True Then BeneFITC = 0
        'MsgBox(BeneFITC)
        If DRow > -1 Then Drv(11, DRow).Value = Format(BeneFITC, F2x)
        'MsgBox(Drv(11, DRow).Value)
        'Me.New_TransDataGridView.EndEdit()
        Me.New_TransBindingSource.EndEdit()
        If My.Settings.DIRECT_SAVE = True Then Me.SAVE_MOBS()

    End Sub
    Private Function RBenefit(ByVal Amountx As String, ByVal Extra As String, ByVal Discountx As String, ByVal Benefit_percent As String, Optional ByVal formatx As String = "0.##")
        Dim AmtM, ExtraM, DiscountM, Benefit_percentM As Decimal
        AmtM = CDec(Val(Amountx))
        ExtraM = CDec(Val(Extra))
        DiscountM = CDec(Val(Discountx))
        Benefit_percentM = CDec(Val(Benefit_percent))
        If Benefit_percentM = 0 Then
            Return 0
        Else
            Return (Benefit_percentM / 100) * AmtM + ExtraM - DiscountM
        End If
    End Function
    Public Sub BusEnb(Optional ByVal d1x As Date = Nothing)
        Me.MonthCalendar1.Visible = False
        datex = Me.DateBusiness.Text
        If d1x = Nothing Then
            If datex = "" Then datex = Now.Date : DateBusiness.Text = Now.Date
        End If
        Try
            If d1x = Nothing Then
                WDate = CDate(Me.DateBusiness.Text)
            Else
                WDate = d1x
            End If
            Me.New_TransDataGridView.ReadOnly = False
            Extent_Fields_readOnly()
            Me.DateBusiness.Enabled = False
            SFC("Date_Business")
            STC(WDate)
            DTC("d")
            SnX("=")
            'If My.Settings.mAKE_TRANS_bAL = True Then
            '    ordx = "Val([Amount])"
            'Else
            '    ordx = "Val(Amount)"
            'End If
            AukF.Db_Load("*", "New_Trans", Me.AukDatabaseDataSet, True, "")
            Me.New_TransDataGridView.AllowUserToAddRows = True
            Dim Ipox As Integer = Me.New_TransBindingSource.Count - 1
            If Ipox >= 0 Then
                Me.New_TransBindingSource.Position = Ipox
            End If
        Catch ex As Exception
            Epx()
            Me.DateBusiness.Focus()
        End Try
    End Sub
    Public Sub Extent_Fields_readOnly()
        Me.D_Benefit_Fields.ReadOnly = True
        Me.d_Date_Field.ReadOnly = True
        Me.Dstatus_Field.ReadOnly = True
        Me.D_SendTime_Field.ReadOnly = True
        Me.Due_Cards_Field.ReadOnly = True
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

        SFC("CLIENTS_ID", "CLIENTS_ID", "MOBILE_NUMBER")
        SJOIN = "OR"
        STC("(" & Str1 & ")", Str1, Str1)
        ExpreC("*l", "l*")
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
    Private Sub Members_Form(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click, ToolStripButton1.Click
        ''Prog.Visible = True
        ''Prog.Value = 0
        ''Prog.Maximum = 10001
        ''For K As Integer = 0 To 10000
        ''    RowX = Me.AukDatabaseDataSet.New_Trans.NewRow
        ''    RowX.Item(0) = SoftIn.Master_ID_String_Get(8)
        ''    Me.AukDatabaseDataSet.New_Trans.Rows.Add(RowX)
        ''    Prog.Value += 1
        ''Next
        FrmL(Clients)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Hide()
    End Sub

    Private Sub PrintAllCompanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRINTToolStripMenuItem.Click, ToolStripMenuItem2.Click, ToolStripLabel1.ButtonClick, ReportOfMobileRechargeToolStripMenuItem.Click
    
        If Check_Chg_GoOn() = False Then Exit Sub
        Dim M As New MobileReport2
        Dim Lopt As New AukDatabaseDataSetTableAdapters.OptionsTableAdapter
        Lopt.Fill(Me.AukDatabaseDataSet.Options)
        Dim Lopt2 As New AukDatabaseDataSetTableAdapters.Mob_ComTableAdapter
        Lopt2.Fill(Me.AukDatabaseDataSet.Mob_Com)
        AukF.Prnt(M, Me.AukDatabaseDataSet, Me.New_TransBindingSource, "{New_Trans.Status}<>'" & CSold & "'")
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
        'DVDRENT.SET_VISIBLE_DATACOLUMN(Me.New_TransDataGridView, My.Settings.CURRENT_BALANCE_MOB, 12)
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
        If My.Settings.ROW_SEL_MOB = "ROW" Then
            If Me.New_TransDataGridView.SelectionMode <> DataGridViewSelectionMode.FullRowSelect Then
                Me.New_TransDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End If
        Else
            If Me.New_TransDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect Then
                Me.New_TransDataGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            End If
        End If
      

        If Me.New_TransBindingSource.Filter Is Nothing Then
            'If Me.FILTER_EXCHANGE.Image.Equals(My.Resources.VsImg.Filter2HS) = False Then
            If Me.FILTER_EXCHANGE.Text <> "FILTER" Then
                Me.FILTER_EXCHANGE.Image = My.Resources.VsImg.Filter2HS
                Me.FILTER_EXCHANGE.Text = "FILTER"
                'If Me.New_TransDataGridView.AllowUserToAddRows = False Then Me.New_TransDataGridView.AllowUserToAddRows = True
            End If
        Else
            If Me.FILTER_EXCHANGE.Text = "FILTER" Then
                Me.FILTER_EXCHANGE.Image = My.Resources.Small_imgs.AukWrong
                Me.FILTER_EXCHANGE.Text = "REMOVE FILTER"
                'If Me.New_TransDataGridView.AllowUserToAddRows = True Then Me.New_TransDataGridView.AllowUserToAddRows = False
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
    Public Sub BaLance()
        BLANCE()
    End Sub
    Public Sub RECHARGE_NUMBER(Optional ByVal S As String = "SEND", Optional ByVal CardsDue As Boolean = False)
        On Error Resume Next
        Dim STR1 As String = UCase(AukF.GridT(Drv, 8))
        Dim Sq As String
        Dim TCom, CardCate As String
        'Dim S As String
        'SND DEFINE AS SEND
        'UND DEFINE AS UNSEND
        Drv = Me.New_TransDataGridView
        S = UCase(S)
        'MsgBox(S)
        Me.New_TransDataGridView.EndEdit()
        Me.New_TransBindingSource.EndEdit()
        Me.New_TransDataGridView(8, Me.New_TransDataGridView.CurrentCell.RowIndex).Value = S
        'Me.New_TransBindingSource.EndEdit()
        If STR1 = "" Or STR1 = Und Or STR1 = CSold Then
            If (S = DueStr Or S = Snd Or S = Und) Then 'CHECK ON CURRENT LABEL,IF ITS NOT BELONGS TO THEM
                If S = DueStr Or S = Snd Then
                    MINUS_BLANCE() 'minus from the account because before  send
                    If DRow > -1 Then Drv(10, DRow).Value = CStr(TimeOfDay) 'Set SEND TIME=cur.time
                ElseIf S = Und Then
                    If DRow > -1 Then Drv(10, DRow).Value = DBNull.Value 'Set SEND TIME= null
                End If
                If (S = DueStr Or S = Snd Or S = Und) And STR1 = CSold Then 'before csold and now due or send then +1 with stock cards
                    Cards_ADD(True) 'Add a card from stock if found
                End If
            ElseIf (S = CSold) And STR1 <> S Then 'first if csold
                Cards_ADD(False) 'remove a card from stock if found
            End If
        ElseIf STR1 = DueStr Or STR1 = Snd Then 'due/snd is same and there is not extra features,due is written for only save 
            If S = Und Or S = CSold Then
                If S = Und And DRow > -1 Then Drv(10, DRow).Value = DBNull.Value 'MAKE SEND TIME=""
                PLUS_BLANCE() 'PLUS THE AMOUNT BECAUSE IT IS NOW UNSEND
                If S = CSold Then
                    Cards_ADD(False)
                End If
            ElseIf STR1 = DueStr And S = Snd Then 'if due to snd ,means due to paid then
                'it is only for save information in stock paid due.
                If My.Settings.TOOK_WHOL_INFO_MOB = True Then
                    Dim DN1, dN2 As Date
                    DN1 = CDate(AukF.GridT(Drv, 7).ToString)
                    If Me.AukDatabaseDataSet.DaY_Sold_Info.Rows.Count = 1 Then
                        dN2 = CDate(Me.AukDatabaseDataSet.DaY_Sold_Info(0).Item("Date_Info").ToString)
                        If DN1 <> dN2 Then
                            'CHECKING THAT PAID DUE IS ON CUR DATE OR NOT.
                            Me.AukDatabaseDataSet.DaY_Sold_Info(0).Todays_Paid_Due = Val(Me.AukDatabaseDataSet.DaY_Sold_Info(0).Item("Todays Paid Due").ToString) + Val(AukF.GridT(Drv, 4)) '4=amt
                        End If
                    Else
                        MsgBox("DAY STOCK INFORMATION ROW IS NOT FOUND, CAN'T SAVE IN PAID DUE FIELD. PLEASE REOPEN THIS FORM.", MsgBoxStyle.Exclamation)
                        'MsgBox("CAN'T ADD MONEY IN PAID DUE SECTION,INTERNAL PROBLEM,CONTACT WITH DEVELOPER." & vbCrLf & "BUT ITS NOT EFFECT ON YOUR CURRENT SYSTEM OF WORK.", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If
        End If
        If S = CSold Then
            If CardsDue = True Then
                If Drv.CurrentRow IsNot Nothing Then
                    If DRow > -1 Then Drv(12, DRow).Value = True 'due=true
                End If
            Else
                If DRow > -1 Then Drv(12, DRow).Value = False 'due=false by normal card selling
            End If
        Else
            If DRow > -1 Then Drv(12, DRow).Value = False 'due=false,if not card selling
        End If
        BLANCE()
        'Me.New_TransDataGridView(8, Me.New_TransDataGridView.CurrentCell.RowIndex).Value = sender.TEXT
        'DUE,BENFIT,LOSS REFRESH ON BOTTOM
        'Exit Sub
trans_CurBalx:  'insert cur bal in transaction
        If (S = "UNSEND" Or S = CSold) And DRow > -1 Then Drv(6, DRow).Value = 0 : GoTo due_Loss_Chek 'FOR SAVIN GO ON DUE CHEKC
        If My.Settings.mAKE_TRANS_bAL = True Then 'trans=curbal
            Sq = AukF.GridT(Drv, 3) 'SETTING TRANS=CUR.BAL
            If AukF.BindFind(Me.MobComBindingSource, "CATEGORY_id", Sq) = True Then
                'Me.BLANCE_LABEL.Text = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Company").ToString & " " & Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Our_Account").ToString & " T.K."
                If DRow > -1 Then Drv(6, DRow).Value = Val(Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Our_Account").ToString)
            Else
                If DRow > -1 Then Drv(6, DRow).Value = 0
            End If
        End If
due_Loss_Chek:
        Me.Check_Due_Loss_BenefitC()
BENEFIT_WORK:
        Me.Set_Benefit_OnCurrent() 'save effected on set benefit
    End Sub
    Private Sub Cards_ADD(ByVal Adding As Boolean)
        TCom = AukF.GridT(Drv, 3).ToString 'geting com id
        CardCate = AukF.GridT(Drv, 4).ToString 'geting the value of amount field
        CARDS_SELLING(TCom, CardCate, Adding)
    End Sub
    Public Sub CARDS_SELLING(ByVal CID As String, ByVal CCATE As Integer, ByVal ADDING As Boolean, Optional ByVal Message As Boolean = True, Optional ByVal HowMany As Integer = 1)
        Dim Im As Integer
        Dim CardsInt As Decimal
        Dim Drv As DataGridView = Me.New_TransDataGridView
        If ADDING = True Then Im = HowMany Else Im = HowMany * -1
        Dim Rx1() As DataRow
        'TCom = AukF.GridT(Drv, 3).ToString 'geting com id
        'CardCate = AukF.GridT(Drv, 4).ToString 'geting the value of amount field
        TCom = CID 'geting com id
        CardCate = CCATE 'geting the value of amount field
        Rx1 = SoftIn.Rows_Select(Me.AukDatabaseDataSet.Mob_Cards, "category_id='" & TCom & "' and Card_Category=" & CardCate)
        If Rx1 IsNot Nothing Then
            RowX = ArV2(Rx1, 0) 'a row of mob cards
            CardsInt = Val(RowX.Item("cards_instock").ToString)
            CardsInt = CardsInt + Im  'inserting card into stock becase before status =card sold
            If CardsInt < 0 Then
                If Message = True Then MsgBox("You can't sell this current card because you are out of stock for this card.", MsgBoxStyle.Exclamation, "Card Can't Be Sold")
                If DRow > -1 Then Drv(8, DRow).Value = ""
            ElseIf CardsInt >= 0 Then 'cards instock >=0,if not untill 0 it will work,we have the value before whats happen next if + or - in cardsint
                RowX.Item("cards_instock") = CardsInt
                CardsInt = Val(RowX.Item("cards_SOLD").ToString)
                RowX.Item("cards_SOLD") = CardsInt + (Im * -1)
                RowX.EndEdit()
            End If
        Else
            If DRow > -1 Then Drv(8, DRow).Value = ""
            If Message = True Then MsgBox("This Card is not Created Yet.Please Create to Sell.", MsgBoxStyle.Information)
        End If
        'If My.Settings.DIRECT_SAVE = True Then Me.SAVE_MOBS()

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
            BeneFit_ = CDec(Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID='" & Sq & "' and Status='SEND'", "SUM", 4))) '11=benefit sum,4=amount
            Extra = CDec(Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID='" & Sq & "'", "SUM", 8))) '8=EXTRA
            DisCount = CDec(Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID='" & Sq & "'", "SUM", "Discount"))) '8=EXTRA
            'MsgBox("A " & BeneFit_ & "E " & Extra & "D " & DisCount)

            'geting all amount in byx,Byx=Sum(Amount)
            'after that collect all due,unsend in Dyn,Dyn=Due+Unsends
            'In Benefit = % of benefit *(AMOUNT-DYN[DUE+UNSENDS])
            'UNSENDS = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID='" & SQ & "' AND STATUS='UNSEND'", "SUM", 4)) '11=benefit sum,4=amount
            'Dyn = Val(Me.DUE_TOTAL_LABEL.Text) + Val(UNSENDS)
            'BeneFit_ = amount
            Me.BENEFIT_TOTAL_LABEL.Text = Format((Benefit_p / 100) * BeneFit_ + Val(Extra) - DisCount, "0.##")
            'MsgBox(extra)
            If Val(Me.BENEFIT_TOTAL_LABEL.Text) - Val(Me.DUE_TOTAL_LABEL.Text) < 0 Then
                Me.LOSS_LABEL.Text = Format(((Me.BENEFIT_TOTAL_LABEL.Text) - Val(Me.DUE_TOTAL_LABEL.Text)) * -1, "0.##")
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

    Private Sub FILTERSELECTEDITEMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTERSELECTEDITEMSToolStripMenuItem.Click, ToolStripMenuItem12.Click, FILTERSELECTEDCELLSToolStripMenuItem.Click
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
        Me.Mob_CardsTableAdapter1.Fill(Me.AukDatabaseDataSet.Mob_Cards)
    End Sub

    Private Sub NewTrans_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Or e.CloseReason = CloseReason.FormOwnerClosing Or e.CloseReason = CloseReason.None Or e.CloseReason = CloseReason.UserClosing Or e.CloseReason = CloseReason.WindowsShutDown Then
            If My.Settings.Dont_RefreshData = True Then
                'MsgBox(TrTb.Rows(0).Item(0).ToString)
                If Me.AukDatabaseDataSet.New_Trans.Rows.Count >= 2500 Then
                    e.Cancel = True
                    Me.Hide()
                    'Exit Sub
                End If
            End If
            If Me.AukDatabaseDataSet.HasChanges = True Then
                If SavMsg() = 1 Then
                    Me.SAVE_MOBS()
                ElseIf SavInt = 2 Then
                    e.Cancel = True
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Public Function Check_Chg_GoOn() As Boolean
        If Me.AukDatabaseDataSet.HasChanges = True Then
            '1=save,2=cancel,0=no
            If SavMsg() = 1 Then
                Me.SAVE_MOBS()
                Check_Chg_GoOn = True
            ElseIf SavInt = 0 Then 'no
                AukF.SingleDataTable_DataRecordRefresh(Me.New_TransBindingSource)
                AukF.SingleDataTable_DataRecordRefresh(Me.MobComBindingSource)
                Me.AukDatabaseDataSet.Mob_Cards.RejectChanges()
                Check_Chg_GoOn = True
            ElseIf SavInt = 2 Then 'cancel
                Check_Chg_GoOn = False
            End If
        Else
            Check_Chg_GoOn = True
        End If
    End Function
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
        If My.Settings.ENTER_TOnEXT_MOB = True Then address = InputBox("Please type client address to save in database,if you don't you can .", "Address", address)
        Try
b1:         If New_TransDataGridView.CurrentRow Is Nothing Then Exit Sub
            Me.New_TransDataGridView.EndEdit()
            Me.New_TransBindingSource.EndEdit()
            Str1(0) = MaxID
            Str1(1) = AukF.GridT(Me.New_TransDataGridView, 1).ToString
            Str1(3) = AukF.GridT(Me.New_TransDataGridView, 2)
            Str1(2) = address
            Me.AukDatabaseDataSet.Mob_Clients.Rows.Add(Str1)
            Me.Mob_ClientsTableAdapter1.Update(Me.AukDatabaseDataSet.Mob_Clients)
            If DRow > -1 Then
                Me.New_TransDataGridView(1, DRow).Value = AukF.GridT(Me.New_TransDataGridView, 1) & "(" & MaxID & ")"
            End If
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
    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
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
        If ADSRC.TWICE_BINDFIND(Me.New_TransBindingSource, "Clients_ID", "Mobile_Number", sender.text, "Transaction_number", Me.New_TransDataGridView) = True Then
            Me.ToolStripTextBox3.ForeColor = Color.White
            Me.ToolStripTextBox3.BackColor = Color.Black
        Else
            Me.ToolStripTextBox3.ForeColor = Color.Black
            Me.ToolStripTextBox3.BackColor = Color.White
        End If
    End Sub
    Private Sub BLANCE_LABEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLANCE_LABEL.Click
        Dim Inputx As String
        If sender.tag = "m" Then
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
        Else
            Dim Rx1() As DataRow
            TCom = AukF.GridT(Drv, 3).ToString 'geting com id
            CardCate = AukF.GridT(Drv, 4).ToString 'geting the value of amount field
            Rx1 = SoftIn.Rows_Select(Me.AukDatabaseDataSet.Mob_Cards, "category_id='" & TCom & "' and Card_Category=" & CardCate)
            If Rx1 IsNot Nothing Then
                RowX = ArV2(Rx1, 0) 'a row of mob cards
                CardsInt = Val(RowX.Item("cards_instock").ToString)
                Inputx = InputBox("Please type the new amount of " & TCom & " " & CardCate & " Stock.", tcom & " " & CardCate & " Cards Amount", Inputx)
                If Inputx = "" Then Exit Sub
                RowX.Item("cards_instock") = Val(Inputx)
                Me.Mob_CardsTableAdapter1.Update(RowX)
                Me.BLANCE_LABEL.Text = "TOTAL CARDS INSTOCK  " & Val(Inputx)   'inserting card into stock becase before status =card sold
                'MsgBox(Me.BLANCE_LABEL.Text)
            Else
                Me.BLANCE_LABEL.Text = "CARD INFORMATION NOT FOUND"
            End If
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
        ADSRC.LOAD_WHOLE_DATABASE(Me.AukDatabaseDataSet.New_Trans)
        'MsgBox(Sql)
    End Sub

    Private Sub ClearDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearDatabaseToolStripMenuItem.Click
        SAVE_MOBS()
        Me.AukDatabaseDataSet.New_Trans.Clear()
        'GoTo DOWORKD
    End Sub

    Private Sub FILTER_EXCHANGE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTER_EXCHANGE.ButtonClick
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
        If FILTER_CHECKED_BUT.Checked = True Then
            AukF.BindFilter(Me.New_TransBindingSource, "mOBILE_NUMBER", sender.TEXT, 1)
        End If
        If e.Control = True And e.KeyCode = Keys.Enter Then
            AukF.BindFilter(Me.New_TransBindingSource, "mOBILE_NUMBER", sender.TEXT, 7) 'auk advance and array function
        ElseIf e.KeyCode = Keys.Enter Then
            AukF.BindFilter(Me.New_TransBindingSource, "mOBILE_NUMBER", sender.TEXT, 1)

        End If
    End Sub

    Private Sub FILTER_CHECKED_BUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTER_CHECKED_BUT.Click
        AukF.BindFilter(Me.New_TransBindingSource, "mOBILE_NUMBER", ToolStripTextBox4.Text, 1)
    End Sub
    Public Sub Get_All_Benefit_in_their_Field() 'Sending Benefit
        Dim S2 As String
        Dim Drv As DataGridView = Me.New_TransDataGridView
        Dim MBp, Amt As Decimal
        'TRY TO INSERT THE VALUE OF BENEFIT
        '11=BENEFIT,9=DISCOUNT,4=AMOUNT,5=EXTRA,12=CUR BAL.
        '11= (MBP/100)*[4] +[5]-[9]
        '11=discount
        '9=DISCOUNT,4=AMOUNT,5=EXTRA,12=CUR BAL.
        '11= (MBP/100)*[4] +[5]-[9]
        Me.New_TransBindingSource.EndEdit()
        S2 = UCase(AukF.GridT(Drv, 8).ToString)
        If S2 <> "SEND" And DRow > -1 Then Drv(11, DRow).Value = 0
        New_TransDataGridView.Visible = False
        Me.New_TransDataGridView.Enabled = False
        If Me.AukDatabaseDataSet.New_Trans.Rows.Count < (Val(My.Settings.MaximumData_load)) Then
            Me.Prog.Visible = True
            Prog.Value = 0
            'Me.COMPANY_NAMES_DIS.Visible = True
            Prog.Visible = True
            Prog.Value = 0
            Prog.Maximum = Me.AukDatabaseDataSet.New_Trans.Rows.Count
            For k As Integer = 0 To Me.AukDatabaseDataSet.New_Trans.Rows.Count - 1
                Dim Rm1 As DataRow
                Dim BENEfit, DIScOUNT, eXTRA As Decimal
                Dim CiD As String 'CATEGORY ID GET
                Dim sT As String 'FOR STATSUS
                'Rnx = Me.AukDatabaseDataSet.New_Trans.Select("CATAGORY_id='" & CiD & "'")
                Rm1 = Me.AukDatabaseDataSet.New_Trans(k)
                sT = UCase(Rm1.Item("STATUS").ToString)
                CiD = Rm1.Item(3).ToString 'cid
                'COMPANY_NAMES_DIS.Text = CiD
                'MsgBox(COMPANY_NAMES_DIS.Text)
                'Exit For
                'geting extra,discount,amout
                eXTRA = Val(Rm1.Item("EXTRAmONEY").ToString)
                DIScOUNT = Val(Rm1.Item("DISCOUNT").ToString)
                Amt = CDec(Val(Rm1.Item("AMOUNT").ToString))
                'getin complete
                If sT = Snd Or sT = CSold Then
                    If sT = Snd Then
                        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Mob_Com, CiD, 5) = True Then 'cid company id
                            MBp = Val(WGeT) 'Cause Get Current Table Cl=3 means be%,get on wget if found.
                        Else
                            MBp = 0
                            If DRow > -1 Then Drv(11, DRow).Value = 0 'bene=0
                        End If
                    ElseIf sT = CSold Then
                        'getting tCom by CID
                        Dim Rx1() As DataRow
                        TCom = CiD  'geting com id
                        CardCate = Amt 'geting the value of amount field
                        Rx1 = SoftIn.Rows_Select(Me.AukDatabaseDataSet.Mob_Cards, "category_id='" & TCom & "' and Card_Category=" & CardCate)
                        If Rx1 IsNot Nothing Then
                            RowX = ArV2(Rx1, 0) 'a row of mob cards
                            MBp = Val(RowX.Item("CArd_Benefit_Percent").ToString)
                        Else
                            MBp = 0
                        End If
                    End If
                Else
                    Rm1.Item("BENEFIT") = 0
                    Rm1.Item("EXTRAmONEY") = 0
                    Rm1.Item("DISCOUNT") = 0
                End If
                BENEfit = RBenefit(Amt, eXTRA, DIScOUNT, MBp, F1x)
                Rm1.Item("Benefit") = BENEfit
                'COMPANY_NAMES_DIS.Text = CiD
                Prog.Value = Prog.Value + 1
            Next
            'Me.COMPANY_NAMES_DIS.Text = "Saving"
            'COMPANY_NAMES_DIS.Visible = False
            If My.Settings.DIRECT_SAVE = True Then SAVE_MOBS()
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

    Private Sub ToolStripLabel8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel8.ButtonClick
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
            If AukF.FindTxt(sender.TEXT, ",") = True Then
                DUE_LOAD_BY_DATE_IN_A_FORMAT(sender.TEXT, False)
            Else
                Me.DueCheck(sender.TEXT)

            End If
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
            Me.Mob_CardsTableAdapter1.Fill(Me.AukDatabaseDataSet.Mob_Cards)
            NeedToRe = False
        End If
        If StockI_mob.Visible = True Then
            If Me.NeedToStockRe = True Then Me.Refresh_Stock_info_tab() : Me.NeedToStockRe = False
        End If
    End Sub

    Private Sub HELP_MOB(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        AukF.OExe(AppPath & "\HELPS\MOBILE RECHARGE.PDF", Me)
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
        'ExpreC("not", "NULL", "NULL")
        'SnX("<>", "<>")
        SJOIN = "OR"
        AukSql.AukSql_Main("*", "New_Trans")
        x2 = BSql
        SFC("discount", "extraMONEY", "bENEFIT")
        STC("0", "0", "0")
        DTC("n", "n", "N")
        SnX(">", ">", ">")
        SJOIN = "OR"
        AukSql.AukSql_Main("*", "New_Trans")
        X2 = Replace(X2, "(", "")
        X2 = Replace(X2, ")", "")
        x3 = BSql
        X3 = Replace(X3, "(", "")
        X3 = Replace(X3, ")", "")
        a1 = "(" & x1 & ") OR (  (" & X2 & " )  AND (" & x3 & ")   ) OR ([STATUS] IS NULL OR  [STATUS] ='')"
        'MsgBox(a1)
        AukF.Db_LoadQ(Me.AukDatabaseDataSet.New_Trans, a1, -1, True)
        'me.New_TransDataGridView.Columns (2).DefaultCellStyle.Font 
        'MsgBox(Sql)
    End Sub

    Private Sub ToolStripMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem24.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.New_TransBindingSource, True)
    End Sub

    Private Sub INPUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INPUTToolStripMenuItem.Click
        AukF.Grid_View_SetCommonItems(Me.New_TransDataGridView, Me.COMMON_ADD_TEXTBOX.Text, Me.COMMONADD_COMBO.Text.Split(",").GetValue(1).ToString)
    End Sub

    Private Sub CARD_SELL(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CARDSELLINGToolStripMenuItem.Click
        Me.RECHARGE_NUMBER(CSold)
    End Sub

    Private Sub SENDMESSAGETIMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SENDMESSAGETIMEToolStripMenuItem.Click
        MsgBox(Me.CID_GET() & "CURRENT NUMBER : " & Me.CELL_NUMB_GET & vbCrLf & "SEND TIME:" & CDate(AukF.GridT(Me.New_TransDataGridView, 7).ToString) & " " & AukF.GridT(Me.New_TransDataGridView, 10).ToString, MsgBoxStyle.Information, "SEND TIME")
    End Sub
    Private Sub SHOWONLYSOLDCARDSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWONLYSOLDCARDSToolStripMenuItem.Click
        AukF.BindFilter(Me.New_TransBindingSource, "sTATUS", CSold)
    End Sub
    Private Sub REMOVESPACEANDFROMCELLNUMBERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REMOVESPACEANDFROMCELLNUMBERSToolStripMenuItem.Click
        SoftIn.SELECTED_CELLS_Replace_MultiTexts(Me.New_TransDataGridView, "2,2", "-, ", "", "", True, "CARD SELLING")
    End Sub
    Private Sub OFFICESERIALCELLNUMBERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFFICESERIALCELLNUMBERSToolStripMenuItem.Click
        Dim Xm As String
        Dim Cid As String
        Xm = InputBox("PLEASE TYPE AS (START-END)" & vbCrLf & "LIKE AS 01913500863-01913500888,25 NUMBER INCLUDE IN THIS SERIAL", "OFFICIAL NUMBERS SYSTEM", Xm)
        Dim X1, X2 As Decimal
        m = Split(Xm, "-")
        X1 = Val(ArV2(m, 0))
        X2 = Val(ArV2(m, 1))
        Sn1 = "0" & Val(X1) 'insert num to get company category
        Sx1 = Mid(Sn1, 1, 3).ToString
        'MsgBox(Sx1)
        If AukF.BindFind(Me.MobComBindingSource, "Digits", Sx1) = True Then
            Cid = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Category_ID").ToString 'com category
        End If
        For K As Decimal = X1 To X2
            num = "0" & Val(K)
            RowX = Me.AukDatabaseDataSet.New_Trans.NewRow
            RowX.Item(0) = SoftIn.Master_ID_String_Get()
            RowX.Item(2) = num 'cell num Input
            RowX.Item(3) = Cid 'tele cate adding
            RowX.Item("Date_Business") = Dat2(WDate) 'date Input
            Me.AukDatabaseDataSet.New_Trans.Rows.Add(RowX)
        Next
    End Sub

    Private Sub SHOPALLDAYINFORMATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOPALLDAYINFORMATIONToolStripMenuItem.Click
        FrmL(StockI_mob)
    End Sub

    Private Sub Card_print(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportOfCardSellingToolStripMenuItem.Click
        If Check_Chg_GoOn() = False Then Exit Sub
        Dim M As New MobileReportCardsOnly2
        Dim Lopt As New AukDatabaseDataSetTableAdapters.OptionsTableAdapter
        Lopt.Fill(Me.AukDatabaseDataSet.Options)
        Dim Lopt2 As New AukDatabaseDataSetTableAdapters.Mob_ComTableAdapter
        Lopt2.Fill(Me.AukDatabaseDataSet.Mob_Com)
        AukF.Prnt(M, Me.AukDatabaseDataSet, Me.New_TransBindingSource, "{New_Trans.Status}='" & CSold & "'")
    End Sub

    Private Sub DBD_BACKuP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBD_BACKuP.Click
        CSOFT.DB_BACKUP()
    End Sub

    Private Sub Due_byDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox7.KeyDown
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
            Try
                SFC("Date_Business", "STATUS")
                STC(CDate(sender.text), "SEND BUT NOT PAID YET")
                DTC("d")
                SnX("=")
                AukF.Db_LoadN(Me.AukDatabaseDataSet.New_Trans, -1, "", True)
            Catch ex As Exception
                Epx()
            End Try
        End If
    End Sub

    Private Sub MultiCardsSell_Button(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MULTICARDSSELLINGToolStripMenuItem.Click
        'Dim InCx As Integer
        cd = (InputBox("Please Type the number how many cards of same category you want to make sold", "Cards Multi Selling Number", InCx))
        If cd = "" Then Exit Sub
        Multi_Cards_Selling(Val(cd))
    End Sub

    Private Sub CURRENT_STOCK_BENEFIT_cOST(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CARD_CEEL1.Click
        Dim InCx As String
        InCx = InputBox("Please Type as (Stock Add money,Benefit)." & vbCrLf & "Default add only Stock Money", "Stock Add Money,Benefit", "0,0")
        If InCx = "" Then Exit Sub
        If AukF.FindTxt(InCx, ",") = False Then
            Me.AukDatabaseDataSet.DaY_Sold_Info(0).Item(1) = Val(Me.AukDatabaseDataSet.DaY_Sold_Info(0).Item(1).ToString) + Val(InCx)
        Else
            asz = Split(InCx, ",")
            d1 = ArV2(asz, 0, 0) 'stock
            d2 = ArV2(asz, 1, 0) 'benefit
            Me.AukDatabaseDataSet.DaY_Sold_Info(0).Item(1) = Val(Me.AukDatabaseDataSet.DaY_Sold_Info(0).Item(1).ToString) + Val(d1)
            Me.AukDatabaseDataSet.DaY_Sold_Info(0).Item(4) = Val(Me.AukDatabaseDataSet.DaY_Sold_Info(0).Item(4).ToString) + Val(d2)

        End If
        Try
            Me.DaY_Sold_InfoBindingSource.EndEdit()
            Me.DaY_Sold_InfoTableAdapter.Update(Me.AukDatabaseDataSet.DaY_Sold_Info)
            If StockI_mob.Visible = True Then StockI_mob.NeedToRe = True
        Catch ex As Exception
            Epx()
        End Try
        If My.Settings.DIRECT_SAVE = True Then SAVE_MOBS()
    End Sub

    Private Sub TODAYSSTOCKINFORMATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TODAYSSTOCKINFORMATIONToolStripMenuItem.Click
        'FrmL(StockI_mob)
        Dim Stock As String
        Dim Benefitx As String
        StockI_mob.Hide()
        StockI_mob.Date_Of_Stock(NDate) 'ITS TRY TO OPEN DATE INFORMATION IN THAT FORM
        STOCK = StockI_mob.StockMoneyShow.Text
        Benefitx = StockI_mob.Benefit_show.Text
        Stock = Replace(Stock, ",", vbCrLf & " ")
        Benefitx = Replace(Benefitx, ",", vbCrLf & " ")
        MsgBox("Todays Stock Information:" & vbCrLf & vbCrLf & Stock & vbCrLf & vbCrLf & "'Total=Stock+Cards Selling Cost+Mobile Stock+Paid Due-Expense", MsgBoxStyle.Information, "Todays Stock Information")
        MsgBox("Todays Benefit Information:" & vbCrLf & vbCrLf & Benefitx, MsgBoxStyle.Information, "Todays Benefit Information")
    End Sub

    Private Sub FILTER_EFFECTSx(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTERUNSENDONLYToolStripMenuItem.Click, FILTERSENDONLYToolStripMenuItem.Click, FILTERDUEONLYToolStripMenuItem.Click, FILTERCARDSONLYToolStripMenuItem.Click, REMOVEFILTERToolStripMenuItem1.Click, FILTERSTATUSNULLSONLYToolStripMenuItem.Click, FILTERONLYCURRENTCOMPANYDUEToolStripMenuItem.Click, FILTERDUEONLYToolStripMenuItem1.Click, FILTERCARDSDUEONLYToolStripMenuItem.Click, FILTERSTATUSNULLSONLYToolStripMenuItem1.Click, FILTERONLYDUEMOBILERECHARGEDUEToolStripMenuItem.Click, FILTERONLYCARDSDUEToolStripMenuItem.Click
        Dim B As BindingSource = Me.New_TransBindingSource
        T = sender.TAG
        If T = "c" Then
            AukF.BindFilter(B, "Status", CSold)
        ElseIf T = "s" Then
            AukF.BindFilter(B, "Status", Snd)
        ElseIf T = "d" Then
            AukF.BindFilter(B, "Status", DueStr)
        ElseIf T = "u" Then
            AukF.BindFilter(B, "Status", Und)
        ElseIf T = "n" Then
            AukF.BindFilter(B, "Status", "")
        ElseIf T = "cd" Then
            a = SoftIn.GetFunction_QrText(Me.AukDatabaseDataSet.New_Trans, "Status", CSold)
            c = SoftIn.GetFunction_QrText(Me.AukDatabaseDataSet.New_Trans, "Due_Cards", "YES")
            v = a & " and " & c
            AukF.BindFilter_BSql(B, v)
        ElseIf T = "md" Then 'mobile due
            AukF.BindFilter(B, "Status", DueStr)
        ElseIf T = "cmd" Then
            tcom = AukF.GridT(Me.New_TransDataGridView, 3).ToString
            a = SoftIn.GetFunction_QrText(Me.AukDatabaseDataSet.New_Trans, "Catagory_id", tcom)
            c = SoftIn.GetFunction_QrText(Me.AukDatabaseDataSet.New_Trans, "status", DueStr)
            v = a & " and " & c
            AukF.BindFilter_BSql(B, v)

        ElseIf T = "r" Then
            B.RemoveFilter()
        End If
    End Sub

    Private Sub Specific_Cards_Message(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TODAYSCARDSSELLINGINFORMATIONToolStripMenuItem.Click
        Dim TCom As String
        ', BenefitStr, CardSellingStr, CardStrArray
        Dim CardStr As String = ""
        Dim CardStr2 As String = ""
        Dim BStr As String = "Individual Cards Benefit Information(Without Due)" & vbCrLf
        Dim PStr As String = "Individual Cards Selling Price Information(Without Due)" & vbCrLf
        Dim CountStr As String = "Individual Sold Cards Number Information(With Due)" & vbCrLf
        Dim StockStr As String = "Individual Cards InStock Number Information" & vbCrLf
        Dim CardsDueStr As String = "Individual Cards Due (Sold,Price) Information" & vbCrLf

        Dim CCate, Count, StockCount, DueCount As Integer
        Dim Benefit, Price, TBenefit, TPrice, TCount, TStockCount, TDueCount, Due, TDue As Decimal
        Me.Prog.Visible = True
        Count = Val(ADSRC.SummaryNonExeTable_New(Me.AukDatabaseDataSet.New_Trans, "Status", CSold))
        If Count = 0 Then TCount = 0 : GoTo lastend
        Prog.Value = 0
        Prog.Maximum = Me.AukDatabaseDataSet.Mob_Cards.Rows.Count
        TCount = 0

        For K As Integer = 0 To Me.AukDatabaseDataSet.Mob_Cards.Rows.Count - 1
            Try
                TCom = Me.AukDatabaseDataSet.Mob_Cards(K).Category_ID.ToString
                CCate = Val(Me.AukDatabaseDataSet.Mob_Cards(K).Item("Card_Category").ToString)
                CardStr = TCom & " " & CCate & " TK. Card: "
                '1=category id,2=card cate
                'Price,TPrice=means Stock 
                Count = Val(ADSRC.SummaryNonExeTable_New(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID,AMOUNT,Status", TCom & "," & CCate & "," & CSold))
                If Count > 0 Then
                    'price ,stock money of card selling by specfic
                    Price = Val(ADSRC.SummaryNonExeTable_New(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID,AMOUNT,Status,Due_Cards", TCom & "," & CCate & "," & CSold & ",False", "Sum", "Amount"))
                    Benefit = Val(ADSRC.SummaryNonExeTable_New(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID,AMOUNT,Status,Due_Cards", TCom & "," & CCate & "," & CSold & ",False", "Sum", "Benefit"))
                    StockCount = Val(Me.AukDatabaseDataSet.Mob_Cards(K).Item("Cards_InStock").ToString)
                    CardStr2 = TCom & " " & CCate & " TK. "
                    DueCount = Val(ADSRC.SummaryNonExeTable_New(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID,AMOUNT,Status,Due_Cards", TCom & "," & CCate & "," & CSold & ",True", "count", "Benefit"))
                    Due = Val(ADSRC.SummaryNonExeTable_New(Me.AukDatabaseDataSet.New_Trans, "CATAGORY_ID,AMOUNT,Status,Due_Cards", TCom & "," & CCate & "," & CSold & ",True", "sum", "amount"))
                    CardsDueStr = CardsDueStr & vbCrLf & CardStr2 & " Count: " & DueCount & ", Due Price: " & Due

                    BStr = BStr & vbCrLf & CardStr & Benefit
                    PStr = PStr & vbCrLf & CardStr & Price
                    CountStr = CountStr & vbCrLf & CardStr & Count
                    StockStr = StockStr & vbCrLf & CardStr & StockCount
                    TPrice += Price
                    TBenefit += Benefit
                    TCount += Count
                    TStockCount += StockCount
                    TDueCount += DueCount
                    TDue += Due
                    'TStockCount = tPriceCount
                End If
                Prog.Value += 1
            Catch ex As Exception
                Epx()
                Exit For
            End Try
        Next
        If TCount > 0 Then
            'pstr means stockstr and cards stock information
            MsgBox(CountStr & vbCrLf & vbCrLf & "Total: " & TCount, MsgBoxStyle.Information, "Individual Cards Selling Number(With Due)")
            If TPrice > 0 Then MsgBox(PStr & vbCrLf & vbCrLf & "Total: " & TPrice, MsgBoxStyle.Information, "Individual Cards Selling Price(Without Due)")
            If TBenefit > 0 Then MsgBox(BStr & vbCrLf & vbCrLf & "Total: " & TBenefit, MsgBoxStyle.Information, "Individual Cards Selling Benefit(Without Due)")
            If TStockCount > 0 Then MsgBox(StockStr & vbCrLf & vbCrLf & "Total: " & TStockCount, MsgBoxStyle.Information, "Individual Cards InStock Information")
            If TDueCount > 0 Then MsgBox(CardsDueStr & vbCrLf & vbCrLf & "Total: " & TDue, MsgBoxStyle.Information, "Individual Cards Due Information")
        Else
lastend:    MsgBox("Information of Cards is not found in this Records.", MsgBoxStyle.Information)
        End If
        Me.Prog.Visible = False
    End Sub

    
    Private Sub CARDS_Due(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CARDSDUEToolStripMenuItem.Click
        Me.RECHARGE_NUMBER(CSold, True)
    End Sub
End Class