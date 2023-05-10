<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMasaKerja = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(25, 91)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(275, 20)
        Me.txtKeterangan.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Keterangan"
        '
        'txtMasaKerja
        '
        Me.txtMasaKerja.Location = New System.Drawing.Point(25, 45)
        Me.txtMasaKerja.Name = "txtMasaKerja"
        Me.txtMasaKerja.Size = New System.Drawing.Size(164, 20)
        Me.txtMasaKerja.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(225, 45)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Masa Kerja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Robby Awaludin"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(347, 171)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMasaKerja)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Bonus Ulang Tahun Perusahaan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMasaKerja As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
