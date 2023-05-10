Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jarijari, tinggi, luasp, volume As Integer

        jarijari = Val(txtJarijari.Text)
        tinggi = Val(txtTinggi.Text)

        luasp = 2 * 3.14 * jarijari * (jarijari + tinggi)
        volume = 3.14 * jarijari * jarijari * tinggi

        txtLuas.Text = Str(luasp)
        txtVolume.Text = Str(volume)
    End Sub
End Class
