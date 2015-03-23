Module ADSRC
    Dim NT As New DataTable
    Public Sub GRID_COLUMN_ADDTO_COMBO(ByVal D As DataGridView, ByVal COM As Object)
        For K As Integer = 0 To D.Columns.Count - 1
            COM.Items.Add(D.Columns(K).HeaderText.ToString)
        Next
        AukF.ComSelIndex(COM)
    End Sub
    Public Sub Query_Matches_From_Table_Select_Grid_Rows(ByVal Dgrid As Object, ByVal WField As Object, ByVal F As String, Optional ByVal Bp As BindingSource = Nothing, Optional ByVal OpenRecInt As Integer = 1500, Optional ByVal Func As Integer = 0, Optional ByVal Sign As String = "=", Optional ByVal WilCard As String = "%")
        Dim T As DataTable
        Dim Rows() As DataRow
        'Dim M As Integer

        'If SoftIn.Ram_Get < 10 Then MsgBox("You ram is less than 10 MB so it's too risky to do so,please refresh you ram by any soft or install more physical memory(ram).", MsgBoxStyle.Information) : Exit Sub
        If Bp Is Nothing Then
            If TypeOf (Dgrid.datasource) Is BindingSource Then
                Bp = Dgrid.datasource
            Else
                MsgBox("Please Select the bindingsource.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        T = AukF.Get_DataSystemObj(Bp)
        w = SoftIn.GetTableColumn_NameString(T, WField)
        If SoftIn.Get_DataType_Str(T, w) = False Then
            If WGeT.ToLower = "datetime" Then
                Try
                    c = CDate(F)
                Catch ex As Exception
                    MsgBox("Please type the data as date type.", MsgBoxStyle.Critical)
                    Exit Sub
                End Try
            ElseIf IsNumeric(F) = False Then
                MsgBox("Please type the data as number type.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        Try
            BSql = SoftIn.GetFunction_QrText(T, WField, F, Func, Sign, True, ";", WilCard)
            If Bp.Filter IsNot Nothing Then
                a = "(" & BSql & ") and ( " & Bp.Filter & ")"
            Else
                a = BSql
            End If
            If T.Rows.Count <= OpenRecInt Then
                Rows = T.Select(a)
                If Rows IsNot Nothing And Rows.Length <> 0 Then
                    For K As Integer = 0 To Rows.GetUpperBound(0)
                        RowX = Rows.GetValue(K)
                        ax = RowX.Item(0).ToString
                        nfield = T.Columns.Item(0).ColumnName.ToString
                        If AukF.BindFind(Bp, nfield, ax) = True Then
                            Select_GridRows(Dgrid, ComRow)
                        End If
                    Next
                    Rows = Nothing
                End If
            Else
                MsgBox("There is a limit to do this type of search so we can't.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Rows = Nothing
            Epx()
        End Try
    End Sub
    Public Sub Select_GridRows(ByVal Grd As Object, ByVal Row As Integer)
        'Dim R As DataGridView
        If Row < 0 Then Exit Sub
        If TypeOf (Grd) Is DataGrid Then
            Grd.Select(Row)
        ElseIf TypeOf (Grd) Is DataGridView Then
            Grd.Rows(Row).Selected = True
        End If
    End Sub
    Public Function QEnterTo_ByOr_(ByVal FINDINPUT As String, ByVal T As DataTable, ByVal DGrid As Object, ByVal Columns As String, Optional ByVal Func As Integer = 0, Optional ByVal Func_Column As String = Nothing, Optional ByVal Func_int As String = Nothing, Optional ByVal ClrDb As Boolean = False, Optional ByVal Start As Integer = -1, Optional ByVal Limit As Integer = 50, Optional ByVal Key As String = ",", Optional ByVal OrderBY As String = "", Optional ByVal Signs As String = Nothing) As Boolean
        'Use to find By KeyPress Event and open and select and ctrl+enter to select.
       
        Dim Ua, Ua2, Ua3, Ua4 As Array
        Dim Ua1(0) As String
        Ua = Columns.Split(CChar(Key))
        If Ua IsNot Nothing Then
            Try
                Ua1(0) = FINDINPUT
            Catch ex As Exception
                Exit Function
            End Try
            If Func_Column IsNot Nothing Then Ua2 = Func_Column.Split(CChar(Key))
            If Func_int IsNot Nothing Then Ua3 = Func_int.Split(CChar(Key))
            If Signs IsNot Nothing Then SingArray = Signs.Split(CChar(Key))
            Return ADSRC.Query_Add_For_SameText_Diff_Field(T, Ua, Ua1, Func, Ua2, Ua3, ClrDb, Start, Limit, OrderBY, Ua4, True)
        End If

        'ua=columns,ua1=findstr,ua2=func_col,ua3=func_int,ua4=sings
    End Function
    Public Function QEnterTo_Query_FObject_and_Select_DataGridObject(ByVal Sender As Object, ByVal e As KeyEventArgs, ByVal T As DataTable, ByVal DGrid As Object, ByVal Columns As String, Optional ByVal Func As Integer = 0, Optional ByVal Func_Column As String = Nothing, Optional ByVal Func_int As String = Nothing, Optional ByVal ClrDb As Boolean = False, Optional ByVal Start As Integer = -1, Optional ByVal Limit As Integer = 50, Optional ByVal Key As String = ",", Optional ByVal OrderBY As String = "", Optional ByVal Signs As String = Nothing) As Boolean
        'Use to find By KeyPress Event and open and select and ctrl+enter to select.
        If e.Modifiers = Keys.Control And e.Shift = True And e.KeyCode = Keys.Enter Then
            If DGrid IsNot Nothing Then
                ADSRC.Query_Matches_From_Table_Select_Grid_Rows(DGrid, DGrid.CurrentCell.ColumnIndex, Sender.text, Nothing, 2500, 1)
                WGeT = "NO"
                Return True
            End If
        ElseIf e.Modifiers = Keys.Control And e.KeyCode = Keys.Enter Then
            If DGrid IsNot Nothing Then
                ADSRC.Query_Matches_From_Table_Select_Grid_Rows(DGrid, DGrid.CurrentCell.ColumnIndex, Sender.text)
                WGeT = "NO"
                Return True
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            Dim Ua, Ua2, Ua3, Ua4 As Array
            Dim Ua1(0) As String
            Ua = Columns.Split(CChar(Key))
            If Ua IsNot Nothing Then
                Try
                    Ua1(0) = Sender.text
                Catch ex As Exception
                    Ua1(0) = Sender.ToString
                End Try
                If Func_Column IsNot Nothing Then Ua2 = Func_Column.Split(CChar(Key))
                If Func_int IsNot Nothing Then Ua3 = Func_int.Split(CChar(Key))
                If Signs IsNot Nothing Then SingArray = Signs.Split(CChar(Key))
                Return ADSRC.Query_Add_For_SameText_Diff_Field(T, Ua, Ua1, Func, Ua2, Ua3, ClrDb, Start, Limit, OrderBY, Ua4, True)
            End If
        End If
        'ua=columns,ua1=findstr,ua2=func_col,ua3=func_int,ua4=sings
    End Function
    Public Function Query_Add_For_SameText_Diff_Field(ByVal T As DataTable, ByVal Columns As String, ByVal FindStr As String, Optional ByVal Func As Integer = 0, Optional ByVal Func_Column As String = Nothing, Optional ByVal Func_int As String = Nothing, Optional ByVal ClrDb As Boolean = False, Optional ByVal Start As Integer = -1, Optional ByVal Limit As Integer = 50, Optional ByVal Key As String = ",", Optional ByVal OrderBY As String = "", Optional ByVal Signs As String = Nothing, Optional ByVal FindOnly_One As Boolean = False) As Boolean
        Dim Ua, Ua2, Ua3, SingArray As Array
        Ua = Columns.Split(CChar(Key))
        If Ua IsNot Nothing Then
            Ua1 = FindStr.Split(CChar(Key))
            If Func_Column IsNot Nothing Then Ua2 = Func_Column.Split(CChar(Key))
            If Func_int IsNot Nothing Then Ua3 = Func_int.Split(CChar(Key))
            If Signs IsNot Nothing Then SingArray = Signs.Split(CChar(Key))
            Return ADSRC.Query_Add_For_SameText_Diff_Field(T, Ua, ua1, Func, Ua2, Ua3, ClrDb, Start, Limit, OrderBY, SingArray, FindOnly_One)
        End If
    End Function
    Public Function Query_Add_For_SameText_Diff_Field(ByVal T As DataTable, ByVal Columns As Array, ByVal FindStr As Array, Optional ByVal Func As Integer = 0, Optional ByVal Func_Column As Array = Nothing, Optional ByVal Func_int As Array = Nothing, Optional ByVal ClrDb As Boolean = False, Optional ByVal Start As Integer = -1, Optional ByVal Limit As Integer = 50, Optional ByVal OrderBY As String = "", Optional ByVal Signs As Array = Nothing, Optional ByVal FindOnly_One As Boolean = False) As Boolean
        'e.g.:ADSRC.Query_OR_ADD_FindOne(sender, e, Me.AukDatabaseDataSet.PS_SOLD_V, "SOLD ID,PRODUCT_SERIAL,SOLD DATE,REPORT ID,PRODUCT NAME", "PRODUCT NAME" ,1, "2")
        Dim Str, Col, SignStr As String
        Dim Dq1 As Date
        Dont_UseLike_Number_Date = True
        For K As Integer = 0 To Columns.GetUpperBound(0)
            COLINT = ArV(Columns, K).ToString
            Col = SoftIn.GetTableColumn_NameString(T, COLINT).ToUpper
            If Signs IsNot Nothing Then SignStr = ArV(Columns, K, Nothing, "=").ToString Else SignStr = "="
            SignX(K) = SignStr
            If FindOnly_One = False Then Str = ArV(FindStr, K).ToString Else Str = ArV(FindStr, 0).ToString
            If SoftIn.Get_DataType_Str(T, Col) = True Then
                SF(K) = Col
                ST(K) = Str
            ElseIf WGeT.ToUpper = "DATETIME" Then
                Try
                    Dq1 = CDate(Str)
                    SF(K) = Col
                    ST(K) = Dq1
                    DTypex(K) = "D"
                Catch ex As Exception
                End Try
            ElseIf IsNumeric(Str) Then
                SF(K) = Col
                ST(K) = Str
                DTypex(K) = "n"
            End If
            If Func_Column IsNot Nothing And Func_int IsNot Nothing Then
                If ArF(Func_Column, COLINT) = True Then
                    Expre(K) = "f" & ArV(Func_int, ComRow)
                End If
            End If
        Next
        SJOIN = "OR"
        AukF.Db_LoadN(T, -1, "", ClrDb, Func, OrderBY, False, Start, Limit)
        If SUMMARY_NONEXE_CUR_TABLE(T, BSql) > 0 Then
            Return True
        Else
            Return False
        End If
        Dont_UseLike_Number_Date = False
        'MsgBox(Sql)
    End Function

    Public Function SUMMARY_NONEXE_CUR_TABLE(ByVal T As DataTable, Optional ByVal BSQLX As String = "", Optional ByVal SUMARY_T As String = "COUNT", Optional ByVal COLUMN_NUM As Object = 0) As Decimal
        If T Is Nothing Then MsgBox("Can't Compute in Table if Table is not a Object.", MsgBoxStyle.Critical) : Exit Function
        Try
            SUMMARY_NONEXE_CUR_TABLE = CDec(Val(T.Compute(SUMARY_T & "([" & SoftIn.GetTableColumn_NameString(T, COLUMN_NUM).ToString & "])", BSQLX).ToString))
        Catch ex As Exception
            'CSOFT.CopyClipBoard(Sql)
            Epx(BSQLX)
            'If T IsNot Nothing Then MsgBox("ERROR(AUK INTERNAL ERROR -61):" & vbCrLf & BSQLX & vbCrLf & "COLUMN:" & SoftIn.GetTableColumn_NameString(T, COLUMN_NUM).ToString, MsgBoxStyle.Critical)
            Return 0
        End Try
    End Function
    Public Function SummaryNonExeTable_New(ByVal T As DataTable, ByVal ColumnArray As String, ByVal FindArray As String, Optional ByVal SUMARY_T As String = "COUNT", Optional ByVal WhichColumn_SumExe As Object = 0) As Decimal
        Dim C, F As Array
        Dim QStr As String
        If T Is Nothing Then MsgBox("Can't Compute in Table if Table is not a Object.", MsgBoxStyle.Critical) : Exit Function

        If ColumnArray <> "" And AukF.FindTxt(ColumnArray, ",") = True Then
            C = Split(ColumnArray, ",")
            Fx = SoftIn.Replace_Database_FieldsNamesByNumber_FromArray(T, C, False)
            C = Split(Fx, ",")
            F = Split(FindArray, ",")
            Dim Q(C.GetUpperBound(0)) As String
            For K As Integer = 0 To C.GetUpperBound(0)
                Q(K) = SoftIn.GetFunction_QrText(T, ArV(C, K), ArV(F, K), 0, "=", True)
            Next
            QStr = ArrayToString(Q, " AND ")
        Else
            If ColumnArray <> "" Then QStr = SoftIn.GetFunction_QrText(T, ColumnArray, FindArray) Else QStr = ""
        End If
        Try
            Return CDec(Val(T.Compute(SUMARY_T & "([" & SoftIn.GetTableColumn_NameString(T, WhichColumn_SumExe).ToString & "])", QStr).ToString))
        Catch ex As Exception
            'If T IsNot Nothing Then MsgBox("ERROR(AUK INTERNAL ERROR -61):" & vbCrLf & BSQLX & vbCrLf & "COLUMN:" & SoftIn.GetTableColumn_NameString(T, COLUMN_NUM).ToString, MsgBoxStyle.Critical)
            Return 0
        End Try
    End Function


    Public Function FIND_FROM_DATATABLE(ByVal T As DataTable, ByVal ObJECTF As Object, Optional ByVal GET_COLUMNTXT As Integer = -1, Optional ByVal DEFAULTVAL As String = "") As DataRow
        If ObJECTF Is Nothing Then Return Nothing : WGeT = DEFAULTVAL : Exit Function
        If TypeOf (ObJECTF) Is String Then
            If ObJECTF = "" Then
                Return Nothing : WGeT = DEFAULTVAL : Exit Function
            End If
        End If
        FIND_FROM_DATATABLE = T.Rows.Find(ObJECTF)
        RowX = FIND_FROM_DATATABLE
        If FIND_FROM_DATATABLE IsNot Nothing Then
            If GET_COLUMNTXT > -1 Then WGeT = FIND_FROM_DATATABLE.Item(GET_COLUMNTXT).ToString Else WGeT = ""
            ComRow = T.Rows.IndexOf(RowX)
        Else
            ComRow = -1
            WGeT = DEFAULTVAL
        End If
    End Function
    Public Function FIND_FROM_DATATABLE_STR(ByVal T As DataTable, ByVal ObJECTF As Object, ByVal GET_COLUMNTXT As Integer, Optional ByVal DEFAULTVAL As String = "") As String
        On Error GoTo B
        If ObJECTF Is Nothing Then FIND_FROM_DATATABLE_STR = DEFAULTVAL : WGeT = DEFAULTVAL : Exit Function
        If TypeOf (ObJECTF) Is String Then
            If ObJECTF = "" Then
                FIND_FROM_DATATABLE_STR = DEFAULTVAL : WGeT = DEFAULTVAL : Exit Function
            End If
        End If
        RowX = T.Rows.Find(ObJECTF)
        If RowX IsNot Nothing Then
            If GET_COLUMNTXT > -1 Then WGeT = RowX.Item(GET_COLUMNTXT).ToString Else WGeT = ""
            Return WGeT
            ComRow = T.Rows.IndexOf(RowX)
        Else
            ComRow = -1
            WGeT = DEFAULTVAL
            Return WGeT
        End If
B:
        WGeT = ""
        ComRow = -1
        Return WGeT
    End Function
    Public Function ROWC_Get_In_InCommand_Grd(ByVal D As DataGridView, ByVal Col As Integer, ByVal FindCol As Integer, Optional ByVal Logic As Boolean = False, Optional ByVal LogicFindCol As Integer = -1, Optional ByVal WhatMatch As String = "") As String
        If D IsNot Nothing Then
            Dim Str As String = ""
            If SoftIn.Get_DataType_Str(D, FindCol) = True Then
                s1 = "'" : s2 = "'"
            ElseIf WGeT.ToUpper = "DATETIME" Then
                s1 = "#" : s2 = "#"
            Else
                s1 = "" : s2 = ""
            End If
            If LogicFindCol = -1 Then LogicFindCol = FindCol
            For K As Integer = 0 To D.SelectedRows.Count - 1
                Try
                    If D.SelectedRows.Item(K).Cells(Col).Value IsNot Nothing Then
                        If Logic = True Then
                            If WhatMatch = D.SelectedRows.Item(K).Cells(LogicFindCol).Value.ToString Then
                                nma = s1 & D.SelectedRows.Item(K).Cells(Col).Value.ToString & s2
                            End If
                        Else
                            nma = s1 & D.SelectedRows.Item(K).Cells(Col).Value.ToString & s2

                        End If
                    End If
                Catch ex As Exception
                    Epx() : Exit Function
                End Try
                If Str = "" AndAlso nma <> "" Then Str = nma : nma = "" Else Str &= "," & nma : nma = ""
            Next
            If Str <> "" Then Return "[" & D.Columns(FindCol).DataPropertyName.ToString & "] In (" & Str & ")" Else Return ""
        End If
    End Function
    Public Function ROWC_Get_In_InCommand(ByVal r() As DataRow, ByVal Col As Object, ByVal FindCol As Object) As String
        Dim T As DataTable
        Dim Str As String = ""
        If r IsNot Nothing Then
            T = r.GetValue(0).table
            If Col = FindCol Then
                Col = SoftIn.GetTableColumn_NameString(T, Col)
                fCol = Col
            Else
                Col = SoftIn.GetTableColumn_NameString(T, Col)
                fCol = SoftIn.GetTableColumn_NameString(T, FindCol)
            End If
            If SoftIn.Get_DataType_Str(T, fcol) = True Then
                s1 = "'" : s2 = "'"
            ElseIf WGeT.ToUpper = "DATETIME" Then
                s1 = "#" : s2 = "#"
            Else
                s1 = "" : s2 = ""
            End If
            For K As Integer = 0 To r.GetUpperBound(0)
                Try
                    nma = s1 & r.GetValue(K).item(Col.ToString).ToString & s2
                Catch ex As Exception
                    Epx() : Exit Function
                End Try
                If Str = "" Then Str = nma Else Str &= "," & nma
            Next
            If Str <> "" Then Return "[" & SoftIn.GetTableColumn_NameString(T, FindCol) & "] In (" & Str & ")" Else Return ""
        End If
    End Function
    Public Function ROWC_Get_In_InCommand(ByVal rC As DataRowCollection, ByVal Col As Object, ByVal FindCol As Object) As String
        Dim T As DataTable
        Dim Str As String = ""
        If r IsNot Nothing Then
            T = r.GetValue(0).table
            If Col = FindCol Then
                Col = SoftIn.GetTableColumn_NameString(T, Col)
                fCol = Col
            Else
                Col = SoftIn.GetTableColumn_NameString(T, Col)
                fCol = SoftIn.GetTableColumn_NameString(T, FindCol)
            End If
            If SoftIn.Get_DataType_Str(T, fcol) = True Then
                s1 = "'" : s2 = "'"
            ElseIf WGeT.ToUpper = "DATETIME" Then
                s1 = "#" : s2 = "#"
            Else
                s1 = "" : s2 = ""
            End If
            For K As Integer = 0 To rC.Count - 1
                Try
                    nma = s1 & rC.Item(K).Item(Col.ToString).ToString & s2
                Catch ex As Exception
                    Epx() : Exit Function
                End Try
                If Str = "" Then Str = nma Else Str &= "," & nma
            Next
            If Str <> "" Then Return "[" & SoftIn.GetTableColumn_NameString(T, FindCol) & "] In (" & Str & ")" Else Return ""
        End If
    End Function
    Public Function LOAD_AND_FIND(ByVal DB As Object, ByVal TITLE As String, ByVal FINDTEXT As String, Optional ByVal COLUMN As Integer = -1, Optional ByVal CLRdb As Boolean = True, Optional ByVal START As Integer = 0, Optional ByVal LIMIT As Integer = 100) As DataRow
        Dim T As DataTable = AukF.Get_DataSystemObj(DB)
        Dim R(0) As DataRow
        SFC(TITLE)
        STC(FINDTEXT)
        If SoftIn.Get_DataType_Str(T, TITLE) = False Then DTC("N")
        AukF.Db_LoadN(T, -1, "", CLRdb, 0, "", False, START, LIMIT)
        If T.Rows.Count > 0 Then
            R = SoftIn.Rows_Select(T, TITLE, FINDTEXT)
            If R IsNot Nothing Then
                RowX = R(0)
            End If
            R = Nothing
            If COLUMN > -1 Then
                WGeT = T.Rows(0).Item(COLUMN).ToString
            Else
                WGeT = ""
            End If
        Else
            RowX = Nothing
            WGeT = ""
        End If
        Return RowX
    End Function
    Public Function FIND_FROM_DATATABLE_INDEX(ByVal T As DataTable, ByVal ObJECTF As Object, Optional ByVal COLUMN As Integer = -1) As Boolean
        On Error GoTo B
        If ObJECTF Is Nothing Then Return False : WGeT = DEFAULTVAL : Exit Function
        If TypeOf (ObJECTF) Is String Then
            If ObJECTF = "" Then
                Return False : WGeT = DEFAULTVAL : Exit Function
            End If
        End If
        RowX = T.Rows.Find(ObJECTF)
        If RowX IsNot Nothing Then
            If COLUMN > -1 Then WGeT = RowX.Item(COLUMN).ToString Else WGeT = ""
            ComRow = T.Rows.IndexOf(RowX)
            Return True
        Else
            WGeT = ""
            ComRow = -1
            Return False
        End If
        Exit Function
B:
        WGeT = ""
        ComRow = -1
        Return False
    End Function
    Public Function FIND_FROM_DATATABLE_ARRAY(ByVal T As DataTable, ByVal ObJECTF As Object, Optional ByVal GET_COLUMNTXT As Integer = -1, Optional ByVal DEFAULTVAL As String = "") As Array
        If ObJECTF Is Nothing Then Return Nothing : WGeT = DEFAULTVAL : Exit Function
        If TypeOf (ObJECTF) Is String Then
            If ObJECTF = "" Then
                Return Nothing : WGeT = DEFAULTVAL : Exit Function
            End If
        End If
        RowX = T.Rows.Find(ObJECTF)
        If RowX IsNot Nothing Then
            If GET_COLUMNTXT > -1 Then WGeT = RowX.Item(GET_COLUMNTXT).ToString Else WGeT = ""
            ComRow = T.Rows.IndexOf(RowX)

            Return RowX.ItemArray
        Else
            ComRow = -1
            WGeT = DEFAULTVAL
            Return Nothing
        End If
    End Function
    Public Function TWICE_BINDFIND(ByVal BP As BindingSource, ByVal TITLE1 As String, ByVal TITLE2 As String, ByVal F1 As String, Optional ByVal TITLE3 As String = "", Optional ByVal DataGrd As Object = Nothing) As Boolean
        If AukF.BindFind(BP, TITLE1, F1, True, DataGrd) = False Then
            If AukF.BindFind(BP, TITLE2, F1, True, DataGrd) = False Then
                If TITLE3 <> "" Then
                    AukF.BindFind(BP, TITLE3, F1, True, DataGrd)
                End If
            End If
        End If
        'MsgBox(ComRow)
        If ComRow = -1 Then Return False Else Return True
    End Function

    Public Function TWICE_EXE(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs, ByVal Bp As BindingSource, Optional ByVal Titles1 As Object = Nothing, Optional ByVal Titles2 As Object = Nothing, Optional ByVal GotoPos As Boolean = True, Optional ByVal ClrDb As Boolean = False, Optional ByVal F1Func As Integer = 0, Optional ByVal F2Func As Integer = 1, Optional ByVal MaxLoad As Integer = 20, Optional ByVal Start As Integer = 0) As String
        If e.KeyCode = Keys.Enter Then
            Return ADSRC.Twice_Q(Bp, Titles1, Titles2, sender.TEXT, GotoPos, ClrDb, F1Func, F2Func, MaxLoad, Start)
        End If
    End Function

    Public Sub Load_Only_LastRecord(ByVal T As DataTable, Optional ByVal Title As String = "*", Optional ByVal ClrDb As Boolean = True)
        Dim CintX As Integer = COUNT_CN(T.TableName)
        If CintX = 1 Then
            AukF.Db_LoadQ(T, BSql, Title, ClrDb, "", False, 0, 1)
        ElseIf CintX > 0 Then
            AukF.Db_LoadQ(T, BSql, Title, ClrDb, "", False, CintX - 1, 1)
        End If
    End Sub
    Public Sub Load_Only_LastRecords(ByVal T As DataTable, Optional ByVal Num As Integer = 500, Optional ByVal Title As String = "*", Optional ByVal ClrDb As Boolean = True)
        Dim CintX As Integer = COUNT_CN(T.TableName)
        If Num >= 1 Then
            If CintX > 0 And Num >= CintX Then
                AukF.Db_LoadQ(T, BSql, Title, ClrDb, "", False, (CintX - Num), Num)
            ElseIf CintX > 0 And Num < CintX Then
                AukF.Db_LoadQ(T, BSql, Title, ClrDb, "", False, CintX, Num)
            End If
        End If
    End Sub
    Public Function Load_Only_LastRecord_GET_DATAROW(ByVal T As DataTable, Optional ByVal COLUMN As Integer = -1, Optional ByVal Title As String = "*", Optional ByVal ClrDb As Boolean = True) As DataRow
        Dim CintX As Integer = COUNT_CN(T.TableName)
        'MsgBox(BSql, , CintX)
        If CintX > 0 Then
            'AukF.Db_LoadF(T, Title, T.TableName, ClrDb, 0, "", False, CintX - 1, 1)
            AukF.Db_LoadQ(T, BSql, Title, ClrDb, "", False, CintX - 1, 1)
            If T.Rows.Count > 0 Then
                Load_Only_LastRecord_GET_DATAROW = T.Rows(0)
                If COLUMN > -1 Then
                    WGeT = T.Rows(0).Item(COLUMN).ToString
                Else
                    WGeT = ""
                End If
            Else
                WGeT = ""
                Return Nothing
            End If
        End If
    End Function
    Public Function Load_Only_LastRecord_Str(ByVal T As DataTable, ByVal COLUMN As Integer, Optional ByVal Title As String = "*", Optional ByVal ClrDb As Boolean = True) As String
        'T.TableName=
        Dim CintX As Integer = COUNT_CN(T.TableName)
        'MsgBox(BSql, , CintX)
        If CintX > 0 Then
            'AukF.Db_LoadF(T, Title, T.TableName, ClrDb, 0, "", False, CintX - 1, 1)
            AukF.Db_LoadQ(T, BSql, "*", ClrDb, "", False, CintX - 1, 1)
            If T.Rows.Count > 0 Then
                RowX = T.Rows(0)
                If COLUMN > -1 Then
                    WGeT = T.Rows(0).Item(COLUMN).ToString
                Else
                    WGeT = ""
                End If
            Else
                WGeT = ""
                RowX = Nothing
            End If
        End If
        Return WGeT
    End Function
    Public Sub Load_Null(ByVal T As DataTable, Optional ByVal Null As Boolean = True)
        SFC(T.Columns(0).ColumnName.ToString)
        If Null = False Then SnX("<>")
        ExpreC("null")
        AukF.Db_LoadN(T, "*", T.TableName, True)
        'MsgBox(Sql)
    End Sub
    Public Function GRID_HEADERS(ByVal COM As Object, ByVal D As DataGridView, Optional ByVal SEP As String = "", Optional ByVal kEYS As String = ",", Optional ByVal ADD_HEADER As Boolean = True)
        Dim UA As Array = Nothing
        Dim DSTR As String
        If SEP.Trim <> "" Then
            UA = SEP.Split(CChar(kEYS))
        End If
        For K As Integer = 0 To D.ColumnCount - 1
            If ADD_HEADER = True Then DSTR = D.Columns(K).HeaderText.ToString Else DSTR = D.Columns(K).DataPropertyName.ToString()
            If ADD_HEADER = True And UA IsNot Nothing Then
                DSTR &= "," & K
                If ArF(UA, K) = False Then
                    COM.Items.Add(UCase(DSTR))
                End If
            Else
                COM.Items.Add(UCase(DSTR))
            End If
        Next
        AukF.ComSelIndex(COM)
    End Function
    Public Function Twice_Q(ByVal Bp As BindingSource, Optional ByVal Titles1 As Object = Nothing, Optional ByVal Titles2 As Object = Nothing, Optional ByVal F1 As String = "", Optional ByVal GotoPos As Boolean = True, Optional ByVal ClrDb As Boolean = False, Optional ByVal F1Func As Integer = 0, Optional ByVal F2Func As Integer = 1, Optional ByVal MaxLoad As Integer = 20, Optional ByVal Start As Integer = 0) As String
        Dim M1, M2 As String
        'Dim McOUNT As Integer
        Dim T As DataTable = AukF.Get_DataSystemObj(Bp)
        If Titles1 IsNot Nothing Then M1 = SoftIn.GetFunction_QrText(T, Titles1, F1, F1Func) Else M1 = ""
        If Titles2 IsNot Nothing Then M2 = SoftIn.GetFunction_QrText(T, Titles2, F1, F2Func) Else M2 = ""
        If M1 <> "" And M2 <> "" Then
            Twice_Q = "( " & M1 & " ) OR ( " & M2 & " )"
        ElseIf M1 <> "" And M2 = "" Then
            Twice_Q = "( " & M1 & " )"
        Else
            MsgBox("Not Supported", MsgBoxStyle.Critical)
        End If
        If Start = -1 Then
            Try
                Start = T.Compute("COUNT([" & T.Columns(0).ColumnName.ToString & "])", Twice_Q)
            Catch ex As Exception
                MsgBox("Err")
                Start = 0
            End Try
        End If
        SoftIn.Sql_Convert_For_Adp(T, Twice_Q, "*")
        AukF.OleDb_SqlGen(Sql, T, T.TableName, ClrDb, MaxLoad, Start)
        Twice_Q = Sql
        If GotoPos = True Then
            If Titles1 IsNot Nothing Then
                If AukF.BindFind(Bp, SoftIn.GetTableColumn_NameString(T, Titles1), F1, True) = False Then
                    If Titles2 IsNot Nothing Then AukF.BindFind(Bp, SoftIn.GetTableColumn_NameString(T, Titles2), F1, True)
                End If
            End If
        End If
    End Function
    Public Function MAXIMUM_VALUE(ByVal TableName As String, ByVal TAB As Object) As Object
        NT = New DataTable
        Dim SummaryStr As String
        SummaryStr = "MAX"
        If SummaryStr.ToLower = "maximam found" Then
        Else
            AukF.Db_LoadN(NT, "" & SummaryStr & " (VAL([" & TAB & "])) AS [AUK QUERY VIEW]", TableName, True)
            If NT.Rows.Count = 0 Then
                Return 0
            Else
                Return Val(NT.Rows(0).Item(0).ToString)
            End If
            'MsgBox(Sql)
        End If
    End Function
    'Public Function MAXIMUM_Str_value(ByVal TableName As String, ByVal ColumnName As Object) As Decimal
    '    NT = New DataTable
    '    Dim SummaryStr As String
    '    SummaryStr = "MAX"
    '    Try
    '        AukF.Db_LoadN(NT, "" & SummaryStr & " (([" & ColumnName & "])) AS [AUK QUERY VIEW]", TableName, True)
    '        Return NT.Rows(0).Item(0)
    '    Catch ex As Exception
    '        Return 0
    '    End Try
    '    'MsgBox(Sql)
    'End Function
    Public Function Summary_Totals(ByVal TableName As Object, ByVal ColumnName As Object, Optional ByVal SummaryStr As String = "Count", Optional ByVal OrderBy As String = "", Optional ByVal GroupBy As Boolean = False) As Decimal
        NT = New DataTable
        If TypeOf (TableName) Is DataTable Then TableName = TableName.tablename.ToString
        Try
            AukF.Db_LoadN(NT, "(" & SummaryStr & " ([" & ColumnName & "])) AS [AUK QUERY VIEW]", TableName, True, 0, OrderBy, GroupBy)
            Return Val(NT.Rows(0).Item(0))
        Catch ex As Exception
            Return 0
            Epx(Sql)
        End Try
        'MsgBox(Sql)
    End Function
    Public Function Summary_Totals_ReturnTable(ByVal TableName As String, ByVal ColumnName As Object, Optional ByVal SummaryStr As String = "Count", Optional ByVal OrderBy As String = "", Optional ByVal Open_Fileds As String = "", Optional ByVal GroupBy As Boolean = False) As DataTable
        NT = New DataTable

        Try
            AukF.Db_LoadN(NT, Open_Fileds & "," & SummaryStr & " ([" & ColumnName & "]) as [AukQuery Value]", TableName, True, 0, OrderBy, GroupBy)
            Return NT
        Catch ex As Exception
            'Clipboard.Clear()
            'Clipboard.SetText(Sql)
            Return Nothing
            Epx(Sql)
        End Try
        'MsgBox(Sql)
    End Function
    'Public Function AdvSumSys_ReturnTb_New(ByVal Tablex As DataTable, Optional ByVal Open_FiledsArray As String = "*", Optional ByVal SummaryArrayStr As String = "", Optional ByVal OrderBy As String = "", Optional ByVal GroupBy As Boolean = False) As DataTable

    'End Function

    Public Function AdvSummSys_RTable(ByVal Tablex As DataTable, Optional ByVal Open_FiledsArray As String = "*", Optional ByVal SummaryArrayStr As String = "", Optional ByVal OrderBy As String = "", Optional ByVal GroupBy As Boolean = False, Optional ByVal OrgName As Boolean = False) As DataTable

        NT = New DataTable
        Dim ColumnAr, OrdAr As String
        Dim UaX As Array
        'SummaryArrayStr="Count,,Sum"
        'If ColumnNameArray = "" Then MsgBox("Without Columns Can't Execute Query.", MsgBoxStyle.Critical) : Return Nothing
        If Open_FiledsArray <> "*" Or Val(Open_FiledsArray) <> -1 Then
            UaX = AukSql.GettingTitleByNumberValue(Tablex, Open_FiledsArray)
            ColumnAr = SoftIn.Replace_Database_FieldsNamesByNumber_FromArray(Tablex, UaX, True) 'geting opening fields
            ColumnAr = Getting_SummaryFields(ColumnAr, SummaryArrayStr, OrgName) 'geting summary str as Sum([Field])

        Else
            ColumnAr = "*"
        End If
        If OrderBy <> "" Then
            UaX = AukSql.GettingTitleByNumberValue(Tablex, OrderBy) 'first geting number from fields name in a array then put it on next sec of brackets
            OrdAr = SoftIn.Replace_Database_FieldsNamesByNumber_FromArray(Tablex, UaX, True) 'geting order fields
        End If

        Try
            AukF.Db_LoadN(NT, ColumnAr, Tablex.TableName.ToString, True, 0, OrdAr, GroupBy)
            'MsgBox(Sql)
            Return NT
        Catch ex As Exception
            'Clipboard.Clear()
            'Clipboard.SetText(Sql)
            Return Nothing
            Epx(Sql)
        End Try
        'MsgBox(Sql)
    End Function

    Private Function Getting_SummaryFields(ByVal OpenFArray As String, Optional ByVal SumFieldArr As String = "", Optional ByVal OrgName As Boolean = False) As String
        Dim A, B As Array

        'Dim intX As Integer = 0
        If SumFieldArr = "" Then Return OpenFArray
        A = Split(OpenFArray, ",")
        B = Split(SumFieldArr, ",")
        Dim NamesOrg(A.GetUpperBound(0)) As String
        For K As Integer = 0 To A.GetUpperBound(0)
            If ArV2(B, K).ToString <> "" Then
                'summanr name ArV2(B, K).ToString
                If InStr(ArV2(B, K).ToString, "[self]", CompareMethod.Text) > 0 Then
                    m = Split(ArV2(B, K).ToString, "=") 'geting in array by '='
                    'such as [self]=total count = count
                    'ArV2(m, 0)=[self]
                    'ArV2(m, 1)=total count
                    'ArV2(m, 2)=count=summary function
                    'A.GetValue(K)=field =[due]; with []

                    A.SetValue(ArV2(m, 2) & "(" & A.GetValue(K) & ")" & " AS [" & ArV2(m, 1) & "]", K)

                Else 'weh n self nots true
                    If OrgName = True Then
                        If ArF(NamesOrg, A.GetValue(K)) = False Then
                            NamesOrg.SetValue(A.GetValue(K), K)
                            A.SetValue(ArV2(B, K).ToString & "( " & A.GetValue(K) & ") AS " & A.GetValue(K), K)
                        Else
                            NamesOrg.SetValue("[" & ArV2(B, K).ToString & " " & A.GetValue(K) & "]", K)
                            A.SetValue(ArV2(B, K).ToString & "( " & A.GetValue(K) & ") AS [" & ArV2(B, K).ToString & " " & A.GetValue(K) & "]", K)
                        End If
                    Else
                        A.SetValue(ArV2(B, K).ToString & "( " & A.GetValue(K) & ") AS [Auk" & K & "]", K)
                    End If
                End If
             
            End If
        Next
        Return ArrayToString(A) 'geting arrya to string
    End Function
    Public Function Summary_Totals_Sql(ByVal BSQLX As String, ByVal TableName As String, ByVal ColumnName As Object, ByVal SummaryStr As String) As Object
        NT = New DataTable
        NT.TableName = TableName
        If SummaryStr.ToLower = "maximam found" Then
        Else
            Try
                AukF.Db_LoadQ(NT, BSQLX, "CSTR(" & SummaryStr & "([" & ColumnName & "])) AS [AUK QUERY VIEW]", True)
                WGeT = Sql
                Return NT.Rows(0).Item(0)
            Catch ex As Exception
                Return 0
            End Try

            'MsgBox(Sql)
        End If
    End Function
    Public Function COUNT_CN(ByVal TableName As String) As Integer
        Try
            NT = New DataTable
            AukF.Db_LoadN(NT, "COUNT(0)", TableName, True)
            COUNT_CN = CInt(NT.Rows(0).Item(0).ToString)
        Catch ex As Exception
            If AukSql.Q_ERRORMSG = True Then Epx()
            COUNT_CN = 0
        End Try

    End Function
    Public Function COUNT_T(ByVal TableName As String, ByVal T As DataTable) As Integer
        AukF.Db_LoadN(T, "COUNT(0)", TableName, True)
        If T.Rows.Count = 1 Then
            COUNT_T = CInt(T.Rows(0).Item(0).ToString)
        Else
            MsgBox("Auk Count Command is can't Executeable." & vbCrLf & "Sql:" & Sql, MsgBoxStyle.Critical)
        End If
    End Function

    Public Function DTXT(ByVal D As Object) As String
        'Dim C, R As Integer
        On Error GoTo b
        Dim STR As String
        'Dim d1 As DataGrid
        If TypeOf (D) Is DataGrid Then
            If D.VisibleRowCount > 0 Then
                DColumn = D.CurrentCell.ColumnNumber : DRow = D.CurrentCell.RowNumber
                STR = D(DRow, DColumn).ToString
            End If
        ElseIf TypeOf (D) Is DataGridView Then
            If D.rows.count > 0 Then
                DColumn = D.CurrentCell.ColumnIndex : DRow = D.CurrentCell.RowIndex
                STR = D(DColumn, DRow).Value.ToString
            End If

        End If
        'MsgBox(DRow & vbCrLf & DColumn & vbCrLf & STR)
        If DRow > -1 And DColumn > -1 Then DTXT = STR Else DTXT = ""
        Exit Function
b:      DRow = -1 : DColumn = -1 : DTXT = ""
    End Function
    Public Function DATAGRID_ADVANCE_SELECTED_FILTER(ByVal D As DataGridView, ByVal BP As BindingSource, Optional ByVal SIGN As String = "=", Optional ByVal FUNC As Integer = 0, Optional ByVal WITHFILTER As Boolean = False) As String
        Dim Str(D.SelectedCells.Count), Str2 As String
        Dim COL As String
        Dim T As DataTable = AukF.Get_DataSystemObj(D)
        For k As Integer = 0 To D.SelectedCells.Count - 1
            If TypeOf (D.SelectedCells(k).Value) Is DBNull Then Str2 = "" Else Str2 = CStr(D.SelectedCells(k).Value)
            COL = D.Columns(D.SelectedCells(k).ColumnIndex).DataPropertyName.ToString
            Str(k) = SoftIn.GetFunction_QrText(T, COL, Str2, FUNC, SIGN)
        Next
        DATAGRID_ADVANCE_SELECTED_FILTER = AukF.BindFilter(BP, Str, WITHFILTER, SIGN, True, )
    End Function
    Public Function DATAGRID_ADVANCE_SELECTED_FILTER(ByVal D As DataGrid, ByVal BP As BindingSource, Optional ByVal SIGN As String = "=", Optional ByVal FUNC As Integer = 0, Optional ByVal WITHFILTER As Boolean = False) As String
        Dim Str As String = DTXT(D)
        Dim T As DataTable = AukF.Get_DataSystemObj(BP)
        DATAGRID_ADVANCE_SELECTED_FILTER = AukF.BindFilter(BP, DColumn, Str, FUNC, WITHFILTER, SIGN, "AND", True)
    End Function
    Public Function INPUTBOX_FILTER(ByVal BP As BindingSource, ByVal COLUMN As Object, Optional ByVal TITLE As String = "", Optional ByVal PROMT As String = "", Optional ByVal dEFAULTs As String = "", Optional ByVal WITHf As Boolean = False) As String
        Dim T As DataTable = AukF.Get_DataSystemObj(BP)
        If TITLE = "" Then
            TITLE = "PLEASE TYPE YOUR QUERY/FILTER TEXT TO FILTER"
        End If
        If PROMT = "" Then
            PROMT = "TYPE QUERY SUCH AS [COLUMN NAME,COLUMN NAME2=QUERY1,QUERY2=FUNC,FUNC2=SIGN,SIGN2]" & vbCrLf & ",PLEASE SEE THE FUNCTIONS FROM FUNCTIONS PDF."
        End If
        If dEFAULTs = "" Then
            dEFAULTs = SoftIn.GetTableColumn_NameString(T, COLUMN) & "="
        End If
        dEFAULTs = InputBox(PROMT, TITLE, dEFAULTs)
        If dEFAULTs.Trim <> "" Then
            INPUTBOX_FILTER = ADSRC.Format_For_Complex(T, dEFAULTs, T, False, BP, True, WITHf)
        End If
    End Function
    Public Function SignsOpt(ByVal Str As Object) As Object
        'Dim K As String
        Dim Ua As Array
        If Str Is Nothing Then Exit Function

        If TypeOf (Str) Is Array Then
            Ua = Str
            For k As Integer = 0 To Ua.GetUpperBound(0)
                Str = Ua.GetValue(k)
                If Str = "0" Or Str.ToString.ToLower = "eg" Or Str.ToString.Trim = "" Then
                    Ua.SetValue("=", k)
                ElseIf Str = "1" Or Str.ToString.ToLower = "l" Then
                    Ua.SetValue("<", k)
                ElseIf Str = "2" Or Str.ToString.ToLower = "le" Then
                    Ua.SetValue("<=", k)
                ElseIf Str = "3" Or Str.ToString.ToLower = "g" Then
                    Ua.SetValue(">", k)
                ElseIf Str = "4" Or Str.ToString.ToLower = "ge" Then
                    Ua.SetValue(">=", k)
                ElseIf Str = "5" Or Str.ToString.ToLower = "n" Or Str.ToString.ToLower = "not" Then
                    Ua.SetValue("<>", k)
                End If
            Next
        Else
            If Str = "0" Or Str.ToString.ToLower = "eg" Or Str.ToString.Trim = "" Then
                SignsOpt = "="
            ElseIf Str = "1" Or Str.ToString.ToLower = "l" Then
                SignsOpt = "<"
            ElseIf Str = "2" Or Str.ToString.ToLower = "le" Then
                SignsOpt = "<="
            ElseIf Str = "3" Or Str.ToString.ToLower = "g" Then
                SignsOpt = ">"
            ElseIf Str = "4" Or Str.ToString.ToLower = "ge" Then
                SignsOpt = ">="
            ElseIf Str = "5" Or Str.ToString.ToLower = "n" Or Str.ToString.ToLower = "not" Then
                SignsOpt = "<>"
            End If
        End If
    End Function
    Public Function Get_TitleNames(ByVal Db_Or_Combo As Object, ByVal Str As Object, Optional ByVal Key As String = ",") As Array
        Dim T As DataTable = Nothing
        Dim CbC As Object = Nothing
        Dim Int As Integer
        Dim Ua As Array
        If TypeOf (Str) Is String Then
            Ua = Split(CStr(Str), Key)
        ElseIf TypeOf (Str) Is Array Then
            Ua = CType(Str, Array)
        End If
        If ArC(Ua) = 0 Then Get_TitleNames = Nothing : Exit Function
        If TypeOf (Db_Or_Combo) Is ComboBox Or TypeOf (Db_Or_Combo) Is ListBox Or TypeOf (Db_Or_Combo) Is ToolStripComboBox Then
            CbC = Db_Or_Combo
        Else
            T = AukF.Get_DataSystemObj(Db_Or_Combo)
        End If
        If CbC IsNot Nothing Then
            For k As Integer = 0 To Ua.GetUpperBound(0)
                If IsNumeric(Ua.GetValue(k)) Then
                    a = CbC.Items.Item(k).ToString
                Else
                    a = AukF.FindInObjectAndSelect(CbC, Ua.GetValue(k), True)
                    If Val(a) > -1 Then a = Ua.GetValue(k)
                End If
                Ua.SetValue(a, k)
            Next
        ElseIf T IsNot Nothing Then
            For k As Integer = 0 To Ua.GetUpperBound(0)
                b = Ua.GetValue(k).ToString
                If IsNumeric(b) Then Int = b : a = T.Columns(Int).ColumnName.ToString Else a = Ua.GetValue(k)
                Ua.SetValue(a, k)
            Next
        Else
            Get_TitleNames = Nothing
        End If
    End Function
    Public Function Table_Execute(ByVal T As DataTable, ByVal StrFil As String, Optional ByVal Execute As Boolean = True, Optional ByVal LoadWith As Boolean = True)
        If T Is Nothing Then Exit Function
        If StrFil.Trim <> "" Then
            AukF.Sql_Expression(SoftIn.Sql_Convert_For_Adp(T, StrFil), T, T.TableName, Not LoadWith)
            'msgbox "Please type a Filter text to Query
        End If
    End Function
    Public Function LOAD_WHOLE_DATABASE(ByVal T As DataTable, Optional ByVal CLRDB As Boolean = True, Optional ByVal TITLES As String = "*", Optional ByVal ORDERBY As String = "", Optional ByVal GROUPBY As Boolean = False, Optional ByVal MAXIMUMDAN As Integer = 1500)
        Dim INT As Integer
        Dim COM As String = ""
        Dim STR2 As String = ""
        Dim MS As MsgBoxStyle = MsgBoxStyle.Information
        Dim MSR As MsgBoxResult
        YFR = CInt(Val(My.Computer.Info.TotalPhysicalMemory.ToString) / 1024 / 1024)
        FR = CInt(Val(My.Computer.Info.AvailablePhysicalMemory.ToString) / 1024 / 1024)
        INT = ADSRC.COUNT_CN(T.TableName.ToString)
        STR2 = "YOUR TOTAL RAM: " & YFR & " MB, AVAIlABLE RAM:" & FR & " MB." & vbCrLf
        CELL = T.Columns.Count * INT
        A = 80 / MAXIMUMDAN
        B = A * INT
        C = CInt(FR / A)
        If Val(FR) < Val(B) Then
            COM = vbCrLf & "YOUR PHYSICAL MEMORY IS TO LOW WHICH NOW FREE " & FR & " MB.IN THIS POSITION ITS DANGEROUS TO LOAD " & INT & " DATA FROM DATABASE." & vbCrLf & STR2 & vbCrLf & "AUK SUGGEST ONLY " & C & " RECORD(S) STARTING FROM RECORD " & T.Rows.Count & "." & vbCrLf & "[YES=WHOLE,NO=AUK SUGGEST,CANCEL=NO EFFECT.]"
            MS = MsgBoxStyle.Information
        End If
        Sql = SoftIn.Sql_Convert_For_Adp(T, "", TITLES, False, ORDERBY, GROUPBY)
        If COM = "" Then
            If AukF.MsgTr("DO YOU WANT LOAD WHOLE DATABASE,WHICH IS CONTAINS " & INT & " DATAROW(S) & " & T.Columns.Count & " DATACOLUMN(S)?", False, MS) Then
                MSZ = Now
                AukF.Sql_Expression(Sql, T, T.TableName, CLRDB, -1, -1)
            End If
            If MSZ = Nothing Then MSZ = Now
            MRZ = DateDiff(DateInterval.Second, MSZ, Now)
            Return "DATABASE LOAD DURATION(SEC) : " & MRZ
        Else
            MSR = MsgBox("DO YOU WANT LOAD WHOLE DATABASE,WHICH IS CONTAINS " & INT & " DATAROW(S) & " & T.Columns.Count & " DATACOLUMN(S)" & " WHICH MEANS THERE ARE " & T.Columns.Count * INT & " DATACELL(S) ?" & COM, MS + MsgBoxStyle.YesNoCancel)
            MSZ = Now
            If MSR = MsgBoxResult.Yes Then
                AukF.Sql_Expression(Sql, T, T.TableName, CLRDB)
            ElseIf MSR = MsgBoxResult.No Then
                AukF.Sql_Expression(Sql, T, T.TableName, False, CInt(C), T.Rows.Count)
            End If
            MRZ = DateDiff(DateInterval.Second, MSZ, Now)
            Return "DATABASE LOAD DURATION(SEC) : " & MRZ
        End If

    End Function
    Public Function ADD_DEFAULTVLUES_iN_ARRAY(ByVal A As Array, Optional ByVal DEFAULTV As String = "", Optional ByVal STARTF As Integer = 0, Optional ByVal LIMIT As Integer = -1)
        If LIMIT = -1 Then LIMIT = A.GetUpperBound(0)
        For K As Integer = STARTF To LIMIT
            A.SetValue(DEFAULTV, K)
        Next
    End Function
    Public Function Query_Arrays_Add(ByVal QStr As Array, Optional ByVal Brackets As Boolean = True, Optional ByVal T As DataTable = Nothing, Optional ByVal Bp As BindingSource = Nothing, Optional ByVal WithFilter As Boolean = False, Optional ByVal LoadWith As Boolean = True, Optional ByVal JOIN As String = "AND") As String
        Dim Execute As Boolean
        If Bp Is Nothing Then Execute = False Else Execute = True
        If QStr Is Nothing Then Query_Arrays_Add = "" : Exit Function
        Dim Str As String = ""
        If Brackets = True Then f1 = "(" : f2 = ")" Else f1 = "" : f1 = f2
        For k As Integer = 0 To QStr.GetUpperBound(0)
            g = QStr.GetValue(k)
            If CStr(g) <> "" Then
                If Str = "" Then Str = Trim(f1 & g & f2) Else Str &= " " & JOIN & " " & f1 & g & f2
            End If
        Next
        Query_Arrays_Add = UCase(Str)
        AukF.Bind_WithFilter_AddWith(Bp, Query_Arrays_Add, WithFilter, Execute)
        Table_Execute(T, Query_Arrays_Add, Execute, LoadWith)
    End Function
    Public Function Advance_Query_ByArray(ByVal Db As Object, ByVal Title As Array, ByVal Qr As Array, Optional ByVal Func As Array = Nothing, Optional ByVal Signx As Array = Nothing, Optional ByVal CheckV As Array = Nothing, Optional ByVal Query_Excute As Boolean = True, Optional ByVal Bp As BindingSource = Nothing, Optional ByVal WithFilter As Boolean = False, Optional ByVal LoadWith As Boolean = True) As String
        Dim QStr(), Tr, Qr1, Sign As String
        Dim T As DataTable = AukF.Get_DataSystemObj(Db)
        Dim Func1 As Integer = 0
        QStr.Resize(QStr, ArC(Title))
        For k As Integer = 0 To QStr.GetUpperBound(0)
            If ArV(CheckV, k).ToString.ToLower = "unchecked" Or ArV(CheckV, k).ToString.ToLower = "false" Or ArV(CheckV, k).ToString.ToLower = "uncheck" Or ArV(CheckV, k).ToString.ToLower = "0" Or ArV(CheckV, k).ToString.ToLower = "no" Or ArV(CheckV, k).ToString.ToLower = "n" Then
            Else
                Tr = CStr(ArV(Title, k))
                Qr1 = CStr(ArV(Qr, k))
                Sign = CStr(ArV(Signx, k))
                Func1 = ArV(Func, k, Nothing, 0)
                QStr(k) = CStr(SoftIn.GetFunction_QrText(T, Tr, Qr1, Func1, Sign, True))
            End If
        Next
        If (Query_Excute = True) Or (Bp IsNot Nothing) Then
            Advance_Query_ByArray = ADSRC.Query_Arrays_Add(QStr, True, T, Bp, WithFilter, LoadWith)
        Else
            Advance_Query_ByArray = ADSRC.Query_Arrays_Add(QStr, True, Nothing, Nothing, WithFilter, False)
        End If
    End Function
    Public Function Format_For_Complex(ByVal Db_Or_Combo As Object, ByVal Str As String, ByVal DB As Object, Optional ByVal Query_Execute As Boolean = True, Optional ByVal Bp As BindingSource = Nothing, Optional ByVal Bp_Filter As Boolean = True, Optional ByVal Bp_WithFilter As Boolean = False, Optional ByVal LoadWith As Boolean = True, Optional ByVal Titles As Object = Nothing, Optional ByVal Start As Integer = 0, Optional ByVal Max As Integer = -1, Optional ByVal WITH_ADD_EX_QUERY As String = "", Optional ByVal OpenTitle As String = "*", Optional ByVal OrderBy As String = "", Optional ByVal GroupBy As Boolean = False) As String
        Dim QStr(), Tr, Qr1, Signx As String
        Dim Fr1 As Integer = 0
        Dim Ua, TT, Qr, Fc, SnA As Array
        Dim T As DataTable = AukF.Get_DataSystemObj(DB)
        Ua = Str.Split(CChar("="))
        If ArC(Ua) >= 1 Then
            If Titles IsNot Nothing Then
                If TypeOf (Titles) Is Array Then TT = CType(Titles, Array) Else TT = Titles.ToString.Split(CChar(","))
            Else
                TT = Get_TitleNames(Db_Or_Combo, Ua.GetValue(0))
            End If
            Qr = ArV(Ua, 1, ",")
            Fc = ArV(Ua, 2, ",")
            SnA = ArV(Ua, 3, ",")
            Signx = CStr(ADSRC.SignsOpt(SnA))
        Else
            Exit Function
        End If
        If TT Is Nothing Then Sql = "" : Exit Function
        Array.Resize(QStr, TT.GetUpperBound(0) + 1)
        For k As Integer = 0 To TT.GetUpperBound(0)
            Tr = CStr(ArV(TT, k)) : Qr1 = CStr(ArV(Qr, k)) : Fr1 = CInt(Val(ArV(Fc, k))) : Signx = CStr(ArV(SnA, k, Nothing, "="))
            QStr(k) = CStr(SoftIn.GetFunction_QrText(T, Tr, Qr1, Fr1, Signx, True, ";")) 'complex=";" to work like that.
        Next
        Format_For_Complex = SrGens.ArrayToStr(QStr, " AND ", "(", ")").ToUpper
        Sql = Format_For_Complex.ToUpper : BSql = Sql & WITH_ADD_EX_QUERY
        If Start = -1 Then
            Try
                Start = T.Compute("count([" & T.Columns(0).ColumnName.ToString & "])", BSql)
            Catch ex As Exception
                Start = 0
            End Try
        End If
        If Query_Execute = True Then Tr = CStr(SoftIn.Sql_Convert_For_Adp(T, Sql, OpenTitle, True, OrderBy, GroupBy)) : AukF.Sql_Expression(Tr, T, T.TableName, Not LoadWith, Max, Start)
        If Bp_Filter = True And Bp IsNot Nothing Then AukF.Bind_WithFilter_AddWith(Bp, BSql, Bp_WithFilter, True, False)
    End Function
End Module
