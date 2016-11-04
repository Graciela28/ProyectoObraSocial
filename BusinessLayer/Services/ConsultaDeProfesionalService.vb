Public Class ConsultaDeProfesionalService
    Private oConsultaDeProfesionalDao As ConsultaDeProfesionalDao

    Public Sub New()
        oConsultaDeProfesionalDao = New ConsultaDeProfesionalDao()
    End Sub

    Public Function getAllProfesionales() As List(Of ConsultaDeProfesional)
        Return oConsultaDeProfesionalDao.getAllProfesionales()
    End Function
End Class
