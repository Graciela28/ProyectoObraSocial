Public Class ProfesionalDao

    'Devuelve un listado de todos los profesionales que se encuentran activos e inactivos
    Public Function getAll() As List(Of ConsultaDeProfesional)
        Dim listadoProfesionales As New List(Of ConsultaDeProfesional)
        Dim strSQL = "select P.id_tipo_doc, TD.nombre as Tipo_documento, P.numero_doc, PRO.matricula, " & _
            "P.nombre, P.apellido, P.fecha_nacimiento, P.telefono, P.mail, " & _
            "D.calle, D.numero, B.nombre as Barrio, L.nombre as Localidad, PR.nombre as Provincia " & _
            "from Profesionales PRO inner join Personas P on PRO.id_tipo_doc = P.id_tipo_doc and " & _
            "PRO.numero_doc = P.numero_doc inner join TiposDocumento TD on P.id_tipo_doc = TD.id " & _
            "inner join Domicilios D on P.direccion = D.id_domicilio inner join Barrios B on " & _
            "D.id_barrio = B.id_barrio inner join Localidades L on B.id_localidad = L.id inner join " & _
            "Provincias PR on L.id_provincia = PR.id"

        For Each row As DataRow In BDHelper.ConsultaSQL("strSQL").Rows
            listadoProfesionales.Add(map(row))
        Next
        Return listadoProfesionales
    End Function

    'Devuelve un listado de Profesionales según el estado que se pasa por parámetro 
    Public Function getByFilters(ByVal estado As Integer, ByVal tipoDoc As Integer, ByVal nroDoc As Integer) As List(Of ConsultaDeProfesional)

        Dim listadoProfesionales As New List(Of ConsultaDeProfesional)
        Dim strSQL = "select P.id_tipo_doc, TD.nombre as Tipo_documento, P.numero_doc, PRO.matricula, " & _
            "P.nombre, P.apellido, P.fecha_nacimiento, P.telefono, P.mail, " & _
            "D.calle, D.numero, B.nombre as Barrio, L.nombre as Localidad, PR.nombre as Provincia " & _
            "from Profesionales PRO inner join Personas P on PRO.id_tipo_doc = P.id_tipo_doc and " & _
            "PRO.numero_doc = P.numero_doc inner join TiposDocumento TD on P.id_tipo_doc = TD.id " & _
            "inner join Domicilios D on P.direccion = D.id_domicilio inner join Barrios B on " & _
            "D.id_barrio = B.id_barrio inner join Localidades L on B.id_localidad = L.id inner join " & _
            "Provincias PR on L.id_provincia = PR.id"
        If estado <> -1 Then strSQL += " and PRO.activo = " & estado
        If tipoDoc <> -1 Then strSQL += " and P.id_tipo_doc = " & tipoDoc
        If nroDoc <> -1 Then strSQL += " and P.numero_doc = " & nroDoc

        For Each row As DataRow In BDHelper.ConsultaSQL(strSQL).Rows
            listadoProfesionales.Add(map(row))
        Next
        Return listadoProfesionales
    End Function

    Private Function map(row As DataRow) As ConsultaDeProfesional
        Dim oProfesional As New ConsultaDeProfesional
        With oProfesional
            .idTipoDoc = Convert.ToInt32(row.Item("id_tipo_doc").ToString)
            .nombreTipoDocumento = row.Item("Tipo_documento").ToString
            .numeroDoc = Convert.ToInt32(row.Item("numero_doc").ToString)
            .matricula = Convert.ToInt32(row.Item("matricula").ToString)
            .nombreProfesional = row.Item("nombre").ToString
            .apellidoProfesional = row.Item("apellido").ToString
            .fechaNacimiento = Convert.ToDateTime(row.Item("fecha_nacimiento").ToString)
            If IsDBNull(row.Item("telefono")) Then
                .telefono = 0
            Else
                .telefono = Convert.ToInt32(row.Item("telefono").ToString)
            End If

            .mailProfesional = row.Item("mail").ToString
            .calle = row.Item("calle").ToString
            .numero = row.Item("numero").ToString
            .nombreBarrio = row.Item("Barrio").ToString
            .nombreLocalidad = row.Item("Localidad").ToString
            .nombreProvincia = row.Item("Provincia").ToString
        End With
        Return oProfesional
    End Function

    Public Function addProfesional(ByVal oProfesional As ConsultaDeProfesional) As Integer
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim status As Integer = 0

        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_Insertar_Profesional"
            command.Connection = connection
            Dim oDomicilioDao As New DomicilioDao
            command.Parameters.AddWithValue("@matricula", oProfesional.matricula.ToString)
            command.Parameters.AddWithValue("@tipoDocumento", oProfesional.idTipoDoc.ToString)
            command.Parameters.AddWithValue("@numeroDocumento", oProfesional.numeroDoc.ToString)
            command.Parameters.AddWithValue("@nombre", oProfesional.nombreProfesional)
            command.Parameters.AddWithValue("@apellido", oProfesional.apellidoProfesional)
            command.Parameters.AddWithValue("@fechaNacimiento", oProfesional.fechaNacimiento.ToString)
            command.Parameters.AddWithValue("@codDomicilio", oDomicilioDao.generarCodigoDomicilio())
            command.Parameters.AddWithValue("@calle", oProfesional.calle)
            command.Parameters.AddWithValue("@numero", oProfesional.numero.ToString)
            command.Parameters.AddWithValue("@barrio", oProfesional.codBarrio.ToString)

            If (oProfesional.telefono = 0) Then
                command.Parameters.AddWithValue("@telefono", DBNull.Value)
            Else
                command.Parameters.AddWithValue("@telefono", oProfesional.telefono.ToString)
            End If
            command.Parameters.AddWithValue("@mail", oProfesional.mailProfesional)
            status = command.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la inserción de un Profesional")
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try
        Return status
    End Function

    'Recibe el tipo y el nro de documento a actualizar 
    Public Sub UpdateProfesional(ByVal documento As Integer, ByVal tipo_documento As Integer, ByVal cod_domicilio As Integer, ByVal oProfesional As ConsultaDeProfesional)
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_modificar_profesional"
            command.Connection = connection

            command.Parameters.AddWithValue("@numeroDocumentoA", documento)
            command.Parameters.AddWithValue("@tipoDocumentoA", tipo_documento)
            command.Parameters.AddWithValue("@matricula", oProfesional.matricula.ToString)
            command.Parameters.AddWithValue("@tipoDocumento", oProfesional.idTipoDoc.ToString)
            command.Parameters.AddWithValue("@numeroDocumento", oProfesional.numeroDoc.ToString)
            command.Parameters.AddWithValue("@nombre", oProfesional.nombreProfesional)
            command.Parameters.AddWithValue("@apellido", oProfesional.apellidoProfesional)
            command.Parameters.AddWithValue("@fechaNacimiento", oProfesional.fechaNacimiento.ToString)
            command.Parameters.AddWithValue("@calle", oProfesional.calle)
            command.Parameters.AddWithValue("@numero", oProfesional.numero.ToString)
            command.Parameters.AddWithValue("@barrio", oProfesional.codBarrio.ToString)
            command.Parameters.AddWithValue("@telefono", oProfesional.telefono.ToString)
            command.Parameters.AddWithValue("@mail", oProfesional.mailProfesional)

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la modificación del Profesional")
            Exit Sub
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub

    Public Sub deleteProfesional(ByVal oProfesional As ConsultaDeProfesional)
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_eliminar_profesional"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@numerodocumentoE", oProfesional.numeroDoc.ToString)
            command.Parameters.AddWithValue("@tipoDocumentoE", oProfesional.idTipoDoc.ToString)
            command.Parameters.AddWithValue("@activo", 0)
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la eliminación del Profesional")
            Exit Sub
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub

    Public Function calcularEdad(ByVal oProfesional As ConsultaDeProfesional) As Integer
        Return DateDiff(DateInterval.Year, oProfesional.fechaNacimiento, Now)
    End Function

    Public Function validarExistenciaProfesional(ByVal tipoDoc As Integer, ByVal nroDoc As Integer) As Integer
        Dim consulta As String = ""
        consulta = "select * from Profesionales PR inner join Personas P on A.id_tipo_doc = P.id_tipo_doc "
        consulta += "and PR.numero_doc = P.id_tipo_doc where PR.id_tipo_doc = @tipoDoc and A.numero_doc = @nroDoc"

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

    Public Function validarExistenciaMatricula(ByVal matricula As Integer) As Integer
        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim consulta As String = ""
        Dim dt As New Data.DataTable
        conexion.ConnectionString = BDHelper.string_conexion
        conexion.Open()
        consulta = "select * from profesionales where matricula = " & matricula
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        dt.Load(cmd.ExecuteReader())
        conexion.Close()
        Return dt.Rows.Count()
    End Function
End Class
