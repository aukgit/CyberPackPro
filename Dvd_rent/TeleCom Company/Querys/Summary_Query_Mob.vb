Public Class Summary_Query_Mob

    Private Sub LoadWholeDatabaseSummarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadWholeDatabaseSummarToolStripMenuItem.Click, ToolStripMenuItem11.Click
        AukF.Db_LoadN(Me.AukDatabaseDataSet.Mobile_ReCharge_Summary)

    End Sub
    Public Sub OpenByYear(ByVal Y As Integer, Optional ByVal FilterDue As Boolean = False)
        SFC("Year")
        STC(Y)
        DTC("n")
        If FilterDue = True Then
            SFC("", "Status Category")
            STC("", "SEND BUT NOT PAID YET")
        End If
        Me.DATE_INFO.Text = "Query on Year:" & Y
        AukF.Db_LoadN(Me.AukDatabaseDataSet.Mobile_ReCharge_Summary)
        FrmL(Me)
    End Sub
    Public Sub OpenByDate(ByVal D1 As String, Optional ByVal FilterDue As Boolean = False)
        Dim D2 As Date
        Try
            D2 = CDate(CDate(D1))
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        'MsgBox(D2)
        SFC("business date")
        STC(D2)
        DTC("d")
        If FilterDue = True Then
            SFC("", "Status Category")
            STC("", "SEND BUT NOT PAID YET")
        End If
        Me.DATE_INFO.Text = "Query on Date:" & SoftIn.AukDateGet(D2)
        AukF.Db_LoadN(Me.AukDatabaseDataSet.Mobile_ReCharge_Summary)
        FrmL(Me)
    End Sub
    Public Sub OpenByBetweenDate(ByVal D1 As String, ByVal D2 As String, Optional ByVal FilterDue As Boolean = False)
        Dim D3 As Date
        Dim D4 As Date

        Try
            D3 = CDate(CDate(D1))
            D4 = CDate(CDate(D2))
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        SFC("business date")
        STC(D3 & "," & D4)

        If FilterDue = True Then
            SFC("", "Status Category")
            STC("", "SEND BUT NOT PAID YET")
        End If
        DTC("d") 'for type of date'd"
        ExpreC("b") 'for the between function 'b'
        AukF.Db_LoadN(Me.AukDatabaseDataSet.Mobile_ReCharge_Summary)
        'MsgBox(Sql)
        Me.DATE_INFO.Text = "Query on Date Between:" & D3 & " AND " & D4
        FrmL(Me)
    End Sub
    Public Sub OpenByMonth(ByVal D1 As String, Optional ByVal FilterDue As Boolean = False)
        Dim D2 As Date
        Try
            D2 = CDate(CDate(D1))
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.Like as 5/2/2008, if date format(d/M/yyyy).It means we select 2008.February,but you have to insert a day.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        dis = DateAndTime.DateDiff(DateInterval.Month, CDate(Now.Date), D2)
        SFC("Month Distance")
        STC(dis)
        If FilterDue = True Then
            SFC("", "Status Category")
            STC("", "SEND BUT NOT PAID YET")
        End If
        DTC("n") 'for type of number'n"
        'ExpreC(") 'f1=func-1=ext word
        AukF.Db_LoadN(Me.AukDatabaseDataSet.Mobile_ReCharge_Summary)
        FrmL(Me)
        Me.DATE_INFO.Text = "Query on Month:" & SoftIn.AukDateGet_monthOnly(D2)
        'MsgBox(Sql)
    End Sub
    Private Sub TodayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodayToolStripMenuItem.Click, ToolStripButton8.ButtonClick, ToolStripMenuItem9.Click
        TODAY_SUMMARY()
    End Sub
    Public Sub TODAY_SUMMARY()
        Me.OpenByDate(CDate(Now.Date), Me.FILTER_DUE_cHECKED.Checked)
    End Sub

    Private Sub YesterdayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesterdayToolStripMenuItem.Click, ToolStripMenuItem8.Click
        Me.OpenByDate(CDate(Now.Date).AddDays(-1), Me.FILTER_DUE_cHECKED.Checked)
    End Sub

    Private Sub TheDayAfterYesterdayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheDayAfterYesterdayToolStripMenuItem.Click, ToolStripMenuItem7.Click
        Me.OpenByDate(CDate(Now.Date).AddDays(-2), Me.FILTER_DUE_cHECKED.Checked)
    End Sub

    Private Sub CurrentMonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentMonthToolStripMenuItem.Click, ToolStripMenuItem6.Click
        Me.OpenByMonth(CDate(Now.Date))
    End Sub

   
    Private Sub ToolStripTextBox5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.OpenByMonth(sender.text, Me.FILTER_DUE_cHECKED.Checked)

        End If
    End Sub

    Private Sub QUERYMANAGERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QUERYMANAGERToolStripMenuItem.Click, ToolStripMenuItem15.Click
        DVDRENT.ShowQr_Product(Me.Mobile_ReCharge_SummaryDataGridView, Me.Mobile_ReCharge_SummaryBindingSource)


    End Sub

   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Mobile_ReCharge_SummaryBindingSource.Filter Is Nothing Then
            If Me.FILTER_CHECKED_BUT.Checked = True Then
                Me.FILTER_CHECKED_BUT.Checked = False
            End If
        Else
            If Me.FILTER_CHECKED_BUT.Checked = False Then
                Me.FILTER_CHECKED_BUT.Checked = True
            End If
        End If
    End Sub
    Public Sub SHOW_DETAILS()
        Dim D As DataGridView = Me.Mobile_ReCharge_SummaryDataGridView
        If D.CurrentRow Is Nothing Then Exit Sub
        If NewTrans.AukDatabaseDataSet.HasChanges = True Then
            If AukF.MsgTr("DO YOU WANT TO SAVE THOSE EDITED INFORMATION IN (RECHARGE)?", False, MsgBoxStyle.Information) = 1 Then
                NewTrans.SAVE_MOBS()
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
            Me.Mob_ComTableAdapter1.Fill(Me.AukDatabaseDataSet.Mob_Com)
            D1 = CDate(AukF.GridT(D, 5))
            COM = AukF.GridT(D, 0).ToString
            If AukF.BindFind(Me.MobComBindingSource, "COMPANY", COM) = True Then
                COM = Me.AukDatabaseDataSet.Mob_Com(ComRow).Category_ID.ToString
            Else
                MsgBox("Can't query,Because Category is not Found.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            STATUS = AukF.GridT(D, 6).ToString 'STATUS
            SFC("CATAGORY_ID", "DATE_BUSINESS", "STATUS") 'CATEGORY IS RIGHT
            DTC("", "d")
            STC(COM, D1, STATUS)
            If STATUS = "" Then ExpreC("", "", "NULL")
            'MsgBox(SF(2).ToString)
            NewTrans.AukDatabaseDataSet.New_Trans.Clear()
            AukF.Db_LoadN(NewTrans.AukDatabaseDataSet.New_Trans, -1, "", True)
            'MsgBox(Sql)
            NewTrans.New_TransBindingSource.RemoveFilter()
            NewTrans.Load_Sum = True
            'NewTrans.Visible = True
            FrmL(NewTrans)
            'A = A
        Catch ex As Exception
            Epx()
        End Try
    End Sub
    Private Sub Summary_Query_Mob_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Mobile_ReCharge_Summary' table. You can move, or remove it, as needed.
        Me.Mobile_ReCharge_SummaryTableAdapter.Fill(Me.AukDatabaseDataSet.Mobile_ReCharge_Summary)
        Me.Mob_ComTableAdapter1.Fill(Me.AukDatabaseDataSet.Mob_Com)
        AukF.AukDataSourceSetObjectListOrComboType(Me.TELECOMCOMPANYS, Me.MobComBindingSource, 1, True, True)
        Me.Mobile_ReCharge_SummaryBindingSource.RemoveFilter()
    End Sub

    Private Sub TELECOMCOMPANYS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TELECOMCOMPANYS.SelectedIndexChanged
        AukF.BindFilter(Me.Mobile_ReCharge_SummaryBindingSource, "COMPANY", sender.TEXT)
    End Sub

    Private Sub FILTER_CHECKED_BUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTER_CHECKED_BUT.Click
        If Me.Mobile_ReCharge_SummaryBindingSource.Filter Is Nothing Then AukF.BindFilter(Me.Mobile_ReCharge_SummaryBindingSource, "COMPANY", Me.TELECOMCOMPANYS.Text) Else Me.Mobile_ReCharge_SummaryBindingSource.RemoveFilter()
    End Sub

  
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        SHOW_DETAILS()
     

    End Sub

    Private Sub Mobile_ReCharge_SummaryDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Mobile_ReCharge_SummaryDataGridView.CellDoubleClick
        SHOW_DETAILS()
    End Sub

    Private Sub ToolStripTextBox4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then Me.OpenByDate(sender.text, Me.FILTER_DUE_cHECKED.Checked)
    End Sub

    Private Sub ToolStripTextBox3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then Me.OpenByYear(Val(sender.text))
    End Sub

    Private Sub FilterSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterSelectedToolStripMenuItem.Click, ToolStripMenuItem13.Click
        ADSRC.DATAGRID_ADVANCE_SELECTED_FILTER(Me.Mobile_ReCharge_SummaryDataGridView, Me.Mobile_ReCharge_SummaryBindingSource)

    End Sub

    Private Sub CurrentYearSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentYearSummaryToolStripMenuItem.Click, ToolStripMenuItem5.Click
        Me.OpenByYear(Now.Year, Me.FILTER_DUE_cHECKED.Checked)
    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click, ToolStripMenuItem14.Click
        Me.Mobile_ReCharge_SummaryBindingSource.RemoveFilter()
    End Sub

    Private Sub ClearDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearDatabaseToolStripMenuItem.Click, ToolStripMenuItem16.Click
        Me.AukDatabaseDataSet.Clear()
    End Sub

    Private Sub show_print(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click, ToolStripButton2.Click, ToolStripMenuItem10.Click
        Dim M As New MOBILE_SUMMARY
        AukF.Prnt(M, Me.AukDatabaseDataSet, Me.Mobile_ReCharge_SummaryBindingSource)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.OpenByBetweenDate(DATE1_.Text, DATE2_.Text, Me.FILTER_DUE_cHECKED.Checked)
    End Sub

    
    Private Sub BETWEEN_RUN(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DATE2_.KeyDown, DATE1_.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.OpenByBetweenDate(DATE1_.Text, DATE2_.Text, Me.FILTER_DUE_cHECKED.Checked)

        End If

    End Sub
End Class