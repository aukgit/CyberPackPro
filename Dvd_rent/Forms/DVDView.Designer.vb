<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DVDViewForm
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
        Dim Costomer_IDLabel As System.Windows.Forms.Label
        Dim Costomer_CategoryLabel As System.Windows.Forms.Label
        Dim Costomer_NameLabel As System.Windows.Forms.Label
        Dim Joining_DateLabel As System.Windows.Forms.Label
        Dim Advance_FeesLabel As System.Windows.Forms.Label
        Dim Costomer_ImageLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.Costomer_InfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Costomer_IDLabel1 = New System.Windows.Forms.Label
        Me.Costomer_CategoryLabel1 = New System.Windows.Forms.Label
        Me.Costomer_NameLabel1 = New System.Windows.Forms.Label
        Me.Joining_DateLabel1 = New System.Windows.Forms.Label
        Me.Advance_FeesLabel1 = New System.Windows.Forms.Label
        Me.Costomer_ImagePictureBox = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Costomer_IDLabel = New System.Windows.Forms.Label
        Costomer_CategoryLabel = New System.Windows.Forms.Label
        Costomer_NameLabel = New System.Windows.Forms.Label
        Joining_DateLabel = New System.Windows.Forms.Label
        Advance_FeesLabel = New System.Windows.Forms.Label
        Costomer_ImageLabel = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Costomer_InfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Costomer_ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Costomer_IDLabel
        '
        Costomer_IDLabel.AutoSize = True
        Costomer_IDLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_IDLabel.Location = New System.Drawing.Point(54, 42)
        Costomer_IDLabel.Name = "Costomer_IDLabel"
        Costomer_IDLabel.Size = New System.Drawing.Size(71, 13)
        Costomer_IDLabel.TabIndex = 2
        Costomer_IDLabel.Text = "Customer ID:"
        '
        'Costomer_CategoryLabel
        '
        Costomer_CategoryLabel.AutoSize = True
        Costomer_CategoryLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_CategoryLabel.Location = New System.Drawing.Point(20, 65)
        Costomer_CategoryLabel.Name = "Costomer_CategoryLabel"
        Costomer_CategoryLabel.Size = New System.Drawing.Size(105, 13)
        Costomer_CategoryLabel.TabIndex = 3
        Costomer_CategoryLabel.Text = "Customer Category:"
        '
        'Costomer_NameLabel
        '
        Costomer_NameLabel.AutoSize = True
        Costomer_NameLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_NameLabel.Location = New System.Drawing.Point(38, 88)
        Costomer_NameLabel.Name = "Costomer_NameLabel"
        Costomer_NameLabel.Size = New System.Drawing.Size(87, 13)
        Costomer_NameLabel.TabIndex = 5
        Costomer_NameLabel.Text = "Customer Name:"
        '
        'Joining_DateLabel
        '
        Joining_DateLabel.AutoSize = True
        Joining_DateLabel.BackColor = System.Drawing.Color.Transparent
        Joining_DateLabel.Location = New System.Drawing.Point(55, 112)
        Joining_DateLabel.Name = "Joining_DateLabel"
        Joining_DateLabel.Size = New System.Drawing.Size(70, 13)
        Joining_DateLabel.TabIndex = 7
        Joining_DateLabel.Text = "Joining Date:"
        '
        'Advance_FeesLabel
        '
        Advance_FeesLabel.AutoSize = True
        Advance_FeesLabel.BackColor = System.Drawing.Color.Transparent
        Advance_FeesLabel.Location = New System.Drawing.Point(11, 135)
        Advance_FeesLabel.Name = "Advance_FeesLabel"
        Advance_FeesLabel.Size = New System.Drawing.Size(114, 13)
        Advance_FeesLabel.TabIndex = 9
        Advance_FeesLabel.Text = "Setup/Initial Payment:"
        '
        'Costomer_ImageLabel
        '
        Costomer_ImageLabel.AutoSize = True
        Costomer_ImageLabel.BackColor = System.Drawing.Color.Transparent
        Costomer_ImageLabel.Location = New System.Drawing.Point(563, 38)
        Costomer_ImageLabel.Name = "Costomer_ImageLabel"
        Costomer_ImageLabel.Size = New System.Drawing.Size(90, 13)
        Costomer_ImageLabel.TabIndex = 11
        Costomer_ImageLabel.Text = "Customer Image:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(760, 22)
        Me.ToolStripLabel1.Text = "DVD INFORMATIONS"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "X"
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Costomer_InfBindingSource
        '
        Me.Costomer_InfBindingSource.AllowNew = False
        Me.Costomer_InfBindingSource.DataMember = "Costomer_Inf"
        Me.Costomer_InfBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'Costomer_IDLabel1
        '
        Me.Costomer_IDLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Costomer_IDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Costomer_IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Costomer_ID", True))
        Me.Costomer_IDLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costomer_IDLabel1.Location = New System.Drawing.Point(131, 38)
        Me.Costomer_IDLabel1.Name = "Costomer_IDLabel1"
        Me.Costomer_IDLabel1.Size = New System.Drawing.Size(427, 23)
        Me.Costomer_IDLabel1.TabIndex = 3
        Me.Costomer_IDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Costomer_CategoryLabel1
        '
        Me.Costomer_CategoryLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Costomer_CategoryLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Costomer_CategoryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Costomer_Category", True))
        Me.Costomer_CategoryLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costomer_CategoryLabel1.Location = New System.Drawing.Point(131, 61)
        Me.Costomer_CategoryLabel1.Name = "Costomer_CategoryLabel1"
        Me.Costomer_CategoryLabel1.Size = New System.Drawing.Size(427, 23)
        Me.Costomer_CategoryLabel1.TabIndex = 4
        Me.Costomer_CategoryLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Costomer_NameLabel1
        '
        Me.Costomer_NameLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Costomer_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Costomer_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Costomer_Name", True))
        Me.Costomer_NameLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costomer_NameLabel1.Location = New System.Drawing.Point(131, 84)
        Me.Costomer_NameLabel1.Name = "Costomer_NameLabel1"
        Me.Costomer_NameLabel1.Size = New System.Drawing.Size(427, 23)
        Me.Costomer_NameLabel1.TabIndex = 6
        Me.Costomer_NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Joining_DateLabel1
        '
        Me.Joining_DateLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Joining_DateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Joining_DateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Joining_Date", True))
        Me.Joining_DateLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Joining_DateLabel1.Location = New System.Drawing.Point(131, 107)
        Me.Joining_DateLabel1.Name = "Joining_DateLabel1"
        Me.Joining_DateLabel1.Size = New System.Drawing.Size(427, 23)
        Me.Joining_DateLabel1.TabIndex = 8
        Me.Joining_DateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Advance_FeesLabel1
        '
        Me.Advance_FeesLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Advance_FeesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Advance_FeesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Costomer_InfBindingSource, "Advance_Fees", True))
        Me.Advance_FeesLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Advance_FeesLabel1.Location = New System.Drawing.Point(131, 130)
        Me.Advance_FeesLabel1.Name = "Advance_FeesLabel1"
        Me.Advance_FeesLabel1.Size = New System.Drawing.Size(427, 23)
        Me.Advance_FeesLabel1.TabIndex = 10
        Me.Advance_FeesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Costomer_ImagePictureBox
        '
        Me.Costomer_ImagePictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Costomer_ImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Costomer_ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Costomer_ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Costomer_InfBindingSource, "Costomer_Image", True))
        Me.Costomer_ImagePictureBox.Location = New System.Drawing.Point(659, 38)
        Me.Costomer_ImagePictureBox.Name = "Costomer_ImagePictureBox"
        Me.Costomer_ImagePictureBox.Size = New System.Drawing.Size(121, 115)
        Me.Costomer_ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Costomer_ImagePictureBox.TabIndex = 12
        Me.Costomer_ImagePictureBox.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(792, 214)
        Me.DataGridView1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(131, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(236, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Current Customer Movies"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(398, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 21)
        Me.TextBox1.TabIndex = 16
        '
        'DVDViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 399)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Costomer_ImageLabel)
        Me.Controls.Add(Me.Costomer_ImagePictureBox)
        Me.Controls.Add(Advance_FeesLabel)
        Me.Controls.Add(Me.Advance_FeesLabel1)
        Me.Controls.Add(Joining_DateLabel)
        Me.Controls.Add(Me.Joining_DateLabel1)
        Me.Controls.Add(Costomer_NameLabel)
        Me.Controls.Add(Me.Costomer_NameLabel1)
        Me.Controls.Add(Costomer_CategoryLabel)
        Me.Controls.Add(Me.Costomer_CategoryLabel1)
        Me.Controls.Add(Costomer_IDLabel)
        Me.Controls.Add(Me.Costomer_IDLabel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DVDViewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Costomers DVD Informations View"
        Me.TopMost = True
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Costomer_InfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Costomer_ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents Costomer_InfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Costomer_IDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Costomer_CategoryLabel1 As System.Windows.Forms.Label
    Friend WithEvents Costomer_NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Joining_DateLabel1 As System.Windows.Forms.Label
    Friend WithEvents Advance_FeesLabel1 As System.Windows.Forms.Label
    Friend WithEvents Costomer_ImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
