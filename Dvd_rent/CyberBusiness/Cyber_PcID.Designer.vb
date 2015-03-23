<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cyber_PcID
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cyber_PcID))
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.Cyber_PCIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cyber_PCIDTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.Cyber_PCIDTableAdapter
        Me.Cyber_PCIDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Cyber_PCIDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Cyber_PCIDDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IPAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cyber_PCIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cyber_PCIDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cyber_PCIDBindingNavigator.SuspendLayout()
        CType(Me.Cyber_PCIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cyber_PCIDBindingSource
        '
        Me.Cyber_PCIDBindingSource.DataMember = "Cyber_PCID"
        Me.Cyber_PCIDBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'Cyber_PCIDTableAdapter
        '
        Me.Cyber_PCIDTableAdapter.ClearBeforeFill = True
        '
        'Cyber_PCIDBindingNavigator
        '
        Me.Cyber_PCIDBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Cyber_PCIDBindingNavigator.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Cyber_PCIDBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cyber_PCIDBindingNavigator.BindingSource = Me.Cyber_PCIDBindingSource
        Me.Cyber_PCIDBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Cyber_PCIDBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Cyber_PCIDBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Cyber_PCIDBindingNavigatorSaveItem})
        Me.Cyber_PCIDBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Cyber_PCIDBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Cyber_PCIDBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Cyber_PCIDBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Cyber_PCIDBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Cyber_PCIDBindingNavigator.Name = "Cyber_PCIDBindingNavigator"
        Me.Cyber_PCIDBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Cyber_PCIDBindingNavigator.Size = New System.Drawing.Size(845, 25)
        Me.Cyber_PCIDBindingNavigator.TabIndex = 0
        Me.Cyber_PCIDBindingNavigator.Text = "BindingNavigator1"
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
        'Cyber_PCIDBindingNavigatorSaveItem
        '
        Me.Cyber_PCIDBindingNavigatorSaveItem.Image = CType(resources.GetObject("Cyber_PCIDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Cyber_PCIDBindingNavigatorSaveItem.Name = "Cyber_PCIDBindingNavigatorSaveItem"
        Me.Cyber_PCIDBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.Cyber_PCIDBindingNavigatorSaveItem.Text = "&Save Data"
        '
        'Cyber_PCIDDataGridView
        '
        Me.Cyber_PCIDDataGridView.AutoGenerateColumns = False
        Me.Cyber_PCIDDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Cyber_PCIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.IPAddress})
        Me.Cyber_PCIDDataGridView.DataSource = Me.Cyber_PCIDBindingSource
        Me.Cyber_PCIDDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cyber_PCIDDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Cyber_PCIDDataGridView.Name = "Cyber_PCIDDataGridView"
        Me.Cyber_PCIDDataGridView.Size = New System.Drawing.Size(845, 535)
        Me.Cyber_PCIDDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PC_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PC ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PC_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PC Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'IPAddress
        '
        Me.IPAddress.DataPropertyName = "IPAddress"
        Me.IPAddress.HeaderText = "IP Address"
        Me.IPAddress.MinimumWidth = 200
        Me.IPAddress.Name = "IPAddress"
        Me.IPAddress.Width = 200
        '
        'Cyber_PcID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(845, 560)
        Me.Controls.Add(Me.Cyber_PCIDDataGridView)
        Me.Controls.Add(Me.Cyber_PCIDBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Cyber_PcID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CyberCafe PC Entry"
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cyber_PCIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cyber_PCIDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cyber_PCIDBindingNavigator.ResumeLayout(False)
        Me.Cyber_PCIDBindingNavigator.PerformLayout()
        CType(Me.Cyber_PCIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents Cyber_PCIDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cyber_PCIDTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.Cyber_PCIDTableAdapter
    Friend WithEvents Cyber_PCIDBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Cyber_PCIDBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cyber_PCIDDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IPAddress As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
