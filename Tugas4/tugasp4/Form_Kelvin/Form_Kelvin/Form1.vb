Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim K, C, F, R As Decimal
        K = CDec(txtKelvin.Text)
        C = ToCelcius(K)
        F = ToFarenheit(K)
        R = ToReamur(K)

        txtCelcius.Text = Str(C)
        txtFarenheit.Text = Str(F)
        txtReamur.Text = Str(R)
    End Sub

    Private Function ToCelcius(K As Decimal) As Decimal
        Dim C As Decimal
        C = K - 273
        Return C
    End Function

    Private Function ToFarenheit(K As Decimal) As Decimal
        Dim F As Decimal
        F = 9 / 5 * (K - 273) + 32
        Return F
    End Function

    Private Function ToReamur(K As Decimal) As Decimal
        Dim R As Decimal
        R = 4 / 5 * (K - 273)
        Return R
    End Function

End Class

