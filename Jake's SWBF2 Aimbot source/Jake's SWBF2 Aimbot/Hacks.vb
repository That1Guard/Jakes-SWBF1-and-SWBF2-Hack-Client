Public NotInheritable Class Hacks

    Private Sub Hacks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim rapidfire As Single
    Dim rapidfire2 As Single
    Dim respawntimer As Single
    Dim respawntimer2 As Single
    Dim originalhealth As Single
    Dim points As Integer
    Dim jump As Integer
    Dim jump2 As Single
    Dim jumping As Boolean = False
    Dim ammobase As String = "&H01DCBAD8"
    Dim secondammobase As String = "&H01DCBB00"
    Dim respawnbase As String = "&H00897A40"
    Dim overheatbase As String = "&H01DCBAD8"
    Dim pointsbase As String = "&H00897AC0"
    Dim falldamagebase As String = "&H0085AD24"
    Dim jumpbase As String = "&H0085AD24"
    Dim rapidfirebase As String = "&H0085AD24"
    Dim staminabase As String = "&H0085AD24"
    Dim spreadbase As String = "&H0085AD24"
    Dim ceilingbase As String = "&H00416E24"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'rapid fire
        If Rapid_Fire.Checked = True Then
            rapidfire = ReadDMAFloat(Form1.process, Form1.pointerbase, {&H24C, &HB4}, 2)
            rapidfire2 = ReadDMAFloat(Form1.process, rapidfirebase, {&H248, &HB4}, 2)
            WriteDMAFloat(Form1.process, Form1.pointerbase, {&H22C, &HB4}, 17, 2)
            WriteDMAFloat(Form1.process, Form1.pointerbase, {&H24C, &HB4}, rapidfire + 1, 2)
            WriteDMAFloat(Form1.process, rapidfirebase, {&H248, &HB4}, rapidfire2 + 2, 2)
        Else

        End If
        'infinite ammo
        If Infinite_Ammo.Checked = True Then
            WriteDMAFloat(Form1.process, ammobase, {&H88, &H10}, 1, 2)
            WriteDMAFloat(Form1.process, secondammobase, {&H88, &H10}, 1, 2)
        Else

        End If

        'no overheat
        If No_Overheat.Checked = True Then
            WriteDMAFloat(Form1.process, overheatbase, {&H8C, &H4}, 1, 2)
        ElseIf No_Overheat.Checked = False Then

        End If

        'no fall damage
        If No_Fall_Damage.Checked = True Then
            WriteDMAFloat(Form1.process, falldamagebase, {&H4F0, &H7C8}, 0, 2)
        ElseIf No_Fall_Damage.Checked = False Then
            WriteDMAFloat(Form1.process, falldamagebase, {&H4F0, &H7C8}, 1, 2)
        End If
        'unlimited jump
        If Unlimited_Jump.Checked = True Then
            jump = ReadDMAInteger(Form1.process, jumpbase, {&H44, &H504}, 2)
            If jump = 4 Or jump = 8 Then
                WriteDMAInteger(Form1.process, jumpbase, {&H44, &H504}, 0, 2)
            Else

            End If
        ElseIf Unlimited_Jump.Checked = False Then

        End If

        'no spread
        If No_Spread.Checked = True Then
            WriteDMAFloat(Form1.process, spreadbase, {&H22C, &H120}, -1, 2)
            WriteDMAFloat(Form1.process, spreadbase, {&H22C, &H2E0}, -1, 2)
        ElseIf No_Spread.Checked = False Then

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles Infinite_Health.CheckedChanged
        'infinite health
        If Infinite_Health.Checked = False Then
            WriteDMAFloat(Form1.process, Form1.pointerbase, {&H48, &H54}, originalhealth, 2)
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles Super_Jump.CheckedChanged
        'super jump
        If Super_Jump.Checked = True Then
            NumericUpDown1.Enabled = True
        ElseIf Super_Jump.Checked = False Then
            NumericUpDown1.Enabled = False
        End If
    End Sub

    Private Sub Continuous_Points_CheckedChanged(sender As Object, e As EventArgs) Handles Continuous_Points.CheckedChanged
        'continuous points
        If Continuous_Points.Checked = True Then
            NumericUpDown2.Enabled = True
        ElseIf Continuous_Points.Checked = False Then
            NumericUpDown2.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'infinite health
        If Infinite_Health.Checked = True Then
            originalhealth = ReadDMAFloat(Form1.process, Form1.pointerbase, {&H48, &H58}, 2)
            WriteDMAFloat(Form1.process, Form1.pointerbase, {&H48, &H54}, 100000, 2)
        ElseIf Infinite_Health.Checked = False Then
            originalhealth = ReadDMAFloat(Form1.process, Form1.pointerbase, {&H48, &H58}, 2)
        End If

        If regen_health.Checked = True Then
            If ReadDMAFloat(Form1.process, Form1.pointerbase, {&H48, &H54}, 2) < originalhealth Then
                WriteDMAFloat(Form1.process, Form1.pointerbase, {&H48, &H54}, ReadDMAFloat(Form1.process, Form1.pointerbase, {&H48, &H54}, 2) + (regen.Value * 10), 2)
            Else

            End If
        Else

        End If

        'instant respawn
        If Instant_Respawn.Checked = True Then
            respawntimer = ReadDMAFloat(Form1.process, respawnbase, {&HC8, &H9C}, 2)
            If respawntimer > 0.5 Then
                WriteDMAFloat(Form1.process, respawnbase, {&HC8, &H9C}, 0.5, 2)
            Else

            End If
            respawntimer2 = ReadDMAFloat(Form1.process, respawnbase, {&HC8, &HA0}, 2)
            If respawntimer2 > 0.5 Then
                WriteDMAFloat(Form1.process, respawnbase, {&HC8, &HA0}, 0.5, 2)
            Else

            End If
        Else

        End If

        'continuous points
        If Continuous_Points.Checked = True Then
            points = ReadDMAInteger(Form1.process, pointsbase, {&H1F0}, 1)
            If points > 29999 Then

            ElseIf points < 0 Then
                WriteDMAInteger(Form1.process, pointsbase, {&H1F0}, 0, 1)
            Else
                WriteDMAInteger(Form1.process, pointsbase, {&H1F0}, points + NumericUpDown2.Value, 1)
            End If
        ElseIf Continuous_Points.Checked = False Then

        End If

        'super jump
        If Super_Jump.Checked = True Then
            jump2 = ReadDMAFloat(Form1.process, jumpbase, {&H44, &H2A0}, 2)
            If jump2 >= 7 And jumping = False Then
                jumping = True
                WriteDMAFloat(Form1.process, jumpbase, {&H44, &H2A0}, NumericUpDown1.Value * 8, 2)
            ElseIf jump2 = 0 And jumping = True Then
                jumping = False
            End If
        ElseIf Super_Jump.Checked = False Then

        End If

        'infinite stamina
        If Infinite_Stamina.Checked = True Then
            WriteDMAFloat(Form1.process, staminabase, {&H3C, &H514}, 120, 2)
        ElseIf Infinite_Stamina.Checked = False Then

        End If

        'map ceiling
        Try
            TextBox1.Text = ReadDMAFloat(Form1.process, ceilingbase, {&H18}, 1)
            If TextBox2.Text.Length = 0 Then

            Else
                WriteDMAFloat(Form1.process, ceilingbase, {&H18}, TextBox2.Text, 1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub regen_health_CheckedChanged(sender As Object, e As EventArgs) Handles regen_health.CheckedChanged
        If regen_health.Checked = True Then
            regen.Enabled = True
        Else
            regen.Enabled = False
        End If
    End Sub

    Private Sub close_hacks_Click(sender As Object, e As EventArgs) Handles close_hacks.Click
        Me.Visible = False
    End Sub
End Class
