Public Class DetalleAtencion
    'Datos de la tabla Atenciones
    Public Property fechaAtencion As Date

    'Datos de la tabla Afiliados
    Public Property tipoDocAfiliado As Integer
    Public Property nroDocAfiliado As Int32

    'Datos de la tabla ProfesionalesxCentroxEspecialidad
    Public Property idCentro As Integer
    Public Property matriculaProfesional As Integer
    Public Property idEspecialidad As Integer
    Public Property fechaAltaProfesional As Date

    'Datos de la tabla Practicas
    Public Property nombrePractica As String

    'Datos de la tabla DetalleAtencion 
    Public Property idPractica As Integer
    Public Property precioPracticaSinCobertura As Double
    Public Property cobertura As Integer
    Public Property precioPracticaConCobertura As Double
    Public Property cantidad As Integer
    Public Property subtotal As Double
End Class
