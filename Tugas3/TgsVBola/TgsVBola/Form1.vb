Public Class Form1

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Function HitungLuas(jarijari As Integer) As Integer
        Dim luas As Integer
        luas = 4 * 3.14 * jarijari * jarijari
        Return luas
    End Function

    Private Function HitungVolume(jarijari As Integer) As Integer
        Dim Volume As Integer
        Volume = 3 / 4 * 3.14 * jarijari * jarijari * jarijari
        Return Volume
    End Function


    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jarijari, luas, volume As Integer

        jarijari = txtJarijari.Text

        luas = HitungLuas(jarijari)
        volume = HitungVolume(jarijari)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)
    End Sub
End Class
