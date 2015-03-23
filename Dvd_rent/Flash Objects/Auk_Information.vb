Public Class Auk_Information

    Private Sub AxShockwaveFlash1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Disposed
        'Me.Dispose()

    End Sub

    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub

    Private Sub AxShockwaveFlash1_FSCommand(ByVal sender As Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles AxShockwaveFlash1.FSCommand
        'If e.command = "exit" Then
        '    'Me.Hide()
        '    'Me.AxShockwaveFlash1.Dispose()

        '    'Me.Controls.Remove(Me.AxShockwaveFlash1)
        'End If
    End Sub

    Private Sub Auk_Information_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AukF.FullScreenSet(Me, True)

    End Sub

    Private Sub AxShockwaveFlash1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles AxShockwaveFlash1.PreviewKeyDown
        If e.KeyCode = Keys.Z Then
            'Me.Finalize()
            Me.Dispose()

            Me.Close()

        End If
    End Sub
End Class