Public Class CoberturaDao
    'Busca la cobertura de una practica de un tipo de afiliado, especialidad y centro específico 
    Public Function buscarCobertura(ByVal tipoAfiliado As Integer, ByVal idPractica As Integer, ByVal idEspecialidad As Integer, ByVal idCentro As Integer) As List(Of Cobertura)

        Dim listaCoberturas As New List(Of Cobertura)
        Dim strSQL = "select * from Coberturas where id_tipo_afiliado = " & tipoAfiliado
        strSQL += " and id_practica = " & idPractica & " and id_especialidad = " & idEspecialidad
        strSQL += " and id_centro = " & idCentro

        For Each row As DataRow In BDHelper.ConsultaSQL(strSQL).Rows
            listaCoberturas.Add(map(row))
        Next
        Return listaCoberturas
    End Function

    Private Function map(row As DataRow) As Cobertura
        Dim oCobertura As New Cobertura
        With oCobertura
            .idTipoAfiliado = CInt(row.Item("id_tipo_afiliado").ToString)
            .idPractica = CInt(row.Item("id_practica").ToString)
            .idEspecialidad = CInt(row.Item("id_especialidad").ToString)
            .idCentro = CInt(row.Item("id_centro").ToString)
            .descripcion = row.Item("descripcion").ToString
            .precioPractica = Convert.ToDouble(row.Item("precio_practica").ToString)
            .porcentajeCobertura = CInt(row.Item("porcentaje_cobertura").ToString)
        End With
        Return oCobertura 
    End Function
End Class
