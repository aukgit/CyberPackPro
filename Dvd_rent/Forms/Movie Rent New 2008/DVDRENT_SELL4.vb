Public Class Product_Input3
    Public TCol, TRow As Integer
    Dim CosID As String
    Dim Rent As Boolean = False
    Dim CtRow As DataRow
    Dim TrTb, CHECKR As New DataTable
    Friend PreTable As New DataTable
    Dim PMovs, Mtype As New BindingSource
    Friend FORMAT1 As String = "'['+DVD_ID + ']' +  '-' + '(' + Movie_Name + ')'"
    Friend FORMAT2 As String = "Movie_Name +  '-' + '['+DVD_ID + ']'"
    'Dim FBnd As New BindingSource
    Public ONLY_M_SOLD As Boolean = False
    Dim DVD As New AukDatabaseDataSet.Product_CollectionDataTable
    Public CusR As AukDatabaseDataSet.Costomer_InfRow
    Public Hook As Boolean = False
    Dim Starter_X As Boolean = False
    Dim NewAdd As Decimal
    Public NeedToReType As Boolean = False
    Public SendFrmSelf As Boolean = False

    Public Function BEFORE_MOVIE(ByVal DVDID As String, ByVal CUSTOMERID As String) As Boolean
        SFC("costomer_id", "dvd_ID")
        STC(CUSTOMERID, DVDID)
        If COUNT_T("DVD_RENT", CHECKR) = 0 Then BEFORE_MOVIE = False Else BEFORE_MOVIE = True
    End Function

    Private Sub Product_CollectionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Product_CollectionBindingNavigatorSaveItem.Click, SaveDataToolStripMenuItem.Click, SAVEToolStripMenuItem.Click, ToolStripMenuItem59.Click
        Try
            Me.Validate()
            Me.Product_CollectionBindingSource.EndEdit()
            Me.Product_CollectionTableAdapter.Update(Me.AukDatabaseDataSet.Product_Collection)
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub Product_Input3_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If NeedToReType = True Then
            MovieTypeRefresh(sender, e)
            NeedToReType = False
        End If
        If Movie_Type.Visible = True Then
            Movie_Type.NeedToReType = True
        End If
    End Sub

    Private Sub Product_input_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If My.Settings.Dont_RefreshData = True Then
            'MsgBox(TrTb.Rows(0).Item(0).ToString)
            If Me.AukDatabaseDataSet.Product_Collection.Rows.Count >= 2500 Then
                e.Cancel = True
                Me.Hide()
                Exit Sub
            End If
        End If
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If Rent = True Then
                MsgBox("PLEASE LET THE CLIENT/CUSTOMER OFF FIRST.", MsgBoxStyle.Critical)
                e.Cancel = True
                Exit Sub
            End If
            If SAVMSG() = 1 Then
                Product_CollectionBindingNavigatorSaveItem_Click(sender, e)
            ElseIf SavInt = 2 Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Product_input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AukDatabaseDataSet.DVD_Rent.DueColumn.DefaultValue = False
        Me.AukDatabaseDataSet.DVD_Rent.Is_AlternativeColumn.DefaultValue = False
        Me.AukDatabaseDataSet.DVD_Rent.Is_Comments_BadColumn.DefaultValue = False
        Me.AukDatabaseDataSet.DVD_Rent.DueColumn.DefaultValue = False
        Me.AukDatabaseDataSet.DVD_Rent.Pay_MoneyColumn.DefaultValue = 0
        Me.AukDatabaseDataSet.DVD_Rent.FineColumn.DefaultValue = 0
        Me.AukDatabaseDataSet.DVD_Rent.ReturnDistance_InHourColumn.DefaultValue = 0
        Me.AukDatabaseDataSet.Product_Collection.MaximamRentDaysColumn.DefaultValue = 0
        'Me.AukDatabaseDataSet.Product_Collection.Movie_TypeColumn .DefaultValue = 1
        Me.AukDatabaseDataSet.Product_Collection.Rent_PriceColumn.DefaultValue = 0
        Me.AukDatabaseDataSet.Product_Collection.Sold_or_Broken_PriceColumn.DefaultValue = 0
        Me.AukDatabaseDataSet.Product_Collection.Total_BenefitColumn.DefaultValue = 0
        'Me.AukDatabaseDataSet.Product_Collection.se.DefaultValue = 0

        Me.AUTOMATICDVDIDWHENNULLToolStripMenuItem.Checked = My.Settings.DVDOPT_AUTOMACI_DVDID
        'Me.AukDatabaseDataSet.DVD_Rent.FineColumn.DefaultValue = 0
        'movie type id =auto id num
        'Me.AukDatabaseDataSet.Type.Movie_TypeColumn.AutoIncrementStep = 1
        'Me.AukDatabaseDataSet.Type.Movie_TypeColumn.AutoIncrementSeed = 1
        'Me.AukDatabaseDataSet.Type.Movie_TypeColumn.AutoIncrement = True
        '---
        Dim Tm1 As New DataTable
        Me.OptionsTableAdapter1.Fill(Me.AukDatabaseDataSet.Options)
        AukF.Db_Load("sELF_roW_ID,SELF_ROW_COLUMN", "Self_row_column", Me.AukDatabaseDataSet.Self_Row_Column, True, "", False, False, CInt(My.Settings.MaximumData_load.ToString))
        Me.DataView1.Table = Me.AukDatabaseDataSet.Type
        Me.TypeTableAdapter1.Fill(Me.AukDatabaseDataSet.Type)
        If My.Settings.DataLoad_view = False And Hook = False Then
            If My.Settings.DRENT_ADEW_LASTMOVIE = True Then
                ADSRC.Load_Only_LastRecord(Me.AukDatabaseDataSet.Product_Collection)
            Else
                SFC("Place")
                STC("InStore")
                AukF.Db_Load("*", "Product_collection", Me.Product_CollectionBindingSource, False, My.Settings.DVDOPT_ORDERBY.ToString, False, False, CInt(My.Settings.MaximumData_load.ToString), 0)
            End If
   
            'AukF.Db_Load("costomer_ID", Tm1.TableName, Tm1, False, "", False, False, 200, 0)
            'AukF.SuggestListSourceAdd_DataTableOpen(Me.Costomer_IDLoad, Tm1, 0, 200)
        End If
        Me.ToolStripComboBox1.SelectedIndex = 2
        SoftIn.TOOLSTRIP_COMBO_DATASOURCE(Me.MOVIE_TYPELIST, Me.AukDatabaseDataSet.Type, 1, True, False)
        'FBnd.DataSource = Me.AukDatabaseDataSet.Product_Collection


    End Sub


    Private Sub Product_CollectionDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Product_CollectionDataGridView.CellDoubleClick
        If e.ColumnIndex = 6 Then

            dvdid = sender(0, e.RowIndex).value.ToString
            CosID = sender(6, e.RowIndex).value.ToString
            DVDView(CosID, dvdid)
        ElseIf e.ColumnIndex = 8 Then
            dvdid = sender(0, e.RowIndex).value.ToString
            COST = sender(8, e.RowIndex).value.ToString
            If Val(COST) > 0 Then
                ViewInfo2.DVDVIEW1(dvdid)

            End If
        End If
    End Sub

    Private Sub Product_CollectionDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Product_CollectionDataGridView.CellEndEdit
        On Error Resume Next
        Dim D As DataGridView = sender
        Dim ItPrice As Double
        Dim R As DataRow
        Dim NB1 As String
        'Dim Item_Price As Double
        ItPrice = Val(sender(1, e.RowIndex).value.ToString)
        Dim DvdRate As Double = My.Settings.Dvd_Bro_price
        Dim CdRate As Double = My.Settings.CD_bro_price
        If My.Settings.ALWAYS_DVDINFO_STORE = True Then
            If e.RowIndex > 0 Then
                INDEX_DATACHAGE(sender, 1)
                INDEX_DATACHAGE(sender, 2)
                INDEX_DATACHAGE(sender, 3)
                INDEX_DATACHAGE(sender, 9)
                INDEX_DATACHAGE(sender, 12)
                INDEX_DATACHAGE(sender, 13)
                'INDEX_DATACHAGE(sender, 14)
            End If
        End If

        TRow = D.CurrentCell.RowIndex
        TCol = D.CurrentCell.ColumnIndex
        sr = AukF.GridT(Me.Product_CollectionDataGridView, 5).ToString
        If sr = "" Then
            Me.Product_CollectionDataGridView.CurrentCell.DataGridView(5, TRow).Value = Now.Date.ToString
        End If
        sr = AukF.GridT(Me.Product_CollectionDataGridView, 1).ToString
        t14x = Val(AukF.GridT(Me.Product_CollectionDataGridView, 13).ToString)
        sa = AukF.GridT(Me.Product_CollectionDataGridView, 3).ToString
        If AukF.FindTxt(sa, "dvd") = True Then
            If ItPrice = 0 Then
                If sr = "" Then
                    Me.Product_CollectionDataGridView.CurrentCell.DataGridView(1, TRow).Value = DvdRate
                End If
            End If
            If t14x = 0 Then
                Me.Product_CollectionDataGridView(13, e.RowIndex).Value = Val(Me.AukDatabaseDataSet.Options.Item(0).Item(3).ToString)
            End If
        ElseIf AukF.FindTxt(sa, "cd") = True Then
            If ItPrice = 0 Then
                If sr = "" Then
                    Me.Product_CollectionDataGridView.CurrentCell.DataGridView(1, TRow).Value = CdRate
                End If
            End If
            If t14x = 0 Then
                Me.Product_CollectionDataGridView(13, e.RowIndex).Value = Val(Me.AukDatabaseDataSet.Options.Item(0).Item(2).ToString)
            End If
        Else
            If t14x = 0 Then
                Me.Product_CollectionDataGridView(13, e.RowIndex).Value = Val(Me.AukDatabaseDataSet.Options.Item(0).Item(3).ToString)
            End If
        End If
        sr = AukF.GridT(Me.Product_CollectionDataGridView, 7).ToString
        If sr = "" Then
            Me.Product_CollectionDataGridView.CurrentCell.DataGridView(7, TRow).Value = "InStore"
        End If
        If e.ColumnIndex = 11 Then
            If sender(7, e.RowIndex).value = "Sold" Or sender(7, e.RowIndex).value = "Broken" Then
                If sender(11, e.RowIndex).value >= 0 Then
                    sender(10, e.RowIndex).value = Val(ItPrice) + Val(ItPrice * (My.Settings.Benefit_DVDSold / 100)) - Val(sender(11, e.RowIndex).value.ToString) ' 11 IS DISCOUNT
                    'MsgBox(ItPrice)
                End If
            End If
        End If
        If My.Settings.DVDOPT_MOVIE_ADVANCE_EQ_MTYPE = True Then
            If sender(12, e.RowIndex).VALUE.ToString = "" Then
                MXD1 = sender(2, e.RowIndex).VALUE.ToString
                If MXD1 <> "" Then
                    R = Me.AukDatabaseDataSet.Type.FindByMovie_Type(CInt(MXD1))
                    If R IsNot Nothing Then
                        sender(12, e.RowIndex).VALUE = R.Item(1).ToString
                    End If
                End If
            End If
        End If
        If My.Settings.DVDOPT_AUTOMACI_DVDID = True Then
            If D(0, e.RowIndex).Value.ToString = "" Then
                If e.RowIndex = 0 Then
                    SoftIn.DataGrid_MasterID_ByDate(D, 10)
                Else
                    If D(0, e.RowIndex - 1).Value.ToString <> "" Then
                        If IsNumeric(D(0, e.RowIndex - 1).Value.ToString) = True Then
                            D(0, e.RowIndex).Value = CDec(D(0, e.RowIndex - 1).Value.ToString) + 1
                        Else
                            NB1 = D(0, e.RowIndex - 1).Value.ToString
                            NA1 = NB1.Split(My.Settings.DVDID_TOKEN.ToString).GetValue(1).ToString
                            D(0, e.RowIndex).Value = NB1.Split(My.Settings.DVDID_TOKEN.ToString).GetValue(0).ToString & My.Settings.DVDID_TOKEN.ToString & Val(NA1) + 1
                        End If
                    End If
                End If
            End If
        End If
        Me.AUTOMATICDVDIDWHENNULLToolStripMenuItem.Checked = My.Settings.DVDOPT_AUTOMACI_DVDID
        If My.Settings.DIRECT_SAVE = True Then
            Product_CollectionBindingNavigatorSaveItem_Click(sender, e)
        End If
    End Sub
    Private Function INDEX_DATACHAGE(ByVal D As DataGridView, ByVal INDEX1 As Integer)
        Dim rN1 As Integer = D.CurrentCell.RowIndex
        Try
            If rN1 > 0 Then
                If D(INDEX1, rN1).Value.ToString = "" Then
                    If D(INDEX1, rN1 - 1).Value.ToString <> "" Then
                        D(INDEX1, rN1).Value = D(INDEX1, rN1 - 1).Value
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Function
    Public Sub OpenWholeDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenWholeDatabaseToolStripMenuItem.Click
        'If AukF.MsgTr(What & "Open all data...?") = True Then
        '    Me.AukDatabaseDataSet.DVD_Rent.Clear()
        '    Me.Product_CollectionTableAdapter.Fill(Me.AukDatabaseDataSet.Product_Collection)
        'End If
        ADSRC.LOAD_WHOLE_DATABASE(Me.AukDatabaseDataSet.Product_Collection, True, "*", My.Settings.DVDOPT_ORDERBY.ToString)
    End Sub
    Private Sub QueryManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryManagerToolStripMenuItem.Click, ToolStripButton4.ButtonClick, ToolStripMenuItem23.Click, ToolStripMenuItem54.Click
        'AukQ.Bnp = Me.Product_CollectionBindingSource
        'AukQ.dV = Me.Product_CollectionDataGridView
        'FrmL(AukQ)
        DVDRENT.ShowQr_Product(Me.Product_CollectionDataGridView, Me.Product_CollectionBindingSource)
    End Sub

    Private Sub ClearDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearDatabaseToolStripMenuItem.Click
        If AukF.MsgTr(What & "Clear Database[PLEASE SAVE BEFORE DO THIS]?") = True Then Me.AukDatabaseDataSet.Product_Collection.Clear()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SameProductsInputToolStripMenuItem.Click, ToolStripMenuItem39.Click, ToolStripMenuItem30.Click
        Dim Rowq As DataRow

        'Try
        qw = InputBox("Please Type DVD_ID as : DVD_ID1,DVD_ID2,DVD_ID3 etc...,Same Dvds", "Same DVD Input", qw)
        dvdid = Me.Product_CollectionDataGridView.CurrentCell.DataGridView(0, Me.Product_CollectionDataGridView.CurrentCell.RowIndex).Value.ToString
        Rowq = Me.AukDatabaseDataSet.Product_Collection.FindByDVD_ID(dvdid)
        GoTo ba
        'Catch ex As Exception
        '    Epx()
        'End Try
        'Exit Sub
ba:
        Try
            AukF.CommonRowsAdd(Rowq, qw, 0, "", "", ",", Me.Product_CollectionDataGridView, Me.ToolStripProgressBar1, True)
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        SFC("DVD_ID")
        STC(Me.ToolStripTextBox1.Text)
        AukF.Db_Load("*", "Product_Collection", Me.Product_CollectionBindingSource, False, My.Settings.DVDOPT_ORDERBY, False, False, 100, -1)
        AukF.BindGotoFind(Me.Product_CollectionBindingSource, "DVD_ID", Me.ToolStripTextBox1.Text)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedItemsEntryToolStripMenuItem.Click, ToolStripMenuItem40.Click, ToolStripMenuItem31.Click
        FrmL(CommonAdd)

    End Sub

    Private Sub CurrentItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentItemToolStripMenuItem.Click
        AukF.Single_DataRecordRefresh(Me.Product_CollectionBindingSource, True)
    End Sub

    Private Sub WholeDataTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WholeDataTableToolStripMenuItem.Click, ToolStripButton3.ButtonClick
        AukF.SingleDataTable_DataRecordRefresh(Me.Product_CollectionBindingSource, True)

    End Sub



    Private Sub SelfSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelfSettingsToolStripMenuItem.Click
        FrmL(SelfEntry)


    End Sub

    Private Sub OpenExactFromFirstToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenExactFromFirstToolStripMenuItem.Click
        SFC("Movie_Name")
        STC(ToolStripTextBox2.Text)
        AukF.Db_Load("*", "Product_collection", Me.Product_CollectionBindingSource, False, "", True, True, 100, -1)
        AukF.DivideIn_To_2(Sql, "where")
        Try
            If Me.Product_CollectionBindingSource.Filter Is Nothing Then
                Me.Product_CollectionBindingSource.Filter = QA2
            ElseIf Me.Product_CollectionBindingSource.Filter <> QA2 Then
                Me.Product_CollectionBindingSource.Filter = QA2
            End If
        Catch ex As Exception
            Epx(QA2)
        End Try

    End Sub

    Private Sub ReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReToolStripMenuItem.Click, RemoveFilterToolStripMenuItem.Click, ToolStripMenuItem44.Click, REMOVEFILTERToolStripMenuItem2.Click, ToolStripMenuItem20.Click, ToolStripMenuItem52.Click
        Me.Product_CollectionBindingSource.RemoveFilter()

    End Sub
    Private Sub TabPage1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        Me.Text = sender.text
    End Sub
    Public Sub MVisFl()
        Me.Pn_1.Visible = False
        Me.Pn_comments.Visible = False
        Me.Pn_Details.Visible = False
    End Sub
    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        Me.Text = sender.text
        If Rent = False Then
            Me.Costomer_IDLoad.Focus()
            MVisFl()

        Else
            Me.Product_CollectionDataGridView.Focus()

        End If
    End Sub
    Public Sub LoadCostomer2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CosID = Costomer_IDLoad.Text
        SFC("Costomer_ID")
        STC(CosID)
        AukF.Db_Load("*", "Costomer_Inf", Me.AukDatabaseDataSet)
        If Me.AukDatabaseDataSet.Costomer_Inf.Rows.Count = 1 Then
            SFC("Costomer_ID", "Place")
            STC(CosID, "InHand")
            AukF.Db_Load("*", "DVD_Rent", Me.AukDatabaseDataSet)
            CusR = Me.AukDatabaseDataSet.Costomer_Inf(0)
            Alt_name = ""
            Rent = True
            Try
                Me.Product_CollectionBindingSource.Filter = "Place='InStore'"
            Catch ex As Exception
                Epx()
            End Try
            Me.DVD_RentDataGridView.ReadOnly = False
            If Me.DVD_RentBindingSource.Count > 0 Then Me.DVD_RentDataGridView.DataSource = Me.DVD_RentBindingSource
            'Me.Costomers_nameLabel.Text = CusR.Item(2).ToString
            'SoftIn.TxtColor_NumberDefine(Me.Advance_FeesLabel1, CDec(Me.AukDatabaseDataSet.Options(0).Item(4).ToString), Color.Red, Color.White, Color.Transparent, Color.Black, "ge")
            If Me.DVD_RentBindingSource.Count = 0 Then
                Me.Pn_1.Visible = True
                Me.Pn_Details.Visible = True
                Me.Button4.Focus()
            Else
                Me.DVD_RentDataGridView.Focus()
            End If
            Me.Pn_Details.Height = 180
            If AukF.BindFind(True, Me.Costomer_CommentsBindingSource, 0, CosID) Then
                For k As Integer = 0 To Me.AukDatabaseDataSet.Costomer_Comments.Columns.Count - 1
                    If Me.AukDatabaseDataSet.Costomer_Comments.Rows(0).Item(k) = "" Then
                    Else
                        Me.Pn_comments.Visible = True
                        Exit For
                    End If
                Next
            Else
                Me.Pn_comments.Visible = False
            End If
        ElseIf Me.AukDatabaseDataSet.Costomer_Inf.Rows.Count = 0 Then
            MsgBox("This Costomer id is not valid...", MsgBoxStyle.Critical)
            Me.Pn_1.Visible = False
            Me.Pn_Details.Visible = False
            Me.Pn_comments.Visible = False

            Rent = False
            Me.DVD_RentDataGridView.ReadOnly = True
            'Me.Costomers_nameLabel.Text = "Costomer Name"

        End If
        SetShow(CosID)

    End Sub
    Public Function LOADING_COSTOMER(ByVal CUSTOMERID As String, ByVal ALT_NAME As String) As Boolean
        Dim MaxCan As Integer
        If Rent = True Then MsgBox("Please let the Customer off.", MsgBoxStyle.Information) : Exit Function

        CosID = CUSTOMERID
        SFC("Costomer_ID")
        STC(CosID)
        AukF.Db_Load("*", "Costomer_Inf", Me.AukDatabaseDataSet)
        If Me.AukDatabaseDataSet.Costomer_Inf.Rows.Count = 1 Then
            SFC("Costomer_ID", "Place")
            STC(CosID, "InHand")
            AukF.Db_Load("*", "DVD_Rent", Me.AukDatabaseDataSet)
            'MsgBox(Sql, , Sql)
            CusR = Me.AukDatabaseDataSet.Costomer_Inf(0)
            ALT_NAME = ALT_NAME
            'Rent = True
            LOADING_COSTOMER = True
            fees = Val(CusR.Item(8).ToString)
            If Val(fees) >= Val(Me.AukDatabaseDataSet.Options(0).Item(4).ToString) Then
                MaxCan = CInt(My.Settings.MaxDVD_RentNumber)
            Else
                MaxCan = CInt(My.Settings.DVDRentNumberNonReg)
            End If
            Filter_Instore_Products()

            Me.DVD_RentDataGridView.ReadOnly = False
            If Me.DVD_RentBindingSource.Count > 0 Then Me.DVD_RentDataGridView.DataSource = Me.DVD_RentBindingSource
            'Me.Costomers_nameLabel.Text = CusR.Item(2).ToString
            If Me.DVD_RentBindingSource.Count > 0 Then
                If AukF.MsgTr("THIS MEMBER ALREADY HAVE " & Me.DVD_RentBindingSource.Count & " DVD OR CD,DO YOU WANT TO RENT HIM/HER?") = True Then
                    LOADING_COSTOMER = True
                    'Rent = True
                Else
                    LOADING_COSTOMER = False
                    'Rent = False
                End If
            End If
        ElseIf Me.AukDatabaseDataSet.Costomer_Inf.Rows.Count = 0 Then
            MsgBox(UCase(CosID) & " THIS CUSTOMER ID IS NOT VALID.", MsgBoxStyle.Critical)
            LOADING_COSTOMER = False
            'Rent = False
        End If
    End Function
    Public Sub LoadCostomer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.ButtonClick
        Dim MaxCan As Integer
        If Rent = True Then MsgBox("Please let the Customer off.", MsgBoxStyle.Information) : Exit Sub
        CosID = Costomer_IDLoad.Text
        SFC("Costomer_ID")
        STC(CosID)
        AukF.Db_Load("*", "Costomer_Inf", Me.AukDatabaseDataSet)
        'MsgBox(Sql)
        If Me.AukDatabaseDataSet.Costomer_Inf.Rows.Count = 1 Then
            Me.Label1.Text = ""
            SFC("Costomer_ID")
            STC(CosID)
            AukF.Db_Load("*", "costomer_comments", Me.AukDatabaseDataSet, False)
            SFC("Costomer_ID", "Place")
            STC(CosID, "InHand")
            AukF.Db_Load("*", "DVD_Rent", Me.AukDatabaseDataSet)
            CusR = Me.AukDatabaseDataSet.Costomer_Inf(0)
            Alt_name = ""
            Rent = True
            fees = Val(CusR.Item(8).ToString)
            If Val(fees) >= Val(Me.AukDatabaseDataSet.Options(0).Item(4).ToString) Then
                MaxCan = CInt(My.Settings.MaxDVD_RentNumber)
            Else
                MaxCan = CInt(My.Settings.DVDRentNumberNonReg)
            End If
            'filters before clients movies
            Filter_Instore_Products()
            Me.DVD_RentDataGridView.ReadOnly = False
            If Me.DVD_RentBindingSource.Count > 0 Then Me.DVD_RentDataGridView.DataSource = Me.DVD_RentBindingSource
            'Me.Costomers_nameLabel.Text = CusR.Item(2).ToString
            'SoftIn.TxtColor_NumberDefine(Me.Advance_FeesLabel1, Val(Me.AukDatabaseDataSet.Options(0).Item(4).ToString), Color.Red, Color.White, Color.Transparent, Color.Black, "ge")
            'MsgBox(fees)
            If Me.DVD_RentBindingSource.Count = 0 Then
                Me.Pn_1.Visible = True
                Me.Pn_Details.Visible = True
                Me.Button4.Focus()
            Else
                Me.DVD_RentDataGridView.Focus()
            End If
            Me.Pn_Details.Height = 180
            If AukF.BindFind(Me.Costomer_CommentsBindingSource, "Costomer_ID", CosID, True) Then
                For k As Integer = 0 To Me.AukDatabaseDataSet.Costomer_Comments.Columns.Count - 1
                    If Me.AukDatabaseDataSet.Costomer_Comments.Rows(0).Item(k) = "" Then
                    Else
                        Me.Pn_comments.Visible = True
                        Exit For
                    End If
                Next
            Else
                Me.Pn_comments.Visible = False
            End If
        ElseIf Me.AukDatabaseDataSet.Costomer_Inf.Rows.Count = 0 Then
            MsgBox(UCase(CosID) & " THIS CUSTOMER ID IS NOT VALID,PLEASE CHECK AGAIN.", MsgBoxStyle.Critical)
            Me.Pn_1.Visible = False
            Me.Pn_Details.Visible = False
            Me.Pn_comments.Visible = False
            Rent = False
            Me.DVD_RentDataGridView.ReadOnly = True
            Me.Costomers_nameLabel.Text = "DVD ID"
        End If
        SetShow(CosID)
    End Sub
    Private Sub Filter_Instore_Products()
        If My.Settings.DVDOPT_PREVIOUS_MOVIE_COSTOMER = True Then
            Try
                SoftIn.Ram_Get_inf()
                If Me.AukDatabaseDataSet.Product_Collection.Count = 0 Then
                    Exit Sub
                End If
                'MsgBox(RamT / Me.AukDatabaseDataSet.Product_Collection.Count)
                If (RamT / Me.AukDatabaseDataSet.Product_Collection.Count) < 0.002 Then
                    If AukF.MsgTr("Filter Store Movies 'InStore'? It's risky because of your memory space." & vbCrLf & WGeT, True, MsgBoxStyle.Critical) = False Then
                        Exit Sub
                    End If
                End If
                'AukF.MsgTr("Filter Stock Products 'InStore'? It's risky because of your memory space and his/her rent movies,he or she had rented most movies in your store." & vbCrLf & WGeT, True, MsgBoxStyle.Critical)
                If Me.Product_CollectionBindingSource.Filter IsNot Nothing Then
                    If InStr(Me.Product_CollectionBindingSource.Filter.ToString, "Place='InStore'", CompareMethod.Text) = 0 Then
                        Me.Product_CollectionBindingSource.Filter = "Place='InStore'"
                    End If
                Else
                    Me.Product_CollectionBindingSource.Filter = "Place='InStore'"
                End If
            Catch ex As Exception
                Epx()
            End Try
        End If
  
    End Sub
    Private Sub CustomerID_TextBox_KeyDonwEffect(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Costomer_IDLoad.KeyDown
        If e.Control = True And e.Shift = True And e.KeyCode = Keys.Enter Then
            'bad rec
            SFC("Costomer_ID", "Is_Comments_Bad")
            STC(sender.text, "y")
            DTC("", "b")
            AukF.Db_Load("*", "DVD_RENT", Me.DVD_RentBindingSource, False, "", False, False, Val(My.Settings.MaximumData_load), -1)
            Me.DVD_RentDataGridView.DataSource = Me.DVD_RentBindingSource
        ElseIf e.Control = True And e.KeyCode = Keys.Enter Then
            SFC("Costomer_ID")
            STC(sender.Text)
            AukF.Db_Load("*", "Dvd_rent", Me.DVD_RentBindingSource, True, "", False, False, Val(My.Settings.MaximumData_load), -1)
        ElseIf e.KeyCode = Keys.Enter Then
            c = sender.text 'geting text
            Try
                c = CDate(c)
                SFC("Date_Rent")
                STC(c)
                DTC("d")
                AukF.Db_Load("*", "Dvd_rent", Me.DVD_RentBindingSource, True, "", False, False, Val(My.Settings.MaximumData_load), -1)
            Catch ex As Exception
                LoadCostomer(sender, e)
            End Try
        End If
    End Sub
    Private Sub SelectedItemsSelfAddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedItemsSelfAddToolStripMenuItem.Click, ToolStripMenuItem36.Click
        FrmL(SelfCommonAdd)
    End Sub

    Private Sub AlternativeShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlternativeShowToolStripMenuItem.Click, Button8.Click, ToolStripButton30.Click, ToolStripMenuItem38.Click
        CostomerCheck.TextBox1.Text = CosID
        FrmL(CostomerCheck)
        CostomerCheck.Button9_Click(sender, e)
    End Sub
    Public Function SEND_MOVIES_BY_DVDID(ByVal SENDER As Object, ByVal DVDID As String, Optional ByVal SendAs As String = "InHand", Optional ByVal iF_INHAND_FALSE_THEN_SEND As Boolean = True, Optional ByVal DUE As Boolean = False)
        Dim R As AukDatabaseDataSet.DVD_RentRow
        Dim R2 As AukDatabaseDataSet.Product_CollectionRow
        Dim RentPr As Decimal
        Dim MoVIE_F As Boolean = False
        'Dim DId As String
        If Rent = True Then
            If LCase(CusR.Item("Costomer_Category").ToString) = "costin" Then 'maximam movies information
                MaxCan = CInt(My.Settings.MaxDVD_RentNumber)
            Else
                MaxCan = CInt(My.Settings.DVDRentNumberNonReg)
            End If
            If Me.DVD_RentBindingSource.Count >= MaxCan Then
                MsgBox(UCase("This customer have due money in 'Advance Fees'" & vbCrLf & " he gave '" & fees & "' he can bought only '" & MaxCan & "' Dvd or Cd.Please check  his informations."), MsgBoxStyle.Critical)
                MsgBox("Sorry,he/she can't rent more dvd/cd than " & maxcan & ".", MsgBoxStyle.Exclamation)
                Exit Function
            End If
            If AukF.FindTxt(DVDID, ",") = True Then
                SFC("DVD_ID")
                STC(DVDID) 'get str as 1,2,3='1','2','3'
                ExpreC("in")
            Else
                SFC("DVD_ID")
                STC(DVDID)
            End If
            AukF.Db_LoadN(DVD, -1, "PRODUCT_COLLECTION", True)
            'MsgBox(Sql)
            If DVD.Rows.Count > 0 Then
                For Mxa As Integer = 0 To DVD.Rows.Count - 1
                    R2 = DVD.Rows(Mxa) 'DVD ROW FROM PRODUCT COLLECTION
                    DVDID = R2("DVD_ID").ToString
                    If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Product_Collection, DVDID) = False Then
                        SFC("DVD_ID")
                        STC(DVDID)
                        AukF.Db_LoadN(Me.AukDatabaseDataSet.Product_Collection, -1, "PRODUCT_COLLECTION", False)
                    End If
                    If R2("PLace").ToString.ToUpper = "INSTORE" Then
                        GoTo ADDIN
                    ElseIf R2(6).ToString.ToUpper = "INHAND" Then
                        BSA = R2("PLace").ToString  'BEFORE PLACE
                        If SendAs.ToUpper = UCase(BSA) And SendAs.ToUpper = "INHAND" Then
                            MNAME = R2.Item("Movie_Name").ToString  ' MOVIE NAME
                            LCUSTOMER = R2.Item("Costomer_ID").ToString  ' LAST CUSTOMER ID
                            If AukF.MsgTr("DVD ID:" & UCase(DVDID) & " , " & "MOVIE NAME:" & UCase(MNAME) & "," & "LAST CUSTOMER ID:" & UCase(LCUSTOMER) & "." & vbCrLf & "CURRENT MOVIE IS IN (" & LCUSTOMER & ")'S  HAND ,DO YOU WANT TO GIVE THIS TO ANOTHER CUSTOMER (" & CStr(CusR.Costomer_ID).ToUpper & ") ?", False, MsgBoxStyle.Critical, "CURRENT MOVIE IS INHAND") = True Then
                                Dim RentTable As New AukDatabaseDataSet.DVD_RentDataTable
                                SFC("DVD_ID", "Place", "Costomer_ID")
                                STC(DVDID, "INHAND", LCUSTOMER) 'get str as 1,2,3='1','2','3'
                                AukF.Db_LoadN(RentTable, -1, "DVD_RENT", True)
                                If RentTable.Rows.Count > 0 Then
                                    R = RentTable.Rows(0)
                                    If R.Due = True Then
                                        If AukF.MsgTr("DVD ID:" & UCase(DVDID) & " , " & "MOVIE NAME:" & UCase(MNAME) & "," & "LAST CUSTOMER ID:" & UCase(LCUSTOMER) & "." & vbCrLf & "IT'S DUE OPTION IS CHECK TRUE.IF YOU CLICK YES,DUE WILL BE CHECK FALSE AND PLACE=INSTORE.", False, MsgBoxStyle.Exclamation) = True Then
                                            R.Due = False
                                            R.Place = "InStore"
                                            Me.DVD_RentTableAdapter.Update(R)
                                            'R2.Place = "InStore"
                                            'Me.Product_CollectionTableAdapter.Update(R2)
                                            GoTo ADDIN
                                        Else
                                            Exit Function
                                        End If
                                    Else 'if due=false
                                        'if current costomer is not interrested in that
                                        'so before place of product collect make =instore,and dvdrent place=instore
                                        'if he/she borrow this movie again that it will reserve again
                                        R.Due = False
                                        R.Place = "InStore"
                                        Me.DVD_RentTableAdapter.Update(R)
                                        'R2.Place = "InStore"
                                        'Me.Product_CollectionTableAdapter.Update(R2)
                                        GoTo ADDIN
                                    End If
                                Else
                                    GoTo ADDIN
                                End If
                            End If
                        End If
                    Else
                        BSA = R2("PLace").ToString  'BEFORE PLACE
                        If SendAs.ToUpper = UCase(BSA) And SendAs.ToUpper = "INHAND" Then
                            MNAME = R2.Item("Movie_Name").ToString ' MOVIE NAME
                            LCUSTOMER = R2.Item("Costomer_ID").ToString    ' LAST CUSTOMER ID
                            MsgBox("DVD ID:" & UCase(DVDID) & " , " & "MOVIE NAME:" & UCase(MNAME) & "," & "PLACE : " & R2("PLace").ToString.ToUpper & " ?", MsgBoxStyle.Critical, "PLACE : " & R2("PLace").ToString.ToUpper)
                        End If
                    End If


                    TRntC()
                    Exit Function
ADDIN:              CUS_ID = CStr(CusR.Costomer_ID).ToString.ToUpper
                    If My.Settings.DVD_OPT_ALWAYSrEMIND = True And Me.BEFORE_MOVIE(DVDID, CUS_ID) = True Then
                        MNAME = CStr(R2.Movie_Name).ToUpper  ' MOVIE NAME
                        If AukF.MsgTr("DVD ID:" & UCase(DVDID) & " , " & "MOVIE NAME:" & UCase(MNAME) & "." & vbCrLf & "CURRENT CUSTOMER RENT THIS MOVIE BEFORE.DO YOU WANT TO RENT HIM/HER AGAIN?") = False Then
                            Exit Function
                        End If
                    End If
                    'if rent db= found
                    If AukF.BindFind(Me.DVD_RentBindingSource, "DVD_ID", DVDID) = True Then
                        R = Me.AukDatabaseDataSet.DVD_Rent(ComRow)
                        MoVIE_F = True
                    Else
                        MoVIE_F = False
                        R = Me.AukDatabaseDataSet.DVD_Rent.NewDVD_RentRow
                    End If
                    Dim InsDate, AddDate As Date
                    Dim Distance As Decimal
                    'r2 is product collection Row
                    R.ID = SoftIn.Master_ID_String_Get(7)
                    R.Costomer_ID = CusR.Costomer_ID
                    R.Costomer_Name = CusR.Item("Costomer_Name").ToString
                    R.Place = SendAs
                    R.DVD_ID = R2.DVD_ID
                    R.Movie_Type = R2.Item("Movie_Type").ToString
                    R.Movie_Name = R2.Item("Movie_Name").ToString
                    R.Date_Rent = Now
                    'optional maximum rent days option
                    'InsMNewDays_DvdOpt=ins movie begin new for days 
                    'R.Return_date = Now.AddDays(Val(My.Settings.Rent_Days))
                    InsDate = CDate(R2.Item("Inserted_date").ToString)
                    Distance = DateDiff(DateInterval.Day, InsDate, CDate(NDate()))
                    If Distance > Val(My.Settings.InsMNewDays_DvdOpt.ToString) Then
                        'old movie ena,old maximum rent in days ,=rent_Days
                        AddDate = Now.AddDays(Val(My.Settings.Rent_Days))
                    Else 'begin new
                        AddDate = Now.AddHours(Val(My.Settings.NewMovies_MaxRentH))
                    End If
                    R.Return_date = AddDate
                    'fins maximum Rent Days
                    R.Alternative_Name = Alt_name
                    R.Due = DUE
                    R.Date_ = CDate(NDate())
                    RentPr = Val(R2.Rent_Price.ToString)
                    If Val(RentPr) > 0 Then
                        R.Pay_Money = RentPr
                    Else
                        If AukF.FindTxt(Str3, "dvd") = True Then
                            R.Pay_Money = Val(Me.AukDatabaseDataSet.Options(0).Item("Company_DVD_Rent").ToString)
                        Else
                            R.Pay_Money = Val(Me.AukDatabaseDataSet.Options(0).Item("Company_CD_Rent").ToString)
                        End If
                    End If
                    NewAdd = NewAdd + Val(R.Item("Pay_Money").ToString) 'add new movies cost

                    Try
                        If MoVIE_F = False Then R.Table.Rows.Add(R)
                    Catch ex As Exception
                        Epx()
                    End Try
                    'R2.Costomer_ID = CUS_ID
                    'R2.Place = SendAs
                    If Me.Label1.Text = "" Then
                        Me.Label1.Text = "[" & DVDID & "]"
                    Else
                        If InStr(Me.Label1.Text, "[" & DVDID & "]") = 0 Then
                            Me.Label1.Text = Me.Label1.Text & "," & "[" & DVDID & "]"
                        End If
                    End If
                Next
            Else 'for the count >0 
                MsgBox("DVD[ " & DVDID & " ] IS NOT FOUND IN DATABASE.", MsgBoxStyle.Critical)
                Try
                    SENDER.FOCUS()
                Catch ex As Exception
                End Try
            End If
        Else 'for the rent=false
            MsgBox("PLEASE LOAD A CUSTOMER FIRST", MsgBoxStyle.Information)
        End If
        TRntC()
            SENDER.FOCUS()

    End Function
    Public Function SEND_MOVIES(ByVal CUS_ID As String, ByVal CUS_NAM As String, ByVal ALTER_nNAME As String, ByVal ROWINT As Integer, Optional ByVal SENDAS As String = "InHand", Optional ByVal Duex As Boolean = False)
        Dim unix As DataRow
        Dim DVDID As String
        Dim MaxCan As Integer
        Dim Str1, Str2, Str3, RentPr, InsDateStr1 As String
        If ROWINT <= -1 Then Exit Function
        If Me.Product_CollectionDataGridView.RowCount = 0 Then Exit Function
        If Rent = False Then Exit Function
        'try on maxcan ,that he can accpet moves
        If LCase(CusR.Item("Costomer_Category").ToString) = "costin" Then 'maximam movies information
            MaxCan = CInt(My.Settings.MaxDVD_RentNumber)
        Else
            MaxCan = CInt(My.Settings.DVDRentNumberNonReg)
        End If
        If Me.DVD_RentBindingSource.Count >= MaxCan Then
            MsgBox(UCase("This customer have due money in 'Advance Fees'" & vbCrLf & " he gave '" & fees & "' he can bought only '" & MaxCan & "' Dvd or Cd.Please check  his informations."), MsgBoxStyle.Critical)
            MsgBox("Sorry,he/she can't rent more dvd/cd than " & MaxCan & ".", MsgBoxStyle.Exclamation)
            Exit Function
        End If
        'If Rent = True Then
        DVDID = AukF.GridT(Me.Product_CollectionDataGridView, 0, ROWINT) 'dvdid
        'MsgBox(DVDID)

        BSA = AukF.GridT(Me.Product_CollectionDataGridView, 7, ROWINT) 'BEFORE PLACE
        If BSA = SENDAS And SENDAS.ToUpper = "INHAND" Then
            MNAME = AukF.GridT(Me.Product_CollectionDataGridView, 4, ROWINT) ' MOVIE NAME
            LCUSTOMER = AukF.GridT(Me.Product_CollectionDataGridView, 6, ROWINT) ' LAST CUSTOMER ID
            If AukF.MsgTr("DVD ID:" & UCase(DVDID) & " , " & "MOVIE NAME:" & UCase(MNAME) & "," & "LAST CUSTOMER ID:" & UCase(LCUSTOMER) & "." & vbCrLf & "CURRENT MOVIE IS IN (" & LCUSTOMER & ")'S  HAND ,DO YOU WANT TO GIVE THIS TO ANOTHER CUSTOMER (" & CUS_ID & ") ?", False, MsgBoxStyle.Critical, "CURRENT MOVIE IS INHAND") = False Then
                Exit Function
            End If
        End If
        If My.Settings.DVD_OPT_ALWAYSrEMIND = True Then 'is before current costomer rent this move or not
            If Me.BEFORE_MOVIE(DVDID, CUS_ID) = True Then
                MNAME = AukF.GridT(Me.Product_CollectionDataGridView, 4, ROWINT) ' MOVIE NAME
                LCUSTOMER = AukF.GridT(Me.Product_CollectionDataGridView, 6, ROWINT)  ' LAST CUSTOMER ID
                Dim RentTable As New AukDatabaseDataSet.DVD_RentDataTable
                SFC("DVD_ID", "Place", "Costomer_ID")
                STC(DVDID, "INHAND", LCUSTOMER) 'get str as 1,2,3='1','2','3'
                AukF.Db_LoadN(RentTable, -1, "DVD_RENT", True)
                If RentTable.Rows.Count > 0 Then
                    R = RentTable.Rows(0)
                    If R.Due = True Then
                        If AukF.MsgTr("DVD ID:" & UCase(DVDID) & " , " & "MOVIE NAME:" & UCase(MNAME) & "," & "LAST CUSTOMER ID:" & UCase(LCUSTOMER) & "." & vbCrLf & "IT'S DUE OPTION IS CHECK TRUE.IF YOU CLICK YES,DUE WILL BE CHECK FALSE AND PLACE=INSTORE.", False, MsgBoxStyle.Exclamation) = True Then
                            R.Due = False
                            R.Place = "InStore"
                            Me.DVD_RentTableAdapter.Update(R)
                            AukF.GridTSet(Me.Product_CollectionDataGridView, "InStore", 7, ROWINT)
                        Else
                            Exit Function
                        End If
                    Else 'if due=false
                        'if current costomer is not interrested in that
                        'so before place of product collect make =instore,and dvdrent place=instore
                        'if he/she borrow this movie again that it will reserve again
                        R.Due = False
                        R.Place = "InStore"
                        Me.DVD_RentTableAdapter.Update(R)
                        AukF.GridTSet(Me.Product_CollectionDataGridView, "InStore", 7, ROWINT)
                    End If
                End If
            End If
        End If
        If AukF.BindFind(Me.DVD_RentBindingSource, "DVD_ID", DVDID) = True Then
            unix = Me.AukDatabaseDataSet.DVD_Rent(ComRow)
        Else
            unix = Me.AukDatabaseDataSet.DVD_Rent.NewRow
        End If
        TRow = ROWINT
        Str1 = AukF.GridT(Me.Product_CollectionDataGridView, 4, TRow) 'mov_name
        Str2 = AukF.GridT(Me.Product_CollectionDataGridView, 2, TRow) 'mov_type
        Str3 = AukF.GridT(Me.Product_CollectionDataGridView, 3, TRow) 'mov _version
        RentPr = Val(AukF.GridT(Me.Product_CollectionDataGridView, 13, TRow)) 'mov _Rent Price
        InsDateStr1 = AukF.GridT(Me.Product_CollectionDataGridView, 5, TRow).ToString '5= ins date
        If Str2.Trim = "" Then
            If Me.AukDatabaseDataSet.Type.Rows.Count > 0 Then
                Str2 = Me.AukDatabaseDataSet.Type(0).Item(0).ToString
            Else
                MsgBox("Please Insert Movie Type ...Then Dop this...", MsgBoxStyle.Critical)
                Exit Function
            End If
        End If
        unix("ID") = SoftIn.Master_ID_String_Get(7)
        unix(1) = CUS_ID 'cos id
        unix(2) = CUS_NAM 'cos name
        unix(3) = SENDAS 'give to place
        unix(4) = DVDID 'dvd id
        unix(5) = Str2 'm type
        unix(6) = Str1 'm version
        unix(7) = CStr(TimeOfDay) 'rent date
        '8= return date=programmatic option maximum rent days
        'optional maximum rent days option
        'InsMNewDays_DvdOpt=ins movie begin new for days 
        Dim InsDate, AddDate As Date
        Dim Distance As Decimal
        If InsDateStr1 = "" Then InsDate = NDate() Else InsDate = CDate(InsDateStr1) 'before get from datatgrid

        Distance = DateDiff(DateInterval.Day, InsDate, CDate(NDate()))
        If Distance > Val(My.Settings.InsMNewDays_DvdOpt.ToString) Then
            'old movie ena,old maximum rent in days ,=rent_Days
            AddDate = Now.AddDays(Val(My.Settings.Rent_Days))
        Else 'begin new
            AddDate = Now.AddHours(Val(My.Settings.NewMovies_MaxRentH))
        End If
        unix("Return_date") = AddDate '8=return date
        'fins maximum Rent Days

        If Trim(Alt_name) <> "" Then
            unix(9) = ALTER_nNAME
            unix(10) = True
        Else
            unix(9) = ""
            unix(10) = False
        End If
        unix("Due") = Duex
        unix("Date_") = CDate(NDate())

        'unix(
        'Rent Price Set Before
        '---------------------------
        If Val(RentPr) <> 0 Then
            unix(13) = Val(RentPr)
        Else
            If AukF.FindTxt(Str3, "dvd") = True Then
                unix(13) = Val(Me.AukDatabaseDataSet.Options(0).Item("Company_DVD_Rent").ToString)
            Else
                unix(13) = Val(Me.AukDatabaseDataSet.Options(0).Item("Company_CD_Rent").ToString)
            End If
        End If
        NewAdd = NewAdd + Val(unix(13).ToString) 'add new movies cost,frm rent cost

        If AukF.BindFind(Me.DVD_RentBindingSource, "DVD_ID", DVDID) = False Then
            Me.AukDatabaseDataSet.DVD_Rent.Rows.Add(unix)
        End If
        'Me.Product_CollectionDataGridView(6, ROWINT).Value = CUS_ID 'SET LAST CUSTOMER
        'Me.Product_CollectionDataGridView(7, ROWINT).Value = SENDAS 'SET LAST CUSTOMER

        'End If
        If Me.Label1.Text = "" Then
            Me.Label1.Text = "[" & DVDID & "]"
        Else
            If InStr(Me.Label1.Text, "[" & DVDID & "]") = 0 Then
                Me.Label1.Text = Me.Label1.Text & "," & "[" & DVDID & "]"
            End If
        End If
        TRntC()
    End Function
    Public Sub TRntC()
        On Error Resume Next
        Dim DueDec As Decimal
        Dim NStr As String
        Dim Dstr2 As String = ""
        'Me.DVD_RentDataGridView.EndEdit()
        Me.DVD_RentBindingSource.EndEdit()
        If Me.AukDatabaseDataSet.DVD_Rent.Count > 0 Then
            Me.RentCostView.Text = Val(Me.AukDatabaseDataSet.DVD_Rent.Compute("Sum(Pay_money)", "Due=False").ToString)
            If Me.AukDatabaseDataSet.DVD_Rent.GetChanges IsNot Nothing Then
                If Me.AukDatabaseDataSet.DVD_Rent.GetChanges(DataRowState.Added) IsNot Nothing Then
                    NewAdd = Val(Me.AukDatabaseDataSet.DVD_Rent.GetChanges(DataRowState.Added).Compute("Sum(Pay_money)", "Due=False").ToString)
                    If NewAdd > 0 Then 'new ,movies add money
                        NStr = " ,NewRent Cost: " & NewAdd
                    Else
                        NStr = ""
                    End If
                End If
            Else
                NStr = ""
            End If
            c = Val(Me.AukDatabaseDataSet.DVD_Rent.Compute("Sum([Fine])", "[Fine] is not null"))
            Me.RentCostView.Text = Val(Me.RentCostView.Text) - NewAdd
            If Val(c) > 0 Then
                Me.RentCostView.Text = Me.RentCostView.Text & " ,Fine:" & c
            End If
            'next before due
            'DueDec = Val(Me.AukDatabaseDataSet.DVD_Rent.Compute("Sum([Pay_Money])", "Due=True"))
            DueDec = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Me.AukDatabaseDataSet.DVD_Rent, "DUE=TRUE", "Sum", "Pay_Money"))

            If Val(DueDec) > 0 Then
                Me.RentCostView.Text = Me.RentCostView.Text & " ,Due:" & DueDec
            End If
            Me.RentCostView.Text &= NStr
        Else
            Me.RentCostView.Text = "00"
        End If

    End Sub
    Private Sub SendItemsToCurrentCostoemrsAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendItemsToCurrentCostoemrsAccountToolStripMenuItem.Click, ToolStripMenuItem49.Click
        Dim riNT As Integer = 0
        'MsgBox(AukF.GridT(Me.Product_CollectionDataGridView, Me.Product_CollectionDataGridView.CurrentCell.RowIndex))
        If Rent = True Then
            If Me.Product_CollectionDataGridView.SelectedRows.Count = 0 Then
                SEND_MOVIES(CusR(0).ToString, CusR(2).ToString, Alt_name, Me.Product_CollectionDataGridView.CurrentCell.RowIndex, "InHand", due_CheckAddNewMov.Checked)
            Else
                For M As Integer = 0 To Me.Product_CollectionDataGridView.SelectedRows.Count - 1
                    riNT = Me.Product_CollectionDataGridView.SelectedRows(M).Index
                    SEND_MOVIES(CusR(0), CusR(2), Alt_name, riNT, "InHand", due_CheckAddNewMov.Checked)
                Next
            End If
        End If
    End Sub
    Public Sub SaveP2()
        Dim Aq As Integer
        Dim DvdId, DvdProfit, Place As String
        Dim MTb As New DataTable
        Dim Row As DataRow
        Dim MaxCan As Integer
        If Rent = True Then
            'fees = Val(CusR.Item(8).ToString)
            'If Val(fees) >= Val(Me.AukDatabaseDataSet.Options(0).Item(4).ToString) Then
            '    MaxCan = CInt(My.Settings.MaxDVD_RentNumber)
            'Else
            '    MaxCan = CInt(My.Settings.DVDRentNumberNonReg)
            'End If
            If LCase(CusR.Item("Costomer_Category").ToString) = "costin" Then 'maximam movies information
                MaxCan = CInt(My.Settings.MaxDVD_RentNumber)
            Else
                MaxCan = CInt(My.Settings.DVDRentNumberNonReg)
            End If
            If Me.DVD_RentBindingSource.Count > MaxCan Then
                MsgBox(UCase("This customer have due money in 'Advance Fees'" & vbCrLf & " he gave '" & fees & "' he can bought only '" & MaxCan & "' Dvd or Cd.Please check  his informations."), MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        Try
            Me.DVD_RentBindingSource.EndEdit()
            Me.DVD_RentTableAdapter.Update(Me.AukDatabaseDataSet.DVD_Rent)
        Catch ex As Exception
            Epx()
        End Try
        If Me.DVD_RentBindingSource.Count <= 100 Then
            AukF.Mother_DB_Load(Me.DVD_RentBindingSource, 4)
            SFC("Dvd_id")
            STC(GetStrs)
            ExpreC("i")
            AukF.Db_Load("DVD_ID,sum(pay_money),Sum(Fine)", "Dvd_rent", MTb, True, "DVD_ID", False, False, 50, 0, True)
            For Aq = 0 To MTb.Rows.Count - 1
                DvdId = MTb.Rows(Aq).Item(0).ToString
                If AukF.BindFind(Me.DVD_RentBindingSource, "DVD_ID", DvdId) = True Then
                    Place = Me.AukDatabaseDataSet.DVD_Rent(ComRow).Item("place").ToString
                End If
                DvdProfit = Val(MTb.Rows(Aq).Item(1).ToString) + Val(MTb.Rows(Aq).Item(2).ToString)
                Row = Me.AukDatabaseDataSet.Product_Collection.FindByDVD_ID(DvdId)
                If Row IsNot Nothing Then
                    Row("Total_Benefit") = DvdProfit
                    Row("place") = Place
                    If Rent = True Then Row("Costomer_ID") = CusR(0).ToString
                    Row.EndEdit()
                End If
            Next
        End If
        Me.Product_CollectionBindingSource.EndEdit()
        Me.Product_CollectionTableAdapter.Update(Me.AukDatabaseDataSet.Product_Collection)
        Me.AukDatabaseDataSet.DVD_Rent.Clear()
    End Sub
    Public Sub SaveP()
        Dim Aq As Integer
        Dim DvdId, DvdProfit, Place As String
        Dim MTb As New DataTable
        Dim Row As DataRow
        Dim MaxCan As Integer
        If Rent = True Then
            'fees = Val(CusR.Item(8).ToString)
            'If Val(fees) >= Val(Me.AukDatabaseDataSet.Options(0).Item(4).ToString) Then
            '    MaxCan = CInt(My.Settings.MaxDVD_RentNumber)
            'Else
            '    MaxCan = CInt(My.Settings.DVDRentNumberNonReg)
            'End If
            If LCase(CusR.Item("Costomer_Category").ToString) = "costin" Then
                MaxCan = CInt(My.Settings.MaxDVD_RentNumber)
            Else
                MaxCan = CInt(My.Settings.DVDRentNumberNonReg)
            End If
            Try
                c = Val(Me.AukDatabaseDataSet.DVD_Rent.Compute("Count(dvd_id)", "place='inhand'"))
            Catch ex As Exception
                c = 0
            End Try
            If c > MaxCan Then
                MsgBox("This customer have due money in 'Advance Fees'" & vbCrLf & " he gave '" & fees & "' he can bought only '" & MaxCan & "' Dvd or Cd.Please check  his informations.", MsgBoxStyle.Critical)
                Exit Sub
            Else
                Me.DVD_RentDataGridView.DataSource = ""
            End If
        End If
        Try
            Me.DVD_RentBindingSource.EndEdit()
            Me.DVD_RentTableAdapter.Update(Me.AukDatabaseDataSet.DVD_Rent)
        Catch ex As Exception
            Epx()
        End Try
        If Me.DVD_RentBindingSource.Count <= 100 Then
            AukF.Mother_DB_Load(Me.DVD_RentBindingSource, 4)
            SFC("Dvd_id")
            STC(GetStrs)
            ExpreC("i")
            AukF.Db_Load("DVD_ID,sum(pay_money),Sum(Fine)", "Dvd_rent", MTb, True, "DVD_ID", False, False, 50, 0, True)
            'MsgBox(Sql)
            For Aq = 0 To MTb.Rows.Count - 1
                DvdId = MTb.Rows(Aq).Item(0).ToString
                If AukF.BindFind(Me.DVD_RentBindingSource, "DVD_ID", DvdId) = True Then
                    Place = Me.AukDatabaseDataSet.DVD_Rent(ComRow).Item("place").ToString
                End If
                'DvdId = Me.AukDatabaseDataSet.DVD_Rent(Aq).DVD_ID.ToString
                'SFC("Dvd_id")
                'STC(DvdId)
                'AukF.Db_Load("sum(pay_money),Sum(Fine)", "Dvd_rent", MTb)
                DvdProfit = Val(MTb.Rows(Aq).Item(1).ToString) + Val(MTb.Rows(Aq).Item(2).ToString)
                Row = Me.AukDatabaseDataSet.Product_Collection.FindByDVD_ID(DvdId)
                If Row IsNot Nothing Then
                    Row("Total_Benefit") = DvdProfit
                    Row("place") = Place
                    If Rent = True Then Row("Costomer_ID") = CusR(0).ToString
                    Row.EndEdit()
                End If
            Next
        End If
        Try
            Me.Product_CollectionBindingSource.EndEdit()
            Me.Product_CollectionTableAdapter.Update(Me.AukDatabaseDataSet.Product_Collection)
            Me.AukDatabaseDataSet.DVD_Rent.Clear()

        Catch ex As Exception
            Epx("PRODUCT COLLECTION DATABASE")
        End Try
     
        If Me.DVD_RentBindingSource.Count > 50 Then
            If Rent = False Then
                MsgBox("Sucessfully Save NonProgrammatic,If any record change in there by user, it will be a great confusing.", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If
        Rent = False
        If My.Settings.RENT_MOVIE_BY_DVDOPT = 1 Then Me.Costomer_IDLoad.Focus()
        Me.DVD_RentDataGridView.DataSource = Me.DVD_RentBindingSource
    End Sub
    Public Sub Save_NonBenefit()
        'Dim Aq As Integer
        'Dim DvdId, DvdProfit, Place As String
        Dim MTb As New DataTable
        'Dim Row As DataRow
        Dim MaxCan As Integer
        If Rent = True Then
            fees = Val(CusR.Item(8).ToString)
            If Val(fees) >= Val(Me.AukDatabaseDataSet.Options(0).Item(4).ToString) Then
                MaxCan = CInt(My.Settings.MaxDVD_RentNumber)
            Else
                MaxCan = CInt(My.Settings.DVDRentNumberNonReg)
            End If
            If Me.DVD_RentBindingSource.Count > MaxCan Then
                MsgBox("This customer have due money in 'Advance Fees'" & vbCrLf & " he gave '" & fees & "' he can bought only '" & MaxCan & "' Dvd or Cd.Please check  his informations.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        Try
            Me.DVD_RentBindingSource.EndEdit()
            Me.DVD_RentTableAdapter.Update(Me.AukDatabaseDataSet.DVD_Rent)
        Catch ex As Exception
            Epx()
        End Try
        Me.Product_CollectionBindingSource.EndEdit()
        Me.Product_CollectionTableAdapter.Update(Me.AukDatabaseDataSet.Product_Collection)
    End Sub
  
    Private Sub SavePro(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveProgramaticToolStripMenuItem.Click, ToolStripButton7.Click, SAVEPROGRAMMATICWAYToolStripMenuItem.Click, ToolStripMenuItem24.Click, ToolStripMenuItem58.Click, ToolStripMenuItem75.Click
        Me.TRntC()
        If Rent = True Then
            If AukF.MsgTr(What & "Save Informations Programmatic...?" & vbCrLf & "His or her total rent cost :" & Me.RentCostView.Text & ".") = True Then
                If My.Settings.DVDOPT_BENEFIT_SHOW = True Then
                    SaveP()
                Else
                    Save_NonBenefit()
                    Me.AukDatabaseDataSet.DVD_Rent.Clear()
                End If
            End If
        Else
            If AukF.MsgTr(What & "Save Informations (NonProgrammatic)...?") = True Then
                SaveP()
            End If
        End If
        SaveCom()
    End Sub
    Public Sub REnd(ByVal Aw As Integer)
        On Error Resume Next
        Dim Row As DataRow
        'Dim Aw As Integer
        Dim mRate As String = My.Settings.Fine.ToString
        Dim DBefore As Boolean
        If Aw > -1 Then
            'row=dvd_rent row
            Row = Me.AukDatabaseDataSet.DVD_Rent(Aw)
            DBefore = CBool(Row("Due").ToString)
            If DBefore = True Then
                MsgBox("DVD ID: " & Row("dvd_ID").ToString & " , MOVIE NAME :" & Row("Movie_Name").ToString & "  Due= True." & vbCrLf & "Please make first the due paid then it will be collected.", MsgBoxStyle.Exclamation)
            Else
                Row(11) = CStr(TimeOfDay)
                Sec = DateAndTime.DateDiff(DateInterval.Second, Row(8), Row(11))
                Row(12) = Format((Sec / 60) / 60, "0.##")
                'MsgBox(mRate)
                If Val(Row(12) * Val(mRate)) <= 0 Then
                    Row(14) = 0
                Else
                    Row(14) = AukF.RemovePoints(Row(12) * Val(mRate))
                End If
                Row(3) = "InStore"
                Row.EndEdit()
            End If
        End If
    End Sub
    Private Sub RentEndCurrentItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentEndCurrentItemToolStripMenuItem.Click, ToolStripMenuItem67.Click
        Aw = Me.DVD_RentBindingSource.Position
        REnd(aw)
    End Sub
    Private Sub AllItemsSetEndInStoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllItemsSetEndInStoreToolStripMenuItem.Click, ToolStripMenuItem68.Click
        'Me.DVD_RentDataGridView.DataSource = ""
        For I = 0 To Me.DVD_RentBindingSource.Count - 1
            REnd(I)
        Next
        'Me.DVD_RentDataGridView.DataSource = Me.DVD_RentBindingSource
        'AukF.Grid_View_SetCommonItems(Me.DVD_RentDataGridView, "InStore", "6", True, Nothing, Nothing, True)
    End Sub

    Private Sub GoToDVDRentViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoToDVDRentViewToolStripMenuItem.Click, ToolStripMenuItem46.Click
        Me.TabControl1.SelectedIndex = 1
        Me.DVD_RentDataGridView.Focus()
    End Sub
    Private Sub SetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetToolStripMenuItem.Click
        AukF.Grid_View_SetCommonItems(Me.DVD_RentDataGridView, ToolStripComboBox1.Text, "6", True, Nothing, Nothing, True)

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem76.Click
        AukF.ComSelIndex(ToolStripComboBox2)
        AukF.Grid_View_SetCommonItems(Me.DVD_RentDataGridView, ToolStripComboBox2.Text, "16", False, Nothing, Nothing, True)
    End Sub
    Private Sub Mov_Key_dnt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            OpenAdvanceSystemToolStripMenuItem_Click(sender, e)

        End If
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        SFC("Movie_Name")
        STC(ToolStripTextBox2.Text)
        AukF.Db_Load("*", "Product_collection", Me.Product_CollectionBindingSource, False, "", True, False, 100, -1)
        AukF.DivideIn_To_2(Sql.ToLower, "where")
        Try
            Me.Product_CollectionBindingSource.Filter = QA2
        Catch ex As Exception
            Epx(QA2)
        End Try
    End Sub
    Private Sub OpenToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem4.Click
        AukF.ComSelIndex(Me.BetCombo)
        AukF.BindFilter_BetweenOparetorN(Me.DVD_RentBindingSource, Me.BetCombo.Text, F1.Text, F2.Text, False, False, True, False)
    End Sub

    Private Sub OpenExactFromFirstToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenExactFromFirstToolStripMenuItem1.Click
        SFC("Movie_Name")
        STC(ToolStripTextBox4.Text)
        AukF.Db_Load("*", "Dvd_rent", Me.DVD_RentBindingSource, True, "", True, True, 100, -1)
    End Sub
    Private Sub OpenToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem3.Click
        SFC("Movie_Name")
        STC(ToolStripTextBox4.Text)
        AukF.Db_Load("*", "Dvd_rent", Me.DVD_RentBindingSource, True, "", True, False, Val(My.Settings.MaximumData_load), -1)
    End Sub
    Private Sub ToolStripTextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            OpenExactFromFirstToolStripMenuItem1_Click(sender, e)
        End If
    End Sub
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        SFC("Costomer_ID")
        STC(ToolStripTextBox5.Text)
        AukF.Db_Load("*", "Dvd_rent", Me.DVD_RentBindingSource, True, "", False, False, Val(My.Settings.MaximumData_load), -1)
    End Sub

    Private Sub CostomerbrowseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostomerbrowseToolStripMenuItem.Click, ToolStripMenuItem4.Click, ToolStripMenuItem35.Click, ToolStripMenuItem62.Click
        Me.TabControl1.SelectedIndex = 1
        Costomer_IDLoad.Focus()
    End Sub
    Private Sub ClearDatabaseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearDatabaseToolStripMenuItem1.Click, ToolStripMenuItem73.Click
        If AukF.MsgTr(What & "Clear database...?") = True Then
            Me.AukDatabaseDataSet.DVD_Rent.Clear()
        End If
    End Sub
    Private Sub GotoProductViewDVDSelectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GotoProductViewDVDSelectorToolStripMenuItem.Click, ToolStripMenuItem1.Click
        Me.TabControl1.SelectedIndex = 0
        Me.Product_CollectionDataGridView.Focus()
    End Sub
    Private Sub Report_ProductCollection(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click, PrintDataToolStripMenuItem.Click, PRINTPREVIEWToolStripMenuItem.Click, ToolStripMenuItem60.Click
        Dim m As New DVDS_REport
        Me.OptionsTableAdapter1.Fill(Me.AukDatabaseDataSet.Options)
        AukF.Prnt(m, Me.AukDatabaseDataSet, Me.Product_CollectionBindingSource)

    End Sub
    Private Sub CheckFIlter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoldToolStripMenuItem.Click, LostToolStripMenuItem.Click, InStoreToolStripMenuItem.Click, InHandToolStripMenuItem.Click, BrokenToolStripMenuItem.Click
        AukF.BindFilter(Me.Product_CollectionBindingSource, "Place", sender.text, 0)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Xi As Integer
        If Rent = False AndAlso NewAdd > 0 Then NewAdd = 0
        If Starter_X = True Then Exit Sub
        If Me.Visible = False Then Exit Sub
        If Rent = True Then
            If Me.DVD_RentBindingSource.Count > 0 Then
                Me.Label1.Visible = True
            End If
        Else
            Me.Label1.Visible = False
            Me.Label1.Text = ""
        End If
        If Val(Me.ListBox1.Width) <> Val(My.Settings.DVDOPT_LISTBOX_WIDTHVALUE) Then
            Me.ListBox1.Width = My.Settings.DVDOPT_LISTBOX_WIDTHVALUE
        End If
        If Rent = True Then
            If My.Settings.DVDOPT_PREVIOUS_MOVIE_COSTOMER = True And Me.ListBox1.Visible = False Then Me.ListBox1.Visible = True
            If My.Settings.DVDOPT_PREVIOUS_MOVIE_COSTOMER = False And Me.ListBox1.Visible = True Then Me.ListBox1.Visible = False
            If Me.TabPage2.ImageIndex <> 0 Then
                Me.TabPage2.ImageIndex = 0
            End If
            If Me.Label1.Text = "" Then
                If Me.DVD_RentBindingSource.Count > 0 Then
                    For Xi = 0 To Me.AukDatabaseDataSet.DVD_Rent.Count - 1
                        If Me.Label1.Text = "" Then
                            Me.Label1.Text = "[" & Me.AukDatabaseDataSet.DVD_Rent(Xi).DVD_ID.ToString & "]"
                        Else
                            If InStr(Me.Label1.Text, "[" & Me.AukDatabaseDataSet.DVD_Rent(Xi).DVD_ID.ToString & "]") = 0 Then
                                Me.Label1.Text = Me.Label1.Text & "," & "[" & Me.AukDatabaseDataSet.DVD_Rent(Xi).DVD_ID.ToString & "]"
                            End If
                        End If
                    Next
                End If
            End If
        Else
            If My.Settings.DVDOPT_PREVIOUS_MOVIE_COSTOMER = True And Me.ListBox1.Visible = False Then Me.ListBox1.Visible = False
            If My.Settings.DVDOPT_PREVIOUS_MOVIE_COSTOMER = False And Me.ListBox1.Visible = True Then Me.ListBox1.Visible = False
            'If Me.CostomerPreviousMoviesRecordToolStripMenuItem.Checked = False And Me.ListBox1.Visible = True Then Me.ListBox1.Visible = False
            If Me.TabPage2.ImageIndex <> -1 Then
                Me.TabPage2.ImageIndex = -1
                Me.Label1.Text = ""
            End If

        End If
        If Rent = True Then
            Me.Costomer_IDLoad.ForeColor = Color.White
            Me.Costomer_IDLoad.BackColor = Color.Black
        Else
            Me.Costomer_IDLoad.ForeColor = Color.Black
            Me.Costomer_IDLoad.BackColor = Color.White
        End If
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_ITEMCOST, 1)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_MTYPE, 2)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_MVERSION, 3)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_PURCHASEDATE, 5)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_COSTOMERID, 6)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_TOTAL_BENEFIT, 8)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_SELFCOLUMN, 9)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_DVDSOLDOPT, 10)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_DVDSOLDOPT, 11)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_MADVANCE_TYPE, 12)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.Product_CollectionDataGridView, My.Settings.MOVIE_RENTALCOST, 13)
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_COMMENTS, 14)

        DVDRENT.SET_READONLY_COLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_PRODUCT_PURCHASE, 5)
        DVDRENT.SET_READONLY_COLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_PRODUCT_SOLDVIEW, 10)
        DVDRENT.SET_READONLY_COLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_PRODUCT_SOLDVIEW, 11)
        DVDRENT.SET_READONLY_COLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_PRODUCT_MADTYPE, 12)
        DVDRENT.SET_READONLY_COLUMN(Me.Product_CollectionDataGridView, My.Settings.DVDOPT_PRODUCT_RENTCOST, 13)
        DVDRENT.SET_READONLY_COLUMN(Me.DVD_RentDataGridView, My.Settings.DVDOPT_DVDRENTVIEW_DVDRENTCOST, 10)

        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DVD_RentDataGridView, My.Settings.DVD_RENT_V_MNAME, 2) 'movie name
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DVD_RentDataGridView, My.Settings.DVDRNT_COS_COMMENTS, 14) 'cos comments
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DVD_RentDataGridView, My.Settings.DVDRNT_COS_COMMENTS, 15) 'bad cos comments

        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DVD_RentDataGridView, My.Settings.DVDRNT_DVDCOMMENTS, 16) 'dvd comments
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DVD_RentDataGridView, My.Settings.DVDRNT_ALTERNATIVE, 4) 'alternaive
        DVDRENT.SET_VISIBLE_DATACOLUMN(Me.DVD_RentDataGridView, My.Settings.DVDRNT_ALTERNATIVE, 9) 'is alternaive

        'Me.Advance_FeesLabel1.Text = a
        If Me.AukDatabaseDataSet.Options.Rows.Count = 1 Then
            SoftIn.TxtColor_NumberDefine(Me.Advance_FeesLabel1, CDec(Me.AukDatabaseDataSet.Options(0).Item(4).ToString), Color.Transparent, Color.Black, Color.Red, Color.White, "ge")

        End If
    End Sub

    Private Sub AdvanceSelectedItemsEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvanceSelectedItemsEntryToolStripMenuItem.Click, ToolStripMenuItem41.Click, ToolStripMenuItem32.Click
        FrmL(Advance_SelectedEntry)
    End Sub
    Private Sub AdvanceSearchQueryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvanceSearchQueryToolStripMenuItem.Click, AdvanceQuerySearchToolStripMenuItem.Click, ToolStripMenuItem50.Click
        FrmL(AdvanceSearch)
    End Sub
    Private Sub HideAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideAllToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub ShowMovieSearchOptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMovieSearchOptionToolStripMenuItem.Click
        FrmL(PrSrc)
    End Sub

    Private Sub Report_DveRent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim m As New DVD_rent_Report3
        AukF.Prnt(m, Me.AukDatabaseDataSet, Me.DVD_RentBindingSource)
    End Sub
    Private Sub CommentEditor_Bring(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click, ToolStripButton8.Click, EntryCostomersCommentsToolStripMenuItem.Click, ToolStripMenuItem66.Click
        Dim Row As DataRow
        If Rent = True Then
            AukF.BindFind(True, Me.Costomer_CommentsBindingSource, 0, CosID)
            If Me.Pn_comments.Visible = True Then
                Me.Pn_comments.Visible = False
                Exit Sub
            End If
            If AukF.BindFind(True, Me.Costomer_CommentsBindingSource, 0, CosID) Then
                Me.Pn_comments.Visible = True
            Else
                Row = Me.AukDatabaseDataSet.Costomer_Comments.NewRow()
                Row.Item(0) = CusR.Item(0)
                For k As Integer = 2 To Row.Table.Columns.Count - 1
                    Row(k) = ""
                Next
                Row.EndEdit()
                Me.AukDatabaseDataSet.Costomer_Comments.Rows.Add(Row)
                Me.Pn_comments.Visible = True
                Try
                    Me.Costomer_CommentsTableAdapter.Update(Me.AukDatabaseDataSet)
                Catch ex As Exception
                    Epx()
                End Try
            End If
        Else
            Me.Pn_comments.Visible = False
        End If
        If Me.Pn_comments.Visible = True Then
            Me.Comments_DescriptionTextBox.Focus()
        Else
            Me.DVD_RentDataGridView.Focus()

        End If
    End Sub
    Public Sub SaveCom()
        Try
            Me.Validate()
            Me.Costomer_CommentsBindingSource.EndEdit()
            'Me.AukDatabaseDataSet.Costomer_Comments.Rows(0).EndEdit()

            Me.Costomer_CommentsTableAdapter.Update(Me.AukDatabaseDataSet)
        Catch ex As Exception
            Epx()

        End Try

    End Sub

    Private Sub ChkSAveUpdate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Thief_Behave_or_PrigCheckBox.Click, RegularCostomerCheckBox.Click, Lying_BehaveCheckBox.Click, Good_BehaveCheckBox.Click, Behave_BadCheckBox.Click, Always_lateCheckBox.Click, Always_InTimeCheckBox.Click
        SaveCom()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaveCom()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Me.Pn_Details.Visible = False
        Me.Pn_1.Visible = False
        If My.Settings.RENT_MOVIE_BY_DVDOPT = 0 Then
            If Me.Product_CollectionBindingSource.Count <> 0 Then
                Me.TabControl1.SelectedIndex = 0
                Me.Product_CollectionDataGridView.Focus()
            Else
                Costomers_nameLabel.Focus()
            End If
        Else
            Costomers_nameLabel.Focus()
        End If



    End Sub
    Public Sub SetShow(ByVal CostomerID As String)
        If My.Settings.DVDOPT_PREVIOUS_MOVIE_COSTOMER = True Then
            If Rent = True Then
                SFC("Costomer_ID")
                STC(CostomerID)
                AukF.Db_Load("DVD_ID,Movie_Name", "DVD_Rent", PreTable, True)
                If PreTable.Columns.Count = 2 Then
                    PreTable.Columns.Add("ShowInfo", System.Type.GetType("System.String"), Me.FORMAT1)
                End If
                If My.Settings.DVDOPT_SEE_LISTVIEW = "2" Then
                    PreTable.Columns(2).Expression = FORMAT1
                ElseIf My.Settings.DVDOPT_SEE_LISTVIEW = "3" Then
                    PreTable.Columns(2).Expression = FORMAT2
                Else
                    PreTable.Columns(2).Expression = FORMAT1
                End If
                PMovs.DataSource = PreTable
                Me.ListBox1.DataSource = PMovs
                If My.Settings.DVDOPT_SEE_LISTVIEW = "2" Or My.Settings.DVDOPT_SEE_LISTVIEW = "3" Then
                    Me.ListBox1.DisplayMember = "ShowInfo"
                ElseIf My.Settings.DVDOPT_SEE_LISTVIEW = "0" Then
                    Me.ListBox1.DisplayMember = "DVD_ID"
                ElseIf My.Settings.DVDOPT_SEE_LISTVIEW = "1" Then
                    Me.ListBox1.DisplayMember = "MOVIE_NAME"
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Pn_comments.Visible = False

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Pn_Details.Visible = False
        Me.Pn_1.Visible = False
        Me.TabControl1.SelectedIndex = 1
        Me.DVD_RentDataGridView.Focus()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click, CancelCustomerToolStripMenuItem.Click, ToolStripMenuItem25.Click, ToolStripMenuItem56.Click
        CancelMember()
    End Sub
    Public Sub CancelMember()
        Rent = False
        Me.AukDatabaseDataSet.Costomer_Comments.Clear()
        Me.AukDatabaseDataSet.Costomer_Inf.Clear()
        Me.AukDatabaseDataSet.DVD_Rent.Clear()
        Me.Pn_comments.Visible = False
        Me.Pn_Details.Visible = False
        Me.Pn_1.Visible = False
        Me.ListBox1.Visible = False
        Label1.Visible = False
    End Sub
    Private Sub ToolStripButton29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton29.Click
        If Rent = True Then
            If Me.Pn_Details.Visible = True Then
                Me.Pn_Details.Visible = False
                Me.Pn_1.Visible = False

                Exit Sub
            End If
            If Me.Pn_Details.Visible = False Then
                Me.Pn_Details.Height = 129
                Me.Pn_Details.Visible = True
                Me.Pn_Details.Height = 129

            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If AukF.MsgTr(What & n & "really delete this costomer comments..?") = True Then
            Try
                'Me.AukDatabaseDataSet.Costomer_Comments.Rows(0).Delete()

                Me.Costomer_CommentsBindingSource.RemoveCurrent()
                Me.Pn_comments.Visible = False

            Catch ex As Exception
                Epx()

            End Try
            SaveCom()

        End If

    End Sub
    Private Sub GridComboFieldDropDownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridComboFieldDropDownToolStripMenuItem.Click, ToolStripMenuItem47.Click
        SendKeys.Send("{F4}")

    End Sub
    Private Sub FilterDVDID_LIst(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox15.TextChanged
        If Len(sender.text) > 2 Then
            PMovs.Filter = "DVD_ID like '" & sender.text & "*'"
        End If

    End Sub
    Private Sub FilterMovieNameList(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox3.TextChanged
        If Len(sender.text) > 4 Then
            PMovs.Filter = "Movie_Name like '" & sender.text & "*'"
        End If
        'pmovs.max

    End Sub
    Private Sub DVDID_FILTER_LIST(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox15.KeyDown
        If e.KeyCode = Keys.Enter Then PMovs.Filter = "DVD_ID like '" & sender.text & "*'"
    End Sub
    Private Sub MovieFilterLIST(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then PMovs.Filter = "Movie_Name like '" & sender.text & "*'"
    End Sub
    Private Sub RemoveFilterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem1.Click
        PMovs.RemoveFilter()
    End Sub
    Private Sub FindInLIst(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox16.TextChanged
        If AukF.FindInObjectAndSelect(Me.ListBox1, sender, True, True, True) = False Then
            AukF.FindInObjectAndSelect(Me.ListBox1, sender, False, True, True)
        End If
    End Sub
    Private Sub SetSelectedItemsProductIDToSmillarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetSelectedItemsProductIDToSmillarToolStripMenuItem.Click, SetSelectedItemsProductIDToSmillarToolStripMenuItem1.Click, ToolStripMenuItem33.Click
        Dim Cn1 As Boolean = False
        Dim Hn As String = ""
        Hn = InputBox("Plase Type New ID Products To Create Serial ID." & vbCrLf & "By this oparetion Serials are Generate After the ID ,If you want to generate serial before id please type after the id "",b"", such as- your id is '-MOVIE-NO' and you want add serail be before then type '-MOVE-NO,b' and get the results.", "Serial ID Generate", Hn)
        Cn1 = AukF.FindTxt(Hn, ",b")
        Hn = Replace(Hn, ",b", "")
        For k As Integer = 0 To (Me.Product_CollectionDataGridView.SelectedRows.Count - 1)
            Try
                If Cn1 = True Then
                    Me.Product_CollectionDataGridView.SelectedRows(k).Cells(0).Value = (Val(Me.Product_CollectionDataGridView.SelectedRows.Count) - Val(k) & Hn)
                Else
                    Me.Product_CollectionDataGridView.SelectedRows(k).Cells(0).Value = (Hn & Val(Me.Product_CollectionDataGridView.SelectedRows.Count - Val(k)))
                End If
            Catch ex As Exception
                Epx()
                Exit For
            End Try

        Next
    End Sub
    Public Function DVDView(ByVal CostoemrID As String, ByVal DVDID As String)
        'On Error Resume Next
        Dim ShowTable, CostomerTable As New DataTable
        SFC("DVD ID", "Customer ID")
        STC(DVDID, CostoemrID)
        AukF.Db_Load("*", "DVD_VIEW2", ShowTable)
        SFC("Costomer_ID")
        STC(CostoemrID)
        AukF.Db_Load("*", "Costomer_Inf", CostomerTable)
        If CostomerTable.Rows.Count > 0 And ShowTable.Rows.Count > 0 Then
            DVDViewForm.Costomer_InfBindingSource.DataMember = ""
            DVDViewForm.Costomer_InfBindingSource.DataSource = CostomerTable
            DVDViewForm.DataGridView1.DataSource = ShowTable
            FrmL(DVDViewForm)
        End If
    End Function
    Private Sub ToolStripMenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem42.Click
        SFC("DVD_ID")
        STC(Me.ToolStripTextBox1.Text)
        AukF.Db_Load("*", "Product_Collection", Me.Product_CollectionBindingSource, False, "", True, True, 100, -1)
        SoftIn.BindFilterByAdvanceCategory(Me.Product_CollectionBindingSource, "DVD_ID", Me.ToolStripTextBox1.Text, False, False, True, "=", False)


    End Sub

    Private Sub ToolStripMenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem43.Click
        SFC("DVD_ID")
        STC(Me.ToolStripTextBox1.Text)
        AukF.Db_Load("*", "Product_Collection", Me.Product_CollectionBindingSource, False, "", True, False, 100, -1)
        SoftIn.BindFilterByAdvanceCategory(Me.Product_CollectionBindingSource, "DVD_ID", Me.ToolStripTextBox1.Text, False, True, False, "=", False)

    End Sub

    Private Sub BadCommands(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox17.KeyDown
        If e.KeyCode = Keys.Enter Then
            SFC("Costomer_ID", "Is_Comments_Bad")
            STC(sender.text, "y")
            DTC("", "b")
            AukF.Db_Load("*", "DVD_RENT", Me.DVD_RentBindingSource, False, "", False, False, Val(My.Settings.MaximumData_load), -1)
            'MsgBox(Sql)

            Me.DVD_RentDataGridView.DataSource = Me.DVD_RentBindingSource
        End If
    End Sub
    Private Sub MoviesInHandCostomersViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoviesInHandCostomersViewToolStripMenuItem.Click
        'Dim ShowTable As New DataTable
        AukF.Db_Load("*", "", Me.AukDatabaseDataSet.DVD_RENTV_HAND)
        If Me.AukDatabaseDataSet.DVD_RENTV_HAND.Rows.Count > 0 Then
            FrmL(ViewQuery)
            ViewQuery.DataGrid1.DataSource = Me.AukDatabaseDataSet.DVD_RENTV_HAND
        End If
    End Sub

    Private Sub DVDIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DVDIDToolStripMenuItem.Click
        Me.ListBox1.DisplayMember = "DVD_ID"
    End Sub

    Private Sub MovieNameToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovieNameToolStripMenuItem1.Click
        'Me.ListBox1.DataSource = PMovs
        Me.ListBox1.DisplayMember = "Movie_Name"
    End Sub

    Private Sub DVDIDMovieNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DVDIDMovieNameToolStripMenuItem.Click
        Me.ListBox1.DisplayMember = "ShowInfo"
    End Sub
    Private Sub ViewSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSettingsToolStripMenuItem.Click
        FrmL(DVDOPT)
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        If Me.ListBox1.SelectedIndex <> -1 Then
            dvdid = PreTable.Rows(Me.ListBox1.SelectedIndex).Item("DVD_ID").ToString
            DVDView(CosID, dvdid)
        End If
    End Sub
    Private Sub Todays_RentedMovies_ReportView(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TODAYSBEToolStripMenuItem.Click, TODAYSTOTALRENTALMOVIESSHOWToolStripMenuItem.Click
        'ViewInfo2.TODAYSVIEW()
        AukF.Db_LoadN(Me.AukDatabaseDataSet.Options)
        SFC("DVD RENT TO NOW DATE DISTANCE(D)")
        'MsgBox(DX)
        STC(0)
        SnX("=")
        AukF.Db_Load("*", "DVD_PROFIT", Me.AukDatabaseDataSet.DVD_PROFIT, True)
        If Me.AukDatabaseDataSet.DVD_PROFIT.Count > 0 Then
            Dim M As New DVDPROFIT_REPOT
            AukF.Prnt(M, Me.AukDatabaseDataSet)
        Else
            MsgBox("Today No Movie Rented.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub DVDINFORMATIONVIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DVDINFORMATIONVIEWToolStripMenuItem.Click
        FrmL(ViewInfo2)
    End Sub

    Public Sub SelfStockRefresh(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHSELFToolStripMenuItem.Click

        Product_input_Load(sender, e)
        'Else
        'AukF.Db_Load("sELF_roW_ID,SELF_ROW_COLUMN", "Self_row_column", Me.AukDatabaseDataSet.Self_Row_Column, True, "", False, False, CInt(My.Settings.MaximumData_load.ToString))

        'End If
        If SelfEntry.Visible = True AndAlso SendFrmSelf = False Then
            SelfEntry.SelfEntry_Load(sender, e)
        Else
            SendFrmSelf = False
        End If

    End Sub

    Private Sub FILTERSELECTEDMOVIETYPEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTERSELECTEDMOVIETYPEToolStripMenuItem.Click
        'TN1 = Me.AukDatabaseDataSet.Type(Me.MOVIE_TYPELIST.SelectedIndex).Item(0).ToString
        'SoftIn.BindFilterByAdvanceCategory(Me.Product_CollectionBindingSource, "MOVIE_TYPE", TN1)
        'SoftIn.BindFilterByAdvanceCategory(Me.Product_CollectionBindingSource, "PLACE", "INSTORE", True, False, False, "=", True)
        TN1 = Me.MOVIE_TYPELIST.Text
        SoftIn.QueryLink(Me.AukDatabaseDataSet.Type, "Movie_Type_Name", tn1, Me.Product_CollectionBindingSource, "Movie_Type", "Movie_type", Me.Product_CollectionBindingSource, False, 1)

    End Sub

    Private Sub ToolStripMenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem45.Click

        TN1 = Me.MOVIE_TYPELIST.Text
        SoftIn.QueryLink(Me.AukDatabaseDataSet.Type, "Movie_Type_Name", tn1, Me.Product_CollectionBindingSource, "Movie_Type", "Movie_type", Me.Product_CollectionBindingSource, False, 0)

    End Sub

    Private Sub FILTERINADVANCEMOVIETYPEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTERINADVANCEMOVIETYPEToolStripMenuItem.Click
        SoftIn.QueryLink(Me.AukDatabaseDataSet.Type, 1, Me.MOVIE_FILTER_TYPE_TEXTBOX.Text, Me.AukDatabaseDataSet.Product_Collection, "Movie_Type", 0, Me.Product_CollectionBindingSource, False, 2, False)
        'STR1 = AukF.Advance_Search(Me.MOVIE_FILTER_TYPE_TEXTBOX.Text, "MOVIE_ADVANCE_TYPE", Me.AukDatabaseDataSet.Product_Collection)
        'Try
        '    Me.Product_CollectionBindingSource.Filter = STR1
        'Catch ex As Exception
        '    Epx(STR1)
        'End Try

    End Sub

    Private Sub DELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEToolStripMenuItem.Click
        If Me.Product_CollectionBindingSource.Count > 0 Then
            Me.Product_CollectionBindingSource.RemoveCurrent()

        End If

    End Sub

    Private Sub ADDNEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDNEWToolStripMenuItem.Click
        Me.Product_CollectionBindingSource.AddNew()

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub AUTOMATICDVDIDWHENNULLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AUTOMATICDVDIDWHENNULLToolStripMenuItem.Click
        My.Settings.DVDOPT_AUTOMACI_DVDID = AUTOMATICDVDIDWHENNULLToolStripMenuItem.Checked
        My.Settings.Save()

    End Sub

    Private Sub SAVEANDCLEARDATABASEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEANDCLEARDATABASEToolStripMenuItem.Click
        If AukF.MsgTr(What & "Save & Clear Database?") = True Then
            Product_CollectionBindingNavigatorSaveItem_Click(sender, e)
            Me.AukDatabaseDataSet.Product_Collection.Clear()

        End If
    End Sub

    Private Sub CLEARDATABASEToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEARDATABASEToolStripMenuItem2.Click
        If AukF.MsgTr(What & "Clear Database?") = True Then Me.AukDatabaseDataSet.DVD_Rent.Clear()

    End Sub

    Private Sub DEFAULTQUERYMANAGERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEFAULTQUERYMANAGERToolStripMenuItem.Click, ToolStripButton6.ButtonClick, DEFAULTQUERYMANAGERToolStripMenuItem1.Click, ToolStripMenuItem71.Click
        'AukQ.dV = Me.DVD_RentDataGridView
        'AukQ.Bnp = Me.DVD_RentBindingSource
        'FrmL(AukQ)  
        DVDRENT.ShowQr_Product(Me.DVD_RentDataGridView, Me.DVD_RentBindingSource)
    End Sub

    Private Sub TOTALBENEFITINVIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOTALBENEFITINVIEWToolStripMenuItem.Click
        ViewInfo2.PROFIT(Now, Now)
        FrmL(ViewInfo2)
    End Sub

    Private Sub CURRENTCOSTOMERSINFORMATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CURRENTCOSTOMERSINFORMATIONToolStripMenuItem.Click
        If Me.Product_CollectionDataGridView.CurrentCell.RowIndex > -1 Then
            Try
                COSIDN = Me.Product_CollectionDataGridView(6, Me.Product_CollectionDataGridView.CurrentCell.RowIndex).Value.ToString
                If Trim(COSIDN) <> "" Then
                    ViewInfo2.DVDVIEW2_BYCustomerS(COSIDN)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        TN1 = Me.MOVIE_TYPELIST.Text
        SoftIn.QueryLink(Me.AukDatabaseDataSet.Type, "Movie_Type_Name", tn1, Me.Product_CollectionBindingSource, "Movie_Type", "Movie_type", Me.Product_CollectionBindingSource, False, 2)

    End Sub
    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        SoftIn.QueryLink(Me.AukDatabaseDataSet.Type, 1, Me.MOVIE_FILTER_TYPE_TEXTBOX.Text, Me.AukDatabaseDataSet.Product_Collection, "Movie_Type", 0, Me.Product_CollectionBindingSource, False, 3, False)

    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        SoftIn.QueryLink(Me.AukDatabaseDataSet.Type, 1, Me.MOVIE_FILTER_TYPE_TEXTBOX.Text, Me.AukDatabaseDataSet.Product_Collection, "Movie_Type", 0, Me.Product_CollectionBindingSource, False, 0, False)

    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        SoftIn.QueryLink(Me.AukDatabaseDataSet.Type, 1, Me.MOVIE_FILTER_TYPE_TEXTBOX.Text, Me.AukDatabaseDataSet.Product_Collection, "Movie_Type", 0, Me.Product_CollectionBindingSource, False, 1, False)

    End Sub
    Private Sub FILTERWHICHFIELDSTYPEISNOTSELECTEDYETToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILTERWHICHFIELDSTYPEISNOTSELECTEDYETToolStripMenuItem.Click
        Try
            SRX = SoftIn.Datatable_Nulls_only("movie_type", True)
            'MsgBox(srx)
            Me.Product_CollectionBindingSource.Filter = SRX
        Catch ex As Exception
            Epx(SRX)
        End Try

    End Sub
    Private Sub OpenAdvanceSystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAdvanceSystemToolStripMenuItem.Click
        Try
            SRX = SoftIn.GetFunction_QrText(Me.AukDatabaseDataSet.Product_Collection, 3, ToolStripTextBox2.Text, 3)
            AukF.Db_LoadQ(Me.AukDatabaseDataSet.Product_Collection, SRX, -1, False, My.Settings.DVDOPT_ORDERBY)
            Me.Product_CollectionBindingSource.Filter = SRX
        Catch ex As Exception
            Epx(SRX)
        End Try
    End Sub
    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Try
            SRX = SoftIn.GetFunction_QrText(Me.AukDatabaseDataSet.Product_Collection, 3, ToolStripTextBox2.Text, 7)
            AukF.Db_LoadQ(Me.AukDatabaseDataSet.Product_Collection, SRX, -1, False, My.Settings.DVDOPT_ORDERBY)
            Me.Product_CollectionBindingSource.Filter = SRX
        Catch ex As Exception
            Epx(SRX)
        End Try
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click, ToolStripMenuItem48.Click
        Dim CUS_N, CUS_i, ALT, STR1 As String
        Dim riNT As Integer
        If Rent = True Then
            SendItemsToCurrentCostoemrsAccountToolStripMenuItem_Click(sender, e)
        Else
            'Dim CusT As New DataTable("Costomer_Inf")
            STR1 = InputBox("PLEASE TYPE CUSTOMER ID,[ALTERNATIVE NAME] TO LOAD CUSTOMER INFORMATION AND SEND SELECTED & SAVE.", "LOAD CUSTOMER", STR1)
            If STR1 <> "" Then
                ALT = UCase(ArV(STR1.Split(","), 1))
                CUS_i = UCase(ArV(STR1.Split(","), 0))
                If Trim(CUS_i) <> "" Then
                    SFC("CoSTOMER_id")
                    STC(CUS_i)
                    AukF.Db_LoadN(CHECKR, "2", "Costomer_Inf")
                    If CHECKR.Rows.Count = 1 Then
                        Me.DVD_RentDataGridView.DataSource = Nothing
                        If My.Settings.DVD_OPT_ALWAYSrEMIND = True Then
                            SFC("CUSTOMER id")
                            STC(CUS_i)
                            NX = ADSRC.COUNT_T("DVD_RENTV_HAND", CHECKR)
                            If Val(NX) > 0 Then
                                If AukF.MsgTr("[" & CUS_i & "] ALREADY HAVE " & NX & " DVDS/CDS ;" & vbCrLf & "DO YOU WANT TO RENT HIM/HER CD/DVD AGAIN?") = False Then
                                    Exit Sub
                                End If
                            End If
                            CUS_N = CHECKR.Rows(0).Item(0).ToString
                            Me.DVD_RentDataGridView.DataSource = Nothing
                            If Me.Product_CollectionDataGridView.SelectedRows.Count = 0 Then
                                SEND_MOVIES(CUS_i, CUS_N, ALT, Me.Product_CollectionDataGridView.CurrentCell.RowIndex)
                            Else
                                For M As Integer = 0 To Me.Product_CollectionDataGridView.SelectedRows.Count - 1
                                    riNT = Me.Product_CollectionDataGridView.SelectedRows(M).Index
                                    SEND_MOVIES(CUS_i, CUS_N, ALT, riNT)
                                Next
                            End If
                            If My.Settings.DVDOPT_BENEFIT_SHOW = True Then
                                Me.SaveP2()
                            Else
                                Me.Save_NonBenefit()
                            End If
                        End If
                    Else
                        MsgBox(CUS_i & " CUSTOMER ID IS INVALID.", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.OptionsTableAdapter1.Fill(Me.AukDatabaseDataSet.Options)

    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click, ToolStripMenuItem34.Click
        Me.OptionsTableAdapter1.Fill(Me.AukDatabaseDataSet.Options)

    End Sub

    Private Sub SetCurrentBadCommentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetCurrentBadCommentsToolStripMenuItem.Click, ToolStripMenuItem65.Click
        If Me.DVD_RentDataGridView.RowCount > 0 Then
            If Me.DVD_RentDataGridView.CurrentRow.Index > -1 Then
                Me.DVD_RentDataGridView(15, Me.DVD_RentDataGridView.CurrentRow.Index).Value = 1
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click, ToolStripMenuItem51.Click
        ADSRC.DATAGRID_ADVANCE_SELECTED_FILTER(Me.Product_CollectionDataGridView, Me.Product_CollectionBindingSource)

    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click, ToolStripMenuItem53.Click
        ADSRC.DATAGRID_ADVANCE_SELECTED_FILTER(Me.Product_CollectionDataGridView, Me.Product_CollectionBindingSource, "=", 0, True)
    End Sub

    Private Sub CURRENTDVDINFORMATIONVIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CURRENTDVDINFORMATIONVIEWToolStripMenuItem.Click
        If Me.Product_CollectionDataGridView.CurrentRow.Index > -1 Then
            DVDID = Me.Product_CollectionDataGridView(0, Me.Product_CollectionDataGridView.CurrentRow.Index)
            ViewInfo2.DVDVIEW1(DVDID)
            FrmL(ViewInfo2)
        End If


    End Sub


    Private Sub FIND_DID_MNAME(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox6.TextChanged
        If AukF.BindFind(Me.Product_CollectionBindingSource, "DVD_ID", sender.TEXT, True) = True Then
            Me.Product_CollectionDataGridView.CurrentRow.Cells(0).Selected = True
            'ElseIf AukF.BindFind(Me.Product_CollectionBindingSource, "MOVIE_NAME", sender.TEXT, True) = True Then
            '    Me.Product_CollectionDataGridView.CurrentRow.Cells(4).Selected = True
        End If
    End Sub

    Private Sub Delbuts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delbuts.Click, DELETECURRENTDATAOBJECTToolStripMenuItem.Click
        If My.Settings.DIRECT_SAVE = True Then
            If AukF.MsgTr("Delete current DataObject [ " & Me.AukDatabaseDataSet.DVD_Rent(Me.DVD_RentBindingSource.Position).DVD_ID.ToUpper & " - " & Me.AukDatabaseDataSet.DVD_Rent(Me.DVD_RentBindingSource.Position).Item("Movie_Name").ToString.ToUpper & "] ?", True) = False Then Exit Sub
        End If
        dvdid = Me.AukDatabaseDataSet.DVD_Rent(Me.DVD_RentBindingSource.Position).DVD_ID.ToUpper
        If Me.DVD_RentDataGridView.CurrentCell.RowIndex > -1 Then
            'Me.REnd(Me.DVD_RentBindingSource.Position)
            'MsgBox(dvdid)
            STC(dvdid)
            RowX = ADSRC.LOAD_AND_FIND(Me.AukDatabaseDataSet.Product_Collection, "DVD_ID", dvdid, 0, False)
            If RowX IsNot Nothing Then
                RowX.Item(6) = "InStore"
                'MsgBox("InStore", , RowX.Item(0))
                Me.Product_CollectionTableAdapter.Update(RowX)
            End If
            If Me.DVD_RentBindingSource.Position > -1 Then Me.AukDatabaseDataSet.DVD_Rent(Me.DVD_RentBindingSource.Position).Delete()
            If My.Settings.DIRECT_SAVE = True Then Me.Save_NonBenefit()
        End If
        If Me.DVD_RentBindingSource.Count > 0 Then
            For Xi = 0 To Me.AukDatabaseDataSet.DVD_Rent.Count - 1
                If Me.Label1.Text = "" Then
                    Me.Label1.Text = "[" & Me.AukDatabaseDataSet.DVD_Rent(Xi).DVD_ID.ToString & "]"
                Else
                    If InStr(Me.Label1.Text, "[" & Me.AukDatabaseDataSet.DVD_Rent(Xi).DVD_ID.ToString & "]") = 0 Then
                        Me.Label1.Text = Me.Label1.Text & "," & "[" & Me.AukDatabaseDataSet.DVD_Rent(Xi).DVD_ID.ToString & "]"
                    End If
                End If
            Next
        Else
            Me.Label1.Text = ""
        End If
    End Sub

    Private Sub SAVE_DVDRENT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DVD_RentDataGridView.CellEndEdit
        If e.ColumnIndex = 11 Then
            Me.TRntC()
        End If
        If e.RowIndex > -1 Then
            If AukF.GridT(sender, 6) = "InStore" Then
                'fine=-1 or recevid date=""
                recxa = AukF.GridT(sender, 12, -1, "")
                If Val(AukF.GridT(sender, 11, -1, -1)) = -1 AndAlso recxa = "" Then
                    REnd(e.RowIndex)
                End If
            End If
        End If

        'If My.Settings.DIRECT_SAVE = True Then Me.Save_NonBenefit()
    End Sub

    Private Sub TWICE_EVENT(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox6.KeyDown
        If e.Control = True And e.KeyCode = Keys.Enter Then
            Try
                SRX = SoftIn.GetFunction_QrText(Me.AukDatabaseDataSet.Product_Collection, 3, sender.TEXT, 3) 'and space array
                AukF.Db_LoadQ(Me.AukDatabaseDataSet.Product_Collection, SRX, -1, False, My.Settings.DVDOPT_ORDERBY)
                Me.Product_CollectionBindingSource.Filter = SRX
            Catch ex As Exception
                Epx(SRX)
            End Try
        ElseIf e.KeyCode = Keys.Enter Then
            If Rent = True Then
                If AukF.BindFind(Me.Product_CollectionBindingSource, "DVD_ID", sender.TEXT, True) = True Then
                    Me.SEND_MOVIES_BY_DVDID(sender, sender.TEXT)
                Else
                    ADSRC.Twice_Q(Me.Product_CollectionBindingSource, "DVD_ID", "MOVIE_NAME", sender.TEXT)
                    If AukF.BindFind(Me.Product_CollectionBindingSource, "DVD_ID", sender.TEXT, True) = True Then
                        Me.SEND_MOVIES_BY_DVDID(sender, sender.TEXT)
                    End If
                End If
            Else
                ADSRC.Twice_Q(Me.Product_CollectionBindingSource, "DVD_ID", "MOVIE_NAME", sender.TEXT)
            End If
        End If
    End Sub

    Private Sub AUTOMATICENTRYMOREBYNUMBERDEVELOPERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AUTOMATICENTRYMOREBYNUMBERDEVELOPERToolStripMenuItem.Click
        Dim R As DataRow
        Dim R2 As DataRow
        R = Me.AukDatabaseDataSet.Product_Collection(Me.Product_CollectionBindingSource.Position)
        INPUTX = InputBox("TYPE NUMBER TO INTER ROWS")
        For K As Integer = 1 To Val(INPUTX)
            R2 = Me.AukDatabaseDataSet.Product_Collection.NewRow
            ID = SoftIn.Master_ID_String_Get(6, 0)
            For M As Integer = 0 To Me.AukDatabaseDataSet.Product_Collection.Columns.Count - 1
                If M <> 0 Then
                    R2(M) = R(M)
                Else
                    R2(0) = ID
                End If
            Next
            R2.Table.Rows.Add(R2)
            Try
                Me.Product_CollectionTableAdapter.Update(R2)
            Catch ex As Exception
                Epx()
                Exit Sub
            End Try
            Me.Text = K

            'Me.Product_CollectionTableAdapter.Insert(ID, R(1), R(2), R(3), R(4), R(5), R(6), Val(R(7)), Val(R(8)), Val(R(9)), Val(R(10)), Val(R(11)), R(12), Val(R(13)), Val(R(14)), Now.Date)
        Next
    End Sub

    Private Sub Costomers_nameLabel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Costomers_nameLabel.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.Control = True Then 'MAKE THEM DUE
                A = sender.TEXT
                Me.SEND_MOVIES_BY_DVDID(sender, a, "InHand", True, True)
            Else
                A = sender.TEXT
                Me.SEND_MOVIES_BY_DVDID(sender, sender.TEXT)
            End If
      

        End If
    End Sub

    Private Sub Costomers_nameLabel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Costomers_nameLabel.TextChanged
        ADSRC.TWICE_BINDFIND(Me.DVD_RentBindingSource, "DVD_ID", "MOVIE_NAME", sender.TEXT)

    End Sub


    Private Sub RENTALSETTINGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RENTALSETTINGSToolStripMenuItem.Click
        FrmL(RENTAL_SET)

    End Sub

    Private Sub ADDINGMOVIESBYIDINCLIENTACCOUNTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDINGMOVIESBYIDINCLIENTACCOUNTToolStripMenuItem.Click, ToolStripMenuItem69.Click
        If Rent = True Then
            Me.Costomers_nameLabel.Focus()
        Else
            Costomer_IDLoad.Focus()
        End If
    End Sub

    Private Sub ToolStripTextBox7_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            AukF.ComSelIndex(ToolStripComboBox4)
            SFC("RENT_PRICE")
            STC(sender.TEXT)
            SnX(ToolStripComboBox4.Text.Split(",").GetValue(1).ToString)
            DTC("N")
            AukF.Db_LoadN(Me.AukDatabaseDataSet.Product_Collection, -1, "", False, 0, My.Settings.DVDOPT_ORDERBY, False, -1, Val(My.Settings.MaximumData_load))
            Me.Product_CollectionBindingSource.Filter = BSql
        End If
    End Sub

    Private Sub FOCUSONCURRENTTABDVDIDTEXTBOXTORENTDVDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FOCUSONCURRENTTABDVDIDTEXTBOXTORENTDVDToolStripMenuItem.Click
        Costomers_nameLabel.Focus()
    End Sub
    Private Sub DVDRENT_Place_Filter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click, ToolStripMenuItem17.Click, ToolStripMenuItem16.Click, ToolStripMenuItem15.Click, ToolStripMenuItem14.Click
        SFC("Place")
        STC(sender.text)
        AukF.Db_Load("*", "Dvd_rent", Me.DVD_RentBindingSource, False, "", False, False, 100, -1)
    End Sub

    Private Sub SELECTEDFILTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SELECTEDFILTERToolStripMenuItem.Click, ToolStripMenuItem70.Click
        ADSRC.DATAGRID_ADVANCE_SELECTED_FILTER(Me.DVD_RentDataGridView, Me.DVD_RentBindingSource)

    End Sub

    Private Sub REMOVEFILTERToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REMOVEFILTERToolStripMenuItem3.Click, ToolStripMenuItem19.Click, ToolStripMenuItem72.Click
        Me.DVD_RentBindingSource.RemoveFilter()
    End Sub

    Private Sub CURRENTDATATABLEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CURRENTDATATABLEToolStripMenuItem.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.DVD_RentBindingSource, True)

    End Sub

    Private Sub CURRENTOBJECTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CURRENTOBJECTToolStripMenuItem.Click
        AukF.Single_DataRecordRefresh(Me.DVD_RentBindingSource, True)

    End Sub

    Private Sub LoadLastMovieCustomer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem26.Click, ToolStripMenuItem57.Click
        Costomer_IDLoad.Text = AukF.GridT(Me.Product_CollectionDataGridView, 6)
        LoadCostomer(sender, e)

    End Sub

    Private Sub ToolStripTextBox5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripMenuItem3_Click(sender, e)
        End If
    End Sub

    Private Sub F1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles F1.KeyDown
        If e.KeyCode = Keys.Enter Then
            OpenToolStripMenuItem4_Click(sender, e)
        End If
    End Sub

    
    Private Sub RunClientMovies(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadClientBadRecordsToolStripMenuItem.Click, LaodClientToolStripMenuItem.Click, LaodClientTillMoviesToolStripMenuItem.Click
        MsgBox(sender.tag)
        If sender.tag = "b" Then
            'bad rec
            SFC("Costomer_ID", "Is_Comments_Bad")
            STC(sender.text, "y")
            DTC("", "b")
            AukF.Db_Load("*", "DVD_RENT", Me.DVD_RentBindingSource, False, "", False, False, Val(My.Settings.MaximumData_load), -1)
            Me.DVD_RentDataGridView.DataSource = Me.DVD_RentBindingSource
        ElseIf sender.tag = "t" Then
            SFC("Costomer_ID")
            STC(sender.Text)
            AukF.Db_Load("*", "Dvd_rent", Me.DVD_RentBindingSource, True, "", False, False, Val(My.Settings.MaximumData_load), -1)
        ElseIf sender.tag = "l" Then
            LoadCostomer(sender, e)
        End If
    End Sub

    Private Sub RentCostView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentCostView.Click
        Me.TRntC()
    End Sub

    Private Sub ToolStripMenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem27.Click
        Try
            RowX = Me.AukDatabaseDataSet.Product_Collection.NewRow
            RowX.Item(0) = Val(ADSRC.MAXIMUM_VALUE("Product_Collection", "dvd_id")) + 1
            Me.AukDatabaseDataSet.Product_Collection.Rows.Add(RowX)
            Me.Product_CollectionBindingSource.Position = Me.Product_CollectionBindingSource.Count - 1

        Catch ex As Exception
            Epx()
        End Try
    End Sub
    Private Sub ToolStripMenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem28.Click
        MsgBox("MAXIMAM DVD ID IN NUMBER VALUE IS: " & ADSRC.MAXIMUM_VALUE("Product_Collection", "dvd_id"), MsgBoxStyle.Information)
    End Sub

    Private Sub DVD_RentBindingSource_ListChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles DVD_RentBindingSource.ListChanged
        Me.TRntC()
    End Sub

    Private Sub DVD_RentBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles DVD_RentBindingSource.AddingNew
        Me.TRntC()
    End Sub

    Private Sub Load_qr_Date(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadTypedYearInformationToolStripMenuItem.Click, LoadCurrentDateMonthToolStripMenuItem.Click, ToolStripMenuItem61.Click
        Dim C As Date
        If Rent = True Then MsgBox("Please let the client off.", MsgBoxStyle.Information) : Exit Sub
        Try
            If sender.tag = "m" Then
                C = CDate(Me.Costomer_IDLoad.Text)
                SFC("Date_Rent", "Date_Rent")
                STC(C.Month, C.Year)
                DTC("n", "n")
                ExpreC("Month", "Year")
                AukF.Db_Load("*", "Dvd_rent", Me.DVD_RentBindingSource, True, "", False, False, Val(My.Settings.MaximumData_load), -1)
            ElseIf sender.tag = "y" Then
                m = Val(Me.Costomer_IDLoad.Text)
                SFC("Date_Rent")
                STC(m)
                DTC("n")
                ExpreC("Year")
                AukF.Db_Load("*", "Dvd_rent", Me.DVD_RentBindingSource, True, "", False, False, Val(My.Settings.MaximumData_load), -1)
            ElseIf sender.tag = "d" Then
                C = CDate(Me.Costomer_IDLoad.Text)
                SFC("Date_Rent")
                STC(C)
                DTC("d")
                'ExpreC("Year")
                AukF.Db_Load("*", "Dvd_rent", Me.DVD_RentBindingSource, True, "", False, False, Val(My.Settings.MaximumData_load), -1)
            End If
        Catch ex As Exception
            MsgBox("Plase Type a valid date for Month Query,type a Integer value for Year Query.", MsgBoxStyle.Information)
        End Try

    End Sub
    Public Sub OpenbyDate_SMsg(ByVal D1 As String)
        Dim D2 As Date
        Dim Tn As DataTable
        'Dim BpP As Decimal
        Dim G As DataGridView = Mob_ComDataGridView
        Try
            D2 = CDate(CDate(D1))
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        SFC("date_rent")
        STC(D2)
        DTC("d")
        Tn = ADSRC.AdvSummSys_RTable(Me.AukDatabaseDataSet.DVD_Rent, "Due,Pay_money,Fine", ",Sum,Sum", "due,Date_Rent", True) 'cause opening by date_rent
    End Sub
    Public Sub CalculateFor_Msg(ByVal Tn As DataTable)
        Dim SDue, SPay As Decimal
        SDue = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Tn, "Due=true", "Sum", 1)) '1=pay_money
        SPay = Val(ADSRC.SUMMARY_NONEXE_CUR_TABLE(Tn, "Due=False", "Sum", 1)) '1=pay_money



    End Sub
    Private Sub TODAYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DUE_CLICLbUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DUE_CLICLbUT.Click, DUE_PAIDCLICK.Click, ToolStripMenuItem64.Click, ToolStripMenuItem63.Click
        Dim BWas As Boolean = CBool(AukF.GridT(Me.DVD_RentDataGridView, 17, -1, "False"))
        Dim NowIs As Boolean = CBool(sender.tag)
        If NowIs = BWas Then
            MsgBox("Due is before " & NowIs, MsgBoxStyle.Exclamation)
        Else
            If DRow > -1 Then Me.DVD_RentDataGridView(17, DRow).Value = NowIs
        End If
    End Sub
    Public Sub SaveAuto()
        If My.Settings.DVDOPT_BENEFIT_SHOW = True Then
            SaveP()
        Else
            Save_NonBenefit()
            Me.AukDatabaseDataSet.DVD_Rent.Clear()
        End If
    End Sub
    Private Sub Rent_InformationLoad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox9.KeyDown, ToolStripTextBox8.KeyDown, ToolStripTextBox10.KeyDown
        If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet.DVD_Rent, Me) = False Then Exit Sub
        CSOFT.Events_of_SummaryTextBox_KeyDown(Me, sender, e, Me.AukDatabaseDataSet.DVD_Rent, "Date_")
    End Sub

    Private Sub DVDRENT_DEATILSSHOW_BYClicl(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YESTERDAYToolStripMenuItem.Click, TODAYToolStripMenuItem.Click, DAYAFTERYESTERDAYToolStripMenuItem.Click
        a = Val(sender.tag)
        Dim D1 As Date = CDate(NDate()).AddDays(a)
        SFC("Date_")
        STC(D1)
        DTC("d")
        SumC("CDATE")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.DVD_Rent)

    End Sub

    Private Sub Due_DVDRent_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox11.KeyDown, ToolStripTextBox13.KeyDown, ToolStripTextBox12.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Rent = True Then MsgBox("Please Let the client off.", MsgBoxStyle.Information) : Exit Sub
            If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet.DVD_Rent, Me) = False Then Exit Sub
            a = sender.tag
            If a = "id" Then
                'ADSRC.TWICE_EXE(sender, e, Me.DVD_RentBindingSource, "Costomer_ID", "Alternative_Name", False, True)
                SFC("Due", "costomer_Id")
                STC("True", sender.text)
                DTC("b")
            ElseIf a = "d" Then
                SFC("Date_", "Due")
                STC(sender.text, "True")
                DTC("d", "b")
                SumC("Cdate")

            ElseIf a = "m" Then
                If CSOFT.Date_Get_FromStr(sender.text) = True Then
                    Dim D1 As Date
                    D1 = CDate(sender.text)
                    SFC("date_Rent", "date_Rent", "Due")
                    STC(D1.Month, D1.Year, "True")
                    SumC("Month", "Year")
                    DTC("n", "n", "b")
                End If

            ElseIf a = "y" Then
                SFC("date_Rent", "Due")
                STC(sender.text, "True")
                SumC("Year")
                DTC("n", "b")
            End If
            AukF.Db_LoadN(Me.AukDatabaseDataSet.DVD_Rent)
        End If

    End Sub

    Private Sub TILLDUESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TILLDUESToolStripMenuItem.Click
        If Rent = True Then MsgBox("Please Let the client off.", MsgBoxStyle.Information) : Exit Sub
        If CSOFT.CheckFormDBChg_GoOn(Me.AukDatabaseDataSet.DVD_Rent, Me) = False Then Exit Sub
        SFC("Due")
        STC("True")
        DTC("b")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.DVD_Rent)
    End Sub

    Private Sub AddNewMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewMemberToolStripMenuItem.Click
        FrmL(Costomers)
    End Sub

    Private Sub sETrENTURNdATEdURATION(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem78.Click
        INX = InputBox("TYPE DURATION IN HOUR ,TO MAKE RETURN DATE=DATE RENT +HOUR:", "DURATION(H)", INX)
        If INX = "" Then Exit Sub
        NX = Val(INX)
        Dim DRENT_DATE, RDaTEX As Date
        DRENT_DATE = CDate(AukF.GridT(Me.DVD_RentDataGridView, 7)) 'RENTAL DATE
        RDaTEX = DRENT_DATE.AddHours(NX)
        If DRow > -1 Then Me.DVD_RentDataGridView(8, DRow).Value = RDaTEX

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If Me.TabControl1.SelectedIndex = 1 Then
            If Rent = True Then
                If My.Settings.RENT_MOVIE_BY_DVDOPT = 0 Then
                    Me.DVD_RentDataGridView.Focus()
                Else
                    Costomers_nameLabel.Focus()
                End If
            Else
                Costomer_IDLoad.Focus()
            End If
        End If
    End Sub

    Private Sub Product_CollectionDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Product_CollectionDataGridView.DataError, DVD_RentDataGridView.DataError
        GrdErrMsg(e)
    End Sub

    Private Sub ADDNEWMOVIETYPEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDNEWMOVIETYPEToolStripMenuItem.Click
        MovieTypeRefresh(sender, e)
        FrmL(Movie_Type)
    End Sub

    Private Sub MovieTypeRefresh(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem79.Click
        Me.TypeTableAdapter1.Fill(Me.AukDatabaseDataSet.Type)
    End Sub

    Private Sub REFRESHWHOLEDATABASEFORREJECHERRORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHWHOLEDATABASEFORREJECHERRORToolStripMenuItem.Click
        Product_input_Load(sender, e)

    End Sub
End Class