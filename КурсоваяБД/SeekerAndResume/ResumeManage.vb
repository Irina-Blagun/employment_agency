Public Class ResumeManage
    Public Type As String

    Private Sub ResumeManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Соискатель: " & Main.Seeker.getCellSelectedRow(1)

        If Type = "update" Then
            LoadData()
        End If
    End Sub

    Public Sub LoadData()
        Label6.Text = "Изменение резюме"

        ComboBox2.Text = Main.Resumes.getCellSelectedRow(2)
        TextBox5.Text = Main.Resumes.getCellSelectedRow(3)
        ComboBox7.Text = Main.Resumes.getCellSelectedRow(4)
        ComboBox3.Text = Main.Resumes.getCellSelectedRow(5)
        ComboBox8.Text = Main.Resumes.getCellSelectedRow(6)
        ComboBox4.Text = Main.Resumes.getCellSelectedRow(7)
        CheckBox1.Checked = Main.Resumes.getCellSelectedRow(8)
        ComboBox5.Text = Main.Resumes.getCellSelectedRow(9)
        ComboBox6.Text = Main.Resumes.getCellSelectedRow(10)
        CheckBox2.Checked = Main.Resumes.getCellSelectedRow(11)

        TextBox3.Text = Main.Resumes.getCellSelectedRow(12)
        TextBox4.Text = Main.Resumes.getCellSelectedRow(13)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Type = "create" Then
            Main.Resumes.Add(Main.Seeker.getCellSelectedRow(0), ComboBox2.Text, TextBox5.Text, ComboBox7.Text, ComboBox3.Text, ComboBox8.Text, ComboBox4.Text, CheckBox1.Checked, ComboBox5.Text, ComboBox6.Text, CheckBox2.Checked, TextBox3.Text, TextBox4.Text)
        ElseIf Type = "update" Then
            Main.Resumes.Update(ComboBox2.Text, TextBox5.Text, ComboBox7.Text, ComboBox3.Text, ComboBox8.Text, ComboBox4.Text, CheckBox1.Checked, ComboBox5.Text, ComboBox6.Text, CheckBox2.Checked, TextBox3.Text, TextBox4.Text)
        End If
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class