Module CSOFT
    Public FlashVersion As String = "9.0.124.0"
    Public FlashFIleName As String = "\install_flash_player.exe"
    Public CompanyName As String = "Developers Organism"
    Public Function VideoHelpItemFolder(ByVal Main As String, ByVal SubFol As String) As Boolean
        If My.Computer.FileSystem.DirectoryExists(AppPath & "\" & Main) = True Then
            If My.Computer.FileSystem.DirectoryExists(AppPath & "\" & Main & "\" & SubFol) = True Then
                Return True
            End If
        End If
    End Function
    Public Sub DGrd_GotolastRow(ByVal Bp As BindingSource)
        On Error Resume Next
        If Bp.Count > 0 Then
            Bp.Position = Bp.Count - 1
        End If
    End Sub
    Public Sub DB_BACKUP()
        If TVer = False Then
            If AukF.MsgTrU("BACKUP DATABASE?", True, MsgBoxStyle.Information) = False Then Exit Sub
            Try
                If My.Settings.REPLACE_DB = True Then
                    nam = My.Settings.BACKUP_FOLDER.ToString & "\" & "CYBERPACK PRO 2.0 BACKUP" & ".mdb"
                Else
                    nam = My.Settings.BACKUP_FOLDER.ToString & "\" & SoftIn.AukDateGet(NDate, "-") & " " & "CYBERPACK PRO 2.0" & ".mdb"
                End If
                My.Computer.FileSystem.CopyFile(SoftDir, nam, True) 'SoftDir=DATABASE FILE PLACE NAME
                MsgBox("DATABASE FILE BACKUP SUCCESSFULLY ON : " & vbCrLf & NAM, MsgBoxStyle.Information, "AUK DATABASE BACKUP 1.0")
            Catch ex As Exception
                Epx(nam)
            End Try
        Else
            MsgBox("IN TRAIL VERSION, IT CAN'T BE POSSIBLE.YOU ALSO CAN'T REINSTALL OR REPLACE DATABASE." & VBCLR & "PLEASE READ THE CONDITIONS OF CYBERPACK PRO.", MsgBoxStyle.Information, "DB BACKUP")
        End If
    End Sub
    Public Sub DateButtonEffectOn(ByVal DGrd As DataGridView, ByVal TBox As TextBox, ByVal DateOption_Method As Boolean)
        Dim Bp As BindingSource = AukF.GetDataGrid_To_Bp(DGrd)
        Dim T As DataTable = AukF.Get_DataSystemObj(Bp)
        Dim FormX As Object = DGrd.FindForm
        If CSOFT.CheckFormDBChg_GoOn(T, FormX, False, "DO YOU WANT TO LOAD NEW IF YOU WANT THEN PLEASE CHOOSE THE OPTION FOR SAVE ." & vbCrLf & "YES=SAVE AND LOAD FOR NEW DATE,NO=STOP SAVE AND DO FOR NEW DATE,CANCEL= CANCEL DOING ALL.") = False Then Exit Sub
        If TBox.Enabled = False Then
            T.Clear()
            DGrd.ReadOnly = True
            DGrd.AllowUserToAddRows = False
            TBox.Enabled = True
            TBox.Focus()
        Else
            If FormX IsNot Nothing Then
                If DateOption_Method Then FormX.DateOption()
            End If
        End If
    End Sub
    Public Function OpenByDateDataGrd(ByVal DGrd As DataGridView, ByVal TBox As Object, ByVal DateField As Object, Optional ByVal NextFunc As Boolean = True, Optional ByVal ExtarnalCmd As Boolean = False, Optional ByVal Calender As Object = Nothing, Optional ByVal ClrBeforeLoad As Boolean = True, Optional ByVal OrdBy As String = "", Optional ByVal BSqlX As String = "") As Date
        If TBox.Enabled = True Then
            Dim D As String
            Dim Date1 As Date
            Dim Bp As BindingSource = AukF.GetDataGrid_To_Bp(DGrd)
            Dim T As DataTable = AukF.Get_DataSystemObj(Bp)
            Dim FieldStr As String = SoftIn.GetTableColumn_NameString(T, DateField)
            If Bp Is Nothing Then Exit Function
            Dim FormX As Object = DGrd.FindForm
            If Calender IsNot Nothing Then Calender.Visible = False
            If CSOFT.CheckFormDBChg_GoOn(T, FormX, False, "DO YOU WANT TO LOAD NEW IF YOU WANT THEN PLEASE CHOOSE THE OPTION FOR SAVE ." & vbCrLf & "YES=SAVE AND LOAD FOR NEW DATE,NO=STOP SAVE AND DO FOR NEW DATE,CANCEL= CANCEL DOING ALL.") = False Then Exit Function
            D = TBox.Text
            Try
                If IsDate(D) = True Then
                    Date1 = CDate(D)
                ElseIf IsNumeric(D) = True Then
                    Date1 = CSOFT.NumToDate(Val(D))
                Else
                    'if date is false
                    If FormX IsNot Nothing Then
                        If NextFunc Then FormX.NextFunc() : Exit Function Else MsgBox("Type Date Format is Not Supported.Please Type A Valid Date.", MsgBoxStyle.Information) : Exit Function
                    Else
                        MsgBox("Type Date Format is Not Supported.Please Type A Valid Date.", MsgBoxStyle.Information)
                    End If
                End If
                DGrd.ReadOnly = False
                If FormX IsNot Nothing Then
                    If ExtarnalCmd Then FormX.ExtarnalCmd()
                End If
                SFC(FieldStr) : STC(Date1) : DTC("d") : SnX("=")
                AukF.Db_LoadN(T, -1, "", ClrBeforeLoad, 0, OrdBy)
                DGrd.AllowUserToAddRows = True
                Dim Ipox As Integer = Bp.Count - 1
                If Ipox >= 0 Then Bp.Position = Ipox
                TBox.enabled = False
                Return Date1
            Catch ex As Exception
                Epx() : TBox.Focus()
            End Try
        End If
    End Function
    Public Function RowStrGetTable(ByVal T As Object, ByVal Column As Object, Optional ByVal Row As Integer = -1, Optional ByVal DefaultStr As String = "") As Object
        If T Is Nothing Then Return DefaultStr
        Dim Tx As DataTable = AukF.Get_DataSystemObj(T)
        Try
            Dim Field As String = SoftIn.GetTableColumn_NameString(Tx, Column).ToString
            If Row = -1 Then Row = 0
            If Tx.Rows.Count > 0 Then
                Return Tx.Rows(Row).Item(Field).ToString
            Else
                Return DefaultStr
            End If
        Catch ex As Exception
            Epx()
        End Try
    End Function

    Public Sub BEFORE_ROW_DATA_INPUT(ByVal D As DataGridView, ByVal INDEX1 As Integer) 'BEST OPTION
        If D.CurrentCell Is Nothing Then Exit Sub
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
    End Sub
    Public Sub CopyClipBoard(ByVal Str As String)
        Clipboard.Clear()
        Clipboard.SetText(Str)
    End Sub
    Public Function CheckOnDb_ShoutDownTime(ByVal DSet As Object, ByVal Formx As Form, Optional ByVal RefreshDb As Boolean = False) As Boolean
        Return CheckFormDBChg_GoOn(DSet, Formx, RefreshDb)
    End Function
    Public Function CheckFormDBChg_GoOn(ByVal DSet As Object, ByVal Formx As Form, Optional ByVal RefreshDb As Boolean = True, Optional ByVal Msgtst As String = Nothing) As Boolean
        Dim Fr As Object = Formx
        If TypeOf (DSet) Is DataSet Then
            '1=save,2=cancel,0=no
            If DSet.HasChanges = True Then
gotoOnSameWork: If SavMsg(Msgtst) = 1 Then
                    Try
                        Fr.SaveAuto() 'try to save database by this common sub
                        Return True
                    Catch ex As Exception
                        Epx()
                        Exit Function
                    End Try

                ElseIf SavInt = 0 Then 'no
                    Try
                        Fr.ReDb() 'refresh database
                    Catch ex As Exception
                    End Try
                    Return True
                ElseIf SavInt = 2 Then 'cancel
                    Return False
                Else
                    Return True
                End If
            Else 'ON CHG FALSE
                Return True
            End If
        Else
            Dim T As DataTable = AukF.Get_DataSystemObj(DSet)
            If SoftIn.GetChages(T) = True Then
                GoTo gotoOnSameWork
            Else 'ON CHG FALSE
                Return True
            End If
        End If

    End Function
    Public Function Date_Get_FromStr(ByVal D1 As String) As Boolean
        Try
            If IsDate(D1) Then
                WGeT = CDate(CDate(D1))
                Return True
            ElseIf IsNumeric(D1) Then
                WGeT = CDate(CSOFT.NumToDate(D1))
                Return True
            Else
                MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
                Return False
            End If
        Catch ex As Exception
            MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
            'Exit Function
        End Try
    End Function
    Public Sub SummaryTextBox_ForOnlyQueryManager(ByVal Tn As DataTable, ByVal DateField As Object, Optional ByVal Find As String = Nothing, Optional ByVal SetBSql As String = "", Optional ByVal ClrBefore As Boolean = True, Optional ByVal ExeOnTable As Boolean = True, Optional ByVal SenderTag As String = Nothing)

        'Dim FR As Object = FormX
        'Dim T As ToolStripTextBox
        'If FR Is Nothing Then FR = Sender.FindForm
        If ClrBefore = True Then
            If SoftIn.GetChages(Tn) = True Then
                If SavMsg("Do You Want to Execute Query?" & vbCrLf & "Please Save Before Execute or you can't get your changes.No= Cancel execute.After that you can't save your data.", "", MsgBoxStyle.Information, MsgBoxStyle.YesNo) = 1 Then 'yes
                    GoTo wrk 'no saving
                ElseIf SavInt = 2 Then 'cancel

                ElseIf SavInt = 0 Then '0=no
                    Exit Sub
                End If
            End If
        End If
wrk:
        If SenderTag IsNot Nothing Then
            a = SenderTag
        Else
            MsgBox("Tag Not found")
        End If
        fieldx = SoftIn.Replace_Database_FieldsNamesByNumber(Tn, DateField)
        If a = "m" Then
            Dim D2 As Date
            SFC(fieldx, fieldx)
            Try
                If CSOFT.Date_Get_FromStr(Find) = True Then
                    D2 = CDate(WGeT)
                Else
                    MsgBox("Please Insert a Valid Date.To get Month & Year from It. Day is not a fact but without day it will not be a vaild date..", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("Please Insert a Valid Date.To get Month & Year from It. Day is not a fact but without day it will not be a vaild date..", MsgBoxStyle.Information)
                Exit Sub
            End Try
            STC(D2.Month, D2.Year)
            SumC("month", "Year")
            DTC("n", "n")
        ElseIf a = "y" Then
            SFC(fieldx)
            Try
                If IsDate(Find) = True Then
                    yx = Val(CDate(Find).Year)
                Else
                    yx = Val((Find))
                End If
            Catch ex As Exception
                MsgBox("Please Insert a Valid Year.", MsgBoxStyle.Information)
                Exit Sub
            End Try
            STC(yx)
            SumC("Year")
            DTC("n")
        ElseIf a = "d" Then
            Dim D2 As Date
            SFC(fieldx)
            Try
                If CSOFT.Date_Get_FromStr(Find) = True Then
                    D2 = CDate(WGeT)
                Else
                    MsgBox("Please Insert a Valid Date.To get Month & Year from It. Day is not a fact but without day it will not be a vaild date..", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
                Exit Sub
            End Try
            STC(D2)
            DTC("d")
            SumC("Cdate")

        Else
            MsgBox("Caregory Not Found", MsgBoxStyle.Critical) : Exit Sub
        End If
        If SetBSql IsNot Nothing Then
            If SetBSql <> "" Then
                'all are may be book so start from 3
                SF(3) = fieldx 'typed for enabled 1 field another ,but this field is not inclueded in function 
                ST(3) = SetBSql
                Expre(3) = "q" 'for Query function,
                'cause we use "quer function" by q
            End If
        End If

        If ExeOnTable = True Then AukF.Db_LoadN(Tn, -1, "", ClrBefore)
        'MsgBox(Sql)
        'CSOFT.CopyClipBoard(Sql)


    End Sub
    Public Sub SummaryTextBox_KeyDown_ForOnlyQueryManager(ByVal Sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs, ByVal Tn As DataTable, ByVal DateField As Object, Optional ByVal Find As String = Nothing, Optional ByVal SetBSql As String = "", Optional ByVal ClrBefore As Boolean = True, Optional ByVal ExeOnTable As Boolean = True, Optional ByVal SenderTag As String = Nothing)
        If e.KeyCode = Keys.Enter Then
            If Find Is Nothing Then Find = Sender.text
            SummaryTextBox_ForOnlyQueryManager(Tn, DateField, Find, SetBSql, ClrBefore, ExeOnTable, SenderTag)
        End If
    End Sub
    Public Sub Events_of_SummaryTextBox_KeyDown(ByVal FormX As Form, ByVal Sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs, ByVal Tn As DataTable, ByVal DateField As Object, Optional ByVal Find As String = Nothing, Optional ByVal SetBSql As String = "", Optional ByVal ClrBefore As Boolean = True, Optional ByVal ExeOnTable As Boolean = True)
        If e.KeyCode = Keys.Enter Then
            Dim FR As Object = FormX
            'Dim T As ToolStripTextBox
            If Find Is Nothing Then Find = Sender.text
            If FR Is Nothing Then FR = Sender.FindForm
            If ClrBefore = True Then
                If SoftIn.GetChages(Tn) = True Then
                    If SavMsg() = 1 Then 'yes
                        FR.SaveAuto()
                    ElseIf SavInt = 2 Then 'cancel
                        Exit Sub
                    ElseIf SavInt = 0 Then '0=no
                        FR.reDB()
                    End If
                End If
            End If
            a = Sender.tag
            fieldx = SoftIn.Replace_Database_FieldsNamesByNumber(Tn, DateField)
            If a = "m" Then
                Dim D2 As Date
                SFC(fieldx, fieldx)
                Try
                    If CSOFT.Date_Get_FromStr(Find) = True Then
                        D2 = CDate(WGeT)
                    Else
                        MsgBox("Please Insert a Valid Date.To get Month & Year from It. Day is not a fact but without day it will not be a vaild date..", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox("Please Insert a Valid Date.To get Month & Year from It. Day is not a fact but without day it will not be a vaild date..", MsgBoxStyle.Information)
                    Exit Sub
                End Try
                STC(D2.Month, D2.Year)
                SumC("month", "Year")
                DTC("n", "n")
            ElseIf a = "y" Then
                SFC(fieldx)
                Try
                    yx = Val(Find)
                Catch ex As Exception
                    MsgBox("Please Insert a Valid Year.", MsgBoxStyle.Information)
                    Exit Sub
                End Try
                STC(yx)
                SumC("Year")
                DTC("n")
            ElseIf a = "d" Then
                Dim D2 As Date
                SFC(fieldx)
                Try
                    If CSOFT.Date_Get_FromStr(Find) = True Then
                        D2 = CDate(WGeT)
                    Else
                        MsgBox("Please Insert a Valid Date.To get Month & Year from It. Day is not a fact but without day it will not be a vaild date..", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox("Please Insert a Valid Date.", MsgBoxStyle.Information)
                    Exit Sub
                End Try
                STC(D2)
                DTC("d")
                'SumC("Cdate")
            Else
                MsgBox("Caregory Not Found", MsgBoxStyle.Critical) : Exit Sub
            End If
            If SetBSql IsNot Nothing Then
                If SetBSql <> "" Then
                    'all are may be book so start from 3
                    SF(3) = fieldx 'typed for enabled 1 field another ,but this field is not inclueded in function 
                    ST(3) = SetBSql
                    Expre(3) = "q" 'for Query function,
                    'cause we use "quer function" by q
                End If
            End If
            If ExeOnTable = True Then AukF.Db_LoadN(Tn, -1, "", ClrBefore)
        End If

    End Sub
    Public Function NumToDate(ByVal Num As String) As Date  'st from 0
        Try
            Return CDate(Num)
        Catch ex As Exception
            Return CDate(NDate()).AddDays(Num)
        End Try
    End Function
    Public Sub RUN_CONDITIONS(ByVal fx As Form)
        'Dim fX As Form
        AukF.OExe(AppPath & "\Conditions.pdf", fx)
    End Sub
    Public Sub RUN_License(ByVal fx As Form)
        'Dim fX As Form
        If My.Computer.FileSystem.FileExists(AppPath & "\License.pdf") = False Then
            AukF.OExe(AppPath & "\License.pdf", fx)
        Else
            MsgBox("License is not attached with this version of soft.. please check license from software installing DVD.", MsgBoxStyle.Information)
        End If

    End Sub
End Module
