Public Class SimSold
    Dim SStock As New AukDatabaseDataSet.SimStockDataTable
    Dim DaY_Sold_InfoTableAdapter As New AukDatabaseDataSetTableAdapters.DaY_Sold_InfoTableAdapter
    Dim SStockAdp As New AukDatabaseDataSetTableAdapters.SimStockTableAdapter
    Private Sub SimSoldBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click, SellItemToolStripMenuItem.Click
        SaveAuto()
    End Sub

    Public Sub SaveAuto() 'sim sold ony
        Try
            Me.Validate()
            Me.SimSoldBindingSource.EndEdit()
            Me.SimSoldTableAdapter.Update(Me.AukDatabaseDataSet.SimSold)
        Catch ex As Exception
            Epx()
        End Try

    End Sub
    Public Sub SaveSimStock() 'sim sold ony
        Try
            Me.Validate()
            Me.SStockAdp.Update(SStock)
        Catch ex As Exception
            Epx()
        End Try

    End Sub
    Public Sub BusDisEnb()
        If Me.DateBusiness.Enabled = False Then
            If Me.AukDatabaseDataSet.HasChanges = True Then
                If SavMsg(NSavStr) = 1 Then
                    SaveAuto()
                ElseIf SavInt = 2 Then
                    Exit Sub
                End If
            End If
            Try
                'Me.DateBusiness.Text = ""
                Me.DateBusiness.Focus()
                Me.SimSoldDataGridView.ReadOnly = True
                Me.DateBusiness.Enabled = True
                Me.AukDatabaseDataSet.SimSold.Clear()
                Me.SimSoldDataGridView.AllowUserToAddRows = False
            Catch ex As Exception
                Epx()
                Me.DateBusiness.Focus()
            End Try
        Else
            BusEnb()
        End If
    End Sub
    Public Sub BusEnb(Optional ByVal d1x As Date = Nothing)
        Me.MonthCalendar1.Visible = False
        datex = Me.DateBusiness.Text
        If d1x = Nothing Then
            If datex = "" Then datex = CDate(Now.Date) : DateBusiness.Text = Now.Date
        End If
        Try
            If d1x = Nothing Then
                WDate = Dat2(Me.DateBusiness.Text)
            Else
                WDate = d1x
            End If
            'Refresh_Stock_info_tab(NDate)
            Me.SimSoldDataGridView.ReadOnly = False
            Extent_Fields_readOnly()
            Me.DateBusiness.Text = WDate
            Me.DateBusiness.Enabled = False
            SFC("Sold_Date")
            STC(WDate)
            DTC("d")
            SnX("=")
            AukF.Db_Load("*", "SimSold", Me.AukDatabaseDataSet, True, "")
            Me.SimSoldDataGridView.AllowUserToAddRows = True
            Dim Ipox As Integer = Me.SimSoldBindingSource.Count - 1
            If Ipox >= 0 Then
                Me.SimSoldBindingSource.Position = Ipox
            End If
        Catch ex As Exception
            Epx()
            Me.DateBusiness.Focus()
        End Try
    End Sub
    Public Sub EFFECT_ON_INFORMATION_TEXT_VIEW()
        On Error Resume Next
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
    Public Sub Extent_Fields_readOnly()
        Me.SoldDate_Field.ReadOnly = True
        Me.TCom_Field.ReadOnly = True
        Me.SimCate_Field.ReadOnly = True


        'Me.Dstatus_Field.ReadOnly = True
        'Me.D_SendTime_Field.ReadOnly = True
        'Me.Due_Cards_Field.ReadOnly = True
    End Sub

    Private Sub SimSold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.DaY_Sold_Info' table. You can move, or remove it, as needed.
        Me.DaY_Sold_InfoTableAdapter1.Fill(Me.AukDatabaseDataSet.DaY_Sold_Info)
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.SimSold' table. You can move, or remove it, as needed.
        Me.SimSoldTableAdapter.Fill(Me.AukDatabaseDataSet.SimSold)
        Me.SimCategoryTableAdapter1.Fill(Me.AukDatabaseDataSet.SimCategory)
        Me.Mob_ComTableAdapter1.Fill(Me.AukDatabaseDataSet.Mob_Com)
        Me.AukDatabaseDataSet.SimSold.DueColumn.DefaultValue = False
        Me.AukDatabaseDataSet.SimSold.PaperCompleteColumn.DefaultValue = False
        AukF.AukDataSourceSetObjectListOrComboType(Me.SimCateCombo, Me.SimCateBindSource, 0, True, True)
        AukF.AukDataSourceSetObjectListOrComboType(Me.comCombo, Me.CompanyBindSource, 0, True, True)
        'Refresh_Stock_info_tab(NDate)
        Me.EFFECT_ON_INFORMATION_TEXT_VIEW()
        Me.DateBusiness.Text = Dat2(NDate())
        Me.BusEnb(NDate)
    End Sub

    Private Sub ToolStripTextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ADSRC.TWICE_EXE(sender, e, Me.SimSoldBindingSource, "Sim_Number", "Client_Name", True, False)
        End If
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.ButtonClick
        Dim DMD1 As Date
        Try
            DMD1 = CDate(Me.DateBusiness.Text)
            BusDisEnb()
        Catch ex As Exception
            LOAD_CLIENTS_INFOR()
        End Try
    End Sub

    Private Sub DateBusiness_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateBusiness.DoubleClick
        Me.MonthCalendar1.Visible = Not Me.MonthCalendar1.Visible
    End Sub
    Public Function CELL_NUMB_GET() As String
        On Error Resume Next
        Dim Drv As DataGridView = Me.SimSoldDataGridView
        Cell = Replace(CStr(AukF.GridT(Drv, 0)), " ", "") 'MOB NUM
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
    Private Sub SimSoldDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SimSoldDataGridView.CellClick
        Dim Drv As DataGridView = Me.SimSoldDataGridView
        If My.Settings.CUR_INFO_SHOW = "NO" Then
            Me.iNFOR.Visible = False
        ElseIf My.Settings.CUR_INFO_SHOW = "SHOW(ID,CELL,CURRENT BALANCE)" Then
            X = AukF.GridT(Drv, 1) 'CLIENTS ID OR NAME
            Cell = CELL_NUMB_GET()
            If Trim(CStr(X)) <> "" Then
                ShowT = "Client: " & X & " , "
            End If
            ShowT = ShowT & "Sim: " & Cell & BaL
        Else 'ONLY ID,CELL
            X = AukF.GridT(Drv, 1) 'CLIENTS ID OR NAME
            Cell = CELL_NUMB_GET()
            If Trim(CStr(X)) <> "" Then
                ShowT = "Client: " & X & " , "
            End If
            ShowT = ShowT & "Sim: " & Cell
        End If
        If My.Settings.CUR_INFO_SHOW = "NO" Then
            If Me.iNFOR.Visible = True Then Me.iNFOR.Visible = False
        Else
            If Me.iNFOR.Visible = False Then iNFOR.Visible = True
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
    End Sub

    Private Sub SetChkBoxes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetPaperCompleteTrueToolStripMenuItem.Click, SetDueTrueToolStripMenuItem.Click
        Dim B4 As Boolean
        If sender.tag = "p" Then
            B4 = AukF.CheckVal_GetBool(AukF.GridT(Me.SimSoldDataGridView, 11)) '11=paper
            AukF.GridTSet(Me.SimSoldDataGridView, Not B4, 11)
        ElseIf sender.tag = "d" Then
            B4 = AukF.CheckVal_GetBool(AukF.GridT(Me.SimSoldDataGridView, 12)) '12=due
            AukF.GridTSet(Me.SimSoldDataGridView, Not B4, 12)
        Else
            MsgBox("no Command Found")
        End If
    End Sub

    Private Sub FilterSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterSelectedToolStripMenuItem.Click
        ADSRC.DATAGRID_ADVANCE_SELECTED_FILTER(Me.SimSoldDataGridView, Me.SimSoldBindingSource)
    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click, RemoveFilterToolStripMenuItem1.Click
        Me.SimSoldBindingSource.RemoveFilter()
    End Sub

    Private Sub FilterOnlyDueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterOnlyDueToolStripMenuItem.Click, LoadDueByNumberToolStripMenuItem.Click
        AukF.BindFilter(Me.SimSoldBindingSource, "Due", "True")

    End Sub

    Private Sub filterBySimAndCombpany(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterCurrentSimCategoryToolStripMenuItem.Click, FilterCurrentCompanyToolStripMenuItem.Click
        a = sender.tag
        If a = "sim" Then
            AukF.BindFilter(Me.SimSoldBindingSource, "Sim_Category", Me.SimCateCombo.Text)
        ElseIf a = "com" Then
            AukF.BindFilter(Me.SimSoldBindingSource, "Category_ID", Me.comCombo.Text)

        End If
    End Sub

    Private Sub BackToStoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToStoreToolStripMenuItem.Click, ToolStripButton4.Click
        Dim S As String
        Dim R2 As AukDatabaseDataSet.SimSoldRow
        Dim SrT As AukDatabaseDataSet.SimStockRow
        S = AukF.GridT(Me.SimSoldDataGridView, 0) 'sim number

        If S <> "" Then
            R2 = SoftIn.Rows_SelectGetOnlyOne(Me.AukDatabaseDataSet.SimSold, 0, S)
            If R2 IsNot Nothing Then
                SFC("Sim_number")
                STC(S) 'sim number
                AukF.Db_LoadN(SStock)
                If SStock.Rows.Count = 1 Then 'replace the datas
                    SStock(0).Category_ID = R2.Item("Category_ID").ToString
                    SStock(0).Sim_Category = R2.Item("Sim_Category").ToString
                    SStock(0).Purchase_Cost = Val(R2.Item("Purchase_Cost").ToString)
                    SStock(0).Sold_Price = Val(R2.Item("Sold_Price").ToString)
                    SStock(0).Purchase_Date = NDate()
                    SStock(0).Benefit = Val(R2.Item("Benefit").ToString)
                    SStock(0).IME = R2.Item("IME").ToString
                ElseIf SStock.Rows.Count = 0 Then 'add new if not exist on stock
                    SrT = SStock.NewRow
                    SrT.Sim_Number = S 'sim number
                    SrT.Category_ID = R2.Item("Category_ID").ToString
                    SrT.Sim_Category = R2.Item("Sim_Category").ToString
                    SrT.Purchase_Cost = Val(R2.Item("Purchase_Cost").ToString)
                    SrT.Sold_Price = Val(R2.Item("Sold_Price").ToString)
                    SrT.Purchase_Date = NDate()
                    SrT.Benefit = Val(R2.Item("Benefit").ToString)
                    SrT.IME = R2.Item("IME").ToString
                    SStock.Rows.Add(SrT)
                ElseIf SStock.Rows.Count > 1 Then
                    MsgBox("Sim Found More than One.It can't be possible.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        Else
            Exit Sub

        End If
        R2.Delete()
        Me.SaveSimStock()
        Me.SaveAuto()

    End Sub
    Public Sub LOAD_CLIENTS_INFOR() 'BY CELL NUMBER
        Dim nUM As String
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If SavMsg("DO YOU WANT SAVE BEFORE LOAD TYPED CLIENT'S CELL NUM/ID ." & vbCrLf & "YES=SAVE AND LOAD FOR NEW DATE,NO=STOP SAVE AND DO FOR NEW DATE,CANCEL= CANCEL DOING ALL.") = 1 Then
                SaveAuto()
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
            Me.SimSoldDataGridView.ReadOnly = False
            SFC("client_Name", "Sim_number")
            STC(nUM, nUM)
            SJOIN = "or"
            ExpreC("l*")
            'DTC("d")
            SnX("=")
            AukF.Db_Load("*", "SimSold", Me.AukDatabaseDataSet, True)
            If Me.SimSoldBindingSource.Filter IsNot Nothing Then Me.SimSoldBindingSource.RemoveFilter()
            If Me.AukDatabaseDataSet.SimSold.Rows.Count > 0 Then
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
    Private Sub DateBusiness_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateBusiness.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                dm = CDate(sender.text)
                BusEnb()
            Catch ex As Exception
                LOAD_CLIENTS_INFOR()
            End Try
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LoadDays(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadTodayToolStripMenuItem.Click, LoadYesterdayToolStripMenuItem.Click
        'SFC("Sold_Date")
        BusEnb((CDate(NDate()).AddDays(Val(sender.tag))))
        'AukF.Db_LoadN(Me.AukDatabaseDataSet.SimSold)
    End Sub

    Private Sub SimStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimStockToolStripMenuItem.Click
        FrmL(SimStock)
    End Sub

    Private Sub SimCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimCategoryToolStripMenuItem.Click
        FrmL(SimCate)
    End Sub

    Private Sub SimSoldDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SimSoldDataGridView.CellEndEdit
        Dim R As AukDatabaseDataSet.SimStockRow
        'Dim R2 As AukDatabaseDataSet.SimSoldRow
        Dim D1 As Date
        Dim SIm As String
        If e.ColumnIndex = 0 Then
            SIm = AukF.GridT(sender)
            SFC("Sim_number")
            STC(SIm)
            AukF.Db_LoadN(SStock)
            If SStock.Rows.Count = 1 Then
                'MsgBox("Found")
                R = SStock(0) 'simstcok

                If R IsNot Nothing Then
                    'If R2 Is Nothing Then R2 = Me.AukDatabaseDataSet.SimSold.NewRow
                    'getting inf from stock to sold
                    'R2.Sim_Number = R.Item("Sim_Number").ToString
                    Try
                        D1 = Dat2(Me.DateBusiness.Text)
                    Catch ex As Exception
                        D1 = NDate()
                    End Try
                    AukF.GridTSet(sender, R.Item("Category_ID").ToString, 4)
                    AukF.GridTSet(sender, R.Item("Sim_Category").ToString, 5)
                    AukF.GridTSet(sender, Val(R.Item("Purchase_Cost").ToString), 7)
                    AukF.GridTSet(sender, Val(R.Item("Sold_Price").ToString), 8)
                    AukF.GridTSet(sender, D1, 10)
                    AukF.GridTSet(sender, Val(R.Item("Benefit").ToString), 9)
                    AukF.GridTSet(sender, R.Item("IME").ToString, 2)
                    GoTo after

                    'Me.AukDatabaseDataSet.SimSold.Rows.Add(R2)
                    'R2.EndEdit()
                End If
                Exit Sub
            ElseIf SStock.Rows.Count = 1 Then
                MsgBox("Found More than 1")
                Exit Sub
            Else
                MsgBox("Current SimNumber is Not found in store.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

        End If
after:
        If My.Settings.DIRECT_SAVE = True Then 'after exist on sold db , delete frm stock and then save sold db
            If R IsNot Nothing Then
                R.Delete()
                Me.SaveSimStock()
                SimStock.NeedToRefresh = True
            End If
         
            Me.SaveAuto()
        End If
    End Sub
    Private Sub DeleteSimFrmStock(ByVal SimNum As String)
        Dim R As AukDatabaseDataSet.SimStockRow
        SFC("Sim_number")
        STC(SIm)
        AukF.Db_LoadN(SStock)
        If SStock.Rows.Count = 1 Then
            If R IsNot Nothing Then
                R.Delete()
                Me.SaveSimStock()
            End If
            Me.SaveSimStock()
        ElseIf SStock.Rows.Count = 1 Then
            MsgBox("Found More than 1 Sim Records, Please Check yourself.", MsgBoxStyle.Critical)
        Else
            MsgBox("Current SimNumber is Not found in store.", MsgBoxStyle.Exclamation)
        End If
    End Sub
 
    Private Sub SimSoldDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles SimSoldDataGridView.DataError
        GrdErrMsg(e)
      
    End Sub

    Private Sub ShowTillDueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowTillDueToolStripMenuItem.Click
        If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me, False) = True Then
            SFC("Due")
            STC("True")
            DTC("b")
            AukF.Db_LoadN(Me.AukDatabaseDataSet.SimSold)
        End If
    End Sub

    Private Sub ShowUnCompletePapersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowUnCompletePapersToolStripMenuItem.Click
        If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me, False) = True Then
            SFC("PaperComplete")
            STC("false")
            DTC("b")
            AukF.Db_LoadN(Me.AukDatabaseDataSet.SimSold)
        End If
    End Sub

    Private Sub ShowSummaryInCurrentRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowSummaryInCurrentRecordsToolStripMenuItem.Click
        Dim SummaryTable As DataTable
        SummaryTable = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.SimSold, "Category_ID,Sim_Category,Discount,Purchase_Cost,Sold_Price,Benefit,PaperComplete,Due,Due", ",,Sum,Sum,Sum,Sum,Count,,[self]=Total Coun=count", "Category_ID,Sim_Category,Due", True, True)
        SummaryTable.TableName = "SimSoldSummaryTab"

        ViewQuery.DataGrid1.DataSource = SummaryTable
        FrmL(ViewQuery)
        Dim Summary As String
        Summary = "Total Sold Price : " & ADSRC.SummaryNonExeTable_New(SummaryTable, "", "", "Sum", "Sold_Price") _
                    & " ; " & "Total Due : " & ADSRC.SummaryNonExeTable_New(SummaryTable, "Due", "True", "Sum", "Sold_Price") _
                    & " ; " & "Total benfit : " & ADSRC.SummaryNonExeTable_New(SummaryTable, "Due", "false", "Sum", "Benefit") _
                     & "; Double Click On Records show Information"

        ViewQuery.DataGrid1.CaptionText = "Sim Records Summary : " & Summary

        'AukMod.GetMultiSplit_Arrays("due=TotalDue . Command.KKK,Run Fast=Options.Enables.PPP,Max=Fun.xrun.LLL", "./=")
        'SummaryTable.WriteXml(AppPath & "\a.xml")
        'SummaryTable.ReadXml(AppPath & "\a.xml")
    End Sub
    Public Sub LoadQuery(ByVal Company As String, ByVal SimCate As String, ByVal Due As Boolean)
        If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me, False) = True Then
            SFC("Category_ID", "Sim_Category", "Due")
            STC(Company, SimCate, Due)
            DTC("", "", "b")
            AukF.Db_LoadN(Me.AukDatabaseDataSet.SimSold)
        End If


    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Due_Laod(sender.text)
        End If
    End Sub
    Private Sub Due_Laod(ByVal Number_Or_Name As String)
        If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me, False) = True Then
            SFC("Sim_Number", "Client_Name")
            STC(Number_Or_Name, Number_Or_Name)
            ExpreC("l*", "L*")
            SJOIN = "OR"
            AukF.Db_LoadN(Me.AukDatabaseDataSet.SimSold)
        End If

    End Sub
End Class