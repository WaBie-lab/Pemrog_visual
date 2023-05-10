Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtGajiBulanan.Text) >= 5000000) Then
            txtKeterangan.Text = "Mohon maaf anda tidak bisa mendapatkan bantuan dari Desa"
        Else
            txtKeterangan.Text = "Selamat anda mendapatkan bantuan dari Desa"
        End If
    End Sub
End Class