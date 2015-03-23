Public Class FeesPaid
    Dim Row1 As AukDatabaseDataSet.Cyber_MonthlyFeesRow

    Dim MFees As New AukDatabaseDataSetTableAdapters.Cyber_MonthlyFeesTableAdapter

    Private Sub Cyber_MemberBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Validate()
        'Me.Cyber_MemberBindingSource.EndEdit()
        'Me.Cyber_MemberTableAdapter.Update(Me.AukDatabaseDataSet.Cyber_Member)

    End Sub

    Private Sub FeesPaid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'e.Cancel = True
        'Me.Hide()

    End Sub
  
    Private Sub FeesPaid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Cyber_Member' table. You can move, or remove it, as needed.
        'Me.Cyber_MemberTableAdapter.Fill(Me.AukDatabaseDataSet.Cyber_Member)
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.Cyber_MonthlyFees' table. You can move, or remove it, as needed.
        'Me.Cyber_MonthlyFeesTableAdapter.Fill(Me.AukDatabaseDataSet.Cyber_MonthlyFees)
        ''TODO: This line of code loads data into the 'AukDatabaseDataSet.Cyber_Member' table. You can move, or remove it, as needed.
        'Me.Cyber_MemberTableAdapter.Fill(Me.AukDatabaseDataSet.Cyber_Member)
        'Cyber_MemberID,Cyber_Member_Name,Member_Charge_Monthly,Advance_Fees,Cyber_Connect
        If My.Settings.DataLoad_view = False Then
            SFC("MEMBERCATEGORY")
            STC("BROADBAND")

            AukF.Db_Load("*", "Cyber_Member", Me.AukDatabaseDataSet.Cyber_Member, False, "", False, False, 200)
        End If
        Me.Monthly_Fees_Paid_DateDateTimePicker.Value = Now.Date
        Me.Monthly_Fees_Paid_DateDateTimePicker.Value = Now

    End Sub

    Private Sub Cyber_MemberIDTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cyber_MemberIDTextBox.KeyDown
        On Error Resume Next

        If e.KeyCode = Keys.Enter Then
            If AukF.BindFind(Me.Cyber_MemberBindingSource, "Cyber_MemberID", sender.text, True) = True Then
                Me.Cyber_Member_NameTextBox.Text = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(1).ToString
                Me.Member_Charge_MonthlyTextBox.Text = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(5).ToString
                'Me.Advance_FeesTextBox.Text = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(5).ToString
                Me.Advance_FeesTextBox.Text = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(6).ToString
                'Me.Cyber_ConnectCheckBox.CheckState = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(6).ToString
                Check()
                'Me.MonthlyFees_PaidTextBox.Text = Val(Row1.Item("MonthlyFees_Paid").ToString)
                'Me.MonthlyFess_DueTextBox.Text = Val(Row1.Item("MonthlyFess_Due").ToString)
                Me.Monthly_Fees_Paid_DateDateTimePicker.Value = CDate(Row1.Monthly_Fees_Paid_Date)
                Me.CommentsTextBox1.Text = CStr(Row1.Comments)
                Me.MonthlyFees_PaidTextBox.Text = Val(CStr(Row1.MonthlyFees_Paid))
                Me.MonthlyFess_DueTextBox.Text = Val(CStr(Row1.MonthlyFess_Due))
            Else
                SFC("Cyber_MemberID")
                STC(sender.text)
                AukF.Db_Load("*", "Cyber_Member", Me.AukDatabaseDataSet.Cyber_Member, False)
                If AukF.BindFind(Me.Cyber_MemberBindingSource, "Cyber_MemberID", sender.text, True) = True Then
                    Me.Cyber_Member_NameTextBox.Text = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(1).ToString
                    Me.Member_Charge_MonthlyTextBox.Text = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(5).ToString
                    'Me.Advance_FeesTextBox.Text = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(5).ToString
                    Me.Advance_FeesTextBox.Text = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(6).ToString
                    'Me.Cyber_ConnectCheckBox.CheckState = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(6).ToString
                    Check()
                    Me.Monthly_Fees_Paid_DateDateTimePicker.Value = CDate(Row1.Monthly_Fees_Paid_Date)
                    Me.CommentsTextBox1.Text = CStr(Row1.Comments)
                    Me.MonthlyFees_PaidTextBox.Text = Val(CStr(Row1.MonthlyFees_Paid))
                    Me.MonthlyFess_DueTextBox.Text = Val(CStr(Row1.MonthlyFess_Due))
                Else
                    Me.Label2.Text = "This member is not valid"
                    Me.Monthly_Fees_Paid_DateDateTimePicker.Value = CDate(Now.Date)
                    Me.CommentsTextBox1.Text = ""
                    Me.MonthlyFees_PaidTextBox.Text = ""
                    Me.MonthlyFess_DueTextBox.Text = ""
                End If
            End If

        End If
    End Sub
    Public Function Check(Optional ByVal EfftectOn As Boolean = True) As Boolean
        'Q_ERRORMSG = False
        SFC("Cyber_MemberID", "Month_Name", "Year_of_Month")
        STC(Me.Cyber_MemberIDTextBox.Text, Me.Monthly_Fees_Paid_DateDateTimePicker.Value.Date.Month, Me.Monthly_Fees_Paid_DateDateTimePicker.Value.Date.Year)
        AukF.Db_LoadN(Me.AukDatabaseDataSet.Cyber_MonthlyFees, -1, "", True, 0, "", False, 0, 1)
        'Clipboard.Clear()
        'Clipboard.SetText(Sql)
        If Me.AukDatabaseDataSet.Cyber_MonthlyFees.Rows.Count > 0 Then
            Me.Label2.Text = UCase("MemberID :<" & Me.Cyber_MemberIDTextBox.Text & "> [(Date:" & Me.Monthly_Fees_Paid_DateDateTimePicker.Value.Date.Month.ToString & "/" & Me.Monthly_Fees_Paid_DateDateTimePicker.Value.Date.Year & ") , Paid :" & Me.AukDatabaseDataSet.Cyber_MonthlyFees.Rows(0).Item(6).ToString & " TK. and Due: " & Me.AukDatabaseDataSet.Cyber_MonthlyFees.Rows(0).Item(7).ToString & " TK.]")
            Check = True
            Row1 = Me.AukDatabaseDataSet.Cyber_MonthlyFees.Rows(0)

        Else
            If AukF.BindFind(Me.Cyber_MemberBindingSource, "Cyber_MemberID", Me.Cyber_MemberIDTextBox.Text) = True Then
                'Row1 = Me.AukDatabaseDataSet.Cyber_MonthlyFees.Rows(0)

                Me.Label2.Text = UCase("MemberID :(" & Me.Cyber_MemberIDTextBox.Text & ") [(Date:" & Me.Monthly_Fees_Paid_DateDateTimePicker.Value.Date.Month.ToString & "/" & Me.Monthly_Fees_Paid_DateDateTimePicker.Value.Date.Year & ") , Fees is Due(NOT PAID YET).]")
                If EfftectOn = True Then
                    Me.Monthly_Fees_Paid_DateDateTimePicker.Value = CDate(Now.Date)
                    Me.CommentsTextBox1.Text = ""
                    Me.MonthlyFees_PaidTextBox.Text = ""
                    Me.MonthlyFess_DueTextBox.Text = ""
                End If
        
                'Check = True
            Else
                Me.Label2.Text = "CURRENT MEMBER IS NOT VALID OR NOT LOADED YET OR ENTRY MORE.<PRESS ENTER>"
                Check = False
            End If
            'Me.Monthly_Fees_Paid_DateDateTimePicker.Value = CDate(Now.Date)
            'Me.CommentsTextBox1.Text = ""
            'Me.MonthlyFees_PaidTextBox.Text = ""
            'Me.MonthlyFess_DueTextBox.Text = ""
        End If
        Q_ERRORMSG = True
    End Function
    Private Sub Cyber_MemberIDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cyber_MemberIDTextBox.TextChanged
        If AukF.BindFind(Me.Cyber_MemberBindingSource, "Cyber_MemberID", sender.text, True) = True Then
            Me.Cyber_Member_NameTextBox.Text = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(1).ToString
            Me.Member_Charge_MonthlyTextBox.Text = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(5).ToString
            Me.Advance_FeesTextBox.Text = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(6).ToString
            'Me.Advance_FeesTextBox.Text = Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item(5).ToString
            'Me.Label3.Text = UCase(Me.AukDatabaseDataSet.Cyber_Member.Rows(ComRow).Item("MEMBERCATEGORY").ToString)
            Me.Label2.Text = "CURRENT MEMBER IS VALID."
        Else
            Me.Cyber_Member_NameTextBox.Text = ""
            Me.Member_Charge_MonthlyTextBox.Text = ""
            Me.Advance_FeesTextBox.Text = ""
            'Me.Advance_FeesTextBox.Text = ""
            Me.Label2.Text = "CURRENT MEMBER IS NOT VALID OR NOT LOADED YET.<PRESS ENTER>"
            'Me.Label3.Text = "MEMBER CATEGORY"

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If AukF.BindFind(Me.Cyber_MemberBindingSource, "Cyber_MemberID", Me.Cyber_MemberIDTextBox.Text) = True Then
            If Check(False) = True Then
                Row1.Monthly_Fees_Paid_Date = Me.Monthly_Fees_Paid_DateDateTimePicker.Value.Date
                Row1.Month_Name = Me.Monthly_Fees_Paid_DateDateTimePicker.Value.Date.Month
                Row1.Year_of_Month = Me.Monthly_Fees_Paid_DateDateTimePicker.Value.Date.Year
                Row1.MonthlyFees_Paid = Val(Me.MonthlyFees_PaidTextBox.Text)
                Row1.MonthlyFess_Due = Val(Me.MonthlyFess_DueTextBox.Text)
                Row1.Comments = Me.CommentsTextBox1.Text
                Row1.Mothly_Fees = Val(Me.Member_Charge_MonthlyTextBox.Text)
                'Row1.EndEdit()
                MFees.Update(Row1)
                'Me.mon()
                Me.Label2.Text = "...<" & Me.Cyber_MemberIDTextBox.Text & "> information is submited successfully...<ReSubmited>"
            Else

                Row1 = Me.AukDatabaseDataSet.Cyber_MonthlyFees.NewRow
ChgID:
                sn1 = SoftIn.ToObject_MasterID_ByDate()

                Row1.ID = sn1
                Row1.Cyber_MemberID = Me.Cyber_MemberIDTextBox.Text
                Row1.Monthly_Fees_Paid_Date = Me.Monthly_Fees_Paid_DateDateTimePicker.Value.Date
                Row1.Month_Name = Me.Monthly_Fees_Paid_DateDateTimePicker.Value.Date.Month
                Row1.Year_of_Month = Me.Monthly_Fees_Paid_DateDateTimePicker.Value.Date.Year
                Row1.MonthlyFees_Paid = Val(Me.MonthlyFees_PaidTextBox.Text)
                Row1.MonthlyFess_Due = Val(Me.MonthlyFess_DueTextBox.Text)
                Row1.Comments = Me.CommentsTextBox1.Text
                Row1.Mothly_Fees = Val(Me.Member_Charge_MonthlyTextBox.Text)
                'Row1.EndEdit()
                Row1.Table.Rows.Add(Row1)
                Try
                    MFees.Update(Me.AukDatabaseDataSet.Cyber_MonthlyFees)
                Catch ex As Exception
                    GoTo ChgID
                End Try
                'Me.mon()
                Me.Label2.Text = "...<" & Me.Cyber_MemberIDTextBox.Text & "> information is submited successfully..."

            End If
        Else
            Me.Label2.Text = "...Command Can't be Submited..."
        End If
     
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Check()

    End Sub

    Private Sub MonthlyFees_PaidTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyFees_PaidTextBox.TextChanged
        Me.MonthlyFess_DueTextBox.Text = Val(Me.Member_Charge_MonthlyTextBox.Text) - Val(Me.MonthlyFees_PaidTextBox.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Check() = True Then
            Row1.Table.Rows(0).Delete()
            'Row1.EndEdit()
            MFees.Update(Row1)
            Me.Label2.Text = UCase("...Fees Remove Successfully...")
        Else
            Me.Label2.Text = UCase("...CURRENT Fees is invalid...")

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SoftIn.TxtColor_NumberDefine(Me.MonthlyFess_DueTextBox, 0, Color.Red, Color.White, Color.White, Color.Black, "eg")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Check()
    End Sub

    Private Sub GotoEffect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MonthlyFess_DueTextBox.KeyDown, MonthlyFees_PaidTextBox.KeyDown, CommentsTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("%S")
    End Sub
End Class