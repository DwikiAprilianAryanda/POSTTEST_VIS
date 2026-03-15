Imports System.IO

Public Class Form1

    ' Validasi input Nama HANYA HURUF
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' Validasi input Umur HANYA ANGKA
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' Validasi input No Telp HANYA ANGKA
    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' Menampilkan dialog pilih gambar
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Pilih Gambar"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            picProfile.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    ' Logika Button Cetak Kartu dengan Error Handling 
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text.Trim() = "" OrElse txtUmur.Text.Trim() = "" OrElse txtNoTelp.Text.Trim() = "" OrElse txtAlamat.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If rbLaki.Checked = False And rbPerempuan.Checked = False Then
            MessageBox.Show("Inputan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim listHobby As String = ""
        Dim checkedBoxes As CheckBox() = {chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8, chk9, chk10}

        For Each chk In checkedBoxes
            If chk.Checked Then
                listHobby &= chk.Text & ", "
            End If
        Next

        If listHobby = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If picProfile.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' JIKA SEMUA VALIDASI LOLOS
        Dim frm2 As New Form2()

        frm2.lblHasilNama.Text = txtNama.Text
        frm2.lblHasilUmur.Text = txtUmur.Text & " Tahun"
        frm2.lblHasilTglLahir.Text = dtpTanggalLahir.Value.ToString("dd MMMM yyyy")
        frm2.lblHasilNoTelp.Text = txtNoTelp.Text
        frm2.lblHasilAlamat.Text = txtAlamat.Text

        If rbLaki.Checked Then
            frm2.lblHasilJK.Text = "Laki-Laki"
        Else
            frm2.lblHasilJK.Text = "Perempuan"
        End If

        ' Menghilangkan koma berlebih di akhir hobi
        frm2.lblHasilHobby.Text = listHobby.TrimEnd(", ".ToCharArray())
        frm2.picHasilFoto.Image = picProfile.Image

        frm2.Show()

    End Sub
End Class