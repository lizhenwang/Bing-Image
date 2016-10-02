<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_AutoRun = New System.Windows.Forms.CheckBox()
        Me.cb_1920x1080 = New System.Windows.Forms.CheckBox()
        Me.cb_1366x768 = New System.Windows.Forms.CheckBox()
        Me.cb_1280x768 = New System.Windows.Forms.CheckBox()
        Me.cb_1280x720 = New System.Windows.Forms.CheckBox()
        Me.cb_AutoSet = New System.Windows.Forms.CheckBox()
        Me.cb_1920x1200 = New System.Windows.Forms.CheckBox()
        Me.cb_800x600 = New System.Windows.Forms.CheckBox()
        Me.cb_1080x1920 = New System.Windows.Forms.CheckBox()
        Me.cb_480x640 = New System.Windows.Forms.CheckBox()
        Me.cb_720x1280 = New System.Windows.Forms.CheckBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "请下载以下尺寸的图片"
        '
        'cb_AutoRun
        '
        Me.cb_AutoRun.AutoSize = True
        Me.cb_AutoRun.Location = New System.Drawing.Point(12, 12)
        Me.cb_AutoRun.Name = "cb_AutoRun"
        Me.cb_AutoRun.Size = New System.Drawing.Size(123, 21)
        Me.cb_AutoRun.TabIndex = 1
        Me.cb_AutoRun.Text = "开机运行缤纷必应"
        Me.cb_AutoRun.UseVisualStyleBackColor = True
        '
        'cb_1920x1080
        '
        Me.cb_1920x1080.AutoSize = True
        Me.cb_1920x1080.Location = New System.Drawing.Point(118, 76)
        Me.cb_1920x1080.Name = "cb_1920x1080"
        Me.cb_1920x1080.Size = New System.Drawing.Size(89, 21)
        Me.cb_1920x1080.TabIndex = 2
        Me.cb_1920x1080.Text = "1920x1080"
        Me.cb_1920x1080.UseVisualStyleBackColor = True
        '
        'cb_1366x768
        '
        Me.cb_1366x768.AutoSize = True
        Me.cb_1366x768.Checked = True
        Me.cb_1366x768.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_1366x768.Enabled = False
        Me.cb_1366x768.Location = New System.Drawing.Point(224, 76)
        Me.cb_1366x768.Name = "cb_1366x768"
        Me.cb_1366x768.Size = New System.Drawing.Size(82, 21)
        Me.cb_1366x768.TabIndex = 3
        Me.cb_1366x768.Text = "1366x768"
        Me.cb_1366x768.UseVisualStyleBackColor = True
        '
        'cb_1280x768
        '
        Me.cb_1280x768.AutoSize = True
        Me.cb_1280x768.Location = New System.Drawing.Point(12, 103)
        Me.cb_1280x768.Name = "cb_1280x768"
        Me.cb_1280x768.Size = New System.Drawing.Size(82, 21)
        Me.cb_1280x768.TabIndex = 4
        Me.cb_1280x768.Text = "1280x768"
        Me.cb_1280x768.UseVisualStyleBackColor = True
        '
        'cb_1280x720
        '
        Me.cb_1280x720.AutoSize = True
        Me.cb_1280x720.Location = New System.Drawing.Point(118, 103)
        Me.cb_1280x720.Name = "cb_1280x720"
        Me.cb_1280x720.Size = New System.Drawing.Size(82, 21)
        Me.cb_1280x720.TabIndex = 5
        Me.cb_1280x720.Text = "1280x720"
        Me.cb_1280x720.UseVisualStyleBackColor = True
        '
        'cb_AutoSet
        '
        Me.cb_AutoSet.AutoSize = True
        Me.cb_AutoSet.Location = New System.Drawing.Point(12, 172)
        Me.cb_AutoSet.Name = "cb_AutoSet"
        Me.cb_AutoSet.Size = New System.Drawing.Size(123, 21)
        Me.cb_AutoSet.TabIndex = 6
        Me.cb_AutoSet.Text = "自动设置桌面壁纸"
        Me.cb_AutoSet.UseVisualStyleBackColor = True
        '
        'cb_1920x1200
        '
        Me.cb_1920x1200.AutoSize = True
        Me.cb_1920x1200.Location = New System.Drawing.Point(12, 76)
        Me.cb_1920x1200.Name = "cb_1920x1200"
        Me.cb_1920x1200.Size = New System.Drawing.Size(89, 21)
        Me.cb_1920x1200.TabIndex = 7
        Me.cb_1920x1200.Text = "1920x1200"
        Me.cb_1920x1200.UseVisualStyleBackColor = True
        '
        'cb_800x600
        '
        Me.cb_800x600.AutoSize = True
        Me.cb_800x600.Location = New System.Drawing.Point(224, 103)
        Me.cb_800x600.Name = "cb_800x600"
        Me.cb_800x600.Size = New System.Drawing.Size(75, 21)
        Me.cb_800x600.TabIndex = 8
        Me.cb_800x600.Text = "800x600"
        Me.cb_800x600.UseVisualStyleBackColor = True
        '
        'cb_1080x1920
        '
        Me.cb_1080x1920.AutoSize = True
        Me.cb_1080x1920.Location = New System.Drawing.Point(12, 130)
        Me.cb_1080x1920.Name = "cb_1080x1920"
        Me.cb_1080x1920.Size = New System.Drawing.Size(89, 21)
        Me.cb_1080x1920.TabIndex = 13
        Me.cb_1080x1920.Text = "1080x1920"
        Me.cb_1080x1920.UseVisualStyleBackColor = True
        '
        'cb_480x640
        '
        Me.cb_480x640.AutoSize = True
        Me.cb_480x640.Location = New System.Drawing.Point(224, 130)
        Me.cb_480x640.Name = "cb_480x640"
        Me.cb_480x640.Size = New System.Drawing.Size(75, 21)
        Me.cb_480x640.TabIndex = 10
        Me.cb_480x640.Text = "480x640"
        Me.cb_480x640.UseVisualStyleBackColor = True
        '
        'cb_720x1280
        '
        Me.cb_720x1280.AutoSize = True
        Me.cb_720x1280.Location = New System.Drawing.Point(118, 130)
        Me.cb_720x1280.Name = "cb_720x1280"
        Me.cb_720x1280.Size = New System.Drawing.Size(82, 21)
        Me.cb_720x1280.TabIndex = 9
        Me.cb_720x1280.Text = "720x1280"
        Me.cb_720x1280.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_Save.Location = New System.Drawing.Point(198, 201)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(108, 32)
        Me.btn_Save.TabIndex = 15
        Me.btn_Save.Text = "保存设置"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(312, 240)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.cb_1080x1920)
        Me.Controls.Add(Me.cb_480x640)
        Me.Controls.Add(Me.cb_720x1280)
        Me.Controls.Add(Me.cb_800x600)
        Me.Controls.Add(Me.cb_1920x1200)
        Me.Controls.Add(Me.cb_AutoSet)
        Me.Controls.Add(Me.cb_1280x720)
        Me.Controls.Add(Me.cb_1280x768)
        Me.Controls.Add(Me.cb_1366x768)
        Me.Controls.Add(Me.cb_1920x1080)
        Me.Controls.Add(Me.cb_AutoRun)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SettingsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cb_AutoRun As CheckBox
    Friend WithEvents cb_1920x1080 As CheckBox
    Friend WithEvents cb_1366x768 As CheckBox
    Friend WithEvents cb_1280x768 As CheckBox
    Friend WithEvents cb_1280x720 As CheckBox
    Friend WithEvents cb_AutoSet As CheckBox
    Friend WithEvents cb_1920x1200 As CheckBox
    Friend WithEvents cb_800x600 As CheckBox
    Friend WithEvents cb_1080x1920 As CheckBox
    Friend WithEvents cb_480x640 As CheckBox
    Friend WithEvents cb_720x1280 As CheckBox
    Friend WithEvents btn_Save As Button
End Class
