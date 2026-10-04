Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserName As String = InputBox("Введите свое имя", "Имя")

        Button1.Visible = False
        Label1.Text = "Здравствуйте, " & UserName & "!"
        Label2.Text = "Рады приветствовать Вас в этом проекте"
        Label1.Visible = True
        Label2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim UserName As String = InputBox("Введите свое имя", "Имя")
        Dim t As Integer = 0 + 64 ' Кнопка ОК и иконка Information
        MsgBox("Здравствуйте, " & UserName & "! Рады приветствовать Вас в нашем проекте!", t, "Привет!!!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim UserName As String = InputBox("Введите свое имя", "Имя")
        Dim t As Integer = 2 + 16 ' Кнопки Прервать/Повтор/Пропустить и иконка Critical
        MsgBox(UserName & "! Произошла ошибка!", t, "Ошибка!!!")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim UserName As String = InputBox("Введите свое имя", "Имя")
        MsgBox("Здравствуйте, " & UserName & "! Вы согласны пройти тестирование?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Тестирование!!!")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim UserName As String = InputBox("Введите свое имя", "Имя")
        Dim k As MsgBoxResult

        k = MsgBox("Здравствуйте, " & UserName & "! Вы согласны пройти тестирование?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Тестирование!!!")

        ' Анализ ответа пользователя
        If k = MsgBoxResult.Yes Then
            MsgBox("Пользователь дал согласие (Нажата кнопка 'Да')", MsgBoxStyle.Information, "Результат")
        Else
            MsgBox("Пользователь отказался (Нажата кнопка 'Нет')", MsgBoxStyle.Exclamation, "Результат")
        End If
    End Sub
End Class
