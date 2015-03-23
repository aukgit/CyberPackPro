<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DL_Opt
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 179)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DataLoad Options"
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox7.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox7.Checked = Global.CyberPack_Pro.My.MySettings.Default.LOGINPASS
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "LOGINPASS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox7.Location = New System.Drawing.Point(6, 150)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(318, 19)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "USE LOGIN FORM USER PASSWORD TO LOAD DATABASE"
        Me.CheckBox7.UseVisualStyleBackColor = False
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox6.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox6.Checked = Global.CyberPack_Pro.My.MySettings.Default.VIRTUAL_CYBERCAFE
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "VIRTUAL_CYBERCAFE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox6.Location = New System.Drawing.Point(6, 127)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(271, 19)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "VIRTUAL DATAGRID:CYBER CAFE MONITORING."
        Me.CheckBox6.UseVisualStyleBackColor = False
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox5.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox5.Checked = Global.CyberPack_Pro.My.MySettings.Default.VIRTUAL_MOVIES_COLLECTION
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "VIRTUAL_MOVIES_COLLECTION", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox5.Location = New System.Drawing.Point(6, 106)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(244, 19)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "VIRTUAL DATAGRID:MOVIES COLLECTION."
        Me.CheckBox5.UseVisualStyleBackColor = False
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox4.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox4.Checked = Global.CyberPack_Pro.My.MySettings.Default.PS_LASTL_ADDINGNEW
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "PS_LASTL_ADDINGNEW", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox4.Location = New System.Drawing.Point(6, 85)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(364, 19)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "PRODUCT SOLD:ADDING NEW PRODUCT ,LOAD LAST ITEM ONLY."
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox3.Checked = Global.CyberPack_Pro.My.MySettings.Default.DRENT_ADEW_LASTMOVIE
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DRENT_ADEW_LASTMOVIE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox3.Location = New System.Drawing.Point(6, 64)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(227, 19)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "MOVIES ADD:LOAD LAST MOVIE ONLY."
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = Global.CyberPack_Pro.My.MySettings.Default.CYBER_LAST_MEMBER_LOAD
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "CYBER_LAST_MEMBER_LOAD", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(6, 22)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(299, 19)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CYBER MEMBER: ALWAYS LOAD ONLY LAST MEMBER."
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "CyberMember Means Cyber Cafe & BroadBand Both Members.")
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox2.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDRENT_LAST_MEMBER
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDRENT_LAST_MEMBER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(6, 43)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(333, 19)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "MOVIE RENT MEMBER: ALWAYS LOAD ONLY LAST MEMBER."
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 128)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Loading Style"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 97)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(351, 19)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Tag = "3"
        Me.RadioButton4.Text = "Always Load TrayIcon And No View Shows of CyberPack Pro."
        Me.ToolTip1.SetToolTip(Me.RadioButton4, "The fast way to run the soft.")
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 72)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(423, 19)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Tag = "2"
        Me.RadioButton3.Text = "Always Start Non-Animated View of CyberPackPro without Splash Screen."
        Me.ToolTip1.SetToolTip(Me.RadioButton3, "Normal way ,it contains 30 MB RAM to open Cyberpack pro.")
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 47)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(379, 19)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Tag = "1"
        Me.RadioButton2.Text = "Always Start Animated View of CyberPackPro with Splash Screen."
        Me.ToolTip1.SetToolTip(Me.RadioButton2, "High Animated way ,it contains 140 MB RAM to open Cyberpack pro.")
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(335, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Tag = "0"
        Me.RadioButton1.Text = "Check physical memory then set automatic starting style."
        Me.ToolTip1.SetToolTip(Me.RadioButton1, "if ram>=256 , show animated view of Cyberpack Pro wih splash screen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if ram>=128" & _
                " , show non-animated view of Cyberpack Pro." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if ram>=64 , show tray icon of Cybe" & _
                "rpack Pro.")
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CyberPack Pro Main Form Transparancy:"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.CyberPack_Pro.My.MySettings.Default, "CyberMainFormTrans", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.HScrollBar1.LargeChange = 1
        Me.HScrollBar1.Location = New System.Drawing.Point(256, 328)
        Me.HScrollBar1.Minimum = 80
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(220, 15)
        Me.HScrollBar1.TabIndex = 1
        Me.HScrollBar1.Value = Global.CyberPack_Pro.My.MySettings.Default.CyberMainFormTrans
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(258, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "100%"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DL_Opt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(488, 367)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "DL_Opt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataLoad Options & CyberPakc Pro Starting Style"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
End Class
