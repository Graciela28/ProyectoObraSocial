Public Class CentroMedicoDao

    'Devuelve un listado de todos los centros médicos activos e inactivos 
    Public Function getAll() As List(Of CentroMedico)
        Dim listadoCentrosMedicos As New List(Of CentroMedico)
        Dim strSQL = "select C.id_centro, C.denominacion, C.telefono, C.mail, C.esPropio, " & _
            "D.calle, D.numero, B.nombre as Barrio, L.nombre as Localidad, PR.nombre as Provincia " & _
            "from CentrosMedicos C inner join Domicilios D on C.id_domicilio = D.id_domicilio " & _
            " inner join Barrios B on D.id_barrio = B.id_barrio inner join Localidades L " & _
            "on B.id_localidad = L.id inner join Provincias PR on L.id_provincia = PR.id"

        For Each row As DataRow In BDHelper.ConsultaSQL(strSQL).Rows
            listadoCentrosMedicos.Add(map(row))
        Next
        Return listadoCentrosMedicos
    End Function

    'Devuelve un listado de todos los centros médicos según el estado que se pase por parámetro
    Public Function getByFilters(ByVal estado As Integer) As List(Of CentroMedico)

        Dim listadoCentrosMedicos As New List(Of CentroMedico)
        Dim strSQL = "select C.id_centro, C.denominacion, C.telefono, C.mail, C.esPropio, " & _
            "D.id_domicilio, D.calle, D.numero, B.id_barrio, L.id as idLocalidad, PR.id as idProvincia " & _
            "from CentrosMedicos C inner join Domicilios D on C.id_domicilio = D.id_domicilio " & _
            " inner join Barrios B on D.id_barrio = B.id_barrio inner join Localidades L " & _
            "on B.id_localidad = L.id inner join Provincias PR on L.id_provincia = PR.id where C.id_centro = " & estado

        If estado <> -1 Then strSQL += " and C.activo = " & estado
        strSQL += " order by C.denominacion DESC"

        For Each row As DataRow In BDHelper.ConsultaSQL(strSQL).Rows
            listadoCentrosMedicos.Add(map(row))
        Next
        Return listadoCentrosMedicos
    End Function

    'Busca un Centro Médico con el código pasado por parámetro 
    Public Function buscarCentroMedico(ByVal cod_centro As Integer) As List(Of CentroMedico)

        Dim listaCentrosMedicos As New List(Of CentroMedico)
        Dim consulta As String = ""
        consulta = "select C.id_centro, C.denominacion, C.telefono, C.mail, C.esPropio, " & _
            "D.id_domicilio, D.calle, D.numero, B.id_barrio, L.id as idLocalidad, PR.id as idProvincia " & _
            "from CentrosMedicos C inner join Domicilios D on C.id_domicilio = D.id_domicilio " & _
            " inner join Barrios B on D.id_barrio = B.id_barrio inner join Localidades L " & _
            "on B.id_localidad = L.id inner join Provincias PR on L.id_provincia = PR.id where C.id_centro = @cod_centro"

        Dim connection As New SqlClient.SqlConnection
        Dim command As SqlClient.SqlCommand
        Dim tabla As New DataTable

        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()

            command = New SqlClient.SqlCommand(consulta, connection)
            command.Parameters.AddWithValue("@cod_centro", cod_centro)
            tabla.Load(command.ExecuteReader())

        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la búsqueda de Afiliados")
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try

        For Each row As DataRow In tabla.Rows
            listaCentrosMedicos.Add(mapToCentroMedico(row))
        Next
        Return listaCentrosMedicos
    End Function

    Private Function mapToCentroMedico(row As DataRow) As CentroMedico
        Dim oCentroMedico As New CentroMedico
        With oCentroMedico
            .idCentro = Convert.ToInt16(row.Item("id_centro").ToString)
            .denominacion = row.Item("denominacion").ToString
            .idDomicilio = Convert.ToInt16(row.Item("id_domicilio").ToString)
            If IsDBNull(row.Item("telefono")) Then
                .telefonoCentro = -1
            Else
                .telefonoCentro = Convert.ToInt32(row.Item("telefono").ToString)
            End If

            .mail = row.Item("mail").ToString
            If Convert.ToInt16(row.Item("esPropio").ToString) = 1 Then
                .esPropio = True
            Else
                .esPropio = False
            End If
            .calle = row.Item("calle").ToString
            .numero = Convert.ToInt32(row.Item("numero").ToString)
            .codBarrio = Convert.ToInt32(row.Item("id_barrio").ToString)
            .idLocalidad = Convert.ToInt32(row.Item("idLocalidad").ToString)
            .idProvincia = Convert.ToInt32(row.Item("idProvincia").ToString)
        End With
        Return oCentroMedico
    End Function

    Private Function map(row As DataRow) As CentroMedico
        Dim oCentroMedico As New CentroMedico
        With oCentroMedico
            .idCentro = Convert.ToInt32(row.Item("id_centro").ToString)
            .denominacion = row.Item("denominacion").ToString

            If IsDBNull(row.Item("telefono")) Then
                .telefonoCentro = -1
            Else
                .telefonoCentro = Convert.ToInt32(row.Item("telefono").ToString)
            End If

            .mail = row.Item("mail").ToString
            .esPropio = row.Item("esPropio").ToString
            .calle = row.Item("calle").ToString
            .numero = Convert.ToInt32(row.Item("numero").ToString)
            .nombreBarrio = row.Item("Barrio").ToString
            .nombreLocalidad = row.Item("Localidad").ToString
            .nombreProvincia = row.Item("Provincia").ToString
        End With
        Return oCentroMedico
    End Function

    Public Function addCentroMedico(ByVal oCentroMedico As CentroMedico) As Integer
        Dim status As Integer = 0
        Dim conexion As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand

        Try
            conexion.ConnectionString = BDHelper.string_conexion
            conexion.Open()

            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_Insertar_CentroMedico"
            command.Connection = conexion
            Dim oDomicilioDao As New DomicilioDao
            Dim id_centro As New Integer
            id_centro = generarIdCentro()
            Dim id_domicilio As New Integer
            id_domicilio = oDomicilioDao.generarCodigoDomicilio()

            command.Parameters.AddWithValue("@id_centro", id_centro)
            command.Parameters.AddWithValue("@denominacion", oCentroMedico.denominacion)
            command.Parameters.AddWithValue("@id_domicilio", id_domicilio)
            If oCentroMedico.telefonoCentro = 0 Then
                command.Parameters.AddWithValue("@telefono", DBNull.Value)
            Else
                command.Parameters.AddWithValue("@telefono", oCentroMedico.telefonoCentro.ToString)
            End If
            command.Parameters.AddWithValue("@mail", oCentroMedico.mail)
            command.Parameters.AddWithValue("@esPropio", oCentroMedico.esPropio.ToString)
            command.Parameters.AddWithValue("@activo", 1)
            command.Parameters.AddWithValue("@calle", oCentroMedico.calle)
            command.Parameters.AddWithValue("@numero", oCentroMedico.numero.ToString)
            command.Parameters.AddWithValue("@id_barrio", oCentroMedico.codBarrio.ToString)

            status = command.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en registro del Centro Médico")
            Exit Function
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return status
    End Function

    Public Function generarIdCentro() As Integer
        Dim tabla As New Data.DataTable
        tabla = BDHelper.ConsultaSQL("SELECT * FROM CentrosMedicos")

        If tabla.Rows.Count > 0 Then
            tabla = BDHelper.ConsultaSQL("SELECT MAX(id_centro) AS cod_centro FROM CentrosMedicos")
            If tabla.Rows.Count > 0 Then
                Return CInt(tabla.Rows(0)("cod_centro").ToString) + 1
            End If
        End If
        Return 1
    End Function

    Public Function updateCentroMedico(ByVal oCentroMedico As CentroMedico) As Integer
        Dim status As Integer = 0
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand

        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()

            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_modificar_CentroMedico"
            command.Connection = connection
            command.Parameters.AddWithValue("@id_CentroA", oCentroMedico.idCentro)
            command.Parameters.AddWithValue("@denominacion", oCentroMedico.denominacion)
            command.Parameters.AddWithValue("@calle", oCentroMedico.calle)
            command.Parameters.AddWithValue("@numero", oCentroMedico.numero.ToString)
            command.Parameters.AddWithValue("@id_barrio", oCentroMedico.codBarrio.ToString)
            If oCentroMedico.telefonoCentro = 0 Then
                command.Parameters.AddWithValue("@telefono", DBNull.Value)
            Else
                command.Parameters.AddWithValue("@telefono", oCentroMedico.telefonoCentro.ToString)
            End If
            command.Parameters.AddWithValue("@mail", oCentroMedico.mail)
            command.Parameters.AddWithValue("@esPropio", oCentroMedico.esPropio.ToString)
            command.Parameters.AddWithValue("@activo", oCentroMedico.activo)
            status = command.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la actualización del Afiliado")
            status = 0
        Finally
            connection.Close()
            connection.Dispose()
        End Try
        Return status
    End Function

    

    Public Sub deleteCentroMedico(ByVal id_centro As Integer)
        Dim conexion As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Try
            conexion.ConnectionString = BDHelper.string_conexion
            conexion.Open()

            command.Connection = conexion
            command.CommandType = CommandType.Text
            command.CommandText = "UPDATE CentrosMedicos SET activo = 0 WHERE id_centro = " + id_centro
            command.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la eliminación de un Centro Médico")
            Exit Sub
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub
End Class
