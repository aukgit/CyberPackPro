Public Class SimCate

    Private Sub SimCate_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CSOFT.CheckOnDb_ShoutDownTime(Me.AukDatabaseDataSet, Me) = False Then Exit Sub
    End Sub
    Public Sub SaveAuto()
        Try
            Me.Validate()
            Me.Mob_ComBindingSource.EndEdit()
            Me.SimCategoryBindingSource.EndEdit()
            Me.Mob_ComTableAdapter.Update(Me.AukDatabaseDataSet.Mob_Com)
            Me.SimCategoryTableAdapter.Update(Me.AukDatabaseDataSet.SimCategory)

        Catch ex As Exception
            Epx()
        End Try
    End Sub
    Private Sub Mob_ComBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mob_ComBindingNavigatorSaveItem.Click
        SaveAuto()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        AukF.DeleteFromMasterTable(Me.Mob_ComBindingSource, 0)

    End Sub

    Private Sub SimCate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AukDatabaseDataSet.SimCategory.SimCategoryColumn.MaxLength = 20
        Me.Mob_ComTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Com)
        Me.SimCategoryTableAdapter.Fill(Me.AukDatabaseDataSet.SimCategory)
    End Sub

    Private Sub SimCategoryDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SimCategoryDataGridView.CellEndEdit, Mob_ComDataGridView.CellEndEdit
        If My.Settings.DIRECT_SAVE = True Then Me.SaveAuto()
    End Sub
End Class