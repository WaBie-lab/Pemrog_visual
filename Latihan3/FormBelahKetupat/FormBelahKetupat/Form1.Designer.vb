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
        Me.txtDiagonal1 = New System.Windows.Forms.TextBox()
        Me.txtDiagonal2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSisi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKeliling = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diagonal1"
        '
        'txtDiagonal1
        '
        Me.txtDiagonal1.Location = New System.Drawing.Point(107, 37)
        Me.txtDiagonal1.Name = "txtDiagonal1"
        Me.txtDiagonal1.Size = New System.Drawing.Size(100, 20)
        Me.txtDiagonal1.TabIndex = 1
        '
        'txtDiagonal2
        '
        Me.txtDiagonal2.Location = New System.Drawing.Point(107, 63)
        Me.txtDiagonal2.Name = "txtDiagonal2"
        Me.txtDiagonal2.Size = New System.Drawing.Size(100, 20)
        Me.txtDiagonal2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Diagonal2"
        '
        'txtSisi
        '
        Me.txtSisi.Location = New System.Drawing.Point(107, 89)
        Me.txtSisi.Name = "txtSisi"
        Me.txtSisi.Size = New System.Drawing.Size(100, 20)
        Me.txtSisi.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sisi"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnHitung.Location = New System.Drawing.Point(107, 116)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 6
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtLuas
        '
        Me.txtLuas.Location = New System.Drawing.Point(107, 160)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(100, 20)
        Me.txtLuas.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Luas"
        '
        'txtKeliling
        '
        Me.txtKeliling.Location = New System.Drawing.Point(107, 186)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(100, 20)
        Me.txtKeliling.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Keliling"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtSisi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDiagonal2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDiagonal1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiagonal1 As TextBox
    Friend WithEvents txtDiagonal2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSisi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Label5 As Label
End Class
