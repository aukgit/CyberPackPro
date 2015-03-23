Public Class AdvanceSearch

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MQ_ENA.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PR_ENA.CheckedChanged

    End Sub

    Private Sub AdvanceSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For I = 0 To Me.ComboBoxArray1.Count - 1
            MsgBox(Me.ComboBoxArray1.Item(I).Name.ToString & vbCrLf & Me.TextBoxArray1.Item(I).Name.ToString)
        Next
    End Sub
End Class