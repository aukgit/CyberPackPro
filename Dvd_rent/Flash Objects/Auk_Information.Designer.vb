<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auk_Information
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Auk_Information))
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 0)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(445, 358)
        Me.AxShockwaveFlash1.TabIndex = 0
        '
        'Auk_Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 358)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Auk_Information"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auk_Information"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash

    Public Sub New()
        Try
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.
        Catch ex As Exception
            MsgBox("Flash 8 ActiveX is not installed Correctly.You may have to install this in order to run CyberPack Pro Animated view.", MsgBoxStyle.Information)
            AukF.OExe(AppPath & "\CheckSoft.exe", Me)
            AukF.OExe(AppPath & "\Install Flash Player 8 ActiveX.msi", Me)
            MsgBox("After Installing Flash 8 ActiveX please restart the soft", MsgBoxStyle.Information)
            Try
                Shell(AppPath & "\CheckSoft.exe")
            Catch exx As Exception
                MsgBox("Some files are missing,Please Conatact with Auk. You tried to delete software executeable file.", MsgBoxStyle.Critical)
                SrGens.Make_Corrupt(1)
                SOFTCLOSE()
            End Try
        End Try
 

    End Sub
End Class
