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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        picFoto = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblHobby = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(170, 101)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(128, 108)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(242, 227)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(50, 21)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.Transparent
        lblID.ForeColor = Color.White
        lblID.Location = New Point(244, 265)
        lblID.Name = "lblID"
        lblID.Size = New Size(29, 21)
        lblID.TabIndex = 2
        lblID.Text = "ID"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.BackColor = Color.Transparent
        lblKomunitas.ForeColor = Color.White
        lblKomunitas.Location = New Point(244, 331)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(81, 21)
        lblKomunitas.TabIndex = 3
        lblKomunitas.Text = "Komunitas"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.BackColor = Color.Transparent
        lblKontak.ForeColor = Color.White
        lblKontak.Location = New Point(244, 298)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(58, 21)
        lblKontak.TabIndex = 4
        lblKontak.Text = "Kontak"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.BackColor = Color.Transparent
        lblHobby.ForeColor = Color.White
        lblHobby.Location = New Point(244, 366)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(56, 21)
        lblHobby.TabIndex = 5
        lblHobby.Text = "Hobby"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label1.Location = New Point(133, 227)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 21)
        Label1.TabIndex = 6
        Label1.Text = "Nama      :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.White
        Label2.Location = New Point(137, 265)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 21)
        Label2.TabIndex = 7
        Label2.Text = "ID         :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label3.Location = New Point(137, 298)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 21)
        Label3.TabIndex = 8
        Label3.Text = "Kontak     :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Location = New Point(133, 331)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 21)
        Label4.TabIndex = 9
        Label4.Text = "Komunitas  :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.White
        Label5.Location = New Point(133, 366)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 21)
        Label5.TabIndex = 10
        Label5.Text = "Hobby      :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(182, 26)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 41)
        Label6.TabIndex = 11
        Label6.Text = "CARD"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(152, 397)
        Label7.Name = "Label7"
        Label7.Size = New Size(166, 32)
        Label7.TabIndex = 12
        Label7.Text = "COMMUNITY"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(471, 472)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblHobby)
        Controls.Add(lblKontak)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(picFoto)
        Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Black
        Name = "Form2"
        Text = "Form2"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
