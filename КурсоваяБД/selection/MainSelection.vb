Public Class MainSelection
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Main.Selection.UpdateDataset()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Main.Selection.SendNotification()
    End Sub

    Private Sub MainSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Selection.UpdateDataset()
    End Sub

    Private Sub MainSelection_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        e.Cancel = True
    End Sub
End Class