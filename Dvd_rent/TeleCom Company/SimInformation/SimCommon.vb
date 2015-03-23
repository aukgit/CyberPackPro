Public Class SimCommon
    Public DxDgrid As DataGridView

    'Private Sub SimCategoryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.SimCategoryBindingSource.EndEdit()
    '    Me.SimCategoryTableAdapter.Update(Me.AukDatabaseDataSet.SimCategory)

    'End Sub

    Private Sub SimCommon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AukDatabaseDataSet.SimCategory.SimCategoryColumn.MaxLength = 20
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.SimCategory' table. You can move, or remove it, as needed.

        Me.AukDatabaseDataSet.SimStock.Sim_CategoryColumn.MaxLength = 20
        Me.AukDatabaseDataSet.SimStock.Purchase_DateColumn.DefaultValue = DBNull.Value
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.SimCategory' table. You can move, or remove it, as needed.
        Me.SimCategoryTableAdapter.Fill(Me.AukDatabaseDataSet.SimCategory)
        DxDgrid = SimStock.SimStockDataGridView
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '"col(1,2,4,5,3,6") on grid=tcom,simcate,purcost,soldpr,purDate,Benefit
        DxDgrid = SimStock.SimStockDataGridView
        Dim Benefit As Decimal
        Dim Boolx(5) As String
        'w& "," & Me.CheckBox2.Checked & "," & Me.CheckBox3.Checked & "," & Me.CheckBox4.Checked & "," & Me.CheckBox4.Checked
        Boolx(0) = Me.CheckBox1.Checked 'com cate
        Boolx(1) = Me.CheckBox1.Checked 'sim cate
        Boolx(2) = Me.CheckBox2.Checked 'purchaseCost
        Boolx(3) = Me.CheckBox2.Checked 'sold pri
        Boolx(4) = Me.CheckBox4.Checked 'purdate
        Boolx(5) = Me.CheckBox2.Checked 'benefit
        Benefit = Val(Me.TextBox2.Text) - Val(Me.TextBox1.Text)
        AukF.Grid_View_Advance_SetCommonItems(SimStock.SimStockDataGridView, "1,2,4,5,3,6", Me.Category_IDTextBox.Text & "," & Me.ComboBox1.Text & "," & Me.TextBox1.Text & "," & Me.TextBox2.Text & "," & Me.TextBox3.Text & "," & Benefit, SrGens.ArrayToStr(Boolx, ","), False, False, False, Me.ProgressBar1, True)
    End Sub
End Class