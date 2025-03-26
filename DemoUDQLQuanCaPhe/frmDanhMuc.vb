Public Class frmDanhMuc
    Private dsDanhMuc As DataTable
    Private Sub frmDanhMuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim truy_van As String = "Select * from DanhMuc where dm_xoa = false"
        dsDanhMuc = XL_DuLieu.DocDuLieu(truy_van)

        dgvDanhSach.DataSource = dsDanhMuc
        dgvDanhSach.Columns(0).Visible = False
        dgvDanhSach.Columns(4).Visible = False
        dgvDanhSach.Columns(1).HeaderText = "Ma"
        dgvDanhSach.Columns(2).HeaderText = "Ten"
        dgvDanhSach.Columns(3).HeaderText = "Mo ta"
    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        Dim DanhMuc As DataRow = dsDanhMuc.NewRow()

        DanhMuc("dm_code") = tbMa.Text
        DanhMuc("dm_ten") = tbTen.Text
        DanhMuc("dm_mo_ta") = tbMoTa.Text
        DanhMuc("dm_xoa") = False

        dsDanhMuc.Rows.Add(DanhMuc)
        XL_DuLieu.GhiDuLieu("DanhMuc", dsDanhMuc)
        MessageBox.Show("Them danh muc thanh cong", "Thong bao", MessageBoxButtons.OK)
    End Sub

    Private Sub dgvDanhSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellClick
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim danhMucView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim danhMuc As DataRow = danhMucView.Row

            tbMa.Text = danhMuc("dm_code")
            tbTen.Text = danhMuc("dm_ten")
            tbMoTa.Text = danhMuc("dm_mo_ta")
        End If
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim danhMucView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim danhMuc As DataRow = danhMucView.Row

            danhMuc("dm_code") = tbMa.Text
            danhMuc("dm_ten") = tbTen.Text
            danhMuc("dm_mo_ta") = tbMoTa.Text

            XL_DuLieu.GhiDuLieu("DanhMuc", dsDanhMuc)
            MessageBox.Show("Cap nhat danh muc thanh cong", "Thong bao", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim danhMucView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim danhMuc As DataRow = danhMucView.Row

            danhMuc("dm_xoa") = True

            XL_DuLieu.GhiDuLieu("DanhMuc", dsDanhMuc)
            dsDanhMuc.Rows.Remove(danhMuc)
            MessageBox.Show("Xoa danh muc thanh cong", "Thong bao", MessageBoxButtons.OK)
        End If
    End Sub
End Class