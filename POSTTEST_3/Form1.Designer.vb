<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudul = New Label()
        grpFoto = New GroupBox()
        picProfile = New PictureBox()
        btnBrowse = New Button()
        grpData = New GroupBox()
        Label1 = New Label()
        txtNama = New TextBox()
        Label2 = New Label()
        txtUmur = New TextBox()
        Label3 = New Label()
        dtpTanggalLahir = New DateTimePicker()
        Label4 = New Label()
        txtNoTelp = New TextBox()
        Label5 = New Label()
        txtAlamat = New TextBox()
        grpJK = New GroupBox()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        grpHobby = New GroupBox()
        chk1 = New CheckBox()
        chk2 = New CheckBox()
        chk3 = New CheckBox()
        chk4 = New CheckBox()
        chk5 = New CheckBox()
        chk6 = New CheckBox()
        chk7 = New CheckBox()
        chk8 = New CheckBox()
        chk9 = New CheckBox()
        chk10 = New CheckBox()
        btnCetak = New Button()
        grpFoto.SuspendLayout()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        grpData.SuspendLayout()
        grpJK.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.BackColor = Color.DarkSlateGray
        lblJudul.Dock = DockStyle.Top
        lblJudul.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(0, 0)
        lblJudul.Margin = New Padding(4, 0, 4, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(1040, 92)
        lblJudul.TabIndex = 0
        lblJudul.Text = "FORM REGISTRASI KOMUNITAS IMPHEN"
        lblJudul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' grpFoto
        ' 
        grpFoto.Controls.Add(picProfile)
        grpFoto.Controls.Add(btnBrowse)
        grpFoto.Font = New Font("Segoe UI Semibold", 9F)
        grpFoto.Location = New Point(27, 123)
        grpFoto.Margin = New Padding(4, 5, 4, 5)
        grpFoto.Name = "grpFoto"
        grpFoto.Padding = New Padding(4, 5, 4, 5)
        grpFoto.Size = New Size(293, 477)
        grpFoto.TabIndex = 1
        grpFoto.TabStop = False
        grpFoto.Text = "Pas Foto Profile"
        ' 
        ' picProfile
        ' 
        picProfile.BackColor = Color.WhiteSmoke
        picProfile.BorderStyle = BorderStyle.FixedSingle
        picProfile.Location = New Point(27, 46)
        picProfile.Margin = New Padding(4, 5, 4, 5)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(239, 337)
        picProfile.SizeMode = PictureBoxSizeMode.Zoom
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.LightGray
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Location = New Point(27, 400)
        btnBrowse.Margin = New Padding(4, 5, 4, 5)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(240, 54)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Pilih Foto..."
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' grpData
        ' 
        grpData.Controls.Add(Label1)
        grpData.Controls.Add(txtNama)
        grpData.Controls.Add(Label2)
        grpData.Controls.Add(txtUmur)
        grpData.Controls.Add(Label3)
        grpData.Controls.Add(dtpTanggalLahir)
        grpData.Controls.Add(Label4)
        grpData.Controls.Add(txtNoTelp)
        grpData.Controls.Add(Label5)
        grpData.Controls.Add(txtAlamat)
        grpData.Controls.Add(grpJK)
        grpData.Font = New Font("Segoe UI Semibold", 9F)
        grpData.Location = New Point(347, 123)
        grpData.Margin = New Padding(4, 5, 4, 5)
        grpData.Name = "grpData"
        grpData.Padding = New Padding(4, 5, 4, 5)
        grpData.Size = New Size(667, 400)
        grpData.TabIndex = 2
        grpData.TabStop = False
        grpData.Text = "Informasi Pribadi"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 46)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama Lengkap"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(160, 42)
        txtNama.Margin = New Padding(4, 5, 4, 5)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(465, 27)
        txtNama.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 108)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 20)
        Label2.TabIndex = 2
        Label2.Text = "Umur"
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(160, 103)
        txtUmur.Margin = New Padding(4, 5, 4, 5)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(105, 27)
        txtUmur.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(307, 108)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 20)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal Lahir"
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(427, 103)
        dtpTanggalLahir.Margin = New Padding(4, 5, 4, 5)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(199, 27)
        dtpTanggalLahir.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 169)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 20)
        Label4.TabIndex = 6
        Label4.Text = "No. Telepon"
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(160, 165)
        txtNoTelp.Margin = New Padding(4, 5, 4, 5)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(465, 27)
        txtNoTelp.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 231)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 8
        Label5.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(160, 226)
        txtAlamat.Margin = New Padding(4, 5, 4, 5)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(465, 27)
        txtAlamat.TabIndex = 9
        ' 
        ' grpJK
        ' 
        grpJK.Controls.Add(rbLaki)
        grpJK.Controls.Add(rbPerempuan)
        grpJK.Location = New Point(160, 292)
        grpJK.Margin = New Padding(4, 5, 4, 5)
        grpJK.Name = "grpJK"
        grpJK.Padding = New Padding(4, 5, 4, 5)
        grpJK.Size = New Size(467, 77)
        grpJK.TabIndex = 10
        grpJK.TabStop = False
        grpJK.Text = "Jenis Kelamin"
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(40, 31)
        rbLaki.Margin = New Padding(4, 5, 4, 5)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(90, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(200, 31)
        rbPerempuan.Margin = New Padding(4, 5, 4, 5)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(108, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(chk1)
        grpHobby.Controls.Add(chk2)
        grpHobby.Controls.Add(chk3)
        grpHobby.Controls.Add(chk4)
        grpHobby.Controls.Add(chk5)
        grpHobby.Controls.Add(chk6)
        grpHobby.Controls.Add(chk7)
        grpHobby.Controls.Add(chk8)
        grpHobby.Controls.Add(chk9)
        grpHobby.Controls.Add(chk10)
        grpHobby.Font = New Font("Segoe UI Semibold", 9F)
        grpHobby.Location = New Point(347, 538)
        grpHobby.Margin = New Padding(4, 5, 4, 5)
        grpHobby.Name = "grpHobby"
        grpHobby.Padding = New Padding(4, 5, 4, 5)
        grpHobby.Size = New Size(667, 154)
        grpHobby.TabIndex = 3
        grpHobby.TabStop = False
        grpHobby.Text = "Pilihan Hobby (Boleh Lebih Dari Satu)"
        ' 
        ' chk1
        ' 
        chk1.AutoSize = True
        chk1.Location = New Point(27, 46)
        chk1.Margin = New Padding(4, 5, 4, 5)
        chk1.Name = "chk1"
        chk1.Size = New Size(80, 24)
        chk1.TabIndex = 0
        chk1.Text = "Coding"
        ' 
        ' chk2
        ' 
        chk2.AutoSize = True
        chk2.Location = New Point(147, 46)
        chk2.Margin = New Padding(4, 5, 4, 5)
        chk2.Name = "chk2"
        chk2.Size = New Size(84, 24)
        chk2.TabIndex = 1
        chk2.Text = "Gaming"
        ' 
        ' chk3
        ' 
        chk3.AutoSize = True
        chk3.Location = New Point(267, 46)
        chk3.Margin = New Padding(4, 5, 4, 5)
        chk3.Name = "chk3"
        chk3.Size = New Size(77, 24)
        chk3.TabIndex = 2
        chk3.Text = "Desain"
        ' 
        ' chk4
        ' 
        chk4.AutoSize = True
        chk4.Location = New Point(387, 46)
        chk4.Margin = New Padding(4, 5, 4, 5)
        chk4.Name = "chk4"
        chk4.Size = New Size(90, 24)
        chk4.TabIndex = 3
        chk4.Text = "Network"
        ' 
        ' chk5
        ' 
        chk5.AutoSize = True
        chk5.Location = New Point(507, 46)
        chk5.Margin = New Padding(4, 5, 4, 5)
        chk5.Name = "chk5"
        chk5.Size = New Size(83, 24)
        chk5.TabIndex = 4
        chk5.Text = "Robotic"
        ' 
        ' chk6
        ' 
        chk6.AutoSize = True
        chk6.Location = New Point(27, 92)
        chk6.Margin = New Padding(4, 5, 4, 5)
        chk6.Name = "chk6"
        chk6.Size = New Size(98, 24)
        chk6.TabIndex = 5
        chk6.Text = "Membaca"
        ' 
        ' chk7
        ' 
        chk7.AutoSize = True
        chk7.Location = New Point(147, 92)
        chk7.Margin = New Padding(4, 5, 4, 5)
        chk7.Name = "chk7"
        chk7.Size = New Size(94, 24)
        chk7.TabIndex = 6
        chk7.Text = "Olahraga"
        ' 
        ' chk8
        ' 
        chk8.AutoSize = True
        chk8.Location = New Point(267, 92)
        chk8.Margin = New Padding(4, 5, 4, 5)
        chk8.Name = "chk8"
        chk8.Size = New Size(72, 24)
        chk8.TabIndex = 7
        chk8.Text = "Musik"
        ' 
        ' chk9
        ' 
        chk9.AutoSize = True
        chk9.Location = New Point(387, 92)
        chk9.Margin = New Padding(4, 5, 4, 5)
        chk9.Name = "chk9"
        chk9.Size = New Size(71, 24)
        chk9.TabIndex = 8
        chk9.Text = "Futsal"
        ' 
        ' chk10
        ' 
        chk10.AutoSize = True
        chk10.Location = New Point(507, 92)
        chk10.Margin = New Padding(4, 5, 4, 5)
        chk10.Name = "chk10"
        chk10.Size = New Size(80, 24)
        chk10.TabIndex = 9
        chk10.Text = "Kuliner"
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.DarkSlateGray
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(27, 615)
        btnCetak.Margin = New Padding(4, 5, 4, 5)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(293, 77)
        btnCetak.TabIndex = 4
        btnCetak.Text = "CETAK KARTU"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1040, 738)
        Controls.Add(btnCetak)
        Controls.Add(grpHobby)
        Controls.Add(grpData)
        Controls.Add(grpFoto)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrasi Komunitas"
        grpFoto.ResumeLayout(False)
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        grpData.ResumeLayout(False)
        grpData.PerformLayout()
        grpJK.ResumeLayout(False)
        grpJK.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents grpFoto As GroupBox
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents grpData As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents grpJK As GroupBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk6 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk8 As CheckBox
    Friend WithEvents chk9 As CheckBox
    Friend WithEvents chk10 As CheckBox
    Friend WithEvents btnCetak As Button
End Class