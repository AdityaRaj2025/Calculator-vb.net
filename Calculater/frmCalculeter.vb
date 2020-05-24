Public Class frmCalculeter
    Dim FirstNum As Decimal
    Dim SecondNum As Decimal
    Dim operations As Integer
    Dim operator_selector As Boolean = False
    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "0"
        End If
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "1"
        Else
            txtDisplay.Text = "1"
        End If
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "2"
        Else
            txtDisplay.Text = "2"
        End If
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "3"
        Else
            txtDisplay.Text = "3"
        End If
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "4"
        Else
            txtDisplay.Text = "4"
        End If
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "5"
        Else
            txtDisplay.Text = "5"
        End If
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "6"
        Else
            txtDisplay.Text = "6"
        End If
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "7"
        Else
            txtDisplay.Text = "7"
        End If
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "8"
        Else
            txtDisplay.Text = "8"
        End If
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "9"
        Else
            txtDisplay.Text = "9"
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtDisplay.Clear()
        txtDisplay.Focus()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        FirstNum = txtDisplay.Text
        txtDisplay.Text = "0"
        operator_selector = True
        operations = 1 ' = +
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        FirstNum = txtDisplay.Text
        txtDisplay.Text = "0"
        operator_selector = True
        operations = 2 ' = -
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        FirstNum = txtDisplay.Text
        txtDisplay.Text = "0"
        operator_selector = True
        operations = 3 ' = *
    End Sub

    Private Sub btnDived_Click(sender As Object, e As EventArgs) Handles btnDived.Click
        FirstNum = txtDisplay.Text
        txtDisplay.Text = "0"
        operator_selector = True
        operations = 4 ' = /
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If operator_selector = True Then
            SecondNum = txtDisplay.Text
            If operations = 1 Then
                txtDisplay.Text = FirstNum + SecondNum
            ElseIf operations = 2 Then
                txtDisplay.Text = FirstNum - SecondNum
            ElseIf operations = 3 Then
                txtDisplay.Text = FirstNum * SecondNum
            Else
                If SecondNum = 0 Then
                    txtDisplay.Text = "Error!"
                Else
                    txtDisplay.Text = FirstNum / SecondNum
                End If
            End If
            operator_selector = False
        End If
    End Sub

    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        If Not (txtDisplay.Text.Contains(".")) Then
            txtDisplay.Text += "."
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnC_Click_1(sender As Object, e As EventArgs) Handles btnC.Click
        txtDisplay.Text = "0"
    End Sub
End Class
