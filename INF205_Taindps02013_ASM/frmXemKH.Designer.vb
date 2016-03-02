<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemKH
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
        Me.dgvXemKH = New System.Windows.Forms.DataGridView()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvXemKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(339, 56)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 16
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'dgvXemKH
        '
        Me.dgvXemKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemKH.Location = New System.Drawing.Point(12, 85)
        Me.dgvXemKH.Name = "dgvXemKH"
        Me.dgvXemKH.Size = New System.Drawing.Size(570, 208)
        Me.dgvXemKH.TabIndex = 15
        '
        'btnXemall
        '
        Me.btnXemall.Location = New System.Drawing.Point(258, 56)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(75, 23)
        Me.btnXemall.TabIndex = 13
        Me.btnXemall.Text = "Xem tất cả"
        Me.btnXemall.UseVisualStyleBackColor = True
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(177, 56)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 23)
        Me.btnXem.TabIndex = 14
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(211, 30)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(160, 20)
        Me.txtMaKH.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mã KH"
        '
        'frmXemKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 314)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.dgvXemKH)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmXemKH"
        Me.Text = "frmXemKH"
        CType(Me.dgvXemKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents dgvXemKH As System.Windows.Forms.DataGridView
    Friend WithEvents btnXemall As System.Windows.Forms.Button
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
