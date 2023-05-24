Imports System.Data.SqlClient
Imports System.Windows.Forms.AxHost
Imports MySql.Data.MySqlClient
Public Class Profile

    Dim mode = "read",
        pwRaw = ""

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LihatProfil()
        MainWindow.LblStatus.Visible = True
        MainWindow.LblStatus.Text = "Lihat Profile"

        PanelEdit.Hide()
        BtnBatal.Visible = False
        BtnSync.Visible = False
    End Sub

    Private Sub LihatProfil()
        CMD = New MySqlCommand("select * from users where username = '" & username & "'", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()

        If RD.HasRows Then
            'MsgBox("Profil Anda")

            lblUser.Text = RD(0).ToString()
            lblNama.Text = RD(1).ToString()
            pwRaw = RD(2).ToString()

            Dim pwEnkripsi As String = ""
            For Each ch In pwRaw
                pwEnkripsi += "*"
            Next

            lblPass.Text = pwEnkripsi
            lblNo.Text = RD(3).ToString()
            lblAlamat.Text = RD(4).ToString()

        End If

        RD.Close()

    End Sub

    Private Sub SwitchMode(ByRef mode As String)
        If mode = "edit" Then
            mode = "read"
            LihatProfil()
            PanelLihat.Show()
            PanelEdit.Hide()
            MainWindow.LblStatus.Text = "Lihat Profile"
            BtnBatal.Visible = False
            BtnSync.Visible = False
        Else
            mode = "edit"
            PanelLihat.Hide()
            PanelEdit.Show()
            MainWindow.LblStatus.Text = "Edit Profile"
            BtnBatal.Visible = True
            BtnSync.Visible = True
            PanelEdit.BringToFront()
        End If
    End Sub

    Private Sub LoadData()
        TxtNama.Text = lblNama.Text
        TxtAlamat.Text = lblAlamat.Text
        TxtNoHP.Text = lblNo.Text
        TxtPassword.Text = pwRaw
        LblUsername.Text = lblUser.Text
        TxtNama.Focus()
    End Sub

    Private Function IsCompleted()
        If TxtNama.Text = vbNullString Or
            TxtPassword.Text = vbNullString Or
            TxtNoHP.Text = vbNullString Or
            TxtAlamat.Text = vbNullString Or
            TxtNama.Text = lblNama.Text And
            TxtPassword.Text = pwRaw And
            TxtNoHP.Text = lblNo.Text And
            TxtAlamat.Text = lblAlamat.Text Then

            Return False
        End If

        Return True
    End Function

    Private Sub ActivatedSimpan()
        If IsCompleted() Then
            BtnSimpan.Enabled = True
        Else
            BtnSimpan.Enabled = False
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        SwitchMode(mode)
        LoadData()

        For Each txt In PanelEdit.Controls.OfType(Of TextBox)
            AddHandler txt.TextChanged, AddressOf ActivatedSimpan
        Next

        BtnSimpan.Enabled = False
        TxtNama.Focus()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim ubah As String
        ubah = "UPDATE users SET " +
                "nama='" + TxtNama.Text + "'," +
                "psw='" + TxtPassword.Text + "'," +
                "telepon='" + TxtNoHP.Text + "'," +
                "alamat='" + TxtAlamat.Text + "' " +
                "WHERE username='" + username + "'"
        CMD = New MySqlCommand(ubah, CONN)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Data Berhasil diubah", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SwitchMode(mode)
    End Sub

    Private Sub BtnSync_Click(sender As Object, e As EventArgs) Handles BtnSync.Click
        LoadData()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Dim batal As String
        batal = MessageBox.Show(
            "Apakah Anda yakin ingin membatalkan perubahan?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If batal = MsgBoxResult.Yes Then
            SwitchMode(mode)
        End If

    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TxtPassword.Focus()
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TxtAlamat.Focus()
        End If
    End Sub

    Private Sub TxtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAlamat.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnSimpan.Focus()
        End If
    End Sub

    Private Sub TxtNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNoHP.KeyPress
        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnSimpan.Focus()
        End If
    End Sub


End Class