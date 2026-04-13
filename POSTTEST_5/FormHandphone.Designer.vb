<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHandphone
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtId = New TextBox()
        txtMerk = New TextBox()
        txtTipe = New TextBox()
        txtHarga = New TextBox()
        txtStok = New TextBox()
        txtCari = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnKembali = New Button()
        dgvData = New DataGridView()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 0
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 20)
        Label2.TabIndex = 1
        Label2.Text = "Merk"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 2
        Label3.Text = "Nama"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 3
        Label4.Text = "Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 20)
        Label5.TabIndex = 4
        Label5.Text = "Stok"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(420, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 20)
        Label6.TabIndex = 5
        Label6.Text = "Cari Data"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(120, 27)
        txtId.Name = "txtId"
        txtId.ReadOnly = True
        txtId.Size = New Size(250, 27)
        txtId.TabIndex = 6
        ' 
        ' txtMerk
        ' 
        txtMerk.Location = New Point(120, 67)
        txtMerk.Name = "txtMerk"
        txtMerk.Size = New Size(250, 27)
        txtMerk.TabIndex = 7
        ' 
        ' txtTipe
        ' 
        txtTipe.Location = New Point(120, 107)
        txtTipe.Name = "txtTipe"
        txtTipe.Size = New Size(250, 27)
        txtTipe.TabIndex = 8
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(120, 147)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(250, 27)
        txtHarga.TabIndex = 9
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(120, 187)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(250, 27)
        txtStok.TabIndex = 10
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(496, 27)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(400, 27)
        txtCari.TabIndex = 11
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(30, 240)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(80, 35)
        btnSimpan.TabIndex = 12
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(116, 240)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(80, 35)
        btnUbah.TabIndex = 13
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(202, 240)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(80, 35)
        btnHapus.TabIndex = 14
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(288, 240)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(82, 35)
        btnBatal.TabIndex = 15
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(814, 490)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(82, 35)
        btnKembali.TabIndex = 16
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' dgvData
        ' 
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(420, 67)
        dgvData.Name = "dgvData"
        dgvData.RowHeadersWidth = 51
        dgvData.Size = New Size(476, 408)
        dgvData.TabIndex = 17
        ' 
        ' FormHandphone
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(920, 545)
        Controls.Add(dgvData)
        Controls.Add(btnKembali)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtCari)
        Controls.Add(txtStok)
        Controls.Add(txtHarga)
        Controls.Add(txtTipe)
        Controls.Add(txtMerk)
        Controls.Add(txtId)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormHandphone"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kelola Data Handphone"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents txtTipe As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents dgvData As DataGridView
End Class