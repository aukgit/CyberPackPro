<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MVIEWS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MVIEWS))
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.SOLD_VIEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SOLD_VIEWTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.SOLD_VIEWTableAdapter
        Me.SOLD_VIEWBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.SEARCHQUERYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SELECTEDFILTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SELECTEDMOVIESSENDTOSOLDLISTIFCLIENTONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.MOVIESTYPESSHOWSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SHOWMOVIEADVANCETYPEONLYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SHOWMOVIETYPESLISTBOXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SHOWFOCUSONDVDIDFOUNDTEXTBOXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.LOADWHOLEDATABASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CLEARDATABASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HIDEVIEWFORMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.FILTERALSOPLACEINSTOREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REMOVEFILTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.FIND_MOVIES = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.SOLD_VIEWDataGrid = New System.Windows.Forms.DataGrid
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.MTYPEVIEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.MTYPE_VIEWTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.MTYPE_VIEWTableAdapter
        Me.MADVANCETYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M_ADVANCE_TYPETableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.M_ADVANCE_TYPETableAdapter
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOLD_VIEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOLD_VIEWBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SOLD_VIEWBindingNavigator.SuspendLayout()
        CType(Me.SOLD_VIEWDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.MTYPEVIEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MADVANCETYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SOLD_VIEWBindingSource
        '
        Me.SOLD_VIEWBindingSource.DataMember = "SOLD_VIEW"
        Me.SOLD_VIEWBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'SOLD_VIEWTableAdapter
        '
        Me.SOLD_VIEWTableAdapter.ClearBeforeFill = True
        '
        'SOLD_VIEWBindingNavigator
        '
        Me.SOLD_VIEWBindingNavigator.AddNewItem = Nothing
        Me.SOLD_VIEWBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SOLD_VIEWBindingNavigator.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.TITLE
        Me.SOLD_VIEWBindingNavigator.BindingSource = Me.SOLD_VIEWBindingSource
        Me.SOLD_VIEWBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SOLD_VIEWBindingNavigator.DeleteItem = Nothing
        Me.SOLD_VIEWBindingNavigator.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SOLD_VIEWBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SOLD_VIEWBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator4, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel1, Me.FIND_MOVIES, Me.ToolStripSeparator6, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.SOLD_VIEWBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SOLD_VIEWBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SOLD_VIEWBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SOLD_VIEWBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SOLD_VIEWBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SOLD_VIEWBindingNavigator.Name = "SOLD_VIEWBindingNavigator"
        Me.SOLD_VIEWBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SOLD_VIEWBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.SOLD_VIEWBindingNavigator.TabIndex = 0
        Me.SOLD_VIEWBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SEARCHQUERYToolStripMenuItem, Me.SELECTEDFILTERToolStripMenuItem, Me.SELECTEDMOVIESSENDTOSOLDLISTIFCLIENTONToolStripMenuItem, Me.ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem, Me.ToolStripSeparator1, Me.MOVIESTYPESSHOWSToolStripMenuItem, Me.SHOWMOVIEADVANCETYPEONLYToolStripMenuItem, Me.SHOWMOVIETYPESLISTBOXToolStripMenuItem, Me.ToolStripSeparator3, Me.SHOWFOCUSONDVDIDFOUNDTEXTBOXToolStripMenuItem, Me.DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem, Me.ToolStripSeparator2, Me.LOADWHOLEDATABASEToolStripMenuItem, Me.CLEARDATABASEToolStripMenuItem, Me.HIDEVIEWFORMToolStripMenuItem, Me.ToolStripSeparator5, Me.FILTERALSOPLACEINSTOREToolStripMenuItem, Me.REMOVEFILTERToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.CyberPack_Pro.My.Resources.VsImg.GoLtrHS
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripDropDownButton1.Text = "MENU"
        '
        'SEARCHQUERYToolStripMenuItem
        '
        Me.SEARCHQUERYToolStripMenuItem.Name = "SEARCHQUERYToolStripMenuItem"
        Me.SEARCHQUERYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.SEARCHQUERYToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.SEARCHQUERYToolStripMenuItem.Text = "SEARCH/QUERY"
        '
        'SELECTEDFILTERToolStripMenuItem
        '
        Me.SELECTEDFILTERToolStripMenuItem.Name = "SELECTEDFILTERToolStripMenuItem"
        Me.SELECTEDFILTERToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.SELECTEDFILTERToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.SELECTEDFILTERToolStripMenuItem.Text = "SELECTED FILTER"
        '
        'SELECTEDMOVIESSENDTOSOLDLISTIFCLIENTONToolStripMenuItem
        '
        Me.SELECTEDMOVIESSENDTOSOLDLISTIFCLIENTONToolStripMenuItem.Name = "SELECTEDMOVIESSENDTOSOLDLISTIFCLIENTONToolStripMenuItem"
        Me.SELECTEDMOVIESSENDTOSOLDLISTIFCLIENTONToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SELECTEDMOVIESSENDTOSOLDLISTIFCLIENTONToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.SELECTEDMOVIESSENDTOSOLDLISTIFCLIENTONToolStripMenuItem.Text = "SELECTED MOVIES SEND TO SOLD LIST IF CLIENT ON"
        Me.SELECTEDMOVIESSENDTOSOLDLISTIFCLIENTONToolStripMenuItem.Visible = False
        '
        'ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem
        '
        Me.ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources._2
        Me.ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.GoLtrHS
        Me.ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem.Name = "ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem"
        Me.ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S or Double Click"
        Me.ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem.Text = "ONLY CURRENT MOVIE SEND TO SOLD LIST"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(440, 6)
        '
        'MOVIESTYPESSHOWSToolStripMenuItem
        '
        Me.MOVIESTYPESSHOWSToolStripMenuItem.Name = "MOVIESTYPESSHOWSToolStripMenuItem"
        Me.MOVIESTYPESSHOWSToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MOVIESTYPESSHOWSToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.MOVIESTYPESSHOWSToolStripMenuItem.Text = "MOVIES TYPES SHOWS"
        '
        'SHOWMOVIEADVANCETYPEONLYToolStripMenuItem
        '
        Me.SHOWMOVIEADVANCETYPEONLYToolStripMenuItem.Name = "SHOWMOVIEADVANCETYPEONLYToolStripMenuItem"
        Me.SHOWMOVIEADVANCETYPEONLYToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.SHOWMOVIEADVANCETYPEONLYToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.SHOWMOVIEADVANCETYPEONLYToolStripMenuItem.Text = "SHOW MOVIE ADVANCE TYPE ONLY"
        '
        'SHOWMOVIETYPESLISTBOXToolStripMenuItem
        '
        Me.SHOWMOVIETYPESLISTBOXToolStripMenuItem.Checked = True
        Me.SHOWMOVIETYPESLISTBOXToolStripMenuItem.CheckOnClick = True
        Me.SHOWMOVIETYPESLISTBOXToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SHOWMOVIETYPESLISTBOXToolStripMenuItem.Name = "SHOWMOVIETYPESLISTBOXToolStripMenuItem"
        Me.SHOWMOVIETYPESLISTBOXToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.SHOWMOVIETYPESLISTBOXToolStripMenuItem.Text = "SHOW MOVIE TYPES LISTBOX"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(440, 6)
        '
        'SHOWFOCUSONDVDIDFOUNDTEXTBOXToolStripMenuItem
        '
        Me.SHOWFOCUSONDVDIDFOUNDTEXTBOXToolStripMenuItem.Name = "SHOWFOCUSONDVDIDFOUNDTEXTBOXToolStripMenuItem"
        Me.SHOWFOCUSONDVDIDFOUNDTEXTBOXToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.SHOWFOCUSONDVDIDFOUNDTEXTBOXToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.SHOWFOCUSONDVDIDFOUNDTEXTBOXToolStripMenuItem.Text = "SHOW FOCUS ON DVD ID FOUND TEXTBOX"
        '
        'DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem
        '
        Me.DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem.Checked = True
        Me.DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem.CheckOnClick = True
        Me.DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem.Name = "DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem"
        Me.DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem.Text = "DIRECT ADD MOVIE IN SOLD LIST WHEN FOUND BY FIND TEXTBOX"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(440, 6)
        '
        'LOADWHOLEDATABASEToolStripMenuItem
        '
        Me.LOADWHOLEDATABASEToolStripMenuItem.Name = "LOADWHOLEDATABASEToolStripMenuItem"
        Me.LOADWHOLEDATABASEToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.LOADWHOLEDATABASEToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.LOADWHOLEDATABASEToolStripMenuItem.Text = "LOAD WHOLE DATABASE"
        '
        'CLEARDATABASEToolStripMenuItem
        '
        Me.CLEARDATABASEToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.RepeatHS
        Me.CLEARDATABASEToolStripMenuItem.Name = "CLEARDATABASEToolStripMenuItem"
        Me.CLEARDATABASEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.CLEARDATABASEToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.CLEARDATABASEToolStripMenuItem.Text = "CLEAR DATABASE"
        '
        'HIDEVIEWFORMToolStripMenuItem
        '
        Me.HIDEVIEWFORMToolStripMenuItem.Name = "HIDEVIEWFORMToolStripMenuItem"
        Me.HIDEVIEWFORMToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HIDEVIEWFORMToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.HIDEVIEWFORMToolStripMenuItem.Text = "HIDE VIEW FORM"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(440, 6)
        '
        'FILTERALSOPLACEINSTOREToolStripMenuItem
        '
        Me.FILTERALSOPLACEINSTOREToolStripMenuItem.Name = "FILTERALSOPLACEINSTOREToolStripMenuItem"
        Me.FILTERALSOPLACEINSTOREToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.FILTERALSOPLACEINSTOREToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.FILTERALSOPLACEINSTOREToolStripMenuItem.Text = "FILTER ALSO PLACE='INSTORE'"
        '
        'REMOVEFILTERToolStripMenuItem
        '
        Me.REMOVEFILTERToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DeleteHS
        Me.REMOVEFILTERToolStripMenuItem.Name = "REMOVEFILTERToolStripMenuItem"
        Me.REMOVEFILTERToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.REMOVEFILTERToolStripMenuItem.Size = New System.Drawing.Size(443, 22)
        Me.REMOVEFILTERToolStripMenuItem.Text = "REMOVE FILTER"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel1.Text = "FIND:"
        '
        'FIND_MOVIES
        '
        Me.FIND_MOVIES.Name = "FIND_MOVIES"
        Me.FIND_MOVIES.Size = New System.Drawing.Size(100, 25)
        Me.FIND_MOVIES.ToolTipText = "FIND MOVIE ID,MOVIE NAME[EXACT FROM FIRST]"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripButton1.Text = "FILTER PLACE= INSTORE"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.Visible = False
        '
        'SOLD_VIEWDataGrid
        '
        Me.SOLD_VIEWDataGrid.AllowNavigation = False
        Me.SOLD_VIEWDataGrid.AllowSorting = False
        Me.SOLD_VIEWDataGrid.BackgroundColor = System.Drawing.Color.DarkGray
        Me.SOLD_VIEWDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SOLD_VIEWDataGrid.CaptionBackColor = System.Drawing.Color.Silver
        Me.SOLD_VIEWDataGrid.CaptionText = "MOVIES VIEW"
        Me.SOLD_VIEWDataGrid.DataMember = ""
        Me.SOLD_VIEWDataGrid.DataSource = Me.SOLD_VIEWBindingSource
        Me.SOLD_VIEWDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SOLD_VIEWDataGrid.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SOLD_VIEWDataGrid.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SOLD_VIEWDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.SOLD_VIEWDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.SOLD_VIEWDataGrid.Name = "SOLD_VIEWDataGrid"
        Me.SOLD_VIEWDataGrid.PreferredColumnWidth = 300
        Me.SOLD_VIEWDataGrid.PreferredRowHeight = 15
        Me.SOLD_VIEWDataGrid.ReadOnly = True
        Me.SOLD_VIEWDataGrid.SelectionBackColor = System.Drawing.Color.Black
        Me.SOLD_VIEWDataGrid.SelectionForeColor = System.Drawing.Color.White
        Me.SOLD_VIEWDataGrid.Size = New System.Drawing.Size(592, 531)
        Me.SOLD_VIEWDataGrid.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SOLD_VIEWDataGrid)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Size = New System.Drawing.Size(792, 548)
        Me.SplitContainer1.SplitterDistance = 196
        Me.SplitContainer1.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.DataSource = Me.MTYPEVIEWBindingSource
        Me.ListBox1.DisplayMember = "MOVIE TYPE NAME"
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(196, 529)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "MOVIES"
        '
        'MTYPEVIEWBindingSource
        '
        Me.MTYPEVIEWBindingSource.DataMember = "MTYPE_VIEW"
        Me.MTYPEVIEWBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 531)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 531)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(592, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MTYPE_VIEWTableAdapter
        '
        Me.MTYPE_VIEWTableAdapter.ClearBeforeFill = True
        '
        'MADVANCETYPEBindingSource
        '
        Me.MADVANCETYPEBindingSource.DataMember = "M_ADVANCE_TYPE"
        Me.MADVANCETYPEBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'M_ADVANCE_TYPETableAdapter
        '
        Me.M_ADVANCE_TYPETableAdapter.ClearBeforeFill = True
        '
        'MVIEWS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.SOLD_VIEWBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MVIEWS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOVIES VIEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOLD_VIEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOLD_VIEWBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SOLD_VIEWBindingNavigator.ResumeLayout(False)
        Me.SOLD_VIEWBindingNavigator.PerformLayout()
        CType(Me.SOLD_VIEWDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.MTYPEVIEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MADVANCETYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents SOLD_VIEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SOLD_VIEWTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.SOLD_VIEWTableAdapter
    Friend WithEvents SOLD_VIEWBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SOLD_VIEWDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents FIND_MOVIES As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SEARCHQUERYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SELECTEDMOVIESSENDTOSOLDLISTIFCLIENTONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MOVIESTYPESSHOWSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SHOWMOVIEADVANCETYPEONLYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SHOWFOCUSONDVDIDFOUNDTEXTBOXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LOADWHOLEDATABASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLEARDATABASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HIDEVIEWFORMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SHOWMOVIETYPESLISTBOXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MTYPEVIEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MTYPE_VIEWTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.MTYPE_VIEWTableAdapter
    Friend WithEvents MADVANCETYPEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents M_ADVANCE_TYPETableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.M_ADVANCE_TYPETableAdapter
    Friend WithEvents SELECTEDFILTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FILTERALSOPLACEINSTOREToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents REMOVEFILTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
