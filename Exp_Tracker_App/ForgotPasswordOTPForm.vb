
Public Class ForgotPasswordOTPForm

    Private mailer As Mail
    Private passwordResetForm As PasswordResetForm
    Private connector As DatabaseConnector
    Private email As String
    Public Sub New(mailer As Mail, passwordResetForm As PasswordResetForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.mailer = mailer
        Me.passwordResetForm = passwordResetForm
    End Sub
    Private Sub ForgotPasswordOTPForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub setEmail(email As String)
        Me.email = email
    End Sub

    Public Function getEmail() As String
        Return email
    End Function

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

    Private Sub verifyButton_Click(sender As Object, e As EventArgs) Handles verifyButton.Click
        Dim fullOTP As String = digitBox1.Text & digitBox2.Text &
            digitBox3.Text & digitBox4.Text & digitBox5.Text & digitBox6.Text

        If (mailer.getResetCode() = fullOTP) Then
            Me.Visible = False
            passwordResetForm.setEmail(getEmail())
            passwordResetForm.Visible = True
            resetDigitBox()
        Else
            MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            digitBox1.BackColor = Color.LightPink
            digitBox2.BackColor = Color.LightPink
            digitBox3.BackColor = Color.LightPink
            digitBox4.BackColor = Color.LightPink
            digitBox5.BackColor = Color.LightPink
            digitBox6.BackColor = Color.LightPink
        End If
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        resetDigitBox()
        Me.Visible = False
    End Sub

    Private Sub resetDigitBox()
        digitBox1.Text = ""
        digitBox2.Text = ""
        digitBox3.Text = ""
        digitBox4.Text = ""
        digitBox5.Text = ""
        digitBox6.Text = ""

        digitBox1.BackColor = Color.White
        digitBox2.BackColor = Color.White
        digitBox3.BackColor = Color.White
        digitBox4.BackColor = Color.White
        digitBox5.BackColor = Color.White
        digitBox6.BackColor = Color.White
    End Sub
End Class