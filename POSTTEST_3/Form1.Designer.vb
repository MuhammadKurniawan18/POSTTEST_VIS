<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Photo = New Label()
        lblNama = New Label()
        lblUmur = New Label()
        lblTanggal = New Label()
        lblTelepon = New Label()
        lblAlamat = New Label()
        picFoto = New PictureBox()
        btnBrowse = New Button()
        PictureBox2 = New PictureBox()
        txtNama = New TextBox()
        txtAlamat = New TextBox()
        txtUmur = New TextBox()
        txtTelepon = New TextBox()
        dtpTanggal = New DateTimePicker()
        grpJenisKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        grpHobby = New GroupBox()
        chkMemancing = New CheckBox()
        chkMenyanyi = New CheckBox()
        chkMenari = New CheckBox()
        chkGaming = New CheckBox()
        chkDesain = New CheckBox()
        chkCoding = New CheckBox()
        chkTraveling = New CheckBox()
        chkOlahraga = New CheckBox()
        btnCetak = New Button()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        grpJenisKelamin.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' Photo
        ' 
        Photo.AutoSize = True
        Photo.Font = New Font("Press Style  Large", 12.0F)
        Photo.Location = New Point(43, 22)
        Photo.Name = "Photo"
        Photo.Size = New Size(64, 21)
        Photo.TabIndex = 0
        Photo.Text = "Photo"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Press Style  Large", 12.0F)
        lblNama.Location = New Point(39, 172)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(66, 21)
        lblNama.TabIndex = 0
        lblNama.Text = "Name"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("Press Style  Large", 12.0F)
        lblUmur.Location = New Point(43, 273)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(66, 21)
        lblUmur.TabIndex = 0
        lblUmur.Text = "Umur"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Press Style  Large", 12.0F)
        lblTanggal.Location = New Point(41, 315)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(145, 21)
        lblTanggal.TabIndex = 1
        lblTanggal.Text = "Tanggal Lahir"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Font = New Font("Press Style  Large", 12.0F)
        lblTelepon.Location = New Point(43, 357)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(116, 21)
        lblTelepon.TabIndex = 2
        lblTelepon.Text = " No Telepon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Press Style  Large", 12.0F)
        lblAlamat.Location = New Point(41, 224)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(86, 21)
        lblAlamat.TabIndex = 3
        lblAlamat.Text = "Alamat"
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = Color.LightGray
        picFoto.BorderStyle = BorderStyle.Fixed3D
        picFoto.Location = New Point(196, 22)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(151, 125)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 4
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.Maroon
        btnBrowse.Cursor = Cursors.Hand
        btnBrowse.Location = New Point(382, 73)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 5
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.DarkRed
        PictureBox2.Location = New Point(25, -22)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(576, 687)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.Maroon
        txtNama.Cursor = Cursors.Hand
        txtNama.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        txtNama.Location = New Point(196, 173)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(364, 25)
        txtNama.TabIndex = 7
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.Maroon
        txtAlamat.Cursor = Cursors.Hand
        txtAlamat.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        txtAlamat.Location = New Point(196, 225)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(364, 25)
        txtAlamat.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.Maroon
        txtUmur.Cursor = Cursors.Hand
        txtUmur.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        txtUmur.Location = New Point(196, 274)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(364, 25)
        txtUmur.TabIndex = 9
        ' 
        ' txtTelepon
        ' 
        txtTelepon.BackColor = Color.Maroon
        txtTelepon.Cursor = Cursors.Hand
        txtTelepon.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        txtTelepon.Location = New Point(196, 357)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(364, 25)
        txtTelepon.TabIndex = 10
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.CalendarMonthBackground = Color.AliceBlue
        dtpTanggal.Location = New Point(197, 315)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(250, 25)
        dtpTanggal.TabIndex = 11
        ' 
        ' grpJenisKelamin
        ' 
        grpJenisKelamin.Controls.Add(rbPerempuan)
        grpJenisKelamin.Controls.Add(rbLaki)
        grpJenisKelamin.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        grpJenisKelamin.Location = New Point(43, 404)
        grpJenisKelamin.Name = "grpJenisKelamin"
        grpJenisKelamin.Size = New Size(250, 125)
        grpJenisKelamin.TabIndex = 12
        grpJenisKelamin.TabStop = False
        grpJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(19, 59)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(113, 20)
        rbPerempuan.TabIndex = 0
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(19, 24)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(96, 20)
        rbLaki.TabIndex = 1
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(chkMemancing)
        grpHobby.Controls.Add(chkMenyanyi)
        grpHobby.Controls.Add(chkMenari)
        grpHobby.Controls.Add(chkGaming)
        grpHobby.Controls.Add(chkDesain)
        grpHobby.Controls.Add(chkCoding)
        grpHobby.Controls.Add(chkTraveling)
        grpHobby.Controls.Add(chkOlahraga)
        grpHobby.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        grpHobby.Location = New Point(310, 404)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(250, 125)
        grpHobby.TabIndex = 13
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' chkMemancing
        ' 
        chkMemancing.AutoSize = True
        chkMemancing.Location = New Point(116, 99)
        chkMemancing.Name = "chkMemancing"
        chkMemancing.Size = New Size(116, 20)
        chkMemancing.TabIndex = 7
        chkMemancing.Text = "Memancing"
        chkMemancing.UseVisualStyleBackColor = True
        ' 
        ' chkMenyanyi
        ' 
        chkMenyanyi.AutoSize = True
        chkMenyanyi.Location = New Point(116, 76)
        chkMenyanyi.Name = "chkMenyanyi"
        chkMenyanyi.Size = New Size(103, 20)
        chkMenyanyi.TabIndex = 6
        chkMenyanyi.Text = "Menyanyi"
        chkMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' chkMenari
        ' 
        chkMenari.AutoSize = True
        chkMenari.Location = New Point(117, 51)
        chkMenari.Name = "chkMenari"
        chkMenari.Size = New Size(81, 20)
        chkMenari.TabIndex = 5
        chkMenari.Text = "Menari"
        chkMenari.UseVisualStyleBackColor = True
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.Location = New Point(117, 25)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(87, 20)
        chkGaming.TabIndex = 4
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' chkDesain
        ' 
        chkDesain.AutoSize = True
        chkDesain.Location = New Point(6, 99)
        chkDesain.Name = "chkDesain"
        chkDesain.Size = New Size(78, 20)
        chkDesain.TabIndex = 3
        chkDesain.Text = "Desain"
        chkDesain.UseVisualStyleBackColor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.Location = New Point(6, 76)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(78, 20)
        chkCoding.TabIndex = 2
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        ' 
        ' chkTraveling
        ' 
        chkTraveling.AutoSize = True
        chkTraveling.Location = New Point(6, 50)
        chkTraveling.Name = "chkTraveling"
        chkTraveling.Size = New Size(103, 20)
        chkTraveling.TabIndex = 1
        chkTraveling.Text = "Traveling"
        chkTraveling.UseVisualStyleBackColor = True
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.Location = New Point(6, 24)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(95, 20)
        chkOlahraga.TabIndex = 0
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.Maroon
        btnCetak.Cursor = Cursors.Hand
        btnCetak.Location = New Point(43, 545)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(517, 46)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(622, 609)
        Controls.Add(btnCetak)
        Controls.Add(grpHobby)
        Controls.Add(grpJenisKelamin)
        Controls.Add(dtpTanggal)
        Controls.Add(txtTelepon)
        Controls.Add(txtUmur)
        Controls.Add(txtAlamat)
        Controls.Add(txtNama)
        Controls.Add(btnBrowse)
        Controls.Add(picFoto)
        Controls.Add(lblAlamat)
        Controls.Add(lblTelepon)
        Controls.Add(lblTanggal)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(Photo)
        Controls.Add(PictureBox2)
        Font = New Font("Press Style  Large", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        grpJenisKelamin.ResumeLayout(False)
        grpJenisKelamin.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Photo As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents grpJenisKelamin As GroupBox
    Friend WithEvents grpHobby As GroupBox

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpJenisKelamin.Enter

    End Sub

    Friend WithEvents btnCetak As Button

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpTanggal.ValueChanged

    End Sub

    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents chkMemancing As CheckBox
    Friend WithEvents chkMenyanyi As CheckBox
    Friend WithEvents chkMenari As CheckBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents chkDesain As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkTraveling As CheckBox
    Friend WithEvents chkOlahraga As CheckBox

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim openFile As New OpenFileDialog

        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"

        If openFile.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(openFile.FileName)
        End If

    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = " " Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or
       txtUmur.Text = "" Or
       txtTelepon.Text = "" Or
       txtAlamat.Text = "" Then

            MsgBox("Inputan tidak boleh kosong")
            Exit Sub

        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MsgBox("Inputan tidak boleh kosong")
            Exit Sub
        End If

        Dim hobbyDipilih As Boolean = False

        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    hobbyDipilih = True
                End If
            End If
        Next

        If hobbyDipilih = False Then
            MsgBox("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If picFoto.Image Is Nothing Then
            MsgBox("Inputan tidak boleh kosong")
            Exit Sub
        End If

        Dim jk As String

        If rbLaki.Checked Then
            jk = "Laki-laki"
        Else
            jk = "Perempuan"
        End If

        Dim hobby As String = ""

        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = CType(ctrl, CheckBox)

                If chk.Checked Then
                    hobby &= chk.Text & ", "
                End If
            End If
        Next

        Dim formHasil As New Form2

        formHasil.lblNama.Text = txtNama.Text
        formHasil.lblUmur.Text = txtUmur.Text
        formHasil.lblTelepon.Text = txtTelepon.Text
        formHasil.lblAlamat.Text = txtAlamat.Text
        formHasil.lblTanggal.Text = dtpTanggal.Text
        formHasil.lblJenisKelamin.Text = jk
        formHasil.lblHobby.Text = hobby

        formHasil.picFoto.Image = picFoto.Image

        formHasil.Show()

    End Sub
End Class
