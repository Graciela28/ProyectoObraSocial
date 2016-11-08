
Public Class EspecialidadXProfesionalXCentro

    Public Property idCentro As Integer
    Public Property idEspecialidad As Integer
    Public Property matriculaProfesional As Integer
    Public Property fechaAltaProfesional As DateTime
    Public Property fechaBajaProfesional As DateTime

    Sub New(idCentro As Integer, idEspecialidad As Integer, matriculaProfesional As Integer, fechaAltaProfesional As DateTime)
        Me.idCentro = idCentro
        Me.idEspecialidad = idEspecialidad
        Me.matriculaProfesional = matriculaProfesional
        Me.fechaAltaProfesional = fechaAltaProfesional
    End Sub

End Class
