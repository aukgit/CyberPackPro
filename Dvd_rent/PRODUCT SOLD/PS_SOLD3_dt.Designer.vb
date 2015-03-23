<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PS_SOLD
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
        Dim REPORT_IDLabel As System.Windows.Forms.Label
        Dim TOTAL_AMOUNNTLabel As System.Windows.Forms.Label
        Dim INSTALLATION_CHARGELabel As System.Windows.Forms.Label
        Dim VATLabel As System.Windows.Forms.Label
        Dim TOTAL_DISCOUNTLabel As System.Windows.Forms.Label
        Dim PAYMENT_CATEGORYLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PS_SOLD))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FINDBYSERIALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.FILTERBYSERIALIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.FILTERBYGOODSNAMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SHOWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PRODUCTNAMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PRODUCTSERIALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.FOCUSONGRIDVIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.SEARCHQUERYINSTOCKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REMOVEFILTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.EDITINEDITORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.LOADALLAGAINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOADONLYCATEGORIESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOADONLYCURRENTPRODUCTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EDITCATEGORIESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EDITCURRENTCATEGORYGOODSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DIRECTINPUTPRICEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PURCHASE_INPUT_TOOLtEXT = New System.Windows.Forms.ToolStripTextBox
        Me.BENEFIT_INPTU_TOOL = New System.Windows.Forms.ToolStripTextBox
        Me.WARRANTY_MONTHS_TOLL = New System.Windows.Forms.ToolStripTextBox
        Me.SAVEINDATABASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SOLDTOCURRENTCLIENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.FUNCTIONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PSCATEGORYDISPSCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PSSUBCATEGORYPSCATEGORYDISBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PSCATEGORYPSSUBCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PSCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.PSEmployeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.PAYMENT_CATEGORYComboBox = New System.Windows.Forms.ComboBox
        Me.RP_IDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.REPORT_IDTextBox = New System.Windows.Forms.TextBox
        Me.TOTAL_AMOUNNTTextBox = New System.Windows.Forms.TextBox
        Me.INSTALLATION_CHARGETextBox = New System.Windows.Forms.TextBox
        Me.VATTextBox = New System.Windows.Forms.TextBox
        Me.TOTAL_DISCOUNTTextBox = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.SOLDIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DISPLAYIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRODUCTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRODUCTSERIALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLIENTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PURCHASECOSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SOLDPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DISCOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BENEFITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SOLDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WARRANTYVALIDMONTHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REPORTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_ID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SELECTEDROWSDELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADDCURRENTINWARRAYSTOCKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PSSOLDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripSplitButton
        Me.SEARCHQUERYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SHOWTODAYSBENEFITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SUMMARYFORMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.filter_combox = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSplitButton
        Me.ADDTOWARRANTYDATABASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SHOWWARRANTYDATABASEVIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator
        Me.HideCurrentFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WARRANTY_TXTBOX = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.CLIENTNAMEFOUCSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FOCUSONGOODSCATEGORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.CANCELCURRENTPRODCUTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SOLDGOODSTOCURRNETToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripSplitButton
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.SHOWCLIENTEDITVIEWFORMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PS_CATEGORYTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CATEGORYTableAdapter
        Me.PS_SUB_CATEGORYTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_SUB_CATEGORYTableAdapter
        Me.PS_CATEGORY_DISTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CATEGORY_DISTableAdapter
        Me.PS_CollectionTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CollectionTableAdapter
        Me.PS_SOLDTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_SOLDTableAdapter
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PS_EmployeTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_EmployeTableAdapter
        Me.PS_CLIENTSTableAdapter1 = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CLIENTSTableAdapter
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RP_IDTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.RP_IDTableAdapter
        Me.PS_WARRANTYTableAdapter1 = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_WARRANTYTableAdapter
        Me.V_WARTableAdapter1 = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.V_WARTableAdapter
        Me.VendorTableAdapter1 = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.VENDORTableAdapter
        Me.VendorsList = New System.Windows.Forms.ComboBox
        Me.VENDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        REPORT_IDLabel = New System.Windows.Forms.Label
        TOTAL_AMOUNNTLabel = New System.Windows.Forms.Label
        INSTALLATION_CHARGELabel = New System.Windows.Forms.Label
        VATLabel = New System.Windows.Forms.Label
        TOTAL_DISCOUNTLabel = New System.Windows.Forms.Label
        PAYMENT_CATEGORYLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PSCATEGORYDISPSCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSSUBCATEGORYPSCATEGORYDISBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSCATEGORYPSSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PSEmployeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RP_IDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PSSOLDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.VENDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'REPORT_IDLabel
        '
        REPORT_IDLabel.AutoSize = True
        REPORT_IDLabel.Location = New System.Drawing.Point(70, 18)
        REPORT_IDLabel.Name = "REPORT_IDLabel"
        REPORT_IDLabel.Size = New System.Drawing.Size(67, 15)
        REPORT_IDLabel.TabIndex = 0
        REPORT_IDLabel.Text = "REPORT ID:"
        '
        'TOTAL_AMOUNNTLabel
        '
        TOTAL_AMOUNNTLabel.AutoSize = True
        TOTAL_AMOUNNTLabel.Location = New System.Drawing.Point(35, 35)
        TOTAL_AMOUNNTLabel.Name = "TOTAL_AMOUNNTLabel"
        TOTAL_AMOUNNTLabel.Size = New System.Drawing.Size(103, 15)
        TOTAL_AMOUNNTLabel.TabIndex = 2
        TOTAL_AMOUNNTLabel.Text = "TOTAL AMOUNNT:"
        '
        'INSTALLATION_CHARGELabel
        '
        INSTALLATION_CHARGELabel.AutoSize = True
        INSTALLATION_CHARGELabel.Location = New System.Drawing.Point(8, 52)
        INSTALLATION_CHARGELabel.Name = "INSTALLATION_CHARGELabel"
        INSTALLATION_CHARGELabel.Size = New System.Drawing.Size(131, 15)
        INSTALLATION_CHARGELabel.TabIndex = 4
        INSTALLATION_CHARGELabel.Text = "INSTALLATION CHARGE:"
        '
        'VATLabel
        '
        VATLabel.AutoSize = True
        VATLabel.Location = New System.Drawing.Point(109, 69)
        VATLabel.Name = "VATLabel"
        VATLabel.Size = New System.Drawing.Size(30, 15)
        VATLabel.TabIndex = 6
        VATLabel.Text = "VAT:"
        '
        'TOTAL_DISCOUNTLabel
        '
        TOTAL_DISCOUNTLabel.AutoSize = True
        TOTAL_DISCOUNTLabel.Location = New System.Drawing.Point(36, 86)
        TOTAL_DISCOUNTLabel.Name = "TOTAL_DISCOUNTLabel"
        TOTAL_DISCOUNTLabel.Size = New System.Drawing.Size(102, 15)
        TOTAL_DISCOUNTLabel.TabIndex = 8
        TOTAL_DISCOUNTLabel.Text = "TOTAL DISCOUNT:"
        '
        'PAYMENT_CATEGORYLabel
        '
        PAYMENT_CATEGORYLabel.AutoSize = True
        PAYMENT_CATEGORYLabel.Location = New System.Drawing.Point(322, 11)
        PAYMENT_CATEGORYLabel.Name = "PAYMENT_CATEGORYLabel"
        PAYMENT_CATEGORYLabel.Size = New System.Drawing.Size(120, 15)
        PAYMENT_CATEGORYLabel.TabIndex = 12
        PAYMENT_CATEGORYLabel.Text = "PAYMENT CATEGORY:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.SplitContainer1.Panel2.Controls.Add(Me.VendorsList)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Size = New System.Drawing.Size(794, 568)
        Me.SplitContainer1.SplitterDistance = 245
        Me.SplitContainer1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox1.DataSource = Me.PSCATEGORYDISPSCollectionBindingSource
        Me.ListBox1.DisplayMember = "PRODUCT_SERIAL"
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(0, 181)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(245, 345)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "PRODUCT_SERIAL"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FINDBYSERIALToolStripMenuItem, Me.ToolStripSeparator2, Me.FILTERBYSERIALIDToolStripMenuItem, Me.FILTERBYGOODSNAMEToolStripMenuItem, Me.ToolStripSeparator3, Me.SHOWToolStripMenuItem, Me.ToolStripSeparator6, Me.FOCUSONGRIDVIEWToolStripMenuItem, Me.ToolStripSeparator7, Me.SEARCHQUERYINSTOCKToolStripMenuItem, Me.REMOVEFILTERToolStripMenuItem, Me.ToolStripSeparator8, Me.EDITINEDITORToolStripMenuItem, Me.ToolStripSeparator9, Me.LOADALLAGAINToolStripMenuItem, Me.LOADONLYCATEGORIESToolStripMenuItem, Me.LOADONLYCURRENTPRODUCTToolStripMenuItem, Me.EDITCATEGORIESToolStripMenuItem, Me.EDITCURRENTCATEGORYGOODSToolStripMenuItem, Me.DIRECTINPUTPRICEToolStripMenuItem, Me.ToolStripSeparator10, Me.FUNCTIONSToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(269, 376)
        '
        'FINDBYSERIALToolStripMenuItem
        '
        Me.FINDBYSERIALToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox4})
        Me.FINDBYSERIALToolStripMenuItem.Name = "FINDBYSERIALToolStripMenuItem"
        Me.FINDBYSERIALToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.FINDBYSERIALToolStripMenuItem.Text = "FIND IN LIST"
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripTextBox4.Tag = ""
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(265, 6)
        '
        'FILTERBYSERIALIDToolStripMenuItem
        '
        Me.FILTERBYSERIALIDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox2})
        Me.FILTERBYSERIALIDToolStripMenuItem.Name = "FILTERBYSERIALIDToolStripMenuItem"
        Me.FILTERBYSERIALIDToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.FILTERBYSERIALIDToolStripMenuItem.Text = "FILTER BY SERIAL/ID"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripTextBox2.Tag = "PRODUCT_SERIAL"
        '
        'FILTERBYGOODSNAMEToolStripMenuItem
        '
        Me.FILTERBYGOODSNAMEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox3})
        Me.FILTERBYGOODSNAMEToolStripMenuItem.Name = "FILTERBYGOODSNAMEToolStripMenuItem"
        Me.FILTERBYGOODSNAMEToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.FILTERBYGOODSNAMEToolStripMenuItem.Text = "FILTER BY GOODS NAME"
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripTextBox3.Tag = "PRODUCT_NAME"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(265, 6)
        '
        'SHOWToolStripMenuItem
        '
        Me.SHOWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PRODUCTNAMEToolStripMenuItem, Me.PRODUCTSERIALToolStripMenuItem})
        Me.SHOWToolStripMenuItem.Name = "SHOWToolStripMenuItem"
        Me.SHOWToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.SHOWToolStripMenuItem.Text = "SHOW"
        Me.SHOWToolStripMenuItem.Visible = False
        '
        'PRODUCTNAMEToolStripMenuItem
        '
        Me.PRODUCTNAMEToolStripMenuItem.Name = "PRODUCTNAMEToolStripMenuItem"
        Me.PRODUCTNAMEToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PRODUCTNAMEToolStripMenuItem.Tag = "0"
        Me.PRODUCTNAMEToolStripMenuItem.Text = "PRODUCT NAME"
        '
        'PRODUCTSERIALToolStripMenuItem
        '
        Me.PRODUCTSERIALToolStripMenuItem.Name = "PRODUCTSERIALToolStripMenuItem"
        Me.PRODUCTSERIALToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PRODUCTSERIALToolStripMenuItem.Tag = "1"
        Me.PRODUCTSERIALToolStripMenuItem.Text = "PRODUCT SERIAL"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(265, 6)
        Me.ToolStripSeparator6.Visible = False
        '
        'FOCUSONGRIDVIEWToolStripMenuItem
        '
        Me.FOCUSONGRIDVIEWToolStripMenuItem.Name = "FOCUSONGRIDVIEWToolStripMenuItem"
        Me.FOCUSONGRIDVIEWToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.FOCUSONGRIDVIEWToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.FOCUSONGRIDVIEWToolStripMenuItem.Text = "FOCUS ON GRID VIEW"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(265, 6)
        '
        'SEARCHQUERYINSTOCKToolStripMenuItem
        '
        Me.SEARCHQUERYINSTOCKToolStripMenuItem.Name = "SEARCHQUERYINSTOCKToolStripMenuItem"
        Me.SEARCHQUERYINSTOCKToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.SEARCHQUERYINSTOCKToolStripMenuItem.Text = "SEARCH/QUERY IN STOCK"
        '
        'REMOVEFILTERToolStripMenuItem
        '
        Me.REMOVEFILTERToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DeleteHS
        Me.REMOVEFILTERToolStripMenuItem.Name = "REMOVEFILTERToolStripMenuItem"
        Me.REMOVEFILTERToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.REMOVEFILTERToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.REMOVEFILTERToolStripMenuItem.Text = "REMOVE FILTER"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(265, 6)
        '
        'EDITINEDITORToolStripMenuItem
        '
        Me.EDITINEDITORToolStripMenuItem.Name = "EDITINEDITORToolStripMenuItem"
        Me.EDITINEDITORToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.EDITINEDITORToolStripMenuItem.Text = "EDIT IN EDITOR"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(265, 6)
        '
        'LOADALLAGAINToolStripMenuItem
        '
        Me.LOADALLAGAINToolStripMenuItem.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.BlackEverSl2
        Me.LOADALLAGAINToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LOADALLAGAINToolStripMenuItem.Name = "LOADALLAGAINToolStripMenuItem"
        Me.LOADALLAGAINToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.LOADALLAGAINToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.LOADALLAGAINToolStripMenuItem.Text = "LOAD ALL AGAIN"
        '
        'LOADONLYCATEGORIESToolStripMenuItem
        '
        Me.LOADONLYCATEGORIESToolStripMenuItem.Name = "LOADONLYCATEGORIESToolStripMenuItem"
        Me.LOADONLYCATEGORIESToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.LOADONLYCATEGORIESToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.LOADONLYCATEGORIESToolStripMenuItem.Text = "LOAD ONLY CATEGORIES"
        '
        'LOADONLYCURRENTPRODUCTToolStripMenuItem
        '
        Me.LOADONLYCURRENTPRODUCTToolStripMenuItem.Name = "LOADONLYCURRENTPRODUCTToolStripMenuItem"
        Me.LOADONLYCURRENTPRODUCTToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.LOADONLYCURRENTPRODUCTToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.LOADONLYCURRENTPRODUCTToolStripMenuItem.Text = "LOAD ONLY CURRENT PRODUCT"
        '
        'EDITCATEGORIESToolStripMenuItem
        '
        Me.EDITCATEGORIESToolStripMenuItem.Name = "EDITCATEGORIESToolStripMenuItem"
        Me.EDITCATEGORIESToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.EDITCATEGORIESToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.EDITCATEGORIESToolStripMenuItem.Text = "EDIT CATEGORIES"
        '
        'EDITCURRENTCATEGORYGOODSToolStripMenuItem
        '
        Me.EDITCURRENTCATEGORYGOODSToolStripMenuItem.Name = "EDITCURRENTCATEGORYGOODSToolStripMenuItem"
        Me.EDITCURRENTCATEGORYGOODSToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.EDITCURRENTCATEGORYGOODSToolStripMenuItem.Text = "EDIT CURRENT  CATEGORY GOODS"
        '
        'DIRECTINPUTPRICEToolStripMenuItem
        '
        Me.DIRECTINPUTPRICEToolStripMenuItem.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.TITLE
        Me.DIRECTINPUTPRICEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PURCHASE_INPUT_TOOLtEXT, Me.BENEFIT_INPTU_TOOL, Me.WARRANTY_MONTHS_TOLL, Me.SAVEINDATABASEToolStripMenuItem, Me.SOLDTOCURRENTCLIENTToolStripMenuItem})
        Me.DIRECTINPUTPRICEToolStripMenuItem.Name = "DIRECTINPUTPRICEToolStripMenuItem"
        Me.DIRECTINPUTPRICEToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.DIRECTINPUTPRICEToolStripMenuItem.Text = "DIRECT INPUT PRICE"
        Me.DIRECTINPUTPRICEToolStripMenuItem.ToolTipText = "DIRECT SAVE CURRENT PRODUCT DEFAULT PURCHASE COST AND BENEFIT PRICE/SOLD PRICE"
        '
        'PURCHASE_INPUT_TOOLtEXT
        '
        Me.PURCHASE_INPUT_TOOLtEXT.BackColor = System.Drawing.Color.SkyBlue
        Me.PURCHASE_INPUT_TOOLtEXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PURCHASE_INPUT_TOOLtEXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PURCHASE_INPUT_TOOLtEXT.Name = "PURCHASE_INPUT_TOOLtEXT"
        Me.PURCHASE_INPUT_TOOLtEXT.Size = New System.Drawing.Size(100, 21)
        Me.PURCHASE_INPUT_TOOLtEXT.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PURCHASE_INPUT_TOOLtEXT.ToolTipText = "PURCHASE COST"
        '
        'BENEFIT_INPTU_TOOL
        '
        Me.BENEFIT_INPTU_TOOL.BackColor = System.Drawing.Color.SkyBlue
        Me.BENEFIT_INPTU_TOOL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BENEFIT_INPTU_TOOL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BENEFIT_INPTU_TOOL.Name = "BENEFIT_INPTU_TOOL"
        Me.BENEFIT_INPTU_TOOL.Size = New System.Drawing.Size(100, 21)
        Me.BENEFIT_INPTU_TOOL.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BENEFIT_INPTU_TOOL.ToolTipText = "BENEFIT COST"
        '
        'WARRANTY_MONTHS_TOLL
        '
        Me.WARRANTY_MONTHS_TOLL.BackColor = System.Drawing.Color.Azure
        Me.WARRANTY_MONTHS_TOLL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WARRANTY_MONTHS_TOLL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.WARRANTY_MONTHS_TOLL.Name = "WARRANTY_MONTHS_TOLL"
        Me.WARRANTY_MONTHS_TOLL.Size = New System.Drawing.Size(100, 21)
        Me.WARRANTY_MONTHS_TOLL.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WARRANTY_MONTHS_TOLL.ToolTipText = "WARRANTY MONTHS"
        '
        'SAVEINDATABASEToolStripMenuItem
        '
        Me.SAVEINDATABASEToolStripMenuItem.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources._3
        Me.SAVEINDATABASEToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SAVEINDATABASEToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAVEINDATABASEToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.saveHS
        Me.SAVEINDATABASEToolStripMenuItem.Name = "SAVEINDATABASEToolStripMenuItem"
        Me.SAVEINDATABASEToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVEINDATABASEToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.SAVEINDATABASEToolStripMenuItem.Text = "SAVE IN DATABASE"
        '
        'SOLDTOCURRENTCLIENTToolStripMenuItem
        '
        Me.SOLDTOCURRENTCLIENTToolStripMenuItem.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.BlackEverSl
        Me.SOLDTOCURRENTCLIENTToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SOLDTOCURRENTCLIENTToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.Small_imgs.AukRight2
        Me.SOLDTOCURRENTCLIENTToolStripMenuItem.Name = "SOLDTOCURRENTCLIENTToolStripMenuItem"
        Me.SOLDTOCURRENTCLIENTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SOLDTOCURRENTCLIENTToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.SOLDTOCURRENTCLIENTToolStripMenuItem.Text = "SOLD TO CURRENT CLIENT"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(265, 6)
        '
        'FUNCTIONSToolStripMenuItem
        '
        Me.FUNCTIONSToolStripMenuItem.Name = "FUNCTIONSToolStripMenuItem"
        Me.FUNCTIONSToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.FUNCTIONSToolStripMenuItem.Text = "FUNCTIONS"
        '
        'PSCATEGORYDISPSCollectionBindingSource
        '
        Me.PSCATEGORYDISPSCollectionBindingSource.DataMember = "PS_CATEGORY_DISPS_Collection"
        Me.PSCATEGORYDISPSCollectionBindingSource.DataSource = Me.PSSUBCATEGORYPSCATEGORYDISBindingSource
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
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 526)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 543)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ADD TO CURRENT CUSTOMER LIST"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Bluesky
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 187)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "SELECT EMPLOYEE NAME"
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.Azure
        Me.ComboBox4.DataSource = Me.PSEmployeBindingSource
        Me.ComboBox4.DisplayMember = "Employe_Name"
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(6, 154)
        Me.ComboBox4.MaxDropDownItems = 80
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(233, 23)
        Me.ComboBox4.TabIndex = 3
        '
        'PSEmployeBindingSource
        '
        Me.PSEmployeBindingSource.DataMember = "PS_Employe"
        Me.PSEmployeBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "DISPLAY CATEGORIES:"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.BackColor = System.Drawing.Color.Azure
        Me.ComboBox3.DataSource = Me.PSSUBCATEGORYPSCATEGORYDISBindingSource
        Me.ComboBox3.DisplayMember = "DISPLAY NAME"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(6, 114)
        Me.ComboBox3.MaxDropDownItems = 80
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(233, 23)
        Me.ComboBox3.TabIndex = 2
        Me.ComboBox3.ValueMember = "DISPLAY ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "SUB CATEGORIES:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CATEGORIES:"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.BackColor = System.Drawing.Color.Azure
        Me.ComboBox2.DataSource = Me.PSCATEGORYPSSUBCATEGORYBindingSource
        Me.ComboBox2.DisplayMember = "SUB_CATEGORY_NAME"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 72)
        Me.ComboBox2.MaxDropDownItems = 80
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(233, 23)
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
        Me.ComboBox1.Location = New System.Drawing.Point(6, 28)
        Me.ComboBox1.MaxDropDownItems = 80
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(233, 23)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.TabStop = False
        Me.ComboBox1.ValueMember = "CATEGORYID"
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(438, 31)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "ADD PRODUCT"
        Me.ToolTip1.SetToolTip(Me.Button6, "Add Product on Current List")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(490, 31)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "ADD"
        Me.ToolTip1.SetToolTip(Me.Button4, "Direct Add Product to Client Account")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(PAYMENT_CATEGORYLabel)
        Me.GroupBox2.Controls.Add(Me.PAYMENT_CATEGORYComboBox)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(REPORT_IDLabel)
        Me.GroupBox2.Controls.Add(Me.REPORT_IDTextBox)
        Me.GroupBox2.Controls.Add(TOTAL_AMOUNNTLabel)
        Me.GroupBox2.Controls.Add(Me.TOTAL_AMOUNNTTextBox)
        Me.GroupBox2.Controls.Add(INSTALLATION_CHARGELabel)
        Me.GroupBox2.Controls.Add(Me.INSTALLATION_CHARGETextBox)
        Me.GroupBox2.Controls.Add(VATLabel)
        Me.GroupBox2.Controls.Add(Me.VATTextBox)
        Me.GroupBox2.Controls.Add(TOTAL_DISCOUNTLabel)
        Me.GroupBox2.Controls.Add(Me.TOTAL_DISCOUNTTextBox)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 437)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(545, 106)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EXTRA INFORMATION"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.BlackEverSlPNG
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(445, 52)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 23)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "&HIDE"
        Me.ToolTip1.SetToolTip(Me.Button5, "HIDE CURRENT CIRCUMSTANCE")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PAYMENT_CATEGORYComboBox
        '
        Me.PAYMENT_CATEGORYComboBox.BackColor = System.Drawing.Color.Azure
        Me.PAYMENT_CATEGORYComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RP_IDBindingSource, "PAYMENT_CATEGORY", True))
        Me.PAYMENT_CATEGORYComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.RP_IDBindingSource, "PAYMENT_CATEGORY", True))
        Me.PAYMENT_CATEGORYComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PAYMENT_CATEGORYComboBox.FormattingEnabled = True
        Me.PAYMENT_CATEGORYComboBox.Items.AddRange(New Object() {"CASH", "CREDIT CARD", "BANK CHEQUE/CHECK", "NET PAYMENT"})
        Me.PAYMENT_CATEGORYComboBox.Location = New System.Drawing.Point(323, 27)
        Me.PAYMENT_CATEGORYComboBox.Name = "PAYMENT_CATEGORYComboBox"
        Me.PAYMENT_CATEGORYComboBox.Size = New System.Drawing.Size(214, 23)
        Me.PAYMENT_CATEGORYComboBox.TabIndex = 5
        '
        'RP_IDBindingSource
        '
        Me.RP_IDBindingSource.DataMember = "RP_ID"
        Me.RP_IDBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'TextBox2
        '
        Me.TextBox2.AutoCompleteCustomSource.AddRange(New String() {"WARRANTY IS VALID FOR  YEARS", "SERVICE IS VAILD FOR  YEARS"})
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "COMMENTS_RP_PS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Location = New System.Drawing.Point(323, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(214, 16)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = Global.CyberPack_Pro.My.MySettings.Default.COMMENTS_RP_PS
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TextBox2, "COMMENTS")
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.BlackEverSlPNG
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(323, 52)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "SETTINGS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'REPORT_IDTextBox
        '
        Me.REPORT_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.REPORT_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RP_IDBindingSource, "REPORT_ID", True))
        Me.REPORT_IDTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REPORT_IDTextBox.Location = New System.Drawing.Point(143, 18)
        Me.REPORT_IDTextBox.Name = "REPORT_IDTextBox"
        Me.REPORT_IDTextBox.ReadOnly = True
        Me.REPORT_IDTextBox.Size = New System.Drawing.Size(174, 15)
        Me.REPORT_IDTextBox.TabIndex = 0
        Me.REPORT_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TOTAL_AMOUNNTTextBox
        '
        Me.TOTAL_AMOUNNTTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.TOTAL_AMOUNNTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TOTAL_AMOUNNTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RP_IDBindingSource, "TOTAL AMOUNNT", True))
        Me.TOTAL_AMOUNNTTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL_AMOUNNTTextBox.Location = New System.Drawing.Point(143, 35)
        Me.TOTAL_AMOUNNTTextBox.Name = "TOTAL_AMOUNNTTextBox"
        Me.TOTAL_AMOUNNTTextBox.Size = New System.Drawing.Size(174, 15)
        Me.TOTAL_AMOUNNTTextBox.TabIndex = 1
        Me.TOTAL_AMOUNNTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'INSTALLATION_CHARGETextBox
        '
        Me.INSTALLATION_CHARGETextBox.BackColor = System.Drawing.Color.LightBlue
        Me.INSTALLATION_CHARGETextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.INSTALLATION_CHARGETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RP_IDBindingSource, "INSTALLATION_CHARGE", True))
        Me.INSTALLATION_CHARGETextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSTALLATION_CHARGETextBox.Location = New System.Drawing.Point(143, 52)
        Me.INSTALLATION_CHARGETextBox.Name = "INSTALLATION_CHARGETextBox"
        Me.INSTALLATION_CHARGETextBox.Size = New System.Drawing.Size(174, 15)
        Me.INSTALLATION_CHARGETextBox.TabIndex = 2
        Me.INSTALLATION_CHARGETextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VATTextBox
        '
        Me.VATTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.VATTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RP_IDBindingSource, "VAT", True))
        Me.VATTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VATTextBox.Location = New System.Drawing.Point(143, 69)
        Me.VATTextBox.Name = "VATTextBox"
        Me.VATTextBox.Size = New System.Drawing.Size(174, 15)
        Me.VATTextBox.TabIndex = 3
        Me.VATTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TOTAL_DISCOUNTTextBox
        '
        Me.TOTAL_DISCOUNTTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.TOTAL_DISCOUNTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TOTAL_DISCOUNTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RP_IDBindingSource, "TOTAL_DISCOUNT", True))
        Me.TOTAL_DISCOUNTTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL_DISCOUNTTextBox.Location = New System.Drawing.Point(143, 86)
        Me.TOTAL_DISCOUNTTextBox.Name = "TOTAL_DISCOUNTTextBox"
        Me.TOTAL_DISCOUNTTextBox.Size = New System.Drawing.Size(174, 15)
        Me.TOTAL_DISCOUNTTextBox.TabIndex = 4
        Me.TOTAL_DISCOUNTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SOLDIDDataGridViewTextBoxColumn, Me.DISPLAYIDDataGridViewTextBoxColumn, Me.PRODUCTNAMEDataGridViewTextBoxColumn, Me.PRODUCTSERIALDataGridViewTextBoxColumn, Me.CLIENTNAMEDataGridViewTextBoxColumn, Me.PURCHASECOSTDataGridViewTextBoxColumn, Me.SOLDPRICEDataGridViewTextBoxColumn, Me.DISCOUNTDataGridViewTextBoxColumn, Me.BENEFITDataGridViewTextBoxColumn, Me.SOLDDATEDataGridViewTextBoxColumn, Me.WARRANTYVALIDMONTHDataGridViewTextBoxColumn, Me.REPORTIDDataGridViewTextBoxColumn, Me.V_ID})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.DataGridView1.DataSource = Me.PSSOLDBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.DataGridView1.Location = New System.Drawing.Point(0, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.OrangeRed
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Size = New System.Drawing.Size(545, 328)
        Me.DataGridView1.TabIndex = 1
        '
        'SOLDIDDataGridViewTextBoxColumn
        '
        Me.SOLDIDDataGridViewTextBoxColumn.DataPropertyName = "SOLD_ID"
        Me.SOLDIDDataGridViewTextBoxColumn.Frozen = True
        Me.SOLDIDDataGridViewTextBoxColumn.HeaderText = "SOLD ID"
        Me.SOLDIDDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.SOLDIDDataGridViewTextBoxColumn.Name = "SOLDIDDataGridViewTextBoxColumn"
        Me.SOLDIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DISPLAYIDDataGridViewTextBoxColumn
        '
        Me.DISPLAYIDDataGridViewTextBoxColumn.DataPropertyName = "DISPLAY_ID"
        Me.DISPLAYIDDataGridViewTextBoxColumn.HeaderText = "DISPLAY_ID"
        Me.DISPLAYIDDataGridViewTextBoxColumn.Name = "DISPLAYIDDataGridViewTextBoxColumn"
        Me.DISPLAYIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DISPLAYIDDataGridViewTextBoxColumn.Visible = False
        '
        'PRODUCTNAMEDataGridViewTextBoxColumn
        '
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_NAME"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT NAME"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.MinimumWidth = 250
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.Name = "PRODUCTNAMEDataGridViewTextBoxColumn"
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODUCTNAMEDataGridViewTextBoxColumn.Width = 250
        '
        'PRODUCTSERIALDataGridViewTextBoxColumn
        '
        Me.PRODUCTSERIALDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_SERIAL"
        Me.PRODUCTSERIALDataGridViewTextBoxColumn.HeaderText = "PRODUCT SERIAL"
        Me.PRODUCTSERIALDataGridViewTextBoxColumn.MinimumWidth = 220
        Me.PRODUCTSERIALDataGridViewTextBoxColumn.Name = "PRODUCTSERIALDataGridViewTextBoxColumn"
        Me.PRODUCTSERIALDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODUCTSERIALDataGridViewTextBoxColumn.Width = 220
        '
        'CLIENTNAMEDataGridViewTextBoxColumn
        '
        Me.CLIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_NAME"
        Me.CLIENTNAMEDataGridViewTextBoxColumn.HeaderText = "CLIENT NAME"
        Me.CLIENTNAMEDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.CLIENTNAMEDataGridViewTextBoxColumn.Name = "CLIENTNAMEDataGridViewTextBoxColumn"
        Me.CLIENTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIENTNAMEDataGridViewTextBoxColumn.Visible = False
        Me.CLIENTNAMEDataGridViewTextBoxColumn.Width = 120
        '
        'PURCHASECOSTDataGridViewTextBoxColumn
        '
        Me.PURCHASECOSTDataGridViewTextBoxColumn.DataPropertyName = "PURCHASE_COST"
        Me.PURCHASECOSTDataGridViewTextBoxColumn.HeaderText = "PURCHASE_COST"
        Me.PURCHASECOSTDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.PURCHASECOSTDataGridViewTextBoxColumn.Name = "PURCHASECOSTDataGridViewTextBoxColumn"
        Me.PURCHASECOSTDataGridViewTextBoxColumn.ReadOnly = True
        Me.PURCHASECOSTDataGridViewTextBoxColumn.Visible = False
        Me.PURCHASECOSTDataGridViewTextBoxColumn.Width = 120
        '
        'SOLDPRICEDataGridViewTextBoxColumn
        '
        Me.SOLDPRICEDataGridViewTextBoxColumn.DataPropertyName = "SOLD_PRICE"
        Me.SOLDPRICEDataGridViewTextBoxColumn.HeaderText = "SOLD PRICE"
        Me.SOLDPRICEDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.SOLDPRICEDataGridViewTextBoxColumn.Name = "SOLDPRICEDataGridViewTextBoxColumn"
        Me.SOLDPRICEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SOLDPRICEDataGridViewTextBoxColumn.Width = 120
        '
        'DISCOUNTDataGridViewTextBoxColumn
        '
        Me.DISCOUNTDataGridViewTextBoxColumn.DataPropertyName = "DISCOUNT"
        Me.DISCOUNTDataGridViewTextBoxColumn.HeaderText = "DISCOUNT"
        Me.DISCOUNTDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.DISCOUNTDataGridViewTextBoxColumn.Name = "DISCOUNTDataGridViewTextBoxColumn"
        '
        'BENEFITDataGridViewTextBoxColumn
        '
        Me.BENEFITDataGridViewTextBoxColumn.DataPropertyName = "BENEFIT"
        Me.BENEFITDataGridViewTextBoxColumn.HeaderText = "BENEFIT"
        Me.BENEFITDataGridViewTextBoxColumn.Name = "BENEFITDataGridViewTextBoxColumn"
        Me.BENEFITDataGridViewTextBoxColumn.ReadOnly = True
        Me.BENEFITDataGridViewTextBoxColumn.Visible = False
        '
        'SOLDDATEDataGridViewTextBoxColumn
        '
        Me.SOLDDATEDataGridViewTextBoxColumn.DataPropertyName = "SOLD DATE"
        Me.SOLDDATEDataGridViewTextBoxColumn.HeaderText = "SOLD DATE"
        Me.SOLDDATEDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.SOLDDATEDataGridViewTextBoxColumn.Name = "SOLDDATEDataGridViewTextBoxColumn"
        Me.SOLDDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SOLDDATEDataGridViewTextBoxColumn.Visible = False
        '
        'WARRANTYVALIDMONTHDataGridViewTextBoxColumn
        '
        Me.WARRANTYVALIDMONTHDataGridViewTextBoxColumn.DataPropertyName = "WARRANTY_VALID_MONTH"
        Me.WARRANTYVALIDMONTHDataGridViewTextBoxColumn.HeaderText = "WARRANTY VALID MONTH"
        Me.WARRANTYVALIDMONTHDataGridViewTextBoxColumn.MinimumWidth = 220
        Me.WARRANTYVALIDMONTHDataGridViewTextBoxColumn.Name = "WARRANTYVALIDMONTHDataGridViewTextBoxColumn"
        Me.WARRANTYVALIDMONTHDataGridViewTextBoxColumn.ReadOnly = True
        Me.WARRANTYVALIDMONTHDataGridViewTextBoxColumn.Width = 220
        '
        'REPORTIDDataGridViewTextBoxColumn
        '
        Me.REPORTIDDataGridViewTextBoxColumn.DataPropertyName = "REPORT_ID"
        Me.REPORTIDDataGridViewTextBoxColumn.HeaderText = "REPORT ID"
        Me.REPORTIDDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.REPORTIDDataGridViewTextBoxColumn.Name = "REPORTIDDataGridViewTextBoxColumn"
        Me.REPORTIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'V_ID
        '
        Me.V_ID.DataPropertyName = "V_ID"
        Me.V_ID.DataSource = Me.AukDatabaseDataSet
        Me.V_ID.DisplayMember = "VENDOR.V_NAME"
        Me.V_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.V_ID.DisplayStyleForCurrentCellOnly = True
        Me.V_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.V_ID.HeaderText = "VENDOR NAME"
        Me.V_ID.MinimumWidth = 140
        Me.V_ID.Name = "V_ID"
        Me.V_ID.ReadOnly = True
        Me.V_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.V_ID.ValueMember = "VENDOR.V_ID"
        Me.V_ID.Width = 140
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SELECTEDROWSDELETEToolStripMenuItem, Me.ADDCURRENTINWARRAYSTOCKToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(296, 48)
        '
        'SELECTEDROWSDELETEToolStripMenuItem
        '
        Me.SELECTEDROWSDELETEToolStripMenuItem.Name = "SELECTEDROWSDELETEToolStripMenuItem"
        Me.SELECTEDROWSDELETEToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.SELECTEDROWSDELETEToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.SELECTEDROWSDELETEToolStripMenuItem.Text = "SELECTED ROWS DELETE"
        '
        'ADDCURRENTINWARRAYSTOCKToolStripMenuItem
        '
        Me.ADDCURRENTINWARRAYSTOCKToolStripMenuItem.Name = "ADDCURRENTINWARRAYSTOCKToolStripMenuItem"
        Me.ADDCURRENTINWARRAYSTOCKToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ADDCURRENTINWARRAYSTOCKToolStripMenuItem.Size = New System.Drawing.Size(295, 22)
        Me.ADDCURRENTINWARRAYSTOCKToolStripMenuItem.Text = "ADD CURRENT IN WARRAY STOCK"
        '
        'PSSOLDBindingSource
        '
        Me.PSSOLDBindingSource.DataMember = "PS_SOLD"
        Me.PSSOLDBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources._1
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.filter_combox, Me.ToolStripTextBox5, Me.ToolStripSeparator4, Me.ToolStripButton2, Me.WARRANTY_TXTBOX, Me.ToolStripSeparator5, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 543)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(545, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.TabStop = True
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SEARCHQUERYToolStripMenuItem, Me.SHOWTODAYSBENEFITToolStripMenuItem, Me.SUMMARYFORMToolStripMenuItem})
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel2.Text = "LOAD BY"
        '
        'SEARCHQUERYToolStripMenuItem
        '
        Me.SEARCHQUERYToolStripMenuItem.Name = "SEARCHQUERYToolStripMenuItem"
        Me.SEARCHQUERYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.SEARCHQUERYToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.SEARCHQUERYToolStripMenuItem.Text = "SEARCH/QUERY"
        '
        'SHOWTODAYSBENEFITToolStripMenuItem
        '
        Me.SHOWTODAYSBENEFITToolStripMenuItem.Name = "SHOWTODAYSBENEFITToolStripMenuItem"
        Me.SHOWTODAYSBENEFITToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.SHOWTODAYSBENEFITToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.SHOWTODAYSBENEFITToolStripMenuItem.Text = "SHOW TODAY'S BENEFIT"
        '
        'SUMMARYFORMToolStripMenuItem
        '
        Me.SUMMARYFORMToolStripMenuItem.Name = "SUMMARYFORMToolStripMenuItem"
        Me.SUMMARYFORMToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.SUMMARYFORMToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.SUMMARYFORMToolStripMenuItem.Text = "SUMMARY FORM"
        '
        'filter_combox
        '
        Me.filter_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filter_combox.DropDownWidth = 200
        Me.filter_combox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filter_combox.Items.AddRange(New Object() {"SOLD_ID", "REPORT_ID", "PRODUCT_SERIAL", "CLIENT_NAME", "PRODUCT_NAME", "SOLD DATE"})
        Me.filter_combox.Name = "filter_combox"
        Me.filter_combox.Size = New System.Drawing.Size(100, 25)
        Me.filter_combox.ToolTipText = "Search Field"
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox5.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolStripTextBox5.ToolTipText = resources.GetString("ToolStripTextBox5.ToolTipText")
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDTOWARRANTYDATABASEToolStripMenuItem, Me.SHOWWARRANTYDATABASEVIEWToolStripMenuItem, Me.ToolStripSeparator13, Me.HideCurrentFormToolStripMenuItem})
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripButton2.Text = "WARRANTY:"
        '
        'ADDTOWARRANTYDATABASEToolStripMenuItem
        '
        Me.ADDTOWARRANTYDATABASEToolStripMenuItem.Name = "ADDTOWARRANTYDATABASEToolStripMenuItem"
        Me.ADDTOWARRANTYDATABASEToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ADDTOWARRANTYDATABASEToolStripMenuItem.Size = New System.Drawing.Size(344, 22)
        Me.ADDTOWARRANTYDATABASEToolStripMenuItem.Text = "ADD/DISCHARGE TO WARRANTY DATABASE"
        '
        'SHOWWARRANTYDATABASEVIEWToolStripMenuItem
        '
        Me.SHOWWARRANTYDATABASEVIEWToolStripMenuItem.Name = "SHOWWARRANTYDATABASEVIEWToolStripMenuItem"
        Me.SHOWWARRANTYDATABASEVIEWToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.SHOWWARRANTYDATABASEVIEWToolStripMenuItem.Size = New System.Drawing.Size(344, 22)
        Me.SHOWWARRANTYDATABASEVIEWToolStripMenuItem.Text = "SHOW WARRANTY DATABASE VIEW"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(341, 6)
        '
        'HideCurrentFormToolStripMenuItem
        '
        Me.HideCurrentFormToolStripMenuItem.Name = "HideCurrentFormToolStripMenuItem"
        Me.HideCurrentFormToolStripMenuItem.ShortcutKeyDisplayString = "Alt/Ctrl+H"
        Me.HideCurrentFormToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HideCurrentFormToolStripMenuItem.Size = New System.Drawing.Size(344, 22)
        Me.HideCurrentFormToolStripMenuItem.Text = "&Hide Product Sold Form"
        '
        'WARRANTY_TXTBOX
        '
        Me.WARRANTY_TXTBOX.Name = "WARRANTY_TXTBOX"
        Me.WARRANTY_TXTBOX.Size = New System.Drawing.Size(100, 25)
        Me.WARRANTY_TXTBOX.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WARRANTY_TXTBOX.ToolTipText = "TYPE SOLD ID/PRODUCT SERIA FOR WARRANTY STOCKL."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.Image = Global.CyberPack_Pro.My.Resources.Resources.Printer
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripButton3.Text = "PRINT"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(438, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "ADD TO LIST"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Azure
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Location = New System.Drawing.Point(5, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(274, 23)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TextBox1, "ADD GOODS IN LIST IF MATCH BY ANY SERIES")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label5.Location = New System.Drawing.Point(3, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "GOODS SERIAL:"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BindingNavigator1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources._1
        Me.BindingNavigator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BindingNavigator1.BindingSource = Me.PSSOLDBindingSource
        Me.BindingNavigator1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripTextBox1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(2, 78)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(543, 25)
        Me.BindingNavigator1.Stretch = True
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorDeleteItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DeleteHS
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(61, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLIENTNAMEFOUCSToolStripMenuItem, Me.ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem, Me.FOCUSONGOODSCATEGORYToolStripMenuItem, Me.ToolStripSeparator11, Me.CANCELCURRENTPRODCUTSToolStripMenuItem, Me.SOLDGOODSTOCURRNETToolStripMenuItem})
        Me.ToolStripButton1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.CyberPack_Pro.My.Resources.VsImg.GoLtrHS
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripButton1.Text = "SOLD"
        '
        'CLIENTNAMEFOUCSToolStripMenuItem
        '
        Me.CLIENTNAMEFOUCSToolStripMenuItem.Name = "CLIENTNAMEFOUCSToolStripMenuItem"
        Me.CLIENTNAMEFOUCSToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.CLIENTNAMEFOUCSToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.CLIENTNAMEFOUCSToolStripMenuItem.Text = "CLIENT NAME FOCUS"
        '
        'ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem
        '
        Me.ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem.Name = "ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem"
        Me.ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem.Text = "ADD GOODS SERIAL TEXTBOX FOCUS"
        '
        'FOCUSONGOODSCATEGORYToolStripMenuItem
        '
        Me.FOCUSONGOODSCATEGORYToolStripMenuItem.Name = "FOCUSONGOODSCATEGORYToolStripMenuItem"
        Me.FOCUSONGOODSCATEGORYToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.FOCUSONGOODSCATEGORYToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.FOCUSONGOODSCATEGORYToolStripMenuItem.Text = "FOCUS ON GOODS CATEGORY"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(325, 6)
        '
        'CANCELCURRENTPRODCUTSToolStripMenuItem
        '
        Me.CANCELCURRENTPRODCUTSToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.Small_imgs.AukWrong
        Me.CANCELCURRENTPRODCUTSToolStripMenuItem.Name = "CANCELCURRENTPRODCUTSToolStripMenuItem"
        Me.CANCELCURRENTPRODCUTSToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CANCELCURRENTPRODCUTSToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.CANCELCURRENTPRODCUTSToolStripMenuItem.Text = "CANCEL CURRENT PRODCUTS"
        '
        'SOLDGOODSTOCURRNETToolStripMenuItem
        '
        Me.SOLDGOODSTOCURRNETToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.Small_imgs.AukRight2
        Me.SOLDGOODSTOCURRNETToolStripMenuItem.Name = "SOLDGOODSTOCURRNETToolStripMenuItem"
        Me.SOLDGOODSTOCURRNETToolStripMenuItem.ShortcutKeyDisplayString = "CTRL/ALT+S"
        Me.SOLDGOODSTOCURRNETToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SOLDGOODSTOCURRNETToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.SOLDGOODSTOCURRNETToolStripMenuItem.Text = "SOLD GOODS TO CURRENT CLIENT"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator12, Me.SHOWCLIENTEDITVIEWFORMToolStripMenuItem})
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripLabel1.Text = "CLIENT NAME"
        Me.ToolStripLabel1.ToolTipText = "TYPE CUSTOMER/CLIENT ID ;BY PRESSING CTRL+ENTER TO CREATE CLIENT/CUSTOMER ID."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = Global.CyberPack_Pro.My.Resources.VsImg.DeleteHS
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+C"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(278, 22)
        Me.ToolStripMenuItem1.Text = "CANCEL CURRENT PRODCUTS"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(275, 6)
        '
        'SHOWCLIENTEDITVIEWFORMToolStripMenuItem
        '
        Me.SHOWCLIENTEDITVIEWFORMToolStripMenuItem.Name = "SHOWCLIENTEDITVIEWFORMToolStripMenuItem"
        Me.SHOWCLIENTEDITVIEWFORMToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.SHOWCLIENTEDITVIEWFORMToolStripMenuItem.Text = "SHOW CLIENT EDIT VIEW FORM"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BackColor = System.Drawing.Color.LightCyan
        Me.ToolStripTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.MaxLength = 2000
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(117, 25)
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolStripTextBox1.ToolTipText = resources.GetString("ToolStripTextBox1.ToolTipText")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PRODUCTS/GOODS SOLD SYSTEM"
        '
        'PS_CATEGORYTableAdapter
        '
        Me.PS_CATEGORYTableAdapter.ClearBeforeFill = False
        '
        'PS_SUB_CATEGORYTableAdapter
        '
        Me.PS_SUB_CATEGORYTableAdapter.ClearBeforeFill = False
        '
        'PS_CATEGORY_DISTableAdapter
        '
        Me.PS_CATEGORY_DISTableAdapter.ClearBeforeFill = False
        '
        'PS_CollectionTableAdapter
        '
        Me.PS_CollectionTableAdapter.ClearBeforeFill = True
        '
        'PS_SOLDTableAdapter
        '
        Me.PS_SOLDTableAdapter.ClearBeforeFill = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 8000
        Me.ToolTip1.AutoPopDelay = 80000
        Me.ToolTip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 1600
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.UseAnimation = False
        Me.ToolTip1.UseFading = False
        '
        'PS_EmployeTableAdapter
        '
        Me.PS_EmployeTableAdapter.ClearBeforeFill = True
        '
        'PS_CLIENTSTableAdapter1
        '
        Me.PS_CLIENTSTableAdapter1.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RP_IDTableAdapter
        '
        Me.RP_IDTableAdapter.ClearBeforeFill = True
        '
        'PS_WARRANTYTableAdapter1
        '
        Me.PS_WARRANTYTableAdapter1.ClearBeforeFill = True
        '
        'V_WARTableAdapter1
        '
        Me.V_WARTableAdapter1.ClearBeforeFill = True
        '
        'VendorTableAdapter1
        '
        Me.VendorTableAdapter1.ClearBeforeFill = True
        '
        'VendorsList
        '
        Me.VendorsList.BackColor = System.Drawing.Color.Azure
        Me.VendorsList.DataSource = Me.VENDORBindingSource
        Me.VendorsList.DisplayMember = "V_NAME"
        Me.VendorsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VendorsList.FormattingEnabled = True
        Me.VendorsList.Location = New System.Drawing.Point(282, 55)
        Me.VendorsList.Name = "VendorsList"
        Me.VendorsList.Size = New System.Drawing.Size(155, 23)
        Me.VendorsList.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.VendorsList, "Vendors List")
        Me.VendorsList.ValueMember = "V_ID"
        '
        'VENDORBindingSource
        '
        Me.VENDORBindingSource.DataMember = "VENDOR"
        Me.VENDORBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'PS_SOLD
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.Backgroud
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(794, 568)
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PS_SOLD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTS/GOODS SOLD"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PSCATEGORYDISPSCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSSUBCATEGORYPSCATEGORYDISBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSCATEGORYPSSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PSEmployeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.RP_IDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PSSOLDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.VENDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents PSCATEGORYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PS_CATEGORYTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CATEGORYTableAdapter
    Friend WithEvents PSCATEGORYPSSUBCATEGORYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PS_SUB_CATEGORYTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_SUB_CATEGORYTableAdapter
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PSSUBCATEGORYPSCATEGORYDISBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PS_CATEGORY_DISTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CATEGORY_DISTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents PSCATEGORYDISPSCollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PS_CollectionTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CollectionTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PSSOLDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PS_SOLDTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_SOLDTableAdapter
    Friend WithEvents FINDBYSERIALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FILTERBYSERIALIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FILTERBYGOODSNAMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents PSEmployeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PS_EmployeTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_EmployeTableAdapter
    Friend WithEvents PS_CLIENTSTableAdapter1 As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CLIENTSTableAdapter
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SHOWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRODUCTNAMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRODUCTSERIALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents filter_combox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents WARRANTY_TXTBOX As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RP_IDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RP_IDTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.RP_IDTableAdapter
    Friend WithEvents REPORT_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TOTAL_AMOUNNTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents INSTALLATION_CHARGETextBox As System.Windows.Forms.TextBox
    Friend WithEvents VATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TOTAL_DISCOUNTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents CANCELCURRENTPRODCUTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SHOWCLIENTEDITVIEWFORMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents REMOVEFILTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FOCUSONGRIDVIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SEARCHQUERYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SEARCHQUERYINSTOCKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EDITINEDITORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LOADALLAGAINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOADONLYCATEGORIESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOADONLYCURRENTPRODUCTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITCATEGORIESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DIRECTINPUTPRICEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PURCHASE_INPUT_TOOLtEXT As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BENEFIT_INPTU_TOOL As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SAVEINDATABASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITCURRENTCATEGORYGOODSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WARRANTY_MONTHS_TOLL As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PAYMENT_CATEGORYComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SHOWTODAYSBENEFITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDTOWARRANTYDATABASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SHOWWARRANTYDATABASEVIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PS_WARRANTYTableAdapter1 As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_WARRANTYTableAdapter
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FUNCTIONSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SELECTEDROWSDELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDCURRENTINWARRAYSTOCKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CLIENTNAMEFOUCSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDGOODSSERIALTEXTBOXFOCUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FOCUSONGOODSCATEGORYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SOLDGOODSTOCURRNETToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUMMARYFORMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideCurrentFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SOLDTOCURRENTCLIENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SOLDIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISPLAYIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTSERIALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PURCHASECOSTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOLDPRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISCOUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BENEFITDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOLDDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WARRANTYVALIDMONTHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REPORTIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents V_ID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents V_WARTableAdapter1 As CyberPack_Pro.AukDatabaseDataSetTableAdapters.V_WARTableAdapter
    Friend WithEvents VendorTableAdapter1 As CyberPack_Pro.AukDatabaseDataSetTableAdapters.VENDORTableAdapter
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents VendorsList As System.Windows.Forms.ComboBox
    Friend WithEvents VENDORBindingSource As System.Windows.Forms.BindingSource
End Class
