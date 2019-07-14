Option Strict On

Public Class Vehicles


    Private Shared vehicleCount As Integer                  ' static or shared private variable to hold the number of vehicle
    Private vehicleId As Integer = 0            ' private variable for identification number
    Private vehicleMake As String = String.Empty            ' private variable for make
    Private vehicleModel As String = String.Empty           ' private variable for model
    Private vehicleYear As String = String.Empty            ' private variable for year
    Private vehiclePrice As String = String.Empty           ' private variable for price
    Private vehicleNew As Boolean = False             ' private variable for status


    Public Sub New()

        vehicleCount += 1      ' increment the shared/static variable counter by 1
        vehicleId = vehicleCount ' assign the customers id

    End Sub

    ''' <summary>
    ''' Constuctor - Parameterized 
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <param name="newCar"></param>
    Public Sub New(make As String, model As String, year As String, price As String, newCar As Boolean)


        Me.New()


        vehicleMake = make
        vehicleModel = model
        vehicleYear = year
        vehiclePrice = price
        vehicleNew = newCar
    End Sub


    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of customers that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return vehicleCount
        End Get
    End Property

    ''' <summary>
    ''' ID property - Sets car order
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property idNumber() As Integer
        Get
            Return vehicleId
        End Get
    End Property

    ''' <summary>
    ''' New Car property - Gets and Sets the new car status
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property newCar() As Boolean
        Get
            Return vehicleNew
        End Get
        Set(ByVal value As Boolean)
            vehicleNew = value
        End Set
    End Property

    ''' <summary>
    ''' Make property - Gets and Sets the Make of the vehicle
    ''' </summary>
    ''' <returns>String</returns>
    Public Property make() As String
        Get
            Return vehicleMake
        End Get
        Set(ByVal value As String)
            vehicleMake = value
        End Set
    End Property

    ''' <summary>
    ''' Model property - Gets and Sets the model of the vehicle
    ''' </summary>
    ''' <returns>String</returns>
    Public Property model() As String
        Get
            Return vehicleModel
        End Get
        Set(ByVal value As String)
            vehicleModel = value
        End Set
    End Property

    ''' <summary>
    ''' Year property - Gets and Sets the Year
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Year() As String
        Get
            Return vehicleYear
        End Get
        Set(ByVal value As String)
            vehicleYear = value
        End Set
    End Property

    ''' <summary>
    ''' Price property - Gets and Sets the price of vehicle
    ''' </summary>
    ''' <returns>String</returns>

    Public Property Price() As String
        Get
            Return vehiclePrice
        End Get
        Set(ByVal value As String)
            vehiclePrice = value
        End Set
    End Property

    Public Function GetSalutation() As String

        Return "It works".ToString()
    End Function


End Class
