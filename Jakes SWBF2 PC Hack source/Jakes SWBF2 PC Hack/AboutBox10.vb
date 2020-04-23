Public NotInheritable Class AboutBox10

    Private Sub AboutBox10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TextBox2.Text.Contains("i") Then

        Else
            TextBox2.Text = "No parameters specified"
        End If
        If TextBox1.Text.Length = 0 Then
            TextBox1.Text = "No directory specified!"
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("Directory: " & TextBox1.Text & vbCrLf & vbCrLf & "Process: " & Form1.TextBox1.Text & ".exe" & vbCrLf & vbCrLf & "Launching Parameters: " & TextBox2.Text)
    End Sub
End Class
