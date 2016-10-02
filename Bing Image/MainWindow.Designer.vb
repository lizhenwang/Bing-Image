<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.菜单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu_End = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Meun_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeIsPoetryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Day = New System.Windows.Forms.Label()
        Me.lbl_Date = New System.Windows.Forms.Label()
        Me.lbl_ImgText = New System.Windows.Forms.Label()
        Me.lbl_ImgAuthor = New System.Windows.Forms.Label()
        Me.lbl_ImgLink = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.link_lizhenwang = New System.Windows.Forms.Label()
        Me.pb_Preview = New System.Windows.Forms.PictureBox()
        Me.lbl_tip = New System.Windows.Forms.Label()
        Me.NI = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TMenu_Show = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TMenu_End = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.菜单ToolStripMenuItem, Me.帮助ToolStripMenuItem, Me.CodeIsPoetryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(753, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '菜单ToolStripMenuItem
        '
        Me.菜单ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Settings, Me.ToolStripMenuItem1, Me.Menu_End})
        Me.菜单ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem"
        Me.菜单ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.菜单ToolStripMenuItem.Text = "菜单"
        '
        'Menu_Settings
        '
        Me.Menu_Settings.Name = "Menu_Settings"
        Me.Menu_Settings.Size = New System.Drawing.Size(100, 22)
        Me.Menu_Settings.Text = "设置"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(97, 6)
        '
        'Menu_End
        '
        Me.Menu_End.Name = "Menu_End"
        Me.Menu_End.Size = New System.Drawing.Size(100, 22)
        Me.Menu_End.Text = "退出"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Meun_About})
        Me.帮助ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        'Meun_About
        '
        Me.Meun_About.Name = "Meun_About"
        Me.Meun_About.Size = New System.Drawing.Size(152, 22)
        Me.Meun_About.Text = "关于"
        '
        'CodeIsPoetryToolStripMenuItem
        '
        Me.CodeIsPoetryToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CodeIsPoetryToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CodeIsPoetryToolStripMenuItem.Name = "CodeIsPoetryToolStripMenuItem"
        Me.CodeIsPoetryToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CodeIsPoetryToolStripMenuItem.Size = New System.Drawing.Size(105, 21)
        Me.CodeIsPoetryToolStripMenuItem.Text = "Code is Poetry"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(338, 486)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 90)
        Me.Label1.TabIndex = 2
        '
        'lbl_Day
        '
        Me.lbl_Day.BackColor = System.Drawing.Color.White
        Me.lbl_Day.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Day.Location = New System.Drawing.Point(341, 489)
        Me.lbl_Day.Name = "lbl_Day"
        Me.lbl_Day.Size = New System.Drawing.Size(70, 58)
        Me.lbl_Day.TabIndex = 3
        Me.lbl_Day.Text = "17"
        Me.lbl_Day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Date
        '
        Me.lbl_Date.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_Date.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Date.ForeColor = System.Drawing.Color.White
        Me.lbl_Date.Location = New System.Drawing.Point(338, 548)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(76, 28)
        Me.lbl_Date.TabIndex = 4
        Me.lbl_Date.Text = "1995.03"
        Me.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_ImgText
        '
        Me.lbl_ImgText.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_ImgText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_ImgText.Location = New System.Drawing.Point(11, 491)
        Me.lbl_ImgText.Name = "lbl_ImgText"
        Me.lbl_ImgText.Size = New System.Drawing.Size(321, 44)
        Me.lbl_ImgText.TabIndex = 5
        '
        'lbl_ImgAuthor
        '
        Me.lbl_ImgAuthor.AutoSize = True
        Me.lbl_ImgAuthor.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.lbl_ImgAuthor.Location = New System.Drawing.Point(12, 535)
        Me.lbl_ImgAuthor.Name = "lbl_ImgAuthor"
        Me.lbl_ImgAuthor.Size = New System.Drawing.Size(44, 17)
        Me.lbl_ImgAuthor.TabIndex = 6
        Me.lbl_ImgAuthor.Text = "版权："
        '
        'lbl_ImgLink
        '
        Me.lbl_ImgLink.AutoSize = True
        Me.lbl_ImgLink.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.lbl_ImgLink.Location = New System.Drawing.Point(12, 555)
        Me.lbl_ImgLink.Name = "lbl_ImgLink"
        Me.lbl_ImgLink.Size = New System.Drawing.Size(44, 17)
        Me.lbl_ImgLink.TabIndex = 7
        Me.lbl_ImgLink.Text = "链接："
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(528, 518)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(613, 522)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "提供数据支持"
        '
        'link_lizhenwang
        '
        Me.link_lizhenwang.AutoSize = True
        Me.link_lizhenwang.ForeColor = System.Drawing.Color.Blue
        Me.link_lizhenwang.Location = New System.Drawing.Point(573, 555)
        Me.link_lizhenwang.Name = "link_lizhenwang"
        Me.link_lizhenwang.Size = New System.Drawing.Size(166, 17)
        Me.link_lizhenwang.TabIndex = 12
        Me.link_lizhenwang.Text = "http://www.lizhenwang.com"
        '
        'pb_Preview
        '
        Me.pb_Preview.BackColor = System.Drawing.SystemColors.Control
        Me.pb_Preview.Location = New System.Drawing.Point(0, 30)
        Me.pb_Preview.Name = "pb_Preview"
        Me.pb_Preview.Size = New System.Drawing.Size(753, 453)
        Me.pb_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Preview.TabIndex = 1
        Me.pb_Preview.TabStop = False
        '
        'lbl_tip
        '
        Me.lbl_tip.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_tip.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_tip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_tip.Location = New System.Drawing.Point(0, 176)
        Me.lbl_tip.Name = "lbl_tip"
        Me.lbl_tip.Size = New System.Drawing.Size(753, 135)
        Me.lbl_tip.TabIndex = 15
        Me.lbl_tip.Text = "正在使用『洪荒之力』加载必应壁纸..."
        Me.lbl_tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NI
        '
        Me.NI.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NI.Text = "NotifyIcon1"
        Me.NI.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TMenu_Show, Me.ToolStripMenuItem3, Me.TMenu_End})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(137, 54)
        '
        'TMenu_Show
        '
        Me.TMenu_Show.Name = "TMenu_Show"
        Me.TMenu_Show.Size = New System.Drawing.Size(136, 22)
        Me.TMenu_Show.Text = "显示主界面"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(133, 6)
        '
        'TMenu_End
        '
        Me.TMenu_End.Name = "TMenu_End"
        Me.TMenu_End.Size = New System.Drawing.Size(136, 22)
        Me.TMenu_End.Text = "退出本软件"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(753, 579)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_tip)
        Me.Controls.Add(Me.link_lizhenwang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_ImgLink)
        Me.Controls.Add(Me.lbl_ImgAuthor)
        Me.Controls.Add(Me.lbl_ImgText)
        Me.Controls.Add(Me.lbl_Date)
        Me.Controls.Add(Me.lbl_Day)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb_Preview)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainWindow"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents 菜单ToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Settings As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents Menu_End As Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Meun_About As Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeIsPoetryToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lbl_Day As Windows.Forms.Label
    Friend WithEvents lbl_Date As Windows.Forms.Label
    Friend WithEvents lbl_ImgText As Windows.Forms.Label
    Friend WithEvents lbl_ImgAuthor As Windows.Forms.Label
    Friend WithEvents lbl_ImgLink As Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents link_lizhenwang As Label
    Friend WithEvents pb_Preview As PictureBox
    Friend WithEvents lbl_tip As Label
    Friend WithEvents NI As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TMenu_Show As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents TMenu_End As ToolStripMenuItem
End Class
