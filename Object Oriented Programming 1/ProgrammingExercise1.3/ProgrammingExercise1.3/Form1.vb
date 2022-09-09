Public Class Form1

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub

    Private Sub FirstButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstButton.Click

        MessageLabel.Text = "Every failure is a step to success"

    End Sub

    Private Sub SecondButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondButton.Click

        MessageLabel.Text = "Try and try until you succeed"

    End Sub

    Private Sub ThirdButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThirdButton.Click

        MessageLabel.Text = "Worry less, Smile more"

    End Sub

    Private Sub FourthButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FourthButton.Click

        MessageLabel.Text = "Done is better than perfect"

    End Sub

    Private Sub MessageLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessageLabel.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
