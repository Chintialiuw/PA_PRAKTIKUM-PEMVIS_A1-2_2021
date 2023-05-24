Imports MySql.Data.MySqlClient

Public Class LoginAdmin
    Private Sub LoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        CMD = New MySqlCommand("Select * From admin where username='" & txtUser.Text & "' and psw='" & txtPass.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            RD.Close()

            Me.Visible = False
            username = txtUser.Text
            mode = "admin"

            Me.Owner = MainWindow
            MainWindow.Show()

        ElseIf Not RD.HasRows Then
            RD.Close()

            MessageBox.Show("Periksa kembali username dan password", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUser.Focus()
            txtUser.Text = ""
            txtPass.Text = ""
        End If

    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Me.Close()
        LoginUser.Location = Me.Location
        LoginUser.Show()
    End Sub

    Private Sub LoginAdmin_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        LoginUser.Show()
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtPass.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin.Focus()
            e.Handled = True
        End If
    End Sub
End Class