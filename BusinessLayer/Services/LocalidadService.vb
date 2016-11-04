Public Class LocalidadService
    Private oLocalidadDao As New LocalidadDao

    Public Function getLocalidadesConFiltro(ByVal idProvincia As Integer) As DataTable
        Return oLocalidadDao.getLocalidadesConFiltro(idProvincia)
    End Function

End Class
