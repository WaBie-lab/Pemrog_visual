Public Class Form1
    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        Const Baju As Integer = 120000
        Const Celana As Integer = 100000
        Const Jilbab As Integer = 45000
        Const KaosKaki As Integer = 20000
        Const Sepatu As Integer = 280000
        Const Rok As Integer = 80000

        Dim sum As Integer
        If cbBaju.Checked = True Then
            sum = sum + Baju
        End If
        If cbCelana.Checked = True Then
            sum = sum + Celana
        End If
        If cbJilbab.Checked = True Then
            sum = sum + Jilbab
        End If
        If cbKaosKaki.Checked = True Then
            sum = sum + KaosKaki
        End If
        If cbSepatu.Checked = True Then
            sum = sum + Sepatu
        End If
        If cbRok.Checked = True Then
            sum = sum + Rok
        End If

        txtHNormal.Text = sum * txtJumlah.Text
        txtHPromo.Text = sum - (sum * 10 / 100)

        If (Val(txtNoMember.Text) = 1111) Then
            txtKeterangan.Text = "Selamat Member Anda Berhasil Digunakan"
        ElseIf (Val(txtNoMember.Text) = 2222) Then
            txtKeterangan.Text = "Selamat Member Anda Berhasil Digunakan"
        ElseIf (Val(txtNoMember.Text) = 3333) Then
            txtKeterangan.Text = "Selamat Member Anda Berhasil Digunakan"
        ElseIf (Val(txtNoMember.Text) = 4444) Then
            txtKeterangan.Text = "Selamat Member Anda Berhasil Digunakan"
        ElseIf (Val(txtNoMember.Text) = 5555) Then
            txtKeterangan.Text = "Selamat Member Anda Berhasil Digunakan"

        Else
            txtKeterangan.Text = "Mohon Maaf No Member yang Anda Masukkan Tidak Terdaftar"
        End If

    End Sub
End Class
