<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeesPaid
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
        Dim Cyber_MemberIDLabel As System.Windows.Forms.Label
        Dim Cyber_Member_NameLabel As System.Windows.Forms.Label
        Dim Member_Charge_MonthlyLabel As System.Windows.Forms.Label
        Dim Advance_FeesLabel As System.Windows.Forms.Label
        Dim Monthly_Fees_Paid_DateLabel As System.Windows.Forms.Label
        Dim MonthlyFees_PaidLabel As System.Windows.Forms.Label
        Dim MonthlyFess_DueLabel As System.Windows.Forms.Label
        Dim CommentsLabel1 As System.Windows.Forms.Label
        Me.Cyber_MemberIDTextBox = New System.Windows.Forms.TextBox
        Me.Cyber_Member_NameTextBox = New System.Windows.Forms.TextBox
        Me.Cyber_MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AukDatabaseDataSet = New CyberPack_Pro.AukDatabaseDataSet
        Me.Member_Charge_MonthlyTextBox = New System.Windows.Forms.TextBox
        Me.Advance_FeesTextBox = New System.Windows.Forms.TextBox
        Me.Monthly_Fees_Paid_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.MonthlyFees_PaidTextBox = New System.Windows.Forms.TextBox
        Me.MonthlyFess_DueTextBox = New System.Windows.Forms.TextBox
        Me.CommentsTextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Cyber_MemberTableAdapter = New CyberPack_Pro.AukDatabaseDataSetTableAdapters.Cyber_MemberTableAdapter
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Cyber_MemberIDLabel = New System.Windows.Forms.Label
        Cyber_Member_NameLabel = New System.Windows.Forms.Label
        Member_Charge_MonthlyLabel = New System.Windows.Forms.Label
        Advance_FeesLabel = New System.Windows.Forms.Label
        Monthly_Fees_Paid_DateLabel = New System.Windows.Forms.Label
        MonthlyFees_PaidLabel = New System.Windows.Forms.Label
        MonthlyFess_DueLabel = New System.Windows.Forms.Label
        CommentsLabel1 = New System.Windows.Forms.Label
        CType(Me.Cyber_MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cyber_MemberIDLabel
        '
        Cyber_MemberIDLabel.AutoSize = True
        Cyber_MemberIDLabel.BackColor = System.Drawing.Color.Transparent
        Cyber_MemberIDLabel.Location = New System.Drawing.Point(98, 65)
        Cyber_MemberIDLabel.Name = "Cyber_MemberIDLabel"
        Cyber_MemberIDLabel.Size = New System.Drawing.Size(70, 15)
        Cyber_MemberIDLabel.TabIndex = 1
        Cyber_MemberIDLabel.Text = "Member ID:"
        '
        'Cyber_Member_NameLabel
        '
        Cyber_Member_NameLabel.AutoSize = True
        Cyber_Member_NameLabel.BackColor = System.Drawing.Color.Transparent
        Cyber_Member_NameLabel.Location = New System.Drawing.Point(79, 96)
        Cyber_Member_NameLabel.Name = "Cyber_Member_NameLabel"
        Cyber_Member_NameLabel.Size = New System.Drawing.Size(89, 15)
        Cyber_Member_NameLabel.TabIndex = 3
        Cyber_Member_NameLabel.Text = "Member Name:"
        '
        'Member_Charge_MonthlyLabel
        '
        Member_Charge_MonthlyLabel.AutoSize = True
        Member_Charge_MonthlyLabel.BackColor = System.Drawing.Color.Transparent
        Member_Charge_MonthlyLabel.Location = New System.Drawing.Point(23, 158)
        Member_Charge_MonthlyLabel.Name = "Member_Charge_MonthlyLabel"
        Member_Charge_MonthlyLabel.Size = New System.Drawing.Size(145, 15)
        Member_Charge_MonthlyLabel.TabIndex = 9
        Member_Charge_MonthlyLabel.Text = "Member Charge Monthly:"
        '
        'Advance_FeesLabel
        '
        Advance_FeesLabel.AutoSize = True
        Advance_FeesLabel.BackColor = System.Drawing.Color.Transparent
        Advance_FeesLabel.Location = New System.Drawing.Point(47, 190)
        Advance_FeesLabel.Name = "Advance_FeesLabel"
        Advance_FeesLabel.Size = New System.Drawing.Size(121, 15)
        Advance_FeesLabel.TabIndex = 11
        Advance_FeesLabel.Text = "Advance/Initial Fees:"
        '
        'Monthly_Fees_Paid_DateLabel
        '
        Monthly_Fees_Paid_DateLabel.AutoSize = True
        Monthly_Fees_Paid_DateLabel.BackColor = System.Drawing.Color.Transparent
        Monthly_Fees_Paid_DateLabel.Location = New System.Drawing.Point(29, 128)
        Monthly_Fees_Paid_DateLabel.Name = "Monthly_Fees_Paid_DateLabel"
        Monthly_Fees_Paid_DateLabel.Size = New System.Drawing.Size(139, 15)
        Monthly_Fees_Paid_DateLabel.TabIndex = 16
        Monthly_Fees_Paid_DateLabel.Text = "Monthly Fees Paid Date:"
        '
        'MonthlyFees_PaidLabel
        '
        MonthlyFees_PaidLabel.AutoSize = True
        MonthlyFees_PaidLabel.BackColor = System.Drawing.Color.Transparent
        MonthlyFees_PaidLabel.Location = New System.Drawing.Point(57, 220)
        MonthlyFees_PaidLabel.Name = "MonthlyFees_PaidLabel"
        MonthlyFees_PaidLabel.Size = New System.Drawing.Size(111, 15)
        MonthlyFees_PaidLabel.TabIndex = 17
        MonthlyFees_PaidLabel.Text = "Monthly Fees Paid:"
        '
        'MonthlyFess_DueLabel
        '
        MonthlyFess_DueLabel.AutoSize = True
        MonthlyFess_DueLabel.BackColor = System.Drawing.Color.Transparent
        MonthlyFess_DueLabel.Location = New System.Drawing.Point(61, 252)
        MonthlyFess_DueLabel.Name = "MonthlyFess_DueLabel"
        MonthlyFess_DueLabel.Size = New System.Drawing.Size(107, 15)
        MonthlyFess_DueLabel.TabIndex = 18
        MonthlyFess_DueLabel.Text = "Monthly Fess Due:"
        '
        'CommentsLabel1
        '
        CommentsLabel1.AutoSize = True
        CommentsLabel1.BackColor = System.Drawing.Color.Transparent
        CommentsLabel1.Location = New System.Drawing.Point(101, 283)
        CommentsLabel1.Name = "CommentsLabel1"
        CommentsLabel1.Size = New System.Drawing.Size(67, 15)
        CommentsLabel1.TabIndex = 19
        CommentsLabel1.Text = "Comments:"
        '
        'Cyber_MemberIDTextBox
        '
        Me.Cyber_MemberIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cyber_MemberIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cyber_MemberIDTextBox.Location = New System.Drawing.Point(180, 63)
        Me.Cyber_MemberIDTextBox.Name = "Cyber_MemberIDTextBox"
        Me.Cyber_MemberIDTextBox.ShortcutsEnabled = False
        Me.Cyber_MemberIDTextBox.Size = New System.Drawing.Size(340, 23)
        Me.Cyber_MemberIDTextBox.TabIndex = 0
        Me.Cyber_MemberIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cyber_Member_NameTextBox
        '
        Me.Cyber_Member_NameTextBox.BackColor = System.Drawing.Color.White
        Me.Cyber_Member_NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cyber_Member_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cyber_MemberBindingSource, "Cyber_Member_Name", True))
        Me.Cyber_Member_NameTextBox.Location = New System.Drawing.Point(180, 92)
        Me.Cyber_Member_NameTextBox.Name = "Cyber_Member_NameTextBox"
        Me.Cyber_Member_NameTextBox.ReadOnly = True
        Me.Cyber_Member_NameTextBox.Size = New System.Drawing.Size(340, 23)
        Me.Cyber_Member_NameTextBox.TabIndex = 1
        Me.Cyber_Member_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cyber_MemberBindingSource
        '
        Me.Cyber_MemberBindingSource.DataMember = "Cyber_Member"
        Me.Cyber_MemberBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Member_Charge_MonthlyTextBox
        '
        Me.Member_Charge_MonthlyTextBox.Location = New System.Drawing.Point(180, 155)
        Me.Member_Charge_MonthlyTextBox.Name = "Member_Charge_MonthlyTextBox"
        Me.Member_Charge_MonthlyTextBox.Size = New System.Drawing.Size(340, 23)
        Me.Member_Charge_MonthlyTextBox.TabIndex = 3
        Me.Member_Charge_MonthlyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Advance_FeesTextBox
        '
        Me.Advance_FeesTextBox.BackColor = System.Drawing.Color.White
        Me.Advance_FeesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Advance_FeesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cyber_MemberBindingSource, "Advance_Fees", True))
        Me.Advance_FeesTextBox.Location = New System.Drawing.Point(180, 186)
        Me.Advance_FeesTextBox.Name = "Advance_FeesTextBox"
        Me.Advance_FeesTextBox.ReadOnly = True
        Me.Advance_FeesTextBox.Size = New System.Drawing.Size(340, 23)
        Me.Advance_FeesTextBox.TabIndex = 4
        Me.Advance_FeesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Monthly_Fees_Paid_DateDateTimePicker
        '
        Me.Monthly_Fees_Paid_DateDateTimePicker.Location = New System.Drawing.Point(180, 123)
        Me.Monthly_Fees_Paid_DateDateTimePicker.Name = "Monthly_Fees_Paid_DateDateTimePicker"
        Me.Monthly_Fees_Paid_DateDateTimePicker.Size = New System.Drawing.Size(340, 23)
        Me.Monthly_Fees_Paid_DateDateTimePicker.TabIndex = 2
        '
        'MonthlyFees_PaidTextBox
        '
        Me.MonthlyFees_PaidTextBox.Location = New System.Drawing.Point(180, 217)
        Me.MonthlyFees_PaidTextBox.Name = "MonthlyFees_PaidTextBox"
        Me.MonthlyFees_PaidTextBox.Size = New System.Drawing.Size(340, 23)
        Me.MonthlyFees_PaidTextBox.TabIndex = 7
        Me.MonthlyFees_PaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MonthlyFess_DueTextBox
        '
        Me.MonthlyFess_DueTextBox.Location = New System.Drawing.Point(180, 248)
        Me.MonthlyFess_DueTextBox.Name = "MonthlyFess_DueTextBox"
        Me.MonthlyFess_DueTextBox.Size = New System.Drawing.Size(340, 23)
        Me.MonthlyFess_DueTextBox.TabIndex = 8
        Me.MonthlyFess_DueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CommentsTextBox1
        '
        Me.CommentsTextBox1.Location = New System.Drawing.Point(180, 279)
        Me.CommentsTextBox1.Name = "CommentsTextBox1"
        Me.CommentsTextBox1.Size = New System.Drawing.Size(340, 23)
        Me.CommentsTextBox1.TabIndex = 9
        Me.CommentsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "BRAODBAND CLIENTS MONTHLY FEES"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.__
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(177, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(343, 24)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "&Submit<This Month> Fees"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(177, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(343, 24)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "&Remove this MonthFees"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(544, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Information(Press Enter on MemberID to See the Paids)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(177, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(343, 24)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "&Check Month Fees"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Cyber_MemberTableAdapter
        '
        Me.Cyber_MemberTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'FeesPaid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CyberPack_Pro.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(544, 444)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(CommentsLabel1)
        Me.Controls.Add(Me.CommentsTextBox1)
        Me.Controls.Add(MonthlyFess_DueLabel)
        Me.Controls.Add(Me.MonthlyFess_DueTextBox)
        Me.Controls.Add(MonthlyFees_PaidLabel)
        Me.Controls.Add(Me.MonthlyFees_PaidTextBox)
        Me.Controls.Add(Monthly_Fees_Paid_DateLabel)
        Me.Controls.Add(Me.Monthly_Fees_Paid_DateDateTimePicker)
        Me.Controls.Add(Cyber_MemberIDLabel)
        Me.Controls.Add(Me.Cyber_MemberIDTextBox)
        Me.Controls.Add(Cyber_Member_NameLabel)
        Me.Controls.Add(Me.Cyber_Member_NameTextBox)
        Me.Controls.Add(Member_Charge_MonthlyLabel)
        Me.Controls.Add(Me.Member_Charge_MonthlyTextBox)
        Me.Controls.Add(Advance_FeesLabel)
        Me.Controls.Add(Me.Advance_FeesTextBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FeesPaid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BroadBand Clients Monthly Charge Paid"
        CType(Me.Cyber_MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cyber_MemberIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cyber_Member_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Member_Charge_MonthlyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Advance_FeesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Monthly_Fees_Paid_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MonthlyFees_PaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MonthlyFess_DueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommentsTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AukDatabaseDataSet As CyberPack_Pro.AukDatabaseDataSet
    Friend WithEvents Cyber_MemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cyber_MemberTableAdapter As CyberPack_Pro.AukDatabaseDataSetTableAdapters.Cyber_MemberTableAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
