Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        Select Case txtKodeVoucher.Text
            Case "1234" : txtKeterangan.Text = "Potongan Harga 25.000"

            Case "2345" : txtKeterangan.Text = "Potongan Harga 15.000"

            Case "3456" : txtKeterangan.Text = "Potongan Harga 8.000"

            Case "4567" : txtKeterangan.Text = "Potongan Harga 5.000"

            Case Else : txtKeterangan.Text = "Tidak ada potongan harga"
        End Select
    End Sub
End Class
