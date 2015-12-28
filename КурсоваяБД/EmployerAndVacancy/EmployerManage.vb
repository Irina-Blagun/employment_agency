Public Class EmployerManage
    Public Type As String
    Public Data As Object

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Type = "update" Then
            LoadData()
        End If

        PictureBox1.Left = Panel1.Width / 2 - PictureBox1.Width / 2
        TextBox1.Width = Panel1.Width - 60
        TextBox1.Left = Panel1.Width / 2 - TextBox1.Width / 2
        TextBox1.Top = 110
    End Sub

    Public Sub LoadData()
        Me.Text = "Изменение"
        PictureBox1.Image = КурсоваяБД.My.Resources.Resources.button_Изменить_1
        PictureBox3.Image = КурсоваяБД.My.Resources.Resources.ИЗМЕНЕНИЕ_РАБОТОДАТЕЛЯ
        TextBox1.Text = Data.getCellSelectedRow(1)
        MaskedTextBox1.Text = Data.getCellSelectedRow(2)
        TextBox2.Text = Data.getCellSelectedRow(4)
        TextBox3.Text = Data.getCellSelectedRow(3)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Type = "create" Then
            Data.Add(TextBox1.Text, MaskedTextBox1.Text, TextBox3.Text, TextBox2.Text)
        ElseIf Type = "update" Then
            Data.Update(TextBox1.Text, MaskedTextBox1.Text, TextBox3.Text, TextBox2.Text)
        End If
        Me.Close()
    End Sub
End Class