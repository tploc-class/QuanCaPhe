﻿Public Class frmDangNhap
    Public NhanVien As DataRow

    Private Sub bDangNhap_Click(sender As Object, e As EventArgs) Handles bDangNhap.Click
        Dim TenDangNhap As String = tbTenDangNhap.Text
        Dim MatKhau As String = Util.getHash(tbMatKhau.Text)
        Dim sql As String = String.Format("Select TaiKhoan.*, NhanVien.* from NhanVien, TaiKhoan 
            where tk_ma = nv_ma_tai_khoan and tk_tai_khoan = '{0}' and nv_xoa = false", TenDangNhap)
        Dim dsNhanVien As DataTable = XL_DuLieu.DocDuLieu(sql)
        If dsNhanVien.Rows.Count = 1 Then
            NhanVien = dsNhanVien.Rows(0)
            If MatKhau = NhanVien("tk_mat_khau") And NhanVien("tk_dang_nhap_loi") <= 5 Then
                NhanVien("tk_dang_nhap_loi") = 0
                XL_DuLieu.GhiDuLieu("TaiKhoan", dsNhanVien)
                Me.DialogResult = DialogResult.OK
            Else
                NhanVien("tk_dang_nhap_loi") = NhanVien("tk_dang_nhap_loi") + 1
                XL_DuLieu.GhiDuLieu("TaiKhoan", dsNhanVien)
            End If
        End If
        lKetQua.Text = "Ten dang nhap/Mat khau khong dung!!!"
    End Sub

    Private Sub bThoat_Click(sender As Object, e As EventArgs) Handles bThoat.Click
        Me.Close()
    End Sub

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class