Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim panjang, lebar, tinggi, luas, volume As Integer

        panjang = Val(txtPanjang.Text)
        lebar = Val(txtLebar.Text)
        tinggi = Val(txtTinggi.Text)

        luas = panjang * lebar
        volume = panjang * lebar * tinggi

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)

    End Sub
End Class
