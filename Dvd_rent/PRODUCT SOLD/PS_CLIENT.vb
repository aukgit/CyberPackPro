Public Class PS_CLIENT
    Public DVD_I As Boolean = False
    Private Sub PS_CLIENTSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PS_CLIENTSBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.PS_CLIENTSBindingSource.EndEdit()
            Me.PS_CLIENTSTableAdapter.Update(Me.AukDatabaseDataSet.PS_CLIENTS)

        Catch ex As Exception
            Epx()

        End Try
   
    End Sub

    Private Sub PS_CLIENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.PS_CLIENTS' table. You can move, or remove it, as needed.
        If My.Settings.DataLoad_view = False Then
            Me.PS_CLIENTSTableAdapter.Fill(Me.AukDatabaseDataSet.PS_CLIENTS)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHQUERYToolStripMenuItem.Click
        'AukQ.Bnp = Me.PS_CLIENTSBindingSource
        'FrmL(AukQ)
        DVDRENT.ShowQr_Product(Me.PS_CLIENTSDataGridView, Me.PS_CLIENTSBindingSource)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click, CURRENTCLIENTCONSINGEDPRODUCTSDATESToolStripMenuItem.Click
        Dim SHOWTABLE As New DataTable
        SFC("CLIENT NAME")
        STC(AukF.GridT(Me.PS_CLIENTSDataGridView, 0))
        If DVD_I = True Then
            AukF.Db_LoadN(SHOWTABLE, -1, "MOVIES_RPLIST")
        Else
            AukF.Db_LoadN(SHOWTABLE, -1, "PS_RPLIST")
        End If
        If SHOWTABLE.Rows.Count > 0 Then
            ViewQuery.DataGrid1.DataSource = SHOWTABLE
            ViewQuery.DVD_I = DVD_I
            FrmL(ViewQuery)
        End If
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        ADSRC.TWICE_EXE(sender, e, Me.PS_CLIENTSBindingSource, "CLIENT_NAME", "CONTACT_NUMBER", True, False, 0, 7, 20)
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        ADSRC.TWICE_BINDFIND(Me.PS_CLIENTSBindingSource, "CLIENT_NAME", "CONTACT_NUMBER", sender.TEXT, "ADDRESS")
    End Sub

    Private Sub LOADWHOLEDATABASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADWHOLEDATABASEToolStripMenuItem.Click
        Me.PS_CLIENTSTableAdapter.Fill(Me.AukDatabaseDataSet.PS_CLIENTS)

    End Sub

    Private Sub CLEARWHOLEDATABASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEARWHOLEDATABASEToolStripMenuItem.Click
        Me.AukDatabaseDataSet.Clear()

    End Sub
End Class