Public Class SplashSc
    Dim Inter As Integer = 0

    Private Sub Lorenzo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Text = Me.Label1.Text
        'My.Computer.Audio.re()
        'MsgBox(My.Settings.SoftNamex.ToString)
        On Error GoTo b
        'MsgBox(Me.AxShockwaveFlash1.FlashVersion.ToString)
        Me.Text = My.Settings.SoftNamex.ToString
        Inter = 88
        Exit Sub

b:
        MsgBox("Please Install Flash Player " & FlashVersion, MsgBoxStyle.Information)
        AukF.OExe(AppPath & FlashFIleName, Me) 'run flash installer
        DVDRENT.SOFTCLOSE()
    End Sub


    Private Sub AxShockwaveFlash1_FSCommand(ByVal sender As Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles AxShockwaveFlash1.FSCommand
        If e.command = "loaded" Then
            Me.Controls.Remove(AxShockwaveFlash)
            Me.Hide()
            Form1.Show()
        ElseIf e.command = "auk" Then
            FrmL(Auk_Information)
        End If
    End Sub

    
    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub
End Class