Public Class SettingsForm
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "设置"
        GetSettings()
        cb_AutoRun.Checked = RegChecker(Application.ExecutablePath)
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim iniPath As String
        iniPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\settings.ini"
        Dim ini As New System.IO.FileStream(iniPath, IO.FileMode.Create)
        ini.Close()
        FileIO.FileSystem.WriteAllText(iniPath, "# Bing Image Special Edition by www.lizhenwang.com.", False)
        FileIO.FileSystem.WriteAllText(iniPath, vbCrLf & "# Do not edit this config file manually." & vbCrLf, True)
        FileIO.FileSystem.WriteAllText(iniPath, "# Version:" & Application.ProductVersion & vbCrLf, True)
        FileIO.FileSystem.WriteAllText(iniPath, "# Date:Aug 22nd,2016" & vbCrLf, True)
        FileIO.FileSystem.WriteAllText(iniPath, vbCrLf & "# 此文件由缤纷必应自动生成，用于保存软件设置，请勿手动修改。" & vbCrLf & vbCrLf, True)

        FileIO.FileSystem.WriteAllText(iniPath, "# ******Settings Start******" & vbCrLf, True)
        FileIO.FileSystem.WriteAllText(iniPath, "Background=" & IIf(cb_AutoSet.Checked, "1", "0") & vbCrLf, True)
        FileIO.FileSystem.WriteAllText(iniPath, "Size=1366x768", True)
        If cb_1920x1200.Checked Then FileIO.FileSystem.WriteAllText(iniPath, "|1920x1200", True)
        If cb_1920x1080.Checked Then FileIO.FileSystem.WriteAllText(iniPath, "|1920x1080", True)
        If cb_1280x768.Checked Then FileIO.FileSystem.WriteAllText(iniPath, "|1280x768", True)
        If cb_1280x720.Checked Then FileIO.FileSystem.WriteAllText(iniPath, "|1280x720", True)
        If cb_800x600.Checked Then FileIO.FileSystem.WriteAllText(iniPath, "|800x600", True)
        If cb_1080x1920.Checked Then FileIO.FileSystem.WriteAllText(iniPath, "|1080x1920", True)
        If cb_720x1280.Checked Then FileIO.FileSystem.WriteAllText(iniPath, "|720x1280", True)
        If cb_480x640.Checked Then FileIO.FileSystem.WriteAllText(iniPath, "|480x640", True)
        FileIO.FileSystem.WriteAllText(iniPath, vbCrLf & "# ******Settings End******", True)
        AutoStart(cb_AutoRun.Checked, LCase(Application.ExecutablePath))
        MessageBox.Show(Me, "已保存软件设置！", "保存")
    End Sub

    Private Sub GetSettings()
        Dim Settings As String
        If My.Computer.FileSystem.FileExists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\settings.ini") Then
            Settings = FileIO.FileSystem.ReadAllText(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\settings.ini", System.Text.Encoding.GetEncoding("GB2312"))
            Settings = LCase(Settings)
            If InStr(Settings, "background=1") > 0 Then cb_AutoSet.Checked = True
            If InStr(Settings, "1920x1200") > 0 Then cb_1920x1200.Checked = True
            If InStr(Settings, "1920x1080") > 0 Then cb_1920x1080.Checked = True
            If InStr(Settings, "1280x768") > 0 Then cb_1280x768.Checked = True
            If InStr(Settings, "1280x720") > 0 Then cb_1280x720.Checked = True
            If InStr(Settings, "800x600") > 0 Then cb_800x600.Checked = True
            If InStr(Settings, "1080x1920") > 0 Then cb_1080x1920.Checked = True
            If InStr(Settings, "720x1280") > 0 Then cb_720x1280.Checked = True
            If InStr(Settings, "480x640") > 0 Then cb_480x640.Checked = True

        Else
            cb_1920x1200.Checked = False
            cb_1920x1080.Checked = False
            cb_1280x768.Checked = False
            cb_1280x720.Checked = False
            cb_800x600.Checked = False
            cb_1080x1920.Checked = False
            cb_720x1280.Checked = False
            cb_480x640.Checked = False
            cb_AutoSet.Checked = False
        End If


    End Sub

    Private Sub cb_AutoSet_CheckedChanged(sender As Object, e As EventArgs) Handles cb_AutoSet.CheckedChanged
        If cb_AutoSet.Checked = True Then
            cb_1920x1080.Checked = True
            cb_1920x1080.Enabled = False
        Else
            cb_1920x1080.Enabled = True
        End If
    End Sub

    Public Function AutoStart(IsAuto As Boolean, ExePath As String) As Boolean
        On Error Resume Next
        Dim reg
        If IsAuto = True Then
            If Environment.Is64BitOperatingSystem = True Then
                reg = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run", True)
            Else
                reg = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            End If
            reg.SetValue("BingImg", Chr(34) & ExePath & Chr(34) & " -tray")
        Else
            If Environment.Is64BitOperatingSystem = True Then
                reg = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run", True)
            Else
                reg = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            End If
            reg.DeleteValue("BingImg")
        End If
        reg.Close()
    End Function

    Public Function RegChecker(ExePath As String) As Boolean
        Dim regCheck
        If Environment.Is64BitOperatingSystem = True Then
            regCheck = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run", True).GetValue("BingImg")
        Else
            regCheck = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue("BingImg")
        End If
        If LCase(regCheck) = LCase(Chr(34) & ExePath & Chr(34) & " -tray") Then
            Return True
        Else
            Return False
        End If
    End Function
End Class