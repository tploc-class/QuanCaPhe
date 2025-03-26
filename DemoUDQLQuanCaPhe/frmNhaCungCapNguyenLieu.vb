Public Class frmNhaCungCapNguyenLieu
    Public Shared TRANG_THAI_THEM = "Them"
    Public Shared TRANG_THAI_CAP_NHAT = "CapNhat"

    Public TrangThai As String
    Public NhaCungCap As DataRow
    Public NhaCungCapNguyenLieu As DataRow

    Dim dsNguyenLieu As DataTable

    Private Sub frmNhaCungCapNguyenLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lNhaCungCap.Text = NhaCungCap("ncc_code") + "-" + NhaCungCap("ncc_ten")

        dsNguyenLieu = XL_DuLieu.DocDuLieu("Select * from NguyenLieu where nl_xoa=False")
        cbNguyenLieu.DataSource = dsNguyenLieu
        cbNguyenLieu.ValueMember = "nl_ma"
        cbNguyenLieu.DisplayMember = "nl_ten"

        If TrangThai = TRANG_THAI_CAP_NHAT Then
            cbNguyenLieu.SelectedValue = NhaCungCapNguyenLieu("nccnl_nguyen_lieu")
            tbGia.Text = NhaCungCapNguyenLieu("nccnl_gia")

            bThem.Visible = False
        Else TrangThai = TRANG_THAI_THEM
            bCapNhat.Visible = False
        End If


    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        NhaCungCapNguyenLieu("nccnl_nha_cung_cap") = NhaCungCap("ncc_ma")
        NhaCungCapNguyenLieu("ncc_ten") = NhaCungCap("ncc_ten")
        NhaCungCapNguyenLieu("nccnl_nguyen_lieu") = cbNguyenLieu.SelectedItem("nl_ma")
        NhaCungCapNguyenLieu("nl_ten") = cbNguyenLieu.SelectedItem("nl_ten")
        NhaCungCapNguyenLieu("nccnl_gia") = tbGia.Text
        NhaCungCapNguyenLieu("nccnl_ghi_chu") = tbGhiChu.Text
        NhaCungCapNguyenLieu("nccnl_xoa") = False
    End Sub

    Private Sub bCapNhat_Click(sender As Object, e As EventArgs) Handles bCapNhat.Click
        NhaCungCapNguyenLieu("nccnl_nguyen_lieu") = cbNguyenLieu.SelectedItem("nl_ma")
        NhaCungCapNguyenLieu("nl_ten") = cbNguyenLieu.SelectedItem("nl_ten")
        NhaCungCapNguyenLieu("nccnl_gia") = tbGia.Text
        NhaCungCapNguyenLieu("nccnl_ghi_chu") = tbGhiChu.Text
    End Sub
End Class