Public Class Form1

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Function HitungLuas(alas As Integer, tinggi As Integer) As Integer
        Dim luas As Integer
        luas = 1 / 2 * alas * tinggi
        Return luas
    End Function

    Private Function HitungKeliling(sisi As Integer) As Integer
        Dim keliling As Integer
        keliling = sisi + sisi + sisi
        Return keliling
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim alas, tinggi, sisi, luas, keliling As Integer

        alas = txtAlas.Text
        tinggi = txtTinggi.Text
        sisi = txtSisi.Text

        luas = HitungLuas(alas, tinggi)
        keliling = HitungKeliling(sisi)

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
