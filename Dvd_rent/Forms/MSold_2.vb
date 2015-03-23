Public Class MSold
    Dim DL As Boolean = False
    Private Sub MSold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TypeTableAdapter.Fill(Me.AukDatabaseDataSet.Type)
        AukF.XPAuk(Me)
        If My.Settings.DONT_SGRID_MS = True Then
            Me.DataGridView1.DataSource = ""
            Me.DataGridView1.Visible = False
        End If
        SFC("PLACE")
        STC("INSTORE")
        If Val(My.Settings.LOAD_MOVIES_MS) = -1 Then
            DL = True
            AukF.Db_LoadN(Me.AukDatabaseDataSet.SOLD_VIEW, -1, "", True, 0, "[dvd ID]", False)
        ElseIf Val(My.Settings.LOAD_MOVIES_MS) > 0 Then
            DL = True
            AukF.Db_LoadN(Me.AukDatabaseDataSet.SOLD_VIEW, -1, "", True, 0, "[dvd ID]", False, 0, Val(My.Settings.LOAD_MOVIES_MS))
        Else
            SF(0) = ""
            ST(0) = ""
            DL = False
        End If
        Me.ComboBox1.SelectedIndex = 0
        Me.ComboBox7.SelectedIndex = 0
    End Sub


    Private Sub Label5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseDown
        AukF.DragAuk(Me)
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
    Public Function MDETAILS(Optional ByVal ID As String = "", Optional ByVal F As Boolean = False)
        If F = False Then
            Me.PictureBox2.Image = My.Resources.Small_imgs.AukWrong
            Me.Label9.Text = "MOVIE [" & ID & "] IS NOT FOUND IN YOUR DATABASE."
        Else
            Me.PictureBox2.Image = My.Resources.Small_imgs.AukRight
            Me.Label9.Text = "MOVIE [" & ID & "] IS FOUND IN YOUR DATABASE."
        End If
    End Function
    Private Sub FIND_DVDID(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown, TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            SFC("DVD ID", "PLACE")
            'MsgBox(sender.TEXT)
            STC(sender.TEXT, "INSTORE")
            AukF.Db_LoadN(Me.AukDatabaseDataSet.SOLD_VIEW, "*", "", True, Me.ComboBox7.SelectedIndex, "", False, 0, 10)
            Me.SOLDVIEW_BindingSource1.Filter = BSql
            Me.MDETAILS(sender.TEXT, AukF.BindFind(Me.SOLDVIEW_BindingSource1, "DVD ID", sender.TEXT, True))
            'MsgBox(Sql)

        End If
    End Sub
    Public Function FindB(ByVal DVDID As String, Optional ByVal GotoP As Boolean = False) As Boolean
        FindB = AukF.BindFind(Me.SOLDVIEW_BindingSource1, "DVD ID", DVDID, GotoP)
    End Function
    Public Function FindB_N(ByVal MName As String, Optional ByVal GotoP As Boolean = False) As Boolean
        FindB_N = AukF.BindFind(Me.SOLDVIEW_BindingSource1, "Name", MName, GotoP)
    End Function
    Public Function FindI(ByVal DVDID As String, Optional ByVal GotoP As Boolean = False) As Boolean
        FindI = ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.SOLD_VIEW, DVDID)
        Try
            If GotoP = True Then
                Me.SOLDVIEW_BindingSource1.Position = ComRow
            End If
        Catch ex As Exception
        End Try
    End Function
    Private Sub MOVE_FIND(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SFC("NAME", "PLACE")
            STC(sender.TEXT, "INSTORE")
            ExpreC("F" & Me.ComboBox7.SelectedIndex)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.SOLD_VIEW, "*", "", False, 0, "", False, -1, 10)
            Me.SOLDVIEW_BindingSource1.Filter = BSql
            Me.MDETAILS(sender.TEXT, AukF.BindFind(Me.SOLDVIEW_BindingSource1, "NAME", sender.TEXT, True))
            'MsgBox(Sql)

        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SFC("TYPE", "PLACE")
        STC(Me.ComboBox1.Text, "INSTORE")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.SOLD_VIEW, "*", "", False, Me.ComboBox7.SelectedIndex, "", False, -1, 1200)
        If Me.SOLDVIEW_BindingSource1.Filter IsNot Nothing Then
            If Me.SOLDVIEW_BindingSource1.Filter <> BSql Then
                Me.SOLDVIEW_BindingSource1.Filter = BSql
            End If
        Else
            Me.SOLDVIEW_BindingSource1.Filter = BSql

        End If

        MsgBox(Sql)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.SOLDVIEW_BindingSource1.EndEdit()
            Me.SOLD_VIEWTableAdapter.Update(Me.AukDatabaseDataSet.SOLD_VIEW)
        Catch ex As Exception
            Epx()
        End Try
    End Sub
    Public Sub RE_PRINT(Optional ByVal SHOWVIEW As Boolean = False)
        Dim M As New SoldReport
        If SHOWVIEW = True Then
            AukF.Prnt(M, Me.AukDatabaseDataSet, Me.SOLDVIEW_BindingSource1)
        Else
            AukF.SET_FILTER_INrEPORT(M, Me.SOLDVIEW_BindingSource1)
            M.Database.Tables(0).SetDataSource(Me.AukDatabaseDataSet)
            M.PrintToPrinter(1, False, 1, 1)
        End If

    End Sub
 

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        AukQ.Bnp = Me.SOLDVIEW_BindingSource1
        AukQ.ClrOpen2.Checked = False
        AukQ.ClrOpen2.Visible = False
        FrmL(AukQ)

    End Sub
    Private Sub DVDID_GOTOFIND(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged, TextBox1.TextChanged
        'ADSRC.TWICE_BINDFIND(Me.SOLDVIEW_BindingSource1, "DVD ID", "Name", sender.text)
        If My.Settings.TEXT_CHG_FIND_MSOLD = True Then
            Me.MDETAILS(sender.TEXT, AukF.BindFind(Me.SOLDVIEW_BindingSource1, "DVD ID", sender.TEXT, True))
        End If
    End Sub



    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        AukF.BindFind(Me.SOLDVIEW_BindingSource1, "name", sender.text, True)
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        FrmL(MSOLD_SET)
    End Sub

    Private Sub TabPage2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.RE_PRINT(True)
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class