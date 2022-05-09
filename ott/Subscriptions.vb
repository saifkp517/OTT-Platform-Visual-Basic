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

        Dim SubscriptionName As String = SubName.Text
        Dim AnnualPrice As String = AnnualSubPrice.Text
        Dim QuarterlyPrice As String = QuarterlySubPrice.Text
        Dim MonthlyPrice As String = MonthlySubPrice.Text

        Dim Valid As Boolean

        Dim ret1 As Boolean = IsNumeric(SubscriptionName)
        Dim ret2 As Boolean = IsNumeric(AnnualPrice)
        Dim ret3 As Boolean = IsNumeric(QuarterlyPrice)
        Dim ret4 As Boolean = IsNumeric(MonthlyPrice)

        If (AnnualSubPrice.Text = "" Or QuarterlySubPrice.Text = "" Or MonthlySubPrice.Text = "" Or SubName.Text = "") Then
            MsgBox("please enter all the values")
        Else
            If (ret1 = True) Then
                MsgBox("cant enter numbers")
                Valid = False
            ElseIf (ret2 = False) Then
                MsgBox("enter only numbers")
                Valid = False
            ElseIf (ret3 = False) Then
                MsgBox("enter only numbers")
                Valid = False
            ElseIf (ret4 = False) Then
                MsgBox("enter only numbers")
                Valid = False
            Else
                Valid = True
            End If
        End If

        If Valid = True Then
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

                Dim cmd3 As New SqlCommand("INSERT INTO Subscriptions values('" & SubName.Text & "', '" & AnnualSubPrice.Text & "', '" & QuarterlySubPrice.Text & "', '" & MonthlySubPrice.Text & "')", con)
                If (SubName.Text = "" And AnnualSubPrice.Text = "" And QuarterlySubPrice.Text = "" And MonthlySubPrice.Text = "") Then
                    MsgBox("Please enter all the details")
                Else
                    cmd3.ExecuteNonQuery()
                    MsgBox("Successfully added subscription", MsgBoxStyle.Information, "Success")

                    ListBox1.Items.Add(SubName.Text)

                    AnnualSubPrice.Clear()
                    SubName.Clear()

                End If

                con.Close()
            End If
            con.Close()
        End If

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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class