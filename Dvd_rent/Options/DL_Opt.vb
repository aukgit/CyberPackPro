Public Class DL_Opt

    Private Sub DL_Opt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'My.Settings.Save()
    End Sub

    Private Sub DL_Opt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.LoadingStyle = 0 Then
            Me.RadioButton1.Checked = True
        ElseIf My.Settings.LoadingStyle = 1 Then
            Me.RadioButton2.Checked = True
        ElseIf My.Settings.LoadingStyle = 2 Then
            Me.RadioButton3.Checked = True
        ElseIf My.Settings.LoadingStyle = 3 Then
            Me.RadioButton4.Checked = True
        End If
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.Click, RadioButton2.Click, RadioButton1.Click, RadioButton4.Click
        My.Settings.LoadingStyle = sender.tag
    End Sub

    Private Sub HScrollBar1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HScrollBar1.ValueChanged
        If TrayIco = False Then
            If AniFrm = True Then
                Form1.Opacity = sender.value / 100
            Else
                LOAD2.Opacity = sender.value / 100
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Label2.Text = Me.HScrollBar1.Value & "%"
        If TrayIco = False Then
            If AniFrm = True Then
                Form1.Opacity = Me.HScrollBar1.Value / 100
            Else
                LOAD2.Opacity = Me.HScrollBar1.Value / 100
            End If
        End If
    End Sub
End Class