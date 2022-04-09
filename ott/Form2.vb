Imports System.Data.SqlClient
Public Class Form2


    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim LoggedIn As New Boolean

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        If (LoginName.Text = "admin" And LoginPassword.Text = "admin123") Then
            MsgBox("Logged in as Admin!", MsgBoxStyle.Information, "Success")
            Me.Hide()
            AdminDash.Show()
        End If

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select password from Users where username='" & LoginName.Text & "' "

        dr = cmd.ExecuteReader()

        While dr.Read()
            If LoginPassword.Text = dr(0) Then
                LoggedIn = True
            Else
                MsgBox("Incorrect Username or password")
            End If
        End While

        If LoggedIn = True Then
            con.Close()
            con.Open()

            Dim cmd2 As New SqlCommand
            Dim dr2 As SqlDataReader

            cmd2.Connection = con
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "select * from Logged where username = '" & LoginName.Text & "' "

            dr2 = cmd2.ExecuteReader

            If dr2.HasRows Then

                con.Close()
                con.Open()

                Dim cmd3 As New SqlCommand
                cmd3.Connection = con
                cmd3.CommandType = CommandType.Text
                cmd3.CommandText = "TRUNCATE TABLE Logged"
                cmd3.ExecuteNonQuery()

                con.Close()
                con.Open()

                Dim cmd4 As New SqlCommand
                cmd4.Connection = con
                cmd4.CommandType = CommandType.Text
                cmd4.CommandText = "INSERT INTO Logged values('" & LoginName.Text & "')"
                cmd4.ExecuteNonQuery()
                UserDash.Show()
                Me.Hide()

            Else

                con.Close()
                con.Open()

                cmd = New SqlCommand("INSERT INTO Logged values('" & LoginName.Text & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Authenticated!")
                Me.Hide()
                UserDash.Show()
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click

        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand

        con2.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con2.Open()
        cmd2.Connection = con2
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "TRUNCATE TABLE Logged"
        cmd2.ExecuteNonQuery()

        MsgBox("Logged Out")
        UserDash.Close()
        AdminDash.Close()
        Form1.Show()


    End Sub
End Class