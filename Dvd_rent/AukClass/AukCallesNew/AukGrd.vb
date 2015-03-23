Public Module AukGrd
    'Public Sub KeyDowns_EvtGridView(ByVal D As DataGridView, ByVal E As KeyEventArgs, Optional ByVal GotoCellBeginEdit As Boolean = True, Optional ByVal EnterId As Boolean = True, Optional ByVal MaxlenOfId As Integer = 9, Optional ByVal EntNextCell As Boolean = True)
    '    If D Is Nothing Then MsgBox("DATAGRID OBJECT IS NOTHING", MsgBoxStyle.Critical) : Exit Sub
    '    Dim HandEnter As Boolean = E.Handled
    '    If HandEnter = True Then 'it means all key down evt is false
    '        If E.KeyCode = Keys.Enter AndAlso EntNextCell = True Then
    '            SetCurrentCell(D, D.CurrentCell.ColumnIndex + 1, D.CurrentCell.RowIndex, GotoCellBeginEdit)
    '        ElseIf E.KeyCode = Keys.Enter AndAlso EntNextCell = False Then 'have chg after
    '            SetCurrentCell(D, D.CurrentCell.ColumnIndex, D.CurrentCell.RowIndex + 1, GotoCellBeginEdit)
    '        ElseIf E.KeyCode = Keys.Up Then
    '            If E.Control = True Then
    '                SetCurrentCell(D, D.CurrentCell.ColumnIndex, 0, GotoCellBeginEdit)
    '            Else
    '                SetCurrentCell(D, D.CurrentCell.ColumnIndex, D.CurrentCell.RowIndex - 1, GotoCellBeginEdit)
    '            End If
    '        ElseIf E.KeyCode = Keys.Down Then
    '            If E.Control = True Then
    '                SetCurrentCell(D, D.CurrentCell.ColumnIndex, D.RowCount - 1, GotoCellBeginEdit)
    '            Else
    '                SetCurrentCell(D, D.CurrentCell.ColumnIndex, D.CurrentCell.RowIndex + 1, GotoCellBeginEdit)
    '            End If
    '        ElseIf E.KeyCode = Keys.Right Then
    '            If E.Control = True Then
    '                SetCurrentCell(D, D.ColumnCount - 1, D.CurrentCell.RowIndex, GotoCellBeginEdit)
    '            Else
    '                SetCurrentCell(D, D.CurrentCell.ColumnIndex + 1, D.CurrentCell.RowIndex, GotoCellBeginEdit)
    '            End If
    '        ElseIf E.KeyCode = Keys.Left Then
    '            If E.Control = True Then
    '                SetCurrentCell(D, 0, D.CurrentCell.RowIndex, GotoCellBeginEdit)
    '            Else
    '                SetCurrentCell(D, D.CurrentCell.ColumnIndex - 1, D.CurrentCell.RowIndex, GotoCellBeginEdit)
    '            End If
    '        End If
    '    Else 'means its ownkeys are effect is true
    '        If E.KeyCode = Keys.Enter AndAlso EntNextCell = True Then
    '            SetCurrentCell(D, D.CurrentCell.ColumnIndex + 1, D.CurrentCell.RowIndex - 1, GotoCellBeginEdit)
    '        ElseIf E.KeyCode = Keys.Enter AndAlso EntNextCell = False Then 'have chg after
    '            SetCurrentCell(D, D.CurrentCell.ColumnIndex, D.CurrentCell.RowIndex + 1, GotoCellBeginEdit)
    '        ElseIf E.KeyCode = Keys.Up Then
    '            If E.Control = True Then
    '                SetCurrentCell(D, D.CurrentCell.ColumnIndex, 0, GotoCellBeginEdit)
    '            Else
    '                SetCurrentCell(D, D.CurrentCell.ColumnIndex, D.CurrentCell.RowIndex - 1, GotoCellBeginEdit)
    '            End If
    '        ElseIf E.KeyCode = Keys.Down Then
    '            If E.Control = True Then
    '                SetCurrentCell(D, D.CurrentCell.ColumnIndex, D.RowCount - 1, GotoCellBeginEdit)
    '            Else
    '                SetCurrentCell(D, D.CurrentCell.ColumnIndex, D.CurrentCell.RowIndex + 1, GotoCellBeginEdit)
    '            End If
    '        ElseIf E.KeyCode = Keys.Right Then
    '            If E.Control = True Then
    '                SetCurrentCell(D, D.ColumnCount - 1, D.CurrentCell.RowIndex, GotoCellBeginEdit)
    '            Else
    '                SetCurrentCell(D, D.CurrentCell.ColumnIndex + 1, D.CurrentCell.RowIndex, GotoCellBeginEdit)
    '            End If
    '        ElseIf E.KeyCode = Keys.Left Then
    '            If E.Control = True Then
    '                SetCurrentCell(D, 0, D.CurrentCell.RowIndex, GotoCellBeginEdit)
    '            Else
    '                SetCurrentCell(D, D.CurrentCell.ColumnIndex - 1, D.CurrentCell.RowIndex, GotoCellBeginEdit)
    '            End If
    '        End If

    '    End If
    '    If EnterId = True Then SoftIn.Master_ID_String(D, MaxlenOfId)
    'End Sub
    'Public Sub SetCurrentCell(ByVal D As DataGridView, Optional ByVal Column As Integer = -1, Optional ByVal RowIndex As Integer = -1, Optional ByVal BeginEdit As Boolean = True, Optional ByVal LogicStr As String = Nothing, Optional ByVal LogicElseCol As Integer = -1, Optional ByVal LogicElseRow As Integer = -1)
    '    If D.CurrentCell Is Nothing Then Exit Sub
    '    Dim MaxRowIndex As Integer = D.RowCount - 1
    '    Dim MaxColumnIndex As Integer = D.ColumnCount - 1

    '    DRow = D.CurrentCell.RowIndex
    '    DColumn = D.CurrentCell.ColumnIndex
    '    If Column = -1 Then Column = DColumn
    '    If RowIndex = -1 Then RowIndex = DRow
    '    If MaxColumnIndex >= Column AndAlso D.Columns(Column).Visible = False Then Column += 1
    '    If LogicStr Is Nothing Then
    '        If (Column > -1 AndAlso RowIndex > -1) Then
    '            If (MaxColumnIndex >= Column AndAlso MaxRowIndex >= RowIndex) Then

    '                D.CurrentCell = D(Column, RowIndex)
    '            End If
    '        End If
    '    Else
    '        If AukF.GridT(D, Column, DRow).ToString = LogicStr Then
    '            D.CurrentCell = D(Column, RowIndex)
    '        Else
    '            If LogicElseRow = -1 Then LogicElseRow = DRow
    '            If LogicElseCol = -1 Then LogicElseCol = DColumn
    '            If (LogicElseRow > -1 AndAlso LogicElseCol > -1) AndAlso (MaxColumnIndex >= LogicElseCol AndAlso MaxRowIndex >= LogicElseRow) Then
    '                D.CurrentCell = D(LogicElseCol, LogicElseRow)

    '            End If
    '        End If
    '    End If

    '    'If BeginEdit = True Then D.BeginEdit(True)
    'End Sub

End Module
