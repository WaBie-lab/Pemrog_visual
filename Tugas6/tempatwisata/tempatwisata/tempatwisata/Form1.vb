Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If rbtnDewasa.Checked = True Then
            txtTotal.Text = "30000"
        ElseIf rbtnRemaja.Checked = True Then
            txtTotal.Text = "20000"
        ElseIf rbtnAnakanak.Checked = True Then
            txtTotal.Text = "15000"
        Else
            MessageBox.Show("Klik Pilihan Tiket")
        End If
    End Sub
End Class


