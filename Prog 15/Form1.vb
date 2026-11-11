Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim strA As String, strB As String
        Dim i As Integer

        strB = ""
        strA = TextBox1.Text

        For i = 1 To Len(strA)
            strB = Mid(strA, i, 1) & strB
        Next i

        TextBox2.Text = strB
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class