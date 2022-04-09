Imports System.Data.SqlClient

Public Class Reports
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.UserSub' table. You can move, or remove it, as needed.

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
            cmd2.CommandText = "SELECT * FROM UserSub WHERE Username = '" & Username & "'"

            dr2 = cmd2.ExecuteReader

            Do While dr2.Read()
                DataGridView1.Rows.Add(dr2("SubName"), Username, dr2("Months"))
                Chart1.Series(0).Points.AddXY(dr2("SubName"), dr2("Months"))
            Loop


        Else
            MsgBox("no users!")
        End If

        dr.Close()
        con.Close()


    End Sub
End Class