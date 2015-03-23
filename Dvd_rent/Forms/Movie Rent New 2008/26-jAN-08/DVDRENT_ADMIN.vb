Public Class DVDRENT_ADMIN

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Settings.Save()
    End Sub

    Private Sub DVDRENT_ADMIN_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.DVD_RentDeleted' table. You can move, or remove it, as needed.
        'Me.DVD_RentDeletedTableAdapter.Fill(Me.AukDatabaseDataSet.DVD_RentDeleted)
        If My.Settings.DVDOpt_PasswordDelRows = True Then
            Me.Enabled = False
            CHK_PASS.fOBJ = Me
            FrmL(CHK_PASS)
            CHK_PASS.TextBox1.Focus()
            'CHK_PASS.Activate()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmL(DVDDeletedRows)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If AukF.MsgTr("Delete Before Records?", True) = False Then Exit Sub
        If Val(My.Settings.DVOpt_DelRowsKeep) > -1 Then
            SFC("DELETED_DATE")
            STC(Dat2(NDate, False).AddDays(-Val(My.Settings.DVOpt_DelRowsKeep)))
            DTC("d")
            SnX("<=")
            AukF.Db_LoadN(Me.AukDatabaseDataSet.DVD_RentDeleted, -1, "", True, 0, "", False, -1, Val(My.Settings.MaximumData_load))
            For K As Integer = 0 To Me.AukDatabaseDataSet.DVD_RentDeleted.Rows.Count - 1
                Me.AukDatabaseDataSet.DVD_RentDeleted(K).Delete()
            Next
            Me.DVD_RentDeletedTableAdapter.Update(Me.AukDatabaseDataSet.DVD_RentDeleted)
        End If
    End Sub

    'Private Sub DVD_RentDeletedBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.DVD_RentDeletedBindingSource.EndEdit()
    '    Me.DVD_RentDeletedTableAdapter.Update(Me.AukDatabaseDataSet.DVD_RentDeleted)

    'End Sub
End Class