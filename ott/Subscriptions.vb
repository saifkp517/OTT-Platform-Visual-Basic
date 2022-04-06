Imports System.Data.SqlClient

Public Class Subscriptions
    Private Sub Subscriptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Subscriptions"

        dr = cmd.ExecuteReader()

        While dr.Read()
            ListBox1.Items.Add(dr(0))
        End While

        dr.Close()
        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        Dim cmd2 As New SqlCommand


        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Subscriptions where SubName='" & SubName.Text & "' "

        dr = cmd.ExecuteReader

        If dr.HasRows Then
            MsgBox("Subscription is already present", MsgBoxStyle.Critical)
            con.Close()
        Else
            con.Close()
            con.Open()

            Dim cmd3 As New SqlCommand("INSERT INTO Subscriptions values('" & SubName.Text & "', '" & SubPrice.Text & "')", con)
            If (SubName.Text = "" And SubPrice.Text = "") Then
                MsgBox("Please enter the details")
            Else
                cmd3.ExecuteNonQuery()
                MsgBox("Successfully added subscription", MsgBoxStyle.Information, "Success")

                ListBox1.Items.Add(SubName.Text)

                SubPrice.Clear()
                SubName.Clear()

            End If

            con.Close()
        End If
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "DELETE FROM Subscriptions WHERE SubName='" & ListBox1.SelectedItem.ToString() & "'"
        cmd.ExecuteNonQuery()

        con.Close()

        ListBox1.Items.Remove(ListBox1.SelectedItem.ToString())

        MsgBox("User Has Been deleted!", MsgBoxStyle.Information, "Success")
    End Sub
End Class