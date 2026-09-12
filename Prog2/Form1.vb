Public Class Form1
    Dim A As Single, B As Single, C As Single, P As Single, Pp As Single, S As Single

    ' Кнопка Button1 — «Вычислить»
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A = Val(TextBox1.Text)
        B = Val(TextBox2.Text)
        C = Val(TextBox3.Text)

        P = A + B + C
        Pp = P / 2
        S = Math.Sqrt(Pp * (Pp - A) * (Pp - B) * (Pp - C))

        TextBox4.Text = Str(P)
        TextBox5.Text = Str(S)
    End Sub

    ' Кнопка Button2 — «Выход»
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
