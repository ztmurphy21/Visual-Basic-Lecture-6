' Name:         Roll Em Project
' Purpose:      Simulate a game of rolling dice
' Programmer:   Zachary Murphy on 2-26-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        'simulates a game of rolling dice

        Dim randGen As New Random
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intTotal As Integer

        'assign random integer from 1-6
        intNum1 = randGen.Next(1, 7)
        intNum2 = randGen.Next(1, 7)

        'display the appropriate image in picDie1
        Select Case intNum1
            Case 1
                picDie1.Image = picOneDot.Image
            Case 2
                picDie1.Image = picTwoDots.Image
            Case 3
                picDie1.Image = picThreeDots.Image
            Case 4
                picDie1.Image = picFourDots.Image
            Case 5
                picDie1.Image = picFiveDots.Image
            Case 6
                picDie1.Image = picSixDots.Image
        End Select

        'display the appropriate image in picDie2
        Select Case intNum2
            Case 1
                picDie2.Image = picOneDot.Image
            Case 2
                picDie2.Image = picTwoDots.Image
            Case 3
                picDie2.Image = picThreeDots.Image
            Case 4
                picDie2.Image = picFourDots.Image
            Case 5
                picDie2.Image = picFiveDots.Image
            Case 6
                picDie2.Image = picSixDots.Image
        End Select

        'calculate and display total number of dots
        intTotal = intNum1 + intNum2
        lblTotal.Text = intTotal.ToString
    End Sub
End Class
