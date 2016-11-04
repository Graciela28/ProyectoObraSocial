Public Class ProfesionalService
    Private oProfesionalDao As ProfesionalDao

    Public Sub New()
        oProfesionalDao = New ProfesionalDao()
    End Sub

    Public Function listarProfesionales() As List(Of ConsultaDeProfesional)
        Return oProfesionalDao.getAll()
    End Function

    Public Function listarProfesionalesConFiltros(ByVal activo As Integer) As List(Of ConsultaDeProfesional)
        Return oProfesionalDao.getByFilters(activo)
    End Function

    Public Function registrarProfesional(ByVal oProfesional As ConsultaDeProfesional) As Boolean
        If oProfesionalDao.addProfesional(oProfesional) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function actualizarProfesional(ByVal documento As Integer, ByVal tipo_documento As Integer, ByVal cod_domicilio As Integer, ByVal oProfesional As ConsultaDeProfesional, ByVal isNew As Boolean) As Boolean
        'Return oBugDao.update(oBug)
        oProfesionalDao.UpdateProfesional(documento, tipo_documento, cod_domicilio, oProfesional)
        Return True
    End Function

    Public Function eliminarProfesional(ByVal oProfesional As ConsultaDeProfesional, ByVal isNew As Boolean) As Boolean
        oProfesionalDao.deleteProfesional(oProfesional)
        Return True
    End Function

    Public Function calcularEdad(ByVal oProfesional As ConsultaDeProfesional) As Integer
        Return oProfesionalDao.calcularEdad(oProfesional)
    End Function

    Public Function validarExistenciaProfesional(ByVal tipoDoc As Integer, ByVal nroDoc As Integer) As Boolean
        If oProfesionalDao.validarExistenciaProfesional(tipoDoc, nroDoc) = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validarExistenciaMatricula(ByVal matricula As Integer) As Boolean
        If oProfesionalDao.validarExistenciaMatricula(matricula) = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
