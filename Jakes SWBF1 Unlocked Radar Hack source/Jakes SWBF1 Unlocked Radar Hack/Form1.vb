Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Try
                WriteInteger("battlefront", &H59EA47, &HA, nsize:=1)
                WriteInteger("battlefront", &H59EA51, &H0, nsize:=1)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox1.Checked = False Then
            Try
                WriteInteger("battlefront", &H59EA47, &HE, nsize:=1)
                WriteInteger("battlefront", &H59EA51, &H44, nsize:=1)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("The radar hack will allow you to see all friendlies and all enemies on the minimap at all times. Instant respawn sets the clients respawn timer to 1 second making you respawn instantly. A map change/restart is required for this feature to take effect.")
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Try
                WriteLong("battlefront", &H58929C, &H8886C7, nsize:=7)
                WriteInteger("battlefront", &H5892A3, &H3F0000, nsize:=3)
                WriteInteger("battlefront", &H4B1130, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox2.Checked = False Then
            Try
                WriteLong("battlefront", &H58929C, &H8886C7, nsize:=7)
                WriteInteger("battlefront", &H5892A3, &H417000, nsize:=3)
                WriteInteger("battlefront", &H4B1130, &H889, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MsgBox("This hack was coded by {VA}Jake. Hack discovered by Battlebelk and [FC]Rage.")
    End Sub
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim hotkey1 As Boolean
        Dim hotkey2 As Boolean
        hotkey1 = GetAsyncKeyState(Keys.D0)
        hotkey2 = GetAsyncKeyState(Keys.LShiftKey)
        Dim hotkey3 As Boolean
        Dim hotkey4 As Boolean
        hotkey3 = GetAsyncKeyState(Keys.D1)
        hotkey4 = GetAsyncKeyState(Keys.LShiftKey)
        Try
            If hotkey1 = True And hotkey2 = True And CheckBox1.Checked = False Then
                CheckBox1.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey1 = True And hotkey2 = True And CheckBox1.Checked = True Then
                CheckBox1.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey3 = True And hotkey4 = True And CheckBox2.Checked = False Then
                CheckBox2.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey3 = True And hotkey4 = True And CheckBox2.Checked = True Then
                CheckBox2.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
        Catch ex As Exception
            MsgBox("An unknown error occurred when attempting to use hotkeys, please notify the developer of this error.")
        End Try
    End Sub
End Class
