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
        GroupBox1 = New GroupBox()
        btnReset = New Button()
        btnHapus = New Button()
        btnUpdate = New Button()
        btnTambah = New Button()
        txtStok = New TextBox()
        txtHarga = New TextBox()
        txtNama = New TextBox()
        txtID = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Label5 = New Label()
        txtSearch = New TextBox()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnReset)
        GroupBox1.Controls.Add(btnHapus)
        GroupBox1.Controls.Add(btnUpdate)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(txtStok)
        GroupBox1.Controls.Add(txtHarga)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Controls.Add(txtID)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 55)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(509, 225)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Input Data Barang"
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(383, 178)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 11
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(267, 178)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 10
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(145, 178)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(25, 178)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(157, 131)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(125, 27)
        txtStok.TabIndex = 7
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(157, 98)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(125, 27)
        txtHarga.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(157, 65)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 5
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(157, 32)
        txtID.Name = "txtID"
        txtID.Size = New Size(125, 27)
        txtID.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 20)
        Label4.TabIndex = 3
        Label4.Text = "Stok                   :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 20)
        Label3.TabIndex = 2
        Label3.Text = "Harga                :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nama Barang    :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 20)
        Label1.TabIndex = 0
        Label1.Text = "ID Barang          :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(11, 325)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(509, 159)
        DataGridView1.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(37, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 20)
        Label5.TabIndex = 12
        Label5.Text = "Cari Barang        :"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(169, 290)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(125, 27)
        txtSearch.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(204, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 28)
        Label6.TabIndex = 13
        Label6.Text = "EasyKasir"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(532, 496)
        Controls.Add(Label6)
        Controls.Add(txtSearch)
        Controls.Add(Label5)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label6 As Label

End Class
