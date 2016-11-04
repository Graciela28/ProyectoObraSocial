Public Class Domicilio
    Private _idDomicilio As Integer
    Private _calle As String
    Private _numero As Integer
    Private _barrio As Barrio

    Public Property idDomicilio() As Integer
        Get
            Return _idDomicilio
        End Get
        Set(value As Integer)
            _idDomicilio = value
        End Set
    End Property
    Public Property calle() As String
        Get
            Return _calle
        End Get
        Set(value As String)
            _calle = value
        End Set
    End Property
    Public Property numero() As Integer
        Get
            Return _numero
        End Get
        Set(value As Integer)
            _numero = value
        End Set
    End Property
    Public Property barrio() As Barrio
        Get
            Return _barrio
        End Get
        Set(value As Barrio)
            _barrio = value
        End Set
    End Property
End Class
