Public Class Advance_SelectedEntry
    Dim StrJ, StrM, StrK As String
    'j title
    'm find text
    'k columns
    Public DxDgrid As DataGridView
    Private Sub Advance_SelectedEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Self_Row_Column' table. You can move, or remove it, as needed.
        Me.Self_Row_ColumnTableAdapter.Fill(Me.AukDatabaseDataSet.Self_Row_Column)
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Type' table. You can move, or remove it, as needed.
        Me.TypeTableAdapter.Fill(Me.AukDatabaseDataSet.Type)
        Me.DateTimePicker1.Value = Now.Date

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'DxDgrid = Product_input.Product_CollectionDataGridView
        StrJ = ""
        StrM = ""
        If Me.C(Me.CheckBox1) Then
            J(2) 'movie type
            M(Me.ComboBox1.SelectedValue.ToString)
        End If
        If Me.C(Me.CheckBox2) Then
            J(3) 'movieversion

            M(Me.ComboBox2.Text)
        End If
        If Me.C(Me.CheckBox3) Then
            J(4) 'moviename
            M(Me.TextBox1.Text)
        End If
        If Me.C(Me.CheckBox4) Then
            J(7) 'place
            M(Me.ComboBox3.Text)
        End If
        If Me.C(Me.CheckBox5) Then
            J(9) 'self
            M(Me.ComboBox4.SelectedValue)
        End If
        If Me.C(Me.CheckBox6) Then
            J(12) 'movie advamce type
            M(Me.TextBox2.Text)
        End If
        If Me.C(Me.CheckBox7) Then
            J(5) 'ins date
            M(Me.DateTimePicker1.Value.Date)
        End If
        If Me.C(Me.CheckBox8) Then J(1) : M(Me.TextBox4.Text) 'puchase cost
        If Me.C(Me.CheckBox9) Then J(13) : M(Me.TextBox5.Text) 'rent default
        If Me.C(Me.CheckBox10) Then J(11) : M(Me.TextBox6.Text) 'discount
        If Me.C(Me.CheckBox10) Then J(14) : M(Me.TextBox7.Text) 'comments
        AukF.Grid_View_Advance_SetCommonItems(Product_Input3.Product_CollectionDataGridView, StrJ, StrM, "", False, False, False, Me.ProgressBar1, True, True)
    End Sub
    Private Function J(ByVal Ik As String)
        If StrJ = "" Then
            StrJ = Ik
        Else
            StrJ = StrJ & "," & Ik
        End If
    End Function
    Private Function M(ByVal Ik As String)
        If StrM = "" Then
            StrM = Ik
        Else
            StrM = StrM & "," & Ik

        End If
    End Function
    Private Function K(ByVal Ik As String)
        If StrK = "" Then
            StrK = Ik
        Else
            StrK = StrK & "," & Ik
        End If
    End Function

    Private Function C(ByVal Ik As CheckBox) As Boolean
        If Ik.Checked = True Then
            C = True
        Else
            C = False
        End If
    End Function

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If Me.TextBox2.Text = "" Then
            Me.TextBox2.Text = Me.ComboBox5.Text
        ElseIf Me.TextBox2.Text <> "" Then
            Me.TextBox2.Text = Me.TextBox2.Text & Me.TextBox3.Text & Me.ComboBox5.Text

        End If
    End Sub

    Private Sub ComboBox5_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectionChangeCommitted
      
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class