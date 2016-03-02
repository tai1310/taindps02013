<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmDN = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDX = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmDN, Me.tsmDX, Me.tsmExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(607, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmDN
        '
        Me.tsmDN.Image = CType(resources.GetObject("tsmDN.Image"), System.Drawing.Image)
        Me.tsmDN.Name = "tsmDN"
        Me.tsmDN.Size = New System.Drawing.Size(95, 20)
        Me.tsmDN.Text = "Đăng Nhập"
        '
        'tsmDX
        '
        Me.tsmDX.Image = CType(resources.GetObject("tsmDX.Image"), System.Drawing.Image)
        Me.tsmDX.Name = "tsmDX"
        Me.tsmDX.Size = New System.Drawing.Size(90, 20)
        Me.tsmDX.Text = "Đăng Xuất"
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(37, 20)
        Me.tsmExit.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(565, 196)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "INF205-ĐIỆN TOÁN ĐÁM MÂY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GVHD: Lê Văn Phụng" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lớp PT10304" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tên SV : Nguyễn Đức Tà" & _
    "i - PS02013" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email : taindps02013@fpt.edu.vn" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 304)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmDN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDX As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
