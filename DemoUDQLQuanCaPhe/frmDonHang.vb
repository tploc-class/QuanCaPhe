Public Class frmDonHang
    Public ma_menu As Integer
    Public chi_nhanh As DataRow
    Public ngay As Date

    Dim dsKhachHang As DataTable
    Dim khach_hang As DataRow

    Dim dsMonAn As DataTable
    Dim dsChiTietDonHang As DataTable
    Dim dsDonHang As DataTable

    Public Loai As Integer '1: moi, 3: cap nhat
    Public don_hang As DataRow

    Private Sub frmDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lChiNhanh.Text = "Chi nhanh: " + chi_nhanh("cn_ten").ToString()
        dtpNgay.Value = ngay

        Dim str As String = String.Format(
            "Select ma_ma, ma_ten, mct_gia from MenuChiTiet, MonAn
                where mct_menu = {0} and mct_mon_an = ma_ma",
            ma_menu)
        dsMonAn = XL_DuLieu.DocDuLieu(str)
        dgvDSMonAn.DataSource = dsMonAn

        If Loai = 1 Then
            str = String.Format(
                "Select ctdh_ma, ctdh_ma_mon_an, ma_ten, ctdh_so_luong, ctdh_gia, 
                ctdh_tong_mon_an, ctdh_khuyen_mai, ctdh_tong_tien, ctdh_ghi_chu, ctdh_xoa, ctdh_ma_don_hang
                from ChiTietDonHang, MonAn where ctdh_ma_mon_an = ma_ma"
            )
            dsChiTietDonHang = XL_DuLieu.DocCauTruc(str)

            str = String.Format("Select * from DonHang")
            dsDonHang = XL_DuLieu.DocCauTruc(str)
            bCapNhat.Visible = False
            bTao.Visible = True
        Else
            dsChiTietDonHang = XL_DuLieu.DocDuLieu(
                "Select ctdh_ma, ctdh_ma_mon_an, ma_ten, ctdh_so_luong, ctdh_gia, 
                ctdh_tong_mon_an, ctdh_khuyen_mai, ctdh_tong_tien, ctdh_ghi_chu, ctdh_xoa, ctdh_ma_don_hang
                from ChiTietDonHang, MonAn where ctdh_ma_mon_an = ma_ma and ctdh_ma_don_hang=" + don_hang("dh_ma").ToString()
            )

            dsDonHang = XL_DuLieu.DocDuLieu(
                "Select * from DonHang where dh_ma = " + don_hang("dh_ma").ToString()
            )

            dsKhachHang = XL_DuLieu.DocDuLieu("Select * from KhachHang where kh_ma=" + don_hang("dh_khach_hang").ToString())
            khach_hang = dsKhachHang.Rows(0)
            tbDienThoai.Text = khach_hang("kh_dien_thoai")
            tbTen.Text = khach_hang("kh_ten")
            tbDiaChi.Text = khach_hang("kh_dia_chi")
            TinhTong()
            bCapNhat.Visible = True
            bTao.Visible = False
        End If
        dgvDSChiTiet.DataSource = dsChiTietDonHang
        dgvDSChiTiet.Columns(0).Visible = False 'ctdn_ma
        dgvDSChiTiet.Columns(0).Visible = False 'ctdn_ma_don_hang


    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        If dgvDSMonAn.SelectedRows.Count > 0 Then
            Dim mon_an As DataRow = dsMonAn(dgvDSMonAn.SelectedCells(0).RowIndex)
            Dim ctdhs() As DataRow = dsChiTietDonHang.Select("ctdh_ma_mon_an = " + mon_an("ma_ma").ToString())

            If ctdhs.Length > 0 Then
                Dim chi_tiet As DataRow = ctdhs(0)
                chi_tiet("ctdh_so_luong") += 1
                chi_tiet("ctdh_tong_tien") = chi_tiet("ctdh_so_luong") * chi_tiet("ctdh_gia")
                chi_tiet("ctdh_tong_mon_an") = chi_tiet("ctdh_tong_tien")
                chi_tiet("ctdh_khuyen_mai") = 0
            Else
                Dim chi_tiet As DataRow = dsChiTietDonHang.NewRow()
                chi_tiet("ctdh_ma_mon_an") = mon_an("ma_ma")
                chi_tiet("ctdh_gia") = mon_an("mct_gia")
                chi_tiet("ctdh_so_luong") = 1
                chi_tiet("ma_ten") = mon_an("ma_ten")
                chi_tiet("ctdh_tong_tien") = chi_tiet("ctdh_so_luong") * chi_tiet("ctdh_gia")
                chi_tiet("ctdh_tong_mon_an") = chi_tiet("ctdh_tong_tien")
                chi_tiet("ctdh_khuyen_mai") = 0
                dsChiTietDonHang.Rows.Add(chi_tiet)
            End If
            TinhTong()
        End If
    End Sub

    Sub TinhTong()
        Dim TongTien = dsChiTietDonHang.Compute("Sum(ctdh_tong_tien)", String.Empty)
        lTongTien.Text = TongTien.ToString()
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDSChiTiet.SelectedCells.Count > 0 Then
            Dim chi_tiet As DataRow = dsChiTietDonHang(dgvDSChiTiet.SelectedCells(0).RowIndex)
            Dim so_luong As Integer = chi_tiet("ctdh_so_luong") - 1
            If so_luong <= 0 Then
                If Loai = 1 Then
                    dsChiTietDonHang.Rows.Remove(chi_tiet)
                ElseIf Loai = 2 Then
                    chi_tiet.Delete()
                End If
            Else
                chi_tiet("ctdh_so_luong") = so_luong
                chi_tiet("ctdh_tong_tien") = chi_tiet("ctdh_so_luong") * chi_tiet("ctdh_gia")
                chi_tiet("ctdh_tong_mon_an") = chi_tiet("ctdh_tong_tien")
                chi_tiet("ctdh_khuyen_mai") = 0
            End If
            TinhTong()
        End If
    End Sub

    Private Sub bTao_Click(sender As Object, e As EventArgs) Handles bTao.Click
        If tbDienThoai.Text = "" Or tbTen.Text = "" Then
            MessageBox.Show("Vui long dien ten va so dien thoai khach hang!", "Thong bao")
            Return
        Else
            If IsDBNull(khach_hang("kh_ma")) Then
                khach_hang("kh_ten") = tbTen.Text
                khach_hang("kh_dia_chi") = tbDiaChi.Text
                XL_DuLieu.GhiDuLieu("KhachHang", dsKhachHang)
            End If
        End If


        Dim don_hang = dsDonHang.NewRow()
        don_hang("dh_ngay") = dtpNgay.Value
        don_hang("dh_tong_mon_an") = Int32.Parse(lTongTien.Text)
        don_hang("dh_tong_khuyen_mai") = 0
        don_hang("dh_tong_tien") = don_hang("dh_tong_mon_an") - don_hang("dh_tong_khuyen_mai")
        don_hang("dh_chi_nhanh") = chi_nhanh("cn_ma")
        don_hang("dh_khach_hang") = khach_hang("kh_ma")
        don_hang("dh_ghi_chu") = tbGhiChu.Text
        don_hang("dh_trang_thai") = 1

        dsDonHang.Rows.Add(don_hang)
        XL_DuLieu.GhiDuLieu("DonHang", dsDonHang)

        For Each ctdh In dsChiTietDonHang.Rows
            ctdh("ctdh_ma_don_hang") = don_hang("dh_ma")
        Next

        XL_DuLieu.GhiDuLieu("ChiTietDonHang", dsChiTietDonHang)

        TatManHinh()
    End Sub

    Sub TatManHinh()

        Dim frm As frmBanHang = Me.Tag
        frm.HienThiDSDonHang()
        Me.Close()
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If tbDienThoai.Text = "" Or tbTen.Text = "" Then
            MessageBox.Show("Vui long dien ten va so dien thoai khach hang!", "Thong bao")
            Return
        Else
            If IsDBNull(khach_hang("kh_ma")) Then
                khach_hang("kh_ten") = tbTen.Text
                khach_hang("kh_dia_chi") = tbDiaChi.Text
                XL_DuLieu.GhiDuLieu("KhachHang", dsKhachHang)
            End If
        End If


        Dim don_hang = dsDonHang.Rows(0)
        don_hang("dh_ngay") = dtpNgay.Value
        don_hang("dh_tong_mon_an") = Int32.Parse(lTongTien.Text)
        don_hang("dh_tong_khuyen_mai") = 0
        don_hang("dh_tong_tien") = don_hang("dh_tong_mon_an") - don_hang("dh_tong_khuyen_mai")
        don_hang("dh_chi_nhanh") = chi_nhanh("cn_ma")
        don_hang("dh_khach_hang") = khach_hang("kh_ma")
        don_hang("dh_ghi_chu") = tbGhiChu.Text

        XL_DuLieu.GhiDuLieu("DonHang", dsDonHang)

        For Each ctdh In dsChiTietDonHang.Rows
            ctdh("ctdh_ma_don_hang") = don_hang("dh_ma")
        Next

        XL_DuLieu.GhiDuLieu("ChiTietDonHang", dsChiTietDonHang)

        TatManHinh()
    End Sub

    Private Sub tbDienThoai_Leave(sender As Object, e As EventArgs) Handles tbDienThoai.Leave
        Dim str As String = String.Format("Select * from KhachHang where kh_dien_thoai like '{0}'",
                tbDienThoai.Text)
        dsKhachHang = XL_DuLieu.DocDuLieu(str)
        If dsKhachHang.Rows.Count > 0 Then
            khach_hang = dsKhachHang.Rows(0)
            tbTen.Text = khach_hang("kh_ten")
            tbDiaChi.Text = khach_hang("kh_dia_chi")
        Else
            khach_hang = dsKhachHang.NewRow()
            khach_hang("kh_dien_thoai") = tbDienThoai.Text
            dsKhachHang.Rows.Add(khach_hang)
        End If
    End Sub
End Class