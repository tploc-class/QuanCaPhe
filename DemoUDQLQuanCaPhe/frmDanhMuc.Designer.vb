<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanhMuc
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
        dgvDanhSach = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        tbMa = New TextBox()
        tbMoTa = New TextBox()
        tbTen = New TextBox()
        bThem = New Button()
        bCapNhat = New Button()
        bXoa = New Button()
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDanhSach
        ' 
        dgvDanhSach.AllowUserToAddRows = False
        dgvDanhSach.AllowUserToDeleteRows = False
        dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSach.Location = New Point(12, 5)
        dgvDanhSach.Name = "dgvDanhSach"
        dgvDanhSach.ReadOnly = True
        dgvDanhSach.Size = New Size(347, 433)
        dgvDanhSach.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(395, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 15)
        Label1.TabIndex = 1
        Label1.Text = "Ma:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(395, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 2
        Label2.Text = "Ten:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(395, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 3
        Label3.Text = "Mo ta:"
        ' 
        ' tbMa
        ' 
        tbMa.Location = New Point(457, 8)
        tbMa.Name = "tbMa"
        tbMa.Size = New Size(156, 23)
        tbMa.TabIndex = 0
        ' 
        ' tbMoTa
        ' 
        tbMoTa.Location = New Point(457, 85)
        tbMoTa.Name = "tbMoTa"
        tbMoTa.Size = New Size(156, 23)
        tbMoTa.TabIndex = 2
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(457, 47)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(156, 23)
        tbTen.TabIndex = 1
        ' 
        ' bThem
        ' 
        bThem.Location = New Point(383, 124)
        bThem.Name = "bThem"
        bThem.Size = New Size(75, 23)
        bThem.TabIndex = 3
        bThem.Text = "Them"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' bCapNhat
        ' 
        bCapNhat.Location = New Point(476, 124)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(75, 23)
        bCapNhat.TabIndex = 4
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(557, 124)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(75, 23)
        bXoa.TabIndex = 5
        bXoa.Text = "Xoa"
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' frmDanhMuc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(649, 450)
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
        Name = "frmDanhMuc"
        Text = "frmDanhMuc"
        CType(dgvDanhSach, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbMa As TextBox
    Friend WithEvents tbMoTa As TextBox
    Friend WithEvents tbTen As TextBox
    Friend WithEvents bThem As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bXoa As Button
End Class
