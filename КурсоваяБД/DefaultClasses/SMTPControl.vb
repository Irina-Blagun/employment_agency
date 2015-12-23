Imports System.Net.Mail
Imports System.Net

Public Module SMTPControl
    Public Sub SendEmail(Add As String, Subject As String, Body As String)
        MsgBox(Add)
        MsgBox(Subject)
        MsgBox(Body)
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("employment.agency@yandex.ru")
            mail.To.Add(Add)
            mail.Subject = Subject
            mail.Body = Body
            Dim smtp As New SmtpClient("smtp.yandex.ru", 25)
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential("employment.agency@yandex.ru", "281195271196")
            smtp.Send(mail)
            MsgBox("Отправлено")
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

End Module
