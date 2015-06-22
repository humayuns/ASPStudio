Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        For Each f In IO.Directory.GetFiles(TextBox1.Text)


            Dim newnode = TreeView1.Nodes.Add(f.Replace(TextBox1.Text, ""))

            Dim filetext = IO.File.ReadAllText(f)

            If filetext.Contains("#include") Then
                newnode.Nodes.Add("includes")
            End If
        Next


    End Sub


    Function GetFileText(filename As String) As String
        Return IO.File.ReadAllText(filename)
    End Function

    
End Class
