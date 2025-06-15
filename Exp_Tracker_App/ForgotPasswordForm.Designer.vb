<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordForm
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
        emailBox = New TextBox()
        verifyButton = New Button()
        emailBoxPanel = New Panel()
        cancelButton = New Button()
        emailBoxPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' emailBox
        ' 
        emailBox.BorderStyle = BorderStyle.None
        emailBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailBox.Location = New Point(11, 10)
        emailBox.Name = "emailBox"
        emailBox.PlaceholderText = "Enter Email"
        emailBox.Size = New Size(179, 25)
        emailBox.TabIndex = 0
        ' 
        ' verifyButton
        ' 
        verifyButton.BackColor = SystemColors.Window
        verifyButton.FlatAppearance.BorderColor = SystemColors.Window
        verifyButton.FlatAppearance.BorderSize = 0
        verifyButton.FlatStyle = FlatStyle.Flat
        verifyButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        verifyButton.Location = New Point(49, 187)
        verifyButton.Name = "verifyButton"
        verifyButton.Size = New Size(97, 41)
        verifyButton.TabIndex = 1
        verifyButton.Text = "Verify"
        verifyButton.UseVisualStyleBackColor = False
        ' 
        ' emailBoxPanel
        ' 
        emailBoxPanel.BackColor = SystemColors.Window
        emailBoxPanel.Controls.Add(emailBox)
        emailBoxPanel.Location = New Point(49, 85)
        emailBoxPanel.Name = "emailBoxPanel"
        emailBoxPanel.Size = New Size(202, 46)
        emailBoxPanel.TabIndex = 2
        ' 
        ' cancelButton
        ' 
        cancelButton.BackColor = SystemColors.Window
        cancelButton.FlatAppearance.BorderColor = SystemColors.Window
        cancelButton.FlatAppearance.BorderSize = 0
        cancelButton.FlatStyle = FlatStyle.Flat
        cancelButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cancelButton.Location = New Point(154, 187)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(97, 41)
        cancelButton.TabIndex = 3
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = False
        ' 
        ' ForgotPasswordForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(107), CByte(163), CByte(202))
        ClientSize = New Size(306, 308)
        Controls.Add(cancelButton)
        Controls.Add(verifyButton)
        Controls.Add(emailBoxPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "ForgotPasswordForm"
        Text = "ForgotPasswordForm"
        emailBoxPanel.ResumeLayout(False)
        emailBoxPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents emailBox As TextBox
    Friend WithEvents verifyButton As Button
    Friend WithEvents emailBoxPanel As Panel
    Friend WithEvents cancelButton As Button
End Class
