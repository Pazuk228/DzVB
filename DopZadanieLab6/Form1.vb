Imports System.Reflection.Emit

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputStr As String = TextBox1.Text
        If Len(inputStr) = 0 Then Exit Sub

        Dim result As String = Mid(inputStr, 1, 1)
        Dim prevChar As String, currChar As String

        For i As Integer = 2 To Len(inputStr)
            prevChar = Mid(inputStr, i - 1, 1)
            currChar = Mid(inputStr, i, 1)
            If LCase(currChar) <> LCase(prevChar) Then
                result &= currChar
            End If
        Next i

        TextBox2.Text = result
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim inputStr As String = Trim(TextBox1.Text)
        If Len(inputStr) = 0 Then Exit Sub

        Dim words() As String = Split(inputStr, " ")
        If words.Length = 0 Then Exit Sub

        Dim targetLetter As String = LCase(Mid(words(0), 1, 1))
        Dim count As Integer = 0

        For Each w As String In words
            If Len(w) > 0 Then
                If LCase(Mid(w, 1, 1)) = targetLetter Then
                    count += 1
                End If
            End If
        Next

        TextBox2.Text = "Количество слов на букву '" & targetLetter & "': " & count
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = Replace(TextBox1.Text, ",", ".")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim inputStr As String = TextBox1.Text
        Dim result As String = ""
        Dim currChar As String
        Dim charCode As Integer

        For i As Integer = 1 To Len(inputStr)
            currChar = Mid(inputStr, i, 1)
            charCode = Asc(UCase(currChar))

            If charCode >= 65 And charCode <= 90 Then
                result &= currChar
            End If
        Next i

        If result = "" Then
            TextBox2.Text = "Латинских букв не найдено"
        Else
            TextBox2.Text = result
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Label3.Text = "Дубликаты: Удаляет все идущие подряд одинаковые буквы во введенной фразе."
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Label3.Text = "Подсчет: Считает, сколько слов начинается с той же буквы, что и первое слово."
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Label3.Text = "Замена: Заменяет все запятые в тексте на точки."
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Label3.Text = "Латиница: Удаляет все символы, оставляя только буквы латинского алфавита."
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Label3.Text = "Очистить: Полностью очищает поля ввода и вывода."
    End Sub

    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Label3.Text = "Выход: Завершает работу приложения."
    End Sub

    Private Sub ClearHint(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave, Button5.MouseLeave, Button6.MouseLeave
        Label3.Text = ""
    End Sub

End Class