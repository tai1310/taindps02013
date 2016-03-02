Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmXemSP
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "workstation id=namlhps01805.mssql.somee.com;packet size=4096;user id=namlhps01805dtdm_SQLLogin_1;pwd=u4crhkdwiz;data source=namlhps01805.mssql.somee.com;persist security info=False;initial catalog=namlhps01805"
    Dim chuoiketnoi As String = "workstation id=taindps02013.mssql.somee.com;packet size=4096;user id=tainguyen_SQLLogin_1;pwd=ufz23ht9ah;data source=taindps02013.mssql.somee.com;persist security info=False;initial catalog=taindps02013"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select SAN_PHAM.MaLoaiSanPham as 'Mã sản phẩm', SAN_PHAM.TenSanPham as 'Tên sản phẩm', LOAI_SAN_PHAM.TenLoaiSanPham as 'Tên loại sản phẩm', SAN_PHAM.DonGia as 'Giá' from SAN_PHAM inner join LOAI_SAN_PHAM on SAN_PHAM.MaLoaiSanPham = LOAI_SAN_PHAM.MaLoaiSanPham where SAN_PHAM.MaLoaiSanPham='" & txtMaSP.Text & "' ", connect)
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMaSP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMaSP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim hienthi As New Class1
        dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmDanhSachSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class