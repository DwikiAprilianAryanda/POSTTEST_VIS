Imports MySql.Data.MySqlClient

Public Class FormHandphone
    ' Konfigurasi Koneksi Database
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim strConn As String = "server=localhost;user id=root;password=;database=db_penjualan_hp"

    ' Subroutine untuk koneksi
    Sub BukaKoneksi()
        conn = New MySqlConnection(strConn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    ' Subroutine (Read) untuk menampilkan data ke DataGridView
    Sub TampilData()
        BukaKoneksi()
        da = New MySqlDataAdapter("SELECT * FROM tb_handphone", conn)
        dt = New DataTable
        da.Fill(dt)
        dgvData.DataSource = dt
    End Sub

    ' Subroutine untuk mengosongkan form
    Sub Bersih()
        txtId.Clear()
        txtMerk.Clear()
        txtTipe.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        txtCari.Clear()
        txtMerk.Focus()
    End Sub

    Private Sub FormHandphone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Bersih()
    End Sub

    ' Fitur CREATE (Simpan)
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtMerk.Text = "" Or txtTipe.Text = "" Or txtHarga.Text = "" Or txtStok.Text = "" Then
            MessageBox.Show("Pastikan semua form terisi!")
        Else
            BukaKoneksi()
            Dim query As String = "INSERT INTO tb_handphone (merk, tipe, harga, stok) VALUES (@merk, @tipe, @harga, @stok)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@merk", txtMerk.Text)
            cmd.Parameters.AddWithValue("@tipe", txtTipe.Text)
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
            cmd.Parameters.AddWithValue("@stok", txtStok.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan!")
            TampilData()
            Bersih()
        End If
    End Sub

    ' Menampilkan data ke TextBox saat baris DataGridView diklik (Persiapan Update/Delete)
    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        Dim baris As Integer = dgvData.CurrentRow.Index
        txtId.Text = dgvData.Rows(baris).Cells(0).Value.ToString()
        txtMerk.Text = dgvData.Rows(baris).Cells(1).Value.ToString()
        txtTipe.Text = dgvData.Rows(baris).Cells(2).Value.ToString()
        txtHarga.Text = dgvData.Rows(baris).Cells(3).Value.ToString()
        txtStok.Text = dgvData.Rows(baris).Cells(4).Value.ToString()
    End Sub

    ' Fitur UPDATE (Ubah)
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtId.Text = "" Then
            MessageBox.Show("Pilih data yang ingin diubah terlebih dahulu!")
        Else
            BukaKoneksi()
            Dim query As String = "UPDATE tb_handphone SET merk=@merk, tipe=@tipe, harga=@harga, stok=@stok WHERE id_hp=@id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@merk", txtMerk.Text)
            cmd.Parameters.AddWithValue("@tipe", txtTipe.Text)
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
            cmd.Parameters.AddWithValue("@stok", txtStok.Text)
            cmd.Parameters.AddWithValue("@id", txtId.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diubah!")
            TampilData()
            Bersih()
        End If
    End Sub

    ' Fitur DELETE (Hapus)
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtId.Text = "" Then
            MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!")
        Else
            Dim konfirmasi As DialogResult = MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo)
            If konfirmasi = DialogResult.Yes Then
                BukaKoneksi()
                Dim query As String = "DELETE FROM tb_handphone WHERE id_hp=@id"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", txtId.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus!")
                TampilData()
                Bersih()
            End If
        End If
    End Sub

    ' Fitur SEARCH (Pencarian dinamis berdasarkan Merk atau Tipe)
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        BukaKoneksi()
        Dim query As String = "SELECT * FROM tb_handphone WHERE merk LIKE @cari OR tipe LIKE @cari"
        da = New MySqlDataAdapter(query, conn)
        da.SelectCommand.Parameters.AddWithValue("@cari", "%" & txtCari.Text & "%")
        dt = New DataTable
        da.Fill(dt)
        dgvData.DataSource = dt
    End Sub

    ' Tombol Batal untuk clear form
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Bersih()
    End Sub

    ' Kembali ke Form Utama
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FormUtama.Show()
        Me.Close()
    End Sub
End Class