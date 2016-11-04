Public Class PracticasxEspecialidadService
    Private oPracticasxEspecialidadDao As PracticasxEspecialidadDao

    Public Sub New()
        oPracticasxEspecialidadDao = New PracticasxEspecialidadDao()
    End Sub

    Public Function getPracticasConFiltro(ByVal idEspecialidad As Integer) As DataTable
        Return oPracticasxEspecialidadDao.getPracticasConFiltro(idEspecialidad)
    End Function
End Class
