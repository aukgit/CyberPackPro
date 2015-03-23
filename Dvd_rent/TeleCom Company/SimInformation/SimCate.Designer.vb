<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimCate
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Mob_ComTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.Mob_ComTableAdapter
        Me.SimCategoryTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.SimCategoryTableAdapter
        Me.SimCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mob_ComBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.Mob_ComBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
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
        Me.Mob_ComBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.SimCategoryDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mob_ComDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.SimCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mob_ComBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mob_ComBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Mob_ComBindingNavigator.SuspendLayout()
        CType(Me.SimCategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mob_ComDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mob_ComTableAdapter
        '
        Me.Mob_ComTableAdapter.ClearBeforeFill = True
        '
        'SimCategoryTableAdapter
        '
        Me.SimCategoryTableAdapter.ClearBeforeFill = True
        '
        'SimCategoryBindingSource
        '
        Me.SimCategoryBindingSource.DataMember = "Mob_ComSimCategory"
        Me.SimCategoryBindingSource.DataSource = Me.Mob_ComBindingSource
        '
        'Mob_ComBindingSource
        '
        Me.Mob_ComBindingSource.DataMember = "Mob_Com"
        Me.Mob_ComBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mob_ComBindingNavigator
        '
        Me.Mob_ComBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Mob_ComBindingNavigator.BindingSource = Me.Mob_ComBindingSource
        Me.Mob_ComBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Mob_ComBindingNavigator.DeleteItem = Nothing
        Me.Mob_ComBindingNavigator.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mob_ComBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Mob_ComBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Mob_ComBindingNavigatorSaveItem})
        Me.Mob_ComBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Mob_ComBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Mob_ComBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Mob_ComBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Mob_ComBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Mob_ComBindingNavigator.Name = "Mob_ComBindingNavigator"
        Me.Mob_ComBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Mob_ComBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.Mob_ComBindingNavigator.TabIndex = 1
        Me.Mob_ComBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DataContainer_NewRecordHS
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(73, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        Me.BindingNavigatorMoveFirstItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DataContainer_MoveFirsHS
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DataContainer_MovePreviousHS
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
        Me.BindingNavigatorMoveNextItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DataContainer_MoveNextHS
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DataContainer_MoveLastHS
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
        Me.BindingNavigatorDeleteItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DeleteHS
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(61, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Mob_ComBindingNavigatorSaveItem
        '
        Me.Mob_ComBindingNavigatorSaveItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.saveHS
        Me.Mob_ComBindingNavigatorSaveItem.Name = "Mob_ComBindingNavigatorSaveItem"
        Me.Mob_ComBindingNavigatorSaveItem.Size = New System.Drawing.Size(81, 22)
        Me.Mob_ComBindingNavigatorSaveItem.Text = "&Save Data"
        '
        'SimCategoryDataGridView
        '
        Me.SimCategoryDataGridView.AutoGenerateColumns = False
        Me.SimCategoryDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SimCategoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SimCategoryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SimCategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3})
        Me.SimCategoryDataGridView.DataSource = Me.SimCategoryBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SimCategoryDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.SimCategoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SimCategoryDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SimCategoryDataGridView.Location = New System.Drawing.Point(350, 25)
        Me.SimCategoryDataGridView.Name = "SimCategoryDataGridView"
        Me.SimCategoryDataGridView.Size = New System.Drawing.Size(442, 541)
        Me.SimCategoryDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Category_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Category ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SimCategory"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SimCategory"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 220
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 220
        '
        'Mob_ComDataGridView
        '
        Me.Mob_ComDataGridView.AutoGenerateColumns = False
        Me.Mob_ComDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Mob_ComDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Mob_ComDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Mob_ComDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Mob_ComDataGridView.DataSource = Me.Mob_ComBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Mob_ComDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.Mob_ComDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.Mob_ComDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Mob_ComDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Mob_ComDataGridView.Name = "Mob_ComDataGridView"
        Me.Mob_ComDataGridView.Size = New System.Drawing.Size(350, 541)
        Me.Mob_ComDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Category_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Category ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ToolTipText = "From Mobile Recharge Company"
        Me.DataGridViewTextBoxColumn1.Width = 140
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Company"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Company"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 160
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 160
        '
        'SimCate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.SimCategoryDataGridView)
        Me.Controls.Add(Me.Mob_ComDataGridView)
        Me.Controls.Add(Me.Mob_ComBindingNavigator)
        Me.Name = "SimCate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SimCate"
        CType(Me.SimCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mob_ComBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mob_ComBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Mob_ComBindingNavigator.ResumeLayout(False)
        Me.Mob_ComBindingNavigator.PerformLayout()
        CType(Me.SimCategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mob_ComDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mob_ComTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.Mob_ComTableAdapter
    Friend WithEvents SimCategoryTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.SimCategoryTableAdapter
    Friend WithEvents SimCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mob_ComBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents Mob_ComBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Mob_ComBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SimCategoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mob_ComDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
