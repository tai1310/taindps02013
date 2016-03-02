<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemSP
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
        Me.dgvXemsp = New System.Windows.Forms.DataGridView()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(339, 41)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 16
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'dgvXemsp
        '
        Me.dgvXemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemsp.Location = New System.Drawing.Point(9, 70)
        Me.dgvXemsp.Name = "dgvXemsp"
        Me.dgvXemsp.Size = New System.Drawing.Size(606, 222)
        Me.dgvXemsp.TabIndex = 15
        '
        'btnXemall
        '
        Me.btnXemall.Location = New System.Drawing.Point(258, 41)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(75, 23)
        Me.btnXemall.TabIndex = 13
        Me.btnXemall.Text = "Xem tất cả"
        Me.btnXemall.UseVisualStyleBackColor = True
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(177, 41)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 23)
        Me.btnXem.TabIndex = 14
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(224, 15)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(160, 20)
        Me.txtMaSP.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mã SP"
        '
        'frmXemSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 306)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.dgvXemsp)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmXemSP"
        Me.Text = "frmXemSP"
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents dgvXemsp As System.Windows.Forms.DataGridView
    Friend WithEvents btnXemall As System.Windows.Forms.Button
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
