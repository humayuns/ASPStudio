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


    End Sub

    Private Sub btnGenerateMergedPage_Click(sender As Object, e As EventArgs) Handles btnGenerateMergedPage.Click
        RichTextBox1.Text = GetMergedPage(TreeView1.SelectedNode.Tag)

        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        For Each s In GetFunctionsList(RichTextBox1.Text)
            ComboBox1.Items.Add("Function " & s)
        Next

        For Each s In GetSubroutinesList(RichTextBox1.Text)
            ComboBox1.Items.Add("Sub " & s)
        Next

        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        For Each s In GetClassesList(RichTextBox1.Text)
            If Not "%".Contains(s) Then
                ComboBox2.Items.Add("Class " & s)
            End If
        Next
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

    Private Function GetFunctionsList(source As String) As List(Of String)
        Dim fl As New List(Of String)
        Dim regex = New System.Text.RegularExpressions.Regex("[F-f]unction[\s\n]+(\S+)[\s\n]*\(")
        Dim matchResult = regex.Match(source)
        While matchResult.Success
            fl.Add(matchResult.Groups(1).Value)
            matchResult = matchResult.NextMatch()
        End While

        Return fl
    End Function

    Private Function GetSubroutinesList(source As String) As List(Of String)
        Dim fl As New List(Of String)
        Dim regex = New System.Text.RegularExpressions.Regex("[S-s]ub[\s\n]+(\S+)[\s\n]*\(")
        Dim matchResult = regex.Match(source)
        While matchResult.Success
            fl.Add(matchResult.Groups(1).Value)
            matchResult = matchResult.NextMatch()
        End While

        Return fl
    End Function

    Private Function GetClassesList(source As String) As List(Of String)
        Dim cl As New List(Of String)
        Dim regex = New System.Text.RegularExpressions.Regex("[C-c]lass[\s\n]+(\S+)[^\n]")
        Dim matchResult = regex.Match(source)
        While matchResult.Success
            cl.Add(matchResult.Groups(1).Value)
            matchResult = matchResult.NextMatch()
        End While
        Return cl
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        RichTextBoxUtils.HighlightText(RichTextBox1, ComboBox1.Text, Color.Blue)
        RichTextBox1.SelectionStart = Strings.InStr(RichTextBox1.Text, ComboBox1.Text, CompareMethod.Text)
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        RichTextBoxUtils.HighlightText(RichTextBox1, ComboBox2.Text, Color.Blue)
        RichTextBox1.SelectionStart = Strings.InStr(RichTextBox1.Text, ComboBox2.Text, CompareMethod.Text)
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Open Containing Folder"
                Process.Start("explorer.exe", "/select," & TreeView1.SelectedNode.Tag)
        End Select
    End Sub


    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            TreeView1.SelectedNode = e.Node
        End If
    End Sub
End Class
