Imports System.Data.SqlClient

Public Class Seeker
    Inherits BasicActions

    Public Sub New(Table As Object)
        MyBase.New(Table, "SELECT id_seeker As 'Номер', sr_name As 'ФИО', sr_phone As 'Телефон', sr_info As 'Информация', sr_email As 'E-mail' FROM seeker")
    End Sub

    Public Sub Add(Name As String, Phone As String, Info As String, Email As String)
        Dim Query As String = "INSERT INTO seeker (sr_name, sr_phone, sr_info, sr_email) VALUES ('" & Name & "', '" & Phone & "', '" & Info & "', '" & Email & "')"
        RunQueryAndUpdate(Query, "Просто жесть")
    End Sub

    Public Sub Update(Name As String, Phone As String, Info As String, Email As String)
        Dim Query As String = "UPDATE seeker Set seeker.sr_name = '" & Name & "', seeker.sr_phone = '" & Phone & "', seeker.sr_info = '" & Info & "', seeker.sr_email = '" & Email & "' WHERE id_seeker = '" & Me.getCellSelectedRow(0) & "'"
        RunQueryAndUpdate(Query, "Просто жесть")
    End Sub

    Public Sub Delete()
        Dim Query As String = "DELETE FROM seeker WHERE id_seeker = '" & Me.getCellSelectedRow(0) & "'"
        RunQueryAndUpdate(Query, "Ошибочка вышла")
    End Sub

End Class