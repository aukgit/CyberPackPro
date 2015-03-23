Public Class DVD_MEMBER

    Private Sub DVD_MEMBER_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()

    End Sub
End Class