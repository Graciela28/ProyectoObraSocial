Public Class AfiliadoDao

    'Devuelve un listado de todos los Afiliados que se encuentran activos
    Public Function getAllAfiliados() As List(Of ConsultaDeAfiliado)
        Dim listaAfiliados As New List(Of ConsultaDeAfiliado)
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim tabla As New DataTable

        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_Listar_Afiliados"
            command.Parameters.AddWithValue("@activo", 1)
            command.Parameters.AddWithValue("@tipo_doc", DBNull.Value)
            command.Parameters.AddWithValue("@num_doc", DBNull.Value)
            tabla.Load(command.ExecuteReader())
        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la consulta de Afiliados")
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try

        For Each row As DataRow In tabla.Rows
            listaAfiliados.Add(mapToAfiliado(row))
        Next

        Return listaAfiliados
    End Function

    'Devuelve un listado de todos los Afiliados que se encuentran en el estado pasado por parámetro 
    Public Function getByFiltersAfiliados(ByVal activo As Integer) As List(Of ConsultaDeAfiliado)

        Dim listaAfiliados As New List(Of ConsultaDeAfiliado)
        Dim strSQL = "SELECT P.id_tipo_doc, TD.nombre as Tipo_documento, P.numero_doc, P.nombre, P.apellido, " & _
            "P.fecha_nacimiento, P.telefono, P.mail, D.calle, D.numero, B.id_barrio, B.nombre as Barrio, " & _
            "L.nombre as Localidad, PR.nombre as Provincia, A.id_tipo_afil, A.empresa_convenio, TA.nombre as Tipo_Afiliado, A.activo  " & _
            "from Afiliados A inner join Personas P on A.id_tipo_doc = P.id_tipo_doc " & _
            "and A.numero_doc = P.numero_doc inner join TiposAfiliado TA on A.id_tipo_afil = TA.id " & _
            "inner join TiposDocumento TD on P.id_tipo_doc = TD.id inner join Domicilios D " & _
            "on P.direccion = D.id_domicilio inner join Barrios B on D.id_barrio = B.id_barrio " & _
            "inner join Localidades L on B.id_localidad = L.id inner join Provincias PR on " & _
            "L.id_provincia = PR.id where 1 = 1"

        If activo <> -1 Then strSQL += " and A.activo = " & activo
        strSQL += " order by P.apellido DESC"
        For Each row As DataRow In BDHelper.ConsultaSQL(strSQL).Rows
            listaAfiliados.Add(mapToAfiliado(row))
        Next
        Return listaAfiliados
    End Function

    'Devuelve el Afiliado con el tipo de documento y el número de documento pasado por parámetro 
    Public Function getByFiltersAfiliados(ByVal tipo_doc As Integer, ByVal num_doc As Integer) As List(Of ConsultaDeAfiliado)

        Dim listaAfiliados As New List(Of ConsultaDeAfiliado)
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim tabla As New DataTable

        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_listar_Afiliados"
            command.Parameters.AddWithValue("@activo", DBNull.Value)
            command.Parameters.AddWithValue("@tipo_doc", DBNull.Value)
            command.Parameters.AddWithValue("@num_doc", num_doc)
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
            listaAfiliados.Add(mapToAfiliado(row))
        Next
        Return listaAfiliados
    End Function

    Private Function mapToAfiliado(row As DataRow) As ConsultaDeAfiliado
        Dim oAfiliado As New ConsultaDeAfiliado
        With oAfiliado
            .idTipoDoc = Convert.ToInt32(row.Item("id_tipo_doc").ToString)
            .nombreTipoDocumento = row.Item("Tipo_documento").ToString
            .numeroDoc = Convert.ToInt32(row.Item("numero_doc").ToString)
            .idTipoAfil = Convert.ToInt32(row.Item("id_tipo_afil").ToString)
            .empresaConvenio = row.Item("empresa_convenio").ToString
            .nombreAfiliado = row.Item("nombre").ToString
            .apellidoAfiliado = row.Item("apellido").ToString
            .fechaNacimiento = Convert.ToDateTime(row.Item("fecha_nacimiento").ToString)

            If IsDBNull(row.Item("telefono")) Then
                .telefono = 0
            Else
                .telefono = Convert.ToInt32(row.Item("telefono").ToString)
            End If

            .mailAfiliado = row.Item("mail").ToString
            .calle = row.Item("calle").ToString
            .numero = Convert.ToInt32(row.Item("numero").ToString)
            .codBarrio = Convert.ToInt32(row.Item("id_barrio").ToString)
            .nombreBarrio = row.Item("Barrio").ToString
            .idLocalidad = Convert.ToInt16(row.Item("id_localidad").ToString)
            .nombreLocalidad = row.Item("Localidad").ToString
            .idProvincia = Convert.ToInt16(row.Item("id_provincia").ToString)
            .nombreProvincia = row.Item("Provincia").ToString
            .nombreTipoAfiliado = row.Item("Tipo_Afiliado").ToString
            .activo = Convert.ToInt32(row.Item("activo"))
        End With
        Return oAfiliado
    End Function

    Public Function addAfiliado(ByVal oAfiliado As ConsultaDeAfiliado) As Integer
        Dim status As Integer = 0
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand

        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()

            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_Insertar_Afiliado"
            command.Connection = connection

            command.Parameters.AddWithValue("@tipoDocumento", oAfiliado.idTipoDoc.ToString)
            command.Parameters.AddWithValue("@numeroDocumento", oAfiliado.numeroDoc)
            command.Parameters.AddWithValue("@nombre", oAfiliado.nombreAfiliado)
            command.Parameters.AddWithValue("@apellido", oAfiliado.apellidoAfiliado)
            command.Parameters.AddWithValue("@fechaNacimiento", oAfiliado.fechaNacimiento)
            command.Parameters.AddWithValue("@activo", oAfiliado.activo)
            command.Parameters.AddWithValue("@tipo_afil", oAfiliado.idTipoAfil)
            command.Parameters.AddWithValue("@codDomicilio", oAfiliado.id_domicilio)
            command.Parameters.AddWithValue("@calle", oAfiliado.calle)
            command.Parameters.AddWithValue("@numero", oAfiliado.numero)
            command.Parameters.AddWithValue("@barrio", oAfiliado.codBarrio)
            command.Parameters.AddWithValue("@telefono", oAfiliado.telefono)
            command.Parameters.AddWithValue("@mail", oAfiliado.mailAfiliado)
            status = command.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la inserción de Afiliados")
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try
        Return status
    End Function

    

    'Recibe el tipo y el nro de documento a actualizar 
    Public Sub UpdateAfiliado(ByVal documento As Integer, ByVal tipo_documento As Integer, ByVal oAfiliado As ConsultaDeAfiliado)
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_modificar_Afiliado"
            command.Connection = connection

            command.Parameters.AddWithValue("@numeroDocumentoA", documento)
            command.Parameters.AddWithValue("@tipoDocumentoA", tipo_documento)
            command.Parameters.AddWithValue("@tipo_afil", oAfiliado.idTipoAfil)
            command.Parameters.AddWithValue("@tipoDocumento", oAfiliado.idTipoDoc)
            command.Parameters.AddWithValue("@numeroDocumento", oAfiliado.numeroDoc)
            command.Parameters.AddWithValue("@nombre", oAfiliado.nombreAfiliado)
            command.Parameters.AddWithValue("@apellido", oAfiliado.apellidoAfiliado)
            command.Parameters.AddWithValue("@fechaNacimiento", oAfiliado.fechaNacimiento)
            command.Parameters.AddWithValue("@calle", oAfiliado.calle)
            command.Parameters.AddWithValue("@numero", oAfiliado.numero)
            command.Parameters.AddWithValue("@barrio", oAfiliado.codBarrio)
            'Si el objeto Afiliado no tiene un telefono, mando null para que se inserte en el campo telefono

            If oAfiliado.telefono = 0 Then
                command.Parameters.AddWithValue("@telefono", DBNull.Value)
            Else
                command.Parameters.AddWithValue("@telefono", oAfiliado.telefono)
            End If

            command.Parameters.AddWithValue("@mail", oAfiliado.mailAfiliado)
            command.Parameters.AddWithValue("@activo", oAfiliado.activo)
            command.Parameters.AddWithValue("@empresa_convenio", oAfiliado.empresaConvenio)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            MsgBox("La seleccion de la fila en la grilla perdió su foco. Por favor volve a seleccionar el afiliado que estas modificando")
            Exit Sub
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub

    Public Sub deleteAfiliado(ByVal oAfiliado As ConsultaDeAfiliado)
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Try

            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()

            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_eliminar_Afiliado"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@numerodocumentoE", oAfiliado.numeroDoc.ToString)
            command.Parameters.AddWithValue("@tipoDocumentoE", oAfiliado.idTipoDoc.ToString)
            command.Parameters.AddWithValue("@activo", 0)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la eliminación del Afiliado")
            Exit Sub
        Finally
            connection.Close()
            connection.Dispose()
        End Try

    End Sub

    Public Sub UpdateAfiliado(oAfiliado As ConsultaDeAfiliado, habilitado As Integer)
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim consulta As String = ""
        Try

            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            consulta = "UPDATE Afiliados SET activo = @activo where numero_doc = @numeroDocumentoE and id_tipo_doc = @tipoDocumentoE"
            command = New SqlClient.SqlCommand(consulta, connection)
            command.Parameters.AddWithValue("@numerodocumentoE", oAfiliado.numeroDoc.ToString)
            command.Parameters.AddWithValue("@tipoDocumentoE", oAfiliado.idTipoDoc.ToString)
            command.Parameters.AddWithValue("@activo", habilitado)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la habilitación del Afiliado")
            Exit Sub
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub

    'Busca un afiliado con el tipo y nro de Documento pasado por parámetro, que se encuentre activo
    Public Function buscarAfiliado(ByVal tipoDocumento As Integer, nroDocumento As Integer) As DataTable
        Dim tabla As New DataTable
        Dim consulta As String = ""
        consulta = "select A.id_tipo_afil as tipoAfiliado, P.nombre + ' ' + P.apellido as nombreCompleto from "
        consulta += "Afiliados A inner join Personas p on A.id_tipo_doc = P.id_tipo_doc "
        consulta += "and A.numero_doc = P.numero_doc "
        consulta += "where A.id_tipo_doc = " & tipoDocumento & " and A.numero_doc = " & nroDocumento & " and A.activo= 1"
        tabla = BDHelper.ConsultaSQL(consulta)
        Return tabla
    End Function

    Public Function calcularEdad(ByVal oAfiliado As ConsultaDeAfiliado) As Integer
        Return DateDiff(DateInterval.Year, oAfiliado.fechaNacimiento, Now)
    End Function

    Public Function validarExistenciaAfiliado(ByVal tipoDoc As Integer, ByVal nroDoc As Integer) As Integer
        Dim consulta As String = ""
        consulta = "select * from Afiliados A inner join Personas P on A.id_tipo_doc = P.id_tipo_doc "
        consulta += "and A.numero_doc = P.id_tipo_doc where A.id_tipo_doc = @tipoDoc and A.numero_doc = @nroDoc"

        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As SqlClient.SqlCommand
        Dim dt As New Data.DataTable

        conexion.ConnectionString = BDHelper.string_conexion
        conexion.Open()
        cmd = New SqlClient.SqlCommand(consulta, conexion)
        cmd.Parameters.AddWithValue("@tipoDoc", tipoDoc)
        cmd.Parameters.AddWithValue("@nroDoc", nroDoc)
        dt.Load(cmd.ExecuteReader())
        conexion.Close()
        Return dt.Rows.Count()
    End Function
End Class
