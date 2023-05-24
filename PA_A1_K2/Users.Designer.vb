<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Users
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
        Me.dgvDataAkunUsers = New System.Windows.Forms.DataGridView()
        Me.TsMenu.SuspendLayout()
        Me.Halaman.SuspendLayout()
        CType(Me.dgvDataAkunUsers, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TsMenu.TabIndex = 15
        Me.TsMenu.Text = "MenuStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripLabel1.Size = New System.Drawing.Size(78, 34)
        Me.ToolStripLabel1.Text = "Users"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(16, 39)
        '
        'Halaman
        '
        Me.Halaman.AutoScroll = True
        Me.Halaman.Controls.Add(Me.dgvDataAkunUsers)
        Me.Halaman.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Halaman.Location = New System.Drawing.Point(0, 49)
        Me.Halaman.Name = "Halaman"
        Me.Halaman.Padding = New System.Windows.Forms.Padding(30)
        Me.Halaman.Size = New System.Drawing.Size(1228, 579)
        Me.Halaman.TabIndex = 22
        '
        'dgvDataAkunUsers
        '
        Me.dgvDataAkunUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDataAkunUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataAkunUsers.Location = New System.Drawing.Point(34, 35)
        Me.dgvDataAkunUsers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvDataAkunUsers.Name = "dgvDataAkunUsers"
        Me.dgvDataAkunUsers.RowHeadersWidth = 62
        Me.dgvDataAkunUsers.Size = New System.Drawing.Size(1160, 509)
        Me.dgvDataAkunUsers.TabIndex = 0
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1228, 628)
        Me.Controls.Add(Me.Halaman)
        Me.Controls.Add(Me.TsMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Users"
        Me.Text = "LihatUsers"
        Me.TsMenu.ResumeLayout(False)
        Me.TsMenu.PerformLayout()
        Me.Halaman.ResumeLayout(False)
        CType(Me.dgvDataAkunUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TsMenu As MenuStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Halaman As Panel
    Friend WithEvents dgvDataAkunUsers As DataGridView
End Class
