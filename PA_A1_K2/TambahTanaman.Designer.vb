<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahTanaman
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahTanaman))
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.TxtDesk = New System.Windows.Forms.TextBox()
        Me.TxtBerat = New System.Windows.Forms.TextBox()
        Me.TxtTinggi = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicBoxGambar = New System.Windows.Forms.PictureBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTime = New System.Windows.Forms.DateTimePicker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.erId = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erHarga = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erTinggi = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erBerat = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erStok = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.TsMenu = New System.Windows.Forms.MenuStrip()
        Me.JudulHalaman = New System.Windows.Forms.ToolStripLabel()
        CType(Me.PicBoxGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erTinggi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erBerat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(152, 360)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(80, 23)
        Me.btnSimpan.TabIndex = 51
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnFoto
        '
        Me.btnFoto.BackColor = System.Drawing.Color.SeaGreen
        Me.btnFoto.FlatAppearance.BorderSize = 0
        Me.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoto.ForeColor = System.Drawing.Color.White
        Me.btnFoto.Location = New System.Drawing.Point(91, 300)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(90, 23)
        Me.btnFoto.TabIndex = 50
        Me.btnFoto.Text = "Upload Foto"
        Me.btnFoto.UseVisualStyleBackColor = False
        '
        'TxtStok
        '
        Me.erHarga.SetIconAlignment(Me.TxtStok, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.TxtStok.Location = New System.Drawing.Point(419, 384)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtStok.Size = New System.Drawing.Size(170, 20)
        Me.TxtStok.TabIndex = 48
        '
        'TxtDesk
        '
        Me.erHarga.SetIconAlignment(Me.TxtDesk, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.TxtDesk.Location = New System.Drawing.Point(419, 300)
        Me.TxtDesk.Multiline = True
        Me.TxtDesk.Name = "TxtDesk"
        Me.TxtDesk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDesk.Size = New System.Drawing.Size(170, 69)
        Me.TxtDesk.TabIndex = 47
        '
        'TxtBerat
        '
        Me.erHarga.SetIconAlignment(Me.TxtBerat, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.TxtBerat.Location = New System.Drawing.Point(419, 272)
        Me.TxtBerat.Name = "TxtBerat"
        Me.TxtBerat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtBerat.Size = New System.Drawing.Size(143, 20)
        Me.TxtBerat.TabIndex = 46
        '
        'TxtTinggi
        '
        Me.erHarga.SetIconAlignment(Me.TxtTinggi, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.TxtTinggi.Location = New System.Drawing.Point(419, 242)
        Me.TxtTinggi.Name = "TxtTinggi"
        Me.TxtTinggi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtTinggi.Size = New System.Drawing.Size(143, 20)
        Me.TxtTinggi.TabIndex = 45
        '
        'TxtHarga
        '
        Me.erHarga.SetIconAlignment(Me.TxtHarga, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.TxtHarga.Location = New System.Drawing.Point(419, 206)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtHarga.Size = New System.Drawing.Size(170, 20)
        Me.TxtHarga.TabIndex = 44
        '
        'TxtNama
        '
        Me.erHarga.SetIconAlignment(Me.TxtNama, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.TxtNama.Location = New System.Drawing.Point(419, 130)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNama.Size = New System.Drawing.Size(170, 20)
        Me.TxtNama.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightGreen
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(301, 384)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "STOK"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightGreen
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(301, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "DESKRIPSI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightGreen
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(301, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "BERAT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGreen
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(301, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "TINGGI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGreen
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(301, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "HARGA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGreen
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(301, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "JENIS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGreen
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "NAMA"
        '
        'PicBoxGambar
        '
        Me.PicBoxGambar.BackColor = System.Drawing.Color.ForestGreen
        Me.PicBoxGambar.Location = New System.Drawing.Point(40, 56)
        Me.PicBoxGambar.Name = "PicBoxGambar"
        Me.PicBoxGambar.Size = New System.Drawing.Size(198, 217)
        Me.PicBoxGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBoxGambar.TabIndex = 35
        Me.PicBoxGambar.TabStop = False
        '
        'TxtId
        '
        Me.TxtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtId.Enabled = False
        Me.erHarga.SetIconAlignment(Me.TxtId, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.TxtId.Location = New System.Drawing.Point(420, 56)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtId.Size = New System.Drawing.Size(35, 13)
        Me.TxtId.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightGreen
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(301, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 17)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "TANGGAL RILIS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightGreen
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(301, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 17)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "ID"
        '
        'DateTime
        '
        Me.erTinggi.SetIconAlignment(Me.DateTime, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.DateTime.Location = New System.Drawing.Point(419, 93)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTime.Size = New System.Drawing.Size(170, 20)
        Me.DateTime.TabIndex = 57
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'erId
        '
        Me.erId.ContainerControl = Me
        '
        'erHarga
        '
        Me.erHarga.ContainerControl = Me
        '
        'erTinggi
        '
        Me.erTinggi.ContainerControl = Me
        '
        'erBerat
        '
        Me.erBerat.ContainerControl = Me
        '
        'erStok
        '
        Me.erStok.ContainerControl = Me
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.SeaGreen
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(40, 360)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(80, 23)
        Me.btnReset.TabIndex = 58
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightGreen
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(390, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Rp"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightGreen
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(566, 244)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "cm"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.LightGreen
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(566, 277)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "g"
        '
        'cmbJenis
        '
        Me.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Tanaman Buah", "Tanaman Hias", "Benih Tanaman"})
        Me.cmbJenis.Location = New System.Drawing.Point(419, 164)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(170, 21)
        Me.cmbJenis.TabIndex = 62
        '
        'TsMenu
        '
        Me.TsMenu.AutoSize = False
        Me.TsMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.TsMenu.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JudulHalaman})
        Me.TsMenu.Location = New System.Drawing.Point(0, 0)
        Me.TsMenu.Name = "TsMenu"
        Me.TsMenu.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.TsMenu.Size = New System.Drawing.Size(643, 32)
        Me.TsMenu.TabIndex = 63
        Me.TsMenu.Text = "MenuStrip1"
        '
        'JudulHalaman
        '
        Me.JudulHalaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JudulHalaman.ForeColor = System.Drawing.Color.White
        Me.JudulHalaman.Name = "JudulHalaman"
        Me.JudulHalaman.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.JudulHalaman.Size = New System.Drawing.Size(148, 23)
        Me.JudulHalaman.Text = "Tambah Tanaman"
        '
        'TambahTanaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(643, 420)
        Me.Controls.Add(Me.TsMenu)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.DateTime)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnFoto)
        Me.Controls.Add(Me.TxtStok)
        Me.Controls.Add(Me.TxtDesk)
        Me.Controls.Add(Me.TxtBerat)
        Me.Controls.Add(Me.TxtTinggi)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicBoxGambar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TambahTanaman"
        Me.Text = "Manajemen Data Tanaman"
        CType(Me.PicBoxGambar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erTinggi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erBerat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TsMenu.ResumeLayout(False)
        Me.TsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnFoto As Button
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents TxtDesk As TextBox
    Friend WithEvents TxtBerat As TextBox
    Friend WithEvents TxtTinggi As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PicBoxGambar As PictureBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTime As DateTimePicker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents erId As ErrorProvider
    Friend WithEvents erHarga As ErrorProvider
    Friend WithEvents erTinggi As ErrorProvider
    Friend WithEvents erBerat As ErrorProvider
    Friend WithEvents erStok As ErrorProvider
    Friend WithEvents btnReset As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents TsMenu As MenuStrip
    Friend WithEvents JudulHalaman As ToolStripLabel
End Class
