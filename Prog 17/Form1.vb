Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim Граф As Graphics = e.Graphics
        Граф.DrawLine(Pens.Black, 20, 350, 650, 350)
        Граф.DrawEllipse(Pens.Black, 50, 250, 100, 100)
        Граф.DrawEllipse(Pens.Black, 200, 250, 100, 100)
        Граф.DrawLine(Pens.Black, 100, 300, 150, 200)
        Граф.DrawLine(Pens.Black, 100, 300, 175, 300)
        Граф.DrawLine(Pens.Black, 175, 300, 225, 200)
        Граф.DrawLine(Pens.Black, 150, 200, 225, 200)
        Граф.DrawLine(Pens.Black, 250, 300, 210, 150)
        Граф.DrawLine(Pens.Black, 190, 160, 230, 150)
        Граф.DrawEllipse(Pens.Black, 130, 190, 40, 10)
        Граф.DrawLine(Pens.Black, 330, 350, 330, 270)
        Граф.DrawLine(Pens.Black, 350, 350, 350, 270)
        Граф.DrawEllipse(Pens.Black, 310, 170, 60, 100)
        Граф.DrawEllipse(Pens.Black, 325, 140, 30, 30)
        Граф.DrawRectangle(Pens.Black, 325, 110, 30, 30)
        Граф.DrawLine(Pens.Black, 315, 220, 270, 260)
        Граф.DrawLine(Pens.Black, 365, 220, 430, 220)
        Граф.DrawRectangle(Pens.Black, 470, 200, 60, 110)
        Граф.DrawRectangle(Pens.Black, 530, 250, 70, 60)
        Граф.DrawEllipse(Pens.Black, 480, 310, 40, 40)
        Граф.DrawEllipse(Pens.Black, 550, 310, 40, 40)
        Граф.DrawLine(Pens.Black, 575, 250, 565, 200)
        Граф.DrawLine(Pens.Black, 585, 250, 595, 200)
        Граф.DrawLine(Pens.Black, 565, 200, 595, 200)
        Граф.DrawEllipse(Pens.Black, 550, 160, 40, 15)
        Граф.DrawEllipse(Pens.Black, 510, 120, 60, 20)
    End Sub

End Class