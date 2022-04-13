Imports System.Data.SqlClient

Public Class Feedbacks
    Private Sub Feedbacks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Feedback"

        dr = cmd.ExecuteReader

        Do While dr.Read()
            ListBox1.Items.Add("" & dr(0) & ": " & dr(1) & "")
        Loop

        con.Close()
        dr.Close()

    End Sub
End Class