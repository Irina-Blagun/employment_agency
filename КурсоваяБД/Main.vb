Public Class Main
    Public Employer As Employer
    Public Vacancy As Vacancy
    Public Seeker As Seeker
    Public Resumes As Resumes

    Public Selection As Selection

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Employer = New Employer(DataGridView1)
        Vacancy = New Vacancy(DataGridView2)
        Seeker = New Seeker(DataGridView3)
        Resumes = New Resumes(DataGridView4)
        Selection = New Selection(MainSelection.DataGridView1)

        Label1.Text = "Вы вошли как, " & User._fullname

        Dim MeW As Integer = Me.Width / 2
        Dim MeH As Integer = Me.Height / 2

        RerenderPanels()
        Panel2.Visible = False

        Me.DataGridView1.Rows(0).Selected = True
        Vacancy.RenderTable(Employer.getCellSelectedRow(0))
        Me.DataGridView3.Rows(0).Selected = True
        Resumes.RenderTable(Seeker.getCellSelectedRow(0))
    End Sub

    Public Sub RerenderPanels()

        ' HEADER
        Panel4.Top = 0
        Panel4.Left = 0
        Panel4.Width = Me.Width
        Panel4.Height = 60

        'CONTENT 1

        Panel1.Left = 20
        Panel1.Width = Me.Width - Panel1.Left * 2.8
        Panel1.Top = Panel4.Height + 20
        Panel1.Height = Me.Height - Panel4.Height - 75


        ' TABLE

        DataGridView1.Left = 20
        DataGridView1.Top = 80
        DataGridView1.Width = Panel1.Width - DataGridView1.Left * 2
        DataGridView1.Height = (Panel1.Height - 80) * 0.4

        ' BUTTONS

        PictureBox5.Top = 80 + DataGridView1.Height + 26
        PictureBox6.Top = 80 + DataGridView1.Height + 26
        PictureBox7.Top = 80 + DataGridView1.Height + 26
        PictureBox16.Top = 80 + DataGridView1.Height + 26
        PictureBox18.Top = 80 + DataGridView1.Height + 26

        DataGridView2.Left = 20
        DataGridView2.Top = DataGridView1.Height + 80 + 80
        DataGridView2.Width = Panel1.Width - 40
        DataGridView2.Height = ((Panel1.Height - 80) * 0.6) - 40 - 80

        'OTHER

        PictureBox21.Top = Panel4.Height / 2 - PictureBox21.Height / 2
        PictureBox21.Left = Panel1.Left

        PictureBox4.Top = Panel4.Height / 2 - PictureBox4.Height / 2
        PictureBox4.Left = PictureBox21.Width * 6

        PictureBox8.Top = Panel4.Height / 2 - PictureBox8.Height / 2
        PictureBox8.Left = PictureBox4.Left + PictureBox4.Width + PictureBox4.Width / 4

        PictureBox23.Top = 80 + DataGridView1.Height + 30

        ''Panel2.Left = 20
        ''Panel2.Top = Panel4.Height + 20
        ''Panel2.Height = Me.Height - Panel4.Height - 75
        ''Panel2.Width = Me.Width - 50

        ''TABLE
        ''DataGridView3.Left = 20
        ''DataGridView3.Top = 80
        ''DataGridView3.Width = Panel1.Width - 40
        ''DataGridView3.Height = (Panel1.Height - 80) * 0.4

        '' TABLE
        'PictureBox9.Top = 80 + DataGridView1.Height + 20
        'PictureBox13.Top = 80 + DataGridView1.Height + 20
        'PictureBox14.Top = 80 + DataGridView1.Height + 20
        'PictureBox15.Top = 80 + DataGridView1.Height + 20
        'PictureBox20.Top = 80 + DataGridView1.Height + 20

        'DataGridView4.Left = 20
        'DataGridView4.Top = DataGridView1.Height + 80 + 80
        'DataGridView4.Width = Panel1.Width - 40
        'DataGridView4.Height = ((Panel1.Height - 80) * 0.6) - 40 - 80

        'CONTENT 2

        Panel2.Left = 20
        Panel2.Width = Me.Width - Panel1.Left * 2.8
        Panel2.Top = Panel4.Height + 20
        Panel2.Height = Me.Height - Panel4.Height - 75


        ' TABLE 2

        DataGridView3.Left = 20
        DataGridView3.Top = 80
        DataGridView3.Width = Panel2.Width - DataGridView3.Left * 2
        DataGridView3.Height = (Panel2.Height - 80) * 0.4

        ' BUTTONS 2

        PictureBox9.Top = 80 + DataGridView3.Height + 26
        PictureBox13.Top = 80 + DataGridView3.Height + 26
        PictureBox14.Top = 80 + DataGridView3.Height + 26
        PictureBox20.Top = 80 + DataGridView3.Height + 26
        PictureBox15.Top = 80 + DataGridView3.Height + 26

        DataGridView4.Left = 20
        DataGridView4.Top = DataGridView3.Height + 80 + 80
        DataGridView4.Width = Panel2.Width - 40
        DataGridView4.Height = ((Panel2.Height - 80) * 0.6) - 40 - 80

        'OTHER 2

        PictureBox25.Top = 80 + DataGridView1.Height + 30

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        EmployerManage.Type = "create"
        EmployerManage.Data = Employer
        EmployerManage.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        EmployerManage.Type = "update"
        EmployerManage.Data = Employer
        EmployerManage.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Select Case MsgBox("Вы уверены, что хотите удалить работодателя " & Employer.getCellSelectedRow(1) & "?", MsgBoxStyle.YesNo, "Удаление работодателя")
            Case MsgBoxResult.Yes
                Employer.Delete()
                Vacancy.UpdateDataset()
        End Select
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        VacancyManage.Type = "create"
        VacancyManage.Data = Vacancy
        VacancyManage.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Select Case MsgBox("Вы уверены, что хотите удалить вакансию " & Vacancy.getCellSelectedRow(3) & " работодателя " & Employer.getCellSelectedRow(3) & "?", MsgBoxStyle.YesNo, "Удаление вакансии")
            Case MsgBoxResult.Yes
                Vacancy.Delete()
        End Select
    End Sub

    Private Sub Form2_ResizeBegin(sender As Object, e As EventArgs) Handles MyBase.ResizeBegin
        RerenderPanels()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Vacancy.RenderTable(Employer.getCellSelectedRow(0))
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        VacancyManage.Type = "update"
        VacancyManage.Data = Vacancy
        VacancyManage.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Panel1.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Panel2.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        SeekerManage.Type = "create"
        SeekerManage.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        SeekerManage.Type = "update"
        SeekerManage.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Select Case MsgBox("Вы уверены, что хотите удалить соискателя " & Seeker.getCellSelectedRow(1) & "?", MsgBoxStyle.YesNo, "Удаление соискателя")
            Case MsgBoxResult.Yes
                Seeker.Delete()
                Resumes.UpdateDataset()
        End Select
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        ResumeManage.Type = "create"
        ResumeManage.Show()
    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Resumes.RenderTable(Seeker.getCellSelectedRow(0))
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Select Case MsgBox("Вы уверены, что хотите удалить резюме на должность """ & Resumes.getCellSelectedRow(3) & """ соискателя " & Seeker.getCellSelectedRow(1) & "?", MsgBoxStyle.YesNo, "Удаление резюме")
            Case MsgBoxResult.Yes
                Resumes.Delete()
        End Select
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Selection.Type = "seeker"
        Selection.RenderTableForSeeker(Resumes.getCellSelectedRow(0), Resumes.getCellSelectedRow(2), Resumes.getCellSelectedRow(4), Resumes.getCellSelectedRow(5), Resumes.getCellSelectedRow(6), Resumes.getCellSelectedRow(9), Resumes.getCellSelectedRow(10), Resumes.getCellSelectedRow(11), Resumes.getCellSelectedRow(7), Resumes.getCellSelectedRow(8))
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Selection.RenderTableForEmployer(Vacancy.getCellSelectedRow(0), Vacancy.getCellSelectedRow(2), Vacancy.getCellSelectedRow(4), Vacancy.getCellSelectedRow(5), Vacancy.getCellSelectedRow(6), Vacancy.getCellSelectedRow(10), Vacancy.getCellSelectedRow(11), Vacancy.getCellSelectedRow(12), Vacancy.getCellSelectedRow(8), Vacancy.getCellSelectedRow(9))
    End Sub

    Private Sub Main_FormClosed(sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case MsgBox("Вы уверены, что хотите выйти из программы?", MsgBoxStyle.YesNo, "Выход")
            Case MsgBoxResult.Yes
                LoginPage.Close()
            Case MsgBoxResult.Cancel
                e.Cancel = True
            Case MsgBoxResult.No
                e.Cancel = True
        End Select
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        ResumeManage.Type = "update"
        ResumeManage.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim a As Boolean = False
        Dim Row As DataGridViewRow
        Dim str_find As String = TextBox1.Text
        For Each Row In DataGridView1.Rows

            If (Row.Cells(1).Value.ToString().Contains(str_find)) Then
                DataGridView1.CurrentCell = Row.Cells(1)
                DataGridView1.Rows(Row.Index).Selected = True
                a = True
                Vacancy.RenderTable(Employer.getCellSelectedRow(0))
            End If
        Next
        If a = False Or TextBox1.Text = "" Then
            DataGridView1.ClearSelection()
            DataGridView2.Columns.Clear()
        End If


    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click

    End Sub
End Class
