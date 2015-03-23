<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSOLD_SET
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSOLD_SET))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox15 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.CheckBox12 = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.CheckBox13 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.CheckBox14 = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.PS_EmployeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.PS_EmployeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
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
        Me.Employe_NameTextBox = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.PS_EmployeTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_EmployeTableAdapter
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Label4 = New System.Windows.Forms.Label
        Employe_NameLabel = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PS_EmployeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PS_EmployeBindingNavigator.SuspendLayout()
        CType(Me.PS_EmployeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(69, 53)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(34, 15)
        Label4.TabIndex = 7
        Label4.Text = "Find:"
        '
        'Employe_NameLabel
        '
        Employe_NameLabel.AutoSize = True
        Employe_NameLabel.Location = New System.Drawing.Point(14, 80)
        Employe_NameLabel.Name = "Employe_NameLabel"
        Employe_NameLabel.Size = New System.Drawing.Size(90, 15)
        Employe_NameLabel.TabIndex = 0
        Employe_NameLabel.Text = "Employe Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CheckBox6)
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox15)
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox9)
        Me.GroupBox2.Controls.Add(Me.CheckBox8)
        Me.GroupBox2.Controls.Add(Me.CheckBox7)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox11)
        Me.GroupBox2.Controls.Add(Me.CheckBox12)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 179)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SETTINGS"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = Global.CyberPack_Pro.My.MySettings.Default.CLIENT_NAME_SHOW_PS
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "CLIENT_NAME_SHOW_PS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox4.Location = New System.Drawing.Point(9, 22)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(135, 19)
        Me.CheckBox4.TabIndex = 0
        Me.CheckBox4.Text = "CLIENT NAME SHOW"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox15.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox15.Checked = Global.CyberPack_Pro.My.MySettings.Default.DEL_SOLD_PS
        Me.CheckBox15.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox15.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DEL_SOLD_PS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox15.ForeColor = System.Drawing.Color.SteelBlue
        Me.CheckBox15.Location = New System.Drawing.Point(9, 136)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(289, 34)
        Me.CheckBox15.TabIndex = 6
        Me.CheckBox15.Text = "DELETE SOLD PRODUCTS/GOODS FROM STOCK &" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MAKE DATABSE FAST TO WORK."
        Me.CheckBox15.UseMnemonic = False
        Me.CheckBox15.UseVisualStyleBackColor = False
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox5.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox5.Checked = Global.CyberPack_Pro.My.MySettings.Default.SAVE_CLIENT_MSOLD
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "SAVE_CLIENT_MSOLD", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox5.ForeColor = System.Drawing.Color.Red
        Me.CheckBox5.Location = New System.Drawing.Point(188, 60)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(189, 34)
        Me.CheckBox5.TabIndex = 9
        Me.CheckBox5.Text = "SAVE CLIENT INFORMATION IN " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLIENT DATABASE"
        Me.CheckBox5.UseVisualStyleBackColor = False
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Checked = Global.CyberPack_Pro.My.MySettings.Default.BENEFIT_RO_PS
        Me.CheckBox9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox9.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "BENEFIT_RO_PS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox9.Location = New System.Drawing.Point(9, 98)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(161, 19)
        Me.CheckBox9.TabIndex = 4
        Me.CheckBox9.Text = "BENEFIT PRICE READONLY"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Checked = Global.CyberPack_Pro.My.MySettings.Default.PURCHASE_RO_PS
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "PURCHASE_RO_PS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox8.Location = New System.Drawing.Point(9, 79)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(171, 19)
        Me.CheckBox8.TabIndex = 3
        Me.CheckBox8.Text = "PURCHASE COST READONLY"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Checked = Global.CyberPack_Pro.My.MySettings.Default.BEFORE_SOLD_MSG_PS
        Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "BEFORE_SOLD_MSG_PS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox7.Location = New System.Drawing.Point(188, 22)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(164, 19)
        Me.CheckBox7.TabIndex = 7
        Me.CheckBox7.Text = "BEFORE SOLD SHOW MSG"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = Global.CyberPack_Pro.My.MySettings.Default.CHECK_BENEFIT_PS
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "CHECK_BENEFIT_PS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox3.Location = New System.Drawing.Point(9, 117)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(354, 19)
        Me.CheckBox3.TabIndex = 5
        Me.CheckBox3.Text = "ALWAYS CHECK BENEFIT,SHOW MSG IF LESS THAN OR EQUAL 1"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Checked = Global.CyberPack_Pro.My.MySettings.Default.PURCHASE_SHOW_PS
        Me.CheckBox11.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "PURCHASE_SHOW_PS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox11.Location = New System.Drawing.Point(9, 60)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(151, 19)
        Me.CheckBox11.TabIndex = 2
        Me.CheckBox11.Text = "PURCHASE COST SHOW"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Checked = Global.CyberPack_Pro.My.MySettings.Default.BENEFIT_SHOW_PS
        Me.CheckBox12.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "BENEFIT_SHOW_PS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox12.Location = New System.Drawing.Point(9, 41)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(107, 19)
        Me.CheckBox12.TabIndex = 1
        Me.CheckBox12.Text = "BENEFIT SHOW"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox13)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox14)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 115)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRINT"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "COM_ADDRESS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox4.Location = New System.Drawing.Point(6, 47)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(387, 23)
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.Text = Global.CyberPack_Pro.My.MySettings.Default.COM_ADDRESS
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Checked = Global.CyberPack_Pro.My.MySettings.Default.SHOW_COMPANYN_PS_R
        Me.CheckBox13.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox13.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "SHOW_COMPANYN_PS_R", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox13.Location = New System.Drawing.Point(6, 76)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(153, 19)
        Me.CheckBox13.TabIndex = 2
        Me.CheckBox13.Text = "SHOW COMPANY NAME"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Checked = Global.CyberPack_Pro.My.MySettings.Default.REPORT_AS_MEMO_MSOLD
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "REPORT_AS_MEMO_MSOLD", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Black
        Me.CheckBox2.Location = New System.Drawing.Point(223, 76)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(159, 19)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "PRINT REPORT AS MEMO"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "MEMO REPORT TITLE:"
        '
        'TextBox3
        '
        Me.TextBox3.AutoCompleteCustomSource.AddRange(New String() {"INVOICE", "INVOICE/BILL", "BILL", "BILL/INVOICE", "inVoice", "inVoice/bIll", "biLL", "biLL/inVoice", "Report", "MEMO", "LIST", "inVOICE", "BiLL", "memo", "Memo", "Order", "Deliver"})
        Me.TextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "TITLE_INVOICE_PS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Location = New System.Drawing.Point(173, 23)
        Me.TextBox3.MaxLength = 12
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(218, 16)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = Global.CyberPack_Pro.My.MySettings.Default.TITLE_INVOICE_PS
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Checked = Global.CyberPack_Pro.My.MySettings.Default.AFTER_SOLD_PRINT_PS
        Me.CheckBox14.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox14.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "AFTER_SOLD_PRINT_PS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox14.Location = New System.Drawing.Point(6, 93)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(172, 19)
        Me.CheckBox14.TabIndex = 3
        Me.CheckBox14.Text = "PRINT INVOICE AFTER SOLD"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.PS_EmployeBindingNavigator)
        Me.GroupBox3.Controls.Add(Employe_NameLabel)
        Me.GroupBox3.Controls.Add(Me.Employe_NameTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 309)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 106)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ADD EMPLOYEE"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(110, 50)
        Me.TextBox5.MaxLength = 25
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(272, 23)
        Me.TextBox5.TabIndex = 0
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.PS_EmployeBindingNavigator.Location = New System.Drawing.Point(3, 19)
        Me.PS_EmployeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PS_EmployeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PS_EmployeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PS_EmployeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PS_EmployeBindingNavigator.Name = "PS_EmployeBindingNavigator"
        Me.PS_EmployeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PS_EmployeBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.PS_EmployeBindingNavigator.Size = New System.Drawing.Size(394, 25)
        Me.PS_EmployeBindingNavigator.TabIndex = 5
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
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
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
        'PS_EmployeBindingNavigatorSaveItem
        '
        Me.PS_EmployeBindingNavigatorSaveItem.Image = CType(resources.GetObject("PS_EmployeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PS_EmployeBindingNavigatorSaveItem.Name = "PS_EmployeBindingNavigatorSaveItem"
        Me.PS_EmployeBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.PS_EmployeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Employe_NameTextBox
        '
        Me.Employe_NameTextBox.BackColor = System.Drawing.Color.White
        Me.Employe_NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Employe_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PS_EmployeBindingSource, "Employe_Name", True))
        Me.Employe_NameTextBox.Location = New System.Drawing.Point(110, 77)
        Me.Employe_NameTextBox.MaxLength = 25
        Me.Employe_NameTextBox.Name = "Employe_NameTextBox"
        Me.Employe_NameTextBox.Size = New System.Drawing.Size(272, 23)
        Me.Employe_NameTextBox.TabIndex = 1
        Me.Employe_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox1.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_USEPASSWORD
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_USEPASSWORD", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(12, 421)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(170, 19)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "USE PASSWORD TO ACCESS"
        Me.CheckBox1.UseMnemonic = False
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'PS_EmployeTableAdapter
        '
        Me.PS_EmployeTableAdapter.ClearBeforeFill = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 600
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.UseAnimation = False
        Me.ToolTip1.UseFading = False
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = Global.CyberPack_Pro.My.MySettings.Default.SHOW_MOVIE_VER_MSOLD
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "SHOW_MOVIE_VER_MSOLD", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox6.Location = New System.Drawing.Point(188, 39)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(201, 19)
        Me.CheckBox6.TabIndex = 10
        Me.CheckBox6.Text = "SHOW MOVIE VERSION IN PRINT"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'MSOLD_SET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.B2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 445)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MSOLD_SET"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSOLD SETTTINGS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PS_EmployeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PS_EmployeBindingNavigator.ResumeLayout(False)
        Me.PS_EmployeBindingNavigator.PerformLayout()
        CType(Me.PS_EmployeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents PS_EmployeBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PS_EmployeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Employe_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PS_EmployeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents PS_EmployeTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.PS_EmployeTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
End Class
