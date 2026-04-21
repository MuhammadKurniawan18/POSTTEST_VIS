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
        Label6 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtIDTransaksi = New TextBox()
        txtTanggal = New TextBox()
        Label3 = New Label()
        cmbBarang = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        txtHarga = New TextBox()
        txtJumlah = New TextBox()
        btnTambah = New Button()
        DataGridView1 = New DataGridView()
        colIDBarang = New DataGridViewTextBoxColumn()
        colBarang = New DataGridViewTextBoxColumn()
        colHarga = New DataGridViewTextBoxColumn()
        colJumlah = New DataGridViewTextBoxColumn()
        colSubtotal = New DataGridViewTextBoxColumn()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtTotal = New TextBox()
        txtBayar = New TextBox()
        txtKembalian = New TextBox()
        btnSimpan = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(200, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(248, 28)
        Label6.TabIndex = 14
        Label6.Text = "FORM TRANSAKSI KASIR"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(376, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 20)
        Label1.TabIndex = 15
        Label1.Text = "ID Transaksi :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(376, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 20)
        Label2.TabIndex = 16
        Label2.Text = "Tanggal :"
        ' 
        ' txtIDTransaksi
        ' 
        txtIDTransaksi.Location = New Point(499, 53)
        txtIDTransaksi.Name = "txtIDTransaksi"
        txtIDTransaksi.Size = New Size(125, 27)
        txtIDTransaksi.TabIndex = 17
        ' 
        ' txtTanggal
        ' 
        txtTanggal.Location = New Point(499, 95)
        txtTanggal.Name = "txtTanggal"
        txtTanggal.Size = New Size(125, 27)
        txtTanggal.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(376, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 20)
        Label3.TabIndex = 19
        Label3.Text = "Pilih Barang :"
        ' 
        ' cmbBarang
        ' 
        cmbBarang.FormattingEnabled = True
        cmbBarang.Location = New Point(488, 139)
        cmbBarang.Name = "cmbBarang"
        cmbBarang.Size = New Size(136, 28)
        cmbBarang.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(376, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 20)
        Label4.TabIndex = 21
        Label4.Text = "Harga : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(376, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 20)
        Label5.TabIndex = 22
        Label5.Text = "Jumlah :"
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(497, 190)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(125, 27)
        txtHarga.TabIndex = 23
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(495, 241)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(125, 27)
        txtJumlah.TabIndex = 24
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(390, 293)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(223, 29)
        btnTambah.TabIndex = 25
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {colIDBarang, colBarang, colHarga, colJumlah, colSubtotal})
        DataGridView1.Location = New Point(12, 53)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(358, 423)
        DataGridView1.TabIndex = 26
        ' 
        ' colIDBarang
        ' 
        colIDBarang.HeaderText = "ID Barang"
        colIDBarang.MinimumWidth = 6
        colIDBarang.Name = "colIDBarang"
        ' 
        ' colBarang
        ' 
        colBarang.HeaderText = "Nama Barang"
        colBarang.MinimumWidth = 6
        colBarang.Name = "colBarang"
        ' 
        ' colHarga
        ' 
        colHarga.HeaderText = "Harga"
        colHarga.MinimumWidth = 6
        colHarga.Name = "colHarga"
        ' 
        ' colJumlah
        ' 
        colJumlah.HeaderText = "Jumlah"
        colJumlah.MinimumWidth = 6
        colJumlah.Name = "colJumlah"
        ' 
        ' colSubtotal
        ' 
        colSubtotal.HeaderText = "Subtotal"
        colSubtotal.MinimumWidth = 6
        colSubtotal.Name = "colSubtotal"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(375, 346)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 20)
        Label7.TabIndex = 27
        Label7.Text = "Total :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(376, 380)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 20)
        Label8.TabIndex = 28
        Label8.Text = "Bayar :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(376, 418)
        Label9.Name = "Label9"
        Label9.Size = New Size(87, 20)
        Label9.TabIndex = 29
        Label9.Text = "Kembalian :"
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(491, 342)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(125, 27)
        txtTotal.TabIndex = 30
        ' 
        ' txtBayar
        ' 
        txtBayar.Location = New Point(490, 382)
        txtBayar.Name = "txtBayar"
        txtBayar.Size = New Size(125, 27)
        txtBayar.TabIndex = 31
        ' 
        ' txtKembalian
        ' 
        txtKembalian.Location = New Point(490, 418)
        txtKembalian.Name = "txtKembalian"
        txtKembalian.Size = New Size(125, 27)
        txtKembalian.TabIndex = 32
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(390, 451)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(223, 29)
        btnSimpan.TabIndex = 33
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(641, 488)
        Controls.Add(btnSimpan)
        Controls.Add(txtKembalian)
        Controls.Add(txtBayar)
        Controls.Add(txtTotal)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(DataGridView1)
        Controls.Add(btnTambah)
        Controls.Add(txtJumlah)
        Controls.Add(txtHarga)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(cmbBarang)
        Controls.Add(Label3)
        Controls.Add(txtTanggal)
        Controls.Add(txtIDTransaksi)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label6)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDTransaksi As TextBox
    Friend WithEvents txtTanggal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbBarang As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents txtKembalian As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents colIDBarang As DataGridViewTextBoxColumn
    Friend WithEvents colBarang As DataGridViewTextBoxColumn
    Friend WithEvents colHarga As DataGridViewTextBoxColumn
    Friend WithEvents colJumlah As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
End Class
