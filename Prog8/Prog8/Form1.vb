Public Class Form1
    Dim vvod As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double
        Dim y As Integer
        Dim v As String, w As String

        vvod = InputBox("Введите число от 1 до 999", "Количество цифр", "1", -1, -1)

        If vvod = "" Then Exit Sub

        If Not IsNumeric(vvod) Then
            MsgBox("Ошибка ввода!!!", 16, "Ошибка")
            Exit Sub
        End If

        x = Val(vvod)

        If x < 1 Or x > 999 Or x <> Int(x) Then
            MsgBox("Ошибка ввода!!!", 16, "Ошибка")
            Exit Sub
        End If

        Select Case x
            Case Is < 10
                y = 1
                v = "одной"
            Case Is < 100
                y = 2
                v = "двух"
            Case Else
                y = 3
                v = "трех"
        End Select

        If y = 1 Then
            w = "цифры"
        Else
            w = "цифр"
        End If

        MsgBox("Ваше число " & vvod & Chr(13) & "состоит из " & v & " " & w, 64, "Результат")
    End Sub
End Class
