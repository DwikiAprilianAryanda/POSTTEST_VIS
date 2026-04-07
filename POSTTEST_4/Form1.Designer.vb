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
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        lblTitle = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        PictureBox2 = New PictureBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cmbKomunitas = New ComboBox()
        rbWanita = New RadioButton()
        rbPria = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        txtUmur = New TextBox()
        txtID = New TextBox()
        txtNama = New TextBox()
        TabPage2 = New TabPage()
        PictureBox3 = New PictureBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        mtbTelepon = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        TabPage3 = New TabPage()
        PictureBox4 = New PictureBox()
        btnSimpanCetak = New Button()
        chkHobby8 = New CheckBox()
        chkHobby7 = New CheckBox()
        chkHobby6 = New CheckBox()
        chkHobby5 = New CheckBox()
        chkHobby4 = New CheckBox()
        chkHobby3 = New CheckBox()
        chkHobby2 = New CheckBox()
        chkHobby1 = New CheckBox()
        grpPeran = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        picProfil = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        grpPeran.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(859, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(93, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(94, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(109, 24)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(91, 24)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(65, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(157, 83)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(676, 45)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Aplikasi Pembuatan Kartu Komunitas"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(44, 162)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(738, 373)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(PictureBox2)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(cmbKomunitas)
        TabPage1.Controls.Add(rbWanita)
        TabPage1.Controls.Add(rbPria)
        TabPage1.Controls.Add(dtpTanggalLahir)
        TabPage1.Controls.Add(txtUmur)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(730, 340)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(556, 190)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(152, 131)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(34, 240)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 20)
        Label6.TabIndex = 12
        Label6.Text = "Jenis Kelamin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(264, 125)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 20)
        Label5.TabIndex = 11
        Label5.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 127)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 20)
        Label4.TabIndex = 10
        Label4.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(494, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 20)
        Label3.TabIndex = 9
        Label3.Text = "Jenis Komunitas/Divisi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(264, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 8
        Label2.Text = "ID Anggota"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 7
        Label1.Text = "Nama"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Divisi Acara", "Divisi Humas", "Divisi Kemitraan", "Divisi Logistik", "Divisi Media", "Divisi Kesekretariatan"})
        cmbKomunitas.Location = New Point(494, 64)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(214, 28)
        cmbKomunitas.TabIndex = 6
        ' 
        ' rbWanita
        ' 
        rbWanita.AutoSize = True
        rbWanita.Location = New Point(128, 263)
        rbWanita.Name = "rbWanita"
        rbWanita.Size = New Size(76, 24)
        rbWanita.TabIndex = 5
        rbWanita.TabStop = True
        rbWanita.Text = "Wanita"
        rbWanita.UseVisualStyleBackColor = True
        ' 
        ' rbPria
        ' 
        rbPria.AutoSize = True
        rbPria.Location = New Point(37, 263)
        rbPria.Name = "rbPria"
        rbPria.Size = New Size(55, 24)
        rbPria.TabIndex = 4
        rbPria.TabStop = True
        rbPria.Text = "Pria"
        rbPria.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(264, 148)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(250, 27)
        dtpTanggalLahir.TabIndex = 3
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(34, 150)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(125, 27)
        txtUmur.TabIndex = 2
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(264, 64)
        txtID.Name = "txtID"
        txtID.Size = New Size(165, 27)
        txtID.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(34, 64)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(156, 27)
        txtNama.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(PictureBox3)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(mtbTelepon)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(730, 340)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak dan Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(199, 106)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(510, 212)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(27, 83)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 20)
        Label9.TabIndex = 5
        Label9.Text = "Nomor Telepon"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(199, 13)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 20)
        Label8.TabIndex = 4
        Label8.Text = "Alamat"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(27, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 20)
        Label7.TabIndex = 3
        Label7.Text = "E-mail"
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(27, 106)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(125, 27)
        mtbTelepon.TabIndex = 2
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(199, 36)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(381, 27)
        txtAlamat.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(27, 36)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(PictureBox4)
        TabPage3.Controls.Add(btnSimpanCetak)
        TabPage3.Controls.Add(chkHobby8)
        TabPage3.Controls.Add(chkHobby7)
        TabPage3.Controls.Add(chkHobby6)
        TabPage3.Controls.Add(chkHobby5)
        TabPage3.Controls.Add(chkHobby4)
        TabPage3.Controls.Add(chkHobby3)
        TabPage3.Controls.Add(chkHobby2)
        TabPage3.Controls.Add(chkHobby1)
        TabPage3.Controls.Add(grpPeran)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(picProfil)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(730, 340)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil dan Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(523, 32)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(191, 191)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 12
        PictureBox4.TabStop = False
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.LimeGreen
        btnSimpanCetak.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpanCetak.ForeColor = Color.White
        btnSimpanCetak.Location = New Point(485, 280)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(229, 34)
        btnSimpanCetak.TabIndex = 11
        btnSimpanCetak.Text = "Simpan dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' chkHobby8
        ' 
        chkHobby8.AutoSize = True
        chkHobby8.Location = New Point(340, 260)
        chkHobby8.Name = "chkHobby8"
        chkHobby8.Size = New Size(63, 24)
        chkHobby8.TabIndex = 10
        chkHobby8.Text = "Riset"
        chkHobby8.UseVisualStyleBackColor = True
        ' 
        ' chkHobby7
        ' 
        chkHobby7.AutoSize = True
        chkHobby7.Location = New Point(340, 229)
        chkHobby7.Name = "chkHobby7"
        chkHobby7.Size = New Size(98, 24)
        chkHobby7.TabIndex = 9
        chkHobby7.Text = "Sosialisasi"
        chkHobby7.UseVisualStyleBackColor = True
        ' 
        ' chkHobby6
        ' 
        chkHobby6.AutoSize = True
        chkHobby6.Location = New Point(340, 199)
        chkHobby6.Name = "chkHobby6"
        chkHobby6.Size = New Size(151, 24)
        chkHobby6.TabIndex = 8
        chkHobby6.Text = "Manajemen Acara"
        chkHobby6.UseVisualStyleBackColor = True
        ' 
        ' chkHobby5
        ' 
        chkHobby5.AutoSize = True
        chkHobby5.Location = New Point(340, 169)
        chkHobby5.Name = "chkHobby5"
        chkHobby5.Size = New Size(92, 24)
        chkHobby5.TabIndex = 7
        chkHobby5.Text = "Fotografi"
        chkHobby5.UseVisualStyleBackColor = True
        ' 
        ' chkHobby4
        ' 
        chkHobby4.AutoSize = True
        chkHobby4.Location = New Point(182, 260)
        chkHobby4.Name = "chkHobby4"
        chkHobby4.Size = New Size(82, 24)
        chkHobby4.TabIndex = 6
        chkHobby4.Text = "Menulis"
        chkHobby4.UseVisualStyleBackColor = True
        ' 
        ' chkHobby3
        ' 
        chkHobby3.AutoSize = True
        chkHobby3.Location = New Point(182, 229)
        chkHobby3.Name = "chkHobby3"
        chkHobby3.Size = New Size(78, 24)
        chkHobby3.TabIndex = 5
        chkHobby3.Text = "Editing"
        chkHobby3.UseVisualStyleBackColor = True
        ' 
        ' chkHobby2
        ' 
        chkHobby2.AutoSize = True
        chkHobby2.Location = New Point(182, 199)
        chkHobby2.Name = "chkHobby2"
        chkHobby2.Size = New Size(136, 24)
        chkHobby2.TabIndex = 4
        chkHobby2.Text = "Public Speaking"
        chkHobby2.UseVisualStyleBackColor = True
        ' 
        ' chkHobby1
        ' 
        chkHobby1.AutoSize = True
        chkHobby1.Location = New Point(182, 169)
        chkHobby1.Name = "chkHobby1"
        chkHobby1.Size = New Size(79, 24)
        chkHobby1.TabIndex = 3
        chkHobby1.Text = "Coding"
        chkHobby1.UseVisualStyleBackColor = True
        ' 
        ' grpPeran
        ' 
        grpPeran.Controls.Add(rbAdmin)
        grpPeran.Controls.Add(rbAnggota)
        grpPeran.Controls.Add(rbKetua)
        grpPeran.Location = New Point(182, 9)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(188, 131)
        grpPeran.TabIndex = 2
        grpPeran.TabStop = False
        grpPeran.Text = "Peran"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(6, 83)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(74, 24)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(6, 53)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(88, 24)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(6, 23)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(68, 24)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(21, 169)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(125, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picProfil
        ' 
        picProfil.Image = CType(resources.GetObject("picProfil.Image"), Image)
        picProfil.Location = New Point(21, 9)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(125, 143)
        picProfil.SizeMode = PictureBoxSizeMode.Zoom
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 50)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(139, 106)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(859, 560)
        Controls.Add(PictureBox1)
        Controls.Add(TabControl1)
        Controls.Add(lblTitle)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents rbPria As RadioButton
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents rbWanita As RadioButton
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents chkHobby4 As CheckBox
    Friend WithEvents chkHobby3 As CheckBox
    Friend WithEvents chkHobby2 As CheckBox
    Friend WithEvents chkHobby1 As CheckBox
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents chkHobby8 As CheckBox
    Friend WithEvents chkHobby7 As CheckBox
    Friend WithEvents chkHobby6 As CheckBox
    Friend WithEvents chkHobby5 As CheckBox
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox

End Class
