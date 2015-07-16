Imports System.Text.RegularExpressions

Module RegexPatterns


    Public Const ASP_INCLUDE_NEW = "<!--\s*#Include\s*File\s*=\s*""([^""]+)""\s*-->"
    Public Const ASP_INCLUDE = "<!--\s#include\s*file[\s]*=[\s]*""([^""]+)""\s-->" ' "#include\s*file[\s]*=[\s]*""([^""]+)"""
    Public Const ASP_SUB_OLD = "[S-s]ub[\s\n]+(\S+)[\s\n]*\("

    Public Const JAVASCRIPT_INCLUDE = "<script\ssrc\s*=[\s]*""([^""]+)""\s*"


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
        Dim regex = New System.Text.RegularExpressions.Regex(expression, RegexOptions.IgnoreCase Or RegexOptions.Multiline)
        Dim matchResult = regex.Match(text)
        While matchResult.Success
            list.Add(matchResult.Groups(1).Value)
            matchResult = matchResult.NextMatch()
        End While

        Return list
    End Function

    Function Match(text As String, expression As String) As String
        Dim regex = New System.Text.RegularExpressions.Regex(expression, RegexOptions.IgnoreCase Or RegexOptions.Multiline)
        Dim matchResult = regex.Match(text)

        Return matchResult.Value
    End Function

    Function MatchGroups(text As String, expression As String) As GroupCollection
        Dim regex = New System.Text.RegularExpressions.Regex(expression, RegexOptions.IgnoreCase Or RegexOptions.Multiline)
        Dim matchResult = regex.Match(text)
        Return matchResult.Groups
    End Function



End Module
