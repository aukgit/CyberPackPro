Public Class DVD_Rent_Query
    Dim Lst, Lst2, Li, ESuma, Exprea As New ListBox
    Public T As DataTable

    Private Sub DVD_Rent_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AukF.ComSelIndex(Me.ComboBox2)
        AukF.ComSelIndex(Me.ComboBox1)
        'T.CaseSensitive = False

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Lst.Items.Clear()
        Lst2.Items.Clear()
        Li.Items.Clear()
        ESuma.Items.Clear()
        Exprea.Items.Clear()

        If C(Me.CheckBox1) = True Then 'cosid
            G(1, Me.TextBox2.Text)
        End If
        If C(Me.CheckBox2) = True Then 'CosName
            If C(Me.CheckBox13) Then
                ln = "lk"
            Else
                ln = ""
            End If
            G(2, Me.TextBox3.Text, ln)
        End If
        If C(Me.CheckBox3) = True Then 'Dvdid
            G(4, Me.TextBox1.Text)
        End If
        If C(Me.CheckBox4) = True Then 'MoveName
            If C(Me.CheckBox14) = True Then
                ln = "lk"
            Else
                ln = ""
            End If
            G(6, Me.TextBox4.Text, ln)
        End If
        If C(Me.CheckBox5) = True Then 'date_rent
            G(7, "", "", "", "between #" & Me.DateTimePicker1.Value.Date & "# and #" & Me.DateTimePicker2.Value.Date & "#")

        End If
        If C(Me.CheckBox6) = True Then 'Re_date
            G(8, "", "", "", "between #" & Me.DateTimePicker3.Value.Date & "# and #" & Me.DateTimePicker4.Value.Date & "#")
        End If
        If C(Me.CheckBox9) = True Then 'paymoney
            G(13, Me.TextBox7.Text, "", AukF.CutTxtGet(Me.ComboBox2.Text, ",", 2))
        End If
        If C(Me.CheckBox10) = True Then 'fine
            G(14, Me.TextBox8.Text, "", AukF.CutTxtGet(Me.ComboBox1.Text, ",", 2))
        End If
        If C(Me.CheckBox11) = True Then 'Cos Comments
            G(16, Me.TextBox10.Text)
        End If
        If C(Me.CheckBox12) = True Then 'place
            G(3, Me.TextBox9.Text)
        End If
        For I = 0 To Me.Lst.Items.Count - 1

            SF(I) = Lst.Items.Item(I).ToString
            'MsgBox(SF(I))
            ST(I) = Lst2.Items.Item(I).ToString
            EP(I) = ESuma.Items.Item(I).ToString 'oparetor
            Expre(I) = Exprea.Items.Item(I).ToString 'expressions First
            LK(I) = Li.Items.Item(I).ToString 'expressions First
        Next
        AukF.Db_Load("*", T.TableName, T, AukF.BoolInvert(Me.CheckBox7.Checked))
        Me.Label4.Text = "Total Found Record:" & T.Rows.Count
        My.Settings.Save()

        MsgBox(Sql)


    End Sub
    Private Function G(ByVal Col As Integer, ByVal Str As String, Optional ByVal Lk As String = "", Optional ByVal Sign As String = "", Optional ByVal Express As String = "")
        'MsgBox(Col, , Str)
        Li.Items.Add(Lk)

        Lst.Items.Add(T.Columns(Col).ColumnName.ToString)
        Lst2.Items.Add(Str)
        ESuma.Items.Add(Sign)
        Exprea.Items.Add(Express)
    End Function
    Private Function C(ByVal Cx As CheckBox) As Boolean
        C = Cx.Checked

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m As New DVD_rent_Report2
        AukF.Prnt(m, Dset)
    End Sub
End Class