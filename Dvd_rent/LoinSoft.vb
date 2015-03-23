Public Class LoinSoft
    Dim UAdp As New AukDatabaseDataSetTableAdapters.UserAccessTableAdapter

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        AukF.BindFind(Me.UsersBindingSource, "UserID", Me.UsernameTextBox.Text, True)

        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Users, Me.UsernameTextBox.Text) = True Then
wrk:        If Me.PasswordTextBox.Text = RowX("Password").ToString Then
                DelUserBeforeAccess(3)
                RowX("LAstLogin") = Now
                Me.UsersTableAdapter.Update(RowX)
                RowX = Me.AukDatabaseDataSet.UserAccess.NewRow
                RowX(0) = SoftIn.Master_ID_String_Get(4)
                RowX(1) = Me.UsernameTextBox.Text
                RowX(2) = Now
                Me.AukDatabaseDataSet.UserAccess.Rows.Add(RowX)
                Me.UAdp.Update(Me.AukDatabaseDataSet.UserAccess)
                Login()
            Else
                MsgBox("Password Is Not Correct", MsgBoxStyle.Critical)
            End If
        Else
            SFC("UserID")
            STC(Me.UsernameTextBox.Text)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.Users, -1, "", False)
            AukF.BindFind(Me.UsersBindingSource, "UserID", Me.UsernameTextBox.Text, True)

            If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Users, Me.UsernameTextBox.Text) = True Then
                GoTo wrk
            Else
                MsgBox("UserID Is Not Correct", MsgBoxStyle.Critical)

            End If

        End If
    End Sub
    Public Sub Login()
        Dim Ckint As Integer
        Ckint = (Convert.ToInt32(My.Computer.Info.AvailablePhysicalMemory) / 1024 / 1024)
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

        Me.Dispose()
        Me.Close()
        Exit Sub
c2:
        AniFrm = True
        SplashSc.Show()
        SplashSc.Activate()
        Me.Dispose()
        Me.Close()
        Exit Sub
c3:
        AniFrm = False
        TrayIco = True
        TRaLoad.NotifyIcon1.Visible = True
        Me.Dispose()
        Me.Close()
        Exit Sub
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        SOFTCLOSE()
    End Sub

    Private Sub UsernameTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab Then
            If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Users, Me.UsernameTextBox.Text) = False Then
                SFC("UserID")
                STC(sender.text)
                AukF.Db_LoadN(Me.AukDatabaseDataSet.Users, -1, "", False)
            End If
            AukF.BindFind(Me.UsersBindingSource, "UserID", sender.text, True)
            Me.PasswordTextBox.Focus()
        End If
    End Sub
    Public Sub DelUserBeforeAccess(ByVal DaysBefore As Integer)
        SFC("LoginTime")
        STC(Now.Date.AddDays(-DaysBefore))
        DTC("d")
        SnX("<=")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.UserAccess)
        For K As Integer = 0 To Me.AukDatabaseDataSet.UserAccess.Rows.Count - 1
            Me.AukDatabaseDataSet.UserAccess.Rows(K).Delete()
        Next
        UAdp.Update(Me.AukDatabaseDataSet.UserAccess)

    End Sub
    

    Private Sub UsernameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsernameTextBox.LostFocus
        'If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Tab Then
        If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Users, Me.UsernameTextBox.Text) = False Then
            SFC("UserID")
            STC(sender.text)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.Users, -1, "", False)
        End If
        AukF.BindFind(Me.UsersBindingSource, "UserID", sender.text, True)
        'Me.PasswordTextBox.Focus()

        'End If
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged
        AukF.BindFind(Me.UsersBindingSource, "UserID", sender.text, True)
    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Click(sender, e)
        End If
    End Sub
End Class
