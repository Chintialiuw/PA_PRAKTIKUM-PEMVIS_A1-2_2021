<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pesanan
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
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Halaman = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvRiwayatPemesanan = New System.Windows.Forms.DataGridView()
        Me.TsMenu.SuspendLayout()
        Me.Halaman.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRiwayatPemesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TsMenu
        '
        Me.TsMenu.AutoSize = False
        Me.TsMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.TsMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsMenu.GripMargin = New System.Windows.Forms.Padding(3)
        Me.TsMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripMenuItem1})
        Me.TsMenu.Location = New System.Drawing.Point(0, 0)
        Me.TsMenu.Name = "TsMenu"
        Me.TsMenu.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.TsMenu.Size = New System.Drawing.Size(1228, 49)
        Me.TsMenu.TabIndex = 16
        Me.TsMenu.Text = "MenuStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripLabel1.Size = New System.Drawing.Size(171, 34)
        Me.ToolStripLabel1.Text = "Daftar Pesanan"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(16, 39)
        '
        'Halaman
        '
        Me.Halaman.AutoScroll = True
        Me.Halaman.Controls.Add(Me.GroupBox1)
        Me.Halaman.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Halaman.Location = New System.Drawing.Point(0, 49)
        Me.Halaman.Name = "Halaman"
        Me.Halaman.Size = New System.Drawing.Size(1228, 571)
        Me.Halaman.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvRiwayatPemesanan)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 34)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1155, 494)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Riwayat Pemesanan"
        '
        'dgvRiwayatPemesanan
        '
        Me.dgvRiwayatPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRiwayatPemesanan.Location = New System.Drawing.Point(24, 38)
        Me.dgvRiwayatPemesanan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvRiwayatPemesanan.Name = "dgvRiwayatPemesanan"
        Me.dgvRiwayatPemesanan.RowHeadersWidth = 62
        Me.dgvRiwayatPemesanan.Size = New System.Drawing.Size(1104, 425)
        Me.dgvRiwayatPemesanan.TabIndex = 0
        '
        'Pesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1228, 620)
        Me.Controls.Add(Me.Halaman)
        Me.Controls.Add(Me.TsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pesanan"
        Me.Text = "Pesanan"
        Me.TsMenu.ResumeLayout(False)
        Me.TsMenu.PerformLayout()
        Me.Halaman.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvRiwayatPemesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TsMenu As MenuStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Halaman As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvRiwayatPemesanan As DataGridView
End Class
