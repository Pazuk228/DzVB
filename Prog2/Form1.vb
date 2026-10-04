Public Class Form1
    Dim A As Single, B As Single, C As Single, P As Single, Pp As Single, S As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A = Val(TextBox1.Text)
        B = Val(TextBox2.Text)
        C = Val(TextBox3.Text)

        If (A + B > C) And (A + C > B) And (B + C > A) And (A > 0) And (B > 0) And (C > 0) Then
            P = A + B + C
            Pp = P / 2
            S = Math.Sqrt(Pp * (Pp - A) * (Pp - B) * (Pp - C))

            TextBox4.Text = Str(P)
            TextBox5.Text = Str(S)
        Else

            MsgBox("Ошибка" + Chr(13) + "Сумма двух сторон треугольника должна быть больше третьей стороны.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ошибка!!!")

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""


            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class