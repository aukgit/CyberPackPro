Public Class SimStock
    Public NeedToRefresh As Boolean = False
    Private Sub SimStockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimStockBindingNavigatorSaveItem.Click, SaveToolStripMenuItem.Click
        SaveAuto()
    End Sub
    Public Sub SaveAuto()
        Try
            Me.Validate()
            Me.SimStockBindingSource.EndEdit()
            Me.SimStockTableAdapter.Update(Me.AukDatabaseDataSet.SimStock)
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub SimStock_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CheckOnDb_ShoutDownTime(Me.AukDatabaseDataSet, Me)
    End Sub
    Private Sub SimStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AukDatabaseDataSet.SimCategory.SimCategoryColumn.MaxLength = 20
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.SimCategory' table. You can move, or remove it, as needed.

        Me.AukDatabaseDataSet.SimStock.Sim_CategoryColumn.MaxLength = 20
        Me.AukDatabaseDataSet.SimStock.Purchase_DateColumn.DefaultValue = DBNull.Value
        Me.Mob_ComTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Com)

        Me.SimCategoryTableAdapter.Fill(Me.AukDatabaseDataSet.SimCategory)
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Mob_Com' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.SimStock' table. You can move, or remove it, as needed.
        Me.SimStockTableAdapter.Fill(Me.AukDatabaseDataSet.SimStock)

    End Sub

    Private Sub AddNewSimCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewSimCategoryToolStripMenuItem.Click
        FrmL(SimCate)

    End Sub

    Private Sub ReLoadDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReLoadDatabaseToolStripMenuItem.Click
        If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me) = True Then
            SimStock_Load(sender, e)
        End If
    End Sub

    Private Sub AddSameCategoryProductBySimNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSameCategoryProductBySimNumberToolStripMenuItem.Click
        Dim Rowq As DataRow
        'Try
        qw = InputBox("Please Type SIM NUMBER as : SIM NUMBER1,SIM NUMBER2,SIM NUMBER3 etc...,Same SIM", "Same SIM Input", qw)
        If qw = "" Then Exit Sub
        dvdid = AukF.GridT(Me.SimStockDataGridView, 0) 'FOR ID
        Rowq = Me.AukDatabaseDataSet.SimStock.FindBySim_Number(dvdid)
        GoTo ba
ba:
        Try
            AukF.CommonRowsAdd(Rowq, qw, 0, "", "", ",", Me.SimStockDataGridView, Me.PROG, True)
        Catch ex As Exception
            Epx()
        End Try
    End Sub
    'Private Sub SimStockDataGridView_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SimStockDataGridView.CellContentClick
    '    If e.ColumnIndex = 2 Then '2=SIM CATE
    '        SimC = AukF.GridT(sender)
    '        Dim R As DataRow
    '        R = SoftIn.Rows_SelectGetOnlyOne(Me.AukDatabaseDataSet.SimCategory, "SimCategory", SimC)
    '        If R IsNot Nothing Then 'inset sim category,1=categoryid=mob com
    '            Me.SimStockDataGridView(1, e.RowIndex).Value = R.Item("Category_Id").ToString
    '        Else
    '            AukF.GridTSet(sender, CSOFT.RowStrGetTable(Me.AukDatabaseDataSet.SimCategory, 1), 1)
    '            'If AukDatabaseDataSet.SimCategory.Rows.Count > 0 Then Me.SimStockDataGridView(2, e.RowIndex).Value = Me.AukDatabaseDataSet.SimCategory(0).SimCategory.ToString
    '        End If
    '    End If
    'End Sub

    Private Sub SimStockDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SimStockDataGridView.CellEndEdit
        Dim TCom, BeforeTCom, SimC As String

        If e.ColumnIndex = 0 Then
            Sn1 = AukF.GridT(sender, 0) 'cell number
            Sx1 = Mid(Sn1, 1, 3).ToString 'cell number 3 digit
            'if not card selling
            'try to insert num with ou space and -
            Sn1 = Replace(Sn1, "-", "")
            Sn1 = Replace(Sn1, " ", "")
            If DRow > -1 Then Me.SimStockDataGridView(0, DRow).Value = Sn1 'INPUTING CELL NUMBER
            Sx1 = Mid(Sn1, 1, 3).ToString 'cell number 3 digit
            '----
            'If DRow > -1 Then x = sender(2, DRow).value

            If AukF.BindFind(Me.MobComBindingSource, "Digits", Sx1) = True Then
                'If DRow > -1 Then x = sender(2, DRow).value

                TCom = Me.AukDatabaseDataSet.Mob_Com(ComRow).Item("Category_ID").ToString
                Me.SimStockDataGridView(1, e.RowIndex).Value = TCom
                If e.RowIndex > 0 Then
                    'if before nulls then input first of this tcom company
                    If AukF.GridT(sender, 2).ToString = "" Then BeforeTCom = AukF.GridT(sender, 1, e.RowIndex - 1)
                    If BeforeTCom = TCom Then
                        CSOFT.BEFORE_ROW_DATA_INPUT(sender, 2) 'FIRST TRY TO INPUT BEFORE ROW sim cate,IF NULL THEN PROGRAMMING IS STRATED
                    End If
                    If AukF.GridT(sender, 2) = "" Then 'still null on sim cate then try the first
                        Dim R As DataRow
                        R = SoftIn.Rows_SelectGetOnlyOne(Me.AukDatabaseDataSet.SimCategory, "Category_ID", TCom)
                        If R IsNot Nothing Then 'inset sim category
                            Me.SimStockDataGridView(2, e.RowIndex).Value = R.Item("SimCategory").ToString
                        Else
                            If AukDatabaseDataSet.SimCategory.Rows.Count > 0 Then Me.SimStockDataGridView(2, e.RowIndex).Value = Me.AukDatabaseDataSet.SimCategory(0).SimCategory.ToString
                        End If
                    End If
                End If
            Else
                CSOFT.BEFORE_ROW_DATA_INPUT(sender, 1) 'FIRST TRY TO INPUT BEFORE ROW sim cate,IF NULL THEN PROGRAMMING IS STRATED
                CSOFT.BEFORE_ROW_DATA_INPUT(sender, 2) 'FIRST TRY TO INPUT BEFORE ROW sim cate,IF NULL THEN PROGRAMMING IS STRATED
                'If AukDatabaseDataSet.SimCategory.Rows.Count > 0 Then Me.SimStockDataGridView(2, e.RowIndex).Value = Me.AukDatabaseDataSet.SimCategory(0).SimCategory.ToString
                AukF.GridTSet(sender, CSOFT.RowStrGetTable(Me.AukDatabaseDataSet.SimCategory, "sIMCATEGORY"), 2, -1, True) '2=SIM CATE
                AukF.GridTSet(sender, CSOFT.RowStrGetTable(Me.AukDatabaseDataSet.Mob_Com, "CATEGORY_ID"), 1, -1, True) '1=TCOM
            End If
        End If
        x = AukF.GridT(Me.SimStockDataGridView, 3, -1, "")
        If x = "" Then 'PURCHASE DATE 
            If DRow > -1 Then Me.SimStockDataGridView(3, DRow).Value = NDate()
        End If
        CSOFT.BEFORE_ROW_DATA_INPUT(sender, 2) 'sim cate
        CSOFT.BEFORE_ROW_DATA_INPUT(sender, 4) 'purcha Cost
        CSOFT.BEFORE_ROW_DATA_INPUT(sender, 5) 'Sold Cost
        'CSOFT.BEFORE_ROW_DATA_INPUT(sender, 6)'benefit
        Dim PurCost, SoldCost As Decimal
        PurCost = AukF.GridT(sender, 4, -1, 0) 'purchaseCost
        SoldCost = AukF.GridT(sender, 5, -1, 0) 'SoldPrice
        If DRow > -1 Then Me.SimStockDataGridView(6, DRow).Value = SoldCost - PurCost 'benefit
        If e.ColumnIndex = 2 Then '2=SIM CATE
            SimC = AukF.GridT(sender)
            Dim R As DataRow
            R = SoftIn.Rows_SelectGetOnlyOne(Me.AukDatabaseDataSet.SimCategory, "SimCategory", SimC)
            If R IsNot Nothing Then 'inset sim category,1=categoryid=mob com
                Me.SimStockDataGridView(1, e.RowIndex).Value = R.Item("Category_Id").ToString
            Else
                AukF.GridTSet(sender, CSOFT.RowStrGetTable(Me.AukDatabaseDataSet.SimCategory, 1), 1)
                'If AukDatabaseDataSet.SimCategory.Rows.Count > 0 Then Me.SimStockDataGridView(2, e.RowIndex).Value = Me.AukDatabaseDataSet.SimCategory(0).SimCategory.ToString
            End If
        End If
        If My.Settings.DIRECT_SAVE = True Then Me.SaveAuto()

    End Sub

    Private Sub FilterSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterSelectedToolStripMenuItem.Click
        ADSRC.DATAGRID_ADVANCE_SELECTED_FILTER(Me.SimStockDataGridView, Me.SimStockBindingSource)
    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.SimStockBindingSource.RemoveFilter()
    End Sub

    Private Sub RefreshDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDatabaseToolStripMenuItem.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.SimStockBindingSource, True)
    End Sub

    Private Sub Db_opt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            a = sender.tag
            If a = "s" Then
                Me.SaveAuto()
            ElseIf a = "d" Then
                Me.SimStockBindingSource.RemoveCurrent()
            ElseIf a = "a" Then
                Me.SimStockBindingSource.AddNew()
                'me.SimStockBindingSource 
            End If
        Catch ex As Exception
            Epx()
        End Try

    End Sub

    Private Sub QueryManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryManagerToolStripMenuItem.Click
        DVDRENT.ShowQr_Product(Me.SimStockDataGridView, Me.SimStockBindingSource)
    End Sub

    Private Sub SimStockDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles SimStockDataGridView.DataError
        GrdErrMsg(e, True)

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SFC("Sim_Number")
            STC(sender.text)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.SimStock, -1, "", False)
            AukF.BindFilter_BSql(Me.SimStockBindingSource, BSql)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            If Me.SimStockBindingSource.Count > 0 Then
                Me.SimStockBindingSource.RemoveCurrent()
            End If
        Catch ex As Exception
            Epx()
        End Try
      
    End Sub


    Private Sub CommonInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommonInformationToolStripMenuItem.Click
        FrmL(SimCommon)
    End Sub

    Private Sub SimSellingFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimSellingFormToolStripMenuItem.Click
        FrmL(SimSold)
    End Sub

    Private Sub SimStock_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Me.NeedToRefresh = True Then
            ReLoadDatabaseToolStripMenuItem_Click(sender, e)
            Me.NeedToRefresh = False

        End If
    End Sub
End Class