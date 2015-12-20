Public Class Employer
    Inherits BasicActions

    Public Sub New(Table As Object)
        MyBase.New(Table, "SELECT id_employer As 'Номер', er_name As 'Название', er_phone As 'Телефон', er_email As 'E-mail', er_adress As 'Адрес' FROM employer")
    End Sub

    Public Sub Add(Name As String, Phone As String, Email As String, Adress As String)
        Dim Query As String = "INSERT INTO employer (er_name, er_phone, er_email, er_adress) VALUES ('" & Name & "', '" & Phone & "', '" & Email & "', '" & Adress & "')"
        RunQueryAndUpdate(Query, "ОК", "Просто жесть")
    End Sub

    Public Sub Update(Name As String, Phone As String, Email As String, Adress As String)
        Dim Query As String = "UPDATE employer SET employer.er_name = '" & Name & "', employer.er_phone='" & Phone & "', employer.er_email='" & Email & "', employer.er_adress='" & Adress & "' WHERE employer.id_employer='" & Me.getCellSelectedRow(0) & "'"
        RunQueryAndUpdate(Query, "ОК", "Просто жесть")
    End Sub

    Public Sub Delete()
        Dim ID As String = getCellSelectedRow(0)
        Dim Query As String = "DELETE FROM employer WHERE id_employer = '" & ID & "'"
        RunQueryAndUpdate(Query, "Работодатель удалён", "Ошибочка вышла")
    End Sub
End Class
