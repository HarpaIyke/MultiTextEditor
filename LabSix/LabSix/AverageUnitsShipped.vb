' Author: Shaheed Ramjohn
' Date: April 17, 2020
' File Name: LabThree
' Purpose: Find the average number of units shipped for three employees using two-dimensional arrays

Option Strict On
Public Class AverageUnitsShipped

#Region "Declarations"

    ' Declare/initialize constants
    Const TOTAL_DAYS As Integer = 7
    Const TOTAL_EMPLOYEES As Integer = 3
    Const MIN_UNITS As Integer = 0
    Const MAX_UNITS As Integer = 5000

    ' Declare/initialize variables
    Dim employeeAverage As Integer = 0
    Dim currentEmployee As Integer = 0
    Dim averageTotal As Integer = 0
    Dim day As Integer = 0

    'Declare arrays
    Dim userInput(2, 6) As Integer
    Dim employeeUnitsTextBoxes(2) As TextBox
    Dim employeeAverageLabels(2) As Label
    Dim employeeIdentifier(2) As Label

#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' When the form loads, initialize the arrays
    ''' </summary>
    Private Sub frmAverageUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initialize arrays
        employeeAverageLabels = {lblAverageOne, lblAverageTwo, lblAverageThree}
        employeeUnitsTextBoxes = {txtEmployeeOne, txtEmployeeTwo, txtEmployeeThree}
        employeeIdentifier = {lblEmployeeOne, lblEmployeeTwo, lblEmployeeThree}

    End Sub

    ''' <summary>
    ''' When btnEnter is clicked receive and validate input, then output it into the appropriate control
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' When the user enters something, check and see if it's a number
        If Integer.TryParse(txtInput.Text, userInput(currentEmployee, day)) Then

            ' If it's a number, see if it's within the valid bounds
            If userInput(currentEmployee, day) > MAX_UNITS Or userInput(currentEmployee, day) < MIN_UNITS Then
                MessageBox.Show("ERROR! Please enter a value between " & MIN_UNITS & " and " & MAX_UNITS)

                ' If the input is valid, output it to the correct textbox
            Else

                employeeUnitsTextBoxes(currentEmployee).Text &= userInput(currentEmployee, day) & vbCrLf
                employeeAverage += userInput(currentEmployee, day)
                day += 1
                lblDay.Text = "Day " & day + 1

            End If

            ' If the max number of days has gone by for one employee, move to the next employee
            If day = TOTAL_DAYS Then

                employeeAverageLabels(currentEmployee).Text = "Average: " & Math.Round((employeeAverage / TOTAL_DAYS), 2)
                averageTotal += employeeAverage
                employeeAverage = 0

                currentEmployee += 1
                day = 0
                lblDay.Text = "Day " & day + 1

            End If

            If currentEmployee = TOTAL_EMPLOYEES Then

                lblAverageTotal.Text &= "Average per day: " & Math.Round((averageTotal / userInput.Length), 2)
                txtInput.Text = String.Empty
                txtInput.Enabled = False
                btnEnter.Enabled = False
                lblDay.Text = "Done!"

            End If

            ' If the user didn't enter a number, display an error message
        Else
            If txtInput.Text = String.Empty Then
                MessageBox.Show("You... didn't enter anything...

That's not this works")
            Else
                MessageBox.Show("ERROR! Please enter an integer!")
            End If
        End If

        txtInput.Text = String.Empty

    End Sub

    ''' <summary>
    ''' Exit the form when btnExit is pressed
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Call the Reset() sub procedure when btnReset is pressed
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

#End Region

#Region "Sub Procedures"

    ''' <summary>
    ''' Reset the form
    ''' </summary>
    Sub Reset()

        ' Reset controls using the ClearControls() sub procedure
        ClearControls(employeeUnitsTextBoxes)
        ClearControls(employeeAverageLabels)

        ' Reset the variables
        day = 0
        currentEmployee = 0
        employeeAverage = 0
        averageTotal = 0

        ' Reset controls not in an array
        lblDay.Text = "Day " & day + 1
        lblAverageTotal.Text = String.Empty
        txtInput.Enabled = True
        btnEnter.Enabled = True

        ' Put the focus back on txtInput
        txtInput.Focus()

    End Sub

    ''' <summary>
    ''' Use a For Each loop to clear controls
    ''' </summary>
    Sub ClearControls(controlArray As Control())

        ' Clear all controls passed through
        For Each controlToClear As Control In controlArray
            controlToClear.Text = String.Empty
        Next

    End Sub

#End Region

End Class
