<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyOTPForm
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
        digitBox1 = New TextBox()
        digitBox2 = New TextBox()
        digitBox3 = New TextBox()
        digitBox6 = New TextBox()
        digitBox5 = New TextBox()
        digitBox4 = New TextBox()
        verifyButton = New Button()
        cancelButton = New Button()
        verifyOTPLabel = New Label()
        SuspendLayout()
        ' 
        ' digitBox1
        ' 
        digitBox1.BorderStyle = BorderStyle.None
        digitBox1.Font = New Font("Roboto Condensed", 16.2F)
        digitBox1.Location = New Point(36, 135)
        digitBox1.MaxLength = 1
        digitBox1.Name = "digitBox1"
        digitBox1.Size = New Size(34, 33)
        digitBox1.TabIndex = 0
        digitBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' digitBox2
        ' 
        digitBox2.BorderStyle = BorderStyle.None
        digitBox2.Font = New Font("Roboto Condensed", 16.2F)
        digitBox2.Location = New Point(76, 135)
        digitBox2.MaxLength = 1
        digitBox2.Name = "digitBox2"
        digitBox2.Size = New Size(34, 33)
        digitBox2.TabIndex = 1
        digitBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' digitBox3
        ' 
        digitBox3.BorderStyle = BorderStyle.None
        digitBox3.Font = New Font("Roboto Condensed", 16.2F)
        digitBox3.Location = New Point(116, 135)
        digitBox3.MaxLength = 1
        digitBox3.Name = "digitBox3"
        digitBox3.Size = New Size(34, 33)
        digitBox3.TabIndex = 2
        digitBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' digitBox6
        ' 
        digitBox6.BorderStyle = BorderStyle.None
        digitBox6.Font = New Font("Roboto Condensed", 16.2F)
        digitBox6.Location = New Point(236, 135)
        digitBox6.MaxLength = 1
        digitBox6.Name = "digitBox6"
        digitBox6.Size = New Size(34, 33)
        digitBox6.TabIndex = 5
        digitBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' digitBox5
        ' 
        digitBox5.BorderStyle = BorderStyle.None
        digitBox5.Font = New Font("Roboto Condensed", 16.2F)
        digitBox5.Location = New Point(196, 135)
        digitBox5.MaxLength = 1
        digitBox5.Name = "digitBox5"
        digitBox5.Size = New Size(34, 33)
        digitBox5.TabIndex = 4
        digitBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' digitBox4
        ' 
        digitBox4.BorderStyle = BorderStyle.None
        digitBox4.Font = New Font("Roboto Condensed", 16.2F)
        digitBox4.Location = New Point(156, 135)
        digitBox4.MaxLength = 1
        digitBox4.Name = "digitBox4"
        digitBox4.Size = New Size(34, 33)
        digitBox4.TabIndex = 3
        digitBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' verifyButton
        ' 
        verifyButton.BackColor = SystemColors.Window
        verifyButton.FlatAppearance.BorderColor = SystemColors.Window
        verifyButton.FlatAppearance.BorderSize = 0
        verifyButton.FlatStyle = FlatStyle.Flat
        verifyButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        verifyButton.Location = New Point(41, 199)
        verifyButton.Name = "verifyButton"
        verifyButton.Size = New Size(108, 36)
        verifyButton.TabIndex = 6
        verifyButton.Text = "Verify"
        verifyButton.UseVisualStyleBackColor = False
        ' 
        ' cancelButton
        ' 
        cancelButton.BackColor = SystemColors.Window
        cancelButton.FlatAppearance.BorderColor = SystemColors.Window
        cancelButton.FlatAppearance.BorderSize = 0
        cancelButton.FlatStyle = FlatStyle.Flat
        cancelButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cancelButton.Location = New Point(155, 199)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(108, 36)
        cancelButton.TabIndex = 7
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = False
        ' 
        ' verifyOTPLabel
        ' 
        verifyOTPLabel.AutoSize = True
        verifyOTPLabel.Font = New Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        verifyOTPLabel.Location = New Point(92, 65)
        verifyOTPLabel.Name = "verifyOTPLabel"
        verifyOTPLabel.Size = New Size(118, 30)
        verifyOTPLabel.TabIndex = 8
        verifyOTPLabel.Text = "Verify OTP"
        ' 
        ' VerifyOTPForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(107), CByte(163), CByte(202))
        ClientSize = New Size(306, 308)
        Controls.Add(verifyOTPLabel)
        Controls.Add(cancelButton)
        Controls.Add(verifyButton)
        Controls.Add(digitBox6)
        Controls.Add(digitBox5)
        Controls.Add(digitBox4)
        Controls.Add(digitBox3)
        Controls.Add(digitBox2)
        Controls.Add(digitBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "VerifyOTPForm"
        Text = "VerifyOTPForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents digitBox1 As TextBox
    Friend WithEvents digitBox2 As TextBox
    Friend WithEvents digitBox3 As TextBox
    Friend WithEvents digitBox6 As TextBox
    Friend WithEvents digitBox5 As TextBox
    Friend WithEvents digitBox4 As TextBox
    Friend WithEvents verifyButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents verifyOTPLabel As Label
End Class
