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
        passwordBox = New TextBox()
        confirmPasswordBox = New TextBox()
        resetButton = New Button()
        cancelButton = New Button()
        passwordNotifier = New Label()
        confirmPassNotifier = New Label()
        SuspendLayout()
        ' 
        ' passwordBox
        ' 
        passwordBox.Location = New Point(80, 87)
        passwordBox.Name = "passwordBox"
        passwordBox.PlaceholderText = "New password"
        passwordBox.Size = New Size(149, 27)
        passwordBox.TabIndex = 0
        ' 
        ' confirmPasswordBox
        ' 
        confirmPasswordBox.Location = New Point(80, 145)
        confirmPasswordBox.Name = "confirmPasswordBox"
        confirmPasswordBox.PlaceholderText = "Confirm password"
        confirmPasswordBox.Size = New Size(149, 27)
        confirmPasswordBox.TabIndex = 1
        ' 
        ' resetButton
        ' 
        resetButton.Location = New Point(57, 210)
        resetButton.Name = "resetButton"
        resetButton.Size = New Size(94, 29)
        resetButton.TabIndex = 2
        resetButton.Text = "Reset"
        resetButton.UseVisualStyleBackColor = True
        ' 
        ' cancelButton
        ' 
        cancelButton.Location = New Point(157, 210)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(94, 29)
        cancelButton.TabIndex = 3
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = True
        ' 
        ' passwordNotifier
        ' 
        passwordNotifier.AutoSize = True
        passwordNotifier.Location = New Point(80, 54)
        passwordNotifier.Name = "passwordNotifier"
        passwordNotifier.Size = New Size(124, 20)
        passwordNotifier.TabIndex = 4
        passwordNotifier.Text = "password notifier"
        ' 
        ' confirmPassNotifier
        ' 
        confirmPassNotifier.AutoSize = True
        confirmPassNotifier.Location = New Point(80, 122)
        confirmPassNotifier.Name = "confirmPassNotifier"
        confirmPassNotifier.Size = New Size(145, 20)
        confirmPassNotifier.TabIndex = 5
        confirmPassNotifier.Text = "confirm pass notifier"
        ' 
        ' PasswordResetForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(107), CByte(163), CByte(202))
        ClientSize = New Size(306, 308)
        Controls.Add(confirmPassNotifier)
        Controls.Add(passwordNotifier)
        Controls.Add(cancelButton)
        Controls.Add(resetButton)
        Controls.Add(confirmPasswordBox)
        Controls.Add(passwordBox)
        FormBorderStyle = FormBorderStyle.None
        Name = "PasswordResetForm"
        Text = "PasswordResetForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents passwordBox As TextBox
    Friend WithEvents confirmPasswordBox As TextBox
    Friend WithEvents resetButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents passwordNotifier As Label
    Friend WithEvents confirmPassNotifier As Label
End Class
