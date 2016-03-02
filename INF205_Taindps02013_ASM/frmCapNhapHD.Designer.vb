<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapNhapHD
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvHoaDon = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.txtTriGia = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtNgay = New System.Windows.Forms.TextBox()
        Me.txtSoHD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 26)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "định dạng :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "yyyymmdd"
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(413, 2)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.Size = New System.Drawing.Size(98, 20)
        Me.txtMaLoai.TabIndex = 43
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(413, 28)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(197, 20)
        Me.txtSoLuong.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Trị Giá"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Ngày"
        '
        'dgvHoaDon
        '
        Me.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoaDon.Location = New System.Drawing.Point(30, 154)
        Me.dgvHoaDon.Name = "dgvHoaDon"
        Me.dgvHoaDon.Size = New System.Drawing.Size(570, 143)
        Me.dgvHoaDon.TabIndex = 39
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(322, 125)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 38
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapnhat
        '
        Me.btnCapnhat.Location = New System.Drawing.Point(223, 125)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapnhat.TabIndex = 37
        Me.btnCapnhat.Text = "Cập nhật"
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(126, 125)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 36
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(30, 125)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 35
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'txtTriGia
        '
        Me.txtTriGia.Location = New System.Drawing.Point(148, 80)
        Me.txtTriGia.Name = "txtTriGia"
        Me.txtTriGia.Size = New System.Drawing.Size(197, 20)
        Me.txtTriGia.TabIndex = 33
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(148, 54)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(197, 20)
        Me.txtMaKH.TabIndex = 32
        '
        'txtNgay
        '
        Me.txtNgay.Location = New System.Drawing.Point(148, 28)
        Me.txtNgay.Name = "txtNgay"
        Me.txtNgay.Size = New System.Drawing.Size(197, 20)
        Me.txtNgay.TabIndex = 34
        '
        'txtSoHD
        '
        Me.txtSoHD.Location = New System.Drawing.Point(148, 2)
        Me.txtSoHD.Name = "txtSoHD"
        Me.txtSoHD.Size = New System.Drawing.Size(197, 20)
        Me.txtSoHD.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Mã khách hàng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(358, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Số lượng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(349, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Mã loại SP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Số HĐ"
        '
        'frmCapNhapHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 311)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvHoaDon)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapnhat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtTriGia)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.txtNgay)
        Me.Controls.Add(Me.txtSoHD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmCapNhapHD"
        Me.Text = "frmCapNhapHD"
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMaLoai As System.Windows.Forms.TextBox
    Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvHoaDon As System.Windows.Forms.DataGridView
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnCapnhat As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents txtTriGia As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents txtNgay As System.Windows.Forms.TextBox
    Friend WithEvents txtSoHD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
