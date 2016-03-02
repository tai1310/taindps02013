<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemHD
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
        Me.btnDong = New System.Windows.Forms.Button()
        Me.dgvXemHD = New System.Windows.Forms.DataGridView()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvXemHD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(358, 43)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 16
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'dgvXemHD
        '
        Me.dgvXemHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemHD.Location = New System.Drawing.Point(50, 72)
        Me.dgvXemHD.Name = "dgvXemHD"
        Me.dgvXemHD.Size = New System.Drawing.Size(570, 239)
        Me.dgvXemHD.TabIndex = 15
        '
        'btnXemall
        '
        Me.btnXemall.Location = New System.Drawing.Point(277, 43)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(75, 23)
        Me.btnXemall.TabIndex = 13
        Me.btnXemall.Text = "Xem tất cả"
        Me.btnXemall.UseVisualStyleBackColor = True
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(196, 43)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 23)
        Me.btnXem.TabIndex = 14
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(242, 17)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(160, 20)
        Me.txtMaHD.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mã HĐ"
        '
        'frmXemHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 328)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.dgvXemHD)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmXemHD"
        Me.Text = "frmXemHD"
        CType(Me.dgvXemHD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents dgvXemHD As System.Windows.Forms.DataGridView
    Friend WithEvents btnXemall As System.Windows.Forms.Button
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
