'Inherits Dvd_Rent.EntriesStr
Public Class Register
    Public TrailInstall As Boolean = False
    Dim a As String = "TEST EDTION(PACKAGE)"
    Dim CLS As Integer = 0
    Dim AukDSet As New AukDatabaseDataSet
    Dim SoftinfoTableAdapter1 As New AukDatabaseDataSetTableAdapters.SOFTINFOTableAdapter
    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
   
    Private Function SoftBack_Time() As Boolean
        Try
            nam = My.Settings.BACKUP_FOLDER.ToString & "\CPackPro " & SoftVersion & " " & SoftIn.AukDateGet(NDate, "-") & " " & CStr(TimeOfDay).Replace(":", ".") & ".mdb"
            My.Computer.FileSystem.CopyFile(SoftDir, nam, True)
            Return True
        Catch ex As Exception
            Epx(nam)
            Return False
        End Try
    End Function
    Private Function AutoBackUp() As Boolean
        If TVer = True Then Return False : Exit Function
        Dim DbSize As Integer = CInt(My.Computer.FileSystem.GetFileInfo(SoftDir).Length / 1024 / 1024)
        Dim Ld, Bd As Date
        If DbSize <= My.Settings.MINIMAM_DBSIZE Then
            If My.Settings.REPLACE_DB = False Then
                SoftBack_Time()
            Else
                Try
                    nam = My.Settings.BACKUP_FOLDER.ToString & "\CyberPack Pro " & SoftVersion & ".mdb"
                    My.Computer.FileSystem.CopyFile(SoftDir, nam, True)
                    Return True
                Catch ex As Exception
                    Epx(nam)
                    Return False
                End Try
            End If
        Else
            If Val(My.Settings.DAYS_BACKYP) > 0 Then
                Ld = CDate(My.Computer.FileSystem.GetFileInfo(SoftDir).LastAccessTime)
                Bd = CDate(My.Settings.BackUp_LAstDate)
                g = DateDiff(DateInterval.Day, Bd, Ld)
                If g < 0 Then g = g * -1
                If g >= My.Settings.DAYS_BACKYP Then
                    My.Settings.BackUp_LAstDate = CDate(Now)
                    My.Settings.Save()
                    If My.Settings.REPLACE_DB = False Then
                        SoftBack_Time()
                    Else
                        Try
                            nam = My.Settings.BACKUP_FOLDER.ToString & "\CyberPack Pro " & SoftVersion & ".mdb"
                            My.Computer.FileSystem.CopyFile(SoftDir, nam, True)
                        Catch ex As Exception
                            Epx(nam)
                            Return False
                        End Try
                    End If
                End If
            End If
        End If
    End Function
    Public Sub ShIn()
        RunningFunctionWorking = "Doing"
        Dim Ckint As Integer
        Ckint = (Convert.ToInt32(My.Computer.Info.AvailablePhysicalMemory) / 1024 / 1024)
        'MsgBox(My.Settings.LoadingStyle)
        'If FirstRun = True Then GoTo c1
        If TVer = False Then AutoBackUp()
        If TVer = True Then
            AukF.Db_LoadN(Me.AukDSet.SOFTINFO)
            If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDSet.SOFTINFO, "Create", 1) = True Then
                Dim D, D2 As DateTime
                Dim Inx As Decimal
                Try
                    D = CDate(WGeT)
                    '1=if now in middile then , if compare date is less then now then return negetive,grater positive
                    '2=if now in last then ,if compare date is less then now then return positive,grater than negetive ;
                    'in this reg check system i use 2nd system.

                    Inx = DateDiff(DateInterval.Minute, D, Now)
                    Inx = Format(Inx / 60 / 24, "0.##") '1day=24 hour.
                    'cause of using 2nd system i'll get the grater date duration positive
                    'like as install date time 1/15/2002 4:26 , running date 1/15/2002 4.30 ,it give the days distance in positive cause running date =now is grater than ins date.
                    If Inx < 0 Then SrGens.Make_Corrupt(0, "Your Database Registration is wrong ,don't try to make me fool.You try to replace database or change your computer date to get more advantage.")
                    'if test=exparied then it can't be possible that this shin is in process.
                    'if its happened thenn something goes wrong.
                    'there is no use of FirstRun
                    'so i'll not be aware of this.
                    ''If FirstRun = True Then
                    If Inx >= TestDays Then
                        SrGens.Make_Corrupt(0, "Database has some problems with registration ,don't try to make me fool.You try to replace database.")
                        SOFTCLOSE()
                        Exit Sub
                    End If
                    ''Else
                    ''MsgBox("Your Using Sytem of Trail of this soft has been expired.Please Register to use.", MsgBoxStyle.Information)
                    ''FrmL(Me)
                    ''End If

                    If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDSet.SOFTINFO, "Ndates", 1) = True Then
                        D = RowX.Item(1)
                        'MsgBox(D.GetDat))
                        D2 = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Soft_Install Date New Function", "")
                        If (CStr(D) = CStr(SoftInsDate)) And CStr(D2) = CStr(SoftInsDate) Then
                            If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDSet.SOFTINFO, "Milex", 1) = True Then
                                I = WGeT
                                a = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AukOrganization\AukSoft\" & SoftName, "Soft_Install Date Code", -1)
                                If (MiliSec <> I) Or CInt(a) <> I Then
                                    GoTo gotcur
                                End If
                            Else
                                GoTo gotcur
                            End If
                        Else
gotcur:                     SrGens.Make_Corrupt(0, "Database has some problems with registration ,don't try to make me fool.You try to replace database or try to change in registry.")
                            SOFTCLOSE()
                        End If
                    End If
                Catch ex As Exception
                    'MsgBox("Database has some problems with registration ,don't try to make me fool.", MsgBoxStyle.Critical)
                    SrGens.Make_Corrupt(0, "Extranal Error in registration ,don't try to make me fool.You try to replace database.")
                    SOFTCLOSE()
                    Exit Sub
                End Try
            Else
                MsgBox("Error to Load,Contact with Auk.Error 511", MsgBoxStyle.Critical)
                SrGens.Make_Corrupt(0, "Your Database is not Correctly Loaded.I think you have reinstall soft to get advantage.")
                SOFTCLOSE()
                Exit Sub
            End If
        End If
        'check login pass system
        If My.Settings.LOGINPASS = True Then
            If ADSRC.COUNT_CN("Users") > 0 Then
                FrmL(LoinSoft)
                Me.Close()
                Exit Sub
            End If
        End If

        If Val(My.Settings.LoadingStyle) = 0 Then
            If Ckint >= 128 Then
                GoTo c2
            ElseIf Ckint >= 58 Then
                GoTo c1
            Else
                GoTo c3
            End If
        ElseIf Val(My.Settings.LoadingStyle) = 1 Then
            GoTo c2
        ElseIf Val(My.Settings.LoadingStyle) = 2 Then
            GoTo c1
        ElseIf Val(My.Settings.LoadingStyle) = 3 Then
            GoTo c3
        Else
            MsgBox("Error In Selection", MsgBoxStyle.Critical) : End : Exit Sub
        End If
c1:     AniFrm = False
        FrmL(LOAD2)
        RunningFunctionWorking = "Done"
        Me.Dispose()
        Me.Close()

        Exit Sub
c2:
        AniFrm = True
        SplashSc.Show()
        SplashSc.Activate()
        RunningFunctionWorking = "Done"
        Me.Dispose()
        Me.Close()
        Exit Sub
c3:
        AniFrm = False
        TrayIco = True
        TRaLoad.Show()
        TRaLoad.NotifyIcon1.Visible = True
        RunningFunctionWorking = "Done"
        Me.Dispose()
        Me.Close()
        Exit Sub
    End Sub
    Public Sub Install_Soft()
        'Dim G1 As String
        Dim Gx As Integer = -1
        Dim Uq As Integer = 0
        Dim ErMsg1 As String = "You try to replace a trail version softs database incase of that your soft now corropted;if you want to get your database again please buy soft or contact with me[01913 500863]"

        If Me.ComboBox1.Items.Item(0).ToString = a Then
            Uq = 0
        Else
            Uq = 1
        End If
        'AVX = SrGens.Ins_OtherCategory(Me.ComboBox1.SelectedIndex, Me.ComboBox1.Text, G1.ToUpper, Me.Label1.Text, Me.TextBox2.Text, True)
        If Me.ComboBox1.Text = "DEVELOPER EDITION CYBERPACK PRO" Then
            If Me.TextBox3.PasswordChar = "*" And Me.TextBox2.Text = "AUKSOFTWARE'S" Then
                If Me.TextBox3.Text = "UNLOCK123" & Now.Hour Then
                    MsgBox("REG AUK DEVELOEPR EDITION", MsgBoxStyle.Information)
                    GoTo regauto
                Else
                    MsgBox("PLASE AUK TRY WITH SYS CLOCK SOUND.", MsgBoxStyle.Critical)
                End If
            Else
                If Me.TextBox3.Text = "AUK REG " & Now.TimeOfDay.Hours & "." & Now.Minute Then
                    Me.TextBox3.PasswordChar = "*"
                Else
                    'MsgBox("AUK REG" & Now.TimeOfDay.Hours & ":" & Now.Minute)
                    MsgBox("AUK SPECIAL REGISTRATION(error in Code).", MsgBoxStyle.Critical)
                End If
            End If

        Else
            If Me.ComboBox1.Items.Item(0).ToString = a Then
                If ComboBox1.SelectedIndex = 0 Then 'check trail is selected or not
                    'trail is selected
                    If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDSet.SOFTINFO, "Create", 1) = True Then
                        'MsgBox("You try to replace a trail version softs database incase of that your soft now corropted;if you wanted to get your database again please buy soft or contact with Alim(auk)[01913 500863]", MsgBoxStyle.Critical)
                        SrGens.Make_Corrupt(0, ErMsg1)
                        End
                        Exit Sub
                    Else 'if database error not found then goto help trail form .. then it enables to install trail version
                        'check that the form is visited help form or not
                        If Me.TrailInstall = False Then
                            'visit the help form
                            Me.Visible = False
                            FrmL(TrailInsInfo)
                            Exit Sub
                        End If

                    End If
                End If
                If ComboBox1.SelectedIndex = 0 Then
                    Me.Label1.Text = "YOU CAN USE THIS PACKAGE SOFTWARE FOR " & SrGens.TestDays.ToString & " DAYS (TEST ONLY)."
                Else
                    Me.Label1.Text = SrGens.For_Soft_Combo_HddSr(Me.ComboBox1.Text, Me.TextBox2.Text)
                End If
            Else
                Me.Label1.Text = SrGens.For_Soft_Combo_HddSr(Me.ComboBox1.Text, Me.TextBox2.Text)
            End If
            '--------- sr Check
            If Me.ComboBox1.Items.Item(0).ToString = a Then 'testing test edition is enable or not
                Uq = 0
                If Me.ComboBox1.SelectedIndex = 0 Then 'geting edition 
                    SoftInsDate = Now : MiliSec = Now.Millisecond
                    If SrGens.TESTEDITION_INSTALLING(Me.TextBox2.Text, Now.Date, SoftInsDate, MiliSec) = True Then
                        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDSet.SOFTINFO, "Create", 1) = True Then 'checking that before in this datatabase tested is installed
                            SrGens.Make_Corrupt(0, ErMsg1)
                            SOFTCLOSE()
                            Exit Sub
                        Else
                            'test is intslling and puting a value on database.
                            TVer = True
                            Try
                                Me.SoftinfoTableAdapter1.Insert("Create", Now)
                                Me.SoftinfoTableAdapter1.Insert("Ndates", SoftInsDate)
                                Me.SoftinfoTableAdapter1.Insert("MileX", MiliSec)
                            Catch ex As Exception
                                'MsgBox("You must try to replace previous database.", MsgBoxStyle.Critical)
                                SrGens.Make_Corrupt(0, ErMsg1)
                                SOFTCLOSE()
                            End Try
                        End If
                        ShIn()
                        'SOFTCLOSE()
                        Exit Sub
                    End If
                Else
                    If Me.TextBox2.Text.Length < 7 Then
                        MsgBox("PLEASE TYPE YOUR COMPANY NAME IN MINIMUM 7 DIGIT.", MsgBoxStyle.Critical) : Exit Sub
                    Else
                        SrGens.GetGenCode_2(True, Me.TextBox2.Text, Me.ComboBox1.Text, Me.Label1.Text, Me.ComboBox1.SelectedIndex + Uq, True)
                    End If
                End If
            Else
                Uq = 1
                If Me.TextBox2.Text.Length < 7 Then
                    MsgBox("PLEASE TYPE YOUR COMPANY NAME IN MINIMUM 7 DIGIT.", MsgBoxStyle.Critical) : Exit Sub
                Else
                    SrGens.GetGenCode_2(True, Me.TextBox2.Text, Me.ComboBox1.Text, Me.Label1.Text, Me.ComboBox1.SelectedIndex + Uq, True)
                End If
            End If
            Gx = GENCODESA.IndexOf(GENCODESA, Me.TextBox3.Text.ToUpper)
            'My.Computer.Clipboard.Clear()
            'My.Computer.Clipboard.SetText(GENCODESA(0))
            'MsgBox(Gx)
            If Gx > -1 Then
                GoTo SoftReg
            Else
                CLS += 1
                MsgBox("PLEASE CHECK YOUR COMPANY NAME & REGISTRATION CODE.[WRONG CODE,TRY 4 TIMES SOFTWARE WILL BE CLOSE]", MsgBoxStyle.Critical)
                If CLS = 3 Then
                    End
                End If
            End If
        End If

        Exit Sub

SoftReg:
        If Me.ComboBox1.Items.Item(0).ToString = a Then 'it means its 1st time of installing soft.. trail option is enabled
            If ComboBox1.SelectedIndex = 0 Then 'chekc that tver is true or not.
                TVer = True 'tver=true means test is true
            Else
                TVer = False
            End If
        Else
            TVer = False
        End If
        If Gx > -1 Then
            If TVer = False Then
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDSet.SOFTINFO, "Create", 1) = True Then
                    Try 'ins new edt so delete the database 
                        RowX.Delete()
                        Me.SoftinfoTableAdapter1.Update(Me.AukDSet.SOFTINFO)
                    Catch ex As Exception
                        MsgBox("Failed to Delete Test Effect contact with auk.", MsgBoxStyle.Critical)
                    End Try
                End If
            Else 'installing trail version
                If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDSet.SOFTINFO, "Create", 1) = True Then
                    'test time check that before in this database ,test ver ins or not
                    SrGens.Make_Corrupt(0, ErMsg1)
                    SOFTCLOSE()
                    Exit Sub
                Else 'or else if not found then try to insert into database the key of create
                    RowX = Me.AukDSet.SOFTINFO.NewRow
                    Me.SoftinfoTableAdapter1.Insert("Create", CDate(Now.Date))
                End If
            End If
            SrGens.Ins_OtherCategory(Me.ComboBox1.SelectedIndex + Uq, Me.ComboBox1.Text, Me.Label1.Text, GENCODESA(Gx), Me.TextBox2.Text, True, 7)
            ShIn()
            'trail version install correctly.
        End If
        Exit Sub
regauto:
        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDSet.SOFTINFO, "Create", 1) = True Then
            Try
                RowX.Delete()
                Me.SoftinfoTableAdapter1.Update(Me.AukDSet.SOFTINFO)
            Catch ex As Exception
                MsgBox("Failed to Delete Test Effect contact with auk.", MsgBoxStyle.Critical)
            End Try
        End If
        SrGens.GetGenCode_2(True, Me.TextBox2.Text, Me.ComboBox1.Text, Me.Label1.Text, Me.ComboBox1.SelectedIndex + Uq, True)
        SrGens.Ins_OtherCategory(Me.ComboBox1.SelectedIndex + Uq, Me.ComboBox1.Text, Me.Label1.Text, GENCODESA(0), Me.TextBox2.Text, True, 7)
        If SrGens.CHECK_OTHER_CATEGORY_INS() = True Then
            ShIn()
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Install_Soft()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Me.ComboBox1.Items.Item(0).ToString = a Then
            If ComboBox1.SelectedIndex = 0 Then
                Me.Label1.Text = "YOU CAN USE THIS PACKAGE SOFTWARE FOR " & SrGens.TestDays.ToString & " DAYS (TEST ONLY)."
            Else
                Me.Label1.Text = SrGens.For_Soft_Combo_HddSr(Me.ComboBox1.Text, Me.TextBox2.Text)
            End If
        Else
            Me.Label1.Text = SrGens.For_Soft_Combo_HddSr(Me.ComboBox1.Text, Me.TextBox2.Text)

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.Items.Item(0).ToString = a Then
            If ComboBox1.SelectedIndex = 0 Then
                Me.Label1.Text = "YOU CAN USE THIS PACKAGE SOFTWARE FOR " & SrGens.TestDays.ToString & " DAYS (TEST ONLY)."
            Else
                Me.Label1.Text = SrGens.For_Soft_Combo_HddSr(Me.ComboBox1.Text, Me.TextBox2.Text)
            End If
        Else
            Me.Label1.Text = SrGens.For_Soft_Combo_HddSr(Me.ComboBox1.Text, Me.TextBox2.Text)
        End If


    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        'Me.Label1.Text = SrGens.For_Soft_Combo_HddSr(Me.ComboBox1.Text, "2.0", Me.TextBox2.Text)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        FrmL(AboutBox1)

    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
    Private Sub Label8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label8.MouseDown
        AukF.DragAuk(Me)

    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then Button16_Click(sender, e)

    End Sub
    Private Sub Label1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        Clipboard.Clear()
        Clipboard.SetText(sender.text)

    End Sub

    Private Sub FreeUseByNet(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'have to type code in free by login
        My.Settings.NetReg = True
        My.Settings.Save()
        'netRegCheck()
        If My.Settings.NetReg = True And My.Settings.NetRegBlock = False Then
            NetConnection.Visible = False : NetConnection.Hide() : NetConnection.Show() : Me.Close() : Exit Sub
        ElseIf My.Settings.NetRegBlock = True And My.Settings.NetReg = True Then
            MsgBox("Free net key validation is over , please contact with developer.", MsgBoxStyle.Information)
            SOFTCLOSE()
        End If
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmL(Auk_Information)
    End Sub
End Class