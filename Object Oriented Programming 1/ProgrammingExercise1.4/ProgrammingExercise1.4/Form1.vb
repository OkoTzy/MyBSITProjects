Public Class Form1
    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub

    Private Sub FirstButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstButton.Click

        First_DL.Text = "Police Dept."
        F_Phone.Text = "(602)554 - 322"

    End Sub

    Private Sub SecondButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondButton.Click

        Second_DL.Text = "Ambulance"
        S_Phone.Text = "(602) 554 - 765"

    End Sub

    Private Sub ThirdButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThirdButton.Click

        Third_DL.Text = "Civil Protection"
        T_Phone.Text = "(602) 554 - 991"

    End Sub

    Private Sub FourthButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FourthButton.Click

        Fourth_DL.Text = "Hospital"
        L_Phone.Text = "(602) 554 - 371"

    End Sub
End Class
