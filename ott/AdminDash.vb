﻿Public Class AdminDash
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Hide()
        Subscriptions.Hide()
        Users.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Hide()
        Users.Hide()
        Subscriptions.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UserDash.Hide()
        Subscriptions.Hide()
        Users.Hide()
        Form2.Show()
    End Sub
End Class