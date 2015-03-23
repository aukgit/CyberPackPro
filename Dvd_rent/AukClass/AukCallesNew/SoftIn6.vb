Public Module SoftIn
    'Public MultiF As Form
    ''' <summary>
    ''' BpFind:Find Items From...
    ''' BpRp:Relation BindingSource ...
    ''' RColumn:Select Same Item what found in this Column...
    ''' FoundChk:If True then if found then Items Check Auto...
    ''' </summary>
    ''' <remarks></remarks>
    ''' <param name="BpFind"></param>
    ''' <param name="BpRp"></param>
    ''' <param name="RColumn"></param>
    ''' <param name="FoundChk"></param>
    ''' <param name="BeforeUnCheck"></param>
    ''' <returns></returns>
    ''' 
    Public RamP, RamV, RamT As Decimal
    Dim Iw As Integer
    Public Function NDate()
        Return CDate(Now.Date)
    End Function
    Public Function AukDateGet(ByVal Da1 As Date, Optional ByVal Key As String = ".") As String
        Return Da1.Day & Key & DateAndTime.MonthName(Da1.Month) & Key & Da1.Year
    End Function
    Public Function AukDateGet_monthOnly(ByVal Da1 As Date, Optional ByVal Key As String = ".") As String
        Return DateAndTime.MonthName(Da1.Month) & Key & Da1.Year
    End Function
    Public Function DateGet_System() As Date
        Return DateAndTime.DateString
    End Function
    Public Sub KeyDown_EffectOn_Combo(ByVal Com As Object, ByVal e As KeyEventArgs)
        If Com.Items.Count = 0 Then Exit Sub
        If e.Control = True Then
            If e.KeyCode = Keys.Right Then
                If (Com.Items.Count - 1) >= (Com.SelectedIndex + 1) Then
                    Com.SelectedIndex = Com.SelectedIndex + 1
                Else
                    Com.SelectedIndex = 0
                End If
            ElseIf e.KeyCode = Keys.Left Then
                If (Com.SelectedIndex - 1) >= 0 Then
                    Com.SelectedIndex = Com.SelectedIndex - 1
                Else
                    Com.SelectedIndex = Com.Items.Count - 1
                End If
            ElseIf e.KeyCode = Keys.Up Then
                Com.SelectedIndex = 0
            ElseIf e.KeyCode = Keys.Down Then
                Com.SelectedIndex = Com.Items.Count - 1
            End If
        End If
    End Sub
    Public Sub DataGridView_AutoMaticID_ByToken(ByVal D As DataGridView, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs, Optional ByVal ToKen As String = Nothing)
        On Error Resume Next
        If D(0, e.RowIndex).Value.ToString = "" Then
            If e.RowIndex = 0 Then
                'SoftIn.DataGrid_MasterID_ByDate(D)
                'Now editing Maximam Number input 
                Dim T As DataTable = AukF.Get_DataSystemObj(D)
                Dim Mn As Decimal
                Mn = ADSRC.MAXIMUM_VALUE(T.TableName.ToString, T)
                D(0, e.RowIndex).Value = Mn + 1
            Else
                If D(0, e.RowIndex - 1).Value.ToString <> "" Then
                    If IsNumeric(D(0, e.RowIndex - 1).Value.ToString) = True Then
                        D(0, e.RowIndex).Value = CDec(D(0, e.RowIndex - 1).Value.ToString) + 1
                    Else
                        NB1 = D(0, e.RowIndex - 1).Value.ToString
                        NA1 = NB1.Split(ToKen).GetValue(1).ToString
                        D(0, e.RowIndex).Value = NB1.Split(token).GetValue(0).ToString & ToKen & Val(NA1) + 1
                    End If
                End If
            End If
        End If
    End Sub
    Public Function Dat(ByVal D As String) As Date
        'Dim c As Date
        Try
            Return CDate(D)
        Catch ex As Exception
            Epx(D.ToString)
            Return Nothing
        End Try
    End Function
    'Public Sub GRID_PRESS_ON_COMBO(ByVal d As DataGridView, ByVal e As KeyEventArgs, ByVal Columns As String)
    '    'If TypeOf (d.Columns(d.CurrentCell.ColumnIndex).ValueType) Is DataGridViewComboBoxDisplayStyle Then
    '    On Error Resume Next
    '    Dim Ua As Array
    '    If e.KeyCode = Keys.Enter Then
    '        Ua = Columns.Split(",")
    '        If ArF(Ua, d.CurrentCell.ColumnIndex.ToString) = True Then
    '            'd.CurrentRow . = d.CurrentCell.RowIndex - 1
    '            SendKeys.Send("{F4}")
    '        End If
    '    End If

    '    'End If
    'End Sub
    Public Function Dat2(ByVal D As String, Optional ByVal Msg As Boolean = False) As Date
        Dim c As Date
        Try
            If IsDate(D) = True Then
                c = CDate(D)
                If c.Day <= 12 Then
                    c = Format(c, "dd-MMM-yyyy")
                Else
                    c = Format(c, "dd-MMM-yyyy")
                End If
                'MsgBox(c)
                Return c
            ElseIf IsNumeric(D) = True Then
                c = CSOFT.NumToDate(D)
                If c.Day <= 12 Then
                    c = Format(c, "dd-MMM-yyyy")
                Else
                    c = Format(c, "dd-MMM-yyyy")
                End If
                Return c
            Else
                If Msg = True Then
                    MsgBox("Please Type a Valid Date format to Convert.", MsgBoxStyle.Information)
                End If
            End If

        Catch ex As Exception
            Epx(D.ToString)
            Return Nothing
        End Try
    End Function

    Public Function Default_DataTable(ByVal T As DataTable)
        If T.Rows.Count > 0 Then
            Return T.Rows.Item(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Public Function OleDB_DataSource_Cnn(ByVal DBSource As String, Optional ByVal Password As String = Nothing)
        Dim contEr As String
        'Dim Ua As Array
        'Dim Count As Integer
        contEr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBSource & ";Persist Security Info=True;Jet OLEDB:Database Password=" & Password
        'MsgBox(DSource)
        OleDB_DataSource_Cnn = contEr
        DSource = OleDB_DataSource_Cnn
    End Function
    Public Function Convert_Hash_RND1(ByVal Str1 As String, Optional ByVal NumPlus As Integer = 0, Optional ByVal NumInto As Integer = 0, Optional ByVal Gethash_ByMadeIT_Double As Boolean = False, Optional ByVal maxD As Integer = 22, Optional ByVal GetCodeByCode As Boolean = False) As String
        If Str1 = Nothing Then Return "" : Exit Function
        Dim C, D, G As Decimal
        Dim H As Security.Cryptography.HashAlgorithm
        Dim HashBytes() As Byte
        Dim Uni As New System.Text.UnicodeEncoding
        H = New Security.Cryptography.HMACSHA512
        If NumPlus > 0 Then C = CDec(AukF.ConTOAsc(Str1, "+", NumPlus, True)) Else C = 0
        If NumInto > 0 Then D = CDec(AukF.ConTOAsc(Str1, "+", NumPlus, True)) Else D = 0
        G = C + D
        If G > 0 Then Str1 = Str1 & G
        If Gethash_ByMadeIT_Double = True Then Str1 = Str1 & Str1
        HashBytes = H.ComputeHash(Uni.GetBytes(Str1))
        Convert_Hash_RND1 = Left(Convert.ToBase64String(HashBytes).ToString, maxD)
        If GetCodeByCode = True Then
            Convert_Hash_RND1 = Convert_Hash_RND1 & Convert_Hash_RND1
            HashBytes = H.ComputeHash(Uni.GetBytes(Convert_Hash_RND1))
            Convert_Hash_RND1 = Left(Convert.ToBase64String(HashBytes).ToString, maxD)
        End If
    End Function
    Public Function Ram_Get_inf() As Decimal
        Ram_Get_inf = (My.Computer.Info.AvailablePhysicalMemory) / 1024 / 1024
        RamP = Ram_Get_inf
        RamV = (My.Computer.Info.AvailableVirtualMemory) / 1024 / 1024
        RamT = RamP + RamV
        tramp = (My.Computer.Info.TotalPhysicalMemory) / 1024 / 1024
        tramv = (My.Computer.Info.TotalVirtualMemory) / 1024 / 1024
        WGeT = "Your Total Ram(Physical Memory): " & tramp & ", Your Total Virtural Ram(Page File Memory): " & tramv & ", Total Memory : " & Val(tramp) + Val(tramv) & "." & vbCrLf
        WGeT += "Your Available Ram(Physical Memory): " & RamP & ", Your Available Virtural Ram(Page File Memory): " & RamV & ", Total Free Memory : " & RamT & "."
    End Function
    Public Function Ram_Get() As Decimal
        Ram_Get = (My.Computer.Info.AvailablePhysicalMemory) / 1024 / 1024
        RamP = Ram_Get
        RamV = (My.Computer.Info.AvailableVirtualMemory) / 1024 / 1024
        RamT = RamP + RamV
    End Function

    Public Function Convert_Hash_RND2(ByVal Str1 As String, Optional ByVal NumPlus As Integer = 0, Optional ByVal NumInto As Integer = 0, Optional ByVal Gethash_ByMadeIT_Double As Boolean = False, Optional ByVal maxD As Integer = 22, Optional ByVal GetCodeByCode As Boolean = False) As String
        If Str1 = Nothing Then Return "" : Exit Function
        Dim C, D, G As Decimal
        Dim H As Security.Cryptography.HashAlgorithm
        Dim HashBytes() As Byte
        Dim Uni As New System.Text.UnicodeEncoding
        H = New Security.Cryptography.MACTripleDES
        If NumPlus > 0 Then C = CDec(AukF.ConTOAsc(Str1, "+", NumPlus, True)) Else C = 0
        If NumInto > 0 Then D = CDec(AukF.ConTOAsc(Str1, "+", NumPlus, True)) Else D = 0
        G = C + D
        If G > 0 Then Str1 = Str1 & G
        If Gethash_ByMadeIT_Double = True Then Str1 = Str1 & Str1
        HashBytes = H.ComputeHash(Uni.GetBytes(Str1))
        Convert_Hash_RND2 = Left(Convert.ToBase64String(HashBytes).ToString, maxD)
        If GetCodeByCode = True Then
            Convert_Hash_RND2 = Convert_Hash_RND2 & Convert_Hash_RND2
            HashBytes = H.ComputeHash(Uni.GetBytes(Convert_Hash_RND2))
            Convert_Hash_RND2 = Left(Convert.ToBase64String(HashBytes).ToString, maxD)
        End If
    End Function
    Public Sub Serial_D_S_Cells(ByVal D As DataGridView)
        For k As Integer = 0 To D.SelectedCells.Count - 1
            Iw = k + 1
            D.SelectedCells(k).Value = Iw
        Next
    End Sub
    Public Sub Master_ID_String(ByVal D As DataGridView, Optional ByVal maxLen As Integer = 9, Optional ByVal MCol As Integer = 0)
        On Error GoTo b
        If AukF.GridT(D, MCol) = "" Then
            n = Mid(D.Name.ToString, 1, 4) : l = D.Columns(MCol).DataPropertyName.ToString
            s = Now.Date & Now.Second : b = Now.Millisecond + Now.Second
            curtxt = AukF.GridT(D)
            agb = curtxt & n & s & Now.Millisecond & b & l & Rnd(Now.Millisecond) & Now.Hour & Now.Day & Now.Second + Now.Year
            If DRow > -1 Then
                If D(MCol, DRow) IsNot Nothing Then
                    D(MCol, DRow).Value = UCase(Left(SoftIn.Convert_Hash_RND1(agb), maxLen))
                End If
            End If
        End If
        Exit Sub
b:      MsgBox("Auk Automatic ID can't create on current row.", MsgBoxStyle.Information)
    End Sub
    Public Sub Master_ID_NumberInsert_NonAuto(ByVal D As DataGridView, ByVal Number As Decimal, Optional ByVal MCol As Integer = 0)
        'n = D.Name.ToString : l = D.Columns(MCol).DataPropertyName.ToString
        's = Now.Date & Now.Second : b = Now.Millisecond + Now.Second
        'agb = n & s & b & Text1 & My.Application.Info.ProductName.ToUpper & l
        If AukF.GridT(D, MCol) = "" Then
            If DRow > -1 Then D(MCol, DRow).Value = Number
        End If
    End Sub
    Public Function Rows_Select(ByVal T As DataTable, ByVal Column As Object, ByVal FindStr As String) As DataRow()
        Dim R() As DataRow
        If Trim(FindStr) = "" Then Return Nothing
        Column = T.Columns(Column).ColumnName.ToString
        If T.Columns(Column).DataType.Name = "String" Then
            R = T.Select("[" & Column & "]='" & FindStr & "'")
        ElseIf T.Columns(Column).DataType.Name = "Date" Then
            R = T.Select("[" & Column & "]=#" & FindStr & "#")
        Else
            R = T.Select("[" & Column & "]=" & FindStr)
        End If
        If R.Length = 0 Then R = Nothing
        Return R
    End Function
    Public Function Rows_SelectGetOnlyOne(ByVal T As DataTable, ByVal Column As Object, ByVal FindStr As String) As DataRow
        Dim R() As DataRow
        R = Rows_Select(T, Column, FindStr)
        If R IsNot Nothing Then
            If R.Length > 0 Then
                Return R(0)
            End If
        End If
        Return Nothing
    End Function


    Public Function Rows_Select(ByVal T As DataTable, ByVal BsqlX As String) As DataRow()
        Dim R() As DataRow
        Try
            'If Trim(FindStr) = "" Then Return Nothing
            R = T.Select(BsqlX)
            If R.Length = 0 Then R = Nothing
            Return R
        Catch ex As Exception
            Epx()
        End Try

    End Function
    Public Function Master_ID_String_Get(Optional ByVal maxLen As Integer = 9, Optional ByVal MCol As Integer = 0)
        n = Now.Date : l = Now.AddDays(21).Day
        s = Now.Date & Now.Second : b = Now.Millisecond + Now.Second
        agb = n & s & Now.Millisecond & b & l & Rnd(Now.Millisecond) & Now.Hour & Now.Day & Now.Second + Now.Year
        Return UCase(Left(SoftIn.Convert_Hash_RND1(agb), maxLen))
    End Function
    Public Function Master_ID_Table_String(ByVal T As DataTable, ByVal CurrentPos As Integer, Optional ByVal Entry_if_exist As Boolean = False, Optional ByVal maxLen As Integer = 9, Optional ByVal MCol As Integer = 0, Optional ByVal Text1 As String = "Auksoftware's")
        n = T.TableName.ToString : l = T.Columns(MCol).ColumnName.ToString
        s = Now.Date & Now.Second : b = Now.Millisecond + Now.Second
        agb = n & CurrentPos & s & b & Text1 & My.Application.Info.ProductName.ToUpper & l
        If TypeOf (T.Rows(CurrentPos).Item(MCol)) Is DBNull Then
            T.Rows(CurrentPos).Item(MCol) = UCase(Left(SoftIn.Convert_Hash_RND1(agb), maxLen))
        ElseIf Entry_if_exist = True Then
            T.Rows(CurrentPos).Item(MCol) = UCase(Left(SoftIn.Convert_Hash_RND1(agb), maxLen))
        End If
    End Function
    Public Function Master_ID_Row_String(ByVal R As DataRow, Optional ByVal Entry_if_exist As Boolean = False, Optional ByVal maxLen As Integer = 9, Optional ByVal MCol As Integer = 0, Optional ByVal Text1 As String = "Auksoftware's")
        n = R.Table.TableName.ToString : l = R.Table.Columns(MCol).ColumnName.ToString
        s = Now.Date & Now.Second : b = Now.Millisecond + Now.Second
        agb = n & s & b & Text1 & My.Application.Info.ProductName.ToUpper & l
        If TypeOf (R(MCol)) Is DBNull Then
            R(MCol) = UCase(Left(SoftIn.Convert_Hash_RND1(agb), maxLen))
        Else
            If Entry_if_exist = True Then
                R(MCol) = UCase(Left(SoftIn.Convert_Hash_RND1(agb), maxLen))
            End If
        End If
    End Function

    Public Function SELECTED_CELLS_COMMON_TXT_UPPERCASE(ByVal D As DataGridView)
        For K As Integer = 0 To D.SelectedCells.Count - 1
            If TypeOf (D.SelectedCells(K).Value) Is DBNull Then
            Else
                D.SelectedCells(K).Value = UCase(CStr(D.SelectedCells(K).Value))
            End If
        Next
    End Function

    Public Function CUT_GRID(ByVal D As DataGridView)
        Dim C As Integer
        If D Is Nothing Then MsgBox("GRID OBJECT IS NOTHING", MsgBoxStyle.Critical) : Exit Function
        COPY_GRID(D)
        Dim CXA As Integer
        Dim rX As Boolean = False
        If D.SelectedRows.Count = 0 Then
            rX = False
            CXA = D.SelectedRows.Count - 1
        ElseIf D.SelectedCells.Count > 0 Then
            rX = True
            CXA = D.SelectedCells.Count - 1
        End If
        If rX = True Then
            AukF.DataGridDeleteItemsProcessor(D, False, True, False)
        Else
            For K As Integer = 0 To CXA
                C = CInt(D.SelectedCells(K).ColumnIndex)
                D.SelectedCells(K).Value = GetType(System.DBNull)
            Next
        End If

    End Function
    Public Function COPY_GRID(ByVal D As DataGridView)
        If D Is Nothing Then MsgBox("GRID OBJECT IS NOTHING", MsgBoxStyle.Critical) : Exit Function
        If D.SelectedRows.Count = 0 And D.SelectedCells.Count > 0 Then
            Array.Resize(DG_SLcELL, D.SelectedCells.Count)
            'D.SelectedCells.CopyTo(DG_SLcELL, 0)
            For k As Integer = (D.SelectedCells.Count - 1) To 0 Step -1
                'MsgBox(D.SelectedCells(k).Value)
                DG_SLcELL.SetValue(D.SelectedCells(k).Value, k)
            Next
            DG_cOPY_CAT = "CELL"
        ElseIf D.SelectedRows.Count > 0 Then
            Array.Resize(DG_SLrOWS, D.SelectedRows.Count)
            Array.Resize(DG_cOL, D.Columns.Count)
            For K As Integer = 0 To D.Columns.Count - 1
                DG_cOL.SetValue(D.Columns(K).DataPropertyName, K)
            Next
            'D.Columns.CopyTo(DG_cOL, 0)
            For K As Integer = 0 To D.SelectedRows.Count - 1
                DG_SLrOWS(K) = D.SelectedRows(K)
            Next
            DG_cOPY_CAT = "ROWS"
        Else
            DG_cOPY_CAT = ""
        End If
        DG_COLUMN = D.CurrentCell.ColumnIndex
    End Function
    Public Function Insert_Copies(ByVal D As DataGridView, Optional ByVal MCOLUMN As Integer = 0, Optional ByVal DeleteAfter As Boolean = False)
        Dim T As DataTable = AukF.Get_DataSystemObj(D)
        Dim P As Integer = D.CurrentCell.RowIndex
        Dim R, Cr As DataRow
        Dim ID As String
        Dim uA As Array
        If P > -1 Then
            InsRows.Resize(InsRows, D.SelectedRows.Count)
            For K As Integer = (D.SelectedRows.Count - 1) To 0 Step -1
                I = D.SelectedRows(K).Index
                ID = AukF.GridT(D, MCOLUMN, I)
                R = T.Rows.Find(ID)
                If R IsNot Nothing Then
                    uA = R.ItemArray
                    Cr = R.Table.NewRow()
                    Cr.ItemArray = uA
                    InsRows.SetValue(Cr, K)
                    If DeleteAfter = True Then R.Delete()
                End If
            Next
        End If
    End Function
    Public Function Serial_Number_Table(ByVal T As DataTable, Optional ByVal Input_F As Boolean = False, Optional ByVal Mcol As Integer = 0)
        On Error GoTo b
        If Input_F = True Then
            For k As Integer = 0 To T.Rows.Count - 1
                T.Rows(k).Item(Mcol) = SoftIn.Master_ID_String_Get()
            Next
        End If
        T.AcceptChanges()
        For k As Integer = 0 To T.Rows.Count - 1
            Iw = k + 1
            T.Rows(k).Item(Mcol) = Iw
        Next
b:      Iw += 1 : Resume Next

    End Function
    Public Function ROWS_DATAG_INNER_CHG(ByVal D As DataGridView, Optional ByVal MCOL As Integer = 0)
        'Dim RD As DataGridViewRow
        Dim IX As Integer
        If D.SelectedRows.Count = 2 Then
            'SoftIn.COPY_GRID(D)
            SoftIn.Insert_Copies(D)
            For K As Integer = 0 To 1
                If K = 0 Then IX = 1 Else IX = 0
                RowX = InsRows.GetValue(K)
                'RD = DG_SLrOWS.GetValue(K)
                'MsgBox(IX, , K)
                For M As Integer = 0 To D.ColumnCount - 1
                    If M <> MCOL Then
                        'MsgBox(RD.Cells(M).Value, , D.SelectedRows(IX).Cells(M).Value)
                        D.SelectedRows(IX).Cells(M).Value = RowX(M)
                    End If
                Next
            Next
        Else
            MsgBox("PLEASE SELECT TWO ROWS THEN EXECUTE THIS COMMAND", MsgBoxStyle.Information)
        End If
    End Function
    Public Function Insert_Cut(ByVal D As DataGridView, Optional ByVal MCOLUMN As Integer = 0)
        Insert_Copies(D, MCOLUMN, True)
    End Function
    Public Function iNSERT_PASTE(ByVal D As DataGridView, Optional ByVal CreateNewID As Boolean = False, Optional ByVal Chg_Columns As String = "", Optional ByVal Insert_Column_Str As String = "", Optional ByVal InputInsetNumber As Decimal = Nothing, Optional ByVal InputInsetNumberBool As Boolean = False, Optional ByVal MaxLen As Integer = 12, Optional ByVal MCOLUMN As Integer = 0)
        Dim T As DataTable = AukF.Get_DataSystemObj(D)
        Dim P As Integer
        Dim R As DataRow
        Dim Ins, ChCol As Array
        Dim ID As String
        Dim UA As Array
        If D.CurrentCell IsNot Nothing Then
            P = D.CurrentCell.RowIndex
            ID = AukF.GridT(D, MCOLUMN, P)
            RowX = T.Rows.Find(ID)
            If RowX IsNot Nothing Then P = T.Rows.IndexOf(RowX) Else P = -1
        Else
            P = -1
        End If
        If P = -1 Then
            P = D.RowCount
        End If
        If Chg_Columns <> "" Then
            If Insert_Column_Str <> "" Then Ins = Insert_Column_Str.Split(",")
            ChCol = Chg_Columns.Split(",")
        End If
        Try
            If InsRows IsNot Nothing Then
                For K As Integer = 0 To InsRows.GetUpperBound(0)
                    R = InsRows.GetValue(K)
                    If R Is Nothing Then MsgBox("COPIES ROWS ARE DELETED,COPY AGAIN OR REFRESH CHANGES.", MsgBoxStyle.Information) : Exit Function
                    If T.TableName <> R.Table.TableName Then MsgBox("CURRENT INSERT COMMAND COPY ROWS IS NOT FROM THIS TABLE PLEASE PASTE IT IN( " & R.Table.TableName.ToUpper & " ).", MsgBoxStyle.Critical)
                    R.EndEdit()
                    ID = R(MCOLUMN).ToString
                    If Chg_Columns <> "" Then
                        For Br As Integer = 0 To ChCol.GetUpperBound(0)
                            R(CInt(ArV(ChCol, Br))) = ArV(Ins, Br, Nothing, GetType(DBNull))
                        Next
                    End If
                    If ADSRC.FIND_FROM_DATATABLE_INDEX(T, ID) = True Then
                        If CreateNewID = False Then
                            For M As Integer = 0 To T.Columns.Count - 1
                                If M <> MCOLUMN Then
                                    RowX(M) = R(M)
                                End If
                            Next
                        Else
                            If SoftIn.Get_DataType_Str(T, MCOLUMN) = True Then
                                Try
                                    UA = R.ItemArray
                                    RowX = T.NewRow
                                    If InputInsetNumberBool = True Then
                                        InputInsetNumber += 1
                                        UA.SetValue(InputInsetNumber, MCOLUMN)
                                    Else
                                        UA.SetValue(SoftIn.Master_ID_String_Get(MaxLen, MCOLUMN), MCOLUMN)
                                    End If
                                    RowX.ItemArray = UA
                                    T.Rows.InsertAt(RowX, P + K)
                                Catch exP As Exception
                                    Epx()
                                End Try
                            End If
                        End If
                    Else
                        T.Rows.InsertAt(R, P + K)
                    End If
                Next
                If InputInsetNumberBool = True Then
                    WGeT = InputInsetNumber
                End If
            Else
                MsgBox("PLEASE COPY SOME ROWS BY AUK INSERT COPY COMMAND", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Epx()
        End Try
    End Function
    Public Function PASTE_GRID(ByVal D As DataGridView)
        If D Is Nothing Then MsgBox("GRID OBJECT IS NOTHING", MsgBoxStyle.Critical) : Exit Function
        Dim rD As DataGridViewRow
        Dim P As Integer
        'Dim sR As Object
        P = 0
        If DG_cOPY_CAT = "CELL" Then
            If D.SelectedCells.Count > 0 And D.SelectedRows.Count = 0 Then
                For K As Integer = 0 To D.SelectedCells.Count - 1
                    MsgBox(D.SelectedCells(K).RowIndex, , ArV(DG_SLcELL, K, Nothing, GetType(System.DBNull)))
                    D.SelectedCells(K).Value = ArV(DG_SLcELL, K, Nothing, GetType(System.DBNull))
                    If DG_SLcELL.GetUpperBound(0) = K Then
                        Exit For
                    End If
                Next
            Else
                MsgBox("PLEASE SELECT CELL FOR PASTE(EXECUTE AUK PASTE COMMAND)", MsgBoxStyle.Information)
            End If
        ElseIf DG_cOPY_CAT = "ROWS" Then
            If D.SelectedRows.Count > 0 Then
                For K As Integer = 0 To D.SelectedRows.Count - 1
                    For M As Integer = 0 To D.Columns.Count - 1
                        rD = DG_SLrOWS.GetValue(K)
                        Try
                            If D.Columns(M).DataPropertyName = ArV(DG_cOL, M) Then
                                D.SelectedRows(K).Cells(M).Value = rD.Cells(M).Value
                            ElseIf ArF(DG_cOL, D.Columns(M).DataPropertyName) = True Then
                                D.SelectedRows(K).Cells(M).Value = rD.Cells(ComRow).Value
                            End If
                        Catch ex As Exception
                            Epx()
                            Exit Function
                        End Try
                    Next
                Next
            Else
                MsgBox("PLEASE SELECT ROW TO FOR PASTE OR REPLACE(EXECUTE AUK PASTE COMMAND)", MsgBoxStyle.Information)
            End If
        End If
    End Function

    Public Function Same_input_Box(Optional ByVal title As String = "") As String
        If title = "" Then
            title = "PLEASE TYPE PRODUCT SERIAL/ID TO ATTRIBUTE SAME QUALITY IN THEIR SPECIFIC PARAMETER"
        End If
        Same_input_Box = InputBox("PLEASE TYPE YOUR SR NUM/ID BY USING THIS ("","") SPLIT KEY TO SPLIT THEM.", title, Same_input_Box)
    End Function
    Public Sub LOST_FOCUS_NEVER_NULL(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal BP As BindingSource, Optional ByVal MSG As Boolean = False)
        If sender.TEXT = "" Then
            If BP.Count > 0 Then
                If MSG = True Then MsgBox("PLEASE TYPE PRODUCT ID/SERIAL.", MsgBoxStyle.Critical)
                sender.FOCUS()
            End If
        End If
    End Sub
    Public Function PREVIOUS_DATAiNPUT_DATAGRID(ByVal D As DataGridView, Optional ByVal MASTERCOL As Integer = 0, Optional ByVal SPLITS_COLUMNS As String = "")
        Dim RI, RI2 As Integer
        RI = D.CurrentRow.Index
        RI2 = RI - 1
        If RI <= 0 And RI2 < 0 Then Exit Function
        Dim a As Array
        If SPLITS_COLUMNS.Trim <> "" Then
            a = SPLITS_COLUMNS.Split(",")
        Else
            a = Nothing
        End If
        For K As Integer = 0 To D.Columns.Count - 1
            If MASTERCOL <> K Then
                If ArF(a, K) = False Then
                    If AukF.GridT(D, K) = "" Then
                        D(K, RI).Value = D(K, RI2).Value
                    End If
                End If
            End If
        Next
    End Function
    Public Sub Same_Input(ByVal Row As DataRow, Optional ByVal MColumn As Integer = 0, Optional ByVal MasterIds As String = "", Optional ByVal Columns As String = "", Optional ByVal Changes As String = "", Optional ByVal Input_MasterId As Boolean = False, Optional ByVal UseMaster_Before As Boolean = False, Optional ByVal Key As String = ",")
        If Row Is Nothing Then Exit Sub
        Dim MIds As Array = MasterIds.Split(Key) 'if master ids =a,d,b,c then try to insert them into sames new rows...
        Dim T As DataTable = Row.Table
        Dim CAr As Array = Nothing
        Dim ChArs As Array = Nothing
        Dim M As Integer = MColumn
        Dim Rn As DataRow
        Dim A, B As String
        If Columns.Trim <> "" Then 'for chg in oter columns
            CAr = Columns.Split(Key) 'car =columns array
        End If
        If Changes.Trim <> "" Then 'if we want to chg in other columns
            ChArs = Changes.Split(Key) 'ChArs =columns chgs array
        End If
        'MIds = master id array, getting from 'MasterIds', by split command
        For K As Integer = 0 To MIds.GetUpperBound(0) 'check how many master id the add rows by it.master ids =a,d,b,c 
            Rn = T.NewRow 'creating new row for new masid
            Midx = ArV(MIds, K) 'every masterid value get in MIDx
            Rn(M) = Midx 'then input in rn rows Master which is M field
            If Input_MasterId = True Then 'only for the category of product sold,if its true then in chg column add this ,master is before or after by its functions
                If UseMaster_Before = True Then A = midx : B = ""
                If UseMaster_Before = False Then A = "" : B = midx
            Else 'If Input_MasterId=false then input nothing,in chg fields without the chg
                A = "" : B = ""
            End If
            For N As Integer = 0 To T.Columns.Count - 1
                If N <> M Then 'field is not master column
                    If ArF(CAr, N) = True Then 'if cur field N Found in ,Wrote Columns  then put the the chg value into it, 
                        'and if Input_MasterId= true then with chg column field try to input the master id also, by using command of use after or before.
                        'if Input_MasterId=false, then a="",b="" but else , in one put the value of master id
                        'so care full
                        Rn(CInt(CAr.GetValue(ComRow).ToString)) = A & ChArs.GetValue(ComRow).ToString.Trim & B
                    Else
                        Rn(N) = Row(N)
                    End If
                End If
            Next
            T.Rows.Add(Rn)
        Next
    End Sub
    Public Sub Same_Input_New(ByVal Row As DataRow, ByVal InputRows As Integer, Optional ByVal MColumn As Integer = 0, Optional ByVal MasterIds As String = "", Optional ByVal Columns As String = "", Optional ByVal Changes As String = "", Optional ByVal MaxLenMasterColumn As Integer = 12, Optional ByVal Key As String = ",")
        If Row Is Nothing Then Exit Sub
        Dim MIds As Array  'if master ids =a,d,b,c then try to insert them into sames new rows...
        Dim T As DataTable = Row.Table
        Dim CAr As Array = Nothing
        Dim ChArs As Array = Nothing
        Dim M As Integer = MColumn
        Dim Rn As DataRow
        'if MasterIds =a,d,b,c then try to insert them into sames new rows...
        If AukF.FindTxt(MasterIds, Key) = True Then MIds = MasterIds.Split(Key)
        If Columns.Trim <> "" Then 'for chg in oter columns
            CAr = Columns.Split(Key) 'car =columns array
        End If
        If Changes.Trim <> "" Then 'if we want to chg in other columns
            ChArs = Changes.Split(Key) 'ChArs =columns chgs array
        End If
        'I have to start from 1 in InputRows ,because user types this
        'if starts from 0 then if InputRows=4 it, inputs 5 rows ,because it counts from 0
        'consequently it will be start from 1
        For K As Integer = 1 To InputRows 'for how manys rows i need to create
            Rn = T.NewRow
            If MIds IsNot Nothing Then Midx = ArV(MIds, K) Else midx = "" 'geting masterID from MasterID array named MIDs to MidX
            '1st checking that ,user input masterid is valid for this row
            'if valid the without check input in on master column
            'or else check max len and datatype for new and automatic master id
            If Midx <> "" Then 'if mids masterid is not null then
                Rn(M) = Midx
            Else
                Dim Mlen As Integer
                If T.Columns(M).MaxLength > MaxLenMasterColumn Then 'checking the master column lenth
                    Mlen = MaxLenMasterColumn
                Else 'if less then oue value then ,input the ori maxlen of master column
                    Mlen = T.Columns(M).MaxLength
                End If
                If SoftIn.Get_DataType_Str(T, M) = True Then 'if string true then input str value
                    Rn(M) = SoftIn.Master_ID_String_Get(Mlen) 'str auto id,its safe
                Else
                    Rn(M) = SoftIn.MasterID_Number_Auto(Mlen) 'number auto id,vary carefull
                End If
            End If
            For N As Integer = 0 To T.Columns.Count - 1
                If N <> M Then 'master column get its master id before,so putting the chg values and before values into this row
                    If ArF(CAr, N) = True Then 'if cur field N Found in ,Wrote Columns  then put the the chg value into it, 
                        Rn(CInt(CAr.GetValue(ComRow).ToString)) = A & ChArs.GetValue(ComRow).ToString.Trim & B
                    Else
                        Rn(N) = Row(N) 'same values input cause this coulmn not found in columns array,car.
                    End If
                End If
            Next
            Try
                T.Rows.Add(Rn) 'at last add the row
            Catch ex As Exception
                Epx()
                Exit Sub
            End Try
        Next
    End Sub
    Public Function GET_BENEFIT(ByVal PUrCHASE As Decimal, ByVal PErCENT As Decimal, Optional ByVal REMOVE_P As Boolean = True, Optional ByVal WITHHUN As Boolean = True) As Decimal
        If WITHHUN = True Then PErCENT = 100 + PErCENT
        O = PErCENT / 100
        GET_BENEFIT = PUrCHASE * O
        If REMOVE_P = True Then GET_BENEFIT = CDec(CInt(GET_BENEFIT))
    End Function
    Public Sub KEY_DOWN_EVENTS_NESTED(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs, ByVal bP As BindingSource, Optional ByVal FOCUS_ON_FTXTBOX As Object = Nothing, Optional ByVal LAST_TXTBOX_NAME As String = "", Optional ByVal ENTER_TONEXT As Boolean = False, Optional ByVal ATLAST_ADD As Boolean = True, Optional ByVal KEY_EVENTS_WRK As Boolean = True, Optional ByVal ADD_N_FUNC As Boolean = False, Optional ByVal NEsTeD As Boolean = True, Optional ByVal WArP As Boolean = True)
        KEY_DOWN_EVENTS(sender, e, bP, FOCUS_ON_FTXTBOX, LAST_TXTBOX_NAME, ENTER_TONEXT, ATLAST_ADD, KEY_EVENTS_WRK, ADD_N_FUNC, NEsTeD, WArP)
    End Sub

    Public Sub KEY_DOWN_EVENTS(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs, ByVal bP As BindingSource, Optional ByVal FOCUS_ON_FTXTBOX As Object = Nothing, Optional ByVal LAST_TXTBOX_NAME As String = "", Optional ByVal ENTER_TONEXT As Boolean = False, Optional ByVal ATLAST_ADD As Boolean = True, Optional ByVal KEY_EVENTS_WRK As Boolean = True, Optional ByVal ADD_N_FUNC As Boolean = False, Optional ByVal NEsTeD As Boolean = False, Optional ByVal WArP As Boolean = False)
        Dim FR As Object = sender.FindForm
        'MsgBox(FR.NAME.ToString)
        Try
            If KEY_EVENTS_WRK = False Then Exit Sub
            If e.KeyCode = Keys.Enter Then
                If ENTER_TONEXT = True Then
                    If (bP.Count - 1) = bP.Position Then
                        If ADD_N_FUNC = False Then
                            If ATLAST_ADD = True Then bP.AddNew()
                        Else
                            Try
                                FR.ADD_N_FUNC()
                            Catch ex As Exception
                                Epx()
                            End Try
                        End If
                    Else
                        bP.MoveNext()
                    End If
                Else
                    If sender.NAME = LAST_TXTBOX_NAME Then
                        If (bP.Count - 1) = bP.Position Then
                            If ADD_N_FUNC = False Then
                                If ATLAST_ADD = True Then bP.AddNew()
                            Else
                                Try
                                    FR.ADD_N_FUNC()
                                Catch ex As Exception
                                    Epx()
                                End Try
                            End If
                        Else
                            bP.MoveNext()
                        End If
                        If FOCUS_ON_FTXTBOX IsNot Nothing Then
                            FOCUS_ON_FTXTBOX.FOCUS()
                        End If
                    Else
                        FR.SelectNextControl(sender, True, True, NEsTeD, WArP)
                    End If
                End If
                Exit Sub
            End If
            If e.Control = True And e.Shift = True Then
                If e.KeyCode = Keys.Up Then
                    FR.SelectNextControl(sender, False, True, NEsTeD, WArP)
                ElseIf e.KeyCode = Keys.Down Then
                    FR.SelectNextControl(sender, True, True, NEsTeD, WArP)
                ElseIf e.KeyCode = Keys.Right Then
                    bP.MoveLast()
                ElseIf e.KeyCode = Keys.Left Then
                    bP.MoveFirst()
                End If
                Exit Sub
            End If
            If e.Modifiers = Keys.Control Then
                If e.KeyCode = Keys.Up Then
                    FR.SelectNextControl(sender, False, True, NEsTeD, WArP)
                ElseIf e.KeyCode = Keys.Down Then
                    FR.SelectNextControl(sender, True, True, NEsTeD, WArP)
                ElseIf e.KeyCode = Keys.Right Then
                    bP.MoveNext()
                ElseIf e.KeyCode = Keys.Left Then
                    bP.MovePrevious()
                End If
                Exit Sub
            End If
            If e.Modifiers = Keys.Control And e.Modifiers = Keys.Shift Then
                If e.KeyCode = Keys.Right Then
                    bP.MoveLast()
                ElseIf e.KeyCode = Keys.Left Then
                    bP.MoveFirst()
                End If
            End If
        Catch ex As Exception
            Epx()
            If FOCUS_ON_FTXTBOX IsNot Nothing Then
                FOCUS_ON_FTXTBOX.FOCUS()
            End If
        End Try

    End Sub
    Public Function Get_ArrayTo_NotNullArrary(ByVal A As Array, Optional ByVal Key As String = ",", Optional ByVal OArray As Boolean = True) As Object
        Dim Str As String
        For k As Integer = 0 To A.GetUpperBound(0)
            If A.GetValue(k).ToString.Trim <> "" Then
                If Str = "" Then Str = A.GetValue(k).ToString.Trim Else Str &= Key & A.GetValue(k).ToString.Trim
            End If
        Next
        If OArray = True Then Get_ArrayTo_NotNullArrary = Str.Split(Key) Else Get_ArrayTo_NotNullArrary = Str
    End Function
    Public Function GetTableColumn_NameString(ByVal Db1 As DataTable, ByVal TStr As Object) As String
        Dim Str As String = CStr(TStr)
        'Dim D As String = "()[]"
        'Dim A As Array
        'If TStr Is Nothing Then Return "" : Exit Function
        'If Db1.TableName = "" Then GetTableColumn_NameString = CStr(TStr) : Exit Function
        Try
            If IsNumeric(TStr) Then
                GetTableColumn_NameString = Db1.Columns(CInt(TStr)).ColumnName.ToString
            Else
                If TStr.ToString.Length >= 1 Then
                    If Left(Str, 1) = "[" And Right(Str, 1) = "]" Then
                        Str = Str.Replace("[", "")
                        Str = Str.Replace("]", "")
                        GetTableColumn_NameString = Db1.Columns(Str).ColumnName.ToString
                        'ElseIf Right(Str, 1) = ")" Then
                        '    A = Str.Split(D.ToCharArray)
                        '    Str = Get_ArrayTo_NotNullArrary(A, ",", True).getvalue(1).ToString.Trim
                        '    GetTableColumn_NameString = Db1.Columns(Str).ColumnName.ToString
                    Else
                        GetTableColumn_NameString = Db1.Columns(CStr(TStr)).ColumnName.ToString
                        'MsgBox(GetTableColumn_NameString)
                    End If
                End If
            End If
        Catch ex As Exception
            'Return CStr(TStr)
            Epx(TStr)
        End Try
        'MsgBox(TStr.ToString.Substring(1, TStr.ToString.Length - 2))
    End Function
    Public Function QueryLink(ByVal Db1 As Object, ByVal Db1Title As Object, ByVal Db1F1 As String, ByVal Db2 As Object, ByVal Db2Title As Object, Optional ByVal Open_Db1_Field_ToLinkWithIn As String = "0", Optional ByVal Bp As BindingSource = Nothing, Optional ByVal Bp_WithFilter_opt As Boolean = False, Optional ByVal QueryFunction As Integer = 0, Optional ByVal ExecuteQueryOnDb2 As Boolean = True, Optional ByVal Max_Open_From_DB1 As Integer = 300, Optional ByVal Load_DataOnDb2_Clear As Boolean = False) As String
        'get the query text for 2nd db2
        Dim Str1, Str2 As String
        Dim Ua() As String
        Dim T, T2 As DataTable
        Dim It1, It2, It3 As String
        T = AukF.Get_DataSystemObj(Db1)
        T2 = AukF.Get_DataSystemObj(Db2)
        Dim DataTb1 As New DataTable(T.TableName.ToString)
        'from it1 i'm just finding from db1 and open db1_Tile 
        'only by it3 and sets its 
        'in incommand to find in db2's it2 field.
        It1 = GetTableColumn_NameString(T, Db1Title)
        It2 = GetTableColumn_NameString(T2, Db2Title)
        It3 = GetTableColumn_NameString(T, Open_Db1_Field_ToLinkWithIn)
        Str1 = GetFunction_QrText(T, It1, Db1F1, QueryFunction, "=", True)
        If Trim(Str1) = "" Then
            Str1 = SoftIn.Datatable_Nulls_only(It1, True)
            Str1 = Sql_Convert_For_Adp(T, Str1)
            AukF.OleDb_SqlGen(Str1, DataTb1, T.TableName.ToUpper, True, Max_Open_From_DB1)
            'MsgBox(Str1)
        Else
            Str1 = Sql_Convert_For_Adp(T, Str1)
            AukF.OleDb_SqlGen(Str1, DataTb1, T.TableName.ToUpper, True, Max_Open_From_DB1)
        End If
        'MsgBox(DataTb1.Rows.Count)
        If DataTb1.Rows.Count > 0 Then
            Ua.Resize(Ua, DataTb1.Rows.Count)
            For k As Integer = 0 To DataTb1.Rows.Count - 1
                Ua.SetValue(CStr(DataTb1.Rows(k).Item(It3).ToString), k)
            Next
            If Get_DataType_Str(T2, It2) = True Then
                Str2 = SrGens.ArrayToStr(Ua, ",", "'", "'")
            Else
                If WGeT = "System.DateTime" Then
                    Str2 = SrGens.ArrayToStr(Ua, ",", "#", "#")
                Else
                    Str2 = SrGens.ArrayToStr(Ua, ",", "", "")
                End If
            End If
            Str2 = GetFunction_QrText(T2, It2, Str2, 8, Sign)
        Else
            Str2 = Datatable_Nulls_only(It3, True)
        End If
        If Bp IsNot Nothing Then
            If Str2.Trim <> "" Then
                SqlToFiler_BindingSource(Bp, Str2.ToUpper, Bp_WithFilter_opt)
            Else
            End If
        End If
        If Str2.Trim <> "" Then QueryLink = (CStr(Str2.ToString)) Else QueryLink = ""
        BSql = QueryLink
        If ExecuteQueryOnDb2 = True Then m = Sql_Convert_For_Adp(T2, QueryLink) : AukF.OleDb_SqlGen(m, T2, T2.TableName.ToUpper, Load_DataOnDb2_Clear, Max_Open_From_DB1, -1, QueryLink)
        DataTb1.Clear()
        'DataTb1.dis
    End Function
    Public Function QueryLink_Direct(ByVal Db1 As Object, ByVal Db1Title As Object, ByVal Db1F1 As String, ByVal Db2 As Object, ByVal Db2Title As Object, Optional ByVal Open_Db1_Field_ToLinkWithIn As String = "0", Optional ByVal Bp As BindingSource = Nothing, Optional ByVal Bp_WithFilter_opt As Boolean = False, Optional ByVal QueryFunction As Integer = 0, Optional ByVal ExecuteQueryOnDb2 As Boolean = True, Optional ByVal Max_Open_From_DB1 As Integer = 300, Optional ByVal Load_DataOnDb2_Clear As Boolean = False) As String
        'get the query text for 2nd db2
        Dim Str1, Str2 As String
        Dim Ua() As String
        Dim T, T2 As DataTable
        Dim It1, It2, It3 As String
        T = AukF.Get_DataSystemObj(Db1)
        T2 = AukF.Get_DataSystemObj(Db2)
        Dim DataTb1 As New DataTable(T.TableName.ToString)
        'from it1 i'm just finding from db1 and open db1_Tile 
        'only by it3 and sets its 
        'in incommand to find in db2's it2 field.
        It1 = GetTableColumn_NameString(T, Db1Title)
        It2 = GetTableColumn_NameString(T2, Db2Title)
        It3 = GetTableColumn_NameString(T, Open_Db1_Field_ToLinkWithIn)
        Str1 = GetFunction_QrText(T, It1, Db1F1, QueryFunction, "=", True)
        If Trim(Str1) = "" Then
            Str1 = SoftIn.Datatable_Nulls_only(It1, True)
            Str1 = Sql_Convert_For_Adp(T, Str1)
            AukF.OleDb_SqlGen(Str1, DataTb1, T.TableName.ToUpper, True, Max_Open_From_DB1)
            'MsgBox(Str1)
        Else
            Str1 = Sql_Convert_For_Adp(T, Str1)
            AukF.OleDb_SqlGen(Str1, DataTb1, T.TableName.ToUpper, True, Max_Open_From_DB1)
        End If
        'MsgBox(DataTb1.Rows.Count)
        If DataTb1.Rows.Count > 0 Then
            Ua.Resize(Ua, DataTb1.Rows.Count)
            For k As Integer = 0 To DataTb1.Rows.Count - 1
                Ua.SetValue(CStr(DataTb1.Rows(k).Item(It3).ToString), k)
            Next
            'If Get_DataType_Str(T2, It2) = True Then
            '    Str2 = SrGens.ArrayToStr(Ua, ",", "'", "'")
            'Else
            '    If WGeT = "System.DateTime" Then
            '        Str2 = SrGens.ArrayToStr(Ua, ",", "#", "#")
            '    Else
            '        Str2 = SrGens.ArrayToStr(Ua, ",", "", "")
            '    End If
            'End If
            'Ua = Str2.Split(",")
            If Ua IsNot Nothing Then

                Str2 = ""
                For K As Integer = 0 To Ua.GetUpperBound(0)
                    M = ArV(Ua, K)
                    If Str2 = "" Then
                        Str2 = "(" & SoftIn.GetFunction_QrText(T2, It2, M, 0) & ")"
                    Else
                        Str2 += Str2 & " AND (" & SoftIn.GetFunction_QrText(T2, It2, M, 0) & ")"
                    End If
                Next
            Else
                Str2 = ""
            End If
        Else
            Str2 = Datatable_Nulls_only(It3, True)
        End If
        If Bp IsNot Nothing Then
            If Str2.Trim <> "" Then
                SqlToFiler_BindingSource(Bp, Str2.ToUpper, Bp_WithFilter_opt)
            Else
            End If
        End If
        If Str2.Trim <> "" Then QueryLink_Direct = (CStr(Str2.ToString)) Else QueryLink_Direct = ""
        BSql = QueryLink_Direct
        If ExecuteQueryOnDb2 = True Then m = Sql_Convert_For_Adp(T2, QueryLink_Direct) : AukF.OleDb_SqlGen(m, T2, T2.TableName.ToUpper, Load_DataOnDb2_Clear, Max_Open_From_DB1, -1, QueryLink_Direct)
        DataTb1.Clear()
        'DataTb1.dis
    End Function
    Public Function Sql_Convert_For_Adp(ByVal T As DataTable, ByVal Str As String, Optional ByVal TitlesOpen As String = "*", Optional ByVal Only_Query_Enable As Boolean = True, Optional ByVal OrderByFileds As String = "", Optional ByVal GroupBy As Boolean = False, Optional ByVal TopLoad As Integer = 0, Optional ByVal Percent As Boolean = False, Optional ByVal OnlyDis As Boolean = False, Optional ByVal DisRow As Boolean = False, Optional ByVal TABLENAME As String = "")
        Dim GrpT As String = OrderByFileds
        Dim TNAM As String = "[" & T.TableName.ToString & "]"
        Dim Px, Tx, Lnq As String
        Dim FQA As Boolean = Only_Query_Enable
        If OnlyDis = True Then Lnq = " Distinct "
        Dim W, FR, SX As String
        Dim NFOR As String
        If GroupBy = False Then W = " WHERE ( " Else W = " HAVING ( "
        FR = " FROM "
        SX = "SELECT "
        If Val(TitlesOpen) = -1 Then TitlesOpen = "*"
        If DisRow = True Then
            Lnq = " DISTINCTROW "
        Else
            If Percent = True Then Px = " PERCENT" Else Px = ""
            If TopLoad > 0 Then Tx = "TOP " & TopLoad Else Tx = ""
            Lnq = Tx & Px
        End If
        TNAM = Lnq & TNAM : Tx = TitlesOpen : Px = " )"
        NFOR = SX & Tx & FR & TNAM
        If InStr(Str, "SELECT", CompareMethod.Text) <> 0 Or InStr(Str, "WHERE", CompareMethod.Text) <> 0 Then Exit Function
        If GroupBy = True Then
            If GrpT = "" Then GrpT = "" Else GrpT = " GROUP BY " & GrpT
        Else
            If GrpT = "" Then GrpT = "" Else GrpT = " ORDER BY " & GrpT
        End If
        If Trim(Str) = "" Then
            If FQA = True Then
                Sql = NFOR & " WHERE ( " & "[" & T.Columns(0).ColumnName.ToString & "] IS NULL" & Px
            Else
                If GrpT = "" Then Sql = NFOR Else Sql = NFOR & GrpT
            End If
        Else
            If GrpT <> "" Then
                If GroupBy = True Then Sql = NFOR & GrpT & W & Str & Px Else Sql = NFOR & W & Str & Px & GrpT
            Else
                Sql = NFOR & W & Str & Px & GrpT
            End If
        End If
        Sql_Convert_For_Adp = Sql.ToUpper.Trim
        BSql = Str 'NEW ADD
    End Function
    Public Function Sql_Convert_For_Adp(ByVal TableName As String, ByVal Str As String, Optional ByVal TitlesOpen As String = "*", Optional ByVal Only_Query_Enable As Boolean = True, Optional ByVal OrderByFileds As String = "", Optional ByVal GroupBy As Boolean = False, Optional ByVal TopLoad As Integer = 0, Optional ByVal Percent As Boolean = False, Optional ByVal OnlyDis As Boolean = False, Optional ByVal DisRow As Boolean = False)
        Dim GrpT As String = OrderByFileds
        Dim TNAM As String = "[" & TableName & "]"
        Dim Px, Tx, Lnq As String
        Dim FQA As Boolean = Only_Query_Enable
        If OnlyDis = True Then Lnq = " Distinct "
        Dim W, FR, SX As String
        Dim NFOR As String
        If GroupBy = False Then W = " WHERE ( " Else W = " HAVING ( "
        FR = " FROM "
        SX = "SELECT "
        If DisRow = True Then
            Lnq = " DISTINCTROW "
        Else
            If Percent = True Then Px = " PERCENT" Else Px = ""
            If TopLoad > 0 Then Tx = "TOP " & TopLoad Else Tx = ""
            Lnq = Tx & Px
        End If
        TNAM = Lnq & TNAM : Tx = TitlesOpen : Px = " )"
        NFOR = SX & Tx & FR & TNAM
        If InStr(Str, "SELECT", CompareMethod.Text) <> 0 Or InStr(Str, "WHERE", CompareMethod.Text) <> 0 Then Exit Function
        If GroupBy = True Then
            If GrpT = "" Then GrpT = "" Else GrpT = " GROUP BY " & GrpT
        Else
            If GrpT = "" Then GrpT = "" Else GrpT = " ORDER BY " & GrpT
        End If
        If Trim(Str) = "" Then
            If FQA = True Then
                Sql = NFOR & " WHERE ( " & " 0 IS NULL" & Px
            Else
                If GrpT = "" Then Sql = NFOR Else Sql = NFOR & GrpT
            End If
        Else
            If GrpT <> "" Then
                If GroupBy = True Then Sql = NFOR & GrpT & W & Str & Px Else Sql = NFOR & W & Str & Px & GrpT
            Else
                Sql = NFOR & W & Str & Px & GrpT
            End If
        End If
        Sql_Convert_For_Adp = Sql.ToUpper.Trim
    End Function
    Public Function Datatable_Nulls_only(ByVal Title As String, Optional ByVal Null As Boolean = True)
        Dim Str1 As String
        If Null = True Then
            Str1 = UCase("([" & Title & "] IS NULL)")
        Else
            Str1 = UCase("([" & Title & "] IS NOT NULL)")
        End If
        Datatable_Nulls_only = Str1
    End Function
    Public Function Normal_Format(ByVal Db1 As DataTable, ByVal Title As Object, ByVal Fstr As String, Optional ByVal Sign As String = "=", Optional ByVal Fr1 As String = "'", Optional ByVal Fr2 As String = "'", Optional ByVal LikeTr As Boolean = False)
        Dim Str As String
        Dim Tit As String = Title
        If For_OnlyMainSql_Title <> "" Then
            Title = For_OnlyMainSql_Title
            Fr1 = ""
            Fr2 = ""
        Else
            Title = "[" & Title & "]"
        End If
        If LikeTr = True Then
            Sign = " LIKE "
        End If
        If Get_DataType_Str(Db1, Tit) = True Then
            If Fstr = "" Then
                If Sign = "=" Then
                    Str = Datatable_Nulls_only(Tit, True)
                    Return Str
                    Exit Function
                ElseIf Sign = "<>" Then
                    Str = Datatable_Nulls_only(Tit, False)
                    Return Str
                    Exit Function
                End If
                Str = Title & Sign & Fr1 & Fstr & Fr2
            Else
                Str = Title & Sign & Fr1 & Fstr & Fr2
                Return Str
                Exit Function
            End If
        Else
            If Fstr = "" Then
                Fstr = 0
            End If
            If Sign.ToUpper = " LIKE " Then
                Str = Title & Sign & Fr1 & Fstr & Fr2
            Else
                If WGeT = "DateTime" Then
                    Str = Title & Sign & "#" & Dat2(Fstr) & "#"
                ElseIf WGeT = "Boolean" Then
                    If Fstr.ToLower = "y" Or Fstr.ToLower = "true" Or Fstr.ToLower = "tr" Or Fstr.ToLower = "t" Or Fstr.ToLower = "yes" Or Fstr.ToLower = "c" Or Fstr.ToLower = "check" Or Fstr.ToLower = "checked" Or Fstr.ToLower = "1" Then
                        Fstr = "TRUE"
                    Else
                        Fstr = "FALSE"
                    End If
                    Str = Title & Sign & Fstr
                Else
                    Str = Title & Sign & Fstr
                End If
            End If
        End If
        Normal_Format = UCase(Str)
        WGeT = Normal_Format
    End Function
    Public Function GetFunction_QrText(ByVal Db1 As DataTable, ByVal Title As Object, ByVal Fstr As String, Optional ByVal Func As Integer = 0, Optional ByVal Sign As String = "=", Optional ByVal ChecksAutoMaticNumer As Boolean = False, Optional ByVal ComplexKey As String = ",", Optional ByVal SWildCard As String = "%", Optional ByVal UseBrackets As Boolean = True)
        ' if query is complex then ComplexKey=";"
        On Error Resume Next
        Dim Str As String
        Dim Ua As Array
        Dim Qt_MainT As Boolean = False
        Dim Title2 As String = GetTableColumn_NameString(Db1, Title)
        'Dim Sp1 As String = "[" & Db1.TableName.ToUpper & "]."
        If UseBrackets = True Then Title = "[" & Title2 & "]" Else Title = Title2
        If Sign = "" Then Sign = "="
        If Func = 0 Then
            Str = Normal_Format(Db1, Title2, Fstr, Sign)
        ElseIf Func = 1 Then
            Str = Normal_Format(Db1, Title2, Fstr, Sign, "'", SWildCard & "'", True)
        ElseIf Func = 2 Then
            Str = Normal_Format(Db1, Title2, Fstr, Sign, "'" & SWildCard, SWildCard & "'", True)
        ElseIf Func = 3 Then
            Str = AukF.Advance_Search(Fstr, Title2, Db1, "AND", " ", False, SWildCard, SWildCard, False, Sign, True)
        ElseIf Func = 4 Then
            'Str = AukF.Advance_Search(Fstr, Title2, Db1, "AND", " ", False, "")
            Str = AukF.Advance_Search(Fstr, Title2, Db1, "AND", " ", False, "", SWildCard, False, Sign, True)
        ElseIf Func = 5 Then
            'Str = AukF.Advance_Search(Fstr, Title2, Db1, "OR", " ", False)
            Str = AukF.Advance_Search(Fstr, Title2, Db1, "OR", " ", False, SWildCard, SWildCard, False, Sign, True)
        ElseIf Func = 6 Then
            'Str = AukF.Advance_Search(Fstr, Title2, Db1, "OR", " ", False, "")
            Str = AukF.Advance_Search(Fstr, Title2, Db1, "OR", " ", False, "", SWildCard, False, Sign, True)
        ElseIf Func = 7 Then 'Chr Array(And)
            Str = AukF.Advance_Search(Fstr, Title2, Db1, "AND", " ", True, SWildCard, SWildCard, False, Sign)
            'Str = AukF.Advance_Search(Fstr, Title2, Db1, "OR", " ", False, SWildCard , SWildCard , False, Sign, True)
        ElseIf Func = 8 Then 'IN COMMAND
            Dim Nstr As String = ""
            If Sign = "<>" Then Nstr = " NOT "
            If Get_DataType_Str(Db1, Title2) = False Then
                If ChecksAutoMaticNumer = True Then
                    Ua = Fstr.Split(ComplexKey)
                    For k As Integer = 0 To Ua.GetUpperBound(0)
                        If WGeT = "DateTime" Then
                            Ua.SetValue("#" & Dat2(Ua.GetValue(k)) & "#", k)
                        Else
                            Ua.SetValue(CStr(Val(Ua.GetValue(k))), k)
                        End If
                    Next
                    Fstr = SrGens.ArrayToStr(Ua, ",")
                End If
                Str = Title & Nstr & " In (" & Fstr & ")"
            Else
                If ChecksAutoMaticNumer = True Then
                    Ua = Fstr.Split(ComplexKey)
                    Fstr = SrGens.ArrayToStr(Ua, ",", "'", "'")
                End If
                Str = Title & Nstr & " In (" & Fstr & ")"
            End If
        ElseIf Func = 9 Then 'Chr Array(or & Exact)'such a InCommand Style
            Str = AukF.Advance_Search(Fstr, Title2, Db1, "OR", ComplexKey, True, "", "", False, Sign, False)
        ElseIf Func = 10 Then 'between opt
            Dim Nstr As String = ""
            If Sign = "<>" Then Nstr = " NOT "
            'Str = AukF.Advance_Search(Fstr, Title2, Db1, "OR", ";", True, "", "", False, Sign, False)
            Ua = Fstr.Split(ComplexKey)
            If Ua.GetUpperBound(0) >= 1 Then
                d1 = ArV(Ua, 0)
                d2 = ArV(Ua, 1)
            Else
                GetFunction_QrText = ""
                MsgBox("Please type atleast 2 object as (object" & ComplexKey & "object)", MsgBoxStyle.Critical, "Please see the Between format")
                Exit Function
            End If
            If Get_DataType_Str(Db1, Title2) = True Then
                N1 = "'"
            Else
                If WGeT = "DateTime" Then
                    n1 = "#"
                Else
                    n1 = ""
                End If
            End If
            Str = Title & Nstr & " BETWEEN " & N1 & D1 & N1 & " AND " & N1 & D2 & N1
        ElseIf Func = 11 Then 'Chr Array(Or)
            Str = AukF.Advance_Search(Fstr, Title2, Db1, "OR", " ", True, SWildCard, SWildCard, False, Sign)
        ElseIf Func = 12 Then 'auk advance 2 complex query system
            Str = AukF.Advance_Search(Fstr, Title2, Db1, "AND", " ", False, SWildCard, SWildCard, False, Sign, True, ";")
        End If
        If Trim(Str) <> "" Then
            GetFunction_QrText = CStr(UCase(Str))
        Else
            GetFunction_QrText = ""
        End If
    End Function
    Public Sub Serial_DataGrid_Selected_Cells(ByVal D As DataGridView)
        Dim T As DataTable = AukF.Get_DataSystemObj(D)
        Dim C As Decimal
        C = (SoftIn.Maximum_Count_FromOpened_TableOnly(T, D.CurrentCell.ColumnIndex))
        For k As Integer = 0 To D.SelectedCells.Count - 1
            C = k + 1
            D.SelectedCells(k).Value = C
        Next
    End Sub
    Public Function Maximum_Count_FromOpened_TableOnly(ByVal T As DataTable, ByVal Field As Object) As Decimal
        Field = SoftIn.GetTableColumn_NameString(T, Field)
        Try
            c = T.Compute("Max(" & Field & ")", "")
            Return c
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Sub SELECTED_CELLS_UPPERCASE(ByVal D As DataGridView)
        For K As Integer = 0 To D.SelectedCells.Count - 1
            If TypeOf (D.SelectedCells(K).Value) Is DBNull Then
            Else
                D.SelectedCells(K).Value = UCase(CStr(D.SelectedCells(K).Value))
            End If
        Next
    End Sub
    Public Sub SELECTED_CELLS_LowerCase(ByVal D As DataGridView)
        For K As Integer = 0 To D.SelectedCells.Count - 1
            If TypeOf (D.SelectedCells(K).Value) Is DBNull Then
            Else
                D.SelectedCells(K).Value = LCase(CStr(D.SelectedCells(K).Value))
            End If
        Next
    End Sub
    Public Sub SELECTED_CELLS_COMMON_TXT(ByVal D As DataGridView, ByVal STR As String)
        For K As Integer = 0 To D.SelectedCells.Count - 1
            D.SelectedCells(K).Value = STR
        Next
    End Sub
    'Public Sub SELECTED_Cells_AddingSomething(ByVal D As DataGridView, ByVal STR As String, Optional ByVal EntryWith As Boolean = False, Optional ByVal Entrybefore As Boolean = False)
    '    Dim R As DataGridViewCell
    '    For K As Integer = 0 To D.SelectedCells.Count - 1
    '        R = D.SelectedCells(K)
    '        AukF.Grid_EntrySomething(R, STR, EntryWith, Entrybefore)

    '    Next
    'End Sub
    Public Sub Select_GridRows(ByVal Grd As Object, ByVal Row As Integer)
        'Dim R As DataGridView
        If Grd Is Nothing Then Exit Sub
        If Row > -1 Then
            If TypeOf (Grd) Is DataGrid Then
                Grd.Select(Row)
            ElseIf TypeOf (Grd) Is DataGridView Then
                Grd.Rows(Row).Selected = True
            End If
        End If

    End Sub

    Public Function Boolean_get(ByVal Str1 As Object) As Boolean
        If Val(Str1) = 1 Or InStr(Str1, "t", CompareMethod.Text) > 0 Or InStr(Str1, "y", CompareMethod.Text) > 0 Then
            Return True
        End If
    End Function
    Public Sub SELECTED_CELLS_Replace_text(ByVal D As DataGridView, ByVal FindT As String, ByVal ReplaceT As String, Optional ByVal Match As Boolean = False)
        For K As Integer = 0 To D.SelectedCells.Count - 1
            If Match = False Then
                D.SelectedCells(K).Value = Replace(D.SelectedCells(K).Value.ToString, FindT, ReplaceT, 1, -1, CompareMethod.Text)
            Else
                D.SelectedCells(K).Value = Replace(D.SelectedCells(K).Value.ToString, FindT, ReplaceT, 1, -1, CompareMethod.Binary)
            End If
        Next
    End Sub
    Public Sub SELECTED_CELLS_Replace_text_By_Column(ByVal D As DataGridView, ByVal Column As Integer, ByVal FindT As String, ByVal ReplaceT As String, Optional ByVal Match As Boolean = False, Optional ByVal UseAll_Rows As Boolean = False, Optional ByVal Dont_RrpArrStr As String = "")
        Dim Rd As DataGridViewRow
        'Dim Int1, Int2 As Integer
        If UseAll_Rows = False Then
gotoN:      For K As Integer = 0 To D.SelectedRows.Count - 1
                Rd = D.SelectedRows(K)
                'If Dont_RrpArrStr <> "" Then
                a = Rd.Cells(Column).Value.ToString
                If AukF.FindTxt(a, Dont_RrpArrStr, Match) = False Then
                    If Match = False Then
                        Rd.Cells(Column).Value = Replace(Rd.Cells(Column).Value.ToString, FindT, ReplaceT, 1, -1, CompareMethod.Text)
                    Else
                        Rd.Cells(Column).Value = Replace(Rd.Cells(Column).Value.ToString, FindT, ReplaceT, 1, -1, CompareMethod.Binary)
                    End If
                End If
                'End If
            Next
        Else
            For K As Integer = 0 To D.RowCount - 1
                Rd = D.Rows(K)
                'If Dont_RrpArrStr <> "" Then
                a = CStr(Rd.Cells(Column).Value)
                If AukF.FindTxt(a, Dont_RrpArrStr, Match) = False Then
                    If Rd.Cells(Column).Value Is DBNull.Value Then
                        x = ""
                    Else
                        x = CStr(Rd.Cells(Column).Value)
                    End If
                    If Match = False Then
                        xrep = Replace(x, FindT, ReplaceT, 1, -1, CompareMethod.Text)
                        Rd.Cells(Column).Value = xrep
                    Else
                        Rd.Cells(Column).Value = Replace(x, FindT, ReplaceT, 1, -1, CompareMethod.Binary)
                    End If
                End If
                'End If

            Next
        End If

    End Sub
    Public Sub SELECTED_CELLS_Replace_text_Format(ByVal D As DataGridView, ByVal TextFormat As String, Optional ByVal Key As String = ",")
        If Trim(TextFormat) = "" Then Exit Sub
        Dim Str() As String
        Str = TextFormat.Split(Key)
        If Str IsNot Nothing Then
            SELECTED_CELLS_Replace_text(D, ArV(Str, 0), ArV(Str, 1), Boolean_get(ArV(Str, 2).ToString))
        End If
    End Sub
    Public Sub SELECTED_CELLS_Replace_MultiTexts(ByVal D As DataGridView, ByVal ColumnsArrarY As String, ByVal FindArray As String, ByVal RepArray As String, Optional ByVal MatchsArraY As String = "", Optional ByVal USeAllRows As Boolean = False, Optional ByVal Dont_ReplaceArrayStr As String = "", Optional ByVal Key As String = ",")
        If Trim(ColumnsArrarY) = "" Then Exit Sub
        Dim Col(), Fnd(), Mat(), Rep(), DnRp(), Colx, Matx, Fndx, Repx, DnRpx As String
        Col = Split(ColumnsArrarY, Key)
        Fnd = Split(FindArray, Key)
        Rep = Split(RepArray, Key)
        Mat = Split(MatchsArraY, Key)
        If Dont_ReplaceArrayStr <> "" Then DnRp = Split(Dont_ReplaceArrayStr, Key) Else DnRp = Nothing
        'boolenad get or check_val
        If Col IsNot Nothing And Fnd IsNot Nothing Then
            For K As Integer = 0 To Col.GetUpperBound(0)
                Colx = ArV2(Col, K)
                Fndx = ArV2(Fnd, K)
                Repx = ArV2(Rep, K)
                Matx = AukF.CheckVal_GetBool(ArV2(Mat, K, False))
                If DnRp IsNot Nothing Then
                    DnRpx = ArV2(DnRp, K)
                Else
                    DnRpx = ""
                End If
                SELECTED_CELLS_Replace_text_By_Column(D, CInt(Colx), Fndx, Repx, CBool(Matx), USeAllRows, DnRpx)

            Next
        End If
    End Sub
    Public Function Replace_MultiTexts(ByVal Text As String, ByVal FindArray As String, ByVal RepArray As String, Optional ByVal MatchsArraY As String = "", Optional ByVal Key As String = ",")
        'If Trim(ColumnsArrarY) = "" Then Exit Function
        Dim Fnd(), Mat(), Rep(), Fndx, Repx As String
        Dim Matx As Boolean
        'Col = Split(ColumnsArrarY, Key)
        Fnd = Split(FindArray, Key)
        Rep = Split(RepArray, Key)
        Mat = Split(MatchsArraY, Key)
        'boolenad get or check_val
        If Fnd IsNot Nothing Then
            For K As Integer = 0 To Fnd.GetUpperBound(0)
                'Colx = ArV2(Col, K)
                Fndx = ArV2(Fnd, K)
                Repx = ArV2(Rep, K)
                Matx = AukF.CheckVal_GetBool(ArV2(Mat, K, False))
                If Matx = True Then
                    Text = Replace(Text, Fndx, Repx, 1, -1, CompareMethod.Text)
                Else
                    Text = Replace(Text, Fndx, Repx, 1, -1, CompareMethod.Binary)
                End If
            Next
            Return Text
        Else
            Return Text
        End If
    End Function
    'Public Function Split_by_Key(ByVal Textx As String, ByVal Key As String)
    '    If Trim(Textx) = "" Then Return Nothing

    'End Function
    Public Function GetChages(ByVal Obj As Object) As Boolean
        'Dim T As DataTable = AukF.Get_DataSystemObj(Obj)
        If TypeOf (Obj) Is BindingSource Then
            Obj = AukF.Get_DataSystemObj(Obj)
        End If
        If Obj Is Nothing Then MsgBox("INTERNAL ERROR ON AUK _ GETCHANGES DATA.OBJECT IS NOTHING .", MsgBoxStyle.Critical) : Exit Function
        If Obj.GetChanges IsNot Nothing Then
            GetChages = True
        Else
            GetChages = False
        End If
    End Function
    Public Function Replace_Database_FieldsNamesByNumber(ByVal T As DataTable, ByVal Nums As String, Optional ByVal UseTBrackets As Boolean = False, Optional ByVal Key As String = ",") As String
        Dim A As Array
        Dim Str As String = ""
        Dim B1, B2 As String
        If Nums = "" Then Return ""
        If UseTBrackets = True Then B1 = "[" : B2 = "]" Else B1 = "" : B2 = ""
        A = Split(Nums, Key)
        Str = Nothing
        For k As Integer = 0 To A.GetUpperBound(0)
            If Str = "" Then Str = B1 & A.GetValue(k) & B2 Else Str = Str & "," & B1 & A.GetValue(k) & B2
        Next
        Replace_Database_FieldsNamesByNumber = Str
    End Function
    Public Function Replace_Database_FieldsNamesByNumber_FromArray(ByVal T As DataTable, ByVal Nums() As String, Optional ByVal UseTBrackets As Boolean = False, Optional ByVal Key As String = ",") As String
        Dim A As Array
        Dim Str As String = ""
        Dim B1, B2 As String
        If Nums Is Nothing Then Return ""
        If UseTBrackets = True Then B1 = "[" : B2 = "]" Else B1 = "" : B2 = ""
        A = Nums
        Str = Nothing
        For k As Integer = 0 To A.GetUpperBound(0)
            If Str = "" Then Str = B1 & A.GetValue(k) & B2 Else Str = Str & "," & B1 & A.GetValue(k) & B2
        Next
        Return Str
    End Function
    Public Function DataGrid_MasterID(ByVal D As DataGridView, ByVal MasterColumn As Integer, ByVal Expression_GetFrom As String, Optional ByVal Key As String = ",", Optional ByVal AddWithSomething As String = "")
        Dim M As Integer = MasterColumn
        Dim A As Array
        Dim Aq As Integer
        Dim Str, S, MTxt As String
        If D.CurrentCell.DataGridView(M, D.CurrentCell.RowIndex).Value.ToString <> "" Then
            A = Expression_GetFrom.Split(Key)
            For Aq = 0 To A.GetUpperBound(0)
                Str = A.GetValue(Aq).ToString
                If Str.ToCharArray(0, 1) = "[" And Str.ToCharArray(Str.Length, 1) = "]" Then
                    S = Str.Replace("[", "")
                    S = S.Replace("]", "")
                    Aq = S
                    If MTxt = "" Then
                        MTxt = D.CurrentCell.DataGridView(Aq, D.CurrentCell.RowIndex).Value.ToString
                    Else
                        MTxt = MTxt & AddWithSomething & D.CurrentCell.DataGridView(Aq, D.CurrentCell.RowIndex).Value.ToString
                    End If
                Else
                    If MTxt = "" Then
                        MTxt = Str
                    Else
                        MTxt = MTxt & AddWithSomething & Str
                    End If
                End If
            Next
        End If
    End Function
    Public Function ToObject_MasterID_ByDate(Optional ByVal TObj As Object = Nothing, Optional ByVal AMCon As String = "1", Optional ByVal PmCon As String = "2", Optional ByVal FindTxt As String = Nothing, Optional ByVal RepText As String = Nothing)

        Dim Cstr1, Sm1 As String
        Dim A1, A2, ReplaceFinderArray, ReplaceTextArray As Array

        Cstr1 = Now.ToString
        Cstr1 = Cstr1.Replace("AM", AMCon)
        Cstr1 = Cstr1.ToUpper.Replace("PM", PmCon)
        If ReplaceFinderArray IsNot Nothing And ReplaceTextArray IsNot Nothing Then
            ReplaceFinderArray = FindTxt.Split(",")
            ReplaceTextArray = RepText.Split(",")
            For k As Integer = 0 To ReplaceFinderArray.GetUpperBound(0)
                Cstr1 = Cstr1.Replace(ReplaceFinderArray.GetValue(k), ReplaceTextArray.GetValue(k))
            Next
        Else
            Sm1 = " ,/,:,-"
            A1 = Sm1.Split(",")
            Sm1 = ",,,"
            A2 = Sm1.Split(",")
            ReplaceFinderArray = A1
            ReplaceTextArray = A2
            For k As Integer = 0 To ReplaceFinderArray.GetUpperBound(0)
                Cstr1 = Cstr1.Replace(ReplaceFinderArray.GetValue(k), ReplaceTextArray.GetValue(k))
            Next
        End If
        If TObj IsNot Nothing Then
            Try
                TObj.text = Cstr1
            Catch ex As Exception
                Try
                    TObj = Cstr1
                Catch exa As Exception
                    Epx(exa.Message.ToString)
                End Try

            End Try
        End If

        ToObject_MasterID_ByDate = Cstr1
    End Function
    'Public Function DataGrid_MasterID_ByDate(ByVal D As DataGrid, Optional ByVal MColumn As Integer = 0, Optional ByVal AMCon As String = "1", Optional ByVal PmCon As String = "2", Optional ByVal ReplaceFinderArray As Array = Nothing, Optional ByVal ReplaceTextArray As Array = Nothing, Optional ByVal MasterColumnVisibleFalse As Boolean = True)

    '    Dim Cstr1, Sm1 As String
    '    Dim A1, A2 As Array
    '    Cstr1 = Now.ToString
    '    Cstr1 = Cstr1.Replace("AM", AMCon)
    '    Cstr1 = Cstr1.ToUpper.Replace("PM", PmCon)
    '    If ReplaceFinderArray IsNot Nothing And ReplaceTextArray IsNot Nothing Then
    '        For k As Integer = 0 To ReplaceFinderArray.GetUpperBound(0)
    '            Cstr1 = Cstr1.Replace(ReplaceFinderArray.GetValue(k), ReplaceTextArray.GetValue(k))
    '        Next
    '    Else
    '        Sm1 = " ,/,:"
    '        A1 = Sm1.Split(",")
    '        Sm1 = ",0,2"
    '        A2 = Sm1.Split(",")
    '        ReplaceFinderArray = A1
    '        ReplaceTextArray = A2
    '        For k As Integer = 0 To ReplaceFinderArray.GetUpperBound(0)
    '            Cstr1 = Cstr1.Replace(ReplaceFinderArray.GetValue(k), ReplaceTextArray.GetValue(k))
    '        Next
    '    End If
    '    Try
    '        sml = D(D.CurrentRowIndex, MColumn).ToString
    '    Catch ex As Exception
    '        sml = ""
    '    End Try
    '    Try
    '        If sml = "" Or sml = "(null)" Or sml = "null" Then
    '            D(D.CurrentRowIndex, MColumn) = Cstr1

    '        End If
    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Function
    Public Function DataGrid_MasterID_ByDate(ByVal D As DataGridView, ByVal MaxLen As Integer, Optional ByVal MColumn As Integer = 0)
        If AukF.GridT(D, MColumn) <> "" Then Exit Function
        Dim Cstr1 As String
        'Dim A1, A2 As Array
        'Cstr1 = Now.ToString
        'Cstr1 = Cstr1.Replace("AM", AMCon)
        'Cstr1 = Cstr1.ToUpper.Replace("PM", PmCon)
        'If ReplaceFinderArray IsNot Nothing And ReplaceTextArray IsNot Nothing Then
        '    For k As Integer = 0 To ReplaceFinderArray.GetUpperBound(0)
        '        Cstr1 = Cstr1.Replace(ReplaceFinderArray.GetValue(k), ReplaceTextArray.GetValue(k))
        '    Next
        'Else
        '    Sm1 = " ,/,:,-"
        '    A1 = Sm1.Split(CChar(","))
        '    Sm1 = ",0,2,1"
        '    A2 = Sm1.Split(CChar(","))
        '    ReplaceFinderArray = A1
        '    ReplaceTextArray = A2
        '    For k As Integer = 0 To ReplaceFinderArray.GetUpperBound(0)
        '        Cstr1 = Cstr1.Replace(ReplaceFinderArray.GetValue(k), ReplaceTextArray.GetValue(k))
        '    Next
        'End If
        Cstr1 = Now.Day & (Now.Day + Now.Second) & Now.Month & Now.Hour & Now.Year & Now.Second & Left(Now.Millisecond, 2) & Now.Minute & Now.Second
        Try
            If AukF.GridT(D, MColumn) = "" Then
                If DRow > -1 Then D(MColumn, DRow).Value = Left(Cstr1, MaxLen)
            End If
        Catch ex As Exception
            Epx()
        End Try
    End Function
    Public Function TxtColor(ByVal Obj As Object, ByVal FndTxt As String, ByVal BckColor As Color, ByVal ForColor As Color, ByVal DefBColor As Color, ByVal DefForColor As Color, Optional ByVal FullMatch As Boolean = True)
        Dim Str As String
        Try
            Str = Obj.text
        Catch ex As Exception
            Str = Obj
        End Try
        If FullMatch = False Then
            If InStr(Str, FndTxt, CompareMethod.Text) > 0 Then
                ChgColr(Obj, BckColor, ForColor)
            Else
                ChgColr(Obj, DefBColor, DefForColor)
            End If
        Else
            If Str = FndTxt Then
                ChgColr(Obj, BckColor, ForColor)
            Else
                ChgColr(Obj, DefBColor, DefForColor)
            End If
        End If
    End Function
    Public Function MASTER_ID_GET_NumberOnly(ByVal D As DataGridView, Optional ByVal MColumn As Integer = 0, Optional ByVal MaxLen As Integer = 4) As Integer
        Dim StrA As String = AukF.GridT(D, MColumn)
        Dim Bp As BindingSource
        If StrA <> "" Then Exit Function
        If TypeOf (D.DataSource) Is BindingSource Then
            Bp = D.DataSource
            If AukF.BindFind(Bp, D.Columns(MColumn).DataPropertyName.ToString, CStr(DRow)) = False Then GoTo nid Else GoTo comid
        End If
nid:    D(MColumn, DRow).Value = DRow : Return DRow : Exit Function
comid:  m = Now.Millisecond : s = Now.Second : mn = Now.Minute
        If m = 0 Then m = 1
        If s = 0 Then s = 1
        If mn = 0 Then mn = 1
        b = AukF.GridT(D, MColumn, DRow - 1) : a = DRow + 1
        c = DRow * m * (m / s) * mn / s
        g = Val(c) + Val(b) + (DRow * s) + s - (m * s)
        t = Val(g) + Val(DRow) & DRow
        f = CInt(Left(t, 9))
        'MsgBox(Right(CStr(TimeOfDay), 2), , f / (m / 100))
        If Right(CStr(TimeOfDay), 2) = "AM" Then
            If (S / 10) <= 1 Then
                f = f / (m / 100) / s
            ElseIf (S / 10) <= 2 Then
                f = f / Rnd(m * 100 * s)
            ElseIf (S / 10) <= 3 Then
                f = f / Rnd(109)
            ElseIf (S / 10) <= 4 Then
                f = f / Rnd(512)
            ElseIf (S / 10) <= 5 Then
                f = f / Rnd(11111)
            Else
                f = f / Rnd(Now.Millisecond * Now.Second)
            End If
        End If
        If Val(F) < 0 Then F = F * -1
        'MsgBox(f)
        exa = Left(f, MaxLen)
        exa = CInt(Val(exa))
        If EXA = 0 Then
            m = Now.Millisecond : s = Now.Second : mn = Now.Minute
            If m = 0 Then m = 1
            If s = 0 Then s = 1
            EXA = S * M
        End If
        D(MColumn, DRow).Value = exa
        Return exa
    End Function
    Public Function MasterID_Number_FromDate_Auto(Optional ByVal MaxLen As Integer = 8)
        Dim Mx As String
        Mx = Now.Day & Now.Month & Now.Year & Now.Hour & Now.Second & Now.Millisecond & Now.Millisecond + Now.Second & Now.Millisecond + Rnd(Now.Second + Now.Millisecond)
        Return Val(Left(Mx, MaxLen))
    End Function
    Public Function MasterID_Number_Auto(Optional ByVal MaxLen As Integer = 8) As Object
comid:  m = Now.Millisecond : s = Now.Second : mn = Now.Minute
        If m = 0 Then m = 1
        If s = 0 Then s = 1
        If mn = 0 Then mn = 1
        a = DRow + 1
        c = DRow * m * (m / s) * mn / s
        g = Val(c) + Val(b) + (DRow * s) + s - (m * s)
        t = Val(g) + Val(Now.Millisecond) & Now.Second
        f = CInt(Left(t, 9))
        'MsgBox(Right(CStr(TimeOfDay), 2), , f / (m / 100))
        If Right(CStr(TimeOfDay), 2) = "AM" Then
            If (S / 10) <= 1 Then
                f = f / (m / 100) / s
            ElseIf (S / 10) <= 2 Then
                f = f / Rnd(m * 100 * s)
            ElseIf (S / 10) <= 3 Then
                f = f / Rnd(109)
            ElseIf (S / 10) <= 4 Then
                f = f / Rnd(512)
            ElseIf (S / 10) <= 5 Then
                f = f / Rnd(11111)
            Else
                f = f / Rnd(Now.Millisecond * Now.Second)
            End If
        End If
        'If Val(F) < 0 Then F = F * -1
        'MsgBox(f)
        exa = Left(f, MaxLen)
        exa = CInt(Val(exa))
worklen: If Len(exa) < MaxLen Then exa = exa & Now.Day & Now.Second & Now.Millisecond & Now.Millisecond + Now.Hour & Now.Year & Now.Millisecond
        exa = Replace(exa, ".", "")
        exa = Left(f, MaxLen)
        If Len(exa) < MaxLen Then GoTo worklen
        Return exa
    End Function
    Public Function Previous_data_input(ByVal Bp As BindingSource, ByVal T As DataTable, Optional ByVal COLUMN As Integer = -1)
        Dim L, P As Integer
        Dim NLX As Boolean = False
        If Bp.Count > 0 Then
            If Bp.Count = -1 Then Exit Function
            P = Bp.Position
            L = P - 1
            If L < 0 Then Exit Function
            If COLUMNS = -1 Then
                If Val(L) >= 0 Then
                    If (T.Rows.Count - 1) < P Then Exit Function
                    For k As Integer = 1 To T.Columns.Count - 1
                        If TypeOf (T.Rows(L).Item(k)) Is DBNull Then NLX = True Else NLX = False
                        If (TypeOf (T.Rows(P).Item(k)) Is DBNull) And NLX = False Then
                            T.Rows(P).Item(k) = T.Rows(L).Item(k)
                        End If
                    Next
                End If
            Else
                If (T.Rows.Count - 1) < P Then Exit Function
                If TypeOf (T.Rows(L).Item(COLUMN)) Is DBNull Then NLX = True Else NLX = False
                If TypeOf (T.Rows(P).Item(COLUMN)) Is DBNull Then
                    If NLX = False Then T.Rows(P).Item(COLUMN) = T.Rows(L).Item(COLUMN)
                End If
            End If
        End If
    End Function
    Public Function TOOLSTRIP_COMBO_DATASOURCE(ByVal COM As Object, ByVal Table As Object, ByVal BIND_C As Integer, Optional ByVal CLEARBEFORE As Boolean = True, Optional ByVal UNIQUE As Boolean = False)
        Dim T1 As DataTable = AukF.Get_DataSystemObj(Table)
        If CLEARBEFORE = True Then COM.Items.Clear()
        For K As Integer = 0 To T1.Rows.Count - 1
            If UNIQUE = True Then
                AukF.UniqueAdd(COM, T1.Rows(K).Item(BIND_C).ToString)
            Else
                COM.Items.Add(T1.Rows(K).Item(BIND_C).ToString)
            End If
        Next
        AukF.ComSelIndex(COM)

    End Function
    Public Function TxtColor_NumberDefine(ByVal Obj As Object, ByVal FndTxt As Double, ByVal BckColor As Color, ByVal ForColor As Color, ByVal DefBColor As Color, ByVal DefForColor As Color, Optional ByVal RuleAbide As String = "=")
        RuleAbide = LCase(RuleAbide)
        Dim Str As String
        Try
            Str = Obj.text
        Catch ex As Exception
            Str = Obj
        End Try
        If RuleAbide = "=" Then
            If Val(Str) = FndTxt Then
                ChgColr(Obj, BckColor, ForColor)
            Else
                ChgColr(Obj, DefBColor, DefForColor)
            End If
        ElseIf RuleAbide = ">" Or RuleAbide = "g" Then
            If Val(Str) > FndTxt Then
                ChgColr(Obj, BckColor, ForColor)
            Else
                ChgColr(Obj, DefBColor, DefForColor)
            End If
        ElseIf RuleAbide = "<" Or RuleAbide = "l" Then
            If Val(Str) < FndTxt Then
                ChgColr(Obj, BckColor, ForColor)
            Else
                ChgColr(Obj, DefBColor, DefForColor)
            End If
        ElseIf RuleAbide = ">=" Or RuleAbide = "eg" Or RuleAbide = "ge" Then
            If Val(Str) >= FndTxt Then
                'MsgBox("ok")

                ChgColr(Obj, BckColor, ForColor)
            Else
                ChgColr(Obj, DefBColor, DefForColor)
            End If
        ElseIf RuleAbide = "<=" Or RuleAbide = "el" Or RuleAbide = "le" Then
            If Val(Str) <= FndTxt Then
                ChgColr(Obj, BckColor, ForColor)
            Else
                ChgColr(Obj, DefBColor, DefForColor)
            End If

        Else
            If Str = FndTxt Then
                ChgColr(Obj, BckColor, ForColor)
            Else
                ChgColr(Obj, DefBColor, DefForColor)
            End If
        End If
    End Function
    Public Function ChgColr(ByVal Obj As Object, ByVal BColor As Color, ByVal FColor As Color)
        Try
            Obj.forecolor = FColor
            Obj.backcolor = BColor
        Catch ex As Exception
            'Epx()
        End Try
    End Function
    Public Function DataGrid_DataPropertyName_Add(ByVal Lst As Object, ByVal D As DataGridView, Optional ByVal Separete As String = "")
        'Dim T As DataTable = AukF.Get_DataSystemObj(Bp)
        Dim LSt2 As Array
        Dim Aq, CL As Integer
        Lst.Items.Clear()
        If Separete <> "" Then
            LSt2 = Separete.Split(",")
        End If
        For Aq = 0 To D.ColumnCount - 1
            'MsgBox(Aq)
            CL = LSt2.IndexOf(LSt2, Aq).ToString
            If CL = -1 Then
                Lst.Items.Add(D.Columns(Aq).DataPropertyName.ToString & "," & Aq)
            End If
        Next
        AukF.ComSelIndex(Lst)
    End Function
    Public Function CheckListBoxRelationChecked(ByVal ChkLst As CheckedListBox, ByVal BpFind As BindingSource, ByVal BpRp As System.Windows.Forms.BindingSource, ByVal FColumn As Integer, ByVal RColumn As Integer, ByVal FoundChk As Boolean, ByVal BeforeUnCheck As Boolean)
        'BpFind :from Find Item ....and BpRp is a common Binding source that any Column mustbe lined with Chklst... 
        Dim d As DataSet = BpFind.DataSource
        Dim t As String = BpFind.DataMember.ToString
        Dim t2 As String = BpRp.DataMember.ToString
        Dim tn As String = d.Tables(t2).Columns(RColumn).ColumnName.ToString
        'Dim Aq As Integer
        If BeforeUnCheck = True Then AukF.AukChkListUnCheck_Item_all(ChkLst)
        For Iw = 0 To d.Tables(t).Rows.Count - 1
            str1 = d.Tables(t).Rows(Iw).Item(FColumn).ToString
            If AukF.BindFind(BpRp, tn, str1) = True Then
                ChkLst.SetItemChecked(ComRow, FoundChk)
            End If
        Next
    End Function
    Public Function SqlToFiler_BindingSource(ByVal Bp As BindingSource, ByVal Sql As String, Optional ByVal FilterWith As Boolean = False, Optional ByVal RemoveFilter_WhenFailed As Boolean = True)
        Dim BStr As String
        Sql = Sql.ToUpper
        AukF.DivideIn_To_2(Sql, "WHERE")
        Try
            If Right(QA2, 1) = ")" And Left(QA2, 1) <> "(" Then
                QA2 = Left(QA2, Len(QA2) - 1)
            End If
            If InStr(Sql, "WHERE", CompareMethod.Text) = 0 And InStr(Sql, "Select", CompareMethod.Text) = 0 Then
                If BStr <> "" Then
                    Bp.Filter = BStr & " and (" & Sql & ")"
                Else
                    Bp.Filter = "(" & Sql & ")"
                End If
            Else
                If BStr <> "" Then
                    Bp.Filter = BStr & " and (" & QA2 & ")"
                Else
                    Bp.Filter = "(" & QA2 & ")"
                End If
            End If

        Catch ex As Exception
            If RemoveFilter_WhenFailed = True Then
                Bp.RemoveFilter()
            Else
                Bp.Filter = BStr
            End If
            Epx(QA2)
        End Try
    End Function
    'Public Function Prnt(ByVal Pr As Object, ByVal Dset As DataSet)
    '    Dim CrpT As New Object
    '    CrpT = Pr
    '    CrpT.Database.Tables(0).SetDataSource(Dset)
    'End Function
    Private Function FD(ByVal WHERE As String, ByVal FIND As String) As Boolean
        If InStr(WHERE, FIND, CompareMethod.Text) <> 0 Then
            FD = True
        Else
            FD = False
        End If
    End Function
    Public Function COM_OBJECT_ADD_EQUAL_SYSTEM(ByVal COM As Object, Optional ByVal CLR As Boolean = True, Optional ByVal dRPsTYLE As ComboBoxStyle = ComboBoxStyle.DropDownList)
        COM.Items.Clear()
        COM.Items.Add("Equals,=")
        COM.Items.Add("NotEquals,<>")
        COM.Items.Add("GreaterThan,>")
        COM.Items.Add("LowerThan,<")
        COM.Items.Add("GreaterThanEqual,>=")
        COM.Items.Add("LowerThanEqual,<=")
        COM.DropDownStyle = dRPsTYLE
        AukF.ComSelIndex(COM)
    End Function
    Public Function BindFilterByAdvanceCategory(ByVal Bp As BindingSource, ByVal TabName As String, ByVal FindText As String, ByVal Exact As RadioButton, ByVal FExact As RadioButton, ByVal AnyWhere As RadioButton, Optional ByVal Sign As String = "=", Optional ByVal withFilter As Boolean = False, Optional ByVal Func As Integer = 0, Optional ByVal Join As String = "AND", Optional ByVal Execute As Boolean = True, Optional ByVal EXTRA_ADD_QUERY As String = "") As String
        BindFilterByAdvanceCategory(Bp, TabName, FindText, Exact.Checked, FExact.Checked, AnyWhere.Checked, Sign, withFilter, Func, Join, Execute, EXTRA_ADD_QUERY)
    End Function
    Public Function BindFilterByAdvanceCategory(ByVal Bp As BindingSource, ByVal TabName As String, ByVal FindText As String, Optional ByVal Exact As Boolean = True, Optional ByVal FExact As Boolean = False, Optional ByVal AnyWhere As Boolean = False, Optional ByVal Sign As String = "=", Optional ByVal WithFilter As Boolean = False, Optional ByVal Func As Integer = 0, Optional ByVal Join As String = "AND", Optional ByVal Execute As Boolean = True, Optional ByVal EXTRA_ADD_QUERY As String = "") As String
        'On Error Resume Next
        Dim T As DataTable = AukF.GetTableFromBindingSouce(Bp)
        If Exact = True Then
            Func = 0
        End If
        If FExact = True Then
            Func = 1
        End If
        If AnyWhere = True Then
            Func = 2
        End If
        BindFilterByAdvanceCategory = AukF.BindFilter(Bp, TabName, FindText, Func, WithFilter, Sign, Join, Execute, EXTRA_ADD_QUERY)
        BSql = BindFilterByAdvanceCategory
    End Function
    Public Function GetDataTypeTableColumn(ByVal Bp As Object, ByVal Column As String) As Type
        Dim T As DataTable = AukF.Get_DataSystemObj(Bp)
        GetDataTypeTableColumn = T.Columns(Column).DataType
        WGeT = GetDataTypeTableColumn.Name.ToString
    End Function
    Public Function Get_DataType_Str(ByVal T As DataTable, ByVal Column As String) As Boolean
        'Dim T As DataTable = AukF.Get_DataSystemObj(Bp)
        'If T Is Nothing Then Return False : WGeT = "" : Exit Function
        Column = GetTableColumn_NameString(T, Column)
        Try
            If T.Columns(Column).DataType.Name = "String" Then
                Get_DataType_Str = True
            Else
                Get_DataType_Str = False
            End If
            WGeT = T.Columns(Column).DataType.Name.ToString
        Catch ex As Exception
            Epx(Column)
        End Try
        'MsgBox(WGeT)
    End Function
    Public Function Get_DataType_Str(ByVal D As DataGridView, ByVal Column As Integer) As Boolean
        'Dim T As DataTable = AukF.Get_DataSystemObj(Bp)
        'If T Is Nothing Then Return False : WGeT = "" : Exit Function
        Try
            If D.Columns(Column).ValueType.Name = "String" Then
                Get_DataType_Str = True
            Else
                Get_DataType_Str = False
            End If
            WGeT = D.Columns(Column).ValueType.Name.ToString
        Catch ex As Exception
            Epx(Column)
        End Try
        'MsgBox(WGeT)
    End Function
End Module
