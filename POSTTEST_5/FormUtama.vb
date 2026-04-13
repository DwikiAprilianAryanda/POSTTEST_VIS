Public Class FormUtama
    Private Sub btnKelolaData_Click(sender As Object, e As EventArgs) Handles btnKelolaData.Click
        ' Membuka form CRUD Handphone
        FormHandphone.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        ' Konfirmasi sebelum keluar
        Dim pesan As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pesan = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class