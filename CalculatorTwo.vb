Public Class CalculatorTwo

    Public cjCalcTwo As New Calculator

    Public plusCount As Integer = 0
    Public minusCount As Integer = 0
    Public multiplyCount As Integer = 0
    Public divideCount As Integer = 0

    Private Sub BtnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        equation.Text = equation.Text & btnOne.Text
        plusCount = 0
        minusCount = 0
        multiplyCount = 0
        divideCount = 0
    End Sub

    Private Sub BtnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        equation.Text = equation.Text & btnTwo.Text
        plusCount = 0
        minusCount = 0
        multiplyCount = 0
        divideCount = 0
    End Sub

    Private Sub BtnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        equation.Text = equation.Text & btnThree.Text
        plusCount = 0
        minusCount = 0
        multiplyCount = 0
        divideCount = 0
    End Sub

    Private Sub BtnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        equation.Text = equation.Text & btnFour.Text
        plusCount = 0
        minusCount = 0
        multiplyCount = 0
        divideCount = 0
    End Sub

    Private Sub BtnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        equation.Text = equation.Text & btnFive.Text
        plusCount = 0
        minusCount = 0
        multiplyCount = 0
        divideCount = 0
    End Sub

    Private Sub BtnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        equation.Text = equation.Text & btnSix.Text
        plusCount = 0
        minusCount = 0
        multiplyCount = 0
        divideCount = 0
    End Sub

    Private Sub BtnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        equation.Text = equation.Text & btnSeven.Text
        plusCount = 0
        minusCount = 0
        multiplyCount = 0
        divideCount = 0
    End Sub

    Private Sub BtnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        equation.Text = equation.Text & btnEight.Text
        plusCount = 0
        minusCount = 0
        multiplyCount = 0
        divideCount = 0
    End Sub

    Private Sub BtnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        equation.Text = equation.Text & btnNine.Text
        plusCount = 0
        minusCount = 0
        multiplyCount = 0
        divideCount = 0
    End Sub

    Private Sub BtnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        equation.Text = equation.Text & btnZero.Text
        plusCount = 0
        minusCount = 0
        multiplyCount = 0
        divideCount = 0
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
        If (plusCount = 0 And minusCount = 0 And multiplyCount = 0 And divideCount = 0) Then
            cjCalcTwo.calculate(equation.Text)
        Else
            Console.WriteLine("Invalid Equation")
        End If
        'equation.Text = ""
    End Sub
End Class

Public Class Calculator

    Public results(10) As Double
    Public resultIndex As Integer

    'Add comments here.
    Public Sub calculate(ByVal equation As String)


        Dim eqArr() As String = equation.Split(New Char() {" "c})

        Dim value As Stack(Of String) = New Stack(Of String)
        Dim operators As Stack(Of String) = New Stack(Of String)

        'Multiplication and division have a higher ranking than addition and subtraction

        For i = 0 To (eqArr.Length() - 1)

            Console.WriteLine(i)
            If (eqArr(i).Equals("+") Or eqArr(i).Equals("-") Or eqArr(i).Equals("*") Or eqArr(i).Equals("/")) Then

                If (operators.Count > 0) Then
                    Dim operCheck As String = operators.Peek()
                    If (operCheck.Equals("*") Or operCheck.Equals("/")) Then

                        Dim numOper As String = operators.Pop()
                        Dim answer As Double
                        Dim rightNum As Double = Double.Parse(value.Pop())
                        Dim leftNum As Double = Double.Parse(value.Pop())

                        If (numOper.Equals("*")) Then
                            answer = leftNum * rightNum
                        ElseIf (numOper.Equals("/")) Then
                            answer = leftNum / rightNum
                        End If

                        value.Push(answer)
                    End If
                End If
                operators.Push(eqArr(i))

            Else
                value.Push(eqArr(i))
            End If


        Next

        While (operators.Count > 0)

            Console.WriteLine("Do we end up here at all?")
            Dim numOper As String = operators.Pop()
            Dim answer As Double
            Dim rightNum As Double = Double.Parse(value.Pop())
            Dim leftNum As Double = Double.Parse(value.Pop())

            If (numOper.Equals("*")) Then
                answer = leftNum * rightNum
            ElseIf (numOper.Equals("/")) Then
                answer = leftNum / rightNum
            ElseIf (numOper.Equals("+")) Then
                answer = leftNum + rightNum
            ElseIf (numOper.Equals("-")) Then
                answer = leftNum - rightNum
            End If

            value.Push(answer)

        End While

        Console.WriteLine(value.Peek().ToString())

    End Sub

    Public Function getResult()
        Return ""
    End Function

    Public Function getPreviousResult(ByVal index As Integer)
        Return ""
    End Function

End Class
