Public Class CommonAdd
    Public D As DataGridView = Product_Input3.Product_CollectionDataGridView
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If AukF.MsgTr(What & "Input This...?") = True Then
            AukF.Grid_View_SetCommonItems(D, Me.TextBox1.Text, Me.ComboBox1.Text.Split(",").GetValue(1).ToString, False, Me.ProgressBar1, True, True)
        End If
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CommonAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SoftIn.DataGrid_DataPropertyName_Add(Me.ComboBox1, D, "0,6,8,10,11")

    End Sub
End Class
