Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Function HitungLuas(jarijari As Integer, sisimiringa As Integer) As Integer
        Dim luas As Integer
        luas = 3.14 * jarijari * (jarijari + sisimiringa)
        Return luas
    End Function

    Private Function HitungVolume(jarijari As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = 1 / 3 * 3.14 * jarijari * jarijari * tinggi
        Return volume
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jarijari, tinggi, sisimiringa, luasp, volume As Integer

        jarijari = txtJarijari.Text
        tinggi = txtTinggi.Text
        sisimiringa = txtSisimiring.Text

        luasp = HitungLuas(jarijari, sisimiringa)
        volume = HitungVolume(jarijari, tinggi)

        txtLuas.Text = Str(luasp)
        txtVolume.Text = Str(volume)
    End Sub
End Class
