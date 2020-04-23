Imports System.Net.NetworkInformation
Imports System.Text

Public Class Form1
    Public process As String = "BattlefrontII"
    Public pointerbase As String = "&H0085AD24"
    Public crosshair As String = "&H0085AD18"
    Dim currentxoffset As Integer() = {&H48, &H30}
    Dim currentyoffset As Integer() = {&H48, &H34}
    Dim currentzoffset As Integer() = {&H48, &H38}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim fp As String
    Dim targetdirectionx As String
    Dim targetdirectionz As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        current_x.Text = ReadDMAFloat(process, pointerbase, currentxoffset, 2)
        current_y.Text = ReadDMAFloat(process, pointerbase, currentyoffset, 2)
        current_z.Text = ReadDMAFloat(process, pointerbase, currentzoffset, 2)

        crosshair_x.Text = ReadDMAFloat(process, crosshair, {&HEC, &H9C}, 2)
        crosshair_y.Text = ReadDMAFloat(process, crosshair, {&HEC, &HA0}, 2)
        crosshair_z.Text = ReadDMAFloat(process, crosshair, {&HEC, &HA4}, 2)

        fp = ReadDMAInteger(process, pointerbase, {&H44, &H138}, 2)
        target_x.Text = ReadFloat(process, "&H" & Hex(fp + 24))
        target_y.Text = ReadFloat(process, "&H" & Hex(fp + 28))
        target_z.Text = ReadFloat(process, "&H" & Hex(fp + 32))

        targetdirectionx = ReadFloat(process, "&H" & Hex(fp + 260)) 'should be 6E '110'
        targetdirectionz = ReadFloat(process, "&H" & Hex(fp + 268))
        Console.WriteLine(targetdirectionx & " " & targetdirectionz)

    End Sub
    Dim correctorx As Integer
    Dim correctorz As Integer


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            If target_x.Text = 0 And target_y.Text = 0 And target_z.Text = 0 And aimbot.enable_aimbot.Checked = True Then
                aimbot.aim_check.Checked = False
            ElseIf target_x.Text <> 0 And target_y.Text <> 0 And target_z.Text <> 0 And aimbot.enable_aimbot.Checked = True Then
                aimbot.aim_check.Checked = True

                'need better aim prediction
                If aimbot.aimpredict = True Then
                    If Math.Abs(x - target_x.Text) < 0.5 Or Math.Abs(z - target_z.Text) < 0.5 Then
                        correctorx = 0
                        correctorz = 0
                    Else
                        If targetdirectionx <= 0 Then
                            correctorx = 1.5
                        ElseIf targetdirectionx > 0 Then
                            correctorx = -1.5
                        End If

                        If targetdirectionz <= 0 Then
                            correctorz = -1.5
                        ElseIf targetdirectionz > 0 Then
                            correctorz = 1.5
                        End If
                    End If

                    WriteDMAFloat(process, crosshair, {&HEC, &H9C}, target_x.Text + correctorx, 2) 'write x coord
                    If aimbot.head.Checked = True Then
                        WriteDMAFloat(process, crosshair, {&HEC, &HA0}, target_y.Text + 0.55, 2) 'write y coord
                    End If
                    If aimbot.chest.Checked = True Then
                        WriteDMAFloat(process, crosshair, {&HEC, &HA0}, target_y.Text, 2) 'write y coord
                    End If
                    WriteDMAFloat(process, crosshair, {&HEC, &HA4}, target_z.Text + correctorz, 2) 'write z coord

                    Console.WriteLine("aim predict")

                ElseIf aimbot.aimpredict = False Then

                    WriteDMAFloat(process, crosshair, {&HEC, &H9C}, target_x.Text, 2) 'write x coord
                    If aimbot.head.Checked = True Then
                        WriteDMAFloat(process, crosshair, {&HEC, &HA0}, target_y.Text + 0.55, 2) 'write y coord
                    End If
                    If aimbot.chest.Checked = True Then
                        WriteDMAFloat(process, crosshair, {&HEC, &HA0}, target_y.Text, 2) 'write y coord
                    End If
                    WriteDMAFloat(process, crosshair, {&HEC, &HA4}, target_z.Text, 2) 'write z coord

                    Console.WriteLine("no aim predict")
                End If
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub
    Dim x As Integer
    Dim y As Integer
    Dim z As Integer

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        x = ReadFloat(process, "&H" & Hex(fp + 24))
        y = ReadFloat(process, "&H" & Hex(fp + 28))
        z = ReadFloat(process, "&H" & Hex(fp + 32))
    End Sub

    Private Sub close_hack_Click(sender As Object, e As EventArgs) Handles close_hack.Click
        Close()
    End Sub

    Private Sub hacks_Click(sender As Object, e As EventArgs) Handles hacks_button.Click
        Hacks.Show()
        Hacks.TopMost = True
        Hacks.TopMost = False
    End Sub

    Private Sub aimbot_button_Click(sender As Object, e As EventArgs) Handles aimbot_button.Click
        aimbot.Show()
        aimbot.TopMost = True
        aimbot.TopMost = False
    End Sub

    Private Sub settings_button_Click(sender As Object, e As EventArgs) Handles settings_button.Click
        settings_window.Show()
    End Sub
    Dim hotkey As String
    Dim userkey As Boolean
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            hotkey = Asc(teleport.Text.ToUpper.Substring(teleport.Text.IndexOf("=") + 2, 1))
            userkey = GetAsyncKeyState(hotkey)
            If userkey = True And settings_window.nohotkeys = False Then
                WriteDMAFloat(process, pointerbase, currentxoffset, crosshair_x.Text, 2)
                WriteDMAFloat(process, pointerbase, currentyoffset, crosshair_y.Text, 2)
                WriteDMAFloat(process, pointerbase, currentzoffset, crosshair_z.Text, 2)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub console_button_Click(sender As Object, e As EventArgs) Handles console_button.Click
        'console.Show()
    End Sub
End Class
