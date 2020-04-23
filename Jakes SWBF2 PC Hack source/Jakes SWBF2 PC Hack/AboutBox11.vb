Public NotInheritable Class AboutBox11

    Private Sub AboutBox11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "Enabling this hack will disable the bothans ability to turn invisible. (your screen only)"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "This hack has an unwanted side effect. There are two different ways to enable this hack. If you enable this hack before the game starts, all command posts will be white when the map loads and stay white for the entire round. (unless disabled). When they are white you will be able to swap units at enemy or friendly cp's but you won't know which is which. If you enable this hack when the map is already loaded, the command posts will stay the color at the time of enabling for the rest of the map. You will also not be able to switch units at any cp! No matter which way you choose to enable this hack, you will be able to see all enemy name tags."
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label1.Text = "Simply enable this hack, then enter a command post. You will be able to move anywhere and switch units at any time!"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs)
        Label1.Text = "Enabling this will restore the sniper rifle reticle."
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Label1.Text = "This will allow you to view the health bar of anything your reticle points at, even if it is behind a wall or across the map! It also shows the nametag of the player if the reticle is pointed at one."
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Label1.Text = "This hack extends the unit swap radius to 682 (999 is max). Now that sounds big but unfortunately it does not extend as far out as you would think it would. A map change is required for this feature to take effect."
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        Label1.Text = "This changes the kills tab to show the player number of everybody on the server. It starts at 0 so if you want to take admin action on a player, add 1 to their player number shown in the kills tab."
    End Sub
End Class
