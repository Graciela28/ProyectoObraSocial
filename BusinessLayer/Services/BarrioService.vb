Public Class BarrioService
    Private oBarrioDao As New BarrioDao

    Public Function GetBarriosConFiltro(ByVal idLocalidad As Integer) As DataTable
        Return oBarrioDao.GetBarriosConFiltro(idLocalidad)
    End Function

    Public Function GetBarriosConFiltro(ByVal oConsultaDeBarrios As ConsultaDeBarrios) As List(Of ConsultaDeBarrios)
        Return oBarrioDao.getBarriosByFilters(oConsultaDeBarrios)
    End Function

    Public Function registrarBarrio(ByVal oBarrio As Barrio) As Boolean
        If oBarrioDao.registrarBarrio(oBarrio) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function eliminarBarrio(ByVal oBarrio As Barrio) As Boolean
        If oBarrioDao.eliminarBarrio(oBarrio) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function actualizarBarrio(ByVal oBarrio As Barrio) As Boolean
        If oBarrioDao.actualizarBarrio(oBarrio) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
