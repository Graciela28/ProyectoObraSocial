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

End Class
