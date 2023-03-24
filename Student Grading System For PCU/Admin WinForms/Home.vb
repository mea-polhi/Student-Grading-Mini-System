Public Class Home

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datelbl.Text = Date.Now.ToString("dd/MM/yyy")
        timelbl.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

End Class