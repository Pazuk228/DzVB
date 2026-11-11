Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim Граф As Graphics = e.Graphics

        ' Закрашенный прямоугольник
        Граф.FillRectangle(Brushes.Yellow, 50, 50, 150, 100)

        ' Закрашенный эллипс
        Граф.FillEllipse(Brushes.Yellow, 250, 50, 150, 100)

        ' Дуга величиной 60 градусов, начиная от 30 градуса
        Граф.DrawArc(Pens.Black, 50, 150, 100, 100, 30, 60)

        ' Дуга величиной 270 градусов, начиная от 0 градуса
        Граф.DrawArc(Pens.Black, 50, 300, 100, 100, 0, 270)

        ' Сектор величиной 60 градусов, начиная от 30 градуса (только контур)
        Граф.DrawPie(Pens.Black, 200, 150, 100, 100, 30, 60)

        ' Сектор величиной 270 градусов, начиная от 0 градуса (только контур)
        Граф.DrawPie(Pens.Black, 200, 300, 100, 100, 0, 270)

        ' Закрашенный сектор величиной 60 градусов, начиная от 30 градуса
        Граф.FillPie(Brushes.Yellow, 350, 150, 100, 100, 30, 60)

        ' Закрашенный сектор величиной 270 градусов, начиная от 0 градуса
        Граф.FillPie(Brushes.Yellow, 350, 300, 100, 100, 0, 270)
    End Sub

End Class