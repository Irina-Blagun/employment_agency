Public Class Form1
    '    Dim SQL As New SQLControl
    '    Dim SMTP As New SMTPControl

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        '        If TextBox1.Text.Length < 3 Or TextBox2.Text.Length = 0 Or ComboBox1.Text = "" Then
        '            MsgBox("Логин или пароль введены неверно")
        '        ElseIf SQL.HasConnection And SQL.Autorization(TextBox1.Text & ComboBox1.Text, TextBox2.Text) Then
        Form2.Show()
        MsgBox("iyguktfjy")
        MsgBox("iyguktfjy")
        '            Me.Hide()
        '        End If
    End Sub

    '    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
    '        Dim Email As String = TextBox3.Text & ComboBox2.Text
    '        Dim Password As String = SQL.GetPassword(Email)
    '        If Password.Length > 0 Then
    '            SMTP.ForgotPassowrd(Password)
    '        End If
    '    End Sub

    '    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    '        Panel2.Visible = Not Panel2.Visible
    '    End Sub
End Class


