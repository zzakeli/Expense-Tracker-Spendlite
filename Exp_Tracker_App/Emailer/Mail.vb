Imports System.Net.Mail
Imports System.Text

Public Class Mail

    Private passCode As String = ""
    Public Function mailMe(email As String) As String
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False

            Smtp_Server.Credentials = New Net.NetworkCredential("plp.unisystem@gmail.com", "nxhy jzrh fhda uzcl")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("plp.unisystem@gmail.com")

            e_mail.To.Add(email)

            e_mail.Subject = "Generated PassCode"
            e_mail.IsBodyHtml = False

            passCode = generatePassCode(6)
            e_mail.Body = "Your PassCode is: " & passCode
            'MsgBox(passCode)
            Smtp_Server.Send(e_mail)

            MessageBox.Show("Sign up successful! Email sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

        Return passCode
    End Function

    Public Function getPassCode()
        Return passCode
    End Function
    Public Function generatePassCode(length As Integer) As String
        Dim characters As String = "0123456789"
        Dim result As New StringBuilder()
        Dim random As New Random()

        For i As Integer = 1 To length
            Dim index As Integer = random.Next(0, characters.Length)
            result.Append(characters(index))
        Next

        Return result.ToString()
    End Function
End Class
