<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanVien
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
        tbMatKhau = New TextBox()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        rbNu = New RadioButton()
        rbNam = New RadioButton()
        tbTimKiem = New TextBox()
        bXoa = New Button()
        bCapNhat = New Button()
        bThem = New Button()
        tbTen = New TextBox()
        tbTaiKhoan = New TextBox()
        tbDiaChi = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dgvDanhSach = New DataGridView()
        bPhucHoi = New Button()
        cbHienThiXoa = New CheckBox()
        GroupBox1.SuspendLayout()
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbMatKhau
        ' 
        tbMatKhau.Location = New Point(533, 205)
        tbMatKhau.Name = "tbMatKhau"
        tbMatKhau.PasswordChar = "*"c
        tbMatKhau.Size = New Size(203, 23)
        tbMatKhau.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(460, 207)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 15
        Label4.Text = "Mat khau:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbNu)
        GroupBox1.Controls.Add(rbNam)
        GroupBox1.Location = New Point(460, 77)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(276, 68)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gioi tinh"
        ' 
        ' rbNu
        ' 
        rbNu.AutoSize = True
        rbNu.Location = New Point(109, 31)
        rbNu.Name = "rbNu"
        rbNu.Size = New Size(41, 19)
        rbNu.TabIndex = 1
        rbNu.TabStop = True
        rbNu.Text = "Nu"
        rbNu.UseVisualStyleBackColor = True
        ' 
        ' rbNam
        ' 
        rbNam.AutoSize = True
        rbNam.Location = New Point(6, 31)
        rbNam.Name = "rbNam"
        rbNam.Size = New Size(51, 19)
        rbNam.TabIndex = 0
        rbNam.TabStop = True
        rbNam.Text = "Nam"
        rbNam.UseVisualStyleBackColor = True
        ' 
        ' tbTimKiem
        ' 
        tbTimKiem.Location = New Point(3, 3)
        tbTimKiem.Name = "tbTimKiem"
        tbTimKiem.Size = New Size(425, 23)
        tbTimKiem.TabIndex = 8
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(661, 249)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(75, 23)
        bXoa.TabIndex = 7
        bXoa.Text = "Xoa"
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(565, 250)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(75, 23)
        bCapNhat.TabIndex = 6
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(462, 251)
        bThem.Name = "bThem"
        bThem.Size = New Size(75, 23)
        bThem.TabIndex = 5
        bThem.Text = "Them"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(533, 2)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(203, 23)
        tbTen.TabIndex = 0
        ' 
        ' tbTaiKhoan
        ' 
        tbTaiKhoan.Location = New Point(533, 159)
        tbTaiKhoan.Name = "tbTaiKhoan"
        tbTaiKhoan.Size = New Size(203, 23)
        tbTaiKhoan.TabIndex = 3
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(533, 38)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(203, 23)
        tbDiaChi.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(460, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 14
        Label3.Text = "Tai Khoan:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(460, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 11
        Label2.Text = "Ten:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(460, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 12
        Label1.Text = "Dia chi:"
        ' 
        ' dgvDanhSach
        ' 
        dgvDanhSach.AllowUserToAddRows = False
        dgvDanhSach.AllowUserToDeleteRows = False
        dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSach.Location = New Point(3, 38)
        dgvDanhSach.Name = "dgvDanhSach"
        dgvDanhSach.ReadOnly = True
        dgvDanhSach.Size = New Size(425, 391)
        dgvDanhSach.TabIndex = 9
        ' 
        ' bPhucHoi
        ' 
        bPhucHoi.Location = New Point(661, 285)
        bPhucHoi.Name = "bPhucHoi"
        bPhucHoi.Size = New Size(75, 23)
        bPhucHoi.TabIndex = 11
        bPhucHoi.Text = "Phuc hoi"
        bPhucHoi.UseVisualStyleBackColor = True
        ' 
        ' cbHienThiXoa
        ' 
        cbHienThiXoa.AutoSize = True
        cbHienThiXoa.Location = New Point(465, 289)
        cbHienThiXoa.Name = "cbHienThiXoa"
        cbHienThiXoa.Size = New Size(179, 19)
        cbHienThiXoa.TabIndex = 10
        cbHienThiXoa.Text = "Hien thi cac nhan vien bi xoa"
        cbHienThiXoa.UseVisualStyleBackColor = True
        ' 
        ' frmNhanVien
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tbMatKhau)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(tbTimKiem)
        Controls.Add(bXoa)
        Controls.Add(bCapNhat)
        Controls.Add(bThem)
        Controls.Add(tbTen)
        Controls.Add(tbTaiKhoan)
        Controls.Add(tbDiaChi)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvDanhSach)
        Controls.Add(bPhucHoi)
        Controls.Add(cbHienThiXoa)
        Name = "frmNhanVien"
        Text = "frmNhanVien"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNu As RadioButton
    Friend WithEvents rbNam As RadioButton
    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents bXoa As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bThem As Button
    Friend WithEvents tbTen As TextBox
    Friend WithEvents tbTaiKhoan As TextBox
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents bPhucHoi As Button
    Friend WithEvents cbHienThiXoa As CheckBox
End Class
