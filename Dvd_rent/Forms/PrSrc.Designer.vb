<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrSrc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Exactword = New System.Windows.Forms.RadioButton
        Me.Fexact = New System.Windows.Forms.RadioButton
        Me.Anywhere = New System.Windows.Forms.RadioButton
        Me.Adsrc = New System.Windows.Forms.RadioButton
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColseSearchOptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movie Name"
        '
        'Button1
        '
        Me.Button1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Button1.Location = New System.Drawing.Point(449, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label2.Location = New System.Drawing.Point(82, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ctrl+F to Colse and  Bring this Search Box"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox1.Controls.Add(Me.Adsrc)
        Me.GroupBox1.Controls.Add(Me.Anywhere)
        Me.GroupBox1.Controls.Add(Me.Fexact)
        Me.GroupBox1.Controls.Add(Me.Exactword)
        Me.GroupBox1.Location = New System.Drawing.Point(85, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 44)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search System"
        '
        'Exactword
        '
        Me.Exactword.AutoSize = True
        Me.Exactword.Location = New System.Drawing.Point(6, 17)
        Me.Exactword.Name = "Exactword"
        Me.Exactword.Size = New System.Drawing.Size(52, 17)
        Me.Exactword.TabIndex = 0
        Me.Exactword.Text = "Exact"
        Me.Exactword.UseVisualStyleBackColor = True
        '
        'Fexact
        '
        Me.Fexact.AutoSize = True
        Me.Fexact.Location = New System.Drawing.Point(81, 17)
        Me.Fexact.Name = "Fexact"
        Me.Fexact.Size = New System.Drawing.Size(100, 17)
        Me.Fexact.TabIndex = 1
        Me.Fexact.Text = "ExactFrom First"
        Me.Fexact.UseVisualStyleBackColor = True
        '
        'Anywhere
        '
        Me.Anywhere.AutoSize = True
        Me.Anywhere.Location = New System.Drawing.Point(204, 17)
        Me.Anywhere.Name = "Anywhere"
        Me.Anywhere.Size = New System.Drawing.Size(74, 17)
        Me.Anywhere.TabIndex = 2
        Me.Anywhere.Text = "Anywhere"
        Me.Anywhere.UseVisualStyleBackColor = True
        '
        'Adsrc
        '
        Me.Adsrc.AutoSize = True
        Me.Adsrc.Checked = True
        Me.Adsrc.Location = New System.Drawing.Point(301, 17)
        Me.Adsrc.Name = "Adsrc"
        Me.Adsrc.Size = New System.Drawing.Size(141, 17)
        Me.Adsrc.TabIndex = 3
        Me.Adsrc.TabStop = True
        Me.Adsrc.Text = "Advance Search System"
        Me.Adsrc.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = Global.CyberPack_Pro.My.MySettings.Default.place_chk_src
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "place_chk_src", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(26, 57)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Place"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.AutoCompleteCustomSource.AddRange(New String() {"InHand", "InStore", "Lost", "Borken", "Lost"})
        Me.TextBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "Place_NormalSearch", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Location = New System.Drawing.Point(85, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(449, 21)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = Global.CyberPack_Pro.My.MySettings.Default.Place_NormalSearch
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "ProductName_Search", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(85, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(449, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = Global.CyberPack_Pro.My.MySettings.Default.ProductName_Search
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Button2.Location = New System.Drawing.Point(355, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Remove Filter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColseSearchOptionToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(210, 26)
        '
        'ColseSearchOptionToolStripMenuItem
        '
        Me.ColseSearchOptionToolStripMenuItem.Name = "ColseSearchOptionToolStripMenuItem"
        Me.ColseSearchOptionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ColseSearchOptionToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ColseSearchOptionToolStripMenuItem.Text = "Colse Search Option"
        '
        'PrSrc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(554, 167)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PrSrc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Adsrc As System.Windows.Forms.RadioButton
    Friend WithEvents Anywhere As System.Windows.Forms.RadioButton
    Friend WithEvents Fexact As System.Windows.Forms.RadioButton
    Friend WithEvents Exactword As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ColseSearchOptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
