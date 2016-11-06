Public Class CentroMedicoService
    Private oCentroMedicoDao As CentroMedicoDao

    Public Sub New()
        oCentroMedicoDao = New CentroMedicoDao()
    End Sub

    Public Function listarCentrosMedicos() As List(Of CentroMedico)
        Return oCentroMedicoDao.getAll()
    End Function

    Public Function listarCentrosConFiltros(ByVal activo As Integer) As List(Of CentroMedico)
        Return oCentroMedicoDao.getByFilters(activo)
    End Function

    Public Function registrarCentroMedico(ByVal oCentroMedico As CentroMedico) As Boolean
        If oCentroMedicoDao.addCentroMedico(oCentroMedico) <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function actualizarCentroMedico(ByVal oCentroMedico As CentroMedico) As Boolean

        oCentroMedicoDao.updateCentroMedico(oCentroMedico)
        Return True
        'Return oBugDao.update(oBug)
    End Function

    Public Function eliminarCentroMedico(ByVal id_centro As Integer, ByVal isNew As Boolean) As Boolean
        oCentroMedicoDao.deleteCentroMedico(id_centro)
        Return True
    End Function

    Public Function generarIdCentro() As Integer
        Return oCentroMedicoDao.generarIdCentro()
    End Function

    Public Function buscarCentroMedico(ByVal cod_centro As Integer) As List(Of CentroMedico)
        Return oCentroMedicoDao.buscarCentroMedico(cod_centro)
    End Function
End Class
