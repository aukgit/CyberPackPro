Public Class PS_WARRANTY
    Dim VWarAdp As New AukDatabaseDataSetTableAdapters.V_WARTableAdapter
    Dim PSoldAdp As New AukDatabaseDataSetTableAdapters.PS_SOLDTableAdapter

    Private Sub PS_WARRANTYBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            Me.PS_WARRANTYBindingSource.EndEdit()
            Me.PS_WARRANTYTableAdapter.Update(Me.AukDatabaseDataSet.PS_WARRANTY)
        Catch ex As Exception
            Epx()
        End Try

    End Sub

    Private Sub PS_WARRANTY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.VENDOR' table. You can move, or remove it, as needed.
        Me.VENDORTableAdapter.Fill(Me.AukDatabaseDataSet.VENDOR)
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.PS_WARRANTY' table. You can move, or remove it, as needed.
        If My.Settings.DataLoad_view = False Then
            Me.PS_WARRANTYTableAdapter.Fill(Me.AukDatabaseDataSet.PS_WARRANTY)
        End If
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        ADSRC.TWICE_EXE(sender, e, Me.PS_WARRANTYBindingSource, "SOLD_ID", "PRODUCT_SERIAL", True, False, 0, 0)
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        ADSRC.TWICE_BINDFIND(Me.PS_WARRANTYBindingSource, "SOLD_ID", "PRODUCT_SERIAL", sender.TEXT, "WARRANTY_ID", Me.PS_WARRANTYDataGridView)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.PS_WARRANTYTableAdapter.Fill(Me.AukDatabaseDataSet.PS_WARRANTY)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        AukQ.Bnp = (Me.PS_WARRANTYBindingSource)
        FrmL(AukQ)

    End Sub

    Private Sub PS_WARRANTY_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If SAVMSG() = 1 Then
                PS_WARRANTYBindingNavigatorSaveItem_Click(sender, e)

            ElseIf SavInt = 2 Then
                e.Cancel = True
                Exit Sub
            End If
            Me.PS_WARRANTYDataGridView.DataSource = Nothing
        End If
    End Sub

    Private Sub Warrent_EffectOn(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        SFC("Product_Serial", "v_id", "Client_Name", "Sold_ID", "worked")
        STC(AukF.GridT(Me.PS_WARRANTYDataGridView, 3), AukF.GridT(Me.PS_WARRANTYDataGridView, 2), AukF.GridT(Me.PS_WARRANTYDataGridView, 5), AukF.GridT(Me.PS_WARRANTYDataGridView, 1), "False")
        DTypex(4) = "b"
        DTypex(1) = "n"
        AukF.Db_LoadN(Me.AukDatabaseDataSet.V_WAR, -1)
        'MsgBox(Sql)

        Dim D As DataGridView = PS_WARRANTYDataGridView
        'w id-0
        'soldid-1
        'vid-2
        'goodsr-3
        'new sr-4
        'client-name-5
        'wardate-6
        'remaindays-7
        'whengiveup-8
        'reportid-9
        If Me.AukDatabaseDataSet.V_WAR.Count = 1 Then
            If AukF.MsgTr("Do you want to resume current product(" & AukF.GridT(D, 3) & ") to client(" & AukF.GridT(D, 5) & ") ?", False) = False Then Exit Sub
            If AukF.GridT(D, 4).ToString <> "" Then 'try on new serial
                Dim NSr As String = AukF.GridT(D, 4).ToString
                'change on ps-sold information
                ADSRC.LOAD_AND_FIND(Me.AukDatabaseDataSet.PS_SOLD, "Sold_Id", AukF.GridT(D, 1).ToString)
                'change new sreail number to before  in ps sold db
                RowX.Item(2) = NSr
                RowX.Item(4) = Replace(CStr(RowX.Item(4)), AukF.GridT(D, 3), NSr, 1, -1, CompareMethod.Text) 'try to replace on name nsr
                'chg complete
                Try
                    Me.PSoldAdp.Update(RowX)
                Catch ex As Exception
                    MsgBox("Can't save in product sold information,contact with developer.", MsgBoxStyle.Critical)
                End Try
                'chg submit

                'try to save on vendor_war
                Me.AukDatabaseDataSet.V_WAR(0).WORKED = True
                Me.AukDatabaseDataSet.V_WAR(0).NEW_PRODUCT_SERIAL = NSr
            Else
                Me.AukDatabaseDataSet.V_WAR(0).WORKED = True
            End If
            Try
                Me.VWarAdp.Update(Me.AukDatabaseDataSet.V_WAR(0))
            Catch ex As Exception
                MsgBox("Can't save in vendor wanrranty information,contact with developer.", MsgBoxStyle.Critical)
            End Try
delwar:
            Try
                If Me.PS_WARRANTYBindingSource.Count > 0 Then Me.PS_WARRANTYBindingSource.RemoveCurrent()
                PS_WARRANTYBindingSource.EndEdit()
                Me.PS_WARRANTYTableAdapter.Update(Me.AukDatabaseDataSet.PS_WARRANTY)
            Catch ex As Exception
                MsgBox("Can't delete wanrranty information,contact with developer.", MsgBoxStyle.Critical)
                If AukF.MsgTr("But you can also delete current product(" & AukF.GridT(D, 3) & ") manually?") = True Then GoTo delwar
            End Try
        ElseIf Me.AukDatabaseDataSet.V_WAR.Count = 0 Then
            MsgBox("Current Product is not found in 'Vendor Warrenty Databse',its impossoble. Contact with developer.", MsgBoxStyle.Critical)
            If AukF.MsgTr("But you can also delete current product(" & AukF.GridT(D, 3) & ") manually?") = True Then
                GoTo delwar
            End If

        Else
            MsgBox("Current Product is found but which number is """ & AukDatabaseDataSet.V_WAR.Count & """ and its impossoble. Contact with developer.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub PS_WARRANTYDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PS_WARRANTYDataGridView.CellDoubleClick
        If e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Then
            PS_VIEW.Load_(AukF.GridT(Me.PS_WARRANTYDataGridView, 9), AukF.GridT(Me.PS_WARRANTYDataGridView, 1))
        ElseIf e.ColumnIndex = 3 Or e.ColumnIndex = 1 Or e.ColumnIndex = 5 Then



        End If
    End Sub
End Class