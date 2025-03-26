Public Class frmNhaCungCap

    Dim dsNhaCungCap As DataTable
    Dim dsNhaCungCapView As DataView

    Dim dsNguyenLieu As DataTable
    Dim dsNguyenLieuView As DataView

    Sub HienThiDSNhaCungCap()
        Dim truy_van As String = "Select * from NhaCungCap where ncc_xoa = " + cbHienThiXoa.Checked.ToString()
        dsNhaCungCap = XL_DuLieu.DocDuLieu(truy_van)
        dsNhaCungCapView = New DataView(dsNhaCungCap)
        dgvDanhSach.DataSource = dsNhaCungCapView

        dgvDanhSach.Columns(0).Visible = False
        dgvDanhSach.Columns(6).Visible = False
    End Sub

    Sub HienThiDSNguyenLieu(ByVal ncc_ma As String)
        Dim truy_van As String = String.Format("Select nccnl_ma, nccnl_nha_cung_cap, ncc_ten,
            nccnl_nguyen_lieu, nl_ten, 
            nccnl_gia, nccnl_ghi_chu, nccnl_xoa from NhaCungCapNguyenLieu, NhaCungCap, NguyenLieu
            where nccnl_nha_cung_cap = ncc_ma and nccnl_nguyen_lieu = nl_ma and 
            nccnl_nha_cung_cap = {0} and
            ncc_xoa = {1}", ncc_ma, cbHienThiXoa.Checked.ToString())
        dsNguyenLieu = XL_DuLieu.DocDuLieu(truy_van)
        dsNguyenLieuView = New DataView(dsNguyenLieu)
        dgvDSNguyenLieu.DataSource = dsNguyenLieuView

        dgvDSNguyenLieu.Columns(0).Visible = False
        dgvDSNguyenLieu.Columns(1).Visible = False
        dgvDSNguyenLieu.Columns(3).Visible = False
        dgvDSNguyenLieu.Columns(7).Visible = False
    End Sub

    Private Sub frmNhaCungCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDSNhaCungCap()
    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        Dim nhaCungCap As DataRow = dsNhaCungCap.NewRow()
        nhaCungCap("ncc_code") = tbMa.Text
        nhaCungCap("ncc_ten") = tbTen.Text
        nhaCungCap("ncc_dia_chi") = tbDiaChi.Text
        nhaCungCap("ncc_dien_thoai") = mtbDienThoai.Text
        nhaCungCap("ncc_ghi_chu") = tbGhiChu.Text
        nhaCungCap("ncc_xoa") = False

        dsNhaCungCap.Rows.Add(nhaCungCap)
        XL_DuLieu.GhiDuLieu("NhaCungCap", dsNhaCungCap)
        MessageBox.Show("Them nha cung cap thanh cong", "Thong bao", MessageBoxButtons.OK)
    End Sub

    Private Sub dgvDanhSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellClick
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim nhaCungCapView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim nhaCungCap As DataRow = nhaCungCapView.Row

            tbMa.Text = nhaCungCap("ncc_code")
            tbTen.Text = nhaCungCap("ncc_ten")
            tbDiaChi.Text = nhaCungCap("ncc_dia_chi")
            mtbDienThoai.Text = nhaCungCap("ncc_dien_thoai")
            tbGhiChu.Text = nhaCungCap("ncc_ghi_chu")

            HienThiDSNguyenLieu(nhaCungCap("ncc_ma").ToString())
        End If
    End Sub

    Private Sub bThemNguyenLieu_Click(sender As Object, e As EventArgs) Handles bThemNguyenLieu.Click
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim nhaCungCapView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim nhaCungCap As DataRow = nhaCungCapView.Row

            Dim frm As frmNhaCungCapNguyenLieu = New frmNhaCungCapNguyenLieu()
            frm.TrangThai = frmNhaCungCapNguyenLieu.TRANG_THAI_THEM
            frm.NhaCungCap = nhaCungCap
            frm.NhaCungCapNguyenLieu = dsNguyenLieu.NewRow()

            Dim dr = frm.ShowDialog()
            If dr = DialogResult.OK Then
                dsNguyenLieu.Rows.Add(frm.NhaCungCapNguyenLieu)
                XL_DuLieu.GhiDuLieu("NhaCungCapNguyenLieu", dsNguyenLieu)
            End If
        Else
            MessageBox.Show("Vui long chon nha cung cap", "Thong bao")
        End If
    End Sub

    Private Sub bCapNhatNguyenLieu_Click(sender As Object, e As EventArgs) Handles bCapNhatNguyenLieu.Click
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim nhaCungCapView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim nhaCungCap As DataRow = nhaCungCapView.Row

            If dgvDanhSach.SelectedCells.Count() > 0 Then
                Dim row_index1 As Integer = dgvDSNguyenLieu.SelectedCells(0).RowIndex
                Dim nguyenLieuView As DataRowView = dgvDSNguyenLieu.Rows(row_index1).DataBoundItem
                Dim nguyenLieu As DataRow = nguyenLieuView.Row
                Dim frm As frmNhaCungCapNguyenLieu = New frmNhaCungCapNguyenLieu()
                frm.TrangThai = frmNhaCungCapNguyenLieu.TRANG_THAI_CAP_NHAT
                frm.NhaCungCap = nhaCungCap
                frm.NhaCungCapNguyenLieu = nguyenLieu
                Dim dr = frm.ShowDialog()
                If dr = DialogResult.OK Then
                    XL_DuLieu.GhiDuLieu("NhaCungCapNguyenLieu", dsNguyenLieu)
                End If
            Else
                MessageBox.Show("Vui long chon nguyen lieu", "Thong bao")
            End If
        Else
            MessageBox.Show("Vui long chon nha cung cap", "Thong bao")
        End If
    End Sub
End Class