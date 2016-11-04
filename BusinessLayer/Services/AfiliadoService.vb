Public Class AfiliadoService
    Private oAfiliadoDao As AfiliadoDao

    Public Sub New()
        oAfiliadoDao = New AfiliadoDao()
    End Sub

    Public Function listarAfiliados() As List(Of ConsultaDeAfiliado)
        Return oAfiliadoDao.getAllAfiliados()
    End Function

    Public Function listarAfiliadosConFiltros(ByVal activo As Integer) As List(Of ConsultaDeAfiliado)
        Return oAfiliadoDao.getByFiltersAfiliados(activo)
    End Function

    Public Function listarAfiliadosConFiltros(ByVal tipo_doc As Integer, ByVal num_doc As Integer) As List(Of ConsultaDeAfiliado)
        Return oAfiliadoDao.getByFiltersAfiliados(tipo_doc, num_doc)
    End Function

    Public Function registrarAfiliado(ByVal oAfiliado As ConsultaDeAfiliado) As Boolean
        If oAfiliadoDao.addAfiliado(oAfiliado) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function actualizarAfiliado(ByVal documento As Integer, ByVal tipo_documento As Integer, ByVal oAfiliado As ConsultaDeAfiliado) As Boolean
        'Return oBugDao.update(oBug)
        oAfiliadoDao.UpdateAfiliado(documento, tipo_documento, oAfiliado)
        Return True
    End Function

    Public Function eliminarAfiliado(ByVal oAfiliado As ConsultaDeAfiliado) As Boolean
        oAfiliadoDao.deleteAfiliado(oAfiliado)
        Return True
    End Function

    Public Function registrarAlta(ByVal oAfiliado As ConsultaDeAfiliado) As Boolean
        oAfiliadoDao.UpdateAfiliado(oAfiliado, 1)
        Return True
    End Function

    Public Function registrarBaja(ByVal oAfiliado As ConsultaDeAfiliado) As Boolean
        oAfiliadoDao.UpdateAfiliado(oAfiliado, 0)
        Return True
    End Function

    Public Function buscarAfiliado(ByVal tipoDocumento As Integer, nroDocumento As Integer) As DataTable
        Return oAfiliadoDao.buscarAfiliado(tipoDocumento, nroDocumento)
    End Function

    Public Function calcularEdad(ByVal oAfiliado As ConsultaDeAfiliado) As Integer
        Return oAfiliadoDao.calcularEdad(oAfiliado)
    End Function

    Public Function validarExistenciaAfiliado(ByVal tipoDoc As Integer, ByVal nroDoc As Integer) As Boolean
        If oAfiliadoDao.validarExistenciaAfiliado(tipoDoc, nroDoc) = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
