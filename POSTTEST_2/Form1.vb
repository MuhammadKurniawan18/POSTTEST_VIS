Public Class Form1

    Sub TampilkanData()
        ListBox1.Items.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            ListBox1.Items.Add(daftarBuku(i))
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TambahBuku("Harry Potter", "Fantasi")
        TambahBuku("Sherlock Holmes", "Misteri")

        TampilkanData()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtJudul.Text <> "" And txtGenre.Text <> "" Then

            TambahBuku(txtJudul.Text, txtGenre.Text)

            txtJudul.Clear()
            txtGenre.Clear()

            TampilkanData()

        Else
            MessageBox.Show("Isi judul dan genre buku")
        End If

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If txtHapus.Text <> "" Then

            HapusBuku(txtHapus.Text)

            txtHapus.Clear()

            TampilkanData()

        Else
            MessageBox.Show("Masukkan judul buku yang akan dihapus")
        End If

    End Sub
End Class