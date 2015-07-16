Public Class RegexTest

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtRegex.TextChanged


        txtMatch.Text = ""
        txtGroup0.Text = ""
        txtGroup1.Text = ""
        txtGroup2.Text = ""

        Try

            txtMatch.Text = RegexPatterns.Match(txtSample.Text, txtRegex.Text)

        Catch ex As Exception

        End Try


        Try
            Dim groups = RegexPatterns.MatchGroups(txtSample.Text, txtRegex.Text)

            If groups.Count > 0 Then
                txtGroup0.Text = groups(0).Value
            End If

            If groups.Count > 1 Then
                txtGroup1.Text = groups(1).Value
            End If

            If groups.Count > 2 Then
                txtGroup2.Text = groups(2).Value
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class