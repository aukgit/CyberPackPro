Public Class Warn
    Public Msg As String
    Dim FX, Fy As Integer
    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        AukF.DragAuk(Me)
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click, Label4.Click
        Me.Hide()
    End Sub

    Private Sub Warn_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Label1.Text = Msg
        AukF.XPAuk(Me)
        Me.Opacity = 0.8
        FX = Me.Location.X
        Fy = Me.Location.Y
    End Sub
    Private Sub Warn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Label3_Click(sender, e)
    End Sub

    Private Sub Warn_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        Me.Label1.Text = Msg
        'Me.StartPosition = FormStartPosition.CenterScreen
        Me.SetDesktopLocation(FX, Fy)





    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
       

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class