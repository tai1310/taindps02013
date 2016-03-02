Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frmCapNhapHD
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "workstation id=namlhps01805.mssql.somee.com;packet size=4096;user id=namlhps01805dtdm_SQLLogin_1;pwd=u4crhkdwiz;data source=namlhps01805.mssql.somee.com;persist security info=False;initial catalog=namlhps01805"
    Dim chuoiketnoi As String = "workstation id=taindps02013.mssql.somee.com;packet size=4096;user id=tainguyen_SQLLogin_1;pwd=ufz23ht9ah;data source=taindps02013.mssql.somee.com;persist security info=False;initial catalog=taindps02013"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub dgvSanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellContentClick
        Dim click As Integer = dgvHoaDon.CurrentCell.RowIndex
        txtSoHD.Text = dgvHoaDon.Item(0, click).Value
        txtNgay.Text = dgvHoaDon.Item(1, click).Value
        txtMaKH.Text = dgvHoaDon.Item(2, click).Value
        txtTriGia.Text = dgvHoaDon.Item(3, click).Value
        txtMaLoai.Text = dgvHoaDon.Item(4, click).Value
        txtSoLuong.Text = dgvHoaDon.Item(5, click).Value
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into CHI_TIET_HOA_DON values (@SoHoaDon,@MaLoai,@SoLuong) insert into HOA_DON values (@SoHoaDon,@Ngay,@MaKH,@TriGia) "
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()

        txtSoHD.Focus()
        If txtSoHD.Text = "" Then
            MessageBox.Show("Bạn chưa nhập số hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            txtNgay.Focus()
            If txtNgay.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtMaKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTriGia.Focus()
                    If txtTriGia.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMaLoai.Focus()
                        If txtMaLoai.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSoLuong.Focus()
                            If IsNumeric(txtSoLuong.Text) = False Then
                                MessageBox.Show("Bạn vui lòng nhập trị giá là số", "Lỗi sai định dạng !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@SoHD", txtSoHD.Text)
                                save.Parameters.AddWithValue("@MaLoai", txtNgay.Text)
                                save.Parameters.AddWithValue("@SoLuong", txtMaKH.Text)
                                save.Parameters.AddWithValue("@MaKH", txtTriGia.Text)
                                save.Parameters.AddWithValue("@Ngay", txtMaLoai.Text)
                                save.Parameters.AddWithValue("@TriGia", txtSoLuong.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtSoHD.Text = Nothing
                                txtNgay.Text = Nothing
                                txtTriGia.Text = Nothing
                                txtMaKH.Text = Nothing
                                txtSoLuong.Text = Nothing
                                txtMaLoai.Text = Nothing

                            End If
                        End If
                    End If
                End If
            End If
        End If


        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select HOA_DON.SoHoaDon as 'Số hóa đơn',HOA_DON.Ngay as 'Ngày',HOA_DON.MaKhachHang as 'Mã khách hàng',HOA_DON.TriGia as 'Trị giá',CHI_TIET_HOA_DON.MaLoaiSanPham as 'Mã loại SP',CHI_TIET_HOA_DON.SoLuong as 'Số lượng' from HOA_DON inner join CHI_TIET_HOA_DON on HOA_DON.SoHoaDon = CHI_TIET_HOA_DON.SoHoaDon", conn)
        db.Clear()
        refesh.Fill(db)
        dgvHoaDon.DataSource = db.DefaultView
    End Sub

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update HOA_DON set SoHoaDon=@SoHD,Ngay=@Ngay, MaKhachHang=@MaKH, TriGia=@TriGia where SoHoaDon=@SoHD update CHI_TIET_HOA_DON set MaLoaiSanPham=@MaLoai, SoLuong=@SoLuong, SoHoaDon=@SoHD where SoHoaDon=@SoHD"

        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try

            txtSoHD.Focus()
            If txtSoHD.Text = "" Then
                MessageBox.Show("Bạn chưa nhập số hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtNgay.Focus()
                If txtNgay.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtMaKH.Focus()
                    If txtMaKH.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtTriGia.Focus()
                        If txtTriGia.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtMaLoai.Focus()
                            If IsNumeric(txtMaLoai.Text) = False Then
                                MessageBox.Show("Bạn vui lòng nhập trị giá là ký tự số", "Lỗi sai định dạng !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                txtSoLuong.Focus()
                                If IsNumeric(txtSoLuong.Text) = False Then
                                    MessageBox.Show("Bạn vui lòng nhập trị giá là số", "Lỗi sai định dạng !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                Else
                                    addupdate.Parameters.AddWithValue("@SoHD", txtSoHD.Text)
                                    addupdate.Parameters.AddWithValue("@MaLoai", txtNgay.Text)
                                    addupdate.Parameters.AddWithValue("@SoLuong", txtMaKH.Text)
                                    addupdate.Parameters.AddWithValue("@MaKH", txtTriGia.Text)
                                    addupdate.Parameters.AddWithValue("@Ngay", txtMaLoai.Text)
                                    addupdate.Parameters.AddWithValue("@TriGia", txtSoLuong.Text)
                                    addupdate.ExecuteNonQuery()
                                    conn.Close() 'đóng kết nối
                                    MessageBox.Show("Cập nhật thành công")
                                    txtSoHD.Text = Nothing
                                    txtNgay.Text = Nothing
                                    txtMaKH.Text = Nothing
                                    txtTriGia.Text = Nothing
                                    txtSoLuong.Text = Nothing
                                    txtMaLoai.Text = Nothing
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvHoaDon.DataSource = db
        dgvHoaDon.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select HOA_DON.SoHoaDon as 'Số hóa đơn',HOA_DON.Ngay as 'Ngày',HOA_DON.MaKhachHang as 'Mã khách hàng',HOA_DON.TriGia as 'Trị giá',CHI_TIET_HOA_DON.MaLoaiSanPham as 'Mã loại SP',CHI_TIET_HOA_DON.SoLuong as 'Số lượng' from HOA_DON inner join CHI_TIET_HOA_DON on HOA_DON.SoHoaDon = CHI_TIET_HOA_DON.SoHoaDon", conn)
        conn.Open()
        load.Fill(db)
        dgvHoaDon.DataSource = db.DefaultView
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from HOA_DON where SoHoaDon=@SoHD delete from CHI_TIET_HOA_DON where SoHoaDon=@SoHD"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtSoHD.Text = "" Then
                MessageBox.Show("Bạn cần chọn hóa đơn để xóa", "Lỗi ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtSoHD.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@SoHD", txtTriGia.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtSoHD.Text = Nothing
                    txtNgay.Text = Nothing
                    txtMaKH.Text = Nothing
                    txtTriGia.Text = Nothing
                    txtMaLoai.Text = Nothing
                    txtSoLuong.Text = Nothing
                    txtSoLuong.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã háo đơn cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvHoaDon.DataSource = db
        dgvHoaDon.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select HOA_DON.SoHoaDon as 'Số hóa đơn',HOA_DON.Ngay as 'Ngày',HOA_DON.MaKhachHang as 'Mã khách hàng',HOA_DON.TriGia as 'Trị giá',CHI_TIET_HOA_DON.MaLoaiSanPham as 'Mã loại SP',CHI_TIET_HOA_DON.SoLuong as 'Số lượng' from HOA_DON inner join CHI_TIET_HOA_DON on HOA_DON.SoHoaDon = CHI_TIET_HOA_DON.SoHoaDon", conn)

        conn.Open()
        load.Fill(db)
        dgvHoaDon.DataSource = db.DefaultView
    End Sub
    Private Sub frmCapNhapHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select HOA_DON.SoHoaDon as 'Số hóa đơn',HOA_DON.Ngay as 'Ngày',HOA_DON.MaKhachHang as 'Mã khách hàng',HOA_DON.TriGia as 'Trị giá',CHI_TIET_HOA_DON.MaLoaiSanPham as 'Mã loại SP',CHI_TIET_HOA_DON.SoLuong as 'Số lượng' from HOA_DON inner join CHI_TIET_HOA_DON on HOA_DON.SoHoaDon = CHI_TIET_HOA_DON.SoHoaDon", conn)

        conn.Open()
        load.Fill(db)
        dgvHoaDon.DataSource = db.DefaultView
    End Sub

End Class