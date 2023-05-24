<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.MsMenu = New System.Windows.Forms.MenuStrip()
        Me.MenuTanaman = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuTambah = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuLihat = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPesanan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuKeranjang = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.SsMenu = New System.Windows.Forms.StatusStrip()
        Me.LblUsername = New System.Windows.Forms.ToolStripLabel()
        Me.LblMode = New System.Windows.Forms.ToolStripLabel()
        Me.LblStatus = New System.Windows.Forms.ToolStripLabel()
        Me.Halaman = New System.Windows.Forms.Panel()
        Me.MsMenu.SuspendLayout()
        Me.SsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MsMenu
        '
        Me.MsMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.MsMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsMenu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MsMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuTanaman, Me.MenuPesanan, Me.MenuUsers, Me.MenuKeranjang, Me.MenuProfile, Me.MenuKeluar, Me.MenuLogOut})
        Me.MsMenu.Location = New System.Drawing.Point(0, 0)
        Me.MsMenu.Name = "MsMenu"
        Me.MsMenu.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.MsMenu.Size = New System.Drawing.Size(1228, 36)
        Me.MsMenu.TabIndex = 8
        Me.MsMenu.Text = "MenuStrip1"
        '
        'MenuTanaman
        '
        Me.MenuTanaman.BackColor = System.Drawing.Color.SeaGreen
        Me.MenuTanaman.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuTambah, Me.MenuLihat})
        Me.MenuTanaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuTanaman.ForeColor = System.Drawing.Color.White
        Me.MenuTanaman.Name = "MenuTanaman"
        Me.MenuTanaman.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MenuTanaman.Size = New System.Drawing.Size(100, 26)
        Me.MenuTanaman.Text = "Tanaman"
        '
        'MenuTambah
        '
        Me.MenuTambah.BackColor = System.Drawing.Color.SeaGreen
        Me.MenuTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuTambah.ForeColor = System.Drawing.Color.White
        Me.MenuTambah.Name = "MenuTambah"
        Me.MenuTambah.Size = New System.Drawing.Size(230, 34)
        Me.MenuTambah.Text = "Tambah Baru"
        '
        'MenuLihat
        '
        Me.MenuLihat.BackColor = System.Drawing.Color.SeaGreen
        Me.MenuLihat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuLihat.ForeColor = System.Drawing.Color.White
        Me.MenuLihat.Name = "MenuLihat"
        Me.MenuLihat.Size = New System.Drawing.Size(230, 34)
        Me.MenuLihat.Text = "Lihat Tanaman"
        '
        'MenuPesanan
        '
        Me.MenuPesanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuPesanan.ForeColor = System.Drawing.Color.White
        Me.MenuPesanan.Name = "MenuPesanan"
        Me.MenuPesanan.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MenuPesanan.Size = New System.Drawing.Size(95, 26)
        Me.MenuPesanan.Text = "Pesanan"
        '
        'MenuUsers
        '
        Me.MenuUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuUsers.ForeColor = System.Drawing.Color.White
        Me.MenuUsers.Name = "MenuUsers"
        Me.MenuUsers.Size = New System.Drawing.Size(73, 26)
        Me.MenuUsers.Text = "Users"
        '
        'MenuKeranjang
        '
        Me.MenuKeranjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuKeranjang.ForeColor = System.Drawing.Color.White
        Me.MenuKeranjang.Name = "MenuKeranjang"
        Me.MenuKeranjang.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MenuKeranjang.Size = New System.Drawing.Size(106, 26)
        Me.MenuKeranjang.Text = "Keranjang"
        '
        'MenuProfile
        '
        Me.MenuProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuProfile.ForeColor = System.Drawing.Color.White
        Me.MenuProfile.Name = "MenuProfile"
        Me.MenuProfile.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MenuProfile.Size = New System.Drawing.Size(75, 26)
        Me.MenuProfile.Text = "Profile"
        '
        'MenuKeluar
        '
        Me.MenuKeluar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.MenuKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuKeluar.ForeColor = System.Drawing.Color.White
        Me.MenuKeluar.Name = "MenuKeluar"
        Me.MenuKeluar.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MenuKeluar.Size = New System.Drawing.Size(76, 26)
        Me.MenuKeluar.Text = "Keluar"
        '
        'MenuLogOut
        '
        Me.MenuLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.MenuLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuLogOut.ForeColor = System.Drawing.Color.White
        Me.MenuLogOut.Name = "MenuLogOut"
        Me.MenuLogOut.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MenuLogOut.Size = New System.Drawing.Size(88, 26)
        Me.MenuLogOut.Text = "Log Out"
        '
        'SsMenu
        '
        Me.SsMenu.AutoSize = False
        Me.SsMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.SsMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SsMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.SsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblUsername, Me.LblMode, Me.LblStatus})
        Me.SsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.SsMenu.Location = New System.Drawing.Point(0, 656)
        Me.SsMenu.Name = "SsMenu"
        Me.SsMenu.Size = New System.Drawing.Size(1228, 38)
        Me.SsMenu.SizingGrip = False
        Me.SsMenu.TabIndex = 18
        Me.SsMenu.Text = "StatusStrip1"
        '
        'LblUsername
        '
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.ForeColor = System.Drawing.Color.White
        Me.LblUsername.Margin = New System.Windows.Forms.Padding(10, 3, 0, 0)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblUsername.Size = New System.Drawing.Size(102, 35)
        Me.LblUsername.Text = "Username"
        '
        'LblMode
        '
        Me.LblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMode.ForeColor = System.Drawing.Color.White
        Me.LblMode.Name = "LblMode"
        Me.LblMode.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.LblMode.Size = New System.Drawing.Size(75, 35)
        Me.LblMode.Text = "(admin)"
        '
        'LblStatus
        '
        Me.LblStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.ForeColor = System.Drawing.Color.White
        Me.LblStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblStatus.Size = New System.Drawing.Size(81, 38)
        Me.LblStatus.Text = "0 dipilih"
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Halaman
        '
        Me.Halaman.AutoScroll = True
        Me.Halaman.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Halaman.Location = New System.Drawing.Point(0, 36)
        Me.Halaman.Name = "Halaman"
        Me.Halaman.Size = New System.Drawing.Size(1228, 620)
        Me.Halaman.TabIndex = 19
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1228, 694)
        Me.Controls.Add(Me.Halaman)
        Me.Controls.Add(Me.SsMenu)
        Me.Controls.Add(Me.MsMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1250, 600)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Green Feel Florist"
        Me.MsMenu.ResumeLayout(False)
        Me.MsMenu.PerformLayout()
        Me.SsMenu.ResumeLayout(False)
        Me.SsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MsMenu As MenuStrip
    Friend WithEvents MenuTanaman As ToolStripMenuItem
    Friend WithEvents MenuTambah As ToolStripMenuItem
    Friend WithEvents MenuLihat As ToolStripMenuItem
    Friend WithEvents MenuPesanan As ToolStripMenuItem
    Friend WithEvents MenuLogOut As ToolStripMenuItem
    Friend WithEvents MenuKeluar As ToolStripMenuItem
    Friend WithEvents MenuKeranjang As ToolStripMenuItem
    Friend WithEvents MenuProfile As ToolStripMenuItem
    Friend WithEvents MenuUsers As ToolStripMenuItem
    Friend WithEvents SsMenu As StatusStrip
    Friend WithEvents LblUsername As ToolStripLabel
    Friend WithEvents LblMode As ToolStripLabel
    Friend WithEvents Halaman As Panel
    Friend WithEvents LblStatus As ToolStripLabel
End Class
