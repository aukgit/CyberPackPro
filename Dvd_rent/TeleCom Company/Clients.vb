Public Class Clients

    Private Sub Mob_ClientsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mob_ClientsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Mob_ClientsBindingSource.EndEdit()
            Me.Mob_ClientsTableAdapter.Update(Me.AukDatabaseDataSet.Mob_Clients)
        Catch ex As Exception
            Epx()
        End Try
    
    End Sub

    Private Sub Clients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Mob_Clients' table. You can move, or remove it, as needed.
        Me.Mob_ClientsTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Clients)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.Mob_ClientsBindingSource, True)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        AukQ.Bnp = Me.Mob_ClientsBindingSource

        FrmL(AukQ)


    End Sub

    Private Sub DIRECT_SAVE(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Mob_ClientsDataGridView.CellEndEdit
        If My.Settings.DIRECT_SAVE = True Then Mob_ClientsBindingNavigatorSaveItem_Click(sender, e)

    End Sub

    Private Sub Clients_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If My.Settings.Dont_RefreshData = True Then
        '    'MsgBox(TrTb.Rows(0).Item(0).ToString)
        '    If Me.AukDatabaseDataSet.Mob_Clients.Rows.Count >= 2500 Then
        '        e.Cancel = True
        '        Me.Hide()
        '        'Exit Sub
        '    End If
        'End If
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If SAVMSG() = 1 Then
                Mob_ClientsBindingNavigatorSaveItem_Click(sender, e)
            ElseIf SavInt = 2 Then
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                ADSRC.TWICE_EXE(sender, e, Me.Mob_ClientsBindingSource, "Client_Name", "Client_Contacts", True, False, 1, 7)
                Me.Mob_ClientsBindingSource.Filter = BSql
                Me.Remove_Filter.Visible = True
            Catch ex As Exception
                Epx()
            End Try
        End If
    End Sub


    Private Sub Mob_ClientsBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Mob_ClientsBindingSource.PositionChanged
        If Me.Mob_ClientsBindingSource.Filter IsNot Nothing Then
            Me.Remove_Filter.Visible = True
        Else
            Me.Remove_Filter.Visible = False
        End If
    End Sub

    Private Sub Remove_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove_Filter.Click
        Me.Mob_ClientsBindingSource.RemoveFilter()
        Me.Remove_Filter.Visible = False
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        ADSRC.TWICE_BINDFIND(Me.Mob_ClientsBindingSource, "Client_ID", "Client_Name", sender.text, "Client_Contacts")

    End Sub
End Class