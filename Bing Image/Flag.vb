Public Class Flag
    Dim w As New WebBrowser

    Private Sub Flag_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        w.Url = New Uri("about:blank")
    End Sub

    Private Sub Flag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ""
        w.Visible = False
        w.Url = New Uri("http://music.163.com/outchain/player?type=2&id=272784&auto=1&height=66")

    End Sub
End Class