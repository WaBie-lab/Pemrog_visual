Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim panjang, lebar, luas, keliling As Integer

        panjang = Val(txtPanjang.Text)
        lebar = Val(txtLebar.Text)

        luas = panjang * lebar
        keliling = 2 * (panjang + lebar)

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
