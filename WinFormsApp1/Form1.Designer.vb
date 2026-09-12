<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmТреугольник
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmТреугольник))
        cmdEnd = New Button()
        cmdStart = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        txtA = New Label()
        txtB = New Label()
        txtC = New Label()
        txtP = New Label()
        txtS = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmdEnd
        ' 
        cmdEnd.BackColor = Color.DarkSeaGreen
        cmdEnd.Font = New Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        cmdEnd.Location = New Point(634, 364)
        cmdEnd.Name = "cmdEnd"
        cmdEnd.Size = New Size(121, 41)
        cmdEnd.TabIndex = 7
        cmdEnd.Text = "Выход"
        cmdEnd.UseVisualStyleBackColor = False
        ' 
        ' cmdStart
        ' 
        cmdStart.BackColor = Color.DarkSeaGreen
        cmdStart.Font = New Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        cmdStart.Location = New Point(634, 301)
        cmdStart.Name = "cmdStart"
        cmdStart.Size = New Size(121, 41)
        cmdStart.TabIndex = 8
        cmdStart.Text = "Вычислить"
        cmdStart.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(577, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(198, 192)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(55, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(394, 30)
        Label1.TabIndex = 10
        Label1.Text = "Введите значение сторон треугольника"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(55, 121)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(95, 23)
        TextBox1.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(252, 121)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(430, 121)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(252, 247)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 14
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(252, 364)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 15
        ' 
        ' txtA
        ' 
        txtA.AutoSize = True
        txtA.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        txtA.Location = New Point(93, 83)
        txtA.Name = "txtA"
        txtA.Size = New Size(27, 30)
        txtA.TabIndex = 16
        txtA.Text = "А"
        ' 
        ' txtB
        ' 
        txtB.AutoSize = True
        txtB.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        txtB.Location = New Point(288, 83)
        txtB.Name = "txtB"
        txtB.Size = New Size(25, 30)
        txtB.TabIndex = 17
        txtB.Text = "В"
        ' 
        ' txtC
        ' 
        txtC.AutoSize = True
        txtC.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        txtC.Location = New Point(467, 83)
        txtC.Name = "txtC"
        txtC.Size = New Size(26, 30)
        txtC.TabIndex = 18
        txtC.Text = "С"
        ' 
        ' txtP
        ' 
        txtP.AutoSize = True
        txtP.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        txtP.Location = New Point(188, 202)
        txtP.Name = "txtP"
        txtP.Size = New Size(245, 30)
        txtP.TabIndex = 21
        txtP.Text = "Периметр треугольника"
        ' 
        ' txtS
        ' 
        txtS.AutoSize = True
        txtS.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        txtS.Location = New Point(197, 312)
        txtS.Name = "txtS"
        txtS.Size = New Size(236, 30)
        txtS.TabIndex = 22
        txtS.Text = "Площадь треугольника"
        ' 
        ' frmТреугольник
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGreen
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(800, 450)
        Controls.Add(txtS)
        Controls.Add(txtP)
        Controls.Add(txtC)
        Controls.Add(txtB)
        Controls.Add(txtA)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(cmdStart)
        Controls.Add(cmdEnd)
        Name = "frmТреугольник"
        Text = "Периметр и площадь треугольника"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdEnd As Button
    Friend WithEvents cmdStart As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtA As Label
    Friend WithEvents txtB As Label
    Friend WithEvents txtC As Label
    Friend WithEvents txtP As Label
    Friend WithEvents txtS As Label

End Class
