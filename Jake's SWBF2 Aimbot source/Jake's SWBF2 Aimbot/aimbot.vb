Public NotInheritable Class aimbot
    Dim process As String = Form1.process
    Private Sub aimbot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub close_button_Click(sender As Object, e As EventArgs) Handles close_button.Click
        Me.Visible = False
    End Sub

    Private Sub aim_check_CheckedChanged(sender As Object, e As EventArgs) Handles aim_check.CheckedChanged
        If aim_check.Checked = True Then
            WriteInteger(Process, &H4BBA14, &H9090, 2) 'x control
            WriteInteger(Process, &H4BBA1F, &H909090, 3) 'z control
            WriteInteger(Process, &H4BBA19, &H909090, 3) 'y control
        Else
            WriteInteger(Process, &H4BBA14, &H3289, 2) 'x control
            WriteInteger(Process, &H4BBA1F, &H84289, 3) 'z control
            WriteInteger(Process, &H4BBA19, &H47289, 3) 'y control
        End If
    End Sub

    Private Sub enable_aimbot_CheckedChanged(sender As Object, e As EventArgs) Handles enable_aimbot.CheckedChanged
        If enable_aimbot.Checked = False Then
            aim_check.Checked = False
        End If
    End Sub
    Public aimpredict As Boolean = False

    Private Sub aim_predict_check_CheckedChanged(sender As Object, e As EventArgs) Handles aim_predict_check.CheckedChanged
        If aim_predict_check.Checked = True Then
            aimpredict = True
        Else
            aimpredict = False
        End If
    End Sub
End Class
