Imports MySql.Data.MySqlClient

Public Class MainWindow

    ' -- FORM -----------------------------------------------------------------------------------------------

    ' Form - Load
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MsMenu.Renderer = New MyRenderer()
        SsMenu.Renderer = New MyRenderer()

        LblStatus.Visible = False
        LblMode.Text = "(" + mode + ")"
        LblUsername.Text = username

        If mode = "admin" Then
            MenuKeranjang.Visible = False
            MenuProfile.Visible = False
        Else
            MenuUsers.Visible = False
            MenuTanaman.DropDownItems.Clear()
            AddHandler MenuTanaman.Click, AddressOf MenuLihat_Click
        End If

        ' buka halaman lihat tanaman
        SwitchPage(LihatTanaman)

    End Sub

    ' -- MENU -----------------------------------------------------------------------------------------------

    Private Sub MenuTambah_Click(sender As Object, e As EventArgs) Handles MenuTambah.Click
        ' buka halaman tambah
        TambahTanaman.Edit = False
        TambahTanaman.Show()
    End Sub

    ' buka halaman lihat
    Private Sub MenuLihat_Click(sender As Object, e As EventArgs) Handles MenuLihat.Click
        SwitchPage(LihatTanaman)
    End Sub

    ' buka halaman pesanan
    Private Sub MenuPesanan_Click(sender As Object, e As EventArgs) Handles MenuPesanan.Click
        SwitchPage(Pesanan)
    End Sub

    ' buka halaman users
    Private Sub MenuUsers_Click(sender As Object, e As EventArgs) Handles MenuUsers.Click
        SwitchPage(Users)
    End Sub

    ' buka halaman keranjang
    Private Sub MenuKeranjang_Click(sender As Object, e As EventArgs) Handles MenuKeranjang.Click
        SwitchPage(Keranjang)
    End Sub

    ' buka halaman profile
    Private Sub MenuProfile_Click(sender As Object, e As EventArgs) Handles MenuProfile.Click
        SwitchPage(Profile)
    End Sub

    ' keluar akun
    Private Sub MenuLogOut_Click(sender As Object, e As EventArgs) Handles MenuLogOut.Click
        MessageBox.Show(
            "Terima kasih telah menggunakan program!",
            "Pemberitahuan",
            MessageBoxButtons.OK,
            MessageBoxIcon.None
        )

        username = ""
        mode = ""

        LoginUser.Owner = Nothing
        LoginUser.Show()

        LoginUser.txtUser.Clear()
        LoginUser.txtPass.Clear()
        LoginUser.txtUser.Focus()

        Me.Close()

    End Sub

    ' keluar program
    Private Sub MenuKeluar_Click(sender As Object, e As EventArgs) Handles MenuKeluar.Click

        Dim keluar As String
        keluar = MessageBox.Show(
            "Apakah Anda yakin ingin keluar dari program?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If keluar = MsgBoxResult.Yes Then
            End
        End If
    End Sub

End Class
