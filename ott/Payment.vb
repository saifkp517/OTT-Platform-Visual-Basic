Imports System.Data.SqlClient


Public Class Payment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "") Then
            MsgBox("Please enter all the details", MsgBoxStyle.Critical)
        Else

            Dim Valid As Boolean

            Dim chars() As Char = TextBox2.Text
            Dim cv As String = TextBox4.Text

            Dim ret As Boolean
            ret = IsNumeric(cv)

            Do
                For Each c As Char In chars
                    If Not IsNumeric(c) Then
                        MsgBox("enter only numbers")
                        Valid = False
                        Exit Do
                    ElseIf (TextBox2.TextLength < 10) Then
                        MsgBox("enter 10 digits")
                        Valid = False
                        Exit Do
                    ElseIf (TextBox4.TextLength > 3) Then
                        MsgBox("only 3 digits should be entered")
                        Valid = False
                        Exit Do
                    ElseIf (ret = False) Then
                        MsgBox("enter only numbers")
                        Valid = False
                        Exit Do
                    Else
                        Valid = True
                    End If

                Next
            Loop While False

            If (Valid = True) Then
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

                    Dim cmd4 As New SqlCommand
                    Dim dr4 As SqlDataReader

                    Dim SubPrice As Integer

                    con.Close()
                    con.Open()

                    Dim cmd2 As New SqlCommand
                    cmd2.Connection = con

                    cmd4.Connection = con

                    Dim Months As Integer

                    Dim Plan As String = Label8.Text

                    If (Plan.Contains("Yearly")) Then

                        Months = 12

                        cmd4.CommandText = "SELECT AnnualPrice FROM Subscriptions WHERE SubName = '" & Label7.Text & "'"

                        dr4 = cmd4.ExecuteReader

                        While dr4.Read
                            SubPrice = dr4(0)
                        End While


                        con.Close()
                        con.Open()

                        cmd2.CommandText = "INSERT INTO UserSub values('" & Label7.Text & "', '" & Username & "', '" & Months & "', '" & SubPrice & "')"
                        cmd2.ExecuteNonQuery()

                        MsgBox("Successfully purchased the subscription", MsgBoxStyle.Information, "Success")

                    ElseIf (Plan.Contains("Quarterly")) Then

                        Months = 4

                        cmd4.CommandText = "SELECT QuarterlyPrice FROM Subscriptions WHERE SubName = '" & Label7.Text & "'"
                        dr4 = cmd4.ExecuteReader

                        While dr4.Read
                            SubPrice = dr4(0)
                        End While


                        con.Close()
                        con.Open()

                        cmd2.CommandText = "INSERT INTO UserSub values('" & Label7.Text & "', '" & Username & "', '" & Months & "', '" & SubPrice & "')"
                        cmd2.ExecuteNonQuery()

                        MsgBox("Successfully purchased the subscription", MsgBoxStyle.Information, "Success")


                    ElseIf (Plan.Contains("Monthly")) Then

                        Months = 1

                        cmd4.CommandText = "SELECT MonthlyPrice FROM Subscriptions WHERE SubName = '" & Label7.Text & "'"
                        dr4 = cmd4.ExecuteReader

                        While dr4.Read
                            SubPrice = dr4(0)
                        End While


                        con.Close()
                        con.Open()

                        cmd2.CommandText = "INSERT INTO UserSub values('" & Label7.Text & "', '" & Username & "', '" & Months & "', '" & SubPrice & "')"
                        cmd2.ExecuteNonQuery()

                        MsgBox("Successfully purchased the subscription", MsgBoxStyle.Information, "Success")

                    End If

                    Dim cmd3 As New SqlCommand
                    Dim dr3 As SqlDataReader

                    con.Close()
                    con.Open()

                    cmd3.Connection = con
                    cmd3.CommandType = CommandType.Text
                    cmd3.CommandText = "INSERT INTO payment values('" & Label2.Text & "', '" & Label1.Text & "', '" & Label3.Text & "')"

                    UserDash.Show()
                    Me.Hide()

                Else
                    MsgBox("no users!")
                End If
                con.Close()

            End If

        End If
    End Sub

End Class