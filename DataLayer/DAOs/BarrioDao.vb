Public Class BarrioDao

    Public Function GetBarriosConFiltro(ByVal idLocalidad As Integer) As DataTable
        Dim tabla As New DataTable
        Dim consulta As String = "select B.id_barrio, B.nombre from Barrios B inner join Localidades L on B.id_localidad = L.id where B.id_localidad =  " & idLocalidad
        tabla = BDHelper.ConsultaSQL(consulta)
        Return tabla
    End Function

    Public Function getBarriosByFilters(ByVal oConsultaDeBarrios As ConsultaDeBarrios) As List(Of ConsultaDeBarrios)
        Dim listaBarrios As New List(Of ConsultaDeBarrios)
        Dim consulta As String = ""

        consulta = "Select P.id as id_prov, P.nombre as n_prov, L.id as id_local, L.nombre as n_local, B.id_barrio, B.nombre as n_barrio "
        consulta += "from Barrios B inner join Localidades L on B.id_localidad = L.id "
        consulta += "inner join Provincias P on L.id_provincia = P.id "
        consulta += "where P.id = @idProvincia and "
        consulta += "L.id = @idLocalidad"

        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As SqlClient.SqlCommand

        Dim dt As New Data.DataTable
        conexion.ConnectionString = BDHelper.string_conexion
        conexion.Open()

        cmd = New SqlClient.SqlCommand(consulta, conexion)
        cmd.Parameters.AddWithValue("@idProvincia", oConsultaDeBarrios.idProvincia)
        cmd.Parameters.AddWithValue("@idLocalidad", oConsultaDeBarrios.idLocalidad)

        dt.Load(cmd.ExecuteReader())
        conexion.Close()

        For Each row As DataRow In dt.Rows
            listaBarrios.Add(mapToConsultaDeBarrios(row))
        Next
        Return listaBarrios
    End Function

    Private Function mapToConsultaDeBarrios(row As DataRow) As ConsultaDeBarrios
        Dim oConsultaDeBarrios As New ConsultaDeBarrios
        With oConsultaDeBarrios
            .idProvincia = Convert.ToInt32(row.Item("id_prov").ToString())
            .nombreProvincia = row.Item("n_prov").ToString()
            .idLocalidad = Convert.ToInt32(row.Item("id_local").ToString())
            .nombreLocalidad = row.Item("n_local").ToString()
            .idBarrio = Convert.ToInt32(row.Item("id_barrio").ToString())
            .nombreBarrio = row.Item("n_barrio").ToString()
        End With
        Return oConsultaDeBarrios
    End Function

    Public Function registrarBarrio(ByVal oBarrio As Barrio) As Integer

        Dim status As Integer = 0
        Dim consulta As String
        oBarrio.id = Me.generarCodigoBarrio()

        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand

        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            consulta = "insert into Barrios values (@idBarrio, @nombre, @idLocalidad)"
            command = New SqlClient.SqlCommand(consulta, connection)
            command.Parameters.AddWithValue("@idBarrio", oBarrio.id)
            command.Parameters.AddWithValue("@nombre", oBarrio.nombre)
            command.Parameters.AddWithValue("@idLocalidad", oBarrio.idLocalidad)
            status = command.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la inserción de Barrio ")
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try
        Return status
    End Function

    'Public Function generarCodigoBarrio() As Integer
    '    Dim tabla As New Data.DataTable
    '    Dim cod_barrio As Integer
    '    Dim consulta As String = ""
    '    consulta = "select count(id_barrio) from barrios "
    '    Dim conexion As New SqlClient.SqlConnection
    '    Dim cmd As SqlClient.SqlCommand
    '    conexion.ConnectionString = BDHelper.string_conexion
    '    conexion.Open()

    '    cmd = New SqlClient.SqlCommand(consulta, conexion)
    '    tabla.Load(cmd.ExecuteReader())
    '    conexion.Close()
    '    cod_barrio = CInt(tabla.Rows(0)(0).ToString) + 1
    '    Return cod_barrio
    'End Function

    Public Function generarCodigoBarrio() As Integer
        Dim tabla As New Data.DataTable
        Dim cod_barrio As Integer
        tabla = BDHelper.ConsultaSQL("select * from Barrios")

        If tabla.Rows.Count > 0 Then
            tabla = BDHelper.ConsultaSQL("select max(id_barrio) as codigoBarrio from Barrios")
            If tabla.Rows.Count > 0 Then
                cod_barrio = CInt(tabla.Rows(0)("codigoBarrio").ToString) + 1
            End If
        Else
            cod_barrio = 1
        End If
        Return cod_barrio
    End Function

    Public Function eliminarBarrio(ByVal oBarrio As Barrio) As Integer

        Dim status As Integer = 0
        Dim consulta As String

        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand

        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            consulta = "delete from Barrios where id_barrio = @idBarrio"
            command = New SqlClient.SqlCommand(consulta, connection)
            command.Parameters.AddWithValue("@idBarrio", oBarrio.id)
            status = command.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error al eliminar el Barrio ")
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try
        Return status
    End Function

    Public Function actualizarBarrio(ByVal oBarrio As Barrio) As Integer

        Dim status As Integer = 0
        Dim consulta As String

        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand

        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            consulta = "update Barrios set nombre = @nombre where id_barrio = @idBarrio"
            command = New SqlClient.SqlCommand(consulta, connection)
            command.Parameters.AddWithValue("@nombre", oBarrio.nombre)
            command.Parameters.AddWithValue("@idBarrio", oBarrio.id)
            status = command.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error al actualizar el Barrio ")
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try
        Return status
    End Function
End Class
