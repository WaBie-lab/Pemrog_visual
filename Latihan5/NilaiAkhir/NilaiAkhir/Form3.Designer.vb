<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeJabatan = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Robby Awaludin"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(23, 95)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(275, 20)
        Me.txtKeterangan.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Keterangan"
        '
        'txtKodeJabatan
        '
        Me.txtKodeJabatan.Location = New System.Drawing.Point(23, 49)
        Me.txtKodeJabatan.Name = "txtKodeJabatan"
        Me.txtKodeJabatan.Size = New System.Drawing.Size(164, 20)
        Me.txtKodeJabatan.TabIndex = 14
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(223, 49)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Kode Jabatan"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(332, 162)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodeJabatan)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Kode Jabatan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKodeJabatan As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
End Class
