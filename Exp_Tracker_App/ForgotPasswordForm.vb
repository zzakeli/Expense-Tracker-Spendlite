Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions

Public Class ForgotPasswordForm
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
        emailBoxPanel.Visible = False
        verifyButton.Visible = False
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        emailBox.Text = ""
        Me.Visible = False
    End Sub
End Class