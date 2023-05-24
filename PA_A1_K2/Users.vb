Imports MySql.Data.MySqlClient

Public Class Users

    ' Form - Load
    Private Sub LihatUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TsMenu.Renderer = New MyRenderer()
        Config.SetDeaultGrid(dgvDataAkunUsers)
        MainWindow.LblStatus.Visible = False

        TampilDataAkunUsers()
        AturGrid()
    End Sub

    Sub TampilDataAkunUsers()
        DA = New MySqlDataAdapter("Select username, nama, telepon, alamat From Users", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "users")
        dgvDataAkunUsers.DataSource = DS.Tables("Users")
        dgvDataAkunUsers.Refresh()
        dgvDataAkunUsers.ReadOnly = True
    End Sub

    Sub AturGrid()
        dgvDataAkunUsers.Columns(0).Width = 150
        dgvDataAkunUsers.Columns(1).Width = 150
        dgvDataAkunUsers.Columns(2).Width = 120
        dgvDataAkunUsers.Columns(3).Width = 350

        dgvDataAkunUsers.Columns(0).HeaderText = "Username"
        dgvDataAkunUsers.Columns(1).HeaderText = "Nama"
        dgvDataAkunUsers.Columns(2).HeaderText = "Telepon"
        dgvDataAkunUsers.Columns(3).HeaderText = "Alamat"

    End Sub
End Class