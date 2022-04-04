Imports System.Data.SqlClient

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim starts As DateTime = Date.Today
        Dim ends As DateTime = DateTimePicker1.Value
        Dim result As TimeSpan = ends.Subtract(starts)
        Dim days As Integer = result.TotalDays



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

                Dim Username As String

                While dr2.Read
                    Username = dr2(0)
                End While

                con.Close()
                con.Open()

                Dim cmd3 As New SqlCommand("INSERT INTO Subscriptions values('" & SubName.Text & "', '" & SubPrice.Text & "', '" & Username & "', '" & starts & "', '" & ends & "', '" & days & "')", con)

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

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmd3 As New SqlCommand
        Dim con3 As New SqlConnection
        Dim dr3 As SqlDataReader

        Dim cmd4 As New SqlCommand
        Dim dr4 As SqlDataReader

        con3.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con3.Open()

        cmd4.Connection = con3
        cmd4.CommandType = CommandType.Text
        cmd4.CommandText = "SELECT TOP 1 * FROM Logged ORDER BY username DESC"

        dr4 = cmd4.ExecuteReader

        Dim LoggedUsername As String
        While dr4.Read
            LoggedUsername = dr4(0)
        End While

        dr4.Close()

        cmd3.Connection = con3
        cmd3.CommandType = CommandType.Text
        cmd3.CommandText = "select SubName from Subscriptions where Username='" & LoggedUsername & "'"
        dr3 = cmd3.ExecuteReader

        Do While dr3.Read
            ListBox1.Items.Add(dr3("SubName"))
        Loop

        dr3.Close()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim subcmd As New SqlCommand
        Dim subdr As SqlDataReader
        Dim subcon As New SqlConnection

        subcon.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        subcon.Open()

        subcmd.Connection = subcon
        subcmd.CommandType = CommandType.Text
        subcmd.CommandText = "SELECT * FROM Subscriptions WHERE SubName = '" & ListBox1.SelectedItem & "'"

        subdr = subcmd.ExecuteReader

        While subdr.Read
            Dim SubName As String = subdr(0)
            Dim SubPrice As String = subdr(1)
            Dim Starts As Date = subdr(3)
            Dim Ends As Date = subdr(4)
            Dim days As Integer = subdr(5)

            Form4.Label1.Text = SubName
            Form4.Label2.Text = SubPrice
            Form4.Label3.Text = Starts
            Form4.Label4.Text = Ends
            Form4.Label5.Text = days
            Form4.Show()

        End While



    End Sub
End Class