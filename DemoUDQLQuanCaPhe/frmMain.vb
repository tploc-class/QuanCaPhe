Public Class frmMain

    Dim dsForm As List(Of Form)
    Dim NhanVien As DataRow

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsForm = New List(Of Form)()
        Me.Hide()
        Dim frm As frmDangNhap = New frmDangNhap()
        Dim dr As DialogResult = frm.ShowDialog()
        If dr = DialogResult.OK Then
            NhanVien = frm.NhanVien
            Me.Show()
        Else
            Me.Close()
        End If
    End Sub

    Function TimForm(type As Type) As Form
        For Each frm In dsForm
            If frm.GetType() Is type Then
                If frm.IsDisposed = True Then
                    dsForm.Remove(frm)
                    frm = Nothing
                End If
                Return frm
            End If
        Next
        Return Nothing
    End Function

    Private Sub DanhMucToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhMucToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmDanhMuc.GetType())
        If frm IsNot Nothing Then
            frm.Show()
            Return
        End If

        Dim frm1 As frmDanhMuc = New frmDanhMuc()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub MonAnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonAnToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmMonAn.GetType())
        If frm IsNot Nothing Then
            frm.Show()
            Return
        End If

        Dim frm1 As frmMonAn = New frmMonAn()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub NhanVienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhanVienToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmNhanVien.GetType())
        If frm IsNot Nothing Then
            frm.Show()
            Return
        End If

        Dim frm1 As frmNhanVien = New frmNhanVien()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub NhaCungCapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhaCungCapToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmNhaCungCap.GetType())
        If frm IsNot Nothing Then
            frm.Show()
            Return
        End If

        Dim frm1 As frmNhaCungCap = New frmNhaCungCap()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub BanHangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BanHangToolStripMenuItem1.Click
        Dim frm As Form = TimForm(frmBanHang.GetType())
        If frm IsNot Nothing Then
            frm.Show()
            Return
        End If

        Dim frm1 As frmBanHang = New frmBanHang()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub ThongKeDoanhThuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThongKeDoanhThuToolStripMenuItem.Click
        Dim frm As Form = TimForm(frmThongKeDoanhThu.GetType())
        If frm IsNot Nothing Then
            frm.Show()
            Return
        End If

        Dim frm1 As frmThongKeDoanhThu = New frmThongKeDoanhThu()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub
End Class
