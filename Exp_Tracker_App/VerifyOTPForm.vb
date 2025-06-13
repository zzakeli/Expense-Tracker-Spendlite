Imports MySql.Data.MySqlClient

Public Class VerifyOTPForm
    Private connector As New DatabaseConnector

    Private usernameSignUpBox As TextBox
    Private emailSignUpBox As TextBox
    Private passwordSignUpBox As MaskedTextBox
    Private confirmPasswordSignUpBox As MaskedTextBox

    Private usernameSignUpBoxPanel As Panel
    Private emailSignUpBoxPanel As Panel
    Private passwordSignUpBoxPanel As Panel
    Private confirmPasswordSignUpBoxPanel As Panel

    Private usernameTextNotifier As Label
    Private emailTextNotifier As Label
    Private passwordTextNotifier As Label
    Private confirmPasswordTextNotifier As Label

    Private signUpButton As Button

    Private switchToLoginButton As Button

    Private mailer As Mail

    Public Sub New(usernameSignUpBox As TextBox, emailSignUpBox As TextBox,
                   passwordSignUpBox As MaskedTextBox, confirmPasswordSignUpBox As MaskedTextBox,
                   usernameTextNotifier As Label, emailTextNotifier As Label, passwordTextNotifier As Label,
                   confirmPasswordTextNotifier As Label, signUpButton As Button, mailer As Mail, usernameSignUpBoxPanel As Panel,
                   emailSignUpBoxPanel As Panel, passwordSignUpBoxPanel As Panel, confirmPasswordSignUpBoxPanel As Panel, switchToLoginButton As Button)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.usernameSignUpBox = usernameSignUpBox
        Me.emailSignUpBox = emailSignUpBox
        Me.passwordSignUpBox = passwordSignUpBox
        Me.confirmPasswordSignUpBox = confirmPasswordSignUpBox

        Me.usernameSignUpBoxPanel = usernameSignUpBoxPanel
        Me.emailSignUpBoxPanel = emailSignUpBoxPanel
        Me.passwordSignUpBoxPanel = passwordSignUpBoxPanel
        Me.confirmPasswordSignUpBoxPanel = confirmPasswordSignUpBoxPanel

        Me.usernameTextNotifier = usernameTextNotifier
        Me.emailTextNotifier = emailTextNotifier
        Me.passwordTextNotifier = passwordTextNotifier
        Me.confirmPasswordTextNotifier = confirmPasswordTextNotifier

        Me.signUpButton = signUpButton

        Me.switchToLoginButton = switchToLoginButton

        Me.mailer = mailer
    End Sub
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        resetDigitBoxes()
        showSignUpComponents()

        Me.Visible = False
    End Sub

    Private Sub resetDigitBoxes()
        digitBox1.Text = ""
        digitBox2.Text = ""
        digitBox3.Text = ""
        digitBox4.Text = ""
        digitBox5.Text = ""
        digitBox6.Text = ""
    End Sub

    Private Sub showSignUpComponents()
        usernameSignUpBox.Visible = True
        emailSignUpBox.Visible = True
        passwordSignUpBox.Visible = True
        confirmPasswordSignUpBox.Visible = True

        usernameSignUpBoxPanel.Visible = True
        emailSignUpBoxPanel.Visible = True
        passwordSignUpBoxPanel.Visible = True
        confirmPasswordSignUpBoxPanel.Visible = True

        usernameTextNotifier.Visible = True
        emailTextNotifier.Visible = True
        passwordTextNotifier.Visible = True
        confirmPasswordTextNotifier.Visible = True

        signUpButton.Visible = True
    End Sub

    Private Sub otpBox_KeyPress(sender As Object, e As KeyPressEventArgs) _
    Handles digitBox1.KeyPress, digitBox2.KeyPress, digitBox3.KeyPress, digitBox4.KeyPress, digitBox5.KeyPress, digitBox6.KeyPress

        Dim currentBox As TextBox = DirectCast(sender, TextBox)

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Return
        End If

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            currentBox.Text = e.KeyChar.ToString()

            Select Case currentBox.Name
                Case "digitBox1" : digitBox2.Focus()
                Case "digitBox2" : digitBox3.Focus()
                Case "digitBox3" : digitBox4.Focus()
                Case "digitBox4" : digitBox5.Focus()
                Case "digitBox5" : digitBox6.Focus()
                Case "digitBox6" : verifyButton.Focus()
            End Select
        End If
    End Sub

    Private Sub otpBox_KeyDown(sender As Object, e As KeyEventArgs) _
    Handles digitBox1.KeyDown, digitBox2.KeyDown, digitBox3.KeyDown, digitBox4.KeyDown, digitBox5.KeyDown, digitBox6.KeyDown

        Dim currentBox As TextBox = DirectCast(sender, TextBox)

        If e.KeyCode = Keys.Back AndAlso currentBox.Text = "" Then
            Select Case currentBox.Name
                Case "digitBox2" : digitBox1.Focus()
                Case "digitBox3" : digitBox2.Focus()
                Case "digitBox4" : digitBox3.Focus()
                Case "digitBox5" : digitBox4.Focus()
                Case "digitBox6" : digitBox5.Focus()
            End Select
        End If
    End Sub

    Private Sub signUpUser()
        Dim username = usernameSignUpBox.Text.ToString()
        Dim email = emailSignUpBox.Text.ToString()
        Dim password = passwordSignUpBox.Text.ToString()
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO user(username, email, password) VALUES ('" & username & "','" & email & "','" & password & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from inserting user.")
        End Try
    End Sub

    Private Sub resetSignUpFields()
        usernameSignUpBox.Text = ""
        emailSignUpBox.Text = ""
        passwordSignUpBox.Text = ""
        confirmPasswordSignUpBox.Text = ""

        usernameSignUpBox.BackColor = Color.White
        emailSignUpBox.BackColor = Color.White
        passwordSignUpBox.BackColor = Color.White
        confirmPasswordSignUpBox.BackColor = Color.White

        usernameSignUpBoxPanel.BackColor = Color.White
        emailSignUpBoxPanel.BackColor = Color.White
        passwordSignUpBoxPanel.BackColor = Color.White
        confirmPasswordSignUpBoxPanel.BackColor = Color.White

        usernameTextNotifier.Text = ""
        emailTextNotifier.Text = ""
        passwordTextNotifier.Text = ""
        confirmPasswordTextNotifier.Text = ""
    End Sub

    Private Sub verifyButton_Click(sender As Object, e As EventArgs) Handles verifyButton.Click
        Dim fullOTP As String = digitBox1.Text & digitBox2.Text &
            digitBox3.Text & digitBox4.Text & digitBox5.Text & digitBox6.Text

        If (mailer.getPassCode() = fullOTP) Then
            MessageBox.Show("OTP verified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Visible = False
            showSignUpComponents()

            signUpUser()

            switchToLoginButton.Enabled = True

            resetSignUpFields()
        Else
            MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class