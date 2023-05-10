Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Function HitungLuas(diagonal1 As Integer, diagonal2 As Integer) As Integer
        Dim luas As Integer
        luas = (diagonal1 * diagonal2) / 2
        Return luas
    End Function

    Private Function HitungKeliling(sisi1 As Integer, sisi2 As Integer, sisi3 As Integer, sisi4 As Integer) As Integer
        Dim keliling As Integer
        keliling = sisi1 + sisi2 + sisi3 + sisi4
        Return keliling
    End Function


    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim diagonal1, diagonal2, sisi1, sisi2, sisi3, sisi4, luas, keliling As Integer

        diagonal1 = txtDiagonal1.Text
        diagonal2 = txtDiagonal2.Text
        sisi1 = txtSisi1.Text
        sisi2 = txtSisi2.Text
        sisi3 = txtSisi3.Text
        sisi4 = txtSisi4.Text

        luas = HitungLuas(diagonal1, diagonal2)
        keliling = HitungKeliling(sisi1, sisi2, sisi3, sisi4)

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
