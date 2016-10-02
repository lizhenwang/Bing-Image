Public Class MainWindow
    Private IsShowEgg As Boolean
    Private MainThread As New System.Threading.Thread(AddressOf MT)
    Private Img_Name, Img_Author, Img_Link As String
    Private Img_Date As String
    Private Settings As String
    Private DirName As String

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Environment.GetCommandLineArgs.Count > 1 Then
            HideMe()
        End If
        If Not My.Computer.FileSystem.DirectoryExists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Download") Then
            My.Computer.FileSystem.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Download")
        End If
        CodeIsPoetryToolStripMenuItem.Text = "代码如诗"
        Me.Text = "缤纷必应"
        lbl_ImgAuthor.Text = ""
        lbl_ImgLink.Text = ""
        With NI
            .Icon = Me.Icon
            .Text = Me.Text
        End With
        MainThread.Start()
    End Sub

    Private Sub CodeIsPoetryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodeIsPoetryToolStripMenuItem.Click
        If IsShowEgg = False Then
            MessageBox.Show(Me, "这里没有彩蛋~不信你再点一次。", "There is nothing here")
            IsShowEgg = True
        Else
            Flag.ShowDialog()
        End If
    End Sub

    Private Sub MT()
        Dim Info As String
        Do
            '***************获取信息及预览图***************
            Info = GetInfo()
            If Not Info = "" Then
                If Not My.Computer.FileSystem.DirectoryExists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Download\" & Mid(Info.Split("|")(1), 1, 4)) Then
                    My.Computer.FileSystem.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Download\" & Mid(Info.Split("|")(1), 1, 4))
                End If
                If Not My.Computer.FileSystem.DirectoryExists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Download\" & Mid(Info.Split("|")(1), 1, 4) & "\" & Mid(Info.Split("|")(1), 5, 2)) Then
                    My.Computer.FileSystem.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Download\" & Mid(Info.Split("|")(1), 1, 4) & "\" & Mid(Info.Split("|")(1), 5, 2))
                End If
                If Not My.Computer.FileSystem.DirectoryExists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Download\" & Mid(Info.Split("|")(1), 1, 4) & "\" & Mid(Info.Split("|")(1), 5, 2) & "\" & Mid(Info.Split("|")(1), 7, 2)) Then
                    My.Computer.FileSystem.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Download\" & Mid(Info.Split("|")(1), 1, 4) & "\" & Mid(Info.Split("|")(1), 5, 2) & "\" & Mid(Info.Split("|")(1), 7, 2))
                End If

                DirName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Download\" & Mid(Info.Split("|")(1), 1, 4) & "\" & Mid(Info.Split("|")(1), 5, 2) & "\" & Mid(Info.Split("|")(1), 7, 2)
                DownloadFile("http://cn.bing.com" & Info.Split("|")(0) & "_1366x768.jpg", DirName & "\1366x768.jpg")

                If lbl_tip.InvokeRequired Then
                    lbl_tip.BeginInvoke(New Action(AddressOf HideTip))
                Else
                    lbl_tip.Visible = False
                End If

                If lbl_ImgText.InvokeRequired Then
                    Img_Name = Info.Split("|")(2)
                    lbl_ImgText.BeginInvoke(New Action(AddressOf ChangeTitle))
                Else
                    lbl_ImgText.Text = Info.Split("|")(2)
                End If

                Img_Date = Info.Split("|")(1)
                If lbl_Date.InvokeRequired Then
                    lbl_Date.BeginInvoke(New Action(AddressOf ChangeDate))
                Else
                    lbl_Date.Text = Mid(Img_Date, 1, 4) & "." & Mid(Img_Date, 5, 2)
                End If

                If lbl_Day.InvokeRequired Then
                    lbl_Day.BeginInvoke(New Action(AddressOf ChangeDay))
                Else
                    lbl_Day.Text = Mid(Img_Date, 7, 2)
                End If

                If lbl_ImgAuthor.InvokeRequired Then
                    Img_Author = Info.Split("|")(3)
                    lbl_ImgAuthor.BeginInvoke(New Action(AddressOf ChangeAuthor))
                Else
                    lbl_ImgAuthor.Text = Info.Split("|")(3)
                End If

                If lbl_ImgLink.InvokeRequired Then
                    Img_Link = Info.Split("|")(4)
                    lbl_ImgLink.BeginInvoke(New Action(AddressOf ChangeLink))
                Else
                    With lbl_ImgLink
                        .Text = "点击以打开图片链接"
                        .Tag = Info.Split("|")(4)
                        .ForeColor = Drawing.Color.Blue
                    End With
                End If

                If pb_Preview.InvokeRequired Then
                    pb_Preview.BeginInvoke(New Action(AddressOf ChangePreview))
                Else
                    pb_Preview.Image = System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Download\" & Info.Split("|")(1) & "\1366x768.jpg")
                End If
                CreateInfoFile(Info, DirName & "\ImgInfo.txt")

                If My.Computer.FileSystem.FileExists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\settings.ini") Then
                    Settings = FileIO.FileSystem.ReadAllText(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\settings.ini", System.Text.Encoding.GetEncoding("GB2312"))
                    Settings = LCase(Settings)
                    Dim size() As String
                    '***************开始下载壁纸***************
                    size = {"1920x1200", "1920x1080", "1280x768", "1280x720", "800x600", "1080x1920", "720x1280", "480x640"}
                    For Each s In size
                        If InStr(Settings, s) > 0 Then
                            DownloadFile("http://cn.bing.com" & Info.Split("|")(0) & "_" & s & ".jpg", DirName & "\" & s & ".jpg")
                        End If
                    Next


                    '***************设置桌面壁纸***************
                    If InStr(Settings, "background=1") > 0 Then
                            SetBackground(DirName & "\1920x1080.jpg")
                        End If
                    End If
                End If
            System.Threading.Thread.Sleep(10000)
            Info = ""
        Loop

    End Sub

    Private Sub ShowMessage()

    End Sub
    Public Function CreateInfoFile(info As String, FilePath As String)
        If Not My.Computer.FileSystem.FileExists(FilePath) Then
            Dim c As New System.IO.FileStream(FilePath, IO.FileMode.Create)
            c.Close()
            FileIO.FileSystem.WriteAllText(FilePath, "Date=" & info.Split("|")(1) & vbCrLf & "Name=" & info.Split("|")(2) & vbCrLf & "Author=" & info.Split("|")(3) & vbCrLf & "Link=" & info.Split("|")(4), False)
        End If
    End Function
    Private Sub ChangeLink()
        With lbl_ImgLink
            .Text = "点击以打开图片链接"
            .Tag = Img_Link
            .ForeColor = Drawing.Color.Blue
        End With


    End Sub
    Private Sub ChangeTitle()
        lbl_ImgText.Text = Img_Name
    End Sub

    Private Sub ChangePreview()
        pb_Preview.Image = System.Drawing.Image.FromFile(DirName & "\1366x768.jpg")
    End Sub

    Private Sub ChangeAuthor()
        lbl_ImgAuthor.Text = Img_Author
    End Sub



    Private Sub ChangeDate()
        lbl_Date.Text = Mid(Img_Date, 1, 4) & "." & Mid(Img_Date, 5, 2)
    End Sub



    Private Sub ChangeDay()
        lbl_Day.Text = Mid(Img_Date, 7, 2)
    End Sub



    Private Sub lbl_ImgLink_MouseClick(sender As Object, e As MouseEventArgs) Handles lbl_ImgLink.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim o As New System.Diagnostics.Process
            o.StartInfo.FileName = lbl_ImgLink.Tag
            o.Start()
        End If
    End Sub

    Private Sub Menu_End_Click(sender As Object, e As EventArgs) Handles Menu_End.Click
        NI.Visible = False
        End
    End Sub

    Private Sub Menu_Settings_Click(sender As Object, e As EventArgs) Handles Menu_Settings.Click
        SettingsForm.ShowDialog()
    End Sub



    Private Sub Meun_About_Click(sender As Object, e As EventArgs) Handles Meun_About.Click
        About.ShowDialog()
    End Sub

    Private Sub TMenu_End_Click(sender As Object, e As EventArgs) Handles TMenu_End.Click
        NI.Visible = False
        End
    End Sub

    Private Sub link_lizhenwang_MouseClick(sender As Object, e As MouseEventArgs) Handles link_lizhenwang.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim o As New System.Diagnostics.Process
            o.StartInfo.FileName = link_lizhenwang.Text
            o.Start()
        End If
    End Sub

    Private Sub HideTip()
        lbl_tip.Visible = False
    End Sub

    Private Sub MainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = 1
        HideMe()
    End Sub



    Private Sub HideMe()
        With Me
            .Opacity = 0
            .ShowInTaskbar = False
            .Hide()
        End With
    End Sub

    Private Sub TMenu_Show_Click(sender As Object, e As EventArgs) Handles TMenu_Show.Click
        ShowWindow()
    End Sub

    Private Sub ShowWindow()
        With Me
            .Opacity = 1
            .ShowInTaskbar = True
            .Visible = True
        End With
    End Sub

    Private Sub NI_MouseClick(sender As Object, e As MouseEventArgs) Handles NI.MouseClick
        If e.Button = MouseButtons.Left Then
            ShowWindow()
        End If
    End Sub
End Class