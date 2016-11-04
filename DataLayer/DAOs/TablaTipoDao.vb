Public Class TablaTipoDao

    'Devuelve un listado de todos los Tipos de Afiliado, Documento o Provincias 
    Public Function getAllTipos(ByVal nombre_tabla As String) As DataTable
        Dim tabla As New DataTable
        Dim listaTipos As New List(Of TablaTipo)
        Dim strSQL = "SELECT * FROM " & nombre_tabla
        tabla = BDHelper.ConsultaSQL(strSQL)
        For Each row As DataRow In tabla.Rows
            listaTipos.Add(mapToTablaTipo(row))
        Next
        Return tabla
    End Function

    Private Function mapToTablaTipo(row As DataRow) As TablaTipo
        Dim oTablaTipo As New TablaTipo
        With oTablaTipo
            .id = Convert.ToInt16(row.Item("id").ToString)
            .nombre = row.Item("nombre").ToString
        End With
        Return oTablaTipo
    End Function

    Public Function getAllTipos(ByVal nombre_tabla As String, ByVal pk As String, ByVal desc As String) As Data.DataTable
        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = BDHelper.string_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select " & pk & " as Nro, " & desc & " as Descripcion from " & nombre_tabla
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function
End Class
