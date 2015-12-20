Public Class EmployerManage
    Public Type As String
    Public Data As Object

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Type = "update" Then
            LoadData()
        End If
    End Sub

    Public Sub LoadData()
        Label6.Text = "Изменение работодателя"
        TextBox1.Text = Data.getCellSelectedRow(1)
        MaskedTextBox1.Text = Data.getCellSelectedRow(2)
        TextBox2.Text = Data.getCellSelectedRow(4)
        TextBox3.Text = Data.getCellSelectedRow(3)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Type = "create" Then
            Data.Add(TextBox1.Text, MaskedTextBox1.Text, TextBox3.Text & ComboBox1.Text, TextBox2.Text)
        ElseIf Type = "update"
            Data.Update(TextBox1.Text, MaskedTextBox1.Text, TextBox3.Text & ComboBox1.Text, TextBox2.Text)
        End If
    End Sub

End Class