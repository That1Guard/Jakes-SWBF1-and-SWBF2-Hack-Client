Public Class Form1
    Dim Mem As ProcMem = New ProcMem
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        CheckBox39.Checked = True
        CheckBox40.Checked = True
        CheckBox41.Checked = True
        Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        AboutBox3.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MsgBox("This hack was made by [RAPTOR]VA-Jake, and is supported for v1.2 of swbf1. Check back often for updates as more features will be available in future releases.")
        Mem.GetProcess("battlefront")
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
        Dim hotkey5 As Boolean
        Dim hotkey6 As Boolean
        hotkey5 = GetAsyncKeyState(Keys.D2)
        hotkey6 = GetAsyncKeyState(Keys.LShiftKey)
        Dim hotkey7 As Boolean
        Dim hotkey8 As Boolean
        hotkey7 = GetAsyncKeyState(Keys.D3)
        hotkey8 = GetAsyncKeyState(Keys.LShiftKey)
        Dim hotkey31 As Boolean
        Dim hotkey32 As Boolean
        hotkey31 = GetAsyncKeyState(Keys.D0)
        hotkey32 = GetAsyncKeyState(Keys.LControlKey)
        Dim hotkey33 As Boolean
        Dim hotkey34 As Boolean
        hotkey33 = GetAsyncKeyState(Keys.D1)
        hotkey34 = GetAsyncKeyState(Keys.LControlKey)
        Dim hotkey35 As Boolean
        Dim hotkey36 As Boolean
        hotkey35 = GetAsyncKeyState(Keys.D2)
        hotkey36 = GetAsyncKeyState(Keys.LControlKey)
        Dim hotkey37 As Boolean
        Dim hotkey38 As Boolean
        hotkey37 = GetAsyncKeyState(Keys.D3)
        hotkey38 = GetAsyncKeyState(Keys.LControlKey)
        Dim hotkey39 As Boolean
        Dim hotkey40 As Boolean
        hotkey39 = GetAsyncKeyState(Keys.D4)
        hotkey40 = GetAsyncKeyState(Keys.LControlKey)
        Dim hotkey41 As Boolean
        Dim hotkey42 As Boolean
        hotkey41 = GetAsyncKeyState(Keys.D5)
        hotkey42 = GetAsyncKeyState(Keys.LControlKey)
        Dim hotkey43 As Boolean
        Dim hotkey44 As Boolean
        hotkey43 = GetAsyncKeyState(Keys.D6)
        hotkey44 = GetAsyncKeyState(Keys.LControlKey)
        Dim hotkey45 As Boolean
        Dim hotkey46 As Boolean
        hotkey45 = GetAsyncKeyState(Keys.D7)
        hotkey46 = GetAsyncKeyState(Keys.LControlKey)
        Dim hotkey47 As Boolean
        Dim hotkey48 As Boolean
        hotkey47 = GetAsyncKeyState(Keys.D8)
        hotkey48 = GetAsyncKeyState(Keys.LControlKey)
        Dim hotkey55 As Boolean
        Dim hotkey56 As Boolean
        hotkey55 = GetAsyncKeyState(Keys.D0)
        hotkey56 = GetAsyncKeyState(Keys.RShiftKey)
        Dim hotkey57 As Boolean
        Dim hotkey58 As Boolean
        hotkey57 = GetAsyncKeyState(Keys.D1)
        hotkey58 = GetAsyncKeyState(Keys.RShiftKey)
        Dim hotkey59 As Boolean
        Dim hotkey60 As Boolean
        hotkey59 = GetAsyncKeyState(Keys.D2)
        hotkey60 = GetAsyncKeyState(Keys.RShiftKey)
        Dim hotkey61 As Boolean
        Dim hotkey62 As Boolean
        hotkey61 = GetAsyncKeyState(Keys.D3)
        hotkey62 = GetAsyncKeyState(Keys.RShiftKey)
        Dim hotkey63 As Boolean
        Dim hotkey64 As Boolean
        hotkey63 = GetAsyncKeyState(Keys.D4)
        hotkey64 = GetAsyncKeyState(Keys.RShiftKey)
        Dim hotkey65 As Boolean
        Dim hotkey66 As Boolean
        hotkey65 = GetAsyncKeyState(Keys.D5)
        hotkey66 = GetAsyncKeyState(Keys.RShiftKey)
        Dim hotkey67 As Boolean
        Dim hotkey68 As Boolean
        hotkey67 = GetAsyncKeyState(Keys.D6)
        hotkey68 = GetAsyncKeyState(Keys.RShiftKey)
        Dim hotkey69 As Boolean
        Dim hotkey70 As Boolean
        hotkey69 = GetAsyncKeyState(Keys.D7)
        hotkey70 = GetAsyncKeyState(Keys.RShiftKey)
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
            If hotkey5 = True And hotkey6 = True And CheckBox3.Checked = False Then
                CheckBox3.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey5 = True And hotkey6 = True And CheckBox3.Checked = True Then
                CheckBox3.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey7 = True And hotkey8 = True And CheckBox4.Checked = False Then
                CheckBox4.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey7 = True And hotkey8 = True And CheckBox4.Checked = True Then
                CheckBox4.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey31 = True And hotkey32 = True And CheckBox5.Checked = False Then
                CheckBox5.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey31 = True And hotkey32 = True And CheckBox5.Checked = True Then
                CheckBox5.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey33 = True And hotkey34 = True And CheckBox6.Checked = False Then
                CheckBox6.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey33 = True And hotkey34 = True And CheckBox6.Checked = True Then
                CheckBox6.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey35 = True And hotkey36 = True And CheckBox7.Checked = False Then
                CheckBox7.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey35 = True And hotkey36 = True And CheckBox7.Checked = True Then
                CheckBox7.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey37 = True And hotkey38 = True And CheckBox8.Checked = False Then
                CheckBox8.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey37 = True And hotkey38 = True And CheckBox8.Checked = True Then
                CheckBox8.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey39 = True And hotkey40 = True And CheckBox9.Checked = False Then
                CheckBox9.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey39 = True And hotkey40 = True And CheckBox9.Checked = True Then
                CheckBox9.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey41 = True And hotkey42 = True And CheckBox10.Checked = False Then
                CheckBox10.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey41 = True And hotkey42 = True And CheckBox10.Checked = True Then
                CheckBox10.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey43 = True And hotkey44 = True And CheckBox11.Checked = False Then
                CheckBox11.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey43 = True And hotkey44 = True And CheckBox11.Checked = True Then
                CheckBox11.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey45 = True And hotkey46 = True And CheckBox12.Checked = False Then
                CheckBox12.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey45 = True And hotkey46 = True And CheckBox12.Checked = True Then
                CheckBox12.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey47 = True And hotkey48 = True And CheckBox13.Checked = False Then
                CheckBox13.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey47 = True And hotkey48 = True And CheckBox13.Checked = True Then
                CheckBox13.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey55 = True And hotkey56 = True And CheckBox14.Checked = False Then
                CheckBox14.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey55 = True And hotkey56 = True And CheckBox14.Checked = True Then
                CheckBox14.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey57 = True And hotkey58 = True And CheckBox15.Checked = False Then
                CheckBox15.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey57 = True And hotkey58 = True And CheckBox15.Checked = True Then
                CheckBox15.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey59 = True And hotkey60 = True And CheckBox16.Checked = False Then
                CheckBox16.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey59 = True And hotkey60 = True And CheckBox16.Checked = True Then
                CheckBox16.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey61 = True And hotkey62 = True And CheckBox17.Checked = False Then
                CheckBox17.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey61 = True And hotkey62 = True And CheckBox17.Checked = True Then
                CheckBox17.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey63 = True And hotkey64 = True And CheckBox18.Checked = False Then
                CheckBox18.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey63 = True And hotkey64 = True And CheckBox18.Checked = True Then
                CheckBox18.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            'If hotkey65 = True And hotkey66 = True And CheckBox19.Checked = False Then
            'CheckBox19.Checked = True
            'My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            'System.Threading.Thread.Sleep(100)
            'ElseIf hotkey65 = True And hotkey66 = True And CheckBox19.Checked = True Then
            'CheckBox19.Checked = False
            'My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep) 
            'System.Threading.Thread.Sleep(100)
            'End If
            If hotkey67 = True And hotkey68 = True And CheckBox42.Checked = False Then
                CheckBox42.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey67 = True And hotkey68 = True And CheckBox42.Checked = True Then
                CheckBox42.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
            If hotkey69 = True And hotkey70 = True And CheckBox44.Checked = False Then
                CheckBox44.Checked = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(100)
            ElseIf hotkey69 = True And hotkey70 = True And CheckBox44.Checked = True Then
                CheckBox44.Checked = False
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                System.Threading.Thread.Sleep(100)
            End If
        Catch ex As Exception
            MsgBox("An unknown error occurred when attempting to use hotkeys, please notify the developer of this error.")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox21.Checked = True
        ElseIf CheckBox1.Checked = False Then
            CheckBox21.Checked = False
        End If
        If CheckBox1.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H4DAE0A, &H90909090, nsize:=4)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox1.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H4DAE0A, &H342454D9, nsize:=4)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox23.Checked = True
        ElseIf CheckBox2.Checked = False Then
            CheckBox23.Checked = False
        End If
        If CheckBox2.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H4DAE06, &H90909090, nsize:=4)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox2.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H4DAE06, &H14244CD8, nsize:=4)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox22.Checked = True
        ElseIf CheckBox3.Checked = False Then
            CheckBox22.Checked = False
        End If
        If CheckBox3.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H510286, &H9090, nsize:=2)
                WriteInteger("battlefront", &H510291, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox3.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H510286, &H3989, nsize:=2)
                WriteInteger("battlefront", &H510291, &H85189, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox20.Checked = True
        ElseIf CheckBox4.Checked = False Then
            CheckBox20.Checked = False
        End If
        If CheckBox4.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H51028B, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox4.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H51028B, &H47989, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = True Then
            CheckBox1.Checked = True
        ElseIf CheckBox21.Checked = False Then
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked = True Then
            CheckBox2.Checked = True
        ElseIf CheckBox23.Checked = False Then
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked = True Then
            CheckBox3.Checked = True
        ElseIf CheckBox22.Checked = False Then
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked = True Then
            CheckBox4.Checked = True
        ElseIf CheckBox20.Checked = False Then
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox24.Checked = True
        ElseIf CheckBox5.Checked = False Then
            CheckBox24.Checked = False
        End If
        If CheckBox5.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H56F2D5, &H9090, nsize:=2)
                WriteInteger("battlefront", &H57389E, &H909090, nsize:=3)
                WriteInteger("battlefront", &H576E82, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox5.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H56F2D5, &HE1D8, nsize:=2)
                WriteInteger("battlefront", &H57389E, &H5860D8, nsize:=3)
                WriteInteger("battlefront", &H576E82, &H5860D8, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            CheckBox26.Checked = True
        ElseIf CheckBox6.Checked = False Then
            CheckBox26.Checked = False
        End If
        If CheckBox6.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H4DA1A7, &H90909090, nsize:=4)
                WriteInteger("battlefront", &H4DA1AB, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox6.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H4DA1A7, &HC2444D9, nsize:=4)
                WriteInteger("battlefront", &H4DA1AB, &H184ED8, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            CheckBox28.Checked = True
        ElseIf CheckBox7.Checked = False Then
            CheckBox28.Checked = False
        End If
        If CheckBox7.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H4DA1AE, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox7.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H4DA1AE, &H1046D8, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            CheckBox30.Checked = True
        ElseIf CheckBox8.Checked = False Then
            CheckBox30.Checked = False
        End If
        If CheckBox8.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H513232, &H909090909090, nsize:=6)
                WriteLong("battlefront", &H51D87F, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox8.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H513232, &HAF096D9, nsize:=6)
                WriteLong("battlefront", &H51D87F, &H6BC95D9, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            CheckBox32.Checked = True
        ElseIf CheckBox9.Checked = False Then
            CheckBox32.Checked = False
        End If
        If CheckBox9.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H5738AC, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox9.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H5738AC, &H9086D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            CheckBox31.Checked = True
        ElseIf CheckBox10.Checked = False Then
            CheckBox31.Checked = False
        End If
        If CheckBox10.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H573737, &HB786D8, nsize:=6)
                WriteLong("battlefront", &H576E27, &HB786D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox10.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H573737, &HB886D8, nsize:=6)
                WriteLong("battlefront", &H576E27, &HB886D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            CheckBox29.Checked = True
        ElseIf CheckBox11.Checked = False Then
            CheckBox29.Checked = False
        End If
        If CheckBox11.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H5738F6, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox11.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H5738F6, &H13096D9, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            CheckBox27.Checked = True
        ElseIf CheckBox12.Checked = False Then
            CheckBox27.Checked = False
        End If
        If CheckBox12.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H56E9FF, &H90909090909090, nsize:=7)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox12.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H56E9FF, &H1000000B286C6, nsize:=7)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            CheckBox25.Checked = True
        ElseIf CheckBox13.Checked = False Then
            CheckBox25.Checked = False
        End If
        If CheckBox13.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H56FB5E, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox13.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H56FB5E, &HB29E88, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked = True Then
            CheckBox5.Checked = True
        ElseIf CheckBox24.Checked = False Then
            CheckBox5.Checked = False
        End If
    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked = True Then
            CheckBox6.Checked = True
        ElseIf CheckBox26.Checked = False Then
            CheckBox6.Checked = False
        End If
    End Sub

    Private Sub CheckBox28_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.Checked = True Then
            CheckBox7.Checked = True
        ElseIf CheckBox28.Checked = False Then
            CheckBox7.Checked = False
        End If
    End Sub

    Private Sub CheckBox30_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox30.CheckedChanged
        If CheckBox30.Checked = True Then
            CheckBox8.Checked = True
        ElseIf CheckBox30.Checked = False Then
            CheckBox8.Checked = False
        End If
    End Sub

    Private Sub CheckBox32_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox32.CheckedChanged
        If CheckBox32.Checked = True Then
            CheckBox9.Checked = True
        ElseIf CheckBox32.Checked = False Then
            CheckBox9.Checked = False
        End If
    End Sub

    Private Sub CheckBox31_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox31.CheckedChanged
        If CheckBox31.Checked = True Then
            CheckBox10.Checked = True
        ElseIf CheckBox31.Checked = False Then
            CheckBox10.Checked = False
        End If
    End Sub

    Private Sub CheckBox29_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox29.CheckedChanged
        If CheckBox29.Checked = True Then
            CheckBox11.Checked = True
        ElseIf CheckBox29.Checked = False Then
            CheckBox11.Checked = False
        End If
    End Sub

    Private Sub CheckBox27_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.Checked = True Then
            CheckBox12.Checked = True
        ElseIf CheckBox27.Checked = False Then
            CheckBox12.Checked = False
        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.Checked = True Then
            CheckBox13.Checked = True
        ElseIf CheckBox25.Checked = False Then
            CheckBox13.Checked = False
        End If
    End Sub

    Private Sub CheckBox39_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox39.CheckedChanged
        If CheckBox39.Checked = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox39.Checked = False
        End If
    End Sub

    Private Sub CheckBox40_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox40.CheckedChanged
        If CheckBox40.Checked = True Then
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox40.Checked = False
            CheckBox46.Checked = False
        End If
    End Sub

    Private Sub CheckBox41_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox41.CheckedChanged
        If CheckBox41.Checked = True Then
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = False
            CheckBox41.Checked = False
            CheckBox42.Checked = False
            CheckBox44.Checked = False
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            CheckBox33.Checked = True
        ElseIf CheckBox14.Checked = False Then
            CheckBox33.Checked = False
        End If
        If CheckBox14.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H510552, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox14.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H510552, &HEC81D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            CheckBox35.Checked = True
        ElseIf CheckBox15.Checked = False Then
            CheckBox35.Checked = False
        End If
        If CheckBox15.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H513C8E, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox15.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H513C8E, &H4508B, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            CheckBox37.Checked = True
        ElseIf CheckBox16.Checked = False Then
            CheckBox37.Checked = False
        End If
        If CheckBox16.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H4DA2C1, &H90909090909090, nsize:=7)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox16.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H4DA2C1, &H446C7, nsize:=7)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = True Then
            CheckBox38.Checked = True
        ElseIf CheckBox17.Checked = False Then
            CheckBox38.Checked = False
        End If
        If CheckBox17.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H57BE19, &H90909090909090, nsize:=7)
                WriteInteger("battlefront", &H57BE20, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox17.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H57BE19, &HE87C7, nsize:=7)
                WriteInteger("battlefront", &H57BE20, &H412000, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
            CheckBox36.Checked = True
        ElseIf CheckBox18.Checked = False Then
            CheckBox36.Checked = False
        End If
        If CheckBox18.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H48E645, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox18.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H48E645, &H440D9, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = True Then
            CheckBox34.Checked = True
        ElseIf CheckBox19.Checked = False Then
            CheckBox34.Checked = False
        End If
    End Sub

    Private Sub CheckBox33_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox33.CheckedChanged
        If CheckBox33.Checked = True Then
            CheckBox14.Checked = True
        ElseIf CheckBox33.Checked = False Then
            CheckBox14.Checked = False
        End If
    End Sub

    Private Sub CheckBox35_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox35.CheckedChanged
        If CheckBox35.Checked = True Then
            CheckBox15.Checked = True
        ElseIf CheckBox35.Checked = False Then
            CheckBox15.Checked = False
        End If
    End Sub

    Private Sub CheckBox37_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox37.CheckedChanged
        If CheckBox37.Checked = True Then
            CheckBox16.Checked = True
        ElseIf CheckBox37.Checked = False Then
            CheckBox16.Checked = False
        End If
    End Sub

    Private Sub CheckBox38_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox38.CheckedChanged
        If CheckBox38.Checked = True Then
            CheckBox17.Checked = True
        ElseIf CheckBox38.Checked = False Then
            CheckBox17.Checked = False
        End If
    End Sub

    Private Sub CheckBox36_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox36.CheckedChanged
        If CheckBox36.Checked = True Then
            CheckBox18.Checked = True
        ElseIf CheckBox36.Checked = False Then
            CheckBox18.Checked = False
        End If
    End Sub

    Private Sub CheckBox34_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox34.CheckedChanged
        If CheckBox34.Checked = True Then
            CheckBox19.Checked = True
        ElseIf CheckBox34.Checked = False Then
            CheckBox19.Checked = False
        End If
    End Sub

    Private Sub CheckBox42_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox42.CheckedChanged
        If CheckBox42.Checked = True Then
            CheckBox43.Checked = True
        ElseIf CheckBox42.Checked = False Then
            CheckBox43.Checked = False
        End If
        If CheckBox42.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H57BCF8, &H909090, nsize:=3)
                WriteInteger("battlefront", &H58B3F7, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox42.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteInteger("battlefront", &H57BCF8, &H144689, nsize:=3)
                WriteInteger("battlefront", &H58B3F7, &H144589, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox43_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox43.CheckedChanged
        If CheckBox43.Checked = True Then
            CheckBox42.Checked = True
        ElseIf CheckBox43.Checked = False Then
            CheckBox42.Checked = False
        End If
    End Sub

    Private Sub CheckBox44_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox44.CheckedChanged
        If CheckBox44.Checked = True Then
            CheckBox45.Checked = True
        ElseIf CheckBox44.Checked = False Then
            CheckBox45.Checked = False
        End If
        If CheckBox44.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H58929C, &H8886C7, nsize:=7)
                WriteInteger("battlefront", &H5892A3, &H3F0000, nsize:=3)
                WriteInteger("battlefront", &H4B1130, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox44.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteLong("battlefront", &H58929C, &H8886C7, nsize:=7)
                WriteInteger("battlefront", &H5892A3, &H417000, nsize:=3)
                WriteInteger("battlefront", &H4B1130, &H889, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox45_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox45.CheckedChanged
        If CheckBox45.Checked = True Then
            CheckBox44.Checked = True
        ElseIf CheckBox45.Checked = False Then
            CheckBox44.Checked = False
        End If
    End Sub
    Dim HackOne As Boolean
    Dim HackOneCave As Integer = 0
    Private Sub CheckBox46_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox46.CheckedChanged
        If CheckBox46.Checked = True Then
            CheckBox47.Checked = True
        ElseIf CheckBox46.Checked = False Then
            CheckBox47.Checked = False
        End If
        If RadioButton2.Checked = True Then
            Try
                If Not HackOne Then
                    HackOneCave = Mem.Allocate
                    Mem.Jmp(&H4DAE06, HackOneCave, "D84C2414D84C2414D9542434", 8)
                Else
                    If Mem.WriteBytes(&H4DAE06, "D84C2414D9542434") Then
                        Mem.DeAllocate(HackOneCave)
                    End If
                End If
                HackOne = Not HackOne
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox47_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox47.CheckedChanged
        If CheckBox47.Checked = True Then
            CheckBox46.Checked = True
        ElseIf CheckBox47.Checked = False Then
            CheckBox46.Checked = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            RadioButton3.Checked = True
            RadioButton5.Checked = True
        ElseIf RadioButton1.Checked = False Then
            RadioButton3.Checked = False
            RadioButton5.Checked = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            RadioButton4.Checked = True
            RadioButton6.Checked = True
        ElseIf RadioButton2.Checked = False Then
            RadioButton4.Checked = False
            RadioButton6.Checked = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            RadioButton1.Checked = True
            RadioButton5.Checked = True
        ElseIf RadioButton3.Checked = False Then
            RadioButton1.Checked = False
            RadioButton5.Checked = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            RadioButton1.Checked = True
            RadioButton3.Checked = True
        ElseIf RadioButton5.Checked = False Then
            RadioButton1.Checked = False
            RadioButton3.Checked = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            RadioButton2.Checked = True
            RadioButton6.Checked = True
        ElseIf RadioButton4.Checked = False Then
            RadioButton2.Checked = False
            RadioButton6.Checked = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            RadioButton2.Checked = True
            RadioButton4.Checked = True
        ElseIf RadioButton6.Checked = False Then
            RadioButton2.Checked = False
            RadioButton4.Checked = False
        End If
    End Sub

    Private Sub CheckBox50_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox50.CheckedChanged
        If CheckBox50.Checked = True Then
            Timer1.Stop()
            Timer1.Enabled = False
        ElseIf CheckBox50.Checked = False Then
            Timer1.Enabled = True
            Timer1.Start()
        End If
    End Sub

    Private Sub CheckBox51_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox51.CheckedChanged
        If CheckBox51.Checked = True Then
            Timer1.Stop()
            Timer1.Enabled = False
            Timer2.Enabled = True
            Timer2.Start()
        ElseIf CheckBox51.Checked = False Then
            Timer2.Stop()
            Timer2.Enabled = False
            Timer1.Enabled = True
            Timer1.Start()
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            RichTextBox1.Text = " "
            Button6.Enabled = True
        ElseIf RadioButton9.Checked = False Then
            RichTextBox1.Text = " "
            Button6.Enabled = False
        End If
    End Sub
    Dim custom As String
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        FolderBrowserDialog1.ShowDialog()
        custom = FolderBrowserDialog1.SelectedPath
        RichTextBox1.Text = custom
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            RichTextBox1.Text = ("C:\Program Files\LucasArts\Star Wars Battlefront\GameData\Battlefront.exe")
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            RichTextBox1.Text = ("C:\Program Files (x86)\LucasArts\Star Wars Battlefront\GameData\Battlefront.exe")
        End If
    End Sub
    Dim myfile As New System.Diagnostics.Process
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            If RadioButton7.Checked = False And RadioButton8.Checked = False And RadioButton9.Checked = False Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                MsgBox("You must select an Operating System first!")
            End If
            If RadioButton7.Checked = True And CheckBox48.Checked = False And CheckBox49.Checked = False Then
                With myfile
                    .StartInfo.WorkingDirectory = "C:\Program Files\LucasArts\Star Wars Battlefront\GameData\"
                    .StartInfo.FileName = "Battlefront.exe"
                End With
                myfile.Start()
            ElseIf RadioButton8.Checked = True And CheckBox48.Checked = False And CheckBox49.Checked = False Then
                With myfile
                    .StartInfo.WorkingDirectory = "C:\Program Files (x86)\LucasArts\Star Wars Battlefront\GameData\"
                    .StartInfo.FileName = "Battlefront.exe"
                End With
                myfile.Start()
            ElseIf RadioButton9.Checked = True And CheckBox48.Checked = False And CheckBox49.Checked = False Then
                With myfile
                    .StartInfo.WorkingDirectory = FolderBrowserDialog1.SelectedPath
                    .StartInfo.FileName = "Battlefront.exe"
                End With
                myfile.Start()
            ElseIf RadioButton7.Checked = True And CheckBox48.Checked = True And CheckBox49.Checked = False Then
                With myfile
                    .StartInfo.WorkingDirectory = "C:\Program Files\LucasArts\Star Wars Battlefront\GameData\"
                    .StartInfo.FileName = "Battlefront.exe"
                    .StartInfo.Arguments = "/nointro"
                End With
                myfile.Start()
            ElseIf RadioButton8.Checked = True And CheckBox48.Checked = True And CheckBox49.Checked = False Then
                With myfile
                    .StartInfo.WorkingDirectory = "C:\Program Files (x86)\LucasArts\Star Wars Battlefront\GameData\"
                    .StartInfo.FileName = "Battlefront.exe"
                    .StartInfo.Arguments = "/nointro"
                End With
                myfile.Start()
            ElseIf RadioButton7.Checked = True And CheckBox48.Checked = True And CheckBox49.Checked = True Then
                With myfile
                    .StartInfo.WorkingDirectory = "C:\Program Files\LucasArts\Star Wars Battlefront\GameData\"
                    .StartInfo.FileName = "Battlefront.exe"
                    .StartInfo.Arguments = "/nointro /win"
                End With
                myfile.Start()
            ElseIf RadioButton8.Checked = True And CheckBox48.Checked = True And CheckBox49.Checked = True Then
                With myfile
                    .StartInfo.WorkingDirectory = "C:\Program Files (x86)\LucasArts\Star Wars Battlefront\GameData\"
                    .StartInfo.FileName = "Battlefront.exe"
                    .StartInfo.Arguments = "/nointro /win"
                End With
                myfile.Start()
            ElseIf RadioButton9.Checked = True And CheckBox48.Checked = True And CheckBox49.Checked = True Then
                With myfile
                    .StartInfo.WorkingDirectory = FolderBrowserDialog1.SelectedPath
                    .StartInfo.FileName = "Battlefront.exe"
                    .StartInfo.Arguments = "/nointro /win"
                End With
                myfile.Start()
            ElseIf RadioButton7.Checked = True And CheckBox48.Checked = False And CheckBox49.Checked = True Then
                With myfile
                    .StartInfo.WorkingDirectory = "C:\Program Files\LucasArts\Star Wars Battlefront\GameData\"
                    .StartInfo.FileName = "Battlefront.exe"
                    .StartInfo.Arguments = "/win"
                End With
                myfile.Start()
            ElseIf RadioButton8.Checked = True And CheckBox48.Checked = False And CheckBox49.Checked = True Then
                With myfile
                    .StartInfo.WorkingDirectory = "C:\Program Files (x86)\LucasArts\Star Wars Battlefront\GameData\"
                    .StartInfo.FileName = "Battlefront.exe"
                    .StartInfo.Arguments = "/win"
                End With
                myfile.Start()
            ElseIf RadioButton9.Checked = True And CheckBox48.Checked = False And CheckBox49.Checked = True Then
                With myfile
                    .StartInfo.WorkingDirectory = FolderBrowserDialog1.SelectedPath
                    .StartInfo.FileName = "Battlefront.exe"
                    .StartInfo.Arguments = "/win"
                End With
                myfile.Start()
            End If
        Catch ex As Exception
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MsgBox("Could not find Battlefront.exe!")
        End Try
    End Sub
End Class
