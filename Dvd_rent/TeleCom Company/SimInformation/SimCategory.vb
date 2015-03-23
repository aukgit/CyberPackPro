Public Class SimCategory

    Private Sub Mob_ComBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mob_ComBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Mob_ComBindingSource.EndEdit()
            Me.Mob_ComTableAdapter.Update(Me.AukDatabaseDataSet.Mob_Com)
            Me.SimCategoryBindingSource.EndEdit()
            Me.SimCategoryTableAdapter.Update(Me.AukDatabaseDataSet.SimCategory)
        Catch ex As Exception
            Epx()
        End Try

    End Sub

    Private Sub SimSold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.SimCategory' table. You can move, or remove it, as needed.
        Me.Mob_ComTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Com)

        Me.SimCategoryTableAdapter.Fill(Me.AukDatabaseDataSet.SimCategory)
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Mob_Com' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Mob_ComDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Mob_ComDataGridView.CellContentClick

    End Sub
End Class