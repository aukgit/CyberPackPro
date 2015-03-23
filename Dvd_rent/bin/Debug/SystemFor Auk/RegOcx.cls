VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "RegOcx"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Private Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal a As Any, ByVal b As Any) As Long
 Private Declare Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" _
  (ByVal lpLibFileName As String) As Long
 Private Declare Function GetProcAddress Lib "kernel32" (ByVal hModule As Long, _
    ByVal lpProcName As String) As Long
Private Declare Function CreateThread Lib "kernel32" (lpThreadAttributes As Any, _
   ByVal dwStackSize As Long, ByVal lpStartAddress As Long, ByVal lParameter As Long, _
   ByVal dwCreationFlags As Long, lpThreadID As Long) As Long
 Private Declare Function WaitForSingleObject Lib "kernel32" (ByVal hHandle As Long, _
    ByVal dwMilliseconds As Long) As Long
 Private Declare Function GetExitCodeThread Lib "kernel32" (ByVal hThread As Long, _
    lpExitCode As Long) As Long
Private Declare Sub ExitThread Lib "kernel32" (ByVal dwExitCode As Long)
 Private Declare Function FreeLibrary Lib "kernel32" (ByVal hLibModule As Long) As Long
Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Long) As Long
Dim Reg As String, Success As Boolean
Dim mresult


Public Sub RegUnReg(ByVal inFileSpec As String, Optional inHandle As String = "")
    On Error Resume Next
    Dim lLib As Long                 ' Store handle of the control library
    Dim lpDLLEntryPoint As Long      ' Store the address of function called
    Dim lpThreadID As Long           ' Pointer that receives the thread identifier
    Dim lpExitCode As Long           ' Exit code of GetExitCodeThread
    Dim mThread
    
      ' Load the control DLL, i. e. map the specified DLL file into the
      ' address space of the calling process
    lLib = LoadLibrary(inFileSpec)
    If lLib = 0 Then
         ' e.g. file not exists or not a valid DLL file
        Prob = "This Component is installed before"
        Exit Sub
        Else
        Prob = ""
    End If
    
      ' Find and store the DLL entry point, i.e. obtain the address of the
      ' “DllRegisterServer” or "DllUnregisterServer" function (to register
      ' or deregister the server’s components in the registry).
      '
    If inHandle = "" Then
        lpDLLEntryPoint = GetProcAddress(lLib, "DllRegisterServer")
    ElseIf inHandle = "U" Or inHandle = "u" Then
        lpDLLEntryPoint = GetProcAddress(lLib, "DllUnregisterServer")
    Else
        MsgBox "Unknown command handle"
        Exit Sub
    End If
    If lpDLLEntryPoint = vbNull Or lpDLLEntryPoint = 0 Then
        GoTo earlyExit1
    End If
    
    Screen.MousePointer = vbHourglass
    
      ' Create a thread to execute within the virtual address space of the calling process
    mThread = CreateThread(ByVal 0, 0, ByVal lpDLLEntryPoint, ByVal 0, 0, lpThreadID)
    If mThread = 0 Then
        GoTo earlyExit1
    End If
    
      ' Use WaitForSingleObject to check the return state (i) when the specified object
      ' is in the signaled state or (ii) when the time-out interval elapses.  This
      ' function can be used to test Process and Thread.
    mresult = WaitForSingleObject(mThread, 10000)
    If mresult <> 0 Then
        GoTo earlyExit2
    End If
    
      ' We don't call the dangerous TerminateThread(); after the last handle
      ' to an object is closed, the object is removed from the system.
    CloseHandle mThread
    FreeLibrary lLib
    
    Screen.MousePointer = vbDefault
    Success = True
    Exit Sub
    
    
earlyExit1:
    Screen.MousePointer = vbDefault
    Prob = "Registration failed in obtaining entry point or creating thread. "
     ' Decrements the reference count of loaded DLL module before leaving
    FreeLibrary lLib
    Success = False
    Exit Sub
    
earlyExit2:
    Success = False
    Screen.MousePointer = vbDefault
   Prob = "Registration failed in signaled state or time-out"
   FreeLibrary lLib
     ' Terminate the thread to free up resources that are used by the thread
     ' NB Calling ExitThread for an application's primary thread will cause
     ' the application to terminate
    lpExitCode = GetExitCodeThread(mThread, lpExitCode)
    ExitThread lpExitCode
End Sub

Public Function RegOcx(Ocx_Name As String)
Reg = "u"
RegUnReg Ocx_Name, Reg
Reg = ""
RegUnReg Ocx_Name, Reg
End Function


