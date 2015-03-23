Public Module EntriesStr
    Public GetStrs As String
    Public Alt_name As String
    Public EStr As String
    Public Res1 As Boolean
    Public AukNewFnTxt As String

    Public QA1, QA2 As String
    Public Itnt As Integer = 0
    Public Res As Boolean
    Public OrdTableName As String = ""
    Public Trd As Boolean
    Public ComRow As Integer
    Public I As Integer
    Public Acc As String
    Public What As String = "Do you want to "
    Public DoSO As String = "Are you want to do so...?"
    Public DRow, DColumn As Integer
    'Public Copy1(16) As Object
    'Public MainFrm As New Form
    'Public Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
    'Public Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    'Public Declare Function ShowWindow Lib "user32" (ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As String) As Integer
    Public Declare Function ReleaseCapture Lib "user32" () As Integer
    'Public Declare Function GetPixel Lib "gdi32" (ByVal hDC As Integer, ByVal X As Integer, ByVal Y As Integer) As Integer
    Public Declare Function SetWindowRgn Lib "user32" (ByVal hwnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Boolean) As Integer
    Public Declare Function CreateRectRgn Lib "gdi32" (ByVal x1 As Integer, ByVal Y1 As Integer, ByVal x2 As Integer, ByVal Y2 As Integer) As Integer
    Public Declare Function CombineRgn Lib "gdi32" (ByVal hDestRgn As Integer, ByVal hSrcRgn1 As Integer, ByVal hSrcRgn2 As Integer, ByVal nCombineMode As Integer) As Integer
    Public Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Integer) As Integer
    Public AukF As New AukFC
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
    'Public Declare Function SetLayeredWindowAttributes Lib "user32" (ByVal hwnd As Integer, ByVal crKey As Integer, ByVal bAlpha As Byte, ByVal dwFlags As Integer) As Integer
    Public WGeT As String
    Public xF As String
    'Public Res As Boolean
    Public Const GWL_EXSTYLE As Short = (-20)
    Public Const WS_EX_LAYERED As Integer = &H80000
    Public Const LWA_ALPHA As Short = &H2S
    Public Const SW_HIDE As Short = 0
    Public Const SW_SHOW As Short = 5
    Public Const WS_EX_TOOLWINDOW As Integer = &H80
End Module
