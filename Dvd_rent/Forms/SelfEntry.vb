Public Class SelfEntry

    Private Sub Self_Row_ColumnBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Self_Row_ColumnBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Self_Row_ColumnBindingSource.EndEdit()
            Me.Self_Row_ColumnTableAdapter.Update(Me.AukDatabaseDataSet.Self_Row_Column)
            If Product_Input3.Visible = True Then Product_Input3.SendFrmSelf = True : Product_Input3.SelfStockRefresh(sender, e)
        Catch ex As Exception
            Epx()

        End Try
    
    End Sub

    Public Sub SelfEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Self_Row_Column' table. You can move, or remove it, as needed.
        Me.Self_Row_ColumnTableAdapter.Fill(Me.AukDatabaseDataSet.Self_Row_Column)
        'Me.AukDatabaseDataSet.Self_Row_Column.Self_Row_IDColumn.DefaultValue = 0
        'Me.AukDatabaseDataSet.Self_Row_Column.Self_Row_ColumnColumn.DefaultValue = 0
        'Me.AukDatabaseDataSet.Self_Row_Column.Row_NumberColumn.DefaultValue = 0
        'Me.AukDatabaseDataSet.Self_Row_Column.ColumnNumberColumn.DefaultValue = 0
        Me.AukDatabaseDataSet.Self_Row_Column.Self_Row_IDColumn.AutoIncrement = False
        Me.AukDatabaseDataSet.Self_Row_Column.Self_Row_IDColumn.AutoIncrementSeed = 1
        Me.AukDatabaseDataSet.Self_Row_Column.Self_Row_IDColumn.AutoIncrementStep = 1


    End Sub
    Private Sub Self_Row_ColumnDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Self_Row_ColumnDataGridView.CellEndEdit
        On Error Resume Next

        Me.Self_Row_ColumnDataGridView.CurrentCell.DataGridView(1, Self_Row_ColumnDataGridView.CurrentCell.RowIndex).Value = AukF.GridT(Self_Row_ColumnDataGridView, 2) & "_R(" & AukF.GridT(Self_Row_ColumnDataGridView, 3) & ")C(" & AukF.GridT(Self_Row_ColumnDataGridView, 4) & ")"
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim ix1 As Integer
        Dim R As DataRow
        Dim Ua As Array
        Dim MaxNum As Integer = ADSRC.MAXIMUM_VALUE("Self_Row_Column", "Self_Row_ID")
        If AukF.MsgTr(What & "Do you want to insert this Self...?") = True Then
            qa = InputBox("Please Type Self Row & Column as (Row,Column)... Such as Row =5 and Column =4 then type ""5,4""...", "Insert Self", qa)

            If qa <> "" Then
                'Dim Lsty As Array
                Ua = Split(qa, ",")
                'If Lsty.Items.Count = 2 Then
                s1 = Ua.GetValue(0).ToString
                s2 = Ua.GetValue(1).ToString
                If Val(s1) > 0 And Val(s2) > 0 Then
                    For I = 1 To Val(s2)
                        For ix1 = 1 To Val(s1)
                            R = Me.AukDatabaseDataSet.Self_Row_Column.NewRow
                            MaxNum += I
                            R(0) = MaxNum
                            R.Item(3) = ix1
                            R.Item(4) = I
                            R(2) = Me.ToolStripTextBox1.Text
                            R(1) = Me.ToolStripTextBox1.Text & "_R(" & ix1 & ")C(" & I & ")"
                            Try
                                R.Table.Rows.Add(R)
                            Catch ex As Exception
                                Epx()
                                Exit For

                            End Try

                        Next
                    Next
                End If
            End If
            'End If
        End If
        If My.Settings.DIRECT_SAVE = True Then Self_Row_ColumnBindingNavigatorSaveItem_Click(sender, e)
    End Sub
    Private Sub COPYSELECTEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPYSELECTEDToolStripMenuItem.Click
        SoftIn.COPY_GRID(Me.Self_Row_ColumnDataGridView)
    End Sub

    Private Sub PASTESELECTORINSERTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PASTESELECTORINSERTToolStripMenuItem.Click
        SoftIn.PASTE_GRID(Me.ContextMenuStrip1.SourceControl)
    End Sub

    Private Sub DELETESELETECToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETESELETECToolStripMenuItem.Click
        SendKeys.Send("{DELETE}")
    End Sub

    Private Sub REFRESHCURRENTTABLEDATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHCURRENTTABLEDATAToolStripMenuItem.Click
        Dim DX As DataGridView = Me.Self_Row_ColumnDataGridView
        If DX IsNot Nothing Then AukF.SingleDataTable_DataRecordRefresh(DX.DataSource, True)
    End Sub
    Private Sub REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem.Click
        Dim DX As DataGridView = Me.Self_Row_ColumnDataGridView
        If DX IsNot Nothing Then AukF.Single_DataRecordRefresh(DX, True)
    End Sub
    Private Sub CUTSELECTEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUTSELECTEDToolStripMenuItem.Click
        SoftIn.CUT_GRID(Me.Self_Row_ColumnDataGridView)
    End Sub
    Private Sub SAMEINPUTX(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAMEPRODUCTGOODINPUTToolStripMenuItem.Click
        Dim DX As DataGridView = Me.ContextMenuStrip1.SourceControl
        INPUTX = InputBox("PLEASE TYPE COMMON STRING TO INPUT.PLEASE CAFEFULL FROM LINK FIELDS AND NUMBER FIELDS.", "COMMON ITEM", INPUTX)
        SoftIn.SELECTED_CELLS_COMMON_TXT(DX, INPUTX)
    End Sub
    Private Sub FORINSERTCOPYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FORINSERTCOPYToolStripMenuItem.Click
        Dim D As DataGridView = Me.ContextMenuStrip1.SourceControl
        SoftIn.Insert_Copies(D)
    End Sub
    Private Sub FORINSERTCURSELECTEDROWSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FORINSERTCURSELECTEDROWSToolStripMenuItem.Click
        Dim D As DataGridView = Me.ContextMenuStrip1.SourceControl
        SoftIn.Insert_Cut(D)
    End Sub
    Private Sub INSERTCOPYROWSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INSERTCOPYROWSToolStripMenuItem.Click
        Dim D As DataGridView = Me.ContextMenuStrip1.SourceControl
        SoftIn.iNSERT_PASTE(D)

    End Sub

    Private Sub CREATENEWINSERTCOPYROWSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CREATENEWINSERTCOPYROWSToolStripMenuItem.Click
        Dim D As DataGridView = Me.ContextMenuStrip1.SourceControl
        SoftIn.iNSERT_PASTE(D, True)
    End Sub
    Private Sub MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem.Click
        Dim D As DataGridView = Me.ContextMenuStrip1.SourceControl
        SoftIn.ROWS_DATAG_INNER_CHG(D)
    End Sub

    Private Sub ShwoQuery(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        DVDRENT.ShowQr_Product(Me.Self_Row_ColumnDataGridView, Me.Self_Row_ColumnBindingSource)

    End Sub

    Private Sub DeleteRow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        AukF.DeleteFromMasterTableGrd(Me.Self_Row_ColumnDataGridView)

    End Sub
    Public Sub SaveAuto()
        Try
            Me.Validate()
            Me.Self_Row_ColumnBindingSource.EndEdit()
            Me.Self_Row_ColumnTableAdapter.Update(Me.AukDatabaseDataSet.Self_Row_Column)

        Catch ex As Exception
            Epx()

        End Try

    End Sub
    Private Sub SelfEntry_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CSOFT.CheckOnDb_ShoutDownTime(Me.AukDatabaseDataSet, Me, False) = False Then 'cancel
            e.Cancel = True
        End If
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.Self_Row_ColumnBindingSource, True)
    End Sub
End Class