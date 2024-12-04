REM EXAMINATION MARKING GUIDELINE
REM EXAMINATION NUMBER:____________
REM WORKSTATION NUMBER:____________
REM EXAMINATION   DATE:____________

Option Explicit On
Option Strict On


Public Class frmQuestion1


    Private Sub frmQuestion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInfoHeading1.Text = "principles of computer programming"
    End Sub

    Private Sub btnQuestion1_2_Click(sender As Object, e As EventArgs) Handles btnQuestion1_2.Click
        lblInfoHeading1.Text = UCase(lblInfoHeading1.Text)
        lblInfoHeading1.ForeColor = Color.Red
        lblInfoHeading1.BackColor = Color.Black
        lblInfoHeading1.Font = New Font("Comic Sans MS", 12)


    End Sub

    Private Sub btnQuestion1_3_Click(sender As Object, e As EventArgs) Handles btnQuestion1_3.Click
        Dim intRandomnumber As Integer
        Dim randomgenerator As New Random

        intRandomnumber = randomgenerator.Next(1, 50)
        lblDisplayRandom.Text = intRandomnumber.ToString

    End Sub

    Private Sub btnQuestion1_4_Click(sender As Object, e As EventArgs) Handles btnQuestion1_4.Click
        Dim decDecimalhours As Decimal
        Dim intHours As Integer
        Dim intMinutes As Integer

        decDecimalhours = CDec(txtDecimalHours.Text)

        intHours = CInt(Math.Floor(decDecimalhours))
        intMinutes = CInt((decDecimalhours - intHours) * 60)

        txtDecimalHours.Text = decDecimalhours.ToString
        txtHours.Text = intHours.ToString
        txtMinutes.Text = intMinutes.ToString


        'Dim strArrDecimalHours() As String = txtDecimalHours.Text.Split(".")
        'If strArrDecimalHours.Length = 2 Then
        '    txtHours.Text = strArrDecimalHours(0)
        '    Dim decimalPart As String = strArrDecimalHours(1)
        '    If decimalPart.Length >= 2 Then
        '        Dim minutes As Integer
        '        If Integer.TryParse(decimalPart.Substring(0, 2), minutes) Then
        '            txtMinutes.Text = minutes.ToString()
        '        Else
        '            txtMinutes.Text = "00"
        '        End If
        '    Else
        '        txtMinutes.Text = "00"
        '    End If
        'Else
        '    txtHours.Text = "0"
        '    txtMinutes.Text = "00"
        'End If


    End Sub

    Private Sub btnQuestion1_5_Click(sender As Object, e As EventArgs) Handles btnQuestion1_5.Click
        ' 1.5.1
        Dim intSquare As Integer
        intSquare = CInt(txtRadicand.Text)


        '1.5.2
        If Math.Sqrt(intSquare).ToString = Math.Floor(Math.Sqrt(intSquare)).ToString Then
            lblDisplaySquare.Text = "The square of " & txtRadicand.Text & " " & "is " & Math.Sqrt(intSquare).ToString & vbCrLf & "Is a perfect square"
        Else
            lblDisplaySquare.Text = "The square of " & txtRadicand.Text & " " & "is " & Math.Sqrt(intSquare).ToString & vbCrLf & "Is not a perfect square"
        End If
    End Sub

    Private Sub btnQuestion1_6_Click(sender As Object, e As EventArgs) Handles btnQuestion1_6.Click
        Dim strSentence As String
        strSentence = CStr(txtSentence.Text)
        lblDisplayString.Text = StrReverse(strSentence.ToString)

    End Sub
End Class
