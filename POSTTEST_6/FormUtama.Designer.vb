<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        btnKelolaData = New Button()
        btnKeluar = New Button()
        btnMenuTransaksi = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(50, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(474, 38)
        Label1.TabIndex = 0
        Label1.Text = "SISTEM PENJUALAN HANDPHONE"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnKelolaData
        ' 
        btnKelolaData.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnKelolaData.Location = New Point(135, 120)
        btnKelolaData.Name = "btnKelolaData"
        btnKelolaData.Size = New Size(250, 50)
        btnKelolaData.TabIndex = 1
        btnKelolaData.Text = "Kelola Data Handphone"
        btnKelolaData.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnKeluar.Location = New Point(135, 252)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(250, 50)
        btnKeluar.TabIndex = 2
        btnKeluar.Text = "Keluar Program"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' btnMenuTransaksi
        ' 
        btnMenuTransaksi.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMenuTransaksi.Location = New Point(135, 186)
        btnMenuTransaksi.Name = "btnMenuTransaksi"
        btnMenuTransaksi.Size = New Size(250, 50)
        btnMenuTransaksi.TabIndex = 3
        btnMenuTransaksi.Text = "Kelola Transaksi"
        btnMenuTransaksi.UseVisualStyleBackColor = True
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 334)
        Controls.Add(btnMenuTransaksi)
        Controls.Add(btnKeluar)
        Controls.Add(btnKelolaData)
        Controls.Add(Label1)
        Name = "FormUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu Utama - Dwiki"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnKelolaData As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnMenuTransaksi As Button
End Class