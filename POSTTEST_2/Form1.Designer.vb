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

    ' Deklarasi Komponen UI
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents txtJudulTambah As System.Windows.Forms.TextBox
    Friend WithEvents txtGenreTambah As System.Windows.Forms.TextBox
    Friend WithEvents txtJudulHapus As System.Windows.Forms.TextBox
    Friend WithEvents listBuku As System.Windows.Forms.ListBox
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpTambah As System.Windows.Forms.GroupBox
    Friend WithEvents grpHapus As System.Windows.Forms.GroupBox
    Friend WithEvents lblJudulTambah As System.Windows.Forms.Label
    Friend WithEvents lblGenreTambah As System.Windows.Forms.Label
    Friend WithEvents lblJudulHapus As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnTambah = New Button()
        btnHapus = New Button()
        txtJudulTambah = New TextBox()
        txtGenreTambah = New TextBox()
        txtJudulHapus = New TextBox()
        listBuku = New ListBox()
        pnlHeader = New Panel()
        lblTitle = New Label()
        grpTambah = New GroupBox()
        lblGenreTambah = New Label()
        lblJudulTambah = New Label()
        grpHapus = New GroupBox()
        lblJudulHapus = New Label()
        pnlHeader.SuspendLayout()
        grpTambah.SuspendLayout()
        grpHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        btnTambah.Cursor = Cursors.Hand
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(100, 100)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(150, 35)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(100, 65)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 35)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Location = New Point(100, 27)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(150, 29)
        txtJudulTambah.TabIndex = 1
        ' 
        ' txtGenreTambah
        ' 
        txtGenreTambah.Location = New Point(100, 62)
        txtGenreTambah.Name = "txtGenreTambah"
        txtGenreTambah.Size = New Size(150, 29)
        txtGenreTambah.TabIndex = 3
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Location = New Point(100, 27)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(150, 29)
        txtJudulHapus.TabIndex = 1
        ' 
        ' listBuku
        ' 
        listBuku.BorderStyle = BorderStyle.FixedSingle
        listBuku.Font = New Font("Segoe UI", 11.25F)
        listBuku.FormattingEnabled = True
        listBuku.Location = New Point(20, 260)
        listBuku.Name = "listBuku"
        listBuku.Size = New Size(560, 177)
        listBuku.TabIndex = 3
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(604, 60)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(372, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "DAFTAR BUKU PERPUSTAKAAN"
        ' 
        ' grpTambah
        ' 
        grpTambah.BackColor = Color.White
        grpTambah.Controls.Add(btnTambah)
        grpTambah.Controls.Add(txtGenreTambah)
        grpTambah.Controls.Add(lblGenreTambah)
        grpTambah.Controls.Add(txtJudulTambah)
        grpTambah.Controls.Add(lblJudulTambah)
        grpTambah.Location = New Point(20, 80)
        grpTambah.Name = "grpTambah"
        grpTambah.Size = New Size(270, 160)
        grpTambah.TabIndex = 1
        grpTambah.TabStop = False
        grpTambah.Text = "Tambah Buku Baru"
        ' 
        ' lblGenreTambah
        ' 
        lblGenreTambah.AutoSize = True
        lblGenreTambah.Location = New Point(15, 65)
        lblGenreTambah.Name = "lblGenreTambah"
        lblGenreTambah.Size = New Size(56, 23)
        lblGenreTambah.TabIndex = 2
        lblGenreTambah.Text = "Genre"
        ' 
        ' lblJudulTambah
        ' 
        lblJudulTambah.AutoSize = True
        lblJudulTambah.Location = New Point(15, 30)
        lblJudulTambah.Name = "lblJudulTambah"
        lblJudulTambah.Size = New Size(93, 23)
        lblJudulTambah.TabIndex = 0
        lblJudulTambah.Text = "Judul Buku"
        ' 
        ' grpHapus
        ' 
        grpHapus.BackColor = Color.White
        grpHapus.Controls.Add(btnHapus)
        grpHapus.Controls.Add(txtJudulHapus)
        grpHapus.Controls.Add(lblJudulHapus)
        grpHapus.Location = New Point(310, 80)
        grpHapus.Name = "grpHapus"
        grpHapus.Size = New Size(270, 160)
        grpHapus.TabIndex = 2
        grpHapus.TabStop = False
        grpHapus.Text = "Hapus Buku"
        ' 
        ' lblJudulHapus
        ' 
        lblJudulHapus.AutoSize = True
        lblJudulHapus.Location = New Point(15, 30)
        lblJudulHapus.Name = "lblJudulHapus"
        lblJudulHapus.Size = New Size(93, 23)
        lblJudulHapus.TabIndex = 0
        lblJudulHapus.Text = "Judul Buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 21.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        ClientSize = New Size(604, 481)
        Controls.Add(listBuku)
        Controls.Add(grpHapus)
        Controls.Add(grpTambah)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.75F)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen Perpustakaan"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        grpTambah.ResumeLayout(False)
        grpTambah.PerformLayout()
        grpHapus.ResumeLayout(False)
        grpHapus.PerformLayout()
        ResumeLayout(False)

    End Sub
End Class