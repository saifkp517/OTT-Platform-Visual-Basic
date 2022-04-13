Public Class AdminDash
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Hide()
        Subscriptions.Hide()
        Users.Show()
        Feedbacks.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Hide()
        Users.Hide()
        Feedbacks.Hide()
        Subscriptions.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UserDash.Hide()
        Subscriptions.Hide()
        Users.Hide()
        Form2.Show()
        Feedbacks.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Feedbacks.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Users.Hide()
        UserDash.Hide()
        Form1.Show()
        Feedbacks.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Hide()
        Users.Hide()
        Subscriptions.Hide()
        Feedbacks.Show()
    End Sub
End Class