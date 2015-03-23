Public Class RENTAL_SET

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        My.Settings.RENT_MOVIE_BY_DVDOPT = Me.ComboBox1.SelectedIndex
        Me.Label2.Text = sender.TEXT
        If Me.ComboBox1.SelectedIndex = 1 Then
            My.Settings.DVDOPT_PREVIOUS_MOVIE_COSTOMER = False
        Else
            My.Settings.DVDOPT_PREVIOUS_MOVIE_COSTOMER = True

        End If
    End Sub

    Private Sub RENTAL_SET_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub RENTAL_SET_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ComboBox1.SelectedIndex = My.Settings.RENT_MOVIE_BY_DVDOPT
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
End Class