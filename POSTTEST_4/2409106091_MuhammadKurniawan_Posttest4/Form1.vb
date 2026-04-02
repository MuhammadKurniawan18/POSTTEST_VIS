Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbKomunitas.Items.Add("IT")
        cmbKomunitas.Items.Add("Design")
        cmbKomunitas.Items.Add("Game")
        cmbKomunitas.Items.Add("Music")
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.png"

        If ofd.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Function Validasi() As Boolean
        If txtNama.Text = "" Or txtID.Text = "" Or mskTelepon.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If Not (cb1.Checked Or cb2.Checked Or cb3.Checked Or cb4.Checked Or cb5.Checked Or cb6.Checked Or cb7.Checked Or cb8.Checked) Then
            MessageBox.Show("Pilih minimal 1 hobby")
            Return False
        End If

        Return True
    End Function

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub SimpanData()
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text File|*.txt"

        If sfd.ShowDialog = DialogResult.OK Then
            Dim data As String =
            txtNama.Text & "," &
            txtID.Text & "," &
            cmbKomunitas.Text & "," &
            mskTelepon.Text

            IO.File.WriteAllText(sfd.FileName, data)

            MessageBox.Show("Data berhasil disimpan")
        End If
    End Sub

    Private Sub BukaData()
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Text File|*.txt"

        If ofd.ShowDialog = DialogResult.OK Then
            Dim isi As String = IO.File.ReadAllText(ofd.FileName)
            Dim data() As String = isi.Split(",")

            txtNama.Text = data(0)
            txtID.Text = data(1)
            cmbKomunitas.Text = data(2)
            mskTelepon.Text = data(3)
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If Not Validasi() Then Exit Sub

        Dim konfirmasi = MessageBox.Show("Cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo)

        If konfirmasi = DialogResult.Yes Then
            Dim f2 As New Form2

            f2.lblNama.Text = txtNama.Text
            f2.lblID.Text = txtID.Text
            f2.lblKomunitas.Text = cmbKomunitas.Text
            f2.lblKontak.Text = mskTelepon.Text
            f2.picFoto.Image = picFoto.Image

            Dim hobby As String = ""

            For Each c As Control In GroupBoxHobby.Controls
                If TypeOf c Is CheckBox Then
                    If CType(c, CheckBox).Checked Then
                        hobby &= c.Text & ", "
                    End If
                End If
            Next

            f2.lblHobby.Text = hobby

            f2.Show()
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        If MessageBox.Show("Yakin keluar?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem1.Click
        SimpanData()
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem1.Click
        BukaData()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        btnSimpanCetak.PerformClick()
    End Sub

    Private Sub SimpanDataToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem1.Click

    End Sub

    Private Sub InputDataToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem1.Click
        TabControl1.SelectedIndex = 0
    End Sub
End Class
