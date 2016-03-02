Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frmCapNhapSP
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "workstation id=namlhps01805.mssql.somee.com;packet size=4096;user id=namlhps01805dtdm_SQLLogin_1;pwd=u4crhkdwiz;data source=namlhps01805.mssql.somee.com;persist security info=False;initial catalog=namlhps01805"
    Dim chuoiketnoi As String = "workstation id=taindps02013.mssql.somee.com;packet size=4096;user id=tainguyen_SQLLogin_1;pwd=ufz23ht9ah;data source=taindps02013.mssql.somee.com;persist security info=False;initial catalog=taindps02013"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SAN_PHAM values (@MaSP,@TenSP,@Gia) insert into LOAI_SAN_PHAM values(@MaSP,@TenLoaiSP)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()

        If txtMaSP.Text = "" Then
            MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            txtTenSP.Focus()
            If txtTenSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtTenLoaiSP.Focus()
                If txtTenLoaiSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên loại sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtGia.Focus()
                    If IsNumeric(txtGia.Text) = False Then
                        MessageBox.Show("Bạn vui lòng nhập giá", "Nhập thiếu !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        save.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                        save.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
                        save.Parameters.AddWithValue("@TenLoaiSP", txtTenLoaiSP.Text)
                        save.Parameters.AddWithValue("@Gia", txtGia.Text)
                        save.ExecuteNonQuery()
                        MessageBox.Show("Lưu thành công")
                        'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                        txtMaSP.Text = Nothing
                        txtTenSP.Text = Nothing
                        txtTenLoaiSP.Text = Nothing
                        txtGia.Text = Nothing

                    End If
                End If
            End If
        End If

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.MaLoaiSanPham as 'Mã sản phẩm',SAN_PHAM.TenSanPham as 'Tên sản phẩm',LOAI_SAN_PHAM.TenLoaiSanPham as 'Tên loại sản phẩm',SAN_PHAM.DonGia as 'Giá' from SAN_PHAM inner join LOAI_SAN_PHAM on SAN_PHAM.MaLoaiSanPham = LOAI_SAN_PHAM.MaLoaiSanPham", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.MaLoaiSanPham as 'Mã sản phẩm',SAN_PHAM.TenSanPham as 'Tên sản phẩm',LOAI_SAN_PHAM.TenLoaiSanPham as 'Tên loại sản phẩm',SAN_PHAM.DonGia as 'Giá' from SAN_PHAM inner join LOAI_SAN_PHAM on SAN_PHAM.MaLoaiSanPham = LOAI_SAN_PHAM.MaLoaiSanPham", conn)
        conn.Open()
        load.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SAN_PHAM set MaLoaiSanPham=@MaSP,TenSanPham=@TenSP, DonGia=@Gia where MaLoaiSanPham=@MaSP update LOAI_SAN_PHAM set MaLoaiSanPham=@MaSP, TenLoaiSanPham=@TenLoaiSP where MaLoaiSanPham=@MaSP"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtTenSP.Focus()
                If txtTenSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenLoaiSP.Focus()
                    If txtTenLoaiSP.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập tên loại sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtGia.Focus()
                        If IsNumeric(txtGia.Text) = False Then
                            MessageBox.Show("Bạn vui lòng nhập giá", "Lỗi sai định dạng !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            addupdate.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                            addupdate.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
                            addupdate.Parameters.AddWithValue("@TenLoaiSP", txtTenLoaiSP.Text)
                            addupdate.Parameters.AddWithValue("@Gia", txtGia.Text)
                            addupdate.ExecuteNonQuery()
                            conn.Close() 'đóng kết nối
                            MessageBox.Show("Cập nhật thành công")
                            txtMaSP.Text = Nothing
                            txtTenSP.Text = Nothing
                            txtTenLoaiSP.Text = Nothing
                            txtGia.Text = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from LOAI_SAN_PHAM where MaLoaiSanPham=@MaSP delete from SAN_PHAM where MaLoaiSanPham=@MaSP"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaSP.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMaSP.Text = Nothing
                    txtTenSP.Text = Nothing
                    txtTenLoaiSP.Text = Nothing
                    txtGia.Text = Nothing
                    txtMaSP.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub dgvSanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanpham.CellContentClick
        Dim click As Integer = dgvSanpham.CurrentCell.RowIndex
        txtMaSP.Text = dgvSanpham.Item(0, click).Value
        txtTenSP.Text = dgvSanpham.Item(1, click).Value
        txtTenLoaiSP.Text = dgvSanpham.Item(2, click).Value
        txtGia.Text = dgvSanpham.Item(3, click).Value
    End Sub

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.MaLoaiSanPham as 'Mã sản phẩm',SAN_PHAM.TenSanPham as 'Tên sản phẩm',LOAI_SAN_PHAM.TenLoaiSanPham as 'Tên loại sản phẩm',SAN_PHAM.DonGia as 'Giá' from SAN_PHAM inner join LOAI_SAN_PHAM on SAN_PHAM.MaLoaiSanPham = LOAI_SAN_PHAM.MaLoaiSanPham", conn)

        conn.Open()
        load.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub

    Private Sub frmCapNhapSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.MaLoaiSanPham as 'Mã sản phẩm',SAN_PHAM.TenSanPham as 'Tên sản phẩm',LOAI_SAN_PHAM.TenLoaiSanPham as 'Tên loại sản phẩm',SAN_PHAM.DonGia as 'Giá' from SAN_PHAM inner join LOAI_SAN_PHAM on SAN_PHAM.MaLoaiSanPham = LOAI_SAN_PHAM.MaLoaiSanPham", conn)
        conn.Open()
        load.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub
End Class