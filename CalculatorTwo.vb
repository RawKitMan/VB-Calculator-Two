Public Class CalculatorTwo

    'Create our calculator instance
    Public cjCalcTwo As New Calculator

    'The format that we are doing these equations on are <number><operator><number2><operator2> and so on
    'To make sure we have that format, we want to track if an operator was used. If so, then we
    'make sure that we do not have double operators in our expression.
    Public plusCount As Integer = 0
    Public minusCount As Integer = 0
    Public multiplyCount As Integer = 0
    Public divideCount As Integer = 0

    'Our index to track our previous results
    Public prevResultIndex As Integer = 0

    'Our number buttons. If a number is being clicked, then we reset the operator tracker
    Private Sub BtnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        equation.Text = equation.Text & btnOne.Text
        ClearOperators()
    End Sub

    Private Sub BtnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        equation.Text = equation.Text & btnTwo.Text
        ClearOperators()
    End Sub

    Private Sub BtnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        equation.Text = equation.Text & btnThree.Text
        ClearOperators()
    End Sub

    Private Sub BtnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        equation.Text = equation.Text & btnFour.Text
        ClearOperators()
    End Sub

    Private Sub BtnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        equation.Text = equation.Text & btnFive.Text
        ClearOperators()
    End Sub

    Private Sub BtnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        equation.Text = equation.Text & btnSix.Text
        ClearOperators()
    End Sub

    Private Sub BtnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        equation.Text = equation.Text & btnSeven.Text
        ClearOperators()
    End Sub

    Private Sub BtnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        equation.Text = equation.Text & btnEight.Text
        ClearOperators()
    End Sub

    Private Sub BtnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        equation.Text = equation.Text & btnNine.Text
        ClearOperators()
    End Sub

    Private Sub BtnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        equation.Text = equation.Text & btnZero.Text
        ClearOperators()
    End Sub

    'Our button  to make the current operand be positive or negative
    Private Sub BtnNegPos_Click(sender As Object, e As EventArgs) Handles btnNegPos.Click
        AddRemoveNeg()
    End Sub

    'Makes the current operand a decimal number
    Private Sub BtnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click

        If (plusCount = 1 Or minusCount = 1 Or multiplyCount = 1 Or divideCount = 1) Then
            equation.Text = equation.Text + "0."
            ClearOperators()
        Else
            equation.Text = equation.Text + "."
        End If
    End Sub

    'Reset the calculator
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        equation.Text = ""
        ClearOperators()
    End Sub

    'Clicking our operator buttons will add that operator to the expression being formed. It should
    'only happen once. Any subsequent clicks will not add to it.
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (plusCount = 0) Then
            equation.Text = equation.Text & " + "
            plusCount += 1
        End If
    End Sub

    Private Sub BtnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If (minusCount = 0) Then
            equation.Text = equation.Text & " - "
            minusCount += 1
        End If
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If (multiplyCount = 0) Then
            equation.Text = equation.Text & " * "
            multiplyCount += 1
        End If
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If (divideCount = 0) Then
            equation.Text = equation.Text & " / "
            divideCount += 1
        End If
    End Sub

    'BEGIN THE MATHS. Please note, this is the only button that works to calculate the expression. The Enter button
    'does not work for this.
    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        SetEquals()
    End Sub

    'Here, we did a setup where if any key inputs are going to be accepted, it will be primarily
    'the number pad. However, the enter button is a very interesting character because it, for some reason
    'adds a '1' at the end of the current number, and THEN does the math. I need more time to figure
    'that out as well as how to get the top row numbers to work properly. I know it involves a shift
    'check but time is of the essence here.
    Private Sub CalculatorTwo_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If (e.KeyCode = 107) Then
            If (plusCount = 0) Then
                equation.Text = equation.Text & " + "
                plusCount += 1
                e.Handled = True
            End If

            'For our - key in our numpad, we're also using it as a way to make a number negative.
            'It has to be pressed immediately after the operator or as the very first input. We use the
            'AddRemoveNeg() function to deal with that. Otherwise, we just do a subtraction like we always do.
        ElseIf (e.KeyCode = 109) Then

            Dim numberCheck As Char = "-"

            If (equation.Text.Length = 0) Then
                AddRemoveNeg()
            ElseIf (equation.Text.Length = 1 And equation.Text(0).Equals(numberCheck)) Then
                AddRemoveNeg()

            ElseIf (minusCount = 0 And equation.Text.Length > 2) Then
                minusCount += 1
                equation.Text = equation.Text & " - "
                e.Handled = True

            End If

        ElseIf (e.KeyCode = 106) Then

            equation.Text = equation.Text & " * "
            multiplyCount += 1
            e.Handled = True

        ElseIf (e.KeyCode = 111) Then

            If (divideCount = 0) Then
                divideCount += 1
                equation.Text = equation.Text & " / "
                e.Handled = True
            End If

        ElseIf (e.KeyCode = 13) Then

            MsgBox("Please click the '=' button. The enter button does weeeeeird things")
            e.Handled = True

        ElseIf (e.KeyCode >= 96 And e.KeyCode <= 105) Then

            equation.Text = equation.Text & e.KeyData.ToString().Replace("NumPad", "")
            plusCount = 0
            minusCount = 0
            multiplyCount = 0
            divideCount = 0
        End If
    End Sub

    'When this function is being called, we do not want the last input to be an operator. We also check
    'to see if the answer falls outside of the Double data type number range. Then we update our 
    'index for our previous results and then reset the calculator
    Public Sub SetEquals()
        If (plusCount = 0 And minusCount = 0 And multiplyCount = 0 And divideCount = 0) Then
            cjCalcTwo.calculate(equation.Text)

            Dim totalAnswer As Double = cjCalcTwo.getResult()
            If ((totalAnswer < Double.MinValue) Or (totalAnswer > Double.MaxValue)) Then
                MsgBox("Answer falls out of range")
                Exit Sub
            End If
            result.Text = equation.Text + " = " + totalAnswer.ToString()

            prevResultIndex += 1
            If (prevResultIndex = 10) Then
                prevResult.Text = cjCalcTwo.getPreviousResult(9)
                prevResultIndex = 0
            ElseIf ((Not (cjCalcTwo.results(0).Equals(""))) And (cjCalcTwo.results(1) Is Nothing)) Then
                prevResult.Text = "No Previous Results"
            Else
                prevResult.Text = cjCalcTwo.getPreviousResult(prevResultIndex - 1)
            End If

            equation.Text = ""
            ClearOperators()
        Else
            MsgBox("Invalid Equation")
        End If
    End Sub


    'The method to add or remove a negative sign from the operand that is being worked on.
    Public Sub AddRemoveNeg()

        Dim charCheck As Char = "-"
        If (equation.Text.Length > 0) Then
            Dim symbol As Char = equation.Text(equation.Text.Length - 1)
            If (equation.Text(0).Equals(charCheck) And equation.Text.Length = 1) Then
                equation.Text = ""
            ElseIf ((plusCount = 1) Or (minusCount = 1) Or (multiplyCount = 1) Or (divideCount = 1)) Then
                If (symbol.Equals(charCheck)) Then
                    Dim substring As String = equation.Text.Substring(0, equation.Text.Length() - 1)
                    equation.Text = substring

                Else
                    equation.Text = equation.Text & "-"
                End If

            End If
        Else

            equation.Text = "-"

        End If
    End Sub

    'If a number is pressed or if we reset the calculator, reset the operator counters
    Public Sub ClearOperators()
        plusCount = 0
        minusCount = 0
        multiplyCount = 0
        divideCount = 0
    End Sub


End Class

Public Class Calculator

    'As in our first Calculator method, we have an array of 10 elements that stores all the results we get
    'and the index for where the results will be placed
    Public results(9) As String
    Public resultIndex As Integer = 0

    'These stacks are going to be used to help us with our order of operations.
    Public value As Stack(Of Double) = New Stack(Of Double)
    Public operators As Stack(Of String) = New Stack(Of String)

    'CALCULATION!!!! This one is really cool because now we have to convert an equation string
    'into something that allows us to do the calculation in the correct order of operations.
    Public Sub calculate(ByVal equation As String)

        'First we create an array that splits the equation string by the whitespace. The whitespace
        'is provided by our operators.
        Dim eqArr() As String = equation.Split(New Char() {" "c})

        'Here's where the magic happens. I found an algorithm on how to program order of operations
        'for basic math functions. You can find it here: https://www.geeksforgeeks.org/expression-evaluation/
        'but I'll break it down below. First, we iterate through our eqArr array so we can push to our
        'value and operators stacks...
        For i = 0 To (eqArr.Length() - 1)
            'If the element is an operator..
            If (eqArr(i).Equals("+") Or eqArr(i).Equals("-") Or eqArr(i).Equals("*") Or eqArr(i).Equals("/")) Then

                'Do we have any operators in our operators stack. If so...
                If (operators.Count > 0) Then
                    'We want to see if the operator at the top is * or /
                    Dim operCheck As String = operators.Peek()
                    If (operCheck.Equals("*") Or operCheck.Equals("/")) Then
                        'If they are, we need to make those calculations. For every operator
                        'there are two values in the value stack to represent the left and right
                        'values in the calculation. We pop those values and the operator from their
                        'respective stacks...
                        Dim numOper As String = operators.Pop()
                        Dim answer As Double
                        Dim rightNum As Double = value.Pop()
                        Dim leftNum As Double = value.Pop()

                        'Then do the calculations, storing them in answer, making sure we do not divide
                        'by zero
                        If (numOper.Equals("*")) Then
                            answer = leftNum * rightNum
                        ElseIf (numOper.Equals("/")) Then
                            If (rightNum = 0) Then
                                MsgBox("Cannot Divide By Zero")
                                Exit Sub
                            Else
                                answer = leftNum / rightNum
                            End If
                        End If

                        'We then push the answer into the value stack
                        value.Push(answer)
                    End If
                End If
                'If there are no operators in the stack, push eqArr element being looked at
                'to the stack
                operators.Push(eqArr(i))

            Else
                'If the element is a number, we parse the string, then push the value into the value stack
                Dim valuePush As Double = Double.Parse(eqArr(i))
                value.Push(valuePush)
            End If


        Next

        'After we've gone through the entire eqArr array and made the appropriate stack pushes
        'we calculate everything that's left as long as there are operators left in the stack.
        'The final result should have nothing left in the operator stack and one value in the 
        'values stack, which is our final answer.
        While (operators.Count > 0)

            Dim numOper As String = operators.Pop()
            Dim answer As Double
            Dim rightNum As Double = value.Pop()
            Dim leftNum As Double = value.Pop()

            If (numOper.Equals("*")) Then
                answer = leftNum * rightNum
            ElseIf (numOper.Equals("/")) Then
                If (rightNum = 0) Then
                    MsgBox("Cannot Divide By Zero")
                    Exit Sub
                Else
                    answer = leftNum / rightNum
                End If

            ElseIf (numOper.Equals("+")) Then
                answer = leftNum + rightNum
            ElseIf (numOper.Equals("-")) Then
                answer = leftNum - rightNum
            End If

            value.Push(answer)

        End While

    End Sub

    'pop the lone value, store it in the results array, update the resultIndex
    'Then return the value to our form.
    Public Function getResult()

        Dim total As Double = value.Pop()
        results(resultIndex) = total.ToString()

        resultIndex += 1
        If (resultIndex = 10) Then
            resultIndex = 0
        End If
        
        Return total

    End Function

    'Returns a previous result to the form based on the designated index.
    Public Function getPreviousResult(ByVal index As Integer)
        For Each item As String In results
            Console.Write(item + ",")
        Next
        Console.WriteLine("")
        Return results(index)

    End Function

End Class
