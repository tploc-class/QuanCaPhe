Public Class frmNhanVien
    Dim dsNhanVien As DataTable
    Dim dsNhanVienView As DataView
    Dim dsTaiKhoan As DataTable

    Sub HienThiDSNhanVien()
        Dim truy_van As String = "Select nv_ma, nv_ten, nv_dia_chi, nv_gioi_tinh, nv_xoa, nv_ma_tai_khoan, tk_tai_khoan, tk_mat_khau 
        from NhanVien, TaiKhoan where nv_ma_tai_khoan = tk_ma and nv_xoa = " + cbHienThiXoa.Checked.ToString()
        dsNhanVien = XL_DuLieu.DocDuLieu(truy_van)
        dsNhanVienView = New DataView(dsNhanVien)
        dgvDanhSach.DataSource = dsNhanVienView

        dgvDanhSach.Columns(0).Visible = False
        dgvDanhSach.Columns(4).Visible = False
        dgvDanhSach.Columns(5).Visible = False
        dgvDanhSach.Columns(7).Visible = False

        dgvDanhSach.Columns(3).HeaderText = "Nam"
    End Sub

    Private Sub frmNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDSNhanVien()

        dsTaiKhoan = XL_DuLieu.DocCauTruc("Select * from TaiKhoan")
    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        Dim taiKhoan As DataRow = dsTaiKhoan.NewRow()
        taiKhoan("tk_tai_khoan") = tbTaiKhoan.Text
        taiKhoan("tk_mat_khau") = Util.getHash(tbMatKhau.Text)
        taiKhoan("tk_xoa") = False
        dsTaiKhoan.Rows.Add(taiKhoan)
        XL_DuLieu.GhiDuLieu("TaiKhoan", dsTaiKhoan)

        Dim nhanVien As DataRow = dsNhanVien.NewRow()
        nhanVien("nv_ten") = tbTen.Text
        nhanVien("nv_dia_chi") = tbDiaChi.Text
        nhanVien("nv_gioi_tinh") = rbNam.Checked
        nhanVien("nv_xoa") = False
        nhanVien("nv_ma_tai_khoan") = taiKhoan("tk_ma")
        nhanVien("tk_tai_khoan") = taiKhoan("tk_tai_khoan")
        nhanVien("tk_mat_khau") = taiKhoan("tk_mat_khau")

        dsNhanVien.Rows.Add(nhanVien)
        XL_DuLieu.GhiDuLieu("NhanVien", dsNhanVien)
        MessageBox.Show("Them nhan vien thanh cong", "Thong bao", MessageBoxButtons.OK)

        dsTaiKhoan.Rows.Remove(taiKhoan)
    End Sub

    Private Sub dgvDanhSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellClick
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim nhanVienView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim nhanVien As DataRow = nhanVienView.Row

            tbTen.Text = nhanVien("nv_ten")
            tbDiaChi.Text = nhanVien("nv_dia_chi")
            If nhanVien("nv_gioi_tinh") Then
                rbNam.Checked = True
            Else
                rbNu.Checked = True
            End If
            tbTaiKhoan.Text = nhanVien("tk_tai_khoan")
        End If
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim nhanVienView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim nhanVien As DataRow = nhanVienView.Row

            If nhanVien("tk_tai_khoan") <> tbTaiKhoan.Text Then
                MessageBox.Show("Anh/chi khong duoc cap nhat tai khoan", "Thong bao", MessageBoxButtons.OK)
                Return
            End If

            nhanVien("nv_ten") = tbTen.Text
            nhanVien("nv_dia_chi") = tbDiaChi.Text
            nhanVien("nv_gioi_tinh") = rbNam.Checked
            nhanVien("tk_mat_khau") = Util.getHash(tbMatKhau.Text)
            XL_DuLieu.GhiDuLieu("NhanVien", dsNhanVien)

            dsTaiKhoan = XL_DuLieu.DocDuLieu("select * from TaiKhoan where tk_ma = " + nhanVien("nv_ma_tai_khoan").ToString())
            Dim taiKhoan As DataRow = dsTaiKhoan.Rows(0)
            taiKhoan("tk_mat_khau") = nhanVien("tk_mat_khau")

            XL_DuLieu.GhiDuLieu("TaiKhoan", dsTaiKhoan)
            MessageBox.Show("Cap nhat nhan vien thanh cong", "Thong bao", MessageBoxButtons.OK)
            dsTaiKhoan.Rows.Remove(taiKhoan)
        End If
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim nhanVienView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim nhanVien As DataRow = nhanVienView.Row

            Dim chuoi As String = String.Format("Anh/chi co that su muon xoa '{0}-{1}' khong?", nhanVien("nv_ten"), nhanVien("nv_dia_chi"))
            Dim luaChon As DialogResult = MessageBox.Show(chuoi, "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If luaChon = DialogResult.Yes Then
                nhanVien("nv_xoa") = True

                XL_DuLieu.GhiDuLieu("NhanVien", dsNhanVien)
                dsNhanVien.Rows.Remove(nhanVien)
                MessageBox.Show("Xoa nhan vien thanh cong", "Thong bao", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub cbHienThiXoa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienThiXoa.CheckedChanged
        HienThiDSNhanVien()

        If cbHienThiXoa.Checked Then
            bPhucHoi.Enabled = True

            bThem.Enabled = False
            bCapNhat.Enabled = False
            bXoa.Enabled = False
        Else
            bPhucHoi.Enabled = False

            bThem.Enabled = True
            bCapNhat.Enabled = True
            bXoa.Enabled = True
        End If
    End Sub

    Private Sub bPhucHoi_Click(sender As Object, e As EventArgs) Handles bPhucHoi.Click
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim nhanVienView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim nhanVien As DataRow = nhanVienView.Row

            Dim chuoi As String = String.Format("Anh/chi co that su muon xoa '{0}-{1}' khong?", nhanVien("nv_ten"), nhanVien("nv_dia_chi"))
            Dim luaChon As DialogResult = MessageBox.Show(chuoi, "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If luaChon = DialogResult.Yes Then
                nhanVien("nv_xoa") = False

                XL_DuLieu.GhiDuLieu("NhanVien", dsNhanVien)
                dsNhanVien.Rows.Remove(nhanVien)
                MessageBox.Show("Phuc hoi nhan vien thanh cong", "Thong bao", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text <> "" Then
            dsNhanVienView.RowFilter = String.Format("nv_ten like '%{0}%' or nv_dia_chi like '%{0}%'", tbTimKiem.Text)
        Else
            dsNhanVienView.RowFilter = ""
        End If
    End Sub
End Class