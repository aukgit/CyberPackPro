'Inherits Dvd_Rent.EntriesStr
Imports Microsoft.Win32

Public Class Register
    Dim Rpx As Microsoft.Win32.RegistryKey
    Dim Rk As Microsoft.Win32.Registry
    'Dim CurWin As Microsoft.Win32.RegistryKey
    Dim Sn As String
    Dim SoftCode As String = "C791_231"
    '& Asc(D) & Asc(R) & Asc(M) & Asc(C)
    Public Dbname As String = My.Application.Info.DirectoryPath & "\AukDatabase2.mdb"
    Dim WinCur As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion"
    Dim AukCur As String = "HKEY_LOCAL_MACHINE\SOFTWARE\AukSoftware's\Database\DVD_RENT"
    'Dim nLoad As New Form
    'Dim Name1 As String
    Public TESTDAYS As String = 12

    Dim One As Boolean

    Private Sub Register_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        AukSoft.Hide()
        AukSoft.Close()

    End Sub
    Private Sub Register_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles Me.Invalidated


        'rpx.

    End Sub
    Private Sub Nload()
        'If One = True Then
        '    Logo.Show()
        '    Logo.Activate()
        'Else
        '    Form1.Show()
        '    Form1.Activate()

        'End If
        'Me.Close()
        SplashSc.Show()
        SplashSc.Activate()

        Me.Close()

    End Sub
    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Rpx = Rk.LocalMachine
        'Login.Close()
        'ax = SrGens.NumbersConverts(Now)
        ''MsgBox(ax)
        'f = NumbersConverts(ax, 0, True)
        'MsgBox(f)

        MsgBox(My.Computer.FileSystem.SpecialDirectories.Temp)
        ''a = SrGens.GenSrls_By_DT_Hour(Now.Date, "testEdition", "AukCOmpany", 3)
        ''a2 = SrGens.GenSrls_By_DT_Hour(Now.Date.AddDays(2), "testEdition", "isugAukCOmpany", 3)
        ''a3 = SrGens.GenSrls_By_DT_Hour(Now.Date.AddDays(3), "testEdition", "qqfAukCOmpany", 3)
        ''a4 = SrGens.GenSrls_By_DT_Hour(Now.Date.AddDays(4), "testEdition", "2356", 3)
        ''a5 = SrGens.GenSrls_By_DT_Hour(Now.Date.AddDays(5), "testEdition", "Aqhny", 3)
        ''a6 = SrGens.GenSrls_By_DT_Hour(Now.Date.AddDays(6), "testEdition", "ahhtraFAFW", 3)
        ''a7 = SrGens.GenSrls_By_DT_Hour(Now.Date.AddDays(7), "testEdition", "GAukCOmpany", 3)
        ''a8 = SrGens.GenSrls_By_DT_Hour(Now.Date.AddDays(8), "testEdition", "Squre", 3)
        ''a9 = SrGens.GenSrls_By_DT_Hour(Now.Date.AddDays(9), "testEdition", "Lorenzo", 3)
        '''MsgBox(a & " " & a2 - a & vbCrLf & a2 & " " & a3 - a2 & vbCrLf & a3 & " " & a4 - a3 & vbCrLf & a4 & " " & a5 - a6 & vbCrLf & a2 &  " " & a7 - a6 & vbCrLf & a2)
        ''G = (a & " -1- " & a2 - a)
        ''G1 = (a2 & " -2- " & a3 - a2)
        ''G2 = (a3 & " -3- " & a4 - a3)
        ''G3 = (a4 & " -4- " & a5 - a4)
        ''G4 = (a5 & " -5- " & a6 - a5)
        ''G5 = (a6 & " -6- " & a7 - a6)
        ''G6 = (a7 & " -7- " & a8 - a7)
        ''G7 = (a8 & " -8- " & a9 - a8)
        ''G8 = (a9 & " -9-" & Now.Date.AddDays(2))
        ''MsgBox(g & vbCrLf & g1 & vbCrLf & g2 & vbCrLf & g3 & vbCrLf & g4 & vbCrLf & g5 & vbCrLf & g6 & vbCrLf & g7 & vbCrLf & g8)
        End

        ml = "Software\AukSoftware's\Database\DVD_RENT"
        Name1 = ml

        Rpx.CreateSubKey(ml)

        'Rpx.OpenSubKey(ml, False)
        'CurWin = Rk.LocalMachine
        'ml2 = "SOFTWARE\Microsoft\Windows\CurrentVersion"
        'CurWin.OpenSubKey(ml2, False)
        CrEr(True)
        Sn = Rk.GetValue(AukCur, "Category", "")
        'm = Rk.GetValue(AukCur, "ShowView", "")
        'If m = "two" Or m = "" Then
        '    Rk.SetValue(AukCur, "ShowView", "one")
        '    One = False

        'Else
        '    Rk.SetValue(AukCur, "ShowView", "two")
        '    One = True
        'End If


        'MsgBox(Rpx.ToString)
        If Sn = "DeveloperInstalling" Then
            'Rk.SetValue(AukCur, "CodePersonalInstalling", xo(xo(Me.TextBox2.Text)))

            'Rk.SetValue(WinCur, "Windows_x86_" & SoftCode, xo(Me.TextBox2.Text))
            'Rk.SetValue(AukCur, "SoftInstallDate", xo(Now.Date))
            Sn = (((Rk.GetValue(AukCur, "CodePersonalInstalling", ""))))
            If Sn.ToLower = "***developeredition-auk-live***" Then
                If (Now.Year < 2006) And (Now.Month < 12) And (Now.Day < 20) Then
                    MsgBox("Please Set Current Date Time In Your Computer to Collect Information Correctly....", MsgBoxStyle.Critical)
                    End
                End If
                sq = xo_back(Rk.GetValue(WinCur, "Windows_x86_" & SoftCode, ""))
                If UCase(sq) <> UCase(Sn) Then
                    SetEr()
                    CrEr(True)

                End If
                gp = xo_back(Rk.GetValue(AukCur, "SoftInstallDate", 0))

                cg = DateDiff(DateInterval.Month, gp, Microsoft.VisualBasic.Now.Date)
                'MsgBox(cg)
                If Val(cg) < 22 Or Val(cg) < 0 Then
                    Nload()
                Else
                    SetEr()
                    MsgBox("There are Serious Problem... Error 232..System Error Contact With Auk(0171-1334201,0193-500863)...", MsgBoxStyle.Critical)
                    End
                End If
            ElseIf Sn.ToLower = "***developeredition-auk-live***confrim" Then
                Nload()
            Else
                SetEr()
                MsgBox("Code Is Wrong ,Contact With Auk(0171-1334201)...", MsgBoxStyle.Critical)
                End

            End If
        ElseIf Sn = "TestEditon" Then
            Me.ComboBox1.Items.RemoveAt(0)
            'If (Now.Year < 2006) And (Now.Month < 12) And (Now.Day < 20) Then
            '    MsgBox("Please Set Current Date Time In Your Computer to Collect Information Correctly....", MsgBoxStyle.Critical)
            '    End
            'End If
            'Dim LD As Date
            'gp = xo_back(Rpx.GetValue("InsDate"))
            'insdate = xo_back(Rpx.GetValue("SoftInfo"))
            'plusdate = xo_back(xo_back(Rk.GetValue(WinCur, "PlK")))
            ''MsgBox(Sn & vbCrLf & gp & vbCrLf & insdate & vbCrLf & plusdate)
            'po = xo_back(xo_back(Rk.GetValue(WinCur, "Windows" & SoftCode)))
            'If plusdate <> po Then
            '    MsgBox("You are just trying to change dates... Software is Corrupt for this PC...Contact with auk...(0171-1334201)", MsgBoxStyle.Critical)

            '    End
            'End If
            'cg = DateDiff(DateInterval.Month, gp, Microsoft.VisualBasic.Now.Date)
            'If insdate <> Microsoft.VisualBasic.Now.Date Then
            '    Dim m As New Date
            '    m = insdate
            '    If m.Year = Now.Date.Year Then
            '        plusdate = plusdate + 1
            '    Else
            '        MsgBox("Contact with Error Soft Information Problem or you have tried to change them....", MsgBoxStyle.Critical)
            '        End
            '    End If




            'End If
            'Rk.SetValue(WinCur, "Windows" & SoftCode, xo(xo(plusdate)))
            m1 = Rk.GetValue(AukCur, "InsDate", "")
            m2 = xo(Rk.GetValue(WinCur, "Windows _Plus++" & SoftCode, ""))
            m3 = xo_back(Rk.GetValue(WinCur, "Windows _G++" & SoftCode, ""))
            LD = Rk.GetValue(WinCur, "Windows _Lndpas" & SoftCode, "")
            If (m1 = m2) And m1 = "" Then
                SetEr()
                CrEr(True)
            End If
            If m1 <> m2 Then
                SetEr()
                'CrEr()
                MsgBox("You are just trying to change dates... Software is Corrupt for this PC...Contact with auk...(0171-1334201)", MsgBoxStyle.Critical)
                End
            End If
            If LD <> "" Then
                mn = DateDiff(DateInterval.Day, LD, Now.Date)
                'MsgBox(mn)
                If Val(mn) < 0 Then
                    SetEr()
                    CrEr(True)
                    End
                End If
            End If
            Rk.SetValue(WinCur, "Windows _Lndpas" & SoftCode, Now.Date)

            mn = DateDiff(DateInterval.Day, m3, Now.Date)
            My.Settings.NowDays = mn
            My.Settings.Save()

            'MsgBox(mn)
            If Val(mn) > Val(TESTDAYS) Or Val(mn) < 0 Then
                'SetEr()
                DoRep()

                MsgBox("Your FreeTime Is Over buy Soft Key From Auk(0171-1334201,0193-500863)", MsgBoxStyle.Critical)
                If Val(mn) < 0 Then
                    SetEr()
                End If
                Me.Show()

            Else
                Nload()
            End If

        ElseIf Sn = "PersonalInstalling" Then

            m1 = Rk.GetValue(AukCur, "CodePersonalInstalling", "")
            m2 = Rk.GetValue(WinCur, "Windows_x86_" & SoftCode, "")
            m2 = AukF.ConTOAsc(xo(m2), "*", 21323)


            'insdate = (((Rpx.GetValue("CodePersonalInstalling"))))
            'po = (((CurWin.GetValue("Windows_x86_" & SoftCode))))
            'MsgBox(po, , insdate)
            If m1 = m2 Then
                'Me.Show()
                'nLoad.Show()
                'Me.Close()
                Nload()

            Else
                MsgBox("Code Is Wrong ,Contact With Auk(0171-1334201,0193-500863)...", MsgBoxStyle.Critical)
                End

            End If
        Else
            'Rk.SetValue(AukCur, "Category", "TestEditon")
            'Rk.SetValue(AukCur, "InsDate", xo(AukF.ConTOAsc(Now.Date.ToLongDateString, "*", 234)))
            'Rk.SetValue(WinCur, "Windows _Plus++" & SoftCode, AukF.ConTOAsc(Now.Date.ToLongDateString, "*", 234))
            'Rk.SetValue(WinCur, "Windows _G++" & SoftCode, xo(Now.Date))
            'TSTVERS()
            ''Rk.SetValue(AukCur, "SoftInfo", (Now.Date))
            ''Rk.SetValue(AukCur, "PlK", 0)
            ''Rk.SetValue(WinCur, "Windows" & SoftCode, (xo(0)))
            'MsgBox("Check Auk System Requirements successfully.....", MsgBoxStyle.Information)
            'Nload()

            Me.Show()
            'AukF.ComSelIndex(Me.ComboBox1)
            ' ''Sn = "***developeredition-auk-live***"
            ''If Sn.ToLower = "***developeredition-auk-live***" Or Sn.ToLower = "***developeredition-auk-live***confrim" Then
            ''    MsgBox("Registry Successfully for only DVD Rent DatabaseManagement.....", MsgBoxStyle.Information)

            ''    Rk.SetValue(AukCur, "CodePersonalInstalling", Sn.ToUpper)
            ''    Rk.SetValue(WinCur, "Windows_x86_" & SoftCode, xo(Sn.ToUpper))
            ''    Rk.SetValue(AukCur, "SoftInstallDate", xo(Now.Date))
            ''    Nload()
            ''Else
            ''    MsgBox("Error In Code Contact with auk(0193500863,01711-334201)", MsgBoxStyle.Critical)
            ''    Exit Sub
            ''End If
            ''Rk.SetValue(AukCur, "Category", "DeveloperInstalling")
        End If
        'Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim Aukf2 As New AukFC
        Dim T1, T2, T3, T4, T5 As String

        If Me.ComboBox1.Text = "PersonalInstalling" Then
            If Trim(Me.TextBox1.Text) = "" Then
                MsgBox("Please Type your company Name....", MsgBoxStyle.Critical)
                Me.TextBox1.Focus()

                Exit Sub

            End If
            T1 = Aukf2.ConTOAsc(Now.Date, "+", Now.Hour, False)
            T2 = Aukf2.ConTOAsc(xo(xo(T1)), "*", Now.Hour, True)
            T3 = (Aukf2.ConTOAsc(Aukf2.ConTOAsc((xo(T1)), "+", Now.Hour, True), "+", Now.Hour, True))
            T4 = (Aukf2.ConTOAsc(Aukf2.ConTOAsc((xo(T1)), "+", Now.Hour, True), "+", Now.Month * Now.Hour * Now.Year + Val(Aukf2.ConTOAsc(Now.Date, "", "", True)), True))
            T5 = AukF.ConTOAsc("ALIM UL KARIM", "*", 21, True) & "-" & AukF.ConTOAsc("CyberPackPro 2.0", "*", 21, True) & "-" & T4 & "-" & T1 & "-" & T2 & "-" & T3 & "-" & AukF.ConTOAsc(Me.TextBox1.Text, "*", Len(Me.TextBox1.Text) * 3, True)
            'MsgBox(T5)
            If T5 = UCase(Me.TextBox2.Text) Then
                My.Settings.REGISTED_VERSION = True
                My.Settings.Save()

                Rk.SetValue(AukCur, "CompanyName", Me.TextBox1.Text)
                Rk.SetValue(AukCur, "CodePersonalInstalling", AukF.ConTOAsc(xo(AukF.ConTOAsc(T5, "*", 234)), "*", 21323))
                Rk.SetValue(WinCur, "Windows_x86_" & SoftCode, AukF.ConTOAsc(T5, "*", 234))
                RemoveSet()
                MsgBox("Registry Successfully.....", MsgBoxStyle.Information)
                NONTSTVERS()
                backRep()
                Rk.SetValue(AukCur, "Category", "PersonalInstalling")
                Nload()
            Else
                MsgBox("Error In Code Contact with auk(0193500863,01711-334201)", MsgBoxStyle.Critical)
                Exit Sub
            End If
        ElseIf Me.ComboBox1.Text = "DeveloperInstalling" Then
            'MsgBox("in")
            Sn = Me.TextBox2.Text
            If Sn.ToLower = "***developeredition-auk-live***" Or Sn.ToLower = "***developeredition-auk-live***confrim" Then
                MsgBox("Registry Successfully for only DVD Rent DatabaseManagment.....", MsgBoxStyle.Information)
                Rk.SetValue(AukCur, "Category", "DeveloperInstalling")
                Rk.SetValue(AukCur, "CodePersonalInstalling", Sn.ToUpper)
                Rk.SetValue(WinCur, "Windows_x86_" & SoftCode, xo(Sn.ToUpper))
                Rk.SetValue(AukCur, "SoftInstallDate", xo(Now.Date))
                Rk.SetValue(AukCur, "Category", "DeveloperInstalling")
                backRep()

                RemoveSet()

                Nload()
                NONTSTVERS()
            Else
                MsgBox("Error In Code Contact with auk(0193500863,01711-334201)", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If Sn.ToLower = "***developeredition-auk-live***confrim" Then
                My.Settings.REGISTED_VERSION = True
                My.Settings.Save()
            End If
        Else
            Rk.SetValue(AukCur, "Category", "TestEditon")
            Rk.SetValue(AukCur, "InsDate", xo(AukF.ConTOAsc(Now.Date.ToLongDateString, "*", 234)))
            Rk.SetValue(WinCur, "Windows _Plus++" & SoftCode, AukF.ConTOAsc(Now.Date.ToLongDateString, "*", 234))
            Rk.SetValue(WinCur, "Windows _G++" & SoftCode, xo(Now.Date))
            TSTVERS()
            MsgBox("TestEdition you can you only " & TESTDAYS & " days.....", MsgBoxStyle.Information)
            Nload()
            My.Settings.REGISTED_VERSION = False
            My.Settings.Save()
        End If


    End Sub
    Public Sub TSTVERS()
        My.Settings.INSTALL_CATEGORY = "TestEditon"
        My.Settings.TotalDays = TESTDAYS
        My.Settings.NowDays = 0
        My.Settings.Save()

    End Sub
    Public Sub NONTSTVERS()
        My.Settings.INSTALL_CATEGORY = ""
        My.Settings.TotalDays = TESTDAYS
        My.Settings.NowDays = TESTDAYS
        My.Settings.Save()

    End Sub

    Public Sub RemoveSet()
        Dim Rk1 As RegistryKey = Registry.LocalMachine
        Dim Rn1 As RegistryKey = Rk1.OpenSubKey(WinCur, True)
        'Rk1.OpenSubKey()
        Try
            Rn1.DeleteValue(SoftCode)

        Catch ex As Exception

        End Try
    End Sub
    Public Sub SetEr()
        Rk.SetValue(WinCur, SoftCode, AukF.ConTOAsc("Error", "*", 894970979661))
    End Sub
    Public Function CrEr(ByVal DoJob As Boolean) As Boolean
        w = AukF.ConTOAsc("Error", "*", 894970979661)
        xwq = Rk.GetValue(WinCur, SoftCode, "")
        If xwq = w Then
            CrEr = True
        Else
            CrEr = False
        End If
        If DoJob = True Then
            If CrEr = True Then
                Try
                    If My.Computer.FileSystem.FileExists(Dbname) = True Then
                        My.Computer.FileSystem.CopyFile(Dbname, "C:\Windows\berC" & SoftCode, True)
                        My.Computer.FileSystem.MoveFile(Dbname, "C:\Windows\ber" & SoftCode, True)

                    End If
                Catch ex As Exception
                    MsgBox("Error is not Fixed,Contact with auk(01913500863).", MsgBoxStyle.Critical)
                End Try
                MsgBox("Please Contact with Developer to buy a Original version of this soft .Contact on (01913-500863)...", MsgBoxStyle.Critical)
                End
            End If
        End If
    End Function
    Public Sub DoRep()
        Try
            My.Computer.FileSystem.CopyFile(Dbname, "C:\Windows\berC" & SoftCode, True)
            My.Computer.FileSystem.MoveFile(Dbname, "C:\Windows\ber" & SoftCode, True)
        Catch ex As Exception
            MsgBox("Error is not Fixed,Contact with auk(01913500863).", MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub backRep()
        Try
            My.Computer.FileSystem.CopyFile("C:\Windows\berC" & SoftCode, My.Application.Info.DirectoryPath & "\AukDatabase2.mdb", True)
            'My.Computer.FileSystem.MoveFile(Dbname, "C:\Windows\ber" & SoftCode, True)
        Catch ex As Exception
            'MsgBox("Error is not Fixed,Contact with auk(01913500863).", MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AukSoft.Show()
        AukSoft.Activate()

    End Sub
End Class