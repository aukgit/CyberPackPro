Public Module AukSql
    Public Sql, BSql As String
    Public Connect As String = My.Settings.AukDatabase2ConnectionString.ToString
    Public Cn As New OleDb.OleDbConnection(Connect)
    'Public SF(), ST(), EXPRE() As String
    Public SJOIN, SF(8), ST(8), Expre(8), DTypex(8), Sumsx(8), SignX(8) As String
    'Public  As String
    Public Dont_UseLike_Number_Date As Boolean = False
    Public Adp As OleDb.OleDbDataAdapter
    Public Q_ERRORMSG As Boolean = True
    Public BracketsSql As Boolean = True
    Public Function AukSql_Main(Optional ByVal OpTitles As String = "*", Optional ByVal TableName As String = "", Optional ByVal Func As Integer = 0) As String
        If Val(OpTitles) = -1 Then OpTitles = "*"
        Dim ColStr(8) As String
        Dim Q, F1, F2, T As String
        Dim Nt As String
        Dim NotOpt As Boolean
        Dim CFUNC As Integer = -1
        l = "%"
        If SJOIN = "" Then SJOIN = "AND"
        For k As Integer = 0 To SF.GetUpperBound(0)
            If Trim(SF(k)) = "" Then GoTo fins
            If IsNumeric(SF(k)) Then T = Val(SF(k)) Else T = "[" & SF(k) & "]"
            Q = ST(k) : e = LCase(Trim(Expre(k))) : d = LCase(Trim(DTypex(k)))
            If Sumsx(k) <> "" Then T = Sumsx(k) & "(" & T & ")"
            s = SignX(k)
            'e= expressions
            'q=stc(collection)
            ' exprec e b= between command,dtc e b = boolean,dtc=n=number
            'exprec="L*"=Like*"
            'exprec="*L"=*Like"
            If s = "" Then s = "="
            If D = "s" Or d = "" Then
                F1 = "'" : F2 = "'"
                If s <> "=" Then F1 = "" : F2 = ""
            ElseIf D = "n" Then
                F1 = "" : F2 = ""
            ElseIf D = "d" Then
                F1 = " # " : F2 = " # "
                If E <> "b" Or e = "between" Then
                    Q = Dat2(Q)
                Else
                    Dim A As Array
                    A = Q.Split(",")
                    c1 = CStr(A.GetValue(0))
                    c2 = CStr(A.GetValue(1))
                    'Q = Dat2(c1) & "," & Dat2(CDate(DateAndTime.DateAdd(DateInterval.Day, 1, (CDate(c2)))))
                    Q = Dat2(c1) & "," & Dat2(c2)

                End If
            ElseIf D = "b" Then 'boolean
                F1 = "" : F2 = ""
                Q = LCase(Q)
                If Q = "y" Or Q = "yes" Or Q = "true" Or Q = "check" Or Q = "checked" Then Q = "TRUE" Else Q = "False"
            End If
            If s = "<>" Then Nt = " NOT " Else Nt = ""
            If Nt = "" Then NotOpt = False Else NotOpt = True
            If Dont_UseLike_Number_Date = True And (LCase(d) = "n" Or LCase(d) = "d" Or LCase(d) = "b") Then CFUNC = Func : Func = 0 : GoTo functionsC
            If e = "" Then
functionsC:     If Func = 0 Then
                    ColStr(k) = T & s & F1 & Q & F2
                ElseIf Func = 1 Then
                    ColStr(k) = T & Nt & " Like " & "'" & Q & l & "'"
                ElseIf Func = 2 Then
                    ColStr(k) = T & Nt & " Like " & "'" & l & Q & l & "'"
                ElseIf Func = 3 Then
                    ColStr(k) = CStr(Advance_Search_MainBp(Q, T, TableName, "AND", " ", False, l, l, NotOpt))
                ElseIf Func = 4 Then
                    ColStr(k) = CStr(Advance_Search_MainBp(Q, T, TableName, "AND", " ", False, "", l, NotOpt))
                ElseIf Func = 5 Then
                    ColStr(k) = CStr(Advance_Search_MainBp(Q, T, TableName, "OR", " ", False, l, l, NotOpt)) 'chr=false,or,any
                ElseIf Func = 6 Then
                    ColStr(k) = CStr(Advance_Search_MainBp(Q, T, TableName, "OR", " ", False, "")) 'chr=false,or,ef
                ElseIf Func = 7 Then
                    ColStr(k) = CStr(Advance_Search_MainBp(Q, T, TableName, "AND", " ", True, l, l, NotOpt)) 'chr=true,And,Any
                ElseIf Func = 8 Then : GoTo incmd
                ElseIf Func = 9 Then
                    ColStr(k) = CStr(Advance_Search_MainBp(Q, T, TableName, "OR", " ", True, "", "", NotOpt)) 'chr=true,or,e
                    GoTo fins
                ElseIf Func = 10 Then : GoTo betsopt
                ElseIf Func = 11 Then
                    ColStr(k) = CStr(Advance_Search_MainBp(Q, T, TableName, "OR", " ", True, l, l, NotOpt)) 'chr=true,or,any
                ElseIf Func = 12 Then
                    ColStr(k) = Advance_Search_MainBp(Q, T, TableName, "AND", " ", False, l, l, False, s, True, ";")
                Else
                    MsgBox("AukInner Error Function Not found [ " & Func & " ].", MsgBoxStyle.Critical)
                End If
                GoTo fins
            ElseIf e = "b" Then ' exprec e b= between command,dtc e b = boolean,dtc=n=number
betsopt:        Try
                    ColStr(k) = T & Nt & " BETWEEN " & F1 & Q.Split(",").GetValue(0) & F2 & " AND " & F1 & Q.Split(",").GetValue(1) & F2
                Catch ex As Exception
                    MsgBox("PLEASE TYPE QUERY TEXT AS ITS BETWEEN FORMAT (OBJECT,OBJECT2)", MsgBoxStyle.Critical)
                End Try
            ElseIf e = "i" Or e = "in" Then
incmd:          ColStr(k) = T & Nt & " IN (" & SrGens.ArrayToStr(Q.Split(","), ",", F1, F2) & ")"
                'MsgBox(SrGens.ArrayToStr(Q.Split(","), ",", F1, F2) & vbCrLf & F1 & vbCrLf & F2)
            ElseIf e = "l2" Or e = "l" Or E = "**" Or E = "*l*" Then
                ColStr(k) = T & Nt & " Like " & "'" & l & Q & l & "'"
            ElseIf e = "l1" Or E = "*" Or E = "l*" Then
                ColStr(k) = T & Nt & " Like " & "'" & Q & l & "'"
            ElseIf e = "l3" Or E = "*l" Then
                ColStr(k) = T & Nt & " Like " & "'" & l & Q & "'"
            ElseIf e = "l4" Or E = "likeany" Then
                ColStr(k) = T & Nt & " Like " & "'" & l & Q & l & "'"
            ElseIf e = "like" Then
                ColStr(k) = T & Nt & " Like " & "'" & Q & "'"
                'ElseIf Left(e, 1) = "f" Then
                '    fnc = CInt(Right(e, Len(e) - 1)) : If Val(fnc) >= 0 And Val(fnc) <= 3 Then Func = fnc : GoTo functionsC
                '    ColStr(k) = T & Nt & " Like " & "'" & Q & l & "'"
            ElseIf e = "null" Then
                ColStr(k) = T & " IS " & Nt & " NULL"
            ElseIf e = "nnull" Then
                ColStr(k) = T & " IS NOT" & " NULL"
            ElseIf Left(e, 1) = "f" Then
                If Trim(Q) = "" Then
                    GoTo fins
                End If
                CFUNC = Func : Func = Val(Right(E, Len(E) - 1)) : GoTo functionsC
            ElseIf Left(e, 1) = "q" Then 'inset only query sql
                ColStr(k) = Q
            Else
                MsgBox("Error In Choosing Auk Expression ,Please Try Check In Command", MsgBoxStyle.Critical, "AukExpression Command")
                'Exit Function
            End If
fins:
            SF(k) = "" : ST(k) = "" : Expre(k) = "" : DTypex(k) = "" : Sumsx(k) = "" : SignX(k) = ""
            If CFUNC > -1 Then Func = CFUNC : CFUNC = -1
        Next
        AukSql_Main = ADSRC.Query_Arrays_Add(ColStr, BracketsSql, Nothing, Nothing, False, True, SJOIN)
        BSql = AukSql_Main
        SJOIN = ""
        BracketsSql = True
    End Function
    Public Function Advance_Search_MainBp(ByVal TxtGraps As String, ByVal WhichFieldx As Object, ByVal TableName As String, Optional ByVal Join As String = "And", Optional ByVal Key As String = " ", Optional ByVal NotUseKey_Split_By_CharArray As Boolean = False, Optional ByVal Fi1 As String = "%", Optional ByVal Fi2 As String = "%", Optional ByVal NotOpt As Boolean = False, Optional ByVal Sign As String = "=", Optional ByVal LikeOptUse As Boolean = True, Optional ByVal SecondKey As String = "")
        On Error Resume Next
        Dim Aq As Integer
        Dim Tnam As String
        'Dim T As DataTable = Me.Get_DataSystemObj(Dbt)
        Dim Ua, Ua2 As Array
        Dim Lx As String
        Dim Str As String = Nothing
        Dim Str2 As String = Nothing
        Dim K As Integer
        If NotUseKey_Split_By_CharArray = True Then
            TxtGraps = TxtGraps.Trim.Replace(" ", "")
            Ua = TxtGraps.ToCharArray
        Else
            If SecondKey = "" Then Ua = TxtGraps.Split(CChar(Key)) Else Ua = TxtGraps.Split(CChar(SecondKey))
        End If
        'If Sign = "<>" Then NotOpt = True
        If LikeOptUse = True Then
            Lx = " Like "
            If NotOpt = True Or Sign = "<>" Then
                Lx = " Not " & Lx
            End If
        Else
            Lx = Sign
            If NotOpt = True Then
                Lx = "<>"
            End If
        End If
        Tnam = WhichFieldx
        If Mid(Tnam, 1, 1) <> "[" Then Tnam = "[" & Tnam & "]"

        'SoftIn.Get_DataType_Str(T, Tnam)
        For Aq = 0 To Ua.GetUpperBound(0)
            If Ua.GetValue(Aq).ToString <> "" Then
                If SecondKey = "" Then
                    If Str = "" Then
                        Str = Tnam & Lx & "'" & Fi1 & Ua.GetValue(Aq) & Fi2 & "'"
                    Else
                        d = Tnam & Lx & "'" & Fi1 & Ua.GetValue(Aq) & Fi2 & "'"
                        If InStr(Str, d, CompareMethod.Text) = 0 Then
                            Str = Str & " " & Join & " " & Tnam & Lx & "'" & Fi1 & Ua.GetValue(Aq) & Fi2 & "'"
                        End If
                    End If
                Else
                    Ua2 = CType(ArV(Ua, Aq, " "), Array)
                    For K = 0 To Ua2.GetUpperBound(0)
                        a = Tnam & Lx & "'" & Fi1 & Ua2.GetValue(K) & Fi2 & "'"
                        If Str2 = Nothing Or Str2 = "" Then
                            Str2 = a
                        ElseIf Str2 <> "" Then
                            dq = InStr(Str2, a, CompareMethod.Text)
                            If dq = 0 Then
                                Str2 = Str2 & " " & Join & " " & a
                            End If
                        End If
                    Next
                    If Join.ToLower = "and" Then join2 = "or" Else join2 = "and"
                    If InStr(Str, Str2, CompareMethod.Text) = 0 Then
                        Str &= " " & Join2 & " (" & Str2 & ")"
                    End If
                    Str2 = ""
                End If
            End If
        Next
        If Str.Trim <> "" Then
            Str = "(" & Str & ")"
            Advance_Search_MainBp = Str
            WGeT = Str
        Else
            Str = ""
            Advance_Search_MainBp = Str
            WGeT = Str
        End If
    End Function
    Public Function GettingTitleByNumberValue(ByVal T As DataTable, ByVal Table_Tiles_In_Number_or_Object As Object, Optional ByVal Key As String = ",") As Array
        Dim A As Array
        Dim Str As String = ""
        'Dim T As DataTable = AukF.Get_DataSystemObj(DBt)
        TableNames_Num_Str = Table_Tiles_In_Number_or_Object
        If TableNames_Num_Str = "" Then Return Nothing
        If TypeOf (TableNames_Num_Str) Is String Then A = Split(CStr(TableNames_Num_Str), ",") Else A = CType(TableNames_Num_Str, Array)
        For k As Integer = 0 To A.GetUpperBound(0)
            nm1 = A.GetValue(k).ToString
            If IsNumeric(nm1) Then
                Str = T.Columns(CInt(Val(nm1))).ColumnName.ToString
                A.SetValue(Str, k)
            End If
        Next
        Return A
    End Function

    Public Function AddTo_Str(ByVal Str As String, Optional ByVal AddingStr As String = "", Optional ByVal Key As String = ",") As String
        If Str.Trim = "" Then
            If Trim(AddingStr) <> "" Then AddTo_Str = AddingStr.Trim Else AddTo_Str = ""
        ElseIf Str.Trim <> "" Then
            If Trim(AddingStr.Trim) <> "" Then AddTo_Str = Str & Key & AddingStr.Trim Else AddTo_Str = Str
        End If
    End Function
    ''PUBLIC FUNCTION TAKE_AR(A AS Array ,
    Public Sub Bets(ByVal F1 As String, ByVal F2 As String, Optional ByVal WhichST As Integer = 0, Optional ByVal DTypeStr As String = "")
        DTypex(WhichST) = DTypeStr
        ST(WhichST) = F1 & "," & F2
        Expre(WhichST) = "b"
    End Sub
    Public Sub DTC(Optional ByVal T As String = "", Optional ByVal T2 As String = "", Optional ByVal t3 As String = "", Optional ByVal T4 As String = "", Optional ByVal T5 As String = "", Optional ByVal T6 As String = "", Optional ByVal T7 As String = "", Optional ByVal T8 As String = "", Optional ByVal t9 As String = "")
        If DTypex(0) = "" Then DTypex(0) = T
        If DTypex(1) = "" Then DTypex(1) = T2
        If DTypex(2) = "" Then DTypex(2) = t3
        If DTypex(3) = "" Then DTypex(3) = T4
        If DTypex(4) = "" Then DTypex(4) = T5
        If DTypex(5) = "" Then DTypex(5) = T6
        If DTypex(6) = "" Then DTypex(6) = T7
        If DTypex(7) = "" Then DTypex(7) = T8
        If DTypex(8) = "" Then DTypex(8) = t9
    End Sub
    Public Sub SFC(Optional ByVal T As String = "", Optional ByVal T2 As String = "", Optional ByVal t3 As String = "", Optional ByVal T4 As String = "", Optional ByVal T5 As String = "", Optional ByVal T6 As String = "", Optional ByVal T7 As String = "", Optional ByVal T8 As String = "", Optional ByVal t9 As String = "")
        'For M As Integer = 0 To 8
        '    If SF(M) Is Nothing Then SF(M) = ""
        '    If ST(M) Is Nothing Then SF(M) = ""
        'Next
        If SF(0) = "" And T <> "" Then SF(0) = T
        If SF(1) = "" And T2 <> "" Then SF(1) = T2
        If SF(2) = "" And t3 <> "" Then SF(2) = t3
        If SF(3) = "" And T4 <> "" Then SF(3) = T4
        If SF(4) = "" And T5 <> "" Then SF(4) = T5
        If SF(5) = "" And T6 <> "" Then SF(5) = T6
        If SF(6) = "" And T7 <> "" Then SF(6) = T7
        If SF(7) = "" And T8 <> "" Then SF(7) = T8
        If SF(8) = "" And t9 <> "" Then SF(8) = t9
    End Sub
    Public Sub STC(Optional ByVal T As Object = "", Optional ByVal T2 As Object = "", Optional ByVal t3 As Object = "", Optional ByVal T4 As Object = "", Optional ByVal T5 As Object = "", Optional ByVal T6 As Object = "", Optional ByVal T7 As Object = "", Optional ByVal T8 As Object = "", Optional ByVal t9 As Object = "")
        If ST(0) = "" And CStr(T) <> "" Then ST(0) = T
        If ST(1) = "" And CStr(T2) <> "" Then ST(1) = T2
        If ST(2) = "" And CStr(t3) <> "" Then ST(2) = t3
        If ST(3) = "" And CStr(T4) <> "" Then ST(3) = T4
        If ST(4) = "" And CStr(T5) <> "" Then ST(4) = T5
        If ST(5) = "" And CStr(T6) <> "" Then ST(5) = T6
        If ST(6) = "" And CStr(T7) <> "" Then ST(6) = T7
        If ST(7) = "" And CStr(T8) <> "" Then ST(7) = T8
        If ST(8) = "" And CStr(t9) <> "" Then ST(8) = t9
    End Sub
    Public Sub ExpreC(Optional ByVal T As String = "", Optional ByVal T2 As String = "", Optional ByVal t3 As String = "", Optional ByVal T4 As String = "", Optional ByVal T5 As String = "", Optional ByVal T6 As String = "", Optional ByVal T7 As String = "", Optional ByVal T8 As String = "", Optional ByVal t9 As String = "")
        If Expre(0) = "" And T <> "" Then Expre(0) = T
        If Expre(1) = "" And T2 <> "" Then Expre(1) = T2
        If Expre(2) = "" And t3 <> "" Then Expre(2) = t3
        If Expre(3) = "" And T4 <> "" Then Expre(3) = T4
        If Expre(4) = "" And T5 <> "" Then Expre(4) = T5
        If Expre(5) = "" And T6 <> "" Then Expre(5) = T6
        If Expre(6) = "" And T7 <> "" Then Expre(6) = T7
        If Expre(7) = "" And T8 <> "" Then Expre(7) = T8
        If Expre(8) = "" And t9 <> "" Then Expre(8) = t9
    End Sub
    Public Sub SnX(Optional ByVal T As String = "", Optional ByVal T2 As String = "", Optional ByVal t3 As String = "", Optional ByVal T4 As String = "", Optional ByVal T5 As String = "", Optional ByVal T6 As String = "", Optional ByVal T7 As String = "", Optional ByVal T8 As String = "", Optional ByVal t9 As String = "")
        If SignX(0) = "" And T <> "" Then SignX(0) = T
        If SignX(1) = "" And T2 <> "" Then SignX(1) = T2
        If SignX(2) = "" And t3 <> "" Then SignX(2) = t3
        If SignX(3) = "" And T4 <> "" Then SignX(3) = T4
        If SignX(4) = "" And T5 <> "" Then SignX(4) = T5
        If SignX(5) = "" And T6 <> "" Then SignX(5) = T6
        If SignX(6) = "" And T7 <> "" Then SignX(6) = T7
        If SignX(7) = "" And T8 <> "" Then SignX(7) = T8
        If SignX(8) = "" And t9 <> "" Then SignX(8) = t9
    End Sub
    Public Sub SumC(Optional ByVal T As String = "", Optional ByVal T2 As String = "", Optional ByVal t3 As String = "", Optional ByVal T4 As String = "", Optional ByVal T5 As String = "", Optional ByVal T6 As String = "", Optional ByVal T7 As String = "", Optional ByVal T8 As String = "", Optional ByVal t9 As String = "")
        If Sumsx(0) = "" And T <> "" Then Sumsx(0) = T
        If Sumsx(1) = "" And T2 <> "" Then Sumsx(1) = T2
        If Sumsx(2) = "" And t3 <> "" Then Sumsx(2) = t3
        If Sumsx(3) = "" And T4 <> "" Then Sumsx(3) = T4
        If Sumsx(4) = "" And T5 <> "" Then Sumsx(4) = T5
        If Sumsx(5) = "" And T6 <> "" Then Sumsx(5) = T6
        If Sumsx(6) = "" And T7 <> "" Then Sumsx(6) = T7
        If Sumsx(7) = "" And T8 <> "" Then Sumsx(7) = T8
        If Sumsx(8) = "" And t9 <> "" Then Sumsx(8) = t9
    End Sub
End Module

