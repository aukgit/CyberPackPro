Public Class StockI_mob
    Public NeedToRe As Boolean = False
    Private Sub DaY_Sold_InfoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaY_Sold_InfoBindingNavigatorSaveItem.Click
        Save()
    End Sub
    Private Sub Save()
        Try
            Me.Validate()
            Me.DaY_Sold_InfoBindingSource.EndEdit()
            Me.DaY_Sold_InfoTableAdapter.Update(Me.AukDatabaseDataSet.DaY_Sold_Info)
            If NewTrans.Visible = True Then NewTrans.NeedToStockRe = True
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub StockI_mob_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If NeedToRe = True Then
            SFC("Date_info")
            STC(NDate)
            DTC("d")
            AukF.Db_LoadN(Me.AukDatabaseDataSet.DaY_Sold_Info)
            NeedToRe = False

        End If
      
    End Sub

    Private Sub StockI_mob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.DaY_Sold_Info' table. You can move, or remove it, as needed.
        'Me.DaY_Sold_InfoTableAdapter.Fill(Me.AukDatabaseDataSet.DaY_Sold_Info)
        SFC("Date_info")
        STC(NDate)
        DTC("d")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.DaY_Sold_Info)
    End Sub

    Private Sub ToolStripLabel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripLabel1.MouseDown
        AukF.DragAuk(Me)
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.DaY_Sold_InfoBindingSource, True)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        ADD_N_FUNC()
    End Sub
    Public Sub ADD_N_FUNC()
        SFC("Date_info")
        STC(Dat2(NDate))
        DTC("d")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.DaY_Sold_Info, -1, "", False)
        If AukF.BindFind(Me.DaY_Sold_InfoBindingSource, "Date_info", Dat2(Me.Date_InfoDateTimePicker.Value), True) = False Then
            Me.DaY_Sold_InfoBindingSource.AddNew()
            Me.Date_InfoDateTimePicker.Value = NDate()
            Me.Todays_BenefitTextBox.Text = 0
            Me.Todays_ExpenseTextBox.Text = 0
            Me.Todays_Paid_DueTextBox.Text = 0
        End If
    End Sub

    Private Sub keyDownEvt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Todays_Paid_DueTextBox.KeyDown, Todays_ExpenseTextBox.KeyDown, Todays_BenefitTextBox.KeyDown, Date_InfoDateTimePicker.KeyDown, Todays_BenefitTextBox2.KeyDown
        SoftIn.KEY_DOWN_EVENTS(sender, e, Me.DaY_Sold_InfoBindingSource, Me.Date_InfoDateTimePicker, Me.Todays_ExpenseTextBox.Name, False, False, True, True)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Date_Of_Stock(Dat2(Me.Date_InfoDateTimePicker.Value))
    End Sub
    Public Sub Date_Of_Stock(ByVal D1 As Date)
        Dim D2 As Date
        Dim RbX As DataRow
        Try
            D2 = CDate(CDate(D1))
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        SFC("Date_info")
        STC(Dat2(D2))
        DTC("d")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.DaY_Sold_Info, -1, "", False)
        RbX = ADSRC.FIND_FROM_DATATABLE(Me.AukDatabaseDataSet.DaY_Sold_Info, Dat2(D1))
        If RbX IsNot Nothing Then 'RBX IS A ROW OF DAY_SOLD INFO
            Dim CStock, bENEFITx, MStock, PDue, CSell, TDue, CCount, Expense, Total, Extra, Discount As Decimal
            Dim CStockStr, MStockStr, PdueStr, CSellstr, TDueStr, CCountStr, ExpenseStr, ExtraStr, DiscountStr As String
            CStockStr = "Products Selling In Shop: "
            MStockStr = ", Mobile Recharge(Without Due)[Paid Only]: "
            ExtraStr = ", [Mobile & Cards] Extra Amount: "
            DiscountStr = ", [Mobile & Cards] Discount Amount: "
            TDueStr = ", Due: "
            PdueStr = ", Paid Due: "
            CSellstr = ", Cards Sold Price(Without Due): "
            CCountStr = ", Cards Number of Selling(With Due): "
            ExpenseStr = ", Shop Expense: "
            CStock = Val(RbX.Item(1).ToString) '1=todays benefit = todays selling
            'getting mob rechg total amout of date
            SFC("Status", "Date_business")
            STC("SEND", D2)
            DTC("", "d")
            MStock = Val(ADSRC.Summary_Totals("New_Trans", "Amount", "SUM"))
            'finx
            'mobile Disocunt
            SFC("Date_business")
            STC(D2)
            DTC("d")
            Discount = Val(ADSRC.Summary_Totals("New_Trans", "DIscount", "SUM")) 'dicount
            'mobile extra
            SFC("Date_business")
            STC(D2)
            DTC("d", "b")
            Extra = Val(ADSRC.Summary_Totals("New_Trans", "ExtraMoney", "SUM")) 'dicount
            'geting Today Paid by Textbox
            PDue = Val(RbX.Item(2).ToString) '2=PAID DUE IN DAY_SOLD_INFO
            'getting cards selling total amout of date
            SFC("Date", "Due")
            STC(D2, "False")
            DTC("d", "b")
            CSell = Val(ADSRC.Summary_Totals(Me.AukDatabaseDataSet.CID_Cards_Benefit, "Total Stock Money", "SUM"))
            'card count
            SFC("Date", "Due")
            STC(D2, "False")
            DTC("d", "b")
            CCount = Val(ADSRC.Summary_Totals(Me.AukDatabaseDataSet.CardBenefitMob, "Count Amount", "SUM")) 'count amt is card count of current category
            'todays due
            SFC("Business Date", "Status CATEGORY")
            STC(D2, "SEND BUT NOT PAID YET")
            DTC("d")
            TDue = Val(ADSRC.Summary_Totals(Me.AukDatabaseDataSet.Mobile_R_QuickSummary, "Amount", "SUM")) 'due,cause filtered by Send But Not paid yet
            'finx
            Expense = Val(RbX.Item(3).ToString) '3=EXPENSE
            Total = CStock + MStock + Discount + Extra + PDue + CSell - Expense '
            Me.StockMoneyShow.Text = CStockStr & CStock & CCountStr & CCount & MStockStr & MStock & ExtraStr & Extra & DiscountStr & Discount & TDueStr & TDue & PdueStr & PDue & CSellstr & CSell & ExpenseStr & Expense & ", Total: " & Total
            'stat benefit season
            SFC("business Date")
            STC(D2)
            DTC("d")
            MStock = Val(ADSRC.Summary_Totals(Me.AukDatabaseDataSet.Mobile_R_QuickSummary, "Current Benefit", "SUM")) 'mobile recharge benefit
            SFC("date")
            STC(D2)
            DTC("d")
            CStock = Val(ADSRC.Summary_Totals(Me.AukDatabaseDataSet.CID_Cards_Benefit, "Benefit", "SUM")) 'mobile cards benefit
            bENEFITx = Val(RbX.Item(4).ToString) '4=BENEFIT OF TODAY SELLIN
            Total = CStock + MStock + Val(bENEFITx)
            Me.Benefit_show.Text = "Mobile Recharge: " & MStock & " , Stock Benefit: " & bENEFITx & " , Cards: " & CStock & ", Total: " & Total
        Else
            MsgBox("That Date of Stock Information is not valid.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub OpenByBetweenDate(ByVal D1 As String, ByVal D2 As String, Optional ByVal FilterDue As Boolean = False)
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
        SFC("date_info")
        Bets(D3, D4, 0, "d") 'getting between option by calling bets
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.DaY_Sold_Info, "1,2,3,4", "SUM,Sum,Sum,Sum")
        Save()
        Calculate(Tn)
    End Sub
    Public Sub CardsOpenMonth(ByVal D1 As String)
        Dim D2 As Date
        Dim Tn As DataTable
        'Dim BpP As Decimal
        Dim G As DataGridView = Mob_ComDataGridView
        Try
            D2 = CDate(CDate(D1))
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.To get month from it.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        'Me.DateInfo.Text = "Summary By Month : " & SoftIn.AukDateGet_monthOnly(D2)
        SFC("date_info", "date_info")
        STC(D2.Month, D2.Year)
        DTC("n", "n")
        SumC("Month", "Year")
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.DaY_Sold_Info, "1,2,3,4", "SUM,Sum,Sum,Sum")
        Save()
        Calculate(Tn)
    End Sub
    Public Sub CardsOpenYear(ByVal Year As String)
        Dim Y As Integer
        Dim Tn As DataTable
        'Dim BpP As Decimal
        Dim G As DataGridView = Mob_ComDataGridView
        Try
            Y = Val(Year)
        Catch ex As Exception
            MsgBox("Please Insert a Valid Year.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        'Me.DateInfo.Text = "Summary By Year : " & Y
        SFC("Date_info")
        STC(Y)
        DTC("n")
        SumC("Year")
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.DaY_Sold_Info, "1,2,3,4", "SUM,Sum,Sum,Sum")
        Save()
        Calculate(Tn)
    End Sub
    Public Sub CardsOpenDate(ByVal D1 As String)
        Dim D2 As Date
        Dim Tn As DataTable
        'Dim BpP As Decimal
        Dim G As DataGridView = Mob_ComDataGridView
        Try
            D2 = CDate(CDate(D1))
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        SFC("Date_info")
        STC(D2)
        DTC("d")
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.DaY_Sold_Info, "1,2,3,4", "SUM,Sum,Sum,Sum")
        Save()
        Calculate(Tn)
    End Sub
    Public Sub Calculate(ByVal Tnx As DataTable)
        Me.TextBox1.Text = 0
        Me.TextBox2.Text = 0
        Me.TextBox3.Text = 0
        Me.TextBox4.Text = 0
        If Tnx Is Nothing Then
            Exit Sub
        End If
        If Tnx.Rows.Count = 0 Then Exit Sub
        Me.TextBox1.Text = Val(Tnx.Rows(0).Item(0).ToString) 'summary selling total
        Me.TextBox2.Text = Val(Tnx.Rows(0).Item(1).ToString) 's due total
        Me.TextBox3.Text = Val(Tnx.Rows(0).Item(2).ToString) 's expense total
        Me.TextBox4.Text = Val(Tnx.Rows(0).Item(3).ToString) 's benefit total
    End Sub
    Private Sub YesterDayShow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.CardsOpenDate(CDate(NDate()).AddDays(-1))
    End Sub

    Private Sub DateOpen(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Todays_BenefitTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                SFC("Date_info")
                STC(CDate(sender.text))
                DTC("d")
                AukF.Db_LoadN(Me.AukDatabaseDataSet.DaY_Sold_Info)
            Catch ex As Exception
                Epx(sender.text)
            End Try
        End If
    
    End Sub
    Private Sub keyDonwEvt_Summary(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown, ToolStripTextBox3.KeyDown, ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If sender.tag = "d" Then
                Me.CardsOpenDate(sender.text)
            ElseIf sender.tag = "m" Then
                Me.CardsOpenMonth(sender.text)
            ElseIf sender.tag = "y" Then
                Me.CardsOpenYear(sender.text)
            End If
        End If
    End Sub

    Private Sub betweenDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bDate2.KeyDown, bDate1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.OpenByBetweenDate(bDate1.Text, bDate2.Text)
        End If
    End Sub

    Private Sub betweenShowBut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.OpenByBetweenDate(bDate1.Text, bDate2.Text)
    End Sub

    Private Sub StockI_mob_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
                    Me.Save()
                ElseIf SavInt = 2 Then
                    e.Cancel = True
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub Todays_BenefitTextBox_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Todays_Paid_DueTextBox.Validated, Todays_ExpenseTextBox.Validated, Todays_BenefitTextBox2.Validated, Todays_BenefitTextBox.Validated
        If My.Settings.DIRECT_SAVE = True Then Me.Save()
    End Sub
End Class