Imports System.Data.SqlClient

Public Class UserDash
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Hide()
        Reports.Hide()
        About.Hide()
        AddSub.Show()
        Feedback.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminDash.Hide()
        AddSub.Hide()
        About.Hide()
        Reports.Hide()
        Feedback.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Hide()
        About.Hide()
        AddSub.Hide()
        Reports.Show()
        Feedback.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand

        con2.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con2.Open()
        cmd2.Connection = con2
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "TRUNCATE TABLE Logged"
        cmd2.ExecuteNonQuery()

        MsgBox("Logged Out")

        About.Hide()
        Form1.Show()
        AdminDash.Hide()
        Feedback.Hide()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        About.Show()
        Form2.Hide()
        AddSub.Hide()
        Reports.Hide()
        Feedback.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        About.Hide()
        Form2.Hide()
        AddSub.Hide()
        Reports.Hide()
        Feedback.Show()
    End Sub
End Class