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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        InputDataToolStripMenuItem1 = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem1 = New ToolStripMenuItem()
        BukaDataToolStripMenuItem1 = New ToolStripMenuItem()
        KeluarToolStripMenuItem1 = New ToolStripMenuItem()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        txtNama = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtID = New TextBox()
        dtpTanggal = New DateTimePicker()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        cmbKomunitas = New ComboBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        txtAlamat = New TextBox()
        mskTelepon = New MaskedTextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        txtEmail = New TextBox()
        TabPage3 = New TabPage()
        btnSimpanCetak = New Button()
        Label11 = New Label()
        GroupBoxHobby = New GroupBox()
        cb8 = New CheckBox()
        cb7 = New CheckBox()
        cb6 = New CheckBox()
        cb5 = New CheckBox()
        cb4 = New CheckBox()
        cb3 = New CheckBox()
        cb2 = New CheckBox()
        cb1 = New CheckBox()
        GroupBox1 = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        Label10 = New Label()
        btnBrowse = New Button()
        picFoto = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBoxHobby.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(467, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InputDataToolStripMenuItem1, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem1, BukaDataToolStripMenuItem1, KeluarToolStripMenuItem1})
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(46, 24)
        InputDataToolStripMenuItem.Text = "File"
        ' 
        ' InputDataToolStripMenuItem1
        ' 
        InputDataToolStripMenuItem1.Name = "InputDataToolStripMenuItem1"
        InputDataToolStripMenuItem1.Size = New Size(224, 26)
        InputDataToolStripMenuItem1.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(224, 26)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem1
        ' 
        SimpanDataToolStripMenuItem1.Name = "SimpanDataToolStripMenuItem1"
        SimpanDataToolStripMenuItem1.Size = New Size(224, 26)
        SimpanDataToolStripMenuItem1.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem1
        ' 
        BukaDataToolStripMenuItem1.Name = "BukaDataToolStripMenuItem1"
        BukaDataToolStripMenuItem1.Size = New Size(224, 26)
        BukaDataToolStripMenuItem1.Text = "Buka data"
        ' 
        ' KeluarToolStripMenuItem1
        ' 
        KeluarToolStripMenuItem1.Name = "KeluarToolStripMenuItem1"
        KeluarToolStripMenuItem1.Size = New Size(224, 26)
        KeluarToolStripMenuItem1.Text = "Keluar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(96, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(253, 32)
        Label2.TabIndex = 2
        Label2.Text = "KARTU KOMUNITAS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.Location = New Point(153, 84)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 62)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(159, 6)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(171, 28)
        txtNama.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(218, 21)
        Label1.TabIndex = 1
        Label1.Text = "Nama                       :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(8, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 21)
        Label3.TabIndex = 2
        Label3.Text = "ID Anggota              :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 21)
        Label4.TabIndex = 3
        Label4.Text = "Tanggal Lahir           :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(8, 124)
        Label5.Name = "Label5"
        Label5.Size = New Size(191, 21)
        Label5.TabIndex = 4
        Label5.Text = "Jenis Kelamin           :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(9, 159)
        Label6.Name = "Label6"
        Label6.Size = New Size(193, 21)
        Label6.TabIndex = 5
        Label6.Text = "Komunitas               :"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(159, 50)
        txtID.Name = "txtID"
        txtID.Size = New Size(171, 28)
        txtID.TabIndex = 6
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(159, 89)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(271, 28)
        dtpTanggal.TabIndex = 7
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(159, 124)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(92, 25)
        rbLaki.TabIndex = 8
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(250, 124)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(106, 25)
        rbPerempuan.TabIndex = 9
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Location = New Point(157, 154)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(151, 29)
        cmbKomunitas.TabIndex = 10
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(0, 167)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(467, 253)
        TabControl1.TabIndex = 4
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), Image)
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(cmbKomunitas)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(dtpTanggal)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label1)
        TabPage1.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabPage1.ForeColor = Color.White
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(459, 220)
        TabPage1.TabIndex = 3
        TabPage1.Text = "Data Utama"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Transparent
        TabPage2.BackgroundImage = My.Resources.Resources._7873750
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(mskTelepon)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabPage2.ForeColor = Color.White
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(459, 220)
        TabPage2.TabIndex = 4
        TabPage2.Text = "Kontak & Info"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(194, 116)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(125, 27)
        txtAlamat.TabIndex = 5
        ' 
        ' mskTelepon
        ' 
        mskTelepon.Location = New Point(194, 19)
        mskTelepon.Mask = "0000-0000-0000"
        mskTelepon.Name = "mskTelepon"
        mskTelepon.Size = New Size(125, 28)
        mskTelepon.TabIndex = 4
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(25, 116)
        Label9.Name = "Label9"
        Label9.Size = New Size(221, 21)
        Label9.TabIndex = 3
        Label9.Text = "Alamat                      :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(25, 69)
        Label8.Name = "Label8"
        Label8.Size = New Size(159, 21)
        Label8.TabIndex = 2
        Label8.Text = "Email               :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(25, 26)
        Label7.Name = "Label7"
        Label7.Size = New Size(181, 21)
        Label7.TabIndex = 1
        Label7.Text = "Nomor Telepon        :"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(194, 69)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(125, 28)
        txtEmail.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.Transparent
        TabPage3.BackgroundImage = My.Resources.Resources._7873750
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.Controls.Add(btnSimpanCetak)
        TabPage3.Controls.Add(Label11)
        TabPage3.Controls.Add(GroupBoxHobby)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(Label10)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(picFoto)
        TabPage3.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabPage3.ForeColor = Color.White
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(459, 220)
        TabPage3.TabIndex = 5
        TabPage3.Text = "Profil & Aktivitas"
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.ForeColor = Color.Black
        btnSimpanCetak.Location = New Point(166, 183)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(220, 29)
        btnSimpanCetak.TabIndex = 5
        btnSimpanCetak.Text = "Simpan dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(25, 21)
        Label11.Name = "Label11"
        Label11.Size = New Size(78, 21)
        Label11.TabIndex = 5
        Label11.Text = "Profile : "
        ' 
        ' GroupBoxHobby
        ' 
        GroupBoxHobby.Controls.Add(cb8)
        GroupBoxHobby.Controls.Add(cb7)
        GroupBoxHobby.Controls.Add(cb6)
        GroupBoxHobby.Controls.Add(cb5)
        GroupBoxHobby.Controls.Add(cb4)
        GroupBoxHobby.Controls.Add(cb3)
        GroupBoxHobby.Controls.Add(cb2)
        GroupBoxHobby.Controls.Add(cb1)
        GroupBoxHobby.Location = New Point(133, 80)
        GroupBoxHobby.Name = "GroupBoxHobby"
        GroupBoxHobby.Size = New Size(300, 97)
        GroupBoxHobby.TabIndex = 4
        GroupBoxHobby.TabStop = False
        GroupBoxHobby.Text = "Hobby / Aktivitas :"
        ' 
        ' cb8
        ' 
        cb8.AutoSize = True
        cb8.Location = New Point(224, 55)
        cb8.Name = "cb8"
        cb8.Size = New Size(61, 25)
        cb8.TabIndex = 7
        cb8.Text = "Edit"
        cb8.UseVisualStyleBackColor = True
        ' 
        ' cb7
        ' 
        cb7.AutoSize = True
        cb7.Location = New Point(157, 55)
        cb7.Name = "cb7"
        cb7.Size = New Size(67, 25)
        cb7.TabIndex = 6
        cb7.Text = "Read"
        cb7.UseVisualStyleBackColor = True
        ' 
        ' cb6
        ' 
        cb6.AutoSize = True
        cb6.Location = New Point(81, 55)
        cb6.Name = "cb6"
        cb6.Size = New Size(78, 25)
        cb6.TabIndex = 5
        cb6.Text = "Design"
        cb6.UseVisualStyleBackColor = True
        ' 
        ' cb5
        ' 
        cb5.AutoSize = True
        cb5.Location = New Point(6, 55)
        cb5.Name = "cb5"
        cb5.Size = New Size(66, 25)
        cb5.TabIndex = 4
        cb5.Text = "Code"
        cb5.UseVisualStyleBackColor = True
        ' 
        ' cb4
        ' 
        cb4.AutoSize = True
        cb4.Location = New Point(224, 25)
        cb4.Name = "cb4"
        cb4.Size = New Size(72, 25)
        cb4.TabIndex = 3
        cb4.Text = "Sport"
        cb4.UseVisualStyleBackColor = True
        ' 
        ' cb3
        ' 
        cb3.AutoSize = True
        cb3.Location = New Point(157, 25)
        cb3.Name = "cb3"
        cb3.Size = New Size(76, 25)
        cb3.TabIndex = 2
        cb3.Text = "Travel"
        cb3.UseVisualStyleBackColor = True
        ' 
        ' cb2
        ' 
        cb2.AutoSize = True
        cb2.Location = New Point(81, 25)
        cb2.Name = "cb2"
        cb2.Size = New Size(70, 25)
        cb2.TabIndex = 1
        cb2.Text = "Game"
        cb2.UseVisualStyleBackColor = True
        ' 
        ' cb1
        ' 
        cb1.AutoSize = True
        cb1.Location = New Point(6, 25)
        cb1.Name = "cb1"
        cb1.Size = New Size(72, 25)
        cb1.TabIndex = 0
        cb1.Text = "Music"
        cb1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbAdmin)
        GroupBox1.Controls.Add(rbAnggota)
        GroupBox1.Controls.Add(rbKetua)
        GroupBox1.Location = New Point(133, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 53)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran :"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(206, 23)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(75, 25)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(98, 23)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(89, 25)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(16, 23)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(71, 25)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(25, 111)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 21)
        Label10.TabIndex = 2
        ' 
        ' btnBrowse
        ' 
        btnBrowse.ForeColor = Color.Black
        btnBrowse.Location = New Point(25, 161)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picFoto
        ' 
        picFoto.InitialImage = Nothing
        picFoto.Location = New Point(25, 44)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(94, 111)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        BackgroundImage = My.Resources.Resources._4868088
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(467, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(MenuStrip1)
        Controls.Add(TabControl1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        GroupBoxHobby.ResumeLayout(False)
        GroupBoxHobby.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputDataToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents mskTelepon As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBoxHobby As GroupBox
    Friend WithEvents cb8 As CheckBox
    Friend WithEvents cb7 As CheckBox
    Friend WithEvents cb6 As CheckBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents btnSimpanCetak As Button

End Class
