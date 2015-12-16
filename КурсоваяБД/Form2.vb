Public Class Form2
    Public Employer As Employer
    Public Vacancy As Vacancy

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Employer = New Employer(DataGridView1)
        Vacancy = New Vacancy(DataGridView2)
    End Sub

    'КНОПКА ДОБАВЛЕНИЯ РАБОТОДАТЕЛЯ

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel2.Visible = Not Panel2.Visible
        PictureBox4.Visible = True
        PictureBox10.Visible = False
    End Sub

    'КНОПКА ИЗМЕНЕНИЯ РАБОТОДАТЕЛЯ

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'ЗАПОЛНЕНИЕ ПОЛЕЙ ДЛЯ ИЗМЕНЕНИЯ
        Dim SelectRow As Object = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex)
        TextBox1.Text = SelectRow.Cells(1).Value.ToString
        TextBox3.Text = SelectRow.Cells(3).Value.ToString
        TextBox4.Text = SelectRow.Cells(4).Value.ToString

        Panel2.Visible = Not Panel2.Visible
        PictureBox10.Visible = True
        PictureBox4.Visible = False
    End Sub

    'ДОБАВЛЕНИЕ РАБОТОДАТЕЛЯ

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If MaskedTextBox1.MaskCompleted = True Then 'ПРОВЕРКА ЗАПОЛНЕНИЯ MASKEDTEXTBOX
            Employer.Add(TextBox1.Text, MaskedTextBox1.Text, TextBox3.Text & ComboBox1.Text, TextBox4.Text)
            PictureBox4.Visible = False
            Panel2.Visible = False
        Else
            MsgBox("Заполните все поля")
        End If
    End Sub

    'ИЗМЕНЕНИЕ РАБОТОДАТЕЛЯ

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If MaskedTextBox1.MaskCompleted = True Then 'ПРОВЕРКА ЗАПОЛНЕНИЯ MASKEDTEXTBOX
            Employer.Update(TextBox1.Text, MaskedTextBox1.Text, TextBox3.Text & ComboBox1.Text, TextBox4.Text)
            PictureBox10.Visible = False
            Panel2.Visible = False
        Else
            MsgBox("Заполните все поля")
        End If
    End Sub

    'УДАЛЕНИЕ РАБОТОДАТЕЛЯ

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Employer.Delete()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'ДАННЫЕ ИЗ CHECKEDLISTBOX В TEXTBOX
        Dim ListStrings(CheckedListBox1.CheckedItems.Count - 1) As String
        Dim Id As Integer = 0
        For Each item In CheckedListBox1.CheckedItems
            ListStrings(Id) = item
            Id += 1
        Next
        TextBox7.Text = Strings.Join(ListStrings, ", ") & "."

        Vacancy.Add(Employer.getCellSelectedRow(0), TextBox2.Text, DateTime.Now.ToString("yyyy-MM-dd"), ComboBox2.Text, TextBox5.Text, MaskedTextBox2.Text, ComboBox3.Text, TextBox6.Text, TextBox7.Text, ComboBox4.Text, CheckBox1.Checked, ComboBox5.Text, ComboBox6.Text, CheckBox2.Checked)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Vacancy.Update(ComboBox2.Text, TextBox5.Text, MaskedTextBox2.Text, ComboBox3.Text, TextBox6.Text, TextBox7.Text, ComboBox4.Text, CheckBox1.Checked, ComboBox5.Text, ComboBox6.Text, CheckBox2.Checked, DateTime.Now.ToString("yyyy-MM-dd"))
    End Sub

    'УДАЛЕНИЕ ВАКАНСИИ

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Vacancy.Delete()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        PictureBox5.Visible = True
        TextBox2.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
    End Sub
End Class
