Public Class MCompany
    Dim SFrm As String = "Mobile_R_QuickSummary"
    Public NeedToRe As Boolean = False
    Dim CSold As String = "CARD SOLD"
    Dim DueStr As String = "SEND BUT NOT PAID YET"
    Dim Snd As String = "SEND"
    Dim Und As String = "UNSEND"
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
            Me.Mob_Cards.EndEdit()
            Me.Mob_CardsTableAdapter.Update(Me.AukDatabaseDataSet.Mob_Cards)
            If NewTrans.Visible = True Then NewTrans.NeedToRe = True
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub MCompany_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If NeedToRe = True Then
            Me.Mob_ComTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Com)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.Mob_Cards, -1, "Mob_Cards", True, 0, "Val(Card_Category)")
            NeedToRe = False
        End If
    End Sub
    Private Sub MCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Mob_ComTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Com)
        AukF.Db_LoadN(Me.AukDatabaseDataSet.Mob_Cards, -1, "Mob_Cards", True, 0, "Val(Card_Category)")
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.Mob_ComBindingSource, True)
        AukF.SingleDataTable_DataRecordRefresh(Me.Mob_Cards, True)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        AukF.DeleteFromMasterTableGrd(Me.Mob_ComDataGridView, 0)
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Me.Mob_ComDataGridView.ReadOnly = False
        AukF.AukOptionsOfDataGrid(Me.Mob_ComDataGridView, "", "5,6,7,8,9,10,11,12,13")
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
        SFC("date")
        STC(D2)
        DTC("n")
        SumC("Year")
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.CID_Cards_Benefit, "0,4,5,6", ",Sum,Sum,Sum", "CID,2", True) '2=date,cause opening by date
        Me.Calculate_Cards2(Tn)
    End Sub
    Private Sub OpenByMonth(ByVal D1 As String)
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
        SFC("date", "Date")
        STC(D2.Month, D2.Year)
        DTC("n", "n")
        SumC("Month", "Year")
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.CID_Cards_Benefit, "0,4,5,6", ",Sum,Sum,Sum", "CID,2", True) '2=date,cause opening by date
        Me.Calculate_Cards2(Tn)
    End Sub
    Private Sub TotalSummary()
        Dim Tn As New DataTable("Mob_Whole_Summary")
        Dim BpP, AmT, DuE, BeneFit, CurB As Decimal
        Dim G As DataGridView = Mob_ComDataGridView
        Dim GStatus As String
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
            GStatus = UCase(Tn.Rows(N).Item(6).ToString)
            If Tn.Rows(N).Item(6).ToString = "SEND" Or GStatus = CSold Then 'get status - BENEFIT
                AmT = Val(Tn.Rows(N).Item(3).ToString) 'value of amount
                BpP = Val(Tn.Rows(N).Item(2).ToString) 'benefit percent=2
                CoM = Tn.Rows(N).Item(0).ToString 'company category id
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
                    If GStatus = CSold Then
                        RowX(9) = Val(RowX(9).ToString) + AmT 'cards total Prince of Sold
                        RowX(10) = Val(RowX(10).ToString) + CurB 'Cards Benefit
                        RowX(11) = Val(RowX(11).ToString) + DiscoUNT 'Cards Count
                    Else
                        RowX(7) = Val(RowX(7)) + BeneFit 'benefit set
                        RowX(9) = Val(RowX(9).ToString) + AmT 'send amount only
                        RowX(10) = Format(Val(RowX(10).ToString) + CurB, "0.##") 'ori benefit
                        RowX(11) = Val(RowX(11).ToString) + DiscoUNT 'ori benefit
                    End If
                 
                End If
            ElseIf Tn.Rows(N).Item(6).ToString = "SEND BUT NOT PAID YET" Then 'get status-DUE
                DuE = Val(Tn.Rows(N).Item(3).ToString)   'COLLECTING DUE IN AMT
                AmT = Val(Tn.Rows(N).Item(3).ToString) 'value of amount
                BpP = Val(Tn.Rows(N).Item(2).ToString) 'benefit percent=2
                CoM = Tn.Rows(N).Item(0).ToString 'company category id
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Mob_Com, CoM) = True Then
                    RowX(3) = Val(RowX(3)) + DuE 'SET DUE ,DUE =DIGITS FIND FIELD
                End If
            End If
            Me.ToolStripProgressBar1.Value = Me.ToolStripProgressBar1.Value + 1
        Next
        ToolStripProgressBar1.Visible = False
        '------ cards calculate
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.CID_Cards_Benefit, "0,4,5,6", ",Sum,Sum,Sum", "CID", True) '2=date,cause opening by date
        'MsgBox(Tn.Rows.Count)
        Me.Calculate_Cards2(Tn)
        'cards calculate fins
        For XQ As Integer = 0 To Me.AukDatabaseDataSet.Mob_Com.Rows.Count - 1
            BeneFit = Val(Me.AukDatabaseDataSet.Mob_Com(XQ).Item("BENEFIT_").ToString)
            DuE = Val(Me.AukDatabaseDataSet.Mob_Com(XQ).Item("Digits_Find").ToString)
            If BeneFit < DuE Then
                Me.AukDatabaseDataSet.Mob_Com(XQ).LOSS = (BeneFit - DuE) * -1
            End If
        Next
        sAVE_MOB() 'SAVING
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
        Me.DateInfo.Text = "Query on Date Between : " & D3 & " AND " & D4
        SFC("business date")
        STC(D3 & "," & D4)
        DTC("d")
        ExpreC("b")
        'Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "[CID],[company],[benefit P],[status category],[Business Date]", "[CID],[company],[benefit P],Sum([Discount]) as Discount,Sum([Extra]) as Extra,[status category],Sum([Current Benefit]) as [Current Benefit]", True) 'sfrm=mob summary form name
        Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "[CID],[company],[benefit P],[status category],[Business Date]", "[CID],[company],[benefit P],Sum([Discount]) as Discount,Sum([Extra]) as Extra,[status category],Sum([Current Benefit]) as [Current Benefit]", True) 'sfrm=mob summary form name
        Query_Expendation(Tn)
        SFC("date")
        Bets(D3, D4, 0, "d") 'getting between option by calling bets
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.CID_Cards_Benefit, "0,4,5,6", ",Sum,Sum,Sum", "CID,2", True) '2=date,cause opening by date
        Me.Calculate_Cards2(Tn)
    End Sub
    Private Sub Query_Expendation(ByVal Tn As DataTable)
        Dim BpP, AmT, DuE, BeneFit, CurB As Decimal
        Dim G As DataGridView = Mob_ComDataGridView
        Dim CoM As String
        Dim GStatus As String
        'Mob_Com Table
        'DIGITS FIND=DUE=3
        'BENEFIT=7
        'LOSS=8
        '9=send amount
        '10=ori.benefit
        '11=discount
        '12=card sell number(Count)
        '13=card price of sold
        '14=cards benefit
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
            If Tn.Rows(N).Item(5).ToString = "SEND" Or Tn.Rows(N).Item(5).ToString = CSold Then 'get status - BENEFIT
                GStatus = Tn.Rows(N).Item(5).ToString
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
                    If UCase(GStatus) = CSold Then
                        RowX(13) = Val(RowX(9).ToString) + AmT 'cards selling price++whihc is in amount
                        RowX(14) = Val(RowX(14).ToString) + CurB 'cards  benefit=14
                        RowX(12) = Val(RowX(12).ToString) + 1 'counting
                    Else
                        RowX(7) = Val(RowX(7)) + BeneFit 'benefit set %+++
                        RowX(9) = Val(RowX(9).ToString) + AmT 'send amount only
                        RowX(10) = Format(Val(RowX(10).ToString) + CurB, "0.##") 'ori benefit
                        RowX(11) = Val(RowX(11).ToString) + DiscoUNT 'ori benefit++
                    End If

                End If
            ElseIf Tn.Rows(N).Item(5).ToString = "SEND BUT NOT PAID YET" Then 'get status-DUE
                'COLLECT DUE
                'company id=0,comname=1
                CoM = Tn.Rows(N).Item(0).ToString 'company category id
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
            Me.AukDatabaseDataSet.Mob_Com(XQ).Cards_Benefit = 0
            Me.AukDatabaseDataSet.Mob_Com(XQ).Cards_Selling_Cost = 0
            Me.AukDatabaseDataSet.Mob_Com(XQ).Cards_Selling_Number = 0
        Next
    End Sub
    Public Sub OpenByDate(ByVal D1 As String)
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
        'MsgBox(D2)
        'Mob_Com Table
        'DIGITS FIND=DUE=3
        'BENEFIT=7
        'LOSS=8
        '9=send amount
        '10=ori.benefit
        '11=discount
        Me.DateInfo.Text = "Summary By Date : " & SoftIn.AukDateGet(D2)
        'BpP = Val(AukF.GridT(G, 3)) 'GET % BENEFIT
        SFC("business date")
        STC(D2)
        DTC("d")
        Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "[CID],[company],[benefit P],[status category],[Business Date]", "[CID],[company],[benefit P],Sum([Discount]) as Discount,Sum([Extra]) as Extra,[status category],Sum([Current Benefit]) as [Current Benefit]", True) 'sfrm=mob summary form name
        Query_Expendation(Tn)
        SFC("date")
        STC(D2)
        DTC("d")
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.CID_Cards_Benefit, "0,4,5,6", ",Sum,Sum,Sum", "CID,2", True) '2=date,cause opening by date
        Me.Calculate_Cards2(Tn)
    End Sub
    Private Sub Calculate_Cards2(ByVal Tnx As DataTable) 'for only TComs View all
        Dim Cid As String
        Dim CardInt As Integer
        Dim Benefit, TStockPrice As Decimal
        '0=cid
        '1=card cate
        '2=card count
        '3="beenfit
        '4=discount
        If Tnx Is Nothing Then
workoff:    Me.sAVE_MOB()
            Exit Sub
        End If
        If Tnx.Columns.Count = 0 Or Tnx.Rows.Count = 0 Then GoTo workoff
        ToolStripProgressBar1.Visible = True
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Maximum = Me.AukDatabaseDataSet.Mob_Com.Rows.Count
        For K As Integer = 0 To Me.AukDatabaseDataSet.Mob_Com.Rows.Count - 1
            Cid = Me.AukDatabaseDataSet.Mob_Com(K).Item(0).ToString 'cid
            'CCate = Val(Me.AukDatabaseDataSet.Mob_Cards(K).Item(2).ToString) 'card cate 
            Benefit = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Tnx, "Cid='" & Cid & "'", "Sum", 2)) 'benefit
            TStockPrice = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Tnx, "Cid='" & Cid & "'", "Sum", 3)) 'total stock Money
            CardInt = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Tnx, "Cid='" & Cid & "'", "Sum", 1)) 'card count +++
            Me.AukDatabaseDataSet.Mob_Com(K).Cards_Benefit = Benefit 'current card category benefit insert
            Me.AukDatabaseDataSet.Mob_Com(K).Cards_Selling_Cost = TStockPrice 'current card category total stock Money insert
            Me.AukDatabaseDataSet.Mob_Com(K).Cards_Selling_Number = CardInt 'current card category sold insert
            ToolStripProgressBar1.Value += 1
        Next
        ToolStripProgressBar1.Visible = False
        ToolStripProgressBar1.Value = 0
        Me.sAVE_MOB()
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
        Me.DateInfo.Text = "Summary By Month : " & SoftIn.AukDateGet_monthOnly(D2)
        SFC("Date", "Date")
        STC(D2.Month, D2.Year)
        DTC("n", "n")
        SumC("Month", "Year")
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.CardBenefitMob, "0,1,3,7,6,8") '7=bebenfti,6=dis,9=due
        Me.sAVE_MOB()
        Calculate_Cards(Tn)
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
        Me.DateInfo.Text = "Summary By Year : " & Y
        SFC("Date")
        STC(Y)
        DTC("n")
        SumC("Year")
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.CardBenefitMob, "0,1,3,7,6,8") '7=bebenfti,6=dis,9=due
        Me.sAVE_MOB()
        Calculate_Cards(Tn)
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
        Me.DateInfo.Text = "Summary By Date : " & SoftIn.AukDateGet(D2)
        SFC("Date")
        STC(D2)
        DTC("d")
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.CardBenefitMob, "0,1,3,7,6,8") '7=bebenfti,6=dis,9=due
        Me.sAVE_MOB()
        'CopyClipBoard(Sql)
        Calculate_Cards(Tn)
    End Sub

    Private Sub Calculate_Cards(ByVal Tnx As DataTable)
        Dim Cid As String
        Dim CCate, CardInt, DueInt As Integer
        Dim Benefit, Discount, Due As Decimal
        '0=cid
        '1=card cate
        '2=card count
        '3="beenfit
        '4=discount
        If Tnx Is Nothing Then
workoff:    For K As Integer = 0 To Me.AukDatabaseDataSet.Mob_Cards.Rows.Count - 1
                Me.AukDatabaseDataSet.Mob_Cards(K).S_Total_Benefit = 0 'current card category benefit insert
                Me.AukDatabaseDataSet.Mob_Cards(K).S_Total_Discount = 0 'current card category discount insert
                Me.AukDatabaseDataSet.Mob_Cards(K).S_Total_Sold_Count = 0
                Me.AukDatabaseDataSet.Mob_Cards(K).S_DueCards = 0
                Me.AukDatabaseDataSet.Mob_Cards(K).S_DueCards_Amount = 0
            Next
            Me.sAVE_MOB()
            Exit Sub
        End If
        If Tnx.Columns.Count = 0 Or Tnx.Rows.Count = 0 Then GoTo workoff
        ToolStripProgressBar1.Visible = True
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Maximum = Me.AukDatabaseDataSet.Mob_Cards.Rows.Count
        For K As Integer = 0 To Me.AukDatabaseDataSet.Mob_Cards.Rows.Count - 1
            Cid = Me.AukDatabaseDataSet.Mob_Cards(K).Item(1).ToString 'cid
            CCate = Val(Me.AukDatabaseDataSet.Mob_Cards(K).Item(2).ToString) 'card cate 
            Benefit = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Tnx, "Cid='" & Cid & "' and [Card Category]=" & CCate & " And Due=False", "Sum", 3)) 'benefit
            Discount = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Tnx, "Cid='" & Cid & "' and [Card Category]=" & CCate, "Sum", 4)) 'discount'we can also give discount on due cards
            CardInt = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Tnx, "Cid='" & Cid & "' and [Card Category]=" & CCate, "Sum", 2)) 'card count +++'in sold count also count due,cause due cards are sold
            DueInt = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Tnx, "Cid='" & Cid & "' and [Card Category]=" & CCate & " And Due=true", "sum", 2)) 'Su of Amount Count Field
            Due = DueInt * CCate 'because  due cards amount =due count * card category
            'Due = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Tnx, "Cid='" & Cid & "' and [Card Category]=" & CCate & " And Due=true", "sum", "Count")) 'Su of Count Field
            Me.AukDatabaseDataSet.Mob_Cards(K).S_Total_Benefit = Benefit 'current card category benefit insert
            Me.AukDatabaseDataSet.Mob_Cards(K).S_Total_Discount = Discount 'current card category discount insert
            Me.AukDatabaseDataSet.Mob_Cards(K).S_Total_Sold_Count = CardInt 'current card category sold insert
            Me.AukDatabaseDataSet.Mob_Cards(K).S_DueCards = DueInt 'current card category due count insert
            Me.AukDatabaseDataSet.Mob_Cards(K).S_DueCards_Amount = Due 'current card category due amount in cards insert
            ToolStripProgressBar1.Value += 1
        Next
        ToolStripProgressBar1.Visible = False
        ToolStripProgressBar1.Value = 0
        Me.sAVE_MOB()
    End Sub
    Private Sub MCompany_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If SavMsg() = 1 Then
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

    Private Sub Mob_CardsDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Mob_CardsDataGridView.CellEndEdit
        SoftIn.Master_ID_String(sender, 4)
    End Sub

   
    Private Sub Save_Effect(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        sAVE_MOB()
    End Sub

    Private Sub Delete_from_Cards(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            If Mob_Cards.Count > 0 Then Me.Mob_Cards.RemoveCurrent()
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.Mob_Cards, True)
    End Sub

    Private Sub TodaysSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodaysSummaryToolStripMenuItem.Click, YesterdaySummaryToolStripMenuItem.Click
        Me.CardsOpenDate(Now.AddDays(sender.tag))

    End Sub

    Private Sub ToolStripTextBox7_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim CurStock, xM As Integer
            CurStock = Val(AukF.GridT(Me.Mob_CardsDataGridView, 4).ToString) '4=cards instock
            xM = Val(sender.text)
            If DRow > -1 Then
                Me.Mob_CardsDataGridView(4, DRow).Value = Val(CurStock) + Val(xM)
            End If
        End If
    End Sub

    Private Sub OpenCardsSummary(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox4.KeyDown, ToolStripTextBox6.KeyDown, ToolStripTextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            If LCase(sender.tag) = "y" Then
                Me.CardsOpenYear(sender.text)
            ElseIf LCase(sender.tag) = "m" Then
                Me.CardsOpenMonth(sender.text)
            ElseIf LCase(sender.tag) = "d" Then
                Me.CardsOpenDate(sender.text)
            End If
        End If
    End Sub

    Private Sub CurrentMonthToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentMonthToolStripMenuItem1.Click
        Me.CardsOpenMonth(NDate)
    End Sub

    Private Sub CurrentYearToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentYearToolStripMenuItem1.Click
        Me.CardsOpenYear(Now.Year)

    End Sub

    Private Sub WholeSummaryCards(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WholeSummaryToolStripMenuItem.Click
        '0=cid
        '1=card cate
        '2=card count
        '3="beenfit
        '4=discount
        Me.DateInfo.Text = "Summary By Month : Whole Summary of Cards"
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.CardBenefitMob, "0,1,3,7,6,8", ",,SUM,SUM,SUM", "0,1,8", True) 'group by due,cid
        Me.sAVE_MOB()
        Calculate_Cards(Tn)
    End Sub

    Private Sub ResetCardsSoldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetCardsSoldToolStripMenuItem.Click
        For K As Integer = 0 To Me.AukDatabaseDataSet.Mob_Cards.Rows.Count - 1
            Me.AukDatabaseDataSet.Mob_Cards(K).Cards_Sold = 0
        Next
    End Sub

    Private Sub DbError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Mob_ComDataGridView.DataError
        GrdErrMsg(e)
    End Sub
End Class