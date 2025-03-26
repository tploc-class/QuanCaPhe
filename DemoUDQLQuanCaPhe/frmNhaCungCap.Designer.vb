<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhaCungCap
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
        tbTimKiem = New TextBox()
        bXoa = New Button()
        bCapNhat = New Button()
        bThem = New Button()
        tbTen = New TextBox()
        tbDiaChi = New TextBox()
        tbMa = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dgvDanhSach = New DataGridView()
        ColorDialog1 = New ColorDialog()
        bPhucHoi = New Button()
        cbHienThiXoa = New CheckBox()
        Label4 = New Label()
        tbGhiChu = New TextBox()
        Label5 = New Label()
        mtbDienThoai = New MaskedTextBox()
        dgvDSNguyenLieu = New DataGridView()
        bXoaNguyenLieu = New Button()
        bCapNhatNguyenLieu = New Button()
        bThemNguyenLieu = New Button()
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDSNguyenLieu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbTimKiem
        ' 
        tbTimKiem.Location = New Point(12, 12)
        tbTimKiem.Name = "tbTimKiem"
        tbTimKiem.Size = New Size(425, 23)
        tbTimKiem.TabIndex = 31
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(731, 119)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(75, 23)
        bXoa.TabIndex = 30
        bXoa.Text = "Xoa"
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(731, 81)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(75, 23)
        bCapNhat.TabIndex = 29
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(731, 40)
        bThem.Name = "bThem"
        bThem.Size = New Size(75, 23)
        bThem.TabIndex = 27
        bThem.Text = "Them"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(542, 79)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(156, 23)
        tbTen.TabIndex = 23
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(542, 117)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(156, 23)
        tbDiaChi.TabIndex = 25
        ' 
        ' tbMa
        ' 
        tbMa.Location = New Point(542, 40)
        tbMa.Name = "tbMa"
        tbMa.Size = New Size(156, 23)
        tbMa.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(469, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 15)
        Label3.TabIndex = 28
        Label3.Text = "Dia chi:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(469, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 26
        Label2.Text = "Ten:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(469, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 15)
        Label1.TabIndex = 24
        Label1.Text = "Ma:"
        ' 
        ' dgvDanhSach
        ' 
        dgvDanhSach.AllowUserToAddRows = False
        dgvDanhSach.AllowUserToDeleteRows = False
        dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSach.Location = New Point(12, 47)
        dgvDanhSach.Name = "dgvDanhSach"
        dgvDanhSach.ReadOnly = True
        dgvDanhSach.Size = New Size(425, 551)
        dgvDanhSach.TabIndex = 22
        ' 
        ' bPhucHoi
        ' 
        bPhucHoi.Location = New Point(634, 229)
        bPhucHoi.Name = "bPhucHoi"
        bPhucHoi.Size = New Size(75, 23)
        bPhucHoi.TabIndex = 35
        bPhucHoi.Text = "Phuc hoi"
        bPhucHoi.UseVisualStyleBackColor = True
        ' 
        ' cbHienThiXoa
        ' 
        cbHienThiXoa.AutoSize = True
        cbHienThiXoa.Location = New Point(465, 232)
        cbHienThiXoa.Name = "cbHienThiXoa"
        cbHienThiXoa.Size = New Size(168, 19)
        cbHienThiXoa.TabIndex = 34
        cbHienThiXoa.Text = "Hien thi cac mon an bi xoa"
        cbHienThiXoa.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(469, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 37
        Label4.Text = "Dien thoai:"
        ' 
        ' tbGhiChu
        ' 
        tbGhiChu.Location = New Point(542, 200)
        tbGhiChu.Name = "tbGhiChu"
        tbGhiChu.Size = New Size(156, 23)
        tbGhiChu.TabIndex = 38
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(469, 202)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 15)
        Label5.TabIndex = 39
        Label5.Text = "Ghi chu:"
        ' 
        ' mtbDienThoai
        ' 
        mtbDienThoai.Location = New Point(542, 158)
        mtbDienThoai.Mask = "0000000000"
        mtbDienThoai.Name = "mtbDienThoai"
        mtbDienThoai.Size = New Size(156, 23)
        mtbDienThoai.TabIndex = 41
        mtbDienThoai.ValidatingType = GetType(Integer)
        ' 
        ' dgvDSNguyenLieu
        ' 
        dgvDSNguyenLieu.AllowUserToAddRows = False
        dgvDSNguyenLieu.AllowUserToDeleteRows = False
        dgvDSNguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDSNguyenLieu.Location = New Point(469, 257)
        dgvDSNguyenLieu.Name = "dgvDSNguyenLieu"
        dgvDSNguyenLieu.ReadOnly = True
        dgvDSNguyenLieu.Size = New Size(337, 341)
        dgvDSNguyenLieu.TabIndex = 42
        ' 
        ' bXoaNguyenLieu
        ' 
        bXoaNguyenLieu.Location = New Point(841, 336)
        bXoaNguyenLieu.Name = "bXoaNguyenLieu"
        bXoaNguyenLieu.Size = New Size(75, 23)
        bXoaNguyenLieu.TabIndex = 45
        bXoaNguyenLieu.Text = "Xoa"
        bXoaNguyenLieu.UseVisualStyleBackColor = True
        ' 
        ' bCapNhatNguyenLieu
        ' 
        bCapNhatNguyenLieu.Location = New Point(841, 298)
        bCapNhatNguyenLieu.Name = "bCapNhatNguyenLieu"
        bCapNhatNguyenLieu.Size = New Size(75, 23)
        bCapNhatNguyenLieu.TabIndex = 44
        bCapNhatNguyenLieu.Text = "Cap nhat"
        bCapNhatNguyenLieu.UseVisualStyleBackColor = True
        ' 
        ' bThemNguyenLieu
        ' 
        bThemNguyenLieu.Location = New Point(841, 257)
        bThemNguyenLieu.Name = "bThemNguyenLieu"
        bThemNguyenLieu.Size = New Size(75, 23)
        bThemNguyenLieu.TabIndex = 43
        bThemNguyenLieu.Text = "Them"
        bThemNguyenLieu.UseVisualStyleBackColor = True
        ' 
        ' frmNhaCungCap
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 610)
        Controls.Add(bXoaNguyenLieu)
        Controls.Add(bCapNhatNguyenLieu)
        Controls.Add(bThemNguyenLieu)
        Controls.Add(dgvDSNguyenLieu)
        Controls.Add(mtbDienThoai)
        Controls.Add(tbGhiChu)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(tbTimKiem)
        Controls.Add(bXoa)
        Controls.Add(bCapNhat)
        Controls.Add(bThem)
        Controls.Add(tbTen)
        Controls.Add(tbDiaChi)
        Controls.Add(tbMa)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvDanhSach)
        Controls.Add(bPhucHoi)
        Controls.Add(cbHienThiXoa)
        Name = "frmNhaCungCap"
        Text = "frmNhaCungCap"
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDSNguyenLieu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents bXoa As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bThem As Button
    Friend WithEvents tbTen As TextBox
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents tbMa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents bPhucHoi As Button
    Friend WithEvents cbHienThiXoa As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbGhiChu As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mtbDienThoai As MaskedTextBox
    Friend WithEvents dgvDSNguyenLieu As DataGridView
    Friend WithEvents bXoaNguyenLieu As Button
    Friend WithEvents bCapNhatNguyenLieu As Button
    Friend WithEvents bThemNguyenLieu As Button
End Class
