Public Class Selection
    Inherits DependentActions

    Public Type As String

    Public Sub New(Table As Object)
        MyBase.New(Table)
    End Sub

    Public Sub RenderTableForSeeker(IDresume As String, Activity As String, MinSalary As String, Sex As String, Age As String, Employment As String, Shedule As String, SocialPackage As String, Education As String, Experience As String)
        MainSelection.Show()
        'Dim Query As String = "SELECT id_vacancy As 'Номер', vy_creation_date As 'Дата создания', vy_activity As 'Вид деятельности', vy_position As 'Должность', vy_min_salary As 'Заработная плата', vy_sex As 'Пол', vy_age As 'Возраст', vy_education As 'Образование', vy_experience As 'Опыт работы', vy_employment As 'Занятость', vy_schedule As 'График работы', vy_social_package As 'Соц. пакет' FROM vacancy WHERE vy_activity = '" & Activity & "' and vy_min_salary <= '" & MinSalary & "' and vy_sex = '" & Sex & "' and vy_age >= '" & Age & "' and vy_employment = '" & Employment & "' and vy_schedule = '" & Shedule & "' and vy_social_package = '" & SocialPackage & "' and vy_education = '" & Education & "' and vy_experience = '" & Experience & "'"
        Dim Query As String = "SELECT employer.er_name As 'Работодатель', employer.er_phone As 'Номер телефона', employer.er_email As 'E-mail', vacancy.id_vacancy As 'Номер', vacancy.vy_creation_date As 'Дата создания', vacancy.vy_activity As 'Вид деятельности', vacancy.vy_position As 'Должность', vacancy.vy_min_salary As 'Заработная плата', vacancy.vy_sex As 'Пол', vacancy.vy_age As 'Возраст', vacancy.vy_education As 'Образование', vacancy.vy_experience As 'Опыт работы', vacancy.vy_employment As 'Занятость', vacancy.vy_schedule As 'График работы', vacancy.vy_social_package As 'Соц. пакет' FROM employer,vacancy,employer_vacancy WHERE employer.id_employer=employer_vacancy.id_employer and vacancy.id_vacancy=employer_vacancy.id_vacancy and vy_activity = '" & Activity & "' and vy_min_salary <= '" & MinSalary & "' and vy_sex = '" & Sex & "' and vy_age >= '" & Age & "' and vy_employment = '" & Employment & "' and vy_schedule = '" & Shedule & "' and vy_social_package = '" & SocialPackage & "' and vy_education = '" & Education & "' and vy_experience = '" & Experience & "'"

        MyBase.RenderDataset(Query)
    End Sub

    Public Sub RenderTableForEmployer(IDvacancy As String, Activity As String, MinSalary As String, Sex As String, Age As String, Employment As String, Shedule As String, SocialPackage As String, Education As String, Experience As String)
        MainSelection.Show()
        Dim Query As String = "SELECT seeker.sr_name As 'Соискатель', seeker.sr_phone As 'Номер телефона', seeker.sr_email As 'E-mail', resume.id_resume As 'Номер', resume.re_creation_date As 'Дата создания', resume.re_activity As 'Вид деятельности', resume.re_office As 'Должность', resume.re_min_salary As 'Заработная плата', resume.re_sex As 'Пол', resume.re_age As 'Возраст', resume.re_education As 'Образование', resume.re_experience As 'Опыт работы', resume.re_employment As 'Занятость', resume.re_schedule As 'График работы', resume.re_social_package As 'Соц. пакет' FROM seeker,resume WHERE re_activity = '" & Activity & "' and re_min_salary >= '" & MinSalary & "' and re_sex = '" & Sex & "' and re_age <= '" & Age & "' and re_employment = '" & Employment & "' and re_schedule = '" & Shedule & "' and re_social_package = '" & SocialPackage & "' and re_education = '" & Education & "' and re_experience = '" & Experience & "'"
        MyBase.RenderDataset(Query)
    End Sub

    Public Sub SendNotification()
        If Type = "seeker" Then
            SMTPControl.SendEmail(Main.Selection.getCellSelectedRow(2), "Резюме, подходящее вашей вакансии", "Здравствуйте, " & Main.Selection.getCellSelectedRow(0) & "! Соискатель " & Main.Seeker.getCellSelectedRow(1) & "  откликнулся на вашу вакансию. " & vbCrLf & vbCrLf & " Контактные данные соискателя: " & vbCrLf & " Телефон: " & Main.Selection.getCellSelectedRow(1) & vbCrLf & " E-mail: " & Main.Selection.getCellSelectedRow(4) & vbCrLf & vbCrLf & " Пол: " & Main.Resumes.getCellSelectedRow(5) & vbCrLf & " Возраст: " & Main.Resumes.getCellSelectedRow(6) & vbCrLf & " Должность: " & Main.Resumes.getCellSelectedRow(3))
        Else
            SMTPControl.SendEmail(Main.Selection.getCellSelectedRow(2), "Вакансия, подходящая вашему резюме", "Здравствуйте, " & Main.Selection.getCellSelectedRow(0) & "! Работодатель " & Main.Employer.getCellSelectedRow(1) & "  откликнулся на ваше резюме. " & vbCrLf & vbCrLf & " Контактные данные работодателя: " & vbCrLf & " Телефон: " & Main.Employer.getCellSelectedRow(2) & vbCrLf & " E-mail: " & Main.Employer.getCellSelectedRow(3) & vbCrLf & vbCrLf & " Должность: " & Main.Vacancy.getCellSelectedRow(3) & vbCrLf & " Заработная плата: " & Main.Vacancy.getCellSelectedRow(4))
        End If
    End Sub

End Class
