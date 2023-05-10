Public Class Form1

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Function HitungLuas(diagonal1 As Integer, diagonal2 As Integer) As Integer
        Dim luas As Integer
        luas = 0.5 * diagonal1 * diagonal2
        Return luas
    End Function

    Private Function HitungKeliling(sisi As Integer) As Integer
        Dim keliling As Integer
        keliling = 4 * sisi
        Return keliling
    End Function

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim diagonal1, diagonal2, sisi, luas, keliling As Integer

        diagonal1 = txtDiagonal1.Text
        diagonal2 = txtDiagonal2.Text
        sisi = txtSisi.Text

        luas = HitungLuas(diagonal1, diagonal2)
        keliling = HitungKeliling(sisi)

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
