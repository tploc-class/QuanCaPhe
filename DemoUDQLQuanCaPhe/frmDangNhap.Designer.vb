<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        tbTenDangNhap = New TextBox()
        tbMatKhau = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        bDangNhap = New Button()
        bThoat = New Button()
        lKetQua = New Label()
        SuspendLayout()
        ' 
        ' tbTenDangNhap
        ' 
        tbTenDangNhap.Location = New Point(105, 40)
        tbTenDangNhap.Name = "tbTenDangNhap"
        tbTenDangNhap.Size = New Size(183, 23)
        tbTenDangNhap.TabIndex = 0
        tbTenDangNhap.Text = "tploc"
        ' 
        ' tbMatKhau
        ' 
        tbMatKhau.Location = New Point(105, 87)
        tbMatKhau.Name = "tbMatKhau"
        tbMatKhau.PasswordChar = "*"c
        tbMatKhau.Size = New Size(183, 23)
        tbMatKhau.TabIndex = 1
        tbMatKhau.Text = "123456"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 2
        Label1.Text = "Ten dang nhap"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 3
        Label2.Text = "Mat Khau"
        ' 
        ' bDangNhap
        ' 
        bDangNhap.Location = New Point(343, 40)
        bDangNhap.Name = "bDangNhap"
        bDangNhap.Size = New Size(75, 23)
        bDangNhap.TabIndex = 4
        bDangNhap.Text = "Dang nhap"
        bDangNhap.UseVisualStyleBackColor = True
        ' 
        ' bThoat
        ' 
        bThoat.Location = New Point(343, 87)
        bThoat.Name = "bThoat"
        bThoat.Size = New Size(75, 23)
        bThoat.TabIndex = 5
        bThoat.Text = "Thoat"
        bThoat.UseVisualStyleBackColor = True
        ' 
        ' lKetQua
        ' 
        lKetQua.AutoSize = True
        lKetQua.ForeColor = Color.Red
        lKetQua.Location = New Point(12, 124)
        lKetQua.Name = "lKetQua"
        lKetQua.Size = New Size(0, 15)
        lKetQua.TabIndex = 6
        ' 
        ' frmDangNhap
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(454, 148)
        Controls.Add(lKetQua)
        Controls.Add(bThoat)
        Controls.Add(bDangNhap)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbMatKhau)
        Controls.Add(tbTenDangNhap)
        Name = "frmDangNhap"
        Text = "frmDangNhap"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbTenDangNhap As TextBox
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bDangNhap As Button
    Friend WithEvents bThoat As Button
    Friend WithEvents lKetQua As Label
End Class
