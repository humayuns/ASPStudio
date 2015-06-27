Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If Strings.Right(TextBox1.Text, 1) <> "\" Then TextBox1.Text &= "\"

        TreeView1.Nodes.Clear()
        RichTextBox1.Clear()
        TextBox3.Clear()

        For Each f In IO.Directory.GetFiles(TextBox1.Text)


            If TextBox2.Text = "" Or f.ToUpper.Contains(TextBox2.Text.ToUpper) Then
                Dim newnode = TreeView1.Nodes.Add(f.Replace(TextBox1.Text, ""))
                newnode.Tag = f

                Dim filetext = IO.File.ReadAllText(f)

                'AddNodes(f, filetext, newnode)

                Try
                    AddNodes(f, filetext, newnode)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try


            End If
        Next


    End Sub

    Private Sub AddNodes(filename As String, filetext As String, node As TreeNode)
        For Each s In GetListOfIncludes(filetext:=filetext)
            Dim newnode = node.Nodes.Add(s.Replace("../", ""))
            Dim newpath = IO.Path.GetDirectoryName(filename) & "\"
            newnode.Tag = newpath & s
            Dim newfiletext = IO.File.ReadAllText(newpath & s)

            AddNodes(newpath & s, newfiletext, newnode)
        Next
    End Sub


    Function GetFileText(filename As String) As String
        Return IO.File.ReadAllText(filename)
    End Function



    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If Not TreeView1.SelectedNode Is Nothing AndAlso TreeView1.SelectedNode.Text <> "" Then
            If IO.File.Exists(TreeView1.SelectedNode.Tag) Then
                RichTextBox1.Text = IO.File.ReadAllText(TreeView1.SelectedNode.Tag)
                TextBox3.Text = TreeView1.SelectedNode.FullPath
            End If
        End If
    End Sub



    Function GetListOfIncludes(filetext As String) As List(Of String)
        Dim list As New List(Of String)
        Dim regex = New System.Text.RegularExpressions.Regex("#include\W+file[\s]*=[\s]*""([^""]+)""")
        Dim matchResult = regex.Match(filetext)
        While matchResult.Success
            list.Add(matchResult.Groups(1).Value)
            matchResult = matchResult.NextMatch()
        End While

        Return list
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "C:\Users\Humayun\Documents\Pentius\VaultCode\IIS1\Staging\myscore.com\"
        TextBox2.Text = ""

    End Sub

    Private Sub btnGenerateMergedPage_Click(sender As Object, e As EventArgs) Handles btnGenerateMergedPage.Click
        RichTextBox1.Text = GetMergedPage(TreeView1.SelectedNode.Tag)
    End Sub

    Private Function GetMergedPage(filename As String) As String

        Dim filecontent = IO.File.ReadAllText(filename)
        Dim filepath = filename.Replace(IO.Path.GetFileName(filename), "")

        Dim filecontentmerged = ""

        Dim list As New List(Of String)
        Dim regex = New System.Text.RegularExpressions.Regex("<!-- #include\W+file[\s]*=[\s]*""([^""]+)"" -->")
        Dim matchResult = regex.Match(filecontent)
        While matchResult.Success
            list.Add(matchResult.Groups(1).Value)

            Dim includefile = matchResult.Value


            filecontent = filecontent.Replace(includefile, IO.File.ReadAllText(filepath & matchResult.Groups(1).Value))

            matchResult = matchResult.NextMatch()
        End While



        Return filecontent
    End Function


    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim s As String()
            s = e.Data.GetData(DataFormats.FileDrop)
            If FileFunctions.IsFile(s(0)) Then
                TextBox1.Text = FileFunctions.GetFilePath(s(0))
                TextBox2.Text = FileFunctions.GetFileName(s(0))
                Button1.PerformClick()
            Else
                TextBox1.Text = s(0)
            End If
        End If
    End Sub

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
End Class
