Public Class PersonaService
    Private oPersonaDao As New PersonaDao

    Public Function validarExistencia(ByVal tipoDoc As Integer, ByVal nroDoc As Integer) As Boolean
        If oPersonaDao.validarExistencia(tipoDoc, nroDoc) = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
