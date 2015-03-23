<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimSold
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimSold))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.SimSoldBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimSoldTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.SimSoldTableAdapter
        Me.SimSoldBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SellItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackToStoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.LoadByClientNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.FilterByOptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.comCombo = New System.Windows.Forms.ToolStripComboBox
        Me.FilterCurrentCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.SimCateCombo = New System.Windows.Forms.ToolStripComboBox
        Me.FilterCurrentSimCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FilterOnlyDueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FilterSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.SetDueTrueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetPaperCompleteTrueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ShowTillDueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowUnCompletePapersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowSummaryInCurrentRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.SimStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SimCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.LoadTodayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadYesterdayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.DateBusiness = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.OpenByNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.OpenByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.OpenTodayDueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenDueByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.OpenUnCompleteItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSplitButton
        Me.LoadDueByNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveFilterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.SimSoldDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCom_Field = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SimCate_Field = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PurCost_field = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SoldPrice_Field = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Benefit_Field = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SoldDate_Field = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.iNFOR = New System.Windows.Forms.Label
        Me.Day_Stock = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaY_Sold_InfoTableAdapter1 = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.DaY_Sold_InfoTableAdapter
        Me.SimCateBindSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyBindSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mob_ComTableAdapter1 = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.Mob_ComTableAdapter
        Me.SimCategoryTableAdapter1 = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.SimCategoryTableAdapter
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimSoldBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimSoldBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SimSoldBindingNavigator.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SimSoldDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Day_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimCateBindSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SimSoldBindingSource
        '
        Me.SimSoldBindingSource.DataMember = "SimSold"
        Me.SimSoldBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'SimSoldTableAdapter
        '
        Me.SimSoldTableAdapter.ClearBeforeFill = True
        '
        'SimSoldBindingNavigator
        '
        Me.SimSoldBindingNavigator.AddNewItem = Nothing
        Me.SimSoldBindingNavigator.BackgroundImage = CType(resources.GetObject("SimSoldBindingNavigator.BackgroundImage"), System.Drawing.Image)
        Me.SimSoldBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SimSoldBindingNavigator.BindingSource = Me.SimSoldBindingSource
        Me.SimSoldBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SimSoldBindingNavigator.DeleteItem = Nothing
        Me.SimSoldBindingNavigator.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimSoldBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SimSoldBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator4, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton4, Me.ToolStripButton3, Me.DateBusiness, Me.ToolStripSplitButton1, Me.ToolStripSeparator11, Me.ToolStripButton2, Me.ToolStripTextBox1})
        Me.SimSoldBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SimSoldBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SimSoldBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SimSoldBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SimSoldBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SimSoldBindingNavigator.Name = "SimSoldBindingNavigator"
        Me.SimSoldBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SimSoldBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.SimSoldBindingNavigator.TabIndex = 0
        Me.SimSoldBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.DropDown = Me.ContextMenuStrip1
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton1.Text = "&Menu"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SellItemToolStripMenuItem, Me.BackToStoreToolStripMenuItem, Me.ToolStripSeparator5, Me.LoadByClientNameToolStripMenuItem, Me.FilterOnlyDueToolStripMenuItem, Me.FilterByOptionToolStripMenuItem, Me.FilterSelectedToolStripMenuItem, Me.RemoveFilterToolStripMenuItem, Me.ToolStripSeparator12, Me.SetDueTrueToolStripMenuItem, Me.SetPaperCompleteTrueToolStripMenuItem, Me.ToolStripSeparator6, Me.ShowTillDueToolStripMenuItem, Me.ShowUnCompletePapersToolStripMenuItem, Me.ShowSummaryInCurrentRecordsToolStripMenuItem, Me.ToolStripSeparator7, Me.SimStockToolStripMenuItem, Me.SimCategoryToolStripMenuItem, Me.ToolStripSeparator8, Me.LoadTodayToolStripMenuItem, Me.LoadYesterdayToolStripMenuItem, Me.ToolStripSeparator9, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(283, 414)
        '
        'SellItemToolStripMenuItem
        '
        Me.SellItemToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.Small_imgs.AukRight2
        Me.SellItemToolStripMenuItem.Name = "SellItemToolStripMenuItem"
        Me.SellItemToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SellItemToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.SellItemToolStripMenuItem.Text = "Save"
        '
        'BackToStoreToolStripMenuItem
        '
        Me.BackToStoreToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.FillLeftHS
        Me.BackToStoreToolStripMenuItem.Name = "BackToStoreToolStripMenuItem"
        Me.BackToStoreToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BackToStoreToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.BackToStoreToolStripMenuItem.Text = "Back To Store"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(279, 6)
        '
        'LoadByClientNameToolStripMenuItem
        '
        Me.LoadByClientNameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox2})
        Me.LoadByClientNameToolStripMenuItem.Name = "LoadByClientNameToolStripMenuItem"
        Me.LoadByClientNameToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.LoadByClientNameToolStripMenuItem.Text = "Load By Client Name/SimNumber"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 21)
        '
        'FilterByOptionToolStripMenuItem
        '
        Me.FilterByOptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comCombo, Me.FilterCurrentCompanyToolStripMenuItem, Me.ToolStripSeparator10, Me.SimCateCombo, Me.FilterCurrentSimCategoryToolStripMenuItem})
        Me.FilterByOptionToolStripMenuItem.Name = "FilterByOptionToolStripMenuItem"
        Me.FilterByOptionToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.FilterByOptionToolStripMenuItem.Text = "Filter By Option"
        '
        'comCombo
        '
        Me.comCombo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comCombo.Name = "comCombo"
        Me.comCombo.Size = New System.Drawing.Size(121, 23)
        '
        'FilterCurrentCompanyToolStripMenuItem
        '
        Me.FilterCurrentCompanyToolStripMenuItem.Name = "FilterCurrentCompanyToolStripMenuItem"
        Me.FilterCurrentCompanyToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.FilterCurrentCompanyToolStripMenuItem.Tag = "com"
        Me.FilterCurrentCompanyToolStripMenuItem.Text = "Filter Current Company"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(218, 6)
        '
        'SimCateCombo
        '
        Me.SimCateCombo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimCateCombo.Name = "SimCateCombo"
        Me.SimCateCombo.Size = New System.Drawing.Size(121, 23)
        '
        'FilterCurrentSimCategoryToolStripMenuItem
        '
        Me.FilterCurrentSimCategoryToolStripMenuItem.Name = "FilterCurrentSimCategoryToolStripMenuItem"
        Me.FilterCurrentSimCategoryToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.FilterCurrentSimCategoryToolStripMenuItem.Tag = "sim"
        Me.FilterCurrentSimCategoryToolStripMenuItem.Text = "Filter Current Sim Category"
        '
        'FilterOnlyDueToolStripMenuItem
        '
        Me.FilterOnlyDueToolStripMenuItem.Name = "FilterOnlyDueToolStripMenuItem"
        Me.FilterOnlyDueToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.FilterOnlyDueToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.FilterOnlyDueToolStripMenuItem.Text = "Filter Only Due"
        '
        'FilterSelectedToolStripMenuItem
        '
        Me.FilterSelectedToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.Filter2HS
        Me.FilterSelectedToolStripMenuItem.Name = "FilterSelectedToolStripMenuItem"
        Me.FilterSelectedToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.FilterSelectedToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.FilterSelectedToolStripMenuItem.Text = "Filter Selected"
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DeleteHS
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "Remove Filter"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(279, 6)
        '
        'SetDueTrueToolStripMenuItem
        '
        Me.SetDueTrueToolStripMenuItem.Name = "SetDueTrueToolStripMenuItem"
        Me.SetDueTrueToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.SetDueTrueToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.SetDueTrueToolStripMenuItem.Tag = "d"
        Me.SetDueTrueToolStripMenuItem.Text = "Chagnge Due CheckBox"
        Me.SetDueTrueToolStripMenuItem.ToolTipText = "Invert the Due CheckBox"
        '
        'SetPaperCompleteTrueToolStripMenuItem
        '
        Me.SetPaperCompleteTrueToolStripMenuItem.Name = "SetPaperCompleteTrueToolStripMenuItem"
        Me.SetPaperCompleteTrueToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.SetPaperCompleteTrueToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.SetPaperCompleteTrueToolStripMenuItem.Tag = "p"
        Me.SetPaperCompleteTrueToolStripMenuItem.Text = "Chagnge CompletePaper CheckBox"
        Me.SetPaperCompleteTrueToolStripMenuItem.ToolTipText = "Invert the CompletePaper CheckBox"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(279, 6)
        '
        'ShowTillDueToolStripMenuItem
        '
        Me.ShowTillDueToolStripMenuItem.Name = "ShowTillDueToolStripMenuItem"
        Me.ShowTillDueToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ShowTillDueToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.ShowTillDueToolStripMenuItem.Text = "Show Till Due"
        '
        'ShowUnCompletePapersToolStripMenuItem
        '
        Me.ShowUnCompletePapersToolStripMenuItem.Name = "ShowUnCompletePapersToolStripMenuItem"
        Me.ShowUnCompletePapersToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ShowUnCompletePapersToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.ShowUnCompletePapersToolStripMenuItem.Text = "Show UnCompletePapers"
        '
        'ShowSummaryInCurrentRecordsToolStripMenuItem
        '
        Me.ShowSummaryInCurrentRecordsToolStripMenuItem.Name = "ShowSummaryInCurrentRecordsToolStripMenuItem"
        Me.ShowSummaryInCurrentRecordsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.ShowSummaryInCurrentRecordsToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.ShowSummaryInCurrentRecordsToolStripMenuItem.Text = "Show Summary In Current Records"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(279, 6)
        '
        'SimStockToolStripMenuItem
        '
        Me.SimStockToolStripMenuItem.Name = "SimStockToolStripMenuItem"
        Me.SimStockToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.SimStockToolStripMenuItem.Text = "Add New Sim In Stock"
        '
        'SimCategoryToolStripMenuItem
        '
        Me.SimCategoryToolStripMenuItem.Name = "SimCategoryToolStripMenuItem"
        Me.SimCategoryToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.SimCategoryToolStripMenuItem.Text = "Add New SimCategory"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(279, 6)
        '
        'LoadTodayToolStripMenuItem
        '
        Me.LoadTodayToolStripMenuItem.Name = "LoadTodayToolStripMenuItem"
        Me.LoadTodayToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.LoadTodayToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.LoadTodayToolStripMenuItem.Tag = "0"
        Me.LoadTodayToolStripMenuItem.Text = "Load Today"
        '
        'LoadYesterdayToolStripMenuItem
        '
        Me.LoadYesterdayToolStripMenuItem.Name = "LoadYesterdayToolStripMenuItem"
        Me.LoadYesterdayToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.LoadYesterdayToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.LoadYesterdayToolStripMenuItem.Tag = "-1"
        Me.LoadYesterdayToolStripMenuItem.Text = "Load Yesterday"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(279, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(282, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(14, 22)
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
        'ToolStripButton4
        '
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = Global.CyberPack_Pro.My.Resources.VsImg.FillLeftHS
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripButton4.Text = "&Back To Store"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = Global.CyberPack_Pro.My.Resources.Small_imgs.AukRight2
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton3.Text = "&Save"
        '
        'DateBusiness
        '
        Me.DateBusiness.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.DateBusiness.Name = "DateBusiness"
        Me.DateBusiness.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenByNumberToolStripMenuItem, Me.ToolStripSeparator3, Me.OpenByDateToolStripMenuItem, Me.ToolStripSeparator1, Me.OpenTodayDueToolStripMenuItem, Me.OpenDueByDateToolStripMenuItem, Me.ToolStripSeparator2, Me.OpenUnCompleteItemsToolStripMenuItem})
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripSplitButton1.Text = "Date"
        '
        'OpenByNumberToolStripMenuItem
        '
        Me.OpenByNumberToolStripMenuItem.Name = "OpenByNumberToolStripMenuItem"
        Me.OpenByNumberToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.OpenByNumberToolStripMenuItem.Text = "Open By Number"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(205, 6)
        '
        'OpenByDateToolStripMenuItem
        '
        Me.OpenByDateToolStripMenuItem.Name = "OpenByDateToolStripMenuItem"
        Me.OpenByDateToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.OpenByDateToolStripMenuItem.Text = "Open By Date"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(205, 6)
        '
        'OpenTodayDueToolStripMenuItem
        '
        Me.OpenTodayDueToolStripMenuItem.Name = "OpenTodayDueToolStripMenuItem"
        Me.OpenTodayDueToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.OpenTodayDueToolStripMenuItem.Text = "Open Today Due"
        '
        'OpenDueByDateToolStripMenuItem
        '
        Me.OpenDueByDateToolStripMenuItem.Name = "OpenDueByDateToolStripMenuItem"
        Me.OpenDueByDateToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.OpenDueByDateToolStripMenuItem.Text = "Open Due By Date"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(205, 6)
        '
        'OpenUnCompleteItemsToolStripMenuItem
        '
        Me.OpenUnCompleteItemsToolStripMenuItem.Name = "OpenUnCompleteItemsToolStripMenuItem"
        Me.OpenUnCompleteItemsToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.OpenUnCompleteItemsToolStripMenuItem.Text = "Open Un Complete Items"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDueByNumberToolStripMenuItem, Me.RemoveFilterToolStripMenuItem1})
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButton2.Text = "Due"
        '
        'LoadDueByNumberToolStripMenuItem
        '
        Me.LoadDueByNumberToolStripMenuItem.Name = "LoadDueByNumberToolStripMenuItem"
        Me.LoadDueByNumberToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D"
        Me.LoadDueByNumberToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.LoadDueByNumberToolStripMenuItem.Text = "Filter Only Due"
        '
        'RemoveFilterToolStripMenuItem1
        '
        Me.RemoveFilterToolStripMenuItem1.Name = "RemoveFilterToolStripMenuItem1"
        Me.RemoveFilterToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+R"
        Me.RemoveFilterToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.RemoveFilterToolStripMenuItem1.Text = "Remove Filter"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox1.ToolTipText = "Load by SimNumber/Clients Name,Effect : Load with & Filter"
        '
        'SimSoldDataGridView
        '
        Me.SimSoldDataGridView.AllowUserToAddRows = False
        Me.SimSoldDataGridView.AutoGenerateColumns = False
        Me.SimSoldDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SimSoldDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn5, Me.TCom_Field, Me.SimCate_Field, Me.DataGridViewTextBoxColumn6, Me.PurCost_field, Me.SoldPrice_Field, Me.Benefit_Field, Me.SoldDate_Field, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn11})
        Me.SimSoldDataGridView.DataSource = Me.SimSoldBindingSource
        Me.SimSoldDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SimSoldDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SimSoldDataGridView.Location = New System.Drawing.Point(0, 50)
        Me.SimSoldDataGridView.Name = "SimSoldDataGridView"
        Me.SimSoldDataGridView.Size = New System.Drawing.Size(600, 516)
        Me.SimSoldDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Sim_Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sim Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Client_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Client Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IME"
        Me.DataGridViewTextBoxColumn12.HeaderText = "IME Number"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Client_Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'TCom_Field
        '
        Me.TCom_Field.DataPropertyName = "Category_ID"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.TCom_Field.DefaultCellStyle = DataGridViewCellStyle1
        Me.TCom_Field.HeaderText = "Category ID"
        Me.TCom_Field.Name = "TCom_Field"
        Me.TCom_Field.Visible = False
        '
        'SimCate_Field
        '
        Me.SimCate_Field.DataPropertyName = "Sim_Category"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.SimCate_Field.DefaultCellStyle = DataGridViewCellStyle2
        Me.SimCate_Field.HeaderText = "Sim Category"
        Me.SimCate_Field.Name = "SimCate_Field"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Discount"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Discount"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'PurCost_field
        '
        Me.PurCost_field.DataPropertyName = "Purchase_Cost"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.PurCost_field.DefaultCellStyle = DataGridViewCellStyle3
        Me.PurCost_field.HeaderText = "Purchase Cost"
        Me.PurCost_field.Name = "PurCost_field"
        Me.PurCost_field.Visible = False
        '
        'SoldPrice_Field
        '
        Me.SoldPrice_Field.DataPropertyName = "Sold_Price"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.SoldPrice_Field.DefaultCellStyle = DataGridViewCellStyle4
        Me.SoldPrice_Field.HeaderText = "Sold Price"
        Me.SoldPrice_Field.Name = "SoldPrice_Field"
        Me.SoldPrice_Field.Width = 70
        '
        'Benefit_Field
        '
        Me.Benefit_Field.DataPropertyName = "Benefit"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.Benefit_Field.DefaultCellStyle = DataGridViewCellStyle5
        Me.Benefit_Field.HeaderText = "Benefit"
        Me.Benefit_Field.Name = "Benefit_Field"
        Me.Benefit_Field.Visible = False
        Me.Benefit_Field.Width = 60
        '
        'SoldDate_Field
        '
        Me.SoldDate_Field.DataPropertyName = "Sold_Date"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        Me.SoldDate_Field.DefaultCellStyle = DataGridViewCellStyle6
        Me.SoldDate_Field.HeaderText = "Sold Date"
        Me.SoldDate_Field.Name = "SoldDate_Field"
        Me.SoldDate_Field.Width = 70
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "PaperComplete"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Comp"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ToolTipText = "PaperComplete"
        Me.DataGridViewCheckBoxColumn1.Width = 40
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Due"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Due"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Comments"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Comments"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.White
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(1, 3)
        Me.MonthCalendar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MonthCalendar1.Location = New System.Drawing.Point(600, 25)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        Me.MonthCalendar1.Visible = False
        '
        'iNFOR
        '
        Me.iNFOR.BackColor = System.Drawing.Color.Black
        Me.iNFOR.Dock = System.Windows.Forms.DockStyle.Top
        Me.iNFOR.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iNFOR.ForeColor = System.Drawing.Color.White
        Me.iNFOR.Location = New System.Drawing.Point(0, 25)
        Me.iNFOR.Name = "iNFOR"
        Me.iNFOR.Size = New System.Drawing.Size(600, 25)
        Me.iNFOR.TabIndex = 7
        Me.iNFOR.Text = "INFORMATION"
        Me.iNFOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.iNFOR.Visible = False
        '
        'Day_Stock
        '
        Me.Day_Stock.DataMember = "DaY_Sold_Info"
        Me.Day_Stock.DataSource = Me.AukDatabaseDataSet
        '
        'DaY_Sold_InfoTableAdapter1
        '
        Me.DaY_Sold_InfoTableAdapter1.ClearBeforeFill = True
        '
        'SimCateBindSource
        '
        Me.SimCateBindSource.DataMember = "SimCategory"
        Me.SimCateBindSource.DataSource = Me.AukDatabaseDataSet
        '
        'CompanyBindSource
        '
        Me.CompanyBindSource.DataMember = "Mob_Com"
        Me.CompanyBindSource.DataSource = Me.AukDatabaseDataSet
        '
        'Mob_ComTableAdapter1
        '
        Me.Mob_ComTableAdapter1.ClearBeforeFill = True
        '
        'SimCategoryTableAdapter1
        '
        Me.SimCategoryTableAdapter1.ClearBeforeFill = True
        '
        'SimSold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.SimSoldDataGridView)
        Me.Controls.Add(Me.iNFOR)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.SimSoldBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SimSold"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SimSold"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimSoldBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimSoldBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SimSoldBindingNavigator.ResumeLayout(False)
        Me.SimSoldBindingNavigator.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.SimSoldDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Day_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimCateBindSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents SimSoldBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SimSoldTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.SimSoldTableAdapter
    Friend WithEvents SimSoldBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SimSoldDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DateBusiness As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents OpenByNumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenByDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenTodayDueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDueByDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenUnCompleteItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BackToStoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SellItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FilterSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShowSummaryInCurrentRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowTillDueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowUnCompletePapersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterByOptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents comCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents FilterCurrentCompanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SimCateCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents FilterCurrentSimCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SimCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LoadTodayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadYesterdayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LoadByClientNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents iNFOR As System.Windows.Forms.Label
    Friend WithEvents Day_Stock As System.Windows.Forms.BindingSource
    Friend WithEvents FilterOnlyDueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents LoadDueByNumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveFilterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SetDueTrueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetPaperCompleteTrueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaY_Sold_InfoTableAdapter1 As CyberPack_Pro.AukDatabaseDataSetTableAdapters.DaY_Sold_InfoTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCom_Field As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SimCate_Field As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurCost_field As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoldPrice_Field As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Benefit_Field As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoldDate_Field As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SimCateBindSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyBindSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mob_ComTableAdapter1 As CyberPack_Pro.AukDatabaseDataSetTableAdapters.Mob_ComTableAdapter
    Friend WithEvents SimCategoryTableAdapter1 As CyberPack_Pro.AukDatabaseDataSetTableAdapters.SimCategoryTableAdapter
End Class
