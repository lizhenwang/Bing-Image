Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "关于"
        lbl_ver.Text = "版本：" & Application.ProductVersion
    End Sub
End Class