Public Class ProfesionalesxCentroxEspecialidadService
    Private oProfesionalesxCentroxEspecialidadDao As ProfesionalesxCentroxEspecialidadDao

    Public Sub New()
        oProfesionalesxCentroxEspecialidadDao = New ProfesionalesxCentroxEspecialidadDao()
    End Sub

    Public Function getCentrosMedicos() As DataTable
        Return oProfesionalesxCentroxEspecialidadDao.getCentrosMedicos()
    End Function

    Public Function getEspecialidadesConFiltro(ByVal idCentro As Integer) As DataTable
        Return oProfesionalesxCentroxEspecialidadDao.getEspecialidadesConFiltro(idCentro)
    End Function

    Public Function getProfesionalesConFiltro(ByVal idCentro As Integer, ByVal idEspecialidad As Integer) As DataTable
        Return oProfesionalesxCentroxEspecialidadDao.getProfesionalesConFiltro(idCentro, idEspecialidad)
    End Function

    Public Function buscarProfesional(ByVal idCentro As Integer, ByVal idEspecialidad As Integer, ByVal matricula As Integer) As DataTable
        Return oProfesionalesxCentroxEspecialidadDao.buscarProfesional(idCentro, idEspecialidad, matricula)
    End Function
End Class
