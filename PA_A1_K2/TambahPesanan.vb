Imports MySql.Data.MySqlClient

Public Class TambahPesanan

    Private Sub SetGridProduk()
        SetDeaultGrid(GridProduk)

        With GridProduk
            .Columns(0).Visible = False
            .Columns(1).Width = 10 / 100 * .Size.Width   ' checkbox
            .Columns(2).Width = 13 / 100 * .Size.Width
            .Columns(3).Width = 37 / 100 * .Size.Width
            .Columns(4).Width = 25 / 100 * .Size.Width
            .Columns(5).Width = 15 / 100 * .Size.Width
            .RowTemplate.Height = 50
            .ReadOnly = True
        End With
    End Sub

    Private Sub Sinkronisasi()
        Dim query As String
        query = "SELECT * FROM users " +
                "WHERE username='" + username + "'"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        RD.Read()

        TxtPenerima.Text = RD.Item("nama")
        TxtUsername.Text = RD.Item("username")
        TxtAlamat.Text = RD.Item("alamat")
        TxtNoTelp.Text = RD.Item("telepon")

        RD.Close()
    End Sub

    Private Sub ClearForm()
        TxtPenerima.Clear()
        TxtAlamat.Clear()
        TxtNoTelp.Clear()
    End Sub

    Private Function GenerateID() As String
        Dim toko, tanggal, urutan, query As String

        toko = "GFF"
        tanggal = DateTime.Now.ToString("yyyyMMdd")

        query = "SELECT COUNT(tanggal) AS count FROM pesanan " +
                "WHERE DATE(tanggal)='" + DateTime.Now.ToString("yyyy-MM-dd") + "'"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        RD.Read()

        urutan = (Val(RD.Item("count")) + 1)

        RD.Close()

        Return toko + tanggal + urutan

    End Function


    ' -- FORM -----------------------------------------------------------------------------------------------

    ' Form - Load
    Private Sub TambahPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Owner = MainWindow

        TsMenu.Renderer = New MyRenderer()

        SetGridProduk()
        GridProduk.ClearSelection()

        Sinkronisasi()

    End Sub

    ' -- GRID -----------------------------------------------------------------------------------------------

    Private Sub GridProduk_Resize(sender As Object, e As EventArgs) Handles GridProduk.Resize
        If sender.RowCount > 0 Then SetGridProduk()
    End Sub


    ' -- BUTTON -----------------------------------------------------------------------------------------------

    Private Sub BtnSync_Click(sender As Object, e As EventArgs) Handles BtnSync.Click
        Sinkronisasi()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearForm()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Dim batal As String
        batal = MessageBox.Show(
            "Apakah Anda yakin ingin membatalkan pesanan?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If batal = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnPesan_Click(sender As Object, e As EventArgs) Handles BtnPesan.Click
        If (TxtPenerima.Text = vbNullString Or TxtNoTelp.Text = vbNullString Or TxtAlamat.Text = vbNullString) Then
            MessageBox.Show("Harap isikan keseluruhan data !", "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idPesanan, query As String

        idPesanan = GenerateID()
        query = "INSERT INTO pesanan VALUES ('" +
                idPesanan + "','" +
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                username + "','" +
                TxtTotal.Text.Split(" ")(1) + "','" +
                "Sedang Dikemas" + "','" +
                TxtPenerima.Text + "','" +
                TxtNoTelp.Text + "','" +
                TxtAlamat.Text + "')"
        CMD = New MySqlCommand(query, CONN)
        CMD.ExecuteNonQuery()

        For Each row In GridProduk.Rows
            Dim idProduk, jumlahProduk, hargaProduk As Integer

            idProduk = row.Cells(0).Value
            jumlahProduk = row.Cells(5).Value
            hargaProduk = row.Cells(4).Value

            ' pesan tanaman
            query = "INSERT INTO detail_pesanan VALUES ('" +
                    idPesanan + "','" +
                    idProduk.ToString() + "','" +
                    jumlahProduk.ToString() + "','" +
                    hargaProduk.ToString() + "')"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()

            ' kurangi stok
            query = "UPDATE produk SET " +
                    "stok = (" +
                        "(SELECT stok FROM produk WHERE id='" + idProduk.ToString() + "') - " + jumlahProduk.ToString() + ") " +
                    "WHERE id='" + idProduk.ToString() + "'"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()

            ' hapus dari keranjang
            query = "DELETE FROM keranjang " +
                    "WHERE username='" + username + "' " +
                    "AND id_produk='" + row.Cells(0).Value.ToString() + "'"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()

        Next

        Keranjang.LoadTanaman()
        MessageBox.Show(
            "Pesanan berhasil dibuat!" & vbCrLf & "Pantau pesanan pada halaman pesanan.",
            "Info",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        Me.Close()
    End Sub


    ' -- TEXTBOX -----------------------------------------------------------------------------------------------

    Private Sub TxtPenerima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPenerima.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TxtNoTelp.Focus()
        End If
    End Sub

    Private Sub TxtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNoTelp.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TxtAlamat.Focus()
        End If

        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAlamat.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BtnPesan.Focus()
        End If
    End Sub
End Class