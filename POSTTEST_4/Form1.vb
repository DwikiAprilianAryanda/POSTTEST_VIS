Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup awal
        cmbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    ' 1. Validasi Nama Hanya Huruf
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = ControlChars.Back OrElse e.KeyChar = " "c) Then
            e.Handled = True
        End If
    End Sub

    ' 2. Validasi Umur & Nomor Telepon Hanya Angka (Untuk MaskedTextBox sudah diatur via Mask di UI)
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    ' 3. Browse Foto Profil
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    ' 4. Proses Simpan & Cetak Kartu
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        ' Error Handling Inputan Kosong (TextBox & MaskedTextBox)
        ' Guard against potential null controls and use String.IsNullOrWhiteSpace for safer checks
        If String.IsNullOrWhiteSpace(If(txtNama?.Text, "")) OrElse
           String.IsNullOrWhiteSpace(If(txtID?.Text, "")) OrElse
           String.IsNullOrWhiteSpace(If(txtUmur?.Text, "")) OrElse
           String.IsNullOrWhiteSpace(If(txtEmail?.Text, "")) OrElse
           String.IsNullOrWhiteSpace(If(txtAlamat?.Text, "")) OrElse
           (mtbTelepon IsNot Nothing AndAlso Not mtbTelepon.MaskCompleted) OrElse
           (cmbKomunitas IsNot Nothing AndAlso cmbKomunitas.SelectedIndex = -1) Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi RadioButton (Gender & Peran)
        If Not (rbPria.Checked Or rbWanita.Checked) OrElse Not (rbKetua.Checked Or rbAnggota.Checked Or rbAdmin.Checked) Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi Checkbox Minimal 1 Hobby Terpilih
        Dim hobbyTerpilih As String = ""
        Dim checkBoxes() As CheckBox = {chkHobby1, chkHobby2, chkHobby3, chkHobby4, chkHobby5, chkHobby6, chkHobby7, chkHobby8}
        Dim isHobbyChecked As Boolean = False

        For Each chk In checkBoxes
            If chk.Checked Then
                isHobbyChecked = True
                hobbyTerpilih &= chk.Text & ", "
            End If
        Next

        If Not isHobbyChecked Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Dialog Konfirmasi Cetak
        Dim result As DialogResult = MessageBox.Show("Data sudah lengkap. Apakah Anda ingin mencetak kartu?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            hobbyTerpilih = hobbyTerpilih.TrimEnd(","c, " "c) ' Bersihkan koma di akhir
            Dim peran As String = If(rbKetua.Checked, "Ketua", If(rbAnggota.Checked, "Anggota", "Admin"))
            Dim gender As String = If(rbPria.Checked, "Pria", "Wanita")

            ' Buka Form 2 dan kirim data
            Dim frmKartu As New Form2()
            frmKartu.TampilkanData(picProfil.Image, txtNama.Text, txtID.Text, cmbKomunitas.Text, peran, mtbTelepon.Text, txtEmail.Text, hobbyTerpilih)
            frmKartu.ShowDialog()
        End If
    End Sub

    ' 5. Menu Navigasi
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        btnSimpanCetak.PerformClick()
    End Sub

    ' Fitur Save Data (TXT/CSV)
    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text Files|*.txt|CSV Files|*.csv"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim dataToSave As String = $"Nama: {txtNama.Text}, ID: {txtID.Text}, Komunitas: {cmbKomunitas.Text}"
            File.WriteAllText(SaveFileDialog1.FileName, dataToSave)
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Fitur Load Data
    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text/CSV Files|*.txt;*.csv"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim content As String = File.ReadAllText(OpenFileDialog1.FileName)
            MessageBox.Show("Isi File:" & vbCrLf & content, "Data Dibuka", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class