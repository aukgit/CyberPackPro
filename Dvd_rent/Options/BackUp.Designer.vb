<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackUp))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Button6 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button8 = New System.Windows.Forms.Button
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.SETTING_BACKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SETTING_BACKTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.SETTING_BACKTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SETTING_BACKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATABASE BACKUP FOLDER: "
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(15, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "BROWSE FOLDER"
        Me.ToolTip1.SetToolTip(Me.Button1, "Browse Folder")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(15, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(452, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "BACKUP CURRENT SOFTWARE SETTINGS IN CURRENT DATABASE"
        Me.ToolTip1.SetToolTip(Me.Button2, "Backup Current Software Settings on Current Database.")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(15, 118)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(452, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "RESTORE CURRENT SOFTWARE SETTINGS FROM CURRENT DATABASE"
        Me.ToolTip1.SetToolTip(Me.Button3, "By this option you can restore your database settings from current database.")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(82, 63)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "BACKUP DATABASE"
        Me.ToolTip1.SetToolTip(Me.Button4, "Backup Database by your given name.")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(346, 63)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(121, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "RESTORE DATABASE"
        Me.ToolTip1.SetToolTip(Me.Button5, "By this option you can restore your backup database and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you can also restore you" & _
                "r database settings from selected database.")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(473, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 52)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AUTO BACKUP"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = Global.CyberPack_Pro.My.MySettings.Default.REPLACE_DB
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "REPLACE_DB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(87, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(101, 19)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "REPLACE ALSO"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DAYS"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.CyberPack_Pro.My.MySettings.Default, "DAYS_BACKYP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 22)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {14, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(41, 23)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.NumericUpDown1, resources.GetString("NumericUpDown1.ToolTip"))
        Me.NumericUpDown1.Value = Global.CyberPack_Pro.My.MySettings.Default.DAYS_BACKYP
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(479, 15)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(188, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Automatic Backup On Current Folder"
        Me.ToolTip1.SetToolTip(Me.Button6, "Automatic Backup By DateTime on Current Folder")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "BACKUP_FOLDER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(15, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(616, 16)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = Global.CyberPack_Pro.My.MySettings.Default.BACKUP_FOLDER
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Please Select a folder to backup database quick and automaic.")
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.CyberPack_Pro.My.MySettings.Default, "MINIMAM_DBSIZE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NumericUpDown2.Location = New System.Drawing.Point(264, 147)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(41, 23)
        Me.NumericUpDown2.TabIndex = 3
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown2.Value = Global.CyberPack_Pro.My.MySettings.Default.MINIMAM_DBSIZE
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Location = New System.Drawing.Point(498, 156)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(130, 10)
        Me.PropertyGrid1.TabIndex = 10
        Me.PropertyGrid1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(473, 118)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(194, 23)
        Me.ProgressBar1.TabIndex = 11
        Me.ProgressBar1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(325, 30)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "IF DATABASE SIZE LESS THAN OR EQUAL THAN                    MB," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THEN IT BACKUP E" & _
            "VERYTIME BEFORE START."
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(393, 15)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 23)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "New DB"
        Me.ToolTip1.SetToolTip(Me.Button7, "You can get the clear database.")
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 90000
        Me.ToolTip1.AutoPopDelay = 90000000
        Me.ToolTip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.InitialDelay = 1000
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Information"
        '
        'Button8
        '
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(203, 63)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(137, 23)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "RESTORE SETTINGS"
        Me.ToolTip1.SetToolTip(Me.Button8, "Software Settings Restore from Select database of CyberPack pro.")
        Me.Button8.UseVisualStyleBackColor = True
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SETTING_BACKBindingSource
        '
        Me.SETTING_BACKBindingSource.DataMember = "SETTING_BACK"
        Me.SETTING_BACKBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'SETTING_BACKTableAdapter
        '
        Me.SETTING_BACKTableAdapter.ClearBeforeFill = True
        '
        'BackUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Small_imgs.Backgroud
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(679, 197)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BackUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Backup System for CyberPack Pro"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SETTING_BACKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents SETTING_BACKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SETTING_BACKTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.SETTING_BACKTableAdapter
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
