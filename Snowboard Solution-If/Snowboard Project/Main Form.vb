' Name:         Snowboard Project
' Purpose:      Display the warehouse location
'               corresponding to an item code
' Programmer:   Zach Murphy on 2-23-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' display the location of the warehouse where the item is stored

        Dim strCode As String

        strCode = txtCode.Text

        If strCode = "12" Then
            lblLocation.Text = "Tennessee"
        ElseIf strCode = "36" Then
            lblLocation.Text = "Kentucky"
        ElseIf strCode = "40" OrElse strCode = "43" Then
            lblLocation.Text = "Louisiana"
        Else
            lblLocation.Text = "Invalid Code"
        End If


        txtCode.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCode_Enter(sender As Object, e As EventArgs) Handles txtCode.Enter
        txtCode.SelectAll()
    End Sub

    Private Sub txtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        ' allows the text box to accept only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        lblLocation.Text = String.Empty
    End Sub
End Class
