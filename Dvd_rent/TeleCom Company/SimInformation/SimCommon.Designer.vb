<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimCommon
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
        Dim Category_IDLabel As System.Windows.Forms.Label
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.SimCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimCategoryTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.SimCategoryTableAdapter
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Category_IDTextBox = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Category_IDLabel = New System.Windows.Forms.Label
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Category_IDLabel
        '
        Category_IDLabel.AutoSize = True
        Category_IDLabel.Location = New System.Drawing.Point(79, 66)
        Category_IDLabel.Name = "Category_IDLabel"
        Category_IDLabel.Size = New System.Drawing.Size(73, 15)
        Category_IDLabel.TabIndex = 1
        Category_IDLabel.Text = "Company ID"
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SimCategoryBindingSource
        '
        Me.SimCategoryBindingSource.DataMember = "SimCategory"
        Me.SimCategoryBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'SimCategoryTableAdapter
        '
        Me.SimCategoryTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.SimCategoryBindingSource
        Me.ComboBox1.DisplayMember = "SimCategory"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(155, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(224, 23)
        Me.ComboBox1.TabIndex = 3
        '
        'Category_IDTextBox
        '
        Me.Category_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SimCategoryBindingSource, "Category_ID", True))
        Me.Category_IDTextBox.Location = New System.Drawing.Point(155, 62)
        Me.Category_IDTextBox.Name = "Category_IDTextBox"
        Me.Category_IDTextBox.ReadOnly = True
        Me.Category_IDTextBox.Size = New System.Drawing.Size(224, 23)
        Me.Category_IDTextBox.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(29, 37)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 19)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Sim Category"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(155, 91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 23)
        Me.TextBox1.TabIndex = 6
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(29, 91)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(123, 19)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Purchase Cost"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.Location = New System.Drawing.Point(29, 149)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(123, 19)
        Me.CheckBox4.TabIndex = 9
        Me.CheckBox4.Text = "Purchase Date"
        Me.CheckBox4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(155, 118)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(224, 23)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(155, 145)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(224, 23)
        Me.TextBox3.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 22)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Entry Common"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 200)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(391, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Selling Price"
        '
        'SimCommon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 223)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Category_IDLabel)
        Me.Controls.Add(Me.Category_IDTextBox)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "SimCommon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Common Entry"
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents SimCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SimCategoryTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.SimCategoryTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Category_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
