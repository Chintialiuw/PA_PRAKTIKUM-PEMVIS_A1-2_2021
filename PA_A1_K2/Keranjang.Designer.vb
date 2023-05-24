<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Keranjang
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
        Me.TsMenu = New System.Windows.Forms.MenuStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnPilih = New System.Windows.Forms.ToolStripButton()
        Me.BtnHapus = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GridKeranjang = New System.Windows.Forms.DataGridView()
        Me.ColID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPilih = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColGambar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColProduk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColJumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPesan = New System.Windows.Forms.Button()
        Me.TsMenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TsMenu
        '
        Me.TsMenu.AutoSize = False
        Me.TsMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.TsMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsMenu.GripMargin = New System.Windows.Forms.Padding(3)
        Me.TsMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BtnPilih, Me.BtnHapus, Me.ToolStripMenuItem1})
        Me.TsMenu.Location = New System.Drawing.Point(0, 0)
        Me.TsMenu.Name = "TsMenu"
        Me.TsMenu.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.TsMenu.Size = New System.Drawing.Size(1228, 50)
        Me.TsMenu.TabIndex = 15
        Me.TsMenu.Text = "MenuStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripLabel1.Size = New System.Drawing.Size(177, 35)
        Me.ToolStripLabel1.Text = "Keranjang Saya"
        '
        'BtnPilih
        '
        Me.BtnPilih.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnPilih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPilih.ForeColor = System.Drawing.Color.White
        Me.BtnPilih.Image = Global.PA_A1_K2.My.Resources.Resources.pilih
        Me.BtnPilih.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPilih.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnPilih.Name = "BtnPilih"
        Me.BtnPilih.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnPilih.Size = New System.Drawing.Size(143, 40)
        Me.BtnPilih.Text = "Pilih Semua"
        '
        'BtnHapus
        '
        Me.BtnHapus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnHapus.AutoSize = False
        Me.BtnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnHapus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Image = Global.PA_A1_K2.My.Resources.Resources.hapus
        Me.BtnHapus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnHapus.Size = New System.Drawing.Size(27, 27)
        Me.BtnHapus.Text = "Hapus Tanaman"
        Me.BtnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(16, 40)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 50)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridKeranjang)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(20, 10, 10, 10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1228, 570)
        Me.SplitContainer1.SplitterDistance = 791
        Me.SplitContainer1.TabIndex = 18
        '
        'GridKeranjang
        '
        Me.GridKeranjang.AllowUserToAddRows = False
        Me.GridKeranjang.AllowUserToDeleteRows = False
        Me.GridKeranjang.AllowUserToResizeColumns = False
        Me.GridKeranjang.AllowUserToResizeRows = False
        Me.GridKeranjang.BackgroundColor = System.Drawing.Color.MintCream
        Me.GridKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridKeranjang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColID, Me.ColPilih, Me.ColGambar, Me.ColProduk, Me.ColHarga, Me.ColJumlah})
        Me.GridKeranjang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridKeranjang.Location = New System.Drawing.Point(20, 10)
        Me.GridKeranjang.Name = "GridKeranjang"
        Me.GridKeranjang.RowHeadersVisible = False
        Me.GridKeranjang.RowHeadersWidth = 62
        Me.GridKeranjang.RowTemplate.Height = 28
        Me.GridKeranjang.Size = New System.Drawing.Size(761, 550)
        Me.GridKeranjang.TabIndex = 0
        '
        'ColID
        '
        Me.ColID.HeaderText = "ID"
        Me.ColID.MinimumWidth = 8
        Me.ColID.Name = "ColID"
        Me.ColID.ReadOnly = True
        Me.ColID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColID.Width = 50
        '
        'ColPilih
        '
        Me.ColPilih.HeaderText = ""
        Me.ColPilih.MinimumWidth = 8
        Me.ColPilih.Name = "ColPilih"
        Me.ColPilih.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColPilih.Width = 30
        '
        'ColGambar
        '
        Me.ColGambar.HeaderText = ""
        Me.ColGambar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.ColGambar.MinimumWidth = 8
        Me.ColGambar.Name = "ColGambar"
        Me.ColGambar.ReadOnly = True
        Me.ColGambar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColGambar.Width = 50
        '
        'ColProduk
        '
        Me.ColProduk.HeaderText = "Produk"
        Me.ColProduk.MinimumWidth = 8
        Me.ColProduk.Name = "ColProduk"
        Me.ColProduk.ReadOnly = True
        Me.ColProduk.Width = 200
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
        Me.ColJumlah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColJumlah.Width = 80
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.47583!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.52417!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtTotal, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnPesan, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(393, 104)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TxtTotal
        '
        Me.TxtTotal.AutoSize = True
        Me.TxtTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(166, 0)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(224, 58)
        Me.TxtTotal.TabIndex = 3
        Me.TxtTotal.Text = "Rp 0"
        Me.TxtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 58)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Pembayaran :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnPesan
        '
        Me.BtnPesan.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnPesan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPesan.FlatAppearance.BorderSize = 0
        Me.BtnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesan.ForeColor = System.Drawing.Color.White
        Me.BtnPesan.Location = New System.Drawing.Point(166, 61)
        Me.BtnPesan.Name = "BtnPesan"
        Me.BtnPesan.Size = New System.Drawing.Size(224, 40)
        Me.BtnPesan.TabIndex = 4
        Me.BtnPesan.Text = "Pesan Sekarang"
        Me.BtnPesan.UseVisualStyleBackColor = False
        '
        'Keranjang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1228, 620)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Keranjang"
        Me.Text = "Keranjang"
        Me.TsMenu.ResumeLayout(False)
        Me.TsMenu.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TsMenu As MenuStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents BtnPilih As ToolStripButton
    Friend WithEvents BtnHapus As ToolStripButton
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GridKeranjang As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPesan As Button
    Friend WithEvents ColID As DataGridViewTextBoxColumn
    Friend WithEvents ColPilih As DataGridViewCheckBoxColumn
    Friend WithEvents ColGambar As DataGridViewImageColumn
    Friend WithEvents ColProduk As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJumlah As DataGridViewTextBoxColumn
End Class
