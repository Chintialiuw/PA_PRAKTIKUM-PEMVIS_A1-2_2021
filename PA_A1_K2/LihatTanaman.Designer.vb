<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LihatTanaman
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
        Me.TsMenu = New System.Windows.Forms.MenuStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TxtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.CbBoxSort = New System.Windows.Forms.ToolStripComboBox()
        Me.CbBoxJenis = New System.Windows.Forms.ToolStripComboBox()
        Me.BtnPilih = New System.Windows.Forms.ToolStripButton()
        Me.BtnHapus = New System.Windows.Forms.ToolStripButton()
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.BtnKeranjang = New System.Windows.Forms.ToolStripButton()
        Me.ContainerTanaman = New System.Windows.Forms.FlowLayoutPanel()
        Me.TsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TsMenu
        '
        Me.TsMenu.AutoSize = False
        Me.TsMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.TsMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsMenu.GripMargin = New System.Windows.Forms.Padding(3)
        Me.TsMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.TxtSearch, Me.CbBoxSort, Me.CbBoxJenis, Me.BtnPilih, Me.BtnHapus, Me.BtnEdit, Me.BtnKeranjang})
        Me.TsMenu.Location = New System.Drawing.Point(0, 0)
        Me.TsMenu.Name = "TsMenu"
        Me.TsMenu.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.TsMenu.Size = New System.Drawing.Size(1228, 50)
        Me.TsMenu.TabIndex = 14
        Me.TsMenu.Text = "MenuStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripLabel1.Size = New System.Drawing.Size(177, 25)
        Me.ToolStripLabel1.Text = "Daftar Tanaman"
        '
        'TxtSearch
        '
        Me.TxtSearch.AutoSize = False
        Me.TxtSearch.BackColor = System.Drawing.Color.MintCream
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.ForeColor = System.Drawing.Color.DarkGray
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.TxtSearch.Size = New System.Drawing.Size(280, 28)
        Me.TxtSearch.Text = "Search"
        '
        'CbBoxSort
        '
        Me.CbBoxSort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CbBoxSort.BackColor = System.Drawing.Color.MintCream
        Me.CbBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbBoxSort.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CbBoxSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbBoxSort.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.CbBoxSort.Name = "CbBoxSort"
        Me.CbBoxSort.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.CbBoxSort.Size = New System.Drawing.Size(160, 30)
        '
        'CbBoxJenis
        '
        Me.CbBoxJenis.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CbBoxJenis.BackColor = System.Drawing.Color.MintCream
        Me.CbBoxJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbBoxJenis.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CbBoxJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbBoxJenis.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.CbBoxJenis.Name = "CbBoxJenis"
        Me.CbBoxJenis.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.CbBoxJenis.Size = New System.Drawing.Size(190, 30)
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
        Me.BtnPilih.Size = New System.Drawing.Size(82, 30)
        Me.BtnPilih.Text = "Pilih"
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
        'BtnEdit
        '
        Me.BtnEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnEdit.AutoSize = False
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.PA_A1_K2.My.Resources.Resources.edit
        Me.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnEdit.Size = New System.Drawing.Size(27, 27)
        Me.BtnEdit.Text = "Edit Tanaman"
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'BtnKeranjang
        '
        Me.BtnKeranjang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnKeranjang.AutoSize = False
        Me.BtnKeranjang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnKeranjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeranjang.Image = Global.PA_A1_K2.My.Resources.Resources.keranjang
        Me.BtnKeranjang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnKeranjang.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnKeranjang.Name = "BtnKeranjang"
        Me.BtnKeranjang.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnKeranjang.Size = New System.Drawing.Size(27, 27)
        Me.BtnKeranjang.Text = "Tambah ke Keranjang"
        '
        'ContainerTanaman
        '
        Me.ContainerTanaman.AutoScroll = True
        Me.ContainerTanaman.BackColor = System.Drawing.Color.White
        Me.ContainerTanaman.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContainerTanaman.Location = New System.Drawing.Point(0, 50)
        Me.ContainerTanaman.Margin = New System.Windows.Forms.Padding(0)
        Me.ContainerTanaman.Name = "ContainerTanaman"
        Me.ContainerTanaman.Padding = New System.Windows.Forms.Padding(10)
        Me.ContainerTanaman.Size = New System.Drawing.Size(1228, 570)
        Me.ContainerTanaman.TabIndex = 17
        '
        'LihatTanaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 620)
        Me.Controls.Add(Me.ContainerTanaman)
        Me.Controls.Add(Me.TsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LihatTanaman"
        Me.Text = "Tanaman"
        Me.TsMenu.ResumeLayout(False)
        Me.TsMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TsMenu As MenuStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TxtSearch As ToolStripTextBox
    Friend WithEvents CbBoxSort As ToolStripComboBox
    Friend WithEvents CbBoxJenis As ToolStripComboBox
    Friend WithEvents BtnPilih As ToolStripButton
    Friend WithEvents BtnHapus As ToolStripButton
    Friend WithEvents BtnEdit As ToolStripButton
    Friend WithEvents BtnKeranjang As ToolStripButton
    Friend WithEvents ContainerTanaman As FlowLayoutPanel
End Class
