Public Class TrailInsInfo
    Dim Img As Integer = 1


    Private Sub TrailInsInfo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Do you want to close this register form?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then SOFTCLOSE() Else e.Cancel = True

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click, Button7.Click, Button6.Click
        If sender.tag = "show" Then Img = 1 : GoTo showimg
        If (Img + 1) > 5 Or (Img - 1) < 0 Then
            If sender.tag = "-" Then
                Img = 5
            Else
                Img = 1
            End If
            Me.PictureBox1.Image = Image.FromFile(AppPath & "\dateimage\" & Img & ".bmp")
        Else
            If Me.PictureBox1.Image Is Nothing Then GoTo showimg
            If sender.tag = "+" Then Img += 1 Else Img -= 1
showimg:    Me.PictureBox1.Image = Image.FromFile(AppPath & "\dateimage\" & Img & ".bmp")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Do you want to close this register form?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then SOFTCLOSE()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Register.TrailInstall = True
        Register.Install_Soft()
        Me.Hide()
        FrmL(Register)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        FrmL(Register)
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RUN_CONDITIONS(Me)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RUN_License(Me)

    End Sub
End Class