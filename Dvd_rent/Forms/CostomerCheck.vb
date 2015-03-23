Public Class CostomerCheck
    Dim bnx As New BindingSource
    Private Sub CostomerCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bnx.DataSource = Me.AukDatabaseDataSet.Costomer_Alternative
        AukF.ComSelIndex(Me.ComboBox1)
        AukF.ComSelIndex(Me.ComboBox2)
        'For I = 0 To Me.Controls.Owner.Controls.Count - 1
        '    MsgBox(Me.Controls.Owner.Controls(I).Name)
        'Next
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Costomer_InfTableAdapter.Fill(Me.AukDatabaseDataSet.Costomer_Inf)

    End Sub

    Public Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If AukF.BindFind(True, Me.Costomer_InfBindingSource, Me.ComboBox1.Text, Me.TextBox1.Text) = False Then
            SFC(Me.ComboBox1.Text)
            STC(Me.TextBox1.Text)
            AukF.Db_Load("*", "Costomer_Inf", Me.AukDatabaseDataSet, False)
            AukF.BindFind(True, Me.Costomer_InfBindingSource, Me.ComboBox1.Text, Me.TextBox1.Text)
        End If
        LoadCos(Me.Costomer_IDLabel1.Text)

    End Sub
    Public Function LoadCos(ByVal id As String)
        If AukF.BindFind(bnx, "Costomer_ID", id) = False Then
            SFC("Costomer_ID")
            STC(id)
            AukF.Db_Load("*", "costomer_Alternative", Me.AukDatabaseDataSet, False, "", False, False, CInt(My.Settings.Maximum_Alternative))
        End If

    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If AukF.BindFind(True, bnx, Me.ComboBox1.Text, Me.TextBox1.Text) = False Then
            SFC(Me.ComboBox1.Text)
            STC(Me.TextBox1.Text)
            AukF.Db_Load("*", "Costomer_Inf", Me.AukDatabaseDataSet, False, "", True)
        End If
        LoadCos(Me.Costomer_NameLabel1.Text)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If AukF.BindFind(True, bnx, Me.ComboBox1.Text, Me.TextBox1.Text) = False Then
            SFC(Me.ComboBox1.Text)
            STC(Me.TextBox1.Text)
            AukF.Db_Load("*", "Costomer_Inf", Me.AukDatabaseDataSet, False, "", True, True)
        End If
        LoadCos(Me.Costomer_NameLabel1.Text)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CusR = Me.AukDatabaseDataSet.Costomer_Inf(Me.Costomer_InfBindingSource.Position)
        Alt_name = ""
        Product_Input3.Costomer_IDLoad.Text = CusR.Item(0).ToString
        Product_Input3.LoadCostomer(sender, e)

        FrmL(Product_Input3)


        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CusR = Me.AukDatabaseDataSet.Costomer_Inf(Me.Costomer_InfBindingSource.Position)
        Product_Input3.Costomer_IDLoad.Text = CusR.Item(0).ToString
        Alt_name = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value.ToString
        Product_Input3.LoadCostomer2(sender, e)
        FrmL(Product_Input3)

        Alt_name = Me.DataGridView1(0, Me.DataGridView1.CurrentRow.Index).Value.ToString

        Me.Hide()

        'MsgBox(Alt_name)

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button9_Click(sender, e)

        End If
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        AukQ.Bnp = Me.CostomerInfCostomerAlternativeBindingSource
        FrmL(AukQ)

    End Sub


    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Button1_Click(sender, e)
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted
        Me.ComboBox1.SelectedIndex = Me.ComboBox2.SelectedIndex

    End Sub
End Class