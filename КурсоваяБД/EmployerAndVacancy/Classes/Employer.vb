Imports System.IO

Public Class Employer
    Inherits BasicActions


    Public Sub New(Table As Object)
        MyBase.New(Table, "SELECT id_employer As 'Номер', er_name As 'Название', er_phone As 'Телефон', er_email As 'E-mail', er_adress As 'Адрес', er_logotype As 'Логотип' FROM employer")
    End Sub

    Public Sub Add(Name As String, Phone As String, Email As String, Adress As String, Image As String)
        Dim fs As FileStream = New FileStream(Image, FileMode.Open, FileAccess.Read)
        Dim br As BinaryReader = New BinaryReader(fs)
        Dim Img() As Byte = br.ReadBytes(fs.Length)

        Dim Query As String = "INSERT INTO employer (er_name, er_phone, er_email, er_adress, er_logotype) VALUES ('" & Name & "', '" & Phone & "', '" & Email & "', '" & Adress & "', @Img)"
        RunQueryWidthParametersAndUpdate(Query, "Просто жесть", Img)
    End Sub

    Public Sub Update(Name As String, Phone As String, Email As String, Adress As String, Image As String)
        Dim fs As FileStream = New FileStream(Image, FileMode.Open, FileAccess.Read)
        Dim br As BinaryReader = New BinaryReader(fs)
        Dim Img() As Byte = br.ReadBytes(fs.Length)

        Dim Query As String = "UPDATE employer SET employer.er_name = '" & Name & "', employer.er_phone='" & Phone & "', employer.er_email='" & Email & "', employer.er_adress='" & Adress & "', employer.er_logotype=@Img WHERE employer.id_employer='" & Me.getCellSelectedRow(0) & "'"
        RunQueryWidthParametersAndUpdate(Query, "Просто жесть", Img)
    End Sub

    Public Sub Delete()
        Dim ID As String = getCellSelectedRow(0)
        Dim Query As String = "DELETE FROM employer WHERE id_employer = '" & ID & "'"
        RunQueryAndUpdate(Query, "Ошибочка вышла")
    End Sub

    Public Function CheckEmployerName(Name As String)
        Dim Query As String = "SELECT er_name FROM employer WHERE employer.er_name = '" & Name & "'"
        Return MyBase.CheckValueOfTheUniqueness(Query)
    End Function
End Class
