
Public Class Form1
    'Dim Flv As FlashNet
    Dim DoCl As Boolean = False
    Dim Closeing As Boolean = False

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Closeing = False Then
            If AukF.MsgTr("Do you want to exit from CyberPack Pro?") = True Then SOFTCLOSE(Me.NotifyIcon1) Else e.Cancel = True
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tny As New DataTable
        AukF.FullScreenSet(Me, True)
        Me.NotifyIcon1.Visible = True
        Me.AxShockwaveFlash1.SetVariable("softname", "")
        AukF.Db_Load("*", "options", Tny)
        My.Settings.SoftNamex = Tny.Rows(0).Item(1).ToString
        'MsgBox("SHOW")
        Me.AxShockwaveFlash1.SetVariable("rcategory", SPackage)
        Me.AxShockwaveFlash1.SetVariable("rcom", RCompany)
        Me.AxShockwaveFlash1.SetVariable("ricode", InsCode)
        Me.AxShockwaveFlash1.SetVariable("rrcode", RegCode)
        'Dim Ckint As Integer
        'Ckint = (Convert.ToInt32(My.Computer.Info.AvailablePhysicalMemory) / 1024 / 1024)
        'If Ckint >= 128 Then
        '    Me.Opacity = 0.94
        'End If
        Me.NotifyIcon1.BalloonTipText = "CyberPack Pro " & SoftVersion & " - " & My.Settings.SoftNamex.ToString
        Me.NotifyIcon1.BalloonTipTitle = Me.NotifyIcon1.BalloonTipText
        Me.NotifyIcon1.Text = Me.NotifyIcon1.BalloonTipText
        'MsgBox(SPackage)
        Me.Opacity = My.Settings.CyberMainFormTrans / 100
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SOFTCLOSE()
    End Sub
    Private Sub AUKLOAD_FORM(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TODAYSBENEFITVIEWToolStripMenuItem.Click, SUMMARYBENEFITVIEWToolStripMenuItem.Click, STOCKMOVIESVIEWToolStripMenuItem.Click, SOLDToolStripMenuItem.Click, RENTCDDVDToolStripMenuItem.Click, RECHARGEToolStripMenuItem.Click, NEWMOVIETYPEToolStripMenuItem.Click, CyberMonthlyChargesSubmitToolStripMenuItem.Click, CAFEMONITORINGToolStripMenuItem.Click, ADDNEWMOBILECOMPANYToolStripMenuItem.Click, ADDNEWMEMBERSToolStripMenuItem.Click, ADDNEWCLIENTSToolStripMenuItem.Click, ADDNEWCLIENTSMONTHLYCHARGESToolStripMenuItem.Click, ADDNEWCDDVDToolStripMenuItem.Click, ADDNEWBROADBANDPACKAGESToolStripMenuItem.Click, ADDDVDSTOCKSELFToolStripMenuItem.Click, ADDANEWMEMBERToolStripMenuItem.Click, WARRANTYDATABASEToolStripMenuItem.Click, TODAYSBENEFITREPORTToolStripMenuItem.Click, SUMMARYBENFITVIEWToolStripMenuItem.Click, CLIENTDATABASEToolStripMenuItem.Click, PRODUCTSOLDToolStripMenuItem.Click, ADDNEWPRODUCTSToolStripMenuItem.Click, ADDNEWCATEGORIESToolStripMenuItem.Click, SETTINGSToolStripMenuItem3.Click, SETTINGSToolStripMenuItem2.Click, SETTINGSToolStripMenuItem1.Click, SETTINGSOFADDINGDVDToolStripMenuItem.Click, SETTINGSToolStripMenuItem.Click, ToolStripMenuItem1.Click, DATABASEBACKUPToolStripMenuItem.Click
        DVDRENT.LOAD_FORMS(sender.TAG, CStr(sender.AccessibleDescription))
        'MsgBox(sender.AccessibleDescription.ToString)
    End Sub
    Private Sub SETTINGSOFRENTMOVIESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SETTINGSOFRENTMOVIESToolStripMenuItem.Click
        FrmL(RENTAL_SET)
    End Sub
    Private Sub EXITFROMSOFTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITFROMSOFTToolStripMenuItem.Click
        'SOFTCLOSE(Me.NotifyIcon1)
        FrmL(Me)
        Me.AxShockwaveFlash1.SetVariable("cmds", "e")
    End Sub
    Private Sub ABOUTDEVELOPERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABOUTDEVELOPERToolStripMenuItem.Click
        DVDRENT.FrmL(Auk_Information)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub
 
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmL(AukSoft)

    End Sub
    Private Sub ShowMainFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmL(Me)
    End Sub
    Private Sub DVDRENTToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Product_Input3.Hide()
    End Sub
    Private Sub COSTOMERENTRYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Costomers.Hide()
    End Sub

    Private Sub CYBERBUSINESSToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cyber.Hide()
    End Sub

    Private Sub ExitFormSoftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If AukF.MsgTr(What & "Exit from CYBERPACK PRO?") = True Then SOFTCLOSE(Me.NotifyIcon1)
    End Sub

    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Enter
        On Error GoTo b
        If SCategory = 0 Then
            Me.AxShockwaveFlash1.TSetProperty("BarViewMD", 6, 100)
            Me.AxShockwaveFlash1.SetVariable("Total1", TestDays)
            Me.AxShockwaveFlash1.SetVariable("NowTime1", nowdaysTst)
            Me.AxShockwaveFlash1.SetVariable("show", CStr("Days Left " & nowdaysTst))
        Else
            Me.AxShockwaveFlash1.TSetProperty("BarViewMD", 6, 0)
        End If
        Exit Sub
b:      MsgBox("Flash " & FlashVersion & " ActiveX is not installed correctly.You may have to install this in order to run CyberPack Pro animated view properly.", MsgBoxStyle.Information)
        AukF.OExe(AppPath & "\CheckSoft.exe", Me)
        AukF.OExe(AppPath & FlashFIleName, Me) 'run flash installer
        MsgBox("After Installing Flash " & FlashVersion & "  ActiveX please restart the soft", MsgBoxStyle.Information)

    End Sub

    Private Sub AxShockwaveFlash1_FSCommand(ByVal sender As Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles AxShockwaveFlash1.FSCommand
        Dim Str1 As String
        Dim Ua2 As Array
        'If Me.AxShockwaveFlash1.MouseButtons = Forms.MouseButtons.Right Then
        '    AukF.ContextShow(Me.WCONTEXT)
        '    MsgBox("A")
        'End If
        Select Case e.command
            Case "auk"
                DoColse()
                FrmL(Auk_Information)
            Case "license"
                DoColse()
                MsgBox(UCase("License for " & My.Settings.SoftNamex.ToString & " Company ... Develop by Alim ul karim(Auk) ...want to buy call on 01913500863,01711334201"), MsgBoxStyle.Information)
            Case "loadForm"
                'MsgBox(SPackage)
                DoColse()
                Str1 = e.args
                Ua2 = Str1.Split(",")
                Try
                    DVDRENT.LOAD_FORMS(ArV(Ua2, 0), ArV(Ua2, 1))
                Catch ex As Exception
                    Epx()
                End Try
            Case "load"
                DoColse()
                Me.AxShockwaveFlash1.SetVariable("softname", My.Settings.SoftNamex)
            Case "tooltip"
                DoColse()
                Me.AxShockwaveFlash1.SetVariable("toolshow", e.args)
                'MsgBox(e.args)
                'Case "newtype"
                '    DVDRENT.LOAD_FORMS(9)
                'Case "self"
                '    DVDRENT.LOAD_FORMS(10)
                'Case "mobilecompany"
                '    DVDRENT.LOAD_FORMS(13)
                'Case "cybermember"
                '    DVDRENT.LOAD_FORMS(1)
                'Case "bclients"
                '    DVDRENT.LOAD_FORMS(3)
                'Case "cyberbusiness"
                '    DVDRENT.LOAD_FORMS(0)
                'Case "recharge"
                '    DVDRENT.LOAD_FORMS(11)
                'Case "mobileclients"
                '    DVDRENT.LOAD_FORMS(12)
                'Case "pakages"
                '    DVDRENT.LOAD_FORMS(4)
                'Case "cyberfees"
                '    DVDRENT.LOAD_FORMS(5)
            Case "settings"
                DoColse()
                DVDRENT.LOAD_FORMS(14, "")
                '    'MsgBox(s1, , s2)
                '    'DoColse()
                'Case "dvdmember"
                '    DVDRENT.LOAD_FORMS(8)
                'Case "newdvd"
                '    DVDRENT.LOAD_FORMS(7)
                'Case "dvdrent"
                '    DVDRENT.LOAD_FORMS(6)
            Case "hide"
                DoColse()
                Me.Hide()
                'DoColse()
            Case "exit"
                DoColse()
                DVDRENT.SOFTCLOSE(Me.NotifyIcon1)
            Case "loaded"
                Closeing = True
                DoColse()
                Me.AxShockwaveFlash1.SetVariable("softname", My.Settings.SoftNamex.ToString)
        End Select
        'MsgBox(e.command)

    End Sub
    Public Sub DoColse()
        If DoCl = False Then
            Try
                My.Forms.SplashSc.Dispose()
                My.Forms.SplashSc.Close()
            Catch ex As Exception
            End Try
            DoCl = True
        End If
    End Sub
    Private Sub CyberMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberMem.Hide()
    End Sub
    Private Sub MobileRechargeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NewTrans.Hide()
    End Sub
    Private Sub HideToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NewTrans.Hide()
    End Sub

    Private Sub SHOWCYBERPACKPROToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWCYBERPACKPROToolStripMenuItem.Click
        FrmL(Me)

    End Sub

    Private Sub HIDECYBERPACKPROToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HIDECYBERPACKPROToolStripMenuItem.Click
        Me.Hide()
    End Sub

    'Private Sub AxShockwaveFlash1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles AxShockwaveFlash1.MouseCaptureChanged
    '    If e.Button = Forms.MouseButtons.Right Then
    '        AukF.ContextShow(Me.WCONTEXT)
    '    End If

    'End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'a = Mid(Me.AxShockwaveFlash1.ProductVersion, 1, 1)
        'If Val(a) < 8 Then
        '    RegOcx.UnRegOcx(AppPath & "\Flash.ocx")
        '    RegOcx.RegOcx(AppPath & "\Flash.ocx")
        '    'Shell(AppPath & "\Install Flash Player 8 ActiveX.msi",)
        '    'Shell(AppPath & "\SAFlashPlayer.exe", AppWinStyle.Hide, True)
        'End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub

  
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        FrmL(Me)
    End Sub

    Private Sub Conditions(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONDITIONSToolStripMenuItem.Click
        CSOFT.RUN_CONDITIONS(Me)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        FrmL(Me)
    End Sub
End Class
