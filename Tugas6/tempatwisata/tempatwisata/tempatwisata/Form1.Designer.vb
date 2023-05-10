<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.t = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbUsia = New System.Windows.Forms.GroupBox()
        Me.rbtnRemaja = New System.Windows.Forms.RadioButton()
        Me.rbtnAnakanak = New System.Windows.Forms.RadioButton()
        Me.rbtnDewasa = New System.Windows.Forms.RadioButton()
        Me.gbUsia.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(28, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pembayaran Wisata Kolam Renang Jempol"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(179, 233)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(110, 20)
        Me.txtTotal.TabIndex = 12
        '
        't
        '
        Me.t.AutoSize = True
        Me.t.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.t.Location = New System.Drawing.Point(108, 233)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(44, 17)
        Me.t.TabIndex = 11
        Me.t.Text = "Total:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Red
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(179, 199)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 28)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(159, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 25)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = ""
        '
        'gbUsia
        '
        Me.gbUsia.Controls.Add(Me.rbtnRemaja)
        Me.gbUsia.Controls.Add(Me.rbtnAnakanak)
        Me.gbUsia.Controls.Add(Me.rbtnDewasa)
        Me.gbUsia.Location = New System.Drawing.Point(111, 93)
        Me.gbUsia.Name = "gbUsia"
        Me.gbUsia.Size = New System.Drawing.Size(200, 100)
        Me.gbUsia.TabIndex = 26
        Me.gbUsia.TabStop = False
        Me.gbUsia.Text = "Usia"
        '
        'rbtnRemaja
        '
        Me.rbtnRemaja.AutoSize = True
        Me.rbtnRemaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnRemaja.Location = New System.Drawing.Point(19, 40)
        Me.rbtnRemaja.Name = "rbtnRemaja"
        Me.rbtnRemaja.Size = New System.Drawing.Size(74, 21)
        Me.rbtnRemaja.TabIndex = 29
        Me.rbtnRemaja.TabStop = True
        Me.rbtnRemaja.Text = "Remaja"
        Me.rbtnRemaja.UseVisualStyleBackColor = True
        '
        'rbtnAnakanak
        '
        Me.rbtnAnakanak.AutoSize = True
        Me.rbtnAnakanak.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAnakanak.Location = New System.Drawing.Point(19, 63)
        Me.rbtnAnakanak.Name = "rbtnAnakanak"
        Me.rbtnAnakanak.Size = New System.Drawing.Size(94, 21)
        Me.rbtnAnakanak.TabIndex = 28
        Me.rbtnAnakanak.TabStop = True
        Me.rbtnAnakanak.Text = "Anak-anak"
        Me.rbtnAnakanak.UseVisualStyleBackColor = True
        '
        'rbtnDewasa
        '
        Me.rbtnDewasa.AutoSize = True
        Me.rbtnDewasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDewasa.Location = New System.Drawing.Point(19, 17)
        Me.rbtnDewasa.Name = "rbtnDewasa"
        Me.rbtnDewasa.Size = New System.Drawing.Size(76, 21)
        Me.rbtnDewasa.TabIndex = 27
        Me.rbtnDewasa.TabStop = True
        Me.rbtnDewasa.Text = "Dewasa"
        Me.rbtnDewasa.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(409, 319)
        Me.Controls.Add(Me.gbUsia)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.t)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pembayaran Wisata Kolam Renang Jempol"
        Me.gbUsia.ResumeLayout(False)
        Me.gbUsia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents t As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents gbUsia As GroupBox
    Friend WithEvents rbtnRemaja As RadioButton
    Friend WithEvents rbtnAnakanak As RadioButton
    Friend WithEvents rbtnDewasa As RadioButton
End Class
