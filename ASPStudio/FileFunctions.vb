Module FileFunctions


    Function IsFile(path As String) As Boolean
        Return IO.File.Exists(path)

    End Function

    Function GetFilePath(path As String) As String
        Return IO.Path.GetDirectoryName(path)
    End Function

    Function GetFileName(path As String) As String

        Return IO.Path.GetFileName(path)
    End Function

    Function GetFileContent(filename As String) As String
        Return IO.File.ReadAllText(filename)
    End Function




End Module
