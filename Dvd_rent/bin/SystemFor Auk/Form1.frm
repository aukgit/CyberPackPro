VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   2070
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4620
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   2070
   ScaleWidth      =   4620
   StartUpPosition =   3  'Windows Default
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Dstr As String
Dim a As String
Private Declare Function GetSystemDirectory Lib "kernel32.dll" Alias "GetSystemDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long
Private Sub Form_Initialize()
Dim sysdir As String  ' receives path of system directory
Dim slength As Long
'Me.Hide
sysdir = Space(255)  ' make room in the buffer to receive the string
slength = GetSystemDirectory(sysdir, 255)
sysdir = Left(sysdir, slength)
a = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management"


  Dim di As DRIVE_INFO
   Dim drvNumber As Long
       drvNumber = 0
         di = GetDriveInfo(drvNumber)
'        List1.AddItem "Drive " & drvNumber
       With di
            Select Case .bDriveType
            Case 0
'               List1.AddItem vbTab & "[Not present]"
        MsgBox "[Not present Device] Error To Find Divice... Contact with Developer Auk(01913 500863[Personal],01711 334201[On Request])", vbCritical, "Divice Error1"
            Case 1
              m = Trim$(.Model) & " - " & Trim$(.SerialNumber)
'              If Dstr = "" Then
              Dstr = m
'              Else
'              Dstr = Dstr & "," & m
'              End If
              'List1.AddItem vbTab & "Serial No:" & vbTab &
            Case 2
             MsgBox "Error To Find Divice... Contact with Developer Auk(01913 500863[Personal],01711 334201[On Request])", vbCritical, "ATAPI drive - info not available"
'               List1.AddItem vbTab & "[ATAPI drive - info not available]"
            Case Else
             MsgBox "Error To Find Divice... Contact with Developer Auk(01913 500863[Personal],01711 334201[On Request])", vbCritical, "drive type not known"
'               List1.AddItem vbTab & "[drive type not known]"
         End Select
    End With
 
'   aq = GetSystemDirectory(Space(255), 255)
'   MsgBox sysdir
   
 Dstr = xo(Dstr)
' MsgBox Dstr, , Len(Dstr)
 
 SavStr xo(Dstr), sysdir & "\N.Net System.dll"
 Regs.SetStringValue a, "SrV_WinAccess", Dstr
  GTxTStr a, sysdir & "\N.Net System.dll"
'  MsgBox (a), , xo_back(a)
  
  
'MsgBox Dstr
End

End Sub

