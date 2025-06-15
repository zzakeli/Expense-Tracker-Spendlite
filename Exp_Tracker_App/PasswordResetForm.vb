Imports MySql.Data.MySqlClient
Public Class PasswordResetForm
    Private connector As New DatabaseConnector
    Private email As String

    Private Sub PasswordResetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub setEmail(email As String)
        Me.email = email
    End Sub

    Public Function getEmail() As String
        Return email
    End Function

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
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
        Me.Visible = False
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        passwordBox.Text = ""
        confirmPasswordBox.Text = ""
        Me.Visible = False
    End Sub
End Class