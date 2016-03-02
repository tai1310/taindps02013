<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapNhapSP
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
        Me.dgvSanpham = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.txtTenLoaiSP = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSanpham
        '
        Me.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanpham.Location = New System.Drawing.Point(12, 160)
        Me.dgvSanpham.Name = "dgvSanpham"
        Me.dgvSanpham.Size = New System.Drawing.Size(570, 147)
        Me.dgvSanpham.TabIndex = 33
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(366, 122)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 32
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapnhat
        '
        Me.btnCapnhat.Location = New System.Drawing.Point(285, 122)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapnhat.TabIndex = 31
        Me.btnCapnhat.Text = "Cập nhật"
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(204, 122)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 30
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(123, 122)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 29
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(146, 96)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(197, 20)
        Me.txtGia.TabIndex = 27
        '
        'txtTenLoaiSP
        '
        Me.txtTenLoaiSP.Location = New System.Drawing.Point(146, 70)
        Me.txtTenLoaiSP.Name = "txtTenLoaiSP"
        Me.txtTenLoaiSP.Size = New System.Drawing.Size(197, 20)
        Me.txtTenLoaiSP.TabIndex = 28
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(146, 44)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(197, 20)
        Me.txtTenSP.TabIndex = 26
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(146, 18)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(197, 20)
        Me.txtMaSP.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Tên SP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Giá"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tên loại SP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Mã SP"
        '
        'frmCapNhapSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 324)
        Me.Controls.Add(Me.dgvSanpham)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapnhat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtGia)
        Me.Controls.Add(Me.txtTenLoaiSP)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCapNhapSP"
        Me.Text = "frmCapNhapSP"
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSanpham As System.Windows.Forms.DataGridView
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnCapnhat As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents txtGia As System.Windows.Forms.TextBox
    Friend WithEvents txtTenLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
