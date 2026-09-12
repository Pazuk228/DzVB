Public Class frmТреугольник
    Dim A As Single, B As Single, C As Single, P As Single, Pp As Single, S As Single
    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        A = Val(txtA.Text)
        B = Val(txtB.Text)
        C = Val(txtC.Text)

        P = A + B + C
        Pp = P / 2
        S = Math.Sqrt(Pp * (Pp - A) * (Pp - B) * (Pp - C))

        txtP.Text = Str(P)
        txtS.Text = Str(S)
    End Sub

    Private Sub cmdEnd_Click(sender As Object, e As EventArgs) Handles cmdEnd.Click
        End
    End Sub
End Class