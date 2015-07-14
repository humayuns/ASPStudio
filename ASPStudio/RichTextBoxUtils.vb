
Module RichTextBoxUtils

    <System.Runtime.CompilerServices.Extension> _
    Sub HighlightText(myRtb As RichTextBox, word As String, color__1 As Color)

        If word = "" Then
            Return
        End If

        Dim s_start As Integer = myRtb.SelectionStart, startIndex As Integer = 0, index As Integer

        While (InlineAssignHelper(index, myRtb.Text.IndexOf(word, startIndex, StringComparison.InvariantCultureIgnoreCase))) <> -1
            myRtb.[Select](index, word.Length)
            myRtb.SelectionColor = color__1

            startIndex = index + word.Length
        End While

        myRtb.SelectionStart = s_start
        myRtb.SelectionLength = 0
        myRtb.SelectionColor = Color.Black
    End Sub
    Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
End Module

