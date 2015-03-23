Public Class MCompany
    Dim SFrm As String = Me.AukDatabaseDataSet.Mobile_ReCharge_Summary.TableName.ToString
    Private Sub Mob_ComBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mob_ComBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Mob_ComBindingSource.EndEdit()
            Me.Mob_ComTableAdapter.Update(Me.AukDatabaseDataSet.Mob_Com)
            If NewTrans.Visible = True Then
                NewTrans.Telecom_CompanyRefreshes()

            End If
        Catch ex As Exception
            Epx()

        End Try
      
    End Sub

    Private Sub MCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Mob_Com' table. You can move, or remove it, as needed.
        Me.Mob_ComTableAdapter.Fill(Me.AukDatabaseDataSet.Mob_Com)
        'Me.AukDatabaseDataSet.Mob_Com.Columns.Add("BENEFIT_", System.Type.GetType("String"), "") '7 COLUMN
        'Me.AukDatabaseDataSet.Mob_Com.Columns.Add("DUE_", System.Type.GetType("String"), "") '8 COLUMN
        'Me.AukDatabaseDataSet.Mob_Com.Columns.Add("LOSS_", System.Type.GetType("String"), "") '9 COLUMN
        'ShowTable.Columns.Add("MEMBER CATEGORY", System.Type.GetType("System.String"), "")

        '7=BENEFIT
        '8=DUE
        '9=LOSS
        'Me.DUE_S.DataPropertyName = "DUE_"
        'Me.BENEFIT_S.DataPropertyName = "BENEFIT_"
        'Me.LOSS_S.DataPropertyName = "LOSS_"
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        AukF.SingleDataTable_DataRecordRefresh(Me.Mob_ComBindingSource, True)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        AukF.DeleteFromMasterTable(Me.Mob_ComBindingSource, 0)

    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Me.Hide()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub GetBenefit(ByVal PID As String, ByVal D1 As Date)
        'Dim Table As New DataTable("New_Trans")
        'SFC("Category_ID", "Date_Business")
        'STC(PID)
        'ExpreC("", " Between #" & D1 & "# AND #" & D1.AddDays(30) & "#")



    End Sub
    Public Sub OpenByMONTH(ByVal D1 As String, Optional ByVal FilterDue As Boolean = False)
        Dim D2 As Integer
        Dim G As DataGridView

        Dim BpP, AmT, DuE, LoSS, BeneFit As Decimal
        Dim CoM As String
        Try
            D2 = CDate(CDate(D1)).Month
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        'MsgBox(D2)
        For K As Integer = 0 To Me.AukDatabaseDataSet.Mob_Com.Rows.Count - 1
            BpP = Val(Me.AukDatabaseDataSet.Mob_Com(K).Item(5).ToString) 'GET % BENEFIT
            CoM = Me.AukDatabaseDataSet.Mob_Com(K).Item(1).ToString
            SFC("date_business", "status", "CATAGORY_ID")
            STC(Y, "SEND", CoM)
            'DTC("d")
            ExpreC("*L*")
            AmT = Val(ADSRC.Summary_Totals("NEW_TRANS", "AMOUNT", "SUM"))
            BeneFit = AmT * (BpP / 100)
            Me.AukDatabaseDataSet.Mob_Com(K).Item(7) = BeneFit 'NEW COLUMN BENEFIT
            SFC("date_business", "status", "CATAGORY_ID")
            STC(Y, "SEND BUT NOT PAID YET", CoM)
            'DTC("d")
            ExpreC("*L*")
            DuE = Val(ADSRC.Summary_Totals("NEW_TRANS", "AMOUNT", "SUM"))
            Me.AukDatabaseDataSet.Mob_Com(K).Item(8) = DuE 'NEW COLUMN DUE
            If BeneFit < DuE Then
                LoSS = (BeneFit - DuE) * -1
            Else
                LoSS = 0
            End If
            Me.AukDatabaseDataSet.Mob_Com(K).Item(9) = BeneFit 'NEW COLUMN LOSS
        Next
    End Sub
    Public Sub OpenByYear(ByVal Y As Integer, Optional ByVal FilterDue As Boolean = False)
        'Dim D2 As Date
        Dim G As DataGridView

        Dim BpP, AmT, DuE, LoSS, BeneFit As Decimal
        Dim CoM As String
        'Try
        '    D2 = CDate(CDate(D1))
        'Catch ex As Exception
        '    MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
        '    Exit Sub
        'End Try
        'MsgBox(D2)
        For K As Integer = 0 To Me.AukDatabaseDataSet.Mob_Com.Rows.Count - 1
            BpP = Val(Me.AukDatabaseDataSet.Mob_Com(K).Item(5).ToString) 'GET % BENEFIT
            CoM = Me.AukDatabaseDataSet.Mob_Com(K).Item(1).ToString
            SFC("date_business", "status", "CATAGORY_ID")
            STC(Y, "SEND", CoM)
            'DTC("d")
            ExpreC("*L*")
            AmT = Val(ADSRC.Summary_Totals("NEW_TRANS", "AMOUNT", "SUM"))
            BeneFit = AmT * (BpP / 100)
            Me.AukDatabaseDataSet.Mob_Com(K).Item(7) = BeneFit 'NEW COLUMN BENEFIT
            SFC("date_business", "status", "CATAGORY_ID")
            STC(Y, "SEND BUT NOT PAID YET", CoM)
            'DTC("d")
            ExpreC("*L*")
            DuE = Val(ADSRC.Summary_Totals("NEW_TRANS", "AMOUNT", "SUM"))
            Me.AukDatabaseDataSet.Mob_Com(K).Item(8) = DuE 'NEW COLUMN DUE
            If BeneFit < DuE Then
                LoSS = (BeneFit - DuE) * -1
            Else
                LoSS = 0
            End If
            Me.AukDatabaseDataSet.Mob_Com(K).Item(9) = BeneFit 'NEW COLUMN LOSS
        Next
    End Sub
    Public Sub OpenByDate(ByVal D1 As String, Optional ByVal FilterDue As Boolean = False)
        Dim D2 As Date
        Dim Tn As DataTable
        Dim BpP, AmT, DuE, LoSS, BeneFit As Decimal
        Dim G As DataGridView = Mob_ComDataGridView
        Dim CoM As String
        Try
            D2 = CDate(CDate(D1))
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
            Exit Sub
        End Try
        'MsgBox(D2)
        'For K As Integer = 0 To Me.Mob_ComDataGridView.RowCount - 1
        'DIGITS FIND=DUE=3
        'BENEFIT=7
        'LOSS=8
        BpP = Val(AukF.GridT(G, 3)) 'GET % BENEFIT
        SFC("business date", "status category", "Company")
        STC(D2, "SEND")
        DTC("d")
        ExpreC("", "", "", "null")
        SnX("", "", "", "<>")
        Tn = ADSRC.Summary_Totals_ReturnTable(SFrm, "AMOUNT", "SUM", "COMPANY", "Company,CID,[benefit P]", True) 'sfrm=mob summary form name
        'NOW PUTTING VALUES IN DATABASE
        For N As Integer = 0 To Tn.Rows.Count - 1
            BpP = Val(Tn.Rows(N).Item(3).ToString) 'benefit percent
            CoM = Tn.Rows(N).Item(2).ToString   'company id=2,comname=1
            AmT = Val(Tn.Rows(N).Item(0).ToString) 'value of amount
            BeneFit = AmT * (BpP / 100) 'geting benefit
            If ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.Mob_Com, CoM) = True Then
                RowX(7) = BeneFit 'benefit set
                'RowX() = BeneFit 'benefit set
            End If
        Next

    End Sub

    Private Sub MCompany_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.AukDatabaseDataSet.HasChanges = True Then
            If SAVMSG() = 1 Then
                Mob_ComBindingNavigatorSaveItem_Click(sender, e)
            ElseIf SavInt = 2 Then
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub CurrentMonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentMonthToolStripMenuItem.Click

    End Sub

    Private Sub OpenDays(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesterdayToolStripMenuItem.Click, TodayToolStripMenuItem.Click, TheDayAfterYesterdayToolStripMenuItem.Click
        Me.OpenByDate(CDate(Now.Date).AddDays(Val(sender.tag)))

    End Sub
End Class