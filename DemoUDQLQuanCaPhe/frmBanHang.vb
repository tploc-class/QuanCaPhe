Public Class frmBanHang
    Public nhanVien As DataRow
    Public dsChiNhanh As DataTable
    Private Sub frmdsDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Khoi tao tam du lieu, khi dang nhap se truyen dung thong tin
        Dim dsNhanVien As DataTable = XL_DuLieu.DocCauTruc("Select * from NhanVien")
        nhanVien = dsNhanVien.NewRow()
        nhanVien("nv_ma") = 1

        HienThiDSChiNhanh()
        HienThiDSDonHang()
    End Sub

    Sub HienThiDSChiNhanh()
        Dim str As String = String.Format(
            "Select distinct cn_ma, cn_ten from ChiNhanh, NhanVienChiNhanh 
                where nvcn_chi_nhanh = cn_ma and nvcn_nhan_vien = {0} and nvcn_ngay_ap_dung <= #{1}#",
            nhanVien("nv_ma"), dtpNgayHienTai.Value.ToString("yyyy-MM-dd"))

        dsChiNhanh = XL_DuLieu.DocDuLieu(str)
        cbChiNhanh.ValueMember = "cn_ma"
        cbChiNhanh.DisplayMember = "cn_ten"
        cbChiNhanh.DataSource = dsChiNhanh
    End Sub

    Public Sub HienThiDSDonHang()
        If cbChiNhanh.SelectedIndex >= 0 Then
            Dim str As String = String.Format(
                "Select * from DonHang, ChiNhanh, TrangThaiDonHang 
                    where cn_ma = dh_chi_nhanh and ttdh_ma = dh_trang_thai
                    and dh_chi_nhanh = {0} and DateValue(dh_ngay) = #{1}#",
                cbChiNhanh.SelectedValue, dtpNgayHienTai.Value.ToString("yyyy-MM-dd"))
            dgvDSDonHang.DataSource = XL_DuLieu.DocDuLieu(str)
        End If
    End Sub

    Private Sub dtpNgayHienTai_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayHienTai.ValueChanged
        HienThiDSChiNhanh()
    End Sub

    Private Sub cbChiNhanh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbChiNhanh.SelectedIndexChanged
        HienThiDSDonHang()
    End Sub

    Private Sub bTaoDon_Click(sender As Object, e As EventArgs) Handles bTao.Click
        If cbChiNhanh.SelectedIndex >= 0 Then
            Dim str As String = String.Format(
                "SELECT * FROM MenuChiNhanh
                    WHERE mcn_ngay_ap_dung <= #{0}# and mcn_chi_nhanh = {1}
                    ORDER By mcn_ngay_ap_dung desc;",
                dtpNgayHienTai.Value.ToString("yyyy-MM-dd"), cbChiNhanh.SelectedItem("cn_ma"))
            Dim temp As DataTable = XL_DuLieu.DocDuLieu(str)
            If (temp.Rows.Count > 0) Then
                Dim frm As frmDonHang = New frmDonHang()
                frm.ma_menu = temp.Rows(0)("mcn_menu")
                frm.chi_nhanh = dsChiNhanh.Rows(cbChiNhanh.SelectedIndex)
                frm.ngay = dtpNgayHienTai.Value
                frm.Loai = 1
                frm.Tag = Me
                frm.Show()
                frm.WindowState = FormWindowState.Maximized
            Else

            End If

        End If
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If cbChiNhanh.SelectedIndex >= 0 Then
            Dim str As String = String.Format(
                "SELECT * FROM MenuChiNhanh
                    WHERE mcn_ngay_ap_dung <= #{0}# and mcn_chi_nhanh = {1}
                    ORDER By mcn_ngay_ap_dung desc;",
                dtpNgayHienTai.Value.ToString("yyyy-MM-dd"), cbChiNhanh.SelectedItem("cn_ma"))
            Dim temp As DataTable = XL_DuLieu.DocDuLieu(str)
            If (temp.Rows.Count > 0) Then
                Dim frm As frmDonHang = New frmDonHang()
                frm.ma_menu = temp.Rows(0)("mcn_menu")
                frm.chi_nhanh = dsChiNhanh.Rows(cbChiNhanh.SelectedIndex)
                frm.ngay = dtpNgayHienTai.Value
                frm.Loai = 2
                frm.Tag = Me
                If dgvDSDonHang.SelectedCells.Count > 0 Then
                    Dim dhv As DataRowView = dgvDSDonHang.Rows(dgvDSDonHang.SelectedCells(0).RowIndex).DataBoundItem
                    Dim don_hang As DataRow = dhv.Row
                    frm.don_hang = don_hang
                    frm.Show()
                    frm.WindowState = FormWindowState.Maximized
                End If

            Else

            End If

        End If
    End Sub


End Class