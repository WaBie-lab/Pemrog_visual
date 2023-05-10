Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Function HitungLuas(jarijari As Integer) As Integer
        Dim luas As Integer
        luas = 3.14 * jarijari * jarijari
        Return luas
    End Function

    Private Function HitungKeliling(jarijari As Integer) As Integer
        Dim keliling As Integer
        keliling = 2 * 3.14 * jarijari
        Return keliling
    End Function


    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jarijari, luas, keliling As Integer

        jarijari = txtJarijari.Text

        luas = HitungLuas(jarijari)
        keliling = HitungKeliling(jarijari)

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub
End Class
