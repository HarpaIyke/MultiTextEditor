' Name: Shaheed Ramjohn
' Co-Author: Kyle Chapman
' Date: April 17, 2020
' Description: Car class for frmCarInventory

Option Strict On
Public Class Car

#Region "Variable Declarations"

    Private Shared carCount As Integer = 0
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0.0D
    Private carIsNew As Boolean = True

#End Region

#Region "Constructors"

    ''' <summary>
    ''' Default constructor: Increments the car count and sets the ID number
    ''' </summary>
    Friend Sub New()
        carCount += 1
        carIdentificationNumber = carCount
    End Sub

    ''' <summary>
    ''' Sets all private variables based on arguments passed in
    ''' </summary>
    ''' <param name="makeValue">A car's manufacturer</param>
    ''' <param name="modelValue">A car's model</param>
    ''' <param name="yearValue">The year a car was manufactured</param>
    ''' <param name="priceValue">A car's price</param>
    ''' <param name="newValue">True if a car is new, false if not</param>
    Friend Sub New(makeValue As String, modelValue As String, yearValue As Integer, priceValue As Decimal, newValue As Boolean)

        Me.New()

        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carIsNew = newValue

    End Sub

#End Region

#Region "Property Procedures"

    ''' <summary>
    ''' Returns the number of car objects
    ''' </summary>
    ''' <returns>The number of car objects</returns>
    Public Shared ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' Returns a cars unique identification number
    ''' </summary>
    ''' <returns>An integer specifying this car</returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' Gets and sets a car's manufacturer
    ''' </summary>
    ''' <returns>A car's manufacturer</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car's model
    ''' </summary>
    ''' <returns>A car's model</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car's year of manufacture
    ''' </summary>
    ''' <returns>A car's year of manufacture</returns>
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car's price
    ''' </summary>
    ''' <returns>A car's price</returns>
    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a flag indicating whether the car is new or not
    ''' </summary>
    ''' <returns>True if the car is new, false if not</returns>
    Public Property IsNew() As Boolean
        Get
            Return carIsNew
        End Get
        Set(value As Boolean)
            carIsNew = value
        End Set
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Returns a string describing the car
    ''' </summary>
    ''' <returns>A string decribing the car</returns>
    Friend Function GetCarData() As String

        Return If(carIsNew, "New ", "Used ").ToString & carYear & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")

    End Function

#End Region

End Class
