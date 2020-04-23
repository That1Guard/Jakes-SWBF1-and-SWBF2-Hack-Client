Public Class Form1
    Dim Mem As ProcMem = New ProcMem

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Information
        AboutBox1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Close Hack
        CheckBox40.Checked = True
        CheckBox42.Checked = True
        CheckBox44.Checked = True
        If AboutBox6.CheckBox1.Checked = True Then
            Try
                My.Computer.FileSystem.RenameFile(AboutBox6.OpenFileDialog2.FileName, "BattlefrontII.exe")
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox("The original file name was successfully restored!")
            Catch ex As Exception
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                MsgBox("There was an error when attempting to restore the original file name. The original file name may not have been restored.")
            End Try
        End If
        Close()
    End Sub
    Private Sub CheckBox39_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox39.CheckedChanged
        'Enable Common Player Hacks
        If CheckBox39.Checked And RadioButton1.Checked Then
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox4.Checked = True
            CheckBox6.Checked = True
            CheckBox103.Checked = True
            CheckBox39.Checked = False
        ElseIf CheckBox39.Checked And RadioButton2.Checked Then
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox6.Checked = True
            CheckBox103.Checked = True
            CheckBox39.Checked = False
        End If
    End Sub

    Private Sub CheckBox40_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox40.CheckedChanged
        'Disable All Player Hacks
        If CheckBox40.Checked Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox33.Checked = False
            CheckBox40.Checked = False
            CheckBox103.Checked = False
        End If
    End Sub

    Private Sub CheckBox41_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox41.CheckedChanged
        'Enable Common Weapon Hacks
        If CheckBox41.Checked And RadioButton3.Checked Then
            CheckBox15.Checked = True
            CheckBox16.Checked = True
            CheckBox17.Checked = True
            CheckBox18.Checked = True
            CheckBox19.Checked = True
            CheckBox21.Checked = True
            CheckBox22.Checked = True
            CheckBox23.Checked = True
            CheckBox41.Checked = False
        ElseIf CheckBox41.Checked And RadioButton4.Checked Then
            CheckBox15.Checked = True
            CheckBox16.Checked = True
            CheckBox17.Checked = True
            CheckBox18.Checked = True
            CheckBox19.Checked = True
            CheckBox21.Checked = True
            CheckBox22.Checked = True
            CheckBox23.Checked = True
            CheckBox41.Checked = False
        End If
    End Sub

    Private Sub CheckBox42_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox42.CheckedChanged
        'Disable All Weapon Hacks
        If CheckBox42.Checked Then
            CheckBox15.Checked = False
            CheckBox16.Checked = False
            CheckBox17.Checked = False
            CheckBox18.Checked = False
            CheckBox19.Checked = False
            CheckBox20.Checked = False
            CheckBox21.Checked = False
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox32.Checked = False
            CheckBox42.Checked = False
            CheckBox89.Checked = False
        End If
    End Sub

    Private Sub CheckBox43_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox43.CheckedChanged
        'Enable Common Map Hacks
        If CheckBox43.Checked And RadioButton5.Checked Then
            CheckBox43.Checked = False
            CheckBox25.Checked = True
            CheckBox29.Checked = True
            CheckBox36.Checked = True
            CheckBox85.Checked = True
            CheckBox87.Checked = True
            CheckBox91.Checked = True
            CheckBox98.Checked = True
            CheckBox100.Checked = True
        ElseIf CheckBox43.Checked And RadioButton6.Checked Then
            CheckBox43.Checked = False
            CheckBox36.Checked = True
            CheckBox25.Checked = True
            CheckBox29.Checked = True
            CheckBox85.Checked = True
            CheckBox87.Checked = True
            CheckBox91.Checked = True
            CheckBox98.Checked = True
            CheckBox100.Checked = True
        End If
    End Sub

    Private Sub CheckBox44_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox44.CheckedChanged
        'Disable All Map Hacks
        If CheckBox44.Checked Then
            CheckBox25.Checked = False
            CheckBox26.Checked = False
            CheckBox27.Checked = False
            CheckBox28.Checked = False
            CheckBox29.Checked = False
            CheckBox30.Checked = False
            CheckBox31.Checked = False
            CheckBox34.Checked = False
            CheckBox35.Checked = False
            CheckBox36.Checked = False
            CheckBox37.Checked = False
            CheckBox38.Checked = False
            CheckBox43.Checked = False
            CheckBox44.Checked = False
            CheckBox83.Checked = False
            CheckBox85.Checked = False
            CheckBox86.Checked = False
            CheckBox87.Checked = False
            CheckBox91.Checked = False
            CheckBox98.Checked = False
            CheckBox100.Checked = False
            CheckBox105.Checked = False
            CheckBox107.Checked = False
            CheckBox108.Checked = False
            CheckBox109.Checked = False
            CheckBox111.Checked = False
            CheckBox112.Checked = False
            CheckBox113.Checked = False
        End If
    End Sub
    Dim HackTwenty As Boolean
    Dim HackTwentyCave As Integer = 0
    Dim HackTwentyOne As Boolean
    Dim HackTwentyOneCave As Integer = 0

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'Infinite Health
        If CheckBox1.Checked = True Then
            CheckBox58.Checked = True
            AboutBox4.Label1.ForeColor = Color.Red
            AboutBox4.Label17.ForeColor = Color.Red
        ElseIf CheckBox1.Checked = False Then
            CheckBox58.Checked = False
            AboutBox4.Label1.ForeColor = Color.Black
            AboutBox4.Label17.ForeColor = Color.Black
        End If
        If CheckBox1.Checked = True And RadioButton1.Checked = True Then
            Try
                WriteInteger("BattlefrontII", &H4D63AB, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox1.Checked = False And RadioButton1.Checked = True Then
            Try
                WriteInteger("BattlefrontII", &H4D63AB, &H44E89, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox1.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteInteger(TextBox1.Text, &H46FC2C, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox1.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteInteger(TextBox1.Text, &H46FC2C, &H44F89, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub
    Dim HackTwentyTwo As Boolean
    Dim HackTwentyTwoCave As Integer = 0
    Dim HackTwentyThree As Boolean
    Dim HackTwentyThreeCave As Integer = 0
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        'Infinite Stamina
        If CheckBox2.Checked And RadioButton2.Checked Then
            CheckBox57.Checked = True
            AboutBox4.Label2.ForeColor = Color.Red
            AboutBox4.Label18.ForeColor = Color.Red
        ElseIf CheckBox2.Checked = False And RadioButton2.Checked Then
            CheckBox57.Checked = False
            AboutBox4.Label2.ForeColor = Color.Black
            AboutBox4.Label18.ForeColor = Color.Black
        End If
        If CheckBox2.Checked And RadioButton1.Checked Then
            CheckBox57.Checked = True
            CheckBox19.Checked = True
            AboutBox4.Label2.ForeColor = Color.Red
            AboutBox4.Label18.ForeColor = Color.Red
        ElseIf CheckBox2.Checked = False And RadioButton1.Checked Then
            CheckBox57.Checked = False
            CheckBox19.Checked = False
            AboutBox4.Label2.ForeColor = Color.Black
            AboutBox4.Label18.ForeColor = Color.Black
        End If
        If CheckBox2.Checked And RadioButton1.Checked Then
            Try
                WriteInteger("BattlefrontII", &H4D7014, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox2.Checked = False And RadioButton1.Checked Then
            Try
                WriteInteger("BattlefrontII", &H4D7014, &H451D9, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox2.Checked And RadioButton2.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H470D4B, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox2.Checked = False And RadioButton2.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H470D4B, &H452D9, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        'Unlimited Jump
        If CheckBox3.Checked Then
            CheckBox56.Checked = True
            AboutBox4.Label3.ForeColor = Color.Red
            AboutBox4.Label19.ForeColor = Color.Red
        ElseIf CheckBox3.Checked = False Then
            CheckBox56.Checked = False
            AboutBox4.Label3.ForeColor = Color.Black
            AboutBox4.Label19.ForeColor = Color.Black
        End If
        If CheckBox3.Checked And RadioButton1.Checked Then
            Try
                WriteLong("BattlefrontII", &H5426B1, &H909090909090, nsize:=6)
                WriteLong("BattlefrontII", &H550052, &H9090909090909090, nsize:=8)
                WriteInteger("BattlefrontII", &H55005A, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox3.Checked = False And RadioButton1.Checked Then
            Try
                WriteLong("BattlefrontII", &H5426B1, &H7549E89, nsize:=6)
                WriteLong("BattlefrontII", &H550052, &H80000075486C7, nsize:=8)
                WriteInteger("BattlefrontII", &H55005A, &H0, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox3.Checked And RadioButton2.Checked Then
            Try
                WriteLong(TextBox1.Text, &H4C272B, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox3.Checked = False And RadioButton2.Checked Then
            Try
                WriteLong(TextBox1.Text, &H4C272B, &H744AB89, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox58_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox58.CheckedChanged
        If CheckBox58.Checked Then
            CheckBox1.Checked = True
        ElseIf CheckBox58.Checked = False Then
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        'Infinite Ship Shields
        If CheckBox4.Checked And RadioButton1.Checked Then
            CheckBox16.Checked = True
            CheckBox55.Checked = True
            AboutBox4.Label4.ForeColor = Color.Red
            AboutBox4.Label20.ForeColor = Color.Red
        ElseIf CheckBox4.Checked = False And RadioButton1.Checked Then
            CheckBox55.Checked = False
            CheckBox16.Checked = False
            AboutBox4.Label4.ForeColor = Color.Black
            AboutBox4.Label20.ForeColor = Color.Black
        End If
        If CheckBox4.Checked And RadioButton2.Checked Then
            CheckBox55.Checked = True
            CheckBox16.Checked = True
            AboutBox4.Label4.ForeColor = Color.Red
            AboutBox4.Label20.ForeColor = Color.Red
        ElseIf CheckBox4.Checked = False And RadioButton2.Checked Then
            CheckBox55.Checked = False
            CheckBox16.Checked = False
            AboutBox4.Label4.ForeColor = Color.Black
            AboutBox4.Label20.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CheckBox57_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox57.CheckedChanged
        If CheckBox57.Checked And RadioButton2.Checked Then
            CheckBox2.Checked = True
        ElseIf CheckBox57.Checked = False And RadioButton2.Checked Then
            CheckBox2.Checked = False
        End If
        If CheckBox57.Checked And RadioButton1.Checked Then
            CheckBox2.Checked = True
        ElseIf CheckBox57.Checked = False And RadioButton1.Checked Then
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox56_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox56.CheckedChanged
        If CheckBox56.Checked Then
            CheckBox3.Checked = True
        ElseIf CheckBox56.Checked = False Then
            CheckBox3.Checked = False
        End If
    End Sub
    Dim HackTwo As Boolean
    Dim HackTwoCave As Integer = 0
    Dim HackTwelve As Boolean
    Dim HackTwelveCave As Integer = 0
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        'Super Jump
        If CheckBox5.Checked Then
            CheckBox12.Checked = False
            CheckBox54.Checked = True
            AboutBox4.Label6.ForeColor = Color.Red
            AboutBox4.Label21.ForeColor = Color.Red
        ElseIf CheckBox5.Checked = False Then
            CheckBox54.Checked = False
            AboutBox4.Label6.ForeColor = Color.Black
            AboutBox4.Label21.ForeColor = Color.Black
        End If
        If RadioButton1.Checked Then
            Try
                If Not HackTwo Then
                    HackTwoCave = Mem.Allocate
                    Mem.Jmp(&H54BB12, HackTwoCave, "D84604D84604D84604D84604D95E04", 6)
                Else
                    If Mem.WriteBytes(&H54BB12, "D84604D95E04") Then
                        Mem.DeAllocate(HackTwoCave)
                    End If
                End If
                HackTwo = Not HackTwo
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
        If RadioButton2.Checked Then
            Try
                If Not HackTwelve Then
                    HackTwelveCave = Mem.Allocate
                    Mem.Jmp(&H4C19CF, HackTwelveCave, "D84304D84304D84304D84304D95B04", 6)
                Else
                    If Mem.WriteBytes(&H4C19CF, "D84304D95B04") Then
                        Mem.DeAllocate(HackTwelveCave)
                    End If
                End If
                HackTwelve = Not HackTwelve
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox54_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox54.CheckedChanged
        If CheckBox54.Checked Then
            CheckBox5.Checked = True
        ElseIf CheckBox54.Checked = False Then
            CheckBox5.Checked = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        'Infinite Hero Health
        If CheckBox6.Checked Then
            CheckBox53.Checked = True
            AboutBox4.Label7.ForeColor = Color.Red
            AboutBox4.Label22.ForeColor = Color.Red
        ElseIf CheckBox6.Checked = False Then
            CheckBox53.Checked = False
            AboutBox4.Label7.ForeColor = Color.Black
            AboutBox4.Label22.ForeColor = Color.Black
        End If
        If CheckBox6.Checked And RadioButton1.Checked Then
            Try
                WriteLong("BattlefrontII", &H652FF8, &H148AFD8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox6.Checked = False Then
            Try
                WriteLong("BattlefrontII", &H652FF8, &H144AFD8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox6.Checked And RadioButton2.Checked Then
            Try
                WriteLong(TextBox1.Text, &H574531, &H148AED8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox6.Checked = False And RadioButton2.Checked Then
            Try
                WriteLong(TextBox1.Text, &H574531, &H144AED8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox53_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox53.CheckedChanged
        If CheckBox53.Checked Then
            CheckBox6.Checked = True
        ElseIf CheckBox53.Checked = False Then
            CheckBox6.Checked = False
        End If
    End Sub

    Private Sub CheckBox55_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox55.CheckedChanged
        If CheckBox55.Checked Then
            CheckBox4.Checked = True
        ElseIf CheckBox55.Checked = False Then
            CheckBox4.Checked = False
        End If
    End Sub
    Dim HackThree As Boolean
    Dim HackThreeCave As Integer = 0
    Dim HackNine As Boolean
    Dim HackNineCave As Integer = 0

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        'Super Sprint
        If RadioButton1.Checked Then
            Try
                If Not HackThree Then
                    HackThreeCave = Mem.Allocate
                    Mem.Jmp(&H5501CC, HackThreeCave, "D88990080000D88990080000 ", 6)
                Else
                    If Mem.WriteBytes(&H5501CC, "D88990080000 ") Then
                        Mem.DeAllocate(HackThreeCave)
                    End If
                End If
                HackThree = Not HackThree
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
        If CheckBox7.Checked Then
            CheckBox52.Checked = True
            AboutBox4.Label8.ForeColor = Color.Red
            AboutBox4.Label23.ForeColor = Color.Red
        ElseIf CheckBox7.Checked = False Then
            CheckBox52.Checked = False
            AboutBox4.Label8.ForeColor = Color.Black
            AboutBox4.Label23.ForeColor = Color.Black
        End If
        If RadioButton2.Checked Then
            Try
                If Not HackNine Then
                    HackNineCave = Mem.Allocate
                    Mem.Jmp(&H4BF022, HackNineCave, "D88E9C060000D88E9C060000", 6)
                Else
                    If Mem.WriteBytes(&H4BF022, "D88E9C060000") Then
                        Mem.DeAllocate(HackNineCave)
                    End If
                End If
                HackNine = Not HackNine
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox52_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox52.CheckedChanged
        If CheckBox52.Checked Then
            CheckBox7.Checked = True
        ElseIf CheckBox52.Checked = False Then
            CheckBox7.Checked = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        'Hover
        If CheckBox8.Checked Then
            CheckBox33.Checked = False
            CheckBox51.Checked = True
            AboutBox4.Label9.ForeColor = Color.Red
            AboutBox4.Label24.ForeColor = Color.Red
        ElseIf CheckBox8.Checked = False Then
            CheckBox51.Checked = False
            AboutBox4.Label9.ForeColor = Color.Black
            AboutBox4.Label24.ForeColor = Color.Black
        End If
        If CheckBox8.Checked And RadioButton2.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H49D85B, &H909090, nsize:=3)
                WriteLong(TextBox1.Text, &H4C1058, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox8.Checked = False And RadioButton2.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H49D85B, &H47989, nsize:=3)
                WriteLong(TextBox1.Text, &H4C1058, &H7948388, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox8.Checked And RadioButton1.Checked Then
            Try
                WriteInteger("BattlefrontII", &H53329B, &H909090, nsize:=3)
                WriteLong("BattlefrontII", &H5523D1, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox8.Checked = False And RadioButton1.Checked Then
            Try
                WriteInteger("BattlefrontII", &H53329B, &H47989, nsize:=3)
                WriteLong("BattlefrontII", &H5523D1, &H7A48388, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox51_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox51.CheckedChanged
        If CheckBox51.Checked Then
            CheckBox8.Checked = True
        ElseIf CheckBox51.Checked = False Then
            CheckBox8.Checked = False
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        'Hardcore Mode
        If CheckBox9.Checked Then
            CheckBox50.Checked = True
            AboutBox4.Label10.ForeColor = Color.Red
            AboutBox4.Label25.ForeColor = Color.Red
        ElseIf CheckBox9.Checked = False Then
            CheckBox50.Checked = False
            AboutBox4.Label10.ForeColor = Color.Black
            AboutBox4.Label25.ForeColor = Color.Black
        End If
        If CheckBox9.Checked And RadioButton1.Checked Then
            Try
                WriteInteger("BattlefrontII", &H4D636C, &H90909090, nsize:=4)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox9.Checked = False And RadioButton1.Checked Then
            Try
                WriteInteger("BattlefrontII", &H4D636C, &H18244CD8, nsize:=4)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox9.Checked And RadioButton2.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H46FBED, &H90909090, nsize:=4)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox9.Checked = False And RadioButton2.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H46FBED, &H18244CD8, nsize:=4)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox50_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox50.CheckedChanged
        If CheckBox50.Checked Then
            CheckBox9.Checked = True
        ElseIf CheckBox50.Checked = False Then
            CheckBox9.Checked = False
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        'Freeze Player Position
        If CheckBox10.Checked Then
            CheckBox49.Checked = True
            AboutBox4.Label11.ForeColor = Color.Red
            AboutBox4.Label26.ForeColor = Color.Red
        ElseIf CheckBox10.Checked = False Then
            CheckBox49.Checked = False
            AboutBox4.Label11.ForeColor = Color.Black
            AboutBox4.Label26.ForeColor = Color.Black
        End If
        If CheckBox10.Checked And RadioButton1.Checked Then
            Try
                WriteLong("BattlefrontII", &H42C91E, &H90909090909090, nsize:=7)
                WriteLong("BattlefrontII", &H42C937, &H90909090909090, nsize:=7)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox10.Checked = False And RadioButton1.Checked Then
            Try
                WriteInteger("BattlefrontII", &H42C91E, &H8B, nsize:=1)
                WriteInteger("BattlefrontII", &H42C91F, &HD02484, nsize:=3)
                WriteInteger("BattlefrontII", &H42C922, &H0, nsize:=2)
                WriteInteger("BattlefrontII", &H42C924, &HD800, nsize:=2)
                WriteInteger("BattlefrontII", &H42C937, &H8B, nsize:=1)
                WriteInteger("BattlefrontII", &H42C938, &H94, nsize:=1)
                WriteInteger("BattlefrontII", &H42C939, &HD824, nsize:=2)
                WriteInteger("BattlefrontII", &H42C93B, &H0, nsize:=2)
                WriteInteger("BattlefrontII", &H42C93D, &HD900, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox10.Checked And RadioButton2.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H49D856, &H9090, nsize:=2)
                WriteInteger(TextBox1.Text, &H49D861, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox10.Checked = False And RadioButton2.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H49D856, &H3989, nsize:=2)
                WriteInteger(TextBox1.Text, &H49D861, &H85189, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox49_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox49.CheckedChanged
        If CheckBox49.Checked Then
            CheckBox10.Checked = True
        ElseIf CheckBox49.Checked = False Then
            CheckBox10.Checked = False
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        'Remove Landing Delay
        If CheckBox11.Checked Then
            CheckBox48.Checked = True
            AboutBox4.Label12.ForeColor = Color.Red
            AboutBox4.Label27.ForeColor = Color.Red
        ElseIf CheckBox11.Checked = False Then
            CheckBox48.Checked = False
            AboutBox4.Label12.ForeColor = Color.Black
            AboutBox4.Label27.ForeColor = Color.Black
        End If
        If CheckBox11.Checked And RadioButton1.Checked Then
            Try
                WriteLong("BattlefrontII", &H54B425, &H9090909090909090, nsize:=8)
                WriteInteger("BattlefrontII", &H54B42D, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox11.Checked = False And RadioButton1.Checked Then
            Try
                WriteLong("BattlefrontII", &H54B425, &H24C86C7, nsize:=8)
                WriteInteger("BattlefrontII", &H54B42D, &H3F00, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox48_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox48.CheckedChanged
        If CheckBox48.Checked Then
            CheckBox11.Checked = True
        ElseIf CheckBox48.Checked = False Then
            CheckBox11.Checked = False
        End If
    End Sub
    Dim HackFour As Boolean
    Dim HackFourCave As Integer = 0
    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged
        'Float Jump
        If RadioButton1.Checked Then
            Try
                If Not HackFour Then
                    HackFourCave = Mem.Allocate
                    Mem.Jmp(&H5367F6, HackFourCave, "D8B6F0040000D8B6F0040000D886F0040000", 6)
                Else
                    If Mem.WriteBytes(&H5367F6, "D886F0040000") Then
                        Mem.DeAllocate(HackFourCave)
                    End If
                End If
                HackFour = Not HackFour
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
        If CheckBox12.Checked Then
            CheckBox5.Checked = False
            CheckBox47.Checked = True
            AboutBox4.Label13.ForeColor = Color.Red
            AboutBox4.Label28.ForeColor = Color.Red
        ElseIf CheckBox12.Checked = False Then
            CheckBox47.Checked = False
            AboutBox4.Label13.ForeColor = Color.Black
            AboutBox4.Label28.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged
        'No Tumble
        If CheckBox13.Checked Then
            CheckBox45.Checked = True
            AboutBox4.Label14.ForeColor = Color.Red
            AboutBox4.Label29.ForeColor = Color.Red
        ElseIf CheckBox13.Checked = False Then
            CheckBox45.Checked = False
            AboutBox4.Label14.ForeColor = Color.Black
            AboutBox4.Label29.ForeColor = Color.Black
        End If
        If CheckBox13.Checked And RadioButton1.Checked Then
            Try
                WriteInteger("BattlefrontII", &H54D6BD, &H9090, nsize:=2)
                WriteInteger("BattlefrontII", &H54D6C6, &H909090, nsize:=3)
                WriteInteger("BattlefrontII", &H54D66E, &H909090, nsize:=3)
                WriteInteger("BattlefrontII", &H54D6D0, &H909090, nsize:=3)
                WriteLong("BattlefrontII", &H54D6D3, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox13.Checked = False And RadioButton1.Checked Then
            Try
                WriteInteger("BattlefrontII", &H54D6BD, &H1FD9, nsize:=2)
                WriteInteger("BattlefrontII", &H54D6C6, &H45FD9, nsize:=3)
                WriteInteger("BattlefrontII", &H54D66E, &H45FD9, nsize:=3)
                WriteInteger("BattlefrontII", &H54D6D0, &H85FD9, nsize:=3)
                WriteLong("BattlefrontII", &H54D6D3, &H754AE8B, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox45_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox45.CheckedChanged
        If CheckBox45.Checked Then
            CheckBox13.Checked = True
        ElseIf CheckBox45.Checked = False Then
            CheckBox13.Checked = False
        End If
    End Sub

    Private Sub CheckBox47_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox47.CheckedChanged
        If CheckBox47.Checked Then
            CheckBox12.Checked = True
        ElseIf CheckBox47.Checked = False Then
            CheckBox12.Checked = False
        End If
    End Sub
    Dim HackFive As Boolean
    Dim HackFiveCave As Integer = 0
    Dim HackThirteen As Boolean
    Dim HackThirteenCave As Integer = 0

    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged
        'Invisibility
        If RadioButton1.Checked Then
            Try
                If Not HackFive Then
                    HackFiveCave = Mem.Allocate
                    Mem.Jmp(&H54FE64, HackFiveCave, "C78312050000909900008183120500009009000081831205000090090000818312050000900900008183120500009009000081831205000090090000818312050000900900008183120500009009000081831205000090090000818312050000900900008183120500009009000081831205000000060000888312050000", 6)
                Else
                    If Mem.WriteBytes(&H54FE64, "888312050000") Then
                        Mem.DeAllocate(HackFiveCave)
                    End If
                End If
                HackFive = Not HackFive
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
        If CheckBox14.Checked Then
            CheckBox46.Checked = True
            AboutBox4.Label15.ForeColor = Color.Red
            AboutBox4.Label30.ForeColor = Color.Red
        ElseIf CheckBox14.Checked = False Then
            CheckBox46.Checked = False
            AboutBox4.Label15.ForeColor = Color.Black
            AboutBox4.Label30.ForeColor = Color.Black
        End If
        If RadioButton2.Checked Then
            Try
                If Not HackThirteen Then
                    HackThirteenCave = Mem.Allocate
                    Mem.Jmp(&H4BED58, HackThirteenCave, "C78302050000909900008183020500009009000081830205000090090000818302050000900900008183020500009009000081830205000090090000818302050000900900008183020500009009000081830205000090090000818302050000900900008183020500009009000081830205000000060000888302050000", 6)
                Else
                    If Mem.WriteBytes(&H4BED58, "888302050000") Then
                        Mem.DeAllocate(HackThirteenCave)
                    End If
                End If
                HackThirteen = Not HackThirteen
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox15.CheckedChanged
        'Infinite Ammo
        If CheckBox15.Checked Then
            CheckBox82.Checked = True
            AboutBox4.Label107.ForeColor = Color.Red
            AboutBox4.Label119.ForeColor = Color.Red
        ElseIf CheckBox15.Checked = False Then
            CheckBox82.Checked = False
            AboutBox4.Label107.ForeColor = Color.Black
            AboutBox4.Label119.ForeColor = Color.Black
        End If
        If CheckBox15.Checked And RadioButton3.Checked Then
            Try
                WriteInteger("BattlefrontII", &H5FC38C, &H909090, nsize:=3)
                WriteInteger("BattlefrontII", &H5FC389, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox15.Checked = False And RadioButton3.Checked Then
            Try
                WriteInteger("BattlefrontII", &H5FC38C, &H1051D9, nsize:=3)
                WriteInteger("BattlefrontII", &H5FC389, &H1069D8, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox15.Checked And RadioButton4.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H55F4F6, &H909090, nsize:=3)
                WriteInteger(TextBox1.Text, &H55F4F3, &H909090, nsize:=3)
                WriteInteger(TextBox1.Text, &H53E6E9, &H909090, nsize:=3)
                WriteInteger(TextBox1.Text, &H53E6EC, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox15.Checked = False And RadioButton4.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H55F4F6, &H1051D9, nsize:=3)
                WriteInteger(TextBox1.Text, &H55F4F3, &H1069D8, nsize:=3)
                WriteInteger(TextBox1.Text, &H53E6E9, &H1069D8, nsize:=3)
                WriteInteger(TextBox1.Text, &H53E6EC, &H1051D9, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox82_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox82.CheckedChanged
        If CheckBox82.Checked Then
            CheckBox15.Checked = True
        ElseIf CheckBox82.Checked = False Then
            CheckBox15.Checked = False
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox16.CheckedChanged
        'Infinite Droideka Shield
        If CheckBox16.Checked And RadioButton3.Checked Then
            CheckBox4.Checked = True
            CheckBox81.Checked = True
            AboutBox4.Label106.ForeColor = Color.Red
            AboutBox4.Label118.ForeColor = Color.Red
        ElseIf CheckBox16.Checked = False And RadioButton3.Checked Then
            CheckBox81.Checked = False
            CheckBox4.Checked = False
            AboutBox4.Label106.ForeColor = Color.Black
            AboutBox4.Label118.ForeColor = Color.Black
        End If
        If CheckBox16.Checked And RadioButton3.Checked Then
            Try
                WriteInteger("BattlefrontII", &H4D625D, &H90909090, nsize:=4)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox16.Checked = False And RadioButton3.Checked Then
            Try
                WriteInteger("BattlefrontII", &H4D625D, &H3C245CD9, nsize:=4)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox16.Checked And RadioButton4.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H46F4F5, &H1446D8, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox16.Checked = False And RadioButton4.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H46F4F5, &H1046D8, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox16.Checked And RadioButton4.Checked Then
            CheckBox81.Checked = True
            CheckBox4.Checked = True
            AboutBox4.Label106.ForeColor = Color.Red
            AboutBox4.Label118.ForeColor = Color.Red
        ElseIf CheckBox16.Checked = False And RadioButton4.Checked Then
            CheckBox81.Checked = False
            CheckBox4.Checked = False
            AboutBox4.Label106.ForeColor = Color.Black
            AboutBox4.Label118.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CheckBox81_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox81.CheckedChanged
        If CheckBox81.Checked Then
            CheckBox16.Checked = True
        ElseIf CheckBox81.Checked = False Then
            CheckBox16.Checked = False
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox17.CheckedChanged
        'Infinite Jetpack
        If CheckBox17.Checked Then
            CheckBox80.Checked = True
            AboutBox4.Label105.ForeColor = Color.Red
            AboutBox4.Label117.ForeColor = Color.Red
        ElseIf CheckBox17.Checked = False Then
            CheckBox80.Checked = False
            AboutBox4.Label105.ForeColor = Color.Black
            AboutBox4.Label117.ForeColor = Color.Black
        End If
        If CheckBox17.Checked And RadioButton3.Checked Then
            Try
                WriteLong("BattlefrontII", &H54C2C2, &H909090909090, nsize:=6)
                WriteLong("BattlefrontII", &H550E94, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox17.Checked = False And RadioButton3.Checked Then
            Try
                WriteLong("BattlefrontII", &H54C2C2, &H8CC96D9, nsize:=6)
                WriteLong("BattlefrontII", &H550E94, &H8CC93D9, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox17.Checked And RadioButton4.Checked Then
            Try
                WriteLong(TextBox1.Text, &H4C20D2, &H909090909090, nsize:=6)
                WriteLong(TextBox1.Text, &H4BFC6D, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox17.Checked = False And RadioButton4.Checked Then
            Try
                WriteLong(TextBox1.Text, &H4C20D2, &H8B095D9, nsize:=6)
                WriteLong(TextBox1.Text, &H4BFC6D, &H8B093D9, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox80_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox80.CheckedChanged
        If CheckBox80.Checked Then
            CheckBox17.Checked = True
        ElseIf CheckBox80.Checked = False Then
            CheckBox17.Checked = False
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox18.CheckedChanged
        'Rapid Fire
        If CheckBox18.Checked Then
            CheckBox79.Checked = True
            AboutBox4.Label35.ForeColor = Color.Red
            AboutBox4.Label47.ForeColor = Color.Red
        ElseIf CheckBox18.Checked = False Then
            CheckBox79.Checked = False
            AboutBox4.Label35.ForeColor = Color.Black
            AboutBox4.Label47.ForeColor = Color.Black
        End If
        If CheckBox18.Checked And RadioButton3.Checked Then
            Try
                WriteLong("BattlefrontII", &H633406, &HB886D8, nsize:=6)
                WriteLong("BattlefrontII", &H6398D7, &HB886D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox18.Checked = False And RadioButton3.Checked Then
            Try
                WriteLong("BattlefrontII", &H633406, &HB486D8, nsize:=6)
                WriteLong("BattlefrontII", &H6398D7, &HB486D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox18.Checked And RadioButton4.Checked Then
            Try
                WriteLong(TextBox1.Text, &H55F2D6, &HB886D8, nsize:=6)
                WriteLong(TextBox1.Text, &H564EE7, &HB886D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox18.Checked = False And RadioButton4.Checked Then
            Try
                WriteLong(TextBox1.Text, &H55F2D6, &HB486D8, nsize:=6)
                WriteLong(TextBox1.Text, &H564EE7, &HB486D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox79_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox79.CheckedChanged
        If CheckBox79.Checked Then
            CheckBox18.Checked = True
        ElseIf CheckBox79.Checked = False Then
            CheckBox18.Checked = False
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox19.CheckedChanged
        'No Overheat
        If CheckBox19.Checked And RadioButton4.Checked Then
            CheckBox78.Checked = True
            AboutBox4.Label36.ForeColor = Color.Red
            AboutBox4.Label48.ForeColor = Color.Red
        ElseIf CheckBox19.Checked = False And RadioButton4.Checked Then
            CheckBox78.Checked = False
            AboutBox4.Label36.ForeColor = Color.Black
            AboutBox4.Label48.ForeColor = Color.Black
        End If
        If CheckBox19.Checked And RadioButton3.Checked Then
            CheckBox78.Checked = True
            CheckBox2.Checked = True
            AboutBox4.Label36.ForeColor = Color.Red
            AboutBox4.Label48.ForeColor = Color.Red
        ElseIf CheckBox19.Checked = False And RadioButton3.Checked Then
            CheckBox78.Checked = False
            CheckBox2.Checked = False
            AboutBox4.Label36.ForeColor = Color.Black
            AboutBox4.Label48.ForeColor = Color.Black
        End If
        If CheckBox19.Checked And RadioButton4.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H55F543, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox19.Checked = False And RadioButton4.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H55F543, &H452D9, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox78_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox78.CheckedChanged
        If CheckBox78.Checked And RadioButton4.Checked Then
            CheckBox19.Checked = True
        ElseIf CheckBox78.Checked = False And RadioButton4.Checked Then
            CheckBox19.Checked = False
        End If
        If CheckBox78.Checked And RadioButton3.Checked Then
            CheckBox19.Checked = True
        ElseIf CheckBox78.Checked = False And RadioButton4.Checked Then
            CheckBox19.Checked = False
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox20.CheckedChanged
        'Instant Charge
        If CheckBox20.Checked Then
            CheckBox77.Checked = True
            AboutBox4.Label37.ForeColor = Color.Red
            AboutBox4.Label49.ForeColor = Color.Red
        ElseIf CheckBox20.Checked = False Then
            CheckBox77.Checked = False
            AboutBox4.Label37.ForeColor = Color.Black
            AboutBox4.Label49.ForeColor = Color.Black
        End If
        If CheckBox20.Checked And RadioButton3.Checked Then
            Try
                WriteLong("BattlefrontII", &H630B54, &HB881D8, nsize:=6)
                WriteLong("BattlefrontII", &H638C34, &HB881D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox20.Checked = False And RadioButton3.Checked Then
            Try
                WriteLong("BattlefrontII", &H630B54, &HB481D8, nsize:=6)
                WriteLong("BattlefrontII", &H638C34, &HB481D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox20.Checked And RadioButton4.Checked Then
            Try
                WriteLong(TextBox1.Text, &H55F734, &HB881D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox20.Checked = False And RadioButton4.Checked Then
            Try
                WriteLong(TextBox1.Text, &H55F734, &HB481D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox77_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox77.CheckedChanged
        If CheckBox77.Checked Then
            CheckBox20.Checked = True
        ElseIf CheckBox77.Checked = False Then
            CheckBox20.Checked = False
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox21.CheckedChanged
        'Instant Fix
        If CheckBox21.Checked Then
            CheckBox76.Checked = True
            AboutBox4.Label38.ForeColor = Color.Red
            AboutBox4.Label50.ForeColor = Color.Red
        ElseIf CheckBox21.Checked = False Then
            CheckBox76.Checked = False
            AboutBox4.Label38.ForeColor = Color.Black
            AboutBox4.Label50.ForeColor = Color.Black
        End If
        If CheckBox21.Checked And RadioButton3.Checked Then
            Try
                WriteLong("BattlefrontII", &H66A5B2, &H14881D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox21.Checked = False And RadioButton3.Checked Then
            Try
                WriteLong("BattlefrontII", &H66A5B2, &H14481D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox21.Checked And RadioButton4.Checked Then
            Try
                WriteLong(TextBox1.Text, &H587002, &H14881D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox21.Checked = False And RadioButton4.Checked Then
            Try
                WriteLong(TextBox1.Text, &H587002, &H14481D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox76_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox76.CheckedChanged
        If CheckBox76.Checked Then
            CheckBox21.Checked = True
        ElseIf CheckBox76.Checked = False Then
            CheckBox21.Checked = False
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox22.CheckedChanged
        'Instant Reload
        If CheckBox22.Checked Then
            CheckBox75.Checked = True
            AboutBox4.Label39.ForeColor = Color.Red
            AboutBox4.Label51.ForeColor = Color.Red
        ElseIf CheckBox22.Checked = False Then
            CheckBox75.Checked = False
            AboutBox4.Label39.ForeColor = Color.Black
            AboutBox4.Label51.ForeColor = Color.Black
        End If
        If CheckBox22.Checked And RadioButton4.Checked Then
            Try
                WriteLong(TextBox1.Text, &H55960D, &HB881D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox22.Checked = False And RadioButton4.Checked Then
            Try
                WriteLong(TextBox1.Text, &H55960D, &HB481D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox22.Checked And RadioButton3.Checked Then
            Try
                WriteLong("BattlefrontII", &H62832D, &HB881D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox22.Checked = False And RadioButton3.Checked Then
            Try
                WriteLong("BattlefrontII", &H62832D, &HB481D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox75_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox75.CheckedChanged
        If CheckBox75.Checked Then
            CheckBox22.Checked = True
        ElseIf CheckBox75.Checked = False Then
            CheckBox22.Checked = False
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox23.CheckedChanged
        'No Spread
        If CheckBox23.Checked Then
            CheckBox74.Checked = True
            AboutBox4.Label40.ForeColor = Color.Red
            AboutBox4.Label52.ForeColor = Color.Red
        ElseIf CheckBox23.Checked = False Then
            CheckBox74.Checked = False
            AboutBox4.Label40.ForeColor = Color.Black
            AboutBox4.Label52.ForeColor = Color.Black
        End If
        If CheckBox23.Checked And RadioButton3.Checked Then
            Try
                WriteLong("BattlefrontII", &H6335F9, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox23.Checked = False And RadioButton3.Checked Then
            Try
                WriteLong("BattlefrontII", &H6335F9, &H15096D9, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox23.Checked And RadioButton4.Checked Then
            Try
                WriteLong(TextBox1.Text, &H55F5A1, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox23.Checked = False And RadioButton4.Checked Then
            Try
                WriteLong(TextBox1.Text, &H55F5A1, &H12096D9, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox74_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox74.CheckedChanged
        If CheckBox74.Checked Then
            CheckBox23.Checked = True
        ElseIf CheckBox74.Checked = False Then
            CheckBox23.Checked = False
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox24.CheckedChanged
        'Infinite Item Timer
        If CheckBox24.Checked Then
            CheckBox73.Checked = True
            AboutBox4.Label41.ForeColor = Color.Red
            AboutBox4.Label53.ForeColor = Color.Red
        ElseIf CheckBox24.Checked = False Then
            CheckBox73.Checked = False
            AboutBox4.Label41.ForeColor = Color.Black
            AboutBox4.Label53.ForeColor = Color.Black
        End If
        If CheckBox24.Checked And RadioButton3.Checked Then
            Try
                WriteInteger("BattlefrontII", &H520982, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox24.Checked = False And RadioButton3.Checked Then
            Try
                WriteInteger("BattlefrontII", &H520982, &H2C57D9, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox24.Checked And RadioButton4.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H4A7CED, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox24.Checked = False And RadioButton4.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H4A7CED, &H2C57D9, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox73_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox73.CheckedChanged
        If CheckBox73.Checked Then
            CheckBox24.Checked = True
        ElseIf CheckBox73.Checked = False Then
            CheckBox24.Checked = False
        End If
    End Sub

    Private Sub CheckBox46_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox46.CheckedChanged
        If CheckBox46.Checked Then
            CheckBox14.Checked = True
        ElseIf CheckBox46.Checked = False Then
            CheckBox14.Checked = False
        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox25.CheckedChanged
        'Disable Death Barriers and Boundaries
        If CheckBox25.Checked Then
            CheckBox72.Checked = True
            AboutBox4.Label56.ForeColor = Color.Red
            AboutBox4.Label81.ForeColor = Color.Red
        ElseIf CheckBox25.Checked = False Then
            CheckBox72.Checked = False
            AboutBox4.Label56.ForeColor = Color.Black
            AboutBox4.Label81.ForeColor = Color.Black
        End If
        If CheckBox25.Checked And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H4D51CF, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox25.Checked = False And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H4D51CF, &H447D9, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox25.Checked And RadioButton6.Checked Then
            Try
                WriteLong(TextBox1.Text, &H46F666, &H90909090909090, nsize:=7)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox25.Checked = False And RadioButton6.Checked Then
            Try
                WriteLong(TextBox1.Text, &H46F666, &H447C7, nsize:=7)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox72_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox72.CheckedChanged
        If CheckBox72.Checked Then
            CheckBox25.Checked = True
        ElseIf CheckBox72.Checked = False Then
            CheckBox25.Checked = False
        End If
    End Sub

    Private Sub CheckBox26_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox26.CheckedChanged
        'No Clip
        If CheckBox26.Checked Then
            CheckBox27.Checked = False
            CheckBox71.Checked = True
            AboutBox4.Label57.ForeColor = Color.Red
            AboutBox4.Label72.ForeColor = Color.Red
        ElseIf CheckBox26.Checked = False Then
            CheckBox71.Checked = False
            AboutBox4.Label57.ForeColor = Color.Black
            AboutBox4.Label72.ForeColor = Color.Black
        End If
        If CheckBox26.Checked And RadioButton6.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H4040C8, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox26.Checked = False And RadioButton6.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H4040C8, &H440D9, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox26.Checked And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H42C907, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox26.Checked = False And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H42C907, &H440D9, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox71_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox71.CheckedChanged
        If CheckBox71.Checked Then
            CheckBox26.Checked = True
        ElseIf CheckBox71.Checked = False Then
            CheckBox26.Checked = False
        End If
    End Sub

    Private Sub CheckBox27_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox27.CheckedChanged
        'Fall Through Current Object
        If CheckBox27.Checked Then
            CheckBox26.Checked = False
            CheckBox70.Checked = True
            AboutBox4.Label58.ForeColor = Color.Red
            AboutBox4.Label73.ForeColor = Color.Red
        ElseIf CheckBox27.Checked = False Then
            CheckBox70.Checked = False
            AboutBox4.Label58.ForeColor = Color.Black
            AboutBox4.Label73.ForeColor = Color.Black
        End If
        If CheckBox27.Checked And RadioButton6.Checked Then
            Try
                WriteLong(TextBox1.Text, &H4BA92B, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox27.Checked = False And RadioButton6.Checked Then
            Try
                WriteLong(TextBox1.Text, &H4BA92B, &H11883D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox27.Checked And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H42D480, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox27.Checked = False And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H42D480, &H7441D8, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox70_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox70.CheckedChanged
        If CheckBox70.Checked Then
            CheckBox27.Checked = True
        ElseIf CheckBox70.Checked = False Then
            CheckBox27.Checked = False
        End If
    End Sub
    Dim address As String

    Private Sub CheckBox28_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox28.CheckedChanged
        'Kill Everybody
        If CheckBox28.Checked Then
            CheckBox69.Checked = True
            AboutBox4.Label59.ForeColor = Color.Red
            AboutBox4.Label74.ForeColor = Color.Red
        ElseIf CheckBox28.Checked = False Then
            CheckBox69.Checked = False
            AboutBox4.Label59.ForeColor = Color.Black
            AboutBox4.Label74.ForeColor = Color.Black
        End If
        If CheckBox28.Checked And RadioButton5.Checked Then
            Try
                WriteLong("BattlefrontII", &H42C91E, &HD024848B, nsize:=7)
                WriteLong("BattlefrontII", &H42C937, &HD824948B, nsize:=7)
                WriteLong("BattlefrontII", &H6509A8, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox28.Checked = False And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H42C91E, &H8B, nsize:=1)
                WriteInteger("BattlefrontII", &H42C91F, &HD02484, nsize:=3)
                WriteInteger("BattlefrontII", &H42C922, &H0, nsize:=2)
                WriteInteger("BattlefrontII", &H42C924, &HD800, nsize:=2)
                WriteInteger("BattlefrontII", &H42C937, &H8B, nsize:=1)
                WriteInteger("BattlefrontII", &H42C938, &H94, nsize:=1)
                WriteInteger("BattlefrontII", &H42C939, &HD824, nsize:=2)
                WriteInteger("BattlefrontII", &H42C93B, &H0, nsize:=2)
                WriteInteger("BattlefrontII", &H42C93D, &HD900, nsize:=2)
                WriteLong("BattlefrontII", &H6509A8, &H18485D9, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox28.Checked And RadioButton6.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H4C2CA0, &H90909090, nsize:=4)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox28.Checked = False And RadioButton6.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H4C2CA0, &H1824448B, nsize:=4)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox69_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox69.CheckedChanged
        If CheckBox69.Checked Then
            CheckBox28.Checked = True
        ElseIf CheckBox69.Checked = False Then
            CheckBox28.Checked = False
        End If
    End Sub

    Private Sub CheckBox29_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox29.CheckedChanged
        'Freeze Mission Timer
        If CheckBox29.Checked Then
            CheckBox68.Checked = True
            AboutBox4.Label60.ForeColor = Color.Red
            AboutBox4.Label75.ForeColor = Color.Red
        ElseIf CheckBox29.Checked = False Then
            CheckBox68.Checked = False
            AboutBox4.Label60.ForeColor = Color.Black
            AboutBox4.Label75.ForeColor = Color.Black
        End If
        If CheckBox29.Checked And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H6715CD, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox29.Checked = False And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H6715CD, &H2456D9, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox29.Checked And RadioButton6.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H58BA8D, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox29.Checked = False And RadioButton6.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H58BA8D, &H2456D9, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox68_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox68.CheckedChanged
        If CheckBox68.Checked Then
            CheckBox29.Checked = True
        ElseIf CheckBox68.Checked = False Then
            CheckBox29.Checked = False
        End If
    End Sub

    Private Sub CheckBox30_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox30.CheckedChanged
        'Instant Win
        If CheckBox30.Checked Then
            CheckBox67.Checked = True
            AboutBox4.Label61.ForeColor = Color.Red
            AboutBox4.Label76.ForeColor = Color.Red
        ElseIf CheckBox30.Checked = False Then
            CheckBox67.Checked = False
            AboutBox4.Label61.ForeColor = Color.Black
            AboutBox4.Label76.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CheckBox67_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox67.CheckedChanged
        If CheckBox67.Checked Then
            CheckBox30.Checked = True
        ElseIf CheckBox67.Checked = False Then
            CheckBox30.Checked = False
        End If
    End Sub
    Dim HackSix As Boolean
    Dim HackSixCave As Integer = 0
    Dim HackEleven As Boolean
    Dim HackElevenCave As Integer = 0
    Private Sub CheckBox31_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox31.CheckedChanged
        'Extreme Points
        If RadioButton5.Checked Then
            Try
                If Not HackSix Then
                    HackSixCave = Mem.Allocate
                    Mem.Jmp(&H662516, HackSixCave, "8187F001000000020000660187F0010000", 7)
                Else
                    If Mem.WriteBytes(&H662516, "660187F0010000") Then
                        Mem.DeAllocate(HackSixCave)
                    End If
                End If
                HackSix = Not HackSix
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
        If CheckBox31.Checked Then
            CheckBox66.Checked = True
            AboutBox4.Label62.ForeColor = Color.Red
            AboutBox4.Label77.ForeColor = Color.Red
        ElseIf CheckBox31.Checked = False Then
            CheckBox66.Checked = False
            AboutBox4.Label62.ForeColor = Color.Black
            AboutBox4.Label77.ForeColor = Color.Black
        End If
        If RadioButton6.Checked Then
            Try
                If Not HackEleven Then
                    HackElevenCave = Mem.Allocate
                    Mem.Jmp(&H580F5D, HackElevenCave, "8183F00100000002000066018BF0010000", 7)
                Else
                    If Mem.WriteBytes(&H580F5D, "66018BF0010000") Then
                        Mem.DeAllocate(HackElevenCave)
                    End If
                End If
                HackEleven = Not HackEleven
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox66_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox66.CheckedChanged
        If CheckBox66.Checked Then
            CheckBox31.Checked = True
        ElseIf CheckBox66.Checked = False Then
            CheckBox31.Checked = False
        End If
    End Sub

    Private Sub CheckBox65_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox65.CheckedChanged
        If CheckBox65.Checked Then
            CheckBox32.Checked = True
        ElseIf CheckBox65.Checked = False Then
            CheckBox32.Checked = False
        End If
    End Sub
    Private Sub CheckBox34_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox34.CheckedChanged
        'Land Anywhere
        If CheckBox34.Checked Then
            CheckBox63.Checked = True
            AboutBox4.Label65.ForeColor = Color.Red
            AboutBox4.Label80.ForeColor = Color.Red
        ElseIf CheckBox34.Checked = False Then
            CheckBox63.Checked = False
            AboutBox4.Label65.ForeColor = Color.Black
            AboutBox4.Label80.ForeColor = Color.Black
        End If
        If CheckBox34.Checked And RadioButton6.Checked Then
            Try
                WriteLong(TextBox1.Text, &H48C9A8, &H9090909090909090, nsize:=8)
                WriteInteger(TextBox1.Text, &H48C9B0, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox34.Checked = False And RadioButton6.Checked Then
            Try
                WriteLong(TextBox1.Text, &H48C9A8, &H20000032483C7, nsize:=8)
                WriteInteger(TextBox1.Text, &H48C9B0, &H0, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox34.Checked And RadioButton5.Checked Then
            Try
                WriteLong("BattlefrontII", &H505EF4, &H9090909090909090, nsize:=8)
                WriteInteger("BattlefrontII", &H505EFC, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox34.Checked = False And RadioButton5.Checked Then
            Try
                WriteLong("BattlefrontII", &H505EF4, &H20000036483C7, nsize:=8)
                WriteInteger("BattlefrontII", &H505EFC, &H0, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox63_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox63.CheckedChanged
        If CheckBox63.Checked Then
            CheckBox34.Checked = True
        ElseIf CheckBox63.Checked = False Then
            CheckBox34.Checked = False
        End If
    End Sub

    Private Sub CheckBox35_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox35.CheckedChanged
        'Instant Awards
        If CheckBox35.Checked Then
            CheckBox62.Checked = True
            AboutBox4.Label66.ForeColor = Color.Red
            AboutBox4.Label82.ForeColor = Color.Red
        ElseIf CheckBox35.Checked = False Then
            CheckBox62.Checked = False
            AboutBox4.Label66.ForeColor = Color.Black
            AboutBox4.Label82.ForeColor = Color.Black
        End If
        If CheckBox35.Checked And RadioButton5.Checked Then
            Try
                WriteLong("BattlefrontII", &H661474, &H3016774483, nsize:=5)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox35.Checked = False And RadioButton5.Checked Then
            Try
                WriteLong("BattlefrontII", &H661474, &H16776C0166, nsize:=5)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox35.Checked And RadioButton6.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H581030, &H240683, nsize:=3)
                WriteLong(TextBox1.Text, &H57FE86, &H2016774483, nsize:=5)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox35.Checked = False And RadioButton6.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H581030, &HE0166, nsize:=3)
                WriteLong(TextBox1.Text, &H57FE86, &H16776C0166, nsize:=5)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox62_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox62.CheckedChanged
        If CheckBox62.Checked Then
            CheckBox35.Checked = True
        ElseIf CheckBox62.Checked = False Then
            CheckBox35.Checked = False
        End If
    End Sub

    Private Sub CheckBox36_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox36.CheckedChanged
        'Deny CP Capture
        If CheckBox36.Checked Then
            CheckBox37.Checked = False
            CheckBox38.Checked = False
            CheckBox61.Checked = True
            AboutBox4.Label67.ForeColor = Color.Red
            AboutBox4.Label83.ForeColor = Color.Red
        ElseIf CheckBox36.Checked = False Then
            CheckBox61.Checked = False
            AboutBox4.Label67.ForeColor = Color.Black
            AboutBox4.Label83.ForeColor = Color.Black
        End If
        If CheckBox36.Checked And RadioButton5.Checked Then
            Try
                WriteLong("BattlefrontII", &H65BD03, &H909090909090, nsize:=6)
                WriteLong("BattlefrontII", &H65B5E5, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox36.Checked = False And RadioButton5.Checked Then
            Try
                WriteLong("BattlefrontII", &H65BD03, &HA086D8, nsize:=6)
                WriteLong("BattlefrontII", &H65B5E5, &HA486D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox36.Checked And RadioButton6.Checked Then
            Try
                WriteLong(TextBox1.Text, &H57B718, &H909090909090, nsize:=6)
                WriteLong(TextBox1.Text, &H57B072, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox36.Checked = False And RadioButton6.Checked Then
            Try
                WriteLong(TextBox1.Text, &H57B718, &HA085D8, nsize:=6)
                WriteLong(TextBox1.Text, &H57B072, &HA485D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox61_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox61.CheckedChanged
        If CheckBox61.Checked Then
            CheckBox36.Checked = True
        ElseIf CheckBox61.Checked = False Then
            CheckBox36.Checked = False
        End If
    End Sub

    Private Sub CheckBox37_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox37.CheckedChanged
        'Capture Only Neutral CP's
        If CheckBox37.Checked Then
            CheckBox36.Checked = False
            CheckBox38.Checked = False
            CheckBox59.Checked = True
            AboutBox4.Label68.ForeColor = Color.Red
            AboutBox4.Label84.ForeColor = Color.Red
        ElseIf CheckBox37.Checked = False Then
            CheckBox59.Checked = False
            AboutBox4.Label68.ForeColor = Color.Black
            AboutBox4.Label84.ForeColor = Color.Black
        End If
        If CheckBox37.Checked And RadioButton5.Checked Then
            Try
                WriteLong("BattlefrontII", &H65BD03, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox37.Checked = False And RadioButton5.Checked Then
            Try
                WriteLong("BattlefrontII", &H65BD03, &HA086D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox37.Checked And RadioButton6.Checked Then
            Try
                WriteLong(TextBox1.Text, &H57B718, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox37.Checked = False And RadioButton6.Checked Then
            Try
                WriteLong(TextBox1.Text, &H57B718, &HA085D8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox59_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox59.CheckedChanged
        If CheckBox59.Checked Then
            CheckBox37.Checked = True
        ElseIf CheckBox59.Checked = False Then
            CheckBox37.Checked = False
        End If
    End Sub
    Dim HackSeven As Boolean
    Dim HackSevenCave As Integer = 0
    Dim HackEight As Boolean
    Dim HackEightCave As Integer = 0
    Dim HackFourteen As Boolean
    Dim HackFourteenCave As Integer = 0
    Dim HackFifteen As Boolean
    Dim HackFifteenCave As Integer = 0

    Private Sub CheckBox38_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox38.CheckedChanged
        'Instant CP Capture
        If CheckBox38.Checked Then
            CheckBox37.Checked = False
            CheckBox36.Checked = False
            CheckBox60.Checked = True
            AboutBox4.Label69.ForeColor = Color.Red
            AboutBox4.Label85.ForeColor = Color.Red
        ElseIf CheckBox38.Checked = False Then
            CheckBox60.Checked = False
            AboutBox4.Label69.ForeColor = Color.Black
            AboutBox4.Label85.ForeColor = Color.Black
        End If
        If RadioButton5.Checked Then
            Try
                If Not HackSeven Then
                    HackSevenCave = Mem.Allocate
                    Mem.Jmp(&H65B5E5, HackSevenCave, "D886A4000000D886A4000000D886A4000000D886A4000000D886A4000000D886A4000000D886A4000000D886A4000000", 6)
                Else
                    If Mem.WriteBytes(&H65B5E5, "D886A4000000") Then
                        Mem.DeAllocate(HackSevenCave)
                    End If
                End If
                HackSeven = Not HackSeven
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
        If RadioButton5.Checked Then
            Try
                If Not HackEight Then
                    HackEightCave = Mem.Allocate
                    Mem.Jmp(&H65BD03, HackEightCave, "D886A0000000D886A0000000D886A0000000D886A0000000D886A0000000D886A0000000D886A0000000D886A0000000", 6)
                Else
                    If Mem.WriteBytes(&H65BD03, "D886A0000000") Then
                        Mem.DeAllocate(HackEightCave)
                    End If
                End If
                HackEight = Not HackEight
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
        If RadioButton6.Checked Then
            Try
                If Not HackFourteen Then
                    HackFourteenCave = Mem.Allocate
                    Mem.Jmp(&H57B718, HackFourteenCave, "D885A0000000D885A0000000D885A0000000D885A0000000", 6)
                Else
                    If Mem.WriteBytes(&H57B718, "D885A0000000") Then
                        Mem.DeAllocate(HackFourteenCave)
                    End If
                End If
                HackFourteen = Not HackFourteen
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
        If RadioButton6.Checked Then
            Try
                If Not HackFifteen Then
                    HackFifteenCave = Mem.Allocate
                    Mem.Jmp(&H57B072, HackFifteenCave, "D885A4000000D885A4000000D885A4000000D885A4000000", 6)
                Else
                    If Mem.WriteBytes(&H57B072, "D885A4000000") Then
                        Mem.DeAllocate(HackFifteenCave)
                    End If
                End If
                HackFifteen = Not HackFifteen
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox60_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox60.CheckedChanged
        If CheckBox60.Checked Then
            CheckBox38.Checked = True
        ElseIf CheckBox60.Checked = False Then
            CheckBox38.Checked = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Hotkeys
        AboutBox4.Show()
    End Sub

    Private Sub CheckBox83_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox83.CheckedChanged
        'Walk Through Walls
        If CheckBox83.Checked Then
            CheckBox84.Checked = True
            AboutBox4.Label63.ForeColor = Color.Red
            AboutBox4.Label78.ForeColor = Color.Red
        ElseIf CheckBox83.Checked = False Then
            CheckBox84.Checked = False
            AboutBox4.Label63.ForeColor = Color.Black
            AboutBox4.Label78.ForeColor = Color.Black
        End If
        If CheckBox83.Checked And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H427BA6, &H909090, nsize:=3)
                WriteInteger("BattlefrontII", &H427B98, &H909090, nsize:=3)
                WriteInteger("BattlefrontII", &H427B8D, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox83.Checked = False And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H427BA6, &H861D8, nsize:=3)
                WriteInteger("BattlefrontII", &H427B98, &H461D8, nsize:=3)
                WriteInteger("BattlefrontII", &H427B8D, &H21D8, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox83.Checked And RadioButton6.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H401018, &H909090, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox83.Checked = False And RadioButton6.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H401018, &H461D8, nsize:=3)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox84_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox84.CheckedChanged
        If CheckBox84.Checked Then
            CheckBox83.Checked = True
        ElseIf CheckBox84.Checked = False Then
            CheckBox83.Checked = False
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("This hack was made by {VA}Jake and is NOT supported for v1.0 of swbf2. Some hacks have been disabled for now but will return in future updates. Be sure to check the change log as each update comes out to stay fully informed on what is new and what has changed. If you plan on running a pc dedicated server, you must have Bryants v1.4 patch installed.")
        AboutBox12.Show()
        AboutBox12.Visible = False
        TextBox1.Text = "BattlefrontII"
    End Sub

    Private Sub CheckBox85_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox85.CheckedChanged
        'Unlimited Flag Capture
        If CheckBox85.Checked = True And RadioButton5.Checked Then
            CheckBox86.Checked = True
            AboutBox4.Label70.ForeColor = Color.Red
            AboutBox4.Label86.ForeColor = Color.Red
        ElseIf CheckBox85.Checked = False And RadioButton5.Checked Then
            CheckBox86.Checked = False
            AboutBox4.Label70.ForeColor = Color.Black
            AboutBox4.Label86.ForeColor = Color.Black
        End If
        If CheckBox85.Checked And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H670876, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox85.Checked = False And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H670876, &HD103, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox85.Checked And RadioButton6.Checked Then
            CheckBox87.Checked = True
        ElseIf CheckBox85.Checked = False And RadioButton6.Checked Then
            CheckBox87.Checked = False
        End If
    End Sub

    Private Sub CheckBox86_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox86.CheckedChanged
        If CheckBox86.Checked Then
            CheckBox85.Checked = True
        ElseIf CheckBox86.Checked = False Then
            CheckBox85.Checked = False
        End If
    End Sub
    Dim HackOne As Boolean
    Dim HackOneCave As Integer = 0
    Dim HackTen As Boolean
    Dim HackTenCave As Integer = 0

    Private Sub CheckBox32_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox32.CheckedChanged
        'One Hit Kill
        If RadioButton3.Checked Then
            Try
                If Not HackOne Then
                    HackOneCave = Mem.Allocate
                    Mem.Jmp(&H4D636C, HackOneCave, AboutBox12.RichTextBox3.Text, 8)
                Else
                    If Mem.WriteBytes(&H4D636C, "D84C2418D954243C") Then
                        Mem.DeAllocate(HackOneCave)
                    End If
                End If
                HackOne = Not HackOne
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
        If CheckBox32.Checked Then
            CheckBox65.Checked = True
            AboutBox4.Label42.ForeColor = Color.Red
            AboutBox4.Label54.ForeColor = Color.Red
        ElseIf CheckBox32.Checked = False Then
            CheckBox65.Checked = False
            AboutBox4.Label42.ForeColor = Color.Black
            AboutBox4.Label54.ForeColor = Color.Black
        End If
        If RadioButton4.Checked Then
            Try
                If Not HackTen Then
                    HackTenCave = Mem.Allocate
                    Mem.Jmp(&H46FBED, HackTenCave, "D84C2418D84C2418D9542418", 8)
                Else
                    If Mem.WriteBytes(&H46FBED, "D84C2418D9542418") Then
                        Mem.DeAllocate(HackTenCave)
                    End If
                End If
                HackTen = Not HackTen
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox87_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox87.CheckedChanged
        'Infinite Reinforcements
        If CheckBox87.Checked Then
            CheckBox88.Checked = True
            AboutBox4.Label71.ForeColor = Color.Red
            AboutBox4.Label87.ForeColor = Color.Red
        ElseIf CheckBox87.Checked = False Then
            CheckBox88.Checked = False
            AboutBox4.Label71.ForeColor = Color.Black
            AboutBox4.Label87.ForeColor = Color.Black
        End If
        If CheckBox87.Checked And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H670328, &H9090, nsize:=2)
                WriteInteger("BattlefrontII", &H670878, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox87.Checked = False And RadioButton5.Checked Then
            Try
                WriteInteger("BattlefrontII", &H670328, &H1089, nsize:=2)
                WriteInteger("BattlefrontII", &H670878, &H1089, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox87.Checked And RadioButton6.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H58AA78, &H9090, nsize:=2)
                WriteInteger(TextBox1.Text, &H58AE98, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox87.Checked = False And RadioButton6.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H58AA78, &H1889, nsize:=2)
                WriteInteger(TextBox1.Text, &H58AE98, &H1889, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox87.Checked And RadioButton6.Checked Then
            CheckBox85.Checked = True
        ElseIf CheckBox87.Checked = False And RadioButton6.Checked Then
            CheckBox85.Checked = False
        End If
    End Sub

    Private Sub CheckBox88_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox88.CheckedChanged
        If CheckBox88.Checked Then
            CheckBox87.Checked = True
        ElseIf CheckBox88.Checked = False Then
            CheckBox87.Checked = False
        End If
    End Sub

    Private Sub CheckBox89_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox89.CheckedChanged
        'Plant More Items
        If CheckBox89.Checked Then
            CheckBox90.Checked = True
            AboutBox4.Label43.ForeColor = Color.Red
            AboutBox4.Label55.ForeColor = Color.Red
        ElseIf CheckBox89.Checked = False Then
            CheckBox90.Checked = False
            AboutBox4.Label43.ForeColor = Color.Black
            AboutBox4.Label55.ForeColor = Color.Black
        End If
        If CheckBox89.Checked And RadioButton3.Checked Then
            Try
                WriteInteger("BattlefrontII", &H63818B, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox89.Checked = False And RadioButton3.Checked Then
            Try
                WriteInteger("BattlefrontII", &H63818B, &H889, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox89.Checked And RadioButton4.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H56448C, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox89.Checked = False And RadioButton4.Checked Then
            Try
                WriteInteger(TextBox1.Text, &H56448C, &H889, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox90_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox90.CheckedChanged
        If CheckBox90.Checked Then
            CheckBox89.Checked = True
        ElseIf CheckBox90.Checked = False Then
            CheckBox89.Checked = False
        End If
    End Sub
    Dim dedi As Integer = 2
    Dim pc As Integer = 3
    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        'PC Dedicated Player Hacks
        If RadioButton1.Checked = True Then
            RadioButton3.Checked = True
            RadioButton5.Checked = True
            CheckBox11.Enabled = True
            CheckBox12.Enabled = True
            CheckBox13.Enabled = True
            'CheckBox40.Checked = True
            'CheckBox42.Checked = True
            'CheckBox44.Checked = True
            CheckBox45.Enabled = True
            CheckBox47.Enabled = True
            CheckBox48.Enabled = True
            CheckBox105.Enabled = True
            CheckBox106.Enabled = True
        ElseIf RadioButton1.Checked = False Then
            RadioButton3.Checked = False
            RadioButton5.Checked = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        'PC Dedicated Weapon Hacks
        If RadioButton3.Checked Then
            RadioButton1.Checked = True
            RadioButton5.Checked = True
        ElseIf RadioButton3.Checked = False Then
            RadioButton1.Checked = False
            RadioButton5.Checked = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        'PC Dedicated Map Hacks
        If RadioButton5.Checked Then
            RadioButton3.Checked = True
            RadioButton1.Checked = True
        ElseIf RadioButton5.Checked = False Then
            RadioButton3.Checked = False
            RadioButton1.Checked = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        'PC/Single Player Player Hacks
        If RadioButton2.Checked = True Then
            RadioButton4.Checked = True
            RadioButton6.Checked = True
            'CheckBox40.Checked = True
            'CheckBox42.Checked = True
            'CheckBox44.Checked = True
            CheckBox11.Enabled = False
            CheckBox12.Enabled = False
            CheckBox13.Enabled = False
            CheckBox45.Enabled = False
            CheckBox47.Enabled = False
            CheckBox48.Enabled = False
            CheckBox105.Enabled = False
            CheckBox106.Enabled = False
        ElseIf RadioButton2.Checked = False Then
            RadioButton4.Checked = False
            RadioButton6.Checked = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        'PC/Single Player Weapon Hacks
        If RadioButton4.Checked Then
            RadioButton2.Checked = True
            RadioButton6.Checked = True
        ElseIf RadioButton4.Checked = False Then
            RadioButton2.Checked = False
            RadioButton6.Checked = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        'PC/Single Player Map Hacks
        If RadioButton6.Checked Then
            RadioButton4.Checked = True
            RadioButton2.Checked = True
        ElseIf RadioButton6.Checked = False Then
            RadioButton4.Checked = False
            RadioButton2.Checked = False
        End If
    End Sub

    Private Sub CheckBox91_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox91.CheckedChanged
        'Instant Respawn
        If CheckBox91.Checked Then
            CheckBox92.Checked = True
            AboutBox4.Label64.ForeColor = Color.Red
            AboutBox4.Label79.ForeColor = Color.Red
        ElseIf CheckBox91.Checked = False Then
            CheckBox92.Checked = False
            AboutBox4.Label64.ForeColor = Color.Black
            AboutBox4.Label79.ForeColor = Color.Black
        End If
        If CheckBox91.Checked And RadioButton5.Checked Then
            Try
                WriteLong("BattlefrontII", &H46EA50, &H3F0000002404C7, nsize:=7)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox91.Checked = False And RadioButton5.Checked Then
            Try
                WriteLong("BattlefrontII", &H46EA50, &H417000002404C7, nsize:=7)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox91.Checked And RadioButton6.Checked Then
            Try
                WriteLong(TextBox1.Text, &H42F61A, &H7DBDE805D9, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox91.Checked = False And RadioButton6.Checked Then
            Try
                WriteLong(TextBox1.Text, &H42F61A, &H7DBDF405D9, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox92_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox92.CheckedChanged
        If CheckBox92.Checked Then
            CheckBox91.Checked = True
        ElseIf CheckBox92.Checked = False Then
            CheckBox91.Checked = False
        End If
    End Sub

    Private Sub CheckBox33_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox33.CheckedChanged
        'Fly
        If CheckBox33.Checked Then
            CheckBox8.Checked = False
            CheckBox64.Checked = True
            AboutBox4.Label16.ForeColor = Color.Red
            AboutBox4.Label31.ForeColor = Color.Red
        ElseIf CheckBox33.Checked = False Then
            CheckBox64.Checked = False
            AboutBox4.Label16.ForeColor = Color.Black
            AboutBox4.Label31.ForeColor = Color.Black
        End If
        If CheckBox33.Checked And RadioButton1.Checked Then
            Try
                WriteLong("BattlefrontII", &H5523D1, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox33.Checked = False And RadioButton1.Checked Then
            Try
                WriteLong("BattlefrontII", &H5523D1, &H7A48388, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox33.Checked And RadioButton2.Checked Then
            Try
                WriteLong(TextBox1.Text, &H4C1058, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox33.Checked = False And RadioButton2.Checked Then
            Try
                WriteLong(TextBox1.Text, &H4C1058, &H7948388, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox64_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox64.CheckedChanged
        If CheckBox64.Checked Then
            CheckBox33.Checked = True
        ElseIf CheckBox64.Checked = False Then
            CheckBox33.Checked = False
        End If
    End Sub
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function
    Dim LeftShift As Boolean
    Dim LeftControl As Boolean
    Dim RightShift As Boolean
    Dim NumRowZero As Boolean
    Dim NumRowOne As Boolean
    Dim NumRowTwo As Boolean
    Dim NumRowThree As Boolean
    Dim NumRowFour As Boolean
    Dim NumRowFive As Boolean
    Dim NumRowSix As Boolean
    Dim NumRowSeven As Boolean
    Dim NumRowEight As Boolean
    Dim NumRowNine As Boolean
    Dim F1 As Boolean
    Dim F2 As Boolean
    Dim F3 As Boolean
    Dim F4 As Boolean
    Dim F5 As Boolean
    Dim F6 As Boolean
    Dim F7 As Boolean
    Dim F8 As Boolean
    Dim F9 As Boolean
    Dim F10 As Boolean
    Dim F11 As Boolean
    Dim F12 As Boolean

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Mem.GetProcess("BattlefrontII")
        LeftShift = GetAsyncKeyState(Keys.LShiftKey)
        LeftControl = GetAsyncKeyState(Keys.LControlKey)
        RightShift = GetAsyncKeyState(Keys.RShiftKey)
        NumRowZero = GetAsyncKeyState(Keys.D0)
        NumRowOne = GetAsyncKeyState(Keys.D1)
        NumRowTwo = GetAsyncKeyState(Keys.D2)
        NumRowThree = GetAsyncKeyState(Keys.D3)
        NumRowFour = GetAsyncKeyState(Keys.D4)
        NumRowFive = GetAsyncKeyState(Keys.D5)
        NumRowSix = GetAsyncKeyState(Keys.D6)
        NumRowSeven = GetAsyncKeyState(Keys.D7)
        NumRowEight = GetAsyncKeyState(Keys.D8)
        NumRowNine = GetAsyncKeyState(Keys.D9)
        F1 = GetAsyncKeyState(Keys.F1)
        F2 = GetAsyncKeyState(Keys.F2)
        F3 = GetAsyncKeyState(Keys.F3)
        F4 = GetAsyncKeyState(Keys.F4)
        F5 = GetAsyncKeyState(Keys.F5)
        F6 = GetAsyncKeyState(Keys.F6)
        F7 = GetAsyncKeyState(Keys.F7)
        F8 = GetAsyncKeyState(Keys.F8)
        F9 = GetAsyncKeyState(Keys.F9)
        F10 = GetAsyncKeyState(Keys.F10)
        F11 = GetAsyncKeyState(Keys.F11)
        F12 = GetAsyncKeyState(Keys.F12)
        If Panel1.Enabled = True And Panel2.Enabled = True And Panel3.Enabled = True And Panel4.Enabled = True And Panel5.Enabled = True And Panel6.Enabled = True And Panel8.Enabled = True And Panel9.Enabled = True And Panel10.Enabled = True Then
            Try
                If NumRowZero = True And LeftShift = True And CheckBox1.Checked = False Then
                    CheckBox1.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowZero = True And LeftShift = True And CheckBox1.Checked = True Then
                    CheckBox1.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowOne = True And LeftShift = True And CheckBox2.Checked = False Then
                    CheckBox2.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowOne = True And LeftShift = True And CheckBox2.Checked = True Then
                    CheckBox2.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If LeftShift = True And NumRowTwo = True And CheckBox3.Checked = False Then
                    CheckBox3.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf LeftShift = True And NumRowTwo = True And CheckBox3.Checked = True Then
                    CheckBox3.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowThree = True And LeftShift = True And CheckBox4.Checked = False Then
                    CheckBox4.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowThree = True And LeftShift = True And CheckBox4.Checked = True Then
                    CheckBox4.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowFour = True And LeftShift = True And CheckBox5.Checked = False Then
                    CheckBox5.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowFour = True And LeftShift = True And CheckBox5.Checked = True Then
                    CheckBox5.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowFive = True And LeftShift = True And CheckBox6.Checked = False Then
                    CheckBox6.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowFive = True And LeftShift = True And CheckBox6.Checked = True Then
                    CheckBox6.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowSix = True And LeftShift = True And CheckBox7.Checked = False Then
                    CheckBox7.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowSix = True And LeftShift = True And CheckBox7.Checked = True Then
                    CheckBox7.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowSeven = True And LeftShift = True And CheckBox8.Checked = False Then
                    CheckBox8.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowSeven = True And LeftShift = True And CheckBox8.Checked = True Then
                    CheckBox8.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowEight = True And LeftShift = True And CheckBox9.Checked = False Then
                    CheckBox9.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowEight = True And LeftShift = True And CheckBox9.Checked = True Then
                    CheckBox9.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowNine = True And LeftShift = True And CheckBox10.Checked = False Then
                    CheckBox10.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowNine = True And LeftShift = True And CheckBox10.Checked = True Then
                    CheckBox10.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F1 = True And LeftShift = True And RadioButton1.Checked = True And CheckBox11.Checked = False Then
                    CheckBox11.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F1 = True And LeftShift = True And RadioButton1.Checked = True And CheckBox11.Checked = True Then
                    CheckBox11.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F2 = True And LeftShift = True And RadioButton1.Checked = True And CheckBox12.Checked = False Then
                    CheckBox12.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F2 = True And LeftShift = True And RadioButton1.Checked = True And CheckBox12.Checked = True Then
                    CheckBox12.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F3 = True And LeftShift = True And RadioButton1.Checked = True And CheckBox13.Checked = False Then
                    CheckBox13.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F3 = True And LeftShift = True And RadioButton1.Checked = True And CheckBox13.Checked = True Then
                    CheckBox13.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F4 = True And LeftShift = True And CheckBox14.Checked = False Then
                    CheckBox14.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F4 = True And LeftShift = True And CheckBox14.Checked = True Then
                    CheckBox14.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F5 = True And LeftShift = True And CheckBox33.Checked = False Then
                    CheckBox33.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F5 = True And LeftShift = True And CheckBox33.Checked = True Then
                    CheckBox33.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowZero = True And LeftControl = True And CheckBox15.Checked = False Then
                    CheckBox15.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowZero = True And LeftControl = True And CheckBox15.Checked = True Then
                    CheckBox15.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowOne = True And LeftControl = True And CheckBox16.Checked = False Then
                    CheckBox16.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowOne = True And LeftControl = True And CheckBox16.Checked = True Then
                    CheckBox16.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowTwo = True And LeftControl = True And CheckBox17.Checked = False Then
                    CheckBox17.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowTwo = True And LeftControl = True And CheckBox17.Checked = True Then
                    CheckBox17.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowThree = True And LeftControl = True And CheckBox18.Checked = False Then
                    CheckBox18.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowThree = True And LeftControl = True And CheckBox18.Checked = True Then
                    CheckBox18.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowFour = True And LeftControl = True And CheckBox19.Checked = False Then
                    CheckBox19.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowFour = True And LeftControl = True And CheckBox19.Checked = True Then
                    CheckBox19.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowFive = True And LeftControl = True And CheckBox20.Checked = False Then
                    CheckBox20.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowFive = True And LeftControl = True And CheckBox20.Checked = True Then
                    CheckBox20.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowSix = True And LeftControl = True And CheckBox21.Checked = False Then
                    CheckBox21.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowSix = True And LeftControl = True And CheckBox21.Checked = True Then
                    CheckBox21.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowSeven = True And LeftControl = True And CheckBox22.Checked = False Then
                    CheckBox22.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowSeven = True And LeftControl = True And CheckBox22.Checked = True Then
                    CheckBox22.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowEight = True And LeftControl = True And CheckBox23.Checked = False Then
                    CheckBox23.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowEight = True And LeftControl = True And CheckBox23.Checked = True Then
                    CheckBox23.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowNine = True And LeftControl = True And CheckBox24.Checked = False Then
                    CheckBox24.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowNine = True And LeftControl = True And CheckBox24.Checked = True Then
                    CheckBox24.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F1 = True And LeftControl = True And CheckBox32.Checked = False Then
                    CheckBox32.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F1 = True And LeftControl = True And CheckBox32.Checked = True Then
                    CheckBox32.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F2 = True And LeftControl = True And CheckBox89.Checked = False Then
                    CheckBox89.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F2 = True And LeftControl = True And CheckBox89.Checked = True Then
                    CheckBox89.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowZero = True And RightShift = True And CheckBox25.Checked = False Then
                    CheckBox25.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowZero = True And RightShift = True And CheckBox25.Checked = True Then
                    CheckBox25.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowOne = True And RightShift = True And CheckBox26.Checked = False Then
                    CheckBox26.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowOne = True And RightShift = True And CheckBox26.Checked = True Then
                    CheckBox26.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowTwo = True And RightShift = True And CheckBox27.Checked = False Then
                    CheckBox27.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowTwo = True And RightShift = True And CheckBox27.Checked = True Then
                    CheckBox27.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowThree = True And RightShift = True And CheckBox28.Checked = False Then
                    CheckBox28.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowThree = True And RightShift = True And CheckBox28.Checked = True Then
                    CheckBox28.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowFour = True And RightShift = True And CheckBox29.Checked = False Then
                    CheckBox29.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowFour = True And RightShift = True And CheckBox29.Checked = True Then
                    CheckBox29.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                'If NumRowFive = True And RightShift = True And CheckBox30.Checked = False Then
                'CheckBox30.Checked = True
                'My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                'System.Threading.Thread.Sleep(100)
                'ElseIf NumRowFive = True And RightShift = True And CheckBox30.Checked = True Then
                'CheckBox30.Checked = False
                'My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep) 
                'System.Threading.Thread.Sleep(100)
                'End If
                If NumRowSix = True And RightShift = True And CheckBox31.Checked = False Then
                    CheckBox31.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowSix = True And RightShift = True And CheckBox31.Checked = True Then
                    CheckBox31.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowSeven = True And RightShift = True And CheckBox83.Checked = False Then
                    CheckBox83.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowSeven = True And RightShift = True And CheckBox83.Checked = True Then
                    CheckBox83.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowEight = True And RightShift = True And CheckBox91.Checked = False Then
                    CheckBox91.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowEight = True And RightShift = True And CheckBox91.Checked = True Then
                    CheckBox91.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If NumRowNine = True And RightShift = True And CheckBox34.Checked = False Then
                    CheckBox34.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf NumRowNine = True And RightShift = True And CheckBox34.Checked = True Then
                    CheckBox34.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F1 = True And RightShift = True And CheckBox35.Checked = False Then
                    CheckBox35.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F1 = True And RightShift = True And CheckBox35.Checked = True Then
                    CheckBox35.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F2 = True And RightShift = True And CheckBox36.Checked = False Then
                    CheckBox36.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F2 = True And RightShift = True And CheckBox36.Checked = True Then
                    CheckBox36.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F3 = True And RightShift = True And CheckBox37.Checked = False Then
                    CheckBox37.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F3 = True And RightShift = True And CheckBox37.Checked = True Then
                    CheckBox37.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F4 = True And RightShift = True And CheckBox38.Checked = False Then
                    CheckBox38.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F4 = True And RightShift = True And CheckBox38.Checked = True Then
                    CheckBox38.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F5 = True And RightShift = True And CheckBox85.Checked = False Then
                    CheckBox85.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F5 = True And RightShift = True And CheckBox85.Checked = True Then
                    CheckBox85.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F6 = True And RightShift = True And CheckBox87.Checked = False Then
                    CheckBox87.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F6 = True And RightShift = True And CheckBox87.Checked = True Then
                    CheckBox87.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F7 = True And RightShift = True And CheckBox98.Checked = False Then
                    CheckBox98.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F7 = True And RightShift = True And CheckBox98.Checked = True Then
                    CheckBox98.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F8 = True And RightShift = True And CheckBox100.Checked = False Then
                    CheckBox100.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F8 = True And RightShift = True And CheckBox100.Checked = True Then
                    CheckBox100.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F6 = True And LeftShift = True And CheckBox103.Checked = False Then
                    CheckBox103.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F6 = True And LeftShift = True And CheckBox103.Checked = True Then
                    CheckBox103.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If F9 = True And RightShift = True And CheckBox105.Checked = False And RadioButton1.Checked = True Then
                    CheckBox105.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf F9 = True And RightShift = True And CheckBox105.Checked = True And RadioButton1.Checked = True Then
                    CheckBox105.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                'If LeftControl = True And F7 = True And CheckBox107.Checked = False And Panel11.Enabled = True Then
                '    CheckBox107.Checked = True
                '    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                '    System.Threading.Thread.Sleep(100)
                'ElseIf LeftControl = True And F7 = True And CheckBox107.Checked = True And Panel11.Enabled = True Then
                '    CheckBox107.Checked = False
                '    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                '    System.Threading.Thread.Sleep(100)
                'End If
                If LeftControl = True And F8 = True And CheckBox108.Checked = False And Panel11.Enabled = True Then
                    CheckBox108.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf LeftControl = True And F8 = True And CheckBox108.Checked = True And Panel11.Enabled = True Then
                    CheckBox108.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If LeftControl = True And F9 = True And CheckBox109.Checked = False And Panel11.Enabled = True Then
                    CheckBox109.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf LeftControl = True And F9 = True And CheckBox109.Checked = True And Panel11.Enabled = True Then
                    CheckBox109.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                If LeftControl = True And F10 = True And CheckBox111.Checked = False And Panel11.Enabled = True Then
                    CheckBox111.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf LeftControl = True And F10 = True And CheckBox111.Checked = True And Panel11.Enabled = True Then
                    CheckBox111.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
                'If LeftControl = True And F11 = True And CheckBox112.Checked = False And Panel11.Enabled = True Then
                '    CheckBox112.Checked = True
                '    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                '    System.Threading.Thread.Sleep(100)
                'ElseIf LeftControl = True And F11 = True And CheckBox112.Checked = True And Panel11.Enabled = True Then
                '    CheckBox112.Checked = False
                '    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                '    System.Threading.Thread.Sleep(100)
                'End If
                If LeftControl = True And F12 = True And CheckBox113.Checked = False And Panel11.Enabled = True Then
                    CheckBox113.Checked = True
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    System.Threading.Thread.Sleep(100)
                ElseIf LeftControl = True And F12 = True And CheckBox113.Checked = True And Panel11.Enabled = True Then
                    CheckBox113.Checked = False
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    System.Threading.Thread.Sleep(100)
                End If
            Catch ex As Exception
                MsgBox("If you are seeing this error then sadly, for some unknown reason, hotkeys cannot be used. Check to make sure an anti-virus program is not blocking this hack.")
            End Try
        End If
    End Sub

    Private Sub CheckBox96_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox96.CheckedChanged
        'Disable Preset Hotkeys
        If CheckBox96.Checked = True Then
            Timer1.Stop()
        ElseIf CheckBox96.Checked = False Then
            Timer1.Start()
        End If
    End Sub
    Dim myfile As New System.Diagnostics.Process
    Dim arg As String
    Dim dir As String

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'Settings, Launch Game
        Try
            With myfile
                .StartInfo.WorkingDirectory = dir
                .StartInfo.FileName = TextBox1.Text
                .StartInfo.Arguments = arg
            End With
            myfile.Start()
        Catch ex As Exception
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            AboutBox10.Label1.Text = ("Could not find " & TextBox1.Text & ".exe!")
            AboutBox10.TextBox1.Text = dir
            AboutBox10.TextBox2.Text = arg
            AboutBox10.Show()
        End Try
    End Sub
    Dim custom As String
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        'Browse
        FolderBrowserDialog1.ShowDialog()
        custom = FolderBrowserDialog1.SelectedPath
        dir = FolderBrowserDialog1.SelectedPath
        RichTextBox1.Text = custom
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton7.CheckedChanged
        'Windows x86
        If RadioButton7.Checked = True And CheckBox102.Checked = False Then
            RichTextBox1.Text = ("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData")
        ElseIf RadioButton7.Checked = True And CheckBox102.Checked = True Then
            RichTextBox1.Text = ("C:\Program Files\Steam\SteamApps\common\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files\Steam\SteamApps\common\Star Wars Battlefront II\GameData")
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton8.CheckedChanged
        'Windows x64
        If RadioButton8.Checked = True And CheckBox102.Checked = False Then
            RichTextBox1.Text = ("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData")
        ElseIf RadioButton8.Checked = True And CheckBox102.Checked = True Then
            RichTextBox1.Text = ("C:\Program Files (x86)\Steam\SteamApps\common\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files (x86)\Steam\SteamApps\common\Star Wars Battlefront II\GameData")
        End If
    End Sub

    Private Sub CheckBox97_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox97.CheckedChanged
        'Enable Custom Hotkeys
        'If CheckBox97.Checked = True Then
        '    CheckBox96.Checked = True
        '    Button5.Enabled = True
        'ElseIf CheckBox97.Checked = False Then
        '    AboutBox7.Timer1.Stop()
        '    AboutBox7.Timer2.Stop()
        '    AboutBox7.Close()
        '    Button5.Enabled = False
        'End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton9.CheckedChanged
        'Custom Directory
        If RadioButton9.Checked = True Then
            RichTextBox1.Text = " "
            Button6.Enabled = True
            CheckBox102.Checked = False
            CheckBox102.Enabled = False
        ElseIf RadioButton9.Checked = False Then
            RichTextBox1.Text = " "
            Button6.Enabled = False
            CheckBox102.Enabled = True
        End If
    End Sub
    Dim HackSixteen As Boolean
    Dim HackSixteenCave As Integer = 0
    Dim HackSeventeen As Boolean
    Dim HackSeventeenCave As Integer = 0

    Private Sub CheckBox98_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox98.CheckedChanged
        'Remove Map Ceiling
        If CheckBox98.Checked = True Then
            CheckBox99.Checked = True
            AboutBox4.Label88.ForeColor = Color.Red
            AboutBox4.Label89.ForeColor = Color.Red
        ElseIf CheckBox98.Checked = False Then
            CheckBox99.Checked = False
            AboutBox4.Label88.ForeColor = Color.Black
            AboutBox4.Label89.ForeColor = Color.Black
        End If
        If RadioButton6.Checked = True Then
            Try
                If Not HackSixteen Then
                    HackSixteenCave = Mem.Allocate
                    Mem.Jmp(&H42E75D, HackSixteenCave, "D805287A8900D80D287A8900D91D287A8900", 6)
                Else
                    If Mem.WriteBytes(&H42E75D, "D91D287A8900") Then
                        Mem.DeAllocate(HackSixteenCave)
                    End If
                End If
                HackSixteen = Not HackSixteen
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
        If RadioButton5.Checked = True Then
            Try
                If Not HackSeventeen Then
                    HackSeventeenCave = Mem.Allocate
                    Mem.Jmp(&H46DA0D, HackSeventeenCave, "D805E8F0BD00D80DE8F0BD00D91DE8F0BD00", 6)
                Else
                    If Mem.WriteBytes(&H46DA0D, "D91DE8F0BD00") Then
                        Mem.DeAllocate(HackSeventeenCave)
                    End If
                End If
                HackSeventeen = Not HackSeventeen
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox99_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox99.CheckedChanged
        If CheckBox99.Checked = True Then
            CheckBox98.Checked = True
        ElseIf CheckBox99.Checked = False Then
            CheckBox98.Checked = False
        End If
    End Sub

    Private Sub CheckBox100_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox100.CheckedChanged
        'Instant Vehicle Respawn
        If CheckBox100.Checked = True Then
            CheckBox101.Checked = True
            AboutBox4.Label90.ForeColor = Color.Red
            AboutBox4.Label91.ForeColor = Color.Red
        ElseIf CheckBox100.Checked = False Then
            CheckBox101.Checked = False
            AboutBox4.Label90.ForeColor = Color.Black
            AboutBox4.Label91.ForeColor = Color.Black
        End If
        If CheckBox100.Checked = True And RadioButton6.Checked = True Then
            Try
                WriteLong(TextBox1.Text, &H58CE16, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox100.Checked = False And RadioButton6.Checked = True Then
            Try
                WriteLong(TextBox1.Text, &H58CE16, &H10093D9, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox100.Checked = True And RadioButton5.Checked = True Then
            Try
                WriteLong("BattlefrontII", &H6736D8, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox100.Checked = False And RadioButton5.Checked = True Then
            Try
                WriteLong("BattlefrontII", &H6736D8, &H10093D9, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox102_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox102.CheckedChanged
        'Steam
        If RadioButton7.Checked = True And CheckBox102.Checked = False Then
            RichTextBox1.Text = ("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files\LucasArts\Star Wars Battlefront II\GameData")
        ElseIf RadioButton7.Checked = True And CheckBox102.Checked = True Then
            RichTextBox1.Text = ("C:\Program Files\Steam\SteamApps\common\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files\Steam\SteamApps\common\Star Wars Battlefront II\GameData")
        End If
        If RadioButton8.Checked = True And CheckBox102.Checked = False Then
            RichTextBox1.Text = ("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files (x86)\LucasArts\Star Wars Battlefront II\GameData")
        ElseIf RadioButton8.Checked = True And CheckBox102.Checked = True Then
            RichTextBox1.Text = ("C:\Program Files (x86)\Steam\SteamApps\common\Star Wars Battlefront II\GameData\BattlefrontII.exe")
            dir = ("C:\Program Files (x86)\Steam\SteamApps\common\Star Wars Battlefront II\GameData")
        End If
    End Sub

    Private Sub CheckBox103_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox103.CheckedChanged
        'No Fall Damage
        If CheckBox103.Checked = True Then
            CheckBox104.Checked = True
            AboutBox4.Label92.ForeColor = Color.Red
            AboutBox4.Label93.ForeColor = Color.Red
        ElseIf CheckBox103.Checked = False Then
            CheckBox104.Checked = False
            AboutBox4.Label92.ForeColor = Color.Black
            AboutBox4.Label93.ForeColor = Color.Black
        End If
        If CheckBox103.Checked = True And RadioButton1.Checked = True Then
            Try
                WriteInteger("BattlefrontII", &H546CDD, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox103.Checked = False And RadioButton1.Checked = True Then
            Try
                WriteInteger("BattlefrontII", &H546CDD, &H1189, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
        If CheckBox103.Checked = True And RadioButton2.Checked = True Then
            Try
                WriteInteger(TextBox1.Text, &H4C9F02, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox103.Checked = False And RadioButton2.Checked = True Then
            Try
                WriteInteger(TextBox1.Text, &H4C9F02, &H3089, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox104_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox104.CheckedChanged
        If CheckBox104.Checked = True Then
            CheckBox103.Checked = True
        ElseIf CheckBox104.Checked = False Then
            CheckBox103.Checked = False
        End If
    End Sub
    Dim HackEighteen As Boolean
    Dim HackEighteenCave As Integer = 0
    Dim HackNineteen As Boolean
    Dim HackNineteenCave As Integer = 0

    Private Sub CheckBox105_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox105.CheckedChanged
        'Super Vehicle Boost
        If CheckBox105.Checked = True Then
            CheckBox106.Checked = True
            AboutBox4.Label94.ForeColor = Color.Red
            AboutBox4.Label95.ForeColor = Color.Red
        ElseIf CheckBox105.Checked = False Then
            CheckBox106.Checked = False
            AboutBox4.Label94.ForeColor = Color.Black
            AboutBox4.Label95.ForeColor = Color.Black
        End If
        If RadioButton5.Checked = True Then
            Try
                If Not HackEighteen Then
                    HackEighteenCave = Mem.Allocate
                    Mem.Jmp(&H515F12, HackEighteenCave, "D981C00E0000D889C00E0000", 6)
                Else
                    If Mem.WriteBytes(&H515F12, "D981C00E0000") Then
                        Mem.DeAllocate(HackEighteenCave)
                    End If
                End If
                HackEighteen = Not HackEighteen
            Catch ex As Exception
                MsgBox("Failed to enable/disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox106_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox106.CheckedChanged
        If CheckBox106.Checked = True Then
            CheckBox105.Checked = True
        ElseIf CheckBox106.Checked = False Then
            CheckBox105.Checked = False
        End If
    End Sub
    Dim client As Integer
    Dim server As Integer

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Dim MyP2 As Process() = Process.GetProcessesByName("swbf2sm")
        Dim MyP3 As Process() = Process.GetProcessesByName("BattlefrontII")
        Dim MyP4 As Process() = Process.GetProcessesByName("Battlefront2")
        If MyP2.Length = 0 And MyP3.Length = 1 And MyP4.Length = 0 Then
            client = 1
            server = 0
        End If
        If MyP2.Length = 0 And MyP3.Length = 0 And MyP4.Length = 1 Then
            client = 1
            server = 0
        End If
        If MyP2.Length = 1 And MyP3.Length = 1 And MyP4.Length = 1 Then
            client = 2
            server = 2
        End If
        If MyP2.Length = 1 And MyP3.Length = 1 And MyP4.Length = 0 Then
            server = 1
            client = 1
        End If
        If MyP2.Length = 1 And MyP3.Length = 0 And MyP4.Length = 0 Then
            server = 1
            client = 0
        End If
        If MyP2.Length = 0 And MyP3.Length = 0 And MyP4.Length = 0 Then
            server = 0
            client = 0
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        'Settings, Check Version
        Try
            If client = 0 And server = 0 Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                MsgBox("No game detected!")
                RadioButton1.Checked = False
                RadioButton2.Checked = False
            End If
            If client = 1 And server = 0 Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox("Client detected!")
                RadioButton2.Checked = True
            End If
            If server = 1 And client = 1 Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox("Server detected!")
                RadioButton1.Checked = True
            End If
            If server = 2 And client = 2 Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                MsgBox("Client and Server detected!")
            End If
            If server = 1 And client = 0 Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                MsgBox("Server detected but not running!")
                RadioButton1.Checked = True
            End If
        Catch ex As Exception
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MsgBox("Hopefully you aren't seeing this message, but if you are then something went wrong while trying to detect which version was running. No known solution found so just don't use this button :).")
        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        'Configure Custom Hotkeys
        'AboutBox7.Show()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)
        'Hack Settings
    End Sub

    Private Sub CheckBox93_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox93.CheckedChanged
        'Skip Intro
        If CheckBox93.Checked = True Then
            arg = arg + " -nointro"
        Else
            arg = arg.Replace("-nointro", "")
        End If
    End Sub

    Private Sub CheckBox94_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox94.CheckedChanged
        'Fix Audio Stuttering
        If CheckBox94.Checked = True Then
            arg = arg + " -audiomixbuffer 80"
        Else
            arg = arg.Replace("-audiomixbuffer 80", "")
        End If
    End Sub

    Private Sub CheckBox95_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox95.CheckedChanged
        'Windowed Mode
        If CheckBox95.Checked = True Then
            arg = arg + " -win"
        Else
            arg = arg.Replace("-win", "")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Multiplayer Hacks Info
        AboutBox11.Show()
    End Sub

    Private Sub CheckBox108_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox108.CheckedChanged
        'Show Enemy Name Tags/Swap Units At Any Command Post
        If CheckBox108.Checked = True Then
            AboutBox4.Label33.ForeColor = Color.Red
            AboutBox4.Label121.ForeColor = Color.Red
            Try
                WriteLong(TextBox1.Text, &H4DD739, &H909090909090, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox108.Checked = False Then
            AboutBox4.Label33.ForeColor = Color.Black
            AboutBox4.Label121.ForeColor = Color.Black
            Try
                WriteLong(TextBox1.Text, &H4DD739, &H2348E89, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox109_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox109.CheckedChanged
        'Move Aftering Entering Command Post
        If CheckBox109.Checked = True Then
            AboutBox4.Label34.ForeColor = Color.Red
            AboutBox4.Label122.ForeColor = Color.Red
            Try
                WriteLong(TextBox1.Text, &H5A6738, &H9090909090909090, nsize:=8)
                WriteInteger(TextBox1.Text, &H5A6740, &H9090, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox109.Checked = False Then
            AboutBox4.Label34.ForeColor = Color.Black
            AboutBox4.Label122.ForeColor = Color.Black
            Try
                WriteLong(TextBox1.Text, &H5A6738, &H7FADB005C7, nsize:=8)
                WriteInteger(TextBox1.Text, &H5A6740, &H0, nsize:=2)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox111_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox111.CheckedChanged
        'Show Items Through Walls
        AboutBox4.Label44.ForeColor = Color.Red
        AboutBox4.Label123.ForeColor = Color.Red
        If CheckBox111.Checked = True Then
            Try
                WriteLong(TextBox1.Text, &H504AD0, &H164C8848D, nsize:=7)
            Catch ex As Exception
                MsgBox("Failed to enabled hack!")
            End Try
        ElseIf CheckBox111.Checked = False Then
            AboutBox4.Label44.ForeColor = Color.Black
            AboutBox4.Label123.ForeColor = Color.Black
            Try
                WriteLong(TextBox1.Text, &H504AD0, &H174C8848D, nsize:=7)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub
    Dim HackTwentyFour As Boolean
    Dim HackTwentyFourCave As Integer = 0
    Private Sub CheckBox112_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox112.CheckedChanged
        'Extend Unit Swap Radius
        If CheckBox112.Checked = True Then
            AboutBox4.Label45.ForeColor = Color.Red
            AboutBox4.Label124.ForeColor = Color.Red
        ElseIf CheckBox112.Checked = False Then
            AboutBox4.Label45.ForeColor = Color.Black
            AboutBox4.Label124.ForeColor = Color.Black
        End If
        Try
            If Not HackTwentyFour Then
                HackTwentyFourCave = Mem.Allocate
                Mem.Jmp(&H4DE794, HackTwentyFourCave, AboutBox12.RichTextBox2.Text, 6)
            Else
                If Mem.WriteBytes(&H4DE794, "D99F2C030000") Then
                    Mem.DeAllocate(HackTwentyFourCave)
                End If
            End If
            HackTwentyFour = Not HackTwentyFour
        Catch ex As Exception
            MsgBox("Failed to enable/disable hack!")
        End Try
    End Sub

    Private Sub CheckBox113_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox113.CheckedChanged
        'Show Player # In Kills Tab
        If CheckBox113.Checked = True Then
            AboutBox4.Label46.ForeColor = Color.Red
            AboutBox4.Label125.ForeColor = Color.Red
            Try
                WriteInteger(TextBox1.Text, &H435A74, &H56, nsize:=1)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox113.Checked = False Then
            AboutBox4.Label46.ForeColor = Color.Black
            AboutBox4.Label125.ForeColor = Color.Black
            Try
                WriteInteger(TextBox1.Text, &H435A74, &H51, nsize:=1)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub CheckBox107_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox107.CheckedChanged
        'Visible Bothans
        If CheckBox107.Checked = True Then
            AboutBox4.Label32.ForeColor = Color.Red
            AboutBox4.Label120.ForeColor = Color.Red
            Try
                WriteLong(TextBox1.Text, &H566109, &H7DBCE10DD8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to enable hack!")
            End Try
        ElseIf CheckBox107.Checked = False Then
            AboutBox4.Label32.ForeColor = Color.Black
            AboutBox4.Label120.ForeColor = Color.Black
            Try
                WriteLong(TextBox1.Text, &H566109, &H7DBCE00DD8, nsize:=6)
            Catch ex As Exception
                MsgBox("Failed to disable hack!")
            End Try
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            Panel1.Enabled = False
            Panel2.Enabled = False
            Panel3.Enabled = False
            Panel4.Enabled = False
            Panel5.Enabled = False
            Panel6.Enabled = False
            Panel8.Enabled = False
            Panel9.Enabled = False
            Panel10.Enabled = False
        Else
            Panel1.Enabled = True
            Panel2.Enabled = True
            Panel3.Enabled = True
            Panel4.Enabled = True
            Panel5.Enabled = True
            Panel6.Enabled = True
            Panel8.Enabled = True
            Panel9.Enabled = True
            Panel10.Enabled = True
        End If
        If RadioButton2.Checked = True And RadioButton1.Checked = False Then
            Panel11.Enabled = True
        Else
            Panel11.Enabled = False
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AboutBox6.Show()
    End Sub

    Private Sub CheckBox110_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox110.CheckedChanged
        If CheckBox110.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
End Class
