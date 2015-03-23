<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DVDOPT
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.CheckBox28 = New System.Windows.Forms.CheckBox
        Me.CheckBox26 = New System.Windows.Forms.CheckBox
        Me.CheckBox25 = New System.Windows.Forms.CheckBox
        Me.CheckBox24 = New System.Windows.Forms.CheckBox
        Me.CheckBox23 = New System.Windows.Forms.CheckBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CheckBox22 = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CheckBox17 = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CheckBox18 = New System.Windows.Forms.CheckBox
        Me.CheckBox14 = New System.Windows.Forms.CheckBox
        Me.CheckBox13 = New System.Windows.Forms.CheckBox
        Me.CheckBox12 = New System.Windows.Forms.CheckBox
        Me.CheckBox10 = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CheckBox21 = New System.Windows.Forms.CheckBox
        Me.CheckBox20 = New System.Windows.Forms.CheckBox
        Me.CheckBox19 = New System.Windows.Forms.CheckBox
        Me.CheckBox16 = New System.Windows.Forms.CheckBox
        Me.CheckBox27 = New System.Windows.Forms.CheckBox
        Me.CheckBox15 = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CheckBox22)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox10)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox9)
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 389)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "(Hide/Show),ReadOnly And Other Options"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.CheckBox28)
        Me.GroupBox6.Controls.Add(Me.CheckBox26)
        Me.GroupBox6.Controls.Add(Me.CheckBox25)
        Me.GroupBox6.Controls.Add(Me.CheckBox24)
        Me.GroupBox6.Controls.Add(Me.CheckBox23)
        Me.GroupBox6.Location = New System.Drawing.Point(390, 165)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(370, 80)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "(HIDE/SHOW DVD) AND PROGRAMMATIC CHANGE RENT VIEW"
        '
        'CheckBox28
        '
        Me.CheckBox28.AutoSize = True
        Me.CheckBox28.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox28.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_BENEFIT_SHOW
        Me.CheckBox28.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox28.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_BENEFIT_SHOW", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox28.ForeColor = System.Drawing.Color.Red
        Me.CheckBox28.Location = New System.Drawing.Point(168, 35)
        Me.CheckBox28.Name = "CheckBox28"
        Me.CheckBox28.Size = New System.Drawing.Size(200, 34)
        Me.CheckBox28.TabIndex = 10
        Me.CheckBox28.Text = "ALWAYS UPDATE BENEFIT/PROFIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHEN RENT DVD SAVE."
        Me.CheckBox28.UseVisualStyleBackColor = True
        '
        'CheckBox26
        '
        Me.CheckBox26.AutoSize = True
        Me.CheckBox26.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVD_RENT_V_MNAME
        Me.CheckBox26.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox26.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVD_RENT_V_MNAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox26.Location = New System.Drawing.Point(168, 16)
        Me.CheckBox26.Name = "CheckBox26"
        Me.CheckBox26.Size = New System.Drawing.Size(98, 19)
        Me.CheckBox26.TabIndex = 9
        Me.CheckBox26.Text = "MOVIE NAME"
        Me.CheckBox26.UseVisualStyleBackColor = True
        '
        'CheckBox25
        '
        Me.CheckBox25.AutoSize = True
        Me.CheckBox25.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDRNT_COS_COMMENTS
        Me.CheckBox25.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox25.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDRNT_COS_COMMENTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox25.Location = New System.Drawing.Point(12, 54)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(151, 19)
        Me.CheckBox25.TabIndex = 8
        Me.CheckBox25.Text = "CUSTOMERS COMMETS"
        Me.CheckBox25.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox25.UseVisualStyleBackColor = True
        '
        'CheckBox24
        '
        Me.CheckBox24.AutoSize = True
        Me.CheckBox24.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDRNT_DVDCOMMENTS
        Me.CheckBox24.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox24.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDRNT_DVDCOMMENTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox24.Location = New System.Drawing.Point(12, 35)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(116, 19)
        Me.CheckBox24.TabIndex = 7
        Me.CheckBox24.Text = "DVD COMMENTS"
        Me.CheckBox24.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox24.UseVisualStyleBackColor = True
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDRNT_ALTERNATIVE
        Me.CheckBox23.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox23.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDRNT_ALTERNATIVE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox23.Location = New System.Drawing.Point(12, 16)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(93, 19)
        Me.CheckBox23.TabIndex = 6
        Me.CheckBox23.Text = "ALTERNATIVE"
        Me.CheckBox23.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox23.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_ORDERBY", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "DVD_ID", "MOVIE_NAME", "VAL(DVD_ID)"})
        Me.ComboBox1.Location = New System.Drawing.Point(547, 251)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(214, 23)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.Text = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_ORDERBY
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "WHEN LOADING ORDER BY "
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_COMMENTS
        Me.CheckBox22.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox22.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_COMMENTS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox22.Location = New System.Drawing.Point(16, 242)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(290, 19)
        Me.CheckBox22.TabIndex = 10
        Me.CheckBox22.Text = "COMMENTS \ INFORMATION \ PRODUCER\ACTOR"
        Me.CheckBox22.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox22.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.CheckBox17)
        Me.GroupBox4.Location = New System.Drawing.Point(390, 119)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(370, 43)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "READONLY FIELDS- DVD RENT VIEW"
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_DVDRENTVIEW_DVDRENTCOST
        Me.CheckBox17.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox17.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_DVDRENTVIEW_DVDRENTCOST", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox17.Location = New System.Drawing.Point(12, 16)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(110, 19)
        Me.CheckBox17.TabIndex = 6
        Me.CheckBox17.Text = "DVD RENT COST"
        Me.CheckBox17.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CheckBox18)
        Me.GroupBox3.Controls.Add(Me.CheckBox14)
        Me.GroupBox3.Controls.Add(Me.CheckBox13)
        Me.GroupBox3.Controls.Add(Me.CheckBox12)
        Me.GroupBox3.Location = New System.Drawing.Point(390, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 107)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "READONLY FIELDS- PRODUCT COLLECTION"
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_PRODUCT_RENTCOST
        Me.CheckBox18.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox18.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_PRODUCT_RENTCOST", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox18.Location = New System.Drawing.Point(12, 82)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(142, 19)
        Me.CheckBox18.TabIndex = 9
        Me.CheckBox18.Text = "RENTAL COST DEFAULT"
        Me.CheckBox18.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_PRODUCT_SOLDVIEW
        Me.CheckBox14.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox14.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_PRODUCT_SOLDVIEW", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox14.Location = New System.Drawing.Point(12, 62)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(178, 19)
        Me.CheckBox14.TabIndex = 8
        Me.CheckBox14.Text = "SOLD/LOST/BROKEN SYSTEM"
        Me.CheckBox14.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_PRODUCT_MADTYPE
        Me.CheckBox13.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox13.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_PRODUCT_MADTYPE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox13.Location = New System.Drawing.Point(12, 42)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(143, 19)
        Me.CheckBox13.TabIndex = 7
        Me.CheckBox13.Text = "MOVIE ADVANCE TYPE"
        Me.CheckBox13.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_PRODUCT_PURCHASE
        Me.CheckBox12.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox12.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_PRODUCT_PURCHASE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox12.Location = New System.Drawing.Point(12, 22)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(111, 19)
        Me.CheckBox12.TabIndex = 6
        Me.CheckBox12.Text = "PURCHASE DATE"
        Me.CheckBox12.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Checked = Global.CyberPack_Pro.My.MySettings.Default.MOVIE_RENTALCOST
        Me.CheckBox10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox10.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "MOVIE_RENTALCOST", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox10.Location = New System.Drawing.Point(16, 220)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(135, 19)
        Me.CheckBox10.TabIndex = 9
        Me.CheckBox10.Text = "MOVIE RENTAL COST"
        Me.CheckBox10.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.HScrollBar1)
        Me.GroupBox2.Controls.Add(Me.CheckBox11)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 270)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(753, 108)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CUSTOMERS PREVIOUS MOVIES VIEW SHOW IN LISTBOX"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(363, 58)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(147, 19)
        Me.RadioButton4.TabIndex = 15
        Me.RadioButton4.Tag = "3"
        Me.RadioButton4.Text = "MOVIE NAME-(DVD ID)"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(202, 58)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(155, 19)
        Me.RadioButton3.TabIndex = 14
        Me.RadioButton3.Tag = "2"
        Me.RadioButton3.Text = "(DVD ID)-(MOVIE NAME)"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(13, 58)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(63, 19)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Tag = "0"
        Me.RadioButton2.Text = "DVD ID"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(99, 58)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(97, 19)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.Tag = "1"
        Me.RadioButton1.Text = "MOVIE NAME"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'HScrollBar1
        '
        Me.HScrollBar1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_LISTBOX_WIDTHVALUE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.HScrollBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.HScrollBar1.Location = New System.Drawing.Point(3, 36)
        Me.HScrollBar1.Maximum = 320
        Me.HScrollBar1.Minimum = 170
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(747, 19)
        Me.HScrollBar1.TabIndex = 11
        Me.HScrollBar1.Value = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_LISTBOX_WIDTHVALUE
        '
        'CheckBox11
        '
        Me.CheckBox11.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox11.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.CheckBox11.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_PREVIOUS_MOVIE_COSTOMER
        Me.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox11.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_PREVIOUS_MOVIE_COSTOMER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CheckBox11.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CheckBox11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.CheckBox11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.CheckBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox11.Location = New System.Drawing.Point(3, 80)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(747, 25)
        Me.CheckBox11.TabIndex = 10
        Me.CheckBox11.Text = "SHOW THIS &LISTBOX WHEN A COSTOMER/MEMBER ID LOADED"
        Me.CheckBox11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Image = Global.CyberPack_Pro.My.Resources.Resources.Bluesky12
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(747, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PLEASE SET LISTBOX WIDTH(170-320)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_MADVANCE_TYPE
        Me.CheckBox9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox9.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_MADVANCE_TYPE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox9.Location = New System.Drawing.Point(16, 198)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(143, 19)
        Me.CheckBox9.TabIndex = 8
        Me.CheckBox9.Text = "MOVIE ADVANCE TYPE"
        Me.CheckBox9.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_DVDSOLDOPT
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_DVDSOLDOPT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox8.Location = New System.Drawing.Point(16, 176)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(196, 19)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.Text = "DVD SOLD/LOST/BROKE SYSTEM"
        Me.CheckBox8.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_SELFCOLUMN
        Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_SELFCOLUMN", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox7.Location = New System.Drawing.Point(16, 154)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(275, 19)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "(SELF COLUMN ID)DVD STOCK SELFS LINK FIELD"
        Me.CheckBox7.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_TOTAL_BENEFIT
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_TOTAL_BENEFIT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox6.Location = New System.Drawing.Point(16, 132)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(183, 19)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "TOTAL BENEFIT/TOTAL PROFIT"
        Me.CheckBox6.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_COSTOMERID
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_COSTOMERID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox5.Location = New System.Drawing.Point(16, 110)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(330, 19)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "LAST CUSTOMER ID(WHO HAVE THE PRODUCT LAST TIME)"
        Me.CheckBox5.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_PURCHASEDATE
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_PURCHASEDATE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox4.Location = New System.Drawing.Point(16, 88)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(111, 19)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "PURCHASE DATE"
        Me.CheckBox4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_MVERSION
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_MVERSION", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox3.Location = New System.Drawing.Point(16, 66)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(113, 19)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "MOVIE VERSION"
        Me.CheckBox3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_MTYPE
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_MTYPE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(16, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(91, 19)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "MOVIE TYPE"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_ITEMCOST
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_ITEMCOST", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(16, 22)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 19)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "ITEM COST"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.CheckBox21)
        Me.GroupBox5.Controls.Add(Me.CheckBox20)
        Me.GroupBox5.Controls.Add(Me.CheckBox19)
        Me.GroupBox5.Controls.Add(Me.CheckBox16)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 407)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(770, 124)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "EDITING OPTIONS"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "DVDID_TOKEN", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(486, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(20, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = Global.CyberPack_Pro.My.MySettings.Default.DVDID_TOKEN
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Checked = Global.CyberPack_Pro.My.MySettings.Default.ALWAYS_DVDINFO_STORE
        Me.CheckBox21.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox21.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "ALWAYS_DVDINFO_STORE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox21.Location = New System.Drawing.Point(8, 62)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(498, 19)
        Me.CheckBox21.TabIndex = 4
        Me.CheckBox21.Text = "ALWAYS INPUT SAME PRODUCTS QUALITY(SUCH AS MOVIE TYPE,VERSION,ITEM COST ETC)"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_MOVIE_ADVANCE_EQ_MTYPE
        Me.CheckBox20.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox20.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_MOVIE_ADVANCE_EQ_MTYPE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox20.Location = New System.Drawing.Point(8, 42)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(408, 19)
        Me.CheckBox20.TabIndex = 3
        Me.CheckBox20.Text = "ALWAYS INSERT SAME TYPE IN (MOVIE ADVANCE TYPE ) WHEN IT IS NULL."
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox19.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_AUTOMACI_DVDID
        Me.CheckBox19.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox19.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_AUTOMACI_DVDID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox19.Location = New System.Drawing.Point(8, 82)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(740, 34)
        Me.CheckBox19.TabIndex = 2
        Me.CheckBox19.Text = "FOREVER INSERT AUTOMATIC DVD ID WHEN DVD ID FIELD IS NULL. IF BEFORE FIELD DVD ID" & _
            " IS NOT NULL THEN INSERT DVD ID BY USING" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PROGRAMMATIC WAY, FIND THERE A SYMBOL " & _
            "FOR INSERT THE AUTO SERIAL. SYMBOL:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckBox19.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Checked = Global.CyberPack_Pro.My.MySettings.Default.DIRECT_SAVE
        Me.CheckBox16.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox16.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DIRECT_SAVE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox16.Location = New System.Drawing.Point(8, 22)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(244, 19)
        Me.CheckBox16.TabIndex = 1
        Me.CheckBox16.Text = "TRY TO SAVE AFTER VALID ANY CELL VALUE"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox27
        '
        Me.CheckBox27.AutoSize = True
        Me.CheckBox27.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox27.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVD_OPT_ALWAYSrEMIND
        Me.CheckBox27.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox27.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVD_OPT_ALWAYSrEMIND", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox27.Location = New System.Drawing.Point(14, 532)
        Me.CheckBox27.Name = "CheckBox27"
        Me.CheckBox27.Size = New System.Drawing.Size(405, 19)
        Me.CheckBox27.TabIndex = 4
        Me.CheckBox27.Text = "ALWAYS SHOW MESSAGE ,IF CUSTOMER HAVE CURRENT MOVIE BEFORE."
        Me.CheckBox27.UseVisualStyleBackColor = False
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox15.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox15.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOPT_USEPASSWORD
        Me.CheckBox15.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox15.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOPT_USEPASSWORD", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox15.Location = New System.Drawing.Point(612, 532)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(170, 19)
        Me.CheckBox15.TabIndex = 2
        Me.CheckBox15.Text = "USE PASSWORD TO ACCESS"
        Me.CheckBox15.UseVisualStyleBackColor = False
        '
        'DVDOPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(794, 561)
        Me.Controls.Add(Me.CheckBox27)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.CheckBox15)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DVDOPT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOVIES RENT & ADDINGS OPTIONS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox17 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox20 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox19 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox22 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox24 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox23 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox25 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox26 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox27 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox28 As System.Windows.Forms.CheckBox
End Class
