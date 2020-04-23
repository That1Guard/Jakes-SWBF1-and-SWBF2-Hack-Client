Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
    Dim chat As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked And RadioButton1.Checked Then
            Try
                chat = 0
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat1.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat2.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat3.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat4.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat5.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat6.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat7.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat8.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat9.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat10.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat11.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat12.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat13.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat14.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat15.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat16.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat17.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat18.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat19.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat20.txt")
                chat = chat + 1
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox(chat & " chat logs were deleted.")
            Catch ex As Exception
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox(chat & " chat logs were deleted.")
            End Try
        ElseIf CheckBox1.Checked And RadioButton2.Checked Then
            Try
                chat = 0
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat1.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat2.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat3.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat4.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat5.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat6.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat7.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat8.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat9.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat10.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat11.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat12.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat13.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat14.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat15.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat16.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat17.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat18.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat19.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\Steam\steamapps\common\Star Wars Battlefront II\GameData\chat20.txt")
                chat = chat + 1
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox(chat & " chat logs were deleted.")
            Catch ex As Exception
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox(chat & " chat logs were deleted.")
            End Try
        End If
        If RadioButton1.Checked And CheckBox1.Checked = False Then
            Try
                chat = 0
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat1.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat2.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat3.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat4.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat5.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat6.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat7.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat8.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat9.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat10.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat11.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat12.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat13.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat14.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat15.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat16.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat17.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat18.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat19.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\chat20.txt")
                chat = chat + 1
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox(chat & " chat logs were deleted.")
            Catch ex As Exception
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox(chat & " chat logs were deleted.")
            End Try
        ElseIf RadioButton2.Checked And CheckBox1.Checked = False Then
            Try
                chat = 0
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat1.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat2.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat3.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat4.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat5.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat6.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat7.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat8.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat9.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat10.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat11.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat12.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat13.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat14.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat15.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat16.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat17.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat18.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat19.txt")
                chat = chat + 1
                My.Computer.FileSystem.DeleteFile("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\chat20.txt")
                chat = chat + 1
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox(chat & " chat logs were deleted.")
            Catch ex As Exception
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox(chat & " chat logs were deleted.")
            End Try
        End If
        If CheckBox1.Checked And RadioButton1.Checked = False And RadioButton2.Checked = False Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MsgBox("You must select an Operating System!")
        End If
        If CheckBox1.Checked = False And RadioButton1.Checked = False And RadioButton2.Checked = False Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MsgBox("You must select an option!")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        AboutBox2.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        AboutBox5.Show()
    End Sub
End Class
