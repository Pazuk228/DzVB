Public Class Form1

    Private offset As Integer = 0
    Private direction As Integer = 2

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        offset += direction

        If offset > 40 Or offset < 0 Then
            direction *= -1
        End If

        Me.Invalidate()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim Граф As Graphics = e.Graphics

        Граф.TranslateTransform(250, 250)
        Граф.ScaleTransform(1, -1)

        Граф.FillRectangle(Brushes.MediumAquamarine, -100, -200, 200, 30)
        Граф.DrawRectangle(Pens.Black, -100, -200, 200, 30)

        Граф.DrawLine(Pens.Black, 0, -40, 50, -170)

        Граф.FillPie(Brushes.Green, -120, -120, 240, 240, 150, 50)
        Граф.FillPie(Brushes.DarkRed, -120, -120, 240, 240, 90, 50)
        Граф.FillPie(Brushes.Violet, -120, -120, 240, 240, 30, 50)
        Граф.FillPie(Brushes.Chocolate, -120, -120, 240, 240, -30, 50)
        Граф.FillPie(Brushes.Red, -120, -120, 240, 240, -90, 50)

        Граф.FillPie(Brushes.Blue, -120 - offset, -120 - offset, 240, 240, 210, 50)

        Граф.FillEllipse(Brushes.Yellow, -40, -40, 80, 80)
        Граф.DrawEllipse(Pens.Black, -40, -40, 80, 80)
    End Sub

End Class