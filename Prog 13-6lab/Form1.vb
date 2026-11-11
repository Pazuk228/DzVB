Public Class Form1
    'Len
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Len(TextBox1.Text).ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Введите исходную строку", 48, "Внимание")
            Exit Sub
        End If

        Dim startPos As String = InputBox("С какой позиции выделять?", "Mid")
        Dim length As String = InputBox("Сколько символов выделить?", "Mid")

        If IsNumeric(startPos) And IsNumeric(length) Then
            TextBox2.Text = Mid(TextBox1.Text, CInt(startPos), CInt(length))
        Else
            MsgBox("Введены некорректные параметры выделения", 16, "Ошибка")
        End If
    End Sub

    'Trim
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = Trim(TextBox1.Text)
    End Sub

    'Asc
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "" Then
            TextBox2.Text = Asc(TextBox1.Text).ToString()
        Else
            TextBox2.Text = "Строка пуста"
        End If
    End Sub

    'InStr
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim searchStr As String = InputBox("Введите подстроку для поиска:", "InStr")
        If searchStr <> "" Then
            Dim pos As Integer = InStr(TextBox1.Text, searchStr)
            If pos > 0 Then
                TextBox2.Text = "Позиция: " & pos.ToString()
            Else
                TextBox2.Text = "Подстрока не найдена"
            End If
        End If
    End Sub

    'Clear
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Label1.Text = "Len: Возвращает длину строки (количество символов)."
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Label1.Text = "Mid: Выделяет заданное количество символов, начиная с указанной позиции."
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Label1.Text = "Trim: Удаляет пробелы как в начале, так и в конце строки."
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Label1.Text = "Asc: Возвращает числовой ASCII-код первого символа."
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Label1.Text = "InStr: Возвращает начальную позицию искомой подстроки."
    End Sub

    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Label1.Text = "Clear: Полностью очищает текстовые поля."
    End Sub

    'Очистка подсказки
    Private Sub ClearHint(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave, Button5.MouseLeave, Button6.MouseLeave
        Label1.Text = ""
    End Sub
End Class