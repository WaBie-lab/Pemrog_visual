Public Class Form1
    Private Sub cmbFakultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFakultas.Items.Clear() 'Fungsi untuk menghapus item yang ada didalam combobox ketika form pertama di pilih'
        cmbFakultas.Items.Add("TEKNIK") 'Fungsi untuk menambah item di dalam combobox'
        cmbFakultas.Items.Add("FKIP")
        cmbFakultas.Items.Add("FIKES")
        cmbFakultas.Items.Add("FISIP")
        cmbFakultas.Items.Add("FE")
        cmbFakultas.Items.Add("FAI")
        cmbFakultas.Items.Add("FH")
    End Sub

    Private Sub cmbProdi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbProdi.Items.Clear() 'Fungsi untuk menghapus item yang ada didalam combobox ketika form pertama di pilih'
        cmbProdi.Items.Add("Teknik Informatika") 'Fungsi untuk menambah item di dalam combobox'
        cmbProdi.Items.Add("Teknik Industri")
        cmbProdi.Items.Add("Peternakan")
        cmbProdi.Items.Add("D3 Teknik Informatika")
        cmbProdi.Items.Add("D3 Teknik Industri")
        cmbProdi.Items.Add("Pendidikan Matematika")
        cmbProdi.Items.Add("Pendidikan Kimia")
        cmbProdi.Items.Add("PG SD")
        cmbProdi.Items.Add("PG PAUD")
        cmbProdi.Items.Add("Pendidikan IPA")
        cmbProdi.Items.Add("Keperawatan")
        cmbProdi.Items.Add("Profesi Ners")
        cmbProdi.Items.Add("Ilmu Keolahragaan")
        cmbProdi.Items.Add("Ilmu Gizi")
        cmbProdi.Items.Add("Ilmu Komunikasi")
        cmbProdi.Items.Add("Ilmu Pemerintahan")
        cmbProdi.Items.Add("D3 Hubungan Masyarakat")
        cmbProdi.Items.Add("Manajemen")
        cmbProdi.Items.Add("Akuntansi")
        cmbProdi.Items.Add("Tasawuf dan Psikoterapi")
        cmbProdi.Items.Add("Ilmu Al-Quran dan Tafsir")
        cmbProdi.Items.Add("Ilmu Hukum")

    End Sub

    Private Sub cmbSemester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSemester.Items.Clear() 'Fungsi untuk menghapus item yang ada didalam combobox ketika form pertama di pilih'
        cmbSemester.Items.Add("1") 'Fungsi untuk menambah item di dalam combobox'
        cmbSemester.Items.Add("2")
        cmbSemester.Items.Add("3")
        cmbSemester.Items.Add("4")
        cmbSemester.Items.Add("5")
        cmbSemester.Items.Add("6")
        cmbSemester.Items.Add("7")
        cmbSemester.Items.Add("8")
    End Sub

    Private Sub cmbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdi.SelectedIndexChanged
        If cmbProdi.Text = "Teknik Informatika" Then 'Jika prodi yang di pilih teknik informatika
            txtNominal.Text = "500000"
        ElseIf cmbProdi.Text = "Teknik Industri" Then
            txtNominal.Text = "400000"
        ElseIf cmbProdi.Text = "Peternakan" Then
            txtNominal.Text = "300000"
        ElseIf cmbProdi.Text = " D3 Teknik Industri" Then
            txtNominal.Text = "200000"
        ElseIf cmbProdi.Text = "D3 Teknik Informatika" Then
            txtNominal.Text = "200000"
        ElseIf cmbProdi.Text = "Pendidikan Matematika" Then
            txtNominal.Text = "400000"
        ElseIf cmbProdi.Text = "Pendidikan Kimia" Then
            txtNominal.Text = "380000"
        ElseIf cmbProdi.Text = "PG SD" Then
            txtNominal.Text = "550000"
        ElseIf cmbProdi.Text = "PG PAUD" Then
            txtNominal.Text = "550000"
        ElseIf cmbProdi.Text = "Pendidikan IPA" Then
            txtNominal.Text = "400000"
        ElseIf cmbProdi.Text = "Keperawatan" Then
            txtNominal.Text = "800000"
        ElseIf cmbProdi.Text = "Profesi Ners" Then
            txtNominal.Text = "300000"
        ElseIf cmbProdi.Text = "Ilmu keolahragaan" Then
            txtNominal.Text = "300000"
        ElseIf cmbProdi.Text = "Ilmu Gizi" Then
            txtNominal.Text = "500000"
        ElseIf cmbProdi.Text = "Ilmu Komunikasi" Then
            txtNominal.Text = "600000"
        ElseIf cmbProdi.Text = "Ilmu Pemerintahan" Then
            txtNominal.Text = "400000"
        ElseIf cmbProdi.Text = "D3 Hubungan Masyarakat" Then
            txtNominal.Text = "300000"
        ElseIf cmbProdi.Text = "Manajemen" Then
            txtNominal.Text = "650000"
        ElseIf cmbProdi.Text = "Akuntansi" Then
            txtNominal.Text = "650000"
        ElseIf cmbProdi.Text = "Tasawuf dan Psikoterapi" Then
            txtNominal.Text = "300000"
        ElseIf cmbProdi.Text = "Ilmu Al-Quran dan Tafsir" Then
            txtNominal.Text = "450000"
        ElseIf cmbProdi.Text = "Ilmu Hukum" Then
            txtNominal.Text = "680.000"
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        txtSisaTunggakan.Text = Val(txtNominal.Text) - Val(txtBayar.Text)
    End Sub

End Class
