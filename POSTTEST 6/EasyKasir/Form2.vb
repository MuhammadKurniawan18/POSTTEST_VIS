Imports MySql.Data.MySqlClient
Public Class Form2

    Dim conn As MySqlConnection
    Sub Koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=kasirdb")
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
    Sub LoadBarang()
        Koneksi()
        Dim cmd As New MySqlCommand("SELECT * FROM barang", conn)
        Dim dr As MySqlDataReader = cmd.ExecuteReader

        cmbBarang.Items.Clear()

        While dr.Read
            cmbBarang.Items.Add(dr("id_barang") & " - " & dr("nama_barang"))
        End While

        dr.Close()
    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBarang()
    End Sub

    Private Sub cmbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBarang.SelectedIndexChanged
        Koneksi()
        Dim splitData() As String = cmbBarang.Text.Split("-")
        Dim idBarang As String = splitData(0).Trim()

        Dim cmd As New MySqlCommand("SELECT * FROM barang WHERE id_barang='" & idBarang & "'", conn)
        Dim dr As MySqlDataReader = cmd.ExecuteReader

        If dr.Read Then
            txtHarga.Text = dr("harga").ToString
        End If

        dr.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim splitData() As String = cmbBarang.Text.Split("-")

        Dim idBarang As String = splitData(0).Trim()
        Dim namaBarang As String = splitData(1).Trim()

        Dim subtotal As Integer = Val(txtHarga.Text) * Val(txtJumlah.Text)

        DataGridView1.Rows.Add(idBarang, namaBarang, txtHarga.Text, txtJumlah.Text, subtotal)

        HitungTotal()

    End Sub
    Sub HitungTotal()
        Dim total As Integer = 0

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            total += Val(DataGridView1.Rows(i).Cells("colSubtotal").Value)
        Next

        txtTotal.Text = total
    End Sub

    Private Sub txtBayar_TextChanged(sender As Object, e As EventArgs) Handles txtBayar.TextChanged
        Dim bayar As Integer = Val(txtBayar.Text)
        Dim total As Integer = Val(txtTotal.Text)

        txtKembalian.Text = bayar - total
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Koneksi()


        Dim cmd As New MySqlCommand("INSERT INTO transaksi VALUES(@id,@tgl,@total)", conn)
        cmd.Parameters.AddWithValue("@id", txtIDTransaksi.Text)
        cmd.Parameters.AddWithValue("@tgl", Now)
        cmd.Parameters.AddWithValue("@total", txtTotal.Text)
        cmd.ExecuteNonQuery()

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim cmd2 As New MySqlCommand("INSERT INTO detail_transaksi(id_transaksi,id_barang,jumlah,subtotal) VALUES(@id,@barang,@jumlah,@subtotal)", conn)
            cmd2.Parameters.AddWithValue("@id", txtIDTransaksi.Text)
            cmd2.Parameters.AddWithValue("@barang", DataGridView1.Rows(i).Cells(0).Value)
            cmd2.Parameters.AddWithValue("@jumlah", DataGridView1.Rows(i).Cells(2).Value)
            cmd2.Parameters.AddWithValue("@subtotal", DataGridView1.Rows(i).Cells(3).Value)
            cmd2.ExecuteNonQuery()
        Next

        MessageBox.Show("Transaksi berhasil disimpan")
    End Sub
End Class