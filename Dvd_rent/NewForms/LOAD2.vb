Public Class LOAD2

    Private Sub LOAD2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'AukF.FullScreenSet(Me, True)
        Me.Text = My.Settings.SoftNamex.ToString & "-" & SoftName
        Me.NotifyIcon1.BalloonTipText = "CyberPack Pro " & SoftVersion & " - " & My.Settings.SoftNamex.ToString
        Me.NotifyIcon1.BalloonTipTitle = Me.NotifyIcon1.BalloonTipText
        Me.NotifyIcon1.Text = Me.NotifyIcon1.BalloonTipText
        Me.Opacity = My.Settings.CyberMainFormTrans / 100

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SOFTCLOSE(Me.NotifyIcon1)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Panel2.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Panel2.Visible = False
    End Sub
    Private Sub HIDECURRENTTHISToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HIDECURRENTTHISToolStripMenuItem.Click, HIDECYBERPACKPROToolStripMenuItem.Click
        Me.Hide()
    End Sub
    Private Sub ABOUTDEVELOPERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABOUTDEVELOPERToolStripMenuItem.Click, DEVELOPERToolStripMenuItem.Click
        DVDRENT.FrmL(Auk_Information)
    End Sub
    Private Sub EXITFROMCYBERPACKPROToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITFROMCYBERPACKPROToolStripMenuItem.Click, EXITFROMSOFTToolStripMenuItem.Click
        Button4_Click(sender, e)
        FrmL(Me)
    End Sub

    Private Sub AUKLOAD_FORM(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SETTINGSOFTWAREToolStripMenuItem.Click, SETTINGFORPRODUCTSOLDToolStripMenuItem.Click, SETTINGFORDVDRENTANDENTRYToolStripMenuItem.Click, SETTINGFORCYBERCAFEMANAGEMENTToolStripMenuItem.Click, TODAYSBENEFITVIEWToolStripMenuItem.Click, SUMMARYBENEFITVIEWToolStripMenuItem.Click, STOCKMOVIESVIEWToolStripMenuItem.Click, SOLDToolStripMenuItem.Click, RENTCDDVDToolStripMenuItem.Click, RECHARGEToolStripMenuItem.Click, NEWMOVIETYPEToolStripMenuItem.Click, CyberMonthlyChargesSubmitToolStripMenuItem.Click, CAFEMONITORINGToolStripMenuItem.Click, ADDNEWMOBILECOMPANYToolStripMenuItem.Click, ADDNEWMEMBERSToolStripMenuItem.Click, ADDNEWCLIENTSToolStripMenuItem.Click, ADDNEWCLIENTSMONTHLYCHARGESToolStripMenuItem.Click, ADDNEWCDDVDToolStripMenuItem.Click, ADDNEWBROADBANDPACKAGESToolStripMenuItem.Click, ADDDVDSTOCKSELFToolStripMenuItem.Click, ADDANEWMEMBERToolStripMenuItem.Click, WARRANTYDATABASEToolStripMenuItem.Click, TODAYSBENEFITREPORTToolStripMenuItem.Click, SUMMARYBENFITVIEWToolStripMenuItem.Click, CLIENTDATABASEToolStripMenuItem.Click, PRODUCTSOLDToolStripMenuItem.Click, ADDNEWPRODUCTSToolStripMenuItem.Click, ADDNEWCATEGORIESToolStripMenuItem.Click, SETTINGSToolStripMenuItem3.Click, SETTINGSToolStripMenuItem2.Click, SETTINGSToolStripMenuItem1.Click, SETTINGSOFADDINGDVDToolStripMenuItem.Click, SETTINGSFORMOBILERECHARGEToolStripMenuItem.Click, ADDNEWVENDORToolStripMenuItem.Click, DATABASEBACKUPToolStripMenuItem.Click
        DVDRENT.LOAD_FORMS(sender.TAG, CStr(sender.AccessibleDescription))
        'MsgBox(sender.AccessibleDescription.ToString)
    End Sub

    Private Sub SHOW_CYBERPACKPRO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        FrmL(Me)

    End Sub

    Private Sub SETTINGSOFRENTMOVIESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SETTINGSOFRENTMOVIESToolStripMenuItem.Click
        FrmL(RENTAL_SET)
    End Sub
    Private Sub SHOWCYBERPACKPROToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWCYBERPACKPROToolStripMenuItem.Click
        FrmL(Me)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        FrmL(Me)
    End Sub

    Private Sub condtions(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONDITIONSToolStripMenuItem.Click
        CSOFT.RUN_CONDITIONS(Me)
    End Sub
End Class