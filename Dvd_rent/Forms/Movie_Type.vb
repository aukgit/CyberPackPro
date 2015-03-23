Public Class Movie_Type
    Public NeedToReType As Boolean
    Private Sub TypeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TypeBindingSource.EndEdit()
            Me.TypeTableAdapter.Update(Me.AukDatabaseDataSet.Type)
            If Product_Input3.Visible = True Then
                Product_Input3.NeedToReType = True
            End If
            'MsgBox(Me.AukDatabaseDataSet.Type.Movie_TypeColum)
        Catch ex As Exception
            Epx()

        End Try
   

    End Sub

    Private Sub Movie_Type_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'If NeedToReType = True Then
        '    AukF.Db_LoadN(Me.AukDatabaseDataSet.Type, -1, "", True, 0, "MOVIE_TYPE")
        '    NeedToReType = False
        'End If
    End Sub
    Private Sub frm_close(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If My.Settings.Dont_RefreshData = True Then
        '    'MsgBox(TrTb.Rows(0).Item(0).ToString)
        '    If Me.AukDatabaseDataSet.Type.Rows.Count >= 2500 Then
        '        e.Cancel = True
        '        Me.Hide()
        '        'Exit Sub
        '    End If
        'End If
        If SoftIn.GetChages(Me.AukDatabaseDataSet) Then
            If SAVMSG() = 1 Then
                TypeBindingNavigatorSaveItem_Click(sender, e)
            ElseIf SavInt = 2 Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub Movie_Type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Type' table. You can move, or remove it, as needed.
        'Me.TypeTableAdapter.Fill(Me.AukDatabaseDataSet.Type)
        Me.AukDatabaseDataSet.Type.Movie_TypeColumn.AutoIncrement = True
        Me.AukDatabaseDataSet.Type.Movie_TypeColumn.AutoIncrementSeed = 1
        Me.AukDatabaseDataSet.Type.Movie_TypeColumn.AutoIncrementStep = 1
        'If FromAnother = False Then
        AukF.Db_LoadN(Me.AukDatabaseDataSet.Type, -1, "", True, 0, "MOVIE_TYPE")
        'End If
        CSOFT.DGrd_GotolastRow(Me.TypeBindingSource)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        AukF.DeleteFromMasterTableGrd(Me.TypeDataGridView, 1)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.TypeBindingSource, True)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        WGeT = InputBox("PLEASE TYPE THE SERAIL ID FOR CREATE PROGAMMATIC VALUES,FORMAT: START-END", "TYPE INPUT ID", INPUTX)
        Dim uA As Array
        uA = WGeT.Split("-")
        If uA.GetUpperBound(0) = 1 Then
            Dim S, EN As Integer
            S = Val(ArV(uA, 0)) : EN = Val(ArV(uA, 1))
            For I = S To EN
                RowX = Me.AukDatabaseDataSet.Type.NewRow
                RowX(0) = I
                Try
                    RowX.Table.Rows.Add(RowX)
                Catch ex As Exception
                    Epx()
                    Exit Sub
                End Try
            Next

        Else
            MsgBox("YOU MUST TYPE IN ORDER", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub COPYSELECTEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPYSELECTEDToolStripMenuItem.Click
        SoftIn.COPY_GRID(Me.TypeDataGridView)
    End Sub

    Private Sub PASTESELECTORINSERTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PASTESELECTORINSERTToolStripMenuItem.Click
        SoftIn.PASTE_GRID(Me.ContextMenuStrip1.SourceControl)
    End Sub

    Private Sub DELETESELETECToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETESELETECToolStripMenuItem.Click
        SendKeys.Send("{DELETE}")
    End Sub

    Private Sub REFRESHCURRENTTABLEDATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHCURRENTTABLEDATAToolStripMenuItem.Click
        Dim DX As DataGridView = Me.TypeDataGridView
        If DX IsNot Nothing Then AukF.SingleDataTable_DataRecordRefresh(DX.DataSource, True)
    End Sub
    Private Sub REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem.Click
        Dim DX As DataGridView = Me.TypeDataGridView
        If DX IsNot Nothing Then AukF.Single_DataRecordRefresh(DX, True)
    End Sub
    Private Sub CUTSELECTEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUTSELECTEDToolStripMenuItem.Click
        SoftIn.CUT_GRID(Me.TypeDataGridView)
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

    Private Sub TypeDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TypeDataGridView.CellEndEdit
        SoftIn.DataGridView_AutoMaticID_ByToken(Me.TypeDataGridView, e, Nothing)

    End Sub

    Private Sub EditEnable(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.TypeDataGridView.ReadOnly = False
    End Sub
End Class