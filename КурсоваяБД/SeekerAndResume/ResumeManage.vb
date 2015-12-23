Public Class ResumeManage
    Public Type As String

    Private Sub ResumeManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Main.Seeker.getCellSelectedRow(1)

        If Type = "update" Then
            LoadData()
        End If
    End Sub

    Public Sub LoadData()
        Label6.Text = "Изменение резюме"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Type = "create" Then
            Main.Seeker.ResumeAdd(TextBox5.Text, ComboBox2.Text, TextBox1.Text, ComboBox3.Text, TextBox2.Text, ComboBox4.Text, CheckBox1.Checked, ComboBox5.Text, ComboBox6.Text, CheckBox2.Checked, TextBox3.Text, TextBox4.Text)
        ElseIf Type = "update"

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class