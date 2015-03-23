<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FilterReportFieldsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.AutoSize = True
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(763, 584)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterReportFieldsToolStripMenuItem, Me.RemoveFilterToolStripMenuItem, Me.CloseReportToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(203, 70)
        '
        'FilterReportFieldsToolStripMenuItem
        '
        Me.FilterReportFieldsToolStripMenuItem.Name = "FilterReportFieldsToolStripMenuItem"
        Me.FilterReportFieldsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FilterReportFieldsToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.FilterReportFieldsToolStripMenuItem.Text = "Filter Report Fields"
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "Remove Filter"
        '
        'CloseReportToolStripMenuItem
        '
        Me.CloseReportToolStripMenuItem.Name = "CloseReportToolStripMenuItem"
        Me.CloseReportToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.CloseReportToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.CloseReportToolStripMenuItem.Text = "Close Report"
        '
        'Reports
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(763, 584)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CyberPack Pro Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FilterReportFieldsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
