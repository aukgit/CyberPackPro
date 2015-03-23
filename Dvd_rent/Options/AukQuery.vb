Public Class AukQ
    Public Bnp As BindingSource
    Public COL As Integer = -1
    Public dV As DataGridView = Nothing
    Dim T As DataTable
    Dim Ua2 As Array
    Public ADD_WITHFILTER As String = ""
    Public QExeCUTE As Boolean = True
    Dim S_Table As DataTable = Nothing
    Public SBp As BindingSource = Nothing
    'Public S_Table_CLR As Boolean = False
    Public S_TABLE_FUNC As Integer = 0
    Public S_Table_Open_Link_Field As String = Nothing
    Dim S_COLUMN() As String
    Public Exe_form As Object = Nothing
    Public OrderBy_Q As String = ""
    'ori firld name=ComboBox3.text
    Private Sub Product_qr_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.QueryTextBox.Focus()
    End Sub
    'Dim TM1 As DataTable = T
    Private Sub Product_qr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        T = AukF.Get_DataSystemObj(Bnp)
        AukF.ComSelIndex(Me.OperatorCombo)
        If ADD_WITHFILTER <> "" Then
            ADD_WITHFILTER = " AND ( " & ADD_WITHFILTER & ")"
        End If
        'MsgBox(ADD_WITHFILTER)
        Me.Label4.Text = "QUERY MANAGER - [" & T.TableName.ToUpper.ToUpper.Replace("_", " ") & "]"
        Me.Text = "QUERY MANAGER - [" & T.TableName.ToUpper.ToUpper.Replace("_", " ") & "]"
        If dV IsNot Nothing Then
            For K As Integer = 0 To dV.ColumnCount - 1
                Me.MainColumnCombo.Items.Add(dV.Columns(K).DataPropertyName.ToUpper.ToString)
                Me.DisplayColumn.Items.Add(dV.Columns(K).HeaderText.ToUpper.ToString)
            Next
        Else
            For K As Integer = 0 To T.Columns.Count - 1
                CNJ = T.Columns(K).ColumnName.ToUpper.ToString
                Me.MainColumnCombo.Items.Add(CNJ)
                CNJ = Replace(CNJ, "_", " ")
                CNJ = Replace(CNJ, "COSTOMER", "CUSTOMER", 1, -1, CompareMethod.Text)
                Me.DisplayColumn.Items.Add(CNJ)
            Next
        End If
        Try
            Me.MainColumnCombo.SelectedIndex = 0
            Me.DisplayColumn.SelectedIndex = 0
            ChgCom()
        Catch ex As Exception
            Epx()
        End Try
        If COL > -1 Then
            If AukF.SelectIndexFromObject(Me.DisplayColumn, COL) = True Then
                Me.MainColumnCombo.SelectedIndex = COL
                Me.DisplayColumn.SelectedIndex = COL

            End If
            'AukF.SelectIndexFromObject(Me.ComboBox3, COL)
        End If
        If SBp IsNot Nothing Then
            S_Table = AukF.Get_DataSystemObj(SBp)
            S_COLUMN.Resize(S_COLUMN, S_Table.Columns.Count)
            For K As Integer = 0 To S_Table.Columns.Count - 1
                S_COLUMN.SetValue(S_Table.Columns(K).ColumnName.ToString, K)
            Next
        End If
        AukF.AddComboToAnother(Me.DisplayColumn, Me.ComboBox4)
        AukF.ComSelIndex(Me.ComboBox4)
        AukF.ComSelIndex(Me.SUMMARY_CATEGORY)
        Me.QueryTextBox.Focus()
        'col is defaulkt=-1,if greater than means call from showQr
        If COL > -1 Then 'try to select on also ,summary field
            Me.ComboBox4.SelectedIndex = COL 'summary fields
        End If
        If Me.CheckStrType = True Then
            Me.FExact.Checked = True
        End If
        AukF.ComSelIndex(Me.QueryTypeCombo)
        Me.DefaultActionOFFDate()
        ShowDateFilterButton() 'for only seperator and datefilter option
        'Me.ComboBox5.SelectedIndex = Me.ComboBox4.SelectedIndex
    End Sub
    Private Sub InterChangeFromCheckedBox(ByVal Sender As Object)
        a = Sender.tag
        Me.QueryTypeCombo.SelectedIndex = Val(a)
    End Sub
    Private Sub OpenFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFilterBut.Click, OpenToolStripMenuItem.Click
        If sender.text = "&Open Only" Then
            OnlyOpen(sender, e)
            Exit Sub
        End If
        Dim Ua2 As Array
        s = Now
        If Me.Complex_CheckBox.Checked = True Then
            Ua2 = Get_TitleNames()
            If Me.QueryTextBox.Text.Trim <> "" Then
                ADSRC.Format_For_Complex(Me.MainColumnCombo, Me.QueryTextBox.Text, T, True, Bnp, True, Me.WITH_FILTER_CHECKBOX.Checked, Me.ClrOpen2.Checked, Ua2, Val(Me.StartDataLaod.Text), Val(Me.EndDataLaod.Text), Me.ADD_WITHFILTER.ToString, -1, OrderBy_Q)
            End If
        Else
            NormalFil()
            If Me.QExeCUTE = True Then AukF.DataSetFilter(Bnp, Not Me.ClrOpen2.Checked, False, "*", False, Val(Me.EndDataLaod.Text), Val(Me.StartDataLaod.Text), OrderBy_Q, False)
        End If
        If Me.QExeCUTE = True Then SUMMARY()
        ALL_EXECUTE()
        Me.Label5.Text = "DATALOAD DURATION (SECOND) : " & DateDiff(DateInterval.Second, S, Now)
    End Sub
    Public Function ALL_EXECUTE()
        Dim SColumn, Str As String
        If QExeCUTE = False Then Exit Function
        If S_Table IsNot Nothing Then
            If ADSRC.SUMMARY_NONEXE_CUR_TABLE(T, BSql) > 0 Then
                Dim R() As DataRow = Nothing
                s = Me.MainColumnCombo.Items(Me.DisplayColumn.SelectedIndex).ToString
                If ArF(S_COLUMN, s) = True And Me.Complex_CheckBox.Checked = False Then
                    SColumn = s : R = Nothing
                Else
                    SColumn = Me.S_Table_Open_Link_Field.ToString
                    R = T.Select(BSql)
                    Str = ADSRC.ROWC_Get_In_InCommand(R, SColumn, SColumn)
                End If
                If R IsNot Nothing Then
                    SFC(SColumn)
                    STC(Str)
                    ExpreC("Q")
                    R = Nothing
                Else
                    SFC(SColumn)
                    STC(Me.QueryTextBox.Text)
                End If
                If SoftIn.Get_DataType_Str(S_Table, SColumn) = False Then
                    If WGeT.ToUpper = "SYSTEM.DATETIME" Then
                        DTC("D")
                    Else
                        DTC("N")
                    End If
                End If
                AukF.Db_LoadN(S_Table, -1, "", Not Me.ClrOpen2.Checked, S_TABLE_FUNC, OrderBy_Q, False, Val(Me.StartDataLaod.Text), Val(Me.EndDataLaod.Text))
                SBp.Filter = BSql
            End If
        End If
        Try
            If Exe_form IsNot Nothing Then Exe_form.Exe_CuteQ()
        Catch ex As Exception
            Epx()
        End Try
    End Function
    Public Function Get_TitleNames() As Array
        'Dim T As DataTable = Nothing
        Dim CbC As ComboBox = Me.DisplayColumn
        Dim CbC2 As ComboBox = Me.MainColumnCombo
        'Dim Int As Integer
        Dim Ua As Array = ArV(Me.QueryTextBox.Text.Split("="), 0, ",")
        If ArC(Ua) = 0 Then Get_TitleNames = Nothing : Exit Function
        For I = 0 To Ua.GetUpperBound(0)
            Try
                c = Ua.GetValue(I)
                If IsNumeric(c) Then
                    Ua.SetValue(CbC2.Items.Item(CInt(c)), I)
                Else
                    If AukF.FindInObjectAndSelect(CbC, c) Then
                        Ua.SetValue(CbC2.Items.Item(ComRow), I)
                    ElseIf AukF.FindInObjectAndSelect(CbC, c, False) Then
                        Ua.SetValue(CbC2.Items.Item(ComRow), I)
                    Else
                        MsgBox("Table Title name is not matched please check ( " & c & " ) which is invalid.", MsgBoxStyle.Critical)
                        Exit Function
                    End If
                End If
            Catch ex As Exception
                Epx()
            End Try
        Next
        Get_TitleNames = Ua
    End Function
    Public Function SUMMARY()
        On Error GoTo B
        Dim TAB As String = Me.MainColumnCombo.Items.Item(Me.ComboBox4.SelectedIndex).ToString
        Dim SRM As String = Me.SUMMARY_CATEGORY.Text
        'MsgBox(BSql)
        Me.Label10.Text = SRM & " : " & T.Compute(SRM & "([" & TAB & "])", BSql) : Exit Function

B:      Me.Label10.Text = "SUMMARY CAN'T EXECUTE IN THIS FIELD"

    End Function
    Public Function NormalFil() As String
        Dim Str1 As String
        Ua2 = Me.OperatorCombo.Text.Split(CChar(","))
        Dim Sign As String = ArV2(Ua2, 1).ToString
        Try
            BSql = SoftIn.GetFunction_QrText(T, Me.MainColumnCombo.Text, Me.QueryTextBox.Text, Me.QueryTypeCombo.SelectedIndex, Sign, True)
            AukF.BindFilter_BSql(Bnp, BSql, Me.QueryTypeCombo.SelectedIndex, Me.WITH_FILTER_CHECKBOX.Checked, Sign, "AND", True)
        Catch ex As Exception
            Epx(Str1)
            'MsgBox(Sql)
        End Try
    End Function
    Public Function NormalFil2(Optional ByVal ExeC As Boolean = True) As String
        Dim Str1 As String
        Ua2 = Me.OperatorCombo.Text.Split(CChar(","))
        Dim Sign As String = ArV2(Ua2, 1).ToString
        Try
            BSql = SoftIn.GetFunction_QrText(T, Me.MainColumnCombo.Text, Me.QueryTextBox.Text, Me.QueryTypeCombo.SelectedIndex, Sign, True)
            AukF.BindFilter_BSql(Bnp, BSql, Me.QueryTypeCombo.SelectedIndex, Me.WITH_FILTER_CHECKBOX.Checked, Sign, "AND", ExeC)
        Catch ex As Exception
            Epx(Str1)
        End Try
    End Function
    Private Sub RemoveFilterButton(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, RemoveFilterToolStripMenuItem.Click
        Bnp.RemoveFilter()
    End Sub

    Private Sub Filter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click, FilterToolStripMenuItem.Click
        Dim Ua2 As Array
        S = Now
        If Me.Complex_CheckBox.Checked = True Then
            Ua2 = Get_TitleNames()
            ADSRC.Format_For_Complex(Me.MainColumnCombo, Me.QueryTextBox.Text, T, QExeCUTE, Bnp, QExeCUTE, Me.WITH_FILTER_CHECKBOX.Checked, Me.ClrOpen2.Checked, Ua2, Val(Me.StartDataLaod.Text), Val(Me.EndDataLaod.Text), Me.ADD_WITHFILTER, -1, OrderBy_Q)
        Else
            NormalFil()
        End If
        SUMMARY()
        Me.ALL_EXECUTE()
        Me.Label5.Text = "DATALOAD DURATION (SECOND) : " & DateDiff(DateInterval.Second, S, Now)

    End Sub

    Private Sub OpenWholeDb(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, OpenWholeDatabaseToolStripMenuItem.Click
        Me.Label5.Text = ADSRC.LOAD_WHOLE_DATABASE(T, True, "*", "", False)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            OpenFilter(sender, e)
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If AukF.MsgTr(What.ToUpper & "CLEAR DATATABLE DATA?") = True Then T.Clear()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainColumnCombo.SelectedIndexChanged
        ChgCom()
    End Sub
    Private Sub ComboBox3_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainColumnCombo.SelectionChangeCommitted
        ChgCom()
    End Sub
    Public Sub ChgCom()
        Me.DisplayFieldDetails.Text = "COLUMN NAME : " & Me.DisplayColumn.Text.ToUpper & "    |    INDEX  :  " & Me.MainColumnCombo.SelectedIndex & "        |     DATA TYPE  :  [ " & T.Columns(Me.MainColumnCombo.Text.ToUpper).DataType.Name.ToString.ToUpper & "  ]"
    End Sub
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles QueryTextBox.KeyDown
        ' Ctrl+Shift+Enter
        If e.Modifiers = Keys.Control And e.Modifiers = Keys.Shift And e.KeyCode = Keys.Enter Then
            OnlyOpen(sender, e)
        ElseIf e.Shift = True And e.Control = True Then
            If e.KeyValue >= 48 And e.KeyValue <= 57 Then 'case 0 num keyvalue =48 ,so for 0 -48 
                AukF.SelectIndexFromObject(Me.DisplayColumn, CInt(e.KeyValue) - 48, True)
                AukF.SelectIndexFromObject(Me.MainColumnCombo, CInt(e.KeyValue) - 48, True)
                AukF.SelectIndexFromObject(Me.ComboBox4, CInt(e.KeyValue) - 48, True)
                'MsgBox(e.KeyValue)
            End If
        ElseIf e.Modifiers = Keys.Control And e.KeyCode = Keys.Enter Then
            Ua2 = Me.OperatorCombo.Text.Split(CChar(","))
            If dV IsNot Nothing Then ADSRC.Query_Matches_From_Table_Select_Grid_Rows(dV, Me.MainColumnCombo.Text, sender.text, Bnp, 1500, Me.QueryTypeCombo.SelectedIndex, Ua2.GetValue(1).ToString())
        ElseIf e.KeyCode = Keys.Enter Then
            If Me.QueryTypeCombo.SelectedIndex = 10 Then 'between
                OnlyOpen(sender, e)
            Else
                OpenFilter(sender, e)
            End If
        End If

    End Sub
    Private Sub ComboBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainColumnCombo.TextChanged
        ChgCom() '
    End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles DisplayColumn.SelectionChangeCommitted
        If Me.Complex_CheckBox.Checked = True Then
            Me.QueryTextBox.Text = Me.DisplayColumn.SelectedIndex & "," & Me.QueryTextBox.Text
        End If
        Me.MainColumnCombo.SelectedIndex = sender.SelectedIndex
        Me.ComboBox4.SelectedIndex = sender.SelectedIndex
        Me.DefaultActionOFFDate()
        ShowDateFilterButton()
        Me.ToolTip2.SetToolTip(sender, sender.text)

    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Complex_CheckBox.Checked = Not Me.Complex_CheckBox.Checked
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Complex_CheckBox.Checked = False
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.QExeCUTE = False
        Q_ERRORMSG = False
        If Me.QueryTextBox.Text = "" Then BSql = "" Else OpenFilter(sender, e)
        Try
            Me.Label10.Text = (Me.SUMMARY_CATEGORY.Text & " : " & Summary_Totals_Sql(BSql, T.TableName, Me.MainColumnCombo.Items.Item(Me.ComboBox4.SelectedIndex).ToString, Me.SUMMARY_CATEGORY.Text))
        Catch ex As Exception
            Me.Label10.Text = ("COMMAND CAN'T EXECUTEABLE")
        End Try
        'MsgBox(BSql)
        Me.QExeCUTE = True
        Q_ERRORMSG = True
    End Sub

    Private Sub OnlyOpen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlyOpenToolStripMenuItem.Click
        Dim Ua2 As Array
        s = Now
        If Me.Complex_CheckBox.Checked = True Then
            Ua2 = Get_TitleNames()
            If Me.QueryTextBox.Text.Trim <> "" Then
                ADSRC.Format_For_Complex(Me.MainColumnCombo, Me.QueryTextBox.Text, T, True, Bnp, False, Me.WITH_FILTER_CHECKBOX.Checked, Me.ClrOpen2.Checked, Ua2, Val(Me.StartDataLaod.Text), Val(Me.EndDataLaod.Text), Me.ADD_WITHFILTER.ToString, -1, OrderBy_Q)
            End If
        Else
            NormalFil2(False)
            If Me.QExeCUTE = True Then AukF.Db_LoadQ(T, BSql, -1, Not Me.ClrOpen2.Checked, "", False, Val(Me.StartDataLaod.Text), Val(Me.EndDataLaod.Text))
        End If
        If Me.QExeCUTE = True Then SUMMARY()
        ALL_EXECUTE()
        Me.Label5.Text = "DATALOAD DURATION (SECOND) : " & DateDiff(DateInterval.Second, S, Now)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click, QueryManagerHelpToolStripMenuItem.Click
        If My.Computer.FileSystem.FileExists(AppPath & "\Helps\QueryManager.pdf") = False Then
            AukF.OExe(AppPath & "\Helps\QueryManager.pdf", Me)
        Else
            MsgBox("Please contact with developer our expert will teach how to smart query in your database, if you buy this soft.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryTextBox.TextChanged
        If Me.Complex_CheckBox.Checked = False Then
            If Me.SearchOpt.Checked = True Then
                If AukF.BindFind(Bnp, Me.MainColumnCombo.Text, sender.text, False) = True Then
                    If dV IsNot Nothing Then
                        ADSRC.Select_GridRows(dV, ComRow)
                    End If
                    Me.QueryTextBox.ForeColor = Color.White
                    Me.QueryTextBox.BackColor = Color.Black
                    Me.Label5.Text = "Found On : " & ComRow
                Else
                    Me.QueryTextBox.ForeColor = Color.Black
                    Me.QueryTextBox.BackColor = Color.White
                    Me.Label5.Text = "Current Text Is Not Found"

                End If
            End If
        End If
    End Sub

    Private Sub SearchOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchOpt.Click
        If sender.checked = False Then
            Me.QueryTextBox.ForeColor = Color.Black
            Me.QueryTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Ua2 = Me.OperatorCombo.Text.Split(CChar(","))
        If dV IsNot Nothing Then ADSRC.Query_Matches_From_Table_Select_Grid_Rows(dV, Me.MainColumnCombo.Text, sender.text, Bnp, 1500, Me.QueryTypeCombo.SelectedIndex, Ua2.GetValue(1).ToString())
        Me.ToolStripMenuItem4.Checked = Me.SearchOpt.Checked

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.SearchOpt.Checked = Me.ToolStripMenuItem4.Checked
        If sender.checked = False Then
            Me.QueryTextBox.ForeColor = Color.Black
            Me.QueryTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click, VersionToolStripMenuItem.Click
        Dim Str1 As String
        Str1 = "Version 1.2" & vbCrLf
        Str1 += "Developed By Alim ul karim(Auk) @ 2008" & vbCrLf
        Str1 += "Query Manager Developed for search diffrent,easy,advance and elegant way." & vbCrLf
        Str1 += "I can built this with your any kind of database soft,contact with me to make a deal." & vbCrLf
        Str1 += "Last Updated On: 11-Jan-2008." & vbCrLf

        MsgBox(Str1, MsgBoxStyle.Information)
        Str1 = ""
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        If Me.MonthCalendar1.Visible = True Then
            Me.QueryTextBox.Text = Me.MonthCalendar1.SelectionRange.Start

        End If
    End Sub

    Private Sub QueryTextBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryTextBox.DoubleClick
        n = T.Columns(Me.MainColumnCombo.Text.ToUpper).DataType.ToString.ToUpper
        If n = "SYSTEM.DATETIME" Then
            Me.MonthCalendar1.Visible = True
        End If
    End Sub

    Private Sub MonthCalendar1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthCalendar1.Leave
        Me.MonthCalendar1.Visible = False
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Bnp IsNot Nothing Then
            If Me.Bnp.Filter IsNot Nothing Then 'filter is ena
                Button4.BackColor = Color.Black
                Button4.ForeColor = Color.White
            Else 'fil disable
                Button4.BackColor = Color.Transparent
                Button4.ForeColor = Color.Black
            End If
        End If


    End Sub
    Private Sub ShowDateFilterButton()
        If T.Columns(Me.MainColumnCombo.Text).DataType.Name.ToUpper = "DATETIME" Then
            Me.Sp1.Visible = True
            Me.DateOpenFilterOptionToolStripMenuItem.Visible = True
        Else
            Me.Sp1.Visible = False
            Me.DateOpenFilterOptionToolStripMenuItem.Visible = False
        End If
    End Sub
    Private Sub ShowSummaryOnCurrentFieldsQuickToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowSummaryOnCurrentFieldsQuickToolStripMenuItem.Click, Label10.DoubleClick
        'Me.ComboBox3.Items.Item(Me.ComboBox4.SelectedIndex).ToString =ori. field name
        'Me.ComboBox5.Text="sum/count/avg etc"
        Dim Str1 As String = ""
        Dim Field As String = Me.MainColumnCombo.Items.Item(Me.ComboBox4.SelectedIndex).ToString
        If Bnp.Filter IsNot Nothing Then
            Str1 = Bnp.Filter
        End If
        Try
            Me.Label10.Text = (Me.SUMMARY_CATEGORY.Text & " : " & ADSRC.SUMMARY_NONEXE_CUR_TABLE(T, Str1, Me.SUMMARY_CATEGORY.Text, CInt(Val(Me.ComboBox4.SelectedIndex.ToString))))
        Catch ex As Exception
            Me.Label10.Text = ("COMMAND CAN'T EXECUTEABLE")
        End Try
    End Sub
    Private Sub DefaultActionOFFDate()
        If Me.CheckDateType = True Then
            Me.MonthCalendar1.Visible = True
            Me.ExactWord.Checked = True
        Else
            Me.MonthCalendar1.Visible = False
        End If
    End Sub
    Private Function CheckDateType() As Boolean
        Dim Nm As String = UCase(T.Columns(Me.MainColumnCombo.Text).DataType.Name.ToString)
        If Nm = "DATETIME" OrElse Nm = "DATE" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function CheckNumberType() As Boolean
        Dim Nm As String = UCase(T.Columns(Me.MainColumnCombo.Text).DataType.Name.ToString)
        If Nm <> "DATETIME" AndAlso Nm <> "BYTES[]" AndAlso Nm <> "STRING" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function CheckStrType() As Boolean
        Dim Nm As String = UCase(T.Columns(Me.MainColumnCombo.Text).DataType.Name.ToString)
        If Nm = "STRING" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub AukCommonDateFind_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox3.KeyDown, ToolStripTextBox2.KeyDown, ToolStripTextBox1.KeyDown
        'ori firld name=ComboBox3.text
        CSOFT.SummaryTextBox_KeyDown_ForOnlyQueryManager(sender, e, T, Me.MainColumnCombo.Text, Nothing, Bnp.Filter, True, True, sender.tag)
    End Sub

    Private Sub DeveloperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeveloperToolStripMenuItem.Click
        FrmL(Auk_Information)
    End Sub

    Private Sub ClickEvtOnCheckedBox(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FExact.Click, ExactWord.Click, AnyWhere.Click, AdvWrdOrFrm.Click, AdvWrdOr.Click, AdvWrdAnd.Click, AdvChrArray.Click
        Me.InterChangeFromCheckedBox(sender)
    End Sub

    Private Sub QueryTypeCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryTypeCombo.SelectedIndexChanged
        Me.ToolTip2.SetToolTip(sender, sender.text)
        Dim Id As Integer = Me.QueryTypeCombo.SelectedIndex
        If Id = 10 Then
            Me.OpenFilterBut.Text = "&Open Only"
        Else
            Me.OpenFilterBut.Text = "&OpenFilter"
        End If
        If Id = 0 Then
            Me.ExactWord.Checked = True
        ElseIf Id = 1 Then
            Me.FExact.Checked = True
        ElseIf Id = 2 Then
            Me.AnyWhere.Checked = True
        ElseIf Id = 3 Then
            Me.AdvWrdAnd.Checked = True
        ElseIf Id = 5 Then
            Me.AdvWrdOr.Checked = True
        ElseIf Id = 6 Then 'adv wrd split fexact
            Me.AdvWrdOrFrm.Checked = True
        ElseIf Id = 7 Then 'adv wrd split fexact
            Me.AdvChrArray.Checked = True
        Else
            Me.AdvOrFrmFirstRadio.Checked = True
        End If

    End Sub

    Private Sub GetDateRangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetDateRangeToolStripMenuItem.Click
        If Me.MonthCalendar1.Visible = True Then
            Me.QueryTextBox.Text = Me.MonthCalendar1.SelectionStart.Date & "," & Me.MonthCalendar1.SelectionEnd.Date
        Else
            MsgBox("Calender is not visible.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub AddDateFromCalenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDateFromCalenderToolStripMenuItem.Click
        If Me.MonthCalendar1.Visible = True Then
            If Me.QueryTextBox.Text <> "" Then Me.QueryTextBox.Text &= "," & Me.MonthCalendar1.SelectionEnd.Date Else Me.QueryTextBox.Text = Me.MonthCalendar1.SelectionEnd.Date
        Else
            MsgBox("Calender is not visible.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub DateOptClick2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EffectYearToolStripMenuItem.Click, EffectMonthToolStripMenuItem.Click, EffectDateToolStripMenuItem.Click
        If Me.CheckDateType = True Then
            SummaryTextBox_ForOnlyQueryManager(T, Me.MainColumnCombo.Text, Me.QueryTextBox.Text, "", True, True, sender.tag)
        Else
            MsgBox("Current Column's DataTy pe is not DateTime.", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub HelpCurrentQrType(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentQueryTypeToolStripMenuItem.Click

    End Sub
End Class
