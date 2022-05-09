Imports System.Data.SqlClient

Public Class AddSub
    Private Sub AddSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim cmd2 As New SqlCommand
        Dim dr2 As SqlDataReader
        Dim con As New SqlConnection

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd2.Connection = con
        cmd2.CommandText = "SELECT * FROM Subscriptions where SubName = '" & ListBox1.SelectedItem & "'"

        Dim Annual As Integer
        Dim Quarterly As Integer
        Dim Monthly As Integer

        dr2 = cmd2.ExecuteReader

        While dr2.Read
            Annual = dr2("AnnualPrice")
            Quarterly = dr2("QuarterlyPrice")
            Monthly = dr2("MonthlyPrice")
        End While
        ListBox2.Items.Clear()
        ListBox2.Items.Add("Yearly Plan -/ ₹" & Annual & "")
        ListBox2.Items.Add("Quarterly Plan -/₹" & Quarterly & "")
        ListBox2.Items.Add("Monthly Plan -/₹" & Monthly & "")
    End Sub
End Class