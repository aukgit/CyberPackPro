Public Class DVDViewForm


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()

        Me.Close()

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()

        Me.Close()

    End Sub

    Private Sub DVDView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AukF.XPAuk(Me)

    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click

    End Sub

    Private Sub ToolStripLabel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripLabel1.MouseDown
        AukF.DragAuk(Me)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ShowTable As New DataTable
        SFC("Customer ID")
        STC(Me.Costomer_IDLabel1.Text)
        AukF.Db_Load("*", "DVD_VIEW2", ShowTable, True, "", False, False, Val(My.Settings.MaximumData_load.ToString))
        Me.DataGridView1.DataSource = ShowTable
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim Dv As DataView = Me.DataGridView1.DataSource.defaultview
        Dv.Sort = "Movie Name"
        I = Dv.Find(sender.text)
        If I > -1 Then Me.DataGridView1.Rows(I).Selected = True

    End Sub
End Class