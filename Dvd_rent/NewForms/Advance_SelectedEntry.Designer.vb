<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Advance_SelectedEntry
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.TypeTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.TypeTableAdapter
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.SelfRowColumnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Self_Row_ColumnTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.Self_Row_ColumnTableAdapter
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.CheckBox10 = New System.Windows.Forms.CheckBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelfRowColumnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TypeBindingSource
        Me.ComboBox1.DisplayMember = "Movie_Type_Name"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(207, 42)
        Me.ComboBox1.MaxDropDownItems = 80
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(304, 23)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Movie_Type"
        '
        'TypeBindingSource
        '
        Me.TypeBindingSource.DataMember = "Type"
        Me.TypeBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TypeTableAdapter
        '
        Me.TypeTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"English+DVD", "Hindi+DVD", "Bangla+DVD", "----------------", "English+CD", "Hindi+CD", "Bangla+CD", "----------------", "SOFTWARE+CD", "SOFTWARE+DVD", "----------------", "GAMES+CD", "GAMES+DVD", "----------------", "MUSIC+CD", "MUSIC+DVD", "----------------", "LEARNING+CD", "LEARNING+DVD"})
        Me.ComboBox2.Location = New System.Drawing.Point(207, 73)
        Me.ComboBox2.MaxDropDownItems = 60
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(304, 23)
        Me.ComboBox2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(207, 256)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(304, 23)
        Me.DateTimePicker1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(207, 104)
        Me.TextBox1.MaxLength = 80
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(304, 23)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"InHand", "InStore", "Lost", "Broken", "Sold"})
        Me.ComboBox3.Location = New System.Drawing.Point(207, 131)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(304, 23)
        Me.ComboBox3.TabIndex = 3
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.SelfRowColumnBindingSource
        Me.ComboBox4.DisplayMember = "Self_Row_Column"
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(207, 162)
        Me.ComboBox4.MaxDropDownItems = 60
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(304, 23)
        Me.ComboBox4.TabIndex = 4
        Me.ComboBox4.ValueMember = "Self_Row_ID"
        '
        'SelfRowColumnBindingSource
        '
        Me.SelfRowColumnBindingSource.DataMember = "Self_Row_Column"
        Me.SelfRowColumnBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'Self_Row_ColumnTableAdapter
        '
        Me.Self_Row_ColumnTableAdapter.ClearBeforeFill = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(207, 193)
        Me.TextBox2.MaxLength = 100
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(304, 23)
        Me.TextBox2.TabIndex = 5
        '
        'ComboBox5
        '
        Me.ComboBox5.DataSource = Me.AukDatabaseDataSet
        Me.ComboBox5.DisplayMember = "Type.Movie_Type_Name"
        Me.ComboBox5.DropDownHeight = 400
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.DropDownWidth = 300
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.IntegralHeight = False
        Me.ComboBox5.Location = New System.Drawing.Point(207, 224)
        Me.ComboBox5.MaxDropDownItems = 60
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(266, 23)
        Me.ComboBox5.TabIndex = 6
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(22, 43)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(177, 24)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Movie Type:"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Location = New System.Drawing.Point(22, 73)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(177, 24)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Movie Version:"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Location = New System.Drawing.Point(22, 103)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(177, 24)
        Me.CheckBox3.TabIndex = 10
        Me.CheckBox3.Text = "Movie Name:"
        Me.CheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox4
        '
        Me.CheckBox4.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox4.Location = New System.Drawing.Point(22, 133)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(177, 24)
        Me.CheckBox4.TabIndex = 11
        Me.CheckBox4.Text = "Movie Place:"
        Me.CheckBox4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'CheckBox5
        '
        Me.CheckBox5.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox5.Location = New System.Drawing.Point(22, 163)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(177, 24)
        Me.CheckBox5.TabIndex = 12
        Me.CheckBox5.Text = "Self Column Link With:"
        Me.CheckBox5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox5.UseVisualStyleBackColor = False
        '
        'CheckBox6
        '
        Me.CheckBox6.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox6.Location = New System.Drawing.Point(22, 193)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(177, 24)
        Me.CheckBox6.TabIndex = 13
        Me.CheckBox6.Text = "Advance Movie TypeEditor:"
        Me.CheckBox6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox6.UseVisualStyleBackColor = False
        '
        'CheckBox7
        '
        Me.CheckBox7.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox7.Location = New System.Drawing.Point(22, 256)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(177, 24)
        Me.CheckBox7.TabIndex = 14
        Me.CheckBox7.Text = "Purchase Date:"
        Me.CheckBox7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox7.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Advance Selected Items Entry"
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
        Me.Button1.Location = New System.Drawing.Point(207, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(304, 30)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Input Programmatically"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 445)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(528, 21)
        Me.ProgressBar1.TabIndex = 17
        Me.ProgressBar1.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(479, 224)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(30, 23)
        Me.TextBox3.TabIndex = 18
        Me.TextBox3.Text = "+"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox8
        '
        Me.CheckBox8.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox8.Location = New System.Drawing.Point(22, 286)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(177, 24)
        Me.CheckBox8.TabIndex = 20
        Me.CheckBox8.Text = "Purchase Cost:"
        Me.CheckBox8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox8.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Location = New System.Drawing.Point(207, 287)
        Me.TextBox4.MaxLength = 80
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(304, 23)
        Me.TextBox4.TabIndex = 19
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox9
        '
        Me.CheckBox9.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox9.Location = New System.Drawing.Point(22, 316)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(177, 24)
        Me.CheckBox9.TabIndex = 22
        Me.CheckBox9.Text = "Rent Default Price:"
        Me.CheckBox9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox9.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Location = New System.Drawing.Point(207, 317)
        Me.TextBox5.MaxLength = 80
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(304, 23)
        Me.TextBox5.TabIndex = 21
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox10
        '
        Me.CheckBox10.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox10.Location = New System.Drawing.Point(22, 346)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(177, 24)
        Me.CheckBox10.TabIndex = 24
        Me.CheckBox10.Text = "Discount:"
        Me.CheckBox10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox10.UseVisualStyleBackColor = False
        '
        'TextBox6
        '
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.Location = New System.Drawing.Point(207, 347)
        Me.TextBox6.MaxLength = 80
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(304, 23)
        Me.TextBox6.TabIndex = 23
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox11
        '
        Me.CheckBox11.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox11.Location = New System.Drawing.Point(22, 377)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(177, 24)
        Me.CheckBox11.TabIndex = 26
        Me.CheckBox11.Text = "Comments/Information:"
        Me.CheckBox11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox11.UseVisualStyleBackColor = False
        '
        'TextBox7
        '
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.Location = New System.Drawing.Point(207, 378)
        Me.TextBox7.MaxLength = 80
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(304, 23)
        Me.TextBox7.TabIndex = 25
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Advance_SelectedEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Bluesky2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(528, 466)
        Me.Controls.Add(Me.CheckBox11)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.CheckBox10)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Advance_SelectedEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advance SelectedEntry"
        Me.TopMost = True
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelfRowColumnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents TypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypeTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.TypeTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents SelfRowColumnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Self_Row_ColumnTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.Self_Row_ColumnTableAdapter
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
End Class
