<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ip_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ip_Settings))
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.Cyber_MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cyber_MemberTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.Cyber_MemberTableAdapter
        Me.Cyber_MemberBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Cyber_MemberBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.Cyber_MemberDataGrid = New System.Windows.Forms.DataGrid
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cyber_MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cyber_MemberBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cyber_MemberBindingNavigator.SuspendLayout()
        CType(Me.Cyber_MemberDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cyber_MemberBindingSource
        '
        Me.Cyber_MemberBindingSource.AllowNew = False
        '
        'Cyber_MemberTableAdapter
        '
        Me.Cyber_MemberTableAdapter.ClearBeforeFill = True
        '
        'Cyber_MemberBindingNavigator
        '
        Me.Cyber_MemberBindingNavigator.AddNewItem = Nothing
        Me.Cyber_MemberBindingNavigator.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.Cyber_MemberBindingNavigator.BindingSource = Me.Cyber_MemberBindingSource
        Me.Cyber_MemberBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Cyber_MemberBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Cyber_MemberBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.Cyber_MemberBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripSeparator2, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripLabel2, Me.ToolStripTextBox2, Me.ToolStripButton3})
        Me.Cyber_MemberBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Cyber_MemberBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Cyber_MemberBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Cyber_MemberBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Cyber_MemberBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Cyber_MemberBindingNavigator.Name = "Cyber_MemberBindingNavigator"
        Me.Cyber_MemberBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Cyber_MemberBindingNavigator.Size = New System.Drawing.Size(1016, 25)
        Me.Cyber_MemberBindingNavigator.TabIndex = 0
        Me.Cyber_MemberBindingNavigator.Text = "BindingNavigator1"
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
        'Cyber_MemberBindingNavigatorSaveItem
        '
        Me.Cyber_MemberBindingNavigatorSaveItem.Image = CType(resources.GetObject("Cyber_MemberBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Cyber_MemberBindingNavigatorSaveItem.Name = "Cyber_MemberBindingNavigatorSaveItem"
        Me.Cyber_MemberBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.Cyber_MemberBindingNavigatorSaveItem.Text = "&Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.CyberPack_Pro.My.Resources.VsImg.PrintPreviewHS
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton1.Text = "&Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel1.Text = "MemberID"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel2.Text = "Filter IP:"
        Me.ToolStripLabel2.ToolTipText = "(Advance Query)"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(120, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.CyberPack_Pro.My.Resources.VsImg.DeleteHS
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(93, 20)
        Me.ToolStripButton3.Text = "&Remove Filter"
        '
        'Cyber_MemberDataGrid
        '
        Me.Cyber_MemberDataGrid.AllowSorting = False
        Me.Cyber_MemberDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.Cyber_MemberDataGrid.CaptionText = "IP ADDRESS SETTINGS"
        Me.Cyber_MemberDataGrid.DataMember = ""
        Me.Cyber_MemberDataGrid.DataSource = Me.Cyber_MemberBindingSource
        Me.Cyber_MemberDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cyber_MemberDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Cyber_MemberDataGrid.LinkColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Cyber_MemberDataGrid.Location = New System.Drawing.Point(0, 25)
        Me.Cyber_MemberDataGrid.Name = "Cyber_MemberDataGrid"
        Me.Cyber_MemberDataGrid.PreferredColumnWidth = 200
        Me.Cyber_MemberDataGrid.Size = New System.Drawing.Size(1016, 716)
        Me.Cyber_MemberDataGrid.TabIndex = 1
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripButton4.Text = "SEARCH/QUERY"
        '
        'Ip_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.Cyber_MemberDataGrid)
        Me.Controls.Add(Me.Cyber_MemberBindingNavigator)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Ip_Settings"
        Me.Text = "Ip_Settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cyber_MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cyber_MemberBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cyber_MemberBindingNavigator.ResumeLayout(False)
        Me.Cyber_MemberBindingNavigator.PerformLayout()
        CType(Me.Cyber_MemberDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents Cyber_MemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cyber_MemberTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.Cyber_MemberTableAdapter
    Friend WithEvents Cyber_MemberBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Cyber_MemberBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cyber_MemberDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
End Class
