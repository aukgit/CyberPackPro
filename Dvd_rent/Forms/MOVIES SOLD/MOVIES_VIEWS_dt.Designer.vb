<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MOVIES_VIEWS
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CURRENTCOLUMNFINDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ADVANCEFILTERONSELECTEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EQUALSTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EQUALANDLESSTHANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NOTEQUALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LESSTHANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GRAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GREATERTHANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FILTERSELECTEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.DAYSVIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TODAYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YESTERDAYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DAYAFTERYESTERDAYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DAYS_LOADTEXT = New System.Windows.Forms.ToolStripTextBox
        Me.DAYS_FIL_COMBO = New System.Windows.Forms.ToolStripComboBox
        Me.DATEVIEWSHOWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SHOWAUKQUERYMANAGERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOADWHOLEDATABASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.WITHFILTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PRINTONLYCURRENTCLIENTGOODSINFORMATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REMOVEFILTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PSSOLDVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.OptionsTableAdapter1 = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.OptionsTableAdapter
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.PS_VIEW1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem = New System.Windows.Forms.CheckBox
        Me.PS_VIEW1DataGrid = New System.Windows.Forms.DataGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.PS_SOLDDataGrid = New System.Windows.Forms.DataGrid
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.MOVIES_SOLD_VTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.MOVIES_SOLD_VTableAdapter
        Me.MOVIES_RPLISTTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.MOVIES_RPLISTTableAdapter
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PSSOLDVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS_VIEW1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS_VIEW1DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS_SOLDDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(402, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "AND"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(289, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(107, 23)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.B3
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.CyberPack_Pro.My.Resources.VsImg.Filter2HS
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(556, 41)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 24)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "QUERY MANAGER(&F)"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.B3
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Global.CyberPack_Pro.My.Resources.VsImg.PrintPreviewHS
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(557, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 24)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "&PRINT VIEW"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.B3
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(281, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(270, 24)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "SHOW &BETWEEN DAYS BENEFIT VIEW"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.B3
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(205, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 24)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "MENU"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CURRENTCOLUMNFINDToolStripMenuItem, Me.ADVANCEFILTERONSELECTEDToolStripMenuItem, Me.FILTERSELECTEDToolStripMenuItem, Me.ToolStripSeparator1, Me.DAYSVIEWToolStripMenuItem, Me.DATEVIEWSHOWToolStripMenuItem, Me.ToolStripSeparator3, Me.SHOWAUKQUERYMANAGERToolStripMenuItem, Me.LOADWHOLEDATABASEToolStripMenuItem, Me.CToolStripMenuItem, Me.ToolStripSeparator2, Me.WITHFILTERToolStripMenuItem, Me.PRINTONLYCURRENTCLIENTGOODSINFORMATIONToolStripMenuItem, Me.REMOVEFILTERToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(377, 286)
        '
        'CURRENTCOLUMNFINDToolStripMenuItem
        '
        Me.CURRENTCOLUMNFINDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.CURRENTCOLUMNFINDToolStripMenuItem.Name = "CURRENTCOLUMNFINDToolStripMenuItem"
        Me.CURRENTCOLUMNFINDToolStripMenuItem.Size = New System.Drawing.Size(376, 22)
        Me.CURRENTCOLUMNFINDToolStripMenuItem.Text = "CURRENT COLUMN FIND"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        '
        'ADVANCEFILTERONSELECTEDToolStripMenuItem
        '
        Me.ADVANCEFILTERONSELECTEDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EQUALSTOToolStripMenuItem, Me.EQUALANDLESSTHANToolStripMenuItem, Me.NOTEQUALToolStripMenuItem, Me.LESSTHANToolStripMenuItem, Me.GRAToolStripMenuItem, Me.GREATERTHANToolStripMenuItem})
        Me.ADVANCEFILTERONSELECTEDToolStripMenuItem.Name = "ADVANCEFILTERONSELECTEDToolStripMenuItem"
        Me.ADVANCEFILTERONSELECTEDToolStripMenuItem.Size = New System.Drawing.Size(376, 22)
        Me.ADVANCEFILTERONSELECTEDToolStripMenuItem.Text = "ADVANCE FILTER ON SELECTED"
        '
        'EQUALSTOToolStripMenuItem
        '
        Me.EQUALSTOToolStripMenuItem.Name = "EQUALSTOToolStripMenuItem"
        Me.EQUALSTOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EQUALSTOToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
        Me.EQUALSTOToolStripMenuItem.Tag = "="
        Me.EQUALSTOToolStripMenuItem.Text = "EQUALS TO"
        '
        'EQUALANDLESSTHANToolStripMenuItem
        '
        Me.EQUALANDLESSTHANToolStripMenuItem.Name = "EQUALANDLESSTHANToolStripMenuItem"
        Me.EQUALANDLESSTHANToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.EQUALANDLESSTHANToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
        Me.EQUALANDLESSTHANToolStripMenuItem.Tag = "<="
        Me.EQUALANDLESSTHANToolStripMenuItem.Text = "EQUAL AND LESS THAN"
        '
        'NOTEQUALToolStripMenuItem
        '
        Me.NOTEQUALToolStripMenuItem.Name = "NOTEQUALToolStripMenuItem"
        Me.NOTEQUALToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NOTEQUALToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
        Me.NOTEQUALToolStripMenuItem.Tag = "<>"
        Me.NOTEQUALToolStripMenuItem.Text = "NOT EQUAL"
        '
        'LESSTHANToolStripMenuItem
        '
        Me.LESSTHANToolStripMenuItem.Name = "LESSTHANToolStripMenuItem"
        Me.LESSTHANToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LESSTHANToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
        Me.LESSTHANToolStripMenuItem.Tag = "<"
        Me.LESSTHANToolStripMenuItem.Text = "LESS THAN"
        '
        'GRAToolStripMenuItem
        '
        Me.GRAToolStripMenuItem.Name = "GRAToolStripMenuItem"
        Me.GRAToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GRAToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
        Me.GRAToolStripMenuItem.Tag = ">="
        Me.GRAToolStripMenuItem.Text = "GREATER THAN AND EQUAL"
        '
        'GREATERTHANToolStripMenuItem
        '
        Me.GREATERTHANToolStripMenuItem.Name = "GREATERTHANToolStripMenuItem"
        Me.GREATERTHANToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GREATERTHANToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
        Me.GREATERTHANToolStripMenuItem.Tag = ">"
        Me.GREATERTHANToolStripMenuItem.Text = "GREATER THAN"
        '
        'FILTERSELECTEDToolStripMenuItem
        '
        Me.FILTERSELECTEDToolStripMenuItem.Name = "FILTERSELECTEDToolStripMenuItem"
        Me.FILTERSELECTEDToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.FILTERSELECTEDToolStripMenuItem.Size = New System.Drawing.Size(376, 22)
        Me.FILTERSELECTEDToolStripMenuItem.Text = "FILTER SELECTED"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(373, 6)
        '
        'DAYSVIEWToolStripMenuItem
        '
        Me.DAYSVIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TODAYToolStripMenuItem, Me.YESTERDAYToolStripMenuItem, Me.DAYAFTERYESTERDAYToolStripMenuItem, Me.DAYS_LOADTEXT, Me.DAYS_FIL_COMBO})
        Me.DAYSVIEWToolStripMenuItem.Name = "DAYSVIEWToolStripMenuItem"
        Me.DAYSVIEWToolStripMenuItem.Size = New System.Drawing.Size(376, 22)
        Me.DAYSVIEWToolStripMenuItem.Text = "DAYS VIEW"
        '
        'TODAYToolStripMenuItem
        '
        Me.TODAYToolStripMenuItem.Name = "TODAYToolStripMenuItem"
        Me.TODAYToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.TODAYToolStripMenuItem.Tag = "0"
        Me.TODAYToolStripMenuItem.Text = "TODAY"
        '
        'YESTERDAYToolStripMenuItem
        '
        Me.YESTERDAYToolStripMenuItem.Name = "YESTERDAYToolStripMenuItem"
        Me.YESTERDAYToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.YESTERDAYToolStripMenuItem.Tag = "1"
        Me.YESTERDAYToolStripMenuItem.Text = "YESTERDAY"
        '
        'DAYAFTERYESTERDAYToolStripMenuItem
        '
        Me.DAYAFTERYESTERDAYToolStripMenuItem.Name = "DAYAFTERYESTERDAYToolStripMenuItem"
        Me.DAYAFTERYESTERDAYToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.DAYAFTERYESTERDAYToolStripMenuItem.Tag = "2"
        Me.DAYAFTERYESTERDAYToolStripMenuItem.Text = "DAY AFTER YESTERDAY"
        '
        'DAYS_LOADTEXT
        '
        Me.DAYS_LOADTEXT.Name = "DAYS_LOADTEXT"
        Me.DAYS_LOADTEXT.Size = New System.Drawing.Size(100, 21)
        '
        'DAYS_FIL_COMBO
        '
        Me.DAYS_FIL_COMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DAYS_FIL_COMBO.Name = "DAYS_FIL_COMBO"
        Me.DAYS_FIL_COMBO.Size = New System.Drawing.Size(121, 21)
        '
        'DATEVIEWSHOWToolStripMenuItem
        '
        Me.DATEVIEWSHOWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox2})
        Me.DATEVIEWSHOWToolStripMenuItem.Name = "DATEVIEWSHOWToolStripMenuItem"
        Me.DATEVIEWSHOWToolStripMenuItem.Size = New System.Drawing.Size(376, 22)
        Me.DATEVIEWSHOWToolStripMenuItem.Text = "DATE VIEW SHOW"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 21)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(373, 6)
        '
        'SHOWAUKQUERYMANAGERToolStripMenuItem
        '
        Me.SHOWAUKQUERYMANAGERToolStripMenuItem.Name = "SHOWAUKQUERYMANAGERToolStripMenuItem"
        Me.SHOWAUKQUERYMANAGERToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.SHOWAUKQUERYMANAGERToolStripMenuItem.Size = New System.Drawing.Size(376, 22)
        Me.SHOWAUKQUERYMANAGERToolStripMenuItem.Text = "SHOW AUK QUERY MANAGER"
        '
        'LOADWHOLEDATABASEToolStripMenuItem
        '
        Me.LOADWHOLEDATABASEToolStripMenuItem.Name = "LOADWHOLEDATABASEToolStripMenuItem"
        Me.LOADWHOLEDATABASEToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.LOADWHOLEDATABASEToolStripMenuItem.Size = New System.Drawing.Size(376, 22)
        Me.LOADWHOLEDATABASEToolStripMenuItem.Text = "LOAD WHOLE DATABASE"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(376, 22)
        Me.CToolStripMenuItem.Text = "CLEAR DATABASE"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(373, 6)
        '
        'WITHFILTERToolStripMenuItem
        '
        Me.WITHFILTERToolStripMenuItem.CheckOnClick = True
        Me.WITHFILTERToolStripMenuItem.Name = "WITHFILTERToolStripMenuItem"
        Me.WITHFILTERToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.WITHFILTERToolStripMenuItem.Size = New System.Drawing.Size(376, 22)
        Me.WITHFILTERToolStripMenuItem.Text = "WITH FILTER"
        '
        'PRINTONLYCURRENTCLIENTGOODSINFORMATIONToolStripMenuItem
        '
        Me.PRINTONLYCURRENTCLIENTGOODSINFORMATIONToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.Resources.Printer
        Me.PRINTONLYCURRENTCLIENTGOODSINFORMATIONToolStripMenuItem.Name = "PRINTONLYCURRENTCLIENTGOODSINFORMATIONToolStripMenuItem"
        Me.PRINTONLYCURRENTCLIENTGOODSINFORMATIONToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PRINTONLYCURRENTCLIENTGOODSINFORMATIONToolStripMenuItem.Size = New System.Drawing.Size(376, 22)
        Me.PRINTONLYCURRENTCLIENTGOODSINFORMATIONToolStripMenuItem.Text = "PRINT_ONLY CURRENT CLIENT GOODS INFORMATION"
        '
        'REMOVEFILTERToolStripMenuItem
        '
        Me.REMOVEFILTERToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DeleteHS
        Me.REMOVEFILTERToolStripMenuItem.Name = "REMOVEFILTERToolStripMenuItem"
        Me.REMOVEFILTERToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.REMOVEFILTERToolStripMenuItem.Size = New System.Drawing.Size(376, 22)
        Me.REMOVEFILTERToolStripMenuItem.Text = "REMOVE FILTER"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.B3
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ONE MONTH BENEFIT VIEW"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.B3
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&TODAY'S BENEFIT VIEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(213, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "SOLD ID/MOVIE ID/PREPARED BY/SOLD DATE/REPORTID/CLIENT NAME"
        '
        'PSSOLDVBindingSource
        '
        Me.PSSOLDVBindingSource.DataMember = "MOVIES_SOLD_V"
        Me.PSSOLDVBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OptionsTableAdapter1
        '
        Me.OptionsTableAdapter1.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(591, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 23)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PS_VIEW1BindingSource
        '
        Me.PS_VIEW1BindingSource.DataMember = "MOVIES_RPLIST"
        Me.PS_VIEW1BindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(438, 41)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(112, 23)
        Me.DateTimePicker2.TabIndex = 14
        '
        'SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem
        '
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.Appearance = System.Windows.Forms.Appearance.Button
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.B3
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.Checked = Global.CyberPack_Pro.My.MySettings.Default.VIEW_DETAILS_PS
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "VIEW_DETAILS_PS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.Location = New System.Drawing.Point(703, 12)
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.Name = "SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem"
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.Size = New System.Drawing.Size(77, 52)
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.TabIndex = 16
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.Text = "SHOW DETAILS."
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.UseVisualStyleBackColor = True
        '
        'PS_VIEW1DataGrid
        '
        Me.PS_VIEW1DataGrid.AlternatingBackColor = System.Drawing.Color.White
        Me.PS_VIEW1DataGrid.BackColor = System.Drawing.Color.White
        Me.PS_VIEW1DataGrid.BackgroundColor = System.Drawing.Color.White
        Me.PS_VIEW1DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PS_VIEW1DataGrid.CaptionBackColor = System.Drawing.Color.Black
        Me.PS_VIEW1DataGrid.CaptionFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PS_VIEW1DataGrid.CaptionForeColor = System.Drawing.Color.White
        Me.PS_VIEW1DataGrid.CaptionText = "Summary"
        Me.PS_VIEW1DataGrid.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PS_VIEW1DataGrid.DataMember = ""
        Me.PS_VIEW1DataGrid.DataSource = Me.PS_VIEW1BindingSource
        Me.PS_VIEW1DataGrid.Dock = System.Windows.Forms.DockStyle.Top
        Me.PS_VIEW1DataGrid.FlatMode = True
        Me.PS_VIEW1DataGrid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PS_VIEW1DataGrid.ForeColor = System.Drawing.Color.Black
        Me.PS_VIEW1DataGrid.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PS_VIEW1DataGrid.HeaderBackColor = System.Drawing.Color.Black
        Me.PS_VIEW1DataGrid.HeaderFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PS_VIEW1DataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.PS_VIEW1DataGrid.LinkColor = System.Drawing.Color.Purple
        Me.PS_VIEW1DataGrid.Location = New System.Drawing.Point(0, 74)
        Me.PS_VIEW1DataGrid.Name = "PS_VIEW1DataGrid"
        Me.PS_VIEW1DataGrid.ParentRowsBackColor = System.Drawing.Color.Gray
        Me.PS_VIEW1DataGrid.ParentRowsForeColor = System.Drawing.Color.White
        Me.PS_VIEW1DataGrid.PreferredColumnWidth = 200
        Me.PS_VIEW1DataGrid.ReadOnly = True
        Me.PS_VIEW1DataGrid.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        Me.PS_VIEW1DataGrid.SelectionForeColor = System.Drawing.Color.Red
        Me.PS_VIEW1DataGrid.Size = New System.Drawing.Size(792, 263)
        Me.PS_VIEW1DataGrid.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(217, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "BETWEEN"
        '
        'PS_SOLDDataGrid
        '
        Me.PS_SOLDDataGrid.AlternatingBackColor = System.Drawing.Color.White
        Me.PS_SOLDDataGrid.BackColor = System.Drawing.Color.White
        Me.PS_SOLDDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.PS_SOLDDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PS_SOLDDataGrid.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PS_SOLDDataGrid.CaptionFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PS_SOLDDataGrid.CaptionForeColor = System.Drawing.Color.White
        Me.PS_SOLDDataGrid.CaptionText = "VIEW OF SOLD ITEMS"
        Me.PS_SOLDDataGrid.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PS_SOLDDataGrid.DataMember = ""
        Me.PS_SOLDDataGrid.DataSource = Me.PSSOLDVBindingSource
        Me.PS_SOLDDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PS_SOLDDataGrid.FlatMode = True
        Me.PS_SOLDDataGrid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PS_SOLDDataGrid.ForeColor = System.Drawing.Color.Black
        Me.PS_SOLDDataGrid.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PS_SOLDDataGrid.HeaderBackColor = System.Drawing.Color.Black
        Me.PS_SOLDDataGrid.HeaderFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PS_SOLDDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.PS_SOLDDataGrid.LinkColor = System.Drawing.Color.DeepSkyBlue
        Me.PS_SOLDDataGrid.Location = New System.Drawing.Point(0, 337)
        Me.PS_SOLDDataGrid.Name = "PS_SOLDDataGrid"
        Me.PS_SOLDDataGrid.ParentRowsBackColor = System.Drawing.Color.Gray
        Me.PS_SOLDDataGrid.ParentRowsForeColor = System.Drawing.Color.White
        Me.PS_SOLDDataGrid.PreferredColumnWidth = 250
        Me.PS_SOLDDataGrid.ReadOnly = True
        Me.PS_SOLDDataGrid.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        Me.PS_SOLDDataGrid.SelectionForeColor = System.Drawing.Color.Red
        Me.PS_SOLDDataGrid.Size = New System.Drawing.Size(792, 229)
        Me.PS_SOLDDataGrid.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.B3
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 74)
        Me.Panel1.TabIndex = 8
        '
        'MOVIES_SOLD_VTableAdapter
        '
        Me.MOVIES_SOLD_VTableAdapter.ClearBeforeFill = True
        '
        'MOVIES_RPLISTTableAdapter
        '
        Me.MOVIES_RPLISTTableAdapter.ClearBeforeFill = True
        '
        'MOVIES_VIEWS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.PS_SOLDDataGrid)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PS_VIEW1DataGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MOVIES_VIEWS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOVIES VIEWS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PSSOLDVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS_VIEW1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS_VIEW1DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS_SOLDDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PSSOLDVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents OptionsTableAdapter1 As CyberPack_Pro.AukDatabaseDataSetTableAdapters.OptionsTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PS_VIEW1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem As System.Windows.Forms.CheckBox
    Friend WithEvents PS_VIEW1DataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PS_SOLDDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MOVIES_SOLD_VTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.MOVIES_SOLD_VTableAdapter
    Friend WithEvents MOVIES_RPLISTTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.MOVIES_RPLISTTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CURRENTCOLUMNFINDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ADVANCEFILTERONSELECTEDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EQUALSTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EQUALANDLESSTHANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LESSTHANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GREATERTHANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GRAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NOTEQUALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FILTERSELECTEDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DAYSVIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TODAYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YESTERDAYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DAYAFTERYESTERDAYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATEVIEWSHOWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WITHFILTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRINTONLYCURRENTCLIENTGOODSINFORMATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REMOVEFILTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOADWHOLEDATABASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DAYS_LOADTEXT As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DAYS_FIL_COMBO As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SHOWAUKQUERYMANAGERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
