<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        lblX = New Label()
        lblY = New Label()
        lblРезультат = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Location = New Point(128, 99)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Location = New Point(562, 99)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(314, 345)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(163, 23)
        TextBox3.TabIndex = 2
        ' 
        ' lblX
        ' 
        lblX.AutoSize = True
        lblX.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        lblX.Location = New Point(164, 55)
        lblX.Name = "lblX"
        lblX.Size = New Size(25, 30)
        lblX.TabIndex = 3
        lblX.Text = "X"
        ' 
        ' lblY
        ' 
        lblY.AutoSize = True
        lblY.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        lblY.Location = New Point(600, 55)
        lblY.Name = "lblY"
        lblY.Size = New Size(25, 30)
        lblY.TabIndex = 4
        lblY.Text = "Y"
        ' 
        ' lblРезультат
        ' 
        lblРезультат.AutoSize = True
        lblРезультат.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        lblРезультат.Location = New Point(338, 295)
        lblРезультат.Name = "lblРезультат"
        lblРезультат.Size = New Size(106, 30)
        lblРезультат.TabIndex = 5
        lblРезультат.Text = "Результат"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button1.Location = New Point(74, 187)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 58)
        Button1.TabIndex = 6
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button2.Location = New Point(210, 187)
        Button2.Name = "Button2"
        Button2.Size = New Size(90, 58)
        Button2.TabIndex = 7
        Button2.Text = "X-Y"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Green
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button3.Location = New Point(354, 187)
        Button3.Name = "Button3"
        Button3.Size = New Size(90, 58)
        Button3.TabIndex = 8
        Button3.Text = "*"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Green
        Button4.BackgroundImageLayout = ImageLayout.None
        Button4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button4.Location = New Point(487, 187)
        Button4.Name = "Button4"
        Button4.Size = New Size(90, 58)
        Button4.TabIndex = 9
        Button4.Text = "X/Y"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Green
        Button5.BackgroundImageLayout = ImageLayout.None
        Button5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button5.Location = New Point(633, 187)
        Button5.Name = "Button5"
        Button5.Size = New Size(90, 58)
        Button5.TabIndex = 10
        Button5.Text = "Rnd0"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGreen
        ClientSize = New Size(800, 450)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lblРезультат)
        Controls.Add(lblY)
        Controls.Add(lblX)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Калькулятор"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents lblРезультат As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button

End Class
