Public Class CentroMedico

    'Datos de la tabla CentroMedico
    Public Property idCentro As Integer
    Public Property denominacion As String
    'Public Property idDomicilio As Integer
    Public Property telefonoCentro As Int32
    Public Property mail As String
    Public Property esPropio As Boolean

    'Datos de la tabla Domicilios
    Public Property idDomicilio As Integer
    Public Property calle As String
    Public Property numero As Integer
    Public Property codBarrio As Integer

    'Datos de la tabla de Barrios
    Public Property nombreBarrio As String
    Public Property idLocalidad As Integer

    'Datos de la tabla Localidades
    Public Property nombreLocalidad As String
    Public Property idProvincia As Integer

    'Datos de la tabla Provincias
    Public Property nombreProvincia As String

    'Datos de la tabla CentrosMedicos
    Public Property activo As Boolean

End Class
