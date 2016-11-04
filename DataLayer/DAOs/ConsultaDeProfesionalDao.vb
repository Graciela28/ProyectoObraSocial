Public Class ConsultaDeProfesionalDao

    'Devuelve un listado de todos los Profesionales que se encuentran activos
    Public Function getAllProfesionales() As List(Of ConsultaDeProfesional)
        Dim listaProfesionales As New List(Of ConsultaDeProfesional)
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim tabla As New DataTable

        Try
            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_Listar_Profesionales"
            command.Parameters.AddWithValue("@activo", 1)
            command.Parameters.AddWithValue("@tipo_doc", DBNull.Value)
            command.Parameters.AddWithValue("@num_doc", DBNull.Value)
            tabla.Load(command.ExecuteReader())
        Catch ex As Exception
            Throw ex
            MsgBox("Hubo un error en la consulta de Profesionales")
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try

        For Each row As DataRow In tabla.Rows
            listaProfesionales.Add(mapToConsultaDeProfesional(row))
        Next
        Return listaProfesionales
    End Function

    Private Function mapToConsultaDeProfesional(row As DataRow) As ConsultaDeProfesional

        Dim oConsultaDeProfesional As New ConsultaDeProfesional
        With oConsultaDeProfesional
            .idTipoDoc = Convert.ToInt16(row.Item("id_tipo_doc").ToString)
            .nombreTipoDocumento = row.Item("Tipo_documento").ToString
            .numeroDoc = Convert.ToInt32(row.Item("numero_doc").ToString)
            .matricula = Convert.ToInt64(row.Item("matricula").ToString)
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

            If IsDBNull(row.Item("numero")) Then
                .numero = 0
            Else
                .numero = Convert.ToInt32(row.Item("numero").ToString)
            End If

            .codBarrio = Convert.ToInt32(row.Item("id_barrio").ToString)
            .nombreBarrio = row.Item("Barrio").ToString
            .idLocalidad = Convert.ToInt16(row.Item("id_localidad").ToString)
            .nombreLocalidad = row.Item("Localidad").ToString
            .idProvincia = Convert.ToInt16(row.Item("id_provincia").ToString)
            .nombreProvincia = row.Item("Provincia").ToString
            .activo = Convert.ToInt32(row.Item("activo"))
        End With
        Return oConsultaDeProfesional
    End Function
End Class
