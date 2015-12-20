Imports System.Net.Mail
Imports System.Net

Public Class SMTPControl
    Public Sub ForgotPassowrd(Password As String)
        Dim mail As New MailMessage()
        mail.From = New MailAddress("employment.agency@yandex.ru")
        mail.To.Add("irina.blagun@gmail.com")
        mail.Subject = "Восстановление пароля"
        mail.Body = "Ваш пароль: " & Password
        Dim smtp As New SmtpClient("smtp.yandex.ru", 25)
        smtp.EnableSsl = True
        smtp.Credentials = New NetworkCredential("employment.agency@yandex.ru", "281195271196")
        smtp.Send(mail)
    End Sub
End Class
