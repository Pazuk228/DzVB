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
        TextBox3.Text = Res.ToString
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
        Randomize()
        Res = Int((1000 - 10 + 1) * Rnd() + 10)
        TextBox3.Text = Res.ToString()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        Res = X ^ Y
        TextBox3.Text = Res.ToString()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        If Y = 0 Then
            MessageBox.Show("Деление на ноль невозможно")
        Else
            Res = CLng(X) \ CLng(Y)
            TextBox3.Text = Res.ToString()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        If Y = 0 Then
            MessageBox.Show("Деление на ноль невозможно")
        Else
            Res = CLng(X) Mod CLng(Y)
            TextBox3.Text = Res.ToString()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Res = Math.Atan(1) * 4
        TextBox3.Text = Res.ToString()
    End Sub
End Class
