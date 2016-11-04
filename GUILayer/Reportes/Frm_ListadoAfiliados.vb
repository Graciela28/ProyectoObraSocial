Imports Microsoft.Reporting.WinForms
Public Class Frm_ListadoAfiliados

    Private Sub Frm_ListadoAfiliados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tabla As DataTable
        Dim consulta As String = ""
        consulta = "select TD.nombre, A.numero_doc, P.apellido + ', ' + P.nombre as NombreAfiliado, DATEDIFF(YEAR, P.fecha_nacimiento, GETDATE()) as Edad, P.telefono "
        consulta += "from Afiliados A inner join Personas P on  A.id_tipo_doc = P.id_tipo_doc and A.numero_doc = P.numero_doc "
        consulta += "inner join TiposDocumento TD on A.id_tipo_doc = TD.id inner join TiposAfiliado TA on A.id_tipo_afil = TA.id "
        tabla = BDHelper.ConsultaSQL(consulta)
        Me.ReportViewerAfiliados.LocalReport.DataSources.Clear()
        Me.ReportViewerAfiliados.LocalReport.DataSources.Add(New ReportDataSource("DataSetAfiliado", tabla))
        Me.ReportViewerAfiliados.RefreshReport()
    End Sub
End Class