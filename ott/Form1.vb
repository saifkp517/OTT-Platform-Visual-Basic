
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Male")
        ComboBox1.Items.Add("Female")
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saif5\source\repos\ott\ott\Database1.mdf;Integrated Security=True"

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Users where username='" & Username.Text & "' "

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("User has Already registered", MsgBoxStyle.Critical)
            con.Close()
        Else
            con.Close()
            con.Open()

            Dim ms As New MemoryStream

            If (PictureBox1.Image Is Nothing) Then
                MsgBox("Please choose an image")
            End If
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)



                cmd = New SqlCommand("INSERT INTO Users values('" & Username.Text & "', '" & Password.Text & "', '" & ComboBox1.SelectedItem.ToString() & "',@image )", con)
                cmd.Parameters.AddWithValue("@image", ms.ToArray())

                If (Username.Text = "" And Password.Text = "") Then
                    MsgBox("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Successfully registered!", MsgBoxStyle.Information, "Success")
                    Me.Hide()

                    con.Close()
                    con.Open()

                    Dim cmd2 As New SqlCommand
                    cmd2.Connection = con
                    cmd2.CommandType = CommandType.Text
                    cmd2.CommandText = "TRUNCATE TABLE Logged"
                    cmd2.ExecuteNonQuery()

                    Dim cmd3 As New SqlCommand
                    cmd3.Connection = con
                    cmd3.CommandType = CommandType.Text
                    cmd3.CommandText = "INSERT INTO Logged values('" & Username.Text & "')"
                    cmd3.ExecuteNonQuery()

                    AddSub.Show()
                    Username.Clear()
                    Password.Clear()
                End If
                con.Close()
            End If
            con.Close()

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG Files(*.Jpg)|*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
