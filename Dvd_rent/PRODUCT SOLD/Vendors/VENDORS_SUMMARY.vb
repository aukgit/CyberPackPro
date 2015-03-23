Public Class VENDORS_SUMMARY

    Private Sub VENDORS_SUMMARY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.V_Summary' table. You can move, or remove it, as needed.
        'Me.V_SummaryTableAdapter.Fill(Me.AukDatabaseDataSet.V_Summary)
        SFC("TOTAL IN HAND")
        STC("0")
        DTC("n")
        SnX(">")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.V_Summary)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        DVDRENT.ShowQr_Product(Me.V_SummaryDataGridView, Me.V_SummaryBindingSource)
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        AukF.BindFind(Me.V_SummaryBindingSource, "VENDOR'S ID", sender.TEXT, True)

    End Sub

    Private Sub V_SummaryDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles V_SummaryDataGridView.CellClick
        AukF.BindFind(Vendor.VENDORBindingSource, "V_ID", AukF.GridT(Me.V_SummaryDataGridView, 0).ToString, True)

    End Sub

    Private Sub V_SummaryDataGridView_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles V_SummaryDataGridView.KeyPress
        AukF.BindFind(Vendor.VENDORBindingSource, "V_ID", AukF.GridT(Me.V_SummaryDataGridView, 0).ToString, True)

    End Sub
End Class