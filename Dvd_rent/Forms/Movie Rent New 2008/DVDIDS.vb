Public Class DVDIDSFrm

    Private Sub DVDIDSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DVDIDSBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.DVDIDSBindingSource.EndEdit()
            Me.DVDIDSTableAdapter.Update(Me.AukDatabaseDataSet.DVDIDS)
            Product_Input3.RefreshDVDIDS()
        Catch ex As Exception
            Epx()
        End Try
    
    End Sub

    Private Sub DVDIDSFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.DVDIDS' table. You can move, or remove it, as needed.
        Me.DVDIDSTableAdapter.Fill(Me.AukDatabaseDataSet.DVDIDS)

    End Sub
End Class