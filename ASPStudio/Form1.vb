Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If Strings.Right(TextBox1.Text, 1) <> "\" Then TextBox1.Text &= "\"

        TreeView1.Nodes.Clear()


        For Each f In IO.Directory.GetFiles(TextBox1.Text)


            If TextBox2.Text = "" Or f.ToUpper.Contains(TextBox2.Text.ToUpper) Then
                Dim newnode = TreeView1.Nodes.Add(f.Replace(TextBox1.Text, ""))

                Dim filetext = IO.File.ReadAllText(f)

                If filetext.Contains("#include") Then

                    For i = 1 To CountSubString(filetext, "#include")
                        newnode.Nodes.Add("includes")
                    Next
                End If
            End If
        Next


    End Sub


    Function GetFileText(filename As String) As String
        Return IO.File.ReadAllText(filename)
    End Function



    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If Not TreeView1.SelectedNode Is Nothing AndAlso TreeView1.SelectedNode.Text <> "" Then
            If IO.File.Exists(TextBox1.Text & TreeView1.SelectedNode.Text) Then
                RichTextBox1.Text = IO.File.ReadAllText(TextBox1.Text & TreeView1.SelectedNode.Text)
            End If
        End If
    End Sub

    Function CountSubString(text As String, search As String) As Integer
        Dim Occurrences As Integer = (text.Length - text.Replace(search, String.Empty).Length) / search.Length
        Return Occurrences
    End Function

End Class
