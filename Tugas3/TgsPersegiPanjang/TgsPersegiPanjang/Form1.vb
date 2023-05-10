Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Function HitungLuas(panjang As Integer, lebar As Integer) As Integer
        Dim luas As Integer
        luas = panjang * lebar
        Return luas
    End Function

    Private Function HitungKeliling(panjang As Integer, lebar As Integer) As Integer
        Dim keliling As Integer
        keliling = 2 * (panjang + lebar)
        Return keliling
    End Function

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim panjang, lebar, luas, keliling As Integer

        panjang = txtPanjang.Text
        lebar = txtLebar.Text

        luas = HitungLuas(panjang, lebar)
        keliling = HitungKeliling(panjang, lebar)

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
