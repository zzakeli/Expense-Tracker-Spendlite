Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Public Class PasswordResetForm
    Private connector As New DatabaseConnector
    Private email As String

    Private Sub PasswordResetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundControlCorners(passwordBoxPanel, 15)
        roundControlCorners(confirmPasswordBoxPanel, 15)
        roundControlCorners(resetButton, 40)
        roundControlCorners(cancelButton, 40)
    End Sub

    Private Sub passwordBox_TextChanged(sender As Object, e As EventArgs) Handles passwordBox.TextChanged
        validatePassword()
    End Sub

    Private Sub confirmPasswordBox_TextChanged(sender As Object, e As EventArgs) Handles confirmPasswordBox.TextChanged
        validateConfirmPassword()
    End Sub

    Private Sub validatePassword()
        Dim password As String = passwordBox.Text

        If String.IsNullOrEmpty(password) Then
            showValidationError("Password cannot be empty.", passwordBox, passwordNotifier, passwordBoxPanel)
            Exit Sub
        End If

        If password.Length < 8 Then
            showValidationError("Password must be at least 8 characters long.", passwordBox, passwordNotifier, passwordBoxPanel)
            Exit Sub
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") OrElse Not System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") OrElse Not System.Text.RegularExpressions.Regex.IsMatch(password, "[0-9]") Then
            showValidationError("Include 1 lowercase, uppercase letter, and 1 number.", passwordBox, passwordNotifier, passwordBoxPanel)
            Exit Sub
        End If

        showValidationSuccess(passwordBox, passwordNotifier, passwordBoxPanel)
    End Sub

    Private Sub validateConfirmPassword()
        Dim confirmPassword = confirmPasswordBox.Text

        If String.IsNullOrEmpty(confirmPassword) Then
            showValidationError("Password cannot be empty.", confirmPasswordBox, confirmPassNotifier, confirmPasswordBoxPanel)
            Exit Sub
        End If

        If (Not passwordBox.Text = confirmPasswordBox.Text) Then
            showValidationError("Password does not match.", confirmPasswordBox, confirmPassNotifier, confirmPasswordBoxPanel)
            Exit Sub
        End If

        showValidationSuccess(confirmPasswordBox, confirmPassNotifier, confirmPasswordBoxPanel)
    End Sub

    'reusing this methods
    Private Sub showValidationError(message As String, textBox As MaskedTextBox, notifier As Label, panel As Panel)
        notifier.Text = message
        notifier.ForeColor = Color.Red
        textBox.BackColor = Color.LightPink
        panel.BackColor = Color.LightPink
    End Sub

    Private Sub showValidationSuccess(textBox As MaskedTextBox, notifier As Label, panel As Panel)
        notifier.Text = ""
        textBox.BackColor = Color.LightGreen
        panel.BackColor = Color.LightGreen
    End Sub

    Private Sub roundControlCorners(ctrl As Control, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        ctrl.Region = New Region(path)
    End Sub

    Public Sub setEmail(email As String)
        Me.email = email
    End Sub

    Public Function getEmail() As String
        Return email
    End Function

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        validatePassword()
        validateConfirmPassword()

        If passwordNotifier.Text = "" AndAlso
            confirmPassNotifier.Text = "" Then
            Dim password As String = confirmPasswordBox.Text
            Dim email As String = getEmail()
            Try
                connector.connect.Open()
                connector.query = "UPDATE user SET password = '" & password & "' WHERE email = '" & email & "';"
                connector.command.CommandText = connector.query
                connector.command.Connection = connector.connect
                connector.command.ExecuteNonQuery()

                MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connector.connect.Close()
            Catch ex As MySqlException
                connector.connect.Close()
            End Try

            passwordBox.Text = ""
            confirmPasswordBox.Text = ""
            passwordBox.BackColor = Color.White
            confirmPasswordBox.BackColor = Color.White
            passwordBoxPanel.BackColor = Color.White
            confirmPasswordBoxPanel.BackColor = Color.White
            passwordNotifier.Text = ""
            confirmPassNotifier.Text = ""
            Me.Visible = False
        End If
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        passwordBox.Text = ""
        confirmPasswordBox.Text = ""
        passwordBox.BackColor = Color.White
        confirmPasswordBox.BackColor = Color.White
        passwordBoxPanel.BackColor = Color.White
        confirmPasswordBoxPanel.BackColor = Color.White
        passwordNotifier.Text = ""
        confirmPassNotifier.Text = ""
        Me.Visible = False
    End Sub

    Private Sub disappearingPassResetLabel_Click(sender As Object, e As EventArgs) Handles disappearingPassResetLabel.Click
        disappearingPassResetLabel.Visible = False
        passwordBox.Focus()
    End Sub

    Private Sub passwordBox_Enter(sender As Object, e As EventArgs) Handles passwordBox.Enter
        disappearingPassResetLabel.Visible = False
    End Sub

    Private Sub passwordBox_Leave(sender As Object, e As EventArgs) Handles passwordBox.Leave
        If String.IsNullOrWhiteSpace(passwordBox.Text) Then
            disappearingPassResetLabel.Visible = True
        End If
    End Sub

    Private Sub disappearingConfirmPassResetLabel_Click(sender As Object, e As EventArgs) Handles disappearingConfirmPassResetLabel.Click
        disappearingConfirmPassResetLabel.Visible = False
        confirmPasswordBox.Focus()
    End Sub

    Private Sub confirmPasswordBox_Enter(sender As Object, e As EventArgs) Handles confirmPasswordBox.Enter
        disappearingConfirmPassResetLabel.Visible = False
    End Sub

    Private Sub confirmPasswordBox_Leave(sender As Object, e As EventArgs) Handles confirmPasswordBox.Leave
        If String.IsNullOrWhiteSpace(confirmPasswordBox.Text) Then
            disappearingConfirmPassResetLabel.Visible = True
        End If
    End Sub

End Class