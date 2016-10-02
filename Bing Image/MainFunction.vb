'"1920x1200", "1920x1080", "1366x768", "1280x768", "1280x720", "1080x1920"
'"http://cn.bing.com" & URLBase & "_" & ImgWidth.ToString & "x" & ImgHeight.ToString & ".jpg"
Module MainFunction
    Private Const SPI_SETDESKWALLPAPER As Integer = &H14
    Private Const SPIF_UPDATEINIFILE As Integer = &H1
    Private Const SPIF_SENDWININICHANGE As Integer = &H2
    Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Private s As Integer

    Public Function SetBackground(ImgPath As String)
        On Error Resume Next
        s = Nothing
        s = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, ImgPath, 1)
    End Function
    Public Function GetInfo() As String
        Dim AllString As String
        Dim UrlBase As String
        Dim ImgDate As String
        Dim ImgName As String
        Dim ImgCopyright As String
        Dim ImgLink As String
        Dim dl As New Net.WebClient
        Try
            dl.Encoding = System.Text.Encoding.UTF8
            AllString = dl.DownloadString("http://cn.bing.com/HPImageArchive.aspx?idx=0&n=1")
            If Not AllString = "" Then
                UrlBase = Mid(AllString, InStr(AllString, "<urlBase>") + 9, InStr(AllString, "</urlBase>") - InStr(AllString, "<urlBase>") - 9)
                ImgDate = Mid(AllString, InStr(AllString, "<enddate>") + 9, InStr(AllString, "</enddate>") - InStr(AllString, "<enddate>") - 9)
                Try
                    ImgName = Mid(AllString, InStr(AllString, "<copyright>") + 11, InStr(AllString, " （©") - InStr(AllString, "<copyright>") - 11)
                Catch ex As Exception
                    ImgName = Mid(AllString, InStr(AllString, "<copyright>") + 11, InStr(AllString, " (©") - InStr(AllString, "<copyright>") - 11)
                End Try
                Try
                    ImgCopyright = Mid(AllString, InStr(AllString, "（© ") + 3, InStr(AllString, "）") - InStr(AllString, "（© ") - 3)
                Catch ex As Exception
                    ImgCopyright = Mid(AllString, InStr(AllString, "(© ") + 3, InStr(AllString, ")") - InStr(AllString, "(© ") - 3)
                End Try
                If InStr(ImgCopyright, "&amp;") > 0 Then
                    ImgCopyright = ImgCopyright.Replace("&amp;", "&")
                End If
                ImgLink = Mid(AllString, InStr(AllString, "<copyrightlink>") + 15, InStr(AllString, "</copyrightlink>") - InStr(AllString, "<copyrightlink>") - 15)
                Return UrlBase & "|" & ImgDate & "|" & ImgName & "|" & ImgCopyright & "|" & ImgLink
            End If

            Return ""
        Catch ex As Exception

            Return ""
        End Try
    End Function

    Public Function DownloadFile(Address As String, SavePath As String) As Boolean
        Dim dl As New Net.WebClient
        Dim b() As Byte
        If Not My.Computer.FileSystem.FileExists(SavePath) Then
            Try
                b = dl.DownloadData(Address)
                If Not b.Length = 0 Then
                    Dim s As New System.IO.FileStream(SavePath, IO.FileMode.Create, IO.FileAccess.Write)
                    s.Write(b, 0, b.Length)
                    s.Close()

                Else

                    Return False
                End If
            Catch ex As Exception

                Return False
            End Try
        Else

            Return True
        End If


    End Function
End Module
