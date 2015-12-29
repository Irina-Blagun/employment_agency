Imports System.IO

Public Class EmployerManage
    Public Type As String
    Public Data As Object
    Dim imgLoc As String

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
        Dim Logotype() As Byte = Data.getCellSelectedRowByte(5)
        If Not Logotype Is Nothing Then
            Dim ms As MemoryStream = New MemoryStream(Logotype)
            PictureBox4.Image = Image.FromStream(ms)
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If Type = "create" Then
            If Data.CheckEmployerName(TextBox1.Text) Then
                Data.Add(TextBox1.Text, MaskedTextBox1.Text, TextBox3.Text, TextBox2.Text, imgLoc)
            Else
                MsgBox("Название работодателя не уникальное")
            End If
        Else Type = "update"
            Data.Update(TextBox1.Text, MaskedTextBox1.Text, TextBox3.Text, TextBox2.Text, imgLoc)
        End If
        Me.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim dlg As OpenFileDialog

        Try
            dlg = New OpenFileDialog()
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*"
            dlg.Title = "Employer Logotype"
            If dlg.ShowDialog() = DialogResult.OK Then
                imgLoc = dlg.FileName.ToString()
                PictureBox4.ImageLocation = imgLoc
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class