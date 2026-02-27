Public Class Form1
    Dim IPK As Double = 0
    Dim IPS As Double = 0
    Dim semester As Integer = 0
    Dim TotalIP As Double = 0

    Private Sub ValidateInput()
        If Double.TryParse(txtSmt.Text, IPS) Then
            ' angka berhasil dibaca
        Else
            MessageBox.Show("Input Harus Angka!")
        End If
    End Sub

    Private Sub kategoriIPK()
        If IPK >= 2.0 AndAlso IPK <= 2.75 Then
            lblKategori.Text = "Cukup"
        ElseIf IPK >= 2.76 AndAlso IPK <= 3.0 Then
            lblKategori.Text = "Memuaskan"
        ElseIf IPK >= 3.01 Then
            lblKategori.Text = "Sangat Memuaskan"
        Else
            lblKategori.Text = "kategori"
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblsmt.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblKategori.Click

    End Sub

    Private Sub txtsmt_TextChanged(sender As Object, e As EventArgs) Handles txtSmt.TextChanged

    End Sub

    Private Sub txtipk_TextChanged(sender As Object, e As EventArgs) Handles txtIPK.TextChanged

    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        ValidateInput()
        semester += 1
        TotalIP += IPS
        IPK = TotalIP / semester
        txtIPK.Text = IPK.ToString("0.00")
        KategoriIPK()
        txtSmt.Clear()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        semester = 0
        TotalIP = 0
        txtSmt.Clear()
        txtIPK.Clear()
        lblKategori.Text = "kategori"
    End Sub
End Class
