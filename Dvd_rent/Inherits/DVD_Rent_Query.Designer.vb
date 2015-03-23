<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DVD_Rent_Query
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.CheckBox14 = New System.Windows.Forms.CheckBox
        Me.CheckBox13 = New System.Windows.Forms.CheckBox
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CheckBox12 = New System.Windows.Forms.CheckBox
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.CheckBox10 = New System.Windows.Forms.CheckBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Query Manager"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(305, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "And"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(305, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "And"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Equals,=", "NotEquals,<>", "GreaterThan,>", "LowerThan,<", "GreaterThanEqual,>=", "LowerThanEqual,<="})
        Me.ComboBox2.Location = New System.Drawing.Point(283, 190)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox2.TabIndex = 19
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Equals,=", "NotEquals,<>", "GreaterThan,>", "LowerThan,<", "GreaterThanEqual,>=", "LowerThanEqual,<="})
        Me.ComboBox1.Location = New System.Drawing.Point(283, 214)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox14.Checked = Global.CYBERPACK_PRO.My.MySettings.Default.nChk2
        Me.CheckBox14.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox14.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CYBERPACK_PRO.My.MySettings.Default, "nChk2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox14.Location = New System.Drawing.Point(440, 120)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox14.TabIndex = 27
        Me.CheckBox14.Text = "&AnyWhere In Field"
        Me.CheckBox14.UseVisualStyleBackColor = False
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox13.Checked = Global.CYBERPACK_PRO.My.MySettings.Default.nChk1
        Me.CheckBox13.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox13.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CYBERPACK_PRO.My.MySettings.Default, "nChk1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox13.Location = New System.Drawing.Point(440, 96)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox13.TabIndex = 26
        Me.CheckBox13.Text = "A&nyWhere In Field"
        Me.CheckBox13.UseVisualStyleBackColor = False
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Checked = False
        Me.DateTimePicker3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.CYBERPACK_PRO.My.MySettings.Default, "Tbxq4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(344, 163)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(90, 21)
        Me.DateTimePicker3.TabIndex = 17
        Me.DateTimePicker3.Value = Global.CYBERPACK_PRO.My.MySettings.Default.Tbxq4
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Checked = False
        Me.DateTimePicker4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.CYBERPACK_PRO.My.MySettings.Default, "TbXq3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(205, 163)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(90, 21)
        Me.DateTimePicker4.TabIndex = 16
        Me.DateTimePicker4.Value = Global.CYBERPACK_PRO.My.MySettings.Default.TbXq3
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Checked = False
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.CYBERPACK_PRO.My.MySettings.Default, "TbXq2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(344, 140)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(90, 21)
        Me.DateTimePicker2.TabIndex = 15
        Me.DateTimePicker2.Value = Global.CYBERPACK_PRO.My.MySettings.Default.TbXq2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.CYBERPACK_PRO.My.MySettings.Default, "TbxQ1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(205, 140)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(90, 21)
        Me.DateTimePicker1.TabIndex = 14
        Me.DateTimePicker1.Value = Global.CYBERPACK_PRO.My.MySettings.Default.TbxQ1
        '
        'TextBox10
        '
        Me.TextBox10.AutoCompleteCustomSource.AddRange(New String() {"Lost", "Broken", "InStore", "InHand"})
        Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CYBERPACK_PRO.My.MySettings.Default, "TrxB10", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox10.Location = New System.Drawing.Point(205, 259)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(229, 21)
        Me.TextBox10.TabIndex = 23
        Me.TextBox10.Text = Global.CYBERPACK_PRO.My.MySettings.Default.TrxB10
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox9
        '
        Me.TextBox9.AutoCompleteCustomSource.AddRange(New String() {"Lost", "Broken", "InStore", "InHand"})
        Me.TextBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CYBERPACK_PRO.My.MySettings.Default, "TrxB9", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox9.Location = New System.Drawing.Point(205, 238)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(229, 21)
        Me.TextBox9.TabIndex = 22
        Me.TextBox9.Text = Global.CYBERPACK_PRO.My.MySettings.Default.TrxB9
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CYBERPACK_PRO.My.MySettings.Default, "TrxB8", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox8.Location = New System.Drawing.Point(205, 215)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(72, 21)
        Me.TextBox8.TabIndex = 20
        Me.TextBox8.Text = Global.CYBERPACK_PRO.My.MySettings.Default.TrxB8
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CYBERPACK_PRO.My.MySettings.Default, "TrxB7", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox7.Location = New System.Drawing.Point(205, 190)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(72, 21)
        Me.TextBox7.TabIndex = 18
        Me.TextBox7.Text = Global.CYBERPACK_PRO.My.MySettings.Default.TrxB7
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CYBERPACK_PRO.My.MySettings.Default, "TrxB4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox4.Location = New System.Drawing.Point(205, 118)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(229, 21)
        Me.TextBox4.TabIndex = 13
        Me.TextBox4.Text = Global.CYBERPACK_PRO.My.MySettings.Default.TrxB4
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CYBERPACK_PRO.My.MySettings.Default, "TrxB3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Location = New System.Drawing.Point(205, 94)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(229, 21)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = Global.CYBERPACK_PRO.My.MySettings.Default.TrxB3
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CYBERPACK_PRO.My.MySettings.Default, "TrxB2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Location = New System.Drawing.Point(205, 71)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(229, 21)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.Text = Global.CYBERPACK_PRO.My.MySettings.Default.TrxB2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CYBERPACK_PRO.My.MySettings.Default, "TrxB1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(205, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(229, 21)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = Global.CYBERPACK_PRO.My.MySettings.Default.TrxB1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox12
        '
        Me.CheckBox12.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox12.Checked = Global.CYBERPACK_PRO.My.MySettings.Default.D11
        Me.CheckBox12.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox12.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CYBERPACK_PRO.My.MySettings.Default, "D11", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox12.Location = New System.Drawing.Point(21, 238)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(178, 21)
        Me.CheckBox12.TabIndex = 8
        Me.CheckBox12.Text = "Place:"
        Me.CheckBox12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox12.UseVisualStyleBackColor = False
        '
        'CheckBox11
        '
        Me.CheckBox11.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox11.Checked = Global.CYBERPACK_PRO.My.MySettings.Default.D12
        Me.CheckBox11.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CYBERPACK_PRO.My.MySettings.Default, "D12", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox11.Location = New System.Drawing.Point(21, 261)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(178, 21)
        Me.CheckBox11.TabIndex = 9
        Me.CheckBox11.Text = "COSTOMERS COMMENTS:"
        Me.CheckBox11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox11.UseVisualStyleBackColor = False
        '
        'CheckBox10
        '
        Me.CheckBox10.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox10.Checked = Global.CYBERPACK_PRO.My.MySettings.Default.D10
        Me.CheckBox10.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CYBERPACK_PRO.My.MySettings.Default, "D10", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox10.Location = New System.Drawing.Point(21, 215)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(178, 21)
        Me.CheckBox10.TabIndex = 7
        Me.CheckBox10.Text = "FINE:"
        Me.CheckBox10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox10.UseVisualStyleBackColor = False
        '
        'CheckBox9
        '
        Me.CheckBox9.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox9.Checked = Global.CYBERPACK_PRO.My.MySettings.Default.D9
        Me.CheckBox9.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CYBERPACK_PRO.My.MySettings.Default, "D9", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox9.Location = New System.Drawing.Point(21, 191)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(178, 21)
        Me.CheckBox9.TabIndex = 6
        Me.CheckBox9.Text = "MOVIE RENT COST:"
        Me.CheckBox9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox9.UseVisualStyleBackColor = False
        '
        'CheckBox6
        '
        Me.CheckBox6.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox6.Checked = Global.CYBERPACK_PRO.My.MySettings.Default.D6
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CYBERPACK_PRO.My.MySettings.Default, "D6", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox6.Location = New System.Drawing.Point(21, 163)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(178, 21)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "RETURN DATE:"
        Me.CheckBox6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox6.UseVisualStyleBackColor = False
        '
        'CheckBox5
        '
        Me.CheckBox5.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox5.Checked = Global.CYBERPACK_PRO.My.MySettings.Default.D5
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CYBERPACK_PRO.My.MySettings.Default, "D5", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox5.Location = New System.Drawing.Point(21, 140)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(178, 21)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "RENTAL DATE:"
        Me.CheckBox5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox5.UseVisualStyleBackColor = False
        '
        'CheckBox4
        '
        Me.CheckBox4.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox4.Checked = Global.CYBERPACK_PRO.My.MySettings.Default.D4
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CYBERPACK_PRO.My.MySettings.Default, "D4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox4.Location = New System.Drawing.Point(21, 117)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(178, 21)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "MOVIE NAME:"
        Me.CheckBox4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Checked = Global.CYBERPACK_PRO.My.MySettings.Default.D1
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CYBERPACK_PRO.My.MySettings.Default, "D1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox3.Location = New System.Drawing.Point(21, 48)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(178, 21)
        Me.CheckBox3.TabIndex = 0
        Me.CheckBox3.Text = "DVD ID:"
        Me.CheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Checked = Global.CYBERPACK_PRO.My.MySettings.Default.D3
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CYBERPACK_PRO.My.MySettings.Default, "D3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(21, 94)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(178, 21)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "COSTOMER'S NAME:"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = Global.CYBERPACK_PRO.My.MySettings.Default.D2
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CYBERPACK_PRO.My.MySettings.Default, "D2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(21, 71)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(178, 21)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "COSTOMER'S ID:"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Resources.__
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(205, 286)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(229, 25)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "&Open"
        Me.Button4.UseCompatibleTextRendering = True
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Resources.__
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.CYBERPACK_PRO.My.Resources.VsImg.PrintHS
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(205, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(229, 25)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "&Print"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(205, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox7.Location = New System.Drawing.Point(21, 286)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(113, 17)
        Me.CheckBox7.TabIndex = 30
        Me.CheckBox7.Text = "OPEN WITH DATA"
        Me.CheckBox7.UseVisualStyleBackColor = False
        '
        'DVD_Rent_Query
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(580, 366)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.CheckBox14)
        Me.Controls.Add(Me.CheckBox13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.DateTimePicker4)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox12)
        Me.Controls.Add(Me.CheckBox11)
        Me.Controls.Add(Me.CheckBox10)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DVD_Rent_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DVD_Rent_Query"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
End Class
