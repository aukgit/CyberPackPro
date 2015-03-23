Public Class Ip_Settings
    Public TData As DataTable
    Public DDataSet As DataSet
    'Public BindS As BindingSource

    Private Sub Cyber_MemberBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cyber_MemberBindingNavigatorSaveItem.Click
        Try
            Me.Cyber_MemberDataGrid.Update()
            Me.Validate()
            Me.Cyber_MemberBindingSource.EndEdit()

            Me.Cyber_MemberTableAdapter.Update(TData)

        Catch ex As Exception
            Epx()

        End Try
   
    End Sub

    Private Sub Ip_Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Cyber_Member' table. You can move, or remove it, as needed.
        'Me.Cyber_MemberTableAdapter.Fill(Me.AukDatabaseDataSet.Cyber_Member)
        Cyber_MemberBindingSource.DataSource = TData


    End Sub

    Private Sub GotoMemberID(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        AukF.BindGotoFind(Me.Cyber_MemberBindingSource, "Cyber_MemberID", sender.text, Me.Cyber_MemberDataGrid)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim M As New IPADDRESS

        AukF.Prnt(M, DDataSet, Me.Cyber_MemberBindingSource)

    End Sub

    Private Sub Advance_IDQuery(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If sender.text.ToString.Trim <> "" Then
                sn1 = AukF.Advance_Search(sender.text.ToString, 2, TData)
                Try
                    Cyber_MemberBindingSource.Filter = sn1

                Catch ex As Exception
                    Epx(sn1)

                End Try
            End If
           

        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Cyber_MemberBindingSource.RemoveFilter()

    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        DVDRENT.ShowQr_Product(Me.Cyber_MemberDataGrid, Me.Cyber_MemberBindingSource)
    End Sub
End Class