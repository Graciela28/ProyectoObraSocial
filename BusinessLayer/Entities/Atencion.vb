Public Class Atencion
    'Atencion
    Public Property fechaAtencion As Date

    'Personas
    Public Property nombreAfiliado As String
    Public Property nombreProfesional As String

    'Afiliados
    Public Property tipoDocAfiliado As Integer
    Public Property nroDocAfiliado As Int32
    Public Property nombreTipoDocumento As String

    'TiposAfiliado
    Public Property idTipoAfil As Integer
    Public Property nombreTipoAfiliado As String

    'CentrosMedicos
    Public Property nombreCentro As String

    'Especialidades
    Public Property nombreEspecialidad As String

    'ProfesionalesxCentroxEspecialidad
    Public Property idCentro As Integer
    Public Property matriculaProfesional As Integer
    Public Property idEspecialidad As Integer
    Public Property fechaAltaProfesional As Date

    'EstadosAtencion
    Public Property idEstado As Integer
    Public Property nombreEstado As String

    'Atención 
    Public Property totalSinCobertura As Double
    Public Property totalConCobertura As Double
    Public Property total As Double
End Class
