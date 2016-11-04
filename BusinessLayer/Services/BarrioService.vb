Public Class BarrioService
    Private oBarrioDao As New BarrioDao
    Public Function GetBarriosConFiltro(ByVal idLocalidad As Integer) As DataTable
        Return oBarrioDao.GetBarriosConFiltro(idLocalidad)
    End Function
End Class
