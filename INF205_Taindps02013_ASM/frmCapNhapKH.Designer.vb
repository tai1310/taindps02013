<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapNhapKH
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
        Me.txtSoDT = New System.Windows.Forms.TextBox()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtTenkh = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblSoDT = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSoDT
        '
        Me.txtSoDT.Location = New System.Drawing.Point(113, 81)
        Me.txtSoDT.Name = "txtSoDT"
        Me.txtSoDT.Size = New System.Drawing.Size(267, 20)
        Me.txtSoDT.TabIndex = 33
        '
        'dgvKH
        '
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(55, 136)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.Size = New System.Drawing.Size(548, 171)
        Me.dgvKH.TabIndex = 32
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(316, 107)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 29
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(154, 107)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 30
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnCapnhat
        '
        Me.btnCapnhat.Location = New System.Drawing.Point(235, 107)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapnhat.TabIndex = 31
        Me.btnCapnhat.Text = "Cập Nhật"
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(114, 55)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(267, 20)
        Me.txtDiaChi.TabIndex = 26
        '
        'txtTenkh
        '
        Me.txtTenkh.Location = New System.Drawing.Point(114, 29)
        Me.txtTenkh.Name = "txtTenkh"
        Me.txtTenkh.Size = New System.Drawing.Size(267, 20)
        Me.txtTenkh.TabIndex = 27
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(114, 3)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(267, 20)
        Me.txtMaKH.TabIndex = 28
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(73, 107)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 25
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblSoDT
        '
        Me.lblSoDT.AutoSize = True
        Me.lblSoDT.Location = New System.Drawing.Point(53, 84)
        Me.lblSoDT.Name = "lblSoDT"
        Me.lblSoDT.Size = New System.Drawing.Size(38, 13)
        Me.lblSoDT.TabIndex = 21
        Me.lblSoDT.Text = "Số ĐT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Địa chỉ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tên KH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Mã KH"
        '
        'frmCapNhapHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 311)
        Me.Controls.Add(Me.txtSoDT)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnCapnhat)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtTenkh)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lblSoDT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCapNhapHD"
        Me.Text = "frmCapNhapKH"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSoDT As System.Windows.Forms.TextBox
    Friend WithEvents dgvKH As System.Windows.Forms.DataGridView
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnCapnhat As System.Windows.Forms.Button
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtTenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents lblSoDT As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
