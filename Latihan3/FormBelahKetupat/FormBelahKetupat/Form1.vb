Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim diagonal1, diagonal2, sisi, luas, keliling As Integer

        diagonal1 = Val(txtDiagonal1.Text)
        diagonal2 = Val(txtDiagonal2.Text)
        sisi = Val(txtSisi.Text)

        luas = 0.5 * diagonal1 * diagonal2
        keliling = 4 * sisi

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
