Module ASPUtils


    Function MergeIncludes(text As String) As String
        Return ""
    End Function

    Function GetFunctions(code As String) As List(Of String)
        Return New List(Of String)
    End Function



    Function GetDependantFiles(filename As String, path As String) As List(Of String)
        Dim filelist As New List(Of String)


        For Each file In IO.Directory.GetFiles(path)
            Dim includes = RegexPatterns.GetListOfIncludeFiles(FileFunctions.GetFileContent(file))

            If includes.Contains(IO.Path.GetFileName(filename)) Then

                filelist.Add(IO.Path.GetFileName(file))
            End If

        Next

        Return filelist
    End Function

End Module
