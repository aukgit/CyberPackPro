Public Class UserCreator

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.UsersBindingSource.EndEdit()
            Me.UsersTableAdapter.Update(Me.AukDatabaseDataSet.Users)

        Catch ex As Exception
            Epx()
        End Try
      
    End Sub

    Private Sub UserCreator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Enabled = False
        CHK_PASS.fOBJ = Me
        FrmL(CHK_PASS)

        CHK_PASS.TextBox1.Focus()
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.AukDatabaseDataSet.Users)

    End Sub

    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoPictureBox.DoubleClick
        Dim O As New OpenFileDialog
        DVDRENT.IMAGE_INPUT(O, Me.LogoPictureBox)
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        AukQ.Bnp = Me.UsersBindingSource
        FrmL(AukQ)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoginInformation.UserIDLoad(Me.UserIDTextBox.Text)
        FrmL(LoginInformation)
    End Sub
End Class
