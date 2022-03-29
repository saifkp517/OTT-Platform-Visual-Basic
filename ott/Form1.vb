
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Users where username='" & Username.Text & "' "

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("User has Already registered", MsgBoxStyle.Critical)
            con.Close()
        Else
            con.Close()
            con.Open()
            cmd = New SqlCommand("INSERT INTO Users values('" & Username.Text & "', '" & Password.Text & "')", con)

            If (Username.Text = "" And Password.Text = "") Then
                MsgBox("Please enter the details")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully registered!", MsgBoxStyle.Information, "Success")
                Me.Hide()
                Form2.Show()
                Username.Clear()
                Password.Clear()
            End If
            con.Close()
        End If
        con.Close()

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
