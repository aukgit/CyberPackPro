<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RENTAL_SET
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RENT MOVIES BY"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"USING DATAGRIDVIEW", "USING TEXTBOX,FAST IN LARGE SCALE DATABASE MONITORING"})
        Me.ComboBox1.Location = New System.Drawing.Point(114, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(456, 23)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(582, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RENT MOVIES BY"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(579, 108)
        Me.GroupBox2.TabIndex = 3
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
        Me.HScrollBar1.Size = New System.Drawing.Size(573, 19)
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
        Me.CheckBox11.Size = New System.Drawing.Size(573, 25)
        Me.CheckBox11.TabIndex = 10
        Me.CheckBox11.Text = "SHOW THIS &LISTBOX WHEN A COSTOMER/MEMBER ID LOADED"
        Me.CheckBox11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Image = Global.CyberPack_Pro.My.Resources.Resources.Bluesky12
        Me.Label3.Location = New System.Drawing.Point(3, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(573, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "PLEASE SET LISTBOX WIDTH(170-320)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RENTAL_SET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(582, 172)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RENTAL_SET"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOVIES RENTAL SETTINGS"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
