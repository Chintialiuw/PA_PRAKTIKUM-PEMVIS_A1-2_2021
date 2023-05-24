Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports MySql.Data.MySqlClient

Public Class Pesanan
    Private Sub Pesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TsMenu.Renderer = New MyRenderer()
        Config.SetDeaultGrid(dgvRiwayatPemesanan)

        If mode = "admin" Then
            TampilDataAdmin()
            AturGrid()
        Else
            TampilDataUser()
            AturGrid()
        End If
    End Sub

    Sub TampilDataAdmin()
        DA = New MySqlDataAdapter("Select * From pesanan order by status_pesanan, tanggal", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "pesanan")
        dgvRiwayatPemesanan.DataSource = DS.Tables("pesanan")
        dgvRiwayatPemesanan.Refresh()
    End Sub

    Sub TampilDataUser()
        DA = New MySqlDataAdapter("Select * From pesanan where username='" & MainWindow.LblUsername.Text & "' order by status_pesanan, tanggal", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "pesanan")
        dgvRiwayatPemesanan.DataSource = DS.Tables("pesanan")
        dgvRiwayatPemesanan.Refresh()
    End Sub

    Sub AturGrid()
        dgvRiwayatPemesanan.Columns(0).Width = 200
        dgvRiwayatPemesanan.Columns(1).Width = 200
        dgvRiwayatPemesanan.Columns(2).Width = 100
        dgvRiwayatPemesanan.Columns(3).Width = 200
        dgvRiwayatPemesanan.Columns(4).Width = 200
        dgvRiwayatPemesanan.Columns(5).Width = 200
        dgvRiwayatPemesanan.Columns(6).Width = 100
        dgvRiwayatPemesanan.Columns(7).Width = 300

        dgvRiwayatPemesanan.Columns(0).HeaderText = "ID"
        dgvRiwayatPemesanan.Columns(1).HeaderText = "Tanggal"
        dgvRiwayatPemesanan.Columns(2).HeaderText = "Username"
        dgvRiwayatPemesanan.Columns(3).HeaderText = "Total Pembayaran"
        dgvRiwayatPemesanan.Columns(4).HeaderText = "Status Pesanan"
        dgvRiwayatPemesanan.Columns(5).HeaderText = "Nama Penerima"
        dgvRiwayatPemesanan.Columns(6).HeaderText = "Telepon Penerima"
        dgvRiwayatPemesanan.Columns(7).HeaderText = "Alamat Penerima"

        dgvRiwayatPemesanan.Columns(2).Visible = False
        dgvRiwayatPemesanan.Columns(5).Visible = False
        dgvRiwayatPemesanan.Columns(6).Visible = False
        dgvRiwayatPemesanan.Columns(7).Visible = False

        dgvRiwayatPemesanan.ReadOnly = True
    End Sub

    Private Sub dgvRiwayatPemesanan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRiwayatPemesanan.CellContentClick
        ' jika sedang terbuka
        If StrukPemesanan.IsHandleCreated Then
            StrukPemesanan.Close()
        End If

        Dim i As Integer
        i = Me.dgvRiwayatPemesanan.CurrentRow.Index
        With dgvRiwayatPemesanan.Rows(i)
            StrukPemesanan.lbID.Text = .Cells(0).Value
            StrukPemesanan.lbTanggal.Text = .Cells(1).Value
            StrukPemesanan.lbUser.Text = .Cells(2).Value
            StrukPemesanan.lbTotal.Text = "Rp " & .Cells(3).Value
            StrukPemesanan.lbStatus.Text = .Cells(4).Value
            StrukPemesanan.lbNama.Text = .Cells(5).Value
            StrukPemesanan.lbTelp.Text = .Cells(6).Value
            StrukPemesanan.lbAlamat.Text = .Cells(7).Value
        End With

        StrukPemesanan.Show()
    End Sub

End Class