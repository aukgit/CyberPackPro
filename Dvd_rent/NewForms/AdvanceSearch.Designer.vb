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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvanceSearch))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.All_AcceptType = New System.Windows.Forms.CheckBox
        Me.AdTypeChk = New System.Windows.Forms.CheckBox
        Me.AdvanceSrType_ChkToDO = New System.Windows.Forms.CheckBox
        Me.BasicTypeSr = New System.Windows.Forms.TextBox
        Me.AdvanceTypeSr = New System.Windows.Forms.TextBox
        Me.bsTYChk = New System.Windows.Forms.CheckBox
        Me.TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AukDatabaseDataSet = New CYBERPACK_PRO.AukDatabaseDataSet
        Me.TypeTableAdapter = New CYBERPACK_PRO.AukDatabaseDataSetTableAdapters.TypeTableAdapter
        Me.TypeSearch_Group = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.AdvanceExtra_ChkToDO = New System.Windows.Forms.CheckBox
        Me.MovNameAnywhereChk = New System.Windows.Forms.CheckBox
        Me.PlaceCombo = New System.Windows.Forms.ComboBox
        Me.MovVersionSr = New System.Windows.Forms.TextBox
        Me.Movie_nameSr = New System.Windows.Forms.TextBox
        Me.PlaceChk = New System.Windows.Forms.CheckBox
        Me.MovVerChk = New System.Windows.Forms.CheckBox
        Me.MovNameChk = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.ExtraSearchOptionGroup = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.All_AcceptType)
        Me.GroupBox1.Controls.Add(Me.AdTypeChk)
        Me.GroupBox1.Controls.Add(Me.AdvanceSrType_ChkToDO)
        Me.GroupBox1.Controls.Add(Me.BasicTypeSr)
        Me.GroupBox1.Controls.Add(Me.AdvanceTypeSr)
        Me.GroupBox1.Controls.Add(Me.bsTYChk)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 106)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advance Movie Type Search"
        '
        'All_AcceptType
        '
        Me.All_AcceptType.Appearance = System.Windows.Forms.Appearance.Button
        Me.All_AcceptType.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Resources.Crystal1
        Me.All_AcceptType.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.All_AcceptType.Checked = True
        Me.All_AcceptType.CheckState = System.Windows.Forms.CheckState.Checked
        Me.All_AcceptType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.All_AcceptType.Location = New System.Drawing.Point(267, 78)
        Me.All_AcceptType.Name = "All_AcceptType"
        Me.All_AcceptType.Size = New System.Drawing.Size(165, 22)
        Me.All_AcceptType.TabIndex = 9
        Me.All_AcceptType.Text = "EXACT MATCH ENABLE"
        Me.All_AcceptType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.All_AcceptType.UseVisualStyleBackColor = True
        '
        'AdTypeChk
        '
        Me.AdTypeChk.AutoSize = True
        Me.AdTypeChk.Checked = True
        Me.AdTypeChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AdTypeChk.Location = New System.Drawing.Point(8, 29)
        Me.AdTypeChk.Name = "AdTypeChk"
        Me.AdTypeChk.Size = New System.Drawing.Size(95, 17)
        Me.AdTypeChk.TabIndex = 8
        Me.AdTypeChk.Text = "Advance Type"
        Me.AdTypeChk.UseVisualStyleBackColor = True
        '
        'AdvanceSrType_ChkToDO
        '
        Me.AdvanceSrType_ChkToDO.Checked = True
        Me.AdvanceSrType_ChkToDO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AdvanceSrType_ChkToDO.Location = New System.Drawing.Point(114, 79)
        Me.AdvanceSrType_ChkToDO.Name = "AdvanceSrType_ChkToDO"
        Me.AdvanceSrType_ChkToDO.Size = New System.Drawing.Size(114, 21)
        Me.AdvanceSrType_ChkToDO.TabIndex = 7
        Me.AdvanceSrType_ChkToDO.Text = "Advance Search"
        Me.AdvanceSrType_ChkToDO.UseVisualStyleBackColor = True
        '
        'BasicTypeSr
        '
        Me.BasicTypeSr.Location = New System.Drawing.Point(114, 52)
        Me.BasicTypeSr.Name = "BasicTypeSr"
        Me.BasicTypeSr.Size = New System.Drawing.Size(320, 21)
        Me.BasicTypeSr.TabIndex = 2
        Me.BasicTypeSr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AdvanceTypeSr
        '
        Me.AdvanceTypeSr.Location = New System.Drawing.Point(114, 25)
        Me.AdvanceTypeSr.Name = "AdvanceTypeSr"
        Me.AdvanceTypeSr.Size = New System.Drawing.Size(320, 21)
        Me.AdvanceTypeSr.TabIndex = 1
        Me.AdvanceTypeSr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bsTYChk
        '
        Me.bsTYChk.AutoSize = True
        Me.bsTYChk.Checked = True
        Me.bsTYChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.bsTYChk.Location = New System.Drawing.Point(8, 52)
        Me.bsTYChk.Name = "bsTYChk"
        Me.bsTYChk.Size = New System.Drawing.Size(108, 17)
        Me.bsTYChk.TabIndex = 0
        Me.bsTYChk.Text = "Movie Basic Type"
        Me.bsTYChk.UseVisualStyleBackColor = True
        '
        'TypeBindingSource
        '
        Me.TypeBindingSource.DataMember = "Type"
        Me.TypeBindingSource.DataSource = Me.AukDatabaseDataSet
        '
        'AukDatabaseDataSet
        '
        Me.AukDatabaseDataSet.DataSetName = "AukDatabaseDataSet"
        Me.AukDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TypeTableAdapter
        '
        Me.TypeTableAdapter.ClearBeforeFill = True
        '
        'TypeSearch_Group
        '
        Me.TypeSearch_Group.Appearance = System.Windows.Forms.Appearance.Button
        Me.TypeSearch_Group.AutoSize = True
        Me.TypeSearch_Group.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Resources.Crystal1
        Me.TypeSearch_Group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TypeSearch_Group.Checked = True
        Me.TypeSearch_Group.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TypeSearch_Group.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TypeSearch_Group.Location = New System.Drawing.Point(25, 122)
        Me.TypeSearch_Group.Name = "TypeSearch_Group"
        Me.TypeSearch_Group.Size = New System.Drawing.Size(153, 23)
        Me.TypeSearch_Group.TabIndex = 1
        Me.TypeSearch_Group.Text = "Search Advance Movie Type"
        Me.TypeSearch_Group.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.AdvanceExtra_ChkToDO)
        Me.GroupBox2.Controls.Add(Me.MovNameAnywhereChk)
        Me.GroupBox2.Controls.Add(Me.PlaceCombo)
        Me.GroupBox2.Controls.Add(Me.MovVersionSr)
        Me.GroupBox2.Controls.Add(Me.Movie_nameSr)
        Me.GroupBox2.Controls.Add(Me.PlaceChk)
        Me.GroupBox2.Controls.Add(Me.MovVerChk)
        Me.GroupBox2.Controls.Add(Me.MovNameChk)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(454, 125)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Advance Query System(Extra MovieSearch)"
        '
        'AdvanceExtra_ChkToDO
        '
        Me.AdvanceExtra_ChkToDO.Checked = True
        Me.AdvanceExtra_ChkToDO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AdvanceExtra_ChkToDO.Location = New System.Drawing.Point(114, 98)
        Me.AdvanceExtra_ChkToDO.Name = "AdvanceExtra_ChkToDO"
        Me.AdvanceExtra_ChkToDO.Size = New System.Drawing.Size(320, 21)
        Me.AdvanceExtra_ChkToDO.TabIndex = 6
        Me.AdvanceExtra_ChkToDO.Text = "Advance Search"
        Me.AdvanceExtra_ChkToDO.UseVisualStyleBackColor = True
        '
        'MovNameAnywhereChk
        '
        Me.MovNameAnywhereChk.Appearance = System.Windows.Forms.Appearance.Button
        Me.MovNameAnywhereChk.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Resources.Crystal1
        Me.MovNameAnywhereChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MovNameAnywhereChk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MovNameAnywhereChk.Location = New System.Drawing.Point(357, 17)
        Me.MovNameAnywhereChk.Name = "MovNameAnywhereChk"
        Me.MovNameAnywhereChk.Size = New System.Drawing.Size(77, 23)
        Me.MovNameAnywhereChk.TabIndex = 5
        Me.MovNameAnywhereChk.Text = "AnyWhere"
        Me.MovNameAnywhereChk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MovNameAnywhereChk.UseVisualStyleBackColor = True
        '
        'PlaceCombo
        '
        Me.PlaceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlaceCombo.FormattingEnabled = True
        Me.PlaceCombo.Items.AddRange(New Object() {"InHand", "InStore", "Lost", "Broken", "Sold"})
        Me.PlaceCombo.Location = New System.Drawing.Point(114, 71)
        Me.PlaceCombo.Name = "PlaceCombo"
        Me.PlaceCombo.Size = New System.Drawing.Size(320, 21)
        Me.PlaceCombo.TabIndex = 3
        '
        'MovVersionSr
        '
        Me.MovVersionSr.AutoCompleteCustomSource.AddRange(New String() {"English+DVD", "Hindi+DVD", "Bangla+DVD", "English+CD", "Hindi+CD", "Bangla+CD", "SOFTWARE+CD", "SOFTWARE+DVD", "GAMES+CD", "GAMES+DVD", "MUSIC+CD", "MUSIC+DVD", "LEARNING+CD", "LEARNING+DVD"})
        Me.MovVersionSr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MovVersionSr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.MovVersionSr.Location = New System.Drawing.Point(114, 45)
        Me.MovVersionSr.Name = "MovVersionSr"
        Me.MovVersionSr.Size = New System.Drawing.Size(320, 21)
        Me.MovVersionSr.TabIndex = 4
        Me.MovVersionSr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Movie_nameSr
        '
        Me.Movie_nameSr.Location = New System.Drawing.Point(114, 19)
        Me.Movie_nameSr.Name = "Movie_nameSr"
        Me.Movie_nameSr.Size = New System.Drawing.Size(237, 21)
        Me.Movie_nameSr.TabIndex = 3
        Me.Movie_nameSr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlaceChk
        '
        Me.PlaceChk.Checked = True
        Me.PlaceChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PlaceChk.Location = New System.Drawing.Point(16, 73)
        Me.PlaceChk.Name = "PlaceChk"
        Me.PlaceChk.Size = New System.Drawing.Size(92, 17)
        Me.PlaceChk.TabIndex = 2
        Me.PlaceChk.Text = "Place"
        Me.PlaceChk.UseVisualStyleBackColor = True
        '
        'MovVerChk
        '
        Me.MovVerChk.Location = New System.Drawing.Point(16, 47)
        Me.MovVerChk.Name = "MovVerChk"
        Me.MovVerChk.Size = New System.Drawing.Size(92, 17)
        Me.MovVerChk.TabIndex = 1
        Me.MovVerChk.Text = "Movie Version"
        Me.MovVerChk.UseVisualStyleBackColor = True
        '
        'MovNameChk
        '
        Me.MovNameChk.Checked = True
        Me.MovNameChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MovNameChk.Location = New System.Drawing.Point(16, 20)
        Me.MovNameChk.Name = "MovNameChk"
        Me.MovNameChk.Size = New System.Drawing.Size(92, 24)
        Me.MovNameChk.TabIndex = 0
        Me.MovNameChk.Text = "Movie Name"
        Me.MovNameChk.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(382, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Open"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(279, 282)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "&Filter"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(176, 282)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "&Remove Filter"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ExtraSearchOptionGroup
        '
        Me.ExtraSearchOptionGroup.Appearance = System.Windows.Forms.Appearance.Button
        Me.ExtraSearchOptionGroup.AutoSize = True
        Me.ExtraSearchOptionGroup.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Resources.Crystal1
        Me.ExtraSearchOptionGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExtraSearchOptionGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExtraSearchOptionGroup.Location = New System.Drawing.Point(25, 282)
        Me.ExtraSearchOptionGroup.Name = "ExtraSearchOptionGroup"
        Me.ExtraSearchOptionGroup.Size = New System.Drawing.Size(116, 23)
        Me.ExtraSearchOptionGroup.TabIndex = 6
        Me.ExtraSearchOptionGroup.Text = "Movie Search Option"
        Me.ExtraSearchOptionGroup.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AdvanceSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CYBERPACK_PRO.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(493, 319)
        Me.Controls.Add(Me.ExtraSearchOptionGroup)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TypeSearch_Group)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "AdvanceSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdvanceSearch"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AukDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bsTYChk As System.Windows.Forms.CheckBox
    Friend WithEvents AdvanceTypeSr As System.Windows.Forms.TextBox
    Friend WithEvents AukDatabaseDataSet As CYBERPACK_PRO.AukDatabaseDataSet
    Friend WithEvents TypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypeTableAdapter As CYBERPACK_PRO.AukDatabaseDataSetTableAdapters.TypeTableAdapter
    Friend WithEvents TypeSearch_Group As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Movie_nameSr As System.Windows.Forms.TextBox
    Friend WithEvents PlaceChk As System.Windows.Forms.CheckBox
    Friend WithEvents MovVerChk As System.Windows.Forms.CheckBox
    Friend WithEvents MovNameChk As System.Windows.Forms.CheckBox
    Friend WithEvents MovVersionSr As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PlaceCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ExtraSearchOptionGroup As System.Windows.Forms.CheckBox
    Friend WithEvents MovNameAnywhereChk As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BasicTypeSr As System.Windows.Forms.TextBox
    Friend WithEvents AdvanceExtra_ChkToDO As System.Windows.Forms.CheckBox
    Friend WithEvents AdvanceSrType_ChkToDO As System.Windows.Forms.CheckBox
    Friend WithEvents AdTypeChk As System.Windows.Forms.CheckBox
    Friend WithEvents All_AcceptType As System.Windows.Forms.CheckBox
End Class
