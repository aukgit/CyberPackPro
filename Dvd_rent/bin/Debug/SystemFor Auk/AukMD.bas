Attribute VB_Name = "AukModule"
Public WGeT As String
Public Sups As String
Public Cmd As String
Public xF As String
Public Res As Boolean
'Public Auk As New AukFunction
Public WGD As String
Public WGH As String
Public WXY As String
Public CKPlace As String
Public MaxStr As String
'Public Regxs As StrReg

'Public SupS As String
Public StPos As String
Public EndPos As String
 Const GWL_EXSTYLE = (-20)
 Const WS_EX_LAYERED = &H80000
 Const LWA_ALPHA = &H2

 Declare Function GetWindowLong Lib "user32" _
() '  Alias "GetWindowLongA" (ByVal hwnd As Long, _
  ByVal nIndex As Long) As Long

 Declare Function SetWindowLong Lib "user32" _
() '   Alias "SetWindowLongA" (ByVal hwnd As Long, _
   ByVal nIndex As Long, ByVal dwNewLong As Long) _
   As Long


Public Declare Function ShowWindow Lib "user32" _
() '(ByVal hwnd As Long, ByVal nCmdShow As Long) As Long

Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
Public Declare Function ReleaseCapture Lib "user32" () As Long
Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long



Declare Function SetLayeredWindowAttributes Lib _
    "user32" (ByVal hwnd As Long, ByVal crKey As Long, _
    ByVal bAlpha As Byte, ByVal dwFlags As Long) As Long
Public Const SW_HIDE = 0
Public Const SW_SHOW = 5

Public Const WS_EX_TOOLWINDOW = &H80&

Public Function Cbc_pl(WP As String)
Cbc_pl = RStr2(WP, ")", "UppI", True)
Cbc_pl = RStr2(WP, "(", "ThRwZ", True)
End Function
Public Function Cbc_pl_back(WP As String)
Cbc_pl_back = RStr2(WP, "ThRwZ", "(", True)
Cbc_pl_back = RStr2(WP, "UppI", ")", True)
End Function
Public Function Sav(Which As TextBox, TextFileName As String)
Open TextFileName For Output As #1
   Print #1, Which.Text
Close #1
Which = Mid(Which, 1, Len(Which) - 1)
End Function
Public Function SavStr(Which As String, TextFileName As String)
Open TextFileName For Output As #1
   Print #1, Which
Close #1
Which = Mid(Which, 1, Len(Which))
End Function
Public Function GTxT(Where As TextBox, TextFileName As String)
On Error Resume Next
Open TextFileName For Input As #1
    Where.Text = Input(LOF(1), 1)
    Close #1
End Function
Public Function GTxTStr(Where As String, TextFileName As String)
On Error Resume Next
Open TextFileName For Input As #1
    Where = Input(LOF(1), 1)
    Close #1
        GTxTStr = Left(Where, Len(Where) - 2)
        Where = GTxTStr
End Function
Public Function RStr(Which As TextBox, ByVal WhatF As String, WhatRep As String, MatchCase As Boolean)
If MatchCase = True Then
mx = Replace(Which, WhatF, WhatRep)
RStr = mx
Which = mx
Else
mx = Replace(Which, WhatF, WhatRep, 1, -1, vbTextCompare)
RStr = mx
Which = mx
End If
End Function
Public Function RStr2(ByVal Which As String, ByVal WhatF As String, ByVal WhatRep As String, MatchCase As Boolean) As String
If MatchCase = True Then
mx = Replace(Which, WhatF, WhatRep)
RStr2 = mx
Which = mx
Else
mx = Replace(Which, WhatF, WhatRep, 1, -1, vbTextCompare)
RStr2 = mx
Which = mx
End If

End Function
Public Function xo(ByVal Max As String)
On Error Resume Next
For a = 1 To Len(Max)
m = Mid(Max, a, 1)
Mid(Max, a, 1) = Chr(Asc(m) + 2)
Next
xo = Max
End Function

Public Function xo_back(ByVal Max As String)
On Error Resume Next
For a = 1 To Len(Max)
m = Mid(Max, a, 1)
Mid(Max, a, 1) = Chr(Asc(m) - 2)
Next
xo_back = Max
End Function
Public Function Findx(ByVal FndTxt As String, ByVal WhatFind As String, ByVal StartPos As String, MatchCase As Boolean) As Boolean
'MsgBox WhatFind

If MatchCase = True Then
fg = InStr(StartPos, FndTxt, WhatFind)
If fg = 0 Then
Res = False
Else
Res = True
StPos = fg
EndPos = Val(fg) + Len(WhatFind)
End If
Else
fg = InStr(StartPos, FndTxt, WhatFind, vbTextCompare)
If fg = 0 Then
Res = False
Else
Res = True
StPos = fg
EndPos = Val(fg) + Len(WhatFind)
End If
End If
Findx = Res

End Function

Public Function AutoFind(ByVal ftxt As String, ByVal What As String, ByVal StartPos As String, ByVal Enp As Boolean, MatchCase As Boolean) As String
On Error Resume Next
Findx ftxt, What, StartPos, MatchCase
'MsgBox Res

If Res = True Then
If Mid(ftxt, EndPos, 1) = "(" Then
cx = InStr(EndPos, ftxt, ")")
If cx > 0 Then
WGeT = Mid(ftxt, EndPos * 1 + 1, cx - (EndPos * 1 + 1))
Else
WGeT = Mid(ftxt, EndPos * 1 + 1)
End If

Else
cx = InStr(EndPos, ftxt, ")")
WGeT = ""
AutoFind = WGeT
AutoFind ftxt, What, cx, Enp, MatchCase
End If
ElseIf Res = False Then
WGeT = ""
AutoFind = WGeT
Exit Function

End If

If Enp = True Then
WGeT = Cbc_pl_back(WGeT)
WGeT = xo_back(WGeT)
End If

AutoFind = WGeT
End Function

