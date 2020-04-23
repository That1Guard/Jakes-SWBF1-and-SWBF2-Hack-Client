Public NotInheritable Class AboutBox6
    Dim permission As Integer
    Dim path As String
    Dim path2 As String
    Dim path3 As String

    Private Sub AboutBox6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        permission = 1
        Form1.TextBox1.Text = "Battlefront2"
        OpenFileDialog1.ShowDialog()
        Try
            My.Computer.FileSystem.RenameFile(OpenFileDialog1.FileName, "Battlefront2.exe")
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            MsgBox("The file was successfully renamed!")
            path = OpenFileDialog1.FileName
            path3 = OpenFileDialog1.SafeFileName
            path2 = path.Replace(path3, "Battlefront2.exe")
            OpenFileDialog2.FileName = path2
        Catch ex As Exception
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MsgBox("Failed to rename the specified file!")
            Form1.TextBox1.Text = "BattlefrontII"
        End Try
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        permission = 0
        Form1.TextBox1.Text = "BattlefrontII"
        Close()
    End Sub
End Class
