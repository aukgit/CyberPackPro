<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSold
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
        Dim Label7 As System.Windows.Forms.Label
        Dim DVD_IDLabel As System.Windows.Forms.Label
        Dim TYPELabel As System.Windows.Forms.Label
        Dim VERSIONLabel As System.Windows.Forms.Label
        Dim NAMELabel As System.Windows.Forms.Label
        Dim PLACELabel As System.Windows.Forms.Label
        Dim SOLD_PRICELabel As System.Windows.Forms.Label
        Dim DISCOUNTLabel As System.Windows.Forms.Label
        Dim SELF_COLUMNLabel As System.Windows.Forms.Label
        Dim ADVANCE_TYPELabel As System.Windows.Forms.Label
        Dim SOLD_DATELabel As System.Windows.Forms.Label
        Dim DVD_IDLabel1 As System.Windows.Forms.Label
        Dim NAMELabel1 As System.Windows.Forms.Label
        Dim PLACELabel1 As System.Windows.Forms.Label
        Dim SOLD_PRICELabel1 As System.Windows.Forms.Label
        Dim DISCOUNTLabel1 As System.Windows.Forms.Label
        Dim SOLD_DATELabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSold))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox7 = New System.Windows.Forms.ComboBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AukDatabaseDataSet = New CYBERPACK_PRO.AukDatabaseDataSet
        Me.TypeTableAdapter = New CYBERPACK_PRO.AukDatabaseDataSetTableAdapters.TypeTableAdapter
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.DVD_IDLabel2 = New System.Windows.Forms.Label
        Me.SOLDVIEW_BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NAMELabel2 = New System.Windows.Forms.Label
        Me.PLACELabel2 = New System.Windows.Forms.Label
        Me.SOLD_PRICELabel2 = New System.Windows.Forms.Label
        Me.DISCOUNTLabel2 = New System.Windows.Forms.Label
        Me.SOLD_DATELabel2 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
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
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.DVD_IDTextBox = New System.Windows.Forms.TextBox
        Me.TYPETextBox = New System.Windows.Forms.TextBox
        Me.VERSIONTextBox = New System.Windows.Forms.TextBox
        Me.NAMETextBox = New System.Windows.Forms.TextBox
        Me.PLACETextBox = New System.Windows.Forms.TextBox
        Me.SOLD_PRICETextBox = New System.Windows.Forms.TextBox
        Me.DISCOUNTTextBox = New System.Windows.Forms.TextBox
        Me.SELF_COLUMNTextBox = New System.Windows.Forms.TextBox
        Me.ADVANCE_TYPETextBox = New System.Windows.Forms.TextBox
        Me.SOLD_DATEDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DVDIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PURCHASECOSTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TYPEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VERSIONDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NAMEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PLACEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SOLDPRICEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DISCOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SELFCOLUMNDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ADVANCETYPEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SOLDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SOLDSELECTEDITEMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SOLDSELECTITEMSANDDISCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.SOLDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DVDIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PURCHASECOSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VERSIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PLACEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SOLDPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DISCOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SELFCOLUMNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ADVANCETYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button2 = New System.Windows.Forms.Button
        Me.SOLD_VIEWTableAdapter = New CYBERPACK_PRO.AukDatabaseDataSetTableAdapters.SOLD_VIEWTableAdapter
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Label7 = New System.Windows.Forms.Label
        DVD_IDLabel = New System.Windows.Forms.Label
        TYPELabel = New System.Windows.Forms.Label
        VERSIONLabel = New System.Windows.Forms.Label
        NAMELabel = New System.Windows.Forms.Label
        PLACELabel = New System.Windows.Forms.Label
        SOLD_PRICELabel = New System.Windows.Forms.Label
        DISCOUNTLabel = New System.Windows.Forms.Label
        SELF_COLUMNLabel = New System.Windows.Forms.Label
        ADVANCE_TYPELabel = New System.Windows.Forms.Label
        SOLD_DATELabel = New System.Windows.Forms.Label
        DVD_IDLabel1 = New System.Windows.Forms.Label
        NAMELabel1 = New System.Windows.Forms.Label
        PLACELabel1 = New System.Windows.Forms.Label
        SOLD_PRICELabel1 = New System.Windows.Forms.Label
        DISCOUNTLabel1 = New System.Windows.Forms.Label
        SOLD_DATELabel1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SOLDVIEW_BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.Transparent
        Label7.Location = New System.Drawing.Point(21, 46)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(77, 15)
        Label7.TabIndex = 33
        Label7.Text = "FIND DVD ID:"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DVD_IDLabel
        '
        DVD_IDLabel.AutoSize = True
        DVD_IDLabel.BackColor = System.Drawing.Color.Transparent
        DVD_IDLabel.Location = New System.Drawing.Point(50, 73)
        DVD_IDLabel.Name = "DVD_IDLabel"
        DVD_IDLabel.Size = New System.Drawing.Size(48, 15)
        DVD_IDLabel.TabIndex = 33
        DVD_IDLabel.Text = "DVD ID:"
        '
        'TYPELabel
        '
        TYPELabel.AutoSize = True
        TYPELabel.BackColor = System.Drawing.Color.Transparent
        TYPELabel.Location = New System.Drawing.Point(63, 131)
        TYPELabel.Name = "TYPELabel"
        TYPELabel.Size = New System.Drawing.Size(35, 15)
        TYPELabel.TabIndex = 37
        TYPELabel.Text = "TYPE:"
        '
        'VERSIONLabel
        '
        VERSIONLabel.AutoSize = True
        VERSIONLabel.BackColor = System.Drawing.Color.Transparent
        VERSIONLabel.Location = New System.Drawing.Point(41, 160)
        VERSIONLabel.Name = "VERSIONLabel"
        VERSIONLabel.Size = New System.Drawing.Size(57, 15)
        VERSIONLabel.TabIndex = 39
        VERSIONLabel.Text = "VERSION:"
        '
        'NAMELabel
        '
        NAMELabel.AutoSize = True
        NAMELabel.BackColor = System.Drawing.Color.Transparent
        NAMELabel.Location = New System.Drawing.Point(56, 102)
        NAMELabel.Name = "NAMELabel"
        NAMELabel.Size = New System.Drawing.Size(42, 15)
        NAMELabel.TabIndex = 41
        NAMELabel.Text = "NAME:"
        '
        'PLACELabel
        '
        PLACELabel.AutoSize = True
        PLACELabel.BackColor = System.Drawing.Color.Transparent
        PLACELabel.Location = New System.Drawing.Point(56, 189)
        PLACELabel.Name = "PLACELabel"
        PLACELabel.Size = New System.Drawing.Size(42, 15)
        PLACELabel.TabIndex = 43
        PLACELabel.Text = "PLACE:"
        '
        'SOLD_PRICELabel
        '
        SOLD_PRICELabel.AutoSize = True
        SOLD_PRICELabel.BackColor = System.Drawing.Color.Transparent
        SOLD_PRICELabel.Location = New System.Drawing.Point(26, 218)
        SOLD_PRICELabel.Name = "SOLD_PRICELabel"
        SOLD_PRICELabel.Size = New System.Drawing.Size(72, 15)
        SOLD_PRICELabel.TabIndex = 45
        SOLD_PRICELabel.Text = "SOLD PRICE:"
        '
        'DISCOUNTLabel
        '
        DISCOUNTLabel.AutoSize = True
        DISCOUNTLabel.BackColor = System.Drawing.Color.Transparent
        DISCOUNTLabel.Location = New System.Drawing.Point(32, 247)
        DISCOUNTLabel.Name = "DISCOUNTLabel"
        DISCOUNTLabel.Size = New System.Drawing.Size(66, 15)
        DISCOUNTLabel.TabIndex = 47
        DISCOUNTLabel.Text = "DISCOUNT:"
        '
        'SELF_COLUMNLabel
        '
        SELF_COLUMNLabel.AutoSize = True
        SELF_COLUMNLabel.BackColor = System.Drawing.Color.Transparent
        SELF_COLUMNLabel.Location = New System.Drawing.Point(14, 276)
        SELF_COLUMNLabel.Name = "SELF_COLUMNLabel"
        SELF_COLUMNLabel.Size = New System.Drawing.Size(84, 15)
        SELF_COLUMNLabel.TabIndex = 49
        SELF_COLUMNLabel.Text = "SELF COLUMN:"
        '
        'ADVANCE_TYPELabel
        '
        ADVANCE_TYPELabel.AutoSize = True
        ADVANCE_TYPELabel.BackColor = System.Drawing.Color.Transparent
        ADVANCE_TYPELabel.Location = New System.Drawing.Point(11, 305)
        ADVANCE_TYPELabel.Name = "ADVANCE_TYPELabel"
        ADVANCE_TYPELabel.Size = New System.Drawing.Size(87, 15)
        ADVANCE_TYPELabel.TabIndex = 51
        ADVANCE_TYPELabel.Text = "ADVANCE TYPE:"
        '
        'SOLD_DATELabel
        '
        SOLD_DATELabel.AutoSize = True
        SOLD_DATELabel.BackColor = System.Drawing.Color.Transparent
        SOLD_DATELabel.Location = New System.Drawing.Point(31, 335)
        SOLD_DATELabel.Name = "SOLD_DATELabel"
        SOLD_DATELabel.Size = New System.Drawing.Size(67, 15)
        SOLD_DATELabel.TabIndex = 53
        SOLD_DATELabel.Text = "SOLD DATE:"
        '
        'DVD_IDLabel1
        '
        DVD_IDLabel1.AutoSize = True
        DVD_IDLabel1.BackColor = System.Drawing.Color.Transparent
        DVD_IDLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DVD_IDLabel1.Location = New System.Drawing.Point(26, 5)
        DVD_IDLabel1.Name = "DVD_IDLabel1"
        DVD_IDLabel1.Size = New System.Drawing.Size(48, 15)
        DVD_IDLabel1.TabIndex = 0
        DVD_IDLabel1.Text = "DVD ID:"
        '
        'NAMELabel1
        '
        NAMELabel1.AutoSize = True
        NAMELabel1.BackColor = System.Drawing.Color.Transparent
        NAMELabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NAMELabel1.Location = New System.Drawing.Point(32, 23)
        NAMELabel1.Name = "NAMELabel1"
        NAMELabel1.Size = New System.Drawing.Size(42, 15)
        NAMELabel1.TabIndex = 6
        NAMELabel1.Text = "NAME:"
        '
        'PLACELabel1
        '
        PLACELabel1.AutoSize = True
        PLACELabel1.BackColor = System.Drawing.Color.Transparent
        PLACELabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PLACELabel1.Location = New System.Drawing.Point(250, 5)
        PLACELabel1.Name = "PLACELabel1"
        PLACELabel1.Size = New System.Drawing.Size(42, 15)
        PLACELabel1.TabIndex = 8
        PLACELabel1.Text = "PLACE:"
        '
        'SOLD_PRICELabel1
        '
        SOLD_PRICELabel1.AutoSize = True
        SOLD_PRICELabel1.BackColor = System.Drawing.Color.Transparent
        SOLD_PRICELabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SOLD_PRICELabel1.Location = New System.Drawing.Point(2, 41)
        SOLD_PRICELabel1.Name = "SOLD_PRICELabel1"
        SOLD_PRICELabel1.Size = New System.Drawing.Size(72, 15)
        SOLD_PRICELabel1.TabIndex = 10
        SOLD_PRICELabel1.Text = "SOLD PRICE:"
        '
        'DISCOUNTLabel1
        '
        DISCOUNTLabel1.AutoSize = True
        DISCOUNTLabel1.BackColor = System.Drawing.Color.Transparent
        DISCOUNTLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DISCOUNTLabel1.Location = New System.Drawing.Point(8, 59)
        DISCOUNTLabel1.Name = "DISCOUNTLabel1"
        DISCOUNTLabel1.Size = New System.Drawing.Size(66, 15)
        DISCOUNTLabel1.TabIndex = 12
        DISCOUNTLabel1.Text = "DISCOUNT:"
        '
        'SOLD_DATELabel1
        '
        SOLD_DATELabel1.AutoSize = True
        SOLD_DATELabel1.BackColor = System.Drawing.Color.Transparent
        SOLD_DATELabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SOLD_DATELabel1.Location = New System.Drawing.Point(225, 20)
        SOLD_DATELabel1.Name = "SOLD_DATELabel1"
        SOLD_DATELabel1.Size = New System.Drawing.Size(67, 15)
        SOLD_DATELabel1.TabIndex = 14
        SOLD_DATELabel1.Text = "SOLD DATE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CYBERPACK_PRO.My.MySettings.Default, "SoftNamex", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = Global.CYBERPACK_PRO.My.MySettings.Default.SoftNamex
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DVD ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MOVIE NAME:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 76)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "AUK QUERY:"
        '
        'ComboBox7
        '
        Me.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"EXACT WORD", "EXACT FROM FIRST", "ANY WHERE IN FIELD", "ADVANCE(AND)", "ADVANCE(AND) FROM FIRST", "ADVANCE(OR)", "ADVANCE(OR) FROM FIRST", "ADVANCE(AND)[CHARACTER ARRAY]", "IN COMMAND(USE "","" TO CONCORD)", "EXTACT BUT CREATE ARRAY OF SPACE WORD", "BETWEEN(USE "","" KEY AND TYPE 2 WORDS)", "ADVANCE(OR)[CHR ARRAY]", "ADVANCE(AUK FAV)[USE "";"" KEYS FOR 'OR']"})
        Me.ComboBox7.Location = New System.Drawing.Point(90, 44)
        Me.ComboBox7.MaxDropDownItems = 15
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(430, 23)
        Me.ComboBox7.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(336, 18)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(185, 23)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(89, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 23)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(559, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 76)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SHOW BY MOVIE CATEGORY"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Small_imgs.B3
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(18, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "LOAD MOVIES"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TypeBindingSource
        Me.ComboBox1.DisplayMember = "Movie_Type_Name"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(18, 18)
        Me.ComboBox1.MaxDropDownItems = 60
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 23)
        Me.ComboBox1.TabIndex = 0
        '
        'TypeBindingSource
        '
        Me.TypeBindingSource.DataMember = "Type"
        Me.TypeBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TypeTableAdapter
        '
        Me.TypeTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 178)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(768, 391)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Small_imgs.B2
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.BindingNavigator1)
        Me.TabPage2.Controls.Add(DVD_IDLabel)
        Me.TabPage2.Controls.Add(Me.DVD_IDTextBox)
        Me.TabPage2.Controls.Add(TYPELabel)
        Me.TabPage2.Controls.Add(Me.TYPETextBox)
        Me.TabPage2.Controls.Add(VERSIONLabel)
        Me.TabPage2.Controls.Add(Me.VERSIONTextBox)
        Me.TabPage2.Controls.Add(NAMELabel)
        Me.TabPage2.Controls.Add(Me.NAMETextBox)
        Me.TabPage2.Controls.Add(PLACELabel)
        Me.TabPage2.Controls.Add(Me.PLACETextBox)
        Me.TabPage2.Controls.Add(SOLD_PRICELabel)
        Me.TabPage2.Controls.Add(Me.SOLD_PRICETextBox)
        Me.TabPage2.Controls.Add(DISCOUNTLabel)
        Me.TabPage2.Controls.Add(Me.DISCOUNTTextBox)
        Me.TabPage2.Controls.Add(SELF_COLUMNLabel)
        Me.TabPage2.Controls.Add(Me.SELF_COLUMNTextBox)
        Me.TabPage2.Controls.Add(ADVANCE_TYPELabel)
        Me.TabPage2.Controls.Add(Me.ADVANCE_TYPETextBox)
        Me.TabPage2.Controls.Add(SOLD_DATELabel)
        Me.TabPage2.Controls.Add(Me.SOLD_DATEDateTimePicker)
        Me.TabPage2.Controls.Add(Label7)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(760, 363)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "MOVIES SOLD"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Small_imgs.B2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(DVD_IDLabel1)
        Me.Panel1.Controls.Add(Me.DVD_IDLabel2)
        Me.Panel1.Controls.Add(NAMELabel1)
        Me.Panel1.Controls.Add(Me.NAMELabel2)
        Me.Panel1.Controls.Add(PLACELabel1)
        Me.Panel1.Controls.Add(Me.PLACELabel2)
        Me.Panel1.Controls.Add(SOLD_PRICELabel1)
        Me.Panel1.Controls.Add(Me.SOLD_PRICELabel2)
        Me.Panel1.Controls.Add(DISCOUNTLabel1)
        Me.Panel1.Controls.Add(Me.DISCOUNTLabel2)
        Me.Panel1.Controls.Add(SOLD_DATELabel1)
        Me.Panel1.Controls.Add(Me.SOLD_DATELabel2)
        Me.Panel1.Location = New System.Drawing.Point(348, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(409, 89)
        Me.Panel1.TabIndex = 62
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Small_imgs.B3
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = Global.CYBERPACK_PRO.My.Resources.VsImg.GotoShortcutsHS
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.Location = New System.Drawing.Point(266, 55)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 25)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "&CLOSE"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Small_imgs.B3
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.CYBERPACK_PRO.My.Resources.VsImg.PrintPreviewHS
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(337, 55)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 25)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "&PRINT"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DVD_IDLabel2
        '
        Me.DVD_IDLabel2.BackColor = System.Drawing.Color.Transparent
        Me.DVD_IDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "DVD ID", True))
        Me.DVD_IDLabel2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVD_IDLabel2.Location = New System.Drawing.Point(80, 5)
        Me.DVD_IDLabel2.Name = "DVD_IDLabel2"
        Me.DVD_IDLabel2.Size = New System.Drawing.Size(131, 15)
        Me.DVD_IDLabel2.TabIndex = 1
        '
        'SOLDVIEW_BindingSource1
        '
        Me.SOLDVIEW_BindingSource1.DataMember = "SOLD_VIEW"
        Me.SOLDVIEW_BindingSource1.DataSource = Me.AukDatabaseDataSet
        Me.SOLDVIEW_BindingSource1.Filter = "PLACE='INSTORE'"
        '
        'NAMELabel2
        '
        Me.NAMELabel2.BackColor = System.Drawing.Color.Transparent
        Me.NAMELabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "NAME", True))
        Me.NAMELabel2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAMELabel2.Location = New System.Drawing.Point(80, 23)
        Me.NAMELabel2.Name = "NAMELabel2"
        Me.NAMELabel2.Size = New System.Drawing.Size(139, 15)
        Me.NAMELabel2.TabIndex = 7
        '
        'PLACELabel2
        '
        Me.PLACELabel2.BackColor = System.Drawing.Color.Transparent
        Me.PLACELabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "PLACE", True))
        Me.PLACELabel2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLACELabel2.Location = New System.Drawing.Point(298, 5)
        Me.PLACELabel2.Name = "PLACELabel2"
        Me.PLACELabel2.Size = New System.Drawing.Size(100, 15)
        Me.PLACELabel2.TabIndex = 9
        '
        'SOLD_PRICELabel2
        '
        Me.SOLD_PRICELabel2.BackColor = System.Drawing.Color.Transparent
        Me.SOLD_PRICELabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "SOLD PRICE", True))
        Me.SOLD_PRICELabel2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SOLD_PRICELabel2.Location = New System.Drawing.Point(80, 41)
        Me.SOLD_PRICELabel2.Name = "SOLD_PRICELabel2"
        Me.SOLD_PRICELabel2.Size = New System.Drawing.Size(131, 15)
        Me.SOLD_PRICELabel2.TabIndex = 11
        '
        'DISCOUNTLabel2
        '
        Me.DISCOUNTLabel2.BackColor = System.Drawing.Color.Transparent
        Me.DISCOUNTLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "DISCOUNT", True))
        Me.DISCOUNTLabel2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DISCOUNTLabel2.Location = New System.Drawing.Point(80, 59)
        Me.DISCOUNTLabel2.Name = "DISCOUNTLabel2"
        Me.DISCOUNTLabel2.Size = New System.Drawing.Size(131, 15)
        Me.DISCOUNTLabel2.TabIndex = 13
        '
        'SOLD_DATELabel2
        '
        Me.SOLD_DATELabel2.BackColor = System.Drawing.Color.Transparent
        Me.SOLD_DATELabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "SOLD DATE", True))
        Me.SOLD_DATELabel2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SOLD_DATELabel2.Location = New System.Drawing.Point(298, 20)
        Me.SOLD_DATELabel2.Name = "SOLD_DATELabel2"
        Me.SOLD_DATELabel2.Size = New System.Drawing.Size(100, 15)
        Me.SOLD_DATELabel2.TabIndex = 15
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(462, 81)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(292, 16)
        Me.TextBox4.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(348, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(409, 22)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "CHECK MOVIE ID"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Image = Global.CYBERPACK_PRO.My.Resources.Small_imgs.AukRight
        Me.PictureBox2.Location = New System.Drawing.Point(348, 43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(380, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(377, 35)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = " MOVIES PARAMETER"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.UseCompatibleTextRendering = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(622, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 18)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "AukOrganization"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CYBERPACK_PRO.My.Resources.Resources.IcoAukSoft_copy
        Me.PictureBox1.Location = New System.Drawing.Point(602, 265)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 75)
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BindingNavigator1.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Small_imgs.TITLE
        Me.BindingNavigator1.BindingSource = Me.SOLDVIEW_BindingSource1
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel2, Me.ToolStripSeparator4, Me.ToolStripButton1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripSeparator3})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(754, 25)
        Me.BindingNavigator1.TabIndex = 55
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.IsLink = True
        Me.ToolStripLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel2.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripLabel2.Text = "&QUERY MANAGER"
        Me.ToolStripLabel2.VisitedLinkColor = System.Drawing.Color.LightSkyBlue
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.CYBERPACK_PRO.My.Resources.VsImg.saveHS
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripButton1.Text = "SUBMIT SOLD INFORMATION"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel1.IsLink = True
        Me.ToolStripLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel1.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel1.LinkVisited = True
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripLabel1.Text = "SETTINGS"
        Me.ToolStripLabel1.VisitedLinkColor = System.Drawing.Color.RoyalBlue
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'DVD_IDTextBox
        '
        Me.DVD_IDTextBox.BackColor = System.Drawing.Color.White
        Me.DVD_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "DVD ID", True))
        Me.DVD_IDTextBox.Location = New System.Drawing.Point(104, 69)
        Me.DVD_IDTextBox.Name = "DVD_IDTextBox"
        Me.DVD_IDTextBox.ReadOnly = True
        Me.DVD_IDTextBox.Size = New System.Drawing.Size(238, 23)
        Me.DVD_IDTextBox.TabIndex = 34
        Me.DVD_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TYPETextBox
        '
        Me.TYPETextBox.BackColor = System.Drawing.Color.White
        Me.TYPETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "TYPE", True))
        Me.TYPETextBox.Location = New System.Drawing.Point(104, 127)
        Me.TYPETextBox.Name = "TYPETextBox"
        Me.TYPETextBox.ReadOnly = True
        Me.TYPETextBox.Size = New System.Drawing.Size(238, 23)
        Me.TYPETextBox.TabIndex = 38
        Me.TYPETextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VERSIONTextBox
        '
        Me.VERSIONTextBox.BackColor = System.Drawing.Color.White
        Me.VERSIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "VERSION", True))
        Me.VERSIONTextBox.Location = New System.Drawing.Point(104, 156)
        Me.VERSIONTextBox.Name = "VERSIONTextBox"
        Me.VERSIONTextBox.ReadOnly = True
        Me.VERSIONTextBox.Size = New System.Drawing.Size(238, 23)
        Me.VERSIONTextBox.TabIndex = 40
        Me.VERSIONTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NAMETextBox
        '
        Me.NAMETextBox.BackColor = System.Drawing.Color.White
        Me.NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "NAME", True))
        Me.NAMETextBox.Location = New System.Drawing.Point(104, 98)
        Me.NAMETextBox.Name = "NAMETextBox"
        Me.NAMETextBox.ReadOnly = True
        Me.NAMETextBox.Size = New System.Drawing.Size(238, 23)
        Me.NAMETextBox.TabIndex = 42
        Me.NAMETextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PLACETextBox
        '
        Me.PLACETextBox.BackColor = System.Drawing.Color.White
        Me.PLACETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "PLACE", True))
        Me.PLACETextBox.Location = New System.Drawing.Point(104, 185)
        Me.PLACETextBox.Name = "PLACETextBox"
        Me.PLACETextBox.ReadOnly = True
        Me.PLACETextBox.Size = New System.Drawing.Size(238, 23)
        Me.PLACETextBox.TabIndex = 44
        Me.PLACETextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SOLD_PRICETextBox
        '
        Me.SOLD_PRICETextBox.BackColor = System.Drawing.Color.White
        Me.SOLD_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "SOLD PRICE", True))
        Me.SOLD_PRICETextBox.Location = New System.Drawing.Point(104, 214)
        Me.SOLD_PRICETextBox.Name = "SOLD_PRICETextBox"
        Me.SOLD_PRICETextBox.ReadOnly = True
        Me.SOLD_PRICETextBox.Size = New System.Drawing.Size(238, 23)
        Me.SOLD_PRICETextBox.TabIndex = 46
        Me.SOLD_PRICETextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DISCOUNTTextBox
        '
        Me.DISCOUNTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "DISCOUNT", True))
        Me.DISCOUNTTextBox.Location = New System.Drawing.Point(104, 243)
        Me.DISCOUNTTextBox.Name = "DISCOUNTTextBox"
        Me.DISCOUNTTextBox.Size = New System.Drawing.Size(238, 23)
        Me.DISCOUNTTextBox.TabIndex = 48
        Me.DISCOUNTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SELF_COLUMNTextBox
        '
        Me.SELF_COLUMNTextBox.BackColor = System.Drawing.Color.White
        Me.SELF_COLUMNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "SELF COLUMN", True))
        Me.SELF_COLUMNTextBox.Location = New System.Drawing.Point(104, 272)
        Me.SELF_COLUMNTextBox.Name = "SELF_COLUMNTextBox"
        Me.SELF_COLUMNTextBox.ReadOnly = True
        Me.SELF_COLUMNTextBox.Size = New System.Drawing.Size(238, 23)
        Me.SELF_COLUMNTextBox.TabIndex = 50
        Me.SELF_COLUMNTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ADVANCE_TYPETextBox
        '
        Me.ADVANCE_TYPETextBox.BackColor = System.Drawing.Color.White
        Me.ADVANCE_TYPETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SOLDVIEW_BindingSource1, "ADVANCE TYPE", True))
        Me.ADVANCE_TYPETextBox.Location = New System.Drawing.Point(104, 301)
        Me.ADVANCE_TYPETextBox.Name = "ADVANCE_TYPETextBox"
        Me.ADVANCE_TYPETextBox.ReadOnly = True
        Me.ADVANCE_TYPETextBox.Size = New System.Drawing.Size(238, 23)
        Me.ADVANCE_TYPETextBox.TabIndex = 52
        Me.ADVANCE_TYPETextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SOLD_DATEDateTimePicker
        '
        Me.SOLD_DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SOLDVIEW_BindingSource1, "SOLD DATE", True))
        Me.SOLD_DATEDateTimePicker.Location = New System.Drawing.Point(104, 330)
        Me.SOLD_DATEDateTimePicker.Name = "SOLD_DATEDateTimePicker"
        Me.SOLD_DATEDateTimePicker.Size = New System.Drawing.Size(238, 23)
        Me.SOLD_DATEDateTimePicker.TabIndex = 54
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Location = New System.Drawing.Point(104, 43)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(238, 23)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TextBox3, "FIND DVDID")
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(760, 363)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "MOVIES VIEW"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DVDIDDataGridViewTextBoxColumn1, Me.PURCHASECOSTDataGridViewTextBoxColumn1, Me.TYPEDataGridViewTextBoxColumn1, Me.VERSIONDataGridViewTextBoxColumn1, Me.NAMEDataGridViewTextBoxColumn1, Me.PLACEDataGridViewTextBoxColumn1, Me.SOLDPRICEDataGridViewTextBoxColumn1, Me.DISCOUNTDataGridViewTextBoxColumn, Me.SELFCOLUMNDataGridViewTextBoxColumn1, Me.ADVANCETYPEDataGridViewTextBoxColumn1, Me.SOLDDATEDataGridViewTextBoxColumn})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.DataSource = Me.SOLDVIEW_BindingSource1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(754, 357)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.VirtualMode = True
        '
        'DVDIDDataGridViewTextBoxColumn1
        '
        Me.DVDIDDataGridViewTextBoxColumn1.DataPropertyName = "DVD ID"
        Me.DVDIDDataGridViewTextBoxColumn1.Frozen = True
        Me.DVDIDDataGridViewTextBoxColumn1.HeaderText = "DVD ID"
        Me.DVDIDDataGridViewTextBoxColumn1.MinimumWidth = 100
        Me.DVDIDDataGridViewTextBoxColumn1.Name = "DVDIDDataGridViewTextBoxColumn1"
        Me.DVDIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PURCHASECOSTDataGridViewTextBoxColumn1
        '
        Me.PURCHASECOSTDataGridViewTextBoxColumn1.DataPropertyName = "PURCHASE COST"
        Me.PURCHASECOSTDataGridViewTextBoxColumn1.HeaderText = "PURCHASE COST"
        Me.PURCHASECOSTDataGridViewTextBoxColumn1.MinimumWidth = 140
        Me.PURCHASECOSTDataGridViewTextBoxColumn1.Name = "PURCHASECOSTDataGridViewTextBoxColumn1"
        Me.PURCHASECOSTDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PURCHASECOSTDataGridViewTextBoxColumn1.Visible = False
        Me.PURCHASECOSTDataGridViewTextBoxColumn1.Width = 140
        '
        'TYPEDataGridViewTextBoxColumn1
        '
        Me.TYPEDataGridViewTextBoxColumn1.DataPropertyName = "TYPE"
        Me.TYPEDataGridViewTextBoxColumn1.HeaderText = "TYPE"
        Me.TYPEDataGridViewTextBoxColumn1.MinimumWidth = 200
        Me.TYPEDataGridViewTextBoxColumn1.Name = "TYPEDataGridViewTextBoxColumn1"
        Me.TYPEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TYPEDataGridViewTextBoxColumn1.Width = 200
        '
        'VERSIONDataGridViewTextBoxColumn1
        '
        Me.VERSIONDataGridViewTextBoxColumn1.DataPropertyName = "VERSION"
        Me.VERSIONDataGridViewTextBoxColumn1.HeaderText = "VERSION"
        Me.VERSIONDataGridViewTextBoxColumn1.MinimumWidth = 150
        Me.VERSIONDataGridViewTextBoxColumn1.Name = "VERSIONDataGridViewTextBoxColumn1"
        Me.VERSIONDataGridViewTextBoxColumn1.ReadOnly = True
        Me.VERSIONDataGridViewTextBoxColumn1.Width = 150
        '
        'NAMEDataGridViewTextBoxColumn1
        '
        Me.NAMEDataGridViewTextBoxColumn1.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn1.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn1.MinimumWidth = 250
        Me.NAMEDataGridViewTextBoxColumn1.Name = "NAMEDataGridViewTextBoxColumn1"
        Me.NAMEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NAMEDataGridViewTextBoxColumn1.Width = 250
        '
        'PLACEDataGridViewTextBoxColumn1
        '
        Me.PLACEDataGridViewTextBoxColumn1.DataPropertyName = "PLACE"
        Me.PLACEDataGridViewTextBoxColumn1.HeaderText = "PLACE"
        Me.PLACEDataGridViewTextBoxColumn1.MinimumWidth = 120
        Me.PLACEDataGridViewTextBoxColumn1.Name = "PLACEDataGridViewTextBoxColumn1"
        Me.PLACEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PLACEDataGridViewTextBoxColumn1.Width = 120
        '
        'SOLDPRICEDataGridViewTextBoxColumn1
        '
        Me.SOLDPRICEDataGridViewTextBoxColumn1.DataPropertyName = "SOLD PRICE"
        Me.SOLDPRICEDataGridViewTextBoxColumn1.HeaderText = "SOLD PRICE"
        Me.SOLDPRICEDataGridViewTextBoxColumn1.MinimumWidth = 120
        Me.SOLDPRICEDataGridViewTextBoxColumn1.Name = "SOLDPRICEDataGridViewTextBoxColumn1"
        Me.SOLDPRICEDataGridViewTextBoxColumn1.Width = 120
        '
        'DISCOUNTDataGridViewTextBoxColumn
        '
        Me.DISCOUNTDataGridViewTextBoxColumn.DataPropertyName = "DISCOUNT"
        Me.DISCOUNTDataGridViewTextBoxColumn.HeaderText = "DISCOUNT"
        Me.DISCOUNTDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.DISCOUNTDataGridViewTextBoxColumn.Name = "DISCOUNTDataGridViewTextBoxColumn"
        Me.DISCOUNTDataGridViewTextBoxColumn.Width = 120
        '
        'SELFCOLUMNDataGridViewTextBoxColumn1
        '
        Me.SELFCOLUMNDataGridViewTextBoxColumn1.DataPropertyName = "SELF COLUMN"
        Me.SELFCOLUMNDataGridViewTextBoxColumn1.HeaderText = "SELF COLUMN"
        Me.SELFCOLUMNDataGridViewTextBoxColumn1.MinimumWidth = 130
        Me.SELFCOLUMNDataGridViewTextBoxColumn1.Name = "SELFCOLUMNDataGridViewTextBoxColumn1"
        Me.SELFCOLUMNDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SELFCOLUMNDataGridViewTextBoxColumn1.Width = 130
        '
        'ADVANCETYPEDataGridViewTextBoxColumn1
        '
        Me.ADVANCETYPEDataGridViewTextBoxColumn1.DataPropertyName = "ADVANCE TYPE"
        Me.ADVANCETYPEDataGridViewTextBoxColumn1.HeaderText = "ADVANCE TYPE"
        Me.ADVANCETYPEDataGridViewTextBoxColumn1.MinimumWidth = 350
        Me.ADVANCETYPEDataGridViewTextBoxColumn1.Name = "ADVANCETYPEDataGridViewTextBoxColumn1"
        Me.ADVANCETYPEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ADVANCETYPEDataGridViewTextBoxColumn1.Width = 350
        '
        'SOLDDATEDataGridViewTextBoxColumn
        '
        Me.SOLDDATEDataGridViewTextBoxColumn.DataPropertyName = "SOLD DATE"
        Me.SOLDDATEDataGridViewTextBoxColumn.HeaderText = "SOLD DATE"
        Me.SOLDDATEDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.SOLDDATEDataGridViewTextBoxColumn.Name = "SOLDDATEDataGridViewTextBoxColumn"
        Me.SOLDDATEDataGridViewTextBoxColumn.Width = 120
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SOLDSELECTEDITEMSToolStripMenuItem, Me.SOLDSELECTITEMSANDDISCOUNTToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(252, 48)
        '
        'SOLDSELECTEDITEMSToolStripMenuItem
        '
        Me.SOLDSELECTEDITEMSToolStripMenuItem.Name = "SOLDSELECTEDITEMSToolStripMenuItem"
        Me.SOLDSELECTEDITEMSToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.SOLDSELECTEDITEMSToolStripMenuItem.Text = "SOLD SELECTED ITEMS"
        '
        'SOLDSELECTITEMSANDDISCOUNTToolStripMenuItem
        '
        Me.SOLDSELECTITEMSANDDISCOUNTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.SOLDToolStripMenuItem})
        Me.SOLDSELECTITEMSANDDISCOUNTToolStripMenuItem.Name = "SOLDSELECTITEMSANDDISCOUNTToolStripMenuItem"
        Me.SOLDSELECTITEMSANDDISCOUNTToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.SOLDSELECTITEMSANDDISCOUNTToolStripMenuItem.Text = "SOLD SELECT ITEMS AND DISCOUNT"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        '
        'SOLDToolStripMenuItem
        '
        Me.SOLDToolStripMenuItem.Name = "SOLDToolStripMenuItem"
        Me.SOLDToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SOLDToolStripMenuItem.Text = "SOLD"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(-1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(774, 24)
        Me.Label5.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(779, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 24)
        Me.Label6.TabIndex = 7
        '
        'DVDIDDataGridViewTextBoxColumn
        '
        Me.DVDIDDataGridViewTextBoxColumn.DataPropertyName = "DVD ID"
        Me.DVDIDDataGridViewTextBoxColumn.HeaderText = "DVD ID"
        Me.DVDIDDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.DVDIDDataGridViewTextBoxColumn.Name = "DVDIDDataGridViewTextBoxColumn"
        Me.DVDIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DVDIDDataGridViewTextBoxColumn.Width = 120
        '
        'PURCHASECOSTDataGridViewTextBoxColumn
        '
        Me.PURCHASECOSTDataGridViewTextBoxColumn.DataPropertyName = "PURCHASE COST"
        Me.PURCHASECOSTDataGridViewTextBoxColumn.HeaderText = "PURCHASE COST"
        Me.PURCHASECOSTDataGridViewTextBoxColumn.MinimumWidth = 140
        Me.PURCHASECOSTDataGridViewTextBoxColumn.Name = "PURCHASECOSTDataGridViewTextBoxColumn"
        Me.PURCHASECOSTDataGridViewTextBoxColumn.Visible = False
        Me.PURCHASECOSTDataGridViewTextBoxColumn.Width = 140
        '
        'TYPEDataGridViewTextBoxColumn
        '
        Me.TYPEDataGridViewTextBoxColumn.DataPropertyName = "TYPE"
        Me.TYPEDataGridViewTextBoxColumn.HeaderText = "TYPE"
        Me.TYPEDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.TYPEDataGridViewTextBoxColumn.Name = "TYPEDataGridViewTextBoxColumn"
        Me.TYPEDataGridViewTextBoxColumn.ReadOnly = True
        Me.TYPEDataGridViewTextBoxColumn.Width = 150
        '
        'VERSIONDataGridViewTextBoxColumn
        '
        Me.VERSIONDataGridViewTextBoxColumn.DataPropertyName = "VERSION"
        Me.VERSIONDataGridViewTextBoxColumn.HeaderText = "VERSION"
        Me.VERSIONDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.VERSIONDataGridViewTextBoxColumn.Name = "VERSIONDataGridViewTextBoxColumn"
        Me.VERSIONDataGridViewTextBoxColumn.Width = 150
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.MinimumWidth = 250
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        Me.NAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.NAMEDataGridViewTextBoxColumn.Width = 250
        '
        'PLACEDataGridViewTextBoxColumn
        '
        Me.PLACEDataGridViewTextBoxColumn.DataPropertyName = "PLACE"
        Me.PLACEDataGridViewTextBoxColumn.HeaderText = "PLACE"
        Me.PLACEDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.PLACEDataGridViewTextBoxColumn.Name = "PLACEDataGridViewTextBoxColumn"
        Me.PLACEDataGridViewTextBoxColumn.Width = 120
        '
        'SOLDPRICEDataGridViewTextBoxColumn
        '
        Me.SOLDPRICEDataGridViewTextBoxColumn.DataPropertyName = "SOLD PRICE"
        Me.SOLDPRICEDataGridViewTextBoxColumn.HeaderText = "SOLD PRICE"
        Me.SOLDPRICEDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.SOLDPRICEDataGridViewTextBoxColumn.Name = "SOLDPRICEDataGridViewTextBoxColumn"
        Me.SOLDPRICEDataGridViewTextBoxColumn.Width = 120
        '
        'DISCOUNT
        '
        Me.DISCOUNT.DataPropertyName = "DISCOUNT"
        Me.DISCOUNT.HeaderText = "DISCOUNT"
        Me.DISCOUNT.Name = "DISCOUNT"
        '
        'SELFCOLUMNDataGridViewTextBoxColumn
        '
        Me.SELFCOLUMNDataGridViewTextBoxColumn.DataPropertyName = "SELF COLUMN"
        Me.SELFCOLUMNDataGridViewTextBoxColumn.HeaderText = "SELF COLUMN"
        Me.SELFCOLUMNDataGridViewTextBoxColumn.MinimumWidth = 120
        Me.SELFCOLUMNDataGridViewTextBoxColumn.Name = "SELFCOLUMNDataGridViewTextBoxColumn"
        Me.SELFCOLUMNDataGridViewTextBoxColumn.ReadOnly = True
        Me.SELFCOLUMNDataGridViewTextBoxColumn.Width = 120
        '
        'ADVANCETYPEDataGridViewTextBoxColumn
        '
        Me.ADVANCETYPEDataGridViewTextBoxColumn.DataPropertyName = "ADVANCE TYPE"
        Me.ADVANCETYPEDataGridViewTextBoxColumn.HeaderText = "ADVANCE TYPE"
        Me.ADVANCETYPEDataGridViewTextBoxColumn.MinimumWidth = 220
        Me.ADVANCETYPEDataGridViewTextBoxColumn.Name = "ADVANCETYPEDataGridViewTextBoxColumn"
        Me.ADVANCETYPEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ADVANCETYPEDataGridViewTextBoxColumn.Width = 220
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Small_imgs.B3
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.CYBERPACK_PRO.My.Resources.VsImg.saveHS
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(580, 574)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 25)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "&SUBMIT SOLD INFORMATION"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'SOLD_VIEWTableAdapter
        '
        Me.SOLD_VIEWTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Small_imgs.B3
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.CYBERPACK_PRO.My.Resources.VsImg.PrintPreviewHS
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(512, 574)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 25)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "&PRINT"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Small_imgs.B3
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(698, 27)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 26)
        Me.Button6.TabIndex = 63
        Me.Button6.Text = "LOAD WHOLE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Small_imgs.B3
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(593, 27)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(103, 26)
        Me.Button7.TabIndex = 64
        Me.Button7.Text = "REMOVE FILTER"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'MSold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CYBERPACK_PRO.My.MySettings.Default, "SoftNamex", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MSold"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = Global.CYBERPACK_PRO.My.MySettings.Default.SoftNamex
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SOLDVIEW_BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents AukDatabaseDataSet As CYBERPACK_PRO.AukDatabaseDataSet
    Friend WithEvents TypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypeTableAdapter As CYBERPACK_PRO.AukDatabaseDataSetTableAdapters.TypeTableAdapter
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SOLDVIEW_BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DVDIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PURCHASECOSTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VERSIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLACEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOLDPRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISCOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SELFCOLUMNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADVANCETYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SOLDSELECTEDITEMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SOLDSELECTITEMSANDDISCOUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SOLDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents DVD_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TYPETextBox As System.Windows.Forms.TextBox
    Friend WithEvents VERSIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PLACETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SOLD_PRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DISCOUNTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SELF_COLUMNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ADVANCE_TYPETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SOLD_DATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SOLD_VIEWTableAdapter As CYBERPACK_PRO.AukDatabaseDataSetTableAdapters.SOLD_VIEWTableAdapter
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DVDIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PURCHASECOSTDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TYPEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VERSIONDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLACEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOLDPRICEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISCOUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SELFCOLUMNDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADVANCETYPEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOLDDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DVD_IDLabel2 As System.Windows.Forms.Label
    Friend WithEvents NAMELabel2 As System.Windows.Forms.Label
    Friend WithEvents PLACELabel2 As System.Windows.Forms.Label
    Friend WithEvents SOLD_PRICELabel2 As System.Windows.Forms.Label
    Friend WithEvents DISCOUNTLabel2 As System.Windows.Forms.Label
    Friend WithEvents SOLD_DATELabel2 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
