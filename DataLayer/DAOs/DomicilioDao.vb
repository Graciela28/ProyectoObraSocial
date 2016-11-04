Public Class DomicilioDao
    Public Function generarCodigoDomicilio() As Integer
        Dim tabla As New Data.DataTable
        Dim cod_domicilio As Integer
        tabla = BDHelper.ConsultaSQL("select * from Domicilios")

        If tabla.Rows.Count > 0 Then
            tabla = BDHelper.ConsultaSQL("select max(id_domicilio) as codigoDomicilio from Domicilios")
            If tabla.Rows.Count > 0 Then
                cod_domicilio = CInt(tabla.Rows(0)("codigoDomicilio").ToString) + 1
            End If
        Else
            cod_domicilio = 1000
        End If
        Return cod_domicilio
    End Function

    Public Function actualizarDomicilio(ByVal oDomicilio As Domicilio) As Integer
        Return 1
    End Function
End Class
