Imports System.Data.SqlClient

Public Class Users
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Users"

        dr = cmd.ExecuteReader()

        While dr.Read()
            ListBox1.Items.Add(dr(0))
        End While

        dr.Close()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "DELETE FROM Users WHERE username='" & ListBox1.SelectedItem.ToString() & "'"
        cmd.ExecuteNonQuery()

        Dim cmd2 As New SqlCommand

        con.Close()

        ListBox1.Items.Remove(ListBox1.SelectedItem.ToString())

        MsgBox("User Has Been deleted!", MsgBoxStyle.Information, "Success")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim User As String = ListBox1.SelectedItem.ToString()

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM UserSub WHERE username='" & ListBox1.SelectedItem.ToString() & "'"

        If (ListBox1.SelectedItems.ToString() <> User) Then
            ListBox2.Items.Clear()
        End If

        Dim dr As SqlDataReader

        dr = cmd.ExecuteReader()

        Do While dr.Read()
            ListBox2.Items.Add(dr(0))
        Loop

    End Sub
End Class