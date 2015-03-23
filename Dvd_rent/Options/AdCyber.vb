Public Class AdCyber

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.TextBox10.Text = 0

    End Sub

    Private Sub AdCyber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.DVDOPT_USEPASSWORD = True Then
            Me.Enabled = False
            CHK_PASS.fOBJ = Me
            FrmL(CHK_PASS)

            CHK_PASS.TextBox1.Focus()
            'CHK_PASS.Activate()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Save()
        With Cyber
            .ScanP = Val(My.Settings.Scaning.ToString)
            .PrintC = Val(My.Settings.PagePrintCyber.ToString.Split(",").GetValue(1))
            .PrintB = Val(My.Settings.PagePrintCyber.ToString.Split(",").GetValue(0))
            .WriteDVD = Val(My.Settings.Write_Cyber.ToString.Split(",").GetValue(1))
            .WriteCD = Val(My.Settings.Write_Cyber.ToString.Split(",").GetValue(0))
        End With
    
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim TX1 As New DataTable("CYBER_MEMBER")
        SFC("MEMBERCATEGORY", "CYBER_MEMBERID")
        STC("CYBER", My.Settings.CYBERMEMBER_ID_CATE & "[0-9]%")
        ExpreC("", "like")
        ADSRC.Load_Only_LastRecord_Str(TX1, 0, "CYBER_MEMBERID", True)
        'WGeT = Str(WGeT)
        C = Val(Replace(WGeT, Str(My.Settings.CYBERMEMBER_ID_CATE), ""))
        My.Settings.CyberCafeMemberLastIDNumber = C
        SFC("MEMBERCATEGORY", "CYBER_MEMBERID")
        STC("'CYBER'", My.Settings.BROAD_BAND_ID_CATE & "[0-9]%")
        ExpreC("", "like")
        SnX("<>")
        ADSRC.Load_Only_LastRecord_Str(TX1, 0, "CYBER_MEMBERID", True)
        'MsgBox(Sql, , WGeT)

        C = Val(WGeT.Replace(My.Settings.BROAD_BAND_ID_CATE, ""))
        My.Settings.Cyber_BroadBandLastMemberID = C
    End Sub
End Class