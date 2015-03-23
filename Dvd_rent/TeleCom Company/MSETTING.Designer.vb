<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSETTING
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox14 = New System.Windows.Forms.CheckBox
        Me.CheckBox15 = New System.Windows.Forms.CheckBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.CheckBox10 = New System.Windows.Forms.CheckBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.CheckBox13 = New System.Windows.Forms.CheckBox
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox16 = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckBox14)
        Me.GroupBox1.Controls.Add(Me.CheckBox15)
        Me.GroupBox1.Controls.Add(Me.CheckBox9)
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 144)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HIDE/SHOW FIELDS"
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox14.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox14.Checked = Global.CyberPack_Pro.My.MySettings.Default.mAKE_TRANS_bAL
        Me.CheckBox14.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox14.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "mAKE_TRANS_bAL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox14.Location = New System.Drawing.Point(187, 83)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(160, 34)
        Me.CheckBox14.TabIndex = 8
        Me.CheckBox14.Text = "MAKE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TRANSACTION = CUR.BAL."
        Me.CheckBox14.UseVisualStyleBackColor = False
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Checked = Global.CyberPack_Pro.My.MySettings.Default.BUSDATE_MOB
        Me.CheckBox15.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "BUSDATE_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox15.Location = New System.Drawing.Point(16, 109)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(106, 19)
        Me.CheckBox15.TabIndex = 4
        Me.CheckBox15.Text = "BUSINESS DATE"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox9.Checked = Global.CyberPack_Pro.My.MySettings.Default.S_MSG_TIME_MOB
        Me.CheckBox9.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "S_MSG_TIME_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox9.Location = New System.Drawing.Point(187, 62)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(137, 19)
        Me.CheckBox9.TabIndex = 7
        Me.CheckBox9.Text = "SEND MESSAGE TIME"
        Me.CheckBox9.UseVisualStyleBackColor = False
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox8.Checked = Global.CyberPack_Pro.My.MySettings.Default.BENEFIT_MOB
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "BENEFIT_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox8.Location = New System.Drawing.Point(187, 41)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(69, 19)
        Me.CheckBox8.TabIndex = 6
        Me.CheckBox8.Text = "BENEFIT"
        Me.CheckBox8.UseVisualStyleBackColor = False
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = Global.CyberPack_Pro.My.MySettings.Default.MOBCOM_NAME_MOB
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "MOBCOM_NAME_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox5.Location = New System.Drawing.Point(16, 87)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(96, 19)
        Me.CheckBox5.TabIndex = 3
        Me.CheckBox5.Text = "CATEGORY ID"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox7.Checked = Global.CyberPack_Pro.My.MySettings.Default.DISCOUNT_MOB
        Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DISCOUNT_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox7.Location = New System.Drawing.Point(187, 20)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(82, 19)
        Me.CheckBox7.TabIndex = 5
        Me.CheckBox7.Text = "DISCOUNT"
        Me.CheckBox7.UseVisualStyleBackColor = False
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = Global.CyberPack_Pro.My.MySettings.Default.TRANS_MOB
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "TRANS_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox4.Location = New System.Drawing.Point(16, 65)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(151, 19)
        Me.CheckBox4.TabIndex = 2
        Me.CheckBox4.Text = "TRANSACTION NUMBER"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = Global.CyberPack_Pro.My.MySettings.Default.EXTRA_COLUMN
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "EXTRA_COLUMN", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(16, 21)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(102, 19)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "EXTRA MONEY"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = Global.CyberPack_Pro.My.MySettings.Default.CLIENTS_ID
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "CLIENTS_ID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(16, 43)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 19)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "CLIENT'S ID/NAME"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "EXTRA MONEY AMOUNT"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.BlackEverSl2PNG
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button1.Location = New System.Drawing.Point(0, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(664, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "SAVE SETTINGS & CLOSE SETTINGS"
        Me.Button1.UseMnemonic = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(383, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 144)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EXTRA MONEY"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "EXTRA_LESS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(142, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 23)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = Global.CyberPack_Pro.My.MySettings.Default.EXTRA_LESS
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox3.Checked = Global.CyberPack_Pro.My.MySettings.Default.EXTRA_M_TR
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "EXTRA_M_TR", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox3.Location = New System.Drawing.Point(6, 47)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(184, 34)
        Me.CheckBox3.TabIndex = 26
        Me.CheckBox3.Text = "ALWAYS ADD EXTRA MONEY IF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AMOUNT LESS THAN"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(13, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "EFFECT ON."
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "EXTRA_EFF2_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.DropDownWidth = 200
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"NO EFFECT,0", "IF CARD COST <= 50 ,EXTRA=1,1", "IF CARD COST <=30 ,EXTRA=1,2", "IF CARD COST <=20 ,EXTRA=1,3", "IF CARD COST <= 50 ,EXTRA=2,4", "IF CARD COST <=30 ,EXTRA=2,5", "IF CARD COST <=20 ,EXTRA=2,6"})
        Me.ComboBox4.Location = New System.Drawing.Point(89, 99)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(169, 23)
        Me.ComboBox4.TabIndex = 2
        Me.ComboBox4.Text = Global.CyberPack_Pro.My.MySettings.Default.EXTRA_EFF2_MOB
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "EXTRA_MONEY_AM", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Location = New System.Drawing.Point(162, 18)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = Global.CyberPack_Pro.My.MySettings.Default.EXTRA_MONEY_AM
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(407, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "GRID ROW SELECT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(4, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "CURRENT RECORD INFO."
        '
        'Button2
        '
        Me.Button2.Image = Global.CyberPack_Pro.My.Resources.VsImg.FontDialogHS
        Me.Button2.Location = New System.Drawing.Point(41, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.HScrollBar1)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(365, 187)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(289, 142)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CELL NUMBER INFORMATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(44, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "SIZE"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"SMALL", "MEDIUM", "LARGE", "EXTRA LARGE"})
        Me.ComboBox3.Location = New System.Drawing.Point(79, 110)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(203, 23)
        Me.ComboBox3.TabIndex = 4
        '
        'HScrollBar1
        '
        Me.HScrollBar1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.CyberPack_Pro.My.MySettings.Default, "INFOR_HEIGHT_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.HScrollBar1.Location = New System.Drawing.Point(79, 84)
        Me.HScrollBar1.Maximum = 75
        Me.HScrollBar1.Minimum = 18
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(203, 17)
        Me.HScrollBar1.TabIndex = 3
        Me.HScrollBar1.Value = Global.CyberPack_Pro.My.MySettings.Default.INFOR_HEIGHT_MOB
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "FONT_INFO_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Location = New System.Drawing.Point(79, 54)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(203, 23)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = Global.CyberPack_Pro.My.MySettings.Default.FONT_INFO_MOB
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "CUR_INFO_SHOW", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.DropDownWidth = 200
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"NO", "SHOW(ID,CELL,CURRENT BALANCE)", "SHOW(ID,CELL)"})
        Me.ComboBox2.Location = New System.Drawing.Point(146, 25)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(136, 23)
        Me.ComboBox2.TabIndex = 0
        Me.ComboBox2.Text = Global.CyberPack_Pro.My.MySettings.Default.CUR_INFO_SHOW
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button3.Image = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button3.Location = New System.Drawing.Point(0, 347)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(664, 26)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "RESET"
        Me.Button3.UseMnemonic = False
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox10.Checked = Global.CyberPack_Pro.My.MySettings.Default.TOOK_WHOL_INFO_MOB
        Me.CheckBox10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox10.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "TOOK_WHOL_INFO_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox10.Location = New System.Drawing.Point(12, 187)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(214, 19)
        Me.CheckBox10.TabIndex = 0
        Me.CheckBox10.Text = "TOOK WHOLE SHOP INFORMATION"
        Me.CheckBox10.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "ROW_SEL_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"CELL", "ROW"})
        Me.ComboBox1.Location = New System.Drawing.Point(517, 162)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 23)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Text = Global.CyberPack_Pro.My.MySettings.Default.ROW_SEL_MOB
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox13.Checked = Global.CyberPack_Pro.My.MySettings.Default.NEXT_B_D_L_MOB
        Me.CheckBox13.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox13.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "NEXT_B_D_L_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox13.Location = New System.Drawing.Point(12, 237)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(254, 19)
        Me.CheckBox13.TabIndex = 1
        Me.CheckBox13.Text = "ANOTHER TOOLSTRIP BOX SHOW IN FORM"
        Me.CheckBox13.UseVisualStyleBackColor = False
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox11.Checked = Global.CyberPack_Pro.My.MySettings.Default.REF_DUE_BENEFIT_MOB
        Me.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox11.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "REF_DUE_BENEFIT_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox11.Location = New System.Drawing.Point(12, 262)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(304, 19)
        Me.CheckBox11.TabIndex = 2
        Me.CheckBox11.Text = "REFRESH ALSO SINGLE UPDATE OF DUE,BENEFIT,LOSS"
        Me.CheckBox11.UseVisualStyleBackColor = False
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox6.Checked = Global.CyberPack_Pro.My.MySettings.Default.ENTER_TOnEXT_MOB
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "ENTER_TOnEXT_MOB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox6.Location = New System.Drawing.Point(12, 287)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(147, 19)
        Me.CheckBox6.TabIndex = 4
        Me.CheckBox6.Text = "SAVE CLIENTS ADDRESS"
        Me.CheckBox6.UseVisualStyleBackColor = False
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox16.Checked = Global.CyberPack_Pro.My.MySettings.Default.ShowDue_Mob
        Me.CheckBox16.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox16.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "ShowDue_Mob", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox16.ForeColor = System.Drawing.Color.Red
        Me.CheckBox16.Location = New System.Drawing.Point(12, 212)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(187, 19)
        Me.CheckBox16.TabIndex = 16
        Me.CheckBox16.Text = "SHOW CLIENT DUE EVERYTIME"
        Me.CheckBox16.UseVisualStyleBackColor = False
        '
        'MSETTING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(664, 403)
        Me.Controls.Add(Me.CheckBox16)
        Me.Controls.Add(Me.CheckBox10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CheckBox13)
        Me.Controls.Add(Me.CheckBox11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MSETTING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOBILE RECHARGE SETTINGS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
End Class
