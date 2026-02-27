Public Class Form1
    Dim totalIP As Double
    Dim jumlahSemester As Integer

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim ipBaru As Double
        Dim Keterangan As String

        If Double.TryParse(TxtIpSemester.Text, ipBaru) Then

            If ipBaru < 0 Or ipBaru > 4 Then
                MessageBox.Show("Nilai IP harus 0 sampai 4!")
            Else
                totalIP = totalIP + ipBaru
                jumlahSemester = jumlahSemester + 1
                Dim ipk As Double = totalIP / jumlahSemester

                Dim ipkDibulatkan As Double = Math.Round(ipk, 2)

                TxtIpk.Text = ipkDibulatkan

                If ipkDibulatkan >= 3.01 Then
                    Keterangan = "Sangat Memuaskan"
                ElseIf ipkDibulatkan >= 2.76 Then
                    Keterangan = "Memuaskan"
                ElseIf ipkDibulatkan >= 2.0 Then
                    Keterangan = "Cukup"
                Else
                    Keterangan = "Kurang"
                End If

                LblPredikat.Text = Keterangan

                TxtIpSemester.Text = ""
            End If

        Else
            MessageBox.Show("Input harus angka!")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        totalIP = 0
        jumlahSemester = 0

        TxtIpSemester.Text = ""
        TxtIpk.Text = ""
        LblPredikat.Text = ""
    End Sub

End Class