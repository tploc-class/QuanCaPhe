<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBanHang
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
        dgvDSDonHang = New DataGridView()
        dtpNgayHienTai = New DateTimePicker()
        tbTimKiem = New TextBox()
        cbChiNhanh = New ComboBox()
        bTao = New Button()
        bCapNhat = New Button()
        CType(dgvDSDonHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDSDonHang
        ' 
        dgvDSDonHang.AllowUserToAddRows = False
        dgvDSDonHang.AllowUserToDeleteRows = False
        dgvDSDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDSDonHang.Location = New Point(11, 36)
        dgvDSDonHang.Margin = New Padding(2, 1, 2, 1)
        dgvDSDonHang.Name = "dgvDSDonHang"
        dgvDSDonHang.RowHeadersWidth = 82
        dgvDSDonHang.RowTemplate.Height = 41
        dgvDSDonHang.Size = New Size(810, 445)
        dgvDSDonHang.TabIndex = 0
        ' 
        ' dtpNgayHienTai
        ' 
        dtpNgayHienTai.CustomFormat = "dd/MM/yyyy"
        dtpNgayHienTai.Format = DateTimePickerFormat.Custom
        dtpNgayHienTai.Location = New Point(341, 8)
        dtpNgayHienTai.Margin = New Padding(2, 1, 2, 1)
        dtpNgayHienTai.Name = "dtpNgayHienTai"
        dtpNgayHienTai.Size = New Size(97, 23)
        dtpNgayHienTai.TabIndex = 1
        ' 
        ' tbTimKiem
        ' 
        tbTimKiem.Location = New Point(11, 8)
        tbTimKiem.Margin = New Padding(2, 1, 2, 1)
        tbTimKiem.Name = "tbTimKiem"
        tbTimKiem.Size = New Size(316, 23)
        tbTimKiem.TabIndex = 2
        ' 
        ' cbChiNhanh
        ' 
        cbChiNhanh.FormattingEnabled = True
        cbChiNhanh.Location = New Point(452, 8)
        cbChiNhanh.Margin = New Padding(2, 1, 2, 1)
        cbChiNhanh.Name = "cbChiNhanh"
        cbChiNhanh.Size = New Size(132, 23)
        cbChiNhanh.TabIndex = 3
        ' 
        ' bTao
        ' 
        bTao.Location = New Point(597, 7)
        bTao.Margin = New Padding(2, 1, 2, 1)
        bTao.Name = "bTao"
        bTao.Size = New Size(81, 22)
        bTao.TabIndex = 4
        bTao.Text = "Tao don"
        bTao.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(691, 7)
        bCapNhat.Margin = New Padding(2, 1, 2, 1)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(81, 22)
        bCapNhat.TabIndex = 5
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' frmBanHang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(836, 485)
        Controls.Add(bCapNhat)
        Controls.Add(bTao)
        Controls.Add(cbChiNhanh)
        Controls.Add(tbTimKiem)
        Controls.Add(dtpNgayHienTai)
        Controls.Add(dgvDSDonHang)
        Margin = New Padding(2, 1, 2, 1)
        Name = "frmBanHang"
        Text = "frmdsDonHang"
        CType(dgvDSDonHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents dgvDSDonHang As DataGridView
    Friend WithEvents dtpNgayHienTai As DateTimePicker
    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents cbChiNhanh As ComboBox
    Friend WithEvents bTao As Button
    Friend WithEvents bCapNhat As Button
End Class
