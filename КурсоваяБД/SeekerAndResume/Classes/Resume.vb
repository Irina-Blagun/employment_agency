Public Class Resumes
    Inherits DependentActions

    Public Sub New(Table As Object)
        MyBase.New(Table)
    End Sub


    Public Sub RenderTable(ID As String)
        Dim Query As String = "SELECT id_resume As 'Номер', re_creation_date As 'Дата создания', re_activity As 'Вид деятельности', re_office As 'Должность', re_min_salary As 'Заработная плата', re_sex As 'Пол', re_age As 'Возраст',  re_education As 'Образование', re_experience As 'Опыт работы', re_employment As 'Занятость', re_schedule As 'График работы', re_social_package As 'Соц. пакет', re_education_place As 'Место обучения', re_workplace As 'Место работы' FROM resume WHERE id_seeker = '" & ID & "'"
        MyBase.RenderDataset(Query)
    End Sub

    Public Sub Add(ID As String, Activity As String, Office As String, Salary As String, Sex As String, Age As String, Education As String, Experience As String, Employment As String, Schedule As String, Social_package As String, Education_place As String, Workplace As String)
        Dim Query As String = "INSERT INTO resume (id_seeker, re_activity, re_office, re_min_salary, re_sex, re_age, re_education, re_experience, re_employment, re_schedule, re_social_package, re_education_place, re_workplace) VALUES ('" & ID & "','" & Activity & "','" & Office & "', '" & Salary & "', '" & Sex & "', '" & Age & "', '" & Education & "', '" & Experience & "', '" & Employment & "', '" & Schedule & "', '" & Social_package & "', '" & Education_place & "', '" & Workplace & "')"
        RunQueryAndUpdate(Query, "УУУ")
    End Sub

    Public Sub Update(Activity As String, Office As String, Salary As String, Sex As String, Age As String, Education As String, Experience As String, Employment As String, Schedule As String, Social_package As String, Education_place As String, Workplace As String)
        Dim Query As String = "UPDATE resume SET re_activity = '" & Activity & "', re_office = '" & Office & "', re_min_salary = '" & Salary & "', re_sex = '" & Sex & "', re_age = '" & Age & "', re_education = '" & Education & "', re_experience = '" & Experience & "', re_employment = '" & Employment & "', re_schedule = '" & Schedule & "', re_social_package = '" & Social_package & "', re_education_place = '" & Education_place & "', re_workplace = '" & Workplace & "' WHERE resume.id_resume='" & Me.getCellSelectedRow(0) & "'"
        RunQueryAndUpdate(Query, "Просто жесть")
    End Sub

    Public Sub Delete()
        Dim ID As String = getCellSelectedRow(0)
        Dim Query As String = "DELETE FROM resume WHERE id_resume = '" & ID & "'"
        RunQueryAndUpdate(Query, "Ошибочка вышла")
    End Sub

End Class