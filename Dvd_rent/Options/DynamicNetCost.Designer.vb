<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DynamicNetCost
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DynamicNetCost))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.CHourBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CHourTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.CHourTableAdapter
        Me.CHourBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CHourBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CHourDataGridView = New System.Windows.Forms.DataGridView
        Me.CHourBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MinuteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NetUsingCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHourBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHourBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CHourBindingNavigator.SuspendLayout()
        CType(Me.CHourDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHourBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(630, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dynamic System : This system effect on Cyber Net Using Cost , when the users net " & _
            "using hour and minute will be crossed this duration and after that .. the new dy" & _
            "namic net using cost will be set."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CHourBindingSource
        '
        Me.CHourBindingSource.DataSource = Me.AukDatabaseDataSet
        Me.CHourBindingSource.Position = 0
        '
        'CHourTableAdapter
        '
        Me.CHourTableAdapter.ClearBeforeFill = True
        '
        'CHourBindingNavigator
        '
        Me.CHourBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CHourBindingNavigator.BackColor = System.Drawing.Color.Black
        Me.CHourBindingNavigator.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.BlackEverSlPNG
        Me.CHourBindingNavigator.BindingSource = Me.CHourBindingSource
        Me.CHourBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CHourBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CHourBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CHourBindingNavigatorSaveItem})
        Me.CHourBindingNavigator.Location = New System.Drawing.Point(0, 47)
        Me.CHourBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CHourBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CHourBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CHourBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CHourBindingNavigator.Name = "CHourBindingNavigator"
        Me.CHourBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CHourBindingNavigator.Size = New System.Drawing.Size(630, 25)
        Me.CHourBindingNavigator.TabIndex = 1
        Me.CHourBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(73, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(33, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorDeleteItem.Image = Global.CyberPack_Pro.My.Resources.Resources.DeleteHS2
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        Me.BindingNavigatorPositionItem.Text = "1"
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
        'CHourBindingNavigatorSaveItem
        '
        Me.CHourBindingNavigatorSaveItem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHourBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.White
        Me.CHourBindingNavigatorSaveItem.Image = CType(resources.GetObject("CHourBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CHourBindingNavigatorSaveItem.Name = "CHourBindingNavigatorSaveItem"
        Me.CHourBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.CHourBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CHourDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.CHourDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CHourDataGridView.AutoGenerateColumns = False
        Me.CHourDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CHourDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHourDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CHourDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.HourDataGridViewTextBoxColumn, Me.MinuteDataGridViewTextBoxColumn, Me.NetUsingCostDataGridViewTextBoxColumn})
        Me.CHourDataGridView.DataSource = Me.CHourBindingSource1
        Me.CHourDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CHourDataGridView.Location = New System.Drawing.Point(0, 72)
        Me.CHourDataGridView.Name = "CHourDataGridView"
        Me.CHourDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHourDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CHourDataGridView.Size = New System.Drawing.Size(630, 453)
        Me.CHourDataGridView.TabIndex = 2
        '
        'CHourBindingSource1
        '
        Me.CHourBindingSource1.DataMember = "CHour"
        Me.CHourBindingSource1.DataSource = Me.CHourBindingSource
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HourDataGridViewTextBoxColumn
        '
        Me.HourDataGridViewTextBoxColumn.DataPropertyName = "Hour"
        Me.HourDataGridViewTextBoxColumn.HeaderText = "Hour"
        Me.HourDataGridViewTextBoxColumn.Name = "HourDataGridViewTextBoxColumn"
        '
        'MinuteDataGridViewTextBoxColumn
        '
        Me.MinuteDataGridViewTextBoxColumn.DataPropertyName = "Minute"
        Me.MinuteDataGridViewTextBoxColumn.HeaderText = "Minute"
        Me.MinuteDataGridViewTextBoxColumn.Name = "MinuteDataGridViewTextBoxColumn"
        Me.MinuteDataGridViewTextBoxColumn.Visible = False
        '
        'NetUsingCostDataGridViewTextBoxColumn
        '
        Me.NetUsingCostDataGridViewTextBoxColumn.DataPropertyName = "NetUsingCost"
        Me.NetUsingCostDataGridViewTextBoxColumn.HeaderText = "Net Using Cost"
        Me.NetUsingCostDataGridViewTextBoxColumn.Name = "NetUsingCostDataGridViewTextBoxColumn"
        '
        'DynamicNetCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 525)
        Me.Controls.Add(Me.CHourDataGridView)
        Me.Controls.Add(Me.CHourBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DynamicNetCost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DynamicNetCost"
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHourBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHourBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CHourBindingNavigator.ResumeLayout(False)
        Me.CHourBindingNavigator.PerformLayout()
        CType(Me.CHourDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHourBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents CHourBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CHourTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.CHourTableAdapter
    Friend WithEvents CHourBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CHourBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CHourDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CHourBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HourDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinuteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NetUsingCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
