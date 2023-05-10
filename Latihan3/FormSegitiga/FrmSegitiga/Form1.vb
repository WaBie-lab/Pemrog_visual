Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim alas, tinggi, sisi, luas, keliling As Integer

        alas = Val(txtAlas.Text)
        tinggi = Val(txtTinggi.Text)
        sisi = Val(txtSisi.Text)

        luas = 1 / 2 * alas * tinggi
        keliling = sisi + sisi + sisi

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub

    Private Sub txtAlas_TextChanged(sender As Object, e As EventArgs) Handles txtAlas.TextChanged

    End Sub

    Private Sub label5_Click(sender As Object, e As EventArgs) Handles label5.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtLuas_TextChanged(sender As Object, e As EventArgs) Handles txtLuas.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtKeliling_TextChanged(sender As Object, e As EventArgs) Handles txtKeliling.TextChanged

    End Sub
End Class
