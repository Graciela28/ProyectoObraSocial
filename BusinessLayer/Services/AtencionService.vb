Public Class AtencionService
    Private oAtencionDao As AtencionDao

    Public Sub New()
        oAtencionDao = New AtencionDao()
    End Sub

    Public Function obtenerFechaActual() As String
        Return oAtencionDao.obtenerFechaActual()
    End Function

    Public Function listarAtencionesConFiltro(Optional ByVal fechaInicio As DateTime = Nothing, Optional ByVal fechaFin As DateTime = Nothing, Optional ByVal tipoDoc As Integer = Nothing, Optional ByVal numDoc As Integer = Nothing) As List(Of Atencion)
        Return oAtencionDao.ListarAtencionesConFiltro(fechaInicio, fechaFin, tipoDoc, numDoc)
    End Function

    Public Function registrarAtencion(ByVal oAtencion As Atencion, ByVal listaDetalles As List(Of DetalleAtencion)) As Boolean
        Return oAtencionDao.registrarAtencion(oAtencion, listaDetalles)
    End Function

    Public Function validarExistenciaAtencion(ByVal oAtencion As Atencion) As DataTable
        Return oAtencionDao.validarExistenciaAtencion(oAtencion)
    End Function

    Public Function getDetallesAtencionByFilters(ByVal oAtencion As Atencion) As List(Of DetalleAtencion)
        Return oAtencionDao.getDetallesAtencionByFilters(oAtencion)
    End Function

    Public Function eliminarAtencion(ByVal oAtencion As Atencion) As Boolean
        Return oAtencionDao.eliminarAtencion(oAtencion)
    End Function
End Class
