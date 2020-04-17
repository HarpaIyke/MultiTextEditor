' Name: Shaheed Ramjohn
' Co-Author: Kyle Chapman
' Date: April 17, 2020
' Description: A program that can accept multiple records of cars and display them in a listview

Option Strict On

Public Class frmCarInventory

#Region "Variable Declarations"

    Dim selectedCar As Car
    Dim isCarSelected As Boolean = False
    Dim isAddingToListView As Boolean = False
    Dim carList As New List(Of Car)

#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' Add the entered data into the listview if it's valid
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Continue if it's valid input
        If IsValidInput() = True Then

            ' If a car is not selected, add it to the list. Otherwise, change the selected car's information
            If Not isCarSelected Then

                selectedCar = New Car(cboMake.Text, txtModel.Text, Convert.ToInt32(nudYear.Value), Convert.ToDecimal(txtPrice.Text), chkNew.Checked)
                carList.Add(selectedCar)

            ElseIf selectedCar.IdentificationNumber > 0 Then

                selectedCar.Make = cboMake.Text
                selectedCar.Model = txtModel.Text
                selectedCar.Year = Convert.ToInt32(nudYear.Value)
                selectedCar.Price = Convert.ToDecimal(txtPrice.Text)
                selectedCar.IsNew = chkNew.Checked

            End If

            Reset()

        End If

    End Sub

    ''' <summary>
    ''' Set everything except the listview to it's default state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    ''' <summary>
    ''' Close the form
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Makes sure the user can't check the box in the listview
    ''' </summary>
    Private Sub lvwCars_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck

        If Not isAddingToListView Then

            e.NewValue = e.CurrentValue

        End If

    End Sub

    ''' <summary>
    ''' If the user selects an item in the listview fill the appropriate controls with the relevant information
    ''' </summary>
    Private Sub lvwCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged

        ' If an item is selected, fill the controls with it's information
        If lvwCars.SelectedIndices.Count = 1 Then
            selectedCar = carList(lvwCars.SelectedIndices(0))
            isCarSelected = True

            cboMake.Text = selectedCar.Make
            txtModel.Text = selectedCar.Model
            nudYear.Value = selectedCar.Year
            txtPrice.Text = selectedCar.Price.ToString()
            chkNew.Checked = selectedCar.IsNew

            lblError.Text = selectedCar.GetCarData

        Else
            isCarSelected = False
        End If

    End Sub

#End Region

#Region "Procedures"

    ''' <summary>
    ''' Validate the input
    ''' </summary>
    Private Function IsValidInput() As Boolean

        Dim errorMessage As String = String.Empty
        Dim isValid As Boolean = True

        ' If there is nothing in txtModel, display an error message
        If txtModel.Text.Trim.Length = 0 Then
            isValid = False
            errorMessage += "Please enter a model!" & vbCrLf
        End If

        ' If there is nothing in txtPrice, display an error message
        If txtPrice.Text.Trim.Length = 0 Then
            isValid = False
            errorMessage += "Please enter a price!" & vbCrLf
        End If

        ' If the data in txtPrice is not a number, display an error message
        If Not IsNumeric(txtPrice.Text) Then
            isValid = False
            errorMessage += "The price must be a number!"
        End If

        ' If the data in cboMake is not a valid make, display an error message
        If cboMake.Text <> "Mitsubishi" And cboMake.Text <> "Honda" And cboMake.Text <> "Hyundai" And cboMake.Text <> "Volkswagon" And cboMake.Text <> "Ford" And cboMake.Text <> "Toyota" And cboMake.Text <> "Nissan" And cboMake.Text <> "Jeep" And cboMake.Text <> "BMW" Then
            isValid = False
            errorMessage += "Please enter a valid make!"
        End If

        ' Print all relevant error messages
        If isValid = False Then
            lblError.Text = "ERROR!" & vbCrLf & errorMessage
        End If

        Return isValid

    End Function

    ''' <summary>
    ''' Clear and then re-populate the list
    ''' </summary>
    Sub PopulateList()

        lvwCars.Items.Clear()

        ' Go through every valid car and populate the list with it
        For index As Integer = 0 To carList.Count - 1

            Dim carItem As New ListViewItem()

            carItem.SubItems.Add(carList(index).IdentificationNumber.ToString())
            carItem.SubItems.Add(carList(index).Make)
            carItem.SubItems.Add(carList(index).Model)
            carItem.SubItems.Add(carList(index).Year.ToString())
            carItem.SubItems.Add(carList(index).Price.ToString("c"))
            carItem.Checked = carList(index).IsNew

            isAddingToListView = True

            lvwCars.Items.Add(carItem)

            isAddingToListView = False

        Next

    End Sub

    ''' <summary>
    ''' Set everything except the listview to it's default state
    ''' </summary>
    Sub Reset()

        chkNew.Checked = False
        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        nudYear.Value = 2020
        cboMake.Text = String.Empty
        lblError.Text = String.Empty

        isCarSelected = False

        PopulateList()

    End Sub
#End Region
End Class
