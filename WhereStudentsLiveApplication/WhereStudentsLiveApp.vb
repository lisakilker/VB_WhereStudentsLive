Public Class frmWhereStudentsLiveApp

    Private Sub mnuFile_Click(sender As Object, e As EventArgs) Handles mnuFile.Click

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub

    Private Sub btnEnterMileage_Click(sender As Object, e As EventArgs) Handles btnEnterMileage.Click
        Dim strMilesEntered As String
        Dim decMilesEntered As Decimal
        Dim decAverage As Decimal
        Dim decTotalMilesEntered As Decimal = 0D
        Dim strInputMessage As String = "Enter your distance (in miles) from school:"
        Dim strInputHeading As String = "Enter Miles"
        Dim strNormalMessage As String = "Enter your distance (in miles) from school:"
        Dim strNonNumericError As String = "Error - Enter a positive number!"
        Dim strNegativeError As String = "Error - Enter a positive number!"
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 10
        Dim intNumberOfEntries As Integer = 1

        strMilesEntered = InputBox(strInputMessage, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strMilesEntered = strCancelClicked

            If IsNumeric(strMilesEntered) Then
                decMilesEntered = Convert.ToDecimal(strMilesEntered)
                If decMilesEntered > 0 Then
                    lstDisplay.Items.Add(decMilesEntered)
                    decTotalMilesEntered += decMilesEntered
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage

                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If

            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strMilesEntered = InputBox(strInputMessage, strInputHeading, " ")
            End If
        Loop

        If intNumberOfEntries > 1 Then
            lblCount.Visible = True
            decAverage = decTotalMilesEntered / (intNumberOfEntries - 1)
            lblCount.Text = "Our students live an average of " & decAverage.ToString("F2") & " miles from the school"
        Else
            MsgBox("You have not entered a number.")
        End If
        btnEnterMileage.Enabled = False
        

    End Sub

    Private Sub lstDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDisplay.SelectedIndexChanged

    End Sub

    Private Sub Clear()
        
    End Sub
    Private Sub Init()
        
    End Sub

    Private Sub Print(value As Integer)

    End Sub

    Private Sub Print(value As Double)

    End Sub

    Private Sub Print(value As String)
        
    End Sub

    Private Sub UpdateCount()

    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstDisplay.Items.Clear()
        UpdateCount()
        lblCount.Visible = False
        btnEnterMileage.Enabled = True
    End Sub
End Class
