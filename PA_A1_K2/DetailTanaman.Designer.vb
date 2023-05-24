<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetailTanaman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailTanaman))
        Me.TsMenu = New System.Windows.Forms.MenuStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnHapus = New System.Windows.Forms.ToolStripButton()
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.BtnKeranjang = New System.Windows.Forms.ToolStripButton()
        Me.TxtJumlah = New System.Windows.Forms.ToolStripTextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PicBoxGambar = New System.Windows.Forms.PictureBox()
        Me.TableDetail = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.TxtDeskripsi = New System.Windows.Forms.TextBox()
        Me.TxtBerat = New System.Windows.Forms.TextBox()
        Me.TxtTinggi = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtJenis = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TsMenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PicBoxGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'TsMenu
        '
        Me.TsMenu.AutoSize = False
        Me.TsMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.TsMenu.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsMenu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TsMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BtnHapus, Me.BtnEdit, Me.BtnKeranjang, Me.TxtJumlah})
        Me.TsMenu.Location = New System.Drawing.Point(0, 0)
        Me.TsMenu.Name = "TsMenu"
        Me.TsMenu.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.TsMenu.Size = New System.Drawing.Size(903, 50)
        Me.TsMenu.TabIndex = 22
        Me.TsMenu.Text = "MenuStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripLabel1.Size = New System.Drawing.Size(201, 35)
        Me.ToolStripLabel1.Text = "Spesifikasi Produk"
        '
        'BtnHapus
        '
        Me.BtnHapus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnHapus.AutoSize = False
        Me.BtnHapus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Image = Global.PA_A1_K2.My.Resources.Resources.hapus
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnHapus.Size = New System.Drawing.Size(27, 27)
        Me.BtnHapus.Text = "Tambah ke Keranjang"
        '
        'BtnEdit
        '
        Me.BtnEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnEdit.AutoSize = False
        Me.BtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Image = Global.PA_A1_K2.My.Resources.Resources.edit
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnEdit.Size = New System.Drawing.Size(27, 27)
        Me.BtnEdit.Text = "Tambah ke Keranjang"
        '
        'BtnKeranjang
        '
        Me.BtnKeranjang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnKeranjang.AutoSize = False
        Me.BtnKeranjang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnKeranjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeranjang.ForeColor = System.Drawing.Color.White
        Me.BtnKeranjang.Image = Global.PA_A1_K2.My.Resources.Resources.keranjang
        Me.BtnKeranjang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKeranjang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnKeranjang.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnKeranjang.Name = "BtnKeranjang"
        Me.BtnKeranjang.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnKeranjang.Size = New System.Drawing.Size(27, 27)
        Me.BtnKeranjang.Text = "Tambah ke Keranjang"
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TxtJumlah.BackColor = System.Drawing.Color.White
        Me.TxtJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJumlah.ForeColor = System.Drawing.Color.Black
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(50, 40)
        Me.TxtJumlah.Text = "1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 50)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PicBoxGambar)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(20, 30, 10, 30)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableDetail)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10, 30, 20, 30)
        Me.SplitContainer1.Size = New System.Drawing.Size(903, 442)
        Me.SplitContainer1.SplitterDistance = 373
        Me.SplitContainer1.TabIndex = 23
        '
        'PicBoxGambar
        '
        Me.PicBoxGambar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PicBoxGambar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicBoxGambar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicBoxGambar.Location = New System.Drawing.Point(20, 30)
        Me.PicBoxGambar.Name = "PicBoxGambar"
        Me.PicBoxGambar.Size = New System.Drawing.Size(343, 382)
        Me.PicBoxGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBoxGambar.TabIndex = 16
        Me.PicBoxGambar.TabStop = False
        '
        'TableDetail
        '
        Me.TableDetail.AutoScroll = True
        Me.TableDetail.ColumnCount = 3
        Me.TableDetail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.54029!))
        Me.TableDetail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.450236!))
        Me.TableDetail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.00948!))
        Me.TableDetail.Controls.Add(Me.TxtStok, 2, 6)
        Me.TableDetail.Controls.Add(Me.TxtDeskripsi, 2, 5)
        Me.TableDetail.Controls.Add(Me.TxtBerat, 2, 4)
        Me.TableDetail.Controls.Add(Me.TxtTinggi, 2, 3)
        Me.TableDetail.Controls.Add(Me.TxtHarga, 2, 2)
        Me.TableDetail.Controls.Add(Me.TxtJenis, 2, 1)
        Me.TableDetail.Controls.Add(Me.TxtNama, 2, 0)
        Me.TableDetail.Controls.Add(Me.Label20, 0, 6)
        Me.TableDetail.Controls.Add(Me.Label8, 1, 0)
        Me.TableDetail.Controls.Add(Me.Label1, 0, 0)
        Me.TableDetail.Controls.Add(Me.Label2, 0, 1)
        Me.TableDetail.Controls.Add(Me.Label3, 0, 2)
        Me.TableDetail.Controls.Add(Me.Label4, 0, 3)
        Me.TableDetail.Controls.Add(Me.Label5, 0, 4)
        Me.TableDetail.Controls.Add(Me.Label6, 0, 5)
        Me.TableDetail.Controls.Add(Me.Label9, 1, 1)
        Me.TableDetail.Controls.Add(Me.Label10, 1, 2)
        Me.TableDetail.Controls.Add(Me.Label11, 1, 3)
        Me.TableDetail.Controls.Add(Me.Label12, 1, 4)
        Me.TableDetail.Controls.Add(Me.Label13, 1, 5)
        Me.TableDetail.Controls.Add(Me.Label14, 1, 6)
        Me.TableDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableDetail.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableDetail.Location = New System.Drawing.Point(10, 30)
        Me.TableDetail.Name = "TableDetail"
        Me.TableDetail.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.TableDetail.RowCount = 7
        Me.TableDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableDetail.Size = New System.Drawing.Size(496, 382)
        Me.TableDetail.TabIndex = 1
        '
        'TxtStok
        '
        Me.TxtStok.BackColor = System.Drawing.Color.White
        Me.TxtStok.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtStok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStok.Location = New System.Drawing.Point(161, 346)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.ReadOnly = True
        Me.TxtStok.Size = New System.Drawing.Size(332, 23)
        Me.TxtStok.TabIndex = 26
        Me.TxtStok.Text = "..."
        '
        'TxtDeskripsi
        '
        Me.TxtDeskripsi.BackColor = System.Drawing.Color.White
        Me.TxtDeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDeskripsi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDeskripsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeskripsi.Location = New System.Drawing.Point(161, 198)
        Me.TxtDeskripsi.Multiline = True
        Me.TxtDeskripsi.Name = "TxtDeskripsi"
        Me.TxtDeskripsi.ReadOnly = True
        Me.TxtDeskripsi.Size = New System.Drawing.Size(332, 142)
        Me.TxtDeskripsi.TabIndex = 25
        Me.TxtDeskripsi.Text = "..."
        '
        'TxtBerat
        '
        Me.TxtBerat.BackColor = System.Drawing.Color.White
        Me.TxtBerat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBerat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtBerat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBerat.Location = New System.Drawing.Point(161, 161)
        Me.TxtBerat.Name = "TxtBerat"
        Me.TxtBerat.ReadOnly = True
        Me.TxtBerat.Size = New System.Drawing.Size(332, 23)
        Me.TxtBerat.TabIndex = 24
        Me.TxtBerat.Text = "..."
        '
        'TxtTinggi
        '
        Me.TxtTinggi.BackColor = System.Drawing.Color.White
        Me.TxtTinggi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTinggi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTinggi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTinggi.Location = New System.Drawing.Point(161, 124)
        Me.TxtTinggi.Name = "TxtTinggi"
        Me.TxtTinggi.ReadOnly = True
        Me.TxtTinggi.Size = New System.Drawing.Size(332, 23)
        Me.TxtTinggi.TabIndex = 23
        Me.TxtTinggi.Text = "..."
        '
        'TxtHarga
        '
        Me.TxtHarga.BackColor = System.Drawing.Color.White
        Me.TxtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtHarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHarga.Location = New System.Drawing.Point(161, 87)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.ReadOnly = True
        Me.TxtHarga.Size = New System.Drawing.Size(332, 23)
        Me.TxtHarga.TabIndex = 22
        Me.TxtHarga.Text = "..."
        '
        'TxtJenis
        '
        Me.TxtJenis.BackColor = System.Drawing.Color.White
        Me.TxtJenis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtJenis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJenis.Location = New System.Drawing.Point(161, 50)
        Me.TxtJenis.Name = "TxtJenis"
        Me.TxtJenis.ReadOnly = True
        Me.TxtJenis.Size = New System.Drawing.Size(332, 23)
        Me.TxtJenis.TabIndex = 21
        Me.TxtJenis.Text = "..."
        '
        'TxtNama
        '
        Me.TxtNama.BackColor = System.Drawing.Color.White
        Me.TxtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNama.Location = New System.Drawing.Point(161, 13)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.ReadOnly = True
        Me.TxtNama.Size = New System.Drawing.Size(332, 23)
        Me.TxtNama.TabIndex = 1
        Me.TxtNama.Text = "..."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 343)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 25)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Stok"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(134, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tinggi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Berat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Desikripsi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(134, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(134, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 25)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(134, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 25)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(134, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 25)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(134, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 25)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(134, 343)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 25)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = ":"
        '
        'DetailTanaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(903, 492)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TsMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DetailTanaman"
        Me.Text = "Nama Tanaman"
        Me.TsMenu.ResumeLayout(False)
        Me.TsMenu.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PicBoxGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableDetail.ResumeLayout(False)
        Me.TableDetail.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TsMenu As MenuStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents BtnHapus As ToolStripButton
    Friend WithEvents BtnEdit As ToolStripButton
    Friend WithEvents BtnKeranjang As ToolStripButton
    Friend WithEvents TxtJumlah As ToolStripTextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PicBoxGambar As PictureBox
    Friend WithEvents TableDetail As TableLayoutPanel
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents TxtDeskripsi As TextBox
    Friend WithEvents TxtBerat As TextBox
    Friend WithEvents TxtTinggi As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtJenis As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
