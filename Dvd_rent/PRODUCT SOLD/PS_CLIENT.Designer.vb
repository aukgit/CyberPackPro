<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PS_CLIENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PS_CLIENT))
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.PS_CLIENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PS_CLIENTSTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CLIENTSTableAdapter
        Me.PS_CLIENTSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.SEARCHQUERYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOADWHOLEDATABASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CLEARWHOLEDATABASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.PS_CLIENTSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.PS_CLIENTSDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CURRENTCLIENTCONSINGEDPRODUCTSDATESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS_CLIENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS_CLIENTSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PS_CLIENTSBindingNavigator.SuspendLayout()
        CType(Me.PS_CLIENTSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PS_CLIENTSBindingSource
        '
        Me.PS_CLIENTSBindingSource.DataMember = "PS_CLIENTS"
        Me.PS_CLIENTSBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'PS_CLIENTSTableAdapter
        '
        Me.PS_CLIENTSTableAdapter.ClearBeforeFill = True
        '
        'PS_CLIENTSBindingNavigator
        '
        Me.PS_CLIENTSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PS_CLIENTSBindingNavigator.BindingSource = Me.PS_CLIENTSBindingSource
        Me.PS_CLIENTSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PS_CLIENTSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PS_CLIENTSBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PS_CLIENTSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator2, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PS_CLIENTSBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripButton2})
        Me.PS_CLIENTSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PS_CLIENTSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PS_CLIENTSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PS_CLIENTSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PS_CLIENTSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PS_CLIENTSBindingNavigator.Name = "PS_CLIENTSBindingNavigator"
        Me.PS_CLIENTSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PS_CLIENTSBindingNavigator.Size = New System.Drawing.Size(809, 25)
        Me.PS_CLIENTSBindingNavigator.TabIndex = 0
        Me.PS_CLIENTSBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(69, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SEARCHQUERYToolStripMenuItem, Me.LOADWHOLEDATABASEToolStripMenuItem, Me.CURRENTCLIENTCONSINGEDPRODUCTSDATESToolStripMenuItem, Me.CLEARWHOLEDATABASEToolStripMenuItem})
        Me.ToolStripButton1.Image = Global.CyberPack_Pro.My.Resources.VsImg.GoLtrHS
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripButton1.Text = "MENU"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SEARCHQUERYToolStripMenuItem
        '
        Me.SEARCHQUERYToolStripMenuItem.Name = "SEARCHQUERYToolStripMenuItem"
        Me.SEARCHQUERYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.SEARCHQUERYToolStripMenuItem.Size = New System.Drawing.Size(332, 22)
        Me.SEARCHQUERYToolStripMenuItem.Text = "SEARCH/QUERY"
        '
        'LOADWHOLEDATABASEToolStripMenuItem
        '
        Me.LOADWHOLEDATABASEToolStripMenuItem.Name = "LOADWHOLEDATABASEToolStripMenuItem"
        Me.LOADWHOLEDATABASEToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.LOADWHOLEDATABASEToolStripMenuItem.Size = New System.Drawing.Size(332, 22)
        Me.LOADWHOLEDATABASEToolStripMenuItem.Text = "LOAD WHOLE DATABASE"
        '
        'CLEARWHOLEDATABASEToolStripMenuItem
        '
        Me.CLEARWHOLEDATABASEToolStripMenuItem.Name = "CLEARWHOLEDATABASEToolStripMenuItem"
        Me.CLEARWHOLEDATABASEToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.CLEARWHOLEDATABASEToolStripMenuItem.Size = New System.Drawing.Size(332, 22)
        Me.CLEARWHOLEDATABASEToolStripMenuItem.Text = "CLEAR WHOLE DATABASE"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'PS_CLIENTSBindingNavigatorSaveItem
        '
        Me.PS_CLIENTSBindingNavigatorSaveItem.Image = CType(resources.GetObject("PS_CLIENTSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PS_CLIENTSBindingNavigatorSaveItem.Name = "PS_CLIENTSBindingNavigatorSaveItem"
        Me.PS_CLIENTSBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.PS_CLIENTSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox1.ToolTipText = "TYPE CLIENT NAME,ADDRESS,CONTACT NUMBER"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(179, 22)
        Me.ToolStripButton2.Text = "SHOW CURRENT CLIENT CONSIGN"
        '
        'PS_CLIENTSDataGridView
        '
        Me.PS_CLIENTSDataGridView.AutoGenerateColumns = False
        Me.PS_CLIENTSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PS_CLIENTSDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PS_CLIENTSDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PS_CLIENTSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.PS_CLIENTSDataGridView.DataSource = Me.PS_CLIENTSBindingSource
        Me.PS_CLIENTSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PS_CLIENTSDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.PS_CLIENTSDataGridView.Name = "PS_CLIENTSDataGridView"
        Me.PS_CLIENTSDataGridView.Size = New System.Drawing.Size(809, 575)
        Me.PS_CLIENTSDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CLIENT_NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CLIENT_NAME"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 130
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CONTACT_NUMBER"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CONTACT_NUMBER"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ADDRESS"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ADDRESS"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 220
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 220
        '
        'CURRENTCLIENTCONSINGEDPRODUCTSDATESToolStripMenuItem
        '
        Me.CURRENTCLIENTCONSINGEDPRODUCTSDATESToolStripMenuItem.Name = "CURRENTCLIENTCONSINGEDPRODUCTSDATESToolStripMenuItem"
        Me.CURRENTCLIENTCONSINGEDPRODUCTSDATESToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.CURRENTCLIENTCONSINGEDPRODUCTSDATESToolStripMenuItem.Size = New System.Drawing.Size(332, 22)
        Me.CURRENTCLIENTCONSINGEDPRODUCTSDATESToolStripMenuItem.Text = "CURRENT CLIENT CONSINGED PRODUCTS DATES"
        '
        'PS_CLIENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 600)
        Me.Controls.Add(Me.PS_CLIENTSDataGridView)
        Me.Controls.Add(Me.PS_CLIENTSBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "PS_CLIENT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCT SOLD CLIENTS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS_CLIENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS_CLIENTSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PS_CLIENTSBindingNavigator.ResumeLayout(False)
        Me.PS_CLIENTSBindingNavigator.PerformLayout()
        CType(Me.PS_CLIENTSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents PS_CLIENTSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PS_CLIENTSTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_CLIENTSTableAdapter
    Friend WithEvents PS_CLIENTSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PS_CLIENTSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PS_CLIENTSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SEARCHQUERYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOADWHOLEDATABASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLEARWHOLEDATABASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CURRENTCLIENTCONSINGEDPRODUCTSDATESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
