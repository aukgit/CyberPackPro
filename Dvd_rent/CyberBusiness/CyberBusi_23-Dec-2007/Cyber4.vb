Public Class Cyber
    Dim CyMem As New AukDatabaseDataSet.Cyber_MemberDataTable
    Dim Bp As New BindingSource
    Dim PCVirView As New DataView
    Public ScanP As Double
    Public PrintC As Double
    Public PrintB As Double
    Public WriteDVD As Double
    Public WriteCD As Double
    Dim ChorsAdp As New AukDatabaseDataSetTableAdapters.CHourTableAdapter
    Dim uW, uP As Array
    Dim Dqa As Date
    Dim Wr, Pr, DTOTAL As String
    Dim PRate As Double
    Dim MnCos As Double = Val(My.Settings.CyberMinCost.ToString)
    Dim DVDPR, CDPR, PRB, PRC, TOTAL As Double
    Dim Msgx As String
    Dim PCTable As New DataTable ' pc id table
    Dim Refresh_PCIDCount As Integer = 0
    Dim Chors As New AukDatabaseDataSet.CHourDataTable
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
        Me.AukDatabaseDataSet.Cyber_Business.DueColumn.DefaultValue = False
        'Me.AukDatabaseDataSet.Cyber_Business.Is_MemberColumn.DefaultValue = False


        Me.MonthCalendar1.TodayDate = Dat(Now.Date)
        Me.AukDatabaseDataSet.Cyber_Business.Is_MemberColumn.DefaultValue = False

        'for the time check on trail
        'Me.Timer1.Enabled = False
        'If TVer = True Then
        '    Msgx = "In trail version of CyberPack Pro you are not suppose to run this ""Cyber Cafe Monitoring@CyberPack Pro"" [Form] more than 300 minutes.If you want to buy please contact with the developer [01913 50863],0167 01013907,01711 334201(onRequest)"
        '    Dim P, N As Decimal
        '    'MsgBox(P, , CStr(My.Settings.CyberLastDate))
        '    If CStr(My.Settings.CyberLastDate) = "" Or CStr(My.Settings.CyberLastDate) = "12:00:00 AM" Or CStr(My.Settings.CyberLastDate) = "00:00:00" Then
        '        My.Settings.CyberLastDate = Now

        '    End If
        '    P = DateDiff(DateInterval.Minute, My.Settings.CyberLastDate, Now)
        '    N = DateAndTime.DateDiff(DateInterval.Day, My.Settings.CyberLastDate, Now)
        '    'MsgBox(P, , My.Settings.CyberLastDate.ToString & N)
        '    If P < 0 Then P = P * -1

        '    If N < 0 Then
        '        SrGens.Make_Corrupt(1)
        '        SOFTCLOSE()
        '        Exit Sub
        '    ElseIf N <= TestDays And N > 0 Then
        '        My.Settings.CyberLastDate = Now
        '        P = 0
        '        My.Settings.Save()
        '        GoTo nextwork
        '    End If
        '    If P >= 300 Then
        '        Warn.Msg = Msgx
        '        FrmL(Warn)
        '        Me.Close()
        '        Exit Sub
        '    End If
        '    My.Settings.Save()
        'End If
        'Me.Timer1.Enabled = True
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
        For k As Integer = 0 To Me.AukDatabaseDataSet.Cyber_PCID.Count - 1
            AukF.UniqueAdd(Me.ToolStripComboBox1, Me.AukDatabaseDataSet.Cyber_PCID(k).Item(1).ToString)
        Next
        AukF.ComSelIndex(Me.ToolStripComboBox1)



        'adding new column on pc id

        PCTable.Merge(Me.AukDatabaseDataSet.Cyber_PCID)
        PCTable.Columns.Add("UserCount", GetType(System.Int64), "")
        PCTable.Columns("UserCount").DefaultValue = 0

        PCVirView = Me.PCTable.DefaultView
        PCVirView.Sort = "PC_ID"
        PCVirView.RowFilter = "UserCount = 0 or USerCount is null"

        Me.PCTable_Ref(False) 'refreshng PC ID

        '''''----Strt for  Dynamic netSuing Cost and Round Figue
        ChorsAdp.Fill(Chors)

        'PCTable_Ref()
        'Me.PC_ID_List.Items.re()
        'AukF.AukOptionsOfDataGrid(Me.Cyber_BusinessDataGridView, "", "3,4,5,6,10,13")

        'IF CYBERCAFE=
    End Sub
    Public Sub PCTable_Ref(Optional ByVal ClearAll As Boolean = False)
        'Dim RowM, RowIns As DataRow
        If ClearAll = True Then
            For K As Integer = 0 To PCTable.Rows.Count - 1
                PCTable.Rows(K).Item(2) = 0
            Next
        Else
            Dim C1, C2 As Integer
            C1 = Me.AukDatabaseDataSet.Cyber_Business.Compute("Count(ID)", "Time_Left is null")
            C2 = PCTable.Rows.Count
            'If (C1 <= C2) Then ' cyberbusiness null field Count <= PCTABLE ROW
            '    'get information from CyberBussiness Table 
            '    'and Refress in PCTable
            '    Dim Rowsx() As DataRow
            '    ' i m having info frm cyber table and null fields + as customer in pctable
            '    Rowsx = Me.AukDatabaseDataSet.Cyber_Business.Select("Time_Left is null")
            '    For K As Integer = 0 To Rowsx.Length - 1
            '        RowM = Rowsx(K)
            '        RowIns = ADSRC.FIND_FROM_DATATABLE(PCTable, RowM.Item("PC_ID")) 'pc table row
            '        ' adding value for user ,in our virtual field 'usercount'
            '        RowIns.Item("UserCount") = Val(RowIns.Item("UserCount").ToString) + 1
            '    Next
            'ElseIf C1 > C2 Then ' cyberbusiness null field Count > PCTABLE ROW
            'geting pc information from PCID and filter in 
            'CyberBussiness Table and set Null end time to use name on PC ID table
            For M As Integer = 0 To PCTable.Rows.Count - 1
                Dim PCID As String = PCTable.Rows(M).Item("PC_ID").ToString
                Dim PCCount As Integer
                PCCount = Me.AukDatabaseDataSet.Cyber_Business.Compute("Count(PC_ID)", "(Time_Left is null) and PC_ID=" & PCID)
                PCTable.Rows(M).Item("UserCount") = PCCount
            Next

        End If
        'MsgBox(C1)

        'End If
        'ViewQuery.DataGrid1.DataSource = PCVirView
        'FrmL(ViewQuery)

    End Sub
    Public Sub InformationView()
        Try
            Dim Show As String

            If AukF.GridT(Me.Cyber_BusinessDataGridView, 0) = "" Then Show = "Information is not valid" : GoTo dis

            Dim CName As String = UCase(AukF.GridT(Me.Cyber_BusinessDataGridView, 2))
            'Dim AccessTime As String = AukF.GridT(Me.Cyber_BusinessDataGridView, 3)
            Dim EndTime As String = AukF.GridT(Me.Cyber_BusinessDataGridView, 4)
            Dim Duration As String = AukF.GridT(Me.Cyber_BusinessDataGridView, 5)
            Dim IMem As Boolean = CBool(AukF.GridT(Me.Cyber_BusinessDataGridView, 13, -1, False))
            Dim MemberT As String
            Dim TPay As String = Val(AukF.GridT(Me.Cyber_BusinessDataGridView, 11, -1, 0))
            If IMem = True Then MemberT = "(M)" Else MemberT = ""
            Dim StayInStr As String
            If EndTime <> "" Then
                Me.Label1.BackColor = Color.SlateGray
                Me.Label1.ForeColor = Color.White
                StayInStr = "DURATION :  " & Duration & " MIN,"
            Else
                Me.Label1.BackColor = Color.SteelBlue
                Me.Label1.ForeColor = Color.Wheat
                'StayInStr = "Connected: " & AccessTime
            End If

            Show = "NAME : " & CName & MemberT & " [ " & StayInStr & " " & "PAY : " & TPay & " T.K ]"
dis:        Me.Label1.Text = Show
        Catch ex As Exception
            Epx()
            Me.Label1.Text = "Error Occur"

        End Try



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
        SoftIn.Master_ID_String(sender, 7)
        Me.InformationView()
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
                Extent_Fields_readOnly()
            Else
                Me.AukDatabaseDataSet.Cyber_Business.Clear()
                Me.Cyber_BusinessBindingSource.RemoveFilter()
                'SoftIn.BindFilterByAdvanceCategory(Me.Cyber_BusinessBindingSource, "date_of_business", "1/1/1011", True, False, False, "=", False)
                'AukF.DataSetFilter(Me.Cyber_BusinessBindingSource, True, False, True, False)
                DATE_BUSI.Enabled = True
                Me.Cyber_BusinessDataGridView.AllowUserToAddRows = False
                Me.DATE_BUSI.Focus()
            End If
            Dim Ipox As Integer = Me.Cyber_BusinessBindingSource.Count - 1
            If Ipox >= 0 Then
                Me.Cyber_BusinessBindingSource.Position = Ipox
            End If
            Exe_CuteQ()
        Catch ex As Exception
            DATE_BUSI.Focus()
            MsgBox("Please Type a Vaild Date...", MsgBoxStyle.Critical)
        End Try
    End Function
    Public Sub Exe_CuteQ() ' that executes when qury from any query executes.
        Me.PCTable_Ref()
    End Sub
    Public Sub Extent_Fields_readOnly()
        Me.Total_Payment.ReadOnly = True
        Me.Discount.ReadOnly = False
        Me.Is_Member.ReadOnly = True

    End Sub
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Me.MonthCalendar1.Visible = False
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
        'Dim Wr, Pr, nMA As String
        'Dim D1 As Date
        'Dim SENDER As DataGridView = SENDER
        On Error Resume Next
        'If Me.Cyber_BusinessDataGridView.CurrentRow IsNot Nothing Then Exit Sub
        SoftIn.Master_ID_String(sender, 7)
        'On Error Resume Next
        '8=SCAN,9=PRINT,WRITE=10
        If e.ColumnIndex = 12 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Or e.ColumnIndex = 10 Then
            GetTotalPaymentOrCurrentTimeToolStripMenuItem_Click(sender, e)
        End If
        'D1 = CDate(Me.D_txt.Text)
        If AukF.GridT(sender, 6) = "" Then
            sender(6, e.RowIndex).Value = Dqa
        End If
        If AukF.GridT(sender, 1) = "" Then 'Pc Id getting, 1= PC ID
            'Pc Id getting
            Me.PCID_Getting()

        End If
        If e.ColumnIndex = 8 Or e.ColumnIndex = 9 Or e.ColumnIndex = 10 Then
            ' if end edit on print,write or scan
            GetTotalPaymentOrCurrentTimeToolStripMenuItem_Click(sender, e)
        End If
        'If e.ColumnIndex = 3 Then
        If AukF.GridT(sender, 3) = "" Then
            If sender.CurrentCell.RowIndex > -1 Then sender(3, e.RowIndex).Value = CStr(TimeOfDay)
        End If

        'customer adding - in pc id

        If e.ColumnIndex = 1 Then 'pc id coulm end edit
            Me.PCID_Adding()
        End If


        If My.Settings.DIRECT_SAVE = True Then Me.SaveAuto()
        Me.InformationView()

        'End If
    End Sub


    Private Sub OpenDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDataToolStripMenuItem.Click
        Try
            AukF.BindFilter_BetweenOparetorN(Me.Cyber_BusinessBindingSource, "Date_of_business", Me.ToolStripTextBox4.Text, Me.ToolStripTextBox5.Text)
            Me.MonthCalendar1.Visible = False
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
    Private Sub Members_Show(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        CyberMem.CyberCafe = True
        FrmL(CyberMem)
        CyberMem.ToolStripTextBox1.Focus()
    End Sub
    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        FrmL(AdCyber)
    End Sub
    Private Sub BetwenDateEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox5.KeyDown, ToolStripTextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then OpenDataToolStripMenuItem_Click(sender, e) : Me.MonthCalendar1.Visible = False
    End Sub

    Private Sub GotoFilterCostomerName(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then OpenExactwordToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Me.Hide()
    End Sub

    Private Sub SearchQueryManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchQueryManagerToolStripMenuItem.Click
        DVDRENT.ShowQr_Product(Me.Cyber_BusinessDataGridView, Me.Cyber_BusinessBindingSource)
    End Sub
    Private Sub SmartLandScapeReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click, ToolStripButton1.Click
        If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me) = False Then Exit Sub
        Dim M As New CafeMonitoring2
        Dim LOpt As New AukDatabaseDataSetTableAdapters.OptionsTableAdapter
        LOpt.Fill(Me.AukDatabaseDataSet.Options)
        M.Database.Tables(1).SetDataSource(Me.AukDatabaseDataSet)
        M.Database.Tables(0).SetDataSource(Me.AukDatabaseDataSet)
        M.Database.Tables("Cyber_PCID").SetDataSource(Me.AukDatabaseDataSet)
        AukF.Prnt(M, Me.AukDatabaseDataSet, Me.Cyber_BusinessBindingSource)

    End Sub
    Private Sub SetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetToolStripMenuItem.Click
        If Me.ToolStripComboBox1.SelectedIndex > 0 Then AukF.Grid_View_SetCommonItems(Me.Cyber_BusinessDataGridView, Me.AukDatabaseDataSet.Cyber_PCID(Me.ToolStripComboBox1.SelectedIndex).PC_ID.ToString, 1, False)
    End Sub
    Private Sub ToolStripTextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox6.TextChanged
        AukF.BindFind(Me.Cyber_BusinessBindingSource, "COSTOMER_NAME", sender.TEXT, True)
    End Sub
    Private Sub Customer_Exit() 'for minus 1
        Dim EndTime As String = AukF.GridT(Me.Cyber_BusinessDataGridView, 4)
        Dim PCID As String = AukF.GridT(Me.Cyber_BusinessDataGridView, 1)
        'exclueding PCID number
        If EndTime = "" Then
            Dim VirR As DataRow
            VirR = ADSRC.FIND_FROM_DATATABLE(PCTable, PCID)
            If VirR IsNot Nothing Then
                VirR.Item("UserCount") = Val(VirR.Item("UserCount").ToString) - 1
            End If

            'one customer exit frm cyber cafe
        End If
    End Sub

    Private Sub GetTotalPaymentOrCurrentTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetTotalPaymentOrCurrentTimeToolStripMenuItem.Click, ToolStripLabel5.Click, ToolStripLabel3.Click
        Try
            MnCos = Val(My.Settings.CyberMinCost.ToString) 'minimimum cst
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
                Customer_Exit()
                '----

                Me.Cyber_BusinessDataGridView(Me.Cyber_BusinessDataGridView.CurrentCell.ColumnIndex, Me.Cyber_BusinessDataGridView.CurrentCell.RowIndex).Value = CStr(TimeOfDay)

            End If
            If Me.Cyber_BusinessDataGridView.CurrentCell.ColumnIndex = 4 Or Me.Cyber_BusinessDataGridView.CurrentCell.ColumnIndex = 5 Or Me.Cyber_BusinessDataGridView.CurrentCell.ColumnIndex = 7 Then
                If Chors.Rows.Count = 0 Then
                    Me.Cyber_BusinessDataGridView(4, Me.Cyber_BusinessDataGridView.CurrentCell.RowIndex).Value = CStr(TimeOfDay)
                    If AukF.GridT(DV, 3) <> "" Then Me.Cyber_BusinessDataGridView(5, Me.Cyber_BusinessDataGridView.CurrentCell.RowIndex).Value = Format(Val(DateAndTime.DateDiff(DateInterval.Second, Dat(AukF.GridT(Me.Cyber_BusinessDataGridView, 3)), Dat(AukF.GridT(Me.Cyber_BusinessDataGridView, 4))) / 60), "0.##")
                    Grate = AukF.GridT(Me.Cyber_BusinessDataGridView, 5, -1, 0)
                    DTOTAL = Val(Format(PRate / 60 * grate, "0.##"))
                    ' inputing NetUsingCost
                    If Val(MnCos) > 0 And DTOTAL <= MnCos Then
                        If DRow > -1 Then DV(7, DRow).Value = MnCos
                    Else
                        If DRow > -1 Then DV(7, DRow).Value = DTOTAL
                    End If
                Else ' its means we have to do some thing for dynamic cost

                End If

            End If
            Dim NetUsC As Decimal
            py = AukF.GridT(DV, 7, -1, 0) 'NET USING COST
            sc = Val(AukF.GridT(DV, 8, -1, 0).ToString) * ScanP 'SCAN
            Pr = (AukF.GridT(DV, 9, -1, 0).ToString) 'PRINT '0=BLACK,1=COLOR
            Wr = (AukF.GridT(DV, 10, -1, 0).ToString) 'WRITE '0=CD,1=DVD.
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
            If DRow > -1 Then DV(11, DRow).Value = TOTAL - AukF.GridT(DV, 12, -1, 0) 'total - discount
            'DV.EndEdit()
            Me.InformationView()
            If My.Settings.DIRECT_SAVE = True Then Save_cyber()
        Catch ex As Exception
            Epx("Getting Total Cost,Err 54")
        End Try
        MsgBox(24 / 10) '2.4
        MsgBox(24 \ 10) '2
        MsgBox(24 Mod 10) '4

        'If My.Settings.DIRECT_SAVE = True Then Cyber_BusinessBindingNavigatorSaveItem_Click(sender, e)
    End Sub
    Private Function RoundFigueCost(ByVal Cost As Decimal)
        If My.Settings.CyberRoundFigure = True Then
            Dim VALx As Decimal = Val(My.Settings.CyberRoundFigureValue)


        End If
    End Function
    Private Sub FILTERCURRENTFIELDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTERCURRENTFIELDToolStripMenuItem.Click, ToolStripSplitButton1.ButtonClick, FilterSelectedItemToolStripMenuItem.Click, RemoveFilterToolStripMenuItem2.Click
        ADSRC.DATAGRID_ADVANCE_SELECTED_FILTER(Me.Cyber_BusinessDataGridView, Me.Cyber_BusinessBindingSource)

    End Sub
    Private Sub REMOVEFILTERToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REMOVEFILTERToolStripMenuItem1.Click
        Me.Cyber_BusinessBindingSource.RemoveFilter()
    End Sub
    Private Sub LOADAMEMBERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADAMEMBERToolStripMenuItem.Click
        Dim COunt As Integer
        Dim Nma As String
        Try
            Me.Cyber_BusinessBindingSource.EndEdit()
            Me.Cyber_BusinessDataGridView.EndEdit()
        Catch ex As Exception
            MsgBox("Please do not Click on Other Fields when a Row is Creating,because by clicking on the other rows field programming Column Unique ID can't Possible to create." & vbclf & "So becarefull and by the way it may not effect on your current data object.", MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        Nma = AukF.GridT(Me.Cyber_BusinessDataGridView, 2).ToString
        If Me.AukDatabaseDataSet.Cyber_Member.DefaultView.Find(Nma) = -1 Then
            SFC("Cyber_MemberID")
            STC(Nma)
            AukF.Db_LoadF(CyMem, "Cyber_memberID,Cyber_Member_Name", "Cyber_Member", True)
        End If
        If AukF.BindFind(Bp, "Cyber_MemberID", nMA) = True Then
            Me.Cyber_BusinessDataGridView(13, Me.Cyber_BusinessDataGridView.CurrentCell.RowIndex).Value = True
            Me.MemName.Text = "MemberName : [" & CyMem.Rows(ComRow).Item(1).ToString & "]"
            If Me.WHENLOADAMEMBERSHOWAMSGToolStripMenuItem.Checked = True Then
                MsgBox("MemberName : [" & CyMem.Rows(ComRow).Item(1).ToString & "], MEMBER ID:[" & CyMem.Rows(ComRow).Item(0).ToString & "] IS FOUND IN MEMBER DATABASE.", MsgBoxStyle.Information)
                'then try to find his/her due is before then show msg
                CustomrFndSql(Nma) 'cos id=nma
                SFC("", "Due") 'first costomer id/name
                STC("", "True")
                DTC("", "b")
                COunt = ADSRC.Summary_Totals("Cyber_Business", "Due")
                If COunt > 0 Then
                    MsgBox("Current Customer Have " & COunt & " Due Records.", MsgBoxStyle.Information)
                End If
            End If
        Else

            If Me.Cyber_BusinessDataGridView.CurrentCell IsNot Nothing Then Me.Cyber_BusinessDataGridView(13, Me.Cyber_BusinessDataGridView.CurrentCell.RowIndex).Value = False
            Me.MemName.Text = ""
            If Me.WHENLOADAMEMBERSHOWAMSGToolStripMenuItem.Checked = True Then MsgBox("MEMBER ID:[" & Nma & "] IS NOT FOUND IN MEMBER DATABASE.", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub CustomrFndSql(ByVal CosID As String)
        SFC("Costomer_Name")
        STC(CosID)
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
        CyberMem.CyberCafe = True
        'FrmL(CyberMem)
        CyberMem.CyberCafeMemberLoad(nma) 'this function open only one meber
     
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
        'If TVer = True Then
        '    Dim P As Decimal
        '    P = DateDiff(DateInterval.Minute, My.Settings.CyberLastDate, Now)
        '    If P < 0 Then P = P * -1
        '    If P >= 300 Then
        '        'MsgBox(My.Settings.CyberLastDate)
        '        'My.Settings.CyberLastDate = Now
        '        'My.Settings.Save()
        '        Warn.Msg = Msgx
        '        FrmL(Warn)
        '        Me.Close()
        '        Me.Timer1.Enabled = False
        '        Exit Sub
        '    End If
        'End If
        If Refresh_PCIDCount <= 2 AndAlso Me.Cyber_BusinessDataGridView.RowCount = 0 Then
            Me.PCTable_Ref(False)
            Refresh_PCIDCount += 1
        End If
        If Me.Cyber_BusinessBindingSource.Filter IsNot Nothing Then
            If Me.ReMoveFilter.Visible = False Then Me.ReMoveFilter.Visible = True
        Else
            If Me.ReMoveFilter.Visible = True Then Me.ReMoveFilter.Visible = False
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

    Private Sub EditPc_ID(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click, ToolStripButton10.ButtonClick, EditPCIDToolStripMenuItem.Click
        Cyber_PcID.AukDatabaseDataSet = Me.AukDatabaseDataSet
        'Cyber_PcID.AukDatabaseDataSet.Cyber_PCID = Me.AukDatabaseDataSet.Cyber_PCID
        Cyber_PcID.Cyber_PCIDBindingSource.DataSource = Me.AukDatabaseDataSet.Cyber_PCID
        Cyber_PcID.Cyber_PCIDBindingSource.DataMember = ""
        FrmL(Cyber_PcID)
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        FrmL(AdCyber)

    End Sub

    Private Sub DATE_BUSI_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATE_BUSI.DoubleClick
        Me.MonthCalendar1.Visible = Not Me.MonthCalendar1.Visible
        Me.MonthCalendar1.Tag = sender.name

    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        'MsgBox(Me.MonthCalendar1.BoldedDates. )
        Me.Controls(sender.tag).text = Me.MonthCalendar1.SelectionRange.Start.Date.Date
    End Sub

    Private Sub MonthCalendar1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthCalendar1.Validated
        Me.MonthCalendar1.Visible = False

    End Sub

    Private Sub Cyber_BusinessDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Cyber_BusinessDataGridView.RowValidated
        Try
            If My.Settings.DIRECT_SAVE = True Then Save_cyber()

        Catch ex As Exception
            Epx()
        End Try

    End Sub

    'Private Sub Cyber_BusinessDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cyber_BusinessDataGridView.KeyDown
    '    'GRID_PRESS_ON_COMBO(sender, e, "1")
    'End Sub


    Private Sub Cyber_BusinessDataGridView_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles Cyber_BusinessDataGridView.UserAddedRow
        Try
            If e.Row.Index >= 0 Then Me.Cyber_BusinessDataGridView(13, e.Row.Index).Value = CBool("False")
            PCID_Getting()

        Catch ex As Exception
            Epx("Error Occur On User Row Adding,Err 53")
        End Try
        ' pc id information
        'information checking

        'Dim Access As String = AukF.GridT(Me.Cyber_BusinessDataGridView, 3, -1, "")

        'Dim ExitTime As String = AukF.GridT(Me.Cyber_BusinessDataGridView, 4, -1, "")

        'If ExitTime = "" And Access <> "" Then
        'mean customer is connected

        'End If


        '----
    End Sub
    Private Sub PCID_Adding() 'for edit - pc id coulm add on correct pc id field customer count
        Dim PCID As String = AukF.GridT(Me.Cyber_BusinessDataGridView, 1)
        Dim RmK As DataRow
        Dim eNDTime As String = AukF.GridT(Me.Cyber_BusinessDataGridView, 4)
        If eNDTime = "" Then 'only if it matters when customer is still using net
            RmK = ADSRC.FIND_FROM_DATATABLE(PCTable, PCID)
            RmK.Item("UserCount") = Val(RmK.Item("UserCount").ToString) + 1
            RmK.EndEdit()
        End If

    End Sub
    Private Sub PCID_Getting()
        On Error GoTo b
        If Me.PCVirView.Count > 0 Then
            Refresh_PCIDCount = 0
            Me.Cyber_BusinessDataGridView.CurrentRow.Cells(1).Value = PCVirView.Item(0).Item("PC_ID") 'datagrid pcid = filtered pc ids first id
            PCVirView.Item(0).Item("UserCount") = Val(PCVirView.Item(0).Item("UserCount").ToString) + 1
            If Me.PCVirView.Count > 0 Then PCVirView.Item(0).EndEdit()
        End If
        If Me.PCVirView.Count = 0 AndAlso Refresh_PCIDCount <= 2 Then
            Me.PCTable_Ref(False)
            Refresh_PCIDCount += 1
        End If
        Exit Sub

b:
        Me.PCTable_Ref(False)
        'ViewInfo2.DataGrid2.DataSource = Me.PCVirView
        'ViewQuery.DataGrid1.DataSource = Me.PCVirView
        ''FrmL(ViewInfo2)
        'FrmL(ViewQuery)

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.Control = True And e.Shift = True And e.KeyCode = Keys.Enter Then
            SoftIn.BindFilterByAdvanceCategory(Me.Cyber_BusinessBindingSource, Me.ColName.Text, sender.text, False, False, True)
            'MsgBox("Any")
        ElseIf e.Control = True And e.KeyCode = Keys.Enter Then
            SoftIn.BindFilterByAdvanceCategory(Me.Cyber_BusinessBindingSource, Me.ColName.Text, sender.text, False, True)
        ElseIf e.KeyCode = Keys.Enter Then
            SoftIn.BindFilterByAdvanceCategory(Me.Cyber_BusinessBindingSource, Me.ColName.Text, sender.text, True)
        ElseIf e.Control = True And e.KeyCode = Keys.R Then
            Me.Cyber_BusinessBindingSource.RemoveFilter()
        End If
    End Sub
    Public Sub SaveAuto()
        Me.Save_cyber()

    End Sub
    Private Sub Query_SearchShow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        DVDRENT.ShowQr_Product(Me.Cyber_BusinessDataGridView, Me.Cyber_BusinessBindingSource, "", Me)
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        AukF.BindFind(Me.Cyber_BusinessBindingSource, "Costomer_Name", sender.text, True, Me.Cyber_BusinessDataGridView)

    End Sub
    Private Sub ReMoveFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReMoveFilter.Click
        Me.Cyber_BusinessBindingSource.RemoveFilter()
        Me.ReMoveFilter.Visible = False
    End Sub
    Private Sub AukNSummary(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox7.KeyDown, ToolStripTextBox9.KeyDown, ToolStripTextBox8.KeyDown
        CSOFT.Events_of_SummaryTextBox_KeyDown(Me, sender, e, Me.AukDatabaseDataSet.Cyber_Business, "Date_of_Business")
    End Sub
  
    Private Sub DueCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox10.KeyDown, ToolStripTextBox14.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me) = False Then Exit Sub
            SFC("costomer_name", "Due")
            STC(sender.text, "True")
            'ExpreC("", "b")
            DTC("", "b") 'type boolean
            If e.Control = True And e.Shift = True Then
                ExpreC("*L*") 'anywhere
            ElseIf e.Control = True And e.Shift = False Then
                ExpreC("L*") 'fextact
            Else
                'nothing 'extact
            End If
            AukF.Db_LoadN(Me.AukDatabaseDataSet.Cyber_Business, -1, "", True, 0)
            Me.Exe_CuteQ() 'execute for pctable refresh

            'MsgBox(Sql)

        End If

    End Sub
    Private Sub dUEcHEKC_CLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TILLDUEToolStripMenuItem.Click, TODAYSDUEToolStripMenuItem1.Click
        'check that db is chg or not ,want to save or not
        If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me) = True Then
            'adding after because in  ShowDueByDate(ByVal D1 As String) , first is date function
            SFC("", "Due")
            STC("", "True")
            DTC("", "b")
            If sender.TAG = "today" Then
                ShowDueByDate(NDate)
            Else
                AukF.Db_LoadN(Me.AukDatabaseDataSet.Cyber_Business)
            End If
        End If
    End Sub
    Private Sub ShowDueByDate(ByVal D1 As String)
        Dim D2 As Date
        If CSOFT.Date_Get_FromStr(D1) = True Then
            'check that db is chg or not ,want to save or not
            If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me) = True Then Exit Sub
            D2 = CDate(WGeT)
            SFC("Date_of_Business")
            STC(D2)
            DTC("d")
            AukF.Db_LoadN(Me.AukDatabaseDataSet.Cyber_Business)
        End If
    End Sub
    Private Sub ShowDueByMonth(ByVal D1 As String)
        Dim D2 As Date
        If CSOFT.Date_Get_FromStr(D1) = True Then
            'check that db is chg or not ,want to save or not
            If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me) = True Then Exit Sub
            D2 = CDate(WGeT)
            SFC("Date_of_Business", "Date_of_Business")
            STC(D2.Month, D2.Year)
            ExpreC("Month", "Year")
            DTC("n", "n")
            AukF.Db_LoadN(Me.AukDatabaseDataSet.Cyber_Business)
        End If
    End Sub
    Private Sub ShowDueByYear(ByVal Y As String)
        'Dim D2 As Date
        'If CSOFT.Date_Get_FromStr(D1) = True Then
        'check that db is chg or not ,want to save or not
        Try
            dx = Val(Y)
        Catch ex As Exception
            Epx()
            Exit Sub
        End Try
        If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me) = True Then Exit Sub
        D2 = CDate(WGeT)
        SFC("Date_of_Business")
        STC(dx)
        ExpreC("Year")
        DTC("n", "n")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.Cyber_Business)
        'End If
    End Sub

    Private Sub Due_Check_TextBOx_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox11.KeyDown, ToolStripTextBox13.KeyDown, ToolStripTextBox12.KeyDown
        If e.KeyCode = Keys.Enter Then
            m = sender.tag
            If m = "m" Then
                Me.ShowDueByMonth(sender.text)
            ElseIf m = "d" Then
                Me.ShowDueByDate(sender.text)
            ElseIf m = "y" Then
                Me.ShowDueByYear(sender.text)
            End If
        End If
    
    End Sub

    Private Sub FilterDueOnly_ToolTipx(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterDueToolStripMenuItem.Click
        AukF.BindFilter(Me.Cyber_BusinessBindingSource, "Due", "True")
    End Sub

    Private Sub SetDue(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Dim Bex As Boolean
        If Me.Cyber_BusinessDataGridView.CurrentRow IsNot Nothing Then
            Bex = SoftIn.Boolean_get(AukF.GridT(Me.Cyber_BusinessDataGridView, 15).ToString)
            If Bex = False Then
                If DRow > -1 Then Me.Cyber_BusinessDataGridView(15, DRow).Value = True
            Else
                MsgBox("It's Due Before.", MsgBoxStyle.Information)

            End If
            If My.Settings.DIRECT_SAVE = True Then Me.SaveAuto()

            '14=due
        End If
    End Sub

    Private Sub PaidDue(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Dim Bex As Boolean

        If Me.Cyber_BusinessDataGridView.CurrentRow IsNot Nothing Then
            Bex = SoftIn.Boolean_get(AukF.GridT(Me.Cyber_BusinessDataGridView, 15).ToString)
            If Bex = True Then
                If DRow > -1 Then Me.Cyber_BusinessDataGridView(15, DRow).Value = False
            Else
                MsgBox("It's Paid Before.", MsgBoxStyle.Information)

            End If
            If My.Settings.DIRECT_SAVE = True Then Me.SaveAuto()

            '14=due
        End If
    End Sub

    Private Sub LOADWHOLEDATABASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADWHOLEDATABASEToolStripMenuItem.Click
        If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me) = False Then Exit Sub
        ADSRC.LOAD_WHOLE_DATABASE(Me.AukDatabaseDataSet.Cyber_Business)
    End Sub

    Private Sub Cyber_BusinessDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Cyber_BusinessDataGridView.DataError
        GrdErrMsg(e)
    End Sub

    Private Sub BetweenDateDblClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox5.DoubleClick, ToolStripTextBox4.DoubleClick
        Me.MonthCalendar1.Tag = sender.name
        Me.MonthCalendar1.Visible = True
    End Sub

    Private Sub ToolStripTextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox14.TextChanged
        AukF.BindFind(Me.Cyber_BusinessBindingSource, "Costomer_Name", sender.text, True)
    End Sub

    Private Sub Cyber_BusinessDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cyber_BusinessDataGridView.KeyDown
        Me.InformationView()

    End Sub

    Private Sub Cyber_BusinessDataGridView_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Cyber_BusinessDataGridView.CellEnter
        Try
            Me.InformationView()
        Catch ex As Exception
            Epx("Cell Enter ,Err 52")
        End Try
    End Sub

    Private Sub Cyber_BusinessDataGridView_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles Cyber_BusinessDataGridView.RowsRemoved
        Try
            Me.PCTable_Ref()

        Catch ex As Exception
            Epx("Rows Removed ,Err 51")
        End Try
    End Sub

    Private Sub Cyber_BusinessDataGridView_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles Cyber_BusinessDataGridView.CellBeginEdit
        Try
            If e.ColumnIndex = 1 Then
                Me.Customer_Exit()
            End If
        Catch ex As Exception
            Epx()
        End Try
       


    End Sub

    Private Sub RefreshPCIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshPCIDToolStripMenuItem.Click
        Try
            Me.PCTable_Ref(True)
            Me.PCTable_Ref(False)
        Catch ex As Exception
            Epx()
        End Try


    End Sub

  
    Private Sub ToolStripTextBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox14.Click

    End Sub
End Class