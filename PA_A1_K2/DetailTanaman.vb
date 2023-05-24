Imports MySql.Data.MySqlClient

Public Class DetailTanaman

    Public Sub LoadData()
        Dim query As String
        query = "SELECT * FROM produk " +
                "WHERE id='" + Me.Name + "'"

        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        While (RD.Read())
            PicBoxGambar.Image = ByteToImg(RD.Item("gambar"))
            Text = RD.Item("nama")
            TxtNama.Text = RD.Item("nama")
            TxtJenis.Text = StrConv(RD.Item("jenis"), VbStrConv.ProperCase)
            TxtHarga.Text = "Rp " & RD.Item("harga")
            TxtTinggi.Text = RD.Item("tinggi") & " cm"
            TxtBerat.Text = RD.Item("berat") & " g"
            TxtDeskripsi.Text = RD.Item("deskripsi")
            TxtStok.Text = RD.Item("stok")
        End While

        RD.Close()
    End Sub

    ' -- FORM -----------------------------------------------------------------------------------------------

    Private Sub Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Owner = MainWindow

        TsMenu.Renderer = New MyRenderer()

        If mode = "admin" Then
            BtnKeranjang.Visible = False
            TxtJumlah.Visible = False
        Else
            BtnEdit.Visible = False
            BtnHapus.Visible = False
        End If

        LoadData()

        If Val(TxtStok.Text) = 0 Then
            BtnKeranjang.Enabled = False
        End If
    End Sub


    ' -- BUTTON -----------------------------------------------------------------------------------------------

    ' hapus tanaman
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim hapus As String,
            query As String
        hapus = MessageBox.Show(
            "Apakah Anda yakin ingin menghapus" & vbCrLf & "produk ini?",
            "Peringatan",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning
        )

        If hapus = DialogResult.OK Then
            query = "DELETE FROM produk " &
                    "WHERE id='" & Me.Name & "'"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show(
                "Produk telah berhasil dihapus!",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LihatTanaman.Close()
            SwitchPage(LihatTanaman)

            Me.Close()
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ' buka halaman edit
        TambahTanaman.Name = Me.Name
        TambahTanaman.Edit = True
        TambahTanaman.Show()
    End Sub

    ' Keranjang - Click
    Private Sub BtnKeranjang_Click(sender As Object, e As EventArgs) Handles BtnKeranjang.Click
        InsertToKeranjang(Me.Name, TxtJumlah.Text)
        MessageBox.Show(
            "Produk berhasil ditambahkan ke keranjang!",
            "Info",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
        Me.Close()
    End Sub

    ' -- TEXTBOX -------------------------------------------------------------------------------------------------

    ' Jumlah - KeyPress
    Private Sub TxtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJumlah.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' Jumlah - KeyUp
    Private Sub TxtJumlah_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtJumlah.KeyUp
        If Val(sender.Text) > Val(TxtStok.Text) Then
            sender.Text = TxtStok.Text
        End If

    End Sub

    ' Jumlah - LostFocus
    Private Sub TxtJumlah_LostFocus(sender As Object, e As EventArgs) Handles TxtJumlah.LostFocus
        If Val(sender.Text) < 1 Then
            sender.Text = 1
        End If
    End Sub

End Class