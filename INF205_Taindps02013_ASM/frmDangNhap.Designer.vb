<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangNhap))
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnDN = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.txtTaiKhoan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(183, 151)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(96, 27)
        Me.btnThoat.TabIndex = 15
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnDN
        '
        Me.btnDN.Location = New System.Drawing.Point(78, 151)
        Me.btnDN.Name = "btnDN"
        Me.btnDN.Size = New System.Drawing.Size(96, 27)
        Me.btnDN.TabIndex = 14
        Me.btnDN.Text = "Đăng nhập"
        Me.btnDN.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 39)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Gợi ý : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TK : admin " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MK: admin"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(78, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 61)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(78, 121)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(188, 20)
        Me.txtMatKhau.TabIndex = 11
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.Location = New System.Drawing.Point(78, 95)
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(188, 20)
        Me.txtTaiKhoan.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Mật khẩu :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tài khoản :"
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 199)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTaiKhoan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDangNhap"
        Me.Text = "frmDangNhap"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnDN As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents txtTaiKhoan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
