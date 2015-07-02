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


    Function GetListOfMatches(text As String, expression As String) As List(Of String)
        Dim list As New List(Of String)
        Dim regex = New System.Text.RegularExpressions.Regex(expression)
        Dim matchResult = regex.Match(text)
        While matchResult.Success
            list.Add(matchResult.Groups(1).Value)
            matchResult = matchResult.NextMatch()
        End While

        Return list
    End Function

End Module
