Public Class LoginPage
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If User.Login(TextBox1.Text, TextBox2.Text) Then
            Me.Hide()
            Main.Show()

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        MsgBox(User._fullname)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ОТКРЫВАЕМ ФОРМУ НА ВЕСЬ ЭКРАН
        Me.WindowState = FormWindowState.Maximized

        ' ВЫРАВНИВАНИЕ ПАНЕЛЕЙ ПО СЕРЕДИНЕ ФОРМЫ
        Dim MeW As Integer = Me.Width / 2
        Dim MeH As Integer = Me.Height / 2

        Panel1.Left = MeW - (Panel1.Width / 2)
        Panel1.Top = MeH - (Panel1.Width / 2)

        Panel2.Left = MeW - (Panel2.Width / 2)
        Panel2.Top = MeH - (Panel2.Width / 2)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Panel2.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Panel2.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class


