<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRO_ADD2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim PRODUCT_SERIALLabel As System.Windows.Forms.Label
        Dim PLACELabel As System.Windows.Forms.Label
        Dim PURCHASE_DATELabel As System.Windows.Forms.Label
        Dim DISPLAY_IDLabel As System.Windows.Forms.Label
        Dim V_IDLabel As System.Windows.Forms.Label
        Dim PURCHASE_COSTLabel As System.Windows.Forms.Label
        Dim BENEFIT_SOLD_COSTLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRO_ADD2))
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.PS_CollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PS_CollectionTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CollectionTableAdapter
        Me.PS_CollectionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripDropDownButton
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADDNEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.SAMEINPUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.PRINTPREVIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ADDNEWCATEGORIESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REFRESHCHANGESOFNEWCATEGORIESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ADDINCURRENTMODELSSERIALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.ALWAYSSHOWBLACKCOLORINNULLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.REFRESHCHANGESCURRENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REFRESHCHANGESCURRENTDATABASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.SETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.PS_CollectionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PRODUCT_SERIALTextBox = New System.Windows.Forms.TextBox
        Me.PLACETextBox = New System.Windows.Forms.TextBox
        Me.PURCHASE_DATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.DISPLAY_IDTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.PSSUBCATEGORYPSCATEGORYDISBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PSCATEGORYPSSUBCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PSCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.SEARCHQUERYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PURCHASEPRODUCTDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.LOADToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SEARCHONLYINBETWEENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BYCURRENTDISPLAYNAMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOADWHOLEDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOADONLYSTOCKPRODUCTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.PS_CATEGORYTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CATEGORYTableAdapter
        Me.PS_SUB_CATEGORYTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_SUB_CATEGORYTableAdapter
        Me.PS_CATEGORY_DISTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CATEGORY_DISTableAdapter
        Me.Label4 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OptionsTableAdapter1 = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.OptionsTableAdapter
        Me.V_IDComboBox = New System.Windows.Forms.ComboBox
        Me.VENDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENDORTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.VENDORTableAdapter
        Me.PURCHASE_COSTTextBox = New System.Windows.Forms.TextBox
        Me.BENEFIT_SOLD_COSTTextBox = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        PRODUCT_SERIALLabel = New System.Windows.Forms.Label
        PLACELabel = New System.Windows.Forms.Label
        PURCHASE_DATELabel = New System.Windows.Forms.Label
        DISPLAY_IDLabel = New System.Windows.Forms.Label
        V_IDLabel = New System.Windows.Forms.Label
        PURCHASE_COSTLabel = New System.Windows.Forms.Label
        BENEFIT_SOLD_COSTLabel = New System.Windows.Forms.Label
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS_CollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS_CollectionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PS_CollectionBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PSSUBCATEGORYPSCATEGORYDISBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSCATEGORYPSSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.VENDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRODUCT_SERIALLabel
        '
        PRODUCT_SERIALLabel.AutoSize = True
        PRODUCT_SERIALLabel.BackColor = System.Drawing.Color.Transparent
        PRODUCT_SERIALLabel.Location = New System.Drawing.Point(10, 62)
        PRODUCT_SERIALLabel.Name = "PRODUCT_SERIALLabel"
        PRODUCT_SERIALLabel.Size = New System.Drawing.Size(100, 15)
        PRODUCT_SERIALLabel.TabIndex = 1
        PRODUCT_SERIALLabel.Text = "PRODUCT SERIAL:"
        '
        'PLACELabel
        '
        PLACELabel.AutoSize = True
        PLACELabel.BackColor = System.Drawing.Color.Transparent
        PLACELabel.Location = New System.Drawing.Point(10, 93)
        PLACELabel.Name = "PLACELabel"
        PLACELabel.Size = New System.Drawing.Size(42, 15)
        PLACELabel.TabIndex = 5
        PLACELabel.Text = "PLACE:"
        '
        'PURCHASE_DATELabel
        '
        PURCHASE_DATELabel.AutoSize = True
        PURCHASE_DATELabel.BackColor = System.Drawing.Color.Transparent
        PURCHASE_DATELabel.Location = New System.Drawing.Point(10, 186)
        PURCHASE_DATELabel.Name = "PURCHASE_DATELabel"
        PURCHASE_DATELabel.Size = New System.Drawing.Size(96, 15)
        PURCHASE_DATELabel.TabIndex = 7
        PURCHASE_DATELabel.Text = "PURCHASE DATE:"
        '
        'DISPLAY_IDLabel
        '
        DISPLAY_IDLabel.AutoSize = True
        DISPLAY_IDLabel.BackColor = System.Drawing.Color.Transparent
        DISPLAY_IDLabel.Location = New System.Drawing.Point(10, 217)
        DISPLAY_IDLabel.Name = "DISPLAY_IDLabel"
        DISPLAY_IDLabel.Size = New System.Drawing.Size(68, 15)
        DISPLAY_IDLabel.TabIndex = 13
        DISPLAY_IDLabel.Text = "DISPLAY ID:"
        '
        'V_IDLabel
        '
        V_IDLabel.AutoSize = True
        V_IDLabel.BackColor = System.Drawing.Color.Transparent
        V_IDLabel.Location = New System.Drawing.Point(10, 248)
        V_IDLabel.Name = "V_IDLabel"
        V_IDLabel.Size = New System.Drawing.Size(90, 15)
        V_IDLabel.TabIndex = 20
        V_IDLabel.Text = "VENDOR NAME:"
        '
        'PURCHASE_COSTLabel
        '
        PURCHASE_COSTLabel.AutoSize = True
        PURCHASE_COSTLabel.BackColor = System.Drawing.Color.Transparent
        PURCHASE_COSTLabel.Location = New System.Drawing.Point(10, 124)
        PURCHASE_COSTLabel.Name = "PURCHASE_COSTLabel"
        PURCHASE_COSTLabel.Size = New System.Drawing.Size(97, 15)
        PURCHASE_COSTLabel.TabIndex = 21
        PURCHASE_COSTLabel.Text = "PURCHASE COST:"
        '
        'BENEFIT_SOLD_COSTLabel
        '
        BENEFIT_SOLD_COSTLabel.AutoSize = True
        BENEFIT_SOLD_COSTLabel.BackColor = System.Drawing.Color.Transparent
        BENEFIT_SOLD_COSTLabel.Location = New System.Drawing.Point(10, 155)
        BENEFIT_SOLD_COSTLabel.Name = "BENEFIT_SOLD_COSTLabel"
        BENEFIT_SOLD_COSTLabel.Size = New System.Drawing.Size(115, 15)
        BENEFIT_SOLD_COSTLabel.TabIndex = 22
        BENEFIT_SOLD_COSTLabel.Text = "BENEFIT SOLD COST:"
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PS_CollectionBindingSource
        '
        Me.PS_CollectionBindingSource.DataMember = "PS_Collection"
        Me.PS_CollectionBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'PS_CollectionTableAdapter
        '
        Me.PS_CollectionTableAdapter.ClearBeforeFill = True
        '
        'PS_CollectionBindingNavigator
        '
        Me.PS_CollectionBindingNavigator.AddNewItem = Nothing
        Me.PS_CollectionBindingNavigator.BackgroundImage = CType(resources.GetObject("PS_CollectionBindingNavigator.BackgroundImage"), System.Drawing.Image)
        Me.PS_CollectionBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PS_CollectionBindingNavigator.BindingSource = Me.PS_CollectionBindingSource
        Me.PS_CollectionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PS_CollectionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PS_CollectionBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PS_CollectionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripSeparator3, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PS_CollectionBindingNavigatorSaveItem})
        Me.PS_CollectionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PS_CollectionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PS_CollectionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PS_CollectionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PS_CollectionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PS_CollectionBindingNavigator.Name = "PS_CollectionBindingNavigator"
        Me.PS_CollectionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PS_CollectionBindingNavigator.Size = New System.Drawing.Size(530, 25)
        Me.PS_CollectionBindingNavigator.TabIndex = 0
        Me.PS_CollectionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(58, 22)
        Me.BindingNavigatorDeleteItem.Text = "&Delete"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SAVEToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.ADDNEWToolStripMenuItem, Me.ToolStripSeparator7, Me.SAMEINPUTToolStripMenuItem, Me.ToolStripSeparator6, Me.PRINTPREVIEWToolStripMenuItem, Me.ToolStripSeparator5, Me.ADDNEWCATEGORIESToolStripMenuItem, Me.REFRESHCHANGESOFNEWCATEGORIESToolStripMenuItem, Me.ToolStripSeparator8, Me.ADDINCURRENTMODELSSERIALToolStripMenuItem, Me.ToolStripSeparator9, Me.ALWAYSSHOWBLACKCOLORINNULLToolStripMenuItem, Me.ToolStripSeparator4, Me.REFRESHCHANGESCURRENTToolStripMenuItem, Me.REFRESHCHANGESCURRENTDATABASEToolStripMenuItem, Me.ToolStripSeparator10, Me.SETTINGSToolStripMenuItem})
        Me.ToolStripButton3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton3.Text = "MENU"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.saveHS
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.ShortcutKeyDisplayString = "Alt+S or Ctrl+S"
        Me.SAVEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.SAVEToolStripMenuItem.Text = "SAVE DATA"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Image = CType(resources.GetObject("DELETEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.ShortcutKeyDisplayString = "Alt+D"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE DATA"
        '
        'ADDNEWToolStripMenuItem
        '
        Me.ADDNEWToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DataContainer_NewRecordHS
        Me.ADDNEWToolStripMenuItem.Name = "ADDNEWToolStripMenuItem"
        Me.ADDNEWToolStripMenuItem.ShortcutKeyDisplayString = "Alt+A"
        Me.ADDNEWToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.ADDNEWToolStripMenuItem.Text = "ADD NEW"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(356, 6)
        '
        'SAMEINPUTToolStripMenuItem
        '
        Me.SAMEINPUTToolStripMenuItem.Name = "SAMEINPUTToolStripMenuItem"
        Me.SAMEINPUTToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAMEINPUTToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.SAMEINPUTToolStripMenuItem.Text = "SAME INPUT"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(356, 6)
        '
        'PRINTPREVIEWToolStripMenuItem
        '
        Me.PRINTPREVIEWToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.Resources.Printer
        Me.PRINTPREVIEWToolStripMenuItem.Name = "PRINTPREVIEWToolStripMenuItem"
        Me.PRINTPREVIEWToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PRINTPREVIEWToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.PRINTPREVIEWToolStripMenuItem.Text = "PRINT PREVIEW"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(356, 6)
        '
        'ADDNEWCATEGORIESToolStripMenuItem
        '
        Me.ADDNEWCATEGORIESToolStripMenuItem.Name = "ADDNEWCATEGORIESToolStripMenuItem"
        Me.ADDNEWCATEGORIESToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ADDNEWCATEGORIESToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.ADDNEWCATEGORIESToolStripMenuItem.Text = "ADD NEW CATEGORIES"
        '
        'REFRESHCHANGESOFNEWCATEGORIESToolStripMenuItem
        '
        Me.REFRESHCHANGESOFNEWCATEGORIESToolStripMenuItem.Name = "REFRESHCHANGESOFNEWCATEGORIESToolStripMenuItem"
        Me.REFRESHCHANGESOFNEWCATEGORIESToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.REFRESHCHANGESOFNEWCATEGORIESToolStripMenuItem.Text = "REFRESH CHANGES OF NEW CATEGORIES"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(356, 6)
        '
        'ADDINCURRENTMODELSSERIALToolStripMenuItem
        '
        Me.ADDINCURRENTMODELSSERIALToolStripMenuItem.Name = "ADDINCURRENTMODELSSERIALToolStripMenuItem"
        Me.ADDINCURRENTMODELSSERIALToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ADDINCURRENTMODELSSERIALToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.ADDINCURRENTMODELSSERIALToolStripMenuItem.Text = "ADD IN CURRENT MODELS SERIAL"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(356, 6)
        '
        'ALWAYSSHOWBLACKCOLORINNULLToolStripMenuItem
        '
        Me.ALWAYSSHOWBLACKCOLORINNULLToolStripMenuItem.Checked = True
        Me.ALWAYSSHOWBLACKCOLORINNULLToolStripMenuItem.CheckOnClick = True
        Me.ALWAYSSHOWBLACKCOLORINNULLToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ALWAYSSHOWBLACKCOLORINNULLToolStripMenuItem.Name = "ALWAYSSHOWBLACKCOLORINNULLToolStripMenuItem"
        Me.ALWAYSSHOWBLACKCOLORINNULLToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.ALWAYSSHOWBLACKCOLORINNULLToolStripMenuItem.Text = "ALWAYS SHOW BLACK COLOR IN NULL"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(356, 6)
        '
        'REFRESHCHANGESCURRENTToolStripMenuItem
        '
        Me.REFRESHCHANGESCURRENTToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.RepeatHS
        Me.REFRESHCHANGESCURRENTToolStripMenuItem.Name = "REFRESHCHANGESCURRENTToolStripMenuItem"
        Me.REFRESHCHANGESCURRENTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.REFRESHCHANGESCURRENTToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.REFRESHCHANGESCURRENTToolStripMenuItem.Text = "REFRESH CHANGES CURRENT"
        '
        'REFRESHCHANGESCURRENTDATABASEToolStripMenuItem
        '
        Me.REFRESHCHANGESCURRENTDATABASEToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.RepeatHS
        Me.REFRESHCHANGESCURRENTDATABASEToolStripMenuItem.Name = "REFRESHCHANGESCURRENTDATABASEToolStripMenuItem"
        Me.REFRESHCHANGESCURRENTDATABASEToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.REFRESHCHANGESCURRENTDATABASEToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.REFRESHCHANGESCURRENTDATABASEToolStripMenuItem.Text = "REFRESH CHANGES CURRENT DATABASE"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(356, 6)
        '
        'SETTINGSToolStripMenuItem
        '
        Me.SETTINGSToolStripMenuItem.Name = "SETTINGSToolStripMenuItem"
        Me.SETTINGSToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.SETTINGSToolStripMenuItem.Text = "SETTINGS"
        Me.SETTINGSToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(69, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add new"
        '
        'PS_CollectionBindingNavigatorSaveItem
        '
        Me.PS_CollectionBindingNavigatorSaveItem.Image = CType(resources.GetObject("PS_CollectionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PS_CollectionBindingNavigatorSaveItem.Name = "PS_CollectionBindingNavigatorSaveItem"
        Me.PS_CollectionBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.PS_CollectionBindingNavigatorSaveItem.Text = "&Save Data"
        '
        'PRODUCT_SERIALTextBox
        '
        Me.PRODUCT_SERIALTextBox.BackColor = System.Drawing.Color.Azure
        Me.PRODUCT_SERIALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PS_CollectionBindingSource, "PRODUCT_SERIAL", True))
        Me.PRODUCT_SERIALTextBox.Location = New System.Drawing.Point(127, 59)
        Me.PRODUCT_SERIALTextBox.Name = "PRODUCT_SERIALTextBox"
        Me.PRODUCT_SERIALTextBox.Size = New System.Drawing.Size(378, 23)
        Me.PRODUCT_SERIALTextBox.TabIndex = 0
        Me.PRODUCT_SERIALTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.PRODUCT_SERIALTextBox, "PLEASE TYPE PRODUCT SERIAL SUCH AS ,IF IT'S A MOBILE THEN TYPE ITS 'IME' NUMBER ," & _
                "IF ITS A SIM THEN TYPE 'SIM NUMBER' ETC")
        '
        'PLACETextBox
        '
        Me.PLACETextBox.AutoCompleteCustomSource.AddRange(New String() {"INSTORE", "LOST", "BROKEN", "SOLD"})
        Me.PLACETextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PLACETextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.PLACETextBox.BackColor = System.Drawing.Color.Azure
        Me.PLACETextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PLACETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PS_CollectionBindingSource, "PLACE", True))
        Me.PLACETextBox.Location = New System.Drawing.Point(127, 90)
        Me.PLACETextBox.Name = "PLACETextBox"
        Me.PLACETextBox.Size = New System.Drawing.Size(378, 23)
        Me.PLACETextBox.TabIndex = 1
        Me.PLACETextBox.TabStop = False
        Me.PLACETextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PURCHASE_DATEDateTimePicker
        '
        Me.PURCHASE_DATEDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Azure
        Me.PURCHASE_DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PS_CollectionBindingSource, "PURCHASE_DATE", True))
        Me.PURCHASE_DATEDateTimePicker.Location = New System.Drawing.Point(127, 183)
        Me.PURCHASE_DATEDateTimePicker.Name = "PURCHASE_DATEDateTimePicker"
        Me.PURCHASE_DATEDateTimePicker.Size = New System.Drawing.Size(378, 23)
        Me.PURCHASE_DATEDateTimePicker.TabIndex = 2
        Me.PURCHASE_DATEDateTimePicker.TabStop = False
        Me.PURCHASE_DATEDateTimePicker.Value = New Date(2007, 1, 1, 0, 0, 0, 0)
        '
        'DISPLAY_IDTextBox
        '
        Me.DISPLAY_IDTextBox.BackColor = System.Drawing.Color.Azure
        Me.DISPLAY_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PS_CollectionBindingSource, "DISPLAY_ID", True))
        Me.DISPLAY_IDTextBox.Location = New System.Drawing.Point(127, 214)
        Me.DISPLAY_IDTextBox.Name = "DISPLAY_IDTextBox"
        Me.DISPLAY_IDTextBox.ReadOnly = True
        Me.DISPLAY_IDTextBox.Size = New System.Drawing.Size(378, 23)
        Me.DISPLAY_IDTextBox.TabIndex = 3
        Me.DISPLAY_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 126)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECT DISPLAY ID(GET LINK DATA)"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(443, 81)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(43, 21)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(443, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 21)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(443, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 21)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(487, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DISPLAY CATEGORIES:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SUB CATEGORIES:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CATEGORIES:"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.BackColor = System.Drawing.Color.Azure
        Me.ComboBox3.DataSource = Me.PSSUBCATEGORYPSCATEGORYDISBindingSource
        Me.ComboBox3.DisplayMember = "DIS VALUE"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(133, 80)
        Me.ComboBox3.MaxDropDownItems = 20
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(305, 23)
        Me.ComboBox3.TabIndex = 2
        Me.ComboBox3.ValueMember = "DISPLAY ID"
        '
        'PSSUBCATEGORYPSCATEGORYDISBindingSource
        '
        Me.PSSUBCATEGORYPSCATEGORYDISBindingSource.DataMember = "PS_SUB_CATEGORYPS_CATEGORY_DIS"
        Me.PSSUBCATEGORYPSCATEGORYDISBindingSource.DataSource = Me.PSCATEGORYPSSUBCATEGORYBindingSource
        '
        'PSCATEGORYPSSUBCATEGORYBindingSource
        '
        Me.PSCATEGORYPSSUBCATEGORYBindingSource.DataMember = "PS_CATEGORYPS_SUB_CATEGORY"
        Me.PSCATEGORYPSSUBCATEGORYBindingSource.DataSource = Me.PSCATEGORYBindingSource
        '
        'PSCATEGORYBindingSource
        '
        Me.PSCATEGORYBindingSource.DataMember = "PS_CATEGORY"
        Me.PSCATEGORYBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.BackColor = System.Drawing.Color.Azure
        Me.ComboBox2.DataSource = Me.PSCATEGORYPSSUBCATEGORYBindingSource
        Me.ComboBox2.DisplayMember = "SUB_CATEGORY_NAME"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(133, 51)
        Me.ComboBox2.MaxDropDownItems = 20
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(305, 23)
        Me.ComboBox2.TabIndex = 1
        Me.ComboBox2.ValueMember = "SUB_CATEGORYID"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.Azure
        Me.ComboBox1.DataSource = Me.PSCATEGORYBindingSource
        Me.ComboBox1.DisplayMember = "CATEGORY"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(133, 22)
        Me.ComboBox1.MaxDropDownItems = 20
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(305, 23)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "CATEGORYID"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources._1
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripTextBox2, Me.ToolStripSeparator2, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 460)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(530, 25)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SEARCHQUERYToolStripMenuItem, Me.PURCHASEPRODUCTDATEToolStripMenuItem, Me.SEARCHONLYINBETWEENToolStripMenuItem, Me.BYCURRENTDISPLAYNAMEToolStripMenuItem, Me.LOADWHOLEDATAToolStripMenuItem, Me.LOADONLYSTOCKPRODUCTSToolStripMenuItem})
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(105, 22)
        Me.ToolStripSplitButton1.Text = "SEARCH/QUERY"
        '
        'SEARCHQUERYToolStripMenuItem
        '
        Me.SEARCHQUERYToolStripMenuItem.Name = "SEARCHQUERYToolStripMenuItem"
        Me.SEARCHQUERYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.SEARCHQUERYToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.SEARCHQUERYToolStripMenuItem.Text = "SEARCH/QUERY"
        '
        'PURCHASEPRODUCTDATEToolStripMenuItem
        '
        Me.PURCHASEPRODUCTDATEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.LOADToolStripMenuItem})
        Me.PURCHASEPRODUCTDATEToolStripMenuItem.Name = "PURCHASEPRODUCTDATEToolStripMenuItem"
        Me.PURCHASEPRODUCTDATEToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.PURCHASEPRODUCTDATEToolStripMenuItem.Text = "PURCHASE PRODUCT DATE"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        '
        'LOADToolStripMenuItem
        '
        Me.LOADToolStripMenuItem.Name = "LOADToolStripMenuItem"
        Me.LOADToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.LOADToolStripMenuItem.Text = "LOAD"
        '
        'SEARCHONLYINBETWEENToolStripMenuItem
        '
        Me.SEARCHONLYINBETWEENToolStripMenuItem.Name = "SEARCHONLYINBETWEENToolStripMenuItem"
        Me.SEARCHONLYINBETWEENToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.SEARCHONLYINBETWEENToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.SEARCHONLYINBETWEENToolStripMenuItem.Text = "SEARCH ONLY IN BETWEEN"
        '
        'BYCURRENTDISPLAYNAMEToolStripMenuItem
        '
        Me.BYCURRENTDISPLAYNAMEToolStripMenuItem.Name = "BYCURRENTDISPLAYNAMEToolStripMenuItem"
        Me.BYCURRENTDISPLAYNAMEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.BYCURRENTDISPLAYNAMEToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.BYCURRENTDISPLAYNAMEToolStripMenuItem.Text = "LOAD CURRENT DISPLAY NAME GOODS"
        '
        'LOADWHOLEDATAToolStripMenuItem
        '
        Me.LOADWHOLEDATAToolStripMenuItem.Name = "LOADWHOLEDATAToolStripMenuItem"
        Me.LOADWHOLEDATAToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.LOADWHOLEDATAToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.LOADWHOLEDATAToolStripMenuItem.Text = "LOAD WHOLE GOODS COLLECTION DATABASE"
        '
        'LOADONLYSTOCKPRODUCTSToolStripMenuItem
        '
        Me.LOADONLYSTOCKPRODUCTSToolStripMenuItem.Name = "LOADONLYSTOCKPRODUCTSToolStripMenuItem"
        Me.LOADONLYSTOCKPRODUCTSToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.LOADONLYSTOCKPRODUCTSToolStripMenuItem.Size = New System.Drawing.Size(342, 22)
        Me.LOADONLYSTOCKPRODUCTSToolStripMenuItem.Text = "LOAD ONLY STOCK PRODUCTS"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(104, 22)
        Me.ToolStripButton1.Text = "PRODUCT SERIAL:"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox2.ToolTipText = "FINDS PRODUCT SERIAL,MOBILE IME,SIM NUMBER ETC... OR FIND IN PRODUCT NAME ALSO,PR" & _
            "ESS ENTER TO EXECUTE EVENT"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.CyberPack_Pro.My.Resources.Resources.Printer
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripButton2.Text = "PRINT PREVIEW"
        '
        'PS_CATEGORYTableAdapter
        '
        Me.PS_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'PS_SUB_CATEGORYTableAdapter
        '
        Me.PS_SUB_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'PS_CATEGORY_DISTableAdapter
        '
        Me.PS_CATEGORY_DISTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "GOODS COLLECTION"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(10, 419)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(195, 19)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "PRESS '&ENTER' TO NEXT RECORD"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox2.Checked = Global.CyberPack_Pro.My.MySettings.Default.PREVIOS_RECORD_PMOB
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "PREVIOS_RECORD_PMOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(211, 419)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(252, 34)
        Me.CheckBox2.TabIndex = 19
        Me.CheckBox2.TabStop = False
        Me.CheckBox2.Text = "ALWAYS TRY TO INPUT PREVIOUS RECORD " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DATA IN NULL FIELDS"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Checked = Global.CyberPack_Pro.My.MySettings.Default.AUTOMAIC_PRODUT_NAME
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "AUTOMAIC_PRODUT_NAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox3.Location = New System.Drawing.Point(10, 435)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(161, 19)
        Me.CheckBox3.TabIndex = 20
        Me.CheckBox3.TabStop = False
        Me.CheckBox3.Text = "AUTOMATIC PRODUCT ID"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 8000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'OptionsTableAdapter1
        '
        Me.OptionsTableAdapter1.ClearBeforeFill = True
        '
        'V_IDComboBox
        '
        Me.V_IDComboBox.BackColor = System.Drawing.Color.Azure
        Me.V_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PS_CollectionBindingSource, "V_ID", True))
        Me.V_IDComboBox.DataSource = Me.VENDORBindingSource
        Me.V_IDComboBox.DisplayMember = "V_NAME"
        Me.V_IDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.V_IDComboBox.FormattingEnabled = True
        Me.V_IDComboBox.Location = New System.Drawing.Point(127, 245)
        Me.V_IDComboBox.MaxDropDownItems = 20
        Me.V_IDComboBox.Name = "V_IDComboBox"
        Me.V_IDComboBox.Size = New System.Drawing.Size(329, 23)
        Me.V_IDComboBox.TabIndex = 21
        Me.V_IDComboBox.ValueMember = "V_ID"
        '
        'VENDORBindingSource
        '
        Me.VENDORBindingSource.DataMember = "VENDOR"
        Me.VENDORBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'VENDORTableAdapter
        '
        Me.VENDORTableAdapter.ClearBeforeFill = True
        '
        'PURCHASE_COSTTextBox
        '
        Me.PURCHASE_COSTTextBox.BackColor = System.Drawing.Color.Azure
        Me.PURCHASE_COSTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PS_CollectionBindingSource, "PURCHASE_COST", True))
        Me.PURCHASE_COSTTextBox.Location = New System.Drawing.Point(127, 121)
        Me.PURCHASE_COSTTextBox.Name = "PURCHASE_COSTTextBox"
        Me.PURCHASE_COSTTextBox.Size = New System.Drawing.Size(377, 23)
        Me.PURCHASE_COSTTextBox.TabIndex = 22
        Me.PURCHASE_COSTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BENEFIT_SOLD_COSTTextBox
        '
        Me.BENEFIT_SOLD_COSTTextBox.BackColor = System.Drawing.Color.Azure
        Me.BENEFIT_SOLD_COSTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PS_CollectionBindingSource, "BENEFIT_SOLD_COST", True))
        Me.BENEFIT_SOLD_COSTTextBox.Location = New System.Drawing.Point(127, 152)
        Me.BENEFIT_SOLD_COSTTextBox.Name = "BENEFIT_SOLD_COSTTextBox"
        Me.BENEFIT_SOLD_COSTTextBox.Size = New System.Drawing.Size(378, 23)
        Me.BENEFIT_SOLD_COSTTextBox.TabIndex = 23
        Me.BENEFIT_SOLD_COSTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(462, 245)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(43, 22)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PRO_ADD2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Bluesky12
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(530, 485)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(BENEFIT_SOLD_COSTLabel)
        Me.Controls.Add(Me.BENEFIT_SOLD_COSTTextBox)
        Me.Controls.Add(PURCHASE_COSTLabel)
        Me.Controls.Add(Me.PURCHASE_COSTTextBox)
        Me.Controls.Add(V_IDLabel)
        Me.Controls.Add(Me.V_IDComboBox)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(PRODUCT_SERIALLabel)
        Me.Controls.Add(Me.PRODUCT_SERIALTextBox)
        Me.Controls.Add(PLACELabel)
        Me.Controls.Add(Me.PLACETextBox)
        Me.Controls.Add(PURCHASE_DATELabel)
        Me.Controls.Add(Me.PURCHASE_DATEDateTimePicker)
        Me.Controls.Add(DISPLAY_IDLabel)
        Me.Controls.Add(Me.DISPLAY_IDTextBox)
        Me.Controls.Add(Me.PS_CollectionBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PRO_ADD2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTS/GOODS COLLECTION "
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS_CollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS_CollectionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PS_CollectionBindingNavigator.ResumeLayout(False)
        Me.PS_CollectionBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PSSUBCATEGORYPSCATEGORYDISBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSCATEGORYPSSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.VENDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents PS_CollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PS_CollectionTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CollectionTableAdapter
    Friend WithEvents PS_CollectionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PS_CollectionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PRODUCT_SERIALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PLACETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PURCHASE_DATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DISPLAY_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents PSCATEGORYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PS_CATEGORYTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CATEGORYTableAdapter
    Friend WithEvents PSCATEGORYPSSUBCATEGORYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PS_SUB_CATEGORYTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_SUB_CATEGORYTableAdapter
    Friend WithEvents PSSUBCATEGORYPSCATEGORYDISBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PS_CATEGORY_DISTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CATEGORY_DISTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents LOADWHOLEDATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SEARCHQUERYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PURCHASEPRODUCTDATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents LOADToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SEARCHONLYINBETWEENToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OptionsTableAdapter1 As CyberPack_Pro.AukDatabaseDataSetTableAdapters.OptionsTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LOADONLYSTOCKPRODUCTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BYCURRENTDISPLAYNAMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SAVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDNEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SAMEINPUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PRINTPREVIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ADDNEWCATEGORIESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REFRESHCHANGESOFNEWCATEGORIESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ADDINCURRENTMODELSSERIALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ALWAYSSHOWBLACKCOLORINNULLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents REFRESHCHANGESCURRENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REFRESHCHANGESCURRENTDATABASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SETTINGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents V_IDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VENDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VENDORTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.VENDORTableAdapter
    Friend WithEvents PURCHASE_COSTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BENEFIT_SOLD_COSTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
