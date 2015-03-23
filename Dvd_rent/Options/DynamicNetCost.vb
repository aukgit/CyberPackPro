Public Class DynamicNetCost

    Private Sub CHourBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHourBindingNavigatorSaveItem.Click
        SaveAuto()
    

    End Sub
    Public Sub SaveAuto()
        Try
            Me.Validate()
            Me.CHourBindingSource.EndEdit()
            Me.CHourTableAdapter.Update(Me.AukDatabaseDataSet.CHour)
        Catch ex As Exception
            Epx()
        End Try
    End Sub


    Private Sub DynamicNetCost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AukDatabaseDataSet.CHour.IDColumn.AutoIncrementStep = 1
        Me.AukDatabaseDataSet.CHour.IDColumn.AutoIncrementSeed = 1
        Me.AukDatabaseDataSet.CHour.IDColumn.AutoIncrement = True
        Me.AukDatabaseDataSet.CHour.HourColumn.DefaultValue = 2
        Me.AukDatabaseDataSet.CHour.MinuteColumn.DefaultValue = 0

        'TODO: This line of code loads data into the 'AukDatabaseDataSet.CHour' table. You can move, or remove it, as needed.
        Me.CHourTableAdapter.Fill(Me.AukDatabaseDataSet.CHour)

    End Sub

    Private Sub DynamicNetCost_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet, Me, False, "DO YOU WANT TO SAVE CHANGES?") = False Then
            e.Cancel = True
        End If
    End Sub
End Class