Public Class TRaLoad
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
        If AukF.MsgTr("Do you want to exit from CyberPack Pro?") = True Then SOFTCLOSE(Me.NotifyIcon1)
    End Sub
    Private Sub ABOUTDEVELOPERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABOUTDEVELOPERToolStripMenuItem.Click
        DVDRENT.FrmL(Auk_Information)
    End Sub
    Private Sub TRaLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Me.NotifyIcon1.BalloonTipText = "CyberPack Pro " & SoftVersion & " - " & My.Settings.SoftNamex.ToString
        Me.NotifyIcon1.BalloonTipTitle = Me.NotifyIcon1.BalloonTipText
        Me.NotifyIcon1.Text = Me.NotifyIcon1.BalloonTipText
    End Sub

    Private Sub NotifyIcon1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseMove
        TRaLoad_Load(sender, e)
    End Sub


    Private Sub Conditions(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONDITIONSToolStripMenuItem.Click
        CSOFT.RUN_CONDITIONS(Me)
    End Sub
End Class