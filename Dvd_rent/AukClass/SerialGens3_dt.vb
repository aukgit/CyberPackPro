Imports Microsoft.Win32.Registry
Imports Microsoft.Win32.RegistryKey
Imports System.Security.Cryptography
Imports System.Text
Public Module SrGens
    Public SoftInsDate As DateTime
    Public SoftCode As String = "C791_231"
    Dim ICode As String = "Microsoft_SrIcodes"
    Dim IName As String = "AukSoftware's Serial Generetor"
    Public SoftName As String = "CyberPack Pro2.0"
    Public TVer As Boolean = False
    Public TestDays As Integer = 7
    Public MiliSec As Integer = -1
    Public SCategory As Integer = -14
    Public nowdaysTst As Integer
    Public TestTimeEnd As Boolean = False
    Dim GetDouble, UcaseX As Boolean
    Public ECor As String = SYS32() & "\winhttp" & SoftCode & ".dll"
    Dim IECor As String = SYS32() & "\winhttpInsTrans" & ICode & ".dll"
    Dim SR1, SR2 As String
    'Public HdSerial As String = SrGens.Get_HddSerial(True)
    Public GENCODESA(4) As String
    'Public RegFrm As Register
    Dim HDD_Sr, IRegCode, IInsCode As String
    Dim Hdd_plus As Integer = 20
    Dim INTO1 As Integer = 144
    Dim INTO2 As Integer = 5
    Dim Plus As Integer = 8291
    Dim Soft_MaxPackage As Integer = 12
    'Dim PLUS4 As Integer = 123 'hdd gen (plus)
    Dim IVer As String = "1.2"
    Dim ExpSr As String = "[sname][sversion][scode][package][company][hdsr]"
    'Dim IExpSr As String = "[icode][sname][iname][sversion][iver][scode][package][company][hdsr]"
    Dim IExpSr As String = ExpSr
    Dim FIXIT_NUM As Integer = 3
    Public SoftVersion As String = "2.0"
    Public RCompany, SPackage, RegCode, InsCode, SFunc_ As String

    Public Function Soft_load_byID(ByVal ID As String, Optional ByVal Msg As Boolean = False) As Boolean  'if registered
        Dim Ua() As String
        SoftCode = ID
        ECor = SYS32() & "\winhttp" & SoftCode & ".dll"
        WGeT = GetStr(ECor)

        If Trim(WGeT) <> "" Then WGeT = xo(WGeT, -FIXIT_NUM) : Ua = WGeT.Split(",") Else Ua = Nothing
        If Ua IsNot Nothing Then
            If WGeT.Trim = "" Then Return False
            If Ua.GetUpperBound(0) >= 17 Then
                SoftCode = Ua(0)
                SoftName = Ua(1)
                SoftVersion = Ua(2)
                Soft_MaxPackage = Ua(3)
                ExpSr = Ua(4)
                RegCode = Ua(5)
                InsCode = Ua(6)
                HDD_Sr = Ua(7)
                FIXIT_NUM = Ua(8)
                Plus = Ua(9)
                Hdd_plus = Ua(10)
                INTO1 = Ua(11)
                INTO2 = Ua(12)
                GetDouble = CBool(Ua(13))
                'UcaseX = CBool(ax)
                UcaseX = CBool(CStr(Ua(14)))
                SCategory = Ua(15)
                RCompany = Ua(16)
                SPackage = Ua(17)
                Return True
            Else
                If Msg = True Then MsgBox("SOFT INFORMATION LOAD REG ERROR.", MsgBoxStyle.Critical)
            End If
        End If
    End Function
    Public Function Soft_load_byID_Sr(ByVal ID As String, Optional ByVal Msg As Boolean = False) As Boolean  'if registered
        Dim Ua() As String
        ICode = ID
        IECor = SYS32() & "\winhttpInsTrans" & ICode & ".dll"
        WGeT = GetStr(IECor)
        'MsgBox(WGeT)
        If WGeT <> "" Then Ua = WGeT.Split(",") Else Ua = Nothing
        If Ua IsNot Nothing Then
            If WGeT.Trim = "" Then Return False
            If Ua.GetUpperBound(0) >= 5 Then
                ICode = Ua(0)
                IName = Ua(1)
                SoftCode = Ua(2)
                SCategory = Ua(3)
                SFunc_ = Ua(4)
                SoftName = Ua(5)
                IRegCode = Ua(6)
                IInsCode = Ua(7)
                Return True
            Else
                If Msg = True Then MsgBox("SOFT[Serials] INFORMATION LOAD REG ERROR.", MsgBoxStyle.Critical)
            End If
        End If
    End Function
    Public Sub Soft_loadBy(ByVal ID As String, ByVal SCODE As String, ByVal SNAME As String, ByVal SVER As String, ByVal sMax As Integer, ByVal EXPSR_ As String, ByVal REGCODE_ As String, ByVal INSCODE_ As String, ByVal HDD_SR_ As String, ByVal FIXIT_NUM_ As Integer, ByVal PLUS_ As Integer, ByVal HDD_PLUS_ As Integer, ByVal INTO1_ As Integer, ByVal INTO2_ As Integer, Optional ByVal GETDOUBLE_ As Boolean = False, Optional ByVal uCASEALL_ As Boolean = True, Optional ByVal SCATEGORY_ As Integer = -14, Optional ByVal SPackage_ As String = "", Optional ByVal RComPany_ As String = "AuOrganization")
        SoftCode = SCODE
        ECor = SYS32() & "\winhttp" & SoftCode & ".dll"
        SoftName = SNAME
        SoftVersion = SVER
        Soft_MaxPackage = sMax
        ExpSr = EXPSR_
        RegCode = REGCODE_
        InsCode = INSCODE_
        HDD_Sr = HDD_SR_
        FIXIT_NUM = FIXIT_NUM_
        Plus = PLUS_
        Hdd_plus = HDD_PLUS_
        INTO1 = INTO1_
        INTO2 = INTO2_
        GetDouble = GETDOUBLE_
        UcaseX = uCASEALL_
        SCategory = SCATEGORY_
        RCompany = RComPany_
        SPackage = SPackage_
    End Sub
    Private Function SYS32() As String
        SYS32 = Environment.SystemDirectory
    End Function
    Public Sub Caliing_MakeSoft_Corrupt(ByVal SoftCode_ As String, ByVal SoftName_ As String, Optional ByVal Category As Integer = 0, Optional ByVal Msg As String = "")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management\Publishers", SoftCode_ & " Windows _ ScreenEffects", AukF.ConTOAsc("Error" & SoftCode_, "*", 2411, True))
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName_, "Soft_Install", "Set Error : Someone try to Change Registration to get more advantages but auk high security is detect that.(Software Corrput you can't run this soft in this windows...Please ReInstall Windows to Run this soft)") 'AukF.ConTOAsc("Error", "*", 2411, True)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", SoftCode_ & "_winappCalling", xo("Software is Corrupt because someone try broke auk secrurtiy .", 1))
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ExpSrlorer\AppKey", "app_key_" & SoftCode_, xo("883294" & SoftCode_, 1))
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", SoftCode_, AukF.ConTOAsc("Error" & SoftCode_, "*", 2411, True))
        If Category = 0 Then
            SavStr(xo("corrupt-" & Category), SYS32() & "\winhttp" & SoftCode_ & ".dll")
            If Msg <> "" Then
                SavStr(xo("corrupt-" & Category & "-" & Msg), SYS32() & "\winhttp" & SoftCode_ & ".dll")
7:              MsgBox(Msg, MsgBoxStyle.Critical, "Software - Corrupt")
                Exit Sub
            End If
            MsgBox("Someone try to Change Registration to get more advantages but auk high security is detect that.(Software Corrput you can't run this soft in this windows...Please ReInstall Windows to Run this soft).", MsgBoxStyle.Critical, "Software - Corrupt")
        ElseIf Category = 1 Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", SoftCode_ & "_winappCalling", xo("You have change you current computer date and set it before.", 1))
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ExpSrlorer\AppKey", "app_key_" & SoftCode_, xo("883294" & SoftCode_, 1))
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", SoftCode_, AukF.ConTOAsc("Error" & SoftCode_, "*", 2411, True))
            SavStr(xo("corrupt-" & Category), SYS32() & "\winhttp" & SoftCode_ & ".dll")
            If Msg <> "" Then
                SavStr(xo("corrupt-" & Category & "-" & Msg), SYS32() & "\winhttp" & SoftCode_ & ".dll")
                MsgBox(Msg, MsgBoxStyle.Critical, "Software - Corrupt")
                Exit Sub
            End If
            MsgBox("You have change your computer current date to get advantages(ReInstall windows to use this soft trail again).", MsgBoxStyle.Critical, "Software - Corrupt")
        ElseIf Category = 2 Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", SoftCode_ & "_winappCalling", xo("You have change you current computer date and set it before.", 1))
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ExpSrlorer\AppKey", "app_key_" & SoftCode_, xo("883294" & SoftCode_, 1))
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", SoftCode_, AukF.ConTOAsc("Error" & SoftCode_, "*", 2411, True))
            SavStr(xo("corrupt-" & Category), SYS32() & "\winhttp" & SoftCode_ & ".dll")
            If Msg <> "" Then
                SavStr(xo("corrupt-" & Category & "-" & Msg), SYS32() & "\winhttp" & SoftCode_ & ".dll")
                MsgBox(Msg, MsgBoxStyle.Critical, "Software - Corrupt")
                Exit Sub
            End If
            MsgBox("You have change in Registry so auk high security detect that.", MsgBoxStyle.Critical, "Software - Corrupt")
        End If
    End Sub
    Public Sub Make_Corrupt(Optional ByVal Category As Integer = 0, Optional ByVal Msg As String = "")
        SrGens.Caliing_MakeSoft_Corrupt(SoftCode, SoftName, Category, Msg)
    End Sub
    Public Sub SrMake_Corrupt(Optional ByVal Category As Integer = 0, Optional ByVal Msg As String = "")
        SrGens.Caliing_MakeSoft_Corrupt(ICode, IName, Category, Msg)
    End Sub
    Public Sub Calling_Delete_Corrupt(ByVal SoftCode_ As String, ByVal Softname_ As String)
        Try
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", SoftCode_ & "_winappCalling", "")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ExpSrlorer\AppKey", "app_key_" & SoftCode_, "") ' xo("883294", 1)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", SoftCode_, "") 'AukF.ConTOAsc("Error", "*", 2411, True)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management\Publishers", SoftCode_ & " Windows _ ScreenEffects", "") 'AukF.ConTOAsc("Error", "*", 2411, True)
            SavStr("", SYS32() & "\winhttp" & SoftCode_ & ".dll")
            My.Computer.Registry.LocalMachine.DeleteSubKey("SOFTWARE\AukOrganization\AukSoft\" & Softname_)
        Catch ex As Exception
            Epx()
        End Try

    End Sub
    Public Sub Delete_Corrupt()
        Calling_Delete_Corrupt(SoftCode, SoftName)
    End Sub
    Public Sub SrDelete_Corrupt()
        Calling_Delete_Corrupt(ICode, IName)
    End Sub
    Private Function Calling_GetCorrupt(ByVal SoftCode_ As String, ByVal Softname_ As String, Optional ByVal ExitSoft As Boolean = False, Optional ByVal MSGSH As Boolean = True) As Boolean
        Dim Nk As String
        'On Error GoTo b
        Dim UA As Array
        a = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", SoftCode_ & "_winappCalling", "")
        b = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ExpSrlorer\AppKey", "app_key_" & SoftCode_, "") ' xo("883294", 1)
        c = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", SoftCode_, "") 'AukF.ConTOAsc("Error", "*", 2411, True)
        d = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Management\Publishers", SoftCode_ & " Windows _ ScreenEffects", "") 'AukF.ConTOAsc("Error", "*", 2411, True)
        If a = "" And b = "" And c = "" And d = "" Then
            Calling_GetCorrupt = False
        Else
            If (b = xo("883294" & SoftCode_, 1)) Or (c = AukF.ConTOAsc("Error" & SoftCode_, "*", 2411, True)) Or (a = xo("You have change you current computer date and set it before.", 1)) Or (d <> "") Then
                Calling_GetCorrupt = True
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & Softname_, "Soft_Install", "Set Error : Someone try to Change Registration to get more advantages but auk high security is detect that.(Software Corrput you can't run this soft in this windows...Please ReInstall Windows to Run this soft)") 'AukF.ConTOAsc("Error", "*", 2411, True)
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
                    Calling_GetCorrupt = True
                    If MSGSH = True Then MsgBox("ERROR IN REGISTRATION ...CANT GET IN.", MsgBoxStyle.Critical)
                    End
                End If
                MsgBox("IF YOU WANT TO GET BACK YOUR DATABASE AGAIN ,DON'T FORMAT YOUR CURRENT WINDOWS AND CONTACT WITH AUK ELSE I CAN'T DO ANYTHING.", MsgBoxStyle.Critical, "TO BACKUP DATABASE")
            Else
                Calling_GetCorrupt = False
            End If
        End If
        Exit Function
    End Function
    Public Function Get_Corrupt(Optional ByVal ExitSoft As Boolean = False, Optional ByVal MSGSH As Boolean = True) As Boolean
        SrGens.Calling_GetCorrupt(SoftCode, SoftName, ExitSoft, MSGSH)
    End Function
    Public Function Sr_Get_Corrupt(Optional ByVal ExitSoft As Boolean = False, Optional ByVal MSGSH As Boolean = True) As Boolean
        SrGens.Calling_GetCorrupt(ICode, IName, ExitSoft, MSGSH)
    End Function
    Public Function GetGenCode_2(ByVal GetHashCodeDouble As Boolean, ByVal Company As String, ByVal Package As String, ByVal RegCode_ As String, ByVal Software_InstallingCategory_packge As Integer, Optional ByVal UcaseAll As Boolean = False) As String
        Dim A As Integer = Software_InstallingCategory_packge
        Dim Str1, Str2 As String
        SCategory = Software_InstallingCategory_packge
        Str1 = Software_InstallingCategory_packge & Company & Package & RegCode_ & SoftCode & SoftName
        'MsgBox(Str1)
        'Clipboard.Clear()
        'Clipboard.SetText(Str1)
        c = AukF.ConTOAsc(Str1, "+", Plus, True)
        aa = SrGens.DisAppearDisgit(SrGens.Convert_Hash(Str1, Plus * 2, 0, GetHashCodeDouble, 8))
        b = SrGens.DisAppearDisgit(SrGens.Convert_Hash(Str1, 0, 0, GetHashCodeDouble, 4, True))
        d = SrGens.DisAppearDisgit(SrGens.Convert_Hash(RegCode_, Plus + 2, INTO1, Not GetHashCodeDouble, 8))
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
        On Error GoTo b
        Dim FileN As String = SYS32() & "\N.Net System.dll"
        'MsgBox(FileN)
runagain: If My.Computer.FileSystem.FileExists(FileN) = True Then
            SR1 = xo(My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", True).GetValue("SrV_WinAccess").ToString, -2)
            SR2 = xo(GetStr(FileN).ToString.Trim, -4)
            If SR1 = SR2 And SR1.Trim <> "" Then
                Find = True
            Else
                Find = False
            End If
        Else
            Find = False
        End If
        'Clipboard.Clear()
        'Clipboard.SetText(SR1)
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\CheckSoft.exe") = True And Find = False Then
            'MsgBox(My.Application.Info.DirectoryPath & "\CheckSoft.exe")
            Shell(My.Application.Info.DirectoryPath & "\CheckSoft.exe")
            If My.Computer.FileSystem.FileExists(SYS32() & "\" & "CheckSoft.exe") = True Then Shell(SYS32() & "\" & "CheckSoft.exe")
            If My.Computer.FileSystem.FileExists(FileN) = False Then GoTo runagain
            SR1 = xo(My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", True).GetValue("SrV_WinAccess").ToString, -2)
            SR2 = xo(GetStr(FileN), -4)
            If SR1 = SR2 Then
                Find = True
            Else
                'Find = False
                SR1 = xo(My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Management", True).GetValue("SrV_WinAccess").ToString, -2)
                SR2 = xo(GetStr(FileN), -4)
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
        Exit Function
b:      If ExitFromSoft = True Then
            MsgBox("Soft is not Valid or Installed Successfully.", MsgBoxStyle.Critical)
            MsgBox(My.Application.Info.DirectoryPath & "\CheckSoft.exe")
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\CheckSoft.exe") = True Then
                Shell(My.Application.Info.DirectoryPath & "\CheckSoft.exe")
            End If
            SOFTCLOSE()
        End If
        Return ""

        'Return Get_HddSerial
    End Function
    Public Function TESTEDITION_INSTALLING(ByVal COMPANY_NAME As String, ByVal INSDATE As Date, ByVal NewInsDate As DateTime, ByVal Mil As Integer, Optional ByVal FIXIT_NUM As Integer = 3) As Boolean
        SCategory = 0
        FIXIT = SCategory & vbCrLf & SoftCode & vbCrLf & INSDATE & vbCrLf & TestDays & vbCrLf & Now & vbCrLf & 0 & vbCrLf & "Begin" & vbCrLf & NewInsDate & vbCrLf & Mil
        FIXTIT = xo(FIXIT, FIXIT_NUM)
        SavStr(FIXTIT, SYS32() & "\winhttp" & SoftCode & ".dll")
        Normal_Reg("TESTEDITION_INSTALLING", COMPANY_NAME, INSDATE, Now, NewInsDate, Mil)
        MsgBox("THIS PACKAGE SOFTWARE TRAIL VERSION IS SUCCESSFULLY INTALLED IN YOUR COMPUTER FOR " & TestDays & ".", MsgBoxStyle.Information, "TEST EDITION IS SUCCESSFULLY REGISTRY")
        TESTEDITION_INSTALLING = True
    End Function
    Public Function Sr_Ins_OtherCategory(ByVal Category As Integer, ByVal Package As String, ByVal RegCode_ As String, ByVal InsCode_ As String, ByVal Company As String, ByVal GETDOUBLE_ As Boolean, Optional ByVal CompanyNameMinLen As Integer = 7) As Boolean
        Dim Str(7) As String
        Sr_Ins_OtherCategory = False
        If Company.Length < CompanyNameMinLen Then
            MsgBox("Please type company name minimam " & CompanyNameMinLen & " digits.Please try again.", MsgBoxStyle.Critical)
            Exit Function
        End If
        Str(0) = ICode
        Str(1) = IName
        Str(2) = SoftCode
        Str(3) = SCategory
        Str(4) = SFunc_
        Str(5) = SoftName
        Str(6) = RegCode
        Str(7) = InsCode
        WGeT = SrGens.ArrayToStr(Str, ",")
        SavStr(xo(WGeT, FIXIT_NUM * 1), IECor)
        MsgBox("Registry [ " & IName & " ] of [ " & SoftName & " ] successfully to your pc by category [ " & Package & " ].", MsgBoxStyle.Information)
        Return True
    End Function
    Public Function Ins_OtherCategory(ByVal Category As Integer, ByVal Package As String, ByVal RegCode_ As String, ByVal InsCode_ As String, ByVal Company As String, ByVal GETDOUBLE_ As Boolean, Optional ByVal CompanyNameMinLen As Integer = 7) As Boolean
        Dim Str(17) As String
        Ins_OtherCategory = False
        If Company.Length < CompanyNameMinLen Then
            MsgBox("Please type company name minimam " & CompanyNameMinLen & "digits.Please try again.", MsgBoxStyle.Critical)
            Exit Function
        End If
        RCompany = Company
        SCategory = Category
        RegCode = RegCode_
        InsCode = InsCode_
        GetDouble = GETDOUBLE_
        SPackage = Package
        Str(0) = SoftCode
        Str(1) = SoftName
        Str(2) = SoftVersion
        Str(3) = Soft_MaxPackage
        Str(4) = ExpSr
        Str(5) = RegCode
        Str(6) = InsCode
        Str(7) = HdSerial
        Str(8) = FIXIT_NUM
        Str(9) = Plus
        Str(10) = Hdd_plus
        Str(11) = INTO1
        Str(12) = INTO2
        Str(13) = GetDouble
        Str(14) = UcaseX
        Str(15) = SCategory
        Str(16) = RCompany
        Str(17) = SPackage
        WGeT = SrGens.ArrayToStr(Str, ",")
        SavStr(xo(WGeT, FIXIT_NUM), ECor)
        bxa = vbCrLf & "We gratitude for purchase our soft moreover thanks for beign with us."
        MsgBox(("Registration of [ " & SoftName & " ] productively grant to your pc by category" & " [ " & SPackage & " ]." & bxa), MsgBoxStyle.Information)
        Return True
    End Function
    Public Function CHECK_OTHER_CATEGORY_INS() As Boolean
        If Soft_load_byID(SoftCode) = False Then
            CHECK_OTHER_CATEGORY_INS = False
            Return False
        Else
            h = HDD_Sr
            HDD_Sr = Get_HddSerial(False)
            If h <> HDD_Sr Then
                MsgBox("SOMEONE TRY TO HACK(CHANGE UR COMPUTER TO ANOTHER) THIS SOFT CORRUPT.PLEASE FORMAT YOUR MAIN DRIVE & INSTALL THIS SOFT AGAIN.", MsgBoxStyle.Critical)
                a = b
                SrGens.Make_Corrupt()
                Return False
                End
            End If
            gencode = SrGens.GetGenCode_2(GetDouble, RCompany, SPackage, RegCode, SCategory, UcaseX)
            If ArF(GENCODESA, InsCode) = False Then
                MsgBox("SOMEONE TRY TO HACK(WITH SERIAL NUMBER) THIS SOFT CORRUPT.PLEASE FORMAT YOUR MAIN DRIVE & INSTALL THIS SOFT AGAIN.", MsgBoxStyle.Critical)
                SrGens.Make_Corrupt()
                Return False
                End
            End If
            Return True
        End If
    End Function
    Public Function CHECK_OTHER_CATEGORY_INS_Sr() As Boolean
        CHECK_OTHER_CATEGORY_INS_Sr = False
        If Soft_load_byID_Sr(ICode) = False Then
            'CHECK_OTHER_CATEGORY_INS_Sr = False
            Return False
        Else
            h = HDD_Sr
            HDD_Sr = Get_HddSerial(False)
            If h <> HDD_Sr Then
                MsgBox("SOMEONE TRY TO HACK(CHANGE UR COMPUTER TO ANOTHER) THIS SOFT CORRUPT.PLEASE FORMAT YOUR MAIN DRIVE & INSTALL THIS SOFT AGAIN.", MsgBoxStyle.Critical)
                SrGens.SrMake_Corrupt()
                Return False
                End
            End If
            gencode = SrGens.GetGenCode_2(GetDouble, RCompany, spackge, RegCode, SCategory, UcaseX)
            If gencode <> InsCode Then
                MsgBox("SOMEONE TRY TO HACK (WITH SERIAL NUMBER) IN [AUK SERIALS] SOFT CORRUPT.PLEASE FORMAT YOUR MAIN DRIVE & INSTALL THIS SOFT AGAIN.", MsgBoxStyle.Critical)
                SrGens.SrMake_Corrupt()
                Return False
                End
            End If
            Return True
        End If
    End Function
    Public Function Check_TestEdition() As Boolean
        Dim Str1 As String
        Dim Ld, InsD As Date
        Dim Ua As Array
        Dim F, C As Integer
        Str1 = xo(GetStr(ECor), -FIXIT_NUM)
        Ua = Str1.Split(vbCrLf)
        'MsgBox(Ua.GetUpperBound(0))
        If Ua.GetUpperBound(0) > 0 Then
            If Ua.GetValue(0).ToString <> "0" Then
                Check_TestEdition = False
                Exit Function
            End If
            'MsgBox(Ua.GetUpperBound(0))
            If Ua.GetUpperBound(0) = 8 Then
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
        If Ua.GetUpperBound(0) = 8 Then
            If Ua.GetUpperBound(0) = 8 And Ua.GetValue(0).ToString = "0" Then
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
                    SrGens.Make_Corrupt(1)
                ElseIf Val(C) <= TestDays And Val(C) >= 0 Then
                    Ua.SetValue("Begins", 6)
                    Str1 = ArrayToStr(Ua, vbCrLf)
                    SavStr(xo(Str1, FIXIT_NUM), ECor)
                    SrGens.nowdaysTst = C
                    SCategory = 0
                    SoftInsDate = ArV(Ua, 7, Nothing, "12:00:00 AM")
                    If CStr(SoftInsDate) = "12:00:00 AM" Then
gotcur:                 SrGens.Make_Corrupt(0, "Your Computer has not been register or you try to change softinstall date.Contact with auk,Dates Null.")
                        SOFTCLOSE()
                        Exit Function
                    End If
                    MiliSec = ArV(Ua, 8, Nothing, -1)
                    If MiliSec = -1 Then
                        GoTo gotcur
                    End If

                    Return True
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
    Public Sub Normal_Reg(ByVal Category As String, ByVal company As String, ByVal insdate As String, ByVal LastAccess As String, Optional ByVal InsDatex As DateTime = Nothing, Optional ByVal MiliSec As Integer = -1)
        'SoftInsDate = Now
        'WGeT = Now.Millisecond
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Company", company)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Install Date", insdate)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Last Access Date", LastAccess)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Cagegory", Category)
        If InsDatex <> Nothing Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Soft_Install Date New Function", InsDatex)
        End If
        If MiliSec > -1 Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Soft_Install Date Code", MiliSec)
        End If
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Soft_Install", "AukSignPerfect....OK")
    End Sub
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
    Public Function For_Soft_Combo_HddSr_AukSerialsSoft(ByVal Package As String, ByVal Company As String, Optional ByVal CompanyNameMinLen As Integer = 9) As String
        'Dim Ex1 As String
        'auksoftware's
        Dim H As Security.Cryptography.HashAlgorithm
        Dim ExpSr_ As String = IExpSr
        Dim HashBytes() As Byte
        Dim Uni As New UnicodeEncoding
        Dim a As Integer = CompanyNameMinLen
        If HdSerial <> "" Then
            If (Len(Company) >= a) Or a = 0 Then
                H = New Security.Cryptography.MD5CryptoServiceProvider
                HashBytes = H.ComputeHash(Uni.GetBytes(HdSerial))
                dm1 = Convert.ToBase64String(HashBytes).ToString
                ExpSr_ = Replace(ExpSr_, "[sname]", SoftName, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[icode]", ICode, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[iver]", IVer, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[iname]", IName, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[scode]", SoftCode, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[package]", Package, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[sversion]", SoftVersion, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[company]", Company, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[gcode]", dm1, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[appname]", My.Application.Info.AssemblyName, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[hdsr]", HdSerial)
                dm2 = AukF.ConTOAsc(ExpSr_, "*", INTO2, True)
                dm4 = AukF.ConTOAsc(ExpSr_, "+", Hdd_plus, True)
                HashBytes = H.ComputeHash(Uni.GetBytes(ExpSr_))
                dm3 = Convert.ToBase64String(HashBytes).ToString
                AukF.DivideIn_To_2(HdSerial, "-", False)
                HDD1 = Trim(QA2)
                HashBytes = H.ComputeHash(Uni.GetBytes(HDD1))
                dm5 = Convert.ToBase64String(HashBytes).ToString
                For_Soft_Combo_HddSr_AukSerialsSoft = dm2 & "-" & Left(dm1, Len(dm1) - 16) & "-" & dm4 & "-" & Left(dm3, 7) & "-" & Left(dm5, 7)
                For_Soft_Combo_HddSr_AukSerialsSoft = UCase(For_Soft_Combo_HddSr_AukSerialsSoft)
            Else
                For_Soft_Combo_HddSr_AukSerialsSoft = "PLEASE TYPE COMPANY NAME MINIMUM LENGHT " & a & "."
            End If
        Else
            MsgBox("YOUR COMPUTER DEVICE SERIAL IS NOT FOUND.", MsgBoxStyle.Critical) : SOFTCLOSE()
        End If
    End Function
    Public Function For_Soft_Combo_HddSr(ByVal Package As String, ByVal Company As String, Optional ByVal CompanyNameMinLen As Integer = 7) As String
        'Dim Ex1 As String
        Dim H As Security.Cryptography.HashAlgorithm
        Dim ExpSr_ As String = ExpSr
        Dim HashBytes() As Byte
        Dim Uni As New UnicodeEncoding
        Dim a As Integer = CompanyNameMinLen
        If HdSerial <> "" Then
            If (Len(Company) >= a) Or a = 0 Then
                H = New Security.Cryptography.MD5CryptoServiceProvider
                HashBytes = H.ComputeHash(Uni.GetBytes(HdSerial))
                dm1 = Convert.ToBase64String(HashBytes).ToString
                ExpSr_ = Replace(ExpSr_, "[sname]", SoftName, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[scode]", SoftCode, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[package]", Package, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[sversion]", SoftVersion, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[company]", Company, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[gcode]", dm1, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[appname]", My.Application.Info.AssemblyName, 1, -1, CompareMethod.Text)
                ExpSr_ = Replace(ExpSr_, "[hdsr]", HdSerial)
                dm2 = AukF.ConTOAsc(ExpSr_, "*", INTO2, True)
                dm4 = AukF.ConTOAsc(ExpSr_, "+", Hdd_plus, True)
                HashBytes = H.ComputeHash(Uni.GetBytes(ExpSr_))
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
        Else
            MsgBox("YOUR COMPUTER DEVICE SERIAL IS NOT FOUND.", MsgBoxStyle.Critical) : SOFTCLOSE()
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
    'Public Function Set_Installed(ByVal GenCode As String, ByVal InsDateN As String, ByVal PakegeName As String, ByVal CompanyName As String, ByVal serialCodeSum_Plus As Integer, Optional ByVal ExpSr As String = "[sname][date][scode][package][cname][mixed]")
    '    'q = My.Computer.FileSystem.SpecialDirectories.ProgramFiles.ToString
    '    'drv = Left$(q, 3)
    '    'sys = drv & "Windows\system32"
    '    s1 = SYS32()
    '    acq = SoftCode & "[#][*]," & SoftName & "[#][*]," & InsDateN & "[#][*]," & PakegeName & "[#][*]," & CompanyName & "[#][*]," & serialCodeSum_Plus & "[#][*]," & ExpSr & "[#][*]," & GenCode

    'End Function
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

End Module
