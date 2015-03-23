Public Class SelfCommonAdd

    Private Sub SelfCommonAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Self_Row_Column' table. You can move, or remove it, as needed.
        Me.Self_Row_ColumnTableAdapter.Fill(Me.AukDatabaseDataSet.Self_Row_Column)

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SFC("Self_name")
            STC(sender.text)
            AukF.Db_Load("*", "Self_Row_Column", Me.AukDatabaseDataSet)


        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            CommonAdd.TextBox1.Text = Me.AukDatabaseDataSet.Self_Row_Column(Me.SelfRowColumnBindingSource.Position).Item(0).ToString()
            FrmL(CommonAdd)
            CommonAdd.ComboBox1.SelectedIndex = CommonAdd.ComboBox1.Items.Count - 1

            Me.Hide()
        Catch ex As Exception
            Epx()
        End Try
       

    End Sub
End Class