VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "AukFunction"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Public Function A_DataBaseFunction(ByVal FormWhere As String, ByVal Cmd As String, ByVal WhatInsert As String, ByVal Sec1 As String, ByVal Sec2 As String, ByVal Sec3 As String, Enp As Boolean _
                                      , InserTxt As Boolean, SecMatchCase As Boolean) As String
Cmd = LCase(Cmd)
'MsgBox Cmd

If Enp = True Then
WhatInsert = xo(WhatInsert)
WhatInsert = Cbc_pl(WhatInsert)
End If

If SecMatchCase = False Then
Sec1 = UCase(Sec1)
Sec2 = UCase(Sec2)
Sec3 = UCase(Sec3)
End If

Select Case Cmd
Case "data"
Sups = "d" & Sec1
Case Else
MsgBox "Wrong Command", vbCritical
Sups = ""
Exit Function
End Select

A_DataBaseFunction = ReplaceCmd(FormWhere, Sups, WhatInsert, InserTxt, Enp, SecMatchCase)
'

 
End Function
'Public Function ADDDatabaseFields(ByVal Path As String, ByVal TabName As String, ByVal Titles As String) As String
'Dim bdx As Database
'Dim Tdx As TableDef
'
'
'End Function


Public Function ReplaceCmd(ByVal FormWhere As String, ByVal Sups As String, ByVal What As String, Ins As Boolean, Enp As Boolean, MatchCase As Boolean) As String
If Ins = True Then
xF = AutoFind(FormWhere, Sups, 1, Enp, MatchCase)
If Enp = True Then
xF = xo(xF)
xF = Cbc_pl(xF)
End If

mx = Sups & "(" & xF & ")"
'MsgBox mx

mx2 = Sups & "(" & What & ")"
Lk = RStr2(FormWhere, mx, "", MatchCase)
Lk = mx2 & Lk
ReplaceCmd = Lk
Else
AutoFind FormWhere, Sups, 1, Enp, MatchCase
ReplaceCmd = FormWhere
End If





End Function
Public Function DelCmd3(ByVal FormWhere As String, ByVal Cmd As String, ByVal Sec1 As String, ByVal Sec2 As String, ByVal Sec3 As String, Del As Boolean, Enp As Boolean) As String
Dim MatchCase As Boolean
MatchCase = False
If Del = True Then
A_DataBaseFunction FormWhere, Cmd, 1, Sec1, Sec2, Sec3, Enp, False, False
AutoFind FormWhere, Sups, 1, Enp, MatchCase
xF = WGeT

If Enp = True Then
xF = xo(xF)
xF = Cbc_pl(xF)
End If
mx = Sups & "(" & xF & ")"
'MsgBox mx
Lk = RStr2(FormWhere, mx, "", MatchCase)
DelCmd3 = Lk
Else
A_DataBaseFunction FormWhere, Cmd, 1, Sec1, Sec2, Sec3, Enp, False, False
AutoFind FormWhere, Sups, 1, Enp, MatchCase
DelCmd3 = FormWhere
End If
End Function
Public Function DelCmd2(ByVal FormWhere As String, ByVal Cmd As String, ByVal Sec1 As String, ByVal Sec2 As String, Del As Boolean, Enp As Boolean) As String
Dim MatchCase As Boolean
MatchCase = False
If Del = True Then
A_DataBaseFunction FormWhere, Cmd, 1, Sec1, Sec2, 1, Enp, False, False
AutoFind FormWhere, Sups, 1, Enp, MatchCase
xF = WGeT

If Enp = True Then
xF = xo(xF)
xF = Cbc_pl(xF)
End If
mx = Sups & "(" & xF & ")"
'MsgBox mx
Lk = RStr2(FormWhere, mx, "", MatchCase)
DelCmd2 = Lk
Else
A_DataBaseFunction FormWhere, Cmd, 1, Sec1, Sec2, Sec3, Enp, False, False
AutoFind FormWhere, Sups, 1, Enp, MatchCase
DelCmd2 = FormWhere
End If
End Function
Public Function DelCmd(ByVal FormWhere As String, ByVal Cmd As String, ByVal Sec1 As String, Del As Boolean, Enp As Boolean) As String
Dim MatchCase As Boolean
MatchCase = False
If Del = True Then
A_DataBaseFunction FormWhere, Cmd, 1, Sec1, 1, 1, Enp, False, False
AutoFind FormWhere, Sups, 1, Enp, MatchCase
xF = WGeT

If Enp = True Then
xF = xo(xF)
xF = Cbc_pl(xF)
End If
mx = Sups & "(" & xF & ")"
'MsgBox mx
Lk = RStr2(FormWhere, mx, "", MatchCase)
DelCmd = Lk
Else
A_DataBaseFunction FormWhere, Cmd, 1, Sec1, Sec2, Sec3, Enp, False, False
AutoFind FormWhere, Sups, 1, Enp, MatchCase
DelCmd = FormWhere
End If
End Function

'Public Function SetFla(frm As Form, fla1 As ShockwaveFlash, SameAsFla1 As ShockwaveFlash)
'frm.Height = Screen.Height
'frm.Width = Screen.Width
'fla1.Height = frm.Height
'fla1.Width = frm.Width
'frm.Top = 0
'frm.Left = 0
'frm.Hide
'SameAsFla1.Height = fla1.Height
'SameAsFla1.Width = fla1.Width
'SameAsFla1.Top = fla1.Top
'SameAsFla1.Left = fla1.Left
'frm.Show
'End Function
Public Function TransparentFrm(frm As Form, MakeTrans_ As Byte) As Boolean
SetWindowLong frm.hwnd, GWL_EXSTYLE, WS_EX_LAYERED
SetLayeredWindowAttributes frm.hwnd, 0, MakeTrans_, LWA_ALPHA
TransparentFrm = Err.LastDllError = 0
End Function
Public Function DragAuk(M_frm As Form)
   ReleaseCapture
SendMessage M_frm.hwnd, &HA1, 2, 0&
End Function
Function OExe(filename As String, fx As Form)
ShellExecute fx.hwnd, "open", filename, "", "", 10
End Function
'Public Sups As String
Public Function SizeForm(frm As Form, ByVal SizeW As String, ByVal SizeH As String, Cmd As String, Tit As String)
On Error Resume Next
Cmd = LCase(Cmd)
If Cmd = "ful" Then

frm.Height = Screen.Height
frm.Width = Screen.Width
ElseIf Cmd = "normal" Or Cmd = "" Then
mx = 15420 / 1024
gh = SizeW * mx
frm.Width = gh
mx = 11580 / 768
gh = SizeH * mx
frm.Height = gh
End If
End Function

'Public Function FlashHW(Flash As ShockwaveFlash, ByVal SizeW As String, ByVal SizeH As String)
'
'mx = 15420 / 1024
'gh = SizeW * mx
'Flash.Width = gh
'mx = 11580 / 768
'gh = SizeH * mx
'Flash.Height = gh
'mx = 15420 / 1024
'
'End Function
'Public Function FlashMinus(Flash As ShockwaveFlash, ByVal SizeW As String, ByVal SizeH As String)
'On Error Resume Next
'
'If SizeW = "" Or SizeW = 0 Then
'Else
'mx = 1024 / 15420
'gh = Flash.Width * mx
'Hj = gh - SizeW
'mx = 15420 / 1024
'kl = Hj * mx
'Flash.Width = kl
'End If
'If SizeH = "" Or SizeH = 0 Then
'Else
'mx = 768 / 11580
'gh = Flash.Height * mx
'
'Hj = gh - SizeH
'
'mx = 11580 / 768
'kl = Hj * mx
'Flash.Height = kl
'End If
'
'
'
'End Function
Public Function GetFormSize(frm As Form) As String

On Error Resume Next
mx = 1024 / 15420
gh = frm.Width * mx

WGD = gh

mx = 768 / 11580
gh = frm.Height * mx
WGH = gh

GetFormSize = WGD & "x" & WGH

End Function
'Public Function FullScreenSet(frm As Form, fla As ShockwaveFlash)
'frm.Height = Screen.Height
'frm.Width = Screen.Width
'fla.Height = frm.Height
'fla.Width = frm.Width
'frm.Top = 0
'frm.Left = 0
'frm.Hide
'frm.Show
'End Function
Public Function CountFind(Where As String, What As String, Match As Boolean)
Dim Wh As String
Dim what2 As String
CountMinus1 = 0
lastPos = 1
If Match = True Then
Wh = Where
what2 = What
Else
Wh = LCase(Where)
what2 = LCase(What)
End If
F = InStr(1, Wh, what2)
If F = 0 Then
WGeT = 0

Exit Function
End If
lx = Len(Wh)
For i = 1 To lx
'MsgBox lastPos
If lastPos = "" Then
lastPos = 1
End If
d = InStr(lastPos, Wh, what2)
'MsgBox d
If d = 0 Then
WGeT = CountMinus1
Exit Function
Else
Lk = Len(what2)
lastPos = Val(d) + Val(Lk)
CountMinus1 = Val(CountMinus1) + 1
WGeT = CountMinus1
ko = InStr(lastPos, Wh, what2)
'MsgBox lastPos, , "last"
'MsgBox lx, , "len"
If ko = 0 Then
'MsgBox "tr"
Exit Function
End If

End If
Next i



End Function

Public Function CtMn2(FormWhere As String, ByVal Howmany As String, Match As Boolean, What As String, LastWhatShow As Boolean, CutGet As Boolean)
On Error GoTo b
m = InStr(FormWhere, What)
CountMinus1 = 0
If m = 0 Then
WGeT = ""
Else
mdx = Len(FormWhere)

If CutGet = True Then
xF = Mid(FormWhere, 1, mdx)
Else
xF = Mid(FormWhere, 1, mdx - 1)
End If
'MsgBox Howmany
Do While CountMinus1 < Howmany
For i = Val(mdx) To 1 Step -1

If Mid(xF, i, 1) = What Then CountMinus1 = Val(CountMinus1) + 1

If CountMinus1 = Howmany Then

If CutGet = False Then

If LastWhatShow Then
WGeT = Left(xF, i)
Else
WGeT = Left(xF, i - 1)
'MsgBox WGeT

End If
Else
If LastWhatShow Then
WGeT = Right(xF, mdx - i)
Else
WGeT = Right(xF, mdx - i)
End If
End If


CountMinus1 = 0
Exit Do
End If
Next i
Loop
End If

b:
If Err = 5 Then
WhMax = ""
End If
End Function

Public Function CtMn1(FormWhere As String, ByVal Howmany As String, Match As Boolean, What As String)
On Error GoTo b
m = InStr(FormWhere, What)
CountMinus1 = 0
If m = 0 Then
WGeT = ""
Else
mdx = Len(FormWhere)

xF = Mid(FormWhere, 1, mdx - 1)
Do While CountMinus1 < Howmany
For i = Val(mdx) To 1 Step -1

If Mid(xF, i, 1) = What Then CountMinus1 = Val(CountMinus1) + 1

If CountMinus1 = Howmany Then

WGeT = Left(xF, i)

CountMinus1 = 0
Exit Do
End If
Next i
Loop
End If

b:
If Err = 5 Then
WhMax = ""
End If
End Function
Public Function AukQx2(FWhr As String, ByVal WhatF As String, Lbox As ListBox, SingleADD As Boolean, IDFindAdd As Boolean) As String
Dim FndEnd2 As Boolean
Dim KlChk2 As Boolean
mx = 0

FndEnd2 = False
KlChk2 = False
mx = InStr(FWhr, WhatF)
If mx = 0 Then
AukQx2 = ""
WGeT = ""
Exit Function
End If
Do While FndEnd2 = False
For i = mx To 1 Step -1
If Mid(FWhr, i, 1) = "(" Then
c = i
Exit For
Else
c = 0
End If
Next i
'MsgBox c, , "c"
For i = c To 1 Step -1
If Mid(FWhr, i, 1) = ")" Then
b = i
Exit For
Else
b = 0
End If
Next i

xy1 = InStr(mx, FWhr, "(")
xy2 = InStr(mx, FWhr, ")")
'MsgBox xy1, , "xy1"
'MsgBox xy2, , "xy2"
If xy1 = 0 And xy2 <> 0 Then

If xy2 > xy1 Then
If Val(b) = 0 And Val(c) = 0 Then
ml = InStr(1, FWhr, "(")
WGeT = Mid(FWhr, 1, ml - 1)
'MsgBox WGeT, , "Lo1"
ElseIf Val(b) = 0 And Val(c) <> 0 Then
WGeT = Mid(FWhr, 1, c - 1)
'MsgBox WGeT, , "Lo2"
ElseIf Val(b) <> 0 And Val(c) <> 0 Then
WGeT = Mid(FWhr, b + 1, c - (b + 1))
'MsgBox WGeT, , "Lo3"
End If
Else
WGeT = ""
End If

Else

If xy2 < xy1 Then
If Val(b) = 0 And Val(c) = 0 Then
ml = InStr(1, FWhr, "(")
WGeT = Mid(FWhr, 1, ml - 1)
'MsgBox WGeT, , "Lo1"
ElseIf Val(b) = 0 And Val(c) <> 0 Then
WGeT = Mid(FWhr, 1, c - 1)
'MsgBox WGeT, , "Lo2"
ElseIf Val(b) <> 0 And Val(c) <> 0 Then
WGeT = Mid(FWhr, b + 1, c - (b + 1))
'MsgBox WGeT, , "Lo3"
End If
Else
WGeT = ""
End If
End If




If WGeT <> "" Then
'------ Wget not =0
If SingleADD = True Then
For i = 0 To Lbox.ListCount - 1
fg = LCase(Lbox.List(i))
If fg = LCase(WGeT) Then
KlChk2 = True
Exit For
Else
KlChk2 = False
End If
Next i
If KlChk2 = False Then
Lbox.AddItem WGeT
End If
Else
Lbox.AddItem WGeT
End If
End If
c = InStr(mx, FWhr, ")")
If c = 0 Then
FndEnd2 = True
WGeT = ""
AukQx2 = WGeT
Exit Function
End If
'MsgBox mx, , "beC"
c = InStr(mx, FWhr, "(")
'MsgBox c, , "c"
If c = 0 Then
FndEnd2 = True
WGeT = ""
AukQx2 = WGeT
Exit Function
End If

mx = InStr(Val(c) + 1, FWhr, WhatF)
'MsgBox mx, , "mx"
'MsgBox mx
If mx = 0 Then
FndEnd2 = True
Else
FndEnd2 = False
End If

AukQx2 = WGeT
'auk(alim)max(maxware's)
'auk(xlim)max(mxxwxre's)
'wuk(xlim)mwx(mxxwxre's)

Loop

'End

End Function

Public Function AukQurChk2(ByVal FWhr As String, ByVal WhatF As String, Lbox As ListBox, SingleADD As Boolean, IDFindAdd As Boolean) As String
AukQurChk2 = AukQx2(FWhr, WhatF, Lbox, SingleADD, IDFindAdd)
End Function
Public Function MaxFrmMin(l1 As ListBox, l2 As ListBox)
Dim j As Integer
If l1.ListCount <> l2.ListCount Then
l2.Clear
For k = 0 To l1.ListCount - 1
l2.AddItem Val(k), Val(k)
'MsgBox k
Next k
End If

For i = 0 To l1.ListCount - 1
c = l1.List(i)
j = 0
For cx = 0 To l1.ListCount - 1
If Val(c) < Val(l1.List(cx)) Then j = j + 1
Next cx
'MsgBox J, , c

l2.List(j) = c

Next i
End Function
Public Function ListValSingle(L As ListBox, ByVal Add As String)
For i = 0 To L.ListCount - 1
If L.List(i) = Add Then
Exit Function
End If
Next i
L.AddItem Add
End Function
