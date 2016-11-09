Imports System.Data.SqlClient
Public Class BDHelper

    Public Shared string_conexion As String = "Data Source=VANIA-PC\SQLEXPRESS;Initial Catalog=BD_OBRA_SOCIAL;Integrated Security=True"

    Public Shared Function EjecutarSQL(ByVal strSql As String) As Integer
        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand

        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Shared Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            tabla.Load(cmd.ExecuteReader())
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Shared Function GetTipos(ByVal nombreTabla As String) As DataTable
        Dim strSQL As String = "select id, nombre from " & nombreTabla
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Public Shared Function GetPersonas(ByVal nombreTabla As String) As DataTable
        Dim strSQL As String = "select p.numero_doc, p.apellido + ',' + p.nombre AS nombre_completo from Personas p inner join " & nombreTabla & " pers on p.id_tipo_doc = pers.id_tipo_doc and p.numero_doc = pers.numero_doc where pers.activo = 1"
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Shared Function eliminar_ExPxC(listaEliminar As List(Of EspecialidadXProfesionalXCentro)) As Boolean
        Dim status As Boolean = False
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim transaction As SqlClient.SqlTransaction
        Dim tabla As New DataTable

        connection.ConnectionString = string_conexion
        connection.Open()
        command.Connection = connection
        transaction = connection.BeginTransaction
        command.Transaction = transaction
        Try
            For Each e As EspecialidadXProfesionalXCentro In listaEliminar
                Dim consulta As String = "DELETE FROM ProfesionalesxCentroxEspecialidad WHERE id_centro = " + e.idCentro.ToString + " AND id_especialidad = " + e.idEspecialidad.ToString + " AND matricula = " + e.matriculaProfesional.ToString + " and fecha_alta = CONVERT(DATETIME, '" + e.fechaAltaProfesional.ToString("dd/MM/yyyy HH:mm:ss") + "', 103)"
                command.CommandText = consulta
                command.ExecuteNonQuery()
            Next
            transaction.Commit()
            status = True
        Catch ex As Exception
            transaction.Rollback()
            Throw ex
        Finally
            connection.Close()
            connection.Dispose()
        End Try
        Return status
    End Function


End Class
