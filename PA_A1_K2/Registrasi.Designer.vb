<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrasi))
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PaleGreen
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(815, 544)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 45)
        Me.btnClear.TabIndex = 44
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Location = New System.Drawing.Point(396, 486)
        Me.btnUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(158, 35)
        Me.btnUser.TabIndex = 43
        Me.btnUser.Text = "Login Sekarang!"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(53, 466)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(859, 25)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Sudah Punya Akun ? "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegist
        '
        Me.btnRegist.BackColor = System.Drawing.Color.PaleGreen
        Me.btnRegist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegist.Location = New System.Drawing.Point(408, 401)
        Me.btnRegist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(136, 45)
        Me.btnRegist.TabIndex = 41
        Me.btnRegist.Text = "Registrasi"
        Me.btnRegist.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(859, 50)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Form Registrasi"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Agency FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(53, 122)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(859, 41)
        Me.lblError.TabIndex = 46
        Me.lblError.Text = "Label Error"
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Algerian", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(125, 37)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Username"
        '
        'txtTelp
        '
        Me.txtTelp.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTelp.Location = New System.Drawing.Point(412, 115)
        Me.txtTelp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(211, 26)
        Me.txtTelp.TabIndex = 37
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPass.Location = New System.Drawing.Point(412, 78)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(211, 26)
        Me.txtPass.TabIndex = 36
        '
        'txtAlamat
        '
        Me.txtAlamat.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtAlamat.Location = New System.Drawing.Point(412, 152)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(211, 62)
        Me.txtAlamat.TabIndex = 38
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtName.Location = New System.Drawing.Point(412, 41)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(211, 26)
        Me.txtName.TabIndex = 39
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUsername.Location = New System.Drawing.Point(412, 4)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(211, 26)
        Me.txtUsername.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Algerian", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(253, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(104, 70)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Algerian", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(252, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(105, 37)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Telepon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Algerian", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(124, 37)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Algerian", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(75, 37)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nama"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.87878!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12121!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 449.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtUsername, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAlamat, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPass, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTelp, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(53, 174)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(859, 218)
        Me.TableLayoutPanel1.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.LightGreen
        Me.Label10.Location = New System.Drawing.Point(-8, 599)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(980, 15)
        Me.Label10.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightGreen
        Me.Label9.Location = New System.Drawing.Point(-8, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(980, 15)
        Me.Label9.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label8.Location = New System.Drawing.Point(-8, 614)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(980, 15)
        Me.Label8.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label11.Location = New System.Drawing.Point(-8, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(980, 15)
        Me.Label11.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SeaGreen
        Me.Label12.Location = New System.Drawing.Point(-8, 629)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(980, 15)
        Me.Label12.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.SeaGreen
        Me.Label13.Location = New System.Drawing.Point(-8, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(980, 15)
        Me.Label13.TabIndex = 48
        '
        'Registrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(965, 643)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Registrasi"
        Me.Padding = New System.Windows.Forms.Padding(50)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Green Feel Florist"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRegist As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblError As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
