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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        txtGenre = New TextBox()
        Label3 = New Label()
        btnTambah = New Button()
        Button1 = New Button()
        txtJudul = New TextBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        txtHapus = New TextBox()
        Label4 = New Label()
        ListBox1 = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(txtJudul)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI", 11F)
        GroupBox1.Location = New Point(40, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(333, 175)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.BorderStyle = BorderStyle.FixedSingle
        txtGenre.Font = New Font("Segoe UI", 9F)
        txtGenre.Location = New Point(139, 88)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(163, 27)
        txtGenre.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(6, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 4
        Label3.Text = "Genre"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = SystemColors.ButtonFace
        btnTambah.Font = New Font("Segoe UI", 9F)
        btnTambah.Location = New Point(233, 131)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(330, 62)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtJudul
        ' 
        txtJudul.BorderStyle = BorderStyle.FixedSingle
        txtJudul.Font = New Font("Segoe UI", 9F)
        txtJudul.Location = New Point(139, 40)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(163, 27)
        txtJudul.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(6, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 0
        Label2.Text = "Judul Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(txtHapus)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Font = New Font("Segoe UI", 11F)
        GroupBox2.Location = New Point(430, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(333, 175)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = SystemColors.Control
        btnHapus.Font = New Font("Segoe UI", 9F)
        btnHapus.Location = New Point(233, 131)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtHapus
        ' 
        txtHapus.BorderStyle = BorderStyle.FixedSingle
        txtHapus.Font = New Font("Segoe UI", 9F)
        txtHapus.Location = New Point(136, 45)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(163, 27)
        txtHapus.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(6, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 6
        Label4.Text = "Judul Buku"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(179, 208)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(464, 204)
        ListBox1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox

End Class
