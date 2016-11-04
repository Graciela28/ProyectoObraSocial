Public Class TablaTipoService
    Private oTablaTipoDao As TablaTipoDao
    Public Sub New()
        oTablaTipoDao = New TablaTipoDao()
    End Sub

    Public Function ListarTipos(ByVal nombre_tabla As String) As DataTable
        Return oTablaTipoDao.getAllTipos(nombre_tabla)
    End Function

    Public Function getAllTipos(ByVal nombre_tabla As String, ByVal pk As String, ByVal desc As String) As DataTable
        Return oTablaTipoDao.getAllTipos(nombre_tabla, pk, desc)
    End Function
End Class
