Public NotInheritable Class AboutBox2

    Private Sub AboutBox2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Label1.Text = ("This will make everything on the battlefield unable to be killed.")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Label1.Text = ("This makes everything on the battlefield take 1 damage point for every explosion/bullet that hits them.")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Label1.Text = ("This locks the player in place making them unable to move.")
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Label1.Text = ("Hover will allow your player to remain at the same height he was when this feature was enabled.")
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            Label1.Text = ("You will never run out of ammo with any gun.")
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            Label1.Text = ("This makes all droideka shields infinite.")
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            Label1.Text = ("This will render droidekas unable to use their shields.")
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            Label1.Text = ("Enabling this will allow you to fly for as long as you want.")
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            Label1.Text = ("Your gun will never overheat again.")
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            Label1.Text = ("This will allow you to fire any gun as fast as you want.")
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            Label1.Text = ("This will make your bullets always travel in a straight line and never stray from the crosshair.")
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            Label1.Text = ("This disables shooting for those times where rapid fire gets annoying.")
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then
            Label1.Text = ("This allows your player to shoot both of his primary or secondary weapons at once.")
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked = True Then
            Label1.Text = ("Walk Through Walls allows your player to walk through almost any wall. Note this does not have the same effect on all maps.")
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked = True Then
            Label1.Text = ("Enabling this while standing on a roof will force your player through the roof and on to the ground.")
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked = True Then
            Label1.Text = ("This will allow your player to walk anywhere outside the battlefield without dying.")
        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked = True Then
            Label1.Text = ("This will cause your player to die instantly if he walks outside of the battlefield.")
        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked = True Then
            Label1.Text = ("No Clip renders all geometry as null, allowing you to pass through any wall or vehicle.")
        End If
    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton19.CheckedChanged
        If RadioButton19.Checked = True Then
            Label1.Text = ("1 kill and its game over.")
        End If
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton20.CheckedChanged
        If RadioButton20.Checked = True Then
            Label1.Text = ("This will freeze the reinforcement count at its current value allowing you to play for as long as your heart desires.")
        End If
    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton21.CheckedChanged
        If RadioButton21.Checked = True Then
            Label1.Text = ("This will make the respawn timer always stay at 1, making you respawn instantly. A map change is required for this to take effect.")
        End If
    End Sub
End Class
