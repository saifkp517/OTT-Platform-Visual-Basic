Imports System.Data.SqlClient

Public Class Feedback
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT TOP 1 * FROM Logged ORDER BY username DESC"

        dr = cmd.ExecuteReader

        If dr.HasRows Then

            Dim Username As String

            While dr.Read
                Username = dr(0)
            End While

            Dim cmd2 As New SqlCommand
            Dim dr2 As SqlDataReader

            con.Close()
            con.Open()

            cmd2.Connection = con
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "INSERT INTO Feedback VALUES('" & Username & "', '" & RichTextBox1.Text & "')"

            cmd2.ExecuteReader()
            MsgBox("Message sent to admin")
            RichTextBox1.Clear()


            con.Close()


        Else
            MsgBox("no users!")
        End If
    End Sub
End Class