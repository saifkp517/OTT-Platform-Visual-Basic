Imports System.Text.RegularExpressions

Module Module1
    Public Function IsNumbers(ByVal cardno As String) As Boolean
        Dim validation As New Regex("/^\d+$/")
        Return validation.IsMatch(cardno)
    End Function

    Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        Return emailExpression.IsMatch(email)
    End Function
End Module


