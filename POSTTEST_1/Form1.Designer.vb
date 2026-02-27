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
        lblsmt = New Label()
        txtSmt = New TextBox()
        txtIPK = New TextBox()
        lblipk = New Label()
        btntambah = New Button()
        btnreset = New Button()
        lblKategori = New Label()
        SuspendLayout()
        ' 
        ' lblsmt
        ' 
        lblsmt.AutoSize = True
        lblsmt.Location = New Point(207, 119)
        lblsmt.Name = "lblsmt"
        lblsmt.Size = New Size(115, 25)
        lblsmt.TabIndex = 0
        lblsmt.Text = "IP SEMESTER"
        ' 
        ' txtSmt
        ' 
        txtSmt.Location = New Point(371, 116)
        txtSmt.Name = "txtSmt"
        txtSmt.Size = New Size(216, 31)
        txtSmt.TabIndex = 1
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(371, 212)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(216, 31)
        txtIPK.TabIndex = 3
        ' 
        ' lblipk
        ' 
        lblipk.AutoSize = True
        lblipk.Location = New Point(207, 215)
        lblipk.Name = "lblipk"
        lblipk.Size = New Size(125, 25)
        lblipk.TabIndex = 2
        lblipk.Text = "IP KUMULATIF"
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(371, 162)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(98, 34)
        btntambah.TabIndex = 4
        btntambah.Text = "Tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' btnreset
        ' 
        btnreset.Location = New Point(489, 162)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(98, 34)
        btnreset.TabIndex = 5
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(335, 281)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(77, 25)
        lblKategori.TabIndex = 6
        lblKategori.Text = "kategori"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblKategori)
        Controls.Add(btnreset)
        Controls.Add(btntambah)
        Controls.Add(txtIPK)
        Controls.Add(lblipk)
        Controls.Add(txtSmt)
        Controls.Add(lblsmt)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblsmt As Label
    Friend WithEvents txtSmt As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblipk As Label
    Friend WithEvents btntambah As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents lblKategori As Label

End Class
