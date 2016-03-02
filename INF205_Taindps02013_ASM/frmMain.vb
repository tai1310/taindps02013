Public Class frmMain
    
    Private Sub tsmDN_Click(sender As Object, e As EventArgs) Handles tsmDN.Click
        frmDangNhap.Show()
    End Sub

    Private Sub tsmDX_Click(sender As Object, e As EventArgs) Handles tsmDX.Click
        tsmDN.Enabled = True
        tsmDX.Enabled = False
    End Sub

    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsmDX.Enabled = False
    End Sub
End Class