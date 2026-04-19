<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdTransaksi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaPembeli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbHandphone = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJumlahBeli = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Transaksi"
        '
        'txtIdTransaksi
        '
        Me.txtIdTransaksi.Enabled = False
        Me.txtIdTransaksi.Location = New System.Drawing.Point(130, 27)
        Me.txtIdTransaksi.Name = "txtIdTransaksi"
        Me.txtIdTransaksi.Size = New System.Drawing.Size(200, 20)
        Me.txtIdTransaksi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Pembeli"
        '
        'txtNamaPembeli
        '
        Me.txtNamaPembeli.Location = New System.Drawing.Point(130, 57)
        Me.txtNamaPembeli.Name = "txtNamaPembeli"
        Me.txtNamaPembeli.Size = New System.Drawing.Size(200, 20)
        Me.txtNamaPembeli.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Handphone"
        '
        'cbHandphone
        '
        Me.cbHandphone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHandphone.FormattingEnabled = True
        Me.cbHandphone.Location = New System.Drawing.Point(130, 87)
        Me.cbHandphone.Name = "cbHandphone"
        Me.cbHandphone.Size = New System.Drawing.Size(200, 21)
        Me.cbHandphone.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jumlah Beli"
        '
        'txtJumlahBeli
        '
        Me.txtJumlahBeli.Location = New System.Drawing.Point(130, 117)
        Me.txtJumlahBeli.Name = "txtJumlahBeli"
        Me.txtJumlahBeli.Size = New System.Drawing.Size(200, 20)
        Me.txtJumlahBeli.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Harga"
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Enabled = False
        Me.txtTotalHarga.Location = New System.Drawing.Point(130, 147)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.Size = New System.Drawing.Size(200, 20)
        Me.txtTotalHarga.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tanggal"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(130, 177)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggal.TabIndex = 11
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(30, 220)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(115, 220)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 13
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(200, 220)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 14
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(285, 220)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(75, 23)
        Me.btnKembali.TabIndex = 15
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'dgvTransaksi
        '
        Me.dgvTransaksi.AllowUserToAddRows = False
        Me.dgvTransaksi.AllowUserToDeleteRows = False
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaksi.Location = New System.Drawing.Point(30, 260)
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.ReadOnly = True
        Me.dgvTransaksi.Size = New System.Drawing.Size(720, 160)
        Me.dgvTransaksi.TabIndex = 16
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvTransaksi)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtJumlahBeli)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbHandphone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaPembeli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdTransaksi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransaksi"
        Me.Text = "Data Transaksi"
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPembeli As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbHandphone As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahBeli As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents dgvTransaksi As System.Windows.Forms.DataGridView

End Class