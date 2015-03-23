<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DVDRENT_ADMIN
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.DVD_RentDeletedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DVD_RentDeletedTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.DVD_RentDeletedTableAdapter
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVD_RentDeletedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Keep Deleted Rows For "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "days."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(307, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Show Deleted Rows"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(17, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(307, 29)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Save Settings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = Global.CyberPack_Pro.My.MySettings.Default.Dont_DeleteDVDRentDeleted
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "Dont_DeleteDVDRentDeleted", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(17, 153)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(225, 19)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "Do not Delete Information Automatic"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = Global.CyberPack_Pro.My.MySettings.Default.DVDOpt_PasswordDelRows
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.CyberPack_Pro.My.MySettings.Default, "DVDOpt_PasswordDelRows", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(17, 175)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(158, 19)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Use To Access Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CyberPack_Pro.My.MySettings.Default, "DVOpt_DelRowsKeep", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(164, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(111, 23)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = Global.CyberPack_Pro.My.MySettings.Default.DVOpt_DelRowsKeep
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(17, 118)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(307, 29)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = " Delete Before Records"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DVD_RentDeletedBindingSource
        '
        Me.DVD_RentDeletedBindingSource.DataMember = "DVD_RentDeleted"
        Me.DVD_RentDeletedBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'DVD_RentDeletedTableAdapter
        '
        Me.DVD_RentDeletedTableAdapter.ClearBeforeFill = True
        '
        'DVDRENT_ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 202)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DVDRENT_ADMIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DVDRENT DELETE ROW OPTIONS"
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVD_RentDeletedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents DVD_RentDeletedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DVD_RentDeletedTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.DVD_RentDeletedTableAdapter
End Class
