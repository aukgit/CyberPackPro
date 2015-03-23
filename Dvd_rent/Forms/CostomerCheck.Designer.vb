<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostomerCheck
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
        Dim Costomer_IDLabel As System.Windows.Forms.Label
        Dim Costomer_CategoryLabel As System.Windows.Forms.Label
        Dim Costomer_NameLabel As System.Windows.Forms.Label
        Dim Costomer_AddressLabel As System.Windows.Forms.Label
        Dim ContactNumber_MobileLabel As System.Windows.Forms.Label
        Dim ContactNumber_PhoneLabel As System.Windows.Forms.Label
        Dim Costomer_ImageLabel As System.Windows.Forms.Label
        Dim Advance_FeesLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CostomerCheck))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CostomerInfCostomerAlternativeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Costomer_InfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.Costomer_IDLabel1 = New System.Windows.Forms.Label
        Me.Costomer_CategoryLabel1 = New System.Windows.Forms.Label
        Me.Costomer_NameLabel1 = New System.Windows.Forms.Label
        Me.Costomer_AddressLabel1 = New System.Windows.Forms.Label
        Me.ContactNumber_MobileLabel1 = New System.Windows.Forms.Label
        Me.ContactNumber_PhoneLabel1 = New System.Windows.Forms.Label
        Me.Costomer_ImagePictureBox = New System.Windows.Forms.PictureBox
        Me.Advance_FeesLabel1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Costomer_InfTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.Costomer_InfTableAdapter
        Me.Costomer_AlternativeTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.Costomer_AlternativeTableAdapter
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.AlternativeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AltAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AltContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Costomer_IDLabel = New System.Windows.Forms.Label
        Costomer_CategoryLabel = New System.Windows.Forms.Label
        Costomer_NameLabel = New System.Windows.Forms.Label
        Costomer_AddressLabel = New System.Windows.Forms.Label
        ContactNumber_MobileLabel = New System.Windows.Forms.Label
        ContactNumber_PhoneLabel = New System.Windows.Forms.Label
        Costomer_ImageLabel = New System.Windows.Forms.Label
        Advance_FeesLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.CostomerInfCostomerAlternativeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Costomer_InfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Costomer_ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Costomer_IDLabel
        '
        Costomer_IDLabel.AutoSize = True
        Costomer_IDLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_IDLabel.Location = New System.Drawing.Point(65, 48)
        Costomer_IDLabel.Name = "Costomer_IDLabel"
        Costomer_IDLabel.Size = New System.Drawing.Size(71, 13)
        Costomer_IDLabel.TabIndex = 4
        Costomer_IDLabel.Text = "Customer ID:"
        '
        'Costomer_CategoryLabel
        '
        Costomer_CategoryLabel.AutoSize = True
        Costomer_CategoryLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_CategoryLabel.Location = New System.Drawing.Point(31, 71)
        Costomer_CategoryLabel.Name = "Costomer_CategoryLabel"
        Costomer_CategoryLabel.Size = New System.Drawing.Size(105, 13)
        Costomer_CategoryLabel.TabIndex = 6
        Costomer_CategoryLabel.Text = "Customer Category:"
        '
        'Costomer_NameLabel
        '
        Costomer_NameLabel.AutoSize = True
        Costomer_NameLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_NameLabel.Location = New System.Drawing.Point(49, 94)
        Costomer_NameLabel.Name = "Costomer_NameLabel"
        Costomer_NameLabel.Size = New System.Drawing.Size(87, 13)
        Costomer_NameLabel.TabIndex = 8
        Costomer_NameLabel.Text = "Customer Name:"
        '
        'Costomer_AddressLabel
        '
        Costomer_AddressLabel.AutoSize = True
        Costomer_AddressLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_AddressLabel.Location = New System.Drawing.Point(37, 117)
        Costomer_AddressLabel.Name = "Costomer_AddressLabel"
        Costomer_AddressLabel.Size = New System.Drawing.Size(99, 13)
        Costomer_AddressLabel.TabIndex = 10
        Costomer_AddressLabel.Text = "Customer Address:"
        '
        'ContactNumber_MobileLabel
        '
        ContactNumber_MobileLabel.AutoSize = True
        ContactNumber_MobileLabel.BackColor = System.Drawing.Color.Transparent
        ContactNumber_MobileLabel.Location = New System.Drawing.Point(14, 140)
        ContactNumber_MobileLabel.Name = "ContactNumber_MobileLabel"
        ContactNumber_MobileLabel.Size = New System.Drawing.Size(122, 13)
        ContactNumber_MobileLabel.TabIndex = 12
        ContactNumber_MobileLabel.Text = "Contact Number Mobile:"
        '
        'ContactNumber_PhoneLabel
        '
        ContactNumber_PhoneLabel.AutoSize = True
        ContactNumber_PhoneLabel.BackColor = System.Drawing.Color.Transparent
        ContactNumber_PhoneLabel.Location = New System.Drawing.Point(14, 163)
        ContactNumber_PhoneLabel.Name = "ContactNumber_PhoneLabel"
        ContactNumber_PhoneLabel.Size = New System.Drawing.Size(122, 13)
        ContactNumber_PhoneLabel.TabIndex = 14
        ContactNumber_PhoneLabel.Text = "Contact Number Phone:"
        '
        'Costomer_ImageLabel
        '
        Costomer_ImageLabel.AutoSize = True
        Costomer_ImageLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_ImageLabel.Location = New System.Drawing.Point(348, 48)
        Costomer_ImageLabel.Name = "Costomer_ImageLabel"
        Costomer_ImageLabel.Size = New System.Drawing.Size(90, 13)
        Costomer_ImageLabel.TabIndex = 16
        Costomer_ImageLabel.Text = "Customer Image:"
        '
        'Advance_FeesLabel
        '
        Advance_FeesLabel.AutoSize = True
        Advance_FeesLabel.BackColor = System.Drawing.Color.Transparent
        Advance_FeesLabel.Location = New System.Drawing.Point(57, 186)
        Advance_FeesLabel.Name = "Advance_FeesLabel"
        Advance_FeesLabel.Size = New System.Drawing.Size(79, 13)
        Advance_FeesLabel.TabIndex = 20
        Advance_FeesLabel.Text = "Advance Fees:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Location = New System.Drawing.Point(10, 23)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(57, 13)
        Label2.TabIndex = 23
        Label2.Text = "Customer:"
        '
        'CostomerInfCostomerAlternativeBindingSource
        '
        Me.CostomerInfCostomerAlternativeBindingSource.DataMember = "Costomer_InfCostomer_Alternative"
        Me.CostomerInfCostomerAlternativeBindingSource.DataSource = Me.Costomer_InfBindingSource
        '
        'Costomer_InfBindingSource
        '
        Me.Costomer_InfBindingSource.DataMember = "Costomer_Inf"
        Me.Costomer_InfBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Costomer_IDLabel1
        '
        Me.Costomer_IDLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Costomer_IDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Costomer_IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Costomer_ID", True))
        Me.Costomer_IDLabel1.Location = New System.Drawing.Point(142, 48)
        Me.Costomer_IDLabel1.Name = "Costomer_IDLabel1"
        Me.Costomer_IDLabel1.Size = New System.Drawing.Size(200, 23)
        Me.Costomer_IDLabel1.TabIndex = 5
        Me.Costomer_IDLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Costomer_CategoryLabel1
        '
        Me.Costomer_CategoryLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Costomer_CategoryLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Costomer_CategoryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Costomer_Category", True))
        Me.Costomer_CategoryLabel1.Location = New System.Drawing.Point(142, 71)
        Me.Costomer_CategoryLabel1.Name = "Costomer_CategoryLabel1"
        Me.Costomer_CategoryLabel1.Size = New System.Drawing.Size(200, 23)
        Me.Costomer_CategoryLabel1.TabIndex = 7
        Me.Costomer_CategoryLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Costomer_NameLabel1
        '
        Me.Costomer_NameLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Costomer_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Costomer_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Costomer_Name", True))
        Me.Costomer_NameLabel1.Location = New System.Drawing.Point(142, 94)
        Me.Costomer_NameLabel1.Name = "Costomer_NameLabel1"
        Me.Costomer_NameLabel1.Size = New System.Drawing.Size(200, 23)
        Me.Costomer_NameLabel1.TabIndex = 9
        Me.Costomer_NameLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Costomer_AddressLabel1
        '
        Me.Costomer_AddressLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Costomer_AddressLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Costomer_AddressLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Costomer_Address", True))
        Me.Costomer_AddressLabel1.Location = New System.Drawing.Point(142, 117)
        Me.Costomer_AddressLabel1.Name = "Costomer_AddressLabel1"
        Me.Costomer_AddressLabel1.Size = New System.Drawing.Size(200, 23)
        Me.Costomer_AddressLabel1.TabIndex = 11
        Me.Costomer_AddressLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ContactNumber_MobileLabel1
        '
        Me.ContactNumber_MobileLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ContactNumber_MobileLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactNumber_MobileLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "ContactNumber_Mobile", True))
        Me.ContactNumber_MobileLabel1.Location = New System.Drawing.Point(142, 140)
        Me.ContactNumber_MobileLabel1.Name = "ContactNumber_MobileLabel1"
        Me.ContactNumber_MobileLabel1.Size = New System.Drawing.Size(200, 23)
        Me.ContactNumber_MobileLabel1.TabIndex = 13
        Me.ContactNumber_MobileLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ContactNumber_PhoneLabel1
        '
        Me.ContactNumber_PhoneLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ContactNumber_PhoneLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactNumber_PhoneLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "ContactNumber_Phone", True))
        Me.ContactNumber_PhoneLabel1.Location = New System.Drawing.Point(142, 163)
        Me.ContactNumber_PhoneLabel1.Name = "ContactNumber_PhoneLabel1"
        Me.ContactNumber_PhoneLabel1.Size = New System.Drawing.Size(200, 23)
        Me.ContactNumber_PhoneLabel1.TabIndex = 15
        Me.ContactNumber_PhoneLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Costomer_ImagePictureBox
        '
        Me.Costomer_ImagePictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Costomer_ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Costomer_ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Costomer_InfBindingSource, "Costomer_Image", True))
        Me.Costomer_ImagePictureBox.Location = New System.Drawing.Point(438, 48)
        Me.Costomer_ImagePictureBox.Name = "Costomer_ImagePictureBox"
        Me.Costomer_ImagePictureBox.Size = New System.Drawing.Size(148, 161)
        Me.Costomer_ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Costomer_ImagePictureBox.TabIndex = 17
        Me.Costomer_ImagePictureBox.TabStop = False
        '
        'Advance_FeesLabel1
        '
        Me.Advance_FeesLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Advance_FeesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Advance_FeesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Advance_Fees", True))
        Me.Advance_FeesLabel1.Location = New System.Drawing.Point(142, 186)
        Me.Advance_FeesLabel1.Name = "Advance_FeesLabel1"
        Me.Advance_FeesLabel1.Size = New System.Drawing.Size(200, 23)
        Me.Advance_FeesLabel1.TabIndex = 21
        Me.Advance_FeesLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(251, 21)
        Me.TextBox1.TabIndex = 24
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 96)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information(Query System)"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Customer ID", "Customer Name", "Contact Mobile", "Contact Phone"})
        Me.ComboBox2.Location = New System.Drawing.Point(73, 45)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(251, 21)
        Me.ComboBox2.TabIndex = 32
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(242, 66)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 24)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "&FromFirst"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(158, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 24)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "&AnyWhere"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(73, 66)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(82, 24)
        Me.Button9.TabIndex = 25
        Me.Button9.Text = "&Open"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Costomer_ID", "Costomer_Name", "ContactNumber_Mobile", "ContactNumber_Phone"})
        Me.ComboBox1.Location = New System.Drawing.Point(342, 295)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(251, 21)
        Me.ComboBox1.TabIndex = 26
        Me.ComboBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(438, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 46)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Send &Customer AlternaiveInformation"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(438, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 24)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "&Send CustomerID"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.Costomer_InfBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(604, 25)
        Me.BindingNavigator1.TabIndex = 28
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'Costomer_InfTableAdapter
        '
        Me.Costomer_InfTableAdapter.ClearBeforeFill = True
        '
        'Costomer_AlternativeTableAdapter
        '
        Me.Costomer_AlternativeTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AlternativeNameDataGridViewTextBoxColumn, Me.AltAddressDataGridViewTextBoxColumn, Me.AltContactNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CostomerInfCostomerAlternativeBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 344)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.Size = New System.Drawing.Size(604, 231)
        Me.DataGridView1.TabIndex = 29
        '
        'AlternativeNameDataGridViewTextBoxColumn
        '
        Me.AlternativeNameDataGridViewTextBoxColumn.DataPropertyName = "Alternative_Name"
        Me.AlternativeNameDataGridViewTextBoxColumn.HeaderText = "ALTERNATIVE NAME"
        Me.AlternativeNameDataGridViewTextBoxColumn.MinimumWidth = 200
        Me.AlternativeNameDataGridViewTextBoxColumn.Name = "AlternativeNameDataGridViewTextBoxColumn"
        Me.AlternativeNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlternativeNameDataGridViewTextBoxColumn.Width = 200
        '
        'AltAddressDataGridViewTextBoxColumn
        '
        Me.AltAddressDataGridViewTextBoxColumn.DataPropertyName = "Alt_Address"
        Me.AltAddressDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.AltAddressDataGridViewTextBoxColumn.MinimumWidth = 180
        Me.AltAddressDataGridViewTextBoxColumn.Name = "AltAddressDataGridViewTextBoxColumn"
        Me.AltAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AltAddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AltAddressDataGridViewTextBoxColumn.Width = 180
        '
        'AltContactNumberDataGridViewTextBoxColumn
        '
        Me.AltContactNumberDataGridViewTextBoxColumn.DataPropertyName = "Alt_ContactNumber"
        Me.AltContactNumberDataGridViewTextBoxColumn.HeaderText = "CONTACT NUMBER."
        Me.AltContactNumberDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.AltContactNumberDataGridViewTextBoxColumn.Name = "AltContactNumberDataGridViewTextBoxColumn"
        Me.AltContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.AltContactNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AltContactNumberDataGridViewTextBoxColumn.Width = 150
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(604, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "DVDRENT CUSTOMERS ALTERNATIVE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(488, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 15)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "ALTERNATIVE QUERY"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CostomerCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(604, 575)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Costomer_IDLabel)
        Me.Controls.Add(Me.Costomer_IDLabel1)
        Me.Controls.Add(Costomer_CategoryLabel)
        Me.Controls.Add(Me.Costomer_CategoryLabel1)
        Me.Controls.Add(Costomer_NameLabel)
        Me.Controls.Add(Me.Costomer_NameLabel1)
        Me.Controls.Add(Costomer_AddressLabel)
        Me.Controls.Add(Me.Costomer_AddressLabel1)
        Me.Controls.Add(ContactNumber_MobileLabel)
        Me.Controls.Add(Me.ContactNumber_MobileLabel1)
        Me.Controls.Add(ContactNumber_PhoneLabel)
        Me.Controls.Add(Me.ContactNumber_PhoneLabel1)
        Me.Controls.Add(Costomer_ImageLabel)
        Me.Controls.Add(Me.Costomer_ImagePictureBox)
        Me.Controls.Add(Advance_FeesLabel)
        Me.Controls.Add(Me.Advance_FeesLabel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CostomerCheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerCheck"
        CType(Me.CostomerInfCostomerAlternativeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Costomer_InfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Costomer_ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents Costomer_InfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Costomer_InfTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.Costomer_InfTableAdapter
    Friend WithEvents Costomer_IDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Costomer_CategoryLabel1 As System.Windows.Forms.Label
    Friend WithEvents Costomer_NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Costomer_AddressLabel1 As System.Windows.Forms.Label
    Friend WithEvents ContactNumber_MobileLabel1 As System.Windows.Forms.Label
    Friend WithEvents ContactNumber_PhoneLabel1 As System.Windows.Forms.Label
    Friend WithEvents Costomer_ImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Advance_FeesLabel1 As System.Windows.Forms.Label
    Friend WithEvents CostomerInfCostomerAlternativeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Costomer_AlternativeTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.Costomer_AlternativeTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AlternativeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AltAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AltContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
