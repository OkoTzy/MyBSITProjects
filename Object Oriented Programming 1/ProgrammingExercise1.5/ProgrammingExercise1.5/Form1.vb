Public Class Form1

    Private Sub DinerName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DinerName.Click

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub SoupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoupButton.Click

        MessageLabel.Text = "Tikka Masala Soup"

    End Sub

    Private Sub SpecialButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialButton.Click

        MessageLabel.Text = "Creamy Presto Shrimp"

    End Sub

    Private Sub DailyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyButton.Click

        MessageLabel.Text = "Pan-Seared Salmon"

    End Sub

    Private Sub MessageLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessageLabel.Click

    End Sub
End Class
