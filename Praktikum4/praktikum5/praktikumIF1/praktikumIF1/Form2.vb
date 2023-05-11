Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtPembelian.Text) >= 1000000) Then
            txtKeterangan.Text = "Selamat anda mendapatkan Diskon 50%"

        ElseIf (txtPembelian.Text >= 800000) Then
            txtKeterangan.Text = "Selamat anda mendapatkan Diskon 40%"

        ElseIf (txtPembelian.Text >= 600000) Then
            txtKeterangan.Text = "Selamat anda mendapatkan Diskon 30%"

        ElseIf (txtPembelian.Text >= 500000) Then
            txtKeterangan.Text = "Selamat anda mendapatkan Diskon 25%"

        Else
            txtKeterangan.Text = "Mohon Maaf anda tidak mendapatkan Diskon"
        End If
    End Sub
End Class