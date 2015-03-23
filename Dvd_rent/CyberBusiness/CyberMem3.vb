Public Class CyberMem
    Dim LOption As New AukDatabaseDataSetTableAdapters.OptionsTableAdapter
    Public CyberCafe As Boolean
    Dim Dec1 As Decimal
    Dim OlnyOneMember As Boolean
    'Public Function CyberCafeMemberLoad(ByVal M As String) As Boolean
    '    SFC("CYBER_MEMBERID")
    '    STC(M)
    '    AukF.Db_LoadF(Me.Cyber_MemberBindingSource)
    '    If Me.AukDatabaseDataSet.Cyber_Member.Rows.Count > 0 Then
    '        OlnyOneMember = True
    '        FrmL(Me)
    '        Return True
    '    Else
    '        MsgBox("Member ID : [ " & M & " ] IS NOT FOUND IN MEMBER DATABASE.", MsgBoxStyle.Critical)
    '        Return False
    '    End If
    'End Function
    'Private Sub Cyber_MemberBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cyber_MemberBindingNavigatorSaveItem.Click, SaveToolStripMenuItem.Click
    '    Try
    '        Me.Update()
    '        'Me.ValidateChildren()
    '        Me.Validate()
    '        'Me.Cyber_MonthlyFeesDataGridView.EndEdit()
    '        Me.Cyber_MemberBindingSource.EndEdit()
    '        Me.Cyber_MemberTableAdapter.Update(Me.AukDatabaseDataSet.Cyber_Member)
    '        Me.Cyber_MonthlyFeesBindingSource.EndEdit()
    '        Me.Cyber_MonthlyFeesTableAdapter.Update(Me.AukDatabaseDataSet.Cyber_MonthlyFees)
    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub
    'Public Sub Save()
    '    Try
    '        Me.Validate()
    '        Me.Cyber_MemberBindingSource.EndEdit()
    '        Me.Cyber_MemberTableAdapter.Update(Me.AukDatabaseDataSet.Cyber_Member)
    '        Me.Cyber_MonthlyFeesBindingSource.EndEdit()
    '        Me.Cyber_MonthlyFeesTableAdapter.Update(Me.AukDatabaseDataSet.Cyber_MonthlyFees)
    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub
    'Private Sub CyberMem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'TODO: This line of code loads data into the 'AukDatabaseDataSet.BroadBand_Pakege' table. You can move, or remove it, as needed.
    '    'Me.BroadBand_PakegeTableAdapter.Fill(Me.AukDatabaseDataSet.BroadBand_Pakege)
    '    If Me.OlnyOneMember = False Then
    '        If My.Settings.DataLoad_view = False Then
    '            If Me.CyberCafe = True Then
    '                SFC("MemberCategory")
    '                STC("Cyber")
    '            Else
    '                SFC("MemberCategory")
    '                STC("'Cyber'")
    '                SnX("<>")
    '            End If
    '            If My.Settings.CYBER_LAST_MEMBER_LOAD = True Then
    '                ADSRC.Load_Only_LastRecord(Me.AukDatabaseDataSet.Cyber_Member)
    '            Else
    '                AukF.Db_Load("*", "Cyber_Member", Me.AukDatabaseDataSet.Cyber_Member, True)
    '            End If
    '            If My.Settings.CyberCafe_Member_FeesLoad = True Then
    '                SFC("Cyber_MemberID")
    '                STC(Me.Cyber_MemberIDTextBox.Text)
    '                AukF.Db_Load("*", "Cyber_MonthlyFees", Me.AukDatabaseDataSet.Cyber_MonthlyFees, False, "", False, False, 960, 0, False)
    '            End If
    '        End If
    '    End If
    '    LOption.Fill(Me.AukDatabaseDataSet.Options)
    '    If Me.CyberCafe = True Then
    '        Me.Text = "Cyber Cafe Members"
    '    Else
    '        Me.Text = "Broadband Internet Providing Clients"
    '    End If
    '    Me.MemberCategoryComboBox.Visible = True
    '    Me.PakeList.Visible = True
    'End Sub
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Costomer_ImagePictureBox.DoubleClick
    '    Dim OpenFileDialog1 As New OpenFileDialog
    '    DVDRENT.IMAGE_INPUT(OpenFileDialog1, Me.Costomer_ImagePictureBox)
    '    'If My.Settings.DIRECT_SAVE = True Then Cyber_MemberBindingNavigatorSaveItem_Click(sender, e)
    'End Sub
    'Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
    '    If e.KeyCode = Keys.Enter Then ADSRC.Twice_Q(Me.Cyber_MemberBindingSource, 0, 1, sender.TEXT)

    'End Sub
    'Private Sub Cyber_MonthlyFeesDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Cyber_MonthlyFeesDataGridView.CellEndEdit
    '    Dim CxDate1 As Date
    '    If TypeOf Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(4, e.RowIndex).Value Is DBNull Then
    '        Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(4, e.RowIndex).Value = Now
    '    End If
    '    Try
    '        CxDate1 = CDate(Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(4, e.RowIndex).Value)
    '    Catch ex As Exception
    '        Epx(Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(4, e.RowIndex).Value.ToString)
    '    End Try
    '    If e.ColumnIndex = 4 Then
    '        Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(2, e.RowIndex).Value = CxDate1.Month '2 moth name,3year
    '        'MsgBox(CxDate1.Month.ToString)
    '        Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(3, e.RowIndex).Value = CxDate1.Year.ToString  '2 moth name,3year
    '        'MsgBox(CxDate1.Year.ToString)
    '    End If
    '    Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(5, Me.Cyber_MonthlyFeesDataGridView.NewRowIndex).Value = Me.Member_Charge_MonthlyTextBox.Text
    '    Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(7, e.RowIndex).Value = Val(AukF.GridT(Me.Cyber_MonthlyFeesDataGridView, 5).ToString) - Val(AukF.GridT(Me.Cyber_MonthlyFeesDataGridView, 6).ToString)

    'End Sub
    'Private Sub Cyber_MonthlyFeesDataGridView_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cyber_MonthlyFeesDataGridView.Enter
    '    On Error Resume Next
    '    Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(5, Me.Cyber_MonthlyFeesDataGridView.NewRowIndex).Value = Me.Member_Charge_MonthlyTextBox.Text
    'End Sub
    'Private Sub Cyber_MonthlyFeesDataGridView_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles Cyber_MonthlyFeesDataGridView.UserAddedRow
    '    Dim CxDate1 As Date
    '    SoftIn.DataGrid_MasterID_ByDate(Me.Cyber_MonthlyFeesDataGridView, 0, "1", 2, Nothing, Nothing, False)
    '    If TypeOf Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(4, Me.Cyber_MonthlyFeesDataGridView.CurrentCell.RowIndex).Value Is DBNull Then
    '        Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(4, Me.Cyber_MonthlyFeesDataGridView.CurrentCell.RowIndex).Value = Now.Date
    '    End If
    '    Try
    '        CxDate1 = CDate(Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(4, Me.Cyber_MonthlyFeesDataGridView.CurrentCell.RowIndex).Value)
    '    Catch ex As Exception
    '        Epx(Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(4, Me.Cyber_MonthlyFeesDataGridView.CurrentCell.RowIndex).Value.ToString)
    '    End Try
    '    If Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(5, Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView.CurrentCell.RowIndex).Value.ToString = "" Then
    '        Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(5, Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView.CurrentCell.RowIndex).Value = Me.Member_Charge_MonthlyTextBox.Text
    '    End If
    '    Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(2, Me.Cyber_MonthlyFeesDataGridView.CurrentCell.RowIndex).Value = CxDate1.Month '2 moth name,3year
    '    Me.Cyber_MonthlyFeesDataGridView.CurrentCell.DataGridView(3, Me.Cyber_MonthlyFeesDataGridView.CurrentCell.RowIndex).Value = CxDate1.Year.ToString
    'End Sub
    'Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
    '    Try
    '        Me.Cyber_MemberBindingSource.AddNew()
    '    Catch ex As Exception
    '        Epx()
    '        Exit Sub
    '    End Try
    '    Me.Member_Charge_MonthlyTextBox.Text = My.Settings.Cyber_MonthlyFees.ToString
    '    Me.Advance_FeesTextBox.Text = My.Settings.Cyber_AdvanceFees.ToString
    '    If My.Settings.AutoCyberMemberID = True Then
    '        If CyberCafe = True Then
    '            dc1 = My.Settings.CyberCafeMemberLastIDNumber
    '        Else
    '            dc1 = My.Settings.Cyber_BroadBandLastMemberID
    '        End If
    '        Dec1 = CDec(dc1)
    '        If CyberCafe = True Then dc1 = My.Settings.CYBERMEMBER_ID_CATE.ToUpper Else dc1 = My.Settings.BROAD_BAND_ID_CATE.ToUpper
    '        If AukF.BindFind(Me.Cyber_MemberBindingSource, 0, dc1 & CDec(Dec1 + 1)) = False Then
    '            Me.Cyber_MemberIDTextBox.Text = dc1 & CDec(Dec1 + 1)
    '            If CyberCafe = True Then
    '                Me.MemberCategoryComboBox.SelectedIndex = 0
    '                'Me.PakeList.SelectedIndex = 0
    '                Me.PakeList.SelectedIndex = 0
    '                Me.Member_Charge_MonthlyTextBox.Text = Val(My.Settings.CafeMonthCharge)
    '                Me.Advance_FeesTextBox.Text = Val(My.Settings.CafeAdvanceFees)
    '                Me.Cyber_ConnectCheckBox.CheckState = CheckState.Unchecked
    '            Else
    '                Me.MemberCategoryComboBox.SelectedIndex = 1
    '                Me.PakeList.SelectedIndex = 1
    '                Me.Cyber_ConnectCheckBox.CheckState = CheckState.Checked
    '            End If
    '        Else
    '            SoftIn.ToObject_MasterID_ByDate(Me.Cyber_MemberIDTextBox, 0, 1, " ,/,-,:", ",,,")
    '        End If
    '        If CyberCafe = True Then
    '            My.Settings.CyberCafeMemberLastIDNumber = Dec1 + 1
    '        Else
    '            My.Settings.Cyber_BroadBandLastMemberID = Dec1 + 1
    '        End If
    '        My.Settings.Save()
    '        Me.Cyber_Member_NameTextBox.Focus()
    '    Else
    '        Me.Cyber_MemberIDTextBox.Focus()
    '    End If
    '    Me.CommentsTextBox.Text = Now
    'End Sub
    'Private Sub SearchQueryFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchQueryFilterToolStripMenuItem.Click
    '    'AukQ.Close()
    '    AukQ.Bnp = Me.Cyber_MemberBindingSource
    '    FrmL(AukQ)
    'End Sub
    'Private Sub CheckTheDuePaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckTheDuePaymentsToolStripMenuItem.Click
    '    Dim ShowTable As New DataTable
    '    SFC("due")
    '    STC(0)
    '    SnX(">")
    '    AukF.Db_LoadN(ShowTable, "*", "Cyber_Info_Query")
    '    If ShowTable.Rows.Count > 0 Then
    '        FrmL(ViewQuery)
    '        ViewQuery.DataGrid1.CaptionText = "Current Month DueFees"
    '        ViewQuery.DataGrid1.DataSource = ShowTable
    '    End If
    'End Sub
    'Public Function ChkUnpaid(ByVal date1 As Date)
    '    Dim A1 As Array
    '    Dim Str As String
    '    Dim NTbt As New DataTable
    '    Dim ShowTable As New DataTable
    '    Dim Row As DataRow
    '    ShowTable.Columns.Clear()
    '    ShowTable.Clear()
    '    ShowTable.Columns.Add("MEMBER CATEGORY", System.Type.GetType("System.String"), "")
    '    ShowTable.Columns.Add("MEMBER ID", System.Type.GetType("System.String"), "")
    '    ShowTable.Columns.Add("MEMBER NAME", System.Type.GetType("System.String"), "")
    '    ShowTable.Columns.Add("MEMBER ADDRESS", System.Type.GetType("System.String"), "")
    '    ShowTable.Columns.Add("IS MEMBER CONNECTECD WITH US", System.Type.GetType("System.String"), "")
    '    Dim Nbp As New BindingSource
    '    Str = ""
    '    SFC("Month_Name", "Year_of_Month", "MEMBERCATEGORY")
    '    AXQ = "BroadBand"
    '    AXQ2 = "Cyber"
    '    If CyberCafe = True Then
    '        STC(date1.Month, date1.Year, "Checked", AXQ2)
    '    Else
    '        STC(date1.Month, date1.Year, "Checked", AXQ)
    '    End If
    '    AukF.Db_LoadN(NTbt, "Cyber_MonthlyFees", "Cyber_MemberID")
    '    Nbp.DataSource = NTbt
    '    For k As Integer = 0 To Me.AukDatabaseDataSet.Cyber_Member.Rows.Count - 1
    '        nma = Me.AukDatabaseDataSet.Cyber_Member.Rows(k).Item(0).ToString
    '        If AukF.BindFind(Nbp, "Cyber_MemberID", nma) = False Then
    '            Row = ShowTable.NewRow
    '            Row.Item(0) = Me.AukDatabaseDataSet.Cyber_Member.Rows(k).Item("MEMBERCATEGORY").ToString
    '            Row.Item(1) = Me.AukDatabaseDataSet.Cyber_Member.Rows(k).Item(0).ToString
    '            Row.Item(2) = Me.AukDatabaseDataSet.Cyber_Member.Rows(k).Item(1).ToString
    '            Row.Item(3) = Me.AukDatabaseDataSet.Cyber_Member.Rows(k).Item(3).ToString 'address
    '            Row.Item(4) = Me.AukDatabaseDataSet.Cyber_Member.Rows(k).Item(2).ToString 'contact
    '            ShowTable.Rows.Add(Row)
    '        End If
    '    Next
    '    If ShowTable.Rows.Count > 0 Then
    '        FrmL(ViewQuery)
    '        ViewQuery.DataGrid1.CaptionText = "CurrentMonth UnPaid Fees : " & DateAndTime.MonthName(date1.Month) & "." & date1.Year.ToString
    '        ViewQuery.DataGrid1.DataSource = ShowTable
    '    End If
    'End Function
    'Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    CyberMem_Load(sender, e)

    'End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        AukF.Single_DataRecordRefresh(Me.Cyber_MemberBindingSource)
        AukF.SingleDataTable_DataRecordRefresh(Me.AukDatabaseDataSet.Cyber_MonthlyFees, True)


    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.Cyber_MemberBindingSource, True)
        AukF.SingleDataTable_DataRecordRefresh(Me.AukDatabaseDataSet.Cyber_MonthlyFees, True)
    End Sub
    'Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
    '    ChkUnpaid(Now.Date)
    'End Sub
    'Private Sub PrsDate1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox3.KeyDown
    '    Dim D1 As Date
    '    If e.KeyCode = Keys.Enter Then
    '        Try
    '            D1 = CDate(sender.text)
    '        Catch ex As Exception
    '            Epx()
    '            Exit Sub
    '        End Try
    '        ChkUnpaid(D1)
    '    End If
    'End Sub
    'Private Sub Cyber_MemberBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cyber_MemberBindingSource.PositionChanged
    '    If My.Settings.CyberCafe_Member_FeesLoad = True Then
    '        If Cyber_MemberIDTextBox.Text <> "" And My.Settings.CyberCafe_Member_FeesLoad = True Then
    '            If AukF.BindFind(Me.Cyber_MonthlyFeesBindingSource, "Cyber_memberID", Cyber_MemberIDTextBox.Text) = False Then
    '                SFC("Cyber_MemberID")
    '                STC(Me.Cyber_MemberIDTextBox.Text)
    '                AukF.Db_Load("*", "Cyber_MonthlyFees", Me.AukDatabaseDataSet.Cyber_MonthlyFees, False, "", False, False, 960, -1, False)
    '            End If
    '        End If
    '    End If
    'End Sub
    Private Sub DueReportPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DueReportPrintToolStripMenuItem.Click
        Dim M As New CYBER_MEMBERS_FEES_DueReport
        Dim ShowTable As DataTable
        'Dim NTbt As New DataTable
        'Dim Nbp As New BindingSource
        'Nbp.DataSource = NTbt
        'Str = ""
        SFC("DUE")
        STC(0)
        SnX(">")
        AukF.Db_LoadN(ShowTable, "*", "Cyber_Info_Query")
        AukF.Prnt(M, ShowTable)
    End Sub
    Private Sub DeleteSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        SendKeys.Send("{DEL}")
    End Sub
    Private Sub MemberCategoryComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberCategoryComboBox.SelectedIndexChanged
        On Error Resume Next
        If Me.MemberCategoryComboBox.SelectedIndex = 0 Then
            Me.Member_Charge_MonthlyTextBox.Text = Val(My.Settings.CafeMonthCharge)
            Me.PakeList.SelectedIndex = 0
            Me.Advance_FeesTextBox.Text = Val(My.Settings.CafeAdvanceFees)
        ElseIf Me.MemberCategoryComboBox.SelectedIndex = 1 Then
            If Me.PakeList.SelectedIndex = 0 Then
                Me.PakeList.SelectedIndex = 1
            End If
            'Me.Member_Charge_MonthlyTextBox.Text = Val(My.Settings.Cyber_MonthlyFees)
            Me.Advance_FeesTextBox.Text = Val(My.Settings.Cyber_AdvanceFees)
        End If
    End Sub
    Private Sub PakeList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PakeList.SelectedIndexChanged
        'if aukf.BindFind (me.BroadBandPakegeBindingSource ,0,me.PakeList .ge
        Try
            Me.Member_Charge_MonthlyTextBox.Text = Val(Me.AukDatabaseDataSet.BroadBand_Pakege(Me.PakeList.SelectedIndex).Item("Total_Cost_Per_Month").ToString)
            Me.PakeList.EndUpdate()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AdvanceCyberOptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvanceCyberOptionToolStripMenuItem.Click
        FrmL(AdCyber)
    End Sub
    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Ip_Settings.TData = Me.AukDatabaseDataSet.Cyber_Member
        Ip_Settings.DDataSet = Me.AukDatabaseDataSet
        'Ip_Settings.BindS = Me.Cyber_MemberBindingSource

        FrmL(Ip_Settings)
    End Sub
    Private Sub IPAddressInformationsPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPAddressInformationsPrintToolStripMenuItem.Click
        LOption.Fill(Me.AukDatabaseDataSet.Options)
        Dim m As New IPADDRESS
        AukF.Prnt(m, Me.AukDatabaseDataSet, Me.Cyber_MemberBindingSource)
    End Sub
    Private Sub PrintReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReportToolStripMenuItem.Click
        LOption.Fill(Me.AukDatabaseDataSet.Options)
        Dim M As New CyberCafe_Members_Report
        AukF.Prnt(M, Me.AukDatabaseDataSet, Me.Cyber_MemberBindingSource)
    End Sub
    'Private Sub TxtPressedEffect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PakeList.KeyDown, MemberCategoryComboBox.KeyDown, Member_ContactTextBox.KeyDown, Member_Charge_MonthlyTextBox.KeyDown, IP_ADDRESSTextBox.KeyDown, E_MAILTextBox.KeyDown, Cyber_MemberIDTextBox.KeyDown, Cyber_Member_NameTextBox.KeyDown, Cyber_Member_AddressTextBox.KeyDown, Cyber_ConnectCheckBox.KeyDown, CommentsTextBox.KeyDown, Advance_FeesTextBox.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If Me.EnterToNextRecord.Checked = True Then
    '            Me.Cyber_MemberBindingSource.MoveNext()
    '        Else
    '            If Me.Cyber_MemberBindingSource.Count = Me.Cyber_MemberBindingSource.Position Then
    '                If sender.name = Me.CommentsTextBox.Name Then
    '                    ''''BindingNavigatorAddNewItem_Click(sender, e)
    '                End If
    '            Else
    '                If sender.name = Me.CommentsTextBox.Name Then
    '                    Me.Cyber_MemberBindingSource.MoveNext()
    '                    Me.Cyber_MemberIDTextBox.Focus()
    '                Else

    '                    Me.SelectNextControl(sender, True, True, True, True)
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub
    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Dim m As New CyberCafeMembers_PersonalReport
        AukF.Prnt(m, Me.AukDatabaseDataSet, Me.Cyber_MemberBindingSource)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Dim ShowDset As New AukDatabaseDataSet
        Dim M As New CyberCafeMembers_PersonalReport
        'ShowDset.BroadBand_Pakege = Me.AukDatabaseDataSet.BroadBand_Pakege.Copy
        SFC("Cyber_MemberID")
        STC(Me.Cyber_MemberIDTextBox.Text)
        AukF.Db_LoadN(ShowDset, "*", "Cyber_Member", True)
        AukF.Db_LoadN(ShowDset, "*", "BroadBand_Pakege", )
        LOption.Fill(ShowDset.Options)
        AukF.Prnt(M, ShowDset, Me.Cyber_MemberBindingSource)

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim OpenFileDialog1 As New SaveFileDialog
        DVDRENT.IMAGE_SAVE(OpenFileDialog1, Me.Costomer_ImagePictureBox)
    End Sub
    'Private Sub PreviousMonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousMonthToolStripMenuItem.Click
    '    ChkUnpaid(Now.Date.AddDays(-1))
    'End Sub
    'Private Sub Before2MonthsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Before2MonthsToolStripMenuItem.Click
    '    ChkUnpaid(Now.Date.AddDays(-2))
    'End Sub
    Private Sub ChekcDues_Text(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim ShowTable As New DataTable
            SFC("due")
            STC(sender.text)
            SnX(">")
            AukF.Db_Load("*", "Cyber_Info_Query", ShowTable)
            If ShowTable.Rows.Count > 0 Then
                FrmL(ViewQuery)

                ViewQuery.DataGrid1.CaptionText = "Current Month DueFees"
                ViewQuery.DataGrid1.DataSource = ShowTable
            End If
        End If
    End Sub
    Private Sub save_direc_opt(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PakeList.Validated, MemberCategoryComboBox.Validated, Member_ContactTextBox.Validated, Member_Charge_MonthlyTextBox.Validated, IP_ADDRESSTextBox.Validated, E_MAILTextBox.Validated, Cyber_MemberIDTextBox.Validated, Cyber_Member_NameTextBox.Validated, Cyber_Member_AddressTextBox.Validated, Cyber_ConnectCheckBox.Validated, CommentsTextBox.Validated, Advance_FeesTextBox.Validated, Costomer_ImagePictureBox.Validated
        ''''If My.Settings.DIRECT_SAVE = True Then Cyber_MemberBindingNavigatorSaveItem_Click(sender, e)
    End Sub
    'Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
    '    AukF.BindFind(Me.Cyber_MemberBindingSource, "Cyber_MemberID", sender.text, True)

    'End Sub
    'Private Sub CyberMem_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    '    If Me.AukDatabaseDataSet.HasChanges = True Then
    '        If SAVMSG() = 1 Then
    '            Save()
    '        ElseIf SavInt = 2 Then
    '            e.Cancel = True
    '        End If
    '    End If
    'End Sub
    Private Sub InsertImportClientsImageFromAFolderByTheirIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertImportClientsImageFromAFolderByTheirIDToolStripMenuItem.Click
        Dim FN As New FolderBrowserDialog
        FN.ShowNewFolderButton = True
        If FN.ShowDialog = Forms.DialogResult.OK Then
            FOL = FN.SelectedPath
            DVDRENT.IMAGE_INPUT_DATATABLE(FOL, Me.AukDatabaseDataSet.Cyber_Member, 11)

        End If
    End Sub
    'Private Sub Cyber_MonthlyFeesDataGridView_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cyber_MonthlyFeesDataGridView.Validated
    '    If My.Settings.DIRECT_SAVE = True Then Cyber_MemberBindingNavigatorSaveItem_Click(sender, e)
    'End Sub
    Private Sub LOADCURRENTCLIENTMONTHLYFEESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADCURRENTCLIENTMONTHLYFEESToolStripMenuItem.Click
        SFC("Cyber_MemberID")
        STC(Me.Cyber_MemberIDTextBox.Text)
        AukF.Db_Load("*", "Cyber_MonthlyFees", Me.AukDatabaseDataSet.Cyber_MonthlyFees, False, "", False, False, 960, 0, False, True)
    End Sub
End Class