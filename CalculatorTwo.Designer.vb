<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalculatorTwo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
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
        Me.equation = New System.Windows.Forms.Label()
        Me.btnNegPos = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.prevResultsLabel = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.Label()
        Me.prevResult = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.btnAdd.Location = New System.Drawing.Point(313, 187)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(313, 217)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtract.TabIndex = 12
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(313, 246)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiply.TabIndex = 13
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(313, 270)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(75, 23)
        Me.btnDivide.TabIndex = 14
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.Location = New System.Drawing.Point(313, 299)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(75, 23)
        Me.btnEqual.TabIndex = 15
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'equation
        '
        Me.equation.AutoSize = True
        Me.equation.BackColor = System.Drawing.SystemColors.Control
        Me.equation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equation.ForeColor = System.Drawing.Color.Black
        Me.equation.Location = New System.Drawing.Point(53, 60)
        Me.equation.Name = "equation"
        Me.equation.Size = New System.Drawing.Size(0, 20)
        Me.equation.TabIndex = 16
        '
        'btnNegPos
        '
        Me.btnNegPos.Location = New System.Drawing.Point(36, 299)
        Me.btnNegPos.Name = "btnNegPos"
        Me.btnNegPos.Size = New System.Drawing.Size(75, 23)
        Me.btnNegPos.TabIndex = 17
        Me.btnNegPos.Text = "+/-"
        Me.btnNegPos.UseVisualStyleBackColor = True
        '
        'btnDecimal
        '
        Me.btnDecimal.Location = New System.Drawing.Point(199, 299)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(75, 23)
        Me.btnDecimal.TabIndex = 18
        Me.btnDecimal.Text = "."
        Me.btnDecimal.UseVisualStyleBackColor = True
        '
        'resultLabel
        '
        Me.resultLabel.AutoSize = True
        Me.resultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultLabel.Location = New System.Drawing.Point(241, 355)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(46, 16)
        Me.resultLabel.TabIndex = 19
        Me.resultLabel.Text = "Result"
        '
        'prevResultsLabel
        '
        Me.prevResultsLabel.AutoSize = True
        Me.prevResultsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevResultsLabel.Location = New System.Drawing.Point(213, 436)
        Me.prevResultsLabel.Name = "prevResultsLabel"
        Me.prevResultsLabel.Size = New System.Drawing.Size(102, 16)
        Me.prevResultsLabel.TabIndex = 20
        Me.prevResultsLabel.Text = "Previous Result"
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.Location = New System.Drawing.Point(82, 390)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(0, 16)
        Me.result.TabIndex = 21
        '
        'prevResult
        '
        Me.prevResult.AutoSize = True
        Me.prevResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevResult.Location = New System.Drawing.Point(82, 477)
        Me.prevResult.Name = "prevResult"
        Me.prevResult.Size = New System.Drawing.Size(130, 16)
        Me.prevResult.TabIndex = 22
        Me.prevResult.Text = "No Previous Results"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(313, 158)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'CalculatorTwo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 540)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.prevResult)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.prevResultsLabel)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.btnDecimal)
        Me.Controls.Add(Me.btnNegPos)
        Me.Controls.Add(Me.equation)
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
        Me.KeyPreview = True
        Me.Name = "CalculatorTwo"
        Me.Text = "Calculator 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents equation As Label
    Friend WithEvents btnNegPos As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents resultLabel As Label
    Friend WithEvents prevResultsLabel As Label
    Friend WithEvents result As Label
    Friend WithEvents prevResult As Label
    Friend WithEvents btnClear As Button
End Class
