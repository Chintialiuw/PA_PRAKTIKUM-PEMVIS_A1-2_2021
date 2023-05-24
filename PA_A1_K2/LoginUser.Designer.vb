<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginUser))
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdm = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRegist
        '
        Me.btnRegist.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRegist.FlatAppearance.BorderSize = 0
        Me.btnRegist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegist.Location = New System.Drawing.Point(363, 428)
        Me.btnRegist.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(221, 32)
        Me.btnRegist.TabIndex = 24
        Me.btnRegist.Text = "Registrasi Sekarang!"
        Me.btnRegist.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(47, 403)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(865, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Belum Punya Akun ? "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(859, 50)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Login sebagai User"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdm
        '
        Me.btnAdm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdm.FlatAppearance.BorderSize = 0
        Me.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdm.Location = New System.Drawing.Point(400, 159)
        Me.btnAdm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdm.Name = "btnAdm"
        Me.btnAdm.Size = New System.Drawing.Size(150, 39)
        Me.btnAdm.TabIndex = 21
        Me.btnAdm.Text = "Login Admin"
        Me.btnAdm.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.PaleGreen
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(400, 326)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(160, 45)
        Me.btnLogin.TabIndex = 20
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPass.Location = New System.Drawing.Point(427, 54)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(196, 26)
        Me.txtPass.TabIndex = 19
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUser.Location = New System.Drawing.Point(427, 4)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(196, 26)
        Me.txtUser.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Algerian", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(118, 50)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Algerian", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(125, 50)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "USERNAME"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.14151!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.85849!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 435.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtUser, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPass, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(53, 205)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(859, 100)
        Me.TableLayoutPanel1.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SeaGreen
        Me.Label5.Location = New System.Drawing.Point(-9, 548)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(980, 15)
        Me.Label5.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SeaGreen
        Me.Label6.Location = New System.Drawing.Point(-9, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(980, 15)
        Me.Label6.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label7.Location = New System.Drawing.Point(-9, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(980, 15)
        Me.Label7.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label8.Location = New System.Drawing.Point(-9, 533)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(980, 15)
        Me.Label8.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightGreen
        Me.Label9.Location = New System.Drawing.Point(-9, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(980, 15)
        Me.Label9.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.LightGreen
        Me.Label10.Location = New System.Drawing.Point(-9, 518)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(980, 15)
        Me.Label10.TabIndex = 39
        '
        'LoginUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(965, 562)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAdm)
        Me.Controls.Add(Me.btnLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "LoginUser"
        Me.Padding = New System.Windows.Forms.Padding(50)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Green Feel Florist"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRegist As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdm As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
