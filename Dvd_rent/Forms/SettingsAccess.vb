Public Class SettingsAccess

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(Me.TextBox2.Text, MsgBoxStyle.Information, "Password")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Save()

    End Sub
End Class