﻿Imports System.Data.SqlClient

Public Class Payment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text) Then
            MsgBox("Please enter all the details", MsgBoxStyle.Critical)
        Else

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
                cmd2.CommandText = "INSERT INTO UserSub values('" & Label7.Text & "', '" & Username & "', '" & TextBox5.Text & "')"
                cmd2.ExecuteNonQuery()

                MsgBox("Successfully purchased the subscription", MsgBoxStyle.Information, "Success")
                UserDash.Show()


            Else
                MsgBox("no users!")
            End If
            con.Close()

        End If
    End Sub
End Class