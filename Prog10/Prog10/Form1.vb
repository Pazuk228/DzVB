Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vvod As String
        Dim age As Integer
        Dim k As MsgBoxResult

StartInput:
        vvod = InputBox("Введите ваш возраст:", "Определение возраста")


        If vvod = "" Then Exit Sub

        If Not IsNumeric(vvod) OrElse Val(vvod) < 0 Then
            k = MsgBox("Введены некорректные данные! Возраст должен быть положительным числом.", MsgBoxStyle.AbortRetryIgnore + MsgBoxStyle.Critical, "Ошибка ввода")

            If k = MsgBoxResult.Abort Then
                End
            ElseIf k = MsgBoxResult.Retry Then
                GoTo StartInput
            ElseIf k = MsgBoxResult.Ignore Then
                Exit Sub
            End If
        Else
            age = Int(Val(vvod))

            Select Case age
                Case 0 To 1
                    MsgBox("Ваша категория: Младенчество", MsgBoxStyle.Information, "Результат")
                Case 2 To 11
                    MsgBox("Ваша категория: Детство", MsgBoxStyle.Information, "Результат")
                Case 12 To 15
                    MsgBox("Ваша категория: Подростковый возраст", MsgBoxStyle.Information, "Результат")
                Case 16 To 20
                    MsgBox("Ваша категория: Юношеский возраст", MsgBoxStyle.Information, "Результат")
                Case 21 To 35
                    MsgBox("Ваша категория: Молодой возраст", MsgBoxStyle.Information, "Результат")
                Case 36 To 60
                    MsgBox("Ваша категория: Зрелый возраст", MsgBoxStyle.Information, "Результат")
                Case 61 To 75
                    MsgBox("Ваша категория: Пожилой возраст", MsgBoxStyle.Information, "Результат")
                Case 76 To 90
                    MsgBox("Ваша категория: Преклонный возраст", MsgBoxStyle.Information, "Результат")
                Case Is > 90
                    MsgBox("Ваша категория: Возраст долгожителей", MsgBoxStyle.Information, "Результат")
            End Select
        End If
    End Sub

End Class