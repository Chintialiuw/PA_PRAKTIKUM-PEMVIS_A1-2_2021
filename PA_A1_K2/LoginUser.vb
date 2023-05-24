Imports MySql.Data.MySqlClient

Public Class LoginUser

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not ConnectToDB() Then End

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        CMD = New MySqlCommand("Select * From users where username='" & txtUser.Text & "' and psw='" & txtPass.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            RD.Close()

            Me.Visible = False
            username = txtUser.Text
            mode = "user"

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

    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click
        Registrasi.Location = Me.Location
        Registrasi.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdm_Click(sender As Object, e As EventArgs) Handles btnAdm.Click
        LoginAdmin.Location = Me.Location
        LoginAdmin.Show()
        Me.Hide()
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