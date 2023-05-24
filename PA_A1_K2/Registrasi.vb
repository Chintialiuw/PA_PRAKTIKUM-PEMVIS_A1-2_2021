
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Windows
Imports MySql.Data.MySqlClient

Public Class Registrasi
    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click
        If Not IsNumeric(txtTelp.Text) Then
            MsgBox("masukan angka")
            Return
        End If

        'Mengecek apakah semua field sudah diisi
        If txtUsername.Text = "" Or
            txtName.Text = "" Or
            txtPass.Text = "" Or
            txtTelp.Text = "" Or
            txtAlamat.Text = "" Then
            lblError.Text = "Jangan ada yang di Kosongin yakk hehe"
            Return
        End If

        'Mengecek apakah username sudah ada di database
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM users WHERE username ='" & txtUsername.Text & "'", CONN)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        reader.Read()
        If reader.HasRows Then
            reader.Close()
            lblError.Text = "Username sudah terdaftar!"
            Return
        End If
        reader.Close()

        'Menambahkan user baru ke database
        Dim simpan As String = "INSERT INTO users (username, nama, psw, telepon, alamat) VALUES (
                                                   '" & txtUsername.Text & "','" & txtName.Text & "',
                                                   '" & txtPass.Text & "','" & txtTelp.Text & "','" & txtAlamat.Text & "')"

        cmd = New MySqlCommand(simpan, CONN)
        cmd.ExecuteNonQuery()
        'Menampilkan pesan sukses
        MessageBox.Show("Registrasi berhasil!")

        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtName.Clear()
        txtPass.Clear()
        txtTelp.Clear()
        txtAlamat.Clear()
    End Sub

    Sub Clear()
        txtUsername.Text = ""
        txtName.Text = ""
        txtPass.Text = ""
        txtTelp.Text = ""
        txtAlamat.Text = ""
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Hide()
        LoginUser.Show()
    End Sub

    Private Sub Registrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblError.Text = ""
    End Sub

    Private Sub Registrasi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LoginUser.Show()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtName.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtPass.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtTelp.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            txtAlamat.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlamat.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnRegist.Focus()
            e.Handled = True
        End If
    End Sub
End Class