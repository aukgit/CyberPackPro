Public Class FIND_BETWEEN
    Public BP As BindingSource = Nothing
    Public ADD_COLUMNS As String = ""
    Dim T As DataTable
    Dim AR1 As Array
    Private Sub FIND_BETWEEN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim STR1 As String
        If BP Is Nothing Then MsgBox("PLEASE SELECT BINDINGSOURCE AUKCOMMAND", MsgBoxStyle.Critical) : Me.Close() : Exit Sub
        'If ADD_COLUMNS = "" Then MsgBox("PLEASE SELECT ADD_COLUMNS AUKCOMMAND", MsgBoxStyle.Critical) : Me.Close() : Exit Sub
        T = AukF.Get_DataSystemObj(BP)
        If ADD_COLUMNS = "" Then
            AukF.ComboToAddTableNames(BP, Me.ComboBox1)
        Else
            STR1 = SoftIn.Replace_Database_FieldsNamesByNumber(T, ADD_COLUMNS)
            AR1 = STR1.Split(CChar(","))
            Me.ComboBox1.DataSource = AR1
        End If
        AukF.ComSelIndex(Me.ComboBox1)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ADSRC.LOAD_WHOLE_DATABASE(T)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If AukF.MsgTr("CLEAR DATA TABLE?", True) Then T.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BP.RemoveFilter()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AukF.BindFilter_BetweenOparetorN(BP, Me.ComboBox1.Text, Me.TextBox1.Text, Me.TextBox2.Text, Me.CheckBox2.Checked, False, True, Not Me.CheckBox1.Checked, -1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PRESS(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown, TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then Button1_Click(sender, e)

    End Sub
End Class