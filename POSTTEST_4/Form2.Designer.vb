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
        picHasilProfil = New PictureBox()
        lblHasilNama = New Label()
        lblHasilID = New Label()
        lblHasilKomunitas = New Label()
        lblHasilKontak = New Label()
        lblHasilHobby = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(picHasilProfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picHasilProfil
        ' 
        picHasilProfil.Location = New Point(130, 96)
        picHasilProfil.Name = "picHasilProfil"
        picHasilProfil.Size = New Size(175, 204)
        picHasilProfil.SizeMode = PictureBoxSizeMode.Zoom
        picHasilProfil.TabIndex = 0
        picHasilProfil.TabStop = False
        ' 
        ' lblHasilNama
        ' 
        lblHasilNama.AutoSize = True
        lblHasilNama.BackColor = Color.Transparent
        lblHasilNama.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHasilNama.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        lblHasilNama.Location = New Point(190, 312)
        lblHasilNama.Name = "lblHasilNama"
        lblHasilNama.Size = New Size(68, 28)
        lblHasilNama.TabIndex = 1
        lblHasilNama.Text = "Nama"
        lblHasilNama.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHasilID
        ' 
        lblHasilID.AutoSize = True
        lblHasilID.BackColor = Color.Transparent
        lblHasilID.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHasilID.Location = New Point(210, 351)
        lblHasilID.Name = "lblHasilID"
        lblHasilID.Size = New Size(27, 23)
        lblHasilID.TabIndex = 2
        lblHasilID.Text = "ID"
        lblHasilID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHasilKomunitas
        ' 
        lblHasilKomunitas.AutoSize = True
        lblHasilKomunitas.BackColor = Color.Transparent
        lblHasilKomunitas.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHasilKomunitas.Location = New Point(200, 374)
        lblHasilKomunitas.Name = "lblHasilKomunitas"
        lblHasilKomunitas.Size = New Size(49, 23)
        lblHasilKomunitas.TabIndex = 3
        lblHasilKomunitas.Text = "Divisi"
        lblHasilKomunitas.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHasilKontak
        ' 
        lblHasilKontak.AutoSize = True
        lblHasilKontak.BackColor = Color.Transparent
        lblHasilKontak.Location = New Point(70, 427)
        lblHasilKontak.Name = "lblHasilKontak"
        lblHasilKontak.Size = New Size(55, 20)
        lblHasilKontak.TabIndex = 4
        lblHasilKontak.Text = "Kontak"
        ' 
        ' lblHasilHobby
        ' 
        lblHasilHobby.AutoSize = True
        lblHasilHobby.BackColor = Color.Transparent
        lblHasilHobby.Location = New Point(71, 458)
        lblHasilHobby.Name = "lblHasilHobby"
        lblHasilHobby.Size = New Size(54, 20)
        lblHasilHobby.TabIndex = 5
        lblHasilHobby.Text = "Hobby"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        Label1.Location = New Point(70, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(289, 31)
        Label1.TabIndex = 6
        Label1.Text = "KARTU TANDA ANGGOTA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(38, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(350, 31)
        Label2.TabIndex = 7
        Label2.Text = "KOMUNITAS MALAS NGODING"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(50, 397)
        Label3.Name = "Label3"
        Label3.Size = New Size(351, 20)
        Label3.TabIndex = 8
        Label3.Text = "_________________________________________________________"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(455, 607)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblHasilHobby)
        Controls.Add(lblHasilKontak)
        Controls.Add(lblHasilKomunitas)
        Controls.Add(lblHasilID)
        Controls.Add(lblHasilNama)
        Controls.Add(picHasilProfil)
        Name = "Form2"
        Text = "Form2"
        CType(picHasilProfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picHasilProfil As PictureBox
    Friend WithEvents lblHasilNama As Label
    Friend WithEvents lblHasilID As Label
    Friend WithEvents lblHasilKomunitas As Label
    Friend WithEvents lblHasilKontak As Label
    Friend WithEvents lblHasilHobby As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
