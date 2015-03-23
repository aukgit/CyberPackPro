Imports R = Microsoft.Win32.Registry
Imports RK = Microsoft.Win32.RegistryKey
Imports Security.Cryptography
Imports System.Text
Public Module SrGens
    Public SoftCode As String = "C791_231"
    Public SoftName As String = "CyberPack Pro2.0"
    Public TestDays As Integer = 14
    Public SCATEGORY As Integer = 0
    Public nowdaysTst As Integer
    Public TestTimeEnd As Boolean = False
    Public ECor As String = SYS32() & "\winhttp" & SoftCode & ".dll"
    Dim SR1, SR2 As String
    Public HdSerial As String = SrGens.Get_HddSerial(True)
    Public GENCODESA(4) As String
    Public RegFrm As Register
    Dim Hdd_plus As Integer = 125
    Dim INTO1 As Integer = 16
    Dim INTO2 As Integer = 231
    Dim Plus As Integer = 8291
    Dim PLUS4 As Integer = 123 'hdd gen (plus)
    Dim Exp As String = "[sname][date][scode][package][cname][mixed]"
    Dim FIXIT_NUM As Integer = 3
    Dim Softversion As String = "2.0"
    Private Function SYS32() As String
        SYS32 = Environment.SystemDirectory
    End Function
    Public Function MakeSoft_Corrupt(Optional ByVal Category As Integer = 0, Optional ByVal Msg As String = "")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management\Publishers", SoftCode & " Windows _ ScreenEffects", AukF.ConTOAsc("Error", "*", 2411, True))
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\CyberPack Pro2.0", Soft_Install, "Set Error : Someone try to Change Registration to get more advantages but auk high security is detect that.(Software Corrput you can't run this soft in this windows...Please ReInstall Windows to Run this soft)") 'AukF.ConTOAsc("Error", "*", 2411, True)
        If Category = 0 Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", SoftCode & "_winappCalling", xo("Software is Corrupt because someone try broke auk secrurtiy .", 1))
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\AppKey", "app_key_" & SoftCode, xo("883294", 1))
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", SoftCode, AukF.ConTOAsc("Error", "*", 2411, True))
            SavStr(xo("corrupt-" & Category), SYS32() & "\winhttp" & SoftCode & ".dll")
            If Msg <> "" Then
                SavStr(xo("corrupt-" & Category & "-" & Msg), SYS32() & "\winhttp" & SoftCode & ".dll")
                MsgBox(Msg, MsgBoxStyle.Critical, "Software - Corrupt")
                Exit Function
            End If
            MsgBox("Someone try to Change Registration to get more advantages but auk high security is detect that.(Software Corrput you can't run this soft in this windows...Please ReInstall Windows to Run this soft).", MsgBoxStyle.Critical, "Software - Corrupt")
        ElseIf Category = 1 Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", SoftCode & "_winappCalling", xo("You have change you current computer date and set it before.", 1))
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\AppKey", "app_key_" & SoftCode, xo("883294", 1))
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", SoftCode, AukF.ConTOAsc("Error", "*", 2411, True))
            SavStr(xo("corrupt-" & Category), SYS32() & "\winhttp" & SoftCode & ".dll")
            If Msg <> "" Then
                SavStr(xo("corrupt-" & Category & "-" & Msg), SYS32() & "\winhttp" & SoftCode & ".dll")
                MsgBox(Msg, MsgBoxStyle.Critical, "Software - Corrupt")
                Exit Function
            End If
            MsgBox("You have change your computer current date to get advantages(ReInstall windows to use this soft trail again).", MsgBoxStyle.Critical, "Software - Corrupt")
        ElseIf Category = 2 Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", SoftCode & "_winappCalling", xo("You have change you current computer date and set it before.", 1))
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\AppKey", "app_key_" & SoftCode, xo("883294", 1))
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", SoftCode, AukF.ConTOAsc("Error", "*", 2411, True))
            SavStr(xo("corrupt-" & Category), SYS32() & "\winhttp" & SoftCode & ".dll")
            If Msg <> "" Then
                SavStr(xo("corrupt-" & Category & "-" & Msg), SYS32() & "\winhttp" & SoftCode & ".dll")
                MsgBox(Msg, MsgBoxStyle.Critical, "Software - Corrupt")
                Exit Function
            End If
            MsgBox("You have change in Registry so auk high security detect that.", MsgBoxStyle.Critical, "Software - Corrupt")
        End If
    End Function
    Public Function Delete_Corrupt()
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", SoftCode & "_winappCalling", "")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\AppKey", "app_key_" & SoftCode, "") ' xo("883294", 1)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", SoftCode, "") 'AukF.ConTOAsc("Error", "*", 2411, True)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management\Publishers", SoftCode & " Windows _ ScreenEffects", "") 'AukF.ConTOAsc("Error", "*", 2411, True)
        SavStr("", SYS32() & "\winhttp" & SoftCode & ".dll")
        My.Computer.Registry.LocalMachine.DeleteSubKey("SOFTWARE\AukOrganization\AukSoft\CyberPack Pro2.0")
    End Function
    Public Function Get_Corrupt(Optional ByVal ExitSoft As Boolean = False, Optional ByVal MSGSH As Boolean = True) As Boolean
        Dim Nk As String
        'On Error GoTo b
        Dim UA As Array

        a = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", SoftCode & "_winappCalling", "")
        b = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\AppKey", "app_key_" & SoftCode, "") ' xo("883294", 1)
        c = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", SoftCode, "") 'AukF.ConTOAsc("Error", "*", 2411, True)
        d = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management\Publishers", SoftCode & " Windows _ ScreenEffects", "") 'AukF.ConTOAsc("Error", "*", 2411, True)
        If a = "" Or b = "" Or c = "" Or d = "" Then
            Get_Corrupt = False
        Else
            If (b = xo("883294", 1)) Or (c = AukF.ConTOAsc("Error", "*", 2411, True)) Or (a = xo("You have change you current computer date and set it before.", 1)) Or (d <> "") Then
                Get_Corrupt = True
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\CyberPack Pro2.0", Soft_Install, "Set Error : Someone try to Change Registration to get more advantages but auk high security is detect that.(Software Corrput you can't run this soft in this windows...Please ReInstall Windows to Run this soft)") 'AukF.ConTOAsc("Error", "*", 2411, True)
                Nk = xo(GetStr(ECor), -2)
                UA = Nk.Split("-")
                If UA.GetUpperBound(0) = 0 Then
                    If MSGSH = True Then MsgBox("SOME SYSTEM & REGISTRATION PROBLEM.[CONACT WITH DEVELOPER OR REINSTALL WINDOWS & THEN INSTALL THIS SOFT AGAIN]", MsgBoxStyle.Critical, "SOFTWARE IS CORRUPT FOR THIS WINDOWS")
                    If ExitSoft = True Then End
                    Exit Function
                ElseIf UA.GetUpperBound(0) > 0 Then
                    If UA.GetValue(0).ToString.Substring(0, 7).ToLower.ToString <> "corrupt" Then
                        'cz = UA.GetValue(0).ToString.Substring(1, 6).ToLower.ToString
                        If MSGSH = True Then MsgBox("SOME SYSTEM & REGISTRATION PROBLEM.[CONACT WITH DEVELOPER OR REINSTALL WINDOWS  & THEN INSTALL THIS SOFT AGAIN]", MsgBoxStyle.Critical, "SOFTWARE IS CORRUPT FOR THIS WINDOWS")
                        If ExitSoft = True Then End
                        Exit Function
                    End If
                End If
                If UA.GetValue(1).ToString = 0 Then
                    If UA.GetUpperBound(0) = 1 Then
                        If MSGSH = True Then MsgBox("SOMEONE TRY TO CHANGE REGISTRATION TO GET MORE ADVANTAGES BUT AUK HIGH SECURITY IS DETECT THAT.(SOFTWARE CORRPUT YOU CAN'T RUN THIS SOFT IN THIS WINDOWS...PLEASE REINSTALL WINDOWS TO RUN THIS SOFT).", MsgBoxStyle.Critical, "SOFTWARE - CORRUPT")

                        If ExitSoft = True Then End
                    Else
                        MsgBox(UA.GetValue(2).ToString, MsgBoxStyle.Critical, "Software - Corrupt")
                        If ExitSoft = True Then End
                    End If
                ElseIf UA.GetValue(1).ToString = 1 Then
                    If UA.GetUpperBound(0) = 1 Then
                        If MSGSH = True Then MsgBox("YOU HAVE CHANGE YOUR COMPUTER CURRENT DATE TO GET ADVANTAGES(REINSTALL WINDOWS TO USE THIS SOFT TRAIL AGAIN).", MsgBoxStyle.Critical, "SOFTWARE - CORRUPT")
                        If ExitSoft = True Then End
                    Else
                        MsgBox(UA.GetValue(2).ToString, MsgBoxStyle.Critical, "Software - Corrupt")
                        If ExitSoft = True Then End
                    End If
                ElseIf UA.GetValue(1).ToString = 2 Then
                    If UA.GetUpperBound(0) = 1 Then
                        If MSGSH = True Then MsgBox("YOU HAVE CHANGE IN REGISTRY SO AUK HIGH SECURITY DETECT THAT.", MsgBoxStyle.Critical, "SOFTWARE - CORRUPT")
                        If ExitSoft = True Then End
                    Else
                        MsgBox(UA.GetValue(2).ToString, MsgBoxStyle.Critical, "Software - Corrupt")
                        If ExitSoft = True Then End
                    End If
                Else
                    Get_Corrupt = True
                    If MSGSH = True Then MsgBox("ERROR IN REGISTRATION ...CANT GET IN.", MsgBoxStyle.Critical)
                    End

                End If
                MsgBox("IF YOU WANT TO GET BACK YOUR DATABASE AGAIN ,DON'T FORMAT YOUR CURRENT WINDOWS AND CONTACT WITH AUK ELSE I CAN'T DO ANYTHING.", MsgBoxStyle.Critical, "TO BACKUP DATABASE")
            Else
                Get_Corrupt = False
            End If
        End If
        Exit Function

        'b:
        '        MsgBox(Err.Number, MsgBoxStyle.Critical, "Error In Checking Corrupt")
        '        MsgBox("Software is not ready.Contact with developer Auk(01913 500863).", MsgBoxStyle.Critical, "Error In Checking Corrupt")
        '        End

    End Function

    Public Function GetGenCode_2(ByVal GetHashCodeDouble As Boolean, ByVal Company As String, ByVal Package As String, ByVal RegCode As String, ByVal Software_InstallingCategory_packge As Integer, Optional ByVal UcaseAll As Boolean = False) As String
        Dim A As Integer = Software_InstallingCategory_packge
        Dim Str1, Str2 As String
        'Software_InstallingCategory_packge=0=test
        'Software_InstallingCategory_packge=1=developer
        'Software_InstallingCategory_packge=2=whole packge
        'Software_InstallingCategory_packge=3=mobile rechargeonly
        'Software_InstallingCategory_packge=4=cyberbusiness+free Mobile
        'Software_InstallingCategory_packge=5=DvdRent+Free Mobile
        '------------------------
        'code Category
        'CodeCategory=0 = normal large code(for all)
        'CodeCategory=1 = small 2 numeric 00000000-0000000
        'CodeCategory=2 = hascode & numeric (medium) AKAKKAKA92018-932798JKKKA
        'CodeCategory=3 = hascodes only SAHMGAJDGHSAJ-SADJHGDJDSAJD
        'If A >= 1 Then
        SCATEGORY = Software_InstallingCategory_packge
        Str1 = Software_InstallingCategory_packge & Company & Package & RegCode & SoftCode & SoftName
        c = AukF.ConTOAsc(Str1, "+", Plus, True)
        aa = SrGens.DisAppearDisgit(SrGens.Convert_Hash(Str1, Plus * 2, 0, GetHashCodeDouble, 8))
        b = SrGens.DisAppearDisgit(SrGens.Convert_Hash(Str1, 0, 0, GetHashCodeDouble, 4, True))
        d = SrGens.DisAppearDisgit(SrGens.Convert_Hash(Str1, Plus + 2, INTO1, Not GetHashCodeDouble, 8))
        Str2 = UCase(c) & "-" & UCase(aa) & "-" & UCase(b) & "-" & UCase(d)
        If UcaseAll = True Then GENCODESA(0) = Str2.ToUpper Else GENCODESA(0) = Str2
        GENCODESA(1) = AukF.ConTOAsc(Str2 & RegCode, "*", Plus, True) & "-" & AukF.ConTOAsc(Left(RegCode, 5) & Package & SoftCode & SoftName, "*", Plus, True)
        If UcaseAll = True Then GENCODESA(1) = UCase(AukF.ConTOAsc(Str2 & RegCode, "*", Plus, True) & "-" & AukF.ConTOAsc(Left(RegCode, 5) & Package & SoftCode & SoftName, "*", Plus, True)) Else 
        aa = AukF.ConTOAsc(Str2, "*", Plus, True)
        GENCODESA(2) = (SrGens.Convert_Hash(Str2, Plus - 100, 0, False, 4) & aa & "-" & SrGens.Convert_Hash(Str2 & RegCode, 0, Plus, True, 8))
        If UcaseAll = True Then GENCODESA(2) = GENCODESA(2).ToUpper
        GENCODESA(3) = (SrGens.Convert_Hash(Str2, INTO1, Plus / 2, GetHashCodeDouble, 8, Not GetHashCodeDouble) & "-" & SrGens.Convert_Hash(Str2, INTO1, Plus, Not GetHashCodeDouble, 5))
        If UcaseAll = True Then GENCODESA(3) = UCase(GENCODESA(3))
        If UcaseAll = True Then GetGenCode_2 = UCase(Str2) Else GetGenCode_2 = (Str2)
    End Function
    Public Function Get_HddSerial(Optional ByVal ExitFromSoft As Boolean = False) As String
        Dim Find As Boolean = False
        SR1 = xo(My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", True).GetValue("SrV_WinAccess").ToString, -2)
        SR2 = xo(AukF.GTxTStr(SR2, Environment.SystemDirectory.ToString & "\N.Net System.dll"), -4)
        If SR1 = SR2 Then
            Find = True
        Else
            Find = False
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\CheckSoft.exe") = True And Find = False Then
            Shell(My.Application.Info.DirectoryPath & "\CheckSoft.exe", AppWinStyle.Hide)
            SR1 = xo(My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", True).GetValue("SrV_WinAccess").ToString, -2)
            SR2 = xo(AukF.GTxTStr(SR2, Environment.SystemDirectory.ToString & "\N.Net System.dll"), -4)
            If SR1 = SR2 Then
                Find = True
            Else
                'Find = False
                SR1 = xo(My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", True).GetValue("SrV_WinAccess").ToString, -2)
                SR2 = xo(AukF.GTxTStr(SR2, Environment.SystemDirectory.ToString & "\N.Net System.dll"), -4)
                If SR1 = SR2 Then
                    Find = True
                Else
                    Find = False
                End If

            End If
        Else
            If ExitFromSoft = True Then
                If Find = False Then
                    MsgBox("YOU HAVE DELETE SOME FILE AND TRY TO IN HOOK REGISTRY.[PLEASE REINSTALL THIS SOFT]", MsgBoxStyle.Critical, "Registration Problem(Some one did this)")
                    End
                End If
            End If
        End If
        If ExitFromSoft = True Then
            If Find = False Then
                MsgBox("YOU HAVE DELETE SOME FILE AND TRY TO IN HOOK REGISTRY.[PLEASE REINSTALL THIS SOFT]", MsgBoxStyle.Critical, "Registration Problem(Some one did this)")
                End
            End If
        End If
        If Find = True Then
            Get_HddSerial = SR1

        End If
    End Function
    Public Function TESTEDITION_INSTALLING(ByVal COMPANY_NAME As String, ByVal INSDATE As Date, Optional ByVal FIXIT_NUM As Integer = 3) As Boolean

        SCATEGORY = 0
        FIXIT = SCATEGORY & vbCrLf & SoftCode & vbCrLf & INSDATE & vbCrLf & TestDays & vbCrLf & Now & vbCrLf & 0 & vbCrLf & "Begin"
        FIXTIT = xo(FIXIT, FIXIT_NUM)
        SavStr(FIXTIT, SYS32() & "\winhttp" & SoftCode & ".dll")
        normal_Reg("TESTEDITION_INSTALLING", COMPANY_NAME, INSDATE, Now.Date)
        MsgBox("THIS PACKAGE SOFTWARE TRAIL VERSION IS SUCCESSFULLY INTALLED IN YOUR COMPUTER FOR " & TestDays & ".", MsgBoxStyle.Information, "TEST EDITION IS SUCCESSFULLY REGISTRY")
        TESTEDITION_INSTALLING = True
    End Function
    Public Function Ins_OtherCategory(ByVal Category As Integer, ByVal Package As String, ByVal GenCode As String, ByVal RegCode As String, ByVal Company As String, ByVal GETDOUBLE As Boolean, Optional ByVal CodeCategory As Integer = 1, Optional ByVal CompanyNameMinLen As Integer = 7) As Boolean
        Dim Str1 As String
        Dim Ld, InsD As Date
        Dim Ua As Array
        Dim F, C As Integer
        Str1 = xo(GetStr(ECor), -FIXIT_NUM)
        'MsgBox(Str1)
        If Len(Company) < CompanyNameMinLen Then
            MsgBox("PLEASE TYPE A COMPANY NAME WHICH LENGHT MINIMUM " & CompanyNameMinLen & ".")
            Ins_OtherCategory = False
        End If
        SCATEGORY = Category
        If Str1.Trim <> "" Then
            Ua = Str1.Trim.Split(vbCrLf)
            If Ua.GetUpperBound(0) >= 9 Then
                If (Ua.GetUpperBound(0) >= 10 And (Ua.GetValue(0) >= 1 Or Ua.GetValue(0) = "")) Then
                Else
                    Ins_OtherCategory = False
                    MsgBox("CONACT WITH DEVELOPER SOME INITIALIZE PROBLEM.AUK ERROR 121(someone try to change in protected file.)", MsgBoxStyle.Critical)
                    Exit Function
                End If
            End If
        End If
        SrGens.normal_Reg(Package, Company, Now, Now)
        Str1 = SCATEGORY & vbCrLf & Company & vbCrLf & HdSerial & vbCrLf & Package & vbCrLf & RegCode & vbCrLf & CodeCategory & vbCrLf & SoftCode & vbCrLf & SoftName & vbCrLf & GETDOUBLE & vbCrLf & Plus & vbCrLf & GenCode
        Ua = Str1.Split(vbCrLf)
        'MsgBox(HdSerial)
        Ua.SetValue(CStr(xo(GenCode, 5)), 10)
        Str1 = SrGens.ArrayToStr(Ua, vbCrLf)
        SavStr(xo(Str1, FIXIT_NUM), ECor)
        MsgBox("REGISTRATION IS SAVE SUCCESSFULLY.", MsgBoxStyle.Information, "REGISTRATION COMPLETE")
        Ins_OtherCategory = True
    End Function
    Public Function CHECK_OTHER_CATEGORY_INS() As Boolean
        Dim Str1 As String
        Dim Ld, InsD As Date
        Dim Genx, TGen As String
        Dim Ua As Array
        Dim F, C As Integer
        'Dim Category, Company, HddSr, Package, Regcode, CodeCategory, Scode, Sname, GetDouble, Plus As String
        Str1 = xo(GetStr(ECor), -FIXIT_NUM)
        If Str1.Trim <> "" Then
            Ua = Str1.Trim.Split(vbCrLf)
            If Ua.GetUpperBound(0) < 3 Then
                CHECK_OTHER_CATEGORY_INS = False
                Exit Function
            End If
            If Ua.GetUpperBound(0) >= 9 And (Ua.GetValue(0) >= 0 And Ua.GetValue(0) <= 10) Then
                Genx = xo(Ua.GetValue(10).ToString.Trim, -5)
                'Ua.SetValue(Genx, 10)
                TGen = SrGens.GetGenCode_2(CBool(Ua.GetValue(8).ToString.Trim), Ua.GetValue(1).ToString.Trim, Ua.GetValue(2).ToString.Trim, Ua.GetValue(3).ToString.Trim, Ua.GetValue(4).ToString.Trim, Ua.GetValue(0).ToString.Trim, Ua.GetValue(5).ToString.Trim, Ua.GetValue(9).ToString.Trim)
                'gen = Genx
                If Genx.Trim.ToUpper = TGen.Trim.ToUpper And Genx.Length > 7 Then
                    CHECK_OTHER_CATEGORY_INS = True
                    SCATEGORY = CInt(Ua.GetValue(0).ToString.Trim)
                Else
                    CHECK_OTHER_CATEGORY_INS = False
                End If
            Else
                CHECK_OTHER_CATEGORY_INS = False
            End If
        Else
            CHECK_OTHER_CATEGORY_INS = False
        End If

    End Function
    Public Function Check_TestEdition(Optional ByVal FIXIT_NUM As Integer = 3) As Boolean
        Dim Str1 As String
        Dim Ld, InsD As Date
        Dim Ua As Array
        Dim F, C As Integer
        Str1 = xo(GetStr(ECor), -FIXIT_NUM)
        'MsgBox(Str1)
        Ua = Str1.Split(vbCrLf)
        'MsgBox(Ua.GetUpperBound(0))
        If Ua.GetUpperBound(0) > 0 Then
            If Ua.GetValue(0).ToString <> "0" Then
                Check_TestEdition = False
                Exit Function
            End If
            If Ua.GetUpperBound(0) >= 6 Then
                If Ua.GetValue(6).ToString = "Finish" Then
                    MsgBox("YOUR PACKAGE SOFTWARE TRAIL TIME IS EXPIRED.[PLEASE REGISTRY(CONACT WITH AUK 01913 500863)].", MsgBoxStyle.Information)
                    Check_TestEdition = True
                    SrGens.TestTimeEnd = True
                    Exit Function
                ElseIf Ua.GetValue(6).ToString = "Error" Then
                    MsgBox("SOME ONE CHANGE COMPUTER DATE & TIME TO GET ADVANTAGES.[REINSTALL WINDOWS].", MsgBoxStyle.Information)
                    Check_TestEdition = True
                    End
                    'SrGens.TestTimeEnd = True
                End If
            End If
        End If

        If Ua.GetUpperBound(0) >= 6 Then
            If Ua.GetUpperBound(0) = 6 And Ua.GetValue(0).ToString = "0" Then
                'test edition active
                Try
                    Ld = CDate(Str1.Split(vbCrLf).GetValue(4))
                    InsD = CDate(Str1.Split(vbCrLf).GetValue(2))
                Catch ex As Exception
                    Epx()
                End Try
                'If normal_CheckReg("TESTEDITION_INSTALLING", Ua.GetValue(2), Ld.Date) = False Then
                '    'MsgBox(normal_CheckReg("TESTEDITION_INSTALLING", Ua.GetValue(2), Ld.Date), , "nor Check False")
                '    SrGens.MakeSoft_Corrupt(0)
                'End If
                F = DateAndTime.DateDiff(DateInterval.Day, Ld.Date, Now.Date)
                'msgbox 
                C = DateAndTime.DateDiff(DateInterval.Day, InsD.Date, Now.Date)
                'MsgBox(F, , "F,c=" & C)
                'Check_TestEdition = True
                Ua.SetValue(CStr(Now), 4)
                Ua.SetValue(CStr(F), 5)
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Last Access Date", Now)
                If Val(C) > TestDays Then
                    TestTimeEnd = True
                    Ua.SetValue("Finish", 6)
                    MsgBox("YOUR PACKAGE SOFTWARE TRAIL TIME IS EXPIRED.[PLEASE REGISTRY(CONACT WITH AUK 01913 500863)].", MsgBoxStyle.Information)
                    Str1 = ArrayToStr(Ua, vbCrLf)
                    SavStr(xo(Str1, FIXIT_NUM), ECor)
                    Check_TestEdition = False
                    'RegFrm.Show()
                    'RegFrm.Activate()
                ElseIf Val(F) < 0 Or Val(C) < 0 Then
                    TestTimeEnd = True
                    Ua.SetValue("Error", 6)
                    Str1 = ArrayToStr(Ua, vbCrLf)
                    SavStr(xo(Str1, FIXIT_NUM), ECor)
                    Check_TestEdition = False
                    SrGens.MakeSoft_Corrupt(1)
                ElseIf Val(C) <= TestDays And Val(C) >= 0 Then
                    Ua.SetValue("Begins", 6)
                    Str1 = ArrayToStr(Ua, vbCrLf)
                    SavStr(xo(Str1, FIXIT_NUM), ECor)
                    SrGens.nowdaysTst = C
                    Check_TestEdition = True
                    SCATEGORY = 0
                    'SrGens.MakeSoft_Corrupt(1)
                End If
            Else
                Check_TestEdition = False
            End If
        Else
            Check_TestEdition = False
        End If

    End Function
    Public Function ArrayToStr(ByVal A1 As Array, Optional ByVal Keys As String = ",", Optional ByVal B As String = "", Optional ByVal A As String = "") As String
        ArrayToStr = ""
        For k As Integer = 0 To A1.GetUpperBound(0)
            If ArrayToStr = "" Then
                ArrayToStr = B & A1.GetValue(k) & A
            Else
                ArrayToStr = ArrayToStr & Keys & B & A1.GetValue(k) & A
            End If
        Next
    End Function
    Public Function normal_Reg(ByVal Category As String, ByVal company As String, ByVal insdate As String, ByVal LastAccess As String)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Company", company)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Install Date", insdate)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Last Access Date", LastAccess)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Cagegory", Category)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Soft_Install", "AukSignPerfect....OK")
    End Function
    Public Function normal_CheckReg(ByVal Category As String, ByVal Insdate As String, ByVal LastAccess As Date) As Boolean
        'c = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Company", "")
        Dim Cat As String
        Dim Lt, insD As Date

        insD = CDate(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Install Date", "")).Date
        Lt = CDate(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Last Access Date", "")).Date
        Cat = UCase(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Cagegory", ""))
        If Cat = Category And CDate(Insdate).Date = insD.Date And Lt = LastAccess.Date Then
            normal_CheckReg = True
            'MsgBox("normal True")
        Else
            normal_CheckReg = False

        End If

        'MsgBox(d & vbCrLf & l & vbCrLf & cat, , Category & vbCrLf & LastAccess & vbCrLf & insdate)
        'If Trim(LCase(Category)) = Trim(LCase(cat)) And CDate(Trim(LCase(LastAccess))).Date = CDate(LCase(Trim(l))) Then
        '    'If d = Insdate Then
        '    'End If

        '    MsgBox("nor Chk True")
        'Else
        '    normal_CheckReg = False
        'End If
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Soft_Install", "AukSignPerfect....OK")

    End Function
    Public Function For_Soft_Combo_HddSr(ByVal Package As String, ByVal Company As String, Optional ByVal CompanyNameMinLen As Integer = 7) As String
        'Dim Ex1 As String
        Dim H As Security.Cryptography.HashAlgorithm
        Dim HashBytes() As Byte
        Dim Uni As New UnicodeEncoding
        Dim a As Integer = CompanyNameMinLen
        If HdSerial <> "" Then
            If (Len(Company) >= a) Or a = 0 Then
                H = New Security.Cryptography.MD5CryptoServiceProvider
                HashBytes = H.ComputeHash(Uni.GetBytes(HdSerial))
                dm1 = Convert.ToBase64String(HashBytes).ToString
                Exp = Exp.ToLower.Replace("[sname]", SoftName)
                Exp = Exp.ToLower.Replace("[scode]", SoftCode)
                Exp = Exp.ToLower.Replace("[package]", Package)
                Exp = Exp.ToLower.Replace("[company]", Company)
                Exp = Exp.ToLower.Replace("[gcode]", dm1)
                dm2 = AukF.ConTOAsc(Exp, "*", INTO2, True)
                dm4 = AukF.ConTOAsc(Exp, "+", Plus, True)
                HashBytes = H.ComputeHash(Uni.GetBytes(Exp))
                dm3 = Convert.ToBase64String(HashBytes).ToString
                AukF.DivideIn_To_2(HdSerial, "-", False)
                HDD1 = Trim(QA2)
                HashBytes = H.ComputeHash(Uni.GetBytes(HDD1))
                dm5 = Convert.ToBase64String(HashBytes).ToString
                For_Soft_Combo_HddSr = dm2 & "-" & Left(dm1, Len(dm1) - 16) & "-" & dm4 & "-" & Left(dm3, 7) & "-" & Left(dm5, 7)
                For_Soft_Combo_HddSr = UCase(For_Soft_Combo_HddSr)
            Else
                For_Soft_Combo_HddSr = "PLEASE TYPE COMPANY NAME MINIMUM LENGHT " & a & "."
            End If
        End If
    End Function
    Public Function DisAppearDisgit(ByVal Str As String, Optional ByVal Back As Boolean = False, Optional ByVal Find As String = "-", Optional ByVal Rep As String = "[#]", Optional ByVal Match As Boolean = False) As String
        If Back = True Then
            Str = AukMod.RStr2(Str, Rep, Find, Match)
        Else
            Str = AukMod.RStr2(Str, Find, Rep, Match)
        End If
        DisAppearDisgit = Str

    End Function
    Public Function Convert_Hash_RND(ByVal Str1 As String, Optional ByVal NumPlus As Integer = 0, Optional ByVal NumInto As Integer = 0, Optional ByVal Gethash_ByMadeIT_Double As Boolean = False, Optional ByVal maxD As Integer = 22, Optional ByVal GetCodeByCode As Boolean = False) As String
        If Str1 = Nothing Then Return "" : Exit Function
        Dim C, D, G As Decimal
        Dim H As Security.Cryptography.HashAlgorithm
        Dim HashBytes() As Byte
        Dim Uni As New UnicodeEncoding
        H = New Security.Cryptography.HMACMD5
        If NumPlus > 0 Then
            C = CDec(AukF.ConTOAsc(Str1, "+", NumPlus, True))
        Else
            C = 0
        End If
        If NumInto > 0 Then
            D = CDec(AukF.ConTOAsc(Str1, "+", NumPlus, True))
        Else
            D = 0
        End If
        G = C + D
        If G > 0 Then
            Str1 = Str1 & G
        End If
        If Gethash_ByMadeIT_Double = True Then
            Str1 = Str1 & Str1
        End If
        HashBytes = H.ComputeHash(Uni.GetBytes(Str1))
        Convert_Hash_RND = Left(Convert.ToBase64String(HashBytes).ToString, maxD)
        If GetCodeByCode = True Then
            Convert_Hash_RND = Convert_Hash_RND & Convert_Hash_RND
            HashBytes = H.ComputeHash(Uni.GetBytes(Convert_Hash_RND))
            Convert_Hash_RND = Left(Convert.ToBase64String(HashBytes).ToString, maxD)
        End If
    End Function
    Public Function Convert_Hash(ByVal Str1 As String, Optional ByVal NumPlus As Integer = 0, Optional ByVal NumInto As Integer = 0, Optional ByVal Gethash_ByMadeIT_Double As Boolean = False, Optional ByVal maxD As Integer = 22, Optional ByVal GetCodeByCode As Boolean = False) As String
        Dim C, D, G As Decimal
        Dim H As Security.Cryptography.HashAlgorithm
        Dim HashBytes() As Byte
        Dim Uni As New UnicodeEncoding
        H = New Security.Cryptography.MD5CryptoServiceProvider
        If NumPlus > 0 Then
            C = CDec(AukF.ConTOAsc(Str1, "+", NumPlus, True))
        Else
            C = 0
        End If
        If NumInto > 0 Then
            D = CDec(AukF.ConTOAsc(Str1, "+", NumPlus, True))
        Else
            D = 0
        End If
        G = C + D
        If G > 0 Then
            Str1 = Str1 & G
        End If
        If Gethash_ByMadeIT_Double = True Then
            Str1 = Str1 & Str1
        End If
        HashBytes = H.ComputeHash(Uni.GetBytes(Str1))
        Convert_Hash = Left(Convert.ToBase64String(HashBytes).ToString, maxD)
        If GetCodeByCode = True Then
            Convert_Hash = Convert_Hash & Convert_Hash
            HashBytes = H.ComputeHash(Uni.GetBytes(Convert_Hash))
            Convert_Hash = Left(Convert.ToBase64String(HashBytes).ToString, maxD)
        End If
    End Function
    'Public Function Set_Installed(ByVal GenCode As String, ByVal InsDateN As String, ByVal PakegeName As String, ByVal CompanyName As String, ByVal serialCodeSum_Plus As Integer, Optional ByVal Exp As String = "[sname][date][scode][package][cname][mixed]")
    '    'q = My.Computer.FileSystem.SpecialDirectories.ProgramFiles.ToString
    '    'drv = Left$(q, 3)
    '    'sys = drv & "Windows\system32"
    '    s1 = SYS32()
    '    acq = SoftCode & "[#][*]," & SoftName & "[#][*]," & InsDateN & "[#][*]," & PakegeName & "[#][*]," & CompanyName & "[#][*]," & serialCodeSum_Plus & "[#][*]," & Exp & "[#][*]," & GenCode

    'End Function
    Public Function GenSrls_By_DT_Hour(ByVal DateN As String, ByVal PakegeName As String, ByVal CompanyName As String, ByVal serialCodeSum_Plus As Integer, Optional ByVal Exp As String = "[sname][date][scode][package][cname][mixed]")
        Dim D1 As Date
        Try
            D1 = CDate(DateN)
        Catch ex As Exception
            Epx()
            Exit Function
        End Try
        Dim HOUR1, MIN1 As String
        a = serialCodeSum_Plus
        Exp = Exp.ToLower.Replace("[sname]", SoftName)
        dat = NumbersConverts(DateN, a)
        Exp = Exp.ToLower.Replace("[date]", dat)
        Exp = Exp.ToLower.Replace("[scode]", SoftCode)
        Exp = Exp.ToLower.Replace("[package]", PakegeName)
        Exp = Exp.ToLower.Replace("[cname]", CompanyName)
        MIN1 = "ABNIO,KLAQ,PPQOI,AJSHDF,LPAS,QQHAJ,AHDJQ,JHAD,HAGF,ALIM,SALIM,CAUKM,PPQKA,LQPA,HRTY,LAPQ,HTJ,HHHA,QQQLA,HGA,PPQ,ALVIDA,TUNE,KHE DIYA,ALVIDA,MUKH,IRON,SPIDER,GAGET,RUM,KKAPQ,KSA,LLA,KURMA,KE.RA,M22@A,JHFAJ,AAF"
        HOUR1 = "PPAWQX,JJAKKFA,RRQTTA,JHSKJHFA,KLJFKA,LLAOF,TTQQQ,KAJF,APUKA,ALIMHSGF,AUK-COM.AJ,AJHGF"
        asq = Right(CStr(TimeOfDay), 2)
        hrtxt = HOUR1.Split(",").GetValue(Now.Hour) & MIN1.Split(",").GetValue(D1.Month) & HOUR1.Split(",").GetValue(Now.Hour) & asq & HOUR1.Split(",").GetValue(Now.Hour)
        'Exp = Exp & hrtxt
        Exp = Exp.ToLower.Replace("[mixed]", hrtxt)
        xn = AukF.ConTOAsc(Exp, "*", CDec(a), True)
        If Val(xn) > 0 Then
            If CheckOdd_Number(D1.Day) = True Then
                If Now.Hour = 1 Or Now.Hour = 3 Or Now.Hour = 5 Or Now.Hour = 7 Or Now.Hour = 9 Then
                    If Now.Hour = 0 Then xn = (xn) * (13) Else xn = (xn) * Now.Hour * (D1.Day + 1)
                Else
                    If D1.Month = 0 Then xn = (xn) * (13) Else xn = (xn) * (D1.Month + 1)
                End If
            End If
        End If
        If CheckOdd_Number(D1.Month) = False Then
            xn = (xn) * (D1.Month / 2)
        End If
        If LCase(asq) = "am" Then
            If Val(xn) > 0 Then
                xn = xn * 2

            End If
        End If
        GenSrls_By_DT_Hour = xn

    End Function
    Public Function CheckOdd_Number(ByVal Num As String) As Boolean
        If InStr(Num / 2, ".") = 0 Then
            CheckOdd_Number = True
        Else
            CheckOdd_Number = False
        End If
    End Function
    Public Function Reg_InPacific(ByVal Dir As String, ByVal NameOFDateIns As String, ByVal NameOfRegCode As String, ByVal NameOfCompanyName As String, ByVal RegFolderName As String, ByVal Group As String, ByVal SoftwareInsCategory As String, ByVal CompanyName As String)
        'NameOFDateIns - date name,where insert or save the ins date
        'NameOfRegCode - name of code of software store .NameOfCompanyName- as same
        'RegFolderName - SoftName By Cr

    End Function
    Public Function Split_ToList(ByVal Lst As ListBox, ByVal Txt As String, Optional ByVal SplitSPec As String = ",")
        Lst.Items.Clear()

        For k As Integer = 0 To Txt.Split(SplitSPec).GetUpperBound(0)
            Lst.Items.Add(Txt.Split(SplitSPec).GetValue(k))
            'MsgBox(Txt.Split(SplitSPec).GetValue(k))
            f = Txt.Split(SplitSPec).GetValue(k) & vbCrLf & f
        Next
        MsgBox(f)
    End Function
    Public Function NumbersConverts(Optional ByVal DateN As String = "", Optional ByVal HowManyTimesRotate As Integer = 0, Optional ByVal back As Boolean = False)
        Dim am, am2 As String
        'Dim Lst, Lst2 As New ListBox
        'Dim Ls4t As ArrayList

        am = "0,1,2,3,4,5,6,7,8,9"
        am2 = "3,5,4,9,0,8,7,1,6,2"
        'Split_ToList(Lst, am, ",")
        'Split_ToList(Lst2, am2, ",")
        'MsgBox(Lst.Items.Count)

        If DateN = "" Then
            DateN = Now.Date
        End If
        If back = False Then
            DateN = DateN.Replace("AM", "Y")
            DateN = DateN.Replace("PM", "Q")
            DateN = DateN.Replace("/", "F")
            DateN = DateN.Replace("-", "L")
            DateN = DateN.Replace(":", "u")
            'DateN = DateN.Replace(":", "u")
            DateN = DateN.Replace(" ", "@")
        Else
            DateN = DateN.Replace("Y", "AM")
            DateN = DateN.Replace("Q", "PM")
            DateN = DateN.Replace("F", "/")
            DateN = DateN.Replace("L", "-")
            DateN = DateN.Replace("u", ":")
            'DateN = DateN.Replace(":", "u")
            DateN = DateN.Replace("@", " ")
        End If
        For dx As Integer = 0 To HowManyTimesRotate
            For k As Integer = 1 To Len(DateN)
                xa = Mid(DateN, k, 1)
                'If LCase(xa) = "a" Or LCase(xa) = "p" Then
                '    xa = Mid(DateN, k, 2)
                '    k = k + 1
                'End If
                If back = False Then
                    'm1 = AukF.FindInObjectAndSelect(Lst, xa, True)
                    m1 = Array.BinarySearch(am.Split(","), xa)
                    If Val(m1) > -1 Then
                        Mid(DateN, k, 1) = am.Split(",").GetValue(CInt(m1))

                        'Else
                        '    MsgBox("Error Function Not Found(" & xa & ").", MsgBoxStyle.Critical)
                        '    Exit Function
                        'Mid(DateN, k, 1) = am2.Split(",").GetValue(CInt(m1))
                    End If
                Else

                    'm1 = AukF.FindInObjectAndSelect(Lst2, xa, True)
                    m1 = Array.BinarySearch(am2.Split(","), xa)

                    If Val(m1) > -1 Then
                        Mid(DateN, k, 1) = am2.Split(",").GetValue(CInt(m1))
                        'Else
                        '    MsgBox("Error Function Not Found(" & xa & ").", MsgBoxStyle.Critical)
                        '    Exit Function
                    End If
                End If
                'm2 = Array.BinarySearch(am2.ToCharArray, xa)
            Next
        Next
        NumbersConverts = DateN

    End Function
    Public Function Convert1(ByVal str1 As String, Optional ByVal CountAsc As Integer = 2, Optional ByVal Sign As String = "+")
        On Error Resume Next
        For m As Integer = 1 To Len(str1)
            xa = Mid(str1, m, 1)
            If Sign = "+" Then
                Mid(str1, m, 1) = Chr(Asc(xa) + CountAsc)
            ElseIf Sign = "*" Then
                Mid(str1, m, 1) = Chr(Asc(xa) * CountAsc)
            ElseIf Sign = "/" Then
                Mid(str1, m, 1) = Chr(Asc(xa) / CountAsc)
            ElseIf Sign = "-" Then
                Mid(str1, m, 1) = Chr(Asc(xa) - CountAsc)
            End If
        Next
        Con1 = str1
    End Function
    Public Function Convert2(ByVal str1 As String, Optional ByVal CountAsc As Integer = -2, Optional ByVal Sign As String = "+")
        On Error Resume Next
        For m As Integer = 1 To Len(str1)
            xa = Mid(str1, m, 1)
            If Sign = "+" Then
                Mid(str1, m, 1) = Chr(Asc(m) + CountAsc)
            ElseIf Sign = "*" Then
                Mid(str1, m, 1) = Chr(Asc(m) * CountAsc)
            ElseIf Sign = "/" Then
                Mid(str1, m, 1) = Chr(Asc(m) / CountAsc)
            ElseIf Sign = "-" Then
                Mid(str1, m, 1) = Chr(Asc(m) - CountAsc)
            End If
        Next
        Con1 = str1
    End Function
    'Public Function AukArr_Find(ByVal Array As Array, ByVal FindTxt As String, Optional ByVal Start As Integer = 0) As Boolean
    '    comrow=array.FindIndex (array,addressof 
    'End Function
    'Private Function FindArray(ByVal s As String, ByVal FindTxt As String, Optional ByVal MatchExt As Boolean = False) As Boolean
    '    If MatchExt = False Then
    '        If s = FindTxt Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Else
    '        If s.ToLower = FindTxt.ToLower Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    End If

    'End Function

End Module
