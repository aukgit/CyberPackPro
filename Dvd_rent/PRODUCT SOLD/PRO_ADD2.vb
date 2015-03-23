Public Class PRO_ADD2
    Public C_PSID As String = ""
    Public HOOK_FR As Boolean = False
    Dim PosChgAuto As Boolean
    Dim TDisBool As Boolean
    Public NeedToVendorRe As Boolean = False
    Dim beDisID As Boolean
    Private Sub PS_CollectionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PS_CollectionBindingNavigatorSaveItem.Click, SAVEToolStripMenuItem.Click
        Try
            Me.Validate()
            Me.PS_CollectionBindingSource.EndEdit()
            Me.PS_CollectionTableAdapter.Update(Me.AukDatabaseDataSet.PS_Collection)
            If PS_SOLD.Visible = True Then
                PS_SOLD.NeedtoRe_proAdd = True
            End If
        Catch ex As Exception
            If Me.PRODUCT_SERIALTextBox.Text = "" Then
                Me.PRODUCT_SERIALTextBox.Focus()
            Else
                Epx()
            End If
        End Try
        If C_PSID <> "" Then
            If PS_SOLD.Created = True And PS_SOLD.Visible = True Then
                PS_SOLD.LOAD_ONLY_CUR(C_PSID)
                FrmL(PS_SOLD)
                Me.Close()
            End If
        End If
    End Sub
    Public Function LOAD_BY_PS(ByVal SID As String)
        'SFC("PRODUCT_SERIAL")
        'STC(SID)
        'AukF.Db_LoadN(Me.PS_CollectionBindingSource)
        AukF.BindFind(Me.PS_CollectionBindingSource, "product_serial", SID, True)

        'If Me.PS_CollectionBindingSource.Count > 0 Then FrmL(Me) : C_PSID = SID
        'Me.PRODUCT_SERIALTextBox.ReadOnly = True
    End Function
    Public Function PS_POS_CHG()
        PosChgAuto = True
        Dim Sn, DnV, dISn As String
        'Dim RNX As DataRowCollection

        If Me.DISPLAY_IDTextBox.Text = "" Then Exit Function
        SC = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, Me.DISPLAY_IDTextBox.Text, 1)
        DnV = RowX(2)
        dISn = RowX(3)
        C = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_SUB_CATEGORY, SC, 2)
        Sn = RowX(1)
        If C <> "" Then
            If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.PS_CATEGORY, C) Then
                AukF.SelectIndexFromObject(Me.ComboBox1, ComRow)
            End If
        End If
        AukF.FindInObjectAndSelect(Me.ComboBox2, Sn, True, True, True)
        AukF.FindInObjectAndSelect(Me.ComboBox3, DnV, True, True, True)
        Me.Label5.Text = dISn 'If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.PS_SUB_CATEGORY, SC) Then"
        PosChgAuto = False
    End Function

    Private Sub PRO_ADD2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If NeedToVendorRe = True Then
            Me.VENDORTableAdapter.Fill(Me.AukDatabaseDataSet.VENDOR)
            NeedToVendorRe = False
        End If
    End Sub

    Private Sub PRO_ADD2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If My.Settings.Dont_RefreshData = True Then
        '    'MsgBox(TrTb.Rows(0).Item(0).ToString)
        '    If Me.AukDatabaseDataSet.PS_Collection.Rows.Count >= 2500 Then
        '        e.Cancel = True
        '        Me.Hide()
        '        'Exit Sub
        '    End If
        'End If
        If Me.HOOK_FR = True Then Me.PS_CollectionBindingSource.Filter = "PLACE='INSTORE'"
        If SoftIn.GetChages(Me.AukDatabaseDataSet.PS_Collection) = True Then
            If SAVMSG() = 1 Then
                PS_CollectionBindingNavigatorSaveItem_Click(sender, e)
            ElseIf SavInt = 2 Then
                e.Cancel = True
            End If
        End If
   
    End Sub
    Private Sub PRO_ADD2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.VENDOR' table. You can move, or remove it, as needed.
        Me.VENDORTableAdapter.Fill(Me.AukDatabaseDataSet.VENDOR)
        If Me.HOOK_FR = False Then
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CATEGORY, -1, "", False, 0, "CATEGORY", False, 0, Val(My.Settings.MaximumData_load))
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SUB_CATEGORY, -1, "", False, 0, "SUB_CATEGORY_NAME", False, 0, Val(My.Settings.MaximumData_load))
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, -1, "", False, 0, "[DISPLAY ID]", False, 0, Val(My.Settings.MaximumData_load))
            If My.Settings.DataLoad_view = False Then
                If My.Settings.PS_LASTL_ADDINGNEW = True Then
                    ADSRC.Load_Only_LastRecord(Me.AukDatabaseDataSet.PS_Collection)
                Else
                    SFC("Place")
                    STC("instore")
                    AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_Collection, -1, "", False, 0, "", False, 0, Val(My.Settings.MaximumData_load))
                End If
            End If
            Me.OptionsTableAdapter1.Fill(Me.AukDatabaseDataSet.Options)
        End If
        PosChgAuto = True
        PS_POS_CHG()
        PosChgAuto = False
        AukF.ComSelIndex(Me.V_IDComboBox)
        'Me.PS_CollectionTableAdapter.Fill(Me.AukDatabaseDataSet.PS_Collection)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click, ADDNEWToolStripMenuItem.Click
        ADD_N_FUNC()
        Me.TxBoxEna()
    End Sub

    Private Sub CHG_INDEX(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged, ComboBox2.SelectedIndexChanged, ComboBox1.SelectedIndexChanged
        On Error Resume Next
        If PosChgAuto = False Then
            Me.DISPLAY_IDTextBox.Text = Me.ComboBox3.SelectedValue.ToString
            Me.PURCHASE_COSTTextBox.Text = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, Me.DISPLAY_IDTextBox.Text, 4) 'purchase cost
            Me.BENEFIT_SOLD_COSTTextBox.Text = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, Me.DISPLAY_IDTextBox.Text, 5) 'benefit cost
        End If

        Me.Label5.Text = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, Me.DISPLAY_IDTextBox.Text, 3)

    End Sub

  
    Private Sub ADDNEWCATEGORIESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDNEWCATEGORIESToolStripMenuItem.Click
        'DVDRENT.LOAD_FORMS(18)
        With PCATE
            'Me.Visible = False
            .AukDatabaseDataSet = Me.AukDatabaseDataSet
            SAMEBP(.PS_CATEGORYBindingSource, Me.PSCATEGORYBindingSource)
            SAMEBP(.PS_SUB_CATEGORYBindingSource, Me.PSCATEGORYPSSUBCATEGORYBindingSource)
            SAMEBP(.PS_CATEGORY_DISBindingSource, Me.PSSUBCATEGORYPSCATEGORYDISBindingSource)
            FrmL(PCATE)
        End With
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click, DELETEToolStripMenuItem.Click

    End Sub


    Private Sub SAMEINPUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAMEINPUTToolStripMenuItem.Click
        If PRODUCT_SERIALTextBox.Text.Trim = "" Then
            MsgBox("PLEASE TYPE PRODUCT SERIAL, SUCH AS IME/SIM/ID FOR IDENTITY OF SPECIFIC PRODUCTS/GOODS.", MsgBoxStyle.Critical)
            Me.PRODUCT_SERIALTextBox.Focus()
        End If
        RowX = ADSRC.FIND_FROM_DATATABLE(Me.AukDatabaseDataSet.PS_Collection, Me.PRODUCT_SERIALTextBox.Text, 4)
        DISC = (ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, Me.DISPLAY_IDTextBox.Text, 3))
        INPUTX = SoftIn.Same_input_Box("PLEASE TYPE IME/SIM/GOODS SERIAL TO ATTRIBUTE SAME QUALITY IN THEIR SPECIFIC ")
        SoftIn.Same_Input(RowX, 0, INPUTX, "1", DISC & " # ", True)
    End Sub

    Private Sub PRODUCT_SERIALTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCT_SERIALTextBox.Leave
        SoftIn.LOST_FOCUS_NEVER_NULL(sender, e, Me.PS_CollectionBindingSource, True)
    End Sub

    Private Sub KEY_DOWNEVT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PURCHASE_DATEDateTimePicker.KeyDown, PRODUCT_SERIALTextBox.KeyDown, PLACETextBox.KeyDown, DISPLAY_IDTextBox.KeyDown, ComboBox3.KeyDown, ComboBox2.KeyDown, ComboBox1.KeyDown, CheckBox3.KeyDown, CheckBox2.KeyDown, CheckBox1.KeyDown
        SoftIn.KEY_DOWN_EVENTS_NESTED(sender, e, Me.PS_CollectionBindingSource, Me.PRODUCT_SERIALTextBox, Me.DISPLAY_IDTextBox.Name.ToString, Me.CheckBox1.Checked, True, True, True)
    End Sub
    Public Sub ADD_N_FUNC()
        'Dim aX As Integer
        Dim BeforeRowID As String = Me.PRODUCT_SERIALTextBox.Text
        Dim DisID As String = Me.DISPLAY_IDTextBox.Text
        Dim VENDORIN As Integer = Me.V_IDComboBox.SelectedIndex
        'BindingNavigatorAddNewItem_Click(ME.BindingNavigatorAddNewItem ,)
        If Me.PRODUCT_SERIALTextBox.Text = "" And My.Settings.AUTOMAIC_PRODUT_NAME = True Then
            Me.PRODUCT_SERIALTextBox.Text = Mid(SoftIn.Convert_Hash_RND1(Now.Date.ToLongDateString & Now.Second).Replace(CChar("/"), "").ToUpper, 1, 8)
        End If
        Try
            'Me.Validate()
            'MsgBox("called")

            Me.PS_CollectionBindingSource.AddNew()
            Me.PURCHASE_DATEDateTimePicker.Value = Now.Date
            Me.PRODUCT_SERIALTextBox.Focus()
            Me.PLACETextBox.Text = "INSTORE"
            'MsgBox(Me.PLACETextBox.Text)
            'If Me.PS_CollectionBindingSource.Count > 0 And Me.PS_CollectionBindingSource.Position >= 1 Then
            '    aX = PS_CollectionBindingSource.Position - 1
            '    If aX > -1 Then Me.DISPLAY_IDTextBox.Text = Me.AukDatabaseDataSet.PS_Collection(aX).Item("DISPLAY_ID").ToString
            'End If
            Me.DISPLAY_IDTextBox.Text = DisID

            If Me.PRODUCT_SERIALTextBox.Text = "" And My.Settings.AUTOMAIC_PRODUT_NAME = True Then
                Me.PRODUCT_SERIALTextBox.Text = Mid(SoftIn.Convert_Hash_RND1(Now.Date.ToLongDateString & Now.Second).Replace(CChar("/"), "").ToUpper, 1, 8)
            End If
            'setting prodcut cost and benifit
            'If PosChgAuto = False Then
            'Me.DISPLAY_IDTextBox.Text = Me.ComboBox3.SelectedValue.ToString
            ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_Collection, BeforeRowID, 4)
            Me.PURCHASE_COSTTextBox.Text = Val(WGeT) 'purchase cost
            Me.BENEFIT_SOLD_COSTTextBox.Text = Val(RowX.Item(5)) 'benefit cost
            'End If
     

            Me.Label5.Text = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, Me.DISPLAY_IDTextBox.Text, 3)
            Try
                If VENDORIN > -1 Then
                    Me.V_IDComboBox.SelectedIndex = VENDORIN
                    'MsgBox(Me.V_IDComboBox.SelectedIndex)
                End If
                'auto select vendor list id
                'If VENDORIN = -1 AndAlso Me.V_IDComboBox.Items.Count > 0 Then
                '    Me.V_IDComboBox.SelectedIndex = 0
                'End If

            Catch ex As Exception
                MsgBox("SORRY CAN'T SELECT VENDORS LIST", MsgBoxStyle.Critical)
            End Try
            Me.Validate()
        Catch ex As Exception
            If Me.PRODUCT_SERIALTextBox.Text = "" Then
                MsgBox("PLEASE TYPE PRODUCT/GOOD SERIAL SUCH AS SIM/IME/ID ETC", MsgBoxStyle.Critical)
                Me.PRODUCT_SERIALTextBox.Focus()
            End If
        End Try
   
    End Sub

    Private Sub REFRESHCHANGESOFNEWCATEGORIESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHCHANGESOFNEWCATEGORIESToolStripMenuItem.Click
        A = Me.DISPLAY_IDTextBox.Text
        Me.PS_CATEGORYTableAdapter.Fill(Me.AukDatabaseDataSet.PS_CATEGORY)
        Me.PS_SUB_CATEGORYTableAdapter.Fill(Me.AukDatabaseDataSet.PS_SUB_CATEGORY)
        Me.PS_CATEGORY_DISTableAdapter.Fill(Me.AukDatabaseDataSet.PS_CATEGORY_DIS)
        Me.OptionsTableAdapter1.Fill(Me.AukDatabaseDataSet.Options)
        Me.DISPLAY_IDTextBox.Text = A

        PS_POS_CHG()

    End Sub

    Private Sub LOADWHOLEDATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADWHOLEDATAToolStripMenuItem.Click
        On Error Resume Next
        A = Me.DISPLAY_IDTextBox.Text
        Me.PS_CATEGORYTableAdapter.Fill(Me.AukDatabaseDataSet.PS_CATEGORY)
        Me.PS_SUB_CATEGORYTableAdapter.Fill(Me.AukDatabaseDataSet.PS_SUB_CATEGORY)
        Me.PS_CATEGORY_DISTableAdapter.Fill(Me.AukDatabaseDataSet.PS_CATEGORY_DIS)
        Me.PS_CollectionTableAdapter.Fill(Me.AukDatabaseDataSet.PS_Collection)
        Me.OptionsTableAdapter1.Fill(Me.AukDatabaseDataSet.Options)

        Me.DISPLAY_IDTextBox.Text = A
        PS_POS_CHG()
        Me.Label5.Text = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, Me.DISPLAY_IDTextBox.Text, 3)

    End Sub

    Private Sub ToolStripTextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        ADSRC.TWICE_EXE(sender, e, Me.PS_CollectionBindingSource, "PRODUCT_SERIAL", "PRODUCT_NAME", True)

    End Sub
    Private Sub ToolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.TextChanged
        ADSRC.TWICE_BINDFIND(Me.PS_CollectionBindingSource, "PRODUCT_SERIAL", "PRODUCT_NAME", sender.TEXT)
    End Sub
    Private Sub PS_CollectionBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PS_CollectionBindingSource.PositionChanged
        PosChgAuto = True
        PS_POS_CHG()
        PosChgAuto = False
    End Sub
    Private Sub TxBoxDis()
        Dim ConsControl = Me.Controls
        If TDisBool = False Then
            For K As Integer = 0 To ConsControl.Count - 1
                If TypeOf ConsControl.Item(K) Is TextBox Then
                    Dim T As TextBox = ConsControl.Item(K)
                    T.Enabled = False
                End If
            Next
            TDisBool = True
        End If
    End Sub
    Private Sub TxBoxEna()
        Dim ConsControl = Me.Controls
        If TDisBool = True Then
            For K As Integer = 0 To ConsControl.Count - 1
                If TypeOf ConsControl.Item(K) Is TextBox Then
                    Dim T As TextBox = ConsControl.Item(K)
                    T.Enabled = True
                End If
            Next
            TDisBool = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.V_IDComboBox.SelectedIndex = -1 Then
            Me.V_IDComboBox.BackColor = Color.Red
        Else
            Me.V_IDComboBox.BackColor = Color.Azure
        End If
        If Me.ALWAYSSHOWBLACKCOLORINNULLToolStripMenuItem.Checked = True Then
            SoftIn.TxtColor(Me.PRODUCT_SERIALTextBox, "", Color.Red, Color.White, Color.Azure, Color.Black)
            'SoftIn.TxtColor(Me.PRODUCT_NAMETextBox, "", Color.Black, Color.White, Color.Azure, Color.Black)
            SoftIn.TxtColor(Me.PLACETextBox, "", Color.Black, Color.White, Color.Azure, Color.Black)
            'SoftIn.TxtColor_NumberDefine(Me.PURCHASE_COSTTextBox, 0, Color.Black, Color.Azure, Color.Azure, Color.Black, "le")
            'SoftIn.TxtColor_NumberDefine(Me.BENEFIT_SOLD_COSTTextBox, 0, Color.Black, Color.Azure, Color.Azure, Color.Black, "le")
            SoftIn.TxtColor(Me.DISPLAY_IDTextBox, "", Color.Red, Color.White, Color.Azure, Color.Black)
        End If
        If Me.CheckBox2.Checked = True Then
            'SoftIn.Previous_data_input(Me.PS_CollectionBindingSource, Me.AukDatabaseDataSet.PS_Collection)
            'SoftIn.Previous_data_input(Me.PS_CollectionBindingSource, Me.AukDatabaseDataSet.PS_Collection, 1)
            SoftIn.Previous_data_input(Me.PS_CollectionBindingSource, Me.AukDatabaseDataSet.PS_Collection, 2)
            SoftIn.Previous_data_input(Me.PS_CollectionBindingSource, Me.AukDatabaseDataSet.PS_Collection, 3)
            SoftIn.Previous_data_input(Me.PS_CollectionBindingSource, Me.AukDatabaseDataSet.PS_Collection, 6)
            'Me.PS_POS_CHG()
            'If Me.PURCHASE_COSTTextBox.Focused = False And Me.BENEFIT_SOLD_COSTTextBox.Focused = False Then CHG_INDEX(sender, e)
            'If Val(Me.PURCHASE_COSTTextBox.Text) = 0 Then
            '    If Me.PURCHASE_COSTTextBox.Focused = False And Me.BENEFIT_SOLD_COSTTextBox.Focused = False Then
            '        SoftIn.Previous_data_input(Me.PS_CollectionBindingSource, Me.AukDatabaseDataSet.PS_Collection, 4)
            '        SoftIn.Previous_data_input(Me.PS_CollectionBindingSource, Me.AukDatabaseDataSet.PS_Collection, 5)
            '    End If
            'End If
        End If
        If Me.CheckBox3.Checked = True Then
            DISC = (ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, Me.DISPLAY_IDTextBox.Text, 3))
            'If disc <> "" And Me.PRODUCT_SERIALTextBox.Text <> "" Then Me.PRODUCT_NAMETextBox.Text = disc & " # " & Me.PRODUCT_SERIALTextBox.Text
        End If

        If Me.PS_CollectionBindingSource.Count = 0 And TDisBool = False Then
            TxBoxDis()
        ElseIf Me.PS_CollectionBindingSource.Count > 0 And TDisBool = True Then
            TxBoxEna()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ADSRC.Twice_Q(Me.PS_CollectionBindingSource, "PRODUCT_SERIAL", "PRODUCT_NAME", ToolStripTextBox2.Text, True)

    End Sub

    Private Sub SEARCHONLYINBETWEENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHONLYINBETWEENToolStripMenuItem.Click
        FIND_BETWEEN.BP = Me.PS_CollectionBindingSource
        FrmL(FIND_BETWEEN)
        'FIND_BETWEEN.ADD_COLUMNS = "*"
    End Sub

    Private Sub SAVE_DIRECT(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PURCHASE_DATEDateTimePicker.Validated, PRODUCT_SERIALTextBox.Validated, PLACETextBox.Validated, DISPLAY_IDTextBox.Validated
        If My.Settings.DIRECT_SAVE = True Then PS_CollectionBindingNavigatorSaveItem_Click(sender, e)
    End Sub

    Private Sub REFRESHCHANGESCURRENTDATABASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHCHANGESCURRENTDATABASEToolStripMenuItem.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.PS_CollectionBindingSource, True)

    End Sub

    Private Sub REFRESHCHANGESCURRENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHCHANGESCURRENTToolStripMenuItem.Click
        AukF.Single_DataRecordRefresh(Me.PS_CollectionBindingSource, True)

    End Sub

    Private Sub LOADToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADToolStripMenuItem.Click
        SFC("PURCHASE_DATE")
        STC(CDate(ToolStripTextBox1.Text))
        DTC("D")
        AukF.Db_LoadN(Me.PS_CollectionBindingSource, "*", "", False)
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then LOADToolStripMenuItem_Click(sender, e)

    End Sub

    Private Sub SEARCHQUERYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHQUERYToolStripMenuItem.Click, ToolStripSplitButton1.ButtonClick
        AukQ.Bnp = Me.PS_CollectionBindingSource
        FrmL(AukQ)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click, PRINTPREVIEWToolStripMenuItem.Click
        Dim M As New PS_COL_REPORT
        AukF.Prnt(M, Me.AukDatabaseDataSet, Me.PS_CollectionBindingSource)

    End Sub
    Private Sub PS_CollectionBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PS_CollectionBindingNavigator.RefreshItems
        If Me.PRODUCT_SERIALTextBox.Text = "" Then
            PRODUCT_SERIALTextBox.Focus()
        End If
    End Sub
    Private Sub LOADONLYSTOCKPRODUCTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADONLYSTOCKPRODUCTSToolStripMenuItem.Click
        SFC("PLACE")
        STC("INSTORE")
        AukF.Db_LoadN(Me.PS_CollectionBindingSource, -1, "", True, 0, "", False, 0, Val(My.Settings.MaximumData_load))
        Me.Label5.Text = ADSRC.FIND_FROM_DATATABLE_STR(Me.AukDatabaseDataSet.PS_CATEGORY_DIS, Me.DISPLAY_IDTextBox.Text, 3)

    End Sub

    Private Sub ADDINCURRENTMODELSSERIALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDINCURRENTMODELSSERIALToolStripMenuItem.Click
        Dim UA As Array
        Dim iNPUTX As String
        Dim S, ENDX As Integer
        Dim SPSTR As String
        Dim MODeL, DisID As String
        iNPUTX = InputBox("PLEASE (MODEL OR NAME OR NOTHING -TO GET FROM DISPLAY NAME),START;END ENTRY", "INSERT MODEL ID", iNPUTX)
        If InStr(iNPUTX, ",") > 0 Then
            SPSTR = ",;"
            UA = iNPUTX.Split(SPSTR.ToCharArray)
            MODeL = UA.GetValue(0).ToString
            S = Val(UA.GetValue(1).ToString)
            ENDX = Val(UA.GetValue(2).ToString)
        Else
            UA = iNPUTX.Split(CChar("-"))
            MODeL = Me.ComboBox3.SelectedText.ToString
            S = Val(UA.GetValue(0).ToString)
            ENDX = Val(UA.GetValue(1).ToString)
        End If
        DisID = Me.ComboBox3.SelectedValue.ToString

        For K As Integer = S To ENDX
            RowX = Me.AukDatabaseDataSet.PS_Collection.NewRow
            RowX(0) = MODeL & "(" & K & ")"
            RowX(2) = "INSTORE"
            RowX(6) = DisID
            RowX(3) = CDate(Now.Date)
            RowX(6) = DisID
            RowX.Table.Rows.Add(RowX)

        Next

    End Sub

    Private Sub BYCURRENTDISPLAYNAMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BYCURRENTDISPLAYNAMEToolStripMenuItem.Click
        SFC("DISPLAY ID")
        STC(Me.ComboBox3.SelectedValue.ToString)
        AukF.Db_LoadN(Me.PS_CollectionBindingSource, -1, "", False)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PCATE.Sr_Cate(Me.ComboBox1.SelectedValue)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PCATE.Sr_Dis(Me.ComboBox3.SelectedValue)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PCATE.Sr_Sub(Me.ComboBox2.SelectedValue)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FrmL(Vendor)
        AukF.BindFind(Vendor.VENDORBindingSource, "V_ID", Me.V_IDComboBox.SelectedValue, True)
    End Sub


End Class