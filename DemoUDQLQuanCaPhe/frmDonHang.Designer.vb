<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonHang
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
        dgvDSMonAn = New DataGridView()
        dgvDSChiTiet = New DataGridView()
        bThem = New Button()
        bXoa = New Button()
        dtpNgay = New DateTimePicker()
        tbDienThoai = New TextBox()
        tbGhiChu = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lChiNhanh = New Label()
        lTongTien = New Label()
        bTao = New Button()
        bCapNhat = New Button()
        Label3 = New Label()
        Label10 = New Label()
        tbTen = New TextBox()
        Label5 = New Label()
        tbDiaChi = New TextBox()
        CType(dgvDSMonAn, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDSChiTiet, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDSMonAn
        ' 
        dgvDSMonAn.AllowUserToAddRows = False
        dgvDSMonAn.AllowUserToDeleteRows = False
        dgvDSMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDSMonAn.Location = New Point(8, 6)
        dgvDSMonAn.Margin = New Padding(2, 1, 2, 1)
        dgvDSMonAn.Name = "dgvDSMonAn"
        dgvDSMonAn.RowHeadersWidth = 82
        dgvDSMonAn.RowTemplate.Height = 41
        dgvDSMonAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDSMonAn.Size = New Size(546, 489)
        dgvDSMonAn.TabIndex = 0
        ' 
        ' dgvDSChiTiet
        ' 
        dgvDSChiTiet.AllowUserToAddRows = False
        dgvDSChiTiet.AllowUserToDeleteRows = False
        dgvDSChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDSChiTiet.Location = New Point(624, 132)
        dgvDSChiTiet.Margin = New Padding(2, 1, 2, 1)
        dgvDSChiTiet.Name = "dgvDSChiTiet"
        dgvDSChiTiet.RowHeadersWidth = 82
        dgvDSChiTiet.RowTemplate.Height = 41
        dgvDSChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDSChiTiet.Size = New Size(543, 363)
        dgvDSChiTiet.TabIndex = 8
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(558, 159)
        bThem.Margin = New Padding(2, 1, 2, 1)
        bThem.Name = "bThem"
        bThem.Size = New Size(62, 22)
        bThem.TabIndex = 4
        bThem.Text = ">"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(558, 193)
        bXoa.Margin = New Padding(2, 1, 2, 1)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(62, 22)
        bXoa.TabIndex = 5
        bXoa.Text = "<"
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' dtpNgay
        ' 
        dtpNgay.CustomFormat = "dd/MM/yyyy"
        dtpNgay.Enabled = False
        dtpNgay.Format = DateTimePickerFormat.Custom
        dtpNgay.Location = New Point(685, 6)
        dtpNgay.Margin = New Padding(2, 1, 2, 1)
        dtpNgay.Name = "dtpNgay"
        dtpNgay.Size = New Size(110, 23)
        dtpNgay.TabIndex = 4
        ' 
        ' tbDienThoai
        ' 
        tbDienThoai.Location = New Point(685, 38)
        tbDienThoai.Margin = New Padding(2, 1, 2, 1)
        tbDienThoai.Name = "tbDienThoai"
        tbDienThoai.Size = New Size(110, 23)
        tbDienThoai.TabIndex = 0
        ' 
        ' tbGhiChu
        ' 
        tbGhiChu.Location = New Point(685, 98)
        tbGhiChu.Margin = New Padding(2, 1, 2, 1)
        tbGhiChu.Name = "tbGhiChu"
        tbGhiChu.Size = New Size(482, 23)
        tbGhiChu.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(618, 44)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 7
        Label1.Text = "Dien thoai"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(618, 104)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 8
        Label2.Text = "Ghi chu"
        ' 
        ' lChiNhanh
        ' 
        lChiNhanh.AutoSize = True
        lChiNhanh.Location = New Point(1107, 6)
        lChiNhanh.Margin = New Padding(2, 0, 2, 0)
        lChiNhanh.Name = "lChiNhanh"
        lChiNhanh.Size = New Size(60, 15)
        lChiNhanh.TabIndex = 9
        lChiNhanh.Text = "chi nhanh"
        ' 
        ' lTongTien
        ' 
        lTongTien.AutoSize = True
        lTongTien.Location = New Point(1111, 510)
        lTongTien.Margin = New Padding(2, 0, 2, 0)
        lTongTien.Name = "lTongTien"
        lTongTien.Size = New Size(56, 15)
        lTongTien.TabIndex = 10
        lTongTien.Text = "Tong tien"
        ' 
        ' bTao
        ' 
        bTao.Location = New Point(1086, 571)
        bTao.Margin = New Padding(2, 1, 2, 1)
        bTao.Name = "bTao"
        bTao.Size = New Size(81, 21)
        bTao.TabIndex = 11
        bTao.Text = "Tao"
        bTao.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(1086, 547)
        bCapNhat.Margin = New Padding(2, 1, 2, 1)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(81, 22)
        bCapNhat.TabIndex = 12
        bCapNhat.Text = "Cap Nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(618, 13)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 13
        Label3.Text = "Ngay"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(812, 44)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(25, 15)
        Label10.TabIndex = 15
        Label10.Text = "Ten"
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(879, 38)
        tbTen.Margin = New Padding(2, 1, 2, 1)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(110, 23)
        tbTen.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(618, 75)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 17
        Label5.Text = "Dia chi"
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(685, 69)
        tbDiaChi.Margin = New Padding(2, 1, 2, 1)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(482, 23)
        tbDiaChi.TabIndex = 2
        ' 
        ' frmDonHang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1172, 651)
        Controls.Add(Label5)
        Controls.Add(tbDiaChi)
        Controls.Add(Label10)
        Controls.Add(tbTen)
        Controls.Add(Label3)
        Controls.Add(bCapNhat)
        Controls.Add(bTao)
        Controls.Add(lTongTien)
        Controls.Add(lChiNhanh)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbGhiChu)
        Controls.Add(tbDienThoai)
        Controls.Add(dtpNgay)
        Controls.Add(bXoa)
        Controls.Add(bThem)
        Controls.Add(dgvDSChiTiet)
        Controls.Add(dgvDSMonAn)
        Margin = New Padding(2, 1, 2, 1)
        Name = "frmDonHang"
        Text = "frmDonHang"
        CType(dgvDSMonAn, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDSChiTiet, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents dgvDSMonAn As DataGridView
    Friend WithEvents dgvDSChiTiet As DataGridView
    Friend WithEvents bThem As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents dtpNgay As DateTimePicker
    Friend WithEvents tbDienThoai As TextBox
    Friend WithEvents tbGhiChu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lChiNhanh As Label
    Friend WithEvents lTongTien As Label
    Friend WithEvents bTao As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDiaChi As TextBox
End Class
