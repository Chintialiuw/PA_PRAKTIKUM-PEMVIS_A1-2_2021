<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StrukPemesanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StrukPemesanan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvProduk = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbAlamat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbTelp = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.lbNama = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbTanggal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(918, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Struk Pemesanan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(50, 30, 50, 30)
        Me.Panel1.Size = New System.Drawing.Size(918, 996)
        Me.Panel1.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvProduk)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(50, 617)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(30)
        Me.GroupBox2.Size = New System.Drawing.Size(818, 349)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Produk Pemesanan"
        '
        'dgvProduk
        '
        Me.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvProduk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProduk.Location = New System.Drawing.Point(30, 51)
        Me.dgvProduk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvProduk.Name = "dgvProduk"
        Me.dgvProduk.RowHeadersWidth = 62
        Me.dgvProduk.RowTemplate.Height = 50
        Me.dgvProduk.Size = New System.Drawing.Size(758, 268)
        Me.dgvProduk.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Gambar"
        Me.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jumlah"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Harga Satuan"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(50, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(30)
        Me.GroupBox1.Size = New System.Drawing.Size(818, 558)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Pemesanan"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.11111!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbAlamat, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTelp, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbID, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbNama, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTanggal, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbUser, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTotal, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 51)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(758, 477)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(255, 329)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 22)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(255, 282)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 22)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(255, 235)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 22)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(255, 188)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 22)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(255, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 22)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(255, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 22)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(255, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 22)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'lbAlamat
        '
        Me.lbAlamat.AutoSize = True
        Me.lbAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlamat.Location = New System.Drawing.Point(298, 329)
        Me.lbAlamat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAlamat.Name = "lbAlamat"
        Me.lbAlamat.Size = New System.Drawing.Size(17, 25)
        Me.lbAlamat.TabIndex = 16
        Me.lbAlamat.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 329)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 25)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Alamat Penerima"
        '
        'lbTelp
        '
        Me.lbTelp.AutoSize = True
        Me.lbTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelp.Location = New System.Drawing.Point(298, 282)
        Me.lbTelp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTelp.Name = "lbTelp"
        Me.lbTelp.Size = New System.Drawing.Size(17, 25)
        Me.lbTelp.TabIndex = 15
        Me.lbTelp.Text = "."
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(298, 0)
        Me.lbID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(17, 25)
        Me.lbID.TabIndex = 9
        Me.lbID.Text = "."
        '
        'lbNama
        '
        Me.lbNama.AutoSize = True
        Me.lbNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNama.Location = New System.Drawing.Point(298, 235)
        Me.lbNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNama.Name = "lbNama"
        Me.lbNama.Size = New System.Drawing.Size(17, 25)
        Me.lbNama.TabIndex = 14
        Me.lbNama.Text = "."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 282)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 25)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "No. Telp Penerima"
        '
        'lbTanggal
        '
        Me.lbTanggal.AutoSize = True
        Me.lbTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTanggal.Location = New System.Drawing.Point(298, 47)
        Me.lbTanggal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTanggal.Name = "lbTanggal"
        Me.lbTanggal.Size = New System.Drawing.Size(17, 25)
        Me.lbTanggal.TabIndex = 10
        Me.lbTanggal.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Username"
        '
        'lbUser
        '
        Me.lbUser.AutoSize = True
        Me.lbUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUser.Location = New System.Drawing.Point(298, 94)
        Me.lbUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(17, 25)
        Me.lbUser.TabIndex = 11
        Me.lbUser.Text = "."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 235)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 25)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Nama Penerima"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 141)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total Pembayaran"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(298, 141)
        Me.lbTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(17, 25)
        Me.lbTotal.TabIndex = 12
        Me.lbTotal.Text = "."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 188)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Status Pesanan"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbStatus)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.lbStatus)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(297, 191)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(458, 41)
        Me.Panel2.TabIndex = 13
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Sedang Dikemas", "Telah Terkirim"})
        Me.cmbStatus.Location = New System.Drawing.Point(4, 5)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(214, 30)
        Me.cmbStatus.TabIndex = 17
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.SeaGreen
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.Location = New System.Drawing.Point(240, 3)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(112, 37)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStatus.Location = New System.Drawing.Point(4, 0)
        Me.lbStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(17, 25)
        Me.lbStatus.TabIndex = 19
        Me.lbStatus.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = ":"
        '
        'StrukPemesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(918, 1050)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "StrukPemesanan"
        Me.Text = "Struk Pemesanan"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbID As Label
    Friend WithEvents lbTanggal As Label
    Friend WithEvents lbStatus As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lbAlamat As Label
    Friend WithEvents lbTelp As Label
    Friend WithEvents lbNama As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents lbUser As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
End Class
