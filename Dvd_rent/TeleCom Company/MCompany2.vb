Public Class MCompany
    Dim SFrm As String = "Mobile_R_QuickSummary"
    Public NeedToRe As Boolean = False
    Private Sub Mob_ComBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mob_ComBindingNavigatorSaveItem.Click
        sAVE_MOB()
        If NewTrans.Visible = True Then
            NewTrans.Telecom_CompanyRefreshes()
        End If


    End Sub
    Public Sub sAVE_MOB()
        Try
            Me.Validate()
            Me.Mob_ComBindingSource.EndEdit()
            Me.Mob_ComTableAdapter.Update(Me.AukDatabaseDataSet.Mob_Com)
            If NewTrans.Visible = True Then NewTrans.NeedToRe = True
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub MCompany_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If NeedToRe = True Then
            Me.Mob_ComTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Com)
            NeedToRe = False
        End If
    End Sub
    Private Sub MCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Mob_ComTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Com)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.Mob_ComBindingSource, True)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        AukF.DeleteFromMasterTable(Me.Mob_ComBindingSource, 0)
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Me.Hide()
    End Sub
    Public Sub OpenByYear(ByVal D1 As String)
        Dim D2 As Integer
        Dim Tn As DataTable
        Dim G As DataGridView = Mob_ComDataGridView
        Try
            D2 = Val(D1)
        Catch ex As Exception
            MsgBox("Please Insert a Valid Integer Year.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        SFC("Year")
        STC(D2)
        DTC("n")
        Me.DateInfo.Text = "Summary By Year : " & (D2)
        'Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "[CID],[company],[benefit P],[status category],[Year]", "[CID],[company],[benefit P],Sum([Discount]) as Discount,Sum([Extra]) as Extra,[status category]", True) 'sfrm=mob summary form name
        Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "[CID],[company],[benefit P],[status category],[Year]", "[CID],[company],[benefit P],Sum([Discount]) as Discount,Sum([Extra]) as Extra,[status category],Sum([Current Benefit]) as [Current Benefit]", True) 'sfrm=mob summary form name
        Query_Expendation(Tn)
    End Sub
    Public Sub OpenByMonth(ByVal D1 As String)
        Dim D2 As Date
        Dim Tn As DataTable
        Dim G As DataGridView = Mob_ComDataGridView
        Try
            D2 = CDate(CDate(D1))
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.To get Month & Year from It. Day is not a fact but without day it will not be a vaild date..", MsgBoxStyle.Information)
            Exit Sub
        End Try
        SFC("Month", "Year")
        STC(D2.Month, D2.Year)
        DTC("n", "n")
        Me.DateInfo.Text = "Summary By Month : " & SoftIn.AukDateGet_monthOnly(D2)
        'Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "[CID],[company],[benefit P],[status category],[Year],[month]", "[CID],[company],[benefit P],Sum([Discount]) as Discount,Sum([Extra]) as Extra,[status category]", True) 'sfrm=mob summary form name
        Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "[CID],[company],[benefit P],[status category],[Year],[month]", "[CID],[company],[benefit P],Sum([Discount]) as Discount,Sum([Extra]) as Extra,[status category],Sum([Current Benefit]) as [Current Benefit]", True) 'sfrm=mob summary form name
        'Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "[CID],[company],[benefit P],[status category],[Business Date]", "[CID],[company],[benefit P],Sum([Discount]) as Discount,Sum([Extra]) as Extra,[status category],Sum([Current Benefit]) as [Current Benefit]", True) 'sfrm=mob summary form name
        Query_Expendation(Tn)
    End Sub
    Public Sub TotalSummary()
        Dim Tn As New DataTable("Mob_Whole_Summary")
        Dim BpP, AmT, DuE, BeneFit, CurB As Decimal
        Dim G As DataGridView = Mob_ComDataGridView
        Dim CoM As String
        AukF.Db_LoadN(Tn)
        'Tn = Me.AukDatabaseDataSet.Mob_Whole_Summary
        'Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "[CID],[company],[benefit P],[status category],[Business Date]", "[CID],[company],[benefit P],Sum([Discount]) as Discount,Sum([Extra]) as Extra,[status category]", True) 'sfrm=mob summary form name
        Dim ExTRA, DiscoUNT As Decimal
        Me.DateInfo.Text = "Total Summary"
        Makeing_Mob_Com_NullValue()
        sAVE_MOB() 'SAVING
        Me.ToolStripProgressBar1.Maximum = Tn.Rows.Count
        ToolStripProgressBar1.Visible = True
        ToolStripProgressBar1.Value = 0
        For N As Integer = 0 To Tn.Rows.Count - 1
            If Tn.Rows(N).Item(6).ToString = "SEND" Then 'get status - BENEFIT
                AmT = Val(Tn.Rows(N).Item(3).ToString) 'value of amount
                BpP = Val(Tn.Rows(N).Item(2).ToString) 'benefit percent=2
                CoM = Tn.Rows(N).Item(0).ToString 'cid
                If AmT <> 0 Then
                    BeneFit = AmT * (BpP / 100) 'geting benefit
                    BeneFit = Format(BeneFit, "0.##")
                Else
                    BeneFit = 0
                End If
                DiscoUNT = Val(Tn.Rows(N).Item(5).ToString)
                ExTRA = Val(Tn.Rows(N).Item(4).ToString)
                BeneFit = Format(BeneFit - DiscoUNT + ExTRA, "0.##")
                CurB = Val(Tn.Rows(N).Item(7).ToString) 'current benefit
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Mob_Com, CoM) = True Then
                    'doing in mob_com
                    RowX(7) = Val(RowX(7)) + BeneFit 'benefit set
                    RowX(9) = Val(RowX(9).ToString) + AmT 'send amount only
                    RowX(10) = Val(RowX(10).ToString) + CurB 'ori benefit
                    RowX(11) = Val(RowX(11).ToString) + DiscoUNT 'ori benefit
                End If
            ElseIf Tn.Rows(N).Item(6).ToString = "SEND BUT NOT PAID YET" Then 'get status-DUE
                DuE = Val(Tn.Rows(N).Item(3).ToString)   'COLLECTING DUE IN AMT
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Mob_Com, CoM) = True Then
                    RowX(3) = Val(RowX(3)) + DuE 'SET DUE ,DUE =DIGITS FIND FIELD
                End If
            End If
            Me.ToolStripProgressBar1.Value = Me.ToolStripProgressBar1.Value + 1
        Next
        ToolStripProgressBar1.Visible = False
        For XQ As Integer = 0 To Me.AukDatabaseDataSet.Mob_Com.Rows.Count - 1
            BeneFit = Val(Me.AukDatabaseDataSet.Mob_Com(XQ).Item("BENEFIT_").ToString)
            DuE = Val(Me.AukDatabaseDataSet.Mob_Com(XQ).Item("Digits_Find").ToString)
            If BeneFit < DuE Then
                Me.AukDatabaseDataSet.Mob_Com(XQ).LOSS = (BeneFit - DuE) * -1
            End If
        Next
        sAVE_MOB() 'SAVING
    End Sub
    Public Sub OpenByBetweenDate(ByVal D1 As String, ByVal D2 As String, Optional ByVal FilterDue As Boolean = False)
        Dim D3, D4 As Date
        Dim Tn As DataTable
        Dim G As DataGridView = Mob_ComDataGridView
        Try
            D3 = CDate(CDate(D1))
            D4 = CDate(CDate(D2))
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        Me.DateInfo.Text = "Query on Date Between : " & D3 & " AND " & D4
        SFC("business date")
        STC(D3 & "," & D4)
        DTC("d")
        ExpreC("b")
        'Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "[CID],[company],[benefit P],[status category],[Business Date]", "[CID],[company],[benefit P],Sum([Discount]) as Discount,Sum([Extra]) as Extra,[status category],Sum([Current Benefit]) as [Current Benefit]", True) 'sfrm=mob summary form name
        Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "[CID],[company],[benefit P],[status category],[Business Date]", "[CID],[company],[benefit P],Sum([Discount]) as Discount,Sum([Extra]) as Extra,[status category],Sum([Current Benefit]) as [Current Benefit]", True) 'sfrm=mob summary form name
        Query_Expendation(Tn)
    End Sub
    Public Sub Query_Expendation(ByVal Tn As DataTable)
        Dim BpP, AmT, DuE, BeneFit, CurB As Decimal
        Dim G As DataGridView = Mob_ComDataGridView
        Dim CoM As String
        'Mob_Com Table
        'DIGITS FIND=DUE=3
        'BENEFIT=7
        'LOSS=8
        '9=send amount
        '10=ori.benefit
        '11=discount
        '--------------
        'Open Table
        '0=cid
        '1=company
        '2=b %
        '3=sum dis
        '4=sum extra
        '5=[status category]
        '6=current Benefit
        '7=sum amount
        'NOW PUTTING VALUES IN DATABASE
        'Dim Rnx() As DataRow
        Dim ExTRA, DiscoUNT As Decimal
        Makeing_Mob_Com_NullValue() 'giving all summary field=0
        sAVE_MOB() 'SAVING
        Me.ToolStripProgressBar1.Maximum = Tn.Rows.Count
        ToolStripProgressBar1.Visible = True
        ToolStripProgressBar1.Value = 0
        For N As Integer = 0 To Tn.Rows.Count - 1
            If Tn.Rows(N).Item(5).ToString = "SEND" Then 'get status - BENEFIT
                AmT = Val(Tn.Rows(N).Item(7).ToString) 'value of amount
                BpP = Val(Tn.Rows(N).Item(2).ToString) 'benefit percent=2
                CoM = Tn.Rows(N).Item(0).ToString
                If AmT = 0 Then
                    BeneFit = 0
                Else
                    BeneFit = AmT * (BpP / 100) 'geting benefit
                    BeneFit = Format(BeneFit, "0.##")
                End If
         
                DiscoUNT = Val(Tn.Rows(N).Item(3).ToString)
                ExTRA = Val(Tn.Rows(N).Item(4).ToString)
                BeneFit = Format(BeneFit - DiscoUNT + ExTRA, "0.##")
                CurB = Val(Tn.Rows(N).Item(6).ToString) 'current benefit
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Mob_Com, CoM) = True Then
                    RowX(7) = Val(RowX(7)) + BeneFit 'benefit set
                    RowX(9) = Val(RowX(9).ToString) + AmT 'send amount only
                    RowX(10) = Val(RowX(10).ToString) + CurB 'ori benefit
                    RowX(11) = Val(RowX(11).ToString) + DiscoUNT 'ori benefit
                End If
            ElseIf Tn.Rows(N).Item(5).ToString = "SEND BUT NOT PAID YET" Then 'get status-DUE
                'COLLECT DUE
                'company id=0,comname=1
                DuE = Val(Tn.Rows(N).Item(7).ToString)   'COLLECTING DUE IN AMT
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Mob_Com, CoM) = True Then
                    RowX(3) = Val(RowX(3)) + DuE 'SET DUE ,DUE =DIGITS FIND FIELD
                End If
            End If
            Me.ToolStripProgressBar1.Value = Me.ToolStripProgressBar1.Value + 1
        Next
        ToolStripProgressBar1.Visible = False
        For XQ As Integer = 0 To Me.AukDatabaseDataSet.Mob_Com.Rows.Count - 1
            BeneFit = Val(Me.AukDatabaseDataSet.Mob_Com(XQ).Item("BENEFIT_").ToString)
            DuE = Val(Me.AukDatabaseDataSet.Mob_Com(XQ).Item("Digits_Find").ToString)
            If BeneFit < DuE Then
                Me.AukDatabaseDataSet.Mob_Com(XQ).LOSS = (BeneFit - DuE) * -1
            End If
        Next
        sAVE_MOB() 'SAVING
    End Sub
    Public Sub Makeing_Mob_Com_NullValue()
        For XQ As Integer = 0 To Me.AukDatabaseDataSet.Mob_Com.Rows.Count - 1
            Me.AukDatabaseDataSet.Mob_Com(XQ).Digits_Find = 0
            Me.AukDatabaseDataSet.Mob_Com(XQ).BENEFIT_ = 0
            Me.AukDatabaseDataSet.Mob_Com(XQ).LOSS = 0
            Me.AukDatabaseDataSet.Mob_Com(XQ).SEND_AMOUNT = 0
            Me.AukDatabaseDataSet.Mob_Com(XQ).OBENEFIT_ = 0
            Me.AukDatabaseDataSet.Mob_Com(XQ).Discount_ = 0
        Next
    End Sub
    Public Sub OpenByDate(ByVal D1 As String, Optional ByVal FilterDue As Boolean = False)
        Dim D2 As Date
        Dim Tn As DataTable
        Dim BpP As Decimal
        Dim G As DataGridView = Mob_ComDataGridView
        Try
            D2 = CDate(CDate(D1))
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        'MsgBox(D2)
        'Mob_Com Table
        'DIGITS FIND=DUE=3
        'BENEFIT=7
        'LOSS=8
        '9=send amount
        '10=ori.benefit
        '11=discount
        Me.DateInfo.Text = "Summary By Date : " & SoftIn.AukDateGet(D2)
        BpP = Val(AukF.GridT(G, 3)) 'GET % BENEFIT
        SFC("business date")
        STC(D2)
        DTC("d")
        Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "[CID],[company],[benefit P],[status category],[Business Date]", "[CID],[company],[benefit P],Sum([Discount]) as Discount,Sum([Extra]) as Extra,[status category],Sum([Current Benefit]) as [Current Benefit]", True) 'sfrm=mob summary form name
        Query_Expendation(Tn)
    End Sub

    Private Sub MCompany_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If SAVMSG() = 1 Then
                Mob_ComBindingNavigatorSaveItem_Click(sender, e)
            ElseIf SavInt = 2 Then
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub CurrentMonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentMonthToolStripMenuItem.Click
        OpenByMonth(NDate)
    End Sub

    Private Sub OpenDays(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesterdayToolStripMenuItem.Click, TodayToolStripMenuItem.Click, TheDayAfterYesterdayToolStripMenuItem.Click, ToolStripLabel1.ButtonClick
        Me.OpenByDate(CDate(Now.Date).AddDays(Val(sender.tag)))

    End Sub
 
    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.OpenByDate(sender.text)
        End If
    End Sub

    Private Sub CurrentYearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentYearToolStripMenuItem.Click
        OpenByYear(Now.Year)
    End Sub

    Private Sub YearDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            OpenByYear(sender.text)
        End If
    End Sub

    Private Sub MonthDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            OpenByMonth(sender.text)
        End If
    End Sub

    Private Sub TotalDBSummary(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.TotalSummary()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        OpenByBetweenDate(Date1_.Text, Date2.Text)

    End Sub

    Private Sub Donw_Bet(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Date2.KeyDown, Date1_.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripMenuItem3_Click(sender, e)
        End If
    End Sub
End Class