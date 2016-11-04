Public Class ConsultaDeAfiliadoDao

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
            listaAfiliados.Add(mapToConsultaDeAfiliado(row))
        Next
        Return listaAfiliados
    End Function

    Private Function mapToConsultaDeAfiliado(row As DataRow) As ConsultaDeAfiliado

        Dim oConsultaDeAfiliado As New ConsultaDeAfiliado
        With oConsultaDeAfiliado
            .idTipoDoc = Convert.ToInt16(row.Item("id_tipo_doc").ToString)
            .nombreTipoDocumento = row.Item("Tipo_documento").ToString
            .numeroDoc = Convert.ToInt32(row.Item("numero_doc").ToString)
            .idTipoAfil = Convert.ToInt16(row.Item("id_tipo_afil").ToString)
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
        Return oConsultaDeAfiliado
    End Function

End Class
