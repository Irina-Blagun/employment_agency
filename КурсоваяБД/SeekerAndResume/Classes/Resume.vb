Public Class Resumes
    Inherits DependentActions

    Public Sub New(Table As Object)
        MyBase.New(Table)
    End Sub


    Public Sub RenderTable(ID As String)
        Dim Query As String = "SELECT id_resume As 'Номер', re_creation_date As 'Дата создания', re_activity As 'Вид деятельности', re_office As 'Должность', re_min_salary As 'Заработная плата', re_sex As 'Пол', re_age As 'Возраст',  re_education As 'Образование', re_experience As 'Опыт работы', re_employment As 'Занятость', re_schedule As 'График работы', re_social_package As 'Соц. пакет' FROM resume WHERE id_seeker = '" & ID & "'"
        MyBase.RenderDataset(Query)
    End Sub

    Public Sub Delete()
        Dim ID As String = getCellSelectedRow(0)
        Dim Query As String = "DELETE FROM resume WHERE id_resume = '" & ID & "'"
        RunQueryAndUpdate(Query, "Ошибочка вышла")
    End Sub

End Class