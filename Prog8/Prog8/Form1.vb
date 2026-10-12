Public Class Form1
    Dim vvod As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double
        Dim y As Integer
        Dim v As String, w As String

        ' Вывод окна для ввода числа пользователем
        vvod = InputBox("Введите число от 1 до 999", "Количество цифр", "1", -1, -1)

        ' 1. Проверка на пустую строку (если нажали Отмена или ничего не ввели)
        If vvod = "" Then Exit Sub

        ' 2. Проверка на то, что введенный текст является числом
        If Not IsNumeric(vvod) Then
            MsgBox("Ошибка ввода!!!", 16, "Ошибка")
            Exit Sub
        End If

        x = Val(vvod)

        ' 3. Проверка на диапазон от 1 до 999 и на то, что число целое
        If x < 1 Or x > 999 Or x <> Int(x) Then
            MsgBox("Ошибка ввода!!!", 16, "Ошибка")
            Exit Sub
        End If

        ' Определение количества цифр с помощью Select Case
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

        ' Склонение слова "цифра"
        If y = 1 Then
            w = "цифры"
        Else
            w = "цифр"
        End If

        ' Вывод итогового результата с информационной иконкой (код 64)
        MsgBox("Ваше число " & vvod & Chr(13) & "состоит из " & v & " " & w, 64, "Результат")
    End Sub
End Class
