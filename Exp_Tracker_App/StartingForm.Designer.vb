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
        usernameSignUpBox = New TextBox()
        usernameSignUpBoxPanel = New Panel()
        emailSignUpBoxPanel = New Panel()
        passwordSignUpBoxPanel = New Panel()
        disappearingPassSignUpLabel = New Label()
        confirmPasswordSignUpBoxPanel = New Panel()
        disappearingConfirmPassSignUpLabel = New Label()
        usernameLogInBoxPanel = New Panel()
        passwordLogInBoxPanel = New Panel()
        disappearingPassLogInLabel = New Label()
        slideContainer.SuspendLayout()
        usernameSignUpBoxPanel.SuspendLayout()
        emailSignUpBoxPanel.SuspendLayout()
        passwordSignUpBoxPanel.SuspendLayout()
        confirmPasswordSignUpBoxPanel.SuspendLayout()
        usernameLogInBoxPanel.SuspendLayout()
        passwordLogInBoxPanel.SuspendLayout()
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
        switchToSignUpButton.BackColor = Color.FromArgb(CByte(107), CByte(163), CByte(202))
        switchToSignUpButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(163), CByte(202))
        switchToSignUpButton.FlatAppearance.BorderSize = 0
        switchToSignUpButton.FlatStyle = FlatStyle.Flat
        switchToSignUpButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        switchToSignUpButton.ForeColor = SystemColors.InfoText
        switchToSignUpButton.Location = New Point(155, 334)
        switchToSignUpButton.Name = "switchToSignUpButton"
        switchToSignUpButton.Size = New Size(137, 39)
        switchToSignUpButton.TabIndex = 8
        switchToSignUpButton.Text = "SIGN UP"
        switchToSignUpButton.UseVisualStyleBackColor = False
        switchToSignUpButton.Visible = False
        ' 
        ' switchLabel
        ' 
        switchLabel.AutoSize = True
        switchLabel.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        switchLabel.ForeColor = SystemColors.ButtonHighlight
        switchLabel.Location = New Point(119, 306)
        switchLabel.Name = "switchLabel"
        switchLabel.Size = New Size(215, 24)
        switchLabel.TabIndex = 7
        switchLabel.Text = "Already have an account?"
        ' 
        ' switchToLoginButton
        ' 
        switchToLoginButton.BackColor = Color.FromArgb(CByte(107), CByte(163), CByte(202))
        switchToLoginButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(107), CByte(163), CByte(202))
        switchToLoginButton.FlatAppearance.BorderSize = 0
        switchToLoginButton.FlatStyle = FlatStyle.Flat
        switchToLoginButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        switchToLoginButton.Location = New Point(155, 334)
        switchToLoginButton.Name = "switchToLoginButton"
        switchToLoginButton.Size = New Size(137, 39)
        switchToLoginButton.TabIndex = 6
        switchToLoginButton.Text = "LOGIN"
        switchToLoginButton.UseVisualStyleBackColor = False
        ' 
        ' passwordSignUpBox
        ' 
        passwordSignUpBox.BorderStyle = BorderStyle.None
        passwordSignUpBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordSignUpBox.Location = New Point(11, 9)
        passwordSignUpBox.Name = "passwordSignUpBox"
        passwordSignUpBox.Size = New Size(246, 25)
        passwordSignUpBox.TabIndex = 1
        passwordSignUpBox.Tag = ""
        passwordSignUpBox.UseSystemPasswordChar = True
        ' 
        ' emailSignUpBox
        ' 
        emailSignUpBox.BorderStyle = BorderStyle.None
        emailSignUpBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailSignUpBox.Location = New Point(11, 8)
        emailSignUpBox.Name = "emailSignUpBox"
        emailSignUpBox.PlaceholderText = "Email"
        emailSignUpBox.Size = New Size(246, 25)
        emailSignUpBox.TabIndex = 3
        ' 
        ' confirmPasswordSignUpBox
        ' 
        confirmPasswordSignUpBox.BorderStyle = BorderStyle.None
        confirmPasswordSignUpBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        confirmPasswordSignUpBox.Location = New Point(11, 9)
        confirmPasswordSignUpBox.Name = "confirmPasswordSignUpBox"
        confirmPasswordSignUpBox.Size = New Size(246, 25)
        confirmPasswordSignUpBox.TabIndex = 4
        confirmPasswordSignUpBox.Tag = ""
        confirmPasswordSignUpBox.UseSystemPasswordChar = True
        ' 
        ' signUpButton
        ' 
        signUpButton.BackColor = Color.FromArgb(CByte(54), CByte(116), CByte(181))
        signUpButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(54), CByte(116), CByte(181))
        signUpButton.FlatAppearance.BorderSize = 0
        signUpButton.FlatStyle = FlatStyle.Flat
        signUpButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        signUpButton.ForeColor = Color.White
        signUpButton.Location = New Point(141, 445)
        signUpButton.Name = "signUpButton"
        signUpButton.Size = New Size(137, 43)
        signUpButton.TabIndex = 5
        signUpButton.Text = "Sign up"
        signUpButton.UseVisualStyleBackColor = False
        ' 
        ' usernameLoginBox
        ' 
        usernameLoginBox.BorderStyle = BorderStyle.None
        usernameLoginBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameLoginBox.Location = New Point(11, 8)
        usernameLoginBox.Name = "usernameLoginBox"
        usernameLoginBox.PlaceholderText = "Username"
        usernameLoginBox.Size = New Size(246, 25)
        usernameLoginBox.TabIndex = 6
        usernameLoginBox.Text = "Jestaly14"
        ' 
        ' passwordLoginBox
        ' 
        passwordLoginBox.BorderStyle = BorderStyle.None
        passwordLoginBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordLoginBox.Location = New Point(11, 8)
        passwordLoginBox.Name = "passwordLoginBox"
        passwordLoginBox.Size = New Size(246, 25)
        passwordLoginBox.TabIndex = 7
        passwordLoginBox.Tag = ""
        passwordLoginBox.UseSystemPasswordChar = True
        ' 
        ' loginButton
        ' 
        loginButton.BackColor = Color.FromArgb(CByte(54), CByte(116), CByte(181))
        loginButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(54), CByte(116), CByte(181))
        loginButton.FlatAppearance.BorderSize = 0
        loginButton.FlatStyle = FlatStyle.Flat
        loginButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginButton.ForeColor = Color.White
        loginButton.Location = New Point(605, 375)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(124, 39)
        loginButton.TabIndex = 8
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = False
        loginButton.Visible = False
        ' 
        ' forgotPassword
        ' 
        forgotPassword.AutoSize = True
        forgotPassword.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        forgotPassword.LinkColor = Color.Black
        forgotPassword.Location = New Point(537, 328)
        forgotPassword.Name = "forgotPassword"
        forgotPassword.Size = New Size(138, 22)
        forgotPassword.TabIndex = 9
        forgotPassword.TabStop = True
        forgotPassword.Text = "Forgot Password?"
        forgotPassword.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' usernameTextNotifier
        ' 
        usernameTextNotifier.AutoSize = True
        usernameTextNotifier.Font = New Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameTextNotifier.Location = New Point(85, 198)
        usernameTextNotifier.Name = "usernameTextNotifier"
        usernameTextNotifier.Size = New Size(0, 20)
        usernameTextNotifier.TabIndex = 10
        ' 
        ' emailTextNotifier
        ' 
        emailTextNotifier.AutoSize = True
        emailTextNotifier.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailTextNotifier.Location = New Point(86, 270)
        emailTextNotifier.Name = "emailTextNotifier"
        emailTextNotifier.Size = New Size(0, 22)
        emailTextNotifier.TabIndex = 11
        ' 
        ' passwordTextNotifier
        ' 
        passwordTextNotifier.AutoSize = True
        passwordTextNotifier.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordTextNotifier.Location = New Point(86, 340)
        passwordTextNotifier.Name = "passwordTextNotifier"
        passwordTextNotifier.Size = New Size(0, 22)
        passwordTextNotifier.TabIndex = 12
        ' 
        ' confirmPasswordTextNotifier
        ' 
        confirmPasswordTextNotifier.AutoSize = True
        confirmPasswordTextNotifier.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        confirmPasswordTextNotifier.Location = New Point(86, 412)
        confirmPasswordTextNotifier.Name = "confirmPasswordTextNotifier"
        confirmPasswordTextNotifier.Size = New Size(0, 22)
        confirmPasswordTextNotifier.TabIndex = 13
        ' 
        ' usernameSignUpBox
        ' 
        usernameSignUpBox.BorderStyle = BorderStyle.None
        usernameSignUpBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameSignUpBox.Location = New Point(11, 8)
        usernameSignUpBox.Name = "usernameSignUpBox"
        usernameSignUpBox.PlaceholderText = "Username"
        usernameSignUpBox.Size = New Size(246, 25)
        usernameSignUpBox.TabIndex = 14
        ' 
        ' usernameSignUpBoxPanel
        ' 
        usernameSignUpBoxPanel.BackColor = SystemColors.Window
        usernameSignUpBoxPanel.Controls.Add(usernameSignUpBox)
        usernameSignUpBoxPanel.Location = New Point(82, 153)
        usernameSignUpBoxPanel.Name = "usernameSignUpBoxPanel"
        usernameSignUpBoxPanel.Size = New Size(265, 42)
        usernameSignUpBoxPanel.TabIndex = 15
        ' 
        ' emailSignUpBoxPanel
        ' 
        emailSignUpBoxPanel.BackColor = SystemColors.Window
        emailSignUpBoxPanel.Controls.Add(emailSignUpBox)
        emailSignUpBoxPanel.Location = New Point(82, 225)
        emailSignUpBoxPanel.Name = "emailSignUpBoxPanel"
        emailSignUpBoxPanel.Size = New Size(265, 42)
        emailSignUpBoxPanel.TabIndex = 16
        ' 
        ' passwordSignUpBoxPanel
        ' 
        passwordSignUpBoxPanel.BackColor = SystemColors.Window
        passwordSignUpBoxPanel.Controls.Add(disappearingPassSignUpLabel)
        passwordSignUpBoxPanel.Controls.Add(passwordSignUpBox)
        passwordSignUpBoxPanel.Location = New Point(83, 297)
        passwordSignUpBoxPanel.Name = "passwordSignUpBoxPanel"
        passwordSignUpBoxPanel.Size = New Size(265, 42)
        passwordSignUpBoxPanel.TabIndex = 17
        ' 
        ' disappearingPassSignUpLabel
        ' 
        disappearingPassSignUpLabel.AutoSize = True
        disappearingPassSignUpLabel.BackColor = Color.Transparent
        disappearingPassSignUpLabel.Cursor = Cursors.IBeam
        disappearingPassSignUpLabel.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        disappearingPassSignUpLabel.ForeColor = Color.DimGray
        disappearingPassSignUpLabel.Location = New Point(9, 9)
        disappearingPassSignUpLabel.Name = "disappearingPassSignUpLabel"
        disappearingPassSignUpLabel.Size = New Size(88, 24)
        disappearingPassSignUpLabel.TabIndex = 19
        disappearingPassSignUpLabel.Text = "Password"
        ' 
        ' confirmPasswordSignUpBoxPanel
        ' 
        confirmPasswordSignUpBoxPanel.BackColor = SystemColors.Window
        confirmPasswordSignUpBoxPanel.Controls.Add(disappearingConfirmPassSignUpLabel)
        confirmPasswordSignUpBoxPanel.Controls.Add(confirmPasswordSignUpBox)
        confirmPasswordSignUpBoxPanel.Location = New Point(83, 367)
        confirmPasswordSignUpBoxPanel.Name = "confirmPasswordSignUpBoxPanel"
        confirmPasswordSignUpBoxPanel.Size = New Size(265, 42)
        confirmPasswordSignUpBoxPanel.TabIndex = 18
        ' 
        ' disappearingConfirmPassSignUpLabel
        ' 
        disappearingConfirmPassSignUpLabel.AutoSize = True
        disappearingConfirmPassSignUpLabel.BackColor = Color.Transparent
        disappearingConfirmPassSignUpLabel.Cursor = Cursors.IBeam
        disappearingConfirmPassSignUpLabel.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        disappearingConfirmPassSignUpLabel.ForeColor = Color.DimGray
        disappearingConfirmPassSignUpLabel.Location = New Point(10, 9)
        disappearingConfirmPassSignUpLabel.Name = "disappearingConfirmPassSignUpLabel"
        disappearingConfirmPassSignUpLabel.Size = New Size(155, 24)
        disappearingConfirmPassSignUpLabel.TabIndex = 20
        disappearingConfirmPassSignUpLabel.Text = "Confirm Password"
        ' 
        ' usernameLogInBoxPanel
        ' 
        usernameLogInBoxPanel.BackColor = SystemColors.Window
        usernameLogInBoxPanel.Controls.Add(usernameLoginBox)
        usernameLogInBoxPanel.Location = New Point(534, 221)
        usernameLogInBoxPanel.Name = "usernameLogInBoxPanel"
        usernameLogInBoxPanel.Size = New Size(265, 42)
        usernameLogInBoxPanel.TabIndex = 16
        usernameLogInBoxPanel.Visible = False
        ' 
        ' passwordLogInBoxPanel
        ' 
        passwordLogInBoxPanel.BackColor = SystemColors.Window
        passwordLogInBoxPanel.Controls.Add(disappearingPassLogInLabel)
        passwordLogInBoxPanel.Controls.Add(passwordLoginBox)
        passwordLogInBoxPanel.Location = New Point(534, 282)
        passwordLogInBoxPanel.Name = "passwordLogInBoxPanel"
        passwordLogInBoxPanel.Size = New Size(265, 42)
        passwordLogInBoxPanel.TabIndex = 17
        passwordLogInBoxPanel.Visible = False
        ' 
        ' disappearingPassLogInLabel
        ' 
        disappearingPassLogInLabel.AutoSize = True
        disappearingPassLogInLabel.BackColor = Color.Transparent
        disappearingPassLogInLabel.Cursor = Cursors.IBeam
        disappearingPassLogInLabel.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        disappearingPassLogInLabel.ForeColor = Color.DimGray
        disappearingPassLogInLabel.Location = New Point(11, 9)
        disappearingPassLogInLabel.Name = "disappearingPassLogInLabel"
        disappearingPassLogInLabel.Size = New Size(88, 24)
        disappearingPassLogInLabel.TabIndex = 20
        disappearingPassLogInLabel.Text = "Password"
        ' 
        ' StartingForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(107), CByte(163), CByte(202))
        ClientSize = New Size(882, 653)
        Controls.Add(slideContainer)
        Controls.Add(passwordLogInBoxPanel)
        Controls.Add(usernameLogInBoxPanel)
        Controls.Add(confirmPasswordSignUpBoxPanel)
        Controls.Add(passwordSignUpBoxPanel)
        Controls.Add(emailSignUpBoxPanel)
        Controls.Add(confirmPasswordTextNotifier)
        Controls.Add(passwordTextNotifier)
        Controls.Add(emailTextNotifier)
        Controls.Add(usernameTextNotifier)
        Controls.Add(forgotPassword)
        Controls.Add(loginButton)
        Controls.Add(signUpButton)
        Controls.Add(usernameSignUpBoxPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "StartingForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Start"
        slideContainer.ResumeLayout(False)
        slideContainer.PerformLayout()
        usernameSignUpBoxPanel.ResumeLayout(False)
        usernameSignUpBoxPanel.PerformLayout()
        emailSignUpBoxPanel.ResumeLayout(False)
        emailSignUpBoxPanel.PerformLayout()
        passwordSignUpBoxPanel.ResumeLayout(False)
        passwordSignUpBoxPanel.PerformLayout()
        confirmPasswordSignUpBoxPanel.ResumeLayout(False)
        confirmPasswordSignUpBoxPanel.PerformLayout()
        usernameLogInBoxPanel.ResumeLayout(False)
        usernameLogInBoxPanel.PerformLayout()
        passwordLogInBoxPanel.ResumeLayout(False)
        passwordLogInBoxPanel.PerformLayout()
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
    Friend WithEvents usernameSignUpBox As TextBox
    Friend WithEvents usernameSignUpBoxPanel As Panel
    Friend WithEvents emailSignUpBoxPanel As Panel
    Friend WithEvents passwordSignUpBoxPanel As Panel
    Friend WithEvents confirmPasswordSignUpBoxPanel As Panel
    Friend WithEvents disappearingPassSignUpLabel As Label
    Friend WithEvents disappearingConfirmPassSignUpLabel As Label
    Friend WithEvents usernameLogInBoxPanel As Panel
    Friend WithEvents passwordLogInBoxPanel As Panel
    Friend WithEvents disappearingPassLogInLabel As Label

End Class
