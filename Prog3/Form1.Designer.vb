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
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
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
        TextBox2.Location = New Point(319, 99)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(573, 99)
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
        lblY.Location = New Point(354, 55)
        lblY.Name = "lblY"
        lblY.Size = New Size(25, 30)
        lblY.TabIndex = 4
        lblY.Text = "Y"
        ' 
        ' lblРезультат
        ' 
        lblРезультат.AutoSize = True
        lblРезультат.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        lblРезультат.Location = New Point(597, 49)
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
        Button1.Size = New Size(98, 58)
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
        Button2.Size = New Size(101, 58)
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
        Button3.Size = New Size(97, 58)
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
        Button4.Size = New Size(110, 58)
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
        Button5.Size = New Size(103, 58)
        Button5.TabIndex = 10
        Button5.Text = "Rnd0"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Green
        Button6.BackgroundImageLayout = ImageLayout.None
        Button6.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button6.Location = New Point(74, 304)
        Button6.Name = "Button6"
        Button6.Size = New Size(98, 58)
        Button6.TabIndex = 11
        Button6.Text = "X^Y"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Green
        Button7.BackgroundImageLayout = ImageLayout.None
        Button7.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button7.Location = New Point(210, 304)
        Button7.Name = "Button7"
        Button7.Size = New Size(101, 58)
        Button7.TabIndex = 12
        Button7.Text = "П"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Green
        Button8.BackgroundImageLayout = ImageLayout.None
        Button8.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button8.Location = New Point(487, 304)
        Button8.Name = "Button8"
        Button8.Size = New Size(110, 58)
        Button8.TabIndex = 13
        Button8.Text = "X\Y"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Green
        Button9.BackgroundImageLayout = ImageLayout.None
        Button9.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button9.Location = New Point(625, 304)
        Button9.Name = "Button9"
        Button9.Size = New Size(122, 58)
        Button9.TabIndex = 14
        Button9.Text = "X mod Y"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button10.BackgroundImageLayout = ImageLayout.None
        Button10.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button10.Location = New Point(354, 304)
        Button10.Name = "Button10"
        Button10.Size = New Size(97, 58)
        Button10.TabIndex = 15
        Button10.Text = "СЕ"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGreen
        ClientSize = New Size(800, 450)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
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
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button

End Class
