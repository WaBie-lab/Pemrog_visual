Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jarijari, luas, keliling As Integer

        jarijari = Val(txtJarijari.Text)

        luas = 3.14 * jarijari * jarijari
        keliling = 2 * 3.14 * jarijari

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)

    End Sub
End Class
