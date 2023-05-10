<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNoMember = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbBaju = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCelana = New System.Windows.Forms.CheckBox()
        Me.cbJilbab = New System.Windows.Forms.CheckBox()
        Me.cbSepatu = New System.Windows.Forms.CheckBox()
        Me.cbKaosKaki = New System.Windows.Forms.CheckBox()
        Me.cbRok = New System.Windows.Forms.CheckBox()
        Me.btnCek = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHNormal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHPromo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNoMember
        '
        Me.txtNoMember.Location = New System.Drawing.Point(190, 57)
        Me.txtNoMember.Name = "txtNoMember"
        Me.txtNoMember.Size = New System.Drawing.Size(100, 20)
        Me.txtNoMember.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Promo Diskon 10%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No Member"
        '
        'cbBaju
        '
        Me.cbBaju.AutoSize = True
        Me.cbBaju.Location = New System.Drawing.Point(190, 84)
        Me.cbBaju.Name = "cbBaju"
        Me.cbBaju.Size = New System.Drawing.Size(47, 17)
        Me.cbBaju.TabIndex = 3
        Me.cbBaju.Text = "Baju"
        Me.cbBaju.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jenis Barang"
        '
        'cbCelana
        '
        Me.cbCelana.AutoSize = True
        Me.cbCelana.Location = New System.Drawing.Point(190, 107)
        Me.cbCelana.Name = "cbCelana"
        Me.cbCelana.Size = New System.Drawing.Size(59, 17)
        Me.cbCelana.TabIndex = 5
        Me.cbCelana.Text = "Celana"
        Me.cbCelana.UseVisualStyleBackColor = True
        '
        'cbJilbab
        '
        Me.cbJilbab.AutoSize = True
        Me.cbJilbab.Location = New System.Drawing.Point(190, 130)
        Me.cbJilbab.Name = "cbJilbab"
        Me.cbJilbab.Size = New System.Drawing.Size(53, 17)
        Me.cbJilbab.TabIndex = 6
        Me.cbJilbab.Text = "Jilbab"
        Me.cbJilbab.UseVisualStyleBackColor = True
        '
        'cbSepatu
        '
        Me.cbSepatu.AutoSize = True
        Me.cbSepatu.Location = New System.Drawing.Point(294, 107)
        Me.cbSepatu.Name = "cbSepatu"
        Me.cbSepatu.Size = New System.Drawing.Size(60, 17)
        Me.cbSepatu.TabIndex = 8
        Me.cbSepatu.Text = "Sepatu"
        Me.cbSepatu.UseVisualStyleBackColor = True
        '
        'cbKaosKaki
        '
        Me.cbKaosKaki.AutoSize = True
        Me.cbKaosKaki.Location = New System.Drawing.Point(294, 84)
        Me.cbKaosKaki.Name = "cbKaosKaki"
        Me.cbKaosKaki.Size = New System.Drawing.Size(73, 17)
        Me.cbKaosKaki.TabIndex = 7
        Me.cbKaosKaki.Text = "Kaos kaki"
        Me.cbKaosKaki.UseVisualStyleBackColor = True
        '
        'cbRok
        '
        Me.cbRok.AutoSize = True
        Me.cbRok.Location = New System.Drawing.Point(294, 129)
        Me.cbRok.Name = "cbRok"
        Me.cbRok.Size = New System.Drawing.Size(46, 17)
        Me.cbRok.TabIndex = 9
        Me.cbRok.Text = "Rok"
        Me.cbRok.UseVisualStyleBackColor = True
        '
        'btnCek
        '
        Me.btnCek.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCek.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCek.Location = New System.Drawing.Point(190, 179)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(75, 23)
        Me.btnCek.TabIndex = 10
        Me.btnCek.Text = "Cek"
        Me.btnCek.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Harga Normal"
        '
        'txtHNormal
        '
        Me.txtHNormal.Location = New System.Drawing.Point(190, 216)
        Me.txtHNormal.Name = "txtHNormal"
        Me.txtHNormal.Size = New System.Drawing.Size(100, 20)
        Me.txtHNormal.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(100, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Harga Promo"
        '
        'txtHPromo
        '
        Me.txtHPromo.Location = New System.Drawing.Point(190, 242)
        Me.txtHPromo.Name = "txtHPromo"
        Me.txtHPromo.Size = New System.Drawing.Size(100, 20)
        Me.txtHPromo.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(124, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Terimakasih Telah Berbelanja Di Tiga Detik Distro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(100, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Jumlah"
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(190, 153)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(100, 20)
        Me.txtJumlah.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(100, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(190, 268)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(314, 20)
        Me.txtKeterangan.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(578, 383)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHPromo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHNormal)
        Me.Controls.Add(Me.btnCek)
        Me.Controls.Add(Me.cbRok)
        Me.Controls.Add(Me.cbSepatu)
        Me.Controls.Add(Me.cbKaosKaki)
        Me.Controls.Add(Me.cbJilbab)
        Me.Controls.Add(Me.cbCelana)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbBaju)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoMember)
        Me.Name = "Form1"
        Me.Text = "Promo Lebaran 10% TigaDetik Distro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNoMember As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbBaju As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCelana As CheckBox
    Friend WithEvents cbJilbab As CheckBox
    Friend WithEvents cbSepatu As CheckBox
    Friend WithEvents cbKaosKaki As CheckBox
    Friend WithEvents cbRok As CheckBox
    Friend WithEvents btnCek As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHNormal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHPromo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtKeterangan As TextBox
End Class
