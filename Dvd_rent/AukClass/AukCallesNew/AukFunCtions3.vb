'Imports Dvd_Rent.AukMod
Public Class AukFC
    Dim PrVI As Integer
    Dim Iw, Kpl, Knd, KrX As Integer
    Dim Dnt As DataTable
    Public ConPro As String = "oledb"
    Public BFil As String
    Dim RefreshDb_Str As String = vbCrLf & "By Refreshing Database you can get the last save data." & vbCrLf & "Now changes will be exhausted."

    Public Function SavStr(ByRef Which As String, ByRef TextFileName As String) As Object
        FileOpen(1, TextFileName, OpenMode.Output)
        PrintLine(1, Which)
        FileClose(1)
        Which = Mid(Which, 1, Len(Which))
    End Function
    Public Function GTxTStr(ByRef Where As String, ByRef TextFileName As String) As Object
        On Error Resume Next
        FileOpen(1, TextFileName, OpenMode.Input)
        Where = InputString(1, LOF(1))
        FileClose(1)
        GTxTStr = Left(Where, Len(Where) - 2)
        Where = GTxTStr
    End Function
    Public Function CommonRowsAdd(ByVal Row As DataRow, ByVal MastersInput As String, ByVal MasterColumn As Integer, Optional ByVal WhichColumn As String = "", Optional ByVal Changes As String = "", Optional ByVal Key As String = ",", Optional ByVal VisibleOff_when_Entry As Object = Nothing, Optional ByVal Prog As Object = Nothing, Optional ByVal PrgVisibleOption As Boolean = False)
        Dim Lst, Lst2, Lst3 As Array
        Dim Aq, Aq2, CL As Integer
        'Dim T As DataTable = Row.Table
        Dim CRows As DataRow
        Dim Str, Str2, Str3 As String
        If MastersInput.Trim <> "" Then Lst = MastersInput.Split(Key)
        If WhichColumn.Trim <> "" Then Lst2 = WhichColumn.Split(Key)
        If Changes.Trim <> "" Then Lst3 = Changes.Split(Key)
        If Prog IsNot Nothing Then
            If PrgVisibleOption = True Then Prog.Visible = True
            Prog.Maximum = Lst.GetUpperBound(0)
            Prog.Value = 0
        End If
        If VisibleOff_when_Entry IsNot Nothing Then VisibleOff_when_Entry.visible = False
        For Aq = 0 To Lst.GetUpperBound(0)
            Str = Lst.GetValue(Aq).ToString
            CRows = Row.Table.NewRow
            CRows.Item(CInt(MasterColumn)) = Str
            For Aq2 = 0 To CRows.Table.Columns.Count - 1
                Try
                    If Lst2 IsNot Nothing Then CL = Array.IndexOf(Lst2, Aq2) Else CL = -1
                    If CL > -1 Then
                        If Lst2 IsNot Nothing Then
                            Str2 = Lst2.GetValue(CL)
                            Str3 = Lst3.GetValue(CL)
                            If IsNumeric(Str2) = True Then CRows.Item(CInt(Str2)) = Str3 Else CRows.Item(CStr(Str2)) = Str3
                        End If
                    Else
                        If Aq2 <> MasterColumn Then CRows.Item(Aq2) = Row.Item(Aq2)
                    End If
                Catch ex As Exception
                    Epx()
                    Exit Function
                End Try
            Next
            Try
                Row.Table.Rows.Add(CRows)
            Catch ex As Exception
                Epx()
                Exit Function
            End Try
        Next
        If VisibleOff_when_Entry IsNot Nothing Then VisibleOff_when_Entry.visible = True
        If Prog IsNot Nothing Then
            If PrgVisibleOption = True Then
                Prog.Visible = False
            End If
        End If
    End Function
    Public Function Get_DataSystemObj(ByVal Obj As Object, Optional ByVal TableName As String = "") As DataTable
        If TypeOf (Obj) Is DataTable Then
            Return Obj
        ElseIf TypeOf (Obj) Is BindingSource Then
            Return Me.GetTableFromBindingSouce(Obj)
        ElseIf TypeOf (Obj) Is DataGridView Or TypeOf (Obj) Is DataGrid Then
            'Dim Obj As DataGridView
            If TypeOf (Obj.DataSource) Is DataTable Then
                Get_DataSystemObj = Obj.DataSource
            ElseIf TypeOf (Obj.DataSource) Is DataSet Then
                Get_DataSystemObj = Obj.DataSource.TABLES(Obj.DataMember.ToString)
            ElseIf TypeOf (Obj.DataSource) Is BindingSource Then
                Get_DataSystemObj = Me.GetTableFromBindingSouce(Obj.DataSource)
            End If
        ElseIf TypeOf (Obj) Is DataSet Then
            If TableName = "" Then MsgBox("Please type TableName to load", MsgBoxStyle.Critical) : Get_DataSystemObj = Nothing : Exit Function
            Return Obj.tables(TableName)
        Else
            MsgBox("AukError DataObject Type isnot Matched with AukCommand", MsgBoxStyle.Critical)
            Get_DataSystemObj = Nothing
        End If
    End Function
    Public Function Auk_ListObject_DataTable_DataType(ByVal Lst As Object, ByVal DbObj As Object, Optional ByVal Separete As String = "", Optional ByVal SelectIndex As Integer = 0, Optional ByVal Uppcase As Boolean = True)
        Dim T As DataTable = Me.Get_DataSystemObj(DbObj)
        Dim Dig As Integer
        Dim Lstq As Array
        Lst.Items.Clear()
        If Separete <> "" Then
            Lstq = Separete.Split(",")
        End If
        For Dig = 0 To T.Columns.Count - 1
            If Lstq.IndexOf(Lstq, Dig) = -1 Then If Uppcase = True Then Lst.Items.Add(T.Columns.Item(Dig).ColumnName.ToString.ToUpper) Else Lst.Items.Add(T.Columns.Item(Dig).ColumnName.ToString)
        Next
        Me.SelectIndexFromObject(Lst, SelectIndex)
    End Function
    Public Function SelectedItemsCopiedToObject(ByVal Lst As ListBox, ByVal FormWhichLstSelectedItem As ListBox, Optional ByVal TrimSystem As Boolean = False, Optional ByVal Unique As Boolean = False)
        Dim xLst As ListBox = FormWhichLstSelectedItem
        Dim Lw, Int As Integer
        Dim StrObj As String
        If xLst.DataSource IsNot Nothing Then
            Dim T As DataTable
            If TypeOf xLst.DataSource Is BindingSource Then
                T = Me.GetTableFromBindingSouce(xLst.DataSource)
            ElseIf TypeOf xLst.DataSource Is DataSet Then
                Me.DivideIn_To_2(xLst.DisplayMember.ToString, ".")
                T = xLst.DataSource.tables(QA1)
            ElseIf TypeOf xLst.DataSource Is DataTable Then
                T = xLst.DataSource
            End If
            For Lw = 0 To xLst.SelectedIndices.Count - 1
                Int = xLst.SelectedIndices.IndexOf(Lw).ToString
                StrObj = xLst.SelectedItems.Item(Int).ToString

                If TrimSystem = True Then StrObj = StrObj.Trim
                If Unique = True Then Me.UniqueAdd(Lst, StrObj) Else Lst.Items.Add(StrObj)
            Next
        Else
            For Lw = 0 To xLst.SelectedItems.Count - 1
                StrObj = xLst.SelectedItems.Item(Lw).ToString
                If TrimSystem = True Then StrObj = StrObj.Trim
                If Unique = True Then Me.UniqueAdd(Lst, StrObj) Else Lst.Items.Add(StrObj)
            Next
        End If
    End Function
    Public Function Text_To_InList(ByVal Lst As Object, ByVal Str As String) As ListBox
        Dim Fiona As Integer
        Lst.Items.Clear()
        If InStr(Str, "-") > 0 Then
            Me.DivideIn_To_2(Str, "-")
            If IsNumeric(QA1) And IsNumeric(QA2) Then
                For Fiona = Val(QA1) To Val(QA2) - 1
                    'MsgBox(Fiona)
                    Lst.Items.Add(Fiona)
                Next
            End If
            Res1 = True
        Else
            Res1 = False

        End If
    End Function
    Public Function List_or_Combo_AddDb_Row_dataSource(ByVal xlst As Object, ByVal Bp As BindingSource, ByVal Column As String, ByVal Row As String)
        Dim Lst As Array
        Dim Uq As Integer
        Dim T As DataTable = Me.GetTableFromBindingSouce(Bp)
        Dim Strp, Tp As String
        xlst.Items.Clear()
        Text_To_InList(Lst, Column)
        If Res1 = False Then
            Lst = Column.Split(",")
        End If
        If Lst.GetUpperBound(0) > 0 Then
            For Uq = 0 To Lst.GetUpperBound(0)
                Tp = Lst.GetValue(Uq).ToString
                If IsNumeric(Row) Then
                    Strp = T.Rows(CInt(Row)).Item(CInt(Tp)).ToString
                    xlst.Items.Add(Strp)
                Else
                    Strp = T.Rows(Row).Item(CInt(Tp)).ToString
                    xlst.Items.Add(Strp)
                End If
            Next
        End If
    End Function
    Public Function Db_Load(ByVal TitleNames As String, ByVal TableName As String, ByVal Db As Object, Optional ByVal ClrDb As Boolean = True, Optional ByVal OrderTableTitles As String = "", Optional ByVal Like_Option As Boolean = False, Optional ByVal Like_From_First As Boolean = False, Optional ByVal Limit As Integer = -1, Optional ByVal LoadStart As Integer = 0, Optional ByVal GroupBy As Boolean = False, Optional ByVal Func As Integer = 0, Optional ByVal TopLoad As Integer = 0, Optional ByVal Percent As Boolean = False, Optional ByVal TitlesBrackeNotCheck As Boolean = False)
        Dim T As DataTable
        'Dim MCount As Integer
   
        If ConPro = "oledb" Then
            If TypeOf (Db) Is DataSet And TableName = "" Then
                MsgBox("Please Type Table name Or Select Table From Dataset", MsgBoxStyle.Critical, "AukNew DataBindCommand")
            Else
                T = Me.Get_DataSystemObj(Db, TableName)
                If TableName = "" And T.TableName <> "" Then
                    TableName = T.TableName.ToString
                ElseIf TableName <> "" Then
                    T.TableName = TableName
                ElseIf TableName = "" And T.TableName = "" Then
                    MsgBox("No Table Name is Found (Internal Command).", MsgBoxStyle.Critical)
                    Exit Function
                End If
                If Like_Option = True Then
                    If Like_From_First = True Then Func = 1 Else Func = 2
                End If
                AukSql.AukSql_Main(TitleNames, TableName, Func)
                If TitlesBrackeNotCheck = True Then
                    If TitleNames <> "*" Then str1 = SoftIn.Replace_Database_FieldsNamesByNumber(T, TitleNames, True)
                    If OrderTableTitles <> "" Then OrderTableTitles = SoftIn.Replace_Database_FieldsNamesByNumber(T, OrderTableTitles, True)
                End If
            End If
            If LoadStart = -1 Then
                If ClrDb = False Then
                    Try
                        'LoadStart = T.Compute("Count([" & T.Columns(0).ColumnName.ToString & "])", BSql)
                        LoadStart = T.Compute("Count([" & T.Columns(0).ColumnName.ToString & "])", BSql)
                    Catch ex As Exception
                        'MsgBox(BSql, , T.Columns(0).ColumnName.ToString)
                        LoadStart = 0
                    End Try
                Else
                    LoadStart = 0
                End If
            End If
            'MsgBox(LoadStart)

            SoftIn.Sql_Convert_For_Adp(T, BSql, TitleNames, False, OrderTableTitles, GroupBy, TopLoad, False, False, False, TableName)
            Sql = UCase(Sql)
            Me.Sql_Expression(Sql, T, TableName, ClrDb, Limit, LoadStart)
        ElseIf ConPro = "odbc" Then
            'Odbc_SqlStatements(TitleNames, TableName, DbT, ClrDb, OrderTableTitles, Like_Option, Like_From_First, Limit, LoadStart)
        End If

    End Function
    Public Function Db_LoadQ(ByVal T As DataTable, Optional ByVal BSQL_STR As String = "", Optional ByVal OpTitles As String = "*", Optional ByVal ClrDB As Boolean = True, Optional ByVal OrderBy As String = "", Optional ByVal Group As Boolean = False, Optional ByVal Start As Integer = 0, Optional ByVal Limit As Integer = -1, Optional ByVal TopLoad As Integer = 0)
        SoftIn.Sql_Convert_For_Adp(T, BSQL_STR, OpTitles, False, OrderTableTitles, GroupBy, TopLoad, False, False, False, TableName)
        Sql = UCase(Sql)
        If Start = -1 Then
            If ClrDB = False Then
                Try
                    Start = T.Compute("Count([" & T.Columns(0).ColumnName.ToString & "])", BSql)
                Catch ex As Exception
                    Start = 0
                End Try
            Else
                Start = 0
            End If
        End If
        Me.Sql_Expression(Sql, T, TableName, ClrDB, Limit, Start, BsqlX)
        Return Sql
    End Function
    Public Function Db_LoadF(ByVal Db As Object, Optional ByVal OpTitles As String = "*", Optional ByVal TableName As String = "", Optional ByVal ClrDB As Boolean = True, Optional ByVal Func As Integer = 0, Optional ByVal OrderBy As String = "", Optional ByVal Group As Boolean = False, Optional ByVal Start As Integer = 0, Optional ByVal Limit As Integer = -1, Optional ByVal TopLoad As Integer = 0)
        Me.Db_Load(OpTitles, TableName, Db, ClrDB, OrderBy, False, False, Limit, Start, Group, Func, TopLoad, False, True)
    End Function
    Public Function Db_LoadN(ByVal Db As Object, Optional ByVal OpTitles As String = "*", Optional ByVal TableName As String = "", Optional ByVal ClrDB As Boolean = True, Optional ByVal Func As Integer = 0, Optional ByVal OrderBy As String = "", Optional ByVal Group As Boolean = False, Optional ByVal Start As Integer = 0, Optional ByVal Limit As Integer = -1, Optional ByVal TopLoad As Integer = 0, Optional ByVal Percent As Boolean = False, Optional ByVal TitlesBrackeNotCheck As Boolean = False)
        If Val(OpTitles) = -1 Then OpTitles = "*"
        Me.Db_Load(OpTitles, TableName, Db, ClrDB, OrderBy, False, False, Limit, Start, Group, Func, TopLoad, Percent, TitlesBrackeNotCheck)
    End Function


    Public Function GetDataGrid_To_Bp(ByVal DtnG As DataGridView) As BindingSource
        If TypeOf (DtnG.DataSource) Is BindingSource Then
            GetDataGrid_To_Bp = DtnG.DataSource
        ElseIf TypeOf (DtnG.DataSource) Is DataSet Then
            GetDataGrid_To_Bp.DataSource = DtnG.DataSource
            GetDataGrid_To_Bp.DataMember = DtnG.DataMember
        ElseIf TypeOf (DtnG.DataSource) Is DataTable Then
            GetDataGrid_To_Bp.DataSource = DtnG.DataSource
        End If
    End Function
    Public Function GetDataGrid_To_DataTable(ByVal DtnG As DataGridView) As DataTable
        If TypeOf (DtnG.DataSource) Is BindingSource Then
            GetDataGrid_To_DataTable = Me.GetTableFromBindingSouce(DtnG.DataSource)
        ElseIf TypeOf (DtnG.DataSource) Is DataSet Then
            GetDataGrid_To_DataTable = DtnG.DataSource.tables(DtnG.DataMember.ToString)
        ElseIf TypeOf (DtnG.DataSource) Is DataTable Then
            GetDataGrid_To_DataTable = DtnG.DataSource
        End If
    End Function
    Public Function FullScreenSet(ByRef frm As System.Windows.Forms.Form, ByVal ToPOSiz As Boolean)
        frm.Height = Screen.PrimaryScreen.Bounds.Height
        frm.Width = Screen.PrimaryScreen.Bounds.Width
        If ToPOSiz = True Then
            frm.Top = 0
            frm.Left = 0
        End If
    End Function
    Public Function Mother_DB_Load(ByVal DbObject_To_Load As Object, ByVal GetInColumn As Integer)
        Dim Str, RStv As String
        Dim Aq As Integer
        Dim T As DataTable = Me.Get_DataSystemObj(DbObject_To_Load)
        RStv = ""
        For Aq = 0 To T.Rows.Count - 1
            Str = T.Rows(Aq).Item(GetInColumn).ToString
            If RStv = "" Then
                RStv = Str
            Else
                RStv = RStv & "," & Str
            End If
        Next
        GetStrs = RStv
        Mother_DB_Load = RStv
    End Function
    Public Function BindFind(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As Object, Optional ByVal GotoPos As Boolean = False, Optional ByVal D As Object = Nothing) As Boolean
        On Error GoTo BN
        'Dim D As DataGrid
        Dim T As DataTable = AukF.Get_DataSystemObj(Bp)
        ComRow = -1
        If IsNumeric(TitleName) = True Then
            Dim Txwn As DataTable = Me.GetTableFromBindingSouce(Bp)
            TitleName = Txwn.Columns(CInt(TitleName)).ColumnName.ToString
        End If
        If SoftIn.Get_DataType_Str(T, TitleName) = False Then
            If UCase(WGeT) = "DATETIME" Then
                If IsDate(FindTxt) = False Then
                    ComRow = -1
                    Return False
                Else
                    FindTxt = Dat2(FindTxt)
                End If
            End If
        End If
        'MsgBox(TitleName)
        ComRow = Bp.Find(TitleName, FindTxt)
        If ComRow > -1 Then
            If D IsNot Nothing Then SoftIn.Select_GridRows(D, ComRow)
        End If
        'WGeT = ComRow
        If ComRow > -1 Then BindFind = True Else BindFind = False
        If GotoPos = True And ComRow > -1 Then Bp.Position = ComRow
        Exit Function
BN:     ComRow = -1 : Return False : Exit Function
    End Function
    Public Function BindDataTableFind(ByVal Table As DataTable, ByVal TitleName As String, ByVal FindTxt As String) As Boolean
        Dim Bp As New BindingSource
        Bp.DataSource = Table
        If IsNumeric(TitleName) = True Then TitleName = Table.Columns(CInt(TitleName)).ColumnName.ToString
        Ap = Bp.Find(TitleName, FindTxt)
        If Ap > -1 Then BindDataTableFind = True Else BindDataTableFind = False
        ComRow = Ap
    End Function
    Public Function Single_DataRecordRefresh(ByVal Bp As BindingSource, Optional ByVal Msg As Boolean = True, Optional ByVal MsgTxt As String = "")
        Dim T As DataTable = Me.GetTableFromBindingSouce(Bp)
        Try
            If Msg = True Then
                If MsgTxt = "" Then
                    If MsgBox("Do you want to Refresh (" & Bp.Position + 1 & ") Record Data...?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        'T.Rows(Bp.Position).RejectChanges()
                        Bp.ResetCurrentItem()
                    End If
                End If
            Else
                'T.Rows(Bp.Position).RejectChanges()
                Bp.ResetCurrentItem()
            End If
        Catch ex As Exception
            Epx()
        End Try
    End Function
    Public Function Single_DataRecordRefresh(ByVal D As DataGridView, Optional ByVal Msg As Boolean = True, Optional ByVal MsgTxt As String = "")
        Dim T As DataTable = AukF.Get_DataSystemObj(D)
        ID = AukF.GridT(D, 0)
        Single_DataRecordRefresh(ID, T, Msg, MsgTxt)
    End Function
    Public Function Single_DataRecordRefresh(ByVal BY_FIND_ID As String, ByVal T As DataTable, Optional ByVal Msg As Boolean = False, Optional ByVal MsgTxt As String = "")
        If ADSRC.FIND_FROM_DATATABLE_INDEX(T, BY_FIND_ID) = False Then
            Exit Function
        End If
        Single_DataRecordRefresh(T, ComRow, Msg, MsgTxt)
    End Function
    Public Function Single_DataRecordRefresh(ByVal T As DataTable, ByVal RowI As Integer, Optional ByVal Msg As Boolean = False, Optional ByVal MsgTxt As String = "")
        Try
            If Msg = True Then
                If MsgTxt = "" Then
                    If MsgBox("Do you want to Refresh (" & RowI + 1 & ") Record Data...?" & vbCrLf & Me.RefreshDb_Str, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        T.Rows(RowI).RejectChanges()
                    End If
                End If
            Else
                T.Rows(RowI).RejectChanges()
            End If
        Catch ex As Exception
            Epx()
        End Try
    End Function
    Public Function RemovePoints(ByVal FormNumber As String) As String
        cf = Val(FormNumber)
        gh = InStr(cf, ".")
        If gh > 0 Then
            gt = Mid(cf, 1, gh - 1)
        Else
            gt = cf
        End If
        If gh > 0 Then
            g = Mid(cf, gh, 3)
            If Val(g) >= 0.46 Then
                m = 10

            Else
                m = 0
            End If
            fr = gt
            If m = 5 Then
                fr = fr & ".5"
            ElseIf m = 10 Then
                fr = Val(fr) + 1
            Else
            End If
        Else
            fr = Val(cf)
        End If
        RemovePoints = Val(fr)
        WGeT = Val(fr)
    End Function
    Public Function SingleDataTable_DataRecordRefresh(ByVal Bp As BindingSource, Optional ByVal Msg As Boolean = False, Optional ByVal MsgTxt As String = "")
        Dim T As DataTable
        T = Me.GetTableFromBindingSouce(Bp)
        If Msg = True Then
            If MsgTxt = "" Then
                If MsgBox("Do you want to Refresh  this (" & T.TableName.ToString & ") all Records...?" & vbCrLf & Me.RefreshDb_Str, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    T.RejectChanges()
                End If
            End If
        Else
            T.RejectChanges()
        End If
    End Function
    Public Function SingleDataTable_DataRecordRefresh(ByVal Bp As DataTable, Optional ByVal Msg As Boolean = False, Optional ByVal MsgTxt As String = "")
        Dim T As DataTable
        T = Me.Get_DataSystemObj(Bp)
        If Msg = True Then
            If MsgTxt = "" Then
                If MsgBox("Do you want to Refresh  this (" & T.TableName.ToString & ") all Records...?" & vbCrLf & Me.RefreshDb_Str, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    T.RejectChanges()
                End If
            End If
        Else
            T.RejectChanges()
        End If
    End Function
    Public Function ContextShow(ByVal Context As ContextMenuStrip)
        If Windows.Forms.Cursor.Position.X <> 0 And Windows.Forms.Cursor.Position.Y <> 0 Then
            Context.Show(Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y)
        End If
    End Function

    Public Function RejectChg(ByVal TabName As String, ByVal Bp As BindingSource) As Boolean
        Dim D As Object
        D = Bp.DataSource
        If Me.MsgTr(What & "Refresh database(" & TabName & ",Reject Changes)...?" & vbCrLf & Me.RefreshDb_Str) = True Then
            Bp.CancelEdit()
            D.RejectChanges()
        End If
    End Function
    Public Function RejectChg(ByVal Bp As BindingSource) As Boolean
        Dim D As Object
        D = Bp.DataSource
        If Me.MsgTr(What & "Refresh database(" & Bp.DataMember.ToString & ",Reject Changes)...?") = True Then
            Bp.CancelEdit()
            D.RejectChanges()
        End If
    End Function
    Public Function GetDateFormatForMaskTxt(ByVal Datex As Date)
        Dim D, M, Y As String
        D = Datex.Day
        M = Datex.Month
        Y = Datex.Year
        If Len(D) < 2 Then
            D = "0" & D
        End If
        If Len(M) < 2 Then
            M = "0" & M
        End If
        GetDateFormatForMaskTxt = M & D & Y

    End Function
    Public Function ComboMustTypeFromList(ByVal Com As Object)
        Me.ComboMustTypeFromList(Com, Com.text)

    End Function
    Public Function ComboMustTypeFromList(ByVal Com As Object, ByVal Txt As Object)
        Dim str As String
        Try
            str = Txt.text
        Catch ex As Exception
            str = Txt.ToString
        End Try
        If Com.Items.Count > 0 Then
            If Com.FindStringExact(Txt) = -1 Then
                MsgBox("Please type Exactword from " & Com.GetType.Name.ToString & "....,Please Select from " & Com.GetType.Name.ToString & ".(Please work carefully)...", MsgBoxStyle.Critical)
                Com.SelectedIndex = 0
                Com.Focus()

            End If
        End If

    End Function
    Public Function DeleteFromMasterTable(ByVal Bp As BindingSource, Optional ByVal PrimaryColumn As Integer = 1)
        Dim Dnt As DataTable
        Dnt = AukF.Get_DataSystemObj(Bp)
        Try
            If Dnt IsNot Nothing AndAlso Bp IsNot Nothing Then
                If Bp.Position > -1 Then
                    If MsgBox("Do you to Delete (" & Dnt.Columns(PrimaryColumn).ColumnName & "='" & Dnt.Rows(Bp.Position).Item(PrimaryColumn) & "') from (" & Dnt.TableName & ") DataTable ..? " & vbCrLf & vbCrLf & "If you delete this item ... its all sub records will be deleted..." & vbCrLf & "So check your self very carefully...You can't get them, if you do not have a backup of this database.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Delete DataRecord From Master Table") = MsgBoxResult.Yes Then
                        Bp.RemoveCurrent()
                    End If
                End If
            End If

        Catch ex As Exception
            Epx()
        End Try
    End Function
    Public Function DeleteMultiRecordsFrmGrid(ByVal Grd As DataGridView, Optional ByVal PrimaryColumn As Integer = 1, Optional ByVal EffectBeforeDelete As Boolean = False)
        DeleteFromMasterTableGrd(Grd, PrimaryColumn, False, EffectBeforeDelete)
    End Function
    Public Sub DeleteFromMasterTableGrd(ByVal Grd As DataGridView, Optional ByVal PrimaryColumn As Integer = 1, Optional ByVal MasterDelMsg As Boolean = True, Optional ByVal EffectBeforeDelete As Boolean = False)
        Dim Dnt As DataTable
        Dnt = AukF.Get_DataSystemObj(Grd)
        Dim Fr As Object = Grd.FindForm
        Try
            If Dnt IsNot Nothing AndAlso Grd IsNot Nothing Then
                If Grd.RowCount > 0 Then
                    Dim Objects As String = ""
                    If EffectBeforeDelete = True Then
                        If Fr IsNot Nothing Then
                            Try
                                Fr.EffectBeforeDelete()
                            Catch ex As Exception
                                Epx()
                            End Try
                        End If
                    End If
                    If Grd.SelectedRows.Count > 0 Then
                        Dim Greater As Boolean = False
                        Dim Count As Integer = Grd.SelectedRows.Count - 1
                        If Count > 10 Then Count = 10 : Greater = True
                        For K As Integer = 0 To Count
                            If Grd.SelectedRows(K).Cells(PrimaryColumn).Value IsNot Nothing Then
                                If Objects = "" Then
                                    Objects = "'" & Grd.SelectedRows(K).Cells(PrimaryColumn).Value.ToString & "'"
                                Else
                                    Objects &= " , '" & Grd.SelectedRows(K).Cells(PrimaryColumn).Value.ToString & "'"
                                End If
                            End If
                        Next
                        If Greater = True Then Objects = Objects & ".... " & (Grd.SelectedRows.Count - 1) & " Records"
                    Else
                        If Grd.CurrentRow IsNot Nothing Then
                            Grd.CurrentRow.Selected = True
                        End If
                        Objects = Grd.SelectedRows(0).Cells(PrimaryColumn).Value.ToString
                    End If
                    If MasterDelMsg = True Then
                        extra = vbCrLf & vbCrLf & "If you delete this item ... its all sub records will be deleted..." & vbCrLf & "So check your self very carefully...You can't get them, if you do not have a backup of this database."
                        ti = "Delete DataRecord(s) From MasterTable"
                    Else
                        ti = "Delete DataRecord(s) From Table"
                        extra = ""
                    End If
                    If MsgBox(UCase("Do you to Delete (" & Grd.Columns(PrimaryColumn).DataPropertyName.ToString & "=" & Objects & ") from (" & Dnt.TableName & ") DataTable ..? " & extra), MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, ti) = MsgBoxResult.Yes Then
                        SendKeys.Send("{DELETE}")
                    End If
                End If
            End If
        Catch ex As Exception
            Epx()
        End Try
    End Sub
    Public Function GetTableFromBindingSouce(ByVal Bp As BindingSource) As DataTable
        Dim D As DataSet
        If TypeOf (Bp.DataSource) Is DataSet Then
            D = Bp.DataSource
            GetTableFromBindingSouce = D.Tables(Bp.DataMember.ToString)
        ElseIf TypeOf (Bp.DataSource) Is DataTable Then
            GetTableFromBindingSouce = Bp.DataSource
        ElseIf TypeOf (Bp.DataSource) Is BindingSource Then
            Dim T As DataTable = GetTableFromBindingSouce(Bp.DataSource)
            GetTableFromBindingSouce = T.ChildRelations(Bp.DataMember.ToString).ChildTable
            'GetTableFromBindingSouce = 
        End If
    End Function
    Public Function ComboToAddTableNames(ByVal Bp As BindingSource, ByVal Com As Object)
        Dim T As DataTable
        T = Me.GetTableFromBindingSouce(Bp)
        'Dim d As DataSet = Bp.DataSource
        'Dim t As String = Bp.DataMember.ToString

        For Iw = 0 To T.Columns.Count - 1
            item = T.Columns(Iw).ColumnName.ToString
            Me.UniqueAdd(Com, item)
        Next
        Me.ComSelIndex(Com)

    End Function
    Public Function ComboToAddTableDataType(ByVal Bp As BindingSource, ByVal Com As Object)
        Dim d As DataSet = Bp.DataSource
        Dim t As String = Bp.DataMember.ToString
        For Iw = 0 To d.Tables(t).Columns.Count - 1
            item = d.Tables(t).Columns(Iw).DataType.ToString
            Me.UniqueAdd(Com, item)
        Next
        Me.ComSelIndex(Com)
    End Function
    Public Function ToolStripComboDataSource(ByVal Com As ToolStripComboBox, ByVal bp As BindingSource, ByVal Column As Integer)
        Dim d As DataSet = bp.DataSource
        Dim t As String = bp.DataMember.ToString
        For Iw = 0 To d.Tables(t).Rows.Count - 1
            item = d.Tables(t).Rows(Iw).Item(Column).ToString
            Me.UniqueAdd(Com, item)
        Next
        Me.ComSelIndex(Com)
    End Function
    Public Function AukChkListUnCheck_Item_all(ByVal ChkList As CheckedListBox)
        Dim kop, crp As Integer
        Try
            crp = ChkList.Items.Count

        Catch ex As Exception
            crp = 0
        End Try
        'MsgBox(crp)
        For kop = 0 To crp - 1
            ChkList.SetItemChecked(kop, False)
        Next
    End Function

    Public Function AukChkList(ByVal ChkList As CheckedListBox, ByVal Bp As BindingSource, ByVal Column As Integer, ByVal FoundCheck As Boolean, ByVal unChkallBefore As Boolean)
        Dim D As DataSet = Bp.DataSource
        Dim t As String = Bp.DataMember.ToString
        Dim Aq As Integer
        If unChkallBefore = True Then AukChkListUnCheck_Item_all(ChkList)
        For Iw = 0 To D.Tables(t).Rows.Count - 1
            item = D.Tables(t).Rows(Iw).Item(Column).ToString
            'MsgBox(item)
            If ChkList.FindStringExact(item) > -1 Then
                Aq = ChkList.FindStringExact(item)
                ChkList.SetItemChecked(Aq, FoundCheck)
            End If
            'Me.UniqueAdd(Com, item)
        Next

    End Function

    Public Function AukDataSourceSetObjectListOrComboType(ByVal Com As Object, ByVal bp As BindingSource, ByVal Column As Integer, ByVal BeforeLoadClr As Boolean, ByVal UniqeAdd As Boolean)
        Dim d As DataSet = bp.DataSource
        Dim t As String = bp.DataMember.ToString
        If BeforeLoadClr = True Then Com.items.clear()
        For Iw = 0 To d.Tables(t).Rows.Count - 1
            item = d.Tables(t).Rows(Iw).Item(Column).ToString
            If UniqeAdd = True Then
                Me.UniqueAdd(Com, item)
            Else
                Com.items.add(item)
            End If
        Next
        Me.ComSelIndex(Com)
    End Function

    Public Function GridT(ByVal D As DataGridView, Optional ByVal Columnx As Integer = -1, Optional ByVal RowIndex As Integer = -1, Optional ByVal DEFAULTSTR As String = "") As Object
        On Error Resume Next
        If D Is Nothing Then MsgBox("GRID OBJECT IS NOTHING", MsgBoxStyle.Critical) : Exit Function
        If D.CurrentCell Is Nothing Then DRow = -1 : DColumn = -1 : Return DEFAULTSTR
        DRow = D.CurrentCell.RowIndex
        DColumn = D.CurrentCell.ColumnIndex
        If RowIndex = -1 Then RowIndex = DRow
        If RowIndex = -1 Then Exit Function
        If Columnx = -1 Then Columnx = DColumn
        If TypeOf (D.CurrentCell.DataGridView(Columnx, RowIndex).Value) Is DBNull Then
            GridT = DEFAULTSTR
        Else
            If D(Columnx, RowIndex) IsNot Nothing Then
                GridT = D(Columnx, RowIndex).Value.ToString
            Else
                GridT = DEFAULTSTR
            End If
        End If
        WGeT = GridT
        Exit Function
b:      Return DEFAULTSTR
    End Function

    Public Sub GridTSet(ByVal D As DataGridView, Optional ByVal SetText As Object = "", Optional ByVal Columnx As Integer = -1, Optional ByVal RowIndex As Integer = -1, Optional ByVal Logic As Boolean = False, Optional ByVal OnlyInputIf As String = "")
        On Error Resume Next
        If D Is Nothing Then MsgBox("GRID OBJECT IS NOTHING", MsgBoxStyle.Critical) : Exit Sub
        If D.CurrentCell Is Nothing Then DRow = -1 : DColumn = -1
        DRow = D.CurrentCell.RowIndex
        DColumn = D.CurrentCell.ColumnIndex
        If RowIndex = -1 Then RowIndex = DRow
        If RowIndex = -1 Then Exit Sub
        If Columnx = -1 Then Columnx = DColumn
        'If TypeOf (D.CurrentCell.DataGridView(Column, RowIndex).Value) Is DBNull Then
        'Else
        If Logic = False Then
input:      If D(Columnx, RowIndex) IsNot Nothing Then
                'If UCase(D.Columns(Column).ValueType.Name) = "STRING" Then
                D(Columnx, RowIndex).Value = SetText
                'End If
            End If
        Else
            xmAn = GridT(D, Columnx, RowIndex).ToString
            If xmAn = OnlyInputIf Then
                GoTo input
            End If
        End If
        'End If


    End Sub

    Public Function ConTOAsc(ByVal Txt As String, ByVal Expresion As String, ByVal WhichNum As String) As String
        Dim Str As String = ""
        For Iw = 1 To Len(Txt)
            n = Asc(Mid(Txt, Iw, 1))
            'MsgBox(n)
            If Expresion = "+" Then
                n = Val(n) + Val(WhichNum)
            ElseIf Expresion = "-" Then
                n = Val(n) - Val(WhichNum)
            ElseIf Expresion = "*" Then
                n = Val(n) * Val(WhichNum)
            ElseIf Expresion = "/" Then
                n = Val(n) / Val(WhichNum)
            End If
            Str = Str & n
        Next
        ConTOAsc = Str
    End Function
    'Public Function AukChkListChecked(ByVal ChkLst As CheckedListBox, ByVal Item As Integer) As Boolean

    'End Function
    Public Function ConTOAsc(ByVal Txt As String, ByVal Expresion As String, ByVal WhichNum As Decimal, ByVal AlsoDoWith As Boolean) As String
        Dim Str As Decimal = 0

        For Iw = 1 To Len(Txt)
            n = CDec(Asc(Mid(Txt, Iw, 1)))
            If AlsoDoWith = True Then
                If Expresion = "+" Then
                    n = CDec(n) + CDec(WhichNum)
                ElseIf Expresion = "-" Then
                    n = CDec(n) - CDec(WhichNum)
                ElseIf Expresion = "*" Then
                    n = CDec(n) * CDec(WhichNum)
                ElseIf Expresion = "/" Then
                    n = CDec(n) / CDec(WhichNum)
                End If

                Str = Str + n
                'MsgBox(Str)

            Else
                If Expresion = "+" Then
                    n = CDec(n) + CDec(WhichNum)
                ElseIf Expresion = "-" Then
                    n = CDec(n) - CDec(WhichNum)
                ElseIf Expresion = "*" Then
                    n = CDec(n) * CDec(WhichNum)
                ElseIf Expresion = "/" Then
                    n = CDec(n) / CDec(WhichNum)
                End If
                Str = Str & n
            End If


        Next
        ConTOAsc = Str
    End Function
    Public Function Prnt(ByVal MRpt As Object, ByVal Dset As Object, Optional ByVal BP As BindingSource = Nothing, Optional ByVal BsqlX_Str As String = "")
        Dim m As Object
        Dim A As String = ""
        m = MRpt
        If BP IsNot Nothing Then
            A = GET_rEPORT_fILTER(BP)
            If BsqlX_Str <> "" Then
                If A = "" Then
                    A = BsqlX_Str
                Else
                    A = A & " and (" & BsqlX_Str & ")"
                End If
            End If
            If A <> "" Then
                m.RecordSelectionFormula = A
            End If
            'MsgBox(GET_rEPORT_fILTER(BP))
        End If
        m.Database.Tables(0).SetDataSource(Dset)
        FrmL(Reports)
        Reports.CrystalReportViewer1.ReportSource = m
    End Function
    Public Function Prnt_ABP(ByVal MRpt As Object, ByVal Dset As Object, Optional ByVal BP() As BindingSource = Nothing)
        Dim m As Object
        Dim Str, A As String
        Dim NBp As BindingSource
        m = MRpt
        If BP IsNot Nothing Then
            For k As Integer = 0 To BP.GetUpperBound(0)
                NBp = BP.GetValue(k)
                A = Me.GET_rEPORT_fILTER(NBp)
                If A <> "" Then
                    If Str = "" Then
                        Str = A
                    Else
                        Str &= " AND " & A
                    End If
                End If
            Next
            If Str <> "" Then
                m.RecordSelectionFormula = Str
            End If
            'MsgBox(GET_rEPORT_fILTER(bP))
        End If
        m.Database.Tables(0).SetDataSource(Dset)
        FrmL(Reports)
        Reports.CrystalReportViewer1.ReportSource = m
    End Function
    Public Function Prnt(ByVal MRpt As Object, ByVal Dset As Object, ByVal BSQLX As String, ByVal TABLEN As String)
        Dim m As Object
        m = MRpt
        If BSQLX IsNot Nothing Then
            A = GET_rEPORT_fILTER(BSQLX, TABLEN)
            If A <> "" Then
                m.RecordSelectionFormula = A
            End If
        End If
        m.Database.Tables(0).SetDataSource(Dset)
        FrmL(Reports)
        Reports.CrystalReportViewer1.ReportSource = m
    End Function
    Public Function SET_FILTER_INrEPORT(ByVal MRpt As Object, ByVal BSQLX As String, ByVal TABLEN As String)
        Dim m As Object
        m = MRpt
        If BSQLX <> "" And TABLEN <> "" Then
            A = GET_rEPORT_fILTER(BSQLX, TABLEN)
            If A <> "" Then
                m.RecordSelectionFormula = A
            End If
        End If
    End Function
    Public Function SET_FILTER_INrEPORT(ByVal MRpt As Object, Optional ByVal BP As BindingSource = Nothing)
        Dim m As Object
        m = MRpt
        If BP IsNot Nothing Then
            A = GET_rEPORT_fILTER(BP)
            If A <> "" Then
                m.RecordSelectionFormula = A
            End If
        End If
    End Function

    Public Function SET_FILTER_INrEPORT_ARRAY_BP(ByVal MRpt As Object, Optional ByVal BP() As BindingSource = Nothing)
        Dim m As Object
        Dim Str, A As String
        Dim NBp As BindingSource
        m = MRpt
        If BP IsNot Nothing Then
            For k As Integer = 0 To BP.GetUpperBound(0)
                NBp = BP.GetValue(k)
                A = Me.GET_rEPORT_fILTER(NBp)
                If A <> "" Then
                    If Str = "" Then
                        Str = A
                    Else
                        Str &= " AND " & A
                    End If
                End If
            Next
            If Str <> "" Then
                m.RecordSelectionFormula = Str
            End If
        End If
    End Function
    Public Function GET_rEPORT_fILTER(ByVal BP As BindingSource) As String
        Dim FIL As String
        Dim T As DataTable = Me.Get_DataSystemObj(BP)
        If BP.Filter IsNot Nothing Then
            FIL = BP.Filter
            FIL = Replace(FIL, "[", "{" & T.TableName.ToString & ".", 1, -1, CompareMethod.Text)
            FIL = FIL.Replace("]", "}")
            FIL = FIL.Replace("%", "*")
            FIL = Replace(FIL, "IS NULL", "=''")
            FIL = Replace(FIL, "IS not NULL", "<>''")
            Return FIL
        Else
            Return ""
        End If
    End Function
    Public Function GET_rEPORT_fILTER(ByVal SQLX As String, ByVal TABLEN As String) As String
        Dim FIL As String
        'Dim T As DataTable = Me.Get_DataSystemObj(BP)
        If Trim(SQLX) <> "" And TABLEN <> "" Then
            FIL = SQLX
            FIL = Replace(FIL, "[", "{" & TABLEN & ".", 1, -1, CompareMethod.Text)
            FIL = FIL.Replace("]", "}")
            FIL = FIL.Replace("%", "*")
            FIL = Replace(FIL, "IS NULL", "=''")
            FIL = Replace(FIL, "IS not NULL", "<>''")

            Return FIL
        Else
            Return ""
        End If
    End Function
    Public Function GetIndexInOrNot(ByVal Lst As ListBox, ByVal Index As Integer) As Boolean
        m = Lst.Items.Count - 1
        If Val(m) >= Index Then
            GetIndexInOrNot = True
            Try
                WGeT = Lst.Items.Item(Index)
            Catch ex As Exception
            End Try
        Else
            GetIndexInOrNot = False
            WGeT = ""
        End If
    End Function
    Public Function GetIndexInOrNot(ByVal Lst As Object, ByVal Index As Integer) As Boolean
        m = Lst.Items.Count - 1
        If Val(m) >= Index Then
            GetIndexInOrNot = True
            WGeT = Lst.Items.Item(Index)
        Else
            GetIndexInOrNot = False
            WGeT = ""
        End If
    End Function
    Public Function SelectIndexFromObject(ByVal lst As Object, ByVal Index As Integer, Optional ByVal GOTOPOS As Boolean = True) As Boolean
        m = lst.Items.Count - 1
        If Val(m) >= Index Then
            If GOTOPOS = True Then lst.SelectedIndex = Index
            SelectIndexFromObject = True
        Else
            SelectIndexFromObject = False
            WGeT = ""
        End If
    End Function
    Public Function DataGridDeleteItems(ByVal D As DataGridView, ByVal CurrentOnly As Boolean, ByVal AllSelected As Boolean)
        Dim Sk As Integer
        mbs = D.SelectedRows.Count
        If AllSelected = True Then
            For PrVI = (mbs - 1) To 0 Step -1
                Sk = D.SelectedRows(PrVI).Index.ToString
                D.Rows.RemoveAt(Sk)
            Next
        ElseIf CurrentOnly = True Then
            D.Rows.RemoveAt(D.CurrentCell.RowIndex.ToString)
        End If
    End Function
    Public Function DataGridDeleteItems(ByVal D As DataGridView, ByVal CurrentOnly As Boolean, ByVal AllSelected As Boolean, ByVal MsgboxShow As Boolean)
        Dim Sk As Integer
        mbs = D.SelectedRows.Count
        If MsgboxShow = True Then
            If Me.MsgTr(What & "delete (" & mbs & ") rows from this DataTable....?") = False Then
                Exit Function
            End If
        End If
        If AllSelected = True Then
            For PrVI = (mbs - 1) To 0 Step -1
                Sk = D.SelectedRows(PrVI).Index.ToString
                D.Rows.RemoveAt(Sk)
            Next
        ElseIf CurrentOnly = True Then
            D.Rows.RemoveAt(D.CurrentCell.RowIndex.ToString)
        End If
    End Function
    Public Function DataGridDeleteItemsProcessor(ByVal D As DataGridView, ByVal CurrentOnly As Boolean, ByVal AllSelected As Boolean, Optional ByVal MsgboxShow As Boolean = True, Optional ByVal Prog As ProgressBar = Nothing)
        Dim Sk As Integer
        mbs = D.SelectedRows.Count
        If MsgboxShow = True Then
            If Me.MsgTr(What & "delete (" & mbs & ") rows from this DataTable....?") = False Then
                Exit Function
            End If
        End If
        If Val(mbs) > 0 Then
            caz = 100 / mbs
        End If

        If AllSelected = True Then
            For PrVI = (mbs - 1) To 0 Step -1
                Sk = D.SelectedRows(PrVI).Index.ToString
                D.Rows.RemoveAt(Sk)
                If Prog IsNot Nothing Then Me.InsPro(Prog, caz)
            Next
        ElseIf CurrentOnly = True Then
            D.Rows.RemoveAt(D.CurrentCell.RowIndex.ToString)
        End If
        If Prog IsNot Nothing Then Prog.Value = 0

    End Function
    Public Function BoolInvert(ByVal B As Boolean) As Boolean
        If B = True Then
            BoolInvert = False
        Else
            BoolInvert = True
        End If
    End Function
    Public Function AukOptionsOfDataGrid(ByVal D As DataGridView, Optional ByVal ReadWriteColumn As String = Nothing, Optional ByVal ReadonlyColumn As String = Nothing, Optional ByVal FrozenColumn As String = Nothing, Optional ByVal UnFrozenColumn As String = Nothing, Optional ByVal InvisibleColumn As String = Nothing, Optional ByVal VisibleColumn As String = Nothing)
        Dim Lp As Array
        Dim Item As Integer
        If ReadonlyColumn Is Nothing Then GoTo READW
READO:  If ReadonlyColumn.Trim <> "" Then
            Lp = ReadonlyColumn.Trim.Split(",")
            If Lp.GetUpperBound(0) > 0 Then
                For PrVI = 0 To Lp.GetUpperBound(0)
                    Item = Val(Lp.GetValue(PrVI).ToString)
                    D.Columns(Item).ReadOnly = True
                    'MsgBox(Val(Lp.GetValue(PrVI).ToString))
                Next
            End If
        End If
READW:  If ReadWriteColumn Is Nothing Then GoTo FRZ
        If ReadWriteColumn.Trim <> "" Then
            'Lp.Items.Clear()
            Lp = ReadWriteColumn.Trim.Split(",")
            If Lp.GetUpperBound(0) > 0 Then
                For PrVI = 0 To Lp.GetUpperBound(0)
                    Item = Val(Lp.GetValue(PrVI).ToString)
                    D.Columns(Item).ReadOnly = False
                Next
            End If
        End If
FRZ:    If FrozenColumn Is Nothing Then GoTo UNFRZ
        If FrozenColumn.Trim <> "" Then
            'Lp.Items.Clear()
            Lp = FrozenColumn.Trim.Split(",")
            If Lp.GetUpperBound(0) > 0 Then
                For PrVI = 0 To Lp.GetUpperBound(0)
                    Item = Val(Lp.GetValue(PrVI).ToString)
                    'MsgBox(Item)
                    D.Columns(Item).Frozen = True
                Next
            End If
        End If
UNFRZ:  If UnFrozenColumn Is Nothing Then GoTo VIS
        If UnFrozenColumn.Trim <> "" Then
            'Lp.Items.Clear()
            Lp = UnFrozenColumn.Trim.Split(",")
            If Lp.GetUpperBound(0) > 0 Then
                For PrVI = 0 To Lp.GetUpperBound(0)
                    Item = Val(Lp.GetValue(PrVI).ToString)
                    D.Columns(Item).Frozen = False
                Next
            End If
        End If
VIS:    If VisibleColumn Is Nothing Then GoTo INVIS
        If VisibleColumn.Trim <> "" Then
            'Lp.Items.Clear()
            Lp = VisibleColumn.Trim.Split(",")

            If Lp.GetUpperBound(0) > 0 Then
                For PrVI = 0 To Lp.GetUpperBound(0)
                    Item = Val(Lp.GetValue(PrVI).ToString)
                    D.Columns(Item).Visible = True
                Next
            End If
        End If
INVIS:  If InvisibleColumn Is Nothing Then Exit Function
        If InvisibleColumn.Trim <> "" Then
            'Lp.Items.Clear()
            Lp = InvisibleColumn.Trim.Split(",")
            If Lp.GetUpperBound(0) > 0 Then
                For PrVI = 0 To Lp.GetUpperBound(0)
                    Item = Val(Lp.GetValue(PrVI).ToString)
                    D.Columns(Item).Visible = False
                Next
            End If
        End If
    End Function
    Public Function DelRowsFromDatabase(ByVal Column As Integer, ByVal CurRow As String, ByVal Tab As Data.DataTable, ByVal WhatFind As String, ByVal AllRowFind As Boolean)
        Dim J As String
        If AllRowFind = True Then
            For PrVI = 0 To Tab.Rows.Count - 1
                J = Tab.Rows(PrVI).Item(Column).ToString
                If J = WhatFind Then
                    Tab.Rows(PrVI).Delete()
                    Tab.Rows(PrVI).ClearErrors()
                End If
            Next
        End If
    End Function
    Public Function DelRowsFromDatabase_ByFindingSomeThing(ByVal Column As Integer, ByVal CurRow As String, ByVal Tab As Data.DataTable, ByVal WhatFind As String, ByVal AllRowFind As Boolean, ByVal CaseSensetive As Boolean)
        Dim J As String
        If AllRowFind = True Then
            For PrVI = 0 To Tab.Rows.Count - 1
                J = Tab.Rows(PrVI).Item(Column).ToString
                If CaseSensetive = True Then
                    If J = WhatFind Then
                        Tab.Rows(PrVI).Delete()
                        Tab.Rows(PrVI).ClearErrors()
                    End If
                Else
                    If J.ToUpper = WhatFind.ToUpper Then
                        Tab.Rows(PrVI).Delete()
                        Tab.Rows(PrVI).ClearErrors()
                    End If
                End If
            Next
        End If
    End Function
    Public Function DelRowsFromDatabase_ByFindingSomeThing(ByVal Column As Integer, ByVal CurRow As String, ByVal Tab As Data.DataTable, ByVal WhatFind As String, ByVal AllRowFind As Boolean, ByVal CaseSensetive As Boolean, ByVal UseInStr As Boolean)
        Dim J As String
        If AllRowFind = True Then
            For PrVI = 0 To Tab.Rows.Count - 1
                J = Tab.Rows(PrVI).Item(Column).ToString
                If UseInStr = True Then
                    If CaseSensetive = True Then
                        If InStr(J, WhatFind) <> 0 Then
                            Tab.Rows(PrVI).Delete()
                            Tab.Rows(PrVI).ClearErrors()
                        End If
                    Else
                        If InStr(J.ToUpper, WhatFind.ToUpper) <> 0 Then
                            Tab.Rows(PrVI).Delete()
                            Tab.Rows(PrVI).ClearErrors()
                        End If
                    End If
                End If
            Next
        End If
    End Function
    Public Function SuggestListSourceAddGveMsg(ByVal Obj As Object, ByVal Dset As DataSet, ByVal TableName As String, ByVal Column As Integer, Optional ByVal MaxNum As Integer = 500, Optional ByVal Msg As Boolean = False)
        Dim lpJ As Integer
        'Dim m As ComboBox
        cvnp = Dset.Tables(TableName).Rows.Count
        If (TypeOf (Obj) Is TextBox) Or (TypeOf (Obj) Is ComboBox) Or (TypeOf (Obj) Is ToolStripComboBox) Or (TypeOf (Obj) Is ToolStripTextBox) Then
            If Dset.Tables(TableName).Rows.Count > 0 Then
                If Val(MaxNum) < Val(cvnp) Then
                    If MaxNum <> 0 Then
                        If Msg = True Then
                            If MsgBox("Do you want to load .... ( " & cvnp & " )Data in current In Object Item...Yes to Load all or Else to Load Maximum(" & MaxNum & ")", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                xne = MaxNum
                            Else
                                xne = cvnp
                            End If
                        Else
                            xne = MaxNum
                        End If
                    End If
                Else
                    xne = cvnp
                End If
                For lpJ = 0 To xne - 1
                    Obj.AutoCompleteCustomSource.Add(Dset.Tables(TableName).Rows(lpJ).Item(Column).ToString)
                Next
            End If
        End If
    End Function
    Public Function FullWordFind(ByVal FindFrom As String, ByVal FindText As String) As Boolean
        c = " " & FindText & " "
        'MsgBox(c)
        If InStr(FindFrom, c) = 0 Then
            FullWordFind = False
        Else
            FullWordFind = True
        End If

    End Function
    Public Function ClearErrorFromDataSet(ByVal Dset As DataSet)
        Dim Nk As Integer
        For Nk = 0 To Dset.Tables.Count - 1
            Dset.Tables(Nk).NewRow.ClearErrors()
        Next
    End Function
    Public Function GetColumnName(ByVal bp As BindingSource, ByVal Column As Integer) As String
        Dim T As DataTable = Me.GetTableFromBindingSouce(bp)
        GetColumnName = T.Columns(ColumnNumber).ColumnName.ToString
    End Function
    Public Function BindFind(ByVal GotoPos As Boolean, ByVal Bp As BindingSource, ByVal ColumnNumber As Integer, ByVal FindTxt As String) As Boolean
        Dim Ap As Integer
        On Error Resume Next

        Dim T As DataTable = Me.GetTableFromBindingSouce(Bp)
        TitleName = T.Columns(ColumnNumber).ColumnName.ToString
        Ap = Bp.Find(TitleName, FindTxt)
        If Ap > -1 Then
            BindFind = True
        Else
            BindFind = False
        End If
        If GotoPos = True Then
            If BindFind = True Then Bp.Position = Ap
        End If
        ComRow = Ap
    End Function
    Public Function BindFind(ByVal GotoPos As Boolean, ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String) As Boolean
        On Error Resume Next
        Dim Ap As Integer
        Ap = Bp.Find(TitleName, FindTxt)
        If Ap > -1 Then
            BindFind = True
        Else
            BindFind = False
        End If
        If GotoPos = True Then
            If BindFind = True Then Bp.Position = Ap
        End If
        ComRow = Ap
    End Function
    Public Function StrNullAndWithAdd(ByVal Str As String, ByVal NullTxt As String, ByVal WithTxt As String)
        If Str.Trim = "" Then
            Str = NullTxt
        Else
            Str = Str & WithTxt
        End If
        StrNullAndWithAdd = Str
        WGeT = Str
    End Function
    Public Function BindGotoFind(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String, Optional ByVal SELETGRID As Object = Nothing) As Boolean
        On Error Resume Next
        Dim Ap As Integer
        Ap = Bp.Find(TitleName, FindTxt)
        If Ap > -1 Then
            BindGotoFind = True
        Else
            BindGotoFind = False
        End If

        If BindGotoFind = True Then Bp.Position = Ap
        ComRow = Ap
        If ComRow > -1 Then
            If TypeOf (SELETGRID) Is DataGrid Then
                SELETGRID.Select(ComRow)
            ElseIf TypeOf (SELETGRID) Is DataGridView Then
                SELETGRID.Rows(ComRow).Selected()
            End If
        End If
    End Function
    Public Function DelItemsFromList_Split(ByVal Lst As Object, ByVal Txt As String, Optional ByVal Key As String = ",")
        Dim IxoQ As Integer
        Dim Lplst As Array
        Lplst = Txt.Split(Key)
        For IxoQ = 0 To Lplst.GetUpperBound(0)
            If Me.FindInObjectAndSelect(Lst, Lplst.GetValue(IxoQ), True, False, False) = True Then
                Lst.Items.Remove(CInt(Lplst.GetValue(IxoQ)))
            End If
        Next

    End Function
    Public Function BindFindTxT(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String, ByVal Column As String) As Boolean
        Dim Ap As Integer
        'Dim Nmp As DataTable
        Dim Dset As DataSet = Bp.DataSource
        Dim TableName As String = Bp.DataMember
        Ap = Bp.Find(TitleName, FindTxt)
        If Ap > -1 Then
            BindFindTxT = True
        Else
            BindFindTxT = False
        End If
        If BindFindTxT = True Then
            WGeT = Dset.Tables(TableName).Rows(Ap).Item(Column).ToString
        End If
        ComRow = Ap
    End Function
    Public Function DataSetFindTxT(ByVal TitleName As String, ByVal FindTxt As String, ByVal DSet As DataSet, ByVal TableName As String, ByVal ColumnNum As Integer) As Boolean
        Dim Ap As Integer
        'Dim Nmp As DataTable
        Dim Bnp As New BindingSource
        Bnp.DataSource = DSet
        Bnp.DataMember = TableName
        Ap = Bnp.Find(TitleName, FindTxt)
        If Ap > -1 Then
            DataSetFindTxT = True
        Else
            DataSetFindTxT = False
        End If

        If DataSetFindTxT = True Then
            WGeT = DSet.Tables(TableName).Rows(Ap).Item(ColumnNum).ToString
        End If
        ComRow = Ap
    End Function
    Public Function Bind_WithFilter_AddWith(ByVal Bp As BindingSource, ByVal NewFilter As String, Optional ByVal WithFilter As Boolean = False, Optional ByVal ExecuteFilter As Boolean = True, Optional ByVal Operator_Out As Boolean = True, Optional ByVal WithFilterJoin As String = "AND", Optional ByVal EXTRA_QUERY As String = "") As String
        'MsgBox(WithFilterJoin)
        Dim Str1 As String = ""
        If Bp Is Nothing Then Bind_WithFilter_AddWith = NewFilter : Exit Function
        If WithFilter = True Then
            If Bp.Filter IsNot Nothing Then Str1 = Bp.Filter.ToString Else Str1 = "" : GoTo FINXa
            If InStr(Str1, NewFilter, CompareMethod.Text) = 0 Then
                If Operator_Out = True Then Bind_WithFilter_AddWith = "(" & Str1 & ") " & WithFilterJoin & " (" & NewFilter & ")" Else Bind_WithFilter_AddWith = Str1 & " " & WithFilterJoin & " " & NewFilter
                BSql = Bind_WithFilter_AddWith
            Else
                Bind_WithFilter_AddWith = Str1
                BFil = UCase(Bind_WithFilter_AddWith)
                BSql = BFil
                Exit Function
            End If
        Else
FINXa:      Bind_WithFilter_AddWith = NewFilter
        End If
        Bind_WithFilter_AddWith = UCase(Bind_WithFilter_AddWith)
        'MsgBox(Bind_WithFilter_AddWith)
        BFil = Bind_WithFilter_AddWith
        BSql = BFil & EXTRA_QUERY
        If ExecuteFilter = True Then
            Try
                Bp.Filter = BFil
            Catch ex As Exception
                Epx(BFil)
            End Try
        End If
    End Function
    Public Function BindFilter_Nulls_only(ByVal Bp As BindingSource, ByVal Title As String, Optional ByVal FilterEnable As Boolean = True, Optional ByVal Null As Boolean = True, Optional ByVal WithFilter As Boolean = False, Optional ByVal EXTRA_QUERY As String = "") As Boolean
        Dim Str1 As String
        If Null = True Then
            Str1 = "([" & Title & "] IS NULL)"
        Else
            Str1 = "([" & Title & "] IS NOT NULL)"
        End If
        Str1 = Str1.ToUpper & EXTRA_QUERY
        BFil = Bind_WithFilter_AddWith(Bp, Str1, WithFilter, False)
        'BFil = BindFilter_Nulls_only
        If FilterEnable = True Then
            Try
                Bp.Filter = BFil
            Catch ex As Exception
                Epx(BFil)
            End Try
        End If
    End Function
    Public Function BindFilter(ByVal Bp As BindingSource, ByVal Tab As Object, Optional ByVal FindTxt As String = "", Optional ByVal Func As Integer = 0, Optional ByVal withFilter As Boolean = False, Optional ByVal Sign As String = "=", Optional ByVal WithFilterJoin_With As String = "AND", Optional ByVal Execute As Boolean = True, Optional ByVal ETRA_ADD_QUERY As String = "") As String
        Dim Str As String = Nothing
        Dim T As DataTable = Me.Get_DataSystemObj(Bp)
        Tab = SoftIn.GetTableColumn_NameString(T, Tab)
        If FindTxt = "" And Sign = "=" Then BindFilter = Me.BindFilter_Nulls_only(Bp, Tab, Execute, True, withFilter, ETRA_ADD_QUERY) : Exit Function
        If FindTxt = "" And Sign = "<>" Then BindFilter = Me.BindFilter_Nulls_only(Bp, Tab, Execute, False, withFilter, ETRA_ADD_QUERY) : Exit Function
        Str = SoftIn.GetFunction_QrText(T, Tab, FindTxt, Func, Sign) & ETRA_ADD_QUERY
        BindFilter = AukF.Bind_WithFilter_AddWith(Bp, Str, withFilter, Execute, False, WithFilterJoin_With)
        BSql = BindFilter
    End Function

    Public Function BindFilter_BSql(ByVal Bp As BindingSource, ByVal BsqlX_ As String, Optional ByVal Func As Integer = 0, Optional ByVal withFilter As Boolean = False, Optional ByVal Sign As String = "=", Optional ByVal WithFilterJoin_With As String = "AND", Optional ByVal Execute As Boolean = True, Optional ByVal ETRA_ADD_QUERY As String = "") As String
        Str1 = BsqlX_ & ETRA_ADD_QUERY
        BindFilter_BSql = AukF.Bind_WithFilter_AddWith(Bp, Str1, withFilter, Execute, False, WithFilterJoin_With)
        BSql = BindFilter_BSql
    End Function
    Public Function BindFilter_ExecuteTable(ByVal Bp As BindingSource, ByVal Tab As Object, Optional ByVal FindTxt As String = "", Optional ByVal ClrDb As Boolean = False, Optional ByVal Func As Integer = 0, Optional ByVal Sign As String = "=", Optional ByVal Start As Integer = 0, Optional ByVal Max As Integer = -1, Optional ByVal ExecuteBp As Boolean = True, Optional ByVal withFilter As Boolean = False, Optional ByVal Join As String = "AND") As String
        BindFilter(Bp, Tab, FindTxt, Func, withFilter, Sign, Join, ExecuteBp)
        Me.DataSetFilter_B(Bp, BSql, ClrDb, False, "*", False, Max, Start)
    End Function
    Public Function Bind_ExecuteTable(ByVal Bp As BindingSource, ByVal Tab As Object, Optional ByVal FindTxt As String = "", Optional ByVal ClrDb As Boolean = False, Optional ByVal Func As Integer = 0, Optional ByVal Sign As String = "=", Optional ByVal Start As Integer = 0, Optional ByVal Max As Integer = -1, Optional ByVal ExecuteBp As Boolean = False, Optional ByVal withFilter As Boolean = False, Optional ByVal Join As String = "AND") As String
        BindFilter(Bp, Tab, FindTxt, Func, withFilter, Sign, Join, ExecuteBp)
        'Me.DataSetFilter(Bp, ClrDb, False, "*", False, Max, Start)
    End Function
    Public Function BindFilter_GetString(ByVal Bp As BindingSource, ByVal Tab As Object, Optional ByVal FindTxt As String = "", Optional ByVal Func As Integer = 0, Optional ByVal withFilter As Boolean = False, Optional ByVal Sign As String = "=", Optional ByVal WithFilterJoin_With As String = "AND") As String
        Dim Str As String = Nothing
        Dim T As DataTable = Me.Get_DataSystemObj(Bp)
        Tab = SoftIn.GetTableColumn_NameString(T, Tab)
        If FindTxt = "" And Sign = "=" Then BindFilter_GetString = Me.BindFilter_Nulls_only(Bp, Tab, False, True, withFilter) : Exit Function
        If FindTxt = "" And Sign = "<>" Then BindFilter_GetString = Me.BindFilter_Nulls_only(Bp, Tab, False, False, withFilter) : Exit Function
        Str = SoftIn.GetFunction_QrText(T, Tab, FindTxt, Func, Sign)
        BindFilter_GetString = AukF.Bind_WithFilter_AddWith(Bp, Str, withFilter, Execute, False, WithFilterJoin_With)
        BSql = BindFilter_GetString
    End Function
    Public Function BindFilter(ByVal Bp As BindingSource, ByVal ArrayQuerys As Array, Optional ByVal withFilter As Boolean = False, Optional ByVal Sign As String = "=", Optional ByVal Execute As Boolean = True, Optional ByVal WithFilterJoin_With As String = "AND") As String
        Dim Str As String = ADSRC.Query_Arrays_Add(ArrayQuerys, True)
        Return AukF.Bind_WithFilter_AddWith(Bp, Str, withFilter, Execute, False, WithFilterJoin_With)
    End Function

    Public Function DataSetFilter(ByVal Bp As BindingSource, Optional ByVal clearBeforeFill As Boolean = False, Optional ByVal FillNullOpen As Boolean = False, Optional ByVal OpenTitles As String = "*", Optional ByVal BindingSourceRemoveFilter As Boolean = False, Optional ByVal MaxLoad As Integer = -1, Optional ByVal STart As Integer = 0, Optional ByVal OrderBy As String = "", Optional ByVal GroupBy As Boolean = False)
        Dim Fil As String
        Dim T As DataTable = AukF.Get_DataSystemObj(Bp)
        Dim TabN As String = T.TableName
        If Bp.Filter IsNot Nothing Then Fil = Bp.Filter.ToUpper Else Fil = ""
        BSql = Fil
        If OpenTitles <> "*" Then OpenTitles = SoftIn.Replace_Database_FieldsNamesByNumber(T, OpenTitles, True)
        If clearBeforeFill = True Then T.Clear()
        If STart = -1 And MaxLoad > -1 Then
            Try
                STart = T.Compute("Count([" & T.Columns(0).ColumnName.ToString & "])", BSql)
            Catch ex As Exception
                STart = 0
            End Try
        End If
        If Fil.Trim <> "" Then Sql = UCase(SoftIn.Sql_Convert_For_Adp(T, Fil, OpenTitles, Not FillNullOpen, OrderBy, GroupBy))
        If Sql <> "" Then
            Sql = Me.Sql_Expression(Sql, T, "", clearBeforeFill, MaxLoad, STart, BSql)
        End If
        If BindingSourceRemoveFilter = True Then Bp.RemoveFilter()
    End Function
    Public Function DataSetFilter_B(ByVal Bp As BindingSource, Optional ByVal BSqlX As String = "", Optional ByVal clearBeforeFill As Boolean = False, Optional ByVal FillNullOpen As Boolean = False, Optional ByVal OpenTitles As String = "*", Optional ByVal BindingSourceRemoveFilter As Boolean = False, Optional ByVal MaxLoad As Integer = -1, Optional ByVal STart As Integer = 0)
        Dim Fil As String
        Dim T As DataTable = AukF.Get_DataSystemObj(Bp)
        Dim TabN As String = T.TableName
        'If Bp.Filter IsNot Nothing Then Fil = Bp.Filter.ToUpper Else Fil = BSqlX
        If BSqlX = "" Then
            If Bp.Filter IsNot Nothing Then Fil = Bp.Filter.ToUpper
        Else
            Fil = BSqlX
        End If
        BSql = Fil 'Start =-1 command auto gen in sqlexpression
        If OpenTitles <> "*" Then OpenTitles = SoftIn.Replace_Database_FieldsNamesByNumber(T, OpenTitles, True)
        If clearBeforeFill = True Then T.Clear()
        If Fil.Trim <> "" Then Sql = UCase(SoftIn.Sql_Convert_For_Adp(T, Fil, OpenTitles, Not FillNullOpen, OrdTableName, False))
        If Sql <> "" Then
            Sql = Me.Sql_Expression(Sql, T, "", clearBeforeFill, MaxLoad, STart, BSql)
        End If
        If BindingSourceRemoveFilter = True Then Bp.RemoveFilter()
    End Function
    Public Function FindTxt(ByVal txt As String, ByVal FndTxt As String, Optional ByVal MatchCase As Boolean = False) As Boolean
        If MatchCase = True Then
            q = InStr(txt, FndTxt)
        Else
            q = InStr(txt, FndTxt, CompareMethod.Text)
        End If
        If q = 0 Then
            FindTxt = False
        Else
            FindTxt = True
        End If
    End Function
    Public Function InsPro(ByVal Prb As ProgressBar, ByVal UpNum As String)
        If (Prb.Value + Val(UpNum)) >= Prb.Maximum Then
            Prb.Value = Prb.Maximum
        Else
            Prb.Value = Prb.Value + Val(UpNum)
        End If
    End Function
    Public Function InsPro(ByVal Prb As ToolStripProgressBar, ByVal UpNum As String)
        If (Prb.Value + Val(UpNum)) >= Prb.Maximum Then
            Prb.Value = Prb.Maximum
        Else
            Prb.Value = Prb.Value + Val(UpNum)
        End If
    End Function
    Public Function ShowObj(ByVal obj As Object)
        q = obj.GetType
        If InStr(q, "Context") <> 0 Or InStr(q, "form") <> 0 Or InStr(q, "menu") <> 0 Then
            xd = Windows.Forms.Cursor.Position.X
            yd = Windows.Forms.Cursor.Position.Y
            If xd <> 0 And yd <> 0 Then
                obj.show(xd, yd)
            End If
        End If
    End Function
    Public Function LstDeleteandSelect(ByVal lst As ListBox, ByVal Del As Integer)
        On Error Resume Next
        chq = lst.Items.Count
        If lst.Items.Count > 0 Then
            If Del > -1 Then
                lst.Items.RemoveAt(Del)
            End If
            If (chq - 1) >= Del Then
                lst.SelectedIndex = Del
            Else
                If (lst.Items.Count > 0) And (Del >= 2) Then
                    lst.SelectedIndex = Del - 2
                End If

            End If
        End If
    End Function
    Public Function LstDeleteSelAllItems(ByVal Lst As ListBox)
        Dim Dlin As String
        On Error Resume Next
        For PrVI = (Lst.SelectedItems.Count - 1) To 0 Step -1
            Dlin = Lst.SelectedItems.Item(PrVI).ToString
            Lst.Items.Remove(Dlin)
        Next
    End Function
    Public Function LstCopyAllSelected(ByVal CopyFromLst As Object, ByVal PasteIn As Object, ByVal Unique As Boolean)
        On Error Resume Next
        For PrVI = 0 To CopyFromLst.SelectedItems.Count - 1
            If Unique = True Then
                Me.UniqueAdd(PasteIn, CopyFromLst.SelectedIndices.Item(PrVI).ToString)
            Else
                PasteIn.Items.Add(CopyFromLst.SelectedIndices.Item(PrVI).ToString)

            End If
        Next
    End Function
    Public Function AddComboToAnother(ByVal Com As Object, ByVal Com2 As Object)
        For PrVI = 0 To Com.Items.Count - 1
            Me.UniqueAdd(Com2, Com.Items.Item(PrVI).ToString)
        Next
    End Function
    Public Function DelRecAll(ByVal TitleOFTable As String, ByVal mdw As BindingSource) As Boolean
        On Error Resume Next
        If MsgBox("Do you want to Delete all Records from " & TitleOFTable & "?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            On Error Resume Next
            DelRecAll = True
            de = mdw.Count - 1
            For PrVI = Val(de) To (0) Step -1
                On Error Resume Next

                mdw.RemoveAt(PrVI)
                mdw.EndEdit()
            Next
        Else
            DelRecAll = False
        End If
    End Function
    Public Function Grid_EntrySomething(ByVal Rx As DataGridViewRow, ByVal Column As Integer, Optional ByVal EntryStr As String = "", Optional ByVal EntryWith As Boolean = False, Optional ByVal EntryBefore As Boolean = False) As String
        Dim B As String = ""
        Dim Str As String = ""
        If EntryWith = False Then
            Str = EntryStr
        Else
            B = Rx.Cells(Column).Value.ToString
            If EntryBefore = True Then
                Str = EntryStr & B
            Else
                Str = B & EntryStr
            End If
        End If
        Rx.Cells(Column).Value = Str
    End Function
    Public Function Grid_View_Advance_SetCommonItems(ByVal D As DataGridView, ByVal Columns As String, ByVal Entry As String, Optional ByVal TrueFalseTxt As String = "", Optional ByVal WithEntry As Boolean = False, Optional ByVal EnrtyBefore As Boolean = False, Optional ByVal AllRecords As Boolean = False, Optional ByVal Prog As ProgressBar = Nothing, Optional ByVal ProgVisibleOpt As Boolean = False, Optional ByVal SetVisible_Opt As Boolean = False)
        'Dim AQ, Inty, Aq2 As Integer
        'Dim P1, P2 As String
        Dim Lst As Array
        Dim Lst2() As String
        Dim Lst3() As String
        Dim Cnt As Integer = 0
        Dim TrF As Boolean
        Dim OCan As Boolean = False
        If Entry.Trim <> "" Then
            Lst = Split(Entry, ",")
        End If
        If Columns.Trim <> "" Then
            Lst2 = Split(Columns, ",")
        End If
        If TrueFalseTxt.Trim <> "" Then
            TrF = True
            Lst3 = Split(TrueFalseTxt, ",")
            Array.Resize(Lst3, CInt(Lst.GetUpperBound(0).ToString) + 1)
        Else
            TrF = False
        End If
        If Prog IsNot Nothing Then
            mx = Prog.Maximum
            If AllRecords = False Then Prog.Maximum = D.SelectedRows.Count Else Prog.Maximum = D.RowCount
            If ProgVisibleOpt = True Then Prog.Visible = True
            Prog.Value = 0
        End If
        If SetVisible_Opt = True Then D.Visible = False
        If AllRecords = False Then Cnt = D.SelectedRows.Count - 1 Else Cnt = D.RowCount - 1
        For k As Integer = 0 To Cnt
            'lst entry
            'lst2 columns
            'lst3 true false is that check or not
            For Im As Integer = 0 To Lst.GetUpperBound(0)
                If TrF = True Then
                    xc = ArV2(Lst3, Im, "False")
                    If Me.CheckVal_GetBool(xc) = True Then OCan = True Else OCan = False
                Else
                    OCan = True
                End If
                If OCan = True Then
                    If AllRecords = False Then
                        Grid_EntrySomething(D.SelectedRows.Item(k), CInt(Lst2.GetValue(Im)), CStr(Lst.GetValue(Im)), WithEntry, EnrtyBefore)
                    Else
                        Grid_EntrySomething(D.Rows(k), CInt(Lst2.GetValue(Im)), CStr(Lst.GetValue(Im)), WithEntry, EnrtyBefore)
                    End If
                End If
            Next
        Next
        If Prog IsNot Nothing Then
            Prog.Maximum = mx
            If ProgVisibleOpt = True Then
                Prog.Visible = False
            End If
            Prog.Value = 0
        End If
        If SetVisible_Opt = True Then D.Visible = True
    End Function
    Public Function CheckVal_GetBool(ByVal Str As String) As Boolean
        If InStr(Str, "check", CompareMethod.Text) > 0 Or InStr(Str, "tr", CompareMethod.Text) > 0 Or InStr(Str, "yes", CompareMethod.Text) > 0 Or Val(Str) = 1 Or UCase(Str) = "TRUE" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function Sql_Expression(ByVal SqlExp As String, ByVal Dbt As Object, Optional ByVal TableName As String = "", Optional ByVal ClrDb As Boolean = True, Optional ByVal MaxLoad As Integer = -1, Optional ByVal StartFrm As Integer = 0, Optional ByVal BsqlX As String = "")
        If ConPro = "oledb" Then
            OleDb_SqlGen(SqlExp, Dbt, TableName, ClrDb, MaxLoad, StartFrm, BsqlX)
        Else
            MsgBox("NO Set ", MsgBoxStyle.Critical)
        End If
    End Function

    Public Function OleDb_SqlGen(ByVal SqlExp As String, ByVal Dbt As Object, Optional ByVal TableName As String = "", Optional ByVal ClrDb As Boolean = True, Optional ByVal MaxLoad As Integer = -1, Optional ByVal StartFrm As Integer = 0, Optional ByVal BsqlX As String = "")
        Dim T As DataTable = Me.Get_DataSystemObj(Dbt, TableName)
        If StartFrm = -1 And ClrDb = False Then
            Try
                StartFrm = T.Compute("COUNT([" & T.Columns(0).ColumnName.ToString & "])", BsqlX)
            Catch ex As Exception
                StartFrm = 0
            End Try
        End If
        'MsgBox(StartFrm)
        Sql = SqlExp
        Try
            Adp = New OleDb.OleDbDataAdapter(SqlExp, Cn)
            If TypeOf (T) Is DataTable Then
                If ClrDb = True Then T.Clear()
                If MaxLoad > 0 Then Adp.Fill(StartFrm, MaxLoad, T) Else Adp.Fill(T)
            Else
                MsgBox("No Type Match with AukCommands... ", MsgBoxStyle.Critical)
                Exit Function
            End If
        Catch ex As Exception
            If Q_ERRORMSG = True Then Epx(SqlExp)

        End Try
    End Function
    Public Function OleDb_SqlGen(ByVal Conn1 As String, ByVal SqlExp As String, ByVal Dbt As Object, Optional ByVal TableName As String = "", Optional ByVal ClrDb As Boolean = True, Optional ByVal MaxLoad As Integer = -1, Optional ByVal StartFrm As Integer = 0)
        Dim T As DataTable = Me.Get_DataSystemObj(Dbt, TableName)
        'If T Is Nothing Then Exit Function
        Sql = SqlExp
        Dim Cnx11 As New OleDb.OleDbConnection(Conn1)
        'Try
        Adp = New OleDb.OleDbDataAdapter(SqlExp, Cnx11)
        If TypeOf (T) Is DataTable Then
            If ClrDb = True Then T.Clear()
            If MaxLoad > 0 Then Adp.Fill(StartFrm, MaxLoad, T) Else Adp.Fill(T)
        Else
            MsgBox("No Type Match with AukCommands... ", MsgBoxStyle.Critical)
            Exit Function
        End If
        'Catch ex As Exception
        '    Epx(SqlExp)
        'End Try
    End Function
    'Public Function BindFilter_BetweenOparetor(ByVal Bp As BindingSource, ByVal D_Field As String, ByVal FindTxt As String, Optional ByVal NotOparetor As Boolean = False, Optional ByVal WithFilter As Boolean = False, Optional ByVal SetInDatatable As Boolean = False, Optional ByVal ClrBefore As Boolean = True, Optional ByVal BindingFilter As Boolean = True, Optional ByVal OrdFields As String = "", Optional ByVal OpenTitles As String = "*") As String
    '    Dim T As DataTable = Me.Get_DataSystemObj(Bp)
    '    'Dim Lst As Array
    'End Function
    Public Function BindFilter_BetweenOparetorN(ByVal Db As Object, ByVal Tab As Object, Optional ByVal FindTxt1 As String = "", Optional ByVal FindTxt2 As String = "", Optional ByVal NotOparetor As Boolean = False, Optional ByVal WithFilter As Boolean = False, Optional ByVal SetInDatatable As Boolean = True, Optional ByVal ClrBefore As Boolean = False, Optional ByVal Start As Integer = 0, Optional ByVal Limit As Integer = 100)
        Dim Sign As String = "="
        Dim FindText As String = FindTxt1 & "," & FindTxt2
        If NotOparetor = True Then Sign = "<>"
        Dim T As DataTable = AukF.Get_DataSystemObj(Db)
        BSql = SoftIn.GetFunction_QrText(T, Tab, FindText, 10, Sign, False, ",")
        SoftIn.Sql_Convert_For_Adp(T, BSql)
        AukF.Sql_Expression(Sql, T, "", ClrBefore)
        'MsgBox(Sql)
        'If SetInDatatable = True Then
        '    Me.DataSetFilter(Db, ClrBefore, False, "*", False, Limit, Start)
        'End If
    End Function
    Public Function Advance_Search(ByVal TxtGraps As String, ByVal WhichFieldx As Object, ByVal Dbt As Object, Optional ByVal Join As String = "And", Optional ByVal Key As String = " ", Optional ByVal NotUseKey_Split_By_CharArray As Boolean = False, Optional ByVal Fi1 As String = "%", Optional ByVal Fi2 As String = "%", Optional ByVal NotOpt As Boolean = False, Optional ByVal Sign As String = "=", Optional ByVal LikeOptUse As Boolean = True, Optional ByVal SecondKey As String = "")
        On Error Resume Next
        Dim Aq As Integer
        Dim Tnam As String
        Dim T As DataTable = Me.Get_DataSystemObj(Dbt)
        Dim Ua, Ua2 As Array
        Dim Lx As String
        Dim Str As String = Nothing
        Dim Str2 As String = Nothing
        Dim K As Integer
        If NotUseKey_Split_By_CharArray = True Then
            TxtGraps = TxtGraps.Trim.Replace(" ", "")
            Ua = TxtGraps.ToCharArray
        Else
            If SecondKey = "" Then Ua = TxtGraps.Split(Key) Else Ua = TxtGraps.Split(SecondKey)
        End If
        'If Sign = "<>" Then NotOpt = True
        If LikeOptUse = True Then
            Lx = " Like "
            If NotOpt = True Or Sign = "<>" Then
                Lx = "Not" & Lx
            End If
        Else
            Lx = Sign
            If NotOpt = True Then
                Lx = "<>"
            End If
        End If
        Tnam = SoftIn.GetTableColumn_NameString(T, WhichFieldx)
        'SoftIn.Get_DataType_Str(T, Tnam)
        For Aq = 0 To Ua.GetUpperBound(0)
            If Ua.GetValue(Aq).ToString <> "" Then
                If SecondKey = "" Then
                    If Str = "" Then
                        Str = "[" & Tnam & "]" & Lx & "'" & Fi1 & Ua.GetValue(Aq) & Fi2 & "'"
                    Else
                        d = "[" & Tnam & "]" & Lx & "'" & Fi1 & Ua.GetValue(Aq) & Fi2 & "'"
                        If InStr(Str, d, CompareMethod.Text) = 0 Then
                            Str = Str & " " & Join & " " & "[" & Tnam & "]" & Lx & "'" & Fi1 & Ua.GetValue(Aq) & Fi2 & "'"
                        End If
                    End If
                Else
                    Ua2 = ArV(Ua, Aq, " ")
                    For K = 0 To Ua2.GetUpperBound(0)
                        If Ua2.GetValue(K).ToString <> "" Then
                            a = "[" & Tnam & "]" & Lx & "'" & Fi1 & Ua2.GetValue(K) & Fi2 & "'"
                            If Str2 = Nothing Or Str2 = "" Then
                                Str2 = a
                            ElseIf Str2 <> "" Then
                                dq = InStr(Str2, a, CompareMethod.Text)
                                If dq = 0 Then
                                    Str2 = Str2 & " " & Join & " " & a
                                End If
                            End If
                        End If
                    Next
                    If Join.ToLower = "and" Then join2 = "or" Else join2 = "and"
                    If InStr(Str, Str2, CompareMethod.Text) = 0 Then
                        If Str = "" Then
                            Str = "(" & Str2 & ")"
                        Else
                            Str &= " " & Join2 & " (" & Str2 & ")"

                        End If
                    End If
                    Str2 = ""
                End If
            End If
        Next
        If Str.Trim <> "" Then
            Str = "(" & Str & ")"
            Advance_Search = Str
            WGeT = Str
        Else
            Str = ""
            Advance_Search = Str
            WGeT = Str
        End If
        BSql = Advance_Search

    End Function
    Public Function Grid_View_SetCommonItems(ByVal D As DataGridView, ByVal InputText As String, ByVal Columns As String, Optional ByVal AllRecords As Boolean = False, Optional ByVal Prog As ProgressBar = Nothing, Optional ByVal ProgVisibleOpt As Boolean = False, Optional ByVal SetVisible_Opt As Boolean = False)
        Dim AQ, Inty As Integer
        If Prog IsNot Nothing Then
            mx = Prog.Maximum
            If AllRecords = False Then
                Prog.Maximum = D.SelectedRows.Count
            Else
                Prog.Maximum = D.RowCount
            End If
            If ProgVisibleOpt = True Then
                Prog.Visible = True
            End If
            Prog.Value = 0
        End If
        'MsgBox(D.SelectedRows.Count)

        If SetVisible_Opt = True Then D.Visible = False
        If AllRecords = False Then
            For AQ = 0 To D.SelectedRows.Count - 1
                Inty = D.SelectedRows.Item(AQ).Index.ToString
                D.SelectedRows.Item(AQ).DataGridView(CInt(Columns), Inty).Value = InputText
                If Prog IsNot Nothing Then
                    Me.InsPro(Prog, 1)
                End If
            Next
        Else
            For AQ = 0 To D.RowCount - 1
                D.CurrentCell.DataGridView(CInt(Columns), AQ).Value = InputText
                If Prog IsNot Nothing Then
                    Me.InsPro(Prog, 1)
                End If
            Next
        End If
        If Prog IsNot Nothing Then
            'mx = Prog.Maximum
            Prog.Maximum = mx
            If ProgVisibleOpt = True Then
                Prog.Visible = False
            End If
            Prog.Value = 0
        End If
        If SetVisible_Opt = True Then D.Visible = True
    End Function

    Public Function DivideIn_To_2(ByVal Str As String, ByVal Find As String, Optional ByVal MathCh As Boolean = False, Optional ByVal A1 As Object = Nothing = Nothing, Optional ByVal A2 As String = Nothing) As String
        If MathCh = False Then dex = InStr((Str), (Find), CompareMethod.Text) Else dex = InStr(Str, Find)
        If dex <> 0 Then
            DivideIn_To_2 = Str.Substring(0, dex - 1)
            If A1 IsNot Nothing Then
                A1 = DivideIn_To_2
            End If
            QA1 = DivideIn_To_2
            'MsgBox(QA1)
            QA2 = Mid(Str, dex + Find.Length, Len(Str))
            If A2 IsNot Nothing Then A2 = QA2
        Else
            QA2 = ""
            QA1 = ""
            DivideIn_To_2 = ""
            If A2 IsNot Nothing Then A2 = ""
            If A1 IsNot Nothing Then A1 = ""
        End If
    End Function
    Public Function DeleteWholeTableRecords(ByVal Bp As BindingSource, Optional ByVal Msg As Boolean = False, Optional ByVal MsgTxt As String = "", Optional ByVal TableName As String = "", Optional ByVal BeforeDel_RemoveFilter As Boolean = False)
        Dim TbTl As String
        Dim DlInt As Integer
        Dim T As DataTable = Me.Get_DataSystemObj(Bp)
        If TableName <> "" Then
            TbTl = T.TableName
        End If
        'TbTl
        If BeforeDel_RemoveFilter = True Then Bp.RemoveFilter()

        If Bp.Count > 0 Then
            If Msg = True Then
                If MsgTxt = "" Then
                    If MsgBox("Do you want to Delete all Records from " & TbTl & "?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        GoTo DoJob
                    End If
                Else
                    If MsgBox(MsgTxt, MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        GoTo DoJob
                    End If
                End If
            Else
                GoTo DoJob

            End If
        Else
            Exit Function

        End If

        Exit Function

DoJob:
        If Bp.Count > 0 Then
            For DlInt = 0 To Bp.Count - 1
                Try
                    Bp.RemoveAt(DlInt)
                    Bp.EndEdit()
                Catch ex As Exception
                    Epx()
                End Try
            Next
        End If
    End Function
    Public Function MsgTr(ByVal Msgtxt As String, Optional ByVal USE_WHAT As Boolean = False, Optional ByVal MSGSTYLE As MsgBoxStyle = MsgBoxStyle.Information, Optional ByVal MSTITLE As String = Nothing) As Boolean
        If USE_WHAT = True Then Msgtxt = What & Msgtxt
        If MsgBox(Msgtxt, MSGSTYLE + MsgBoxStyle.YesNo, MSTITLE) = MsgBoxResult.Yes Then MsgTr = True Else MsgTr = False
    End Function
    Public Function MsgTrU(ByVal Msgtxt As String, Optional ByVal USE_WHAT As Boolean = False, Optional ByVal MSGSTYLE As MsgBoxStyle = MsgBoxStyle.Information, Optional ByVal MSTITLE As String = Nothing) As Boolean
        If USE_WHAT = True Then Msgtxt = What.ToUpper & Msgtxt
        If MsgBox(Msgtxt, MSGSTYLE + MsgBoxStyle.YesNo, MSTITLE) = MsgBoxResult.Yes Then MsgTrU = True Else MsgTrU = False
    End Function
    Public Function ComSelIndex(ByVal com As Object)
        If com.SelectedIndex = -1 Then

            If com.Items.Count > 0 Then
                com.SelectedIndex = 0
            End If
        End If
    End Function
    Public Function GivePoints2(ByVal Num As String, ByVal Digit As String) As String
        cf = Val(Num)
        Digit = Val(Digit) + 1
        gh = InStr(cf, ".")
        If gh > 0 Then
            gt = Mid(cf, 1, gh - 1)
            g = Mid(cf, gh + 1, Digit)
            m = Val(gt) & "." + Val(g)
            ewq = Replace(cf, m, "")
            dws = Mid(ewq, 1, 1)
            If dws >= 5 Then
                Mid(g, Len(g), 1) = Val(Mid(g, Len(g), 1)) + 1
            End If
            gt = Val(gt) & "." & Val(g)
        Else
            gt = cf
        End If
        GivePoints2 = Val(gt)
    End Function
    Public Function InPText(ByVal TextBoxName As TextBox) As Boolean
        If Trim(TextBoxName.Text) = "" Then
            TextBoxName.Text = TextI
            InPText = True
        Else
            InPText = False
        End If
    End Function
    Public Function InPText(ByVal TextBoxName As TextBox, ByVal TextI As String) As Boolean
        If Trim(TextBoxName.Text) = "" Then
            TextBoxName.Text = TextI
            InPText = True
        Else
            InPText = False
        End If
    End Function
    Public Function ComboFind(ByVal Cause1Combo As ComboBox, ByVal CauseTextBox As String)
        m = Cause1Combo.FindStringExact(CauseTextBox)
        If m > -1 Then
            Cause1Combo.SelectedIndex = m
        End If
    End Function
    Public Function ComboFind(ByVal Cause1Combo As ComboBox, ByVal CauseTextBox As String, ByVal NotFindSelectFirst As Boolean)
        If NotFindSelectFirst = True Then
            m = Cause1Combo.FindStringExact(CauseTextBox)
            If m > -1 Then
                Cause1Combo.SelectedIndex = m
            Else
                Cause1Combo.SelectedIndex = 0

            End If
        Else
            m = Cause1Combo.FindStringExact(CauseTextBox)
            If m > -1 Then
                Cause1Combo.SelectedIndex = m
            End If
        End If
    End Function
    Public Function MaxCountNumListBox(ByVal L As ListBox, ByVal L2 As ListBox, ByVal L3 As ListBox)
        Dim Nm As Decimal
        If L.Items.Count > L2.Items.Count Then
            Nm = L.Items.Count
        ElseIf L.Items.Count < L2.Items.Count Then
            Nm = L2.Items.Count
        Else
            Nm = L2.Items.Count
        End If
        If Nm < L3.Items.Count Then
            Nm = L3.Items.Count
        End If
        MaxCountNumListBox = Nm
        WGeT = MaxCountNumListBox
    End Function
    Public Function FindInObjectAndSelect(ByVal Cause1Combo As Object, ByVal CauseTextBox As Object, Optional ByVal Exact As Boolean = True, Optional ByVal NotFoundSelFirst As Boolean = False, Optional ByVal GotoPos As Boolean = False, Optional ByVal START As Integer = 0) As Boolean
        'IF TYPE OF(Cause1Combo
        If TypeOf (CauseTextBox) Is String Then
            caukq = CauseTextBox.ToString
        Else
            Try
                caukq = CauseTextBox.text
            Catch ex As Exception
                caukq = CauseTextBox.ToString
            End Try
        End If
        If Exact = True Then
            m = Cause1Combo.FindStringExact(caukq, START)
        Else
            m = Cause1Combo.FindStringExact(caukq, START)
            If m = -1 Then m = Cause1Combo.FindString(caukq, START)
        End If
        ComRow = m
        If m > -1 Then
            If GotoPos = True Then Cause1Combo.SelectedIndex = m
            FindInObjectAndSelect = True
        Else
            If NotFoundSelFirst = True Then Cause1Combo.SelectedIndex = 0
            FindInObjectAndSelect = False
        End If
        ComRow = m
        'End If
    End Function
    Public Function UnMatchComboFind(ByVal Cause1Combo As Object, ByVal CauseTextBox As String, ByVal NotFindSelectFirst As Boolean)
        If NotFindSelectFirst = True Then
            m = Cause1Combo.FindString(CauseTextBox)
            If m > -1 Then
                Cause1Combo.SelectedIndex = m
            Else
                Cause1Combo.SelectedIndex = 0
            End If
        Else
            m = Cause1Combo.FindString(CauseTextBox)
            If m > -1 Then
                Cause1Combo.SelectedIndex = m
            End If
        End If
    End Function
    Public Function UniqueAdd(ByVal Lst As Object, ByVal Item As String) As Boolean
        c = Lst.FindStringExact(Item)
        If c = -1 Then
            UniqueAdd = True
        Else
            UniqueAdd = False
        End If
        If UniqueAdd = True Then
            Lst.Items.Add(Item)
        End If

    End Function
    Public Function XPAuk(ByRef Frm As System.Windows.Forms.Form) As Object
        Dim Y As Single
        Dim X As Single
        If VB6.PixelsToTwipsY(Frm.Height) < 615 Then Frm.Height = VB6.TwipsToPixelsY(615) 'Checks that form
        If VB6.PixelsToTwipsX(Frm.Width) < 1695 Then Frm.Width = VB6.TwipsToPixelsX(1695) 'is not too small
        X = VB6.PixelsToTwipsX(Frm.Width) / VB6.TwipsPerPixelX 'Registers the size of the
        Y = VB6.PixelsToTwipsY(Frm.Height) / VB6.TwipsPerPixelY 'form in pixels
        Sum = CreateRectRgn(5, 0, X - 5, 1)
        CombineRgn(Sum, Sum, CreateRectRgn(3, 1, X - 3, 2), 2)
        CombineRgn(Sum, Sum, CreateRectRgn(2, 2, X - 2, 3), 2)
        CombineRgn(Sum, Sum, CreateRectRgn(1, 3, X - 1, 4), 2)
        CombineRgn(Sum, Sum, CreateRectRgn(1, 4, X - 1, 5), 2)
        CombineRgn(Sum, Sum, CreateRectRgn(0, 5, X, Y), 2)
        SetWindowRgn(Frm.Handle.ToInt32, Sum, True)
    End Function
    Public Function DragAuk(ByRef M_frm As System.Windows.Forms.Form) As Object
        ReleaseCapture()
        SendMessage(M_frm.Handle.ToInt32, &HA1S, 2, 0)
    End Function
    Function OExe(ByRef filename As String, ByRef fx As System.Windows.Forms.Form) As Object
        ShellExecute(fx.Handle.ToInt32, "open", filename, "", "", 10)
    End Function




End Class
