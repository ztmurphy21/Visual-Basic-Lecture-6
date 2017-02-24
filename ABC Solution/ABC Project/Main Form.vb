' Name:         ABC Project
' Purpose:      Display the price per item
' Programmer:   Zach Murphy on 2-23-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the price per item

        Dim intQuantity As Integer
        Dim intPrice As Integer

        Integer.TryParse(txtQuantity.Text, intQuantity)

        ' determine the price per item 
        Select Case intQuantity
            Case 1 To 5
                intPrice = 25
            Case 6 To 10
                intPrice = 23
            Case Is > 10
                intPrice = 20
            Case Else
                intPrice = 0
        End Select


        lblPrice.Text = intPrice.ToString("C2")
        txtQuantity.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtQuantity_Enter(sender As Object, e As EventArgs) Handles txtQuantity.Enter
        txtQuantity.SelectAll()
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        ' allow only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        lblPrice.Text = String.Empty
    End Sub
End Class
