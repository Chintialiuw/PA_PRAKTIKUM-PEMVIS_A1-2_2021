Imports MySql.Data.MySqlClient

Public Class Keranjang

    ' atur tampilan grid
    Private Sub SetGridKeranjang()
        SetDeaultGrid(GridKeranjang)

        With GridKeranjang
            .Columns(0).Visible = False                 ' id
            .Columns(1).Width = 7 / 100 * .Size.Width   ' checkbox
            .Columns(2).Width = 10 / 100 * .Size.Width  ' gambar
            .Columns(3).Width = 45 / 100 * .Size.Width  ' produk
            .Columns(4).Width = 20 / 100 * .Size.Width  ' harga
            .Columns(5).Width = 14 / 100 * .Size.Width  ' jumlah
            .RowTemplate.Height = 50
        End With
    End Sub

    ' tampilkan tanaman di keranjang
    Public Sub LoadTanaman()
        GridKeranjang.Rows.Clear()

        Dim query As String
        query = "SELECT p.id, p.gambar, p.nama, p.harga, k.jumlah FROM keranjang k " &
                "INNER JOIN produk p " &
                "ON (k.id_produk = p.id) " &
                "WHERE username='" & username & "'"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        Do While RD.Read()
            GridKeranjang.Rows.Add({
                RD.Item("id"),
                False,
                RD.Item("gambar"),
                RD.Item("nama"),
                RD.Item("harga"),
                RD.Item("jumlah")
            })
        Loop

        RD.Close()
        GridKeranjang.ClearSelection()

    End Sub

    Private Sub RefreshStok()

        Dim id, jumlah, stok As Integer
        Dim query As String

        For Each row In GridKeranjang.Rows
            id = row.Cells("ColID").Value
            jumlah = row.Cells("ColJumlah").Value

            query = "SELECT stok FROM produk " +
                    "WHERE id='" & id & "'"
            CMD = New MySqlCommand(query, CONN)
            RD = CMD.ExecuteReader()
            RD.Read()
            stok = RD.Item("stok")
            RD.Close()

            If jumlah > stok Then

                If stok = 0 Then
                    ' jika stok kosong, hapus dari keranjang
                    query = "DELETE FROM keranjang " +
                            "WHERE username='" + username + "' " +
                            "AND id_produk='" & id & "'"

                Else
                    ' samakan jumlah dengan stok produk
                    query = "UPDATE keranjang SET " +
                        "jumlah='" & stok & "' " +
                        "WHERE username='" + username + "' " +
                        "AND id_produk='" & id & "'"
                End If

                CMD = New MySqlCommand(query, CONN)
                CMD.ExecuteNonQuery()
            End If



            LoadTanaman()
        Next

    End Sub


    ' -- FORM -----------------------------------------------------------------------------------------------

    ' Form - Load
    Private Sub Keranjang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TsMenu.Renderer = New MyRenderer()

        BtnHapus.Visible = False
        BtnPesan.Enabled = False
        MainWindow.LblStatus.Visible = False

        SetGridKeranjang()
        LoadTanaman()
        RefreshStok()

    End Sub


    ' -- BUTTON -----------------------------------------------------------------------------------------------

    ' Pesan - Click
    Private Sub BtnPesan_Click(sender As Object, e As EventArgs) Handles BtnPesan.Click

        For Each row In GridKeranjang.Rows
            If row.Cells("ColPilih").Value = True Then
                TambahPesanan.GridProduk.Rows.Add({
                    row.Cells("ColID").Value,
                    TambahPesanan.GridProduk.RowCount + 1 & ".",
                    row.Cells("ColGambar").Value,
                    row.Cells("ColProduk").Value,
                    row.Cells("ColHarga").Value,
                    row.Cells("ColJumlah").Value
                })
            End If
        Next

        TambahPesanan.TxtTotal.Text = TxtTotal.Text
        TambahPesanan.Show()
    End Sub

    ' Pilih - Click
    Private Sub BtnPilih_Click(sender As Object, e As EventArgs) Handles BtnPilih.Click
        If sender.Text = "Pilih Semua" Then
            For Each row In GridKeranjang.Rows
                row.Cells("ColPilih").Value = True
            Next
        Else
            For Each row In GridKeranjang.Rows
                row.Cells("ColPilih").Value = False
            Next
            GridKeranjang.ClearSelection()
        End If
    End Sub

    ' Hapus - Click
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim query As String

        For Each row In GridKeranjang.Rows
            If row.Cells("ColPilih").Value = True Then
                query = "DELETE FROM keranjang " &
                        "WHERE username='" & username & "'" &
                        "AND id_produk='" & row.Cells("ColID").Value & "'"
                CMD = New MySqlCommand(query, CONN)
                CMD.ExecuteNonQuery()
            End If
        Next

        LoadTanaman()
        BtnHapus.Visible = False
    End Sub

    ' -- TEXTBOX -------------------------------------------------------------------------------------------------

    Private Sub CellJumlah_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' -- GRID -------------------------------------------------------------------------------------------------

    ' Grid - Resize
    Private Sub GridKeranjang_Resize(sender As Object, e As EventArgs) Handles GridKeranjang.Resize
        If sender.RowCount > 0 Then SetGridKeranjang()
    End Sub

    ' Grid - CellMouseClick
    Private Sub GridKeranjang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GridKeranjang.CellMouseClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then

            Dim chkCell = sender.Rows(e.RowIndex).Cells("ColPilih")

            If chkCell.Value = False Then
                chkCell.Value = True

            Else
                chkCell.Value = False
                sender.ClearSelection()
            End If

        End If
    End Sub

    ' Grid - CellValueChanged
    Private Sub GridKeranjang_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles GridKeranjang.CellValueChanged

        ' cell jumlah diubah -----------------------------------------
        If e.RowIndex >= 0 And e.ColumnIndex = 5 Then

            With sender.Rows(e.RowIndex)

                Dim query As String
                Dim idProduk, jumlahProduk, stokProduk As Integer

                idProduk = .Cells("ColID").Value
                jumlahProduk = .Cells("ColJumlah").Value

                'ambil stok
                query = "SELECT stok FROM produk " +
                        "WHERE id='" & idProduk & "'"
                CMD = New MySqlCommand(query, CONN)
                RD = CMD.ExecuteReader()

                RD.Read()
                stokProduk = RD.Item("stok")
                RD.Close()

                If jumlahProduk = 0 Then
                    query = "DELETE FROM keranjang " +
                            "WHERE username='" + username + "' " +
                            "AND id_produk='" & idProduk & "'"
                    CMD = New MySqlCommand(query, CONN)
                    CMD.ExecuteNonQuery()

                    LoadTanaman()
                    Exit Sub

                ElseIf jumlahProduk > stokProduk Then
                    jumlahProduk = stokProduk

                End If

                query = "UPDATE keranjang SET " +
                        "jumlah='" & jumlahProduk & "' " +
                        "WHERE id_produk='" & idProduk & "' " +
                        "AND username='" & username & "'"
                CMD = New MySqlCommand(query, CONN)
                CMD.ExecuteNonQuery()

            End With

            LoadTanaman()
        End If

        ' cell checkbox diubah ---------------------------------------
        Dim selected As Integer,
            total As Integer

        ' hitung produk yg di-select
        total = 0
        For Each row In sender.Rows
            If row.Cells("ColPilih").Value = True Then
                selected += 1
                total += Val(row.Cells("ColHarga").Value) * Val(row.Cells("ColJumlah").Value)
                row.DefaultCellStyle.BackColor = C_SELECT
            Else
                row.DefaultCellStyle.BackColor = Color.White
            End If
        Next

        ' cell select diubah
        If selected > 0 Then
            BtnHapus.Visible = True
            BtnPilih.Text = "Batal"
            BtnPesan.Enabled = True

            MainWindow.LblStatus.Text = selected & " dipilih"
            MainWindow.LblStatus.Visible = True
        Else
            BtnHapus.Visible = False
            BtnPilih.Text = "Pilih Semua"
            BtnPesan.Enabled = False
            MainWindow.LblStatus.Visible = False
        End If

        ' ubah total pembayaran
        TxtTotal.Text = "Rp " & total
    End Sub

    ' Grid - CellMouseDoubleClick
    Private Sub GridKeranjang_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GridKeranjang.CellMouseDoubleClick

        If Not e.ColumnIndex = 5 Then

            Dim idCell = sender.Rows(e.RowIndex).Cells("ColID")

            If DetailTanaman.IsHandleCreated Then
                DetailTanaman.Close()
            End If

            DetailTanaman.BtnKeranjang.Visible = False
            DetailTanaman.TxtJumlah.Visible = False
            DetailTanaman.Name = idCell.Value
            DetailTanaman.Show()

        End If
    End Sub

    ' Grid - EditingControlShowing
    Private Sub GridKeranjang_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GridKeranjang.EditingControlShowing

        If GridKeranjang.CurrentCell.ColumnIndex = 5 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf CellJumlah_KeyPress
        End If

    End Sub

End Class