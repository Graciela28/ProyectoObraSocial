Public Class PracticasxEspecialidadDao
    Public Function getPracticasConFiltro(ByVal idEspecialidad As Integer) As DataTable
        Dim strSQL = "select A.id, A.nombre from Practicas A inner join "
        strSQL += "PracticasxEspecialidad B on A.id = B.id_practica "
        strSQL += "where B.id_especialidad = " & idEspecialidad

        'For Each row As DataRow In BDHelper.ConsultaSQL(strSQL).Rows
        '    listadoPracticas.Add(map(row))
        'Next
        'Return listadoPracticas
        Return BDHelper.ConsultaSQL(strSQL)
    End Function

    Private Function map(row As DataRow) As Practica
        Dim oPractica As New Practica
        With oPractica
            .idPractica = Convert.ToInt32(row.Item("id").ToString)
            .nombrePractica = row.Item("nombre").ToString
        End With
        Return oPractica
    End Function
End Class
