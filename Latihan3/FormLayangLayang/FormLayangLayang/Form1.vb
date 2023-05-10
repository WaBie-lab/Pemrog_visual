Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim diagonal1, diagonal2, sisi1, sisi2, sisi3, sisi4, luas, keliling As Integer

        diagonal1 = Val(txtDiagonal1.Text)
        diagonal2 = Val(txtDiagonal2.Text)
        sisi1 = Val(txtSisi1.Text)
        sisi2 = Val(txtSisi2.Text)
        sisi3 = Val(txtSisi3.Text)
        sisi4 = Val(txtSisi4.Text)

        luas = (diagonal1 * diagonal2) / 2
        keliling = sisi1 + sisi2 + sisi3 + sisi4

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
