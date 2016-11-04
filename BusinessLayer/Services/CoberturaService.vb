Public Class CoberturaService
    Private oCoberturaDao As CoberturaDao

    Public Sub New()
        oCoberturaDao = New CoberturaDao()
    End Sub

    Public Function buscarCobertura(ByVal tipoAfiliado As Integer, ByVal idPractica As Integer, ByVal idEspecialidad As Integer, ByVal idCentro As Integer) As List(Of Cobertura)
        Return oCoberturaDao.buscarCobertura(tipoAfiliado, idPractica, idEspecialidad, idCentro)
    End Function

    Public Function calcularSubTotal(ByVal precio As Double, ByVal porcentajeCobertura As Integer, ByVal cantidad As Integer) As Double
        Dim SubTotal As Double
        SubTotal = (precio - (precio * porcentajeCobertura / 100)) * cantidad
        Return SubTotal
    End Function
End Class
