Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As MySqlConnection

    Sub Koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=kasirdb")
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Sub TampilData()
        Koneksi()
        Dim da As New MySqlDataAdapter("SELECT * FROM barang", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Dim cmd As MySqlCommand

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Koneksi()
        cmd = New MySqlCommand("INSERT INTO barang VALUES(@id,@nama,@harga,@stok)", conn)
        cmd.Parameters.AddWithValue("@id", txtID.Text)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
        cmd.Parameters.AddWithValue("@stok", txtStok.Text)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil ditambahkan")
        TampilData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As EventArgs) Handles DataGridView1.CellClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        txtID.Text = DataGridView1.Item(0, i).Value
        txtNama.Text = DataGridView1.Item(1, i).Value
        txtHarga.Text = DataGridView1.Item(2, i).Value
        txtStok.Text = DataGridView1.Item(3, i).Value
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Koneksi()
        cmd = New MySqlCommand("UPDATE barang SET nama_barang=@nama,harga=@harga,stok=@stok WHERE id_barang=@id", conn)
        cmd.Parameters.AddWithValue("@id", txtID.Text)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
        cmd.Parameters.AddWithValue("@stok", txtStok.Text)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil diupdate")
        TampilData()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Koneksi()
        cmd = New MySqlCommand("DELETE FROM barang WHERE id_barang=@id", conn)
        cmd.Parameters.AddWithValue("@id", txtID.Text)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil dihapus")
        TampilData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Koneksi()
        Dim da As New MySqlDataAdapter("SELECT * FROM barang WHERE nama_barang LIKE '%" & txtSearch.Text & "%'", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Sub Bersih()
        txtID.Text = ""
        txtNama.Text = ""
        txtHarga.Text = ""
        txtStok.Text = ""
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Bersih()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Form2.Show()
    End Sub
End Class
