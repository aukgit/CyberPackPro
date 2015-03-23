<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ps_employees
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Employe_NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ps_employees))
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.PS_EmployeTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_EmployeTableAdapter
        Me.PS_EmployeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.PS_EmployeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.PS_EmployeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Employe_NameTextBox = New System.Windows.Forms.TextBox
        Label4 = New System.Windows.Forms.Label
        Employe_NameLabel = New System.Windows.Forms.Label
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PS_EmployeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PS_EmployeBindingNavigator.SuspendLayout()
        CType(Me.PS_EmployeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Location = New System.Drawing.Point(67, 42)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(34, 15)
        Label4.TabIndex = 11
        Label4.Text = "Find:"
        '
        'Employe_NameLabel
        '
        Employe_NameLabel.AutoSize = True
        Employe_NameLabel.BackColor = System.Drawing.Color.Transparent
        Employe_NameLabel.Location = New System.Drawing.Point(12, 69)
        Employe_NameLabel.Name = "Employe_NameLabel"
        Employe_NameLabel.Size = New System.Drawing.Size(90, 15)
        Employe_NameLabel.TabIndex = 8
        Employe_NameLabel.Text = "Employe Name:"
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PS_EmployeTableAdapter
        '
        Me.PS_EmployeTableAdapter.ClearBeforeFill = True
        '
        'PS_EmployeBindingNavigator
        '
        Me.PS_EmployeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PS_EmployeBindingNavigator.BackColor = System.Drawing.Color.Silver
        Me.PS_EmployeBindingNavigator.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources._2
        Me.PS_EmployeBindingNavigator.BindingSource = Me.PS_EmployeBindingSource
        Me.PS_EmployeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PS_EmployeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PS_EmployeBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PS_EmployeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PS_EmployeBindingNavigatorSaveItem})
        Me.PS_EmployeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PS_EmployeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PS_EmployeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PS_EmployeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PS_EmployeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PS_EmployeBindingNavigator.Name = "PS_EmployeBindingNavigator"
        Me.PS_EmployeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PS_EmployeBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.PS_EmployeBindingNavigator.Size = New System.Drawing.Size(551, 25)
        Me.PS_EmployeBindingNavigator.TabIndex = 6
        Me.PS_EmployeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(69, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'PS_EmployeBindingSource
        '
        Me.PS_EmployeBindingSource.DataMember = "PS_Employe"
        Me.PS_EmployeBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.BackColor = System.Drawing.Color.Transparent
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
        'PS_EmployeBindingNavigatorSaveItem
        '
        Me.PS_EmployeBindingNavigatorSaveItem.Image = CType(resources.GetObject("PS_EmployeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PS_EmployeBindingNavigatorSaveItem.Name = "PS_EmployeBindingNavigatorSaveItem"
        Me.PS_EmployeBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.PS_EmployeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(108, 39)
        Me.TextBox5.MaxLength = 25
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(431, 23)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Employe_NameTextBox
        '
        Me.Employe_NameTextBox.BackColor = System.Drawing.Color.White
        Me.Employe_NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Employe_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PS_EmployeBindingSource, "Employe_Name", True))
        Me.Employe_NameTextBox.Location = New System.Drawing.Point(108, 66)
        Me.Employe_NameTextBox.MaxLength = 25
        Me.Employe_NameTextBox.Name = "Employe_NameTextBox"
        Me.Employe_NameTextBox.Size = New System.Drawing.Size(431, 23)
        Me.Employe_NameTextBox.TabIndex = 10
        Me.Employe_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ps_employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(551, 105)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Employe_NameLabel)
        Me.Controls.Add(Me.Employe_NameTextBox)
        Me.Controls.Add(Me.PS_EmployeBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ps_employees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD NEW EMPLOYEE"
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PS_EmployeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PS_EmployeBindingNavigator.ResumeLayout(False)
        Me.PS_EmployeBindingNavigator.PerformLayout()
        CType(Me.PS_EmployeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents PS_EmployeTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_EmployeTableAdapter
    Friend WithEvents PS_EmployeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PS_EmployeBindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents PS_EmployeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Employe_NameTextBox As System.Windows.Forms.TextBox
End Class
