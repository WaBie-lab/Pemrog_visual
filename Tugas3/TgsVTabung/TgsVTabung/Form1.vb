Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Function HitungLuas(jarijari As Integer, tinggi As Integer) As Integer
        Dim luas As Integer
        luas = 2 * 3.14 * jarijari * (jarijari + tinggi)
        Return luas
    End Function

    Private Function HitungVolume(jarijari As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = 3.14 * jarijari * jarijari * tinggi
        Return volume
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jarijari, tinggi, luasp, volume As Integer

        jarijari = txtJarijari.Text
        tinggi = txtTinggi.Text

        luasp = HitungLuas(jarijari, tinggi)
        volume = HitungVolume(jarijari, tinggi)

        txtLuas.Text = Str(luasp)
        txtVolume.Text = Str(volume)
    End Sub
End Class
