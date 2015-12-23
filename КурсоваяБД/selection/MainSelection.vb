Public Class MainSelection
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Main.Selection.UpdateDataset()
    End Sub
End Class