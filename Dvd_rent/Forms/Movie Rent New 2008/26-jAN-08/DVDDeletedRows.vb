Public Class DVDDeletedRows
    Dim DvDRAdp As New AukDatabaseDataSetTableAdapters.DVD_RentTableAdapter
    Private Sub DVD_RentDeletedBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DVD_RentDeletedBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.DVD_RentDeletedBindingSource.EndEdit()
            Me.DVD_RentDeletedTableAdapter.Update(Me.AukDatabaseDataSet.DVD_RentDeleted)

        Catch ex As Exception
            Epx()
        End Try
     
    End Sub

    Private Sub DVDDeletedRows_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.DVD_RentDeletedTableAdapter.Fill(Me.AukDatabaseDataSet.DVD_RentDeleted)
        ToolStripTextBox1.Text = NDate()
        Me.ToolStripTextBox1.Focus()
        SFC("Deleted_Date")
        STC(NDate)
        DTC("D")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.DVD_RentDeleted)
        Me.DVD_RentDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        AukF.DeleteMultiRecordsFrmGrid(Me.DVD_RentDataGridView, 5) 'dvdid
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        DVDRENT.ShowQr_Product(Me.DVD_RentDataGridView, Me.DVD_RentDeletedBindingSource)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ADSRC.LOAD_WHOLE_DATABASE(Me.AukDatabaseDataSet.DVD_RentDeleted)
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        'If e.Control = True And e.Shift = False And e.KeyCode = Keys.Enter Then sender.tag = "m"
        'If e.Control = True And e.KeyCode = Keys.Enter Then sender.tag = "m"
        sender.tag = "d"
        CSOFT.Events_of_SummaryTextBox_KeyDown(Me, sender, e, Me.AukDatabaseDataSet.DVD_RentDeleted, "Deleted_Date")
    End Sub
   
    Private Sub TransferToDVDRENTDATABASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferToDVDRENTDATABASEToolStripMenuItem.Click
        Dim DelRow As DataRow
        If AukF.MsgTrU("REALLY WANT TO TRANSFER SELECTED ROW(S) TO DVD RENT DATABASE?", True, MsgBoxStyle.Information) = False Then Exit Sub
        If Me.DVD_RentDataGridView.SelectedRows.Count = 0 AndAlso Me.DVD_RentDataGridView.CurrentCell IsNot Nothing Then Me.DVD_RentDataGridView.CurrentRow.Selected = True
        For K As Integer = DVD_RentDataGridView.SelectedRows.Count - 1 To 0 Step -1
            If Me.DVD_RentDataGridView.SelectedRows.Item(K).Cells(0).Value IsNot Nothing Then
                Dim RentID As String = Me.DVD_RentDataGridView.SelectedRows.Item(K).Cells(0).Value.ToString 'Rent DBID
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.DVD_RentDeleted, RentID) = True Then
                    DelRow = RowX
                    Dim IT As Array
                    IT = RowX.ItemArray
                    Dim Km(19) As Object
                    For L As Integer = 0 To IT.Length - 4 'normal for 1,ad there 3 column is extra
                        Km(L) = ArV2(IT, L, DBNull.Value)
                    Next
                    Try
                        Me.AukDatabaseDataSet.DVD_Rent.Rows.Add(Km)
                        Me.DvDRAdp.Update(Me.AukDatabaseDataSet.DVD_Rent)
                    Catch ex As Exception
                        Epx()
                        Try
                            Km(0) = SoftIn.Master_ID_String_Get(9, 0)
                            Me.AukDatabaseDataSet.DVD_Rent.Rows.Add(Km)
                            Me.DvDRAdp.Update(Me.AukDatabaseDataSet.DVD_Rent)
                        Catch exx As Exception
                            Me.AukDatabaseDataSet.DVD_Rent.Clear()
                            'DVD_RentDeletedBindingNavigatorSaveItem_Click(sender, e)

                            Epx()
                            Exit Sub
                        End Try
                    End Try
                End If


            End If
        Next
        SendKeys.Send("{DELETE}")
        Me.AukDatabaseDataSet.DVD_Rent.Clear()
        DVD_RentDeletedBindingNavigatorSaveItem_Click(sender, e)

        'SendKeys.Send("{DELETE}")
    End Sub
End Class