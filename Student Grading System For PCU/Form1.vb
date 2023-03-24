
Public Class Login

    'LOGIN
    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = "admin" And txtPassword.Text = "admin") Then
            MsgBox("Welcome Admin", MsgBoxStyle.Information)
            AdminForm.Show()

        Else
            MsgBox("Incorrect Input", MsgBoxStyle.Exclamation)
        End If

    End Sub

    'Close Button
    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub



    'MOUSE EVENTS
    Private Sub btnLogin_MouseHover(sender As Object, e As EventArgs) Handles btnLogin.MouseHover
        btnLogin.BackColor = Color.DarkCyan
        btnLogin.ForeColor = Color.Lime
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.PaleTurquoise
        btnLogin.ForeColor = Color.Black
    End Sub

    Private Sub btnCancel_MouseHover(sender As Object, e As EventArgs) Handles btnCancel.MouseHover
        btnCancel.BackColor = Color.DarkCyan
        btnCancel.ForeColor = Color.Red
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackColor = Color.PaleTurquoise
        btnCancel.ForeColor = Color.Black
    End Sub

End Class
