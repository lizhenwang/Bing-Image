<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.pb_LOGO = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_ver = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pb_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_LOGO
        '
        Me.pb_LOGO.Image = CType(resources.GetObject("pb_LOGO.Image"), System.Drawing.Image)
        Me.pb_LOGO.Location = New System.Drawing.Point(114, 14)
        Me.pb_LOGO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_LOGO.Name = "pb_LOGO"
        Me.pb_LOGO.Size = New System.Drawing.Size(100, 100)
        Me.pb_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_LOGO.TabIndex = 0
        Me.pb_LOGO.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "缤纷必应 特别版"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_ver
        '
        Me.lbl_ver.Location = New System.Drawing.Point(12, 144)
        Me.lbl_ver.Name = "lbl_ver"
        Me.lbl_ver.Size = New System.Drawing.Size(304, 29)
        Me.lbl_ver.TabIndex = 2
        Me.lbl_ver.Text = "Label2"
        Me.lbl_ver.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 77)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "软件作者：黎振旺" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "缤纷必应由必应提供数据支持，""必应标识""版权归微软公司所有。音乐《歌唱祖国》来自网易云音乐。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(328, 255)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_ver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb_LOGO)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.pb_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pb_LOGO As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_ver As Label
    Friend WithEvents Label2 As Label
End Class
