Public Class ViewInf
    'Friend DvDPro As New AukDatabaseDataSet.DVD_PROFITDataTable
    'Friend DvDView1 As New AukDatabaseDataSet.DVDVIEWDataTable
    'Friend DvDView2 As New AukDatabaseDataSet.DVD_View2DataTable
    Private Sub ViewInf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet1.DVD_View2' table. You can move, or remove it, as needed.
        Me.DVD_View2TableAdapter1.Fill(Me.AukDatabaseDataSet1.DVD_View2)
        Me.DateTimePicker1.Value = Now.Date
        Me.DISTANSE(7)
    End Sub
    Public Function DvD_IDFind1_View1(ByVal Field As Integer, ByVal WhatEqual As String)
        'SFC(Me.DvDView1.Columns(Field).ColumnName.ToString)
        'STC(WhatEqual)
        'If Me.DvDView1.Columns(Field).DataType.ToString.ToLower = "system.datetime" Then
        '    STC("#" & WhatEqual & "#")
        '    'MsgBox("a")

        '    EPC("=")
        'Else
        '    STC(WhatEqual)
        'End If
        'AukF.Db_Load("*", "DVD_VIEW", Me.DvDView1, True, "[Movie Name]", False, False, Val(My.Settings.MaximumData_load))
        'DvDPro.Clear()
        'DvDView2.Clear()
        'Me.DataGrid1.DataSource = Me.DvDView1
        SoftIn.BindFilterByAdvanceCategory(Me.DVDVIEWBindingSource1, Me.AukDatabaseDataSet.DVDVIEW.Columns(Field).ColumnName.ToString, WhatEqual, True, False, False, "=", False)
        AukF.DataTableFilter(Me.DVDVIEWBindingSource1, True, False, True, True, Val(My.Settings.MaximumData_load))
        Me.DataGrid1.DataSource = Me.DVDVIEWBindingSource1

    End Function
    Public Function DvD_IDFind1_View2(ByVal Field As Integer, ByVal WhatEqual As String)
        'SFC(Me.DvDView2.Columns(Field).ColumnName.ToString)
        'STC(WhatEqual)
        'If Me.DvDView2.Columns(Field).DataType.ToString.ToLower = "system.datetime" Then
        '    STC("#" & WhatEqual & "#")
        '    'MsgBox("a")

        '    EPC("=")
        'Else
        '    STC(WhatEqual)
        'End If
        'AukF.Db_Load("*", "DVD_VIEW2", Me.DvDView2, True, "[Movie Name]", False, False, Val(My.Settings.MaximumData_load))
        'DvDPro.Clear()
        'DvDView1.Clear()
        'Me.DataGrid1.DataSource = Me.DvDView2
        SoftIn.BindFilterByAdvanceCategory(Me.DVD_View2BindingSource1, Me.AukDatabaseDataSet.DVD_View2.Columns(Field).ColumnName.ToString, WhatEqual, True, False, False, "=", False)
        AukF.DataTableFilter(Me.DVD_View2BindingSource1, True, False, True, True, Val(My.Settings.MaximumData_load))
        Me.DataGrid1.DataSource = Me.DVD_View2BindingSource1

    End Function
    Public Function DvD_IDFind1_Profit(ByVal Field As Integer, ByVal WhatEqual As String)

        'SFC(Me.DvDPro.Columns(Field).ColumnName.ToString)

        'If Me.DvDPro.Columns(Field).DataType.ToString.ToLower = "system.datetime" Then
        '    STC("#" & WhatEqual & "#")
        '    'MsgBox("a")

        '    EPC("=")
        'Else
        '    STC(WhatEqual)
        'End If
        'AukF.Db_Load("*", "DVD_PROFIT", Me.DvDPro, True, "[MOVIE NAME]", False, False, Val(My.Settings.MaximumData_load))
        'DvDView2.Clear()
        'DvDView1.Clear()
        'Me.DataGrid1.DataSource = Me.DvDPro
        SoftIn.BindFilterByAdvanceCategory(Me.DVD_PROFITBindingSource1, Me.AukDatabaseDataSet.DVD_PROFIT.Columns(Field).ColumnName.ToString, WhatEqual, True, False, False, "=", False)
        AukF.DataTableFilter(Me.DVD_PROFITBindingSource1, True, False, True, True, Val(My.Settings.MaximumData_load))
        Me.DataGrid1.DataSource = Me.DVD_PROFITBindingSource1

    End Function

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DAYSDISTANCEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAYSDISTANCEToolStripMenuItem1.Click

    End Sub
    Public Function DISTANSE(ByVal DAYS As Double)
        Dim D1 As Date = Me.DateTimePicker1.Value.Date
        Me.DateTimePicker2.Value = D1.AddDays(DAYS)
    End Function

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If Me.ALSOSETONEDAYDISTANCEWHENCHANGEFIRSTONEDATEToolStripMenuItem.Checked = True Then
            Me.DISTANSE(7)

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If CHKTXT(Me.TextBox1) = True Then
            Me.DvD_IDFind1_View1(QA1, QA2)
        Else
            Me.DvD_IDFind1_View1(0, Me.TextBox1.Text)
        End If
    End Sub
    Public Function CHKTXT(ByVal TEXTBOX1 As TextBox) As Boolean
        If InStr(TEXTBOX1.Text, "=", CompareMethod.Text) <> 0 Then

            AukF.DivideIn_To_2(TEXTBOX1.Text, "=", False, S1, S2)
            CHKTXT = True
        Else
            CHKTXT = False

        End If
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If CHKTXT(Me.TextBox2) = True Then
            Me.DvD_IDFind1_View2(QA1, QA2)
        Else
            Me.DvD_IDFind1_View2(0, Me.TextBox2.Text)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DvD_IDFind1_Profit(23, 0)

        'MsgBox(Sql)

    End Sub

    Private Sub ViewTheFormatOfProfitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTheFormatOfProfitToolStripMenuItem.Click
        ShowFormat("DVD_PROFIT")

    End Sub
    Public Function ShowFormat(ByVal TableName As String)
        Dim Str1 As String = ""

        For k As Integer = 0 To Me.AukDatabaseDataSet.Tables(TableName).Columns.Count - 1
            a1 = k
            a2 = Me.AukDatabaseDataSet.Tables(TableName).Columns(k).ColumnName.ToString
            a3 = Me.AukDatabaseDataSet.Tables(TableName).Columns(k).DataType.ToString
            If Str1 = "" Then
                Str1 = a1 & " -ColumnName:( " & a2 & ") -DataType(" & a3 & ")"
            Else
                Str1 = Str1 & vbCrLf & a1 & " -ColumnName:( " & a2 & ") -DataType(" & a3 & ")"

            End If
        Next
        MsgBox(Str1, MsgBoxStyle.Information, TableName & " -Formats")

    End Function

    Private Sub ViewTheFormatOfDataView1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTheFormatOfDataView1ToolStripMenuItem.Click
        ShowFormat("DVDView")

    End Sub

    Private Sub ViewTheFormatOfDataView2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewTheFormatOfDataView2ToolStripMenuItem.Click
        ShowFormat("DVD_View2")

    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class