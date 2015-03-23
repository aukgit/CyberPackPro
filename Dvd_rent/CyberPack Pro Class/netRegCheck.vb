Public Module netRegCheck_Class
    Public RunningFunctionWorking As String = ""
    Public Function netRegCheck(ByVal HtmlStr As String) As Boolean
        netRegCheck = False
        If My.Settings.NetReg = True Then
            netRegCheck = True

            Try
                If Now.Year < 2008 Then
                    ''time is not correct
                    MsgBox("Please Set your computer date correctly,restart soft again after set date and time.", MsgBoxStyle.Critical, "Your Computer clock is not correct")
                    SOFTCLOSE()
                    Exit Function
                End If
                If InStr(HtmlStr, "<BODY><PRE>CyberSerial</PRE>", CompareMethod.Binary) > 0 And My.Settings.NetRegBlock = False Then
                    If My.Settings.NetRegBlock = True Then
                        MsgBox("Registration validation is over , please contact with developer.", MsgBoxStyle.Information)
                        SOFTCLOSE()
                        Exit Function
                    End If
                    If Now.Year = 2008 And Now.Day >= 15 And Now.Month = 11 Then 'nov 11 2008 over
                        MsgBox("Registration validation is over , please contact with developer.", MsgBoxStyle.Information)
                        My.Settings.NetReg = False
                        My.Settings.NetRegBlock = True
                        My.Settings.Save()
                        SOFTCLOSE()
                        Exit Function
                    End If
                    Register.ShIn() 'RUN SOFTWARE REG IS FOUND,this current form is closed but we can still call this function again
againCheck:
                    'when we reach the end of ShIN function Now We can Close the Current running Form Because ... 
                    'Now One Form is Still running From ShiN Command
                    If RunningFunctionWorking = "Done" Then

                        SCategory = 1 ' it detect the catagopry which is jut installed ,1= developer edition
                        ' if SCATEGORY is not seleect no form wil load up
                        netRegCheck = True
                        NetConnection.Close()
                    ElseIf RunningFunctionWorking = "Doing" Then
                        GoTo againCheck
                    Else
                        MsgBox("There is an unknown problem cameup .... Please contact with developer.Error Code 9213", MsgBoxStyle.Critical)
                        SOFTCLOSE()
                        End
                    End If

                ElseIf InStr(HtmlStr, "<BODY><PRE>CyberSerial2008</PRE>", CompareMethod.Binary) > 0 Then
                    'reg key is not valid
                    netRegCheck = False
                    NetConnection.Label2.Text = "Your License Key Validation Time Is Expire." & vbCrLf & "Please register for use ( contact with developer )."
                    FrmL(NetConnection)
                Else
                    netRegCheck = False

                    FrmL(NetConnection)
                End If
            Catch ex As Exception
                FrmL(NetConnection)
            End Try
        Else
            Return False
        End If

    End Function
End Module
