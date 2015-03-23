Public Class DVDOPT

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub OPTIONCLIKEVENT(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.Click, RadioButton3.Click, RadioButton2.Click, RadioButton1.Click
        On Error Resume Next
        My.Settings.DVDOPT_SEE_LISTVIEW = sender.TAG
        If sender.TAG = 2 Then
            Product_Input3.PreTable.Columns(2).Expression = Product_Input3.FORMAT1
        ElseIf sender.TAG = 3 Then
            Product_Input3.PreTable.Columns(2).Expression = Product_Input3.FORMAT2
        Else
            Product_Input3.PreTable.Columns(2).Expression = Product_Input3.FORMAT1
        End If
        If Product_Input3.ListBox1.DataSource IsNot Nothing Then
            If My.Settings.DVDOPT_SEE_LISTVIEW = "2" Or My.Settings.DVDOPT_SEE_LISTVIEW = "3" Then
                Product_Input3.ListBox1.DisplayMember = "ShowInfo"
            ElseIf My.Settings.DVDOPT_SEE_LISTVIEW = "0" Then
                Product_Input3.ListBox1.DisplayMember = "DVD_ID"
            ElseIf My.Settings.DVDOPT_SEE_LISTVIEW = "1" Then
                Product_Input3.ListBox1.DisplayMember = "MOVIE_NAME"

            End If
        End If
        If Product_Input3.ListBox1.Visible = True Then
            If My.Settings.DVDOPT_SEE_LISTVIEW = "2" Or My.Settings.DVDOPT_SEE_LISTVIEW = "3" Then
                Product_Input3.ListBox1.DisplayMember = ""
                Product_Input3.ListBox1.DisplayMember = "ShowInfo"
            End If
        End If
    
    End Sub
    Private Sub DVDOPT_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub
    Private Sub DVDOPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.DVDOPT_SEE_LISTVIEW = "0" Then
            Me.RadioButton1.Checked = True
        ElseIf My.Settings.DVDOPT_SEE_LISTVIEW = "1" Then
            Me.RadioButton2.Checked = True
        ElseIf My.Settings.DVDOPT_SEE_LISTVIEW = "2" Then
            Me.RadioButton3.Checked = True
        ElseIf My.Settings.DVDOPT_SEE_LISTVIEW = "3" Then
            Me.RadioButton4.Checked = True
        End If
        If My.Settings.DVDOPT_USEPASSWORD = True Then
            Me.Enabled = False
            CHK_PASS.fOBJ = Me
            FrmL(CHK_PASS)

            CHK_PASS.TextBox1.Focus()
            'CHK_PASS.Activate()
        End If
        AukF.FindInObjectAndSelect(Me.ComboBox1, My.Settings.DVDOPT_ORDERBY.ToString, True, True)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.Save()

    End Sub


   
End Class