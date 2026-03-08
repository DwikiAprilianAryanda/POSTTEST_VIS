Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TambahDataBuku("Harry Potter", "Fantasi")
        TambahDataBuku("Sherlock Holmes", "Misteri")

        UpdateTampilanList(listBuku)
    End Sub

    Private Sub UpdateTampilanList(ByRef listUI As ListBox)
        listUI.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            listUI.Items.Add(daftarBuku(i, 0) & " - [" & daftarBuku(i, 1) & "]")
        Next
    End Sub

    Private Sub TambahDataBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        Else
            MessageBox.Show("Kapasitas perpustakaan penuh!")
        End If
    End Sub

    ' TOMBOL TAMBAH
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtJudulTambah.Text.Trim()
        Dim genre As String = txtGenreTambah.Text.Trim()

        If judul = "" Or genre = "" Then
            MessageBox.Show("Mohon isi Judul dan Genre buku!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If CariIndeksBuku(judul) <> -1 Then
            MessageBox.Show("Buku dengan judul tersebut sudah ada di daftar!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        TambahDataBuku(judul, genre)

        UpdateTampilanList(listBuku)

        txtJudulTambah.Clear()
        txtGenreTambah.Clear()
        txtJudulTambah.Focus()
    End Sub

    ' TOMBOL HAPUS
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtJudulHapus.Text.Trim()

        If judul = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim index As Integer = CariIndeksBuku(judul)

        If index = -1 Then
            MessageBox.Show("Buku tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        For i As Integer = index To jumlahBuku - 2
            daftarBuku(i, 0) = daftarBuku(i + 1, 0)
            daftarBuku(i, 1) = daftarBuku(i + 1, 1)
        Next

        daftarBuku(jumlahBuku - 1, 0) = ""
        daftarBuku(jumlahBuku - 1, 1) = ""
        jumlahBuku -= 1

        UpdateTampilanList(listBuku)
        txtJudulHapus.Clear()
        MessageBox.Show("Buku berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class