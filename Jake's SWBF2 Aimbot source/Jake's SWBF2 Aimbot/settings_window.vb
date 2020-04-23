Imports System.IO

Public NotInheritable Class settings_window

    Private Sub settings_window_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dir2 = Directory.GetCurrentDirectory()
        Try
            Dim reader As New System.IO.StreamReader(dir2 & "\settings.ini")
            Dim load1(6) As String
            Dim num As Integer = 0
            Do While reader.Peek <> -1
                load1(num) = reader.ReadLine
                num += 1
            Loop
            reader.Close()
            'steam
            If load1(0) = "steam = true" Then
                steam.Checked = True
            Else
                steam.Checked = False
            End If
            'OS
            If load1(1) = "OS = x86" Then
                x86.Checked = True
            ElseIf load1(1) = "OS = x64" Then
                x64.Checked = True
            ElseIf load1(1) = "OS = custom" Then
                customdir.Checked = True
            End If
            'win
            If load1(2) = "win = true" Then
                windowed.Checked = True
            Else
                windowed.Checked = False
            End If
            'fix audio
            If load1(3) = "audio = true" Then
                fixaudio.Checked = True
            Else
                fixaudio.Checked = False
            End If
            'skip logos
            If load1(4) = "skip = true" Then
                skiplogos.Checked = True
            Else
                skiplogos.Checked = False
            End If
            'sounds
            If load1(5) = "sound = true" Then
                playsounds.Checked = True
            Else
                playsounds.Checked = False
            End If
            'nohotkeys
            If load1(6) = "nohotkeys = true" Then
                disablehotkeys.Checked = True
            Else
                disablehotkeys.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public sound As Boolean
    Public nohotkeys As Boolean


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Close1.Click, Close1.Click
        'close
        Close()
    End Sub
    Dim save(6) As String
    Dim dir2 As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Save1.Click
        'save
        'steam
        If steam.Checked = True Then
            save(0) = "steam = true"
        Else
            save(0) = "steam = false"
        End If
        'x86
        If x86.Checked = True Then
            save(1) = "OS = x86"
        End If
        'x64
        If x64.Checked = True Then
            save(1) = "OS = x64"
        End If
        'custom
        If customdir.Checked = True Then
            save(1) = "OS = custom"
        End If
        'windowed mode
        If win = True Then
            save(2) = "win = true"
        Else
            save(2) = "win = false"
        End If
        'fix audio stuttering
        If audio = True Then
            save(3) = "audio = true"
        Else
            save(3) = "audio = false"
        End If
        'skip intro
        If skip = True Then
            save(4) = "skip = true"
        Else
            save(4) = "skip = false"
        End If
        'sounds
        If sound = True Then
            save(5) = "sound = true"
        Else
            save(5) = "sound = false"
        End If
        'hotkeys
        If nohotkeys = True Then
            save(6) = "nohotkeys = true"
        Else
            save(6) = "nohotkeys = false"
        End If
        dir2 = Directory.GetCurrentDirectory()
        Try
            File.WriteAllLines(dir2 & "\settings.ini", save)
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            MsgBox("Settings successfully saved!")
        Catch ex As Exception
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MsgBox("Failed to save the settings to a file!")
        End Try
    End Sub
    Dim myfile As New System.Diagnostics.Process
    Dim arg As String
    Dim dir As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Launch.Click
        'launch
        Try
            With myfile
                .StartInfo.WorkingDirectory = dir
                .StartInfo.FileName = "BattlefrontII"
                .StartInfo.Arguments = arg
            End With
            myfile.Start()
        Catch ex As Exception
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MsgBox("Could not find BattlefrontII.exe!")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles steam.CheckedChanged
        'steam
        If x86.Checked = True And steam.Checked = False Then
            RichTextBox1.Text = ("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData")
        ElseIf x86.Checked = True And steam.Checked = True Then
            RichTextBox1.Text = ("C:\Program Files\Steam\SteamApps\common\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files\Steam\SteamApps\common\Star Wars Battlefront II\GameData")
        End If
        If x64.Checked = True And steam.Checked = False Then
            RichTextBox1.Text = ("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData")
        ElseIf x64.Checked = True And steam.Checked = True Then
            RichTextBox1.Text = ("C:\Program Files (x86)\Steam\SteamApps\common\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files (x86)\Steam\SteamApps\common\Star Wars Battlefront II\GameData")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles x86.CheckedChanged
        'windows x86
        If x86.Checked = True And steam.Checked = False Then
            RichTextBox1.Text = ("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData")
        ElseIf x86.Checked = True And steam.Checked = True Then
            RichTextBox1.Text = ("C:\Program Files\Steam\SteamApps\common\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files\Steam\SteamApps\common\Star Wars Battlefront II\GameData")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles x64.CheckedChanged
        'windows x64
        If x64.Checked = True And steam.Checked = False Then
            RichTextBox1.Text = ("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData")
        ElseIf x64.Checked = True And steam.Checked = True Then
            RichTextBox1.Text = ("C:\Program Files (x86)\Steam\SteamApps\common\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files (x86)\Steam\SteamApps\common\Star Wars Battlefront II\GameData")
        End If
    End Sub
    Dim win As Boolean
    Dim audio As Boolean
    Dim skip As Boolean

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles windowed.CheckedChanged
        'windowed mode
        If windowed.Checked = True Then
            arg = arg + " -win"
            win = True
        Else
            arg = arg.Replace("-win", "")
            win = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles fixaudio.CheckedChanged
        'fix audio stuttering
        If fixaudio.Checked = True Then
            arg = arg + " -audiomixbuffer 80"
            audio = True
        Else
            arg = arg.Replace("-audiomixbuffer 80", "")
            audio = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles skiplogos.CheckedChanged
        'skip startup logos
        If skiplogos.Checked = True Then
            arg = arg + " -nointro"
            skip = True
        Else
            arg = arg.Replace("-nointro", "")
            skip = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles customdir.CheckedChanged
        'custom directory
        If customdir.Checked = True Then
            RichTextBox1.Text = " "
            Browse.Enabled = True
            steam.Checked = False
            steam.Enabled = False
        ElseIf customdir.Checked = False Then
            RichTextBox1.Text = " "
            Browse.Enabled = False
            steam.Enabled = True
        End If
    End Sub
    Dim custom As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Browse.Click
        'browse
        FolderBrowserDialog1.ShowDialog()
        custom = FolderBrowserDialog1.SelectedPath
        dir = FolderBrowserDialog1.SelectedPath
        RichTextBox1.Text = custom
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'disable hotkeys
        If disablehotkeys.Checked = True Then
            nohotkeys = True
        Else
            nohotkeys = False
        End If
        'sounds
        If playsounds.Checked = True Then
            sound = True
        Else
            sound = False
        End If
    End Sub

    Private Sub set_teleport_key_Click(sender As Object, e As EventArgs) Handles set_teleport_key.Click
        setkey.Show()
    End Sub
End Class
