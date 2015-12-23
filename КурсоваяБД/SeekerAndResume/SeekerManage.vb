Public Class SeekerManage
    Public Type As String

    Private Sub SeekerManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Type = "update" Then
            LoadData()
        End If
    End Sub

    Public Sub LoadData()
        Label6.Text = "Изменение работодателя"
        TextBox1.Text = Main.Seeker.getCellSelectedRow(1)
        MaskedTextBox1.Text = Main.Seeker.getCellSelectedRow(2)
        TextBox2.Text = Main.Seeker.getCellSelectedRow(3)
        TextBox3.Text = Main.Seeker.getCellSelectedRow(4)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Type = "create" Then
            Main.Seeker.Add(TextBox1.Text, MaskedTextBox1.Text, TextBox2.Text, TextBox3.Text)
        ElseIf Type = "update" Then
            Main.Seeker.Update(TextBox1.Text, MaskedTextBox1.Text, TextBox2.Text, TextBox3.Text)
        End If
        Me.Close()
    End Sub

End Class