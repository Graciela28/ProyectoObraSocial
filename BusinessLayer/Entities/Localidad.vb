Public Class Localidad
    Private _id As Integer
    Private _nombre As String
    Private _barrios As List(Of Barrio)

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
    Public Property barrios() As List(Of Barrio)
        Get
            Return _barrios
        End Get
        Set(value As List(Of Barrio))
            _barrios = value
        End Set
    End Property
End Class
