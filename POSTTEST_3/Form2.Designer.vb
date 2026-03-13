<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        picFoto = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTelepon = New Label()
        lblAlamat = New Label()
        lblTanggal = New Label()
        lblJenisKelamin = New Label()
        lblHobby = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(33, 153)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(217, 238)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.DarkRed
        lblNama.Font = New Font("Press Style  Large", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblNama.Location = New Point(358, 176)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(50, 16)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Maroon
        lblUmur.Font = New Font("Press Style  Large", 9.0F)
        lblUmur.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblUmur.Location = New Point(635, 235)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(49, 16)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Umur"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.BackColor = Color.Maroon
        lblTelepon.Font = New Font("Press Style  Large", 9.0F)
        lblTelepon.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblTelepon.Location = New Point(664, 175)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(64, 16)
        lblTelepon.TabIndex = 3
        lblTelepon.Text = "Telepon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Maroon
        lblAlamat.Font = New Font("Press Style  Large", 9.0F)
        lblAlamat.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblAlamat.Location = New Point(655, 281)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(65, 16)
        lblAlamat.TabIndex = 4
        lblAlamat.Text = "Alamat"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.BackColor = Color.Maroon
        lblTanggal.Font = New Font("Press Style  Large", 9.0F)
        lblTanggal.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblTanggal.Location = New Point(383, 232)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(68, 16)
        lblTanggal.TabIndex = 5
        lblTanggal.Text = "Tanggal"
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.BackColor = Color.Maroon
        lblJenisKelamin.Font = New Font("Press Style  Large", 9.0F)
        lblJenisKelamin.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblJenisKelamin.Location = New Point(442, 303)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(111, 16)
        lblJenisKelamin.TabIndex = 6
        lblJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.BackColor = Color.Maroon
        lblHobby.Font = New Font("Press Style  Large", 9.0F)
        lblHobby.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblHobby.Location = New Point(365, 374)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(51, 16)
        lblHobby.TabIndex = 7
        lblHobby.Text = "Hobby"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.car_finald
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(793, 510)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Maroon
        Label1.Font = New Font("Press Style  Large", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label1.Location = New Point(278, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 21)
        Label1.TabIndex = 9
        Label1.Text = "Nama :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Maroon
        Label2.Font = New Font("Press Style  Large", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label2.Location = New Point(556, 230)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 10
        Label2.Text = "Umur :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Maroon
        Label3.Font = New Font("Press Style  Large", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label3.Location = New Point(278, 230)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 21)
        Label3.TabIndex = 11
        Label3.Text = "Tanggal :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Maroon
        Label4.Font = New Font("Press Style  Large", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label4.Location = New Point(283, 370)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 21)
        Label4.TabIndex = 12
        Label4.Text = "Hobby :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Maroon
        Label5.Font = New Font("Press Style  Large", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label5.Location = New Point(556, 170)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 21)
        Label5.TabIndex = 13
        Label5.Text = "Telepom :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Maroon
        Label6.Font = New Font("Press Style  Large", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label6.Location = New Point(556, 277)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 21)
        Label6.TabIndex = 14
        Label6.Text = "Alamat :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Maroon
        Label7.Font = New Font("Press Style  Large", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label7.Location = New Point(283, 299)
        Label7.Name = "Label7"
        Label7.Size = New Size(153, 21)
        Label7.TabIndex = 15
        Label7.Text = "Jenis Kelamin :"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(793, 510)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblHobby)
        Controls.Add(lblJenisKelamin)
        Controls.Add(lblTanggal)
        Controls.Add(lblAlamat)
        Controls.Add(lblTelepon)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(picFoto)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
