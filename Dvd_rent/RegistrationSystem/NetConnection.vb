Public Class NetConnection

    Dim StrHtml As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Settings.NetReg = False
        My.Settings.Save()
        MsgBox("Your Free Net Registration Information is deleted Properly, please restart soft to register again.", MsgBoxStyle.Information)
        SOFTCLOSE()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SOFTCLOSE()
    End Sub

    Private Sub TryAgain(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.WebBrowser1.Refresh(WebBrowserRefreshOption.Normal)

    End Sub
    Private Sub WebBrowser1_StatusTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebBrowser1.StatusTextChanged
        'MsgBox(Me.WebBrowser1.StatusText)
        If Me.WebBrowser1.StatusText = "Done" Then
            StrHtml = Me.WebBrowser1.DocumentText
            'MsgBox(StrHtml)
            If netRegCheck(StrHtml) = True Then
                '    'Clipboard.Clear()
                '    'Clipboard.SetText(StrHtml)
                Me.Hide()
                '    'bcoz if .. found str it will execute auto .. form .inshhow command
                Register.Hide()
            Else
                Me.Label2.Text = "Please Click 'Try Again' to Connect to the Server."
            End If
            'CallOn = False
        End If
    End Sub

    Private Sub NetConnection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Hide()
        'CallOn = True

    End Sub
End Class