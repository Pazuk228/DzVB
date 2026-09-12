Public Class Form1
    Dim X As Double
    Dim Y As Double
    Dim Res As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        Res = X + Y
        TextBox3.Text = Res.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        Res = X - Y
        TextBox3.Text = Res.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        Res = X * Y
        TextBox3.Text = Res.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)

        If Y = 0 Then
            MessageBox.Show("Деление на ноль невозможно")
        Else
            Res = X / Y
            TextBox3.Text = Res.ToString()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Res = Rnd()
        TextBox3.Text = Res.ToString()
    End Sub
End Class
