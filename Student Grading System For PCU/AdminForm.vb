Public Class AdminForm


    'MOUSE EVENTS
    Private Sub btnRecord_MouseHover(sender As Object, e As EventArgs) Handles btnRecord.MouseHover
        btnRecord.BackColor = Color.FromArgb(149, 209, 204)
    End Sub

    Private Sub btnRecord_MouseLeave(sender As Object, e As EventArgs) Handles btnRecord.MouseLeave
        btnRecord.BackColor = Color.FromArgb(85, 132, 172)
    End Sub

    Private Sub btnLogout_MouseHover(sender As Object, e As EventArgs) Handles btnLogout.MouseHover
        btnLogout.BackColor = Color.FromArgb(149, 209, 204)
        btnLogout.ForeColor = Color.Red
    End Sub

    Private Sub btnLogout_MouseLeave(sender As Object, e As EventArgs) Handles btnLogout.MouseLeave
        btnLogout.ForeColor = Color.White
        btnLogout.BackColor = Color.FromArgb(85, 132, 172)
    End Sub


    'SHOW PANEL
    Sub switchPanel(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel3.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        switchPanel(Record)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        switchPanel(PCU)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        switchPanel(Home)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Dispose()
    End Sub



End Class