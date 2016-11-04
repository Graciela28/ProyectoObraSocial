Public Class ConsultaDeAfiliado
    'Datos de la tabla Persona
    Public Property idTipoDoc As Integer
    Public Property numeroDoc As Int32
    Public Property nombreAfiliado As String
    Public Property apellidoAfiliado As String
    Public Property fechaNacimiento As Date
    Public Property direccion As Int32
    Public Property telefono As Int32
    Public Property mailAfiliado As String

    'Datos de la  tabla Afiliado
    Public Property idTipoAfil As Integer
    Public Property empresaConvenio As String
    Public Property activo As Boolean

    'Datos de la tabla TiposDocumento y TiposAfiliado
    Public Property nombreTipoAfiliado As String
    Public Property nombreTipoDocumento As String


    'Datos de la tabla Domicilios
    Public Property id_domicilio As Integer
    Public Property calle As String
    Public Property numero As Integer
    Public Property codBarrio As Integer

    'Datos de la tabla de Barrios
    Public Property nombreBarrio As String

    'Datos de la tabla Localidades
    Public Property idLocalidad As Integer
    Public Property nombreLocalidad As String

    'Datos de la tabla Provincias
    Public Property idProvincia As Integer
    Public Property nombreProvincia As String
End Class
