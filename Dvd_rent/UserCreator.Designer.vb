<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserCreator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim LastLoginLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserCreator))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.UsernameTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.UsersTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.UsersTableAdapter
        Me.UsersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.UsersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripButton
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.LastLoginLabel1 = New System.Windows.Forms.Label
        Me.UserIDTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        DescriptionLabel = New System.Windows.Forms.Label
        LastLoginLabel = New System.Windows.Forms.Label
        UserIDLabel = New System.Windows.Forms.Label
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(193, 124)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(70, 15)
        DescriptionLabel.TabIndex = 8
        DescriptionLabel.Text = "Description"
        '
        'LastLoginLabel
        '
        LastLoginLabel.AutoSize = True
        LastLoginLabel.Location = New System.Drawing.Point(195, 178)
        LastLoginLabel.Name = "LastLoginLabel"
        LastLoginLabel.Size = New System.Drawing.Size(64, 15)
        LastLoginLabel.TabIndex = 10
        LastLoginLabel.Text = "Last Login:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.BackColor = System.Drawing.Color.Transparent
        UserIDLabel.Location = New System.Drawing.Point(216, 40)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(47, 15)
        UserIDLabel.TabIndex = 11
        UserIDLabel.Text = "User ID"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImage = CType(resources.GetObject("LogoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.UsersBindingSource, "Image", True))
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(186, 220)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(198, 68)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(65, 15)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLabel.Location = New System.Drawing.Point(202, 96)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(61, 15)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "UserName", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(269, 64)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(235, 23)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(269, 91)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(235, 23)
        Me.PasswordTextBox.TabIndex = 2
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'UsersBindingNavigator
        '
        Me.UsersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsersBindingNavigator.BackColor = System.Drawing.Color.Black
        Me.UsersBindingNavigator.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.BlackEverSl2
        Me.UsersBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UsersBindingNavigator.BindingSource = Me.UsersBindingSource
        Me.UsersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsersBindingNavigatorSaveItem, Me.ToolStripLabel1})
        Me.UsersBindingNavigator.Location = New System.Drawing.Point(186, 0)
        Me.UsersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsersBindingNavigator.Name = "UsersBindingNavigator"
        Me.UsersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsersBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.UsersBindingNavigator.Size = New System.Drawing.Size(330, 25)
        Me.UsersBindingNavigator.TabIndex = 6
        Me.UsersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.Black
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.Black
        Me.BindingNavigatorDeleteItem.Image = Global.CyberPack_Pro.My.Resources.VsImg.DeleteHS
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
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
        'UsersBindingNavigatorSaveItem
        '
        Me.UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsersBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.Black
        Me.UsersBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsersBindingNavigatorSaveItem.Name = "UsersBindingNavigatorSaveItem"
        Me.UsersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Image = Global.CyberPack_Pro.My.Resources.VsImg.Filter2HS
        Me.ToolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripLabel1.Text = "Search"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(269, 118)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(235, 23)
        Me.DescriptionTextBox.TabIndex = 3
        '
        'LastLoginLabel1
        '
        Me.LastLoginLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "LastLogin", True))
        Me.LastLoginLabel1.Location = New System.Drawing.Point(266, 178)
        Me.LastLoginLabel1.Name = "LastLoginLabel1"
        Me.LastLoginLabel1.Size = New System.Drawing.Size(218, 23)
        Me.LastLoginLabel1.TabIndex = 11
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(269, 37)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(235, 23)
        Me.UserIDTextBox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(268, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 22)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Current User Login Information"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UserCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.Backgroud
        Me.ClientSize = New System.Drawing.Size(516, 220)
        Me.Controls.Add(Me.UsersBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(LastLoginLabel)
        Me.Controls.Add(Me.LastLoginLabel1)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserCreator"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserCreator"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersBindingNavigator.ResumeLayout(False)
        Me.UsersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents UsersBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents UsersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastLoginLabel1 As System.Windows.Forms.Label
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripButton

End Class
