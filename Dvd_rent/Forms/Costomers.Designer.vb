<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Costomers
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
        Dim Costomer_IDLabel As System.Windows.Forms.Label
        Dim Costomer_CategoryLabel As System.Windows.Forms.Label
        Dim Costomer_NameLabel As System.Windows.Forms.Label
        Dim Costomer_AddressLabel As System.Windows.Forms.Label
        Dim ContactNumber_MobileLabel As System.Windows.Forms.Label
        Dim ContactNumber_PhoneLabel As System.Windows.Forms.Label
        Dim Joining_DateLabel As System.Windows.Forms.Label
        Dim Advance_FeesLabel As System.Windows.Forms.Label
        Dim Costomer_ImageLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Costomers))
        Me.Costomer_InfBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Costomer_InfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.DelBinNav = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripDropDownButton
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageInputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.FreeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StopMemberShipToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CostInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelMemberShipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.INPUTIMAGESFROMFOLDERBYTHEIRIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.LOADAGAINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.SETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CLOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.Costomer_InfBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.ShowAllMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintOnlyCurrentMemberInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PRINTCURRENTIDCARDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PRINTALLMEMBERSIDCARDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSplitButton
        Me.RefreshCurrentItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshWholeDataTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Costomer_IDTextBox = New System.Windows.Forms.TextBox
        Me.Costomer_NameTextBox = New System.Windows.Forms.TextBox
        Me.Costomer_AddressTextBox = New System.Windows.Forms.TextBox
        Me.ContactNumber_MobileTextBox = New System.Windows.Forms.TextBox
        Me.ContactNumber_PhoneTextBox = New System.Windows.Forms.TextBox
        Me.Joining_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Advance_FeesTextBox = New System.Windows.Forms.TextBox
        Me.Costomer_ImagePictureBox = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.CostomerInfCostomerAlternativeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Costomer_CategoryComBo = New System.Windows.Forms.ComboBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlternativeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AltAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AltContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button6 = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.CUSTOMERINHANDVIEW = New System.Data.DataView
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Costomer_InfTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.Costomer_InfTableAdapter
        Me.Costomer_ALternativeTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.Costomer_AlternativeTableAdapter
        Me.OptionsTableAdapter1 = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.OptionsTableAdapter
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Costomer_IDLabel = New System.Windows.Forms.Label
        Costomer_CategoryLabel = New System.Windows.Forms.Label
        Costomer_NameLabel = New System.Windows.Forms.Label
        Costomer_AddressLabel = New System.Windows.Forms.Label
        ContactNumber_MobileLabel = New System.Windows.Forms.Label
        ContactNumber_PhoneLabel = New System.Windows.Forms.Label
        Joining_DateLabel = New System.Windows.Forms.Label
        Advance_FeesLabel = New System.Windows.Forms.Label
        Costomer_ImageLabel = New System.Windows.Forms.Label
        CType(Me.Costomer_InfBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Costomer_InfBindingNavigator.SuspendLayout()
        CType(Me.Costomer_InfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Costomer_ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostomerInfCostomerAlternativeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERINHANDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Costomer_IDLabel
        '
        Costomer_IDLabel.AutoSize = True
        Costomer_IDLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_IDLabel.Location = New System.Drawing.Point(24, 74)
        Costomer_IDLabel.Name = "Costomer_IDLabel"
        Costomer_IDLabel.Size = New System.Drawing.Size(21, 13)
        Costomer_IDLabel.TabIndex = 1
        Costomer_IDLabel.Text = "ID:"
        '
        'Costomer_CategoryLabel
        '
        Costomer_CategoryLabel.AutoSize = True
        Costomer_CategoryLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_CategoryLabel.Location = New System.Drawing.Point(24, 100)
        Costomer_CategoryLabel.Name = "Costomer_CategoryLabel"
        Costomer_CategoryLabel.Size = New System.Drawing.Size(56, 13)
        Costomer_CategoryLabel.TabIndex = 3
        Costomer_CategoryLabel.Text = "Category:"
        '
        'Costomer_NameLabel
        '
        Costomer_NameLabel.AutoSize = True
        Costomer_NameLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_NameLabel.Location = New System.Drawing.Point(24, 126)
        Costomer_NameLabel.Name = "Costomer_NameLabel"
        Costomer_NameLabel.Size = New System.Drawing.Size(39, 13)
        Costomer_NameLabel.TabIndex = 5
        Costomer_NameLabel.Text = "Name:"
        '
        'Costomer_AddressLabel
        '
        Costomer_AddressLabel.AutoSize = True
        Costomer_AddressLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_AddressLabel.Location = New System.Drawing.Point(24, 152)
        Costomer_AddressLabel.Name = "Costomer_AddressLabel"
        Costomer_AddressLabel.Size = New System.Drawing.Size(51, 13)
        Costomer_AddressLabel.TabIndex = 7
        Costomer_AddressLabel.Text = "Address:"
        '
        'ContactNumber_MobileLabel
        '
        ContactNumber_MobileLabel.AutoSize = True
        ContactNumber_MobileLabel.BackColor = System.Drawing.Color.Transparent
        ContactNumber_MobileLabel.Location = New System.Drawing.Point(24, 207)
        ContactNumber_MobileLabel.Name = "ContactNumber_MobileLabel"
        ContactNumber_MobileLabel.Size = New System.Drawing.Size(64, 13)
        ContactNumber_MobileLabel.TabIndex = 9
        ContactNumber_MobileLabel.Text = "Mobile No."
        '
        'ContactNumber_PhoneLabel
        '
        ContactNumber_PhoneLabel.AutoSize = True
        ContactNumber_PhoneLabel.BackColor = System.Drawing.Color.Transparent
        ContactNumber_PhoneLabel.Location = New System.Drawing.Point(24, 233)
        ContactNumber_PhoneLabel.Name = "ContactNumber_PhoneLabel"
        ContactNumber_PhoneLabel.Size = New System.Drawing.Size(89, 13)
        ContactNumber_PhoneLabel.TabIndex = 11
        ContactNumber_PhoneLabel.Text = "Land Phone No."
        '
        'Joining_DateLabel
        '
        Joining_DateLabel.AutoSize = True
        Joining_DateLabel.BackColor = System.Drawing.Color.Transparent
        Joining_DateLabel.Location = New System.Drawing.Point(24, 260)
        Joining_DateLabel.Name = "Joining_DateLabel"
        Joining_DateLabel.Size = New System.Drawing.Size(75, 13)
        Joining_DateLabel.TabIndex = 13
        Joining_DateLabel.Text = "Joining Date:"
        '
        'Advance_FeesLabel
        '
        Advance_FeesLabel.AutoSize = True
        Advance_FeesLabel.BackColor = System.Drawing.Color.Transparent
        Advance_FeesLabel.Location = New System.Drawing.Point(24, 285)
        Advance_FeesLabel.Name = "Advance_FeesLabel"
        Advance_FeesLabel.Size = New System.Drawing.Size(85, 13)
        Advance_FeesLabel.TabIndex = 15
        Advance_FeesLabel.Text = "Initial Payment:"
        '
        'Costomer_ImageLabel
        '
        Costomer_ImageLabel.AutoSize = True
        Costomer_ImageLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_ImageLabel.Location = New System.Drawing.Point(361, 72)
        Costomer_ImageLabel.Name = "Costomer_ImageLabel"
        Costomer_ImageLabel.Size = New System.Drawing.Size(93, 13)
        Costomer_ImageLabel.TabIndex = 17
        Costomer_ImageLabel.Text = "Customer Image:"
        '
        'Costomer_InfBindingNavigator
        '
        Me.Costomer_InfBindingNavigator.AddNewItem = Nothing
        Me.Costomer_InfBindingNavigator.BackColor = System.Drawing.Color.Black
        Me.Costomer_InfBindingNavigator.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.BlackEverSl2
        Me.Costomer_InfBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Costomer_InfBindingNavigator.BindingSource = Me.Costomer_InfBindingSource
        Me.Costomer_InfBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Costomer_InfBindingNavigator.DeleteItem = Me.DelBinNav
        Me.Costomer_InfBindingNavigator.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costomer_InfBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Costomer_InfBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripSeparator3, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.DelBinNav, Me.Costomer_InfBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripButton2})
        Me.Costomer_InfBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Costomer_InfBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Costomer_InfBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Costomer_InfBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Costomer_InfBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Costomer_InfBindingNavigator.Name = "Costomer_InfBindingNavigator"
        Me.Costomer_InfBindingNavigator.PositionItem = Nothing
        Me.Costomer_InfBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.Costomer_InfBindingNavigator.TabIndex = 0
        Me.Costomer_InfBindingNavigator.Text = "BindingNavigator1"
        '
        'Costomer_InfBindingSource
        '
        Me.Costomer_InfBindingSource.DataMember = "Costomer_Inf"
        Me.Costomer_InfBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'DelBinNav
        '
        Me.DelBinNav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DelBinNav.ForeColor = System.Drawing.Color.White
        Me.DelBinNav.Image = Global.CyberPack_Pro.My.Resources.Resources.DeleteHS2
        Me.DelBinNav.Name = "DelBinNav"
        Me.DelBinNav.Size = New System.Drawing.Size(23, 22)
        Me.DelBinNav.Text = "&Save Data"
        Me.DelBinNav.ToolTipText = "Save Data(Ctrl+S)"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.AddNewToolStripMenuItem, Me.ImageInputToolStripMenuItem, Me.ToolStripSeparator7, Me.FreeToolStripMenuItem, Me.StopMemberShipToolStripMenuItem1, Me.CostInToolStripMenuItem, Me.CancelMemberShipToolStripMenuItem, Me.ToolStripSeparator6, Me.INPUTIMAGESFROMFOLDERBYTHEIRIDToolStripMenuItem, Me.ToolStripSeparator5, Me.LOADAGAINToolStripMenuItem, Me.ToolStripSeparator4, Me.SETTINGSToolStripMenuItem, Me.CLOSEToolStripMenuItem})
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton3.Text = "MENU"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.saveHS
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl/Alt+S"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeyDisplayString = "Alt+D"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.NewDocumentHS
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.ShortcutKeyDisplayString = "Alt+A"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AddNewToolStripMenuItem.Text = "Add New"
        '
        'ImageInputToolStripMenuItem
        '
        Me.ImageInputToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.EditInformationHS
        Me.ImageInputToolStripMenuItem.Name = "ImageInputToolStripMenuItem"
        Me.ImageInputToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImageInputToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ImageInputToolStripMenuItem.Text = "Image Input"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(204, 6)
        '
        'FreeToolStripMenuItem
        '
        Me.FreeToolStripMenuItem.Name = "FreeToolStripMenuItem"
        Me.FreeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.FreeToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.FreeToolStripMenuItem.Text = "Free"
        '
        'StopMemberShipToolStripMenuItem1
        '
        Me.StopMemberShipToolStripMenuItem1.Name = "StopMemberShipToolStripMenuItem1"
        Me.StopMemberShipToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.StopMemberShipToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.StopMemberShipToolStripMenuItem1.Text = "Stop MemberShip"
        '
        'CostInToolStripMenuItem
        '
        Me.CostInToolStripMenuItem.Name = "CostInToolStripMenuItem"
        Me.CostInToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.CostInToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CostInToolStripMenuItem.Text = "CostIn"
        '
        'CancelMemberShipToolStripMenuItem
        '
        Me.CancelMemberShipToolStripMenuItem.Name = "CancelMemberShipToolStripMenuItem"
        Me.CancelMemberShipToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.CancelMemberShipToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CancelMemberShipToolStripMenuItem.Text = "Cancel MemberShip"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(204, 6)
        '
        'INPUTIMAGESFROMFOLDERBYTHEIRIDToolStripMenuItem
        '
        Me.INPUTIMAGESFROMFOLDERBYTHEIRIDToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.OrganizerHS
        Me.INPUTIMAGESFROMFOLDERBYTHEIRIDToolStripMenuItem.Name = "INPUTIMAGESFROMFOLDERBYTHEIRIDToolStripMenuItem"
        Me.INPUTIMAGESFROMFOLDERBYTHEIRIDToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.INPUTIMAGESFROMFOLDERBYTHEIRIDToolStripMenuItem.Text = "Folder Images"
        Me.INPUTIMAGESFROMFOLDERBYTHEIRIDToolStripMenuItem.ToolTipText = "Input Images From Folder By their ID"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(204, 6)
        '
        'LOADAGAINToolStripMenuItem
        '
        Me.LOADAGAINToolStripMenuItem.Name = "LOADAGAINToolStripMenuItem"
        Me.LOADAGAINToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.LOADAGAINToolStripMenuItem.Text = "Database Refresh"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(204, 6)
        '
        'SETTINGSToolStripMenuItem
        '
        Me.SETTINGSToolStripMenuItem.Name = "SETTINGSToolStripMenuItem"
        Me.SETTINGSToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SETTINGSToolStripMenuItem.Text = "Settings"
        '
        'CLOSEToolStripMenuItem
        '
        Me.CLOSEToolStripMenuItem.Name = "CLOSEToolStripMenuItem"
        Me.CLOSEToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CLOSEToolStripMenuItem.Text = "Close"
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
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.Color.Black
        Me.BindingNavigatorPositionItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(13, 22)
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
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add new"
        '
        'Costomer_InfBindingNavigatorSaveItem
        '
        Me.Costomer_InfBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Costomer_InfBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.White
        Me.Costomer_InfBindingNavigatorSaveItem.Image = CType(resources.GetObject("Costomer_InfBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Costomer_InfBindingNavigatorSaveItem.Name = "Costomer_InfBindingNavigatorSaveItem"
        Me.Costomer_InfBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Costomer_InfBindingNavigatorSaveItem.Text = "&Save Data"
        Me.Costomer_InfBindingNavigatorSaveItem.ToolTipText = "Save Data(Ctrl+S)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel1.Text = "Customer ID:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(70, 25)
        Me.ToolStripTextBox1.ToolTipText = "FIND CUSTOMER ID ,PRESS ENTER TO OPEN ID OR NAME FROM FIRST"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowAllMemberToolStripMenuItem, Me.PrintOnlyCurrentMemberInformationToolStripMenuItem, Me.PRINTCURRENTIDCARDToolStripMenuItem, Me.PRINTALLMEMBERSIDCARDToolStripMenuItem})
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.CyberPack_Pro.My.Resources.VsImg.PrintHS
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripButton1.Text = "Reports View"
        '
        'ShowAllMemberToolStripMenuItem
        '
        Me.ShowAllMemberToolStripMenuItem.Name = "ShowAllMemberToolStripMenuItem"
        Me.ShowAllMemberToolStripMenuItem.Size = New System.Drawing.Size(360, 22)
        Me.ShowAllMemberToolStripMenuItem.Text = "Show all Member Report View"
        '
        'PrintOnlyCurrentMemberInformationToolStripMenuItem
        '
        Me.PrintOnlyCurrentMemberInformationToolStripMenuItem.Name = "PrintOnlyCurrentMemberInformationToolStripMenuItem"
        Me.PrintOnlyCurrentMemberInformationToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintOnlyCurrentMemberInformationToolStripMenuItem.Size = New System.Drawing.Size(360, 22)
        Me.PrintOnlyCurrentMemberInformationToolStripMenuItem.Text = "View Only Current Member Information"
        '
        'PRINTCURRENTIDCARDToolStripMenuItem
        '
        Me.PRINTCURRENTIDCARDToolStripMenuItem.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources._2
        Me.PRINTCURRENTIDCARDToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PRINTCURRENTIDCARDToolStripMenuItem.Name = "PRINTCURRENTIDCARDToolStripMenuItem"
        Me.PRINTCURRENTIDCARDToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PRINTCURRENTIDCARDToolStripMenuItem.Size = New System.Drawing.Size(360, 22)
        Me.PRINTCURRENTIDCARDToolStripMenuItem.Text = "View Current Id Card"
        '
        'PRINTALLMEMBERSIDCARDToolStripMenuItem
        '
        Me.PRINTALLMEMBERSIDCARDToolStripMenuItem.Name = "PRINTALLMEMBERSIDCARDToolStripMenuItem"
        Me.PRINTALLMEMBERSIDCARDToolStripMenuItem.Size = New System.Drawing.Size(360, 22)
        Me.PRINTALLMEMBERSIDCARDToolStripMenuItem.Text = "View All Members Id Card"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshCurrentItemToolStripMenuItem, Me.RefreshWholeDataTableToolStripMenuItem})
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = Global.CyberPack_Pro.My.Resources.VsImg.RefreshDocViewHS
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(81, 22)
        Me.ToolStripButton2.Text = "Refresh"
        '
        'RefreshCurrentItemToolStripMenuItem
        '
        Me.RefreshCurrentItemToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.RefreshCurrentItemToolStripMenuItem.Name = "RefreshCurrentItemToolStripMenuItem"
        Me.RefreshCurrentItemToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.RefreshCurrentItemToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.RefreshCurrentItemToolStripMenuItem.Text = "Refresh Current Item"
        '
        'RefreshWholeDataTableToolStripMenuItem
        '
        Me.RefreshWholeDataTableToolStripMenuItem.Name = "RefreshWholeDataTableToolStripMenuItem"
        Me.RefreshWholeDataTableToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.RefreshWholeDataTableToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.RefreshWholeDataTableToolStripMenuItem.Text = "Refresh WholeDataTable"
        '
        'Costomer_IDTextBox
        '
        Me.Costomer_IDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Costomer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Costomer_ID", True))
        Me.Costomer_IDTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costomer_IDTextBox.Location = New System.Drawing.Point(116, 69)
        Me.Costomer_IDTextBox.Name = "Costomer_IDTextBox"
        Me.Costomer_IDTextBox.Size = New System.Drawing.Size(244, 23)
        Me.Costomer_IDTextBox.TabIndex = 0
        Me.Costomer_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Costomer_NameTextBox
        '
        Me.Costomer_NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Costomer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Costomer_Name", True))
        Me.Costomer_NameTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costomer_NameTextBox.Location = New System.Drawing.Point(116, 121)
        Me.Costomer_NameTextBox.Name = "Costomer_NameTextBox"
        Me.Costomer_NameTextBox.Size = New System.Drawing.Size(244, 23)
        Me.Costomer_NameTextBox.TabIndex = 2
        Me.Costomer_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Costomer_AddressTextBox
        '
        Me.Costomer_AddressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Costomer_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Costomer_Address", True))
        Me.Costomer_AddressTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costomer_AddressTextBox.Location = New System.Drawing.Point(116, 147)
        Me.Costomer_AddressTextBox.Multiline = True
        Me.Costomer_AddressTextBox.Name = "Costomer_AddressTextBox"
        Me.Costomer_AddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Costomer_AddressTextBox.Size = New System.Drawing.Size(244, 49)
        Me.Costomer_AddressTextBox.TabIndex = 3
        Me.Costomer_AddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContactNumber_MobileTextBox
        '
        Me.ContactNumber_MobileTextBox.AutoCompleteCustomSource.AddRange(New String() {"011", "015", "016", "017", "019"})
        Me.ContactNumber_MobileTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ContactNumber_MobileTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ContactNumber_MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "ContactNumber_Mobile", True))
        Me.ContactNumber_MobileTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNumber_MobileTextBox.Location = New System.Drawing.Point(116, 202)
        Me.ContactNumber_MobileTextBox.Name = "ContactNumber_MobileTextBox"
        Me.ContactNumber_MobileTextBox.Size = New System.Drawing.Size(244, 23)
        Me.ContactNumber_MobileTextBox.TabIndex = 4
        Me.ContactNumber_MobileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContactNumber_PhoneTextBox
        '
        Me.ContactNumber_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "ContactNumber_Phone", True))
        Me.ContactNumber_PhoneTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNumber_PhoneTextBox.Location = New System.Drawing.Point(116, 228)
        Me.ContactNumber_PhoneTextBox.Name = "ContactNumber_PhoneTextBox"
        Me.ContactNumber_PhoneTextBox.Size = New System.Drawing.Size(244, 23)
        Me.ContactNumber_PhoneTextBox.TabIndex = 5
        Me.ContactNumber_PhoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Joining_DateDateTimePicker
        '
        Me.Joining_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Costomer_InfBindingSource, "Joining_Date", True))
        Me.Joining_DateDateTimePicker.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Joining_DateDateTimePicker.Location = New System.Drawing.Point(116, 254)
        Me.Joining_DateDateTimePicker.Name = "Joining_DateDateTimePicker"
        Me.Joining_DateDateTimePicker.Size = New System.Drawing.Size(244, 23)
        Me.Joining_DateDateTimePicker.TabIndex = 6
        '
        'Advance_FeesTextBox
        '
        Me.Advance_FeesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Advance_Fees", True))
        Me.Advance_FeesTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Advance_FeesTextBox.Location = New System.Drawing.Point(116, 280)
        Me.Advance_FeesTextBox.Name = "Advance_FeesTextBox"
        Me.Advance_FeesTextBox.Size = New System.Drawing.Size(244, 23)
        Me.Advance_FeesTextBox.TabIndex = 7
        Me.Advance_FeesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Costomer_ImagePictureBox
        '
        Me.Costomer_ImagePictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Costomer_ImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Costomer_ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Costomer_ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Costomer_InfBindingSource, "Costomer_Image", True))
        Me.Costomer_ImagePictureBox.Location = New System.Drawing.Point(456, 69)
        Me.Costomer_ImagePictureBox.Name = "Costomer_ImagePictureBox"
        Me.Costomer_ImagePictureBox.Size = New System.Drawing.Size(214, 193)
        Me.Costomer_ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Costomer_ImagePictureBox.TabIndex = 18
        Me.Costomer_ImagePictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "CUSTOMER'S INFORMATION/PROFILE"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(456, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 22)
        Me.Button1.TabIndex = 8
        Me.Button1.TabStop = False
        Me.Button1.Text = "&Change Image"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CostomerInfCostomerAlternativeBindingSource
        '
        Me.CostomerInfCostomerAlternativeBindingSource.AllowNew = True
        Me.CostomerInfCostomerAlternativeBindingSource.DataMember = "Costomer_InfCostomer_Alternative"
        Me.CostomerInfCostomerAlternativeBindingSource.DataSource = Me.Costomer_InfBindingSource
        '
        'Costomer_CategoryComBo
        '
        Me.Costomer_CategoryComBo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.Costomer_InfBindingSource, "Costomer_Category", True))
        Me.Costomer_CategoryComBo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Costomer_Category", True))
        Me.Costomer_CategoryComBo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Costomer_CategoryComBo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Costomer_CategoryComBo.FormattingEnabled = True
        Me.Costomer_CategoryComBo.Items.AddRange(New Object() {"Free", "CostIn", "Cancel MemberShip", "Stop MemberShip"})
        Me.Costomer_CategoryComBo.Location = New System.Drawing.Point(116, 95)
        Me.Costomer_CategoryComBo.Name = "Costomer_CategoryComBo"
        Me.Costomer_CategoryComBo.Size = New System.Drawing.Size(244, 21)
        Me.Costomer_CategoryComBo.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DereferenceLinks = False
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.Title = "Select Image"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CostomerIDDataGridViewTextBoxColumn, Me.AlternativeNameDataGridViewTextBoxColumn, Me.AltAddressDataGridViewTextBoxColumn, Me.AltContactNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CostomerInfCostomerAlternativeBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 352)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(792, 221)
        Me.DataGridView1.TabIndex = 21
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IDDataGridViewTextBoxColumn.Width = 120
        '
        'CostomerIDDataGridViewTextBoxColumn
        '
        Me.CostomerIDDataGridViewTextBoxColumn.DataPropertyName = "Costomer_ID"
        Me.CostomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CostomerIDDataGridViewTextBoxColumn.Name = "CostomerIDDataGridViewTextBoxColumn"
        Me.CostomerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostomerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CostomerIDDataGridViewTextBoxColumn.Visible = False
        Me.CostomerIDDataGridViewTextBoxColumn.Width = 80
        '
        'AlternativeNameDataGridViewTextBoxColumn
        '
        Me.AlternativeNameDataGridViewTextBoxColumn.DataPropertyName = "Alternative_Name"
        Me.AlternativeNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.AlternativeNameDataGridViewTextBoxColumn.MinimumWidth = 220
        Me.AlternativeNameDataGridViewTextBoxColumn.Name = "AlternativeNameDataGridViewTextBoxColumn"
        Me.AlternativeNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AlternativeNameDataGridViewTextBoxColumn.Width = 220
        '
        'AltAddressDataGridViewTextBoxColumn
        '
        Me.AltAddressDataGridViewTextBoxColumn.DataPropertyName = "Alt_Address"
        Me.AltAddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AltAddressDataGridViewTextBoxColumn.MinimumWidth = 220
        Me.AltAddressDataGridViewTextBoxColumn.Name = "AltAddressDataGridViewTextBoxColumn"
        Me.AltAddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AltAddressDataGridViewTextBoxColumn.Width = 220
        '
        'AltContactNumberDataGridViewTextBoxColumn
        '
        Me.AltContactNumberDataGridViewTextBoxColumn.DataPropertyName = "Alt_ContactNumber"
        Me.AltContactNumberDataGridViewTextBoxColumn.HeaderText = "Mobile No."
        Me.AltContactNumberDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.AltContactNumberDataGridViewTextBoxColumn.Name = "AltContactNumberDataGridViewTextBoxColumn"
        Me.AltContactNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AltContactNumberDataGridViewTextBoxColumn.Width = 120
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(456, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 22)
        Me.Button2.TabIndex = 22
        Me.Button2.TabStop = False
        Me.Button2.Text = "&Hide"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(792, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "DVD CUSTOMERS ALTERNATIVE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(564, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 22)
        Me.Button3.TabIndex = 24
        Me.Button3.TabStop = False
        Me.Button3.Text = "Save File"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(564, 43)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 22)
        Me.Button4.TabIndex = 25
        Me.Button4.TabStop = False
        Me.Button4.Text = "Search/Query"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FilterIndex = 0
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(678, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "ALTERNATIVE QUERY"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.BlackEverSlPNG
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(116, 304)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(244, 25)
        Me.Button5.TabIndex = 27
        Me.Button5.TabStop = False
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.DataGrid1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(1, 336)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 237)
        Me.Panel1.TabIndex = 28
        Me.Panel1.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.B3
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(697, 38)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 25)
        Me.Button6.TabIndex = 28
        Me.Button6.TabStop = False
        Me.Button6.Text = "HIDE"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGrid1.BackColor = System.Drawing.Color.Black
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Black
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.CUSTOMERINHANDVIEW
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.ForeColor = System.Drawing.Color.White
        Me.DataGrid1.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.Black
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGrid1.Location = New System.Drawing.Point(3, 69)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.White
        Me.DataGrid1.ParentRowsVisible = False
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(777, 166)
        Me.DataGrid1.TabIndex = 1
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'CUSTOMERINHANDVIEW
        '
        Me.CUSTOMERINHANDVIEW.AllowEdit = False
        Me.CUSTOMERINHANDVIEW.Table = Me.AukDatabaseDataSet.DVD_RENTV_HAND
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.Black
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.ForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.Black
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "DVD_RENTV_HAND"
        Me.DataGridTableStyle1.PreferredColumnWidth = 120
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "DVD ID"
        Me.DataGridTextBoxColumn1.MappingName = "DVD ID"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "MOVIE NAME"
        Me.DataGridTextBoxColumn2.MappingName = "MOVIE NAME"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 220
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "PLACE"
        Me.DataGridTextBoxColumn4.MappingName = "PLACE"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "MOVIE TYPE"
        Me.DataGridTextBoxColumn3.MappingName = "MOVIE TYPE"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "MOVIE RENTAL DATE"
        Me.DataGridTextBoxColumn5.MappingName = "MOVIE RENTAL DATE"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "RETURN DATE"
        Me.DataGridTextBoxColumn6.MappingName = "RETURN DATE"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 120
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "DURATION(D)"
        Me.DataGridTextBoxColumn7.MappingName = "RENT FROM NOW DURATION(D)"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 120
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "DURATION(H)"
        Me.DataGridTextBoxColumn8.MappingName = "RENT FROM NOW DURATION(H)"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 120
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Due"
        Me.DataGridTextBoxColumn9.MappingName = "Due"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 120
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CUSTOMER'S RENT INFORMATION"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Checked = Global.CyberPack_Pro.My.MySettings.Default.FAST_LOAD_DVD_RENTC
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "FAST_LOAD_DVD_RENTC", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(456, 312)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(328, 17)
        Me.CheckBox2.TabIndex = 29
        Me.CheckBox2.Text = "DATA LOAD FASTER AND DISABLE SHOWING RENT MOVIES."
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = Global.CyberPack_Pro.My.MySettings.Default.chktONEXT
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "chktONEXT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(456, 294)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(190, 17)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "&PRESS 'ENTER' TO NEXT RECORD"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Costomer_InfTableAdapter
        '
        Me.Costomer_InfTableAdapter.ClearBeforeFill = True
        '
        'Costomer_ALternativeTableAdapter
        '
        Me.Costomer_ALternativeTableAdapter.ClearBeforeFill = True
        '
        'OptionsTableAdapter1
        '
        Me.OptionsTableAdapter1.ClearBeforeFill = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Costomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Costomer_CategoryComBo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Costomer_IDLabel)
        Me.Controls.Add(Me.Costomer_IDTextBox)
        Me.Controls.Add(Costomer_CategoryLabel)
        Me.Controls.Add(Costomer_NameLabel)
        Me.Controls.Add(Me.Costomer_NameTextBox)
        Me.Controls.Add(Costomer_AddressLabel)
        Me.Controls.Add(Me.Costomer_AddressTextBox)
        Me.Controls.Add(ContactNumber_MobileLabel)
        Me.Controls.Add(Me.ContactNumber_MobileTextBox)
        Me.Controls.Add(ContactNumber_PhoneLabel)
        Me.Controls.Add(Me.ContactNumber_PhoneTextBox)
        Me.Controls.Add(Joining_DateLabel)
        Me.Controls.Add(Me.Joining_DateDateTimePicker)
        Me.Controls.Add(Advance_FeesLabel)
        Me.Controls.Add(Me.Advance_FeesTextBox)
        Me.Controls.Add(Costomer_ImageLabel)
        Me.Controls.Add(Me.Costomer_ImagePictureBox)
        Me.Controls.Add(Me.Costomer_InfBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Costomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer's Information"
        CType(Me.Costomer_InfBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Costomer_InfBindingNavigator.ResumeLayout(False)
        Me.Costomer_InfBindingNavigator.PerformLayout()
        CType(Me.Costomer_InfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Costomer_ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostomerInfCostomerAlternativeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERINHANDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Costomer_InfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Costomer_InfBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Costomer_InfBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Costomer_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Costomer_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Costomer_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNumber_MobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNumber_PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Joining_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Advance_FeesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Costomer_ImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Costomer_CategoryComBo As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents RefreshCurrentItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshWholeDataTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CostomerInfCostomerAlternativeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents PrintOnlyCurrentMemberInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowAllMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents Costomer_InfTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.Costomer_InfTableAdapter
    Friend WithEvents Costomer_ALternativeTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.Costomer_AlternativeTableAdapter
    Friend WithEvents OptionsTableAdapter1 As CyberPack_Pro.AukDatabaseDataSetTableAdapters.OptionsTableAdapter
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents CUSTOMERINHANDVIEW As System.Data.DataView
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LOADAGAINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SETTINGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents INPUTIMAGESFROMFOLDERBYTHEIRIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CLOSEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRINTCURRENTIDCARDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRINTALLMEMBERSIDCARDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopMemberShipToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CostInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelMemberShipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageInputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostomerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlternativeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AltAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AltContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents DelBinNav As System.Windows.Forms.ToolStripButton
End Class
