Imports System.Data.SqlClient

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader


        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Subscriptions where SubName='" & SubName.Text & "' "

        dr = cmd.ExecuteReader

        If dr.HasRows Then
            MsgBox("Subscription has already been bought", MsgBoxStyle.Critical)
            con.Close()
        Else
            con.Close()
            con.Open()

            Dim cmd2 As New SqlCommand
            Dim dr2 As SqlDataReader


            cmd2.Connection = con
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "select * from Logged"
            dr2 = cmd2.ExecuteReader


            If dr2.HasRows Then

                MsgBox("HasRows")

                Dim Username As String

                While dr2.Read

                    Username = dr2(0)
                    MsgBox(Username)

                End While

                con.Close()
                con.Open()

                Dim cmd3 As New SqlCommand("INSERT INTO Subscriptions values('" & SubName.Text & "', '" & SubPrice.Text & "', '" & Username & "')", con)

                If (SubName.Text = "" And SubPrice.Text = "") Then
                    MsgBox("Please enter the details")
                Else

                    cmd3.ExecuteNonQuery()
                    MsgBox("Successfully added subscription", MsgBoxStyle.Information, "Success")
                    SubPrice.Clear()
                    SubName.Clear()
                End If

                con.Close()
            Else
                MsgBox("no users bitch!, more like cant fetch users dumbass")
            End If
        End If
        con.Close()


    End Sub


End Class