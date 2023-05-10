Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jarijari, luas, volume As Integer

        jarijari = Val(txtJarijari.Text)

        luas = 6 * jarijari * jarijari
        volume = jarijari * jarijari * jarijari

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)

    End Sub
End Class
