Public NotInheritable Class AboutBox2

    Private Sub AboutBox2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Label1.Text = ("Infinite Health will allow everyone and everything on the battlefield to be unkillable.")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Label1.Text = ("Infinite Stamina will allow everyone and every vehicle to sprint/boost forever.")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Label1.Text = ("Unlimited Jump will allow any unit to jump as many times as they want. Dont jump too high or you will be killed. Also dont come down too fast or you will be killed.")
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Label1.Text = ("This enables the command ships in space to have infinite shields so you cannot destory the outer systems. You can still go into the hangar and disable shields from the inside if you need to.")
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            Label1.Text = ("This greatly increases the normal jump height of any player/bot.")
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Label1.Text = ("This stops the timer on the heros health so you don't have to kill anyone to stay alive.")
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            Label1.Text = ("This greatly increases the players/bots sprint speed. Combine this with unlimited jump and you can pretty much fly around the map.")
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked Then
            Label1.Text = ("Hover will lock everyones Y axis meaning they cannot jump or fall.")
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked Then
            Label1.Text = ("This either increases the players health to a large amount or greatly reduces the damage of all weapons, i'm still not sure to this day.")
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked Then
            Label1.Text = ("This will lock the players/bots X and Z coordinates meaning they cannot move left/right or forward/backward. However they can still jump and fall.")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked Then
            Label1.Text = ("Remove Landing Delay removes the time it takes for your player to be able to move again after falling from a high place or tumbling on the ground.")
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked Then
            Label1.Text = ("This hack will altar the jump ability to a float type jump, making the player slowly fly up and then float back down. Sometimes results in death.")
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked Then
            Label1.Text = ("This will make your droideka shield energy never run out.")
        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked Then
            Label1.Text = ("Infinite Jetpack allows your player to fly for as long as you want without having to land and refuel.")
        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked Then
            Label1.Text = ("This hack removes the shot delay of all weapons and allows you to fire one shot after another as fast as you can.")
        End If
    End Sub

    Private Sub RadioButton19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton19.CheckedChanged
        If RadioButton19.Checked Then
            Label1.Text = ("No Overheat allows you to shoot weapons that overheat as many times as you want without having to wait for a cooldown.")
        End If
    End Sub

    Private Sub RadioButton20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton20.CheckedChanged
        If RadioButton20.Checked Then
            Label1.Text = ("Instant Charge removes the time it takes for you to charge up your weapon, such as the bowcaster/arc caster.")
        End If
    End Sub

    Private Sub RadioButton21_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton21.CheckedChanged
        If RadioButton21.Checked Then
            Label1.Text = ("This will increase the rate at which you can fix objects to an instant.")
        End If
    End Sub

    Private Sub RadioButton22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton22.CheckedChanged
        If RadioButton22.Checked Then
            Label1.Text = ("Instant Reload allows any gun to be reloaded instantly.")
        End If
    End Sub

    Private Sub RadioButton23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton23.CheckedChanged
        If RadioButton23.Checked Then
            Label1.Text = ("No Spread prevents the players bullets from straying from a straight path to their target.")
        End If
    End Sub

    Private Sub RadioButton24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton24.CheckedChanged
        If RadioButton24.Checked Then
            Label1.Text = ("This makes the timer to the items on the battlefield infinite. For example the time bomb will never explode, mines will never dispear, dets, turrets and healthpacks will never expire.")
        End If
    End Sub

    Private Sub RadioButton25_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton25.CheckedChanged
        If RadioButton25.Checked Then
            Label1.Text = ("This will disable all death regions on the map and will allow you go outside the battlefield. Unfortunatly, the leaving battlefield message won't disapear and you can't respawn.")
        End If
    End Sub

    Private Sub RadioButton26_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton26.CheckedChanged
        If RadioButton26.Checked Then
            Label1.Text = ("Activating this hack will render all geometry as null, allowing anything to pass through all objects. When using this feature on the pc dedicated version, you must enable on the client as well as the server for this to take effect.")
        End If
    End Sub

    Private Sub RadioButton27_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton27.CheckedChanged
        If RadioButton27.Checked Then
            Label1.Text = ("Fall Through causes the player to fall through whatever they are standing on. May not work on some buildings.")
        End If
    End Sub

    Private Sub RadioButton31_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton31.CheckedChanged
        If RadioButton31.Checked Then
            Label1.Text = ("You will need an extra point counter for these extreme points.")
        End If
    End Sub

    Private Sub RadioButton32_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton32.CheckedChanged
        If RadioButton32.Checked Then
            Label1.Text = ("Land Anywhere is a hack made for space battles. It allows any ship to land on any point on the map including outside the hangar. Must be activated before taking off in a ship.")
        End If
    End Sub

    Private Sub RadioButton33_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton33.CheckedChanged
        If RadioButton33.Checked Then
            Label1.Text = ("1 kill or 1 point will get you all the awards that you can get.")
        End If
    End Sub

    Private Sub RadioButton34_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton34.CheckedChanged
        If RadioButton34.Checked Then
            Label1.Text = ("This prevents anyone from capturing any command posts.")
        End If
    End Sub

    Private Sub RadioButton35_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton35.CheckedChanged
        If RadioButton35.Checked Then
            Label1.Text = ("This allows players to capture only the neutral cp's.")
        End If
    End Sub

    Private Sub RadioButton36_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton36.CheckedChanged
        If RadioButton36.Checked Then
            Label1.Text = ("This changes the amount of time it takes to capture a cp to an instant.")
        End If
    End Sub

    Private Sub RadioButton29_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton29.CheckedChanged
        If RadioButton29.Checked Then
            Label1.Text = ("This freezes the mission timer so you can play a battle for as long as you want.")
        End If
    End Sub

    Private Sub RadioButton30_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton30.CheckedChanged
        If RadioButton30.Checked Then
            Label1.Text = ("1 kill, 1 cap, 1 death will end any game on any map with any gamemode.")
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked Then
            Label1.Text = ("You will never run out of ammo for any weapon.")
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked Then
            Label1.Text = ("This causes all players to be invisible.")
        End If
    End Sub

    Private Sub RadioButton28_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton28.CheckedChanged
        If RadioButton28.Checked Then
            Label1.Text = ("This will throw everybody off the map and kill them in the process.")
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked Then
            Label1.Text = ("This will prevent your player from being blown away by explosions. Be careful as the more powerful explosions may crash your game.")
        End If
    End Sub

    Private Sub RadioButton37_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton37.CheckedChanged
        If RadioButton37.Checked Then
            Label1.Text = ("This will allow you to capture as many flags as you want without ending the game.")
        End If
    End Sub

    Private Sub RadioButton38_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton38.CheckedChanged
        If RadioButton38.Checked Then
            Label1.Text = ("This will allow you to walk through almost any wall. This hack has different effects on every map, use at own risk.")
        End If
    End Sub

    Private Sub RadioButton39_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton39.CheckedChanged
        If RadioButton39.Checked Then
            Label1.Text = ("This will allow you to kill as many units as you want without ending the game. This works for hunt as well.")
        End If
    End Sub

    Private Sub RadioButton40_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton40.CheckedChanged
        If RadioButton40.Checked Then
            Label1.Text = ("This increases the amount of items you can put on the battlefield but sadly it does not make them infinite. I'm trying to find a way to fix this currently.")
        End If
    End Sub

    Private Sub RadioButton41_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton41.CheckedChanged
        If RadioButton41.Checked Then
            Label1.Text = ("This changes the respawn timer to always stay at 1 second, making you instantly respawn. A map change is required for this to take effect.")
        End If
    End Sub

    Private Sub RadioButton42_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton42.CheckedChanged
        If RadioButton42.Checked Then
            Label1.Text = ("Fly allows the player to infinitly go up after jumping or hitting a slope. Unfortunately, there is no other way to go down other than disabling the hack. However, this is very useful for getting over walls.")
        End If
    End Sub

    Private Sub RadioButton43_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton43.CheckedChanged
        If RadioButton43.Checked = True Then
            Label1.Text = ("This feature will remove the map ceiling so you can go as high as you want on any map. A map change is required for this feature to take effect.")
        End If
    End Sub

    Private Sub RadioButton44_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton44.CheckedChanged
        If RadioButton44.Checked = True Then
            Label1.Text = ("This feature will cause your tank to respawn instantly after being destroyed.")
        End If
    End Sub

    Private Sub RadioButton45_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton45.CheckedChanged
        If RadioButton45.Checked = True Then
            Label1.Text = ("This feature disables the collision scale of all objects allowing the players and/or vehicles to fall from any height and not take any damage. A map change is required for this feature to take effect.")
        End If
    End Sub

    Private Sub RadioButton46_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton46.CheckedChanged
        If RadioButton46.Checked = True Then
            Label1.Text = ("This will cause your tanks boost speed to be exponentially faster than the original speed allowing you to cross the map in seconds.")
        End If
    End Sub
End Class
