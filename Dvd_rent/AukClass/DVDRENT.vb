Imports F = Microsoft.VisualBasic.FileSystem
Imports SYSTEM.ComponentModel

Public Module DVDRENT
    'Public Dhq As Form1.ControlCollection
    Dim CyberCafeForm As New CyberMem
    Public TrayIco As Boolean = False
    Public AniFrm As Boolean = False
    Public AppPath As String = My.Application.Info.DirectoryPath
 
    Public Function SOFTCLOSE(Optional ByVal Object1VisFl As NotifyIcon = Nothing)
        Dim F As String = AppPath & "\CheckSoft.exe"

        If Object1VisFl IsNot Nothing Then
            Object1VisFl.Visible = False
        End If
        Try
            If My.Computer.FileSystem.FileExists(AppPath & "\CheckSoft.exe") = True Then
                Shell(AppPath & "\CheckSoft.exe", AppWinStyle.Hide)
            Else
                MsgBox("Some files of this soft has been deleted,Please ReInstall Windows;Now Soft will be corrupt.", MsgBoxStyle.Critical)
                SrGens.Make_Corrupt()
            End If
        Catch ex As Exception
            Epx()
            SrGens.Make_Corrupt()
        End Try
        End
    End Function

    Public Function TWICE_EXE_View(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs, ByVal Bp As BindingSource, Optional ByVal Titles1 As Object = Nothing, Optional ByVal Titles2 As Object = Nothing, Optional ByVal GotoPos As Boolean = True, Optional ByVal ClrDb As Boolean = False, Optional ByVal F1Func As Integer = 0, Optional ByVal F2Func As Integer = 1, Optional ByVal MaxLoad As Integer = 20, Optional ByVal Start As Integer = 0) As String
        Dim T As DataTable = AukF.Get_DataSystemObj(Bp)
        If e.KeyCode = Keys.Enter Then
            If ADSRC.FIND_FROM_DATATABLE_INDEX(T, sender.text) Then
                If Bp.Filter Is Nothing Then
                    Bp.Position = ComRow
                Else
                    AukF.BindFind(Bp, Titles1, sender.text, True)
                End If
            Else
                TWICE_EXE_View = ADSRC.Twice_Q(Bp, Titles1, Titles2, sender.TEXT, GotoPos, ClrDb, F1Func, F2Func, MaxLoad, Start)
            End If
        End If
    End Function
    Public Sub SAMEBP(ByVal PASTBP As BindingSource, ByVal BP1 As BindingSource)
        PASTBP.DataSource = BP1.DataSource
        PASTBP.DataMember = BP1.DataMember
        PASTBP.Position = BP1.Position
        'PASTBP.Filter = BP1.Filter
    End Sub
    Public Function IMAGE_INPUT_DATATABLE(ByVal FOLDER As String, ByVal T As DataTable, ByVal ENTRY_IMAGE_IN_FIELD As Integer)
        Dim nM As String
        Dim BYTES() As Byte
        Dim tY As New ImageConverter
        'Dim Uni As New System.Text.UnicodeEncoding
        If My.Computer.FileSystem.DirectoryExists(FOLDER) Then
            For K As Integer = 0 To My.Computer.FileSystem.GetFiles(FOLDER).Count - 1
                NM = My.Computer.FileSystem.GetFiles(FOLDER).Item(K).ToString
                N = My.Computer.FileSystem.GetFileInfo(nM).Name.ToString
                N = Left(N, Len(N) - 4)
                If ADSRC.FIND_FROM_DATATABLE_INDEX(T, N, 0) = True Then
                    'MsgBox(nM, , "OK" & N)
                    BYTES = tY.ConvertTo(System.Drawing.Image.FromFile(nM), GetType(Byte()))
                    RowX(ENTRY_IMAGE_IN_FIELD) = BYTES
                End If
            Next
        End If
    End Function
    Public Function ShowQr_Product(ByVal DGrid As Object, ByVal Bp As BindingSource, Optional ByVal EXTRA_QUERY As String = "", Optional ByVal ExeFromQuery_Default_QueryMethod As Form = Nothing)
        'Dim Fq As AukQ = FrmQrObject
        'Dim C As Integer
        If TypeOf (DGrid) Is DataGridView Then AukQ.dV = DGrid
        S = DTXT(DGrid)
        AukQ.Exe_form = ExeFromQuery_Default_QueryMethod
        AukQ.COL = DColumn
        AukQ.ADD_WITHFILTER = EXTRA_QUERY
        AukQ.Bnp = Bp
        FrmL(AukQ)
        AukQ.QueryTextBox.Text = S
        AukQ.QueryTextBox.Focus()
    End Function
    Public Function ShowQr_Product_ONLY_CYBER(ByVal FrmQrObject As AukQ, ByVal DGrid As Object, ByVal Bp As BindingSource, Optional ByVal EXTRA_QUERY As String = "", Optional ByVal Sbp As BindingSource = Nothing, Optional ByVal STitle As String = Nothing)
        Dim Fq As AukQ = FrmQrObject
        If DGrid Is Nothing Then MsgBox("Please Select a DataGrid First then execute the command again.") : Exit Function
        'Dim C As Integer
        If TypeOf (DGrid) Is DataGridView Then Fq.dV = DGrid
        S = DTXT(DGrid)
        Fq.COL = DColumn
        Fq.ADD_WITHFILTER = EXTRA_QUERY
        Fq.Bnp = Bp
        If Sbp IsNot Nothing And STitle IsNot Nothing Then
            Fq.SBp = Sbp
            Fq.S_Table_Open_Link_Field = STitle
        End If
        FrmL(Fq)
        Fq.QueryTextBox.Text = S
        'MsgBox(DTXT(d) & DColumn)
        Fq.QueryTextBox.Focus()
    End Function
    Public Function LOAD_FORMS(ByVal iLOAD As Integer, ByVal CategoryFrm As String, Optional ByVal MSG As String = "")
        Dim Ki As Integer = 0
        Dim Ki2 As Integer = 0
        'MsgBox(SCATEGORY)
        Dim iX As Integer = iLOAD
        Dim CStrX As String = ""
        'LAST NUMBER 34
        Select Case iLOAD 'load options
            Case 14
                FrmL(Option_Gen) : Exit Function
            Case 15
                FrmL(DVDOPT) : Exit Function
            Case 16
                FrmL(AdCyber) : Exit Function
            Case 26
                FrmL(PS_SETTING) : Exit Function
            Case 27
                FrmL(Auk_Information) : Exit Function
            Case 30
                FrmL(MSOLD_SET) : Exit Function 'movie sold set
            Case 31
                FrmL(MSETTING) : Exit Function 'mobile recharge set
            Case 34
                CSOFT.DB_BACKUP() : Exit Function 'db backup if tver=false then
                'Case 35
                '    CSOFT.RUN_CONDITIONS() : Exit Function 'RUN CONDITIONS
        End Select

        Select Case SCATEGORY
            Case 0
                CStrX = "cdms"
            Case 1
                CStrX = "cdms"
            Case 2
                CStrX = "cdms"
            Case 3
                CStrX = "c"
            Case 4
                CStrX = "d"
            Case 5
                CStrX = "m"
            Case 6
                CStrX = "s"
            Case 7
                CStrX = "cdm"
            Case 8
                CStrX = "ms"
            Case 9
                CStrX = "cms"
            Case 10
                CStrX = "dms"
            Case 11
                CStrX = "cm"
            Case 12
                CStrX = "cd"
        End Select
        'MsgBox(CategoryFrm)
        If InStr(CStrX, CategoryFrm, CompareMethod.Text) > 0 And LCase(CategoryFrm) = "c" Then
            Select Case iLOAD
                Case 0
                    FrmL(Cyber)
                Case 1
                    If CyberCafeForm.Created = True Then
                        CyberCafeForm.CyberCafe = True
                        FrmL(CyberCafeForm)
                    Else
                        CyberCafeForm = New CyberMem
                        CyberCafeForm.CyberCafe = True
                        FrmL(CyberCafeForm)
                    End If
                Case 3
                    FrmL(CyberMem)
                Case 4
                    FrmL(Pakages)
                Case 5
                    FrmL(FeesPaid)
            End Select
        ElseIf InStr(CStrX, CategoryFrm, CompareMethod.Text) > 0 And LCase(CategoryFrm) = "d" Then
            Select Case iLOAD
                Case 6
                    Product_Input3.TabControl1.SelectedIndex = 1
                    FrmL(Product_Input3)
                Case 7
                    FrmL(Product_Input3)
                Case 8
                    FrmL(Costomers)
                Case 9
                    FrmL(Movie_Type)
                Case 10
                    FrmL(SelfEntry)
                Case 17
                    FrmL(MSold) 'movies sold
                Case 21
                    FrmL(MOVIES_VIEWS) 'movies summary
                Case 22
                    MOVIES_VIEWS.TODAYS_RP_SHOW_PRINT()  'movies summary today print
                Case 25
                    FrmL(ViewInfo2) 'movies instore summary
                Case 32
                    ViewInfo2.TODAYSVIEW()  'movies rent todays View
            End Select
        ElseIf InStr(CStrX, CategoryFrm, CompareMethod.Text) > 0 And LCase(CategoryFrm) = "m" Then
            Select Case iLOAD
                Case 11
                    FrmL(NewTrans)
                Case 12
                    FrmL(Clients)
                Case 13
                    FrmL(MCompany)
            End Select
        ElseIf InStr(CStrX, CategoryFrm, CompareMethod.Text) > 0 And LCase(CategoryFrm) = "s" Then
            Select Case iLOAD
                Case 18
                    FrmL(PCATE)
                Case 19
                    FrmL(PRO_ADD2)
                Case 20
                    FrmL(PS_SOLD)
                Case 23
                    PS_VIEW.TODAYS_RP_SHOW_PRINT()  'ps summary today print
                Case 24
                    FrmL(PS_VIEW) 'ps summary 
                Case 28
                    FrmL(PS_WARRANTY) 'ps WARRANTY
                Case 29
                    FrmL(PS_CLIENT) 'ps CLIENTS
                Case 33
                    FrmL(Vendor) 'CALL VENDORS

            End Select
        Else
            'If MSG = "" Then MsgBox("You can't run this in this package...Please buy from Auk(01913 500863)", MsgBoxStyle.Critical) Else MsgBox(MSG, MsgBoxStyle.Critical, "This Packge is not supported with this form")
            FrmL(Buyx)
        End If

    End Function
    Public Sub FrmL(ByVal Frm As Form)
        On Error GoTo b
        'On Error Resume Next
        If Frm.Created = False Then
            Frm.Show()
            Frm.Activate()
        Else
            Frm.Activate()
            If Frm.Visible = False Then
                Frm.Visible = True
            End If
        End If
        If Frm.WindowState = FormWindowState.Minimized Then
            Frm.WindowState = FormWindowState.Normal
        End If
        Frm.Focus()
        Exit Sub
b:      Epx(Frm.Text)
    End Sub

    Public Function SET_VISIBLE_DATACOLUMN(ByVal D As DataGridView, ByVal CHK_BOOL As Boolean, ByVal COLUMN As Integer)
        'If CHK_BOOL = True Then
        Try
            If D.Columns(COLUMN).Visible <> CHK_BOOL Then
                D.Columns(COLUMN).Visible = CHK_BOOL
            End If
        Catch ex As Exception
            Epx()
        End Try
      
        'End If
    End Function
    Public Function SET_READONLY_COLUMN(ByVal D As DataGridView, ByVal CHK_BOOL As Boolean, ByVal COLUMN As Integer)
        'If CHK_BOOL = True Then
        Try
            If D.Columns(COLUMN).ReadOnly <> CHK_BOOL Then
                D.Columns(COLUMN).ReadOnly = CHK_BOOL
            End If
        Catch ex As Exception
            Epx()
        End Try
      
        'End If
    End Function
    Public Function IMAGE_INPUT(ByVal OpenFileDialog1 As OpenFileDialog, ByVal IMAGEOBJECT As PictureBox)
        'Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Jpg File|*.Jpg|Png Files|*.png|Gif File|*.Gif|Bmp File|*.Bmp"
        OpenFileDialog1.FilterIndex = My.Settings.ImageFiltersIndex
        Try
            If OpenFileDialog1.ShowDialog() = Forms.DialogResult.OK Then
                IMAGEOBJECT.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName.ToString)
                My.Settings.ImageFiltersIndex = OpenFileDialog1.FilterIndex
                My.Settings.Save()
                'MsgBox("ok")
            End If
        Catch ex As Exception
            If OpenFileDialog1.FileName <> "" Then Epx()
        End Try
    End Function
    Public Function IMAGE_SAVE(ByVal OpenFileDialog1 As SaveFileDialog, ByVal IMAGE As PictureBox)
        'Dim OpenFileDialog1 As New SaveFileDialog
        OpenFileDialog1.Filter = "Jpg File|*.Jpg|Png Files|*.png|Gif File|*.Gif|Bmp File|*.Bmp"
        OpenFileDialog1.FilterIndex = My.Settings.ImageFiltersIndex
        OpenFileDialog1.AddExtension = True
        Try
            If OpenFileDialog1.ShowDialog() = Forms.DialogResult.OK Then
                Dim bmp1 As New Bitmap(IMAGE.Image)
                Select Case OpenFileDialog1.FilterIndex
                    Case 0
                        bmp1.Save(OpenFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Case 1
                        bmp1.Save(OpenFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
                    Case 2
                        bmp1.Save(OpenFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                    Case 3
                        bmp1.Save(OpenFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                End Select
                My.Settings.ImageFiltersIndex = OpenFileDialog1.FilterIndex
                My.Settings.Save()
                'MsgBox("ok")
            End If
        Catch ex As Exception
            If OpenFileDialog1.FileName <> "" Then Epx()
        End Try
    End Function
End Module
