Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=taindps02013.mssql.somee.com;packet size=4096;user id=tainguyen_SQLLogin_1;pwd=ufz23ht9ah;data source=taindps02013.mssql.somee.com;persist security info=False;initial catalog=taindps02013"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select * from KHACH_HANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function

    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=taindps02013.mssql.somee.com;packet size=4096;user id=tainguyen_SQLLogin_1;pwd=ufz23ht9ah;data source=taindps02013.mssql.somee.com;persist security info=False;initial catalog=taindps02013"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select SAN_PHAM.MaLoaiSanPham as 'Mã sản phẩm', SAN_PHAM.TenSanPham as 'Tên sản phẩm', LOAI_SAN_PHAM.TenLoaiSanPham as 'Tên loại sản phẩm', SAN_PHAM.DonGia as 'Giá' from SAN_PHAM inner join LOAI_SAN_PHAM on SAN_PHAM.MaLoaiSanPham = LOAI_SAN_PHAM.MaLoaiSanPham", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function

    Public Function Loadhoadon() As DataSet
        Dim chuoiketnoi As String = "workstation id=taindps02013.mssql.somee.com;packet size=4096;user id=tainguyen_SQLLogin_1;pwd=ufz23ht9ah;data source=taindps02013.mssql.somee.com;persist security info=False;initial catalog=taindps02013"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select HOA_DON.SoHoaDon as 'Số hóa đơn',HOA_DON.Ngay as 'Ngày',HOA_DON.MaKhachHang as 'Mã khách hàng',HOA_DON.TriGia as 'Trị giá',CHI_TIET_HOA_DON.MaLoaiSanPham as 'Mã loại SP',CHI_TIET_HOA_DON.SoLuong as 'Số lượng' from HOA_DON inner join CHI_TIET_HOA_DON on HOA_DON.SoHoaDon = CHI_TIET_HOA_DON.SoHoaDon", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class

