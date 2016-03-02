Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.DataTable
Imports System.Data.DataSet
Public Class frmXemKH
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "workstation id=namlhps01805.mssql.somee.com;packet size=4096;user id=namlhps01805dtdm_SQLLogin_1;pwd=u4crhkdwiz;data source=namlhps01805.mssql.somee.com;persist security info=False;initial catalog=namlhps01805"
    Dim chuoiketnoi As String = "workstation id=taindps02013.mssql.somee.com;packet size=4096;user id=tainguyen_SQLLogin_1;pwd=ufz23ht9ah;data source=taindps02013.mssql.somee.com;persist security info=False;initial catalog=taindps02013"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim hienthi As New Class1
        dgvXemKH.DataSource = hienthi.Loadkhachang.Tables(0)
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select KHACH_HANG.MaKhachHang as 'Mã khách hàng', KHACH_HANG.Ten as 'Tên khách hàng', KHACH_HANG.SoDT as 'Số điện thoại', KHACH_HANG.DiaChi as 'Địa chỉ' from KHACH_HANG where KHACH_HANG.MaKhachHang='" & txtMaKH.Text & "' ", connect)
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemKH.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemKH.DataSource = db.DefaultView
                    txtMaKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMaKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmXemKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class