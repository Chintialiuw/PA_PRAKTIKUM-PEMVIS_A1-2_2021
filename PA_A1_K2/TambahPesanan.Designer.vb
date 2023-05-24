<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahPesanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahPesanan))
        Me.TsMenu = New System.Windows.Forms.MenuStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnBatal = New System.Windows.Forms.ToolStripButton()
        Me.BtnClear = New System.Windows.Forms.ToolStripButton()
        Me.BtnSync = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridProduk = New System.Windows.Forms.DataGridView()
        Me.ColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColGambar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColProduk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColJumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPenerima = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNoTelp = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.Label()
        Me.BtnPesan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TsMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TsMenu
        '
        Me.TsMenu.AutoSize = False
        Me.TsMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.TsMenu.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BtnBatal, Me.BtnClear, Me.BtnSync})
        Me.TsMenu.Location = New System.Drawing.Point(0, 0)
        Me.TsMenu.Name = "TsMenu"
        Me.TsMenu.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.TsMenu.Size = New System.Drawing.Size(454, 32)
        Me.TsMenu.TabIndex = 23
        Me.TsMenu.Text = "MenuStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripLabel1.Size = New System.Drawing.Size(119, 23)
        Me.ToolStripLabel1.Text = "Buat Pesanan"
        '
        'BtnBatal
        '
        Me.BtnBatal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnBatal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.ForeColor = System.Drawing.Color.White
        Me.BtnBatal.Image = Global.PA_A1_K2.My.Resources.Resources.cancel
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnBatal.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnBatal.Size = New System.Drawing.Size(38, 26)
        Me.BtnBatal.Text = "Batalkan"
        '
        'BtnClear
        '
        Me.BtnClear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Image = Global.PA_A1_K2.My.Resources.Resources.clear
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnClear.Size = New System.Drawing.Size(38, 26)
        Me.BtnClear.Text = "Reset"
        '
        'BtnSync
        '
        Me.BtnSync.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnSync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSync.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSync.ForeColor = System.Drawing.Color.White
        Me.BtnSync.Image = Global.PA_A1_K2.My.Resources.Resources.sync
        Me.BtnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSync.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSync.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnSync.Name = "BtnSync"
        Me.BtnSync.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnSync.Size = New System.Drawing.Size(38, 26)
        Me.BtnSync.Text = "Sync"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GridProduk)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.BtnPesan)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(13, 6, 13, 6)
        Me.Panel1.Size = New System.Drawing.Size(454, 434)
        Me.Panel1.TabIndex = 24
        '
        'GridProduk
        '
        Me.GridProduk.BackgroundColor = System.Drawing.Color.White
        Me.GridProduk.ColumnHeadersHeight = 34
        Me.GridProduk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColId, Me.ColNo, Me.ColGambar, Me.ColProduk, Me.ColHarga, Me.ColJumlah})
        Me.GridProduk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProduk.Location = New System.Drawing.Point(13, 24)
        Me.GridProduk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GridProduk.MultiSelect = False
        Me.GridProduk.Name = "GridProduk"
        Me.GridProduk.ReadOnly = True
        Me.GridProduk.RowHeadersWidth = 62
        Me.GridProduk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GridProduk.Size = New System.Drawing.Size(428, 189)
        Me.GridProduk.TabIndex = 0
        '
        'ColId
        '
        Me.ColId.HeaderText = "ID"
        Me.ColId.MinimumWidth = 8
        Me.ColId.Name = "ColId"
        Me.ColId.ReadOnly = True
        Me.ColId.Width = 150
        '
        'ColNo
        '
        Me.ColNo.HeaderText = "No."
        Me.ColNo.MinimumWidth = 8
        Me.ColNo.Name = "ColNo"
        Me.ColNo.ReadOnly = True
        Me.ColNo.Width = 150
        '
        'ColGambar
        '
        Me.ColGambar.HeaderText = ""
        Me.ColGambar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.ColGambar.MinimumWidth = 8
        Me.ColGambar.Name = "ColGambar"
        Me.ColGambar.ReadOnly = True
        Me.ColGambar.Width = 150
        '
        'ColProduk
        '
        Me.ColProduk.HeaderText = "Nama Produk"
        Me.ColProduk.MinimumWidth = 8
        Me.ColProduk.Name = "ColProduk"
        Me.ColProduk.ReadOnly = True
        Me.ColProduk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColProduk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColProduk.Width = 150
        '
        'ColHarga
        '
        Me.ColHarga.HeaderText = "Harga (Rp)"
        Me.ColHarga.MinimumWidth = 8
        Me.ColHarga.Name = "ColHarga"
        Me.ColHarga.ReadOnly = True
        Me.ColHarga.Width = 150
        '
        'ColJumlah
        '
        Me.ColJumlah.HeaderText = "Jumlah"
        Me.ColJumlah.MinimumWidth = 8
        Me.ColJumlah.Name = "ColJumlah"
        Me.ColJumlah.ReadOnly = True
        Me.ColJumlah.Width = 150
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09524!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtUsername, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtPenerima, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtNoTelp, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtAlamat, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtTotal, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 213)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(428, 193)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Location = New System.Drawing.Point(2, 166)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(159, 27)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Username"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Location = New System.Drawing.Point(165, 166)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 27)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = ":"
        '
        'TxtUsername
        '
        Me.TxtUsername.AutoSize = True
        Me.TxtUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtUsername.Location = New System.Drawing.Point(185, 166)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(241, 27)
        Me.TxtUsername.TabIndex = 22
        Me.TxtUsername.Text = "Username"
        Me.TxtUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(2, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Penerima"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(2, 58)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 56)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Alamat Pengiriman"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(2, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "No. Telepon"
        '
        'TxtPenerima
        '
        Me.TxtPenerima.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtPenerima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPenerima.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtPenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPenerima.Location = New System.Drawing.Point(185, 8)
        Me.TxtPenerima.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPenerima.Name = "TxtPenerima"
        Me.TxtPenerima.Size = New System.Drawing.Size(241, 21)
        Me.TxtPenerima.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(165, 6)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 26)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(165, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 26)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(165, 58)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 56)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = ":"
        '
        'TxtNoTelp
        '
        Me.TxtNoTelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtNoTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNoTelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNoTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoTelp.Location = New System.Drawing.Point(185, 34)
        Me.TxtNoTelp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNoTelp.Name = "TxtNoTelp"
        Me.TxtNoTelp.Size = New System.Drawing.Size(241, 21)
        Me.TxtNoTelp.TabIndex = 11
        '
        'TxtAlamat
        '
        Me.TxtAlamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAlamat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAlamat.Location = New System.Drawing.Point(185, 60)
        Me.TxtAlamat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(241, 52)
        Me.TxtAlamat.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(2, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Metode Pembayaran"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(185, 114)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(241, 26)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "COD (Bayar Di Tempat)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(2, 140)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 26)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Total Pembayaran"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(165, 114)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 26)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(165, 140)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 26)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = ":"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTotal
        '
        Me.TxtTotal.AutoSize = True
        Me.TxtTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(185, 140)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(241, 26)
        Me.TxtTotal.TabIndex = 25
        Me.TxtTotal.Text = "Rp 0"
        Me.TxtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnPesan
        '
        Me.BtnPesan.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnPesan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnPesan.FlatAppearance.BorderSize = 0
        Me.BtnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPesan.ForeColor = System.Drawing.Color.White
        Me.BtnPesan.Location = New System.Drawing.Point(13, 406)
        Me.BtnPesan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnPesan.Name = "BtnPesan"
        Me.BtnPesan.Size = New System.Drawing.Size(428, 22)
        Me.BtnPesan.TabIndex = 11
        Me.BtnPesan.Text = "Pesan Sekarang"
        Me.BtnPesan.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Produk Dipesan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TambahPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(454, 466)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TsMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TambahPesanan"
        Me.Text = "Pesanan Baru"
        Me.TsMenu.ResumeLayout(False)
        Me.TsMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TsMenu As MenuStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents BtnSync As ToolStripButton
    Friend WithEvents BtnBatal As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPenerima As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNoTelp As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents BtnPesan As Button
    Friend WithEvents BtnClear As ToolStripButton
    Friend WithEvents GridProduk As DataGridView
    Friend WithEvents ColId As DataGridViewTextBoxColumn
    Friend WithEvents ColNo As DataGridViewTextBoxColumn
    Friend WithEvents ColGambar As DataGridViewImageColumn
    Friend WithEvents ColProduk As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJumlah As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtUsername As Label
    Friend WithEvents TxtTotal As Label
End Class
