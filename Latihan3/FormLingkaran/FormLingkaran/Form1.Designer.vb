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
        Me.Label = New System.Windows.Forms.Label()
        Me.txtJarijari = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKeliling = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(23, 36)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(50, 17)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Jarijari"
        '
        'txtJarijari
        '
        Me.txtJarijari.Location = New System.Drawing.Point(118, 36)
        Me.txtJarijari.Name = "txtJarijari"
        Me.txtJarijari.Size = New System.Drawing.Size(100, 20)
        Me.txtJarijari.TabIndex = 1
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(118, 71)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 2
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'txtLuas
        '
        Me.txtLuas.Location = New System.Drawing.Point(118, 107)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(100, 20)
        Me.txtLuas.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Luas"
        '
        'txtKeliling
        '
        Me.txtKeliling.Location = New System.Drawing.Point(118, 133)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(100, 20)
        Me.txtKeliling.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Keliling"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtJarijari)
        Me.Controls.Add(Me.Label)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label As Label
    Friend WithEvents txtJarijari As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Label2 As Label
End Class
