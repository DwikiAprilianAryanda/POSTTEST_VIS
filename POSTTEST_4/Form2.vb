Public Class Form2

    ' Sub/Method khusus untuk menerima data dari Form 1
    Public Sub TampilkanData(foto As Image, nama As String, id As String, komunitas As String, peran As String, telepon As String, email As String, hobby As String)

        ' Set Foto
        If foto IsNot Nothing Then
            picHasilProfil.Image = foto
        Else
            picHasilProfil.BackColor = Color.LightGray ' Placeholder jika foto kosong
        End If

        ' Set Text pada Label
        lblHasilNama.Text = nama.ToUpper()
        lblHasilID.Text = "ID: " & id
        lblHasilKomunitas.Text = komunitas & " (" & peran & ")"
        lblHasilKontak.Text = "Kontak: " & telepon & " | " & email
        lblHasilHobby.Text = "Hobby/Aktivitas: " & vbCrLf & hobby

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Atur form agar tidak bisa di resize dan posisinya di tengah
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub picHasilProfil_Click(sender As Object, e As EventArgs) Handles picHasilProfil.Click

    End Sub
End Class