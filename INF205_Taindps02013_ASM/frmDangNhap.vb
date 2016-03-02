Public Class frmDangNhap

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDN.Click
        If txtTaiKhoan.Text = "admin" And txtMatKhau.Text = "admin" Then
            frmQuanLy.Show()
            Me.Close()
            frmMain.tsmDN.Enabled = False
            frmMain.tsmDX.Enabled = True
        Else
            MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()

    End Sub
End Class