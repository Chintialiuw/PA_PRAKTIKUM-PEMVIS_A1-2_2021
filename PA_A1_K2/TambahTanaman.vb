Imports System.Drawing.Imaging
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class TambahTanaman
    Public Edit As Boolean

    Private Sub TambahTanaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Owner = MainWindow

        Dim id As Integer

        TxtId.ReadOnly = True
        DateTime.Enabled = False

        If Not Edit Then
            Me.Text = "Tambah Tanaman Baru"
            JudulHalaman.Text = "Tambah Tanaman Baru"
            id = GenerateID()
            TxtId.Text = id
        Else
            loadData()
            id = Me.Name
            TxtId.Text = id
            Me.Text = "Edit Tanaman " & TxtNama.Text
            JudulHalaman.Text = "Edit Tanaman"
        End If
    End Sub

    Private Function GenerateID() As String
        Dim urutan, query As String

        query = "SELECT id FROM produk " +
                "ORDER BY id DESC " +
                "LIMIT 1"

        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        RD.Read()

        urutan = (Val(RD.Item("id")) + 1)

        RD.Close()

        Return urutan

    End Function

    Sub kosong()
        TxtNama.Text = ""
        cmbJenis.SelectedIndex = -1
        TxtHarga.Text = ""
        TxtTinggi.Text = ""
        TxtBerat.Text = ""
        TxtDesk.Text = ""
        TxtStok.Text = ""
        PicBoxGambar.Image = Nothing
    End Sub

    Sub loadData()
        Dim query As String
        query = "select * from produk " +
                "where id ='" & Me.Name & "'"

        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        While (RD.Read())
            TxtId.Text = RD.Item("id")
            TxtNama.Text = RD.Item("nama")
            DateTime.Text = RD.Item("tanggal_rilis")
            cmbJenis.Text = RD.Item("jenis")
            TxtHarga.Text = RD.Item("harga")
            TxtStok.Text = RD.Item("stok")
            TxtTinggi.Text = RD.Item("tinggi")
            TxtBerat.Text = RD.Item("berat")
            TxtDesk.Text = RD.Item("deskripsi")
            PicBoxGambar.Image = ByteToImg(RD.Item("gambar"))
        End While
        RD.Close()
    End Sub

    Private Function CekDataKosong()
        If TxtNama.Text = "" Then
            MessageBox.Show("Nama Tanaman Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNama.Focus()
        ElseIf cmbJenis.Text = "" Then
            MessageBox.Show("Jenis Tanaman Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbJenis.Focus()
        ElseIf TxtHarga.Text = "" Then
            MessageBox.Show("Harga Tanaman Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtHarga.Focus()
        ElseIf TxtTinggi.Text = "" Then
            MessageBox.Show("Tinggi Tanaman Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtTinggi.Focus()

        ElseIf TxtBerat.Text = "" Then
            MessageBox.Show("Berat Tanaman Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBerat.Focus()
        ElseIf TxtDesk.Text = "" Then
            MessageBox.Show("Deskripsi Tanaman Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDesk.Focus()
        ElseIf TxtStok.Text = "" Then
            MessageBox.Show("Stok Tanaman Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtStok.Focus()
        ElseIf PicBoxGambar.Image Is Nothing Then
            MessageBox.Show("Foto Tanaman Wajib Disi !!!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnFoto.Focus()
        Else
            Return True
        End If

        Return False
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click


        If CekDataKosong() = True Then

            ' ganti , menjadi .

            Dim tinggi, berat As String

            tinggi = TxtTinggi.Text
            If tinggi.IndexOf(",") <> -1 Then
                tinggi = tinggi.Split(",")(0) & "." & tinggi.Split(",")(1)
            End If

            berat = TxtBerat.Text
            If berat.IndexOf(",") <> -1 Then
                berat = berat.Split(",")(0) & "." & berat.Split(",")(1)
            End If

            Dim ms As New MemoryStream
            PicBoxGambar.Image.Save(ms, ImageFormat.Jpeg)

            If Not Edit Then
                ' mode tambah tanaman
                CMD = New MySqlCommand("Select * From produk where id = '" & TxtId.Text & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()

                If Not RD.HasRows Then
                    RD.Close()
                    Dim Tambah As String = "insert into produk (id, tanggal_rilis, nama, Jenis, harga, stok, tinggi, berat, deskripsi, gambar)
                                        values('" & TxtId.Text & "', '" & DateTime.Value.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & TxtNama.Text & "', 
                                                '" & cmbJenis.Text & "', '" & TxtHarga.Text & "', '" & TxtStok.Text & "', '" & tinggi & "','" & berat & "', 
                                                '" & TxtDesk.Text & "', @img)"
                    CMD = New MySqlCommand(Tambah, CONN)
                    CMD.Parameters.Add("@img", MySqlDbType.LongBlob).Value = ms.ToArray()
                    CMD.ExecuteNonQuery()
                    MsgBox("DATA TELAH TERSIMPAN DI DATABASE", MsgBoxStyle.Information, "Perhatian")
                    Me.Close()

                    DetailTanaman.LoadData()
                    LihatTanaman.ResetFilter()
                    LihatTanaman.LoadTanaman(
                        "SELECT * FROM produk " +
                        "ORDER BY " + LihatTanaman.CbBoxSort.Text
                    )

                Else
                    MsgBox("ID TELAH TERSEDIA", MsgBoxStyle.Exclamation)
                End If

                RD.Close()
                TxtNama.Focus()
            Else
                ' mode edit tanaman
                Dim Edit As String = "Update produk set tanggal_rilis = '" & DateTime.Value.ToString("yyyy-MM-dd HH:mm:ss") & "',
                                                    nama = '" & TxtNama.Text & "',
                                                    jenis = '" & cmbJenis.Text & "',
                                                    harga = '" & TxtHarga.Text & "',
                                                    tinggi = '" & tinggi & "',
                                                    berat = '" & berat & "',
                                                    stok = '" & TxtStok.Text & "',
                                                    deskripsi = '" & TxtDesk.Text & "',
                                                    gambar = @img
                                                    where id='" & TxtId.Text & "'"
                CMD = New MySqlCommand(Edit, CONN)
                CMD.Parameters.Add("@img", MySqlDbType.LongBlob).Value = ms.ToArray()
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data Telah Di Edit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

                DetailTanaman.LoadData()
                LihatTanaman.ResetFilter()
                LihatTanaman.LoadTanaman(
                    "SELECT * FROM produk " +
                    "ORDER BY " + LihatTanaman.CbBoxSort.Text
                )

                TxtNama.Focus()

            End If
        End If
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PicBoxGambar.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If Not Edit Then
            kosong()
        Else
            loadData()
        End If
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmbJenis.Focus()
            e.Handled = True
        End If
    End Sub
    Private Sub cmbJenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbJenis.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TxtHarga.Focus()
            e.Handled = True
        End If
    End Sub
    ' -- Eror Handling -------------------------------------------------------------------------------------------------
    Private Sub TxtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHarga.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            TxtTinggi.Focus()
            e.Handled = True
        ElseIf Not ((e.KeyChar >= "0" And e.KeyChar <="9") Or
            e.KeyChar = vbBack) Or
            e.KeyChar = "." And sender.Text.IndexOf(".") = -1 Then

            erHarga.SetError(TxtHarga, "Inputan Harus Berupa Angka")
            e.Handled = True
        Else
            e.Handled = False
            erHarga.Clear()
        End If
    End Sub

    Private Sub TxtTinggi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTinggi.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TxtBerat.Focus()
            e.Handled = True

        ElseIf Not (
                (e.KeyChar >= "0" And e.KeyChar <= "9") Or
                e.KeyChar = vbBack Or
                (e.KeyChar = "." And sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1) Or
                (e.KeyChar = "," And sender.Text.IndexOf(",") = -1 And sender.Text.IndexOf(".") = -1)
            ) Then

            erTinggi.SetError(TxtTinggi, "Inputan Harus Berupa Angka")
            e.Handled = True

        Else
            e.Handled = False
            erTinggi.Clear()
        End If

    End Sub

    Private Sub TxtBerat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBerat.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            TxtDesk.Focus()
            e.Handled = True
        ElseIf Not (
                (e.KeyChar >= "0" And e.KeyChar <= "9") Or
                e.KeyChar = vbBack Or
                (e.KeyChar = "." And sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1) Or
                (e.KeyChar = "," And sender.Text.IndexOf(",") = -1 And sender.Text.IndexOf(".") = -1)
            ) Then

            erBerat.SetError(TxtBerat, "Inputan Harus Berupa Angka")
            e.Handled = True
        Else
            e.Handled = False
            erBerat.Clear()
        End If
    End Sub
    Private Sub TxtDesk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDesk.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TxtStok.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub TxtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStok.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnFoto.Focus()
            e.Handled = True
        ElseIf Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
        erStok.SetError(TxtStok, "Inputan Harus Berupa Angka")
            e.Handled = True
        Else
            e.Handled = False
            erStok.Clear()
        End If
    End Sub
End Class