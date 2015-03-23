<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendor))
        Me.V_IDTextBox = New System.Windows.Forms.TextBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ADDNEWVENDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SAVEEDITEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.REJECTCHANGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REHECTWHOLETABLECHANGESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CHANGEINSERTVENDORIMAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.SHOWCURRENTVENDORSALLWARRANTYPRODUCTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SHOWWARRENTYVENDORSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.QUERYMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QUERYMANAGERFORVENDORSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.CLOSEVENDORSINFORMATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VENDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.V_NAMETextBox = New System.Windows.Forms.TextBox
        Me.V_ADDRESSTextBox = New System.Windows.Forms.TextBox
        Me.V_MOBILETextBox = New System.Windows.Forms.TextBox
        Me.V_PHONETextBox = New System.Windows.Forms.TextBox
        Me.V_IMAGEPictureBox = New System.Windows.Forms.PictureBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TOTAL_PRODUCTSTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.V_WARTableAdapter1 = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.V_WARTableAdapter
        Me.VendorTableAdapter1 = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.VENDORTableAdapter
        Me.V_WARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_WARDataGridView = New System.Windows.Forms.DataGridView
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SOLDIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLIENTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRODUCTSERIALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NEWPRODUCTSERIALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GIVEPRODUCTDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RETURNEDPRODUCTDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COMMENTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WORKEDDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.VENDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_IMAGEPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_WARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_WARDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'V_IDTextBox
        '
        Me.V_IDTextBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.V_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDORBindingSource, "V_ID", True))
        Me.V_IDTextBox.Location = New System.Drawing.Point(187, 72)
        Me.V_IDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.V_IDTextBox.Name = "V_IDTextBox"
        Me.V_IDTextBox.Size = New System.Drawing.Size(290, 23)
        Me.V_IDTextBox.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDNEWVENDORToolStripMenuItem, Me.SAVEEDITEDToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.ToolStripSeparator1, Me.REJECTCHANGEToolStripMenuItem, Me.REHECTWHOLETABLECHANGESToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripMenuItem1, Me.CHANGEINSERTVENDORIMAGEToolStripMenuItem, Me.ToolStripSeparator5, Me.SHOWCURRENTVENDORSALLWARRANTYPRODUCTSToolStripMenuItem, Me.SHOWWARRENTYVENDORSToolStripMenuItem, Me.ToolStripSeparator3, Me.QUERYMToolStripMenuItem, Me.QUERYMANAGERFORVENDORSToolStripMenuItem, Me.ToolStripSeparator4, Me.CLOSEVENDORSINFORMATIONToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(302, 298)
        '
        'ADDNEWVENDORToolStripMenuItem
        '
        Me.ADDNEWVENDORToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DataContainer_NewRecordHS
        Me.ADDNEWVENDORToolStripMenuItem.Name = "ADDNEWVENDORToolStripMenuItem"
        Me.ADDNEWVENDORToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ADDNEWVENDORToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.ADDNEWVENDORToolStripMenuItem.Tag = "1"
        Me.ADDNEWVENDORToolStripMenuItem.Text = "ADD NEW VENDOR"
        '
        'SAVEEDITEDToolStripMenuItem
        '
        Me.SAVEEDITEDToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.saveHS
        Me.SAVEEDITEDToolStripMenuItem.Name = "SAVEEDITEDToolStripMenuItem"
        Me.SAVEEDITEDToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVEEDITEDToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.SAVEEDITEDToolStripMenuItem.Tag = "2"
        Me.SAVEEDITEDToolStripMenuItem.Text = "SAVE EDITED"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DeleteHS
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.DELETEToolStripMenuItem.Tag = "3"
        Me.DELETEToolStripMenuItem.Text = "DELETE CURRENT"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(298, 6)
        '
        'REJECTCHANGEToolStripMenuItem
        '
        Me.REJECTCHANGEToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.RefreshDocViewHS
        Me.REJECTCHANGEToolStripMenuItem.Name = "REJECTCHANGEToolStripMenuItem"
        Me.REJECTCHANGEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.REJECTCHANGEToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.REJECTCHANGEToolStripMenuItem.Tag = "4"
        Me.REJECTCHANGEToolStripMenuItem.Text = "REJECT CHANGE"
        '
        'REHECTWHOLETABLECHANGESToolStripMenuItem
        '
        Me.REHECTWHOLETABLECHANGESToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.RefreshDocViewHS
        Me.REHECTWHOLETABLECHANGESToolStripMenuItem.Name = "REHECTWHOLETABLECHANGESToolStripMenuItem"
        Me.REHECTWHOLETABLECHANGESToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.REHECTWHOLETABLECHANGESToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.REHECTWHOLETABLECHANGESToolStripMenuItem.Tag = "5"
        Me.REHECTWHOLETABLECHANGESToolStripMenuItem.Text = "REJECT WHOLE TABLE CHANGES"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(298, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CyberPack_Pro.My.Resources.VsImg.SearchFolderHS
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(301, 22)
        Me.ToolStripMenuItem1.Tag = "14"
        Me.ToolStripMenuItem1.Text = "INPUT IMAGE FROM FOLDER"
        Me.ToolStripMenuItem1.ToolTipText = "Input Image From Folder: Select Image by Vendor's ID"
        '
        'CHANGEINSERTVENDORIMAGEToolStripMenuItem
        '
        Me.CHANGEINSERTVENDORIMAGEToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.ResizeHS
        Me.CHANGEINSERTVENDORIMAGEToolStripMenuItem.Name = "CHANGEINSERTVENDORIMAGEToolStripMenuItem"
        Me.CHANGEINSERTVENDORIMAGEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.CHANGEINSERTVENDORIMAGEToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.CHANGEINSERTVENDORIMAGEToolStripMenuItem.Tag = "6"
        Me.CHANGEINSERTVENDORIMAGEToolStripMenuItem.Text = "CHANGE/INSERT VENDOR IMAGE"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(298, 6)
        '
        'SHOWCURRENTVENDORSALLWARRANTYPRODUCTSToolStripMenuItem
        '
        Me.SHOWCURRENTVENDORSALLWARRANTYPRODUCTSToolStripMenuItem.Name = "SHOWCURRENTVENDORSALLWARRANTYPRODUCTSToolStripMenuItem"
        Me.SHOWCURRENTVENDORSALLWARRANTYPRODUCTSToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.SHOWCURRENTVENDORSALLWARRANTYPRODUCTSToolStripMenuItem.Tag = "7"
        Me.SHOWCURRENTVENDORSALLWARRANTYPRODUCTSToolStripMenuItem.Text = "ALL WARRANTY PRODUCTS"
        Me.SHOWCURRENTVENDORSALLWARRANTYPRODUCTSToolStripMenuItem.ToolTipText = "SHOW CURRENT VENDOR'S ALL WARRANTY PRODUCTSSHOW CURRENT VENDOR'S ALL WARRANTY PRO" & _
            "DUCTS"
        '
        'SHOWWARRENTYVENDORSToolStripMenuItem
        '
        Me.SHOWWARRENTYVENDORSToolStripMenuItem.Name = "SHOWWARRENTYVENDORSToolStripMenuItem"
        Me.SHOWWARRENTYVENDORSToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.SHOWWARRENTYVENDORSToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.SHOWWARRENTYVENDORSToolStripMenuItem.Tag = "8"
        Me.SHOWWARRENTYVENDORSToolStripMenuItem.Text = "SHOW THE LIST OF LEAST PRODUCTS"
        Me.SHOWWARRENTYVENDORSToolStripMenuItem.ToolTipText = "FILTER THE VENDORS WHO HAVE RECEIVED AT LEAST" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ONE PRODUCT ONLY.NOT WORKED YET."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(298, 6)
        '
        'QUERYMToolStripMenuItem
        '
        Me.QUERYMToolStripMenuItem.Name = "QUERYMToolStripMenuItem"
        Me.QUERYMToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.QUERYMToolStripMenuItem.Tag = "9"
        Me.QUERYMToolStripMenuItem.Text = "QUERY MANAGER FOR WARRENTY"
        Me.QUERYMToolStripMenuItem.Visible = False
        '
        'QUERYMANAGERFORVENDORSToolStripMenuItem
        '
        Me.QUERYMANAGERFORVENDORSToolStripMenuItem.Name = "QUERYMANAGERFORVENDORSToolStripMenuItem"
        Me.QUERYMANAGERFORVENDORSToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.QUERYMANAGERFORVENDORSToolStripMenuItem.Tag = "10"
        Me.QUERYMANAGERFORVENDORSToolStripMenuItem.Text = "QUERY MANAGER FOR VENDORS"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(298, 6)
        '
        'CLOSEVENDORSINFORMATIONToolStripMenuItem
        '
        Me.CLOSEVENDORSINFORMATIONToolStripMenuItem.Name = "CLOSEVENDORSINFORMATIONToolStripMenuItem"
        Me.CLOSEVENDORSINFORMATIONToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.CLOSEVENDORSINFORMATIONToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.CLOSEVENDORSINFORMATIONToolStripMenuItem.Tag = "11"
        Me.CLOSEVENDORSINFORMATIONToolStripMenuItem.Text = "CLOSE VENDORS INFORMATION"
        '
        'VENDORBindingSource
        '
        Me.VENDORBindingSource.DataMember = "VENDOR"
        Me.VENDORBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_NAMETextBox
        '
        Me.V_NAMETextBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.V_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDORBindingSource, "V_NAME", True))
        Me.V_NAMETextBox.Location = New System.Drawing.Point(187, 96)
        Me.V_NAMETextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.V_NAMETextBox.Name = "V_NAMETextBox"
        Me.V_NAMETextBox.Size = New System.Drawing.Size(290, 23)
        Me.V_NAMETextBox.TabIndex = 1
        '
        'V_ADDRESSTextBox
        '
        Me.V_ADDRESSTextBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.V_ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDORBindingSource, "V_ADDRESS", True))
        Me.V_ADDRESSTextBox.Location = New System.Drawing.Point(187, 120)
        Me.V_ADDRESSTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.V_ADDRESSTextBox.Name = "V_ADDRESSTextBox"
        Me.V_ADDRESSTextBox.Size = New System.Drawing.Size(290, 23)
        Me.V_ADDRESSTextBox.TabIndex = 2
        '
        'V_MOBILETextBox
        '
        Me.V_MOBILETextBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.V_MOBILETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDORBindingSource, "V_MOBILE", True))
        Me.V_MOBILETextBox.Location = New System.Drawing.Point(187, 145)
        Me.V_MOBILETextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.V_MOBILETextBox.Name = "V_MOBILETextBox"
        Me.V_MOBILETextBox.Size = New System.Drawing.Size(290, 23)
        Me.V_MOBILETextBox.TabIndex = 3
        '
        'V_PHONETextBox
        '
        Me.V_PHONETextBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.V_PHONETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDORBindingSource, "V_PHONE", True))
        Me.V_PHONETextBox.Location = New System.Drawing.Point(187, 170)
        Me.V_PHONETextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.V_PHONETextBox.Name = "V_PHONETextBox"
        Me.V_PHONETextBox.Size = New System.Drawing.Size(290, 23)
        Me.V_PHONETextBox.TabIndex = 4
        '
        'V_IMAGEPictureBox
        '
        Me.V_IMAGEPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.V_IMAGEPictureBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.V_IMAGEPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.VENDORBindingSource, "V_IMAGE", True))
        Me.V_IMAGEPictureBox.Location = New System.Drawing.Point(605, 68)
        Me.V_IMAGEPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.V_IMAGEPictureBox.Name = "V_IMAGEPictureBox"
        Me.V_IMAGEPictureBox.Size = New System.Drawing.Size(145, 146)
        Me.V_IMAGEPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.V_IMAGEPictureBox.TabIndex = 12
        Me.V_IMAGEPictureBox.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Location = New System.Drawing.Point(703, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 16)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TextBox1, "FIND BY VENDOR'S ID OR NAME")
        '
        'TOTAL_PRODUCTSTextBox
        '
        Me.TOTAL_PRODUCTSTextBox.BackColor = System.Drawing.Color.White
        Me.TOTAL_PRODUCTSTextBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TOTAL_PRODUCTSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VENDORBindingSource, "TOTAL_PRODUCTS", True))
        Me.TOTAL_PRODUCTSTextBox.Location = New System.Drawing.Point(187, 195)
        Me.TOTAL_PRODUCTSTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TOTAL_PRODUCTSTextBox.Name = "TOTAL_PRODUCTSTextBox"
        Me.TOTAL_PRODUCTSTextBox.ReadOnly = True
        Me.TOTAL_PRODUCTSTextBox.Size = New System.Drawing.Size(290, 23)
        Me.TOTAL_PRODUCTSTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.TOTAL_PRODUCTSTextBox, "Double Click to refrech total products count")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.Location = New System.Drawing.Point(183, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Tag = "12"
        Me.ToolTip1.SetToolTip(Me.Label1, "PREVIOUS RECORD:CTRL+LEFT ARROW")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label2.Location = New System.Drawing.Point(213, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Tag = "13"
        Me.ToolTip1.SetToolTip(Me.Label2, "NEXT RECORD:CTRL+RIGHT ARROW")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label3.Location = New System.Drawing.Point(241, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Tag = "1"
        Me.ToolTip1.SetToolTip(Me.Label3, "CTRL+A")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label4.Location = New System.Drawing.Point(303, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Tag = "2"
        Me.ToolTip1.SetToolTip(Me.Label4, "CTRL+S")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label5.Location = New System.Drawing.Point(364, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Tag = "3"
        Me.ToolTip1.SetToolTip(Me.Label5, "CTRL+D")
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label6.Location = New System.Drawing.Point(423, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Tag = "4"
        Me.ToolTip1.SetToolTip(Me.Label6, "CTRL+E")
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label7.Location = New System.Drawing.Point(484, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Tag = "10"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label12.Location = New System.Drawing.Point(651, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 15)
        Me.Label12.TabIndex = 28
        Me.Label12.Tag = "6"
        '
        'V_WARTableAdapter1
        '
        Me.V_WARTableAdapter1.ClearBeforeFill = True
        '
        'VendorTableAdapter1
        '
        Me.VendorTableAdapter1.ClearBeforeFill = True
        '
        'V_WARBindingSource
        '
        Me.V_WARBindingSource.DataMember = "VENDORV_WAR"
        Me.V_WARBindingSource.DataSource = Me.VENDORBindingSource
        '
        'V_WARDataGridView
        '
        Me.V_WARDataGridView.AutoGenerateColumns = False
        Me.V_WARDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.V_WARDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.VIDDataGridViewTextBoxColumn, Me.VNAMEDataGridViewTextBoxColumn, Me.SOLDIDDataGridViewTextBoxColumn, Me.CLIENTNAMEDataGridViewTextBoxColumn, Me.PRODUCTSERIALDataGridViewTextBoxColumn, Me.NEWPRODUCTSERIALDataGridViewTextBoxColumn, Me.GIVEPRODUCTDATEDataGridViewTextBoxColumn, Me.RETURNEDPRODUCTDATEDataGridViewTextBoxColumn, Me.COMMENTSDataGridViewTextBoxColumn, Me.WORKEDDataGridViewCheckBoxColumn})
        Me.V_WARDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.V_WARDataGridView.DataSource = Me.V_WARBindingSource
        Me.V_WARDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.V_WARDataGridView.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.V_WARDataGridView.Location = New System.Drawing.Point(0, 254)
        Me.V_WARDataGridView.Name = "V_WARDataGridView"
        Me.V_WARDataGridView.Size = New System.Drawing.Size(800, 346)
        Me.V_WARDataGridView.TabIndex = 28
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(370, 224)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(107, 19)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.Text = "ENTER TO NEXT"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label13.Location = New System.Drawing.Point(4, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(761, 24)
        Me.Label13.TabIndex = 30
        Me.Label13.Tag = "1"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(765, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 25)
        Me.Label14.TabIndex = 31
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.Location = New System.Drawing.Point(228, 224)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(140, 19)
        Me.CheckBox2.TabIndex = 32
        Me.CheckBox2.Text = "ADD NEW AFTER LAST"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'VIDDataGridViewTextBoxColumn
        '
        Me.VIDDataGridViewTextBoxColumn.DataPropertyName = "V_ID"
        Me.VIDDataGridViewTextBoxColumn.HeaderText = "V_ID"
        Me.VIDDataGridViewTextBoxColumn.Name = "VIDDataGridViewTextBoxColumn"
        Me.VIDDataGridViewTextBoxColumn.Visible = False
        '
        'VNAMEDataGridViewTextBoxColumn
        '
        Me.VNAMEDataGridViewTextBoxColumn.DataPropertyName = "V_NAME"
        Me.VNAMEDataGridViewTextBoxColumn.HeaderText = "V_NAME"
        Me.VNAMEDataGridViewTextBoxColumn.Name = "VNAMEDataGridViewTextBoxColumn"
        Me.VNAMEDataGridViewTextBoxColumn.Visible = False
        '
        'SOLDIDDataGridViewTextBoxColumn
        '
        Me.SOLDIDDataGridViewTextBoxColumn.DataPropertyName = "SOLD_ID"
        Me.SOLDIDDataGridViewTextBoxColumn.HeaderText = "SOLD_ID"
        Me.SOLDIDDataGridViewTextBoxColumn.Name = "SOLDIDDataGridViewTextBoxColumn"
        Me.SOLDIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SOLDIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CLIENTNAMEDataGridViewTextBoxColumn
        '
        Me.CLIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_NAME"
        Me.CLIENTNAMEDataGridViewTextBoxColumn.HeaderText = "CLIENT_NAME"
        Me.CLIENTNAMEDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.CLIENTNAMEDataGridViewTextBoxColumn.Name = "CLIENTNAMEDataGridViewTextBoxColumn"
        Me.CLIENTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIENTNAMEDataGridViewTextBoxColumn.Width = 120
        '
        'PRODUCTSERIALDataGridViewTextBoxColumn
        '
        Me.PRODUCTSERIALDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_SERIAL"
        Me.PRODUCTSERIALDataGridViewTextBoxColumn.HeaderText = "GOOD'S SERIAL"
        Me.PRODUCTSERIALDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.PRODUCTSERIALDataGridViewTextBoxColumn.Name = "PRODUCTSERIALDataGridViewTextBoxColumn"
        Me.PRODUCTSERIALDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODUCTSERIALDataGridViewTextBoxColumn.Width = 150
        '
        'NEWPRODUCTSERIALDataGridViewTextBoxColumn
        '
        Me.NEWPRODUCTSERIALDataGridViewTextBoxColumn.DataPropertyName = "NEW_PRODUCT_SERIAL"
        Me.NEWPRODUCTSERIALDataGridViewTextBoxColumn.HeaderText = "NEW GOOD SERIAL"
        Me.NEWPRODUCTSERIALDataGridViewTextBoxColumn.MinimumWidth = 200
        Me.NEWPRODUCTSERIALDataGridViewTextBoxColumn.Name = "NEWPRODUCTSERIALDataGridViewTextBoxColumn"
        Me.NEWPRODUCTSERIALDataGridViewTextBoxColumn.ReadOnly = True
        Me.NEWPRODUCTSERIALDataGridViewTextBoxColumn.ToolTipText = "NEW_PRODUCT_SERIAL"
        Me.NEWPRODUCTSERIALDataGridViewTextBoxColumn.Width = 200
        '
        'GIVEPRODUCTDATEDataGridViewTextBoxColumn
        '
        Me.GIVEPRODUCTDATEDataGridViewTextBoxColumn.DataPropertyName = "GIVE_PRODUCT_DATE"
        Me.GIVEPRODUCTDATEDataGridViewTextBoxColumn.HeaderText = "SEND DATE"
        Me.GIVEPRODUCTDATEDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.GIVEPRODUCTDATEDataGridViewTextBoxColumn.Name = "GIVEPRODUCTDATEDataGridViewTextBoxColumn"
        Me.GIVEPRODUCTDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.GIVEPRODUCTDATEDataGridViewTextBoxColumn.ToolTipText = "PRODUCT WARRANTY SEND DATE"
        '
        'RETURNEDPRODUCTDATEDataGridViewTextBoxColumn
        '
        Me.RETURNEDPRODUCTDATEDataGridViewTextBoxColumn.DataPropertyName = "RETURNED_PRODUCT_DATE"
        Me.RETURNEDPRODUCTDATEDataGridViewTextBoxColumn.HeaderText = "RETURNED DATE"
        Me.RETURNEDPRODUCTDATEDataGridViewTextBoxColumn.Name = "RETURNEDPRODUCTDATEDataGridViewTextBoxColumn"
        Me.RETURNEDPRODUCTDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.RETURNEDPRODUCTDATEDataGridViewTextBoxColumn.ToolTipText = "PRODUCT RETURNED DATE"
        '
        'COMMENTSDataGridViewTextBoxColumn
        '
        Me.COMMENTSDataGridViewTextBoxColumn.DataPropertyName = "COMMENTS"
        Me.COMMENTSDataGridViewTextBoxColumn.HeaderText = "COMMENTS"
        Me.COMMENTSDataGridViewTextBoxColumn.MaxInputLength = 30
        Me.COMMENTSDataGridViewTextBoxColumn.MinimumWidth = 140
        Me.COMMENTSDataGridViewTextBoxColumn.Name = "COMMENTSDataGridViewTextBoxColumn"
        Me.COMMENTSDataGridViewTextBoxColumn.Width = 140
        '
        'WORKEDDataGridViewCheckBoxColumn
        '
        Me.WORKEDDataGridViewCheckBoxColumn.DataPropertyName = "WORKED"
        Me.WORKEDDataGridViewCheckBoxColumn.HeaderText = "WORKED"
        Me.WORKEDDataGridViewCheckBoxColumn.Name = "WORKEDDataGridViewCheckBoxColumn"
        Me.WORKEDDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Vendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.V_WARDataGridView)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.V_IDTextBox)
        Me.Controls.Add(Me.V_NAMETextBox)
        Me.Controls.Add(Me.V_ADDRESSTextBox)
        Me.Controls.Add(Me.V_MOBILETextBox)
        Me.Controls.Add(Me.V_PHONETextBox)
        Me.Controls.Add(Me.V_IMAGEPictureBox)
        Me.Controls.Add(Me.TOTAL_PRODUCTSTextBox)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Vendor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vedors Information"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.VENDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_IMAGEPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_WARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_WARDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents VENDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents V_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents V_ADDRESSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents V_MOBILETextBox As System.Windows.Forms.TextBox
    Friend WithEvents V_PHONETextBox As System.Windows.Forms.TextBox
    Friend WithEvents V_IMAGEPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TOTAL_PRODUCTSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ADDNEWVENDORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAVEEDITEDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents REJECTCHANGEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REHECTWHOLETABLECHANGESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CHANGEINSERTVENDORIMAGEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SHOWWARRENTYVENDORSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CLOSEVENDORSINFORMATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QUERYMANAGERFORVENDORSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QUERYMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents V_WARTableAdapter1 As CyberPack_Pro.AukDatabaseDataSetTableAdapters.V_WARTableAdapter
    Friend WithEvents VendorTableAdapter1 As CyberPack_Pro.AukDatabaseDataSetTableAdapters.VENDORTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SHOWCURRENTVENDORSALLWARRANTYPRODUCTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents V_WARBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_WARDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOLDIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTSERIALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NEWPRODUCTSERIALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GIVEPRODUCTDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RETURNEDPRODUCTDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMMENTSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WORKEDDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
