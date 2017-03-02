' Lottery Project
' Will output the six winning numbers for tonights lotter!
'Programmer: Zachary Murphy on 2-27-2017

Public Class MainForm
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        'variables needed
        Dim randGen As New Random
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intNum3 As Integer
        Dim intNum4 As Integer
        Dim intNum5 As Integer
        Dim intNum6 As Integer
        Dim strSpace As String

        'will use this to make output look neat.
        strSpace = " , "

        'lets draw the winning numbers randomly!
        intNum1 = randGen.Next(1, 55)
        intNum2 = randGen.Next(1, 55)
        intNum3 = randGen.Next(1, 55)
        intNum4 = randGen.Next(1, 55)
        intNum5 = randGen.Next(1, 55)
        intNum6 = randGen.Next(1, 55)

        'output the winning numbers
        lblNumbers.Text = intNum1.ToString + strSpace + intNum2.ToString + strSpace + intNum3.ToString + strSpace + intNum4.ToString + strSpace +
            intNum5.ToString + strSpace + intNum6.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the application
        Me.Close()

    End Sub


End Class
