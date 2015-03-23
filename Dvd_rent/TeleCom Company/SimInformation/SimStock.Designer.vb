<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimStock))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.SimStockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimStockTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.SimStockTableAdapter
        Me.SimStockBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.RefreshDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.QueryManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.FilterSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.CommonInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.AddSameCategoryProductBySimNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.AddNewSimCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SimSellingFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ReLoadDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SimStockBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.PROG = New System.Windows.Forms.ToolStripProgressBar
        Me.SimStockDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCom_Field = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.MobComBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimCate_Fied = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mob_ComTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.Mob_ComTableAdapter
        Me.SimCategoryTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.SimCategoryTableAdapter
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimStockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimStockBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SimStockBindingNavigator.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SimStockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobComBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SimStockBindingSource
        '
        Me.SimStockBindingSource.DataMember = "SimStock"
        Me.SimStockBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'SimStockTableAdapter
        '
        Me.SimStockTableAdapter.ClearBeforeFill = True
        '
        'SimStockBindingNavigator
        '
        Me.SimStockBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SimStockBindingNavigator.BindingSource = Me.SimStockBindingSource
        Me.SimStockBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SimStockBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SimStockBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SimStockBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SimStockBindingNavigatorSaveItem, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.PROG})
        Me.SimStockBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SimStockBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SimStockBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SimStockBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SimStockBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SimStockBindingNavigator.Name = "SimStockBindingNavigator"
        Me.SimStockBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SimStockBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.SimStockBindingNavigator.TabIndex = 0
        Me.SimStockBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(69, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add new"
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
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDown = Me.ContextMenuStrip1
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripDropDownButton1.Text = "Menu"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshDatabaseToolStripMenuItem, Me.ToolStripSeparator3, Me.QueryManagerToolStripMenuItem, Me.ToolStripSeparator4, Me.FilterSelectedToolStripMenuItem, Me.RemoveFilterToolStripMenuItem, Me.ToolStripSeparator5, Me.CommonInformationToolStripMenuItem, Me.ToolStripSeparator6, Me.AddSameCategoryProductBySimNumberToolStripMenuItem, Me.ToolStripSeparator7, Me.AddNewSimCategoryToolStripMenuItem, Me.SimSellingFormToolStripMenuItem, Me.ToolStripSeparator8, Me.ReLoadDatabaseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(228, 288)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(224, 6)
        '
        'RefreshDatabaseToolStripMenuItem
        '
        Me.RefreshDatabaseToolStripMenuItem.Name = "RefreshDatabaseToolStripMenuItem"
        Me.RefreshDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.RefreshDatabaseToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.RefreshDatabaseToolStripMenuItem.Text = "Reject Changes"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(224, 6)
        '
        'QueryManagerToolStripMenuItem
        '
        Me.QueryManagerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueryManagerToolStripMenuItem.Name = "QueryManagerToolStripMenuItem"
        Me.QueryManagerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QueryManagerToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.QueryManagerToolStripMenuItem.Text = "Query Manager"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(224, 6)
        '
        'FilterSelectedToolStripMenuItem
        '
        Me.FilterSelectedToolStripMenuItem.Name = "FilterSelectedToolStripMenuItem"
        Me.FilterSelectedToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.FilterSelectedToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.FilterSelectedToolStripMenuItem.Text = "Filter Selected"
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "Remove Filter"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(224, 6)
        '
        'CommonInformationToolStripMenuItem
        '
        Me.CommonInformationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommonInformationToolStripMenuItem.Name = "CommonInformationToolStripMenuItem"
        Me.CommonInformationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.CommonInformationToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.CommonInformationToolStripMenuItem.Text = "Common Information"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(224, 6)
        '
        'AddSameCategoryProductBySimNumberToolStripMenuItem
        '
        Me.AddSameCategoryProductBySimNumberToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSameCategoryProductBySimNumberToolStripMenuItem.Name = "AddSameCategoryProductBySimNumberToolStripMenuItem"
        Me.AddSameCategoryProductBySimNumberToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.AddSameCategoryProductBySimNumberToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AddSameCategoryProductBySimNumberToolStripMenuItem.Text = "Add Same By SimNumber"
        Me.AddSameCategoryProductBySimNumberToolStripMenuItem.ToolTipText = "Add Same Product Category By SimNumber"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(224, 6)
        '
        'AddNewSimCategoryToolStripMenuItem
        '
        Me.AddNewSimCategoryToolStripMenuItem.Name = "AddNewSimCategoryToolStripMenuItem"
        Me.AddNewSimCategoryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.AddNewSimCategoryToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AddNewSimCategoryToolStripMenuItem.Text = "Add New Sim Category"
        '
        'SimSellingFormToolStripMenuItem
        '
        Me.SimSellingFormToolStripMenuItem.Name = "SimSellingFormToolStripMenuItem"
        Me.SimSellingFormToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.SimSellingFormToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.SimSellingFormToolStripMenuItem.Text = "Sim Selling Form"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(224, 6)
        '
        'ReLoadDatabaseToolStripMenuItem
        '
        Me.ReLoadDatabaseToolStripMenuItem.Name = "ReLoadDatabaseToolStripMenuItem"
        Me.ReLoadDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ReLoadDatabaseToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ReLoadDatabaseToolStripMenuItem.Text = "ReLoad Database"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 21)
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
        'SimStockBindingNavigatorSaveItem
        '
        Me.SimStockBindingNavigatorSaveItem.Image = CType(resources.GetObject("SimStockBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SimStockBindingNavigatorSaveItem.Name = "SimStockBindingNavigatorSaveItem"
        Me.SimStockBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.SimStockBindingNavigatorSaveItem.Text = "&Save Data"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripLabel1.Text = "SimNumber"
        '
        'PROG
        '
        Me.PROG.Name = "PROG"
        Me.PROG.Size = New System.Drawing.Size(100, 22)
        Me.PROG.Visible = False
        '
        'SimStockDataGridView
        '
        Me.SimStockDataGridView.AutoGenerateColumns = False
        Me.SimStockDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SimStockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.TCom_Field, Me.SimCate_Fied, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.IME})
        Me.SimStockDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.SimStockDataGridView.DataSource = Me.SimStockBindingSource
        Me.SimStockDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SimStockDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SimStockDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.SimStockDataGridView.Name = "SimStockDataGridView"
        Me.SimStockDataGridView.Size = New System.Drawing.Size(792, 541)
        Me.SimStockDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Sim_Number"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sim Number"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'TCom_Field
        '
        Me.TCom_Field.DataPropertyName = "Category_ID"
        Me.TCom_Field.DataSource = Me.MobComBindingSource
        Me.TCom_Field.DisplayMember = "Company"
        Me.TCom_Field.HeaderText = "Category ID"
        Me.TCom_Field.MinimumWidth = 120
        Me.TCom_Field.Name = "TCom_Field"
        Me.TCom_Field.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TCom_Field.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TCom_Field.ToolTipText = "Mobile Company Name"
        Me.TCom_Field.ValueMember = "Category_ID"
        Me.TCom_Field.Width = 120
        '
        'MobComBindingSource
        '
        Me.MobComBindingSource.DataMember = "Mob_Com"
        Me.MobComBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'SimCate_Fied
        '
        Me.SimCate_Fied.DataPropertyName = "Sim_Category"
        Me.SimCate_Fied.DataSource = Me.AukDatabaseDataSet
        Me.SimCate_Fied.DisplayMember = "SimCategory.SimCategory"
        Me.SimCate_Fied.HeaderText = "Sim Category"
        Me.SimCate_Fied.MinimumWidth = 120
        Me.SimCate_Fied.Name = "SimCate_Fied"
        Me.SimCate_Fied.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SimCate_Fied.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SimCate_Fied.ValueMember = "SimCategory.SimCategory"
        Me.SimCate_Fied.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Purchase_Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Purchase Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ToolTipText = "Automatic Effect by Today"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Purchase_Cost"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Purchase Cost"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Sold_Price"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Sold Price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Benefit"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn7.HeaderText = "Benefit"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.ToolTipText = "Automatic Get"
        '
        'IME
        '
        Me.IME.DataPropertyName = "IME"
        Me.IME.HeaderText = "IME Number"
        Me.IME.MinimumWidth = 180
        Me.IME.Name = "IME"
        Me.IME.Width = 180
        '
        'Mob_ComTableAdapter
        '
        Me.Mob_ComTableAdapter.ClearBeforeFill = True
        '
        'SimCategoryTableAdapter
        '
        Me.SimCategoryTableAdapter.ClearBeforeFill = True
        '
        'SimStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.SimStockDataGridView)
        Me.Controls.Add(Me.SimStockBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SimStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SimStock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimStockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimStockBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SimStockBindingNavigator.ResumeLayout(False)
        Me.SimStockBindingNavigator.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.SimStockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobComBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents SimStockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SimStockTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.SimStockTableAdapter
    Friend WithEvents SimStockBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SimStockBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SimStockDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MobComBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mob_ComTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.Mob_ComTableAdapter
    Friend WithEvents SimCategoryTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.SimCategoryTableAdapter
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PROG As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QueryManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FilterSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CommonInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddSameCategoryProductBySimNumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddNewSimCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimSellingFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReLoadDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCom_Field As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SimCate_Fied As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IME As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
