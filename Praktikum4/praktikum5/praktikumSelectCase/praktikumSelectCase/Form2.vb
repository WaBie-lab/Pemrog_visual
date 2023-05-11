Public Class Form2
    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        Select Case txtKodeJurusan.Text
            Case "2005" : txtKeterangan.Text = "Teknik Informatika"

            Case "2001" : txtKeterangan.Text = "Teknik Sipil "

            Case "2002" : txtKeterangan.Text = "Teknik Peternakan"

            Case "2003" : txtKeterangan.Text = "Perawat"

            Case "2004" : txtKeterangan.Text = "Gizi"

            Case "2006" : txtKeterangan.Text = "Teknik Industri"

            Case "2007" : txtKeterangan.Text = "Manajemen"

            Case "2009" : txtKeterangan.Text = "Hukum"

            Case "2008" : txtKeterangan.Text = "PGSD"

            Case Else : txtKeterangan.Text = "Mohon maaf Kode yang anda masukan tidak terdaftar"
        End Select
    End Sub
End Class