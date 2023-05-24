Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports MySql.Data.MySqlClient

Module Config

    ' database
    Public CONN As MySqlConnection,
        CMD As MySqlCommand,
        RD As MySqlDataReader,
        DA As MySqlDataAdapter,
        DS As DataSet,
        STR As String

    ' Color
    Public C_SELECT = ColorTranslator.FromHtml("#dcffed")

    ' akun login
    ' NANTI HAPUS!!
    Public mode As String = ""
    Public username As String = ""

    ' -- DATABASE --------------------------------------------------------------------------------------

    ' konek ke database
    Public Function ConnectToDB() As Boolean
        Try
            ' koneksi ke database
            STR = "server=localhost;userid=root;password=;database=green_feel_florist"
            CONN = New MySqlConnection(STR)

            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If

            Return True

        Catch ex As Exception
            ' gagal koneksi ke database
            'MessageBox.Show(ex.Message)
            MsgBox("Nyalain XAMPP nya dulu yuk!")
            Return False
        End Try
    End Function

    Public Sub InsertToKeranjang(id As String, tambahan As Integer)
        Dim query As String

        Dim jumlahAwal, jumlahAkhir, stokProduk As Integer

        query = "SELECT jumlah FROM keranjang " +
                "WHERE id_produk='" + id + "' " +
                "AND username='" + username + "'"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        RD.Read()

        If RD.HasRows Then
            jumlahAwal = Val(RD.Item("jumlah"))
        Else
            jumlahAwal = 0
        End If
        RD.Close()

        query = "SELECT stok FROM produk " +
                "WHERE id='" + id + "'"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        RD.Read()
        stokProduk = Val(RD.Item("stok"))
        RD.Close()

        If (jumlahAwal + tambahan) > stokProduk Then
            jumlahAkhir = stokProduk
        Else
            jumlahAkhir = jumlahAwal + tambahan
        End If

        If jumlahAwal = 0 Then
            query = "INSERT INTO keranjang VALUES ('" +
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                username + "','" +
                id + "','" +
                jumlahAkhir.ToString() + "')"
        Else
            query = "UPDATE keranjang SET " +
                    "jumlah='" & jumlahAkhir.ToString() & "' " +
                    "WHERE id_produk='" + id + "' " +
                    "AND username='" + username + "'"
        End If

        CMD = New MySqlCommand(query, CONN)
        CMD.ExecuteNonQuery()

    End Sub

    ' -- IMAGE --------------------------------------------------------------------------------------
    Public Function ByteToImg(img As Byte()) As Image
        Dim ms As New MemoryStream(img)
        Return Image.FromStream(ms)
    End Function

    Public Function ResizeImg(img As Image, width As Integer, height As Integer) As Image
        img = New Bitmap(img, New Size(width, height))
        Return img
    End Function

    ' -- FORM --------------------------------------------------------------------------------------

    Public Sub SwitchPage(halaman As Form)

        For Each c In MainWindow.Halaman.Controls.OfType(Of Form)
            If c IsNot halaman Then
                c.Close()
            End If
        Next

        halaman.TopLevel = False
        halaman.Dock = DockStyle.Fill

        MainWindow.Halaman.Controls.Clear()
        MainWindow.Halaman.Controls.Add(halaman)

        halaman.Show()

    End Sub


    ' -- GRID --------------------------------------------------------------------------------------

    Sub SetDeaultGrid(grid As DataGridView)
        With grid
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .RowHeadersVisible = False
            .BorderStyle = BorderStyle.None
            .BackgroundColor = Color.White
            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            .RowsDefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.ForeColor = Color.Black
            .RowsDefaultCellStyle.Font = New Drawing.Font("Microsoft Sans Serif", 9)
            .RowsDefaultCellStyle.SelectionBackColor = C_SELECT
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToAddRows = False
            .ColumnHeadersHeight = 30
        End With
    End Sub


End Module
