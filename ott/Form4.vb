Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Series(0).Points.AddXY("April", 110)
        Chart1.Series(0).Points.AddXY("May", 80)
        Chart1.Series(0).Points.AddXY("June", 100)
        Chart1.Series(0).Points.AddXY("July", 60)
    End Sub
End Class