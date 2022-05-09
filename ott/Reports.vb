Imports System.Data.SqlClient
Imports System.IO

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

            Label6.Text = Username

            con.Close()
            con.Open()

            cmd2.Connection = con
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "SELECT * FROM UserSub WHERE Username = '" & Username & "'"

            dr2 = cmd2.ExecuteReader

            Dim Sum As Integer

            Do While dr2.Read()
                DataGridView1.Rows.Add(dr2("SubName"), Username, dr2("Months"), dr2("SubPrice"))
                Chart1.Series(0).Points.AddXY(dr2("SubName"), dr2("SubPrice"))
                Chart2.Series(0).Points.AddXY(dr2("SubName"), dr2("SubPrice"))
                Sum += dr2("SubPrice")
            Loop

            Label4.Text = Sum

            Dim cmd3 As New SqlCommand
            Dim da As New SqlDataAdapter(cmd3)
            Dim dt As New DataTable

            con.Close()
            con.Open()

            cmd3.Connection = con
            cmd3.CommandText = "SELECT image FROM Users WHERE username = '" & Username & "'"

            da.Fill(dt)
            Dim img() As Byte
            img = dt.Rows(0)(0)
            Dim ms As New MemoryStream(img)

            PictureBox1.Image = Image.FromStream(ms)

            con.Close()


        Else
            MsgBox("no users currently logged in, please login and try again!", MsgBoxStyle.Critical)
        End If

        dr.Close()
        con.Close()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim Index As Integer
        Index = e.RowIndex

        Dim Name As String = DataGridView1.Item(0, Index).Value

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader


        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT SubName FROM Subscriptions WHERE SubName = '" & Name & "'"

        dr = cmd.ExecuteReader

        While dr.Read
            MsgBox(dr(0))
        End While

    End Sub
End Class