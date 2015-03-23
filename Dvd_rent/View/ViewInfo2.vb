Public Class ViewInfo2
    Dim D1 As New AukQ
    Dim D2 As New AukQ
    Dim P1 As New AukQ

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AukF.ContextShow(Me.ContextMenuStrip1)

    End Sub
    Public Function PROFIT(ByVal DATE1 As Date, ByVal DATE2 As Date) As String
        DX = DateDiff(DateInterval.Day, DATE1, DATE2)
        SFC("DVD RENT TO NOW DATE DISTANCE(D)")
        'MsgBox(DX)
        STC(DX)
        SnX("=")
        AukF.Db_Load("*", "DVD_PROFIT", Me.AukDatabaseDataSet.DVD_PROFIT, True)
        Me.DataGrid2.CaptionText = "PROFIT INFORMATION VIEW"
        Me.DataGrid2.DataSource = Me.DVD_PROFITBindingSource
        RE_SUM()
    End Function
    Public Function PROFIT2(ByVal DATE1 As Date, ByVal DATE2 As Date)
        AukF.BindFilter_BetweenOparetorN(Me.DVD_PROFITBindingSource, "DVD RENT DATE", DATE1, DATE2)
        Me.DataGrid2.CaptionText = "PROFIT INFORMATION VIEW"
        Me.DataGrid2.DataSource = Me.DVD_PROFITBindingSource
        'MsgBox(Sql)
        RE_SUM()
        'AukF.Db_Load("*", "DVD_PROFIT", Me.AukDatabaseDataSet.DVD_PROFIT, True, "[MOVIE NAME]")
    End Function
    Public Function DVDRENTQr(Optional ByVal PLACE As String = "INHAND", Optional ByVal DVDID As String = "")
        If DVDID <> "" Then
            SFC("DVD ID", "PLACE")
            STC(DVDID, PLACE)
        Else
            SFC("PLACE")
            STC(PLACE)
        End If
        AukF.Db_Load("*", "DVD_RENTV1", Me.AukDatabaseDataSet.DVD_RENTV1, True)
        If Me.AukDatabaseDataSet.DVD_RENTV1.Rows.Count > 0 Then
            Me.Show()
            Me.Activate()
            Me.DataGrid2.CaptionText = "DVD RENT VIEW INFORMATIONS OF (DVD ID: " & DVDID.ToUpper & " & PLACE: " & PLACE & ")"
            Me.DataGrid2.DataSource = Me.DVD_RENTV1BindingSource
            RE_SUM()
        End If
    End Function
    Public Function DVDVIEW1(ByVal DVDID As String)
        SFC("DVD ID")
        STC(DVDID)
        AukF.Db_Load("*", "DVD_VIEW2", Me.AukDatabaseDataSet.DVD_View2, True)
        If Me.AukDatabaseDataSet.DVD_View2.Rows.Count > 0 Then
            FrmL(Me)

            Me.DataGrid2.CaptionText = "DVD VIEW INFORMATIONS SYSTEM 2 SHOWS YOU (DVD ID: " & DVDID.ToUpper & ")"
            Me.DataGrid2.DataSource = Me.DVD_View2BindingSource
            RE_SUM()
        End If
    End Function
    Public Function DVDVIEW2_BYCustomerS(ByVal Customer As String)
        SFC("Customer ID")
        STC(Customer)
        AukF.Db_Load("*", "DVD_VIEW2", Me.AukDatabaseDataSet.DVD_View2, True)
        If Me.AukDatabaseDataSet.DVD_View2.Rows.Count > 0 Then
            FrmL(Me)

            Me.DataGrid2.CaptionText = "DVD VIEW INFORMATIONS SYSTEM 2 SHOWS YOU (Customer ID: " & Customer.ToUpper & ")"
            Me.DataGrid2.DataSource = Me.DVD_View2BindingSource
            RE_SUM()
        End If
    End Function
    Public Function RE_SUM()
        'On Error Resume Next
        'Dim pX As BindingSource
        'pX = Me.DataGrid2.DataSource
        'If pX Is Nothing Then Exit Function
        'Dim T1 As DataTable = AukF.Get_DataSystemObj(pX)
        'Me.Label9.Text = pX.Count.ToString()
        'If T1.TableName.ToUpper = "DVD_VIEW2" Then
        '    Me.Label10.Text = T1.Compute("SUM([DVD RENT CustomerS COST])", "dUE=FALSE")
        '    Me.Label11.Text = T1.Compute("SUM([TOTAL FINE + RENT COST])", "dUE=FALSE") & " ,FINE: " & T1.Compute("SUM([Fine])", "dUE=FALSE")  'TOTAL BENEFIT
        '    Me.Label12.Text = 0 & " ,DUE: " & T1.Compute("SUM([TOTAL PROFIT])", "DUE=TRUE") 'DISCOUNT 'DISCOUNT
        'ElseIf T1.TableName.ToUpper = "DVDVIEW" Then
        '    Me.Label10.Text = T1.Compute("SUM([DVD RENT COST])", "dUE=FALSE")
        '    Me.Label11.Text = 0 'TOTAL BENEFIT
        '    Me.Label12.Text = 0 & " ,DUE: " & T1.Compute("SUM([DVD RENT COST])", "DUE=TRUE") 'DISCOUNT'DISCOUNT
        'ElseIf T1.TableName.ToUpper = "DVD_PROFIT" Then
        '    Me.Label10.Text = T1.Compute("SUM([CustomerS DVD RENT COST])", "dUE=FALSE")
        '    'cbnyx = Val(ADSRC.Summary_Totals("DVD_PROFIT", "PRODUCT COST", "Sum", "[DVD ID]", True))
        '    'MsgBox(cbnyx)
        '    Me.Label11.Text = T1.Compute("SUM([TOTAL PROFIT])", "dUE=FALSE") & " ,FINE: " & T1.Compute("SUM([Fine])", "dUE=FALSE") & " ,TOTAL DVD BUY COST:" & cbny & ",TOATAL:" & Val(Val(T1.Compute("SUM([PRODUCT COST]+[TOTAL PROFIT]+[Fine])", "dUE=FALSE"))) 'TOTAL BENEFIT
        '    Me.Label12.Text = T1.Compute("SUM([DISCOUNT])", "") & " ,DUE: " & T1.Compute("SUM([TOTAL PROFIT])", "DUE=TRUE") 'DISCOUNT
        'End If
    End Function
    Private Sub ViewInfo2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataGrid2.DataSource = Me.DVD_PROFITBindingSource
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If D1.Created = False Then
            D1 = New AukQ
        End If
        D1.Bnp = Me.DVDVIEWBindingSource
        'D2.Bnp.DataMember = Me.DVD_PROFITBindingSource.DataMember
        Me.DataGrid2.DataSource = D1.Bnp
        Me.DataGrid2.CaptionText = "DVD DATA VIEW INFORMATION SYSTEM 1"
        D1.Text = Me.DataGrid2.CaptionText
        D1.ClrOpen2.Checked = False
        D1.Show()
        D1.Activate()
        D1.EndDataLaod.Text = 500
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If D2.Created = False Then
            D2 = New AukQ
        End If
        D2.Bnp = Me.DVD_View2BindingSource
        'D2.Bnp.DataMember = Me.DVD_PROFITBindingSource.DataMember
        D2.ClrOpen2.Checked = False
        Me.DataGrid2.DataSource = D2.Bnp
        Me.DataGrid2.CaptionText = "DVD DATA VIEW INFORMATION SYSTEM 2"
        D2.Text = Me.DataGrid2.CaptionText
        D2.Show()
        D2.Activate()
        D1.EndDataLaod.Text = 500
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If P1.Created = False Then
            P1 = New AukQ
        End If
        P1.ClrOpen2.Checked = False
        P1.Bnp = Me.DVD_PROFITBindingSource
        'P1.Bnp.DataMember = Me.DVD_PROFITBindingSource.DataMember
        Me.DataGrid2.DataSource = P1.Bnp
        Me.DataGrid2.CaptionText = "PROFIT INFORMATION VIEW"
        P1.Text = Me.DataGrid2.CaptionText
        P1.Show()
        P1.Activate()
        D1.EndDataLaod.Text = 500
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PROFIT(Now, Now)
        RE_SUM()
    End Sub
    Public Sub TODAYSVIEW(Optional ByVal Msg As Boolean = True)
        PROFIT(Now, Now)
        If Me.AukDatabaseDataSet.DVD_PROFIT.Count > 0 Then
            Dim M As New DVDPROFIT_REPOT
            AukF.Prnt(M, Me.AukDatabaseDataSet, Me.DVD_PROFITBindingSource)
        Else
            MsgBox("Today No Movie Rent.")
        End If

    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PROFIT2(Me.DateTimePicker1.Value.Date, Me.DateTimePicker2.Value.Date)
        RE_SUM()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        RE_SUM()

    End Sub

    Private Sub SETAWEEKDISTANCEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SETAWEEKDISTANCEToolStripMenuItem.Click
        Me.DateTimePicker1.Value = Me.DateTimePicker2.Value.Date.AddDays(7)

    End Sub

    Private Sub SETAMONTHDISTANCEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SETAMONTHDISTANCEToolStripMenuItem.Click
        Me.DateTimePicker1.Value = Me.DateTimePicker2.Value.Date.AddMonths(1)

    End Sub

    Private Sub SETAYEARDISTANCEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SETAYEARDISTANCEToolStripMenuItem.Click
        Me.DateTimePicker1.Value = Me.DateTimePicker2.Value.Date.AddYears(1)

    End Sub

    Private Sub SET2YEARDISTANCEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SET2YEARDISTANCEToolStripMenuItem.Click
        Me.DateTimePicker1.Value = Me.DateTimePicker2.Value.Date.AddYears(2)
    End Sub

    Private Sub SET5YEARSDISTANCEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SET5YEARSDISTANCEToolStripMenuItem.Click
        Me.DateTimePicker1.Value = Me.DateTimePicker2.Value.Date.AddYears(5)
    End Sub

    Private Sub PREVIOUSDAYSBENEFITPROFITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PREVIOUSDAYSBENEFITPROFITToolStripMenuItem.Click
        PROFIT(Now.Date, Now.Date.AddDays(+1))

    End Sub

    Private Sub PRSS(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then PROFIT(Now, CDate(sender.TEXT))
        Catch ex As Exception
            Epx(sender.TEXT)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim M As New DVDPROFIT_REPOT
        AukF.Prnt(M, Me.AukDatabaseDataSet, Me.DVD_PROFITBindingSource)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim M As New DVDVIEW_REPORT_1
        AukF.Prnt(M, Me.AukDatabaseDataSet, Me.DVDVIEWBindingSource)

    End Sub
    Private Sub FILTERSELED(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SELECTEDFILTERToolStripMenuItem.Click, SELECTEDFILTERLOWERORLESSTHANToolStripMenuItem.Click, SELECTEDFILTERLOWERORLESSTHANEQUALToolStripMenuItem.Click, SELECTEDFILTERGREATERTHANToolStripMenuItem.Click, SELECTEDFILTERGREATERTHANEQUALSToolStripMenuItem.Click
        ADSRC.DATAGRID_ADVANCE_SELECTED_FILTER(Me.DataGrid2, Me.DataGrid2.DataSource, sender.TAG, 0, Me.WITHFILTERToolStripMenuItem.Checked)
    End Sub

    Private Sub CURRENTFIELDFILTERSYSTEMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CURRENTFIELDFILTERSYSTEMToolStripMenuItem.Click
        Dim Bpx As BindingSource
        If Me.DataGrid2.DataSource Is Nothing Then Exit Sub
        If Me.DataGrid2.DataSource.Equals(Me.DVDVIEWBindingSource) Then
            Bpx = Me.DVDVIEWBindingSource
        ElseIf Me.DataGrid2.DataSource.Equals(Me.DVD_View2BindingSource) Then
            Bpx = Me.DVD_View2BindingSource
        ElseIf Me.DataGrid2.DataSource.Equals(Me.DVD_PROFITBindingSource) Then
            Bpx = Me.DVD_PROFITBindingSource
        ElseIf Me.DataGrid2.DataSource.Equals(Me.DVD_RENTV1BindingSource) Then
            Bpx = Me.DVD_RENTV1BindingSource
        Else
            Bpx = Nothing
            Exit Sub
        End If
        DVDRENT.ShowQr_Product(Me.DataGrid2, Bpx)
    End Sub

    Private Sub CUSTOMERSINHANDVIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERSINHANDVIEWToolStripMenuItem.Click
        DVDRENTQr()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub REMOVEFILTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REMOVEFILTERToolStripMenuItem.Click
        If Me.DataGrid2.DataSource IsNot Nothing Then
            'MsgBox("REMOVE ")
            Dim bP As BindingSource = Me.DataGrid2.DataSource
            bP.RemoveFilter()

        End If
    End Sub

    Private Sub DVD_RENTV1BindingSource_ListChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles DVD_RENTV1BindingSource.ListChanged, DVDVIEWBindingSource.ListChanged, DVD_PROFITBindingSource.ListChanged, DVD_View2BindingSource.ListChanged
        Me.RE_SUM()
    End Sub
End Class