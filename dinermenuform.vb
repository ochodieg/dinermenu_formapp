Public Class dinermenuform

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub homeButton_Click(sender As Object, e As EventArgs) Handles homeButton.Click
        Dim textbox As Control
        itemNameLabel.Text = ""
        For Each textbox In Me.Controls
            If TypeOf textbox Is TextBox Then
                textbox.Text = ""

            End If

        Next
        itemDescriptionLabel.Text = ""
        For Each textbox In Me.Controls
            If TypeOf textbox Is TextBox Then
                textbox.Text = ""

            End If

        Next
    End Sub

    Private Sub RavioliButton_Click(sender As Object, e As EventArgs) Handles RavioliButton.Click
        Me.itemNameLabel.Text = "Ravioli"
        Me.itemDescriptionLabel.Text = "lil raviolis stuffed with raviolis made from ravioli's finest ravioli"



    End Sub

    Private Sub PastaroniButton_Click(sender As Object, e As EventArgs) Handles PastaroniButton.Click
        Me.itemNameLabel.Text = "Pastaroni"
        Me.itemDescriptionLabel.text = "-Pasta? 
-Macaroni? 
-Pastrami? 
Hey, I never said we had an 'A' Health inspector rating."

    End Sub

    Private Sub mabButton_Click(sender As Object, e As EventArgs) Handles ballmeatButton.Click
        Me.itemNameLabel.Text = "Meat-a-balls"
        Me.itemDescriptionLabel.Text = "Ball meat. Hey, it's extra if you want it cooked"

    End Sub

    Private Sub spaghootButton_Click(sender As Object, e As EventArgs) Handles spaghootButton.Click
        Me.itemNameLabel.Text = "Eh - spaghooti"
        Me.itemDescriptionLabel.Text = "- Pasghetti
- tomato sauce
- Pepperoni
- noodles
- chicken
- horse leg
- pig feet
- cow hooves."

    End Sub
End Class
