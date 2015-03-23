Public Class Pakages

    Private Sub BroadBand_PakegeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BroadBand_PakegeBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.BroadBand_PakegeBindingSource.EndEdit()
            Me.BroadBand_PakegeTableAdapter.Update(Me.AukDatabaseDataSet.BroadBand_Pakege)

        Catch ex As Exception
            Epx()
        End Try
     
    End Sub

    Private Sub Pakages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.BroadBand_Pakege' table. You can move, or remove it, as needed.
        'Me.BroadBand_PakegeTableAdapter.Fill(Me.AukDatabaseDataSet.BroadBand_Pakege)
        AukF.Db_Load("*", "BroadBand_Pakege", Me.AukDatabaseDataSet.BroadBand_Pakege, True, "", False, False, Val(50), 2)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.BroadBand_PakegeBindingSource, True)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        AukF.DeleteFromMasterTable(Me.BroadBand_PakegeBindingSource, 1)

    End Sub

    Private Sub BroadBand_PakegeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BroadBand_PakegeDataGridView.CellContentClick

    End Sub
End Class