Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double

        If Not IsNumeric(TextBox1.Text) Or Not IsNumeric(TextBox2.Text) Then
            MsgBox("Пожалуйста, введите корректные числа в оба поля", MsgBoxStyle.Critical, "Ошибка ввода")
            Exit Sub
        End If

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)

        If a > b Then
            MsgBox("Максимальное число: " & a, MsgBoxStyle.Information, "Результат")
        ElseIf b > a Then
            MsgBox("Максимальное число: " & b, MsgBoxStyle.Information, "Результат")
        Else
            MsgBox("Числа равны", MsgBoxStyle.Information, "Результат")
        End If
    End Sub
End Class