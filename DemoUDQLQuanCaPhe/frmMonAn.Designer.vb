<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonAn
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
        bXoa = New Button()
        bCapNhat = New Button()
        bThem = New Button()
        tbTen = New TextBox()
        tbMoTa = New TextBox()
        tbMa = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dgvDanhSach = New DataGridView()
        tbTimKiem = New TextBox()
        ColorDialog1 = New ColorDialog()
        cbDanhMuc = New ComboBox()
        Label4 = New Label()
        cbHienThiXoa = New CheckBox()
        bPhucHoi = New Button()
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(634, 173)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(75, 23)
        bXoa.TabIndex = 15
        bXoa.Text = "Xoa"
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(553, 173)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(75, 23)
        bCapNhat.TabIndex = 14
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(460, 173)
        bThem.Name = "bThem"
        bThem.Size = New Size(75, 23)
        bThem.TabIndex = 12
        bThem.Text = "Them"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(542, 83)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(156, 23)
        tbTen.TabIndex = 8
        ' 
        ' tbMoTa
        ' 
        tbMoTa.Location = New Point(542, 121)
        tbMoTa.Name = "tbMoTa"
        tbMoTa.Size = New Size(156, 23)
        tbMoTa.TabIndex = 10
        ' 
        ' tbMa
        ' 
        tbMa.Location = New Point(542, 44)
        tbMa.Name = "tbMa"
        tbMa.Size = New Size(156, 23)
        tbMa.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(469, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 13
        Label3.Text = "Mo ta:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(469, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 11
        Label2.Text = "Ten:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(469, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 15)
        Label1.TabIndex = 9
        Label1.Text = "Ma:"
        ' 
        ' dgvDanhSach
        ' 
        dgvDanhSach.AllowUserToAddRows = False
        dgvDanhSach.AllowUserToDeleteRows = False
        dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSach.Location = New Point(12, 51)
        dgvDanhSach.Name = "dgvDanhSach"
        dgvDanhSach.ReadOnly = True
        dgvDanhSach.Size = New Size(425, 391)
        dgvDanhSach.TabIndex = 7
        ' 
        ' tbTimKiem
        ' 
        tbTimKiem.Location = New Point(12, 16)
        tbTimKiem.Name = "tbTimKiem"
        tbTimKiem.Size = New Size(425, 23)
        tbTimKiem.TabIndex = 16
        ' 
        ' cbDanhMuc
        ' 
        cbDanhMuc.FormattingEnabled = True
        cbDanhMuc.Location = New Point(542, 13)
        cbDanhMuc.Name = "cbDanhMuc"
        cbDanhMuc.Size = New Size(156, 23)
        cbDanhMuc.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(470, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 15)
        Label4.TabIndex = 18
        Label4.Text = "Danh muc:"
        ' 
        ' cbHienThiXoa
        ' 
        cbHienThiXoa.AutoSize = True
        cbHienThiXoa.Location = New Point(465, 213)
        cbHienThiXoa.Name = "cbHienThiXoa"
        cbHienThiXoa.Size = New Size(168, 19)
        cbHienThiXoa.TabIndex = 19
        cbHienThiXoa.Text = "Hien thi cac mon an bi xoa"
        cbHienThiXoa.UseVisualStyleBackColor = True
        ' 
        ' bPhucHoi
        ' 
        bPhucHoi.Location = New Point(634, 210)
        bPhucHoi.Name = "bPhucHoi"
        bPhucHoi.Size = New Size(75, 23)
        bPhucHoi.TabIndex = 20
        bPhucHoi.Text = "Phuc hoi"
        bPhucHoi.UseVisualStyleBackColor = True
        ' 
        ' frmMonAn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(bPhucHoi)
        Controls.Add(cbHienThiXoa)
        Controls.Add(Label4)
        Controls.Add(cbDanhMuc)
        Controls.Add(tbTimKiem)
        Controls.Add(bXoa)
        Controls.Add(bCapNhat)
        Controls.Add(bThem)
        Controls.Add(tbTen)
        Controls.Add(tbMoTa)
        Controls.Add(tbMa)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvDanhSach)
        Name = "frmMonAn"
        Text = "frmMonAn"
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bXoa As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bThem As Button
    Friend WithEvents tbTen As TextBox
    Friend WithEvents tbMoTa As TextBox
    Friend WithEvents tbMa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents cbDanhMuc As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbHienThiXoa As CheckBox
    Friend WithEvents bPhucHoi As Button
End Class
