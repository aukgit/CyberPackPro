Public Class PrSrc
    'Public T As DataTable
    Public Bp As BindingSource = Product_Input3.Product_CollectionBindingSource
    Dim T As DataTable
    Dim Sn1 As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        T = AukF.Get_DataSystemObj(Bp)

        'If Me.Adsrc.Checked = True Then
        '    sql1 = AukF.Advance_Search(Me.TextBox1.Text, 3, Bp)
        '    If Me.CheckBox1.Checked Then
        '        Sn1 = " and ([place]='" & Me.TextBox2.Text & "')"
        '        Sql = sql1 & Sn1
        '    Else
        '        Sn1 = ""
        '        Sql = sql1
        '    End If
        '    Sql = "select * from product_collection where " & Sql
        '    AukF.OleDb_SqlGen(Sql, Bp, "", False)
        '    'MsgBox(Sql)
        '    Try
        '        Bp.Filter = sql1

        '    Catch ex As Exception
        '        Epx(Bp.Filter)

        '    End Try

        'Else
        '    If Me.CheckBox1.Checked = True Then
        '        AukF.DataFilterExtraOrdinary(Bp, "movie_name,place", Me.TextBox1.Text & "," & Me.TextBox2.Text, ",", True, Me.Exactword.Checked, Me.Fexact.Checked, Me.Anywhere.Checked)
        '    Else
        '        SoftIn.BindFilterByAdvanceCategory(Bp, "movie_name", Me.TextBox1.Text, Me.Exactword, Me.Fexact, Me.Anywhere, "=", False, 0)
        '    End If
        '    AukF.DataSetFilter(Bp, False, False, True, False)
        '    MsgBox(Bp.Filter)

        'End If
        If Me.Adsrc.Checked = True Then
            BSql = AukF.Advance_Search(Me.TextBox1.Text, "movie_name", Bp)
        Else
            BSql = SoftIn.BindFilterByAdvanceCategory(Bp, "Movie_name", Me.TextBox1.Text, Me.Exactword, Me.Fexact, Me.Anywhere, "=", False, 0, "AND", False)
        End If
        If Me.CheckBox1.Checked = True Then
            BSql = BSql & "(Place='" & Me.TextBox2.Text & ")"
        End If
        AukF.Bind_WithFilter_AddWith(Bp, BSql, False)
        SoftIn.Sql_Convert_For_Adp(T, BSql)
        AukF.Db_LoadN(T, -1, "", False, 0, My.Settings.DVDOPT_ORDERBY, False, -1, 100)

    End Sub

    Private Sub ColseSearchOptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColseSearchOptionToolStripMenuItem.Click
        Me.Hide()
        FrmL(Product_Input3)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Bp.RemoveFilter()

    End Sub
End Class