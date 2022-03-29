Imports System.Data.SqlClient
Public Class Form2
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim LoggedIn As New Boolean

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select password from Users where username='" & LoginName.Text & "' "

        dr = cmd.ExecuteReader()

        While dr.Read()
            If LoginPassword.Text = dr(0) Then
                MsgBox("Authenticated")
                LoggedIn = True
                Me.Hide()
                Form3.Show()
            Else
                MsgBox("Incorrect Username or password")
            End If
        End While

        If LoggedIn = True Then
            con.Close()
            con.Open()
            cmd = New SqlCommand("INSERT INTO Logged values('" & LoginName.Text & "')", con)
            cmd.ExecuteNonQuery()
        End If

    End Sub
End Class