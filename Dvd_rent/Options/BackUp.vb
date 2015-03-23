Public Class BackUp

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FN As New FolderBrowserDialog
        FN.ShowNewFolderButton = True
        If FN.ShowDialog = Forms.DialogResult.OK Then
            Me.TextBox1.Text = FN.SelectedPath
        End If
    End Sub

    Private Sub BackUp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()

    End Sub

    Private Sub BackUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.SETTING_BACK' table. You can move, or remove it, as needed.
        If TVer = True Then

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.PropertyGrid1.SelectedObject = My.Settings
        If Me.AukDatabaseDataSet.SETTING_BACK.Rows.Count = 0 Then Me.SETTING_BACKTableAdapter.Fill(Me.AukDatabaseDataSet.SETTING_BACK)
        Me.ProgressBar1.Maximum = Me.PropertyGrid1.SelectedGridItem.Parent.GridItems.Count
        ProgressBar1.Value = 0
        ProgressBar1.Visible = True
        Me.Cursor = Cursors.WaitCursor
        For K As Integer = 0 To Me.AukDatabaseDataSet.SETTING_BACK.Rows.Count - 1
            Me.AukDatabaseDataSet.SETTING_BACK.Rows(K).Delete()
        Next
        Me.SETTING_BACKTableAdapter.Update(Me.AukDatabaseDataSet.SETTING_BACK)

        For K As Integer = 0 To Me.PropertyGrid1.SelectedGridItem.Parent.GridItems.Count - 1
            ID = Me.PropertyGrid1.SelectedGridItem.Parent.GridItems(K).Label
            valx = Me.PropertyGrid1.SelectedGridItem.Parent.GridItems(K).Value
            'MsgBox(ID)
            If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.SETTING_BACK, id) = True Then
                RowX(1) = valx
            Else
                RowX = Me.AukDatabaseDataSet.SETTING_BACK.NewRow
                RowX(0) = id : RowX(1) = valx
                RowX.Table.Rows.Add(RowX)

            End If
            ProgressBar1.Value += 1
        Next
        Try
            Me.SETTING_BACKTableAdapter.Update(Me.AukDatabaseDataSet.SETTING_BACK)
        Catch ex As Exception
            Epx() : Exit Sub
        End Try
        Me.Cursor = Cursors.Default

        ProgressBar1.Visible = False
        'MsgBox()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click


        If AukF.MsgTrU("RESTORE DATABASE?", True, MsgBoxStyle.Information) = True Then
            Dim Info As New DataTable("softinfo")
            Dim F As New OpenFileDialog
            F.Filter = "Auk CyberPackProDatabase,MSAccess Database.mdb|*.mdb"
            F.AddExtension = True
            Try
                F.InitialDirectory = Me.TextBox1.Text
            Catch ex As Exception
            End Try
            If F.ShowDialog = Forms.DialogResult.OK Then
                'My.Computer.FileSystem.CopyFile(SoftDir, SoftDir & "BAS", True)
                Try
                    SFC("softcode", "softwarename")
                    STC("AUK_CYBERPACK PRO 2.0", "CYBERPACK PRO 2.0")
                    AukSql.AukSql_Main("*", "softinfo", 0)
                    DSource = SoftIn.OleDB_DataSource_Cnn(F.FileName.ToString, "lorenzom268")
                    SoftIn.Sql_Convert_For_Adp("softinfo", BSql)
                    AukF.OleDb_SqlGen(DSource, Sql, Info)
                    If Info.Rows(0).Item(0) = "AUK_CYBERPACK PRO 2.0" And Info.Rows(0).Item(1) = "CYBERPACK PRO 2.0" Then
                        My.Computer.FileSystem.CopyFile(F.FileName, SoftDir, True)
                    Else
                        MsgBox("This database is not for Auk" & SoftName & " because function not match.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    If AukF.MsgTrU("RESTORE SETTINGS?", True) = True Then
                        Button3_Click(sender, e) 'restore settings
                    End If
                    MsgBox("PLEASE REOPEN ,OPENED FORMS.", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("This database is not for " & SoftName & " because a error is occur when try to load.", MsgBoxStyle.Critical)
                    Exit Sub
                End Try
                My.Computer.FileSystem.CopyFile(F.FileName.ToString, SoftDir, True)
            End If

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim F As New SaveFileDialog
        F.Filter = "Auk CyberPackProDatabase,MSAccess Database.mdb|*.mdb"
        F.AddExtension = True
        Try
            F.InitialDirectory = Me.TextBox1.Text
        Catch ex As Exception
        End Try
        If F.ShowDialog = Forms.DialogResult.OK Then
            My.Computer.FileSystem.CopyFile(SoftDir, F.FileName.ToString, True)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Id As String
        If Me.AukDatabaseDataSet.SETTING_BACK.Rows.Count = 0 Then Me.SETTING_BACKTableAdapter.Fill(Me.AukDatabaseDataSet.SETTING_BACK)
        Me.ProgressBar1.Maximum = Me.AukDatabaseDataSet.SETTING_BACK.Rows.Count
        ProgressBar1.Value = 0
        ProgressBar1.Visible = True
        Try
            For k As Integer = 0 To Me.AukDatabaseDataSet.SETTING_BACK.Rows.Count - 1
                RowX = Me.AukDatabaseDataSet.SETTING_BACK.Rows(k)
                Id = RowX(0).ToString
                My.Settings.PropertyValues.Item(Id).PropertyValue = RowX(1)
                'MsgBox(My.Settings.Properties.Item(Id).DefaultValue, , RowX(1))
                'Exit For
                ProgressBar1.Value += 1
            Next
        Catch ex As Exception
            Epx()
            If AukF.MsgTr("continue?", True) = False Then GoTo saveok
        Finally
            Beep()
        End Try
saveok: My.Settings.Save()
        My.Settings.Reload()
        ProgressBar1.Visible = False
    End Sub

    Private Sub AutomaitcBackupByDatetime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            nam = Me.TextBox1.Text & "\CPackPro " & SoftVersion & " " & SoftIn.AukDateGet(NDate, "-") & " " & CStr(TimeOfDay).Replace(":", ".") & ".mdb"
            My.Computer.FileSystem.CopyFile(SoftDir, nam, True)
            MsgBox("Successfully Backup " & nam, MsgBoxStyle.Information)
        Catch ex As Exception
            Epx(nam)
        End Try
    End Sub


    Private Sub TextBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.DoubleClick
        Button1_Click(sender, e)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If AukF.MsgTr("Do you want to get ReNew Database and default settings?") = True Then
            My.Computer.FileSystem.CopyFile(AppPath & "\nwd.xbase", SoftDir, True)
            My.Settings.Reset()
        End If
    End Sub

    Private Sub CheckBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.MouseHover
        'Me.ToolTip1.AutoPopDelay = 900000
        'Me.ToolTip1.ReshowDelay = 1000

        Me.ToolTip1.SetToolTip(sender, "If you select this option, everytime when auto backup system means (Days Or Size Less Than)" & vbCrLf & "occur it will not backup database in diffrent names by datetime. " & vbCrLf & "It will backup database in one name(CPackPro " & SoftVersion & ") and replace also database by this file name.")


    End Sub

    Private Sub NumericUpDown1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown1.Enter
        Me.ToolTip1.SetToolTip(sender, "First it check our memory saved date when the day backup system last occur." & vbCrLf & "If the checked date duration is greater than or equal to this value then " & vbCrLf & "this option try to backup our database in your selected folder by DateTime." & vbCrLf & vbCrLf & "This option will be accepted if 'Size less than option of backup' is not accepted.")

    End Sub

    Private Sub NumericUpDown1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NumericUpDown1.MouseClick
        '        Everytime when you open our software,
        'First it check our memory saved date when it has been last backup.
        'If the checked date duration is greater than or equal to this value then
        'this option try to backup our database in your selected folder by DateTime.

        'This option will be accepted if 'Size less than option of backup' is not accepted.

        Me.ToolTip1.SetToolTip(sender, "First it check our memory saved date when the day backup system last occur." & vbCrLf & "If the checked date duration is greater than or equal to this value then " & vbCrLf & "this option try to backup our database in your selected folder by DateTime." & vbCrLf & vbCrLf & "This option will be accepted if 'Size less than option of backup' is not accepted.")

    End Sub

    Private Sub NumericUpDown2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.Enter
        '        Everytime when you open our software,
        'if your current database size is less than or equal to this value of text ,
        'it will be backup on your selected folder by datetime.

        'This option will be accepted if days auto backup is not accepted.
        Me.ToolTip1.SetToolTip(sender, "Everytime when you open our software," & vbCrLf & "if your current database size is less than or equal to this value of text ," & vbCrLf & "it will be backedup on your selected folder by datetime." & vbCrLf & vbCrLf & "This option will be accepted if days auto backup is not accepted.")

    End Sub

    Private Sub NumericUpDown2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NumericUpDown2.MouseClick
        Me.ToolTip1.SetToolTip(sender, "Everytime when you open our software," & vbCrLf & "if your current database size is less than or equal to this value of text ," & vbCrLf & "it will be backedup on your selected folder by datetime." & vbCrLf & vbCrLf & "This option will be accepted if days auto backup is not accepted.")

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        If AukF.MsgTrU("RESTORE SETTINGS FROM A SELECTED DATABASE?", True, MsgBoxStyle.Information) = True Then
            Dim Info As New DataTable("softinfo")
            Dim SetBack As New DataTable("Setting_Back")

            Dim F As New OpenFileDialog
            F.Filter = "Auk CyberPackProDatabase,MSAccess Database.mdb|*.mdb"
            F.AddExtension = True
            Try
                F.InitialDirectory = Me.TextBox1.Text
            Catch ex As Exception
            End Try
            If F.ShowDialog = Forms.DialogResult.OK Then
                'My.Computer.FileSystem.CopyFile(SoftDir, SoftDir & "BAS", True)
                Try
                    SFC("softcode", "softwarename")
                    STC("AUK_CYBERPACK PRO 2.0", "CYBERPACK PRO 2.0")
                    AukSql.AukSql_Main("*", "softinfo", 0)
                    DSource = SoftIn.OleDB_DataSource_Cnn(F.FileName.ToString, "lorenzom268")
                    SoftIn.Sql_Convert_For_Adp("softinfo", BSql)
                    AukF.OleDb_SqlGen(DSource, Sql, Info)
                    If Info.Rows(0).Item(0) = "AUK_CYBERPACK PRO 2.0" And Info.Rows(0).Item(1) = "CYBERPACK PRO 2.0" Then
                        'My.Computer.FileSystem.CopyFile(F.FileName, SoftDir, True)
                        SoftIn.Sql_Convert_For_Adp("Setting_Back", "", "*", False)
                        AukF.OleDb_SqlGen(DSource, Sql, SetBack)
                        From_DBRestroeSteetings(SetBack)
                    Else
                        MsgBox("This database is not for Auk" & SoftName & " because function not match.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    MsgBox("PLEASE REOPEN ,OPENED FORMS.", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("This database is not for " & SoftName & " because a error is occur when try to load.", MsgBoxStyle.Critical)
                    Exit Sub
                End Try
            End If

        End If
    End Sub
    Public Sub From_DBRestroeSteetings(ByVal Db As DataTable)
        Dim Id As String
        If Db.Rows.Count = 0 Then MsgBox("Current Database Has No Data To Restore.", MsgBoxStyle.Information) : Exit Sub
        Me.ProgressBar1.Maximum = Db.Rows.Count
        ProgressBar1.Value = 0
        ProgressBar1.Visible = True
        Try
            For k As Integer = 0 To Db.Rows.Count - 1
                RowX = Db.Rows(k)
                Id = RowX(0).ToString
                My.Settings.PropertyValues.Item(Id).PropertyValue = RowX(1)
                'MsgBox(My.Settings.Properties.Item(Id).DefaultValue, , RowX(1))
                'Exit For
                ProgressBar1.Value += 1
            Next
        Catch ex As Exception
            Epx()
            If AukF.MsgTr("continue?", True) = False Then GoTo saveok
        Finally
            Beep()
        End Try
saveok: My.Settings.Save()
        My.Settings.Reload()
        ProgressBar1.Visible = False
    End Sub

End Class