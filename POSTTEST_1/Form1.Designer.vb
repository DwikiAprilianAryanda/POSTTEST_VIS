<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label2 = New Label()
        LblPredikat = New Label()
        TxtIpSemester = New TextBox()
        TxtIpk = New TextBox()
        BtnTambah = New Button()
        BtnReset = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(161, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(161, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 1
        Label2.Text = "IP Kumulatif"
        ' 
        ' LblPredikat
        ' 
        LblPredikat.AutoSize = True
        LblPredikat.Location = New Point(273, 238)
        LblPredikat.Name = "LblPredikat"
        LblPredikat.Size = New Size(53, 20)
        LblPredikat.TabIndex = 2
        LblPredikat.Text = "Label3"
        ' 
        ' TxtIpSemester
        ' 
        TxtIpSemester.Location = New Point(273, 120)
        TxtIpSemester.Name = "TxtIpSemester"
        TxtIpSemester.Size = New Size(194, 27)
        TxtIpSemester.TabIndex = 3
        ' 
        ' TxtIpk
        ' 
        TxtIpk.Location = New Point(273, 191)
        TxtIpk.Name = "TxtIpk"
        TxtIpk.ReadOnly = True
        TxtIpk.Size = New Size(194, 27)
        TxtIpk.TabIndex = 4
        ' 
        ' BtnTambah
        ' 
        BtnTambah.Location = New Point(273, 153)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(94, 29)
        BtnTambah.TabIndex = 5
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Location = New Point(373, 153)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(94, 29)
        BtnReset.TabIndex = 6
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnReset)
        Controls.Add(BtnTambah)
        Controls.Add(TxtIpk)
        Controls.Add(TxtIpSemester)
        Controls.Add(LblPredikat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblPredikat As Label
    Friend WithEvents TxtIpSemester As TextBox
    Friend WithEvents TxtIpk As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnReset As Button

End Class
