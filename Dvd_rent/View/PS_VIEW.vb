Public Class PS_VIEW
    Dim dGRID As DataGrid = Me.PS_VIEW1DataGrid


    Private Sub PS_VIEW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oOPT As New AukDatabaseDataSetTableAdapters.OptionsTableAdapter
        oOPT.Fill(Me.AukDatabaseDataSet.Options)

        Me.DateTimePicker1.Value = Now.Date
        Me.DateTimePicker2.Value = CDate(Now.Date).AddDays(7)
        SoftIn.COM_OBJECT_ADD_EQUAL_SYSTEM(Me.DAYS_FIL_COMBO)
    End Sub

   

    Private Sub PS_VIEW1BindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PS_VIEW1BindingSource.PositionChanged
        FILTERS()
    End Sub
    Public Sub Exe_CuteQ()
        'MsgBox("Call")
        Me.FILTERS()
    End Sub
    Public Function FILTERS()
        If Me.PS_VIEW1DataGrid.DataSource IsNot Nothing Then
            If PS_VIEW1BindingSource.Position > -1 Then
                If Me.PS_VIEW1DataGrid.CurrentRowIndex > -1 And Me.PS_VIEW1DataGrid.VisibleRowCount > 0 Then
                    If Me.PS_VIEW1DataGrid(Me.PS_VIEW1DataGrid.CurrentRowIndex, 0).ToString <> "" Then
                        AukF.BindFilter(Me.PSSOLDVBindingSource, "REPORT ID", Me.PS_VIEW1DataGrid(PS_VIEW1DataGrid.CurrentRowIndex, 0).ToString)
                    End If
                ElseIf Me.PS_VIEW1DataGrid.VisibleRowCount > 0 Then
                    If Me.PS_VIEW1DataGrid(0, 0).ToString <> "" Then
                        AukF.BindFilter(Me.PSSOLDVBindingSource, "REPORT ID", Me.PS_VIEW1DataGrid(PS_VIEW1DataGrid.CurrentRowIndex, 0).ToString)
                    End If
                End If
            ElseIf PS_VIEW1BindingSource.Count > 0 Then
                On Error Resume Next
                PS_VIEW1BindingSource.Position = 0 : FILTERS()
            End If
        End If

    End Function
    Public Function Load_(ByVal ReportID As String, ByVal SoldID As String)
        On Error Resume Next
        ADSRC.LOAD_AND_FIND(Me.PS_VIEW1BindingSource, "REPORT ID", ReportID, -1, False, -1)
        ADSRC.LOAD_AND_FIND(Me.PSSOLDVBindingSource, "SOLD ID", SoldID, -1, False, -1)
        If AukF.BindFind(Me.PS_VIEW1BindingSource, "REPORT ID", ReportID) = True Then
            Me.PS_VIEW1DataGrid.Select(ComRow)
            FrmL(Me)
        End If
        If AukF.BindFind(Me.PSSOLDVBindingSource, "SOLD ID", SoldID, True) = True Then Me.PS_SOLDDataGrid.Select(ComRow)
    End Function
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        'ADSRC.TWICE_EXE(sender, e, Me.PSSOLDVBindingSource, "sold id", "product_serial", True, False, 0, 0)
        'Dim R(0) As DataRow
        If ADSRC.QEnterTo_Query_FObject_and_Select_DataGridObject(sender, e, Me.AukDatabaseDataSet.PS_SOLD_V, dGRID, "SOLD ID,PRODUCT_SERIAL,REPORT ID,PRODUCT NAME", 0, "PRODUCT NAME", "1", False, -1, Val(My.Settings.MaximumData_load)) = True Then
            If WGeT = "NO" Then Exit Sub
            Me.PSSOLDVBindingSource.Filter = BSql
            RPIDX = Me.PS_SOLDDataGrid(Me.PS_SOLDDataGrid.CurrentRowIndex, 10).ToString
            If RPIDX <> "" Then
                ADSRC.LOAD_AND_FIND(Me.AukDatabaseDataSet.PS_VIEW1, "REPORT ID", RPIDX, -1, False, -1)
                Me.PS_VIEW1BindingSource.Filter = BSql
            End If
        ElseIf ADSRC.QEnterTo_Query_FObject_and_Select_DataGridObject(sender, e, Me.AukDatabaseDataSet.PS_VIEW1, dGRID, "REPORT ID,CLIENT NAME,SOLD DATE,PREPARED BY,PAYMENT CATEGORY", 0, Nothing, Nothing, False, -1, Val(My.Settings.MaximumData_load)) = True Then
            Me.PS_VIEW1BindingSource.Filter = BSql
            RPIDX = Me.PS_VIEW1DataGrid(Me.PS_VIEW1DataGrid.CurrentRowIndex, 0).ToString
            If RPIDX <> "" Then
                ADSRC.LOAD_AND_FIND(Me.AukDatabaseDataSet.PS_SOLD_V, "REPORT ID", RPIDX, -1, False, -1)
                Me.PSSOLDVBindingSource.Filter = BSql
            End If
        End If
        FILTERS()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If ADSRC.TWICE_BINDFIND(Me.PSSOLDVBindingSource, "sold id", "product_serial", sender.text) Then
            Me.PS_SOLDDataGrid.Select(ComRow)
        ElseIf ADSRC.TWICE_BINDFIND(Me.PS_VIEW1BindingSource, "PREPARED BY", "SOLD DATE", sender.text) Then
            Me.PS_VIEW1DataGrid.Select(ComRow)
            'MsgBox("PRE,SOLDID", , sender.TEXT)
        ElseIf ADSRC.TWICE_BINDFIND(Me.PS_VIEW1BindingSource, "REPORT ID", "CLIENT NAME", sender.text) Then
            Me.PS_VIEW1DataGrid.Select(ComRow)
            'MsgBox("RP,CLIM")
        End If
    End Sub
    Public Function TODAYS_VIEW()
        Me.DAYS_BENEFIT(0)
        If Me.AukDatabaseDataSet.MOVIES_RPLIST.Rows.Count > 0 Then
            FrmL(Me)
        End If
    End Function
    Public Function Load_date(ByVal D1 As String, ByVal d2 As String)
        Dim Da, Da2 As Date
        Me.AukDatabaseDataSet.PS_SOLD_V.Clear()
        Me.AukDatabaseDataSet.PS_VIEW1.Clear()
        Try
            Da = CDate(D1) : Da2 = CDate(d2)
        Catch ex As Exception
            Epx()
            Exit Function
        End Try
        AukF.BindFilter_BetweenOparetorN(Me.PS_VIEW1BindingSource, "Sold Date", Da, Da2, False, False, True, True)
        If Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.Checked = True Then
            AukF.BindFilter_BetweenOparetorN(Me.PSSOLDVBindingSource, "Sold date", Da, Da2, False, Me.WITHFILTERToolStripMenuItem.Checked, True, True, -1, Val(My.Settings.MaximumData_load))
        End If
        FILTERS()

        'MsgBox(Sql)

    End Function
 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Me.Load_date(CDate(Now.Date), CDate(Now.Date))
        DAYS_BENEFIT(0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, SHOWAUKQUERYMANAGERToolStripMenuItem.Click
        Dim gD As DataGrid
        If My.Settings.VIEW_DETAILS_PS = True Then
            If dGRID.Name = Me.PS_SOLDDataGrid.Name Then
                gD = Me.PS_VIEW1DataGrid
            Else
                gD = Me.PS_SOLDDataGrid
            End If
        Else
            dGRID = Nothing
        End If
        If dGRID Is Nothing Then MsgBox("Please select a DataGrid Row First then execute the command.Please Checked on Show Details to query.", MsgBoxStyle.Information) : Exit Sub

        AukQ.Exe_form = Me
        DVDRENT.ShowQr_Product_ONLY_CYBER(AukQ, dGRID, dGRID.DataSource, "", gD.DataSource, "REPORT ID")

    End Sub

    Private Sub PS_VIEW1DataGrid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PS_VIEW1DataGrid.Enter, PS_SOLDDataGrid.Enter
        dGRID = sender

    End Sub
    Public Function DAYS_BENEFIT(ByVal DAYS As Decimal, Optional ByVal SIGN As String = "=")
        Me.AukDatabaseDataSet.PS_SOLD_V.Clear()
        Me.AukDatabaseDataSet.PS_VIEW1.Clear()
        SFC("SOLD TO NOW DURATION(DAY)")
        STC(DAYS)
        DTC("N")
        SnX(SIGN)
        AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_VIEW1)
        If Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.Checked = True Then
            SFC("SOLD TO NOW DURATION(DAY)")
            STC(DAYS)
            DTC("N")
            SnX(SIGN)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SOLD_V)



        End If
        FILTERS()
    End Function
    Public Function MONTHS_BENEFIT(ByVal mONTHS As Decimal, Optional ByVal SIGN As String = "=")
        Me.AukDatabaseDataSet.PS_SOLD_V.Clear()
        Me.AukDatabaseDataSet.PS_VIEW1.Clear()
        SFC("DURATION MONTHS")
        STC(mONTHS)
        DTC("N")
        SnX(SIGN)
        AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_VIEW1)
        If Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.Checked = True Then
            SFC("DURATION MONTHS")
            STC(mONTHS)
            DTC("N")
            SnX(SIGN)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SOLD_V)
        End If
        FILTERS()
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.MONTHS_BENEFIT(1)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AukF.ContextShow(Me.ContextMenuStrip1)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Load_date(CDate(Me.DateTimePicker1.Value.Date), CDate(Me.DateTimePicker2.Value.Date))
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        I = dGRID.CurrentCell.ColumnNumber
        If I >= 0 Then
            'MsgBox(AukF.BindFind(dGRID.DataSource, I, sender.TEXT, True))
            If AukF.BindFind(dGRID.DataSource, I, sender.TEXT, True) = True Then
                dGRID.Select(ComRow)
            End If

        End If
    End Sub

 
    Private Sub FILTERSELECTEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTERSELECTEDToolStripMenuItem.Click
        ADSRC.DATAGRID_ADVANCE_SELECTED_FILTER(dGRID, dGRID.DataSource, "=", 0, Me.WITHFILTERToolStripMenuItem.Checked)
    End Sub

    Private Sub EQUALSTOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOTEQUALToolStripMenuItem.Click, LESSTHANToolStripMenuItem.Click, GREATERTHANToolStripMenuItem.Click, GRAToolStripMenuItem.Click, EQUALSTOToolStripMenuItem.Click, EQUALANDLESSTHANToolStripMenuItem.Click
        SIGN = sender.TAG
        ADSRC.DATAGRID_ADVANCE_SELECTED_FILTER(dGRID, dGRID.DataSource, SIGN, 0, Me.WITHFILTERToolStripMenuItem.Checked)

    End Sub

    Private Sub PS_VIEW_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()

    End Sub

    Public Sub PrINT()
        Dim M As New PS_BENEFIT
        M.ReportDefinition.Sections(4).SectionFormat.EnableSuppress = Not Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.Checked
        AukF.Prnt_ABP(M, Me.AukDatabaseDataSet)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PrINT()
    End Sub
    Public Sub TODAYS_RP_SHOW_PRINT()
        'If Me.Visible = False Then
        '    Me.PS_VIEW1DataGrid.DataSource = Nothing
        '    Me.PS_SOLDDataGrid.DataSource = Nothing
        'End If
     
        Me.DAYS_BENEFIT(0)
        'MsgBox("PER")

        If Me.PS_VIEW1BindingSource.Count > 0 Then
            PrINT()
        Else
            MsgBox("NO DATA FOUND.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub PRINTONLYCURRENTCLIENTGOODSINFORMATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRINTONLYCURRENTCLIENTGOODSINFORMATIONToolStripMenuItem.Click
        Dim M As New PS_BENEFIT
        Dim Bp(1) As BindingSource
        M.ReportDefinition.Sections(4).SectionFormat.EnableSuppress = Not Me.SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.Checked
        Bp(0) = Me.PSSOLDVBindingSource
        Bp(1) = Me.PS_VIEW1BindingSource
        AukF.Prnt_ABP(M, Me.AukDatabaseDataSet, Bp)
    End Sub

    Private Sub SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWDETAILSOFSOLDPRODUCTSToolStripMenuItem.Click
        My.Settings.Save()

    End Sub
    Private Sub REMOVEFILTERToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripxXMenuItem.Click
        Me.PSSOLDVBindingSource.RemoveFilter()
        Me.PS_VIEW1BindingSource.RemoveFilter()
        Me.FILTERS()
    End Sub
    Private Sub DAYS_VIEWS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YESTERDAYToolStripMenuItem.Click, TODAYToolStripMenuItem.Click, DAYAFTERYESTERDAYToolStripMenuItem.Click
        Me.DAYS_BENEFIT(sender.TAG)
    End Sub
    Private Sub PS_VIEW1DataGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PS_VIEW1DataGrid.DoubleClick
        If My.Settings.VIEW_DETAILS_PS = True Then
            rpid = sender(Me.PS_VIEW1DataGrid.CurrentRowIndex, 0)
            Me.Load_by_RPID_details(rpid)
        End If
    End Sub

    Private Sub PS_SOLDDataGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PS_SOLDDataGrid.DoubleClick
        rpid = sender(Me.PS_SOLDDataGrid.CurrentRowIndex, 10)
        Me.Load_by_RPID_Main(rpid)
    End Sub
    Public Function Load_by_RPID_details(ByVal RPsID As String, Optional ByVal filter As Boolean = True)
        ADSRC.LOAD_AND_FIND(PSSOLDVBindingSource, "REPORT ID", RPsID, -1, False, -1)

        'MsgBox(BSql)
        If filter = True Then Me.PSSOLDVBindingSource.Filter = BSql
    End Function
    Public Function Load_by_RPID_Main(ByVal RPsID As String, Optional ByVal filter As Boolean = True)
        ADSRC.LOAD_AND_FIND(PS_VIEW1BindingSource, "REPORT ID", RPsID, -1, False, -1)
        'MsgBox(BSql)
        If filter = True Then
            Me.PS_VIEW1BindingSource.Filter = BSql
        Else
            If AukF.BindFind(PS_VIEW1BindingSource, "REPORT ID", RPsID, True) = True Then
                Me.PS_VIEW1DataGrid.Select(ComRow)
            End If
        End If
    End Function
    Private Sub LOADWHOLEDATABASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOADWHOLEDATABASEToolStripMenuItem.Click
        ADSRC.LOAD_WHOLE_DATABASE(AukF.Get_DataSystemObj(Me.PS_VIEW1BindingSource), True)
        If My.Settings.VIEW_DETAILS_PS = True Then
            ADSRC.LOAD_WHOLE_DATABASE(AukF.Get_DataSystemObj(Me.PSSOLDVBindingSource), True)
        End If
    End Sub
    Private Sub CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click
        If AukF.MsgTr("DO YOU WANT TO CLEAR?") = True Then Me.AukDatabaseDataSet.PS_SOLD_V.Clear() : Me.AukDatabaseDataSet.PS_VIEW1.Clear()
    End Sub

    Private Sub DAYS_LOADTEXT_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DAYS_LOADTEXT.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DAYS_BENEFIT(sender.TEXT, Me.DAYS_FIL_COMBO.Text.Split(",").GetValue(1).ToString)
        End If
    End Sub
End Class