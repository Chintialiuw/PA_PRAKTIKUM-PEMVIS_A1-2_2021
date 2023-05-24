Imports MySql.Data.MySqlClient
Imports System.Windows

Public Class StrukPemesanan
    Sub TampilDetailProduk()
        dgvProduk.Rows.Clear()

        Dim Produk As String
        Produk = "Select p.gambar, p.nama, dp.jumlah, dp.harga From produk p INNER JOIN detail_pesanan dp
                  ON (p.id = dp.id_produk) INNER JOIN pesanan ps ON (dp.id_pesanan = ps.id)
                  where ps.id = '" & lbID.Text & "'"
        CMD = New MySqlCommand(Produk, CONN)
        RD = CMD.ExecuteReader

        Do While RD.Read()
            dgvProduk.Rows.Add({
                       RD.Item("gambar"),
                       RD.Item("nama"),
                       RD.Item("jumlah"),
                       RD.Item("harga")
            })
        Loop
        RD.Close()
        dgvProduk.ClearSelection()
        dgvProduk.Refresh()
        dgvProduk.ReadOnly = True
    End Sub

    Sub AturGrid()
        dgvProduk.Columns(0).Width = 75
        dgvProduk.Columns(1).Width = 210
        dgvProduk.Columns(2).Width = 100
        dgvProduk.Columns(3).Width = 100
    End Sub

    Private Sub StrukPemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Owner = MainWindow

        Config.SetDeaultGrid(dgvProduk)

        If mode = "admin" Then
            lbStatus.Visible = False
            If lbStatus.Text.ToLower = "sedang dikemas" Then
                cmbStatus.SelectedIndex = 0
            Else
                cmbStatus.SelectedIndex = 1
            End If
        Else
            cmbStatus.Visible = False
            btnUpdate.Visible = False
        End If

        TampilDetailProduk()
        AturGrid()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        MainWindow.LblMode.Text = "(" + mode + ")"

        Dim Isi, Status As String
        Status = cmbStatus.SelectedIndex

        If Status = 0 Then
            Isi = "Sedang Dikemas"
        Else
            Isi = "Telah Terkirim"
        End If

        cmbStatus.Text = Isi

        Dim Ubah As String = "Update pesanan set
                              status_pesanan = '" & Isi & "' where id = '" & lbID.Text & "'"
        CMD = New MySqlCommand(Ubah, CONN)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Status Pesanan Berhasil Diubah", "Notifikasi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information)

        Me.Close()
        Call Pesanan.TampilDataAdmin()
    End Sub


End Class