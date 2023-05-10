Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Function HitungLuas(sisi As Integer) As Integer
        Dim luas As Integer
        luas = 6 * sisi * sisi
        Return luas
    End Function

    Private Function HitungVolume(sisi As Integer) As Integer
        Dim volume As Integer
        volume = sisi * sisi * sisi
        Return volume
    End Function


    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, luas, volume As Integer

        sisi = Val(txtSisi.Text)

        luas = HitungLuas(sisi)
        volume = HitungVolume(sisi)

        txtLuas.Text = Str(luas)
        txtVolume.Text = Str(volume)

    End Sub
End Class
