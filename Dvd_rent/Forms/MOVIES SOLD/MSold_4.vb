Public Class MSold
    Public GS As Boolean = False
    Public cLIENT As String = ""
    Public soldID As String
    Public RpID As String
    Dim TDISCOUNT As Decimal

    Private Sub MSold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.PS_Employe' table. You can move, or remove it, as needed.
        Dim oPT As New AukDatabaseDataSetTableAdapters.OptionsTableAdapter
        oPT.Fill(Me.AukDatabaseDataSet.Options)

        Me.PS_EmployeTableAdapter.Fill(Me.AukDatabaseDataSet.PS_Employe)
        ADSRC.GRID_HEADERS(Me.FILTERCOMBO, Me.DataGridView1)
        AukF.ComSelIndex(Me.FILTERCOMBO)
        AukF.ComSelIndex(Me.ComboBox4)
        AukF.XPAuk(Me)
    End Sub
    Public Function GET_BACK_INTORE(ByVal SID As String, ByVal SoldXID As String) As Boolean
        'Dim PSc As DataTable = Me.AukDatabaseDataSet.PS_Collection
        Dim PSs As DataTable = Me.AukDatabaseDataSet.PS_SOLD
        Dim S As DataRow
        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Product_Collection, SID) = True Then
            Me.AukDatabaseDataSet.PS_Collection(ComRow).PLACE = "InStore"
            Me.AukDatabaseDataSet.PS_Collection(ComRow).EndEdit()
            Return False
        Else
            If ADSRC.FIND_FROM_DATATABLE_INDEX(PSs, SoldXID) = True Then
                'Ty = CStr(RowX(1))
                S = Me.AukDatabaseDataSet.Product_Collection.NewRow
                S(0) = RowX(2) 'movie id/dvdid
                S(1) = RowX("MOVIE_TYPE")  'movie type
                S(2) = RowX("INFORMATION") 'MOVIE VERSION
                S(3) = RowX(4) 'movie NAME
                S(6) = "InStore" 'movie PLACE
                S(7) = RowX(5) 'movie purchase COST
                S(10) = RowX(6) 'movie SOLD PRICE
                S(11) = RowX(7) 'movie dicsount
                Me.AukDatabaseDataSet.Product_Collection.Rows.Add(S)
                'Me.AukDatabaseDataSet.PS_Collection.NewRow.EndEdit()
            End If
        End If
    End Function
    Public Function ADDLST(ByVal DvDiD As String, Optional ByVal FOUND_MSG As Boolean = True) As Boolean
        Dim RA As Array = Nothing
        Dim cmRow As Integer
        Dim PCOST, BPR As Decimal
        Dim DisId, proN As String
        Dim BenefitC As Decimal
        RA = ADSRC.FIND_FROM_DATATABLE_ARRAY(Me.AukDatabaseDataSet.Product_Collection, DvDiD)
        If RA Is Nothing Then
            SFC("DVD_ID")
            STC(DvDiD)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.Product_Collection, -1, "", False)
            'MsgBox("add")

            RA = ADSRC.FIND_FROM_DATATABLE_ARRAY(Me.AukDatabaseDataSet.Product_Collection, DvDiD)
        End If
        PLACE = ArV(RA, 6).ToString.ToUpper
        If PLACE <> "INSTORE" Then
            If FOUND_MSG = True Then
                MsgBox("MOVIE [" & DvDiD & "] PLACE " & PLACE & ".", MsgBoxStyle.Information)
            End If
            Exit Function
        End If
        DisId = ArV(RA, 1)
        proN = ArV(RA, 3)
        cmRow = ComRow
        If GS = False Then MsgBox("PLEASE LOAD A CLIENT FIRST/TYPE CLIENT NAME IN CLIENT TEXTBOX PRESS 'ENTER' TO TRY TO LOAD.", MsgBoxStyle.Critical) : ToolStripTextBox1.Focus() : Return False : Exit Function
        If FOUND_MSG = True Then
            If AukF.BindFind(Me.PSSOLDBindingSource, "PRODUCT_SERIAL", DvDiD) = True Then MsgBox("THIS MOVIE IS EXIST IN CURRENT CLIENT ACCOUNT.", MsgBoxStyle.Information, "EXIST PRODUCT") : Exit Function
        End If
        If RA IsNot Nothing Then
            soldID = Mid(SrGens.Convert_Hash_RND(RpID, Now.Second, Now.Millisecond, False, 22).ToString.ToUpper, 1, 8)
            If GS = True Then
                ADDLST = True
                PCOST = CDec(Val(ArV(RA, 7))) : BPR = CDec(Val(ArV(RA, 10)))
                If BPR <= 0 Then
                    'MsgBox(Val(My.Settings.Benefit_DVDSold.ToString))
                    BPR = SoftIn.GET_BENEFIT(PCOST, Val(My.Settings.Benefit_DVDSold.ToString))
                End If
                BenefitC = CDec(Val(Val(BPR) - Val(PCOST)))
                c = BenefitC
                PS = ArV(RA, 0)
                PNX = proN
                If My.Settings.CHECK_BENEFIT_PS = True Then
                    If C < 0 Then
                        MsgBox("CURRENT MOVIE [" & PNX & "] SOLD PRICE IS LESS THAN PURCHASE COST." & "CHECK YOURSELF.", MsgBoxStyle.Critical, "SOLD PRICE IS LESS THAN PURCHASE COST<LOSS>")
                        GOTOPOS_PS(PS)
                        Exit Function
                    End If
                    If C = 1 Then
                        MsgBox("CURRENT MOVIE [" & PNX & "] SOLD PRICE IS SO CHEAP, BENEFIT IS ONLY ONE TAKA,CHECK YOUR SELF.", MsgBoxStyle.Critical, "SOLD PRICE IS CHEAP,LOW BENEFIT ONLY ONE TAKA.")
                        GOTOPOS_PS(PS)
                        Exit Function
                    End If
                    If C = 0 Then
                        MsgBox("CURRENT MOVIE [" & PNX & "] SOLD PRICE IS SO CHEAP, THERE IS NO BENEFIT,CHECK YOUR SELF.", MsgBoxStyle.Critical, "SOLD PRICE IS CHEAP,NO BENEFIT")
                        GOTOPOS_PS(PS)
                        Exit Function
                    End If
                End If
                RowX = Me.AukDatabaseDataSet.PS_SOLD.NewRow
                RowX(0) = soldID
                RowX(1) = "MOVIESOLD"  'MOVIE TYPE,dISPLAY ID
                RowX(2) = ArV(RA, 0) 'DVD ID
                RowX(3) = cLIENT 'CLIENT
                RowX(4) = proN 'MOVIE NAME
                RowX(5) = Val(PCOST) 'PUR COST
                RowX(6) = Val(BPR) 'BENEFIT COST
                RowX(7) = Val(ArV(RA, 11)) 'DISCOUNT
                RowX(8) = BenefitC 'BENEFIT
                RowX(9) = CDate(Now.Date.Date)   'SOLD DATE
                RowX(10) = 0 'WANRRETY
                RowX(11) = RpID 'REP ID
                RowX(12) = ArV(RA, 2) 'movie version in information
                RowX(13) = Val(DisId) 'MOVIE TYPE IN MOVIE TYPE
                Me.AukDatabaseDataSet.Product_Collection(cmRow).Place = "Sold"
                Me.AukDatabaseDataSet.Product_Collection(cmRow).EndEdit()
                Me.AukDatabaseDataSet.PS_SOLD.Rows.Add(RowX)
                CHG_RP()
            Else
                ADDLST = False
            End If
        Else
            ADDLST = False
            Me.DVDID_TOOLLOADTEXTBOX.Focus()
        End If
    End Function

    Public Function GOTOPOS_PS(ByVal SID As String)
        AukF.BindFind(Me.PSSOLDBindingSource, "PRODUCT_SERIAL", SID, True)
    End Function

    Private Sub Label5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseDown
        AukF.DragAuk(Me)
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
    'Public Function MDETAILS(Optional ByVal ID As String = "", Optional ByVal F As Boolean = False)
    '    If F = False Then
    '        Me.PictureBox2.Image = My.Resources.Small_imgs.AukWrong
    '        Me.Label9.Text = "MOVIE [" & ID & "] IS NOT FOUND IN YOUR DATABASE."
    '    Else
    '        Me.PictureBox2.Image = My.Resources.Small_imgs.AukRight
    '        Me.Label9.Text = "MOVIE [" & ID & "] IS FOUND IN YOUR DATABASE."
    '    End If
    'End Function

    Private Sub FIND_DVDID(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown, DVDID_TOOLLOADTEXTBOX.KeyDown
        If e.KeyCode = Keys.Enter Then
            SFC("DVD_ID")
            STC(sender.TEXT)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.Product_Collection, "*", "", False, 0, "", False, 0, 1)
            If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Product_Collection, sender.text) = True Then
                'RowX = Me.AukDatabaseDataSet.Product_Collection(0)
                PLACE = UCase(CStr(RowX(6)))
                DVDID = UCase(CStr(RowX(0)))
                Me.DVDID_TOOLLOADTEXTBOX.BackColor = Color.White
                Me.DVDID_TOOLLOADTEXTBOX.ForeColor = Color.Black
                If PLACE = "INSTORE" Then
                    Me.ADDLST(sender.TEXT)
                Else
                    MsgBox("MOVIE [" & DVDID & "] IS FOUND BUT ITS PLACE " & PLACE, MsgBoxStyle.Information)
                End If
            Else
                Me.DVDID_TOOLLOADTEXTBOX.BackColor = Color.Red
                Me.DVDID_TOOLLOADTEXTBOX.ForeColor = Color.White
            End If
        End If
        If e.KeyCode = Keys.Enter And e.Modifiers = Keys.Control Then
            SOLDToolStripMenuItem_Click(sender, e)

        End If
    End Sub
    'Public Function FindB(ByVal DVDID As String, Optional ByVal GotoP As Boolean = False) As Boolean
    '    FindB = AukF.BindFind(Me.SOLDVIEW_BindingSource1, "DVD ID", DVDID, GotoP)
    'End Function
    'Public Function FindB_N(ByVal MName As String, Optional ByVal GotoP As Boolean = False) As Boolean
    '    FindB_N = AukF.BindFind(Me.SOLDVIEW_BindingSource1, "Name", MName, GotoP)
    'End Function
    'Public Function FindI(ByVal DVDID As String, Optional ByVal GotoP As Boolean = False) As Boolean
    '    FindI = ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.SOLD_VIEW, DVDID)
    '    Try
    '        If GotoP = True Then
    '            Me.SOLDVIEW_BindingSource1.Position = ComRow
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Function
    Public Function VIEW_BY_REPORT_ID(ByVal REPORTID As String)
        SFC("REPORT_ID")
        STC(REPORTID)
        AukF.Db_LoadN(Me.RP_IDBindingSource)
        'MsgBox(Me.RP_IDBindingSource.Count)
        If Me.RP_IDBindingSource.Count <> 1 Then
            MsgBox("No Invoice serial is correctly found.", MsgBoxStyle.Critical)
            Exit Function
        Else
            SFC("REPORT_ID")
            STC(REPORTID)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SOLD)
            Me.DVDID_TOOLLOADTEXTBOX.Focus()
            If Me.AukDatabaseDataSet.PS_SOLD.Rows.Count > 0 Then
                cLIENT = Me.AukDatabaseDataSet.PS_SOLD(0).Item("CLIENT_NAME").ToString.ToUpper
                'GS = True
                FrmL(Me)
                Me.ToolStripTextBox1.Text = cLIENT
            End If
        End If
    End Function
    Private Sub MOVE_FIND(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        Dim dV As DataView = Me.AukDatabaseDataSet.Product_Collection.DefaultView
        Dim rDV As DataRowView
        dV.Sort = "MOVIE_NAME"
        If e.KeyCode = Keys.Enter Then
            SFC("MOVIE_NAME")
            STC(sender.TEXT)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.Product_Collection, "*", "", False, 0,"", False, 0, 1)
            ComRow = dV.Find(sender.TEXT)
            If ComRow > -1 Then
                'RowX = Me.AukDatabaseDataSet.Product_Collection(0)
                rDV = dV.Item(ComRow)
                PLACE = UCase(CStr(rDV(6)))
                DVDID = UCase(CStr(rDV(0)))
                sender.BackColor = Color.White
                sender.ForeColor = Color.Black
                If PLACE = "INSTORE" Then
                    Me.ADDLST(DVDID)
                Else
                    MsgBox("MOVIE [" & DVDID & "] IS FOUND BUT ITS PLACE " & PLACE, MsgBoxStyle.Information)
                End If
            Else
                sender.BackColor = Color.Red
                sender.ForeColor = Color.White
            End If
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmL(MSOLD_SET)
    End Sub
    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
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
                DQA = CDate(ArV(A, 1))
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
                STC(sender.TEXT)
                AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CLIENTS)
                If Me.AukDatabaseDataSet.PS_CLIENTS.Rows.Count = 1 Then
                    cLIENT = Me.AukDatabaseDataSet.PS_CLIENTS(0).CLIENT_NAME.ToString
                    GS = True
                Else
                    A = Me.ToolStripTextBox1.Text.Split(";")
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
    Public Sub CHG_RP()
        On Error Resume Next

        'MsgBox(Val(Me.AukDatabaseDataSet.PS_SOLD.Compute("SUM(DISCOUNT)", "")), , Val(Me.AukDatabaseDataSet.PS_SOLD.Compute("SUM(SOLD_PRICE)", "")))
        'MsgBox(Val(Me.AukDatabaseDataSet.PS_SOLD.Compute("SUM(SOLD_PRICE)", "CLIENT_NAME='" & cLIENT & "'")))
        TDISCOUNT = Val(Me.AukDatabaseDataSet.PS_SOLD.Compute("SUM(DISCOUNT)", "DISCOUNT IS NOT NULL")) + Val(Me.DISCOUNT_TEXTBOX.Text)
        Me.TOTAL_AMOUNNTTextBox.Text = Val(Me.AukDatabaseDataSet.PS_SOLD.Compute("SUM(SOLD_PRICE)", "")) - Val(TDISCOUNT)
        If Me.AukDatabaseDataSet.RP_ID.Rows.Count = 1 Then
            Me.AukDatabaseDataSet.RP_ID(0).TOTAL_AMOUNNT = Me.TOTAL_AMOUNNTTextBox.Text
            Me.AukDatabaseDataSet.RP_ID(0).TOTAL_DISCOUNT = Me.DISCOUNT_TEXTBOX.Text
            Me.Validate()
            Me.RP_IDBindingSource.EndEdit()
        End If
    End Sub
    Public Sub SELL()
        If GS = True Then
            Me.DataGridView1.DataSource = Me.PSSOLDBindingSource
            RpID = Replace(SrGens.Convert_Hash(cLIENT & Now.Date.ToLongDateString), "\", "")
            RpID = RpID.Replace(CChar("/@$%&*!\+"), "")
            'RpID = RpID.Replace("+", "")
            If RpID.Length < 12 Then
                RpID = RpID & SrGens.Convert_Hash(cLIENT).Replace(CChar("/@$%&*!\+"), "")
            End If
            RpID = Mid(RpID, 1, 12).ToUpper
            RpID = "INV-" & Now.Month & "-" & RpID
            SFC("REPORT_ID")
            STC(RpID)
            AukF.Db_LoadN(Me.RP_IDBindingSource)
            SFC("REPORT_ID")
            STC(RpID)
            AukF.Db_LoadN(Me.PSSOLDBindingSource)
            If Me.AukDatabaseDataSet.RP_ID.Rows.Count = 0 Then
                Me.RP_IDTableAdapter.Insert(RpID, 0, 0, 0, 0, "CASH(DVD SOLD)", Me.AukDatabaseDataSet.PS_Employe(0).Employe_Name.ToString, CDate(Now.Date))
                SFC("REPORT_ID")
                STC(RpID)
                AukF.Db_LoadN(Me.RP_IDBindingSource)
                If Me.AukDatabaseDataSet.RP_ID.Rows.Count <> 1 Then
                    MsgBox("CONTACT WITH AUK ERROR IN INSERT REPORT ID,WHICH IS IMPOSSIBLE.", MsgBoxStyle.Critical)
                End If
            End If
            Me.DISCOUNT_TEXTBOX.Text = Val(Me.AukDatabaseDataSet.RP_ID(0).TOTAL_DISCOUNT.ToString)
            CHG_RP()
            Me.DVDID_TOOLLOADTEXTBOX.Focus()
        Else
            RpID = ""
            Me.DataGridView1.DataSource = Nothing
        End If
    End Sub


    Private Sub SEARCHQUERYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHQUERYToolStripMenuItem.Click
        DVDRENT.ShowQr_Product(Me.DataGridView1, Me.PSSOLDBindingSource, "([DISPLAY_ID] = '" & "MOVIESOLD" & "')")
    End Sub
    Public Function SOLD()
        'DIM R AS DataRow 
        Dim C As Decimal
        Me.Validate()
        'MsgBox(Me.ComboBox4.Text & Len(Me.ComboBox4.Text), , Me.AukDatabaseDataSet.RP_ID.Columns("PREPARED_BY").MaxLength)
        Me.CHG_RP()

        Me.AukDatabaseDataSet.RP_ID(0).PREPARED_BY = Me.ComboBox4.Text
        Me.AukDatabaseDataSet.RP_ID(0).TOTAL_DISCOUNT = Me.DISCOUNT_TEXTBOX.Text
        Try
            Me.PSSOLDBindingSource.EndEdit()
            Me.RP_IDBindingSource.EndEdit()
            Me.RP_IDTableAdapter.Update(Me.AukDatabaseDataSet.RP_ID)
            CHG_RP()
            For K As Integer = (Me.DataGridView1.RowCount - 1) To 0 Step -1
                PS = AukF.GridT(Me.DataGridView1, 1, K, "") 'DVD ID
                PNX = AukF.GridT(Me.DataGridView1, 2, K, "") 'MOVIE NAME
                C = AukF.GridT(Me.DataGridView1, 7, K, 0) 'BENEFITS
                'MsgBox(PS & vbCrLf & PNX & vbCrLf & C)
                'S = S - D : C = S - P
                If My.Settings.CHECK_BENEFIT_PS = True Then
                    If C < 0 Then
                        MsgBox("CURRENT MOVIE [" & PNX & "] SOLD PRICE IS LESS THAN PURCHASE COST." & "CHECK YOURSELF.", MsgBoxStyle.Critical, "SOLD PRICE IS LESS THAN PURCHASE COST<LOSS>")
                        GOTOPOS_PS(PS)
                        Exit Function
                    End If
                    If C = 1 Then
                        MsgBox("CURRENT MOVIE [" & PNX & "] SOLD PRICE IS SO CHEAP, BENEFIT IS ONLY ONE TAKA,CHECK YOUR SELF.", MsgBoxStyle.Critical, "SOLD PRICE IS CHEAP,LOW BENEFIT ONLY ONE TAKA.")
                        GOTOPOS_PS(PS)
                        Exit Function
                    End If
                    If C = 0 Then
                        MsgBox("CURRENT MOVIE [" & PNX & "] SOLD PRICE IS SO CHEAP, THERE IS NO BENEFIT,CHECK YOUR SELF.", MsgBoxStyle.Critical, "SOLD PRICE IS CHEAP,NO BENEFIT")
                        GOTOPOS_PS(PS)
                        Exit Function
                    End If
                End If
                'MsgBox(PS)
                If My.Settings.DEL_SOLD_PS = True Then
                    If ADSRC.FIND_FROM_DATATABLE(Me.AukDatabaseDataSet.Product_Collection, PS) IsNot Nothing Then
                        'MsgBox(RowX.Item(1))
                        RowX.Delete()
                        RowX.EndEdit()
                    End If
                End If
            Next
            Me.PSSOLDBindingSource.EndEdit()
            Me.PS_SOLDTableAdapter1.Update(Me.AukDatabaseDataSet.PS_SOLD)
            Me.Product_CollectionTableAdapter1.Update(Me.AukDatabaseDataSet.Product_Collection)
            Me.AukDatabaseDataSet.Product_Collection.Clear()
            GS = False
            My.Settings.Save()
            If My.Settings.AFTER_SOLD_PRINT_PS = True Then SPRNT(False)
        Catch ex As Exception
            Epx()
        End Try
        If My.Settings.AFTER_SOLD_PRINT_PS = False Then Me.AukDatabaseDataSet.PS_SOLD.Clear() : Me.AukDatabaseDataSet.RP_ID.Clear()
    End Function
    Public Sub SPRNT_MEMOS(Optional ByVal MEMO As Boolean = True)
        Dim M As New Object
        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim iO As CrystalDecisions.CrystalReports.Engine.FieldObject
        Me.CHG_RP()

        If MEMO = True Then
            M = New MSOLD_MEMO_RP
            iO = M.ReportDefinition.ReportObjects("ComName")
            iO.ObjectFormat.EnableSuppress = Not My.Settings.SHOW_COMPANYN_PS_R
            T = M.ReportDefinition.ReportObjects("inV")
            T.Text = My.Settings.TITLE_INVOICE_PS.ToString
            If My.Settings.COM_ADDRESS.ToString.Trim = "" Then
                M.ReportDefinition.Sections(9).SectionFormat.EnableSuppress = True
            Else
                M.ReportDefinition.Sections(9).SectionFormat.EnableSuppress = False
                T = M.ReportDefinition.ReportObjects("ADDRESS_")
                T.Text = My.Settings.COM_ADDRESS.ToString.Trim
            End If
        Else
            M = New SoldReport
            If My.Settings.COM_ADDRESS.ToString.Trim = "" Then
                M.ReportDefinition.Sections(1).SectionFormat.EnableSuppress = True
            Else
                M.ReportDefinition.Sections(1).SectionFormat.EnableSuppress = False
                T = M.ReportDefinition.ReportObjects("ADDRESS_")
                T.Text = My.Settings.COM_ADDRESS.ToString.Trim
            End If
            M.ReportDefinition.Sections(1).SectionFormat.EnableSuppress = Not My.Settings.SHOW_COMPANYN_PS_R
        End If

        AukF.Prnt(M, Me.AukDatabaseDataSet)
 
    End Sub
    Public Sub SPRNT(Optional ByVal show_rp As Boolean = True)
        Dim M As New Object
        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim iO As CrystalDecisions.CrystalReports.Engine.FieldObject
        Me.CHG_RP()

        If My.Settings.REPORT_AS_MEMO_MSOLD = True Then
            M = New MSOLD_MEMO_RP
            iO = M.ReportDefinition.ReportObjects("ComName")
            iO.ObjectFormat.EnableSuppress = Not My.Settings.SHOW_COMPANYN_PS_R
            T = M.ReportDefinition.ReportObjects("inV")
            T.Text = My.Settings.TITLE_INVOICE_PS.ToString
            If My.Settings.COM_ADDRESS.ToString.Trim = "" Then
                M.ReportDefinition.Sections(9).SectionFormat.EnableSuppress = True
            Else
                M.ReportDefinition.Sections(9).SectionFormat.EnableSuppress = False
                T = M.ReportDefinition.ReportObjects("ADDRESS_")
                T.Text = My.Settings.COM_ADDRESS.ToString.Trim
            End If
        Else
            M = New SoldReport
            If My.Settings.COM_ADDRESS.ToString.Trim = "" Then
                M.ReportDefinition.Sections(1).SectionFormat.EnableSuppress = True
            Else
                M.ReportDefinition.Sections(1).SectionFormat.EnableSuppress = False
                T = M.ReportDefinition.ReportObjects("ADDRESS_")
                T.Text = My.Settings.COM_ADDRESS.ToString.Trim
            End If
            M.ReportDefinition.Sections(1).SectionFormat.EnableSuppress = Not My.Settings.SHOW_COMPANYN_PS_R
        End If
        If show_rp = True Then
            AukF.Prnt(M, Me.AukDatabaseDataSet)
        Else
            Reports.CrystalReportViewer1.ReportSource = M
            M.Database.Tables(0).SetDataSource(Me.AukDatabaseDataSet)
            Reports.CrystalReportViewer1.PrintReport()
            Me.AukDatabaseDataSet.PS_SOLD.Clear()
            Me.AukDatabaseDataSet.RP_ID.Clear()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If GS = True Then
            Me.ToolStripTextBox1.BackColor = Color.Black
            ToolStripTextBox1.ForeColor = Color.White
        ElseIf GS = False Then
            Me.ToolStripTextBox1.BackColor = Color.White
            ToolStripTextBox1.ForeColor = Color.Black
        End If
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DataGridView1, My.Settings.BENEFIT_SHOW_PS, 7)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DataGridView1, My.Settings.PURCHASE_SHOW_PS, 4)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DataGridView1, My.Settings.CLIENT_NAME_SHOW_PS, 3)
        DVDRENT.SET_READONLY_COLUMN (Me.DataGridView1, My.Settings.PURCHASE_RO_PS , 4)
    End Sub
    Private Sub ToolStripTextBox3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox3.KeyDown
        Dim DvdS As String = "MOVIESOLD"
        If e.KeyCode = Keys.Enter Then
            If GS = False Then
                BSql = SoftIn.GetFunction_QrText(Me.AukDatabaseDataSet.PS_SOLD, Me.DataGridView1.Columns(Me.FILTERCOMBO.SelectedIndex).DataPropertyName.ToUpper, sender.text, 0)
                If BSql <> "" Then
                    BSql &= " AND ([DISPLAY_ID] = '" & DvdS & "')"
                End If
                AukF.Db_LoadQ(Me.AukDatabaseDataSet.PS_SOLD, BSql, "*", False, "PRODUCT_SERIAL", False, -1, 1000)
            Else
                MsgBox("PLEASE LET THE CLIENT OFF", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim P, S, D, B As Decimal
        P = AukF.GridT(sender, 4, -1, 0) 'PURCHASE
        S = AukF.GridT(sender, 5, -1, 0) 'SOLD PR
        D = AukF.GridT(sender, 6, -1, 0) 'DISCOUNT
        'B = AukF.GridT(sender,, 8, 0)
        PS = AukF.GridT(sender, 2, -1, "")
        S = S - D
        B = S - P 'BENEFIT
        'MsgBox(P, , S)
        sender(7, e.RowIndex).VALUE = B
        If My.Settings.CHECK_BENEFIT_PS = True Then
            If B < 0 Then
                MsgBox("CURRENT MOVIE [" & PS & "] SOLD PRICE IS LESS THAN PURCHASE COST." & "CHECK YOURSELF.", MsgBoxStyle.Critical, "SOLD PRICE IS LESS THAN PURCHASE COST<LOSS>")
            End If
            If B = 1 Then
                MsgBox("CURRENT MOVIE [" & PS & "] SOLD PRICE IS SO CHEAP, BENEFIT IS ONLY ONE TAKA,CHECK YOUR SELF.", MsgBoxStyle.Critical, "SOLD PRICE IS CHEAP,LOW BENEFIT ONLY ONE TAKA.")
            End If
            If B = 0 Then
                MsgBox("CURRENT MOVIE [" & PS & "] SOLD PRICE IS SO CHEAP, THERE IS NO BENEFIT,CHECK YOUR SELF.", MsgBoxStyle.Critical, "SOLD PRICE IS CHEAP,NO BENEFIT")
            End If
        End If
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.ButtonClick
        Me.SPRNT(True)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FrmL(MSOLD_SET)

    End Sub
    Private Sub SOLDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOLDToolStripMenuItem.Click, ToolStripButton1.ButtonClick
        If My.Settings.BEFORE_SOLD_MSG_PS = True Then
            If AukF.MsgTrU("SOLD THIS MOVIES TO CURRENT CLIENT(" & cLIENT & ")?", True) = False Then Exit Sub
        End If
        If GS = True Then SOLD() Else MsgBox("FIRST LOAD A CLIENT AND SELECT PRODUCTS THEN CLICK ON SOLD.", MsgBoxStyle.Critical) : Me.ToolStripTextBox1.Focus()
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.ButtonClick
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
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        FrmL(MVIEWS)
    End Sub
    Private Sub REFRESHCURRENTITEMENTRYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHCURRENTITEMENTRYToolStripMenuItem.Click
        dvdid = CStr(Me.DataGridView1(0, Me.PSSOLDBindingSource.Position).Value)
        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Product_Collection, dvdid) = True Then
            AukF.Single_DataRecordRefresh(Me.AukDatabaseDataSet.Product_Collection, ComRow)
        End If
        AukF.Single_DataRecordRefresh(Me.PSSOLDBindingSource)
    End Sub
    Private Sub CANCELSOLDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELSOLDToolStripMenuItem.Click
        If GS = True Then
            If AukF.MsgTr("CANCEL CURRENT CLIENT ALL BROWSE MOVIES?", True) = True Then
                Me.AukDatabaseDataSet.PS_SOLD.Clear()
                Me.AukDatabaseDataSet.RP_ID.Clear()
                GS = False
            End If
        Else
            Me.AukDatabaseDataSet.PS_SOLD.Clear()
            Me.AukDatabaseDataSet.RP_ID.Clear()
        End If
    End Sub
    Private Sub ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem.Click
        Me.DVDID_TOOLLOADTEXTBOX.Focus()
    End Sub
    Private Sub CLIENTNAMEFOUCSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTNAMEFOUCSToolStripMenuItem.Click
        Me.ToolStripTextBox1.Focus()
    End Sub
    Private Sub DISCOUNT_TEXTBOX_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISCOUNT_TEXTBOX.TextChanged
        Me.CHG_RP()
    End Sub

    Private Sub GOTOCLIENTDATABASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GOTOCLIENTDATABASToolStripMenuItem.Click
        PS_CLIENT.DVD_I = True
        FrmL(PS_CLIENT)
    End Sub

    Private Sub DVDID_TOOLLOADTEXTBOX_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DVDID_TOOLLOADTEXTBOX.TextChanged
        If AukF.BindFind(Me.PSSOLDBindingSource, "PRODUCT_SERIAL", sender.TEXT, True) = True Then
            Me.DataGridView1.Rows(ComRow).Selected = True
        End If
    End Sub
    Public Function Open_dvd(ByVal DVDid As String) As Boolean
        Product_Input3.Hook = True
        With Product_Input3
            If DVDid <> "" Then
                If AukF.BindFind(.Product_CollectionBindingSource, "dvd_id", DVDid, True) = False Then
                    SFC("DVD_ID")
                    STC(DVDid)
                    AukF.Db_LoadN(.Product_CollectionBindingSource, -1, "", False)
                    'MsgBox(Sql)
                    If AukF.BindFind(.Product_CollectionBindingSource, "dvd_id", DVDid, True) = True Then
                        Open_dvd = True
                        FrmL(Product_Input3)
                        Exit Function
                    Else
                        Open_dvd = False
                    End If
                End If
            End If
        End With
        Open_dvd = False
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmL(Product_Input3)
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        If My.Settings.DEL_SOLD_PS = False Then
            dvdid = AukF.GridT(Me.DataGridView1, 1)
            If Open_dvd(dvdid) = False Then
                GoTo OPENVIEW
            End If
        Else
            GoTo OPENVIEW
        End If
        Exit Sub
OPENVIEW: MOVIES_VIEWS.Load_(AukF.GridT(Me.DataGridView1, 9), AukF.GridT(Me.DataGridView1, 0))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmL(ps_employees)
    End Sub
    Private Sub SUMMARYFORMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUMMARYFORMToolStripMenuItem.Click
        FrmL(MOVIES_VIEWS)
    End Sub

    Private Sub TODAYSBENEFITVIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TODAYSBENEFITVIEWToolStripMenuItem.Click
        MOVIES_VIEWS.TODAYS_RP_SHOW_PRINT()
    End Sub
    Private Sub HideMovieSoldFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideMovieSoldFormToolStripMenuItem.Click, Button3.Click
        Me.Hide()
    End Sub
    Private Sub PRINT_MEMOS_RPT(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRINTASSERIALToolStripMenuItem.Click, PRINTASMEMOToolStripMenuItem.Click
        SPRNT_MEMOS(CBool(sender.TAG.ToString))
    End Sub
End Class