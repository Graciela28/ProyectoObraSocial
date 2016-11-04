Public Class AtencionDao

    Public Function obtenerFechaActual() As String
        Dim fechaActual As String

        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim consulta As String = ""
        Try

            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            consulta = "select getdate() as fecha"
            command = New SqlClient.SqlCommand(consulta, connection)
            tabla.Load(command.ExecuteReader())

        Catch ex As Exception
            Throw ex
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try
        fechaActual = tabla.Rows(0)(0).ToString()
        Return fechaActual
    End Function

    Public Function registrarAtencion(ByVal oAtencion As Atencion, ByVal listaDetalles As List(Of DetalleAtencion)) As Boolean

        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As SqlClient.SqlCommand = Nothing
        Dim trans As SqlClient.SqlTransaction = Nothing
        Dim status As Boolean
        Dim consulta As String = ""

        Try
            conexion.ConnectionString = BDHelper.string_conexion
            conexion.Open()
            trans = conexion.BeginTransaction()

            consulta = "INSERT into Atenciones values (@fecha, @tipoDoc, @nroDoc, @idCentro, @matricula, @idEspecialidad, @fechaAlta, @estado, @total_sc, @total_cc, @total)"
            cmd = New SqlClient.SqlCommand(consulta, conexion, trans)
            oAtencion.fechaAtencion = Now
            cmd.Parameters.AddWithValue("@fecha", oAtencion.fechaAtencion.ToString())
            cmd.Parameters.AddWithValue("@tipoDoc", oAtencion.tipoDocAfiliado.ToString())
            cmd.Parameters.AddWithValue("@nroDoc", oAtencion.nroDocAfiliado.ToString())
            cmd.Parameters.AddWithValue("@idCentro", oAtencion.idCentro.ToString())
            cmd.Parameters.AddWithValue("@matricula", oAtencion.matriculaProfesional.ToString())
            cmd.Parameters.AddWithValue("@idEspecialidad", oAtencion.idEspecialidad.ToString())
            cmd.Parameters.AddWithValue("@fechaAlta", oAtencion.fechaAltaProfesional.ToString("dd/MM/yyyy"))
            cmd.Parameters.AddWithValue("@estado", oAtencion.idEstado)
            cmd.Parameters.AddWithValue("@total_sc", oAtencion.totalSinCobertura)
            cmd.Parameters.AddWithValue("@total_cc", oAtencion.totalConCobertura)
            cmd.Parameters.AddWithValue("@total", oAtencion.total)
            cmd.ExecuteNonQuery()

            For Each oDetalleAtencion As DetalleAtencion In listaDetalles
                consulta = "INSERT into DetallesAtencion values ( "
                consulta += "@fecha, @tipoDoc, @nroDoc, @idCentro, @matricula, "
                consulta += "@idEspecialidad, @fechaAlta, @idPractica, @precioSinCobertura, @cobertura, @precioConCobertura, @cantidad, @subtotal)"
                cmd = New SqlClient.SqlCommand(consulta, conexion, trans)
                cmd.Parameters.AddWithValue("@fecha", oAtencion.fechaAtencion.ToString())
                cmd.Parameters.AddWithValue("@tipoDoc", oAtencion.tipoDocAfiliado.ToString())
                cmd.Parameters.AddWithValue("@nroDoc", oAtencion.nroDocAfiliado.ToString())
                cmd.Parameters.AddWithValue("@idCentro", oAtencion.idCentro.ToString())
                cmd.Parameters.AddWithValue("@matricula", oAtencion.matriculaProfesional.ToString())
                cmd.Parameters.AddWithValue("@idEspecialidad", oAtencion.idEspecialidad.ToString())
                cmd.Parameters.AddWithValue("@fechaAlta", oAtencion.fechaAltaProfesional.ToString())
                cmd.Parameters.AddWithValue("@idPractica", oDetalleAtencion.idPractica.ToString())
                cmd.Parameters.AddWithValue("@precioSinCobertura", oDetalleAtencion.precioPracticaSinCobertura)
                cmd.Parameters.AddWithValue("@cobertura", oDetalleAtencion.cobertura)
                cmd.Parameters.AddWithValue("@precioConCobertura", oDetalleAtencion.precioPracticaConCobertura)
                cmd.Parameters.AddWithValue("@cantidad", oDetalleAtencion.cantidad)
                cmd.Parameters.AddWithValue("@subtotal", oDetalleAtencion.subtotal)
                cmd.ExecuteNonQuery()
            Next
            trans.Commit()
            status = True
        Catch sqlEx As SqlClient.SqlException
            trans.Rollback()
            status = False
            Throw sqlEx
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return status
    End Function

    Public Function ListarAtencionesConFiltro(Optional ByVal fechaInicio As DateTime = Nothing, Optional ByVal fechaFin As DateTime = Nothing, Optional ByVal tipoDoc As Integer = Nothing, Optional ByVal numDoc As Integer = Nothing) As List(Of Atencion)
        Dim listaAtenciones As New List(Of Atencion)
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim tabla As New DataTable

        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_Listar_Atenciones"

            If (fechaInicio.ToString("dd/MM/yyyy") = "01/01/0001") Then
                command.Parameters.AddWithValue("@fechaInicio", DBNull.Value)
            Else
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio)
            End If
            If (fechaFin.ToString("dd/MM/yyyy") = "01/01/0001") Then
                command.Parameters.AddWithValue("@fechaFin", DBNull.Value)
            Else
                command.Parameters.AddWithValue("@fechaFin", fechaFin)
            End If
            If (tipoDoc = 0) Then
                command.Parameters.AddWithValue("@tipo_doc", DBNull.Value)
            Else
                command.Parameters.AddWithValue("@tipo_doc", tipoDoc)
            End If
            If (numDoc = 0) Then
                command.Parameters.AddWithValue("@num_doc", DBNull.Value)
            Else
                command.Parameters.AddWithValue("@num_doc", numDoc)
            End If
            tabla.Load(command.ExecuteReader())
        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la consulta de Atenciones")
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try

        For Each row As DataRow In tabla.Rows
            listaAtenciones.Add(mapToAtencion(row))
        Next
        Return listaAtenciones
    End Function

    Private Function mapToAtencion(row As DataRow) As Atencion
        Dim oAtencion As New Atencion
        With oAtencion
            .fechaAtencion = Convert.ToDateTime(row.Item("fecha_atencion").ToString())
            .nombreAfiliado = row.Item("nombreAfiliado").ToString()
            .nombreTipoDocumento = row.Item("n_tipoDocumento").ToString()
            .idTipoAfil = Convert.ToInt32(row.Item("idTipoAfiliado").ToString())
            .tipoDocAfiliado = Convert.ToInt32(row.Item("tipo_doc_Afil").ToString())
            .nroDocAfiliado = Convert.ToInt32(row.Item("nro_doc_Afil").ToString())
            .nombreTipoAfiliado = row.Item("nombreTipoAfiliado").ToString()
            .idCentro = Convert.ToInt16(row.Item("id_centro").ToString())
            .nombreCentro = row.Item("denominacion").ToString()
            .nombreProfesional = row.Item("nombreProfesional").ToString()
            .matriculaProfesional = Convert.ToInt64(row.Item("matricula").ToString())
            .nombreEspecialidad = row.Item("nombreEspecialidad").ToString()
            .idEspecialidad = Convert.ToInt16(row.Item("id_especialidad").ToString())
            .fechaAltaProfesional = Convert.ToDateTime(row.Item("fecha_alta").ToString())
            .idEstado = Convert.ToInt16(row.Item("estado").ToString())
            .nombreEstado = row.Item("n_estado").ToString()
            .totalSinCobertura = Convert.ToDouble(row.Item("total_sc").ToString())
            .totalConCobertura = Convert.ToDouble(row.Item("total_cc").ToString())
            .total = Convert.ToDouble(row.Item("total").ToString())
        End With
        Return oAtencion
    End Function

    Public Function eliminarAtencion(ByVal oAtencion As Atencion) As Boolean

        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As SqlClient.SqlCommand = Nothing
        Dim trans As SqlClient.SqlTransaction = Nothing
        Dim status As Boolean
        Dim consulta As String = ""

        Try
            conexion.ConnectionString = BDHelper.string_conexion
            conexion.Open()
            trans = conexion.BeginTransaction()

            consulta = "UPDATE Atenciones set estado = 3 "
            consulta += "where fecha_atencion = @fecha and tipo_doc_Afil = @tipoDoc "
            consulta += "and nro_doc_Afil = @nroDoc and id_centro = @idCentro "
            consulta += "and matricula = @matricula and id_especialidad = @idEspecialidad "
            consulta += "and fecha_alta = @fechaAlta"
            cmd = New SqlClient.SqlCommand(consulta, conexion, trans)

            cmd.Parameters.AddWithValue("@fecha", oAtencion.fechaAtencion.ToString())
            cmd.Parameters.AddWithValue("@tipoDoc", oAtencion.tipoDocAfiliado.ToString())
            cmd.Parameters.AddWithValue("@nroDoc", oAtencion.nroDocAfiliado.ToString())
            cmd.Parameters.AddWithValue("@idCentro", oAtencion.idCentro.ToString())
            cmd.Parameters.AddWithValue("@matricula", oAtencion.matriculaProfesional.ToString())
            cmd.Parameters.AddWithValue("@idEspecialidad", oAtencion.idEspecialidad.ToString())
            cmd.Parameters.AddWithValue("@fechaAlta", oAtencion.fechaAltaProfesional.ToString("dd/MM/yyyy"))
            cmd.ExecuteNonQuery()

            trans.Commit()
            status = True
        Catch sqlEx As SqlClient.SqlException
            trans.Rollback()
            status = False
            Throw sqlEx
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return status
    End Function

    Public Function validarExistenciaAtencion(ByVal oAtencion As Atencion) As DataTable
        Dim listaAtenciones As New List(Of Atencion)
        Dim consulta As String = ""
        consulta = "select * from Atenciones "
        consulta += "where fecha_atencion = @fechaAtencion "
        consulta += "and tipo_doc_Afil = @tipoDoc and nro_doc_Afil = @nroDoc "
        consulta += "and id_centro = @idCentro and matricula = @matricula and id_especialidad = @idEspecialidad "
        consulta += "and fecha_alta = @fecha_alta"

        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As SqlClient.SqlCommand

        Dim dt As New Data.DataTable
        conexion.ConnectionString = BDHelper.string_conexion
        conexion.Open()

        cmd = New SqlClient.SqlCommand(consulta, conexion)
        cmd.Parameters.AddWithValue("@fechaAtencion", oAtencion.fechaAtencion.ToString("dd/MM/yyyy"))
        cmd.Parameters.AddWithValue("@tipoDoc", oAtencion.tipoDocAfiliado)
        cmd.Parameters.AddWithValue("@nroDoc", oAtencion.nroDocAfiliado)
        cmd.Parameters.AddWithValue("@idCentro", oAtencion.idCentro)
        cmd.Parameters.AddWithValue("@matricula", oAtencion.matriculaProfesional)
        cmd.Parameters.AddWithValue("@idEspecialidad", oAtencion.idEspecialidad)
        cmd.Parameters.AddWithValue("@fecha_alta", oAtencion.fechaAltaProfesional.ToString("dd/MM/yyyy"))
        dt.Load(cmd.ExecuteReader())
        conexion.Close()
        Return dt
    End Function

    Public Function getDetallesAtencionByFilters(ByVal oAtencion As Atencion) As List(Of DetalleAtencion)
        Dim listaDetalles As New List(Of DetalleAtencion)
        Dim consulta As String = ""
        consulta = "select D.*, P.nombre as nombrePractica from DetallesAtencion D inner join Practicas P on D.id_practica = P.id "
        consulta += " where fecha_atencion = @fechaAtencion "
        consulta += "and tipo_doc_Afil = @tipoDoc and nro_doc_Afil = @nroDoc "
        consulta += "and id_centro = @idCentro and matricula = @matricula and id_especialidad = @idEspecialidad "
        consulta += "and fecha_alta = @fecha_alta"

        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As SqlClient.SqlCommand

        Dim dt As New Data.DataTable
        conexion.ConnectionString = BDHelper.string_conexion
        conexion.Open()

        cmd = New SqlClient.SqlCommand(consulta, conexion)
        cmd.Parameters.AddWithValue("@fechaAtencion", oAtencion.fechaAtencion)
        cmd.Parameters.AddWithValue("@tipoDoc", oAtencion.tipoDocAfiliado)
        cmd.Parameters.AddWithValue("@nroDoc", oAtencion.nroDocAfiliado)
        cmd.Parameters.AddWithValue("@idCentro", oAtencion.idCentro)
        cmd.Parameters.AddWithValue("@matricula", oAtencion.matriculaProfesional)
        cmd.Parameters.AddWithValue("@idEspecialidad", oAtencion.idEspecialidad)
        cmd.Parameters.AddWithValue("@fecha_alta", oAtencion.fechaAltaProfesional)
        dt.Load(cmd.ExecuteReader())
        conexion.Close()

        For Each row As DataRow In dt.Rows
            listaDetalles.Add(mapToDetalleAtencion(row))
        Next
        Return listaDetalles
    End Function

    Private Function mapToDetalleAtencion(row As DataRow) As DetalleAtencion
        Dim oDetalleAtencion As New DetalleAtencion
        With oDetalleAtencion
            .fechaAtencion = Convert.ToDateTime(row.Item("fecha_atencion").ToString())
            .tipoDocAfiliado = Convert.ToInt32(row.Item("tipo_doc_Afil").ToString())
            .nroDocAfiliado = Convert.ToInt32(row.Item("nro_doc_Afil").ToString())
            .idCentro = Convert.ToInt16(row.Item("id_centro").ToString())
            .matriculaProfesional = Convert.ToInt64(row.Item("matricula").ToString())
            .idEspecialidad = Convert.ToInt16(row.Item("id_especialidad").ToString())
            .fechaAltaProfesional = Convert.ToDateTime(row.Item("fecha_alta").ToString())
            .idPractica = Convert.ToInt16(row.Item("id_practica").ToString())
            .nombrePractica = row.Item("nombrePractica").ToString()
            .precioPracticaSinCobertura = Convert.ToDouble(row.Item("precio_practica_sc").ToString())
            .cobertura = Convert.ToInt16(row.Item("cobertura").ToString())
            .precioPracticaConCobertura = Convert.ToDouble(row.Item("precio_practica_cc").ToString())
            .cantidad = Convert.ToInt16(row.Item("cantidad").ToString())
            .subtotal = Convert.ToDouble(row.Item("subtotal").ToString())
        End With
        Return oDetalleAtencion
    End Function
End Class
