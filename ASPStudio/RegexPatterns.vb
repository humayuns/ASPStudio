Imports System.Text.RegularExpressions

Module RegexPatterns



    'Regular expression for selecting procedure of classic asp
    ' http://stackoverflow.com/questions/21901096/regular-expression-for-selecting-procedure-of-classic-asp?rq=1

    ' ^\s*(Sub.*?)^\s*End Sub
    ' Sub SubName[\s\S]*?End Sub

    Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        Return emailExpression.IsMatch(email)
    End Function

End Module
