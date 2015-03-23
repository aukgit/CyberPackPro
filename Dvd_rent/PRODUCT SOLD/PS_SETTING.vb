Public Class PS_SETTING

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PS_SETTING_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
        If SoftIn.GetChages(Me.AukDatabaseDataSet) = True Then
            If SAVMSG() = 1 Then
                PS_EmployeBindingNavigatorSaveItem_Click(sender, e)
            ElseIf SavInt = 2 Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub PS_SETTING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.PS_Employe' table. You can move, or remove it, as needed.
        Me.PS_EmployeTableAdapter.Fill(Me.AukDatabaseDataSet.PS_Employe)
        If My.Settings.DVDOPT_USEPASSWORD = True Then
            Me.Enabled = False
            CHK_PASS.fOBJ = Me
            FrmL(CHK_PASS)
        End If
    End Sub

    Private Sub PS_EmployeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PS_EmployeBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.PS_EmployeBindingSource.EndEdit()
            Me.PS_EmployeTableAdapter.Update(Me.AukDatabaseDataSet.PS_Employe)
        Catch ex As Exception
            Epx()

        End Try
    
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        AukF.BindFind(Me.PS_EmployeBindingSource, "EMPLOYE_NAME", sender.TEXT, True)
    End Sub
End Class