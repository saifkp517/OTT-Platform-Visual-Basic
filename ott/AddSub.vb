Imports System.Data.SqlClient

Public Class AddSub
    Private Sub AddSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListBox2.Items.Add("Yearly")
        ListBox2.Items.Add("Quarterly")
        ListBox2.Items.Add("Monthly")

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
        Payment.Label7.Text = ListBox1.SelectedItem.ToString()
        Payment.Label8.Text = ListBox2.SelectedItem.ToString()
        Me.Hide()
        Payment.Show()
    End Sub


End Class