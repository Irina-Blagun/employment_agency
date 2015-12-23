Public Class VacancyManage
    Public Type As String
    Public Data As Object

    Private Sub VacancyManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Работодатель: " & Main.Employer.getCellSelectedRow(1)

        If Type = "update" Then
            LoadData()
        End If
    End Sub

    Public Sub LoadData()
        Label6.Text = "Изменение вакансии"

        ComboBox2.Text = Data.getCellSelectedRow(2)
        TextBox5.Text = Data.getCellSelectedRow(3)
        ComboBox1.Text = Data.getCellSelectedRow(4)
        ComboBox3.Text = Data.getCellSelectedRow(5)
        ComboBox7.Text = Data.getCellSelectedRow(6)

        ComboBox4.Text = Data.getCellSelectedRow(8)
        CheckBox1.Checked = Data.getCellSelectedRow(9)
        ComboBox5.Text = Data.getCellSelectedRow(10)
        ComboBox6.Text = Data.getCellSelectedRow(11)
        CheckBox2.Checked = Data.getCellSelectedRow(12)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Type = "create" Then
            Data.Add(Main.Employer.getCellSelectedRow(0), ComboBox2.Text, TextBox5.Text, ComboBox1.Text, ComboBox3.Text, ComboBox7.Text, "", ComboBox4.Text, CheckBox1.Checked, ComboBox5.Text, ComboBox6.Text, CheckBox2.Checked)
        ElseIf Type = "update" Then
            Data.Update(ComboBox2.Text, TextBox5.Text, ComboBox1.Text, ComboBox3.Text, ComboBox7.Text, "", ComboBox4.Text, CheckBox1.Checked, ComboBox5.Text, ComboBox6.Text, CheckBox2.Checked)
        End If
        Me.Close()
    End Sub

End Class