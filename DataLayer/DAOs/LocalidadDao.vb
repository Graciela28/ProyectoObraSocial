Public Class LocalidadDao
    'Devuelve un listado de todas las localidades de la provincia pasada por parámetro 
    Public Function getLocalidadesConFiltro(ByVal idProvincia As Integer) As DataTable
        Dim tabla As New DataTable
        Dim consulta As String = ""
        consulta = "select L.id, L.nombre from Localidades L inner join Provincias P on L.id_provincia = P.id where P.id= " & idProvincia
        tabla = BDHelper.ConsultaSQL(consulta)
        Return tabla
    End Function

End Class
