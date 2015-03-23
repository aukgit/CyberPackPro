<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movie_Type
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movie_Type))
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypeTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.TypeTableAdapter
        Me.TypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TypeDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Movie_Type_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.SAMEPRODUCTGOODINPUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.TypeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.CUTSELECTEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COPYSELECTEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PASTESELECTORINSERTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FORINSERTCOPYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FORINSERTCURSELECTEDROWSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.INSERTCOPYROWSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CREATENEWINSERTCOPYROWSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DELETESELETECToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REFRESHCURRENTTABLEDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TypeBindingNavigator.SuspendLayout()
        CType(Me.TypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TypeBindingSource
        '
        Me.TypeBindingSource.DataMember = "Type"
        Me.TypeBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'TypeTableAdapter
        '
        Me.TypeTableAdapter.ClearBeforeFill = True
        '
        'TypeBindingNavigator
        '
        Me.TypeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TypeBindingNavigator.BindingSource = Me.TypeBindingSource
        Me.TypeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TypeBindingNavigator.DeleteItem = Nothing
        Me.TypeBindingNavigator.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TypeBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripButton2})
        Me.TypeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TypeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TypeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TypeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TypeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TypeBindingNavigator.Name = "TypeBindingNavigator"
        Me.TypeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TypeBindingNavigator.Size = New System.Drawing.Size(761, 25)
        Me.TypeBindingNavigator.TabIndex = 0
        Me.TypeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TypeDataGridView
        '
        Me.TypeDataGridView.AutoGenerateColumns = False
        Me.TypeDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Movie_Type_Name})
        Me.TypeDataGridView.DataSource = Me.TypeBindingSource
        Me.TypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TypeDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TypeDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.TypeDataGridView.Name = "TypeDataGridView"
        Me.TypeDataGridView.ReadOnly = True
        Me.TypeDataGridView.Size = New System.Drawing.Size(761, 521)
        Me.TypeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Movie_Type"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Movie_Type_Name
        '
        Me.Movie_Type_Name.DataPropertyName = "Movie_Type_Name"
        Me.Movie_Type_Name.HeaderText = "MOVIE TYPE"
        Me.Movie_Type_Name.MaxInputLength = 60
        Me.Movie_Type_Name.MinimumWidth = 500
        Me.Movie_Type_Name.Name = "Movie_Type_Name"
        Me.Movie_Type_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Movie_Type_Name.Width = 500
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CUTSELECTEDToolStripMenuItem, Me.COPYSELECTEDToolStripMenuItem, Me.PASTESELECTORINSERTToolStripMenuItem, Me.ToolStripSeparator5, Me.FORINSERTCOPYToolStripMenuItem, Me.FORINSERTCURSELECTEDROWSToolStripMenuItem, Me.INSERTCOPYROWSToolStripMenuItem, Me.CREATENEWINSERTCOPYROWSToolStripMenuItem, Me.MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem, Me.ToolStripSeparator3, Me.DELETESELETECToolStripMenuItem, Me.REFRESHCURRENTTABLEDATAToolStripMenuItem, Me.REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem, Me.ToolStripSeparator4, Me.SAMEPRODUCTGOODINPUTToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(291, 286)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(287, 6)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(287, 6)
        '
        'REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem
        '
        Me.REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem.Name = "REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem"
        Me.REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem.Text = "REFRESH ONLY CURRENT SELECTED DATA"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(287, 6)
        '
        'SAMEPRODUCTGOODINPUTToolStripMenuItem
        '
        Me.SAMEPRODUCTGOODINPUTToolStripMenuItem.Name = "SAMEPRODUCTGOODINPUTToolStripMenuItem"
        Me.SAMEPRODUCTGOODINPUTToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.SAMEPRODUCTGOODINPUTToolStripMenuItem.Text = "SAME PHRASE INPUT IN SELECTED CELLS"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripSeparator6, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripSeparator7, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ToolStripSeparator8, Me.ToolStripMenuItem12})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(291, 286)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(287, 6)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(287, 6)
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem11.Text = "REFRESH ONLY CURRENT SELECTED DATA"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(287, 6)
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem12.Text = "SAME PHRASE INPUT IN SELECTED CELLS"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add New"
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(61, 22)
        Me.BindingNavigatorDeleteItem.Text = "&Delete"
        '
        'TypeBindingNavigatorSaveItem
        '
        Me.TypeBindingNavigatorSaveItem.Image = CType(resources.GetObject("TypeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TypeBindingNavigatorSaveItem.Name = "TypeBindingNavigatorSaveItem"
        Me.TypeBindingNavigatorSaveItem.Size = New System.Drawing.Size(81, 22)
        Me.TypeBindingNavigatorSaveItem.Text = "&Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton1.Text = "&Refresh"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripButton2.Text = "&Edit Enable"
        '
        'CUTSELECTEDToolStripMenuItem
        '
        Me.CUTSELECTEDToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.CutHS
        Me.CUTSELECTEDToolStripMenuItem.Name = "CUTSELECTEDToolStripMenuItem"
        Me.CUTSELECTEDToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.CUTSELECTEDToolStripMenuItem.Text = "CUT SELECTED"
        '
        'COPYSELECTEDToolStripMenuItem
        '
        Me.COPYSELECTEDToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.CopyHS
        Me.COPYSELECTEDToolStripMenuItem.Name = "COPYSELECTEDToolStripMenuItem"
        Me.COPYSELECTEDToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.COPYSELECTEDToolStripMenuItem.Text = "COPY SELECTED"
        '
        'PASTESELECTORINSERTToolStripMenuItem
        '
        Me.PASTESELECTORINSERTToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.PasteHS
        Me.PASTESELECTORINSERTToolStripMenuItem.Name = "PASTESELECTORINSERTToolStripMenuItem"
        Me.PASTESELECTORINSERTToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.PASTESELECTORINSERTToolStripMenuItem.Text = "PASTE SELECT OR REPLACE"
        '
        'FORINSERTCOPYToolStripMenuItem
        '
        Me.FORINSERTCOPYToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.CopyHS
        Me.FORINSERTCOPYToolStripMenuItem.Name = "FORINSERTCOPYToolStripMenuItem"
        Me.FORINSERTCOPYToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.FORINSERTCOPYToolStripMenuItem.Text = "FOR INSERT COPY"
        '
        'FORINSERTCURSELECTEDROWSToolStripMenuItem
        '
        Me.FORINSERTCURSELECTEDROWSToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.CutHS
        Me.FORINSERTCURSELECTEDROWSToolStripMenuItem.Name = "FORINSERTCURSELECTEDROWSToolStripMenuItem"
        Me.FORINSERTCURSELECTEDROWSToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.FORINSERTCURSELECTEDROWSToolStripMenuItem.Text = "FOR INSERT CUT"
        '
        'INSERTCOPYROWSToolStripMenuItem
        '
        Me.INSERTCOPYROWSToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.PasteHS
        Me.INSERTCOPYROWSToolStripMenuItem.Name = "INSERTCOPYROWSToolStripMenuItem"
        Me.INSERTCOPYROWSToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.INSERTCOPYROWSToolStripMenuItem.Text = "INSERT COPY/CUT ROWS/PASTE ROWS"
        '
        'CREATENEWINSERTCOPYROWSToolStripMenuItem
        '
        Me.CREATENEWINSERTCOPYROWSToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.NewDocumentHS
        Me.CREATENEWINSERTCOPYROWSToolStripMenuItem.Name = "CREATENEWINSERTCOPYROWSToolStripMenuItem"
        Me.CREATENEWINSERTCOPYROWSToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.CREATENEWINSERTCOPYROWSToolStripMenuItem.Text = "CREATE NEW (INSERT COPY ROWS)"
        '
        'MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem
        '
        Me.MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources._2
        Me.MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem.Name = "MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem"
        Me.MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem.Text = "MAKE INTERCHANGE IN TWO ROWS VALUES"
        '
        'DELETESELETECToolStripMenuItem
        '
        Me.DELETESELETECToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DeleteHS
        Me.DELETESELETECToolStripMenuItem.Name = "DELETESELETECToolStripMenuItem"
        Me.DELETESELETECToolStripMenuItem.ShortcutKeyDisplayString = "DELETE"
        Me.DELETESELETECToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.DELETESELETECToolStripMenuItem.Text = "DELETE SELECTED"
        '
        'REFRESHCURRENTTABLEDATAToolStripMenuItem
        '
        Me.REFRESHCURRENTTABLEDATAToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.RepeatHS
        Me.REFRESHCURRENTTABLEDATAToolStripMenuItem.Name = "REFRESHCURRENTTABLEDATAToolStripMenuItem"
        Me.REFRESHCURRENTTABLEDATAToolStripMenuItem.Size = New System.Drawing.Size(290, 22)
        Me.REFRESHCURRENTTABLEDATAToolStripMenuItem.Text = "REFRESH CURRENT TABLE DATA"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CyberPack_Pro.My.Resources.VsImg.CutHS
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem1.Text = "CUT SELECTED"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.CyberPack_Pro.My.Resources.VsImg.CopyHS
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem2.Text = "COPY SELECTED"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.CyberPack_Pro.My.Resources.VsImg.PasteHS
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem3.Text = "PASTE SELECT OR REPLACE"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.CyberPack_Pro.My.Resources.VsImg.CopyHS
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem4.Text = "FOR INSERT COPY"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = Global.CyberPack_Pro.My.Resources.VsImg.CutHS
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem5.Text = "FOR INSERT CUT"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Image = Global.CyberPack_Pro.My.Resources.VsImg.PasteHS
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem6.Text = "INSERT COPY/CUT ROWS/PASTE ROWS"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Image = Global.CyberPack_Pro.My.Resources.VsImg.NewDocumentHS
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem7.Text = "CREATE NEW (INSERT COPY ROWS)"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources._2
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem8.Text = "MAKE INTERCHANGE IN TWO ROWS VALUES"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Image = Global.CyberPack_Pro.My.Resources.VsImg.DeleteHS
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.ShortcutKeyDisplayString = "DELETE"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem9.Text = "DELETE SELECTED"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Image = Global.CyberPack_Pro.My.Resources.VsImg.RepeatHS
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(290, 22)
        Me.ToolStripMenuItem10.Text = "REFRESH CURRENT TABLE DATA"
        '
        'Movie_Type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 546)
        Me.Controls.Add(Me.TypeDataGridView)
        Me.Controls.Add(Me.TypeBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Movie_Type"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NEW MOVIE/DVD TYPES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TypeBindingNavigator.ResumeLayout(False)
        Me.TypeBindingNavigator.PerformLayout()
        CType(Me.TypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents TypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypeTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.TypeTableAdapter
    Friend WithEvents TypeBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TypeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TypeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Movie_Type_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CUTSELECTEDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COPYSELECTEDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PASTESELECTORINSERTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FORINSERTCOPYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FORINSERTCURSELECTEDROWSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INSERTCOPYROWSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CREATENEWINSERTCOPYROWSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MAKEINTERCHANGEINTWOROWSVALUESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DELETESELETECToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REFRESHCURRENTTABLEDATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REFRESHONLYCURRENTSELECTEDDATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SAMEPRODUCTGOODINPUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
End Class
