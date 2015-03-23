Public Class Vendor
    Dim VenId As Decimal
    Public Sub SAVE()
        Try
            Me.VENDORBindingSource.EndEdit()
            Me.V_WARBindingSource.EndEdit()
            Me.VendorTableAdapter1.Update(Me.AukDatabaseDataSet.VENDOR)
            Me.V_WARTableAdapter1.Update(Me.AukDatabaseDataSet.V_WAR)
            If PRO_ADD2.Visible = True Then
                PRO_ADD2.NeedToVendorRe = True
            End If
        Catch ex As Exception
            Epx()
      
        End Try
    End Sub
    Public Sub ADD_VEN()
        Try
            Me.VENDORBindingSource.AddNew()
            Me.V_IDTextBox.Text = VenId + 1
            VenId = Me.V_IDTextBox.Text
            Me.V_NAMETextBox.Focus()
        Catch ex As Exception
            Epx()
       
        End Try
    End Sub
    Public Sub DEL_VEN()
        Try
            Me.VENDORBindingSource.RemoveCurrent()
        Catch ex As Exception
            Epx()
     
        End Try
    End Sub
    Public Sub REJECT_SIN()
        If Me.V_WARDataGridView.Focused = False Then
            AukF.Single_DataRecordRefresh(Me.VENDORBindingSource)
        Else
            AukF.Single_DataRecordRefresh(Me.V_WARBindingSource)
        End If
    End Sub
    Public Sub REJECT_TAB()
        If Me.V_WARDataGridView.Focused = False Then
            AukF.SingleDataTable_DataRecordRefresh(Me.VENDORBindingSource, True)
        Else
            AukF.SingleDataTable_DataRecordRefresh(Me.V_WARBindingSource, True)
        End If
    End Sub
    Public Sub CHG_IMAGE()
        Dim O As New OpenFileDialog
        DVDRENT.IMAGE_INPUT(O, Me.V_IMAGEPictureBox)

    End Sub
    Public Sub SHOW_ALL_WARRENT()
        SFC("v_ID")
        STC(Me.V_IDTextBox.Text)
        DTC("n")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.V_WAR, -1, "", False)
    End Sub
    Public Sub FILTER_LEAST_PRODUCTS()
        FrmL(VENDORS_SUMMARY)

    End Sub
    Public Sub q_WAR()
        DVDRENT.ShowQr_Product(Me.V_WARDataGridView, Me.V_WARBindingSource)
    End Sub
    Public Sub q_VEN()
        'DVDRENT.ShowQr_Product(AukQ,  , Me.V_WARBindingSource)
        AukQ.Bnp = Me.VENDORBindingSource
        FrmL(AukQ)
    End Sub
    Private Sub WORK_WITH_LABELS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEVENDORSINFORMATIONToolStripMenuItem.Click, SHOWWARRENTYVENDORSToolStripMenuItem.Click, SHOWCURRENTVENDORSALLWARRANTYPRODUCTSToolStripMenuItem.Click, SAVEEDITEDToolStripMenuItem.Click, REJECTCHANGEToolStripMenuItem.Click, REHECTWHOLETABLECHANGESToolStripMenuItem.Click, QUERYMToolStripMenuItem.Click, QUERYMANAGERFORVENDORSToolStripMenuItem.Click, DELETEToolStripMenuItem.Click, CHANGEINSERTVENDORIMAGEToolStripMenuItem.Click, ADDNEWVENDORToolStripMenuItem.Click, Label5.Click, Label7.Click, Label6.Click, Label4.Click, Label3.Click, Label2.Click, Label12.Click, Label1.Click, ToolStripMenuItem1.Click
        On Error GoTo B
        Select Case sender.TAG
            Case 1
                Me.ADD_VEN()
            Case 2
                Me.SAVE()
            Case 3
                Me.DEL_VEN()
            Case 4
                Me.REJECT_SIN()
            Case 5
                Me.REJECT_TAB()
            Case 6
                Me.CHG_IMAGE()
            Case 7
                Me.SHOW_ALL_WARRENT()
            Case 8
                Me.FILTER_LEAST_PRODUCTS()
            Case 9
                Me.q_WAR()
            Case 10
                Me.q_VEN()
            Case 11
                Me.Close()
            Case 12
                Me.VENDORBindingSource.MovePrevious()
            Case 13
                Me.VENDORBindingSource.MoveNext()
            Case 14
                Dim Ox As FolderBrowserDialog
                If Ox.ShowDialog = Forms.DialogResult.OK Then
                    DVDRENT.IMAGE_INPUT_DATATABLE(Ox.SelectedPath, Me.AukDatabaseDataSet.VENDOR, 5)
                End If
        End Select
        Exit Sub
B:      Epx()

    End Sub
    Public Sub Load_Ven(ByVal ID As String)
        SFC("V_ID")
        STC(ID)
        AukF.Db_LoadN(Me.AukDatabaseDataSet.VENDOR, -1, "", False)
        SFC("v_ID", "Worked")
        STC(ID, "False")
        DTC("n", "b")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.V_WAR, -1, "", False)
        AukF.BindFind(Me.VENDORBindingSource, "V_id", ID, True)
    End Sub

    Private Sub Vendor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If SavMsg() = 1 Then
                Me.SAVE()
            ElseIf SavInt = 2 Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Vendor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.V_WAR' table. You can move, or remove it, as needed.
        Me.V_WARTableAdapter1.Fill(Me.AukDatabaseDataSet.V_WAR)
        AukF.Db_LoadN(Me.AukDatabaseDataSet.VENDOR, -1, "", False)
        SFC("Worked")
        STC("False")
        DTC("n", "b")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.V_WAR, -1, "", False)
        AukF.XPAuk(Me)
        VenId = ADSRC.MAXIMUM_VALUE("Vendor", "V_ID")
    End Sub

    'Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
    '    'If ADSRC.TWICE_BINDFIND(Me.V_WARBindingSource, "sold_id", "pRODUCT_SERIAL", sender.TEXT, "nEW_PRODUCT_SERIAL", Me.V_WARDataGridView) = False Then
    '    ADSRC.TWICE_BINDFIND(Me.V_WARBindingSource, "CLIENT_NAME", "COMMENTS", sender.TEXT, "", Me.V_WARDataGridView)
    '    'End If
    'End Sub

    Private Sub V_IMAGEPictureBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles V_IMAGEPictureBox.DoubleClick
        Me.CHG_IMAGE()
    End Sub

    Private Sub kEdOWN_(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles V_PHONETextBox.KeyDown, V_NAMETextBox.KeyDown, V_MOBILETextBox.KeyDown, V_IDTextBox.KeyDown, V_ADDRESSTextBox.KeyDown, TOTAL_PRODUCTSTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If sender.NAME = Me.V_PHONETextBox.Name Then
                Me.V_IMAGEPictureBox.Focus()
                Exit Sub
            End If
        End If
        SoftIn.KEY_DOWN_EVENTS(sender, e, Me.VENDORBindingSource, Me.V_IDTextBox, Me.V_IMAGEPictureBox.Name.ToString, Me.CheckBox1.Checked, Me.CheckBox2.Checked, True, True)

    End Sub
    Public Sub ADD_N_FUNC()
        ADD_VEN()
    End Sub

    Private Sub V_IMAGEPictureBox_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles V_IMAGEPictureBox.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CHG_IMAGE()
            If Me.CheckBox2.Checked = True Then ADD_N_FUNC() Else Me.V_IDTextBox.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.VENDORBindingSource.Count = 0 Then
            If Me.V_WARBindingSource.AllowNew = True Then Me.V_WARBindingSource.AllowNew = False
        Else
            If Me.V_WARBindingSource.AllowNew = False Then Me.V_WARBindingSource.AllowNew = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        AukF.BindFind(Me.VENDORBindingSource, "V_ID", sender.TEXT, True)
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        Me.Close()
    End Sub

    Private Sub Label13_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label13.MouseDown
        AukF.DragAuk(Me)
    End Sub

    Private Sub V_PHONETextBox_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles V_PHONETextBox.Validated, V_NAMETextBox.Validated, V_MOBILETextBox.Validated, V_IDTextBox.Validated, V_ADDRESSTextBox.Validated, TOTAL_PRODUCTSTextBox.Validated
        If My.Settings.DIRECT_SAVE = True Then Me.Normal_save()
    End Sub
    Public Sub Normal_save()
        Try
            Me.VENDORBindingSource.EndEdit()
            Me.VendorTableAdapter1.Update(Me.AukDatabaseDataSet.VENDOR)
        Catch ex As Exception
            Epx()
        End Try
    End Sub
    Public Sub VWar_save()
        Try
            'Me.VENDORBindingSource.EndEdit()
            Me.V_WARBindingSource.EndEdit()
            'Me.VendorTableAdapter1.Update(Me.AukDatabaseDataSet.VENDOR)
            Me.V_WARTableAdapter1.Update(Me.AukDatabaseDataSet.V_WAR)
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub V_WARDataGridView_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles V_WARDataGridView.Validated
        If My.Settings.DIRECT_SAVE = True Then VWar_save()
    End Sub
End Class