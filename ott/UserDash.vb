Public Class UserDash
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Hide()
        Reports.Hide()
        AddSub.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminDash.Hide()
        AddSub.Hide()
        Reports.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Hide()
        AddSub.Hide()
        Reports.Show()
    End Sub
End Class