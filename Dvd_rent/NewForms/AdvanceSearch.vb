Public Class AdvanceSearch
    Dim Lst, Lst2, Lst3 As New ListBox

    Public Bnp As BindingSource
    Public T As DataTable

    Private Sub AdvanceSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Type' table. You can move, or remove it, as needed.
        'Me.TypeTableAdapter.Fill(Me.AukDatabaseDataSet.Type)
        T = AukF.Get_DataSystemObj(Bnp)

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    'Dim A As Array
    '    Dim Join As String = "And"
    '    Lst.Items.Clear()
    '    Lst2.Items.Clear()
    '    Lst3.Items.Clear()
    '    Lst4.Items.Clear()
    '    If Me.All_AcceptType.Checked Then
    '        Join = "And"
    '    Else
    '        Join = "Or"
    '    End If
    '    If Me.TypeSearch.Checked = True Then
    '        'SFC()
    '        If C(Me.AdvanceSrType) Then
    '            sn1 = AukF.Advance_Search(Me.AdvanceTypeSr.Text, 12, T, Join)
    '            If C(Me.AdTypeChk) Then
    '                MsgBox(sn1)
    '                G(12, "", "", "", "", sn1)
    '            End If
    '            If C(Me.bsTYChk) Then
    '                'A = Me.BasicTypeSr.Text.Split(" ")
    '                sn1 = AukF.Advance_Search(Me.BasicTypeSr.Text, 1, Me.AukDatabaseDataSet.Type, Join)
    '                MsgBox(sn1)

    '                AukF.OleDb_SqlGen(sn1, Me.AukDatabaseDataSet.Type)
    '                sn2 = AukF.Mother_DB_Load(Me.AukDatabaseDataSet.Type, 0)
    '                MsgBox(sn2)
    '                G(1, "", "", "", "", " Movie_Type_Name In (" & sn2 & ")")
    '            End If
    '        Else
    '            If C(Me.AdTypeChk) Then
    '                G(12, Me.AdvanceTypeSr.Text)
    '            End If
    '            If C(Me.bsTYChk) Then
    '                G(1, Me.BasicTypeSr.Text)
    '            End If
    '        End If

    '    End If
    '    If C(Me.CheckBox6) Then

    '        If C(Me.MovNameChk) Then
    '            If Me.AdvanceExtra.Checked = False Then
    '                G(3, Me.Movie_nameSr.Text, Me.MovNameAnywhereChk.Checked.ToString) 'move name
    '            Else
    '                sn1 = AukF.Advance_Search(Me.Movie_nameSr.Text, 3, T)
    '                G(3, "", "", "=", "", sn1) 'move name
    '            End If
    '        End If
    '        If C(Me.MovVerChk) Then
    '            G(2, Me.Movie_nameSr.Text) 'moveversion
    '        End If
    '        If C(Me.PlaceChk) Then
    '            G(6, Me.PlaceCombo.Text) 'place
    '        End If
    '    End If
    '    For I = 0 To Me.Lst.Items.Count - 1
    '        SF(I) = Lst.Items.Item(I).ToString
    '        ST(I) = Lst2.Items.Item(I).ToString
    '        LK(I) = Lst3.Items.Item(I).ToString
    '        ExpressionsQ(I) = Lst4.Items.Item(I).ToString 'Instert the Advance Sr In COmmand there
    '        MsgBox(ExpressionsQ(I) & vbCrLf & SF(I) & vbCrLf & ST(I), , "A")
    '    Next
    '    If C(Me.MovNameAnywhereChk) = True Then
    '        AukF.Db_Load("*", "Product_collection", T, False, "", True, False, Val(My.Settings.MaximumData_load))
    '    Else
    '        AukF.Db_Load("*", "Product_collection", T, False, "", True, True, Val(My.Settings.MaximumData_load))
    '    End If
    '    MsgBox(Sql)

    'End Sub
    Private Function G(ByVal Col As Integer, ByVal Str As String, Optional ByVal Lk As String = "", Optional ByVal Expressions As String = "", Optional ByVal INCommand As String = "")
        'MsgBox("Col :" & Col & vbCrLf & Str, , Lst.Items.Count - 1)
        Lst.Items.Add(T.Columns(Col).ColumnName) 'column name
        Lst2.Items.Add(Str)
        Lst3.Items.Add(Expressions)


    End Function
    Private Function C(ByVal Cx As CheckBox) As Boolean
        C = Cx.Checked
    End Function

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeSearch_Group.CheckedChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.GroupBox1.Enabled = Me.TypeSearch_Group.Checked
        Me.GroupBox2.Enabled = Me.ExtraSearchOptionGroup.Checked

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Bnp.RemoveFilter()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Join As String = "And"
        Lst.Items.Clear()
        Lst2.Items.Clear()
        Lst3.Items.Clear()



        If Me.All_AcceptType.Checked Then
            Join = "And"
        Else
            Join = "Or"
        End If
        'If C(Me.TypeSearch_Group) Then
        '    If C(Me.AdvanceSrType_ChkToDO) Then
        '        If C(Me.AdTypeChk) Then '
        '            sn1 = AukF.Advance_Search(Me.AdvanceTypeSr.Text, 12, T, Join)
        '            G(12, "", "", sn1)

        '        End If
        '    End If
        'End If
        '--------------------------------------

        If Me.TypeSearch_Group.Checked = True Then
            'SFC()
            If C(Me.AdvanceSrType_ChkToDO) Then
                If Me.AdvanceTypeSr.Text.Trim <> "" Then
                    sn1 = AukF.Advance_Search(Me.AdvanceTypeSr.Text, 12, T, Join)
                    If C(Me.AdTypeChk) Then
                        'MsgBox(sn1)
                        G(12, "", "", sn1)
                    End If
                End If
                If C(Me.bsTYChk) Then
                    'A = Me.BasicTypeSr.Text.Split(" ")
                    sn1 = AukF.Advance_Search(Me.BasicTypeSr.Text, 1, Me.AukDatabaseDataSet.Type, Join)
                    'MsgBox(sn1, , "ans")
                    If Me.BasicTypeSr.Text.Trim <> "" Then AukF.OleDb_SqlGen("Select * from Type  where " & sn1, Me.AukDatabaseDataSet.Type)
                    If Me.AukDatabaseDataSet.Type.Rows.Count > 0 Then
                        sn2 = AukF.Mother_DB_Load(Me.AukDatabaseDataSet.Type, 0)
                        G(1, "", "", " Movie_Type In (" & sn2 & ")")
                    End If
                End If
            Else
                If C(Me.AdTypeChk) Then
                    If Me.AdvanceTypeSr.Text.Trim <> "" Then G(12, Me.AdvanceTypeSr.Text)
                End If
                If C(Me.bsTYChk) Then
                    If Me.BasicTypeSr.Text.Trim <> "" Then G(1, Me.BasicTypeSr.Text)
                End If
            End If

        End If
        If C(Me.ExtraSearchOptionGroup) Then

            If C(Me.MovNameChk) Then
                If Me.AdvanceExtra_ChkToDO.Checked = False Then
                    G(3, Me.Movie_nameSr.Text, Me.MovNameAnywhereChk.Checked.ToString) 'move name
                Else
                    sn1 = AukF.Advance_Search(Me.Movie_nameSr.Text, 3, T)
                    G(3, "", "", sn1) 'move name
                End If
            End If
            'MsgBox(MovVersionSr.Text)
            If C(Me.MovVerChk) Then
                G(2, Me.MovVersionSr.Text) 'moveversion
            End If
            If C(Me.PlaceChk) Then
                G(6, Me.PlaceCombo.Text) 'place
            End If
        End If

        c1 = Me.Lst.Items.Count
        For k As Integer = 0 To Val(c1) - 1
            SF(k) = Lst.Items.Item(k)
            ST(k) = Lst2.Items.Item(k)
            ExpressionsQ(k) = Lst3.Items.Item(k)
        Next
        If C(Me.MovNameAnywhereChk) = True Then
            AukSql.SqlAukCmDND("*", "", False, False, "Product_collection", True, True)
        Else
            AukSql.SqlAukCmDND("*", "", False, False, "Product_collection", True, False)
        End If
        s1 = AukF.DivideIn_To_2(Sql, "where")
        Try
            Bnp.Filter = QA2
        Catch ex As Exception
            Epx(QA2)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Join As String = "And"
        Lst.Items.Clear()
        Lst2.Items.Clear()
        Lst3.Items.Clear()



        If Me.All_AcceptType.Checked Then
            Join = "And"
        Else
            Join = "Or"
        End If
        'If C(Me.TypeSearch_Group) Then
        '    If C(Me.AdvanceSrType_ChkToDO) Then
        '        If C(Me.AdTypeChk) Then '
        '            sn1 = AukF.Advance_Search(Me.AdvanceTypeSr.Text, 12, T, Join)
        '            G(12, "", "", sn1)

        '        End If
        '    End If
        'End If
        '--------------------------------------

        If Me.TypeSearch_Group.Checked = True Then
            'SFC()
            If C(Me.AdvanceSrType_ChkToDO) Then
                If Me.AdvanceTypeSr.Text.Trim <> "" Then
                    sn1 = AukF.Advance_Search(Me.AdvanceTypeSr.Text, 12, T, Join)
                    If C(Me.AdTypeChk) Then
                        'MsgBox(sn1)
                        G(12, "", "", sn1)
                    End If
                End If
                If C(Me.bsTYChk) Then
                    'A = Me.BasicTypeSr.Text.Split(" ")
                    sn1 = AukF.Advance_Search(Me.BasicTypeSr.Text, 1, Me.AukDatabaseDataSet.Type, Join)
                    'MsgBox(sn1, , "ans")
                    If Me.BasicTypeSr.Text.Trim <> "" Then AukF.OleDb_SqlGen("Select * from Type  where " & sn1, Me.AukDatabaseDataSet.Type)
                    If Me.AukDatabaseDataSet.Type.Rows.Count > 0 Then
                        sn2 = AukF.Mother_DB_Load(Me.AukDatabaseDataSet.Type, 0)
                        G(1, "", "", " Movie_Type In (" & sn2 & ")")
                    End If
                End If
            Else
                If C(Me.AdTypeChk) Then
                    If Me.AdvanceTypeSr.Text.Trim <> "" Then G(12, Me.AdvanceTypeSr.Text)
                End If
                If C(Me.bsTYChk) Then
                    If Me.BasicTypeSr.Text.Trim <> "" Then G(1, Me.BasicTypeSr.Text)
                End If
            End If

        End If
        If C(Me.ExtraSearchOptionGroup) Then

            If C(Me.MovNameChk) Then
                If Me.AdvanceExtra_ChkToDO.Checked = False Then
                    G(3, Me.Movie_nameSr.Text, Me.MovNameAnywhereChk.Checked.ToString) 'move name
                Else
                    sn1 = AukF.Advance_Search(Me.Movie_nameSr.Text, 3, T)
                    G(3, "", "", sn1) 'move name
                End If
            End If
            'MsgBox(MovVersionSr.Text)
            If C(Me.MovVerChk) Then
                G(2, Me.MovVersionSr.Text) 'moveversion
            End If
            If C(Me.PlaceChk) Then
                G(6, Me.PlaceCombo.Text) 'place
            End If
        End If

        c1 = Me.Lst.Items.Count
        For k As Integer = 0 To Val(c1) - 1
            SF(k) = Lst.Items.Item(k)
            ST(k) = Lst2.Items.Item(k)
            ExpressionsQ(k) = Lst3.Items.Item(k)
        Next
        If C(Me.MovNameAnywhereChk) = True Then
            AukF.Db_Load("*", "Product_collection", T, False, "", True, False, Val(My.Settings.MaximumData_load))
        Else
            AukF.Db_Load("*", "Product_collection", T, False, "", True, True, Val(My.Settings.MaximumData_load))
        End If
        s1 = AukF.DivideIn_To_2(Sql.ToLower, "where")
        'MsgBox(QA2)
        Try
            Bnp.Filter = QA2
        Catch ex As Exception
            Epx(QA2)
        End Try

    End Sub

 
    Private Sub AdvanceTypeSr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvanceTypeSr.TextChanged

    End Sub
End Class