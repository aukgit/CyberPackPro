Public Class Cyber_PcID

    Private Sub Cyber_PCIDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cyber_PCIDBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Cyber_PCIDBindingSource.EndEdit()
            Me.Cyber_PCIDTableAdapter.Update(Me.AukDatabaseDataSet.Cyber_PCID)
        Catch ex As Exception
            Epx()
        End Try
   

    End Sub

    Private Sub Cyber_PcID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Cyber_PCID' table. You can move, or remove it, as needed.
        'Me.Cyber_PCIDTableAdapter.Fill(Me.AukDatabaseDataSet.Cyber_PCID)

    End Sub

    Private Sub Cyber_PcID_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If SAVMSG() = 1 Then
                Cyber_PCIDBindingNavigatorSaveItem_Click(sender, e)
            ElseIf SavInt = 2 Then
                e.Cancel = True


            End If
        End If
    End Sub

    Private Sub Cyber_PCIDDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Cyber_PCIDDataGridView.CellEndEdit
        If My.Settings.DIRECT_SAVE = True Then Cyber_PCIDBindingNavigatorSaveItem_Click(sender, e)
    End Sub
End Class