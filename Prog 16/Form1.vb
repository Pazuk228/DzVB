Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim Граф As Graphics = e.Graphics

        ' Левый отрезок: 0, 400 - координаты одной из точек отрезка, другой 300,0
        Граф.DrawLine(Pens.Black, 0, 400, 300, 0)

        ' Правый отрезок
        Граф.DrawLine(Pens.Black, 400, 300, 600, 400)

        ' Прямоугольник: 400, 300 - координаты левого верхнего угла прям-ка, 200 - ширина пр-ка, 100 - высота
        Граф.DrawRectangle(Pens.Black, 400, 300, 200, 100)

        ' Эллипс, вписанный в этот прямоугольник - параметры те же, что и у прямоугольника
        Граф.DrawEllipse(Pens.Black, 400, 300, 200, 100)

        Граф.DrawRectangle(Pens.Black, 200, 300, 100, 100) ' Квадрат

        Граф.DrawEllipse(Pens.Black, 400, 0, 200, 200) ' Круг

        Граф.DrawEllipse(Pens.Black, 0, 0, 200, 400) ' Высокий эллипс
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class