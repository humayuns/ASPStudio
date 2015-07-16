Public Class RegexTest

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtRegex.TextChanged
        Try

            txtMatch.Text = RegexPatterns.Match(txtSample.Text, txtRegex.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class