Public Class ProfesionalesxCentroxEspecialidadDao

    Public Function getCentrosMedicos() As DataTable
      
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim consulta As String = ""
        Try

            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            consulta = "select distinct A.id_centro, B.denominacion "
            consulta += "from ProfesionalesxCentroxEspecialidad A inner join CentrosMedicos B "
            consulta += "on A.id_centro = B.id_centro"
            command = New SqlClient.SqlCommand(consulta, connection)
            tabla.Load(command.ExecuteReader())

        Catch ex As Exception
            Throw ex
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try
        Return tabla
    End Function

    Public Function getEspecialidadesConFiltro(ByVal idCentro As Integer) As DataTable

        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim consulta As String = ""

        Try

            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            consulta = "select distinct A.id_especialidad, B.nombre "
            consulta += "from ProfesionalesxCentroxEspecialidad A inner join Especialidades B "
            consulta += "on A.id_especialidad = B.id"
            consulta += " where A.id_centro = " & idCentro
            command = New SqlClient.SqlCommand(consulta, connection)
            tabla.Load(command.ExecuteReader())
        Catch ex As Exception
            Throw ex
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try
        Return tabla
    End Function

    Public Function getProfesionalesConFiltro(ByVal idCentro As Integer, ByVal idEspecialidad As Integer) As DataTable
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim consulta As String = ""

        Try

            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            consulta = "select A.matricula, P.nombre + ' ' + P.apellido as nombreCompleto, A.fecha_alta "
            consulta += "from ProfesionalesxCentroxEspecialidad A "
            consulta += "inner join Profesionales B on  A.matricula = B.matricula "
            consulta += "inner join Personas P on B.id_tipo_doc = P.id_tipo_doc and B.numero_doc = P.numero_doc "
            consulta += " where A.id_centro = " & idCentro & " and "
            consulta += "A.id_especialidad = " & idEspecialidad

            command = New SqlClient.SqlCommand(consulta, connection)
            tabla.Load(command.ExecuteReader())
        Catch ex As Exception
            Throw ex
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try
        Return tabla
    End Function

    Public Function buscarProfesional(ByVal idCentro As Integer, ByVal idEspecialidad As Integer, ByVal matricula As Integer) As DataTable
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim tabla As New DataTable
        Dim consulta As String = ""

        Try

            connection.ConnectionString = BDHelper.string_conexion
            connection.Open()
            consulta = "select A.matricula, P.nombre + ' ' + P.apellido as nombreCompleto, A.fecha_alta "
            consulta += "from ProfesionalesxCentroxEspecialidad A "
            consulta += "inner join Profesionales B on  A.matricula = B.matricula "
            consulta += "inner join Personas P on B.id_tipo_doc = P.id_tipo_doc and B.numero_doc = P.numero_doc "
            consulta += " where A.id_centro = " & idCentro & " and "
            consulta += "A.id_especialidad = " & idEspecialidad & " and "
            consulta += "A.matricula = " & matricula

            command = New SqlClient.SqlCommand(consulta, connection)
            tabla.Load(command.ExecuteReader())
        Catch ex As Exception
            Throw ex
            Exit Function
        Finally
            connection.Close()
            connection.Dispose()
        End Try
        Return tabla
    End Function
End Class
