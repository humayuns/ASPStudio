Module ASPUtils


    Function MergeIncludes(text As String) As String
        Return ""
    End Function

    Function GetMergedPage(filename As String) As String

        Dim filecontent = IO.File.ReadAllText(filename)
        Dim filepath = filename.Replace(IO.Path.GetFileName(filename), "")

        Return GetMergedPage(filecontent, filepath)

    End Function

    Function GetMergedPage(filecontent As String, filepath As String) As String
        Dim filecontentmerged = ""

        Dim list As New List(Of String)
        Dim regex = New System.Text.RegularExpressions.Regex(RegexPatterns.ASP_INCLUDE)
        Dim matchResult = regex.Match(filecontent)
        While matchResult.Success
            list.Add(matchResult.Groups(1).Value)

            Dim includefile = matchResult.Value

            If IO.File.Exists(filepath & matchResult.Groups(1).Value) Then
                filecontent = filecontent.Replace(includefile, IO.File.ReadAllText(filepath & matchResult.Groups(1).Value))
            End If
            matchResult = matchResult.NextMatch()
        End While



        Return filecontent
    End Function

    Function GetFunctions(code As String) As List(Of String)
        Return New List(Of String)
    End Function



    Function GetDependantFiles(filename As String, path As String) As List(Of String)
        Dim filelist As New List(Of String)


        For Each file In IO.Directory.GetFiles(path)
            Dim includes = GetListOfIncludeFiles(FileFunctions.GetFileContent(file))

            If includes.Contains(IO.Path.GetFileName(filename)) Then

                filelist.Add(IO.Path.GetFileName(file))
            End If

        Next

        Return filelist
    End Function

    Function GetListOfIncludeFiles(text As String) As List(Of String)
        Return GetListOfMatches(text, ASP_INCLUDE)
    End Function

End Module
