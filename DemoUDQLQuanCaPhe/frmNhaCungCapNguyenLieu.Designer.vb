<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhaCungCapNguyenLieu
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
        cbNguyenLieu = New ComboBox()
        tbGia = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        bThem = New Button()
        bHuy = New Button()
        lNhaCungCap = New Label()
        bCapNhat = New Button()
        Label3 = New Label()
        tbGhiChu = New TextBox()
        SuspendLayout()
        ' 
        ' cbNguyenLieu
        ' 
        cbNguyenLieu.FormattingEnabled = True
        cbNguyenLieu.Location = New Point(125, 40)
        cbNguyenLieu.Name = "cbNguyenLieu"
        cbNguyenLieu.Size = New Size(121, 23)
        cbNguyenLieu.TabIndex = 0
        ' 
        ' tbGia
        ' 
        tbGia.Location = New Point(125, 87)
        tbGia.Name = "tbGia"
        tbGia.Size = New Size(121, 23)
        tbGia.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 2
        Label1.Text = "Nguyen lieu:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 15)
        Label2.TabIndex = 3
        Label2.Text = "Gia:"
        ' 
        ' bThem
        ' 
        bThem.DialogResult = DialogResult.OK
        bThem.Location = New Point(278, 38)
        bThem.Name = "bThem"
        bThem.Size = New Size(75, 23)
        bThem.TabIndex = 4
        bThem.Text = "Them"
        bThem.UseVisualStyleBackColor = True
        ' 
        ' bHuy
        ' 
        bHuy.DialogResult = DialogResult.Cancel
        bHuy.Location = New Point(278, 89)
        bHuy.Name = "bHuy"
        bHuy.Size = New Size(75, 23)
        bHuy.TabIndex = 5
        bHuy.Text = "Huy"
        bHuy.UseVisualStyleBackColor = True
        ' 
        ' lNhaCungCap
        ' 
        lNhaCungCap.AutoSize = True
        lNhaCungCap.Location = New Point(38, 9)
        lNhaCungCap.Name = "lNhaCungCap"
        lNhaCungCap.Size = New Size(27, 15)
        lNhaCungCap.TabIndex = 6
        lNhaCungCap.Text = "Gia:"
        ' 
        ' bCapNhat
        ' 
        bCapNhat.DialogResult = DialogResult.OK
        bCapNhat.Location = New Point(278, 38)
        bCapNhat.Name = "bCapNhat"
        bCapNhat.Size = New Size(75, 23)
        bCapNhat.TabIndex = 7
        bCapNhat.Text = "Cap nhat"
        bCapNhat.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 9
        Label3.Text = "Ghi chu:"
        ' 
        ' tbGhiChu
        ' 
        tbGhiChu.Location = New Point(121, 138)
        tbGhiChu.Name = "tbGhiChu"
        tbGhiChu.Size = New Size(121, 23)
        tbGhiChu.TabIndex = 8
        ' 
        ' frmNhaCungCapNguyenLieu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(448, 196)
        Controls.Add(Label3)
        Controls.Add(tbGhiChu)
        Controls.Add(bCapNhat)
        Controls.Add(lNhaCungCap)
        Controls.Add(bHuy)
        Controls.Add(bThem)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbGia)
        Controls.Add(cbNguyenLieu)
        Name = "frmNhaCungCapNguyenLieu"
        Text = "Thong tin nguyen lieu cua nha cung cap"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbNguyenLieu As ComboBox
    Friend WithEvents tbGia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bThem As Button
    Friend WithEvents bHuy As Button
    Friend WithEvents lNhaCungCap As Label
    Friend WithEvents bCapNhat As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbGhiChu As TextBox
End Class
