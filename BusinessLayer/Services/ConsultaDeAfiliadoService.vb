Public Class ConsultaDeAfiliadoService
    Private oConsultaDeAfiliadoDao As ConsultaDeAfiliadoDao

    Public Sub New()
        oConsultaDeAfiliadoDao = New ConsultaDeAfiliadoDao()
    End Sub

    Public Function getAllAfiliados() As List(Of ConsultaDeAfiliado)
        Return oConsultaDeAfiliadoDao.getAllAfiliados()
    End Function
End Class
