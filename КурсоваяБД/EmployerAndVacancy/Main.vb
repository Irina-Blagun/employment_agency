Public Class Main
    Public Employer As Employer
    Public Vacancy As Vacancy

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Employer = New Employer(DataGridView1)
        Vacancy = New Vacancy(DataGridView2)

        Dim MeW As Integer = Me.Width / 2
        Dim MeH As Integer = Me.Height / 2

        RerenderPanels()
    End Sub

    Public Sub RerenderPanels()

        ' HEADER
        Panel4.Top = 0
        Panel4.Left = 0
        Panel4.Width = Me.Width
        Panel4.Height = 60

        'SIDERBAR
        Panel5.Top = Panel4.Height
        Panel5.Left = 0
        Panel5.Height = Me.Height - Panel4.Height
        Panel5.Width = 260

        'CONTENT

        Panel1.Left = Panel5.Width + 20
        Panel1.Top = Panel4.Height + 20
        Panel1.Height = Me.Height - Panel4.Height - 75
        Panel1.Width = Me.Width - Panel5.Width - 50

        ' TABLE
        DataGridView1.Left = 20
        DataGridView1.Top = 80
        DataGridView1.Width = Panel1.Width - 40
        DataGridView1.Height = (Panel1.Height - 80) * 0.4

        ' TABLE
        PictureBox5.Top = 80 + DataGridView1.Height + 20
        PictureBox6.Top = 80 + DataGridView1.Height + 20
        PictureBox7.Top = 80 + DataGridView1.Height + 20
        DataGridView2.Left = 20
        DataGridView2.Top = DataGridView1.Height + 80 + 80
        DataGridView2.Width = Panel1.Width - 40
        DataGridView2.Height = ((Panel1.Height - 80) * 0.6) - 40 - 80




    End Sub

    'КНОПКА ДОБАВЛЕНИЯ РАБОТОДАТЕЛЯ

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        EmployerManage.Type = "create"
        EmployerManage.Data = Employer
        EmployerManage.Show()

        'Panel2.Visible = Not Panel2.Visible
        'PictureBox4.Visible = True
        'PictureBox10.Visible = False
    End Sub

    'КНОПКА ИЗМЕНЕНИЯ РАБОТОДАТЕЛЯ

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        EmployerManage.Type = "update"
        EmployerManage.Data = Employer
        EmployerManage.Show()

        ''ЗАПОЛНЕНИЕ ПОЛЕЙ ДЛЯ ИЗМЕНЕНИЯ
        'Dim SelectRow As Object = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex)
        'TextBox1.Text = SelectRow.Cells(1).Value.ToString
        'TextBox3.Text = SelectRow.Cells(3).Value.ToString
        'TextBox4.Text = SelectRow.Cells(4).Value.ToString

        'Panel2.Visible = Not Panel2.Visible
        'PictureBox10.Visible = True
        'PictureBox4.Visible = False
    End Sub

    'УДАЛЕНИЕ РАБОТОДАТЕЛЯ

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Select Case MsgBox("Вы действительно хотите удалить работодателя '" & Employer.getCellSelectedRow(1) & "'", MsgBoxStyle.YesNo, "Удаление")
            Case MsgBoxResult.Yes
                Employer.Delete()
        End Select
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        VacancyManage.Type = "create"
        VacancyManage.Data = Vacancy
        VacancyManage.Employer = Employer
        VacancyManage.Show()

        ''ДАННЫЕ ИЗ CHECKEDLISTBOX В TEXTBOX
        'Dim ListStrings(CheckedListBox1.CheckedItems.Count - 1) As String
        'Dim Id As Integer = 0
        'For Each item In CheckedListBox1.CheckedItems
        '    ListStrings(Id) = item
        '    Id += 1
        'Next
        'TextBox7.Text = Strings.Join(ListStrings, ", ") & "."

        'Vacancy.Add(Employer.getCellSelectedRow(0), TextBox2.Text, DateTime.Now.ToString("yyyy-MM-dd"), ComboBox2.Text, TextBox5.Text, MaskedTextBox2.Text, ComboBox3.Text, TextBox6.Text, TextBox7.Text, ComboBox4.Text, CheckBox1.Checked, ComboBox5.Text, ComboBox6.Text, CheckBox2.Checked)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Select Case MsgBox("Вы действительно хотите удалить вакансию '" & Employer.getCellSelectedRow(3) & "'", MsgBoxStyle.YesNo, "Удаление")
            Case MsgBoxResult.Yes
                Vacancy.Delete()
        End Select
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)

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
        VacancyManage.Employer = Employer
        VacancyManage.Show()
    End Sub
End Class
