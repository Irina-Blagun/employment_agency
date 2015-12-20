Public Class Vacancy
    Inherits DependentActions

    Public Sub New(Table As Object)
        MyBase.New(Table)
    End Sub


    Public Sub RenderTable(ID As String)
        Dim Query As String = "SELECT id_vacancy As 'Номер', vy_creation_date As 'Дата создания', vy_activity As 'Вид деятельности', vy_position As 'Должность', vy_min_salary As 'Заработная плата', vy_sex As 'Пол', vy_age As 'Возраст', vy_languages As 'Владение языками', vy_education As 'Образование', vy_experience As 'Опыт работы', vy_employment As 'Занятость', vy_schedule As 'График работы', vy_social_package As 'Соц. пакет', vy_update_date As 'Дата обновления' FROM vacancy WHERE id_vacancy in (SELECT id_vacancy FROM employer_vacancy WHERE employer_vacancy.id_employer = '" & ID & "')"
        MyBase.RenderDataset(Query)
    End Sub


    Public Sub Add(ID As String, Activity As String, Position As String, Salary As String, Sex As String, Age As String, Languages As String, Education As String, Experience As String, Employment As String, Schedule As String, Social_package As String)
        Dim Query As String = "INSERT INTO vacancy (vy_activity, vy_position, vy_min_salary, vy_sex, vy_age, vy_languages, vy_education, vy_experience, vy_employment, vy_schedule, vy_social_package) VALUES ('" & Activity & "', '" & Position & "', '" & Salary & "', '" & Sex & "', '" & Age & "', '" & Languages & "', '" & Education & "', '" & Experience & "', '" & Employment & "', '" & Schedule & "', '" & Social_package & "'); INSERT INTO employer_vacancy(id_employer, id_vacancy) VALUES ('" & ID & "', IDENT_CURRENT('vacancy'))"

        RunQueryAndUpdate(Query, "ОК", "Просто жесть")
    End Sub

    Public Sub Update(Activity As String, Position As String, Salary As String, Sex As String, Age As String, Languages As String, Education As String, Experience As String, Employment As String, Schedule As String, Social_package As String)
        Dim Query As String = "UPDATE vacancy SET vy_activity = '" & Activity & "', vy_position = '" & Position & "', vy_min_salary = '" & Salary & "', vy_sex = '" & Sex & "', vy_age = '" & Age & "', vy_languages = '" & Languages & "', vy_education = '" & Education & "', vy_experience = '" & Experience & "', vy_employment = '" & Employment & "', vy_schedule = '" & Schedule & "', vy_social_package = '" & Social_package & "', vy_update_date = '" & DateTime.Now.ToString("yyyy-MM-dd") & "' WHERE vacancy.id_vacancy='" & Me.getCellSelectedRow(0) & "'"
        RunQueryAndUpdate(Query, "ОК", "Просто жесть")
    End Sub

    Public Sub Delete()
        Dim ID As String = getCellSelectedRow(0)
        Dim Query As String = "DELETE FROM vacancy WHERE id_vacancy = '" & ID & "'"
        RunQueryAndUpdate(Query, "Вакансия удалена", "Ошибочка вышла")
    End Sub

End Class
