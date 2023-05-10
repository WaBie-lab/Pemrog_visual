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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPanjang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLebar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTinggi = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menghitung Luas & Volume Persegi Panjang"
        '
        'txtPanjang
        '
        Me.txtPanjang.Location = New System.Drawing.Point(123, 58)
        Me.txtPanjang.Name = "txtPanjang"
        Me.txtPanjang.Size = New System.Drawing.Size(100, 20)
        Me.txtPanjang.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Panjang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Lebar"
        '
        'txtLebar
        '
        Me.txtLebar.Location = New System.Drawing.Point(123, 86)
        Me.txtLebar.Name = "txtLebar"
        Me.txtLebar.Size = New System.Drawing.Size(100, 20)
        Me.txtLebar.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tinggi"
        '
        'txtTinggi
        '
        Me.txtTinggi.Location = New System.Drawing.Point(123, 112)
        Me.txtTinggi.Name = "txtTinggi"
        Me.txtTinggi.Size = New System.Drawing.Size(100, 20)
        Me.txtTinggi.TabIndex = 5
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnHitung.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHitung.Location = New System.Drawing.Point(123, 139)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 7
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Volume"
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(123, 201)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(100, 20)
        Me.txtVolume.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Luas"
        '
        'txtLuas
        '
        Me.txtLuas.Location = New System.Drawing.Point(123, 175)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(100, 20)
        Me.txtLuas.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTinggi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLebar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPanjang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLebar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLuas As TextBox
End Class
