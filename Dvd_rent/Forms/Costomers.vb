Public Class Costomers
    Dim CurObjs As Object
    Dim TDisBool As Boolean = False

    Dim bnx As New BindingSource
    Dim COUNT_TABLE As New DataTable
    Private Sub Costomer_InfBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Costomer_InfBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Costomer_InfBindingSource.EndEdit()
            Me.CostomerInfCostomerAlternativeBindingSource.EndEdit()
            Me.Costomer_InfTableAdapter.Update(Me.AukDatabaseDataSet.Costomer_Inf)
            Me.Costomer_ALternativeTableAdapter.Update(Me.AukDatabaseDataSet.Costomer_Alternative)
        Catch ex As Exception
            If Me.Costomer_IDTextBox.Text = "" Then
                Costomer_IDTextBox.Focus()
            Else
                Epx()
            End If
        End Try
    End Sub
    Public Sub SAVE_ALT()
        Try
            Me.Validate()
            Me.CostomerInfCostomerAlternativeBindingSource.EndEdit()
            Me.Costomer_ALternativeTableAdapter.Update(Me.AukDatabaseDataSet.Costomer_Alternative)
        Catch ex As Exception
            If Me.Costomer_IDTextBox.Text = "" Then
                Costomer_IDTextBox.Focus()
            Else
                Epx()
            End If
        End Try
    End Sub
    Public Function CNT(ByVal CUSID As String) As Integer
        If My.Settings.FAST_LOAD_DVD_RENTC = True Then Exit Function
        If CUSID = "" Then Return 0 : Me.Button5.Text = "HIS/HER HAS NO MOVIES INHAND" : Exit Function
        SFC("CUSTOMER ID")
        STC(CUSID)
        CNT = ADSRC.COUNT_T("DVD_RENTV_HAND", COUNT_TABLE)
        If CNT = 0 Then
            Me.Button5.Text = "HIS/HER HAS NO MOVIES INHAND"
        Else
            Me.Button5.Text = "HE/SHE HAS (" & CNT & ") MOVIES"
        End If
    End Function
    Public Function ENABLE_QUERY_INVIEW(ByVal CUSID As String) As Integer
        If My.Settings.FAST_LOAD_DVD_RENTC = True Then Exit Function
        Dim INTX As Integer
        INTX = CNT(CUSID)
        ENABLE_QUERY_INVIEW = INTX
        If Me.Panel1.Visible = True Then
            Me.CUSTOMERINHANDVIEW.RowFilter = "[Customer ID]='" & CUSID & "'"
            'MsgBox(Me.CUSTOMERINHANDVIEW.RowFilter)
            If Me.CUSTOMERINHANDVIEW.Find(CUSID) > -1 Then Exit Function
            If INTX > 0 Then
                SFC("CUSTOMER ID")
                STC(CUSID) '"2,3,7,8,9,10,11,12"
                AukF.Db_LoadN(Me.AukDatabaseDataSet.DVD_RENTV_HAND, "*", "", False, 0, "", False, 0, 500)
                'MsgBox(Me.AukDatabaseDataSet.DVD_RENTV_HAND.Rows.Count)
                'MsgBox(Me.AukDatabaseDataSet.DVD_RENTV_HAND.Rows.Count)
            End If
        End If
    End Function
    Private Sub Costomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Costomer_ALternative' table. You can move, or remove it, as needed.
        On Error Resume Next
        bnx.DataSource = Me.AukDatabaseDataSet.Costomer_Alternative
        If My.Settings.FAST_LOAD_DVD_RENTC = False Then Me.Button5.Visible = True
        Me.OptionsTableAdapter1.Fill(Me.AukDatabaseDataSet.Options)
        If My.Settings.DataLoad_view = False Then
            If My.Settings.DVDRENT_LAST_MEMBER = True Then
                ADSRC.Load_Only_LastRecord(Me.AukDatabaseDataSet.Costomer_Inf)
                LoadCos(Me.Costomer_IDTextBox.Text)
            Else
                Me.Costomer_InfTableAdapter.Fill(Me.AukDatabaseDataSet.Costomer_Inf)
                LoadCos(Me.Costomer_IDTextBox.Text)
            End If
        End If
        Me.AukDatabaseDataSet.Cyber_MonthlyFees.IDColumn.MaxLength = 15
        CNT(Me.Costomer_IDTextBox.Text)
        Me.CUSTOMERINHANDVIEW.Sort = "CUSTOMER ID"
        Me.DataGrid1.DataSource = Me.CUSTOMERINHANDVIEW
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Costomer_ImagePictureBox.DoubleClick
        OpenFileDialog1.Filter = "Jpg File|*.Jpg|Png Files|*.png|Gif File|*.Gif|Bmp File|*.Bmp"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.FilterIndex = My.Settings.ImageFiltersIndex
        Try
            If Me.OpenFileDialog1.ShowDialog() = Forms.DialogResult.OK Then
                Me.Costomer_ImagePictureBox.Image = System.Drawing.Image.FromFile(Me.OpenFileDialog1.FileName.ToString)
                My.Settings.ImageFiltersIndex = OpenFileDialog1.FilterIndex
                My.Settings.Save()
            End If
        Catch ex As Exception
            If OpenFileDialog1.FileName <> "" Then Epx()
        End Try


        'Dim P As System.Windows.Forms.PictureBox
        'P.Image = System.Drawing.Image.FromFile("a")


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim m As New CostoemrReport
        'ReportV.AukDatabaseDataSet = Me.AukDatabaseDataSet
        'ReportV.Costomer_InfBindingSource.DataSource = Me.AukDatabaseDataSet
        'ReportV.Costomer_InfBindingSource.DataMember = "Costomer_Inf"
        'FrmL(ReportV)


        'AukF.Prnt(m, Me.AukDatabaseDataSet)

    End Sub
    Private Sub Costomer_InfBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Costomer_InfBindingSource.PositionChanged
        On Error Resume Next
        If Costomer_InfBindingSource.Count > 0 Then
            LoadCos(Me.Costomer_IDTextBox.Text)
            ENABLE_QUERY_INVIEW(Me.Costomer_IDTextBox.Text)
        End If

    End Sub
    Public Function LoadCos(ByVal id As String)
        If Val(My.Settings.Maximum_Alternative) > -1 Then
            If AukF.BindFind(bnx, "Costomer_ID", id) = False Then
                If id = "" Then Exit Function
                SFC("Costomer_ID")
                STC(id)
                AukF.Db_Load("*", "costomer_Alternative", Me.AukDatabaseDataSet, False, "", False, False, CInt(My.Settings.Maximum_Alternative))
            End If
            If Me.Label2.Text <> "DVD CUSTOMERS ALTERNATIVE" Then
                Me.Label2.Text = "DVD CUSTOMERS ALTERNATIVE"
            End If
        Else
            Me.Label2.Text = "NO ALTERNATIVE ALLOW"
        End If
        CNT(id)
    End Function
    Public Function PrintOnlyLoadCos(ByVal id As String)
        If AukF.BindFind(bnx, "Costomer_ID", id) = False Then
            SFC("Costomer_ID")
            STC(id)
            AukF.Db_Load("*", "costomer_Alternative", Me.AukDatabaseDataSet, True, "", False, False, CInt(My.Settings.Maximum_Alternative))

        End If

    End Function
    Private Sub WithOutImagePrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim m As New CostoemrReport
        AukF.Prnt(m, Me.AukDatabaseDataSet, Me.Costomer_InfBindingSource)

    End Sub

    Private Sub prsd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Joining_DateDateTimePicker.KeyDown, Costomer_NameTextBox.KeyDown, Costomer_IDTextBox.KeyDown, Costomer_CategoryComBo.KeyDown, Costomer_AddressTextBox.KeyDown, ContactNumber_PhoneTextBox.KeyDown, ContactNumber_MobileTextBox.KeyDown, Advance_FeesTextBox.KeyDown, Button1.KeyDown
        'If e.KeyCode = Keys.Enter Then

        '    If Me.CheckBox1.Checked = True Then
        '        If Me.Costomer_InfBindingSource.Position = Me.Costomer_InfBindingSource.Count - 1 Then
        '            Try
        '                Me.Costomer_InfBindingSource.AddNew()
        '            Catch ex As Exception
        '                Epx()
        '            End Try
        '        Else
        '            Me.Costomer_InfBindingSource.MoveNext()
        '        End If
        '    Else
        '        Me.SelectNextControl(sender, True, True, True, True)
        '        If sender.name = Advance_FeesTextBox.Name Then
        '            If Me.Costomer_InfBindingSource.Position = Me.Costomer_InfBindingSource.Count - 1 Then
        '                Try
        '                    Me.Costomer_InfBindingSource.AddNew()
        '                Catch ex As Exception
        '                    Epx()
        '                End Try
        '                Me.Costomer_IDTextBox.Focus()

        '            Else
        '                Me.Costomer_InfBindingSource.MoveNext()
        '                Me.Costomer_IDTextBox.Focus()

        '            End If
        '        End If
        '    End If

        'End If
        'If e.Shift = True And e.Control = True Then
        '    If e.KeyCode = Keys.A Then
        '        CurObjs = sender
        '        Me.DataGridView1.Focus()
        '    End If
        'End If
        'If e.Modifiers = Keys.Control Then

        '    If e.KeyCode = Keys.Up Then
        '        Me.SelectNextControl(sender, False, True, True, True)
        '    ElseIf e.KeyCode = Keys.Down Then
        '        Me.SelectNextControl(sender, True, True, True, True)
        '    ElseIf e.KeyCode = Keys.Right Then
        '        'Me.SelectNextControl(sender, True, True, True, True)
        '        Me.Costomer_InfBindingSource.MoveNext()
        '    ElseIf e.KeyCode = Keys.Left Then
        '        'Me.SelectNextControl(sender, True, True, True, True)
        '        Me.Costomer_InfBindingSource.MovePrevious()
        '    ElseIf e.KeyCode = Keys.S Then
        '        'Me.SelectNextControl(sender, True, True, True, True)
        '        'Me.Costomer_InfBindingSource.MovePrevious()
        '        Costomer_InfBindingNavigatorSaveItem_Click(sender, e)

        '    End If
        'End If
        SoftIn.KEY_DOWN_EVENTS(sender, e, Me.Costomer_InfBindingSource, Me.Costomer_IDTextBox, Me.Advance_FeesTextBox.Name.ToString, Me.CheckBox1.Checked, True, True, True)
    End Sub
    Public Function ADD_N_FUNC()
        Dim DE As Int64
        Dim Int As Integer = 0

        If My.Settings.AUTOMATICID_DVDMEBER = True Then
            Me.Costomer_InfBindingSource.AddNew()
            D = My.Settings.DVDMEMBER_STATW.ToString
            DE = CInt(Val(My.Settings.DVDMEBER_ID_SR.ToString))
goagain:    ID = D & (DE)
            Me.TxBoxEna()
            'MsgBox(id)
            If Int = 150 Then
                MsgBox("Please set the maximum integer number of last member id from settings", MsgBoxStyle.Information)
                Me.Costomer_CategoryComBo.SelectedIndex = 1
                Me.Costomer_IDTextBox.Focus()
                Me.Joining_DateDateTimePicker.Value = Now
                Me.Advance_FeesTextBox.Text = Val(Me.AukDatabaseDataSet.Options(0).Item("Advance_Fees").ToString)
                Exit Function
            End If

            If AukF.BindFind(Me.Costomer_InfBindingSource, "costomer_id", id) = False Then
                Me.Costomer_IDTextBox.Text = ID
                My.Settings.DVDMEBER_ID_SR = DE
                My.Settings.Save()
            Else
                GoTo plusid
            End If
            Me.Costomer_CategoryComBo.SelectedIndex = 1
            Me.Costomer_NameTextBox.Focus()
            Me.Joining_DateDateTimePicker.Value = Now.Date
            Me.Advance_FeesTextBox.Text = Val(Me.AukDatabaseDataSet.Options(0).Item("Advance_Fees").ToString)
            'Me.Validate()
        Else
            Me.Costomer_InfBindingSource.AddNew()
            Me.Costomer_IDTextBox.Focus()
            Me.Advance_FeesTextBox.Text = Val(Me.AukDatabaseDataSet.Options(0).Item("Advance_Fees").ToString)
            Me.Joining_DateDateTimePicker.Value = Now
        End If
        Exit Function
plusid:
        Int += 1 : DE = DE + 1 : GoTo goagain

    End Function
    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        On Error Resume Next
        AukF.BindGotoFind(Me.Costomer_InfBindingSource, "Costomer_ID", sender.text)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        ADD_N_FUNC()


    End Sub

    Private Sub RefreshCurrentItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshCurrentItemToolStripMenuItem.Click, ToolStripButton2.ButtonClick
        AukF.Single_DataRecordRefresh(Me.Costomer_InfBindingSource, True)

    End Sub

    Private Sub RefreshWholeDataTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshWholeDataTableToolStripMenuItem.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.Costomer_InfBindingSource, True)

    End Sub

    Private Sub QraKe(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.Shift = True And e.Control = True Then
            If e.KeyCode = Keys.A Then
                Try
                    CurObjs.focus()
                Catch ex As Exception
                    Me.Costomer_NameTextBox.Focus()
                End Try
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'On Error Resume Next
        Dim aQa1, Aqa2 As String
        Try
            aQa1 = Me.Advance_FeesTextBox.Text
            Aqa2 = Val(Me.AukDatabaseDataSet.Options(0).Item("Advance_Fees").ToString)
        Catch ex As Exception
            Aqa2 = 0
        End Try
        If Val(aQa1) < Val(Aqa2) Then
            Me.Advance_FeesTextBox.ForeColor = Color.White
            Me.Advance_FeesTextBox.BackColor = Color.Red
        Else
            Me.Advance_FeesTextBox.ForeColor = Color.Black
            Me.Advance_FeesTextBox.BackColor = Color.White
        End If
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Costomers_Load(sender, e)

    End Sub


    Private Sub AddingLast(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        SoftIn.Master_ID_String(sender, 4)

    End Sub
    Private Sub DataGridView1_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        SoftIn.Master_ID_String(sender, 4)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub
    Private Sub PrintOnlyCurrentMemberInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintOnlyCurrentMemberInformationToolStripMenuItem.Click, ToolStripButton1.ButtonClick
        Dim m As New CostoemrReport
        B = AukF.BindFilter_GetString(Me.Costomer_InfBindingSource, "COSTOMER_ID", Me.Costomer_IDTextBox.Text)
        'MsgBox(b)
        AukF.Prnt(m, Me.AukDatabaseDataSet, b, "costomer_inf")
    End Sub

    Private Sub ShowAllMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllMemberToolStripMenuItem.Click
        'Me.Costomer_InfTableAdapter.Fill(Me.AukDatabaseDataSet.Costomer_Inf)
        'LoadCos(Me.Costomer_IDTextBox.Text)
        Dim M As New CostoemrReport
        AukF.Prnt(M, Me.AukDatabaseDataSet, Me.Costomer_InfBindingSource)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AukQ.Bnp = Me.Costomer_InfBindingSource
        FrmL(AukQ)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        DVDRENT.IMAGE_SAVE(Me.SaveFileDialog1, Me.Costomer_ImagePictureBox)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        'Dim BNP2 As New BindingSource
        'MsgBox(Me.AukDatabaseDataSet.Costomer_Inf.ChildRelations(Me.CostomerInfCostomerAlternativeBindingSource.DataMember.ToString).ChildTable.TableName.ToString)

        AukQ.Bnp = Me.CostomerInfCostomerAlternativeBindingSource
        FrmL(AukQ)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ENABLE_QUERY_INVIEW(Me.Costomer_IDTextBox.Text) > 0 Then
            Me.Panel1.Visible = True
            Me.ENABLE_QUERY_INVIEW(Me.Costomer_IDTextBox.Text)
        Else
            MsgBox("HE/SHE HAS NO MOVIE", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Panel1.Visible = False
        Me.Costomer_NameTextBox.Focus()
    End Sub
    Private Sub Costomer_InfBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Costomer_InfBindingNavigator.RefreshItems
        If Me.Costomer_InfBindingSource.Position = -1 Then Me.BindingNavigatorPositionItem.Text = 0 Else Me.BindingNavigatorPositionItem.Text = Me.Costomer_InfBindingSource.Position + 1
    End Sub

    Private Sub Costomer_IDTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Costomer_IDTextBox.LostFocus
        If Me.Costomer_IDTextBox.Text = "" And Me.Costomer_InfBindingSource.Position > -1 Then MsgBox(UCase("Please type Customer ID,It can't be null."), MsgBoxStyle.Critical) : sender.focus() : Exit Sub
    End Sub

    Private Sub save_Direct_Validate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Joining_DateDateTimePicker.Validated, Costomer_NameTextBox.Validated, Costomer_IDTextBox.Validated, Costomer_CategoryComBo.Validated, Costomer_AddressTextBox.Validated, ContactNumber_PhoneTextBox.Validated, ContactNumber_MobileTextBox.Validated, Advance_FeesTextBox.Validated, Costomer_ImagePictureBox.Validated
        Me.Costomer_InfBindingSource.EndEdit()
        If My.Settings.DIRECT_SAVE = True Then Costomer_InfBindingNavigatorSaveItem_Click(sender, e)

    End Sub

    Private Sub save_check(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        'If My.Settings.DIRECT_SAVE = True Then Costomer_InfBindingNavigatorSaveItem_Click(sender, e)
        My.Settings.Save()

    End Sub

    Private Sub TWICE_CALL(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then ADSRC.Twice_Q(Me.Costomer_InfBindingSource, 0, 2, sender.TEXT)
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked = True Then Me.Button5.Visible = False : Me.AukDatabaseDataSet.DVD_RENTV_HAND.Clear() Else Me.Button5.Visible = True : Me.ENABLE_QUERY_INVIEW(Me.Costomer_IDTextBox.Text)
        LoadCos(Me.Costomer_IDTextBox.Text)
    End Sub

    Private Sub LOADAGAINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADAGAINToolStripMenuItem.Click
        Costomers_Load(sender, e)

    End Sub

    Private Sub SETTINGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SETTINGSToolStripMenuItem.Click
        FrmL(DVD_MEMBER)

    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub INPUTIMAGESFROMFOLDERBYTHEIRIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INPUTIMAGESFROMFOLDERBYTHEIRIDToolStripMenuItem.Click
        Dim FN As New FolderBrowserDialog
        FN.ShowNewFolderButton = True
        If FN.ShowDialog = Forms.DialogResult.OK Then
            FOL = FN.SelectedPath
            DVDRENT.IMAGE_INPUT_DATATABLE(FOL, Me.AukDatabaseDataSet.Costomer_Inf, 6)

        End If
    End Sub

    Private Sub PRINTCURRENTIDCARDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRINTCURRENTIDCARDToolStripMenuItem.Click
        Dim m As New DVD_MEMBER_IDCARD
        B = AukF.BindFilter_GetString(Me.Costomer_InfBindingSource, "COSTOMER_ID", Me.Costomer_IDTextBox.Text)
        AukF.Prnt(m, Me.AukDatabaseDataSet, b, "costomer_inf")
    End Sub

    Private Sub PRINTALLMEMBERSIDCARDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRINTALLMEMBERSIDCARDToolStripMenuItem.Click
        Dim m As New DVD_MEMBER_IDCARD
        'B = AukF.BindFilter_GetString(Me.Costomer_InfBindingSource, "COSTOMER_ID", Me.Costomer_IDTextBox.Text)
        AukF.Prnt(m, Me.AukDatabaseDataSet)

    End Sub

    Private Sub Costomers_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If SAVMSG() = 1 Then
                Costomer_InfBindingNavigatorSaveItem_Click(sender, e)
            ElseIf SavInt = 2 Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FreeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopMemberShipToolStripMenuItem1.Click, FreeToolStripMenuItem.Click, CostInToolStripMenuItem.Click, CancelMemberShipToolStripMenuItem.Click
        AukF.FindInObjectAndSelect(Me.Costomer_CategoryComBo, sender.text, True, False, True)
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        GrdErrMsg(e)
    End Sub

    Private Sub DataGridView1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Validated
        If My.Settings.DIRECT_SAVE = True Then Costomer_InfBindingNavigatorSaveItem_Click(sender, e)

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Costomer_InfBindingSource.Count = 0 And TDisBool = False Then
            TxBoxDis()
        ElseIf Me.Costomer_InfBindingSource.Count > 0 And TDisBool = True Then
            TxBoxEna()
        End If
    End Sub
    Private Sub TxBoxDis()
        If TDisBool = False Then
            For K As Integer = 0 To Me.Controls.Count - 1
                If TypeOf Me.Controls.Item(K) Is TextBox Then
                    Dim T As TextBox = Me.Controls.Item(K)
                    T.Enabled = False
                End If
            Next
            TDisBool = True
        End If
    End Sub
    Private Sub TxBoxEna()
        If TDisBool = True Then
            For K As Integer = 0 To Me.Controls.Count - 1
                If TypeOf Me.Controls.Item(K) Is TextBox Then
                    Dim T As TextBox = Me.Controls.Item(K)
                    T.Enabled = True
                End If
            Next
            TDisBool = False
        End If
    End Sub

    Private Sub DelBinNav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBinNav.Click

    End Sub
End Class