Public Class BarrioDao

    Public Function GetBarriosConFiltro(ByVal idLocalidad As Integer) As DataTable
        Dim tabla As New DataTable
        Dim consulta As String = "select B.id_barrio, B.nombre from Barrios B inner join Localidades L on B.id_localidad = L.id where B.id_localidad =  " & idLocalidad
        tabla = BDHelper.ConsultaSQL(consulta)
        Return tabla
    End Function
End Class
