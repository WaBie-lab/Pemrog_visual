Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim F, C, R, K As Integer
        F = CDec(txtFahrenheit.Text)
        C = ToCelcius(F)
        R = ToReamur(F)
        K = ToKelvin(F)

        txtCelcius.Text = Str(C)
        txtReamur.Text = Str(R)
        txtKelvin.Text = Str(K)
    End Sub

    Private Function ToCelcius(F As Integer) As Decimal
        Dim C As Integer
        C = 5 / 9 * (F - 32)
        Return C
    End Function

    Private Function ToReamur(F As Integer) As Decimal
        Dim R As Integer
        R = 4 / 9 * (F - 32)
        Return R
    End Function

    Private Function ToKelvin(F As Integer) As Decimal
        Dim K As Integer
        K = 5 / 9 * (F - 32) + 273
        Return K
    End Function

End Class

