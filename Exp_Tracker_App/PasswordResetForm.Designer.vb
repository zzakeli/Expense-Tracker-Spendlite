<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordResetForm
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
        resetButton = New Button()
        cancelButton = New Button()
        passwordNotifier = New Label()
        confirmPassNotifier = New Label()
        passwordBox = New MaskedTextBox()
        disappearingPassResetLabel = New Label()
        confirmPasswordBox = New MaskedTextBox()
        disappearingConfirmPassResetLabel = New Label()
        passwordBoxPanel = New Panel()
        confirmPasswordBoxPanel = New Panel()
        passwordBoxPanel.SuspendLayout()
        confirmPasswordBoxPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' resetButton
        ' 
        resetButton.BackColor = SystemColors.Window
        resetButton.FlatAppearance.BorderColor = SystemColors.Window
        resetButton.FlatStyle = FlatStyle.Flat
        resetButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        resetButton.Location = New Point(43, 220)
        resetButton.Name = "resetButton"
        resetButton.Size = New Size(97, 41)
        resetButton.TabIndex = 2
        resetButton.Text = "Reset"
        resetButton.UseVisualStyleBackColor = False
        ' 
        ' cancelButton
        ' 
        cancelButton.BackColor = SystemColors.Window
        cancelButton.FlatAppearance.BorderColor = SystemColors.Window
        cancelButton.FlatAppearance.BorderSize = 0
        cancelButton.FlatStyle = FlatStyle.Flat
        cancelButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cancelButton.Location = New Point(165, 220)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(97, 41)
        cancelButton.TabIndex = 3
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = False
        ' 
        ' passwordNotifier
        ' 
        passwordNotifier.AutoSize = True
        passwordNotifier.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordNotifier.Location = New Point(46, 97)
        passwordNotifier.Name = "passwordNotifier"
        passwordNotifier.Size = New Size(0, 22)
        passwordNotifier.TabIndex = 4
        ' 
        ' confirmPassNotifier
        ' 
        confirmPassNotifier.AutoSize = True
        confirmPassNotifier.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        confirmPassNotifier.Location = New Point(46, 186)
        confirmPassNotifier.Name = "confirmPassNotifier"
        confirmPassNotifier.Size = New Size(0, 22)
        confirmPassNotifier.TabIndex = 5
        ' 
        ' passwordBox
        ' 
        passwordBox.BorderStyle = BorderStyle.None
        passwordBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordBox.Location = New Point(12, 11)
        passwordBox.Name = "passwordBox"
        passwordBox.Size = New Size(194, 25)
        passwordBox.TabIndex = 6
        passwordBox.UseSystemPasswordChar = True
        ' 
        ' disappearingPassResetLabel
        ' 
        disappearingPassResetLabel.AutoSize = True
        disappearingPassResetLabel.BackColor = Color.Transparent
        disappearingPassResetLabel.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        disappearingPassResetLabel.ForeColor = Color.DimGray
        disappearingPassResetLabel.Location = New Point(12, 11)
        disappearingPassResetLabel.Name = "disappearingPassResetLabel"
        disappearingPassResetLabel.Size = New Size(88, 24)
        disappearingPassResetLabel.TabIndex = 7
        disappearingPassResetLabel.Text = "Password"
        ' 
        ' confirmPasswordBox
        ' 
        confirmPasswordBox.BorderStyle = BorderStyle.None
        confirmPasswordBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        confirmPasswordBox.Location = New Point(12, 12)
        confirmPasswordBox.Name = "confirmPasswordBox"
        confirmPasswordBox.Size = New Size(194, 25)
        confirmPasswordBox.TabIndex = 8
        confirmPasswordBox.UseSystemPasswordChar = True
        ' 
        ' disappearingConfirmPassResetLabel
        ' 
        disappearingConfirmPassResetLabel.AutoSize = True
        disappearingConfirmPassResetLabel.BackColor = Color.Transparent
        disappearingConfirmPassResetLabel.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        disappearingConfirmPassResetLabel.ForeColor = Color.DimGray
        disappearingConfirmPassResetLabel.Location = New Point(12, 12)
        disappearingConfirmPassResetLabel.Name = "disappearingConfirmPassResetLabel"
        disappearingConfirmPassResetLabel.Size = New Size(155, 24)
        disappearingConfirmPassResetLabel.TabIndex = 9
        disappearingConfirmPassResetLabel.Text = "Confirm Password"
        ' 
        ' passwordBoxPanel
        ' 
        passwordBoxPanel.BackColor = SystemColors.Window
        passwordBoxPanel.Controls.Add(disappearingPassResetLabel)
        passwordBoxPanel.Controls.Add(passwordBox)
        passwordBoxPanel.Location = New Point(43, 46)
        passwordBoxPanel.Name = "passwordBoxPanel"
        passwordBoxPanel.Size = New Size(219, 48)
        passwordBoxPanel.TabIndex = 10
        ' 
        ' confirmPasswordBoxPanel
        ' 
        confirmPasswordBoxPanel.BackColor = SystemColors.Window
        confirmPasswordBoxPanel.Controls.Add(disappearingConfirmPassResetLabel)
        confirmPasswordBoxPanel.Controls.Add(confirmPasswordBox)
        confirmPasswordBoxPanel.Location = New Point(43, 135)
        confirmPasswordBoxPanel.Name = "confirmPasswordBoxPanel"
        confirmPasswordBoxPanel.Size = New Size(219, 48)
        confirmPasswordBoxPanel.TabIndex = 11
        ' 
        ' PasswordResetForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(107), CByte(163), CByte(202))
        ClientSize = New Size(306, 308)
        Controls.Add(confirmPasswordBoxPanel)
        Controls.Add(confirmPassNotifier)
        Controls.Add(passwordNotifier)
        Controls.Add(cancelButton)
        Controls.Add(resetButton)
        Controls.Add(passwordBoxPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "PasswordResetForm"
        Text = "PasswordResetForm"
        passwordBoxPanel.ResumeLayout(False)
        passwordBoxPanel.PerformLayout()
        confirmPasswordBoxPanel.ResumeLayout(False)
        confirmPasswordBoxPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents resetButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents passwordNotifier As Label
    Friend WithEvents confirmPassNotifier As Label
    Friend WithEvents passwordBox As MaskedTextBox
    Friend WithEvents disappearingPassResetLabel As Label
    Friend WithEvents confirmPasswordBox As MaskedTextBox
    Friend WithEvents disappearingConfirmPassResetLabel As Label
    Friend WithEvents passwordBoxPanel As Panel
    Friend WithEvents confirmPasswordBoxPanel As Panel
End Class
