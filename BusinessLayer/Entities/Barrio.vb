Public Class Barrio
    Private _id As Integer
    Private _nombre As String
    Private _idLocalidad As Integer

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
    Public Property idLocalidad() As Integer
        Get
            Return _idLocalidad
        End Get
        Set(value As Integer)
            _idLocalidad = value
        End Set
    End Property
End Class
