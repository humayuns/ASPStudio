Module StringFunctions


    Function CountSubString(text As String, search As String) As Integer
        Dim Occurrences As Integer = (text.Length - text.Replace(search, String.Empty).Length) / search.Length
        Return Occurrences
    End Function

End Module
