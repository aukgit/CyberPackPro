Public Class Cyber
    Dim CyMem As New AukDatabaseDataSet.Cyber_MemberDataTable
    Dim Bp As New BindingSource
    Public ScanP As Double
    Public PrintC As Double
    Public PrintB As Double
    Public WriteDVD As Double
    Public WriteCD As Double
    Dim uW, uP As Array
    Dim Dqa As Date
    Dim Wr, Pr, DTOTAL As String
    Dim PRate As Double
    Dim MnCos As Double = Val(My.Settings.CyberMinCost.ToString)
    Dim DVDPR, CDPR, PRB, PRC, TOTAL As Double
    Dim Msgx As String
    'Friend DV As DataGridView = Me.Cyber_BusinessDataGridView
    Private Sub Cyber_BusinessBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cyber_BusinessBindingNavigatorSaveItem.Click, ToolStripMenuItem1.Click
        Try
            Me.Validate()
            Me.Cyber_BusinessBindingSource.EndEdit()
            Me.Cyber_BusinessTableAdapter.Update(Me.AukDatabaseDataSet.Cyber_Business)
        Catch ex As Exception
            Epx()
        End Try
    End Sub
    Public Sub Save_cyber()
        Try
            Me.Cyber_BusinessBindingSource.EndEdit()
            Me.Cyber_BusinessTableAdapter.Update(Me.AukDatabaseDataSet.Cyber_Business)
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub Cyber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Cyber_Business' table. You can move, or remove it, as needed.
        'Me.Cyber_BusinessTableAdapter.Fill(Me.AukDatabaseDataSet.Cyber_Business)
        Me.Timer1.Enabled = False
        If TVer = True Then
            Msgx = "In trail version of CyberPack Pro you are not suppose to run this ""Cyber Cafe Monitoring@CyberPack Pro"" [Form] more than 300 minutes.If you want to buy please contact with the developer [01913 50863],0167 01013907,01711 334201(onRequest)"
            Dim P, N As Decimal
            'MsgBox(P, , CStr(My.Settings.CyberLastDate))
            If CStr(My.Settings.CyberLastDate) = "" Or CStr(My.Settings.CyberLastDate) = "12:00:00 AM" Then
                My.Settings.CyberLastDate = Now
            End If
            P = DateDiff(DateInterval.Minute, My.Settings.CyberLastDate, Now)
            N = DateAndTime.DateDiff(DateInterval.Day, My.Settings.CyberLastDate, Now)
            'MsgBox(P, , My.Settings.CyberLastDate.ToString & N)
            If P < 0 Then P = P * -1

            If N < 0 Then
                SrGens.Make_Corrupt(1)
                SOFTCLOSE()
                Exit Sub
            ElseIf N <= TestDays And N > 0 Then
                My.Settings.CyberLastDate = Now
                P = 0
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
        End If
        Me.Timer1.Enabled = True
nextwork: Dim OPc As New AukDatabaseDataSetTableAdapters.Cyber_PCIDTableAdapter
        OPc.Fill(Me.AukDatabaseDataSet.Cyber_PCID)
        AukF.Auk_ListObject_DataTable_DataType(Me.ColName, Me.Cyber_BusinessBindingSource, "0")
        Me.OptionsTableAdapter1.Fill(Me.AukDatabaseDataSet.Options)
        Bp.DataSource = CyMem
        'MsgBox(Bp.Count)
        ColName.SelectedIndex = 2
        ScanP = Val(My.Settings.Scaning.ToString)
        PrintC = Val(My.Settings.PagePrintCyber.ToString.Split(",").GetValue(1))
        PrintB = Val(My.Settings.PagePrintCyber.ToString.Split(",").GetValue(0))
        WriteDVD = Val(My.Settings.Write_Cyber.ToString.Split(",").GetValue(1))
        WriteCD = Val(My.Settings.Write_Cyber.ToString.Split(",").GetValue(0))
        Me.DATE_BUSI.Text = Now.Date
        ToolStripLabel1_Click(sender, e)
        Me.AukDatabaseDataSet.Cyber_Member.DefaultView.Sort = "Cyber_MemberID Asc"
        AukF.ComSelIndex(ToolStripComboBox1)
        WHENLOADAMEMBERSHOWAMSGToolStripMenuItem.Checked = My.Settings.NEW_CYBER_MSG

        'Me.PC_ID_List.Items.re()
        'AukF.AukOptionsOfDataGrid(Me.Cyber_BusinessDataGridView, "", "3,4,5,6,10,13")

        'IF CYBERCAFE=
    End Sub

    Private Sub Cyber_BusinessDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Cyber_BusinessDataGridView.CellClick
        On Error Resume Next
        If Me.Cyber_BusinessDataGridView.CurrentCell.RowIndex = -1 Then Exit Sub
        If Me.Cyber_BusinessDataGridView.NewRowIndex = Me.Cyber_BusinessDataGridView.CurrentCell.RowIndex Then Exit Sub
        nma = AukF.GridT(Me.Cyber_BusinessDataGridView, 2)
        If AukF.BindFind(Bp, "Cyber_MemberID", nma) = True Then
            'MsgBox(nma)
            Me.MemName.Text = "MemberName : [" & CyMem.Rows(ComRow).Item(1).ToString & "]"
        Else
            Me.MemName.Text = ""
        End If
    End Sub
    Private Sub D_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DATE_BUSI.KeyDown
        If e.KeyCode = Keys.Enter Then
            'D_txt.validate()
            Load_DB(sender.text)
        End If
    End Sub
    Public Function Load_DB(ByVal datex As String)
        Try
            If datex = "" Then datex = Now.Date : DATE_BUSI.Text = Now.Date
            If datex <> "" Then
                Dqa = CDate(datex)
                DATE_BUSI.Enabled = False
                SFC("Date_of_Business")
                sm = Dqa
                STC(sm)
                DTC("d")
                AukF.Db_LoadN(Me.AukDatabaseDataSet.Cyber_Business, -1, "", True, 0, "pc_id")
                'MsgBox(Sql)
                Me.Cyber_BusinessDataGridView.Focus()
                Me.Cyber_BusinessDataGridView.AllowUserToAddRows = True
            Else
                Me.AukDatabaseDataSet.Cyber_Business.Clear()
                Me.Cyber_BusinessBindingSource.RemoveFilter()
                'SoftIn.BindFilterByAdvanceCategory(Me.Cyber_BusinessBindingSource, "date_of_business", "1/1/1011", True, False, False, "=", False)
                'AukF.DataSetFilter(Me.Cyber_BusinessBindingSource, True, False, True, False)
                DATE_BUSI.Enabled = True
                Me.Cyber_BusinessDataGridView.AllowUserToAddRows = False
                Me.DATE_BUSI.Focus()
            End If
        Catch ex As Exception
            DATE_BUSI.Focus()
            MsgBox("Please Type a Vaild Date...", MsgBoxStyle.Critical)
        End Try
    End Function

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        If DATE_BUSI.Enabled = False Then
            If SoftIn.GetChages(Me.Cyber_BusinessBindingSource) = True Then
                Cyber_BusinessBindingNavigatorSaveItem_Click(sender, e)
            End If
            DATE_BUSI.Enabled = True
            DATE_BUSI.Focus()
        Else
            Load_DB(Me.DATE_BUSI.Text)
        End If
    End Sub
    Private Sub RefreshCurrentItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshCurrentItemToolStripMenuItem.Click, ToolStripButton3.ButtonClick
        AukF.Single_DataRecordRefresh(Me.Cyber_BusinessBindingSource, True)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.Cyber_BusinessBindingSource, True)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DATE_BUSI.Enabled = True Then
            If Me.Cyber_BusinessDataGridView.ReadOnly = False Then Me.Cyber_BusinessDataGridView.ReadOnly = True
        Else
            If Me.Cyber_BusinessDataGridView.ReadOnly = True Then Me.Cyber_BusinessDataGridView.ReadOnly = False
        End If
        'ToolStripLabel4.Text = Format((Val(Me.ToolStripTextBox2.Text) / 60), "0.##")

    End Sub

    Private Sub Cyber_BusinessDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Cyber_BusinessDataGridView.CellEndEdit
        Dim Wr, Pr, nMA As String
        'Dim D1 As Date
        'Dim SENDER As DataGridView = SENDER
        SoftIn.Master_ID_String(sender, 7)
        'On Error Resume Next
        If e.ColumnIndex = 12 Then
            GetTotalPaymentOrCurrentTimeToolStripMenuItem_Click(sender, e)
        End If
        'D1 = CDate(Me.D_txt.Text)
        If AukF.GridT(sender, 6) = "" Then
            sender(6, e.RowIndex).Value = Dqa
        End If
        If AukF.GridT(sender, 1) = "" Then
            Dim Beint As Integer = DRow - 1
            If Beint > -1 Then
                SBE = AukF.GridT(sender, 1, Beint)
            Else
                If Me.AukDatabaseDataSet.Cyber_PCID.Rows.Count > 0 Then
                    sender(1, DRow).Value = Me.AukDatabaseDataSet.Cyber_PCID(0).PC_ID
                End If
            End If
            If SBE IsNot Nothing Or SBE <> "" Then
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Cyber_PCID, SBE) = True Then
                    Beint = ComRow + 1
                    If Beint >= (Me.AukDatabaseDataSet.Cyber_PCID.Rows.Count - 1) Then
                        sender(1, DRow).Value = Me.AukDatabaseDataSet.Cyber_PCID(0).PC_ID
                    Else
                        sender(1, DRow).Value = Me.AukDatabaseDataSet.Cyber_PCID(Beint).PC_ID
                    End If
                Else
                    If Me.AukDatabaseDataSet.Cyber_PCID.Rows.Count > 0 Then
                        sender(1, DRow).Value = Me.AukDatabaseDataSet.Cyber_PCID(0).PC_ID
                    End If
                End If

            End If
        End If
        'If e.ColumnIndex = 3 Then
        If AukF.GridT(sender, 3) = "" Then
            If sender.CurrentCell.RowIndex > -1 Then sender(3, e.RowIndex).Value = CStr(TimeOfDay)
        End If
        'End If
        If My.Settings.DIRECT_SAVE = True Then Save_cyber()
    End Sub


    Private Sub OpenDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDataToolStripMenuItem.Click
        Try
            AukF.BindFilter_BetweenOparetorN(Me.Cyber_BusinessBindingSource, "Date_of_business", Me.ToolStripTextBox4.Text, Me.ToolStripTextBox5.Text)
        Catch ex As Exception
            Epx()
        End Try

    End Sub

    Private Sub OpenExactwordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenExactwordToolStripMenuItem.Click
        Try
            SFC("Costomer_Name")
            STC(ToolStripTextBox3.Text)
            AukF.Db_Load("*", "Cyber_business", Me.Cyber_BusinessBindingSource, False)
            SoftIn.SqlToFiler_BindingSource(Me.Cyber_BusinessBindingSource, Sql)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub OpenExactFromFirstToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenExactFromFirstToolStripMenuItem.Click
        Try
            SFC("Costomer_Name")
            STC(ToolStripTextBox3.Text)
            AukF.Db_Load("*", "Cyber_business", Me.Cyber_BusinessBindingSource, False, "", True, True)
            SoftIn.SqlToFiler_BindingSource(Me.Cyber_BusinessBindingSource, Sql)
        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub OpenAnywhereInFieldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAnywhereInFieldToolStripMenuItem.Click
        Try
            SFC("Costomer_Name")
            STC(ToolStripTextBox3.Text)
            'LKC(1)
            AukF.Db_Load("*", "Cyber_business", Me.Cyber_BusinessBindingSource, False, "", True)
            SoftIn.SqlToFiler_BindingSource(Me.Cyber_BusinessBindingSource, Sql)

        Catch ex As Exception
            Epx()
        End Try
    End Sub
    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Cyber_BusinessBindingSource.RemoveFilter()
    End Sub
    Private Sub FilterAnyWhereInFieldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterAnyWhereInFieldToolStripMenuItem.Click
        AukF.ComSelIndex(ColName)
        SoftIn.BindFilterByAdvanceCategory(Me.Cyber_BusinessBindingSource, ColName.Text, ToolStripTextBox1.Text, False, False, True, "=", False)
    End Sub
    Private Sub ExactFromFirstToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExactFromFirstToolStripMenuItem.Click
        AukF.ComSelIndex(ColName)
        SoftIn.BindFilterByAdvanceCategory(Me.Cyber_BusinessBindingSource, ColName.Text, ToolStripTextBox1.Text, False, True, False, "=", False)
    End Sub

    Private Sub ExtactWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtactWordToolStripMenuItem.Click
        AukF.ComSelIndex(ColName)
        SoftIn.BindFilterByAdvanceCategory(Me.Cyber_BusinessBindingSource, ColName.Text, ToolStripTextBox1.Text, True, False, False, "=", False)
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        My.Settings.Cyber_per_hourRate = ToolStripTextBox2.Text
        My.Settings.Save()

    End Sub
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        CyberMem.CyberCafe = True
        FrmL(CyberMem)
        CyberMem.ToolStripTextBox1.Focus()
    End Sub
    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        FrmL(AdCyber)
    End Sub
    Private Sub BetwenDateEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox5.KeyDown, ToolStripTextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then OpenDataToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub GotoFilterCostomerName(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then OpenExactwordToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Me.Hide()
    End Sub

    Private Sub SearchQueryManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchQueryManagerToolStripMenuItem.Click
        DVDRENT.ShowQr_Product(AukQ, Me.Cyber_BusinessDataGridView, Me.Cyber_BusinessBindingSource)
    End Sub
    Private Sub SmartLandScapeReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmartLandScapeReportToolStripMenuItem.Click, ToolStripButton1.ButtonClick, ToolStripMenuItem3.Click
        Dim M As New CafeMonitoring
        Dim LOpt As New AukDatabaseDataSetTableAdapters.OptionsTableAdapter
        LOpt.Fill(Me.AukDatabaseDataSet.Options)
        M.Database.Tables(1).SetDataSource(Me.AukDatabaseDataSet)
        M.Database.Tables(0).SetDataSource(Me.AukDatabaseDataSet)
        M.Database.Tables("Cyber_PCID").SetDataSource(Me.AukDatabaseDataSet)
        AukF.Prnt(M, Me.AukDatabaseDataSet, Me.Cyber_BusinessBindingSource)

    End Sub
    Private Sub SetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetToolStripMenuItem.Click
        AukF.Grid_View_SetCommonItems(Me.Cyber_BusinessDataGridView, ToolStripComboBox1.Text, 1, False)
    End Sub
    Private Sub ToolStripTextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox6.TextChanged
        AukF.BindFind(Me.Cyber_BusinessBindingSource, "COSTOMER_NAME", sender.TEXT, True)
    End Sub
    Private Sub GetTotalPaymentOrCurrentTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetTotalPaymentOrCurrentTimeToolStripMenuItem.Click, ToolStripLabel5.Click, ToolStripLabel3.Click
        MnCos = Val(My.Settings.CyberMinCost.ToString)
        Dim DV As DataGridView = Me.Cyber_BusinessDataGridView
        If DV.CurrentRow Is Nothing Then Exit Sub
        If CBool(AukF.GridT(DV, 13, -1, "fALSE")) = False Then
            PRate = Val(My.Settings.Cyber_per_hourRate.ToString)
        Else
            cs = AukF.GridT(DV, 2)
            If AukF.BindFind(Bp, "cyber_memberID", cs) = True Then
                'MsgBox("rate" & PRate & vbCrLf & ComRow & vbCrLf & cs & vbCrLf & My.Settings.NetUsingCost_Cafe_Member)
                PRate = My.Settings.NetUsingCost_Cafe_Member
            End If
            If PRate <= 0 Then PRate = Val(My.Settings.Cyber_per_hourRate.ToString)
        End If
        If Me.Cyber_BusinessDataGridView.CurrentCell.ColumnIndex = 3 Or Me.Cyber_BusinessDataGridView.CurrentCell.ColumnIndex = 4 Then
            Me.Cyber_BusinessDataGridView(Me.Cyber_BusinessDataGridView.CurrentCell.ColumnIndex, Me.Cyber_BusinessDataGridView.CurrentCell.RowIndex).Value = CStr(TimeOfDay)
        End If
        If Me.Cyber_BusinessDataGridView.CurrentCell.ColumnIndex = 4 Or Me.Cyber_BusinessDataGridView.CurrentCell.ColumnIndex = 5 Or Me.Cyber_BusinessDataGridView.CurrentCell.ColumnIndex = 7 Then
            Me.Cyber_BusinessDataGridView(4, Me.Cyber_BusinessDataGridView.CurrentCell.RowIndex).Value = CStr(TimeOfDay)
            If AukF.GridT(DV, 3) <> "" Then Me.Cyber_BusinessDataGridView(5, Me.Cyber_BusinessDataGridView.CurrentCell.RowIndex).Value = Format(Val(DateAndTime.DateDiff(DateInterval.Second, CDate(AukF.GridT(Me.Cyber_BusinessDataGridView, 3)), CDate(AukF.GridT(Me.Cyber_BusinessDataGridView, 4))) / 60), "0.##")
            Grate = AukF.GridT(Me.Cyber_BusinessDataGridView, 5, -1, 0)
            DTOTAL = Val(Format(PRate / 60 * grate, "0.##"))
            If Val(MnCos) > 0 And DTOTAL <= MnCos Then
                DV(7, DRow).Value = MnCos
            Else
                DV(7, DRow).Value = DTOTAL
            End If
        End If
        py = AukF.GridT(DV, 7, -1, 0) 'NET USING COST
        sc = AukF.GridT(DV, 8, -1, 0) * ScanP 'SCAN
        Pr = AukF.GridT(DV, 9, -1, 0) 'PRINT '0=BLACK,1=COLOR
        Wr = AukF.GridT(DV, 10, -1, 0) 'WRITE '0=CD,1=DVD.
        If Wr.Trim <> "" And InStr(Wr, ",") > 0 Then uW = Wr.Split(",") Else uW = Nothing
        If Pr.Trim <> "" And InStr(Pr, ",") > 0 Then uP = Pr.Split(",") Else uP = Nothing
        If Wr.Trim = "" Then
            DVDPR = 0 : CDPR = 0
        Else
            If InStr(Wr, ",") = 0 Then
                CDPR = Val(Wr) * Val(WriteCD) : DVDPR = 0
            Else
                CDPR = Val(ArV(uW, 0, Nothing, 0)) * Val(WriteCD)
                DVDPR = Val(ArV(uW, 1, Nothing, 0)) * Val(WriteDVD)
            End If
        End If
        If Pr.Trim = "" Then
            PRB = 0 : PRC = 0
        Else
            If InStr(Pr, ",") = 0 Then
                PRB = Val(Pr) * Val(PrintB) : PRC = 0
            Else
                PRB = Val(ArV(uP, 0, Nothing, 0)) * Val(PrintB)
                PRC = Val(ArV(uP, 1, Nothing, 0)) * Val(PrintC)
            End If
        End If
        TOTAL = Val(DVDPR) + Val(CDPR) + Val(PRB) + Val(PRC) + Val(py) + Val(sc)
        DV(11, DRow).Value = TOTAL - AukF.GridT(DV, 12, -1, 0) 'total - discount
        'DV.EndEdit()

        If My.Settings.DIRECT_SAVE = True Then Save_cyber()

        'If My.Settings.DIRECT_SAVE = True Then Cyber_BusinessBindingNavigatorSaveItem_Click(sender, e)
    End Sub

    Private Sub FILTERCURRENTFIELDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTERCURRENTFIELDToolStripMenuItem.Click
        ADSRC.DATAGRID_ADVANCE_SELECTED_FILTER(Me.Cyber_BusinessDataGridView, Me.Cyber_BusinessBindingSource)

    End Sub
    Private Sub REMOVEFILTERToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REMOVEFILTERToolStripMenuItem1.Click
        Me.Cyber_BusinessBindingSource.RemoveFilter()
    End Sub
    Private Sub LOADAMEMBERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADAMEMBERToolStripMenuItem.Click
        nMA = AukF.GridT(Me.Cyber_BusinessDataGridView, 2).ToString
        If Me.AukDatabaseDataSet.Cyber_Member.DefaultView.Find(nMA) = -1 Then
            SFC("Cyber_MemberID")
            STC(nMA)
            AukF.Db_LoadF(CyMem, "Cyber_memberID,Cyber_Member_Name", "Cyber_Member", False)
        End If
        If AukF.BindFind(Bp, "Cyber_MemberID", nMA) = True Then
            Me.Cyber_BusinessDataGridView(13, Me.Cyber_BusinessDataGridView.CurrentCell.RowIndex).Value = True
            Me.MemName.Text = "MemberName : [" & CyMem.Rows(ComRow).Item(1).ToString & "]"
            If Me.WHENLOADAMEMBERSHOWAMSGToolStripMenuItem.Checked = True Then MsgBox("MemberName : [" & CyMem.Rows(ComRow).Item(1).ToString & "], MEMBER ID:[" & CyMem.Rows(ComRow).Item(0).ToString & "] IS FOUND IN MEMBER DATABASE.", MsgBoxStyle.Information)
        Else
            Me.Cyber_BusinessDataGridView(13, Me.Cyber_BusinessDataGridView.CurrentCell.RowIndex).Value = False
            Me.MemName.Text = ""
            If Me.WHENLOADAMEMBERSHOWAMSGToolStripMenuItem.Checked = True Then MsgBox("MEMBER ID:[" & NMA & "] IS NOT FOUND IN MEMBER DATABASE.", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub WHENLOADAMEMBERSHOWAMSGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WHENLOADAMEMBERSHOWAMSGToolStripMenuItem.Click
        My.Settings.NEW_CYBER_MSG = WHENLOADAMEMBERSHOWAMSGToolStripMenuItem.Checked
        'My.Settings.NEW_CYBER_MSG = WHENLOADAMEMBERSHOWAMSGToolStripMenuItem.Checked
        'MsgBox(My.Settings.NEW_CYBER_MSG)
        My.Settings.Save()
        'AukF.AukOptionsOfDataGrid(Me.Cyber_BusinessDataGridView, "", "3,4,5,6,10,13")
    End Sub
    Private Sub CURRENTMEMBERINFORMATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CURRENTMEMBERINFORMATIONToolStripMenuItem.Click
        nma = AukF.GridT(Me.Cyber_BusinessDataGridView, 2)
        ''''If CyberMem.CyberCafeMemberLoad(NMA) = True Then
        ''''    Me.WindowState = FormWindowState.Minimized
        ''''End If
    End Sub
 
    Private Sub SAVECLEARDATABASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVECLEARDATABASEToolStripMenuItem.Click
        Cyber_BusinessBindingNavigatorSaveItem_Click(sender, e)
        Me.AukDatabaseDataSet.Cyber_Business.Clear()
    End Sub

    Private Sub Cyber_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If SoftIn.GetChages(Me.AukDatabaseDataSet) = True Then
            If SAVMSG() = 1 Then
                Save_cyber()
            ElseIf SavInt = 2 Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        Cyber_PcID.AukDatabaseDataSet = Me.AukDatabaseDataSet
        'Cyber_PcID.AukDatabaseDataSet.Cyber_PCID = Me.AukDatabaseDataSet.Cyber_PCID
        Cyber_PcID.Cyber_PCIDBindingSource.DataSource = Me.AukDatabaseDataSet.Cyber_PCID
        FrmL(Cyber_PcID)
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TVer = True Then
            Dim P As Decimal
            P = DateDiff(DateInterval.Minute, My.Settings.CyberLastDate, Now)
            If P < 0 Then P = P * -1
            If P >= 300 Then
                'MsgBox(My.Settings.CyberLastDate)
                'My.Settings.CyberLastDate = Now
                'My.Settings.Save()
                Warn.Msg = Msgx
                FrmL(Warn)
                Me.Close()
                Me.Timer1.Enabled = False
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Try
            Me.Cyber_BusinessBindingSource.AddNew()
            'If My.Settings.DIRECT_SAVE = True Then Cyber_BusinessBindingNavigatorSaveItem_Click(sender, e)
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            If My.Settings.DIRECT_SAVE = True Then
                If AukF.MsgTr("Delete current Record?", True) = False Then Exit Sub
            End If
            Me.Cyber_BusinessBindingSource.RemoveCurrent()
            If My.Settings.DIRECT_SAVE = True Then Cyber_BusinessBindingNavigatorSaveItem_Click(sender, e)
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub EditPc_ID(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click, ToolStripMenuItem5.Click
        Cyber_PcID.AukDatabaseDataSet = Me.AukDatabaseDataSet
        'Cyber_PcID.AukDatabaseDataSet.Cyber_PCID = Me.AukDatabaseDataSet.Cyber_PCID
        Cyber_PcID.Cyber_PCIDBindingSource.DataSource = Me.AukDatabaseDataSet.Cyber_PCID
        Cyber_PcID.Cyber_PCIDBindingSource.DataMember = ""
        FrmL(Cyber_PcID)
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        FrmL(AdCyber)

    End Sub
End Class