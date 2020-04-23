Public NotInheritable Class setkey
    Public key As String
    Private Sub setkey_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Me.KeyPreview = True
        key = e.KeyChar.ToString()
        Form1.teleport.Text = "Teleport To Crosshair = " & key
        System.Threading.Thread.Sleep(200)
        Close()
    End Sub

    Private Sub setkey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
