Public Class PS_SOLD
    Dim SAVING As Boolean = False
    Dim WARCHK As New DataTable
    Public GS As Boolean = False
     Public cLIENT As String = ""
    Public soldID As String
    Public RpID As String
    Public NeedtoRe_proAdd As Boolean

    Public Function ADDLST(ByVal SID As String, Optional ByVal FindOpenDb As Boolean = False) As Boolean
        Dim RA As Array
        Dim cmRow As Integer
        Dim PCOST, BPR As Decimal
        Dim DisId, DisN, proN As String
        Dim BenefitC As Decimal
        RA = ADSRC.FIND_FROM_DATATABLE_ARRAY(Me.AukDatabaseDataSet.PS_Collection, SID)
        If RA Is Nothing Then
            If FindOpenDb = True Then
                SFC("Product_Serial")
                STC(SID)
                AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_Collection, -1, "", False)
                RA = ADSRC.FIND_FROM_DATATABLE_ARRAY(Me.AukDatabaseDataSet.PS_Collection, SID)
            End If
        End If

        'ra= ps collection row
        'ra0=pr sr
        'r1=pname
        'r2=place
        'r3= prchase date
        'r4=pro cost
        'r5=bn pr
        'r6=dis id
        'r7=vid

        DisId = ArV(RA, 6)
        DisN = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, DisId, 3).ToString
        proN = DisN & " # " & ArV(RA, 0)
        cmRow = ComRow
        WARANT = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, ArV(RA, 6), 7)
        If GS = False Then MsgBox("PLEASE LOAD A CUSTOMER FIRST", MsgBoxStyle.Critical) : ToolStripTextBox1.Focus() : Return False : Exit Function
        If AukF.BindFind(Me.PSSOLDBindingSource, "PRODUCT_SERIAL", SID) = True Then MsgBox("THIS PRODUCT IS EXIST IN CURRENT CUSTOMER ACCOUNT.", MsgBoxStyle.Information, "EXIST PRODUCT") : Exit Function
        If RA IsNot Nothing Then
            soldID = Mid(SrGens.Convert_Hash_RND(RpID, Now.Second, Now.Millisecond).ToString.ToUpper, 1, 6)
            If GS = True Then
                '''''this is for get price from display id table
                ''''If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, ArV(RA, 6)) = True Then
                ''''    PCOST = CDec(Val(RowX(4).ToString)) : BPR = CDec(Val(RowX(5).ToString))
                ''''Else
                ''''    MsgBox("DISPLAY ID IS NOT VALID,CONTACT WITH ALIM-UL-KARIM.", MsgBoxStyle.Critical)
                ''''    Exit Function
                ''''End If

                'get price from ps colletion row
                PCOST = Val(ArV(RA, 4, Nothing, 0))
                BPR = Val(ArV(RA, 5, Nothing, 0))
                '-----
                ADDLST = True
                BenefitC = CDec(Val(Val(BPR) - Val(PCOST)))
                c = BenefitC
                PS = ArV(RA, 0)
                PNX = proN
                If My.Settings.CHECK_BENEFIT_PS = True Then
                    If C < 0 Then
                        MsgBox("CURRENT PRODUCT [" & PNX & "] SOLD PRICE IS LESS THAN PURCHASE COST." & "CHECK YOURSELF.", MsgBoxStyle.Critical, "SOLD PRICE IS LESS THAN PURCHASE COST<LOSS>")
                        GOTOPOS_PS(PS)
                        Exit Function
                    End If
                    If C = 1 Then
                        MsgBox("CURRENT PRODUCT [" & PNX & "] SOLD PRICE IS SO CHEAP, BENEFIT IS ONLY ONE TAKA,CHECK YOUR SELF.", MsgBoxStyle.Critical, "SOLD PRICE IS CHEAP,LOW BENEFIT ONLY ONE TAKA.")
                        GOTOPOS_PS(PS)
                        Exit Function
                    End If
                    If C = 0 Then
                        MsgBox("CURRENT PRODUCT [" & PNX & "] SOLD PRICE IS SO CHEAP, THERE IS NO BENEFIT,CHECK YOUR SELF.", MsgBoxStyle.Critical, "SOLD PRICE IS CHEAP,NO BENEFIT")
                        GOTOPOS_PS(PS)
                        Exit Function
                    End If
                End If
                RowX = Me.AukDatabaseDataSet.PS_SOLD.NewRow
                RowX(0) = soldID
                RowX(1) = DisId 'DIS
                RowX(2) = ArV(RA, 0) 'PRO SR
                RowX(3) = cLIENT 'CLIENT
                RowX(4) = proN 'PRO NAME
                RowX(5) = Val(PCOST) 'PUR COST
                RowX(6) = Val(BPR) 'BENEFIT COST
                RowX(7) = 0
                RowX(8) = BenefitC 'BENEFIT
                RowX(9) = Dat(Now.Date.Date)   'SOLD DATE
                RowX(10) = Val(WARANT) 'WANRRETY
                RowX(11) = RpID 'REP ID
                If ArV(RA, 7).ToString = "" Then
                    MsgBox("CURRENT PRODUCT VENDOR IS NOT SELECTED", MsgBoxStyle.Critical)
                    RowX("V_ID") = DBNull.Value 'VENDORS ID LINKED WITH
                    'RowX("V_ID") = ArV(RA, 7)
                Else
                    RowX("V_ID") = ArV(RA, 7) 'VENDORS ID LINKED WITH
                End If

                Me.AukDatabaseDataSet.PS_Collection(cmRow).PLACE = "SOLD"
                Me.AukDatabaseDataSet.PS_Collection(cmRow).EndEdit()
                Me.AukDatabaseDataSet.PS_SOLD.Rows.Add(RowX)
                CHG_RP()
            Else
                ADDLST = False
            End If
        Else
            ADDLST = False
            If RA Is Nothing Then MsgBox("PRODUCT ID [ " & SID & " ] IS NOT FOUND IN DATABASE.", MsgBoxStyle.Critical) : Exit Function
            ToolStripTextBox1.Focus()
        End If
    End Function
    Public Sub CHG_RP()
        'MsgBox(Val(Me.AukDatabaseDataSet.PS_SOLD.Compute("SUM(DISCOUNT)", "")), , Val(Me.AukDatabaseDataSet.PS_SOLD.Compute("SUM(SOLD_PRICE)", "")))
        'MsgBox(Val(Me.AukDatabaseDataSet.PS_SOLD.Compute("SUM(SOLD_PRICE)", "CLIENT_NAME='" & cLIENT & "'")))
        On Error Resume Next

        Me.TOTAL_AMOUNNTTextBox.Text = Val(Me.AukDatabaseDataSet.PS_SOLD.Compute("SUM(SOLD_PRICE)", "")) - Val(Me.AukDatabaseDataSet.PS_SOLD.Compute("SUM(DISCOUNT)", ""))
        If Val(My.Settings.VAT_PER_PS) <> -1 Then
            a = Val(Me.TOTAL_AMOUNNTTextBox.Text) - Val(Me.TOTAL_DISCOUNTTextBox.Text)
            Me.VATTextBox.Text = SoftIn.GET_BENEFIT(a, Val(My.Settings.VAT_PER_PS), True, False)
        End If
        Me.Validate()
        Me.RP_IDBindingSource.EndEdit()
    End Sub

    Private Sub PS_SOLD_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If NeedtoRe_proAdd = True Then
            Me.PS_CollectionTableAdapter.Fill(Me.AukDatabaseDataSet.PS_Collection)
            NeedtoRe_proAdd = False
        End If
    End Sub
    Private Sub PS_SOLD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AukF.ComSelIndex(Me.VendorsList)
        Me.TextBox1.MaxLength = Me.AukDatabaseDataSet.PS_Collection.PRODUCT_SERIALColumn.MaxLength
        AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CATEGORY, -1, "", False, 0, "CATEGORY", False, 0, Val(My.Settings.MaximumData_load))
        AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SUB_CATEGORY, -1, "", False, 0, "SUB_CATEGORY_NAME", False, 0, Val(My.Settings.MaximumData_load))
        AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, -1, "", False, 0, "[DISPLAY ID]", False, 0, Val(My.Settings.MaximumData_load))
        If My.Settings.DataLoad_view = False Then
            SFC("PLACE")
            STC("INSTORE")
            AukF.Db_LoadN(Me.PSCATEGORYDISPSCollectionBindingSource, -1, "", False, 0, "", False, 0, Val(My.Settings.MaximumData_load))
        End If

        AukF.BindFilter(PSCATEGORYDISPSCollectionBindingSource, "PLACE", "INSTORE")
        'If My.Settings.DIS_LIST_PS_SOLD = 0 Then
        '    Me.ListBox1.DisplayMember = "PRODUCT_NAME"
        'Else
        'Me.ListBox1.DisplayMember = "PRODUCT_SERIAL"
        'End If
        AukF.ComSelIndex(filter_combox)
        AukF.ComSelIndex(Me.PAYMENT_CATEGORYComboBox)
        Me.PS_EmployeTableAdapter.Fill(Me.AukDatabaseDataSet.PS_Employe)
        Me.VendorTableAdapter1.Fill(Me.AukDatabaseDataSet.VENDOR)
    End Sub
    Public Function VIEW_BY_REPORT_ID(ByVal REPORTID As String)
        SFC("REPORT_ID")
        STC(REPORTID)
        AukF.Db_LoadN(Me.RP_IDBindingSource)
        If Me.RP_IDBindingSource.Count <> 1 Then
            MsgBox("No Invoice serial is correctly found.", MsgBoxStyle.Critical)
            Exit Function
        Else
            SFC("REPORT_ID")
            STC(REPORTID)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SOLD)
            If Me.AukDatabaseDataSet.PS_SOLD.Rows.Count > 0 Then
                FrmL(Me)
            End If
        End If
    End Function
    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        Dim A As Array
        If e.KeyCode = Keys.R And e.Modifiers = Keys.Control And e.Modifiers = Keys.Shift Then
            If GS = True Then MsgBox("Please Let off Current Client Account.", MsgBoxStyle.Critical) : Exit Sub Else Me.AukDatabaseDataSet.PS_SOLD.Clear()
            SFC("REPORT_ID")
            STC(RpID)
            AukF.Db_LoadN(Me.RP_IDBindingSource)
            If Me.RP_IDBindingSource.Count <> 1 Then
                MsgBox("No Invoice serial is correctly found.", MsgBoxStyle.Critical)
            End If
            SFC("REPORT_ID")
            STC(sender.TEXT)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SOLD)
            Exit Sub
        End If
        If e.KeyCode = Keys.R And e.Modifiers = Keys.Control Then
            If GS = True Then MsgBox("Please Let off Current Client Account.", MsgBoxStyle.Critical) : Exit Sub Else Me.AukDatabaseDataSet.PS_SOLD.Clear()
            Dim DQA As Date
            A = Me.ToolStripTextBox1.Text.Split(";")
            Try
                DQA = Dat(ArV(A, 1))
            Catch ex As Exception
                Epx(ArV(A, 1))
                Exit Sub
            End Try
            cLIENT = ArV(A, 0)
            Me.GET_RPID(cLIENT, DQA)
            SFC("REPORT_ID")
            STC(RpID)
            AukF.Db_LoadN(Me.RP_IDBindingSource)
            If Me.RP_IDBindingSource.Count <> 1 Then
                MsgBox("No Invoice serial is correctly found.", MsgBoxStyle.Critical)
            Else
                GS = True
            End If
            SFC("REPORT_ID")
            STC(sender.TEXT)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SOLD)
            'SELL()
            Exit Sub
        End If
        If My.Settings.SAVE_CLIENT_MSOLD = True Then
            If e.KeyCode = Keys.Enter And e.Modifiers = Keys.Control Then
                If GS = True Then MsgBox("Please Let off Current Client Account.", MsgBoxStyle.Critical) : Exit Sub Else Me.AukDatabaseDataSet.PS_SOLD.Clear()
                SFC("CLIENT_NAME")
                A = Me.ToolStripTextBox1.Text.Split(";")
                STC(ArV(A, 0))
                AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CLIENTS)
                If Me.AukDatabaseDataSet.PS_CLIENTS.Rows.Count = 1 Then
                    cLIENT = Me.AukDatabaseDataSet.PS_CLIENTS(0).CLIENT_NAME.ToString
                    GS = True
                Else
                    'A = Me.ToolStripTextBox1.Text.Split(";")
                    Me.PS_CLIENTSTableAdapter1.Insert(ArV(A, 0), ArV(A, 1), ArV(A, 2))
                    SFC("CLIENT_NAME")
                    STC(ArV(A, 0))
                    AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CLIENTS)
                    If Me.AukDatabaseDataSet.PS_CLIENTS.Rows.Count = 1 Then
                        cLIENT = Me.AukDatabaseDataSet.PS_CLIENTS(0).CLIENT_NAME.ToString
                        GS = True
                    Else
                        GS = False
                        MsgBox("NOT FOUND CAN'T CREATE CLIENT,CONTACT WITH DEVELOPER.", MsgBoxStyle.Critical)
                    End If
                End If
                SELL()
                Exit Sub
            End If
            If e.KeyCode = Keys.Enter Then
                If GS = True Then MsgBox("Please Let off Current Client Account.", MsgBoxStyle.Critical) : Exit Sub Else Me.AukDatabaseDataSet.PS_SOLD.Clear()
                SFC("CLIENT_NAME")
                STC(sender.TEXT)
                AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CLIENTS)
                If Me.AukDatabaseDataSet.PS_CLIENTS.Rows.Count = 1 Then
                    cLIENT = Me.AukDatabaseDataSet.PS_CLIENTS(0).CLIENT_NAME.ToString
                    GS = True
                Else
                    cLIENT = ""
                    GS = False
                End If
                SELL()
            End If
        Else
            If e.KeyCode = Keys.Enter Then
                If GS = True Then MsgBox("Please Let off Current Client Account.", MsgBoxStyle.Critical) : Exit Sub Else Me.AukDatabaseDataSet.PS_SOLD.Clear()
                cLIENT = sender.TEXT
                GS = True
                SELL()
            End If
        End If


    End Sub
    Public Function GET_RPID(ByVal CLIENTn As String, ByVal DATE1 As Date)
        RpID = Replace(SrGens.Convert_Hash(CLIENTn & DATE1.ToLongDateString), "\", "")
        RpID = RpID.Replace(CChar("/@$%&*!\+"), "")
        If RpID.Length < 8 Then
            RpID = RpID & SrGens.Convert_Hash(CLIENTn).Replace(CChar("/@$%&*!\+"), "")
        End If
        RpID = Mid(RpID, 1, 8).ToUpper
        RpID = "INV-" & Now.Month & "-" & RpID
        Return RpID

    End Function
    Public Sub SELL()
        If GS = True Then
            Me.DataGridView1.DataSource = Me.PSSOLDBindingSource
            RpID = Replace(SrGens.Convert_Hash(cLIENT & Now.Date.ToLongDateString), "\", "")
            RpID = RpID.Replace(CChar("/@$%&*!\+"), "")
            'RpID = RpID.Replace("+", "")
            If RpID.Length < 8 Then
                RpID = RpID & SrGens.Convert_Hash(cLIENT).Replace(CChar("/@$%&*!\+"), "")
            End If
            RpID = Mid(RpID, 1, 8).ToUpper
            RpID = "INV-" & Now.Month & "-" & RpID
            SFC("REPORT_ID")
            STC(RpID)
            AukF.Db_LoadN(Me.RP_IDBindingSource)
            SFC("REPORT_ID")
            STC(RpID)
            AukF.Db_LoadN(Me.PSSOLDBindingSource)
            If Me.AukDatabaseDataSet.RP_ID.Rows.Count = 0 Then
                Me.RP_IDTableAdapter.Insert(RpID, 0, 0, 0, 0, "CASH", SoftIn.Default_DataTable(Me.AukDatabaseDataSet.PS_Employe), Dat(Now.Date))
                SFC("REPORT_ID")
                STC(RpID)
                AukF.Db_LoadN(Me.RP_IDBindingSource)
                If Me.AukDatabaseDataSet.RP_ID.Rows.Count <> 1 Then
                    MsgBox("CONTACT WITH AUK ERROR IN INSERT REPORT ID,WHICH IS IMPOSSIBLE.", MsgBoxStyle.Critical)
                End If
            End If
        Else
            RpID = ""
            Me.DataGridView1.DataSource = Nothing
        End If
    End Sub


    Private Sub GOOD_FIND_FRMLIST(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox4.TextChanged
        If AukF.FindInObjectAndSelect(Me.ListBox1, sender.TEXT, True, False, True) = False Then
            AukF.FindInObjectAndSelect(Me.ListBox1, sender.TEXT, False, False, True)
        End If


    End Sub

    Private Sub SAVE_DIS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTSERIALToolStripMenuItem.Click, PRODUCTNAMEToolStripMenuItem.Click
        My.Settings.DIS_LIST_PS_SOLD = sender.TAG
        My.Settings.Save()
        If My.Settings.DIS_LIST_PS_SOLD = 0 Then
            Me.ListBox1.DisplayMember = "PRODUCT_NAME"
        Else
            Me.ListBox1.DisplayMember = "PRODUCT_SERIAL"
        End If
    End Sub

    Private Sub FILTER_LIST(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox3.TextChanged, ToolStripTextBox2.TextChanged
        AukF.BindFilter(PSsTOCK, sender.TAG, sender.TEXT)
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        ADDLST(Me.ListBox1.SelectedValue.ToString)
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ADDLST(sender.TEXT, True)
            If AukF.BindFind(Me.PSSOLDBindingSource, "Product_Serial", sender.text, True) = True Then
                Me.DataGridView1.Rows(ComRow).Selected = True
            End If
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Label6.Text = "TOTAL GOOD(S): " & Me.ListBox1.Items.Count

        If GS = True Then
            Me.ToolStripTextBox1.BackColor = Color.Black
            ToolStripTextBox1.ForeColor = Color.White
        ElseIf GS = False Then
            Me.ToolStripTextBox1.BackColor = Color.LightCyan
            ToolStripTextBox1.ForeColor = Color.Black
        End If
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DataGridView1, My.Settings.BENEFIT_SHOW_PS, 8)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DataGridView1, My.Settings.PURCHASE_SHOW_PS, 5)
        DVDRENT.SET_READONLY_COLUMN(Me.DataGridView1, My.Settings.WARN_M_READONLY_PS, 10)
        DVDRENT.SET_READONLY_COLUMN(Me.DataGridView1, My.Settings.PURCHASE_RO_PS, 5)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DataGridView1, My.Settings.CLIENT_NAME_SHOW_PS, 4)

        'DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DataGridView1, My.Settings.PURCHASE_SHOW_PS, 5)


    End Sub
    Public Function SOLD()
        'DIM R AS DataRow 
        Dim C As Decimal
        Me.Validate()
        CHG_RP()

        'MsgBox(Me.ComboBox4.Text & Len(Me.ComboBox4.Text), , Me.AukDatabaseDataSet.RP_ID.Columns("PREPARED_BY").MaxLength)
        Me.AukDatabaseDataSet.RP_ID(0).PREPARED_BY = Me.ComboBox4.Text
        'Try
        Me.PSSOLDBindingSource.EndEdit()
        Me.RP_IDBindingSource.EndEdit()
        Me.RP_IDTableAdapter.Update(Me.AukDatabaseDataSet.RP_ID)
        For K As Integer = (Me.DataGridView1.RowCount - 1) To 0 Step -1
            PS = AukF.GridT(Me.DataGridView1, 3, K, "")
            PNX = AukF.GridT(Me.DataGridView1, 2, K, "")
            C = AukF.GridT(Me.DataGridView1, 8, K, 0)
            'MsgBox(PS & vbCrLf & PNX & vbCrLf & C)

            'S = S - D : C = S - P
            If My.Settings.CHECK_BENEFIT_PS = True Then
                If C < 0 Then
                    MsgBox("CURRENT PRODUCT [" & PNX & "] SOLD PRICE IS LESS THAN PURCHASE COST." & "CHECK YOURSELF.", MsgBoxStyle.Critical, "SOLD PRICE IS LESS THAN PURCHASE COST<LOSS>")
                    GOTOPOS_PS(PS)
                    Exit Function
                End If
                If C = 1 Then
                    MsgBox("CURRENT PRODUCT [" & PNX & "] SOLD PRICE IS SO CHEAP, BENEFIT IS ONLY ONE TAKA,CHECK YOUR SELF.", MsgBoxStyle.Critical, "SOLD PRICE IS CHEAP,LOW BENEFIT ONLY ONE TAKA.")
                    GOTOPOS_PS(PS)
                    Exit Function
                End If
                If C = 0 Then
                    MsgBox("CURRENT PRODUCT [" & PNX & "] SOLD PRICE IS SO CHEAP, THERE IS NO BENEFIT,CHECK YOUR SELF.", MsgBoxStyle.Critical, "SOLD PRICE IS CHEAP,NO BENEFIT")
                    GOTOPOS_PS(PS)
                    Exit Function
                End If
            End If
            'MsgBox(PS)
            If My.Settings.DEL_SOLD_PS = True Then
                If ADSRC.FIND_FROM_DATATABLE(Me.AukDatabaseDataSet.PS_Collection, PS) IsNot Nothing Then
                    RowX.Delete()
                    'RowX.EndEdit()
                    Try
                        Me.PS_CollectionTableAdapter.Update(RowX)
                    Catch ex As Exception
                        MsgBox("[ " & RowX.Item(1) & " ]IN PRODUCT INSTORE DELETE PRODUCT IS EXIST." & vbCrLf & "PLEASE REOPEN CURRENT FORM TO DO THE CHANGES AGAIN.", MsgBoxStyle.Critical)
                        Exit Function
                    End Try
                End If
            End If
        Next

        Try
            Me.PSSOLDBindingSource.EndEdit()
            Me.PS_SOLDTableAdapter.Update(Me.AukDatabaseDataSet.PS_SOLD)
        Catch ex As Exception
            Epx()
            Exit Function
        End Try
     
        'Try
        '    Me.PS_CollectionTableAdapter.Update(Me.AukDatabaseDataSet.PS_Collection)
        'Catch ex As Exception
        '    MsgBox("IN STOCK OF PRODUCTS COLLECTION, WE CAN'T SAVE THE CHANGES;DELETED PRODUCTS ARE EXIST." & vbCrLf & "PLEASE REOPEN CURRENT FORM TO DO THE CHANGES AGAIN.", MsgBoxStyle.Critical)
        'End Try
        GS = False
        My.Settings.Save()
        If My.Settings.AFTER_SOLD_PRINT_PS = True Then SPRNT(False)
        If My.Settings.AFTER_SOLD_PRINT_PS = False Then Me.AukDatabaseDataSet.PS_SOLD.Clear() : Me.AukDatabaseDataSet.RP_ID.Clear()

    End Function
    Public Sub SPRNT(Optional ByVal show_rp As Boolean = True)
        CHG_RP()
        Dim M As New PS_MEMO_RP24_SDiscount
        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim iO As CrystalDecisions.CrystalReports.Engine.FieldObject
        T = M.ReportDefinition.ReportObjects("COM")
        T.Text = Me.TextBox2.Text
        T = M.ReportDefinition.ReportObjects("inV")
        T.Text = My.Settings.TITLE_INVOICE_PS.ToString
        iO = M.ReportDefinition.ReportObjects("ComName")
        iO.ObjectFormat.EnableSuppress = Not My.Settings.SHOW_COMPANYN_PS_R
        'T = M.ReportDefinition.ReportObjects("ComName")
        'T.ObjectFormat.EnableSuppress = Not My.Settings.SHOW_COMPANYN_PS_R
        If My.Settings.COM_ADDRESS.ToString.Trim = "" Then
            M.ReportDefinition.Sections(10).SectionFormat.EnableSuppress = True
        Else
            M.ReportDefinition.Sections(10).SectionFormat.EnableSuppress = False
            T = M.ReportDefinition.ReportObjects("Text1")
            T.Text = My.Settings.COM_ADDRESS.ToString.Trim
        End If
        iO = M.ReportDefinition.ReportObjects("showwarranty1")
        iO.ObjectFormat.EnableSuppress = Not My.Settings.WARM_SHOW_PS
        If show_rp = True Then
            AukF.Prnt(M, Me.AukDatabaseDataSet)
        Else
            Reports.CrystalReportViewer1.ReportSource = M
            'MsgBox(Reports.CrystalReportViewer1.ViewCount)
            'M.PrintToPrinter(1, True, 0, Reports.CrystalReportViewer1.ViewCount)
            M.Database.Tables(0).SetDataSource(Me.AukDatabaseDataSet)
            Reports.CrystalReportViewer1.PrintReport()
            Me.AukDatabaseDataSet.PS_SOLD.Clear()
            Me.AukDatabaseDataSet.RP_ID.Clear()
        End If
    End Sub
    Public Function GOTOPOS_PS(ByVal SID As String)
        AukF.BindFind(Me.PSSOLDBindingSource, "PRODUCT_SERIAL", SID, True)
    End Function
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.ButtonClick, SOLDGOODSTOCURRNETToolStripMenuItem.Click, SOLDTOCURRENTCLIENTToolStripMenuItem.Click
        If My.Settings.BEFORE_SOLD_MSG_PS = True Then
            If AukF.MsgTrU("SOLD THIS PRODUCTS/GOODS TO CURRENT CUSTOMER/CLIENT(" & cLIENT & ")?", True) = False Then Exit Sub
        End If
        If GS = True Then SOLD() Else MsgBox("FIRST LOAD A CLIENT AND SELECT PRODUCTS THEN CLICK ON SOLD.", MsgBoxStyle.Critical) : Me.ToolStripTextBox1.Focus()


    End Sub


    Private Sub ToolStripTextBox6_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WARRANTY_TXTBOX.KeyDown
        'Dim mONTHS As Decimal
        If e.KeyCode = Keys.Enter Then
            ToolStripButton2_ButtonClick(sender, e)

            'SFC("SOLD_ID", "PRODUCT_SERIAL")
            'SJOIN = "OR"
            'STC(sender.TEXT, sender.TEXT)
            'AukF.Db_LoadN(WARCHK, -1, "PS_SOLD")
            ''MsgBox(Sql)
            'If WARCHK.Rows.Count = 1 Then
            '    RowX = WARCHK.Rows(0)
            '    N = CDate(RowX(9))
            '    W = RowX(10) : mONTHS = CDec(Val(W))
            '    If Val(w) = 0 Then MsgBox("NO WARRANTY IS VALID", MsgBoxStyle.Critical, "PRODUCT IS FOUND") : Exit Sub
            '    C = DateDiff(DateInterval.Day, N, Now.Date)
            '    V = Format(C / 30, "0.##") 'NOW DISTANCE BY MNONTH
            '    W = "CURRENT PRODUCT/GOOD(" & WARCHK.Rows(0).Item(4) & ") IS FOUND BY ID" & UB(sender.TEXT) & "." & vbCrLf & "THE CUSTOMER/CLIENT OF THIS PRODUCT IS " & RowX(3).ToString & "." & vbCrLf & "CURRENT PRODCUT WARRANTY IS VALID FOR (" & RowX(10).ToString & ") MONTH(S) WHICH MEANS " & RowX(10).ToString / 12 & " YEAR(S).CLIENT BUY THIS ON " & CDate(RowX(9).ToString) & ". NOW DATE IS " & Now.Date & ",WHICH MEANS " & V & " MONTH(S) OR " & C & " DAY(S) LEFT." & vbCrLf
            '    W = W & "WARRANTY " & Val(RowX(10).ToString) * 30 & " DAY(S) OR " & RowX(10).ToString & " MONTH(S) OR " & RowX(10).ToString / 12 & " YEARS(S)." & vbCrLf & "LEFT " & C & " DAY(S) OR " & V & " MONTH(S) " & Format(V / 12, "0.##") & " YEAR(S)"
            '    'MsgBox(Val(mONTHS), , Val(V))
            '    If (Val(mONTHS) - Val(V)) > 0 Then
            '        MsgBox(W, MsgBoxStyle.Information, "WARRANTY IS  VALID," & "LEFT " & C & " DAY(S);REMAIN " & (Val(RowX(10).ToString) * 30) - C)
            '    Else
            '        MsgBox(W, MsgBoxStyle.Critical, "WARRANTY IS NOT VALID")
            '    End If
            'Else
            '    MsgBox("CURRENT PRODUCT IS NOT VALID", MsgBoxStyle.Critical, "PLEASE TYPE CORRECTLY")
            'End If
        End If
        'ADSRC.LOAD_AND_FIND ME.AukDatabaseDataSet .PS_SOLD ,
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim UA, UA2 As Array
        Dim INPuTX As String
        Dim STR(6) As String
        Dim C, S, D As String
        INPuTX = InputBox("PLEASE TYPE AS THIS TYPE FORMAT: " & vbCrLf & "GOOD'S ID;DISPLAYID OR (CATEGORY/SUBCATEGORY/DISPLAY INDEX)", "ADD NEW PRODCUT", INPuTX)
        If INPuTX.Trim <> "" Then
            UA = INPuTX.Split(";")
            P = ArV(UA, 0)
            If InStr(ArV(UA, 1), "/") = 0 Then
                D = CInt(Val(ArV(UA, 1)))
            Else
                UA2 = ArV(UA, 1, "/")
                C = ArV(UA2, 0, Nothing, 0) - 1 : S = ArV(UA2, 1, Nothing, 0) - 1 : D = ArV(UA2, 2, Nothing, 0) - 1
                If S < 0 Then S = 0 : If C < 0 Then C = 0 : If D < 0 Then D = 0
                If AukF.SelectIndexFromObject(Me.ComboBox1, C, True) = True And AukF.SelectIndexFromObject(Me.ComboBox2, S, True) = True And AukF.SelectIndexFromObject(Me.ComboBox3, D, True) = True Then
                    D = Me.ComboBox3.SelectedValue.ToString
                End If
            End If
            If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, D) = True Then
                STR(0) = P
                STR(1) = ""
                STR(2) = "INSTORE"
                STR(3) = Now.Date
                P = Val(ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, D, 4))
                B = Val(ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, D, 5))
                If ArV(UA, 2).ToString <> "" Then STR(4) = P Else STR(4) = Val(ArV(UA, 2).ToString)
                If ArV(UA, 3).ToString <> "" Then STR(5) = B Else STR(4) = Val(ArV(UA, 3).ToString)
                STR(6) = D
                Me.AukDatabaseDataSet.PS_Collection.Rows.Add(STR)
                Try
                    Me.PS_CollectionTableAdapter.Update(Me.AukDatabaseDataSet.PS_Collection)
                Catch ex As Exception
                    Epx()
                End Try
            Else
                MsgBox("DISPLAY ID IS NOT VALID CAN'T INSERT", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Function GET_PRONAME(ByVal PRSR As String, ByVal DIPLAYID As Integer)
        On Error Resume Next
        DISC = (ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, DIPLAYID, 3))
        If disc <> "" And PRSR <> "" Then Return disc & " # " & PRSR
    End Function



    Private Sub INSTALLATION_CHARGETextBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INSTALLATION_CHARGETextBox.DoubleClick
        Try
            sender.TEXT = Val(My.Settings.INS_PS_CHARGE.ToString)
            'sender.validate()
            Me.RP_IDBindingSource.EndEdit()
        Catch ex As Exception
            MsgBox("PLEASE LOAD A CLIENT FIRST THEN TRY TO DO IT.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FrmL(PS_SETTING)


    End Sub


    Public Function GET_BACK_INTORE(ByVal SID As String, ByVal SoldXID As String) As Boolean
        'Dim PSc As DataTable = Me.AukDatabaseDataSet.PS_Collection
        Dim PSs As DataTable = Me.AukDatabaseDataSet.PS_SOLD
        Dim S(6) As String
        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.PS_Collection, SID) = True Then
            Me.AukDatabaseDataSet.PS_Collection(ComRow).PLACE = "INSTORE"
            Me.AukDatabaseDataSet.PS_Collection(ComRow).EndEdit()
            Return False
        Else
            If ADSRC.FIND_FROM_DATATABLE_INDEX(PSs, SoldXID) = True Then
                S(0) = RowX(2) 'PS SERIAL
                S(1) = "" 'PS NAME
                S(2) = "INSTORE" 'PLACE
                S(3) = Now.Date 'PURCHASE DATE
                S(4) = RowX(5) 'PS COST
                S(5) = RowX(6) 'SOLD PRICE
                S(6) = RowX(1) 'DIS ID
                S(7) = RowX("v_id") 'VENDOR'S ID
                Me.AukDatabaseDataSet.PS_Collection.Rows.Add(S)
                'Me.AukDatabaseDataSet.PS_Collection.NewRow.EndEdit()
            End If
        End If
    End Function

    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim P, S, D, B As Decimal
        P = AukF.GridT(sender, 5, -1, 0)
        S = AukF.GridT(sender, 6, -1, 0)
        D = AukF.GridT(sender, 7, -1, 0)
        'B = AukF.GridT(sender,, 8, 0)
        PS = AukF.GridT(sender, 2, -1, "")
        S = S - D
        If My.Settings.CHECK_BENEFIT_PS = True Then
            If S - P < 0 Then
                MsgBox("CURRENT PRODUCT [" & PS & "] SOLD PRICE IS LESS THAN PURCHASE COST." & "CHECK YOURSELF.", MsgBoxStyle.Critical, "SOLD PRICE IS LESS THAN PURCHASE COST<LOSS>")
            End If
            If S - P = 1 Then
                MsgBox("CURRENT PRODUCT [" & PS & "] SOLD PRICE IS SO CHEAP, BENEFIT IS ONLY ONE TAKA,CHECK YOUR SELF.", MsgBoxStyle.Critical, "SOLD PRICE IS CHEAP,LOW BENEFIT ONLY ONE TAKA.")
            End If
            If S - P = 0 Then
                MsgBox("CURRENT PRODUCT [" & PS & "] SOLD PRICE IS SO CHEAP, THERE IS NO BENEFIT,CHECK YOUR SELF.", MsgBoxStyle.Critical, "SOLD PRICE IS CHEAP,NO BENEFIT")
            End If
        End If
        If e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 10 Then
            PSX = AukF.GridT(sender, 1).ToString
            If PSX <> "" Then 'TRY TO UPDATES PRODUCT PRICE & BENEFIT & WARRANTY
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, PSX, 4) = True Then
                    RowX(4) = Val(AukF.GridT(sender, 5))
                    RowX(5) = Val(AukF.GridT(sender, 6))
                    RowX(7) = Val(AukF.GridT(sender, 10))
                    RowX.EndEdit()
                    Try
                        Me.PS_CATEGORY_DISTableAdapter.Update(Me.AukDatabaseDataSet.PS_CATEGORY_DIS)
                    Catch ex As Exception
                        Epx()
                    End Try
                End If
            End If
        End If
        B = S - P
        sender(8, e.RowIndex).VALUE = B
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim iA As Integer
        Dim PS, SOLDIDX As String
        If AukF.MsgTrU("DELETE SELECTED?", True) = False Then Exit Sub
        If Me.DataGridView1.SelectedRows.Count = 0 Then
            If Me.PSSOLDBindingSource.Count > 0 Then
                PS = AukF.GridT(Me.DataGridView1, 3, -1, "")
                SOLDIDX = AukF.GridT(Me.DataGridView1, 0, -1, "")
                GET_BACK_INTORE(PS, SOLDIDX)
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.PS_SOLD, SOLDIDX) = True Then
                    RowX.Delete()
                    RowX.EndEdit()
                End If
            End If
        Else
            'MsgBox(Me.DataGridView1.SelectedRows.Count)
            For k As Integer = (Me.DataGridView1.SelectedRows.Count - 1) To 0 Step -1
                iA = Me.DataGridView1.SelectedRows(k).Index
                PS = AukF.GridT(Me.DataGridView1, 3, iA, "")
                SOLDIDX = AukF.GridT(Me.DataGridView1, 0, iA, "")
                GET_BACK_INTORE(PS, SOLDIDX)
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.PS_SOLD, SOLDIDX) = True Then
                    RowX.Delete() : RowX.EndEdit()
                End If
            Next
        End If
    End Sub

    Private Sub CANCELCURRENTPRODCUTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GS = True Then
            If AukF.MsgTr(UCase(What) & "CANCEL CURRENT CLIENT ITEM(S)?", False) = True Then
                GS = False
                Me.PSSOLDBindingSource.CancelEdit()
                Me.PSCATEGORYDISPSCollectionBindingSource.CancelEdit()
                Me.AukDatabaseDataSet.RejectChanges()
            End If
        Else
            Me.PSSOLDBindingSource.CancelEdit()
            Me.PSCATEGORYDISPSCollectionBindingSource.CancelEdit()
            Me.AukDatabaseDataSet.RejectChanges()
        End If

 
    End Sub
    Private Sub SHOWCLIENTEDITVIEWFORMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWCLIENTEDITVIEWFORMToolStripMenuItem.Click
        FrmL(PS_CLIENT)

    End Sub
    Private Sub REMOVEFILTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REMOVEFILTERToolStripMenuItem.Click
        Me.PSCATEGORYDISPSCollectionBindingSource.RemoveFilter()

    End Sub

    Private Sub FOCUSONGRIDVIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FOCUSONGRIDVIEWToolStripMenuItem.Click
        If GS = True Then
            Me.DataGridView1.Focus()
        Else
            ToolStripTextBox1.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ADDLST(Me.ListBox1.SelectedValue)

    End Sub

    Private Sub ListBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Then
            Me.ADDLST(Me.ListBox1.SelectedValue.ToString)
        End If
    End Sub


    Private Sub ToolStripTextBox5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox5.KeyDown
        Dim DvdS As String = "MOVIESOLD"
        If GS = False Then
            If e.KeyCode = Keys.Enter Then
                'SFC(filter_combox.Text)
                'STC(sender.TEXT)
                BSql = SoftIn.GetFunction_QrText(Me.AukDatabaseDataSet.PS_SOLD, filter_combox.Text, sender.text, 0)
                If BSql <> "" Then
                    BSql &= " AND ([DISPLAY_ID] <> '" & DvdS & "')"
                End If
                AukF.Db_LoadQ(Me.AukDatabaseDataSet.PS_SOLD, BSql, "*", True, "PRODUCT_SERIAL", False, -1, 1000)
                'MsgBox(Sql)
            Else
                SoftIn.KeyDown_EffectOn_Combo(Me.filter_combox, e)
            End If
        Else
            MsgBox("PLEASE LET THE CLIENT OFF", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub SEARCHQUERYINSTOCKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHQUERYINSTOCKToolStripMenuItem.Click
        AukQ.Bnp = Me.PSCATEGORYDISPSCollectionBindingSource
        FrmL(AukQ)

    End Sub

    Private Sub CANCELCURRENTPRODCUTSToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELCURRENTPRODCUTSToolStripMenuItem.Click
        If GS = True Then
            If AukF.MsgTr("cancel this sold selected products?", True) = True Then
                Me.AukDatabaseDataSet.PS_SOLD.Clear()
                Me.AukDatabaseDataSet.RP_ID.Clear()
                GS = False
            End If
        Else
            Me.AukDatabaseDataSet.PS_SOLD.Clear()
            Me.AukDatabaseDataSet.RP_ID.Clear()
        End If

    End Sub


    Private Sub EDITINEDITORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITINEDITORToolStripMenuItem.Click
        If Me.ListBox1.SelectedIndex > -1 Then
            PRO_ADD2.LOAD_BY_PS(Me.ListBox1.SelectedValue.ToString())

        End If
    End Sub

    Private Sub LOADALLAGAINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADALLAGAINToolStripMenuItem.Click
        PS_SOLD_Load(sender, e)

    End Sub
    Public Sub LOAD_ONLY_CUR(ByVal SID As String)
        SFC("PRODUCT_SERIAL")
        STC(SID)
        AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_Collection, -1, "", False)
    End Sub
    Public Sub LOAD_ONLY_CUR_WITH_DIS(ByVal SID As String)
        SFC("PRODUCT_SERIAL")
        STC(SID)
        AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_Collection, -1, "", False)
        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.PS_Collection, SID) Then
            D = RowX("DISPLAY_id")
            SFC("DISPLAY_ID")
            STC(D)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, -1, "", False)
        End If
    End Sub
    Private Sub LOADONLYCATEGORIESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADONLYCATEGORIESToolStripMenuItem.Click
        'On Error Resume Next
        C = Me.ComboBox1.SelectedIndex
        S = Me.ComboBox2.SelectedIndex
        D = Me.ComboBox3.SelectedIndex
        AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CATEGORY, -1, "", False, 0, "CATEGORY", False, 0, Val(My.Settings.MaximumData_load))
        AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SUB_CATEGORY, -1, "", False, 0, "SUB_CATEGORY_NAME", False, 0, Val(My.Settings.MaximumData_load))
        AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, -1, "", False, 0, "[DISPLAY ID]", False, 0, Val(My.Settings.MaximumData_load))
        Me.ComboBox1.SelectedIndex = C
        Me.ComboBox2.SelectedIndex = S
        Me.ComboBox3.SelectedIndex = D
    End Sub

    Private Sub SEARCHQUERYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHQUERYToolStripMenuItem.Click
        'AukQ.Bnp = Me.PSSOLDBindingSource
        'FrmL(AukQ)
        DVDRENT.ShowQr_Product(Me.DataGridView1, Me.PSSOLDBindingSource, "([DISPLAY_ID]  <>'" & "MOVIESOLD" & "')")
    End Sub

    Private Sub EDITCATEGORIESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITCATEGORIESToolStripMenuItem.Click
        PCATE.HOOK_FR = True
        PCATE.AukDatabaseDataSet = Me.AukDatabaseDataSet
        With PCATE
            'SAMEBP(.PS_CATEGORYBindingSource, Me.PSCATEGORYBindingSource)
            'SAMEBP(.PS_SUB_CATEGORYBindingSource, Me.PSCATEGORYPSSUBCATEGORYBindingSource)
            SAMEBP(.PS_CATEGORY_DISBindingSource, Me.PSSUBCATEGORYPSCATEGORYDISBindingSource)


        End With
        PCATE.PS_CATEGORY_DISDataGridView.Dock = DockStyle.Fill
        FrmL(PCATE)


    End Sub


    Private Sub EDITCURRENTCATEGORYGOODSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITCURRENTCATEGORYGOODSToolStripMenuItem.Click
        PRO_ADD2.HOOK_FR = True
        PRO_ADD2.AukDatabaseDataSet = Me.AukDatabaseDataSet
        With PRO_ADD2
            SAMEBP(.PSCATEGORYBindingSource, Me.PSCATEGORYBindingSource)
            SAMEBP(.PSCATEGORYPSSUBCATEGORYBindingSource, Me.PSCATEGORYPSSUBCATEGORYBindingSource)
            SAMEBP(.PSSUBCATEGORYPSCATEGORYDISBindingSource, Me.PSSUBCATEGORYPSCATEGORYDISBindingSource)
            SAMEBP(.PS_CollectionBindingSource, Me.PSCATEGORYDISPSCollectionBindingSource)
            .VENDORBindingSource.DataSource = Me.AukDatabaseDataSet.VENDOR

            .TopMost = True
        End With
        FrmL(PRO_ADD2)
    End Sub

    Private Sub CATEGORY_COMBOS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.Validated, ComboBox2.Validated, ComboBox1.Validated
        If SAVING = False Then
            'MsgBox(Me.ComboBox3.SelectedValue.ToString)
            'AukF.ComSelIndex(Me.ComboBox3)
            If sender.NAME = Me.ComboBox1.Name Then
                If Me.ComboBox2.Items.Count >= 1 Then
                    Me.ComboBox2.SelectedIndex = 0
                End If
                If Me.ComboBox3.Items.Count >= 1 Then
                    Me.ComboBox3.SelectedIndex = 0
                    'MsgBox(Me.ComboBox3.GetItemText(ComboBox3.SelectedIndex) & ComboBox3.SelectedValue, , ComboBox3.SelectedIndex)
                End If
            End If
            If sender.NAME = Me.ComboBox2.Name Then
                If Me.ComboBox3.Items.Count >= 1 Then
                    Me.ComboBox3.SelectedIndex = 0
                    'MsgBox(Me.ComboBox3.GetItemText(ComboBox3.SelectedIndex) & ComboBox3.SelectedValue, , ComboBox3.SelectedIndex)
                End If
            End If
            If Me.ComboBox3.SelectedIndex > -1 Then
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, Me.ComboBox3.SelectedValue.ToString, 4) = True Then
                    'MsgBox("Call")
                    Me.PURCHASE_INPUT_TOOLtEXT.Text = Val(WGeT)
                    Me.BENEFIT_INPTU_TOOL.Text = Val(RowX(5).ToString)
                    Me.WARRANTY_MONTHS_TOLL.Text = Val(RowX(7).ToString)
                End If
            End If
        End If
    End Sub

    Private Sub SAVEINDATABASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEINDATABASEToolStripMenuItem.Click
        SAVING = True
        a = Me.ComboBox3.SelectedValue.ToString
        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, a) = True Then
            RowX(4) = Val(Me.PURCHASE_INPUT_TOOLtEXT.Text)
            RowX(5) = CDec(Val(Me.BENEFIT_INPTU_TOOL.Text))
            RowX(7) = CDec(Val(Me.WARRANTY_MONTHS_TOLL.Text))
            'RowX.EndEdit()
            Try
                Me.PS_CATEGORYTableAdapter.Update(Me.AukDatabaseDataSet.PS_CATEGORY)
                Me.PS_CATEGORY_DISTableAdapter.Update(Me.AukDatabaseDataSet.PS_CATEGORY_DIS)
                'Me.PS_CollectionTableAdapter.Update(Me.AukDatabaseDataSet.PS_Collection)
            Catch ex As Exception
                Epx()
            End Try
            RowX = Nothing
        End If
        SAVING = False
    End Sub

    Private Sub ToolStripButton3_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SPRNT()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        AukF.FindInObjectAndSelect(Me.ListBox1, sender, False, False, True)
    End Sub

    Private Sub PS_SOLD_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If GS = True Then
            If AukF.MsgTrU("CANCEL CURRENT CLIENT?", True, MsgBoxStyle.Information) = False Then
                e.Cancel = True
            End If
        End If
    End Sub

    

    Private Sub ToolStripButton2_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.ButtonClick
        Dim mONTHS As Decimal
        SFC("SOLD_ID", "PRODUCT_SERIAL")
        SJOIN = "OR"
        STC(Me.WARRANTY_TXTBOX.Text, WARRANTY_TXTBOX.Text)
        AukF.Db_LoadN(WARCHK, -1, "PS_SOLD")
        'MsgBox(Sql)
        If WARCHK.Rows.Count = 1 Then

            RowX = WARCHK.Rows(0)
            N = Dat(RowX(9))
            W = RowX(10) : mONTHS = CDec(Val(W))
            If Val(w) = 0 Then MsgBox("NO WARRANTY IS VALID", MsgBoxStyle.Critical, "PRODUCT IS FOUND") : Exit Sub
            C = DateDiff(DateInterval.Day, N, Now.Date)
            V = Format(C / 30, "0.##") 'NOW DISTANCE BY MNONTH
            W = "CURRENT PRODUCT/GOOD(" & WARCHK.Rows(0).Item(4) & ") IS FOUND BY ID" & UB(sender.TEXT) & "." & vbCrLf & "THE CUSTOMER/CLIENT OF THIS PRODUCT IS " & RowX(3).ToString & "." & vbCrLf & "CURRENT PRODCUT WARRANTY IS VALID FOR (" & RowX(10).ToString & ") MONTH(S) WHICH MEANS " & RowX(10).ToString / 12 & " YEAR(S).CLIENT BUY THIS ON " & Dat(RowX(9).ToString) & ". NOW DATE IS " & Now.Date & ",WHICH MEANS " & V & " MONTH(S) OR " & C & " DAY(S) LEFT." & vbCrLf
            W = W & "WARRANTY " & Val(RowX(10).ToString) * 30 & " DAY(S) OR " & RowX(10).ToString & " MONTH(S) OR " & RowX(10).ToString / 12 & " YEARS(S)." & vbCrLf & "LEFT " & C & " DAY(S) OR " & V & " MONTH(S) " & Format(V / 12, "0.##") & " YEAR(S)"
            'MsgBox(Val(mONTHS), , Val(V))
            If (Val(mONTHS) - Val(V)) > 0 Then
                MsgBox(W, MsgBoxStyle.Information, "WARRANTY IS  VALID," & "LEFT " & C & " DAY(S);REMAIN " & (Val(RowX(10).ToString) * 30) - C)
            Else
                MsgBox(W, MsgBoxStyle.Critical, "WARRANTY IS NOT VALID")
            End If
        Else
            MsgBox("CURRENT PRODUCT IS NOT VALID", MsgBoxStyle.Critical, "PLEASE TYPE CORRECTLY")
        End If
    End Sub

    Private Sub WARRANTY_ADDINGS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDTOWARRANTYDATABASEToolStripMenuItem.Click
        Dim mONTHS As Decimal
        Dim PRO_SR, REMAIN As String
        Dim DqA, DqA2 As Date
        SFC("SOLD_ID", "PRODUCT_SERIAL")
        SJOIN = "OR"
        STC(Me.WARRANTY_TXTBOX.Text, WARRANTY_TXTBOX.Text)
        AukF.Db_LoadN(WARCHK, -1, "PS_SOLD")
        'MsgBox(Sql)
        If WARCHK.Rows.Count = 1 Then
            Dim PrName, PrSr, CLientName, WarYear, BuyDate, LefDate, WarMonths As String
            RowX = WARCHK.Rows(0) 'A PS_COLLECTION ROW WHICH IS FOUND BY ID
            N = Dat(RowX(9))
            PRO_SR = RowX(2).ToString
            W = RowX(10) : mONTHS = CDec(Val(W))
            If Val(w) = 0 Then MsgBox("NO WARRANTY IS VALID", MsgBoxStyle.Critical, "PRODUCT IS FOUND") : Exit Sub
            C = DateDiff(DateInterval.Day, N, Now.Date)
            V = Format(C / 30, "0.##") 'NOW DISTANCE BY MNONTH
            W = "CURRENT PRODUCT/GOOD(" & WARCHK.Rows(0).Item(4) & ") IS FOUND BY ID" & UB(WARRANTY_TXTBOX.Text) & "." & vbCrLf & "THE CUSTOMER/CLIENT OF THIS PRODUCT IS " & RowX(3).ToString & "." & vbCrLf & "CURRENT PRODCUT WARRANTY IS VALID FOR (" & RowX(10).ToString & ") MONTH(S) WHICH MEANS " & RowX(10).ToString / 12 & " YEAR(S).CLIENT BUY THIS ON " & Dat(RowX(9).ToString) & ". NOW DATE IS " & Now.Date & ",WHICH MEANS " & V & " MONTH(S) OR " & C & " DAY(S) LEFT" & vbCrLf
            W = W & "WARRANTY " & Val(RowX(10).ToString) * 30 & " DAY(S) OR " & RowX(10).ToString & " MONTH(S) OR " & RowX(10).ToString / 12 & " YEARS(S)." & vbCrLf & "LEFT " & C & " DAY(S) OR " & V & " MONTH(S) " & Format(V / 12, "0.##") & " YEAR(S)"

            PrSr = WARCHK.Rows(0).Item(4)
            PrName = RowX(3).ToString
            CLientName = UB(WARRANTY_TXTBOX.Text)
            WarMonths = RowX(10).ToString 'get database .. war month
            WarYear = RowX(10).ToString / 12 'convert to year
            BuyDate = Dat(RowX(9).ToString)
            LefDate = V & " MONTH(S) OR " & C & " DAY(S) LEFT"
            'MsgBox(Val(mONTHS), , Val(V))
            REMAIN = (Val(RowX(10).ToString) * 30) - C
            REMAIN = Val(REMAIN)

            If (Val(mONTHS) - Val(V)) > 0 Then
                'MsgBox(W, MsgBoxStyle.Information, "WARRANTY IS  VALID," & "LEFT " & C & " DAY(S);REMAIN " & (Val(RowX(10).ToString) * 30) - C)
                SFC("PRODUCT_SERIAL")
                STC(PRO_SR)
                AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_WARRANTY)
                'if product exist befoire in warrany db
                If Me.AukDatabaseDataSet.PS_WARRANTY.Rows.Count = 1 Then
                    D = Me.AukDatabaseDataSet.PS_WARRANTY.Rows(0).Item(5).ToString 'GETING WARRAY DATE
                    Try
                        DqA = Dat(Me.AukDatabaseDataSet.PS_WARRANTY.Rows(0).Item(3).ToString) 'GETING REMAINS DAYS
                    Catch ex As Exception
                        Epx()
                    End Try
                    M = DqA.AddDays(Val(D)) 'ADD DAY BECAUSE ,THE DAY GET BY DAYS DISTANCE N IT MEANS YESTERDAY AND SO ADD 1 DAY
                    DqA2 = Dat(M)
                    If DqA2 = Dat(Now.Date) Then 'CHECKIN TO DATES IF GET MATCHED THEN DISHCARGE
                        If AukF.MsgTr("DISCHARGE THIS CURRENT PRODUCT [ " & WARCHK.Rows(0).Item(4) & " ] TO THIS PRODUCTS CLIENT?", True) = True Then
                            Me.AukDatabaseDataSet.PS_WARRANTY.Rows(0).Delete() : Me.AukDatabaseDataSet.PS_WARRANTY.Rows(0).EndEdit()
                            Me.PS_WARRANTYTableAdapter1.Update(Me.AukDatabaseDataSet.PS_WARRANTY.Rows(0))
                        End If
                    Else
                        MsgBox("CURRENT PRODUCT IS ALREADY IN WARRANTY STOCK.WE WILL GIVE UP ON " & Dat(M) & ".", MsgBoxStyle.Information)
                    End If
                Else
                    'if pr is not exist in warranty stock....
                    INPUTX = InputBox("PLEASE TYPE THE DATE WHEN YOU WANT TO GIVE THIS PRODCUT TO THE CLIENT.", "DATE,REMAIN WARRANTY:" & REMAIN & " DAYS", INPUTX)
                    Try
                        DqA = Dat(INPUTX)
                    Catch ex As Exception
                        Epx() : Exit Sub
                    End Try
                    'D = DateDiff(DateInterval.Day, Now, DqA)
                    Dim ID As String
                    Dim vID As Object
                    Dim Rx As DataRow
                    vID = RowX("V_ID")
                    ID = SoftIn.Master_ID_String_Get(5) 'warranty id create
                    WRID = ID
                    CNAME = RowX("CLIENT_NAME").ToString
                    'ME.PS_WARRANTYTableAdapter1 .Insert ID,ROWX(0),PRO_SR,CDATE(NOW.Date ),REMAIN,
                    Me.PS_WARRANTYTableAdapter1.Insert(ID, RowX(0), PRO_SR, Dat(Now.Date), CInt(REMAIN), DqA, RowX("REPORT_ID").ToString, CNAME, "", vID)
                    Rx = RowX
                    ID = SoftIn.Master_ID_String_Get(6) 'v_war id create
                    VNAME = ADSRC.LOAD_AND_FIND(Me.AukDatabaseDataSet.VENDOR, "V_ID", vID, 1, False).Item("V_NAME").ToString
                    RowX = Rx
                    Me.V_WARTableAdapter1.Insert(ID, RowX("V_ID").ToString, VNAME, RowX(2).ToString, "", Dat(Now), DqA, "", False, RowX("SOLD_id").ToString, RowX("CLIENT_nAME").ToString, WRID) 'DqA ,  RowX("REPORT_ID").ToString)
                    MsgBox("PRODUCT ADD IN WARRANTY STOCK SUCCESSFULLY.", MsgBoxStyle.Information)
                End If
            Else
                MsgBox(W, MsgBoxStyle.Critical, "WARRANTY IS NOT VALID")
            End If
        Else
            MsgBox("CURRENT PRODUCT IS NOT VALID", MsgBoxStyle.Critical, "PLEASE TYPE CORRECTLY")
        End If
    End Sub

    Private Sub SHOWWARRANTYDATABASEVIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWWARRANTYDATABASEVIEWToolStripMenuItem.Click
        FrmL(PS_WARRANTY)

    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox4.KeyDown, ComboBox3.KeyDown, ComboBox2.KeyDown, ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If sender.NAME = Me.ComboBox4.Name Then
                Me.ListBox1.Focus()
            Else
                Me.SelectNextControl(sender, True, True, True, False)
            End If

        End If
    End Sub

    Private Sub CLIENTNAMEFOUCSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTNAMEFOUCSToolStripMenuItem.Click
        Me.ToolStripTextBox1.Focus()
    End Sub

    Private Sub ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem.Click
        TextBox1.Focus()

    End Sub

    Private Sub FOCUSONGOODSCATEGORYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FOCUSONGOODSCATEGORYToolStripMenuItem.Click
        Me.ComboBox1.Focus()
    End Sub

    Private Sub SELECTEDROWSDELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SELECTEDROWSDELETEToolStripMenuItem.Click
        BindingNavigatorDeleteItem_Click(sender, e)

    End Sub

    Private Sub ADDCURRENTINWARRAYSTOCKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDCURRENTINWARRAYSTOCKToolStripMenuItem.Click
        WARRANTY_TXTBOX.Text = AukF.GridT(Me.DataGridView1, 0)
        WARRANTY_ADDINGS(sender, e)
    End Sub

    Private Sub SUMMARYFORMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUMMARYFORMToolStripMenuItem.Click
        FrmL(PS_VIEW)

    End Sub

    Private Sub SHOWTODAYSBENEFITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWTODAYSBENEFITToolStripMenuItem.Click
        PS_VIEW.TODAYS_VIEW()

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        PS_VIEW.Load_(AukF.GridT(Me.DataGridView1, 11), AukF.GridT(Me.DataGridView1, 0))

    End Sub

    Private Sub PRINT(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.SPRNT()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ADDLST(Me.TextBox1.Text, True)
    End Sub

    Private Sub HideCurrentFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideCurrentFormToolStripMenuItem.Click, Button5.Click
        Me.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If TextBox1.Text = "" Then
            MsgBox("Please Type Product Serial to add", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim STR(7) As String
        Dim C, S, D As String
        Dim C1, S1, D1 As String
        C = Val(Me.ComboBox1.SelectedValue)
        S = Val(Me.ComboBox2.SelectedValue)
        D = Val(Me.ComboBox3.SelectedValue)
        C1 = Me.ComboBox1.Text
        S1 = Me.ComboBox2.Text
        D1 = Me.ComboBox3.Text

        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, D) = True Then
            'str imagine.. as ps new row array str
            Dim P As String
            P = TextBox1.Text
            STR(0) = P 'pr serial
            STR(1) = "" ' proname
            STR(2) = "INSTORE"
            STR(3) = Now.Date
            P = Val(ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, D, 4))
            B = Val(ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, D, 5))
            If ArV(UA, 2).ToString <> "" Then STR(4) = P Else STR(4) = Val(ArV(UA, 2).ToString)
            If ArV(UA, 3).ToString <> "" Then STR(5) = B Else STR(4) = Val(ArV(UA, 3).ToString)
            STR(6) = D
            STR(7) = Me.VendorsList.SelectedValue
            'MsgBox(Me.VendorsList.SelectedValue)
            Try
                Me.AukDatabaseDataSet.PS_Collection.Rows.Add(STR)
                Me.PS_CollectionTableAdapter.Update(Me.AukDatabaseDataSet.PS_Collection)
                Me.ListBox1.SelectedIndex = Me.ListBox1.Items.Count - 1
            Catch ex As Exception
                Epx()
            End Try
        Else
            MsgBox("DISPLAY ID IS NOT VALID CAN'T INSERT", MsgBoxStyle.Critical)
        End If
    End Sub

  
End Class