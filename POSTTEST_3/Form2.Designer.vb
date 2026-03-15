<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        lblHeaderTitle = New Label()
        lblFooterTitle = New Label()
        picHasilFoto = New PictureBox()
        lblHasilNama = New Label()
        LabelUmur = New Label()
        lblHasilUmur = New Label()
        LabelTL = New Label()
        lblHasilTglLahir = New Label()
        LabelJK = New Label()
        lblHasilJK = New Label()
        LabelTelp = New Label()
        lblHasilNoTelp = New Label()
        LabelAlamat = New Label()
        lblHasilAlamat = New Label()
        LabelHobby = New Label()
        lblHasilHobby = New Label()
        grpDetails = New GroupBox()
        CType(picHasilFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.BackColor = Color.OrangeRed
        lblHeaderTitle.Dock = DockStyle.Top
        lblHeaderTitle.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(0, 0)
        lblHeaderTitle.Margin = New Padding(4, 0, 4, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(467, 92)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "KOMUNITAS PROGRAMMER IMPHEN"
        lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFooterTitle
        ' 
        lblFooterTitle.BackColor = Color.DarkSlateGray
        lblFooterTitle.Dock = DockStyle.Bottom
        lblFooterTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblFooterTitle.ForeColor = Color.White
        lblFooterTitle.Location = New Point(0, 800)
        lblFooterTitle.Margin = New Padding(4, 0, 4, 0)
        lblFooterTitle.Name = "lblFooterTitle"
        lblFooterTitle.Size = New Size(467, 62)
        lblFooterTitle.TabIndex = 1
        lblFooterTitle.Text = "MEMBER IDENTIFICATION CARD"
        lblFooterTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picHasilFoto
        ' 
        picHasilFoto.BackColor = Color.WhiteSmoke
        picHasilFoto.BorderStyle = BorderStyle.FixedSingle
        picHasilFoto.Location = New Point(133, 123)
        picHasilFoto.Margin = New Padding(4, 5, 4, 5)
        picHasilFoto.Name = "picHasilFoto"
        picHasilFoto.Size = New Size(199, 276)
        picHasilFoto.SizeMode = PictureBoxSizeMode.Zoom
        picHasilFoto.TabIndex = 2
        picHasilFoto.TabStop = False
        ' 
        ' lblHasilNama
        ' 
        lblHasilNama.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHasilNama.Location = New Point(27, 415)
        lblHasilNama.Margin = New Padding(4, 0, 4, 0)
        lblHasilNama.Name = "lblHasilNama"
        lblHasilNama.Size = New Size(413, 54)
        lblHasilNama.TabIndex = 3
        lblHasilNama.Text = "[Nama Member]"
        lblHasilNama.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelUmur
        ' 
        LabelUmur.AutoSize = True
        LabelUmur.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LabelUmur.ForeColor = Color.Gray
        LabelUmur.Location = New Point(13, 31)
        LabelUmur.Margin = New Padding(4, 0, 4, 0)
        LabelUmur.Name = "LabelUmur"
        LabelUmur.Size = New Size(55, 19)
        LabelUmur.TabIndex = 0
        LabelUmur.Text = "UMUR:"
        ' 
        ' lblHasilUmur
        ' 
        lblHasilUmur.AutoSize = True
        lblHasilUmur.Font = New Font("Segoe UI Semibold", 9F)
        lblHasilUmur.Location = New Point(120, 29)
        lblHasilUmur.Margin = New Padding(4, 0, 4, 0)
        lblHasilUmur.Name = "lblHasilUmur"
        lblHasilUmur.Size = New Size(15, 20)
        lblHasilUmur.TabIndex = 1
        lblHasilUmur.Text = "-"
        ' 
        ' LabelTL
        ' 
        LabelTL.AutoSize = True
        LabelTL.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LabelTL.ForeColor = Color.Gray
        LabelTL.Location = New Point(13, 69)
        LabelTL.Margin = New Padding(4, 0, 4, 0)
        LabelTL.Name = "LabelTL"
        LabelTL.Size = New Size(83, 19)
        LabelTL.TabIndex = 2
        LabelTL.Text = "TGL LAHIR:"
        ' 
        ' lblHasilTglLahir
        ' 
        lblHasilTglLahir.AutoSize = True
        lblHasilTglLahir.Font = New Font("Segoe UI Semibold", 9F)
        lblHasilTglLahir.Location = New Point(120, 68)
        lblHasilTglLahir.Margin = New Padding(4, 0, 4, 0)
        lblHasilTglLahir.Name = "lblHasilTglLahir"
        lblHasilTglLahir.Size = New Size(15, 20)
        lblHasilTglLahir.TabIndex = 3
        lblHasilTglLahir.Text = "-"
        ' 
        ' LabelJK
        ' 
        LabelJK.AutoSize = True
        LabelJK.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LabelJK.ForeColor = Color.Gray
        LabelJK.Location = New Point(13, 108)
        LabelJK.Margin = New Padding(4, 0, 4, 0)
        LabelJK.Name = "LabelJK"
        LabelJK.Size = New Size(67, 19)
        LabelJK.TabIndex = 4
        LabelJK.Text = "GENDER:"
        ' 
        ' lblHasilJK
        ' 
        lblHasilJK.AutoSize = True
        lblHasilJK.Font = New Font("Segoe UI Semibold", 9F)
        lblHasilJK.Location = New Point(120, 106)
        lblHasilJK.Margin = New Padding(4, 0, 4, 0)
        lblHasilJK.Name = "lblHasilJK"
        lblHasilJK.Size = New Size(15, 20)
        lblHasilJK.TabIndex = 5
        lblHasilJK.Text = "-"
        ' 
        ' LabelTelp
        ' 
        LabelTelp.AutoSize = True
        LabelTelp.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LabelTelp.ForeColor = Color.Gray
        LabelTelp.Location = New Point(13, 146)
        LabelTelp.Margin = New Padding(4, 0, 4, 0)
        LabelTelp.Name = "LabelTelp"
        LabelTelp.Size = New Size(73, 19)
        LabelTelp.TabIndex = 6
        LabelTelp.Text = "TELEPON:"
        ' 
        ' lblHasilNoTelp
        ' 
        lblHasilNoTelp.AutoSize = True
        lblHasilNoTelp.Font = New Font("Segoe UI Semibold", 9F)
        lblHasilNoTelp.Location = New Point(120, 145)
        lblHasilNoTelp.Margin = New Padding(4, 0, 4, 0)
        lblHasilNoTelp.Name = "lblHasilNoTelp"
        lblHasilNoTelp.Size = New Size(15, 20)
        lblHasilNoTelp.TabIndex = 7
        lblHasilNoTelp.Text = "-"
        ' 
        ' LabelAlamat
        ' 
        LabelAlamat.AutoSize = True
        LabelAlamat.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LabelAlamat.ForeColor = Color.Gray
        LabelAlamat.Location = New Point(13, 185)
        LabelAlamat.Margin = New Padding(4, 0, 4, 0)
        LabelAlamat.Name = "LabelAlamat"
        LabelAlamat.Size = New Size(70, 19)
        LabelAlamat.TabIndex = 8
        LabelAlamat.Text = "ALAMAT:"
        ' 
        ' lblHasilAlamat
        ' 
        lblHasilAlamat.Font = New Font("Segoe UI Semibold", 9F)
        lblHasilAlamat.Location = New Point(120, 183)
        lblHasilAlamat.Margin = New Padding(4, 0, 4, 0)
        lblHasilAlamat.Name = "lblHasilAlamat"
        lblHasilAlamat.Size = New Size(280, 46)
        lblHasilAlamat.TabIndex = 9
        lblHasilAlamat.Text = "-"
        ' 
        ' LabelHobby
        ' 
        LabelHobby.AutoSize = True
        LabelHobby.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LabelHobby.ForeColor = Color.Gray
        LabelHobby.Location = New Point(13, 231)
        LabelHobby.Margin = New Padding(4, 0, 4, 0)
        LabelHobby.Name = "LabelHobby"
        LabelHobby.Size = New Size(62, 19)
        LabelHobby.TabIndex = 10
        LabelHobby.Text = "HOBBY:"
        ' 
        ' lblHasilHobby
        ' 
        lblHasilHobby.Font = New Font("Segoe UI Semibold", 9F)
        lblHasilHobby.Location = New Point(120, 229)
        lblHasilHobby.Margin = New Padding(4, 0, 4, 0)
        lblHasilHobby.Name = "lblHasilHobby"
        lblHasilHobby.Size = New Size(280, 46)
        lblHasilHobby.TabIndex = 11
        lblHasilHobby.Text = "-"
        ' 
        ' grpDetails
        ' 
        grpDetails.Controls.Add(LabelUmur)
        grpDetails.Controls.Add(lblHasilUmur)
        grpDetails.Controls.Add(LabelTL)
        grpDetails.Controls.Add(lblHasilTglLahir)
        grpDetails.Controls.Add(LabelJK)
        grpDetails.Controls.Add(lblHasilJK)
        grpDetails.Controls.Add(LabelTelp)
        grpDetails.Controls.Add(lblHasilNoTelp)
        grpDetails.Controls.Add(LabelAlamat)
        grpDetails.Controls.Add(lblHasilAlamat)
        grpDetails.Controls.Add(LabelHobby)
        grpDetails.Controls.Add(lblHasilHobby)
        grpDetails.Location = New Point(27, 477)
        grpDetails.Margin = New Padding(4, 5, 4, 5)
        grpDetails.Name = "grpDetails"
        grpDetails.Padding = New Padding(4, 5, 4, 5)
        grpDetails.Size = New Size(413, 292)
        grpDetails.TabIndex = 4
        grpDetails.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(467, 862)
        Controls.Add(grpDetails)
        Controls.Add(lblHasilNama)
        Controls.Add(picHasilFoto)
        Controls.Add(lblFooterTitle)
        Controls.Add(lblHeaderTitle)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ID Card Member"
        CType(picHasilFoto, ComponentModel.ISupportInitialize).EndInit()
        grpDetails.ResumeLayout(False)
        grpDetails.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblFooterTitle As Label
    Friend WithEvents picHasilFoto As PictureBox
    Friend WithEvents lblHasilNama As Label
    Friend WithEvents LabelUmur As Label
    Friend WithEvents lblHasilUmur As Label
    Friend WithEvents LabelTL As Label
    Friend WithEvents lblHasilTglLahir As Label
    Friend WithEvents LabelJK As Label
    Friend WithEvents lblHasilJK As Label
    Friend WithEvents LabelTelp As Label
    Friend WithEvents lblHasilNoTelp As Label
    Friend WithEvents LabelAlamat As Label
    Friend WithEvents lblHasilAlamat As Label
    Friend WithEvents LabelHobby As Label
    Friend WithEvents lblHasilHobby As Label
    Friend WithEvents grpDetails As GroupBox
End Class