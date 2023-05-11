Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim R, C, F, K As Decimal
        R = CDec(txtReamur.Text)
        C = ToCelcius(R)
        F = ToFarenheit(R)
        K = ToKelvin(R)

        txtCelcius.Text = Str(C)
        txtFarenheit.Text = Str(F)
        txtKelvin.Text = Str(K)
    End Sub

    Private Function ToCelcius(R As Decimal) As Decimal
        Dim C As Decimal
        C = 5 / 4 * R
        Return C
    End Function

    Private Function ToFarenheit(R As Decimal) As Decimal
        Dim F As Decimal
        F = (9 / 4) * R + 32
        Return F
    End Function

    Private Function ToKelvin(R As Decimal) As Decimal
        Dim K As Decimal
        K = 5 / 4 * R + 273
        Return K
    End Function

End Class

