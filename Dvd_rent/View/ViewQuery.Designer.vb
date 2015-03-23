<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewQuery
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
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.BackColor = System.Drawing.Color.White
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.Black
        Me.DataGrid1.CaptionText = "ViewQuery"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.LinkColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 220
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGrid1.Size = New System.Drawing.Size(692, 516)
        Me.DataGrid1.TabIndex = 0
        '
        'ViewQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 516)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "ViewQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewQuery"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
End Class
