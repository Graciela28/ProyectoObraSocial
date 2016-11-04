Public Class PersonaDao

    Public Function validarExistencia(ByVal tipoDoc As Integer, ByVal nroDoc As Integer) As Integer
        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim consulta As String = ""
        Dim dt As New Data.DataTable
        conexion.ConnectionString = BDHelper.string_conexion
        conexion.Open()
        consulta = "select * from personas where id_tipo_doc = " & tipoDoc
        consulta &= " and numero_doc = " & nroDoc
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        dt.Load(cmd.ExecuteReader())
        conexion.Close()
        Return dt.Rows.Count()
    End Function
End Class
