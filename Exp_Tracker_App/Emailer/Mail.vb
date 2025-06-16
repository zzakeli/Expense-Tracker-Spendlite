Imports System.Net.Mail
Imports System.Text

Public Class Mail

    Private passCode As String = ""
    Private resetCode As String = ""

    Public Function resetMe(email As String) As String
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False

            Smtp_Server.Credentials = New Net.NetworkCredential("plp.unisystem@gmail.com", "nxhy jzrh fhda uzcl")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("plp.unisystem@gmail.com", "SpendLite")

            e_mail.To.Add(email)

            e_mail.Subject = "Reset Password"
            e_mail.IsBodyHtml = True

            resetCode = generatePassCode(6)

            Dim htmlBody As String = "
                                    <html>
                                        <body style='font-family: Arial, sans-serif; padding: 20px; background-color: #f9f9f9;'>
                                            <div style='max-width: 500px; margin: auto; background: white; padding: 30px; border-radius: 8px; box-shadow: 0 2px 5px rgba(0,0,0,0.1);'>
                                                <h2 style='color: #2e6da4;'>Password Reset Request</h2>
                                                <p>Hi,</p>
                                                <p>We received a request to reset your password. Use the code below to reset it:</p>
                                                <div style='text-align: center; font-size: 24px; font-weight: bold; color: #d9534f; margin: 20px 0;'>
                                                    " & resetCode & "
                                                </div>
                                                <p>If you did not request a password reset, you can safely ignore this email.</p>
                                                <p>Regards,<br><b>SpendLite Team</b></p>
                                            </div>
                                        </body>
                                    </html>"

            e_mail.Body = htmlBody
            'MsgBox(passCode)
            Smtp_Server.Send(e_mail)

            'MessageBox.Show("Check your email for verification.", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

        Return resetCode
    End Function
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
            e_mail.From = New MailAddress("plp.unisystem@gmail.com", "SpendLite")

            e_mail.To.Add(email)

            e_mail.Subject = "Email Verification"
            e_mail.IsBodyHtml = True

            passCode = generatePassCode(6)

            Dim htmlBody As String = "
                                    <html>
                                        <body style='font-family: Arial, sans-serif; padding: 20px; background-color: #f4f4f4;'>
                                            <div style='max-width: 500px; margin: auto; background: white; padding: 30px; border-radius: 8px; box-shadow: 0 2px 5px rgba(0,0,0,0.1);'>
                                                <h2 style='color: #5cb85c;'>Your Verification Code</h2>
                                                <p>Hello,</p>
                                                <p>Your passcode has been generated. Use the code below to proceed:</p>
                                                <div style='text-align: center; font-size: 24px; font-weight: bold; color: #0275d8; margin: 20px 0;'>
                                                    " & passCode & "
                                                </div>
                                                <p>Please do not share this code with anyone.</p>
                                                <p>Thank you,<br><b>SpendLite Team</b></p>
                                            </div>
                                        </body>
                                    </html>"

            e_mail.Body = htmlBody
            'MsgBox(passCode)
            Smtp_Server.Send(e_mail)


            MessageBox.Show("Check you email for verification code.", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

        Return passCode
    End Function

    Public Function getPassCode()
        Return passCode
    End Function

    Public Function getResetCode()
        Return resetCode
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
