Public Class ViewQuery
    Public DVD_I As Boolean = False
    Private Sub DataGrid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim T As DataTable = AukF.Get_DataSystemObj(Me.DataGrid1)
        If T IsNot Nothing Then
            If T.TableName = "SimSoldSummaryTab" Then
                '1=company,2=simcate,7=due
                SimSold.LoadQuery(Me.DataGrid1(Me.DataGrid1.CurrentRowIndex, 0), Me.DataGrid1(Me.DataGrid1.CurrentRowIndex, 1), Me.DataGrid1(Me.DataGrid1.CurrentRowIndex, 7))
                FrmL(SimSold)
            End If
            If T.TableName.ToUpper = "PS_RPLIST" Or T.TableName.ToUpper = "MOVIES_RPLIST" Then
                ID = Me.DataGrid1(Me.DataGrid1.CurrentRowIndex, 0)
                If DVD_I = False Then
                    PS_SOLD.VIEW_BY_REPORT_ID(ID)
                Else
                    MSold.VIEW_BY_REPORT_ID(ID)
                End If
            End If
        End If
    End Sub

 
    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub
End Class