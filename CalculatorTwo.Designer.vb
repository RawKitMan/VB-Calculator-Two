<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorTwo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.equation = New System.Windows.Forms.RichTextBox()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'equation
        '
        Me.equation.Location = New System.Drawing.Point(12, 48)
        Me.equation.Name = "equation"
        Me.equation.Size = New System.Drawing.Size(380, 88)
        Me.equation.TabIndex = 0
        Me.equation.Text = ""
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(36, 176)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(75, 23)
        Me.btnOne.TabIndex = 1
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(117, 176)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(75, 23)
        Me.btnTwo.TabIndex = 2
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(198, 176)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(75, 23)
        Me.btnThree.TabIndex = 3
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Location = New System.Drawing.Point(36, 217)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(75, 23)
        Me.btnFour.TabIndex = 4
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Location = New System.Drawing.Point(117, 217)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(75, 23)
        Me.btnFive.TabIndex = 5
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'btnSix
        '
        Me.btnSix.Location = New System.Drawing.Point(198, 217)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(75, 23)
        Me.btnSix.TabIndex = 6
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = True
        '
        'btnSeven
        '
        Me.btnSeven.Location = New System.Drawing.Point(36, 260)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(75, 23)
        Me.btnSeven.TabIndex = 7
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = True
        '
        'btnEight
        '
        Me.btnEight.Location = New System.Drawing.Point(117, 260)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(75, 23)
        Me.btnEight.TabIndex = 8
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = True
        '
        'btnNine
        '
        Me.btnNine.Location = New System.Drawing.Point(198, 260)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(75, 23)
        Me.btnNine.TabIndex = 9
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = True
        '
        'btnZero
        '
        Me.btnZero.Location = New System.Drawing.Point(117, 299)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(75, 23)
        Me.btnZero.TabIndex = 10
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(328, 176)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(328, 205)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtract.TabIndex = 12
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(328, 234)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiply.TabIndex = 13
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(328, 263)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(75, 23)
        Me.btnDivide.TabIndex = 14
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.Location = New System.Drawing.Point(328, 293)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(75, 23)
        Me.btnEqual.TabIndex = 15
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'CalculatorTwo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 471)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.btnNine)
        Me.Controls.Add(Me.btnEight)
        Me.Controls.Add(Me.btnSeven)
        Me.Controls.Add(Me.btnSix)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.equation)
        Me.Name = "CalculatorTwo"
        Me.Text = "Calculator 2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents equation As RichTextBox
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnEqual As Button
End Class
