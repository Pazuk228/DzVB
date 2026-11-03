Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim F As String = InputBox("Введите Вашу фамилию", "Регистрация")
        Dim I As String = InputBox("Введите Ваше имя", "Регистрация")
        Dim O As String = InputBox("Введите Ваше отчество", "Регистрация")

        Me.Text = "Зарплата учителя. " & F & " " & I & " " & O
        Label1.Text = I & " " & O & "! Введите, пожалуйста, свои данные."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Razryad As Integer, Chasy As Integer
        Dim Stavka As Double, Zarplata As Double
        Dim D1, D2, D3, D4, D5, D6, D7, D8, D9, D As Double
        Dim NalogPodohod As Double, NalogPension As Double
        Dim Itog As Double

        If Not IsNumeric(TextBox1.Text) Or Not IsNumeric(TextBox2.Text) Then
            MsgBox("Ошибка ввода! Введите числа.", MsgBoxStyle.Critical, "Ошибка")
            Exit Sub
        End If

        Razryad = CInt(Val(TextBox1.Text))
        Chasy = CInt(Val(TextBox2.Text))

        Select Case Razryad
            Case 8 : Stavka = 1500
            Case 9 : Stavka = 1667
            Case 10 : Stavka = 1873
            Case 11 : Stavka = 2057
            Case 12 : Stavka = 2263
            Case 13 : Stavka = 2492
            Case 14 : Stavka = 2739
            Case 15 : Stavka = 3020
            Case Else
                MsgBox("Вы неверно ввели разряд. Разряд выходит за допустимые пределы (8-15).", MsgBoxStyle.Critical, "Ошибка!")
                TextBox1.Text = ""
                TextBox1.Focus()
                Exit Sub
        End Select

        Zarplata = Stavka * Chasy / 18

        D1 = 0 : D2 = 0 : D3 = 0 : D4 = 0 : D5 = 0 : D6 = 0 : D7 = 0 : D8 = 0 : D9 = 0

        If CheckBox1.Checked Then D1 = 0.12 * Zarplata
        If CheckBox2.Checked Then D2 = 0.1 * Stavka
        If CheckBox4.Checked Then D3 = 0.15 * Stavka
        If CheckBox3.Checked Then D4 = 0.2 * Stavka

        If RadioButton2.Checked Then D5 = 0.3 * Zarplata
        If RadioButton3.Checked Then D6 = 0.5 * Zarplata
        If RadioButton4.Checked Then D7 = 0.5 * Zarplata

        D8 = 0.1 * Zarplata
        D9 = 100

        D = D1 + D2 + D3 + D4 + D5 + D6 + D7 + D8 + D9

        Dim Nachisleno As Double = Zarplata + D
        TextBox3.Text = Nachisleno.ToString("0.00")

        NalogPodohod = 0.13 * Nachisleno
        TextBox4.Text = NalogPodohod.ToString("0.00")

        NalogPension = 0.01 * Nachisleno
        TextBox5.Text = NalogPension.ToString("0.00")

        Itog = Nachisleno - NalogPodohod - NalogPension
        TextBox6.Text = Itog.ToString("0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        RadioButton1.Checked = True

        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class