Imports VB = Microsoft.VisualBasic
'Imports Drmc_DatabaseSoft_by_Auk.AukFunC

Public Module AukMod
    Public SoftDir As String = My.Application.Info.DirectoryPath & "\AukDatabase2.mdb"
    Public SavInt As Integer = -1
    Public DG_cOL(), DG_SLcELL() As String
    Public DG_cOPY_CAT As String = ""
    Public DG_SLrOWS() As DataGridViewRow
    Public DG_COLUMN As Integer
    Public RowX As DataRow
    Public InsRows() As DataRow

    Public DSource As String
    Public NSavStr As String = "DO YOU WANT TO LOAD NEW IF YOU WANT THEN PLEASE CHOOSE THE OPTION FOR SAVE ." & vbCrLf & "YES=SAVE AND LOAD FOR NEW DATE,NO=STOP SAVE AND DO FOR NEW DATE,CANCEL= CANCEL DOING ALL."
    Dim GrdErrorMsg As String

    'Public InsT As New DataTable
    Public Function UB(ByVal S As String, Optional ByVal BRAC As String = "[]")
        UB = Left(BRAC, 1) & S & Right(BRAC, 1)
    End Function
    Public Sub GrdErrMsg(ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs, Optional ByVal ShowMsg As Boolean = True)
        If e.Context = DataGridViewDataErrorContexts.Commit AndAlso e.Exception IsNot Nothing Then
            If GrdErrorMsg <> e.Exception.Message.ToString Then
                GrdErrorMsg = e.Exception.Message.ToString
                If ShowMsg = True Then MsgBox(GrdErrorMsg, MsgBoxStyle.Information, "Please work Carefully.")
            End If
        End If
    End Sub
    Public Function ArrayToString(ByVal Axq As Array, Optional ByVal Key As String = ",") As String
        'Dim Str1 As String
        If Axq Is Nothing Then Return ""
        If Axq IsNot Nothing Then
            For k As Integer = 0 To Axq.GetUpperBound(0)
                If ArrayToString = "" Then
                    ArrayToString = Axq.GetValue(k).ToString
                Else
                    ArrayToString = ArrayToString & Key & Axq.GetValue(k).ToString
                End If
            Next
        End If
    End Function
    Public Function SavMsg(Optional ByVal MSGTXT As String = Nothing, Optional ByVal TABLEn As String = "", Optional ByVal MST As MsgBoxStyle = MsgBoxStyle.Information, Optional ByVal MsgTypePlus As MsgBoxStyle = MsgBoxStyle.YesNoCancel) As Integer
        Dim RS As MsgBoxResult
        'YES=1
        'NO=0
        'CANCEL=2
        ' & vbCrLf & "YES=SAVE & EXIT , NO=EXIT, CANCEL=RESUME WORKING."
        If MSGTXT Is Nothing Then
            If TABLEn = "" Then TABLEn = "CURRENT EDIT DATA"
            RS = MsgBox(UCase(What) & "SAVE " & UCase(TABLEn) & "?", MST + MsgBoxStyle.YesNoCancel)
        Else
            RS = MsgBox(MSGTXT, MST + MsgTypePlus)
        End If
        If RS = MsgBoxResult.Yes Then
            SavMsg = 1
        ElseIf RS = MsgBoxResult.No Then
            SavMsg = 0
        ElseIf RS = MsgBoxResult.Cancel Then
            SavMsg = 2
        End If
        SavInt = SavMsg
    End Function
  
    Public Function ArF(ByVal Ua As Array, ByVal ObjectStr As Object, Optional ByVal Start As Integer = 1, Optional ByVal Count As Integer = -1) As Boolean
        If Ua Is Nothing Then
            ArF = False
            ComRow = -1
            Exit Function
        End If
        If Start = 1 And Count = -1 Then
            ArF = Ua.IndexOf(Ua, ObjectStr)
        ElseIf Start > 1 And Count = -1 Then
            ArF = Ua.IndexOf(Ua, ObjectStr, Start)
        ElseIf Start > 1 And Count > -1 Then
            ArF = Ua.IndexOf(Ua, ObjectStr, Start, Count)
        End If
        ComRow = ArF
        If ArF = -1 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function ArV2(ByVal Ua As Array, ByVal N As Integer, Optional ByVal Defaultvalue As Object = "") As Object
        Return ArV(Ua, N, Nothing, Defaultvalue)
    End Function

    Public Function ArV(ByVal Ua As Array, ByVal N As Integer, Optional ByVal SplitKey As Object = Nothing, Optional ByVal Defaultvalue As Object = "") As Object
        If Ua Is Nothing And SplitKey = "" Then
            ArV = Defaultvalue
        ElseIf Ua Is Nothing And SplitKey <> "" Then
            ArV = Nothing
        End If
        If Ua IsNot Nothing Then
            If (SplitKey IsNot Nothing) And (Ua.GetUpperBound(0) >= N) Then
                ArV = Ua.GetValue(N).ToString.Split(SplitKey)
            ElseIf Ua.GetUpperBound(0) >= N Then
                ArV = Ua.GetValue(N)
                If TypeOf (ArV) Is DBNull Then
                    ArV = Defaultvalue
                End If
            Else
                If SplitKey Is Nothing Then ArV = Defaultvalue Else ArV = Nothing
            End If
        Else
            If (SplitKey IsNot Nothing) Then ArV = Nothing Else ArV = Defaultvalue
        End If

    End Function
    Public Function ArC(ByVal Ua As Array) As Integer
        If Ua Is Nothing Then
            ArC = 0
            Exit Function
        Else
            ArC = Ua.GetUpperBound(0) + 1
        End If
    End Function
    Public Function ArFB(ByVal Ua As Array, ByVal ObjectStr As Object, Optional ByVal Start As Integer = 1, Optional ByVal Count As Integer = -1) As Boolean
        If Ua Is Nothing Or Ua.GetUpperBound(0) = -1 Then
            ComRow = -1
            ArFB = False
            Exit Function
        End If
        If Start = 1 And Count = -1 Then
            ComRow = Ua.IndexOf(Ua, ObjectStr)
        ElseIf Start > 1 And Count = -1 Then
            ComRow = Ua.IndexOf(Ua, ObjectStr, Start)
        ElseIf Start > 1 And Count > -1 Then
            ComRow = Ua.IndexOf(Ua, ObjectStr, Start, Count)
        End If
        If ComRow > -1 Then
            ArFB = True
        Else
            ArFB = False
        End If
    End Function
    Public Function SavStr(ByRef Which As String, ByRef TextFileName As String) As Object
        On Error GoTo b
        FileOpen(1, TextFileName, OpenMode.Output)
        PrintLine(1, Which)
        FileClose(1)
        Exit Function
b:      MsgBox("Try to save but Protected(internal Command).", MsgBoxStyle.Critical)
    End Function
    Public Function GetStr(ByRef TextFileName As String) As Object
        On Error GoTo Ex1
        If My.Computer.FileSystem.FileExists(TextFileName) = True Then
            FileOpen(1, TextFileName, OpenMode.Input)
            GetStr = InputString(1, LOF(1))
            FileClose(1)
        End If
        'If Where IsNot Nothing Then
        '    Where = GetStr
        'End If
        Return GetStr.ToString.Trim
        Exit Function
Ex1:    Where = "" : Return ""
    End Function
   
    Public Sub Ebx3(ByVal Exp As Exception)
        vgb = "(ExecptionMessage : " & Exp.Message & ")"
        vgb2 = "(ExecptionSource : " & Exp.Source & ")"
        fg = vgb & vbNewLine _
         & vgb2
        MsgBox(fg, MsgBoxStyle.Critical, "AukSoftware's (01673-175222)")
    End Sub
    Public Sub Ebx3(ByVal Exp As Exception, ByVal ErrNum As String, ByVal ErrDes As String)
        vgb = "(Error Number : " & """" & ErrNum & """)" & vbNewLine _
               & "(ExecptionMessage : " & Exp.Message & ")"
        vgb2 = "(Error Description : " & ErrDes & ")" & vbNewLine _
                 & "(ExecptionSource : " & Exp.Source & ")"

        fg = vgb & vbNewLine _
         & vgb2

        MsgBox(fg, MsgBoxStyle.Critical, "AukSoftware's (01673-175222)")


    End Sub
    Public Sub Ebx(ByVal ErrN As String, ByVal ErrD As String)
        vgb = "(Error Number : " & """" & ErrN & """):" & vbNewLine _
                                                   & ErrD
        gb2 = "Error Source : " & Err.Source
        cfew = vgb & vbNewLine _
         & gb2
        MsgBox(cfew, MsgBoxStyle.Critical, "Auk Error Handler[Contact With Alim (01711334201,0193-500863)]")
    End Sub

    Public Function xT(ByVal text As TextBox) As Boolean
        If Trim(text.Text) = "" Then
            xT = True
        Else
            xT = False
        End If
    End Function
    Public Sub Epx(ByVal Exp As String)
        If InStr(Err.Description, "does not allow nulls.", CompareMethod.Text) = 0 Then
            srp = "(Error Number : " & """" & Err.Number & """)" & vbCrLf & "(Error Source : " & """" & Err.Source.ToString & """)" & vbCrLf & "(Error Description : " & """" & Err.Description & """)" & vbCrLf & "(Expression : " & """" & Exp & """)"

            MsgBox(srp, MsgBoxStyle.Critical, "Auk Error Handler{Contact with auk:01673-175222,0193500863,01711-334201}")
        End If


      
    End Sub
    Public Sub Epx()
        If InStr(Err.Description, "does not allow nulls.", CompareMethod.Text) = 0 Then
            Ebx(Err.Number, Err.Description)
        End If
    End Sub
    Public Sub Epx2()
        Ebx(Err.Number, Err.Description, Err.Description)
    End Sub
    Public Sub Epx2(ByVal Tit As String)
        Ebx(Err.Number, Err.Description, Tit)
    End Sub
    Public Sub Ebx(ByVal ErrN As String, ByVal ErrD As String, ByVal Tit As String)
        vgb = "(Error Number : " & """" & ErrN & """):" & vbNewLine _
                                                   & ErrD
        MsgBox(vgb, MsgBoxStyle.Critical, Tit)
    End Sub
    Public Function Cbc_pl_back(ByRef WP As String) As String
        Cbc_pl_back = RStr2(WP, "ThRwZ", "(", True)
        Cbc_pl_back = RStr2(WP, "UppI", ")", True)
    End Function
    Public Function Sav(ByRef Which As System.Windows.Forms.TextBox, ByRef TextFileName As String) As String
        FileOpen(1, TextFileName, OpenMode.Output)
        PrintLine(1, Which.Text)
        FileClose(1)
        Which.Text = Mid(Which.Text, 1, Len(Which.Text) - 1)
    End Function


    Public Function RStr(ByRef Which As System.Windows.Forms.TextBox, ByVal WhatF As String, ByRef WhatRep As String, ByRef MatchCase As Boolean) As String
        Dim mx As String
        If MatchCase = True Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = Replace(Which.Text, WhatF, WhatRep)
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RStr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RStr = mx
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Which.Text = mx
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = Replace(Which.Text, WhatF, WhatRep, 1, -1, CompareMethod.Text)
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RStr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RStr = mx
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Which.Text = mx
        End If
    End Function
    Public Function RStr2(ByVal Which As String, ByVal WhatF As String, ByVal WhatRep As String, ByRef MatchCase As Boolean) As String
        Dim mx As String
        If MatchCase = True Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = Replace(Which, WhatF, WhatRep)
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RStr2 = mx
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Which = mx
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = Replace(Which, WhatF, WhatRep, 1, -1, CompareMethod.Text)
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RStr2 = mx
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Which = mx
        End If

    End Function
    Public Function xo(ByVal Max As String, Optional ByVal EnNum As Integer = 2) As String
        'Dim m As String
        'Dim a As String
        On Error Resume Next
        For a = 1 To Len(Max)
            'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            m = Mid(Max, a, 1)
            'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Mid(Max, a, 1) = Chr(Asc(m) + EnNum)
        Next
        'UPGRADE_WARNING: Couldn't resolve default property of object xo. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        xo = Max
    End Function

    Public Function xo_back(ByVal Max As String, Optional ByVal EnNum As Integer = 2) As String
        'Dim m As String
        'Dim a As String
        On Error Resume Next
        For a = 1 To Len(Max)
            'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            m = Mid(Max, a, 1)
            'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Mid(Max, a, 1) = Chr(Asc(m) - EnNum)
        Next
        'UPGRADE_WARNING: Couldn't resolve default property of object xo_back. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        xo_back = Max
    End Function
End Module
