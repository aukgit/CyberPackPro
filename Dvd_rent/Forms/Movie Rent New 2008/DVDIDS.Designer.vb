<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DVDIDSFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DVDIDSFrm))
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.DVDIDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DVDIDSTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.DVDIDSTableAdapter
        Me.DVDIDSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.DVDIDSDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.DVDIDSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVDIDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVDIDSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DVDIDSBindingNavigator.SuspendLayout()
        CType(Me.DVDIDSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DVDIDSBindingSource
        '
        Me.DVDIDSBindingSource.DataMember = "DVDIDS"
        Me.DVDIDSBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'DVDIDSTableAdapter
        '
        Me.DVDIDSTableAdapter.ClearBeforeFill = True
        '
        'DVDIDSBindingNavigator
        '
        Me.DVDIDSBindingNavigator.AddNewItem = Nothing
        Me.DVDIDSBindingNavigator.BindingSource = Me.DVDIDSBindingSource
        Me.DVDIDSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DVDIDSBindingNavigator.DeleteItem = Nothing
        Me.DVDIDSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.DVDIDSBindingNavigatorSaveItem})
        Me.DVDIDSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DVDIDSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DVDIDSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DVDIDSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DVDIDSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DVDIDSBindingNavigator.Name = "DVDIDSBindingNavigator"
        Me.DVDIDSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DVDIDSBindingNavigator.Size = New System.Drawing.Size(536, 25)
        Me.DVDIDSBindingNavigator.TabIndex = 0
        Me.DVDIDSBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DVDIDSDataGridView
        '
        Me.DVDIDSDataGridView.AllowUserToAddRows = False
        Me.DVDIDSDataGridView.AutoGenerateColumns = False
        Me.DVDIDSDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DVDIDSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DVDIDSDataGridView.DataSource = Me.DVDIDSBindingSource
        Me.DVDIDSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DVDIDSDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.DVDIDSDataGridView.Name = "DVDIDSDataGridView"
        Me.DVDIDSDataGridView.Size = New System.Drawing.Size(536, 403)
        Me.DVDIDSDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
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
        'DVDIDSBindingNavigatorSaveItem
        '
        Me.DVDIDSBindingNavigatorSaveItem.Image = CType(resources.GetObject("DVDIDSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DVDIDSBindingNavigatorSaveItem.Name = "DVDIDSBindingNavigatorSaveItem"
        Me.DVDIDSBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.DVDIDSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DVDIDSFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 428)
        Me.Controls.Add(Me.DVDIDSDataGridView)
        Me.Controls.Add(Me.DVDIDSBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DVDIDSFrm"
        Me.Text = "DVDIDS"
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVDIDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVDIDSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DVDIDSBindingNavigator.ResumeLayout(False)
        Me.DVDIDSBindingNavigator.PerformLayout()
        CType(Me.DVDIDSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents DVDIDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DVDIDSTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.DVDIDSTableAdapter
    Friend WithEvents DVDIDSBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DVDIDSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DVDIDSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
