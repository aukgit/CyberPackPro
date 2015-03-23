Public Class MVIEWS
    Private Sub MVIEWS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim MTY As New AukDatabaseDataSetTableAdapters.MTYPE_VIEWTableAdapter
        Me.MTYPE_VIEWTableAdapter.Fill(Me.AukDatabaseDataSet.MTYPE_VIEW)
        'Dim MTADY As New AukDatabaseDataSetTableAdapters.M_ADVANCE_TYPETableAdapter
        Me.M_ADVANCE_TYPETableAdapter.Fill(Me.AukDatabaseDataSet.M_ADVANCE_TYPE)
        'MsgBox(Me.AukDatabaseDataSet.M_ADVANCE_TYPE.Rows.Count)

        Me.FIND_MOVIES.Focus()

    End Sub

    Private Sub LOADWHOLEDATABASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADWHOLEDATABASEToolStripMenuItem.Click
        Me.Label2.Text = ADSRC.LOAD_WHOLE_DATABASE(Me.AukDatabaseDataSet.SOLD_VIEW)

    End Sub

    Private Sub CLEARDATABASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEARDATABASEToolStripMenuItem.Click
        If AukF.MsgTrU("CLEAR DATABASE?", True) = True Then Me.AukDatabaseDataSet.SOLD_VIEW.Clear()

    End Sub

    Private Sub HIDEVIEWFORMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HIDEVIEWFORMToolStripMenuItem.Click
        Me.Hide()

    End Sub

    Private Sub SEARCHQUERYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHQUERYToolStripMenuItem.Click
        'AukQ.Bnp = Me.SOLD_VIEWBindingSource
        'FrmL(AukQ)
        DVDRENT.ShowQr_Product(Me.SOLD_VIEWDataGrid, Me.SOLD_VIEWBindingSource)

    End Sub
    Public Function Send_to(ByVal DvdID As String)
        Dim Place As String
        Place = Me.SOLD_VIEWDataGrid(Me.SOLD_VIEWDataGrid.CurrentRowIndex, 4).ToString
        If Place.ToUpper <> "INSTORE" Then
            Me.Label2.Text = "CURRENT MOVIE [" & DvdID & "] PLACE IS NOT INSTORE,PLACE " & Place.ToUpper & "."
        End If
        With MSold
            If .GS Then
                If .ADDLST(DvdID) = True Then
                    Me.Label2.Text = "MOVIE [" & DvdID & "] SUBMIT SUCCESSFULLY."
                Else
                    Me.Label2.Text = "MOVIE [" & DvdID & "] FAILED TO SUBMIT."
                End If
            Else
                FrmL(MSold)
                MsgBox("PLEASE LOAD CLIENT THEN TRY TO SEND MOVIES TO HIS/HER ACCOUNT.", MsgBoxStyle.Information)
                Me.Label2.Text = "MOVIE [" & DvdID & "] FAILED TO SUBMIT."
                .ToolStripTextBox1.Focus()
            End If
        End With
    End Function

    Private Sub ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ONLYCURRENTMOVIESENDTOSOLDLISTToolStripMenuItem.Click
        Send_to(CStr(Me.SOLD_VIEWDataGrid(Me.SOLD_VIEWDataGrid.CurrentRowIndex, 0).ToString))
    End Sub

    Private Sub SOLD_VIEWDataGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOLD_VIEWDataGrid.DoubleClick
        Send_to(CStr(Me.SOLD_VIEWDataGrid(Me.SOLD_VIEWDataGrid.CurrentRowIndex, 0).ToString))
    End Sub

    Private Sub SHOWFOCUSONDVDIDFOUNDTEXTBOXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWFOCUSONDVDIDFOUNDTEXTBOXToolStripMenuItem.Click
        Me.FIND_MOVIES.Focus()

    End Sub

    Private Sub SHOWMOVIEADVANCETYPEONLYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWMOVIEADVANCETYPEONLYToolStripMenuItem.Click
        Me.ListBox1.DataSource = Me.MADVANCETYPEBindingSource
        Me.ListBox1.DisplayMember = "ADVANCE MOVIE TYPE"
        Me.ListBox1.ValueMember = "MOVIES"
    End Sub

    Private Sub SHOWMOVIETYPESLISTBOXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWMOVIETYPESLISTBOXToolStripMenuItem.Click
        Me.SplitContainer1.Panel1Collapsed = sender.CHECKED
    End Sub

    Private Sub FIND_MOVIES_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FIND_MOVIES.KeyDown
        ADSRC.TWICE_EXE(sender, e, Me.SOLD_VIEWBindingSource, "DVD ID", "NAME", False)
        If e.KeyCode = Keys.Enter Then
            If ADSRC.TWICE_BINDFIND(Me.SOLD_VIEWBindingSource, "DVD ID", "NAME", sender.TEXT) = True Then
                Me.SOLD_VIEWDataGrid.Select(ComRow)

                If Me.DIRECTADDMOVIEINSOLDLISTWHENFOUNDBYFINDTEXTBOXToolStripMenuItem.Checked = True Then
                    Send_to(Me.SOLD_VIEWDataGrid(ComRow, 0))
                End If
            End If
        End If
 
    End Sub

    Private Sub FIND_MOVIES_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FIND_MOVIES.TextChanged
        If ADSRC.TWICE_BINDFIND(Me.SOLD_VIEWBindingSource, "DVD ID", "NAME", sender.TEXT) = True Then
            Me.SOLD_VIEWDataGrid.Select(ComRow)

        End If
    End Sub

    Private Sub MOVIESTYPESSHOWSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOVIESTYPESSHOWSToolStripMenuItem.Click
        Me.ListBox1.DataSource = Me.MTYPEVIEWBindingSource
        Me.ListBox1.DisplayMember = "MOVIE TYPE NAME"
        Me.ListBox1.ValueMember = "MOVIES"

    End Sub

    Private Sub ListBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        'ON
        '        Me.Label1.Text = "TOTAL MOVIES : " & Me.ListBox1.SelectedValue.ToString
    End Sub
    Public Function LOADBY_LIST()
        Dim BP As BindingSource
        BP = Me.ListBox1.DataSource
        Dim D1 As Date = Now
        'MsgBox(D1)
        If BP.Equals(Me.MADVANCETYPEBindingSource) = True Then
            SFC("ADVANCE TYPE")
            STC(Me.ListBox1.Text)
        Else
            SFC("TYPE")
            STC(Me.ListBox1.Text)
        End If
        AukF.Db_LoadN(Me.AukDatabaseDataSet.SOLD_VIEW)
        s = DateDiff(DateInterval.Second, D1, Now)
        Me.Label2.Text = "DATALOAD DURATION(SECOND) : " & S
        Me.SOLD_VIEWDataGrid.CaptionText = "MOVIES VIEW," & BSql
    End Function
    Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        LOADBY_LIST()

    End Sub

    Private Sub ListBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyDown
        On Error Resume Next
        Me.Label1.Text = "TOTAL MOVIES : " & Me.ListBox1.SelectedValue.ToString

        If e.KeyCode = Keys.Enter Then
            LOADBY_LIST()
        End If
    End Sub

  
    Private Sub SOLD_VIEWDataGrid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SOLD_VIEWDataGrid.KeyDown
        If e.KeyCode = Keys.Enter Then
            Send_to(CStr(Me.SOLD_VIEWDataGrid(Me.SOLD_VIEWDataGrid.CurrentRowIndex, 0).ToString))
        End If
    End Sub


    Private Sub FILTERALSOPLACEINSTOREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTERALSOPLACEINSTOREToolStripMenuItem.Click
        AukF.BindFilter(Me.SOLD_VIEWBindingSource, "PLACE", "INSTORE")
    End Sub

    Private Sub REMOVEFILTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REMOVEFILTERToolStripMenuItem.Click
        Me.SOLD_VIEWBindingSource.RemoveFilter()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        On Error Resume Next
        Me.Label1.Text = "TOTAL MOVIES : " & Me.ListBox1.SelectedValue.ToString
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FILTERALSOPLACEINSTOREToolStripMenuItem_Click(sender, e)
    End Sub

 
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim dV As DataView = Me.AukDatabaseDataSet.SOLD_VIEW.DefaultView
        'Dim rDV As DataRowView
        dV.Sort = "NAME"
        INPUTX = InputBox("")
        ComRow = dV.Find(INPUTX)
        MsgBox(ComRow)
    End Sub
End Class