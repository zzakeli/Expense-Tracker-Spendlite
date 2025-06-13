<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartingForm
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
        components = New ComponentModel.Container()
        slideContainer = New Panel()
        terminateButton = New Button()
        switchToSignUpButton = New Button()
        switchLabel = New Label()
        switchToLoginButton = New Button()
        passwordSignUpBox = New MaskedTextBox()
        emailSignUpBox = New TextBox()
        confirmPasswordSignUpBox = New MaskedTextBox()
        signUpButton = New Button()
        usernameLoginBox = New TextBox()
        passwordLoginBox = New MaskedTextBox()
        loginButton = New Button()
        forgotPassword = New LinkLabel()
        Timer1 = New Timer(components)
        usernameTextNotifier = New Label()
        emailTextNotifier = New Label()
        passwordTextNotifier = New Label()
        confirmPasswordTextNotifier = New Label()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        usernameSignUpBox = New TextBox()
        slideContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' slideContainer
        ' 
        slideContainer.BackColor = Color.FromArgb(CByte(54), CByte(116), CByte(181))
        slideContainer.Controls.Add(terminateButton)
        slideContainer.Controls.Add(switchToSignUpButton)
        slideContainer.Controls.Add(switchLabel)
        slideContainer.Controls.Add(switchToLoginButton)
        slideContainer.Location = New Point(433, -32)
        slideContainer.Name = "slideContainer"
        slideContainer.Size = New Size(454, 695)
        slideContainer.TabIndex = 0
        ' 
        ' terminateButton
        ' 
        terminateButton.Location = New Point(343, 644)
        terminateButton.Name = "terminateButton"
        terminateButton.Size = New Size(94, 29)
        terminateButton.TabIndex = 9
        terminateButton.Text = "Terminate"
        terminateButton.UseVisualStyleBackColor = True
        ' 
        ' switchToSignUpButton
        ' 
        switchToSignUpButton.Location = New Point(160, 333)
        switchToSignUpButton.Name = "switchToSignUpButton"
        switchToSignUpButton.Size = New Size(124, 39)
        switchToSignUpButton.TabIndex = 8
        switchToSignUpButton.Text = "Sign up"
        switchToSignUpButton.UseVisualStyleBackColor = True
        switchToSignUpButton.Visible = False
        ' 
        ' switchLabel
        ' 
        switchLabel.AutoSize = True
        switchLabel.ForeColor = SystemColors.ButtonHighlight
        switchLabel.Location = New Point(138, 310)
        switchLabel.Name = "switchLabel"
        switchLabel.Size = New Size(170, 20)
        switchLabel.TabIndex = 7
        switchLabel.Text = "Already hve an account?"
        ' 
        ' switchToLoginButton
        ' 
        switchToLoginButton.Location = New Point(160, 333)
        switchToLoginButton.Name = "switchToLoginButton"
        switchToLoginButton.Size = New Size(124, 39)
        switchToLoginButton.TabIndex = 6
        switchToLoginButton.Text = "LOGIN"
        switchToLoginButton.UseVisualStyleBackColor = True
        ' 
        ' passwordSignUpBox
        ' 
        passwordSignUpBox.Location = New Point(99, 305)
        passwordSignUpBox.Name = "passwordSignUpBox"
        passwordSignUpBox.Size = New Size(223, 27)
        passwordSignUpBox.TabIndex = 1
        passwordSignUpBox.Tag = ""
        passwordSignUpBox.UseSystemPasswordChar = True
        ' 
        ' emailSignUpBox
        ' 
        emailSignUpBox.Location = New Point(99, 242)
        emailSignUpBox.Name = "emailSignUpBox"
        emailSignUpBox.PlaceholderText = "Email"
        emailSignUpBox.Size = New Size(223, 27)
        emailSignUpBox.TabIndex = 3
        ' 
        ' confirmPasswordSignUpBox
        ' 
        confirmPasswordSignUpBox.Location = New Point(99, 357)
        confirmPasswordSignUpBox.Name = "confirmPasswordSignUpBox"
        confirmPasswordSignUpBox.Size = New Size(223, 27)
        confirmPasswordSignUpBox.TabIndex = 4
        confirmPasswordSignUpBox.Tag = ""
        confirmPasswordSignUpBox.UseSystemPasswordChar = True
        ' 
        ' signUpButton
        ' 
        signUpButton.Location = New Point(140, 417)
        signUpButton.Name = "signUpButton"
        signUpButton.Size = New Size(124, 39)
        signUpButton.TabIndex = 5
        signUpButton.Text = "SIGN UP"
        signUpButton.UseVisualStyleBackColor = True
        ' 
        ' usernameLoginBox
        ' 
        usernameLoginBox.Location = New Point(553, 206)
        usernameLoginBox.Name = "usernameLoginBox"
        usernameLoginBox.PlaceholderText = "Username"
        usernameLoginBox.Size = New Size(223, 27)
        usernameLoginBox.TabIndex = 6
        usernameLoginBox.Text = "Jestaly14"
        ' 
        ' passwordLoginBox
        ' 
        passwordLoginBox.Location = New Point(553, 262)
        passwordLoginBox.Name = "passwordLoginBox"
        passwordLoginBox.Size = New Size(223, 27)
        passwordLoginBox.TabIndex = 7
        passwordLoginBox.Tag = ""
        passwordLoginBox.Text = "Wanbilyon3Dimension"
        passwordLoginBox.UseSystemPasswordChar = True
        ' 
        ' loginButton
        ' 
        loginButton.Location = New Point(606, 342)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(124, 39)
        loginButton.TabIndex = 8
        loginButton.Text = "LOGIN"
        loginButton.UseVisualStyleBackColor = True
        ' 
        ' forgotPassword
        ' 
        forgotPassword.AutoSize = True
        forgotPassword.LinkColor = Color.Black
        forgotPassword.Location = New Point(553, 292)
        forgotPassword.Name = "forgotPassword"
        forgotPassword.Size = New Size(125, 20)
        forgotPassword.TabIndex = 9
        forgotPassword.TabStop = True
        forgotPassword.Text = "Forgot Password?"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' usernameTextNotifier
        ' 
        usernameTextNotifier.AutoSize = True
        usernameTextNotifier.Location = New Point(103, 164)
        usernameTextNotifier.Name = "usernameTextNotifier"
        usernameTextNotifier.Size = New Size(0, 20)
        usernameTextNotifier.TabIndex = 10
        ' 
        ' emailTextNotifier
        ' 
        emailTextNotifier.AutoSize = True
        emailTextNotifier.Location = New Point(103, 219)
        emailTextNotifier.Name = "emailTextNotifier"
        emailTextNotifier.Size = New Size(0, 20)
        emailTextNotifier.TabIndex = 11
        ' 
        ' passwordTextNotifier
        ' 
        passwordTextNotifier.AutoSize = True
        passwordTextNotifier.Location = New Point(103, 278)
        passwordTextNotifier.Name = "passwordTextNotifier"
        passwordTextNotifier.Size = New Size(0, 20)
        passwordTextNotifier.TabIndex = 12
        ' 
        ' confirmPasswordTextNotifier
        ' 
        confirmPasswordTextNotifier.AutoSize = True
        confirmPasswordTextNotifier.Location = New Point(103, 335)
        confirmPasswordTextNotifier.Name = "confirmPasswordTextNotifier"
        confirmPasswordTextNotifier.Size = New Size(0, 20)
        confirmPasswordTextNotifier.TabIndex = 13
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.BorderRadius = 30
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' usernameSignUpBox
        ' 
        usernameSignUpBox.Location = New Point(99, 189)
        usernameSignUpBox.Name = "usernameSignUpBox"
        usernameSignUpBox.PlaceholderText = "Username"
        usernameSignUpBox.Size = New Size(223, 27)
        usernameSignUpBox.TabIndex = 14
        ' 
        ' StartingForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(246))
        ClientSize = New Size(882, 653)
        Controls.Add(usernameSignUpBox)
        Controls.Add(confirmPasswordTextNotifier)
        Controls.Add(passwordTextNotifier)
        Controls.Add(emailTextNotifier)
        Controls.Add(usernameTextNotifier)
        Controls.Add(slideContainer)
        Controls.Add(forgotPassword)
        Controls.Add(loginButton)
        Controls.Add(passwordLoginBox)
        Controls.Add(usernameLoginBox)
        Controls.Add(signUpButton)
        Controls.Add(confirmPasswordSignUpBox)
        Controls.Add(emailSignUpBox)
        Controls.Add(passwordSignUpBox)
        FormBorderStyle = FormBorderStyle.None
        Name = "StartingForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Start"
        slideContainer.ResumeLayout(False)
        slideContainer.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents slideContainer As Panel
    Friend WithEvents passwordSignUpBox As MaskedTextBox
    Friend WithEvents Guna2TextBox1 As TextBox
    Friend WithEvents emailSignUpBox As TextBox
    Friend WithEvents confirmPasswordSignUpBox As MaskedTextBox
    Friend WithEvents signUpButton As Button
    Friend WithEvents switchLabel As Label
    Friend WithEvents switchToLoginButton As Button
    Friend WithEvents usernameLoginBox As TextBox
    Friend WithEvents passwordLoginBox As MaskedTextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents forgotPassword As LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents switchToSignUpButton As Button
    Friend WithEvents terminateButton As Button
    Friend WithEvents usernameTextNotifier As Label
    Friend WithEvents emailTextNotifier As Label
    Friend WithEvents passwordTextNotifier As Label
    Friend WithEvents confirmPasswordTextNotifier As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents usernameSignUpBox As TextBox

End Class
