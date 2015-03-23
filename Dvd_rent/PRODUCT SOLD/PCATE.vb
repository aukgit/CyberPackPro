Public Class PCATE
    Dim D As DataGridView
    Public HOOK_FR As Boolean = False
    Dim DIdS, Cate, SCate As Decimal

    'Friend LST As New ComboBox
    Private Sub PS_CATEGORYBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PS_CATEGORYBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.PS_CATEGORYBindingSource.EndEdit()
            Me.PS_CATEGORY_DISBindingSource.EndEdit()
            Me.PS_CATEGORYBindingSource.EndEdit()
            Me.PS_CATEGORYTableAdapter.Update(Me.AukDatabaseDataSet.PS_CATEGORY)
            Me.PS_SUB_CATEGORYTableAdapter.Update(Me.AukDatabaseDataSet.PS_SUB_CATEGORY)
            Me.PS_CATEGORY_DISTableAdapter.Update(Me.AukDatabaseDataSet.PS_CATEGORY_DIS)
        Catch ex As Exception
            Epx()
        End Try

    End Sub

    Private Sub PCATE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If HOOK_FR = False Then
            If My.Settings.DataLoad_view = False Then
                AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CATEGORY, -1, "", False, 0, "CATEGORY", False, 0, Val(My.Settings.MaximumData_load))
                AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SUB_CATEGORY, -1, "", False, 0, "SUB_CATEGORY_NAME", False, 0, Val(My.Settings.MaximumData_load))
                AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, -1, "", False, 0, "[DISPLAY ID]", False, 0, Val(My.Settings.MaximumData_load))
            Else
                AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CATEGORY, -1, "", False, 0, "CATEGORY", False, 0, Val(My.Settings.MaximumData_load))
                AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SUB_CATEGORY, -1, "", False, 0, "SUB_CATEGORY_NAME", False, 0, Val(My.Settings.MaximumData_load))
            End If
        End If
        DIdS = MAXIMUM_VALUE("PS_CATEGORY_DIS", "DISPLAY ID")
        DIdS += 1
        Cate = MAXIMUM_VALUE("PS_CATEGORY", "categoryid") : Cate += 1
        SCate = MAXIMUM_VALUE("PS_SUB_CATEGORY", "sub_categoryid") : SCate += 1
        'MsgBox(SCate, , Cate)
        'LST.DataSource = Me.AukDatabaseDataSet
        'LST.DataSource = Me.PS_CATEGORYBindingSource
        'LST.DisplayMember = "CATEGORY"
        'MsgBox(LST.Items.Count)
        AukF.SuggestListSourceAddGveMsg(Me.category_find, Me.AukDatabaseDataSet, "ps_category", 1, 300)
    End Sub


    Private Sub DIS_ENDEDIT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PS_CATEGORY_DISDataGridView.CellEndEdit
        On Error Resume Next
        SoftIn.Master_ID_NumberInsert_NonAuto(Me.PS_CATEGORY_DISDataGridView, DIdS)
        DIdS += 1
        'MsgBox(PS_CATEGORY_DISDataGridView.Rows.Count)
        SCAT = AukF.GridT(sender, 1)
        'MsgBox(SCAT, , "SCAT")
        'C = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY, CAT, 1)
        S = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_SUB_CATEGORY, SCAT, 1)
        cat = RowX(2)
        catn = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY, cat, 1)
        CD = Me.ADDSOMETING_DISPLAY.Text
        If Trim(CD) <> "" Then
            G = AukF.GridT(sender, 2)
            If InStr(G, CD) = 0 Then
                sender(2, e.RowIndex).Value = G & CD
            End If
            'MsgBox(CD, , AukF.GridT(sender, 2))
        End If
        MN = catn & " " & S & " " & AukF.GridT(sender, 2)
        sender(3, e.RowIndex).VALUE = MN
        If e.ColumnIndex = 4 Then
            GET_BEN()
        End If
        SoftIn.PREVIOUS_DATAiNPUT_DATAGRID(sender, 0)
    End Sub
    Public Function REFRESH_DISPLAY() 'ADDING DISPLAY NAME
        Dim D As DataGridView = Me.PS_CATEGORY_DISDataGridView
        Dim SENDER As DataGridView
        SENDER = D
        If D.RowCount = 0 Then Exit Function
        SCAT = AukF.GridT(D, 1, 0)
        S = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_SUB_CATEGORY, SCAT, 1)
        cat = RowX(2)
        catn = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY, cat, 1)
        For K As Integer = 0 To D.RowCount - 1
            CD = Me.ADDSOMETING_DISPLAY.Text
            If Trim(CD) <> "" Then
                G = AukF.GridT(SENDER, 2)
                If InStr(G, CD) = 0 Then
                    SENDER(2, D.CurrentCell.RowIndex).Value = G & CD
                End If
            End If
            MN = catn & " " & S & " " & AukF.GridT(D, 2, K)
            D(3, K).Value = MN
        Next

    End Function
    Public Sub GET_BEN()
        D = Me.PS_CATEGORY_DISDataGridView
        AD = SoftIn.GET_BENEFIT(AukF.GridT(D, 4, -1, 0), Val(My.Settings.benefit_percent_MSol.ToString))
        If Val(AukF.GridT(D, 4, -1, 0)) < Val(AD) Then
            D(5, DRow).Value = AD
        End If
        'MsgBox(AukF.GridT(D, 3, -1, 0))
    End Sub
    Private Sub PS_CATEGORY_DISDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PS_CATEGORY_DISDataGridView.CellContentClick
        'GET_BEN()
    End Sub

    Private Sub ToolStripTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        AukF.BindFind(Me.PS_CATEGORYBindingSource, "DISPLAY_ID", sender.TEXT, True)
    End Sub

    Private Sub frm_close(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
   
        If SoftIn.GetChages(Me.AukDatabaseDataSet.PS_CATEGORY) = True Or SoftIn.GetChages(Me.AukDatabaseDataSet.PS_CATEGORY_DIS) = True Or SoftIn.GetChages(Me.AukDatabaseDataSet.PS_SUB_CATEGORY) = True Then
            If SAVMSG() = 1 Then
                PS_CATEGORYBindingNavigatorSaveItem_Click(sender, e)
            ElseIf SavInt = 2 Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub COPYSELECTEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPYSELECTEDToolStripMenuItem.Click
        SoftIn.COPY_GRID(Me.ContextMenuStrip1.SourceControl)
    End Sub

    Private Sub PASTESELECTORINSERTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PASTESELECTORINSERTToolStripMenuItem.Click
        SoftIn.PASTE_GRID(Me.ContextMenuStrip1.SourceControl)
    End Sub

    Private Sub DELETESELETECToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETESELETECToolStripMenuItem.Click
        SendKeys.Send("{DELETE}")
    End Sub

    Private Sub REFRESHCURRENTTABLEDATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHCURRENTTABLEDATAToolStripMenuItem.Click
        Dim DX As DataGridView = Me.ContextMenuStrip1.SourceControl
        If DX IsNot Nothing Then AukF.SingleDataTable_DataRecordRefresh(DX.DataSource, True)
    End Sub
    Private Sub REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem.Click
        Dim DX As DataGridView = Me.ContextMenuStrip1.SourceControl
        If DX IsNot Nothing Then AukF.Single_DataRecordRefresh(DX, True)
    End Sub
    Private Sub CUTSELECTEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUTSELECTEDToolStripMenuItem.Click
        SoftIn.CUT_GRID(Me.ContextMenuStrip1.SourceControl)
    End Sub

    Private Sub SUB_CAT_END(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PS_SUB_CATEGORYDataGridView.CellEndEdit
        'SoftIn.MASTER_ID_GET(Me.PS_SUB_CATEGORYDataGridView)
        SoftIn.Master_ID_NumberInsert_NonAuto(sender, SCate) : SCate += 1
    End Sub

    Private Sub SAMEINPUTX(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAMEPRODUCTGOODINPUTToolStripMenuItem.Click
        Dim DX As DataGridView = Me.ContextMenuStrip1.SourceControl
        INPUTX = InputBox("PLEASE TYPE COMMON STRING TO INPUT.PLEASE CAFEFULL FROM LINK FIELDS AND NUMBER FIELDS.", "COMMON ITEM", INPUTX)
        SoftIn.SELECTED_CELLS_COMMON_TXT(DX, INPUTX)
    End Sub

    Private Sub FORINSERTCOPYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FORINSERTCOPYToolStripMenuItem.Click
        Dim D As DataGridView = Me.ContextMenuStrip1.SourceControl
        SoftIn.Insert_Copies(D)
    End Sub

    Private Sub PS_CATEGORYDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PS_CATEGORYDataGridView.CellEndEdit
        SoftIn.Master_ID_NumberInsert_NonAuto(sender, Cate) : Cate += 1
    End Sub

    Private Sub FORINSERTCURSELECTEDROWSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FORINSERTCURSELECTEDROWSToolStripMenuItem.Click
        Dim D As DataGridView = Me.ContextMenuStrip1.SourceControl
        SoftIn.Insert_Cut(D)
    End Sub

    Private Sub INSERTCOPYROWSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INSERTCOPYROWSToolStripMenuItem.Click
        Dim D As DataGridView = Me.ContextMenuStrip1.SourceControl
        If D.Name = Me.PS_CATEGORYDataGridView.Name Then
            SoftIn.iNSERT_PASTE(D, False, "", "", Cate, True) : Cate = CDec(WGeT)
        ElseIf D.Name = Me.PS_SUB_CATEGORYDataGridView.Name Then
            SoftIn.iNSERT_PASTE(D, False, "2", AukF.GridT(Me.PS_CATEGORYDataGridView, 0), SCate, True)
        ElseIf D.Name = Me.PS_CATEGORY_DISDataGridView.Name Then
            SoftIn.iNSERT_PASTE(D, False, "1", AukF.GridT(Me.PS_SUB_CATEGORYDataGridView, 0), DIdS, True) : DIdS = CDec(WGeT)
        End If
    End Sub

    Private Sub CREATENEWINSERTCOPYROWSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CREATENEWINSERTCOPYROWSToolStripMenuItem.Click
        Dim D As DataGridView = Me.ContextMenuStrip1.SourceControl

        If D.Name = Me.PS_CATEGORYDataGridView.Name Then
            SoftIn.iNSERT_PASTE(D, True, "", "", Cate, True) : Cate = CDec(WGeT)
        ElseIf D.Name = Me.PS_SUB_CATEGORYDataGridView.Name Then
            SoftIn.iNSERT_PASTE(D, True, "2", AukF.GridT(Me.PS_CATEGORYDataGridView, 0), SCate, True) : SCate = CDec(WGeT)
        ElseIf D.Name = Me.PS_CATEGORY_DISDataGridView.Name Then
            SoftIn.iNSERT_PASTE(D, True, "1", AukF.GridT(Me.PS_SUB_CATEGORYDataGridView, 0), DIdS, True) : DIdS = CDec(WGeT)
        End If
    End Sub

    Private Sub MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem.Click
        Dim D As DataGridView = Me.ContextMenuStrip1.SourceControl
        SoftIn.ROWS_DATAG_INNER_CHG(D)
    End Sub

    Private Sub ToolStripTextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles category_find.TextChanged
        'MsgBox(LST.Items.Count)
        'If AukF.FindInObjectAndSelect(LST, sender.TEXT, False) = True Then
        '    Me.PS_CATEGORYBindingSource.Position = ComRow
        'End If
        AukF.BindFind(Me.PS_CATEGORYBindingSource, "CATEGORY", sender.TEXT, True)
    End Sub

    Private Sub GETCURRENTQUANTITYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GETCURRENTQUANTITYToolStripMenuItem.Click
        Dim D As DataGridView = PS_CATEGORY_DISDataGridView
        If D.Name = Me.PS_CATEGORY_DISDataGridView.Name Then
            SFC("DISPLAY_ID")
            STC(AukF.GridT(D, 0))
            WGeT = ADSRC.COUNT_CN("PS_COLLECTION")
            D(6, D.CurrentCell.RowIndex).Value = WGeT
        End If
    End Sub

    Private Sub INPUTWARRANTY1YEARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INPUTWARRANTY6YEARToolStripMenuItem.Click, INPUTWARRANTY5YEARToolStripMenuItem.Click, INPUTWARRANTY4YEARToolStripMenuItem.Click, INPUTWARRANTY3YEARToolStripMenuItem.Click, INPUTWARRANTY2YEARToolStripMenuItem.Click, INPUTWARRANTY1YEARToolStripMenuItem.Click
        Dim D As DataGridView = Me.PS_CATEGORY_DISDataGridView
        S = sender.TAG
        D(7, D.CurrentCell.RowIndex).Value = Val(S) * 12
    End Sub

    Private Sub INPUTWARRANTY7ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INPUTWARRANTY7ToolStripMenuItem.Click
        Dim D As DataGridView = Me.PS_CATEGORY_DISDataGridView
        If D.Name = Me.PS_CATEGORY_DISDataGridView.Name Then
            D(7, D.CurrentCell.RowIndex).Value = 6
        End If
    End Sub

    Private Sub CONVERTYEASSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONVERTYEASSToolStripMenuItem.Click
        Dim D As DataGridView = Me.PS_CATEGORY_DISDataGridView
        If D.Name = Me.PS_CATEGORY_DISDataGridView.Name Then
            S = AukF.GridT(D, 7)
            D(7, D.CurrentCell.RowIndex).Value = Val(S) * 12
        End If
    End Sub

    Private Sub CONVERTDAYSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONVERTDAYSToolStripMenuItem.Click
        Dim D As DataGridView = Me.PS_CATEGORY_DISDataGridView
        If D.Name = Me.PS_CATEGORY_DISDataGridView.Name Then
            S = AukF.GridT(D, 7)
            D(7, D.CurrentCell.RowIndex).Value = Val(S) / 30

        End If
    End Sub

    Private Sub REFESHINPUTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFESHINPUTSToolStripMenuItem.Click
        Me.REFRESH_DISPLAY()
    End Sub
    Public Sub Sr_Dis(ByVal Id As String)

        FrmL(Me)

        Dim SID As String
        Dim CIDx As String
        Dim DId As String = Id
        SID = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, Id, 1)
        CIDx = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_SUB_CATEGORY, SID, 2)
        With PRO_ADD2
            DVDRENT.SAMEBP(PS_CATEGORYBindingSource, .PSCATEGORYBindingSource)
            DVDRENT.SAMEBP(PS_SUB_CATEGORYBindingSource, .PSCATEGORYPSSUBCATEGORYBindingSource)
            DVDRENT.SAMEBP(PS_CATEGORY_DISBindingSource, .PSSUBCATEGORYPSCATEGORYDISBindingSource)
        End With

        AukF.BindFilter(Me.PS_CATEGORYBindingSource, 0, CIDx)
        AukF.BindFilter(Me.PS_SUB_CATEGORYBindingSource, 0, SID)
        AukF.BindFilter(Me.PS_CATEGORY_DISBindingSource, 0, DId)
        Me.PS_CATEGORY_DISDataGridView.Focus()
        PS_CATEGORY_DISDataGridView.Dock = DockStyle.Fill
    End Sub
    Public Sub Sr_Sub(ByVal Id As String)

        FrmL(Me)
        Dim SID As String = Id
        Dim CIDx As String
        CIDx = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_SUB_CATEGORY, SID, 2)

        With PRO_ADD2
            DVDRENT.SAMEBP(PS_CATEGORYBindingSource, .PSCATEGORYBindingSource)
            DVDRENT.SAMEBP(PS_SUB_CATEGORYBindingSource, .PSCATEGORYPSSUBCATEGORYBindingSource)
            DVDRENT.SAMEBP(PS_CATEGORY_DISBindingSource, .PSSUBCATEGORYPSCATEGORYDISBindingSource)
        End With

        AukF.BindFilter(Me.PS_CATEGORYBindingSource, 0, CIDx)
        AukF.BindFilter(Me.PS_SUB_CATEGORYBindingSource, 0, SID)

        Me.PS_CATEGORY_DISDataGridView.Visible = False
        Me.PS_CATEGORYDataGridView.Visible = False
        Me.PS_SUB_CATEGORYDataGridView.Focus()
        PS_SUB_CATEGORYDataGridView.Dock = DockStyle.Fill

    End Sub
    Public Sub Sr_Cate(ByVal Id As String)

        FrmL(Me)

        With PRO_ADD2

            DVDRENT.SAMEBP(PS_CATEGORYBindingSource, .PSCATEGORYBindingSource)
            DVDRENT.SAMEBP(PS_SUB_CATEGORYBindingSource, .PSCATEGORYPSSUBCATEGORYBindingSource)
            DVDRENT.SAMEBP(PS_CATEGORY_DISBindingSource, .PSSUBCATEGORYPSCATEGORYDISBindingSource)
        End With

        AukF.BindFilter(Me.PS_CATEGORYBindingSource, "CAtegoryid", Id)
        Me.PS_CATEGORY_DISDataGridView.Visible = False
        Me.PS_SUB_CATEGORYDataGridView.Visible = False
        Me.PS_CATEGORYDataGridView.Focus()
        PS_CATEGORYDataGridView.Dock = DockStyle.Fill
    End Sub
    Private Sub InsertSerialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertSerialToolStripMenuItem.Click
        SoftIn.Serial_Number_Table(Me.AukDatabaseDataSet.PS_CATEGORY_DIS)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.PS_CATEGORYBindingSource.Filter IsNot Nothing OrElse Me.PS_CATEGORY_DISBindingSource.Filter IsNot Nothing OrElse Me.PS_SUB_CATEGORYBindingSource.Filter IsNot Nothing Then
            Me.RemovewFilBut.Visible = True
        Else
            Me.RemovewFilBut.Visible = False
        End If
    End Sub
    Private Sub RemovewFilBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemovewFilBut.Click
        Me.PS_CATEGORYBindingSource.RemoveFilter()
        Me.PS_CATEGORY_DISBindingSource.RemoveFilter()
        Me.PS_SUB_CATEGORYBindingSource.RemoveFilter()
    End Sub
End Class