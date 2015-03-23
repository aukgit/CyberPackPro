<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvanceSearch
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
        Me.ComboBox9 = New System.Windows.Forms.ComboBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.ComboBox8 = New System.Windows.Forms.ComboBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ComboBox7 = New System.Windows.Forms.ComboBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DE_ENA = New System.Windows.Forms.CheckBox
        Me.MQ_ENA = New System.Windows.Forms.CheckBox
        Me.PR_ENA = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBoxArray1 = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(Me.components)
        Me.CheckBoxArray1 = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.TextBoxArray1 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ComboBoxArray1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBoxArray1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxArray1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.CheckBox9)
        Me.GroupBox1.Controls.Add(Me.ComboBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 87)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MOVIE QUALITIES"
        '
        'ComboBox9
        '
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"EXACT WORD", "EXACT FROM FIRST", "ANY WHERE IN FIELD", "ADVANCE(AND)", "ADVANCE(AND) FROM FIRST", "ADVANCE(OR)", "ADVANCE(OR) FROM FIRST", "ADVANCE(AND)[CHARACTER ARRAY]", "IN COMMAND(USE "","" TO CONCORD)", "EXTACT BUT CREATE ARRAY OF SPACE WORD", "BETWEEN(USE "","" KEY AND TYPE 2 WORDS)", "ADVANCE(OR)[CHR ARRAY]", "ADVANCE(AUK FAV)[USE "";"" KEYS FOR 'OR']"})
        Me.ComboBox9.Location = New System.Drawing.Point(510, 47)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(252, 23)
        Me.ComboBox9.TabIndex = 18
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(167, 47)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(337, 23)
        Me.TextBox9.TabIndex = 17
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox9
        '
        Me.CheckBox9.Location = New System.Drawing.Point(17, 49)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(144, 19)
        Me.CheckBox9.TabIndex = 16
        Me.CheckBox9.Text = "MOVIE ADVANCE TYPE"
        Me.CheckBox9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"EXACT WORD", "EXACT FROM FIRST", "ANY WHERE IN FIELD", "ADVANCE(AND)", "ADVANCE(AND) FROM FIRST", "ADVANCE(OR)", "ADVANCE(OR) FROM FIRST", "ADVANCE(AND)[CHARACTER ARRAY]", "IN COMMAND(USE "","" TO CONCORD)", "EXTACT BUT CREATE ARRAY OF SPACE WORD", "BETWEEN(USE "","" KEY AND TYPE 2 WORDS)", "ADVANCE(OR)[CHR ARRAY]", "ADVANCE(AUK FAV)[USE "";"" KEYS FOR 'OR']"})
        Me.ComboBox8.Location = New System.Drawing.Point(510, 22)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(252, 23)
        Me.ComboBox8.TabIndex = 15
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(167, 22)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(337, 23)
        Me.TextBox8.TabIndex = 14
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox8
        '
        Me.CheckBox8.Location = New System.Drawing.Point(17, 22)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(144, 19)
        Me.CheckBox8.TabIndex = 13
        Me.CheckBox8.Text = "MOVIE TYPE"
        Me.CheckBox8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.ComboBox7)
        Me.GroupBox3.Controls.Add(Me.ComboBox5)
        Me.GroupBox3.Controls.Add(Me.ComboBox4)
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.CheckBox7)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBox5)
        Me.GroupBox3.Controls.Add(Me.CheckBox4)
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(768, 187)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DETAILS"
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"EXACT WORD", "EXACT FROM FIRST", "ANY WHERE IN FIELD", "ADVANCE(AND)", "ADVANCE(AND) FROM FIRST", "ADVANCE(OR)", "ADVANCE(OR) FROM FIRST", "ADVANCE(AND)[CHARACTER ARRAY]", "IN COMMAND(USE "","" TO CONCORD)", "EXTACT BUT CREATE ARRAY OF SPACE WORD", "BETWEEN(USE "","" KEY AND TYPE 2 WORDS)", "ADVANCE(OR)[CHR ARRAY]", "ADVANCE(AUK FAV)[USE "";"" KEYS FOR 'OR']"})
        Me.ComboBox7.Location = New System.Drawing.Point(510, 150)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(252, 23)
        Me.ComboBox7.TabIndex = 20
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"EXACT WORD", "EXACT FROM FIRST", "ANY WHERE IN FIELD", "ADVANCE(AND)", "ADVANCE(AND) FROM FIRST", "ADVANCE(OR)", "ADVANCE(OR) FROM FIRST", "ADVANCE(AND)[CHARACTER ARRAY]", "IN COMMAND(USE "","" TO CONCORD)", "EXTACT BUT CREATE ARRAY OF SPACE WORD", "BETWEEN(USE "","" KEY AND TYPE 2 WORDS)", "ADVANCE(OR)[CHR ARRAY]", "ADVANCE(AUK FAV)[USE "";"" KEYS FOR 'OR']"})
        Me.ComboBox5.Location = New System.Drawing.Point(510, 120)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(252, 23)
        Me.ComboBox5.TabIndex = 18
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"EXACT WORD", "EXACT FROM FIRST", "ANY WHERE IN FIELD", "ADVANCE(AND)", "ADVANCE(AND) FROM FIRST", "ADVANCE(OR)", "ADVANCE(OR) FROM FIRST", "ADVANCE(AND)[CHARACTER ARRAY]", "IN COMMAND(USE "","" TO CONCORD)", "EXTACT BUT CREATE ARRAY OF SPACE WORD", "BETWEEN(USE "","" KEY AND TYPE 2 WORDS)", "ADVANCE(OR)[CHR ARRAY]", "ADVANCE(AUK FAV)[USE "";"" KEYS FOR 'OR']"})
        Me.ComboBox4.Location = New System.Drawing.Point(510, 97)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(252, 23)
        Me.ComboBox4.TabIndex = 17
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"EXACT WORD", "EXACT FROM FIRST", "ANY WHERE IN FIELD", "ADVANCE(AND)", "ADVANCE(AND) FROM FIRST", "ADVANCE(OR)", "ADVANCE(OR) FROM FIRST", "ADVANCE(AND)[CHARACTER ARRAY]", "IN COMMAND(USE "","" TO CONCORD)", "EXTACT BUT CREATE ARRAY OF SPACE WORD", "BETWEEN(USE "","" KEY AND TYPE 2 WORDS)", "ADVANCE(OR)[CHR ARRAY]", "ADVANCE(AUK FAV)[USE "";"" KEYS FOR 'OR']"})
        Me.ComboBox3.Location = New System.Drawing.Point(510, 72)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(252, 23)
        Me.ComboBox3.TabIndex = 16
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"EXACT WORD", "EXACT FROM FIRST", "ANY WHERE IN FIELD", "ADVANCE(AND)", "ADVANCE(AND) FROM FIRST", "ADVANCE(OR)", "ADVANCE(OR) FROM FIRST", "ADVANCE(AND)[CHARACTER ARRAY]", "IN COMMAND(USE "","" TO CONCORD)", "EXTACT BUT CREATE ARRAY OF SPACE WORD", "BETWEEN(USE "","" KEY AND TYPE 2 WORDS)", "ADVANCE(OR)[CHR ARRAY]", "ADVANCE(AUK FAV)[USE "";"" KEYS FOR 'OR']"})
        Me.ComboBox2.Location = New System.Drawing.Point(510, 47)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(252, 23)
        Me.ComboBox2.TabIndex = 15
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(131, 150)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(373, 23)
        Me.TextBox7.TabIndex = 14
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox7
        '
        Me.CheckBox7.Location = New System.Drawing.Point(17, 151)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(111, 19)
        Me.CheckBox7.TabIndex = 13
        Me.CheckBox7.Text = "SELF COLUMN"
        Me.CheckBox7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"EXACT WORD", "EXACT FROM FIRST", "ANY WHERE IN FIELD", "ADVANCE(AND)", "ADVANCE(AND) FROM FIRST", "ADVANCE(OR)", "ADVANCE(OR) FROM FIRST", "ADVANCE(AND)[CHARACTER ARRAY]", "IN COMMAND(USE "","" TO CONCORD)", "EXTACT BUT CREATE ARRAY OF SPACE WORD", "BETWEEN(USE "","" KEY AND TYPE 2 WORDS)", "ADVANCE(OR)[CHR ARRAY]", "ADVANCE(AUK FAV)[USE "";"" KEYS FOR 'OR']"})
        Me.ComboBox1.Location = New System.Drawing.Point(510, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(252, 23)
        Me.ComboBox1.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(131, 121)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(373, 23)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(131, 97)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(373, 23)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(131, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(373, 23)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(131, 47)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(373, 23)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox5
        '
        Me.CheckBox5.Location = New System.Drawing.Point(17, 122)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(111, 19)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "PLACE"
        Me.CheckBox5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.Location = New System.Drawing.Point(17, 97)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(111, 19)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "CUSTOMER ID"
        Me.CheckBox4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.Location = New System.Drawing.Point(17, 72)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(111, 19)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "PURCHASE DATE"
        Me.CheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(17, 47)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(111, 19)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "MOVIE NAME"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(17, 22)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(111, 19)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "DVD ID"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(131, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(373, 23)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DE_ENA
        '
        Me.DE_ENA.Appearance = System.Windows.Forms.Appearance.Button
        Me.DE_ENA.AutoSize = True
        Me.DE_ENA.BackColor = System.Drawing.Color.Transparent
        Me.DE_ENA.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.DE_ENA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DE_ENA.Location = New System.Drawing.Point(721, 24)
        Me.DE_ENA.Name = "DE_ENA"
        Me.DE_ENA.Size = New System.Drawing.Size(56, 25)
        Me.DE_ENA.TabIndex = 0
        Me.DE_ENA.Text = "ENABLE"
        Me.DE_ENA.UseVisualStyleBackColor = False
        '
        'MQ_ENA
        '
        Me.MQ_ENA.Appearance = System.Windows.Forms.Appearance.Button
        Me.MQ_ENA.AutoSize = True
        Me.MQ_ENA.BackColor = System.Drawing.Color.Transparent
        Me.MQ_ENA.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.MQ_ENA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MQ_ENA.Location = New System.Drawing.Point(724, 239)
        Me.MQ_ENA.Name = "MQ_ENA"
        Me.MQ_ENA.Size = New System.Drawing.Size(56, 25)
        Me.MQ_ENA.TabIndex = 2
        Me.MQ_ENA.Text = "ENABLE"
        Me.MQ_ENA.UseVisualStyleBackColor = False
        '
        'PR_ENA
        '
        Me.PR_ENA.Appearance = System.Windows.Forms.Appearance.Button
        Me.PR_ENA.AutoSize = True
        Me.PR_ENA.BackColor = System.Drawing.Color.Transparent
        Me.PR_ENA.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.PR_ENA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PR_ENA.Location = New System.Drawing.Point(724, 350)
        Me.PR_ENA.Name = "PR_ENA"
        Me.PR_ENA.Size = New System.Drawing.Size(56, 25)
        Me.PR_ENA.TabIndex = 3
        Me.PR_ENA.Text = "ENABLE"
        Me.PR_ENA.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(15, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "EXECUTE QUERY"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AdvanceSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 401)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PR_ENA)
        Me.Controls.Add(Me.MQ_ENA)
        Me.Controls.Add(Me.DE_ENA)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "AdvanceSearch"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdvanceSearch"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ComboBoxArray1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBoxArray1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxArray1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DE_ENA As System.Windows.Forms.CheckBox
    Friend WithEvents MQ_ENA As System.Windows.Forms.CheckBox
    Friend WithEvents PR_ENA As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBoxArray1 As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
    Friend WithEvents CheckBoxArray1 As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
    Friend WithEvents TextBoxArray1 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
End Class
