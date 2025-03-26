Public Class frmMonAn

    Dim dsMonAn As DataTable
    Dim dsMonAnView As DataView
    Dim dsDanhMuc As DataTable

    Sub HienThiDSMonAn()
        Dim truy_van As String = "Select ma_ma, ma_code, ma_ten, dm_ten, ma_mo_ta, ma_danh_muc, ma_xoa from MonAn, DanhMuc where ma_danh_muc = dm_ma and ma_xoa = " + cbHienThiXoa.Checked.ToString()
        dsMonAn = XL_DuLieu.DocDuLieu(truy_van)
        dsMonAnView = New DataView(dsMonAn)
        dgvDanhSach.DataSource = dsMonAnView

        dgvDanhSach.Columns(0).Visible = False
        dgvDanhSach.Columns(5).Visible = False
        dgvDanhSach.Columns(6).Visible = False
    End Sub

    Private Sub frmMonAn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim truy_van As String = "Select * from DanhMuc where dm_xoa = false"
        dsDanhMuc = XL_DuLieu.DocDuLieu(truy_van)
        cbDanhMuc.DataSource = dsDanhMuc
        cbDanhMuc.ValueMember = "dm_ma"
        cbDanhMuc.DisplayMember = "dm_ten"

        HienThiDSMonAn()
        bPhucHoi.Enabled = False
    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        Dim monAn As DataRow = dsMonAn.NewRow()
        monAn("ma_code") = tbMa.Text
        monAn("ma_ten") = tbTen.Text
        monAn("ma_mo_ta") = tbMoTa.Text
        monAn("ma_danh_muc") = cbDanhMuc.Items(cbDanhMuc.SelectedIndex)("dm_ma")
        monAn("ma_xoa") = False
        monAn("dm_ten") = cbDanhMuc.Items(cbDanhMuc.SelectedIndex)("dm_ten")

        dsMonAn.Rows.Add(monAn)
        XL_DuLieu.GhiDuLieu("MonAn", dsMonAn)
        MessageBox.Show("Them mon an thanh cong", "Thong bao", MessageBoxButtons.OK)
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim monAnView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim monAn As DataRow = monAnView.Row

            monAn("ma_code") = tbMa.Text
            monAn("ma_ten") = tbTen.Text
            monAn("ma_mo_ta") = tbMoTa.Text
            monAn("ma_danh_muc") = cbDanhMuc.Items(cbDanhMuc.SelectedIndex)("dm_ma")
            monAn("dm_ten") = cbDanhMuc.Items(cbDanhMuc.SelectedIndex)("dm_ten")

            XL_DuLieu.GhiDuLieu("MonAn", dsMonAn)

            MessageBox.Show("Cap nhat mon an thanh cong", "Thong bao", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub bXoa_Click(sender As Object, e As EventArgs) Handles bXoa.Click
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim monAnView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim monAn As DataRow = monAnView.Row

            Dim chuoi As String = String.Format("Anh/chi co that su muon xoa '{0}-{1}' khong?", monAn("ma_code"), monAn("ma_ten"))
            Dim luaChon As DialogResult = MessageBox.Show(chuoi, "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If luaChon = DialogResult.Yes Then
                monAn("ma_xoa") = True

                XL_DuLieu.GhiDuLieu("MonAn", dsMonAn)
                dsMonAn.Rows.Remove(monAn)
                MessageBox.Show("Xoa mon an thanh cong", "Thong bao", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub dgvDanhSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellClick
        If dgvDanhSach.SelectedCells.Count() > 0 Then
            Dim row_index As Integer = dgvDanhSach.SelectedCells(0).RowIndex
            Dim monAnView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim monAn As DataRow = monAnView.Row

            tbMa.Text = monAn("ma_code")
            tbTen.Text = monAn("ma_ten")
            tbMoTa.Text = monAn("ma_mo_ta")
            cbDanhMuc.SelectedValue = monAn("ma_danh_muc")
        End If
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text <> "" Then
            dsMonAnView.RowFilter = String.Format("ma_ten like '%{0}%' or ma_code like '%{0}%'", tbTimKiem.Text)
        Else
            dsMonAnView.RowFilter = ""
        End If
    End Sub

    Private Sub cbHienThiXoa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienThiXoa.CheckedChanged
        HienThiDSMonAn()

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
            Dim monAnView As DataRowView = dgvDanhSach.Rows(row_index).DataBoundItem
            Dim monAn As DataRow = monAnView.Row

            Dim chuoi As String = String.Format("Anh/chi co that su muon phuc hoi '{0}-{1}' khong?", monAn("ma_code"), monAn("ma_ten"))
            Dim luaChon As DialogResult = MessageBox.Show(chuoi, "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If luaChon = DialogResult.Yes Then
                monAn("ma_xoa") = False

                XL_DuLieu.GhiDuLieu("MonAn", dsMonAn)
                dsMonAn.Rows.Remove(monAn)
                MessageBox.Show("Phuc hoi mon an thanh cong", "Thong bao", MessageBoxButtons.OK)
            End If
        End If
    End Sub
End Class