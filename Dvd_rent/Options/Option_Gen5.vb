Public Class Option_Gen

    Private Sub OptionsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsBindingNavigatorSaveItem.Click, SAVECURRENTSCREENCHANGEToolStripMenuItem.Click
        Try
            My.Settings.SoftNamex = Me.Company_NameTextBox.Text
            If TrayIco = True Then
                TRaLoad.NotifyIcon1.BalloonTipText = "CyberPack Pro " & SoftVersion & " - " & My.Settings.SoftNamex.ToString
                TRaLoad.NotifyIcon1.BalloonTipTitle = TRaLoad.NotifyIcon1.BalloonTipText
                TRaLoad.NotifyIcon1.Text = TRaLoad.NotifyIcon1.BalloonTipText
            Else
                If AniFrm = True Then
                    Form1.AxShockwaveFlash1.SetVariable("softname", Me.Company_NameTextBox.Text)
                Else
                    LOAD2.Text = My.Settings.SoftNamex.ToString & "-" & SoftName
                End If
            End If
            Me.Validate()
            Me.OptionsBindingSource.EndEdit()
            Me.OptionsTableAdapter.Update(Me.AukDatabaseDataSet.Options)
            My.Settings.Save()
        Catch ex As Exception
            Epx()
        End Try


    End Sub

    Private Sub Option_Gen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If SCATEGORY = 0 Then Me.Button6.Visible = False
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Options' table. You can move, or remove it, as needed.
        Me.OptionsTableAdapter.Fill(Me.AukDatabaseDataSet.Options)
        If TVer = True Then
            Me.Button6.Visible = False
            Me.ResetFirstOccur.Visible = False
            Me.ResetDefaultSettingsToolStripMenuItem.Visible = False
        End If
        If My.Settings.DVDOPT_USEPASSWORD = True Then
            Me.Enabled = False
            CHK_PASS.fOBJ = Me
            FrmL(CHK_PASS)
            CHK_PASS.TextBox1.Focus()
            'CHK_PASS.Activate()
        End If
        My.Application.SaveMySettingsOnExit = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = -1

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox4.Text = -1

    End Sub
    Private Sub TextBox7_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.Validated
        If Val(sender.text) > 50 Then
            MsgBox("Please Set Number between 1-50", MsgBoxStyle.Information)
            sender.text = 50

            sender.Focus()
        End If
    End Sub
    Private Sub TextBox8_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.Validated
        If Val(sender.text) > 50 Then
            MsgBox("Please Set Number between 1-50", MsgBoxStyle.Information)
            sender.text = 50

            sender.Focus()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.TextBox10.Text = 0

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next

        a = Val(Me.TextBox11.Text)
        b = Val(Me.TextBox12.Text) - Val(Me.TextBox11.Text)
        c = 100 * (b / a)
        Me.TextBox13.Text = c

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        FrmL(AdCyber)
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click, PASSWORDToolStripMenuItem.Click
        FrmL(SettingsAccess)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FrmL(BackUp)
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click, DATALOADANDSOFTSTARTSTYLEToolStripMenuItem.Click
        FrmL(DL_Opt)
    End Sub
    Private Sub Option_Gen_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If BackUp.Visible = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ADDNEWEMPLOYEEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDNEWEMPLOYEEToolStripMenuItem.Click
        FrmL(ps_employees)

    End Sub

    Private Sub MOVIERENTALSETTINGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOVIERENTALSETTINGSToolStripMenuItem.Click
        FrmL(RENTAL_SET)

    End Sub

    Private Sub AukFormLoads(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTSOLDSETTINGSToolStripMenuItem.Click, MOVIESSOLDSETTINGSToolStripMenuItem.Click, MOBILERECHARGESETTINGSToolStripMenuItem.Click, DVDENTRYORADDNEWDVDSETTINGSToolStripMenuItem.Click, CYBERCAFEANDBUSINESSSETTINGSToolStripMenuItem.Click
        DVDRENT.LOAD_FORMS(sender.tag, "")

    End Sub

    Private Sub CloseCyberPackProSettingsViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseCyberPackProSettingsViewToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Reset(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetFirstOccur.Click, ResetDefaultSettingsToolStripMenuItem.Click
        My.Settings.Reset()

    End Sub

    Private Sub Reload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click, ReloadSettingsToolStripMenuItem.Click
        My.Settings.Reload()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        FrmL(mRentDays)

    End Sub

    Private Sub ADDNEWUSERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDNEWUSERToolStripMenuItem.Click
        FrmL(UserCreator)

    End Sub
End Class