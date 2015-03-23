Public Class MSETTING
  

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Save()
        If NewTrans.Visible = True Then
            NewTrans.NeedTO_INFOR_FONT_CHG = True
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f As New FontConverter
        Dim Fx1 As Font
        Fx1 = f.ConvertFromString(My.Settings.FONT_INFO_MOB)
        Me.FontDialog1.Font = Fx1
        If Me.FontDialog1.ShowDialog = Forms.DialogResult.OK Then
            My.Settings.FONT_INFO_MOB = f.ConvertToString(Me.FontDialog1.Font)
        End If
        NewTrans.EFFECT_ON_INFORMATION_TEXT_VIEW()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If Me.ComboBox3.SelectedIndex = 0 Then 'SMALL
            My.Settings.FONT_INFO_MOB = "Calibri, 14.25pt"
            My.Settings.INFOR_HEIGHT_MOB = 25
        ElseIf Me.ComboBox3.SelectedIndex = 1 Then 'MEDIUM
            My.Settings.FONT_INFO_MOB = "Calibri, 15.75pt"
            My.Settings.INFOR_HEIGHT_MOB = 30
        ElseIf Me.ComboBox3.SelectedIndex = 2 Then 'LARGE
            My.Settings.FONT_INFO_MOB = "Calibri, 20.75pt"
            My.Settings.INFOR_HEIGHT_MOB = 37
        ElseIf Me.ComboBox3.SelectedIndex = 3 Then 'ex LARGE
            My.Settings.FONT_INFO_MOB = "Calibri, 26.25pt, style=Bold"
            My.Settings.INFOR_HEIGHT_MOB = 47
        End If
        NewTrans.EFFECT_ON_INFORMATION_TEXT_VIEW()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Settings.Reload()

    End Sub
    Private Sub INFORMATION_EDIT_UPDATE(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox3.Validating, HScrollBar1.Validating, ComboBox3.Validating, ComboBox2.Validating, Button2.Validating
        NewTrans.EFFECT_ON_INFORMATION_TEXT_VIEW()
    End Sub

    Private Sub HScrollBar1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HScrollBar1.ValueChanged
        NewTrans.EFFECT_ON_INFORMATION_TEXT_VIEW()
    End Sub
End Class