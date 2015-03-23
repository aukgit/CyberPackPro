<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PS_WARRANTY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PS_WARRANTY))
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.PS_WARRANTYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PS_WARRANTYTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_WARRANTYTableAdapter
        Me.PS_WARRANTYBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.PS_WARRANTYDataGridView = New System.Windows.Forms.DataGridView
        Me.VENDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENDORTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.VENDORTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_ID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NEW_PRODUCT_SERIAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLIENT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS_WARRANTYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS_WARRANTYBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PS_WARRANTYBindingNavigator.SuspendLayout()
        CType(Me.PS_WARRANTYDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PS_WARRANTYBindingSource
        '
        Me.PS_WARRANTYBindingSource.DataMember = "PS_WARRANTY"
        Me.PS_WARRANTYBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'PS_WARRANTYTableAdapter
        '
        Me.PS_WARRANTYTableAdapter.ClearBeforeFill = True
        '
        'PS_WARRANTYBindingNavigator
        '
        Me.PS_WARRANTYBindingNavigator.AddNewItem = Nothing
        Me.PS_WARRANTYBindingNavigator.BindingSource = Me.PS_WARRANTYBindingSource
        Me.PS_WARRANTYBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PS_WARRANTYBindingNavigator.DeleteItem = Nothing
        Me.PS_WARRANTYBindingNavigator.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PS_WARRANTYBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripButton2})
        Me.PS_WARRANTYBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PS_WARRANTYBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PS_WARRANTYBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PS_WARRANTYBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PS_WARRANTYBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PS_WARRANTYBindingNavigator.Name = "PS_WARRANTYBindingNavigator"
        Me.PS_WARRANTYBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PS_WARRANTYBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.PS_WARRANTYBindingNavigator.TabIndex = 0
        Me.PS_WARRANTYBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.GoLtrHS
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(84, 22)
        Me.BindingNavigatorDeleteItem.Text = "&EFFECT ON"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripLabel1.Text = "SEARCH ON FIELDS"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox1.ToolTipText = "FIND WARRANTY ID,SOLD ID,PRODUCT SERIAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LOAD ONLY PRODUCT SERIAL OR SOLD ID"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(138, 22)
        Me.ToolStripButton1.Text = "LOAD WHOLE DATABASE"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripButton2.Text = "&QUERY"
        '
        'PS_WARRANTYDataGridView
        '
        Me.PS_WARRANTYDataGridView.AllowUserToAddRows = False
        Me.PS_WARRANTYDataGridView.AutoGenerateColumns = False
        Me.PS_WARRANTYDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PS_WARRANTYDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PS_WARRANTYDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PS_WARRANTYDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.V_ID, Me.DataGridViewTextBoxColumn3, Me.NEW_PRODUCT_SERIAL, Me.CLIENT_NAME, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PS_WARRANTYDataGridView.DataSource = Me.PS_WARRANTYBindingSource
        Me.PS_WARRANTYDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PS_WARRANTYDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PS_WARRANTYDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.PS_WARRANTYDataGridView.Name = "PS_WARRANTYDataGridView"
        Me.PS_WARRANTYDataGridView.Size = New System.Drawing.Size(792, 560)
        Me.PS_WARRANTYDataGridView.TabIndex = 1
        '
        'VENDORBindingSource
        '
        Me.VENDORBindingSource.DataMember = "VENDOR"
        Me.VENDORBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'VENDORTableAdapter
        '
        Me.VENDORTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "WARRANTY_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.ToolTipText = "WARRANTY ID"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SOLD_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SOLD ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'V_ID
        '
        Me.V_ID.DataPropertyName = "V_ID"
        Me.V_ID.DataSource = Me.AukDatabaseDataSet
        Me.V_ID.DisplayMember = "VENDOR.V_NAME"
        Me.V_ID.DisplayStyleForCurrentCellOnly = True
        Me.V_ID.HeaderText = "VENDOR NAME"
        Me.V_ID.MinimumWidth = 130
        Me.V_ID.Name = "V_ID"
        Me.V_ID.ReadOnly = True
        Me.V_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.V_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.V_ID.ToolTipText = "LINKED WITH VENDORS ID"
        Me.V_ID.ValueMember = "VENDOR.V_ID"
        Me.V_ID.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PRODUCT_SERIAL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GOOD'S SERIAL"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 140
        '
        'NEW_PRODUCT_SERIAL
        '
        Me.NEW_PRODUCT_SERIAL.DataPropertyName = "NEW_PRODUCT_SERIAL"
        Me.NEW_PRODUCT_SERIAL.HeaderText = "NEW SERIAL"
        Me.NEW_PRODUCT_SERIAL.MinimumWidth = 140
        Me.NEW_PRODUCT_SERIAL.Name = "NEW_PRODUCT_SERIAL"
        Me.NEW_PRODUCT_SERIAL.ToolTipText = "NEW PRODUCT SERIAL"
        Me.NEW_PRODUCT_SERIAL.Width = 140
        '
        'CLIENT_NAME
        '
        Me.CLIENT_NAME.DataPropertyName = "CLIENT_NAME"
        Me.CLIENT_NAME.HeaderText = "CLIENT NAME"
        Me.CLIENT_NAME.MinimumWidth = 120
        Me.CLIENT_NAME.Name = "CLIENT_NAME"
        Me.CLIENT_NAME.ReadOnly = True
        Me.CLIENT_NAME.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "WARRANTY_DATE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "WARRANTY DATE"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.ToolTipText = "SEND PRODUCT IN WARRANTY"
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "REMAIN_DAYS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "REMAIN DAYS"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 110
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "WHEN_GIVE_UP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "WHEN GIVE UP"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.ToolTipText = "WHEN RETURN OR HAND OVER THE PRODUCT TO THE CLIENT"
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "REPORT_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "REPORT ID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 130
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 130
        '
        'PS_WARRANTY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 585)
        Me.Controls.Add(Me.PS_WARRANTYDataGridView)
        Me.Controls.Add(Me.PS_WARRANTYBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PS_WARRANTY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PS WARRANTY"
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS_WARRANTYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS_WARRANTYBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PS_WARRANTYBindingNavigator.ResumeLayout(False)
        Me.PS_WARRANTYBindingNavigator.PerformLayout()
        CType(Me.PS_WARRANTYDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents PS_WARRANTYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PS_WARRANTYTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_WARRANTYTableAdapter
    Friend WithEvents PS_WARRANTYBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PS_WARRANTYDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents VENDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VENDORTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.VENDORTableAdapter
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents V_ID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NEW_PRODUCT_SERIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENT_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
