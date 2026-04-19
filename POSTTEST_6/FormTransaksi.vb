Imports MySql.Data.MySqlClient

Public Class FormTransaksi
    ' Konfigurasi Koneksi Database
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim strConn As String = "server=localhost;user id=root;password=;database=db_penjualan_hp"
    Dim hargaSatuan As Decimal = 0

    Sub BukaKoneksi()
        conn = New MySqlConnection(strConn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    ' Menampilkan data menggunakan INNER JOIN dari tabel berelasi
    Sub TampilDataTransaksi()
        BukaKoneksi()
        Dim query As String = "SELECT t.id_transaksi, t.tanggal_transaksi, t.nama_pembeli, h.merk, h.tipe, t.jumlah_beli, t.total_harga " &
                              "FROM tb_transaksi t INNER JOIN tb_handphone h ON t.id_hp = h.id_hp"
        da = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        da.Fill(dt)
        dgvTransaksi.DataSource = dt
    End Sub

    ' Memuat data Handphone ke dalam ComboBox (Relasi Data)
    Sub LoadDataHandphone()
        BukaKoneksi()
        Dim query As String = "SELECT id_hp, CONCAT(merk, ' - ', tipe) AS nama_hp FROM tb_handphone WHERE stok > 0"
        da = New MySqlDataAdapter(query, conn)
        Dim dtHp As New DataTable
        da.Fill(dtHp)

        cbHandphone.DataSource = dtHp
        cbHandphone.DisplayMember = "nama_hp" ' Teks yang ditampilkan
        cbHandphone.ValueMember = "id_hp"     ' Nilai ID yang disimpan sebagai Foreign Key
    End Sub

    Sub Bersih()
        txtIdTransaksi.Clear()
        txtNamaPembeli.Clear()
        txtJumlahBeli.Clear()
        txtTotalHarga.Clear()
        dtpTanggal.Value = DateTime.Now
        LoadDataHandphone()
        txtNamaPembeli.Focus()
    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDataTransaksi()
        Bersih()
    End Sub

    ' Fitur mengambil Harga otomatis saat ComboBox HP dipilih
    Private Sub cbHandphone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHandphone.SelectedIndexChanged
        If cbHandphone.SelectedValue IsNot Nothing AndAlso TypeOf cbHandphone.SelectedValue Is Integer Then
            BukaKoneksi()
            Dim query As String = "SELECT harga FROM tb_handphone WHERE id_hp = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", cbHandphone.SelectedValue)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                hargaSatuan = Convert.ToDecimal(result)
            End If
            HitungTotal()
        End If
    End Sub

    ' Event untuk menghitung total harga otomatis
    Private Sub txtJumlahBeli_TextChanged(sender As Object, e As EventArgs) Handles txtJumlahBeli.TextChanged
        HitungTotal()
    End Sub

    Sub HitungTotal()
        Dim jumlah As Integer = 0
        If Integer.TryParse(txtJumlahBeli.Text, jumlah) Then
            txtTotalHarga.Text = (jumlah * hargaSatuan).ToString()
        Else
            txtTotalHarga.Text = "0"
        End If
    End Sub

    ' Fitur SIMPAN (CREATE) Transaksi
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaPembeli.Text = "" Or txtJumlahBeli.Text = "" Then
            MessageBox.Show("Pastikan semua form terisi!")
        Else
            BukaKoneksi()
            Dim query As String = "INSERT INTO tb_transaksi (tanggal_transaksi, nama_pembeli, id_hp, jumlah_beli, total_harga) " &
                                  "VALUES (@tanggal, @nama, @id_hp, @jumlah, @total)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@nama", txtNamaPembeli.Text)
            cmd.Parameters.AddWithValue("@id_hp", cbHandphone.SelectedValue)
            cmd.Parameters.AddWithValue("@jumlah", txtJumlahBeli.Text)
            cmd.Parameters.AddWithValue("@total", txtTotalHarga.Text)
            cmd.ExecuteNonQuery()

            ' Fitur Tambahan: Mengurangi Stok Handphone setelah Transaksi Berhasil
            Dim updateStokQuery As String = "UPDATE tb_handphone SET stok = stok - @jumlah WHERE id_hp = @id_hp"
            Dim cmdUpdate = New MySqlCommand(updateStokQuery, conn)
            cmdUpdate.Parameters.AddWithValue("@jumlah", txtJumlahBeli.Text)
            cmdUpdate.Parameters.AddWithValue("@id_hp", cbHandphone.SelectedValue)
            cmdUpdate.ExecuteNonQuery()

            MessageBox.Show("Transaksi berhasil disimpan dan stok terpotong!")
            TampilDataTransaksi()
            Bersih()
        End If
    End Sub

    ' Fitur DELETE (Hapus Transaksi)
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtIdTransaksi.Text = "" Then
            MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!")
        Else
            Dim konfirmasi As DialogResult = MessageBox.Show("Hapus data transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo)
            If konfirmasi = DialogResult.Yes Then
                BukaKoneksi()
                Dim query As String = "DELETE FROM tb_transaksi WHERE id_transaksi=@id"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", txtIdTransaksi.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data transaksi dihapus!")
                TampilDataTransaksi()
                Bersih()
            End If
        End If
    End Sub

    ' CellClick DataGridView untuk Set ID saat ingin dihapus
    Private Sub dgvTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellClick
        Dim baris As Integer = dgvTransaksi.CurrentRow.Index
        txtIdTransaksi.Text = dgvTransaksi.Rows(baris).Cells(0).Value.ToString()
        ' (Untuk update transaksi, Anda bisa mengembangkan lebih lanjut, namun umumnya ID transaksi di-generate dan dilarang untuk diubah)
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Bersih()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FormUtama.Show()
        Me.Close()
    End Sub
End Class