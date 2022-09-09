Public Class Form1

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click

        Me.Close()
    End Sub

    Private Sub JapaneseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JapaneseButton.Click

        MessageLabel.Text = "Kon'nichiwa sekai"
        ButtonLabel.Text = JapaneseButton.Text
    End Sub

    Private Sub IndonesianButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndonesianButton.Click

        MessageLabel.Text = "Halo Dunia"
        ButtonLabel.Text = IndonesianButton.Text
    End Sub
End Class
