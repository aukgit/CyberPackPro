Public Class LoginInformation

    Private Sub UserAccessBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccessBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserAccessBindingSource.EndEdit()
        Me.UserAccessTableAdapter.Update(Me.AukDatabaseDataSet.UserAccess)

    End Sub

    Private Sub LoginInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.UserAccess' table. You can move, or remove it, as needed.
        'Me.UserAccessTableAdapter.Fill(Me.AukDatabaseDataSet.UserAccess)

    End Sub
    Public Sub UserIDLoad(ByVal Id As String)
        SFC("UserID")
        STC(Id)
        AukF.Db_LoadN(Me.AukDatabaseDataSet.UserAccess)
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        DVDRENT.ShowQr_Product(Me.UserAccessDataGridView, Me.UserAccessBindingSource) 'execute query manager
    End Sub
End Class