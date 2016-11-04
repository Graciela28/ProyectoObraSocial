Public Class Provincia

    Private _id As Integer
    Private _nombre As String
    Private _localidades As List(Of Localidad)

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property localidades() As List(Of Localidad)
        Get
            Return _localidades
        End Get
        Set(value As List(Of Localidad))
            _localidades = value
        End Set
    End Property
End Class
