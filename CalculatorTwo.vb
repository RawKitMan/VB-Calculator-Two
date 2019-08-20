

Public Class CalculatorTwo

    Public cjCalcTwo As New Calculator

    Public plusCount As Integer = 0
    Public minusCount As Integer = 0
    Public multiplyCount As Integer = 0
    Public divideCount As Integer = 0
    Public prevResultIndex As Integer = 0

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

    Private Sub BtnNegPos_Click(sender As Object, e As EventArgs) Handles btnNegPos.Click
        AddRemoveNeg()
    End Sub

    Private Sub BtnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click

        If (plusCount = 1 Or minusCount = 1 Or multiplyCount = 1 Or divideCount = 1) Then
            equation.Text = equation.Text + "0."
            ClearOperators()
        Else
            equation.Text = equation.Text + "."
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        equation.Text = ""
        ClearOperators()
    End Sub

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

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        SetEquals()
    End Sub

    Private Sub CalculatorTwo_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If (e.KeyCode = 107) Then
            If (plusCount = 0) Then
                equation.Text = equation.Text & " + "
                plusCount += 1
                e.Handled = True
            End If

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

            SetEquals()
            e.Handled = True

        ElseIf (e.KeyCode >= 96 And e.KeyCode <= 105) Then

            equation.Text = equation.Text & e.KeyData.ToString().Replace("NumPad", "")
            plusCount = 0
            minusCount = 0
            multiplyCount = 0
            divideCount = 0
        End If
    End Sub

    Public Sub SetEquals()
        If (plusCount = 0 And minusCount = 0 And multiplyCount = 0 And divideCount = 0) Then
            cjCalcTwo.calculate(equation.Text)

            Dim totalAnswer As Double = cjCalcTwo.getResult()
            If ((totalAnswer < Double.MinValue) Or (totalAnswer > Double.MaxValue)) Then
                MsgBox("Answer falls out of range")
                Exit Sub
            End If
            result.Text = equation.Text + " = " + totalAnswer.ToString()

            If (prevResultIndex = 10) Then
                prevResultIndex = 0
            End If

            prevResult.Text = cjCalcTwo.getPreviousResult(prevResultIndex)
            prevResultIndex += 1
            equation.Text = ""
            ClearOperators()
        Else
            MsgBox("Invalid Equation")
        End If
    End Sub

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

    Public Sub ClearOperators()
        plusCount = 0
        minusCount = 0
        multiplyCount = 0
        divideCount = 0
    End Sub


End Class

Public Class Calculator

    Public results(10) As Double
    Public resultIndex As Integer = 0
    Public value As Stack(Of Double) = New Stack(Of Double)
    Public operators As Stack(Of String) = New Stack(Of String)

    'Add comments here.
    Public Sub calculate(ByVal equation As String)


        Dim eqArr() As String = equation.Split(New Char() {" "c})

        'Multiplication and division have a higher ranking than addition and subtraction
        For Each item As String In eqArr
            Console.Write(item + ",")
        Next
        Console.WriteLine()


        For i = 0 To (eqArr.Length() - 1)
            If (eqArr(i).Equals("+") Or eqArr(i).Equals("-") Or eqArr(i).Equals("*") Or eqArr(i).Equals("/")) Then

                If (operators.Count > 0) Then
                    Dim operCheck As String = operators.Peek()
                    If (operCheck.Equals("*") Or operCheck.Equals("/")) Then

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
                        End If

                        Console.WriteLine(answer)
                        value.Push(answer)

                    End If

                End If
                operators.Push(eqArr(i))

            Else
                Console.WriteLine("Did we push a value?")
                value.Push(Double.Parse(eqArr(i)))
            End If


        Next

        While (operators.Count > 0)

            Dim numOper As String = operators.Pop()
            Dim answer As Double
            Dim rightNum As Double = value.Pop()
            Dim leftNum As Double = value.Pop()
            Console.WriteLine(leftNum.ToString + numOper + rightNum.ToString)
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

    Public Function getResult()

        Dim total As Double = value.Pop()

        resultIndex += 1

        If (resultIndex = 10) Then
            resultIndex = 0
        End If

        results(resultIndex) = total
        Return total

    End Function

    Public Function getPreviousResult(ByVal index As Integer)
        If (results.Length = 1) Then
            Return "No Previous Results"
        Else
            Return results(index).ToString()
        End If

    End Function

End Class
