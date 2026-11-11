Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Vse_glasnie As String, Fraza As String, Vstrechennie_glasnie As String
        Dim t As String
        Dim n As Integer, i As Integer, d As Integer

        Vse_glasnie = "аеёиоуыэюяАЕЁИОУЫЭЮЯ"

        Fraza = TextBox1.Text
        Vstrechennie_glasnie = ""
        n = Len(Fraza)

        For i = 1 To n
            t = Mid(Fraza, i, 1)
            If InStr(Vse_glasnie, t) <> 0 Then
                If InStr(Vstrechennie_glasnie, t) = 0 Then
                    Vstrechennie_glasnie = Vstrechennie_glasnie & t
                End If
            End If
        Next i

        d = Len(Vstrechennie_glasnie)

        Select Case d
            Case 0
                Label2.Text = "Гласных нет"
                TextBox2.Visible = False
            Case 1
                TextBox2.Visible = True
                Label2.Text = "Встреченная гласная:"
                TextBox2.Text = Vstrechennie_glasnie
            Case Else
                TextBox2.Visible = True
                Label2.Text = "Встреченные гласные:"
                TextBox2.Text = Vstrechennie_glasnie
        End Select
    End Sub
End Class