Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtMasaKerja.Text) >= 20) Then
            txtKeterangan.Text = "Selamat anda mendapat bonus berupa tiket haji"

        ElseIf (txtMasaKerja.Text >= 15) Then
            txtKeterangan.Text = "Selamat anda mendapat bonus berupa kulkas"

        ElseIf (txtMasaKerja.Text >= 10) Then
            txtKeterangan.Text = "Selamat anda mendapat bonus Tv"

        ElseIf (txtMasaKerja.Text >= 5) Then
            txtKeterangan.Text = "Selamat anda mendapat bonus Kompor gas"

        Else
            txtKeterangan.Text = "Mohon maaf anda belum layak untuk mendapatkan bonus"
        End If
    End Sub
End Class