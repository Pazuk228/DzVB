Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tb_car As Double, Tb_trailer As Double
        Dim KO As Double = 1.0, KBC As Double = 1.0, KM As Double = 1.0, KC As Double = 1.0
        Dim T_car As Double, T_trailer As Double, Total As Double

        Dim isJuridical As Boolean = RadioButton19.Checked
        If isJuridical Then
            Tb_car = 2375
        Else
            Tb_car = 1980
        End If
        Tb_trailer = 395

        If RadioButton16.Checked Then
            KO = 1.0
        ElseIf RadioButton17.Checked Then
            KO = 1.5
        End If

        If isJuridical Then KO = 1.5

        If RadioButton1.Checked Then KM = 0.5
        If RadioButton2.Checked Then KM = 0.7
        If RadioButton3.Checked Then KM = 1.0
        If RadioButton4.Checked Then KM = 1.3
        If RadioButton5.Checked Then KM = 1.5
        If RadioButton6.Checked Then KM = 1.7

        If RadioButton12.Checked Then KBC = 1.3
        If RadioButton14.Checked Then KBC = 1.2
        If RadioButton15.Checked Then KBC = 1.15
        If RadioButton13.Checked Then KBC = 1.0

        If RadioButton17.Checked Or isJuridical Then KBC = 1.0

        If RadioButton11.Checked Then KC = 0.7
        If RadioButton10.Checked Then KC = 0.8
        If RadioButton9.Checked Then KC = 0.9
        If RadioButton8.Checked Then KC = 0.95
        If RadioButton7.Checked Then KC = 1.0

        If isJuridical Then
            T_car = Tb_car * KO * KM
        Else
            T_car = Tb_car * KO * KBC * KM * KC
        End If

        T_trailer = 0
        If CheckBox1.Checked Then
            If isJuridical Then
                T_trailer = Tb_trailer
            Else
                T_trailer = Tb_trailer * KC
            End If
        End If

        Total = T_car + T_trailer

        TextBox1.Text = Total.ToString("0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class