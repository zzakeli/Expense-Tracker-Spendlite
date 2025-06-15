Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class ForgotPasswordForm
    Private connector As New DatabaseConnector

    Private forgotPasswordOTPForm As ForgotPasswordOTPForm
    Private mailer As Mail
    Public Sub New(forgotPasswordOTPForm As ForgotPasswordOTPForm, mailer As Mail)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.forgotPasswordOTPForm = forgotPasswordOTPForm
        Me.mailer = mailer
    End Sub
    Private Sub emailBox_TextChanged(sender As Object, e As EventArgs) Handles emailBox.TextChanged
        If (emailBox.Text = "" Or Not IsValidEmail(emailBox.Text)) Then
            emailBox.BackColor = Color.LightPink
            emailBoxPanel.BackColor = Color.LightPink
        Else
            emailBox.BackColor = Color.White
            emailBoxPanel.BackColor = Color.White
        End If
    End Sub

    Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, pattern)
    End Function

    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundControlCorners(emailBoxPanel, 15)
        roundControlCorners(verifyButton, 40)
        roundControlCorners(cancelButton, 40)
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

    Private Sub verifyButton_Click(sender As Object, e As EventArgs) Handles verifyButton.Click
        'emailBoxPanel.Visible = False
        'verifyButton.Visible = False
        Dim email As String = emailBox.Text.ToString().Trim()

        If (email = "") Then
            MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            emailBox.BackColor = Color.LightPink
            emailBoxPanel.BackColor = Color.LightPink
            Return
        Else
            emailBox.BackColor = Color.White
            emailBoxPanel.BackColor = Color.White
        End If
        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            emailBox.BackColor = Color.LightPink
            emailBoxPanel.BackColor = Color.LightPink
            Return
        Else
            emailBox.BackColor = Color.White
            emailBoxPanel.BackColor = Color.White
        End If

        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS existing_email FROM user WHERE email = '" & email & "';"
            connector.command.CommandText = connector.query
            connector.command.Connection = connector.connect
            connector.reader = connector.command.ExecuteReader()

            If connector.reader.Read() Then
                Dim existingEmailCount As Integer = Convert.ToInt32(connector.reader("existing_email"))
                If existingEmailCount = 0 Then
                    MessageBox.Show("This email address is not registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    emailBox.BackColor = Color.LightPink
                    emailBoxPanel.BackColor = Color.LightPink
                    connector.connect.Close()
                    Return
                Else
                    emailBox.BackColor = Color.White
                    emailBoxPanel.BackColor = Color.White
                End If
            End If

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
        End Try

        mailer.resetMe(email)
        forgotPasswordOTPForm.setEmail(email)

        emailBox.Text = ""
        emailBoxPanel.BackColor = Color.White
        emailBox.BackColor = Color.White

        MessageBox.Show("Password reset verification code was sent to your email.")
        Me.Visible = False
        forgotPasswordOTPForm.Visible = True
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        emailBox.Text = ""
        emailBoxPanel.BackColor = Color.White
        emailBox.BackColor = Color.White
        Me.Visible = False
    End Sub
End Class