Public Class DomicilioService
    Private oDomicilioDao As New DomicilioDao

    Public Function generarCodigoDomicilio() As Integer
        Return oDomicilioDao.generarCodigoDomicilio()
    End Function

    Public Function actualizarDomicilio(oDomicilio As Domicilio) As Boolean
        If oDomicilioDao.actualizarDomicilio(oDomicilio) = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
