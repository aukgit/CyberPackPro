Public Class CHK_PASS
    Dim INTCL As Integer = 0
    Public fOBJ As Form
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Settings.SettingsAccessUserPassword = "" Then
            Me.DialogResult = Forms.DialogResult.Yes
            fOBJ.Enabled = True
            fOBJ.Activate()
            Me.Close()
        End If
        If Me.TextBox1.Text = My.Settings.SettingsAccessUserPassword Then
            Me.DialogResult = Forms.DialogResult.Yes
            fOBJ.Enabled = True
            fOBJ.Activate()
            Me.Close()
        Else
            If INTCL >= 3 Then
                'End
                MsgBox("SOFTWARE IS CLOSE NOW.", MsgBoxStyle.Critical)
                SOFTCLOSE()
            Else
                Me.DialogResult = Forms.DialogResult.No
                INTCL += 1
                MsgBox("PASSWORD IS WRONG ,IF YOU FAILED " & (3 - INTCL) + 1 & " TIMES THEN FORM SOFTWARE WILL ME CLOSE.", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        fOBJ.Close()

        Me.Close()

    End Sub

    Private Sub PRESS(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then Button1_Click(sender, e)

    End Sub

    Private Sub CHK_PASS_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TextBox1.Focus()

    End Sub

    Private Sub CHK_PASS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Activate()
    End Sub

    Private Sub CHK_PASS_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Activate()

    End Sub
End Class