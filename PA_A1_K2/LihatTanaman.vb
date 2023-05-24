Imports MySql.Data.MySqlClient

Public Class LihatTanaman
    ' ASLI

    ' buka halaman detail
    Private Sub OpenDetailTanaman(sender As Object, e As EventArgs)

        ' jika sedang terbuka
        If DetailTanaman.IsHandleCreated Then
            DetailTanaman.Close()
        End If

        DetailTanaman.Name = sender.Name
        DetailTanaman.Show()

    End Sub

    ' pilih tanaman
    Private Sub SelectTanaman(sender As Object, e As EventArgs)
        With sender.FlatAppearance

            If .BorderColor = Color.Silver Then
                sender.Tag = "selected"
                sender.BackColor = C_SELECT
                .BorderColor = Color.Teal
            Else
                sender.Tag = ""
                sender.BackColor = Color.White
                .BorderColor = Color.Silver
            End If

            Dim selected As Integer = 0
            For Each tanaman In ContainerTanaman.Controls.OfType(Of Button)
                selected = IIf(tanaman.Tag = "selected", selected + 1, selected)
            Next

            If mode = "admin" Then
                BtnHapus.Visible = IIf(selected > 0, True, False)
                BtnEdit.Visible = IIf(selected = 1, True, False)
            Else
                BtnKeranjang.Visible = IIf(selected > 0, True, False)
            End If

            MainWindow.LblStatus.Text = selected & " dipilih"
        End With
    End Sub

    ' unselect pilihan tanaman
    Private Sub UnselectAll()
        For Each tanaman In ContainerTanaman.Controls.OfType(Of Button)
            tanaman.FlatAppearance.BorderColor = Color.Silver
            tanaman.BackColor = Color.White
            tanaman.Tag = ""
        Next

        BtnEdit.Visible = False
        BtnHapus.Visible = False
        BtnKeranjang.Visible = False
        BtnPilih.Text = "Pilih"
        MainWindow.LblStatus.Visible = False
        MainWindow.LblStatus.Text = "0 dipilih"
    End Sub

    ' tampilkan tanaman
    Public Sub LoadTanaman(query As String)
        ContainerTanaman.Controls.Clear()

        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        Do While (RD.Read())
            Dim tanaman As New Button

            With tanaman
                .Font = New Drawing.Font("Verdana", 8)
                .Size = New Size(145, 200)

                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 1
                .FlatAppearance.BorderColor = Color.Silver

                .Padding = New Padding(3, 0, 3, 0)
                .Margin = New Padding(11, 0, 0, 10)

                Dim img As Image
                img = ByteToImg(RD.Item("gambar"))
                img = ResizeImg(img, 128, 128)

                .Image = img
                .ImageAlign = ContentAlignment.TopLeft

                .TextImageRelation = TextImageRelation.ImageAboveText
                .TextAlign = ContentAlignment.TopLeft

                .Name = RD.Item("id")
                .Text = vbCrLf + RD.Item("nama") + vbCrLf + "Rp " + RD.Item("harga").ToString()

                ' tambahkan event ke tiap-tiap tanaman
                AddHandler .Click, AddressOf OpenDetailTanaman

            End With

            ContainerTanaman.Controls.Add(tanaman)
        Loop
        RD.Close()


    End Sub

    Public Sub ResetFilter()
        TxtSearch.Clear()
        CbBoxJenis.SelectedIndex = 0
        CbBoxSort.SelectedIndex = 0
    End Sub


    ' -- FORM -----------------------------------------------------------------------------------------------

    ' Form - Load
    Private Sub LihatTanaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopLevel = False

        TsMenu.Renderer = New MyRenderer()

        BtnEdit.Visible = False
        BtnHapus.Visible = False
        BtnKeranjang.Visible = False
        MainWindow.LblStatus.Visible = False

        'BtnPilih.Visible = False

        CbBoxJenis.Items.Add("Semua")
        CbBoxJenis.Items.Add("Tanaman Hias")
        CbBoxJenis.Items.Add("Tanaman Buah")
        CbBoxJenis.Items.Add("Benih Tanaman")

        CbBoxSort.Items.Add("Nama ASC")
        CbBoxSort.Items.Add("Nama DESC")
        CbBoxSort.Items.Add("Harga ASC")
        CbBoxSort.Items.Add("Harga DESC")

        CbBoxSort.SelectedIndex = 0
        CbBoxJenis.SelectedIndex = 0

        ' produk yg tersedia
        LoadTanaman(
            "SELECT * FROM produk " +
            "ORDER BY " + CbBoxSort.Text
        )
    End Sub

    ' -- BUTTON -----------------------------------------------------------------------------------------------

    ' Pilih - Click
    Private Sub BtnPilih_Click(sender As Object, e As EventArgs) Handles BtnPilih.Click
        sender.Text = IIf(sender.Text = "Pilih", "Batal", "Pilih")

        For Each tanaman In ContainerTanaman.Controls.OfType(Of Button)
            If sender.Text = "Batal" Then
                MainWindow.LblStatus.Visible = True
                RemoveHandler tanaman.Click, AddressOf OpenDetailTanaman
                AddHandler tanaman.Click, AddressOf SelectTanaman
            Else
                UnselectAll()
                RemoveHandler tanaman.Click, AddressOf SelectTanaman
                AddHandler tanaman.Click, AddressOf OpenDetailTanaman
            End If
        Next

    End Sub

    ' Hapus - Click
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        Dim hapus As String,
            query As String

        hapus = MessageBox.Show(
            "Apakah Anda yakin ingin menghapus " & vbCrLf & "produk yang dipilih?",
            "Peringatan",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning
        )

        ' hapus tanaman
        If hapus = MsgBoxResult.Ok Then

            For Each tanaman In ContainerTanaman.Controls.OfType(Of Button)
                If tanaman.Tag = "selected" Then

                    query = "DELETE FROM produk " &
                            "WHERE id='" & tanaman.Name & "'"
                    CMD = New MySqlCommand(query, CONN)
                    CMD.ExecuteNonQuery()

                End If
            Next

            MessageBox.Show(
                "Produk telah berhasil dihapus!",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LoadTanaman(
                "SELECT * FROM produk " &
                IIf(CbBoxJenis.Text = "Semua", "", "WHERE jenis='" & CbBoxJenis.Text & "' ") &
                "ORDER BY " & CbBoxSort.Text
            )
        End If

    End Sub

    ' Edit - Click
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ' buka halaman edit tanaman
        For Each tanaman In ContainerTanaman.Controls.OfType(Of Button)
            If tanaman.Tag = "selected" Then
                TambahTanaman.Name = tanaman.Name
                TambahTanaman.Edit = True
                TambahTanaman.Show()
            End If
        Next
    End Sub

    ' Keranjang - Click
    Private Sub BtnKeranjang_Click(sender As Object, e As EventArgs) Handles BtnKeranjang.Click
        Dim query, id As String
        Dim stok, dipilih, berhasil As Integer

        dipilih = 0
        berhasil = 0

        For Each tanaman In ContainerTanaman.Controls.OfType(Of Button)
            id = tanaman.Name

            If tanaman.Tag = "selected" Then

                query = "SELECT stok FROM produk " +
                        "WHERE id='" + id + "'"
                CMD = New MySqlCommand(query, CONN)
                RD = CMD.ExecuteReader()
                RD.Read()
                stok = RD.Item("stok")
                RD.Close()

                If stok > 0 Then
                    InsertToKeranjang(tanaman.Name, 1)
                    berhasil += 1
                End If

                dipilih += 1
            End If
        Next

        If berhasil <> 0 Then
            MessageBox.Show(
                "Produk berhasil ditambahkan ke keranjang!",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        End If

        If berhasil <> dipilih Then
            MessageBox.Show(
                "Beberapa produk gagal ditambahkan ke keranjang!",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
        End If

    End Sub


    ' -- TEXTBOX -------------------------------------------------------------------------------------------------

    ' Search - GotFocus
    Private Sub TxtSearch_GotFocus(sender As Object, e As EventArgs) Handles TxtSearch.GotFocus
        If sender.Text = "Search" Then
            sender.Clear()
        End If

        sender.ForeColor = Color.Black
        UnselectAll()
    End Sub

    ' Search - LostFocus 
    Private Sub TxtSearch_LostFocus(sender As Object, e As EventArgs) Handles TxtSearch.LostFocus
        If sender.Text = vbNullString Then
            sender.Text = "Search"
            sender.ForeColor = Color.DarkGray
        Else
            sender.ForeColor = Color.Black
        End If
    End Sub

    ' Search - KeyPress
    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            LoadTanaman(
                "SELECT * FROM produk " +
                "WHERE nama LIKE '%" + sender.Text + "%' " +
                "ORDER BY " + CbBoxSort.Text
            )
            CbBoxJenis.SelectedIndex = 0
        End If

    End Sub

    ' Search - TextChanged
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        If sender.Text = vbNullString Then
            LoadTanaman(
                "SELECT * FROM produk " +
                IIf(CbBoxJenis.Text = "Semua", "", "WHERE jenis='" & CbBoxJenis.Text & "' ") +
                "ORDER BY " & CbBoxSort.Text
            )
        End If
    End Sub

    ' -- COMBOBOX -------------------------------------------------------------------------------------------------

    ' Jenis & Sort - SelectedIndexChanged
    Private Sub CbBox_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles CbBoxJenis.SelectedIndexChanged, CbBoxSort.SelectedIndexChanged

        If TxtSearch.Text = "Search" Then
            LoadTanaman(
                "SELECT * FROM produk " +
                IIf(CbBoxJenis.Text = "Semua", "", "WHERE jenis='" & CbBoxJenis.Text & "' ") +
                "ORDER BY " & CbBoxSort.Text
            )
        Else
            LoadTanaman(
                "SELECT * FROM produk " +
                "WHERE nama LIKE '%" & TxtSearch.Text & "%' " +
                IIf(CbBoxJenis.Text = "Semua", "", "AND jenis='" & CbBoxJenis.Text & "' ") +
                "ORDER BY " & CbBoxSort.Text
            )
        End If
    End Sub


End Class