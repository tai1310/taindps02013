Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.DataTable
Imports System.Data.DataSet
Public Class frmXemHD
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "workstation id=namlhps01805.mssql.somee.com;packet size=4096;user id=namlhps01805dtdm_SQLLogin_1;pwd=u4crhkdwiz;data source=namlhps01805.mssql.somee.com;persist security info=False;initial catalog=namlhps01805"
    Dim chuoiketnoi As String = "workstation id=taindps02013.mssql.somee.com;packet size=4096;user id=tainguyen_SQLLogin_1;pwd=ufz23ht9ah;data source=taindps02013.mssql.somee.com;persist security info=False;initial catalog=taindps02013"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim hienthi As New Class1
        dgvXemHD.DataSource = hienthi.Loadhoadon.Tables(0)
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select HOA_DON.SoHoaDon as 'Số hóa đơn',HOA_DON.Ngay as 'Ngày',HOA_DON.MaKhachHang as 'Mã khách hàng',HOA_DON.TriGia as 'Trị giá',CHI_TIET_HOA_DON.MaLoaiSanPham as 'Mã loại SP',CHI_TIET_HOA_DON.SoLuong as 'Số lượng' from HOA_DON inner join CHI_TIET_HOA_DON on HOA_DON.SoHoaDon = CHI_TIET_HOA_DON.SoHoaDon where HOA_DON.SoHoaDon='" & txtMaHD.Text & "' ", connect)
        Try
            If txtMaHD.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemHD.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemHD.DataSource = db.DefaultView
                    txtMaHD.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMaHD.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

End Class