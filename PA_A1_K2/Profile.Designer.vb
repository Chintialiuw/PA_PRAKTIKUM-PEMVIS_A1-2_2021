<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profile
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
        Me.BtnBatal = New System.Windows.Forms.ToolStripButton()
        Me.BtnSync = New System.Windows.Forms.ToolStripButton()
        Me.Halaman = New System.Windows.Forms.Panel()
        Me.PanelLihat = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEdit = New System.Windows.Forms.Panel()
        Me.TxtNoHP = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TsMenu.SuspendLayout()
        Me.Halaman.SuspendLayout()
        Me.PanelLihat.SuspendLayout()
        Me.PanelEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'TsMenu
        '
        Me.TsMenu.AutoSize = False
        Me.TsMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.TsMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsMenu.GripMargin = New System.Windows.Forms.Padding(3)
        Me.TsMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripMenuItem1, Me.BtnBatal, Me.BtnSync})
        Me.TsMenu.Location = New System.Drawing.Point(0, 0)
        Me.TsMenu.Name = "TsMenu"
        Me.TsMenu.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.TsMenu.Size = New System.Drawing.Size(1228, 50)
        Me.TsMenu.TabIndex = 19
        Me.TsMenu.Text = "MenuStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripLabel1.Size = New System.Drawing.Size(139, 35)
        Me.ToolStripLabel1.Text = "Profile Saya"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(16, 40)
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
        Me.BtnBatal.Size = New System.Drawing.Size(38, 40)
        Me.BtnBatal.Text = "Batalkan"
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
        Me.BtnSync.Size = New System.Drawing.Size(38, 40)
        Me.BtnSync.Text = "Reset"
        '
        'Halaman
        '
        Me.Halaman.AutoScroll = True
        Me.Halaman.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Halaman.Controls.Add(Me.PanelLihat)
        Me.Halaman.Controls.Add(Me.PanelEdit)
        Me.Halaman.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Halaman.Location = New System.Drawing.Point(0, 50)
        Me.Halaman.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Halaman.Name = "Halaman"
        Me.Halaman.Size = New System.Drawing.Size(1228, 570)
        Me.Halaman.TabIndex = 20
        '
        'PanelLihat
        '
        Me.PanelLihat.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.PanelLihat.Controls.Add(Me.lblUser)
        Me.PanelLihat.Controls.Add(Me.Label5)
        Me.PanelLihat.Controls.Add(Me.btnEdit)
        Me.PanelLihat.Controls.Add(Me.lblNo)
        Me.PanelLihat.Controls.Add(Me.lblAlamat)
        Me.PanelLihat.Controls.Add(Me.lblPass)
        Me.PanelLihat.Controls.Add(Me.lblNama)
        Me.PanelLihat.Controls.Add(Me.Label4)
        Me.PanelLihat.Controls.Add(Me.Label3)
        Me.PanelLihat.Controls.Add(Me.Label2)
        Me.PanelLihat.Controls.Add(Me.Label1)
        Me.PanelLihat.Location = New System.Drawing.Point(190, 2)
        Me.PanelLihat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLihat.Name = "PanelLihat"
        Me.PanelLihat.Size = New System.Drawing.Size(870, 501)
        Me.PanelLihat.TabIndex = 12
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(436, 98)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(30, 22)
        Me.lblUser.TabIndex = 25
        Me.lblUser.Text = "...."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(262, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 22)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Username"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(346, 394)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(165, 41)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "Edit Profile"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.Location = New System.Drawing.Point(436, 326)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(30, 22)
        Me.lblNo.TabIndex = 21
        Me.lblNo.Text = "...."
        '
        'lblAlamat
        '
        Me.lblAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamat.Location = New System.Drawing.Point(436, 207)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(205, 92)
        Me.lblAlamat.TabIndex = 19
        Me.lblAlamat.Text = "...."
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(436, 154)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(30, 22)
        Me.lblPass.TabIndex = 18
        Me.lblPass.Text = "...."
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(436, 40)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(30, 22)
        Me.lblNama.TabIndex = 17
        Me.lblNama.Text = "...."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(262, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(262, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "No HP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama "
        '
        'PanelEdit
        '
        Me.PanelEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.PanelEdit.Controls.Add(Me.TxtNoHP)
        Me.PanelEdit.Controls.Add(Me.TxtAlamat)
        Me.PanelEdit.Controls.Add(Me.TxtPassword)
        Me.PanelEdit.Controls.Add(Me.TxtNama)
        Me.PanelEdit.Controls.Add(Me.BtnSimpan)
        Me.PanelEdit.Controls.Add(Me.LblUsername)
        Me.PanelEdit.Controls.Add(Me.Label11)
        Me.PanelEdit.Controls.Add(Me.Label12)
        Me.PanelEdit.Controls.Add(Me.Label13)
        Me.PanelEdit.Controls.Add(Me.Label14)
        Me.PanelEdit.Controls.Add(Me.Label15)
        Me.PanelEdit.Location = New System.Drawing.Point(190, 0)
        Me.PanelEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelEdit.Name = "PanelEdit"
        Me.PanelEdit.Size = New System.Drawing.Size(870, 501)
        Me.PanelEdit.TabIndex = 23
        '
        'TxtNoHP
        '
        Me.TxtNoHP.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtNoHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNoHP.Location = New System.Drawing.Point(440, 325)
        Me.TxtNoHP.MaxLength = 13
        Me.TxtNoHP.Name = "TxtNoHP"
        Me.TxtNoHP.Size = New System.Drawing.Size(201, 26)
        Me.TxtNoHP.TabIndex = 27
        '
        'TxtAlamat
        '
        Me.TxtAlamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAlamat.Location = New System.Drawing.Point(440, 206)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(201, 93)
        Me.TxtAlamat.TabIndex = 26
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Location = New System.Drawing.Point(440, 153)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(201, 26)
        Me.TxtPassword.TabIndex = 25
        '
        'TxtNama
        '
        Me.TxtNama.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNama.Location = New System.Drawing.Point(440, 39)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(201, 26)
        Me.TxtNama.TabIndex = 23
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(346, 394)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(165, 41)
        Me.BtnSimpan.TabIndex = 22
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(436, 91)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(30, 22)
        Me.LblUsername.TabIndex = 20
        Me.LblUsername.Text = "...."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(262, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 22)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Username"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(262, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 22)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Password"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(262, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 22)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Alamat"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(262, 326)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 22)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "No HP"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(262, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 22)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Nama "
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1228, 620)
        Me.Controls.Add(Me.Halaman)
        Me.Controls.Add(Me.TsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Profile"
        Me.Text = "Profile"
        Me.TsMenu.ResumeLayout(False)
        Me.TsMenu.PerformLayout()
        Me.Halaman.ResumeLayout(False)
        Me.PanelLihat.ResumeLayout(False)
        Me.PanelLihat.PerformLayout()
        Me.PanelEdit.ResumeLayout(False)
        Me.PanelEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TsMenu As MenuStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Halaman As Panel
    Friend WithEvents PanelLihat As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNo As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents PanelEdit As Panel
    Friend WithEvents TxtNoHP As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents LblUsername As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnSync As ToolStripButton
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents BtnBatal As ToolStripButton
End Class
