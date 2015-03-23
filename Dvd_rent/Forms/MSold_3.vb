Public Class MSold
    Public GS As Boolean = False
    Public cLIENT As String = ""
    Public soldID As String
    Public RpID As String

    Private Sub MSold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AukDatabaseDataSet.PS_SOLD' table. You can move, or remove it, as needed.
        Me.PS_SOLDTableAdapter.Fill(Me.AukDatabaseDataSet.PS_SOLD)
        Me.TypeTableAdapter.Fill(Me.AukDatabaseDataSet.Type)
        AukF.XPAuk(Me)
   
        Me.ComboBox1.SelectedIndex = 0
        Me.ComboBox7.SelectedIndex = 0
    End Sub


    Private Sub Label5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseDown
        AukF.DragAuk(Me)
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
    'Public Function MDETAILS(Optional ByVal ID As String = "", Optional ByVal F As Boolean = False)
    '    If F = False Then
    '        Me.PictureBox2.Image = My.Resources.Small_imgs.AukWrong
    '        Me.Label9.Text = "MOVIE [" & ID & "] IS NOT FOUND IN YOUR DATABASE."
    '    Else
    '        Me.PictureBox2.Image = My.Resources.Small_imgs.AukRight
    '        Me.Label9.Text = "MOVIE [" & ID & "] IS FOUND IN YOUR DATABASE."
    '    End If
    'End Function
    Private Sub FIND_DVDID(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown, ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SFC("DVD ID", "PLACE")
            'MsgBox(sender.TEXT)
            STC(sender.TEXT, "INSTORE")
            AukF.Db_LoadN(Me.AukDatabaseDataSet.SOLD_VIEW, "*", "", True, Me.ComboBox7.SelectedIndex, "", False, 0, 10)
            Me.SOLDVIEW_BindingSource1.Filter = BSql
            AukF.BindFind(Me.SOLDVIEW_BindingSource1, "DVD ID", sender.TEXT, True)
            'Me.MDETAILS(sender.TEXT, )
            'MsgBox(Sql)

        End If
    End Sub
    Public Function FindB(ByVal DVDID As String, Optional ByVal GotoP As Boolean = False) As Boolean
        FindB = AukF.BindFind(Me.SOLDVIEW_BindingSource1, "DVD ID", DVDID, GotoP)
    End Function
    Public Function FindB_N(ByVal MName As String, Optional ByVal GotoP As Boolean = False) As Boolean
        FindB_N = AukF.BindFind(Me.SOLDVIEW_BindingSource1, "Name", MName, GotoP)
    End Function
    Public Function FindI(ByVal DVDID As String, Optional ByVal GotoP As Boolean = False) As Boolean
        FindI = ADSRC.FIND_FROM_DATATABLE_INDEX(Me.AukDatabaseDataSet.SOLD_VIEW, DVDID)
        Try
            If GotoP = True Then
                Me.SOLDVIEW_BindingSource1.Position = ComRow
            End If
        Catch ex As Exception
        End Try
    End Function
    Private Sub MOVE_FIND(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SFC("NAME", "PLACE")
            STC(sender.TEXT, "INSTORE")
            ExpreC("F" & Me.ComboBox7.SelectedIndex)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.SOLD_VIEW, "*", "", False, 0, "", False, -1, 10)
            Me.SOLDVIEW_BindingSource1.Filter = BSql
            AukF.BindFind(Me.SOLDVIEW_BindingSource1, "NAME", sender.TEXT, True)
            'Me.MDETAILS(sender.TEXT, )
            'MsgBox(Sql)

        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SFC("TYPE", "PLACE")
        STC(Me.ComboBox1.Text, "INSTORE")
        AukF.Db_LoadN(Me.AukDatabaseDataSet.SOLD_VIEW, "*", "", False, 0, "", False, -1, 1200)
        If Me.SOLDVIEW_BindingSource1.Filter IsNot Nothing Then
            If Me.SOLDVIEW_BindingSource1.Filter <> BSql Then
                Me.SOLDVIEW_BindingSource1.Filter = BSql
            End If
        Else
            Me.SOLDVIEW_BindingSource1.Filter = BSql
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.SOLDVIEW_BindingSource1.EndEdit()
            Me.SOLD_VIEWTableAdapter.Update(Me.AukDatabaseDataSet.SOLD_VIEW)
        Catch ex As Exception
            Epx()
        End Try
    End Sub
    Public Sub RE_PRINT(Optional ByVal SHOWVIEW As Boolean = False)
        Dim M As New SoldReport
        If SHOWVIEW = True Then
            AukF.Prnt(M, Me.AukDatabaseDataSet, Me.SOLDVIEW_BindingSource1)
        Else
            AukF.SET_FILTER_INrEPORT(M, Me.SOLDVIEW_BindingSource1)
            M.Database.Tables(0).SetDataSource(Me.AukDatabaseDataSet)
            M.PrintToPrinter(1, False, 1, 1)
        End If

    End Sub
 

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AukQ.Bnp = Me.SOLDVIEW_BindingSource1
        AukQ.ClrOpen2.Checked = False
        AukQ.ClrOpen2.Visible = False
        FrmL(AukQ)

    End Sub
    Private Sub DVDID_GOTOFIND(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged, ToolStripTextBox2.TextChanged
        'ADSRC.TWICE_BINDFIND(Me.SOLDVIEW_BindingSource1, "DVD ID", "Name", sender.text)
        If My.Settings.TEXT_CHG_FIND_MSOLD = True Then
            Me.MDETAILS(sender.TEXT, AukF.BindFind(Me.SOLDVIEW_BindingSource1, "DVD ID", sender.TEXT, True))
        End If
    End Sub



    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        AukF.BindFind(Me.SOLDVIEW_BindingSource1, "name", sender.text, True)
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmL(MSOLD_SET)
    End Sub

    Private Sub TabPage2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.RE_PRINT(True)
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        Dim A As Array
        If e.KeyCode = Keys.Enter And e.Modifiers = Keys.Control Then
            If GS = True Then MsgBox("Please Let off Current Client Account.", MsgBoxStyle.Critical) : Exit Sub Else Me.AukDatabaseDataSet.PS_SOLD.Clear()
            SFC("CLIENT_NAME")
            STC(sender.TEXT)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CLIENTS)
            If Me.AukDatabaseDataSet.PS_CLIENTS.Rows.Count = 1 Then
                cLIENT = Me.AukDatabaseDataSet.PS_CLIENTS(0).CLIENT_NAME.ToString
                GS = True
            Else
                A = Me.ToolStripTextBox1.Text.Split(";")
                Me.PS_CLIENTSTableAdapter1.Insert(ArV(A, 0), ArV(A, 1), ArV(A, 2))
                SFC("CLIENT_NAME")
                STC(ArV(A, 0))
                AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CLIENTS)
                If Me.AukDatabaseDataSet.PS_CLIENTS.Rows.Count = 1 Then
                    cLIENT = Me.AukDatabaseDataSet.PS_CLIENTS(0).CLIENT_NAME.ToString
                    GS = True
                Else
                    GS = False
                    MsgBox("NOT FOUND CAN'T CREATE CLIENT,CONTACT WITH DEVELOPER.", MsgBoxStyle.Critical)
                End If
            End If
            SELL()
            Exit Sub
        End If
        If e.KeyCode = Keys.R And e.Modifiers = Keys.Control And e.Modifiers = Keys.Shift Then
            If GS = True Then MsgBox("Please Let off Current Client Account.", MsgBoxStyle.Critical) : Exit Sub Else Me.AukDatabaseDataSet.PS_SOLD.Clear()
            SFC("REPORT_ID")
            STC(RpID)
            AukF.Db_LoadN(Me.RP_IDBindingSource)
            If Me.RP_IDBindingSource.Count <> 1 Then
                MsgBox("No Invoice serial is correctly found.", MsgBoxStyle.Critical)
            End If
            SFC("REPORT_ID")
            STC(sender.TEXT)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SOLD)
            Exit Sub
        End If
        If e.KeyCode = Keys.R And e.Modifiers = Keys.Control Then
            If GS = True Then MsgBox("Please Let off Current Client Account.", MsgBoxStyle.Critical) : Exit Sub Else Me.AukDatabaseDataSet.PS_SOLD.Clear()
            Dim DQA As Date
            A = Me.ToolStripTextBox1.Text.Split(";")
            Try
                DQA = CDate(ArV(A, 1))
            Catch ex As Exception
                Epx(ArV(A, 1))
                Exit Sub
            End Try
            cLIENT = ArV(A, 0)
            Me.GET_RPID(cLIENT, DQA)
            SFC("REPORT_ID")
            STC(RpID)
            AukF.Db_LoadN(Me.RP_IDBindingSource)
            If Me.RP_IDBindingSource.Count <> 1 Then
                MsgBox("No Invoice serial is correctly found.", MsgBoxStyle.Critical)
            Else
                GS = True
            End If
            SFC("REPORT_ID")
            STC(sender.TEXT)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_SOLD)
            'SELL()
            Exit Sub
        End If

        If e.KeyCode = Keys.Enter Then
            If GS = True Then MsgBox("Please Let off Current Client Account.", MsgBoxStyle.Critical) : Exit Sub Else Me.AukDatabaseDataSet.PS_SOLD.Clear()
            SFC("CLIENT_NAME")
            STC(sender.TEXT)
            AukF.Db_LoadN(Me.AukDatabaseDataSet.PS_CLIENTS)
            If Me.AukDatabaseDataSet.PS_CLIENTS.Rows.Count = 1 Then
                cLIENT = Me.AukDatabaseDataSet.PS_CLIENTS(0).CLIENT_NAME.ToString
                GS = True
            Else
                cLIENT = ""
                GS = False
            End If
            SELL()
        End If
    End Sub
    Public Function GET_RPID(ByVal CLIENTn As String, ByVal DATE1 As Date)
        RpID = Replace(SrGens.Convert_Hash(CLIENTn & DATE1.ToLongDateString), "\", "")
        RpID = RpID.Replace(CChar("/@$%&*!\+"), "")
        If RpID.Length < 8 Then
            RpID = RpID & SrGens.Convert_Hash(CLIENTn).Replace(CChar("/@$%&*!\+"), "")
        End If
        RpID = Mid(RpID, 1, 8).ToUpper
        RpID = "INV-" & Now.Month & "-" & RpID
        Return RpID

    End Function
    Public Sub SELL()
        If GS = True Then
            Me.PS_SOLDDataGridView.DataSource = Me.PSSOLDBindingSource
            RpID = Replace(SrGens.Convert_Hash(cLIENT & Now.Date.ToLongDateString), "\", "")
            RpID = RpID.Replace(CChar("/@$%&*!\+"), "")
            'RpID = RpID.Replace("+", "")
            If RpID.Length < 8 Then
                RpID = RpID & SrGens.Convert_Hash(cLIENT).Replace(CChar("/@$%&*!\+"), "")
            End If
            RpID = Mid(RpID, 1, 8).ToUpper
            RpID = "INV-" & Now.Month & "-" & RpID
            SFC("REPORT_ID")
            STC(RpID)
            AukF.Db_LoadN(Me.RP_IDBindingSource)
            SFC("REPORT_ID")
            STC(RpID)
            AukF.Db_LoadN(Me.PSSOLDBindingSource)
            If Me.AukDatabaseDataSet.RP_ID.Rows.Count = 0 Then
                Me.RP_IDTableAdapter.Insert(RpID, 0, 0, 0, 0, "CASH", Me.AukDatabaseDataSet.PS_Employe(0).Employe_Name.ToString, CDate(Now.Date))
                SFC("REPORT_ID")
                STC(RpID)
                AukF.Db_LoadN(Me.RP_IDBindingSource)
                If Me.AukDatabaseDataSet.RP_ID.Rows.Count <> 1 Then
                    MsgBox("CONTACT WITH AUK ERROR IN INSERT REPORT ID,WHICH IS IMPOSSIBLE.", MsgBoxStyle.Critical)
                End If
            End If
        Else
            RpID = ""
            Me.PS_SOLDDataGridView.DataSource = Nothing
        End If
    End Sub
End Class