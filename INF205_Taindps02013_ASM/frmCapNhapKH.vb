Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frmCapNhapKH
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "workstation id=namlhps01805.mssql.somee.com;packet size=4096;user id=namlhps01805dtdm_SQLLogin_1;pwd=u4crhkdwiz;data source=namlhps01805.mssql.somee.com;persist security info=False;initial catalog=namlhps01805"
    Dim chuoiketnoi As String = "workstation id=taindps02013.mssql.somee.com;packet size=4096;user id=tainguyen_SQLLogin_1;pwd=ufz23ht9ah;data source=taindps02013.mssql.somee.com;persist security info=False;initial catalog=taindps02013"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACH_HANG values (@MaKhachHang,@Ten,@SoDT,@DiaChi)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()

        If txtMaKH.Text = "" Then
            MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            txtTenkh.Focus()
            If txtTenkh.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtSoDT.Focus()
                If IsNumeric(txtSoDT.Text) = False Then
                    MessageBox.Show("Bạn vui lòng nhập số điện thoại là số", "Lỗi sai định dạng !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtDiaChi.Focus()
                    If txtDiaChi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        save.Parameters.AddWithValue("@MaKhachHang", txtMaKH.Text)
                        save.Parameters.AddWithValue("@Ten", txtTenkh.Text)
                        save.Parameters.AddWithValue("@SoDT", txtSoDT.Text)
                        save.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                        save.ExecuteNonQuery()
                        MessageBox.Show("Lưu thành công")
                        'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                        txtMaKH.Text = Nothing
                        txtTenkh.Text = Nothing
                        txtSoDT.Text = Nothing
                        txtDiaChi.Text = Nothing

                    End If
                End If
            End If
        End If

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select KHACH_HANG.MaKhachHang as 'Mã KH',KHACH_HANG.Ten as 'Tên KH', KHACH_HANG.SoDT as 'Số ĐT', KHACH_HANG.DiaChi as 'Địa chỉ' from KHACH_HANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKhachHang as 'Mã KH' ,Ten as 'Tên Khách Hàng', SoDT as 'Số ĐT', DiaChi as 'Địa chỉ' from KHACH_HANG", conn)
        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from KHACH_HANG where MaKhachHang=@MaKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần chọn khách hàng để xóa", "Lỗi ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaKH.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtMaKH.Text = Nothing
                    txtTenkh.Text = Nothing
                    txtSoDT.Text = Nothing
                    txtDiaChi.Text = Nothing
                    txtMaKH.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKhachHang as 'Mã KH' ,Ten as 'Tên Khách Hàng', SoDT as 'Số ĐT', DiaChi as 'Địa chỉ' from KHACH_HANG", conn)

        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        Dim click As Integer = dgvKH.CurrentCell.RowIndex
        txtMaKH.Text = dgvKH.Item(0, click).Value
        txtTenkh.Text = dgvKH.Item(1, click).Value
        txtSoDT.Text = dgvKH.Item(2, click).Value
        txtDiaChi.Text = dgvKH.Item(3, click).Value
    End Sub

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KHACH_HANG set MaKhachHang=@MaKH,Ten=@Ten, SoDT=@SoDT, DiaChi=@DiaChi where MaKhachHang=@MaKH"

        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtTenkh.Focus()
                If txtTenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtSoDT.Focus()
                    If IsNumeric(txtSoDT.Text) = False Then
                        MessageBox.Show("Bạn vui lòng nhập số điện thoại là số", "Lỗi sai định dạng !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtDiaChi.Focus()
                        If txtDiaChi.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            addupdate.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                            addupdate.Parameters.AddWithValue("@Ten", txtTenkh.Text)
                            addupdate.Parameters.AddWithValue("@SoDT", txtSoDT.Text)
                            addupdate.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                            addupdate.ExecuteNonQuery()
                            conn.Close() 'đóng kết nối
                            MessageBox.Show("Cập nhật thành công")
                            txtMaKH.Text = Nothing
                            txtTenkh.Text = Nothing
                            txtSoDT.Text = Nothing
                            txtDiaChi.Text = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub frmCapNhapKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKhachHang as 'Mã KH' ,Ten as 'Tên Khách Hàng', SoDT as 'Số ĐT', DiaChi as 'Địa chỉ' from KHACH_HANG", conn)

        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub
End Class