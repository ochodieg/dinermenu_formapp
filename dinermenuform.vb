Public Class dinermenuform

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub homeButton_Click(sender As Object, e As EventArgs) Handles homeButton.Click
        Dim textbox As Control
        item1Label.Text = ""
        For Each textbox In Me.Controls
            If TypeOf textbox Is TextBox Then
                textbox.Text = ""

            End If

        Next
        item2Label.Text = ""
        For Each textbox In Me.Controls
            If TypeOf textbox Is TextBox Then
                textbox.Text = ""

            End If

        Next
    End Sub

    Private Sub RavioliButton_Click(sender As Object, e As EventArgs) Handles RavioliButton.Click
        Me.item1Label.Text = "Ravioli"
        Me.item2Label.Text = "lil raviolis stuffed with raviolis made from ravioli"



    End Sub
End Class
