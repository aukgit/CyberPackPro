Public Class ps_employees

    Private Sub ps_employees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
End Class