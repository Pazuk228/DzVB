Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim k As Double, z As Double, t As Double, x As Double, y As Double
        Dim vvod As String = TextBox1.Text

        If Not IsNumeric(vvod) Then
            MsgBox("Введите число !!!", MsgBoxStyle.Critical, "Ошибка!!!")
            Exit Sub
        End If

        k = Val(vvod)

        If k < 0 Or k > 10 Then
            MsgBox("Значение k должно быть в диапазоне [0; 10].", MsgBoxStyle.Critical, "Ошибка!!!")
            Exit Sub
        End If

        If k = 0 Then
            z = 10
        Else
            z = Math.Sin(k)
        End If

        t = 1 / (1 + Math.Exp(k))
        x = (3 * z + Math.Tan(t * z)) / (t + 1)

        Dim underRoot As Double = 1 + Math.Sin(x) ^ 3
        Dim logArg As Double = Math.Sin(x) ^ 2 + Math.Sqrt(underRoot)
        y = x ^ (t * k) + Math.Log10(logArg)

        Label2.Text = "z = " & z.ToString("0.0000000")
        Label3.Text = "t = " & t.ToString("0.0000000")
        Label4.Text = "x = " & x.ToString("0.0000000")
        Label5.Text = "y = " & y.ToString("0.0000000")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""

        TextBox1.Focus()
    End Sub
End Class