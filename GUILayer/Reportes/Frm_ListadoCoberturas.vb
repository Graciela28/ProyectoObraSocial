Imports Microsoft.Reporting.WinForms
Public Class Frm_ListadoCoberturas

    Private Sub Frm_ListadoCoberturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As String = ""
        Dim tabla As DataTable

        consulta = "select T3.denominacion as n_centro, T2.nombre as tipo_afiliado, "
        consulta += "T6.nombre as n_especialidad, T5.nombre as n_practica, "
        consulta += "T1.descripcion, T1.precio_practica, T1.porcentaje_cobertura "
        consulta += "FROM Coberturas T1 inner join TiposAfiliado T2 on "
        consulta += "T1.id_tipo_afiliado = T2.id inner join CentrosMedicos T3 "
        consulta += "on T1.id_centro = T3.id_centro inner join "
        consulta += "PracticasxEspecialidad T4 on T1.id_practica = T4.id_practica "
        consulta += "and T1.id_especialidad = T4.id_especialidad inner join "
        consulta += "Especialidades T6 on T4.id_especialidad = T6.id inner join "
        consulta += "Practicas T5 on T4.id_practica = T5.id  "
        consulta += "order by T3.denominacion  "

        Me.ReportViewerCoberturas.RefreshReport()
        tabla = BDHelper.ConsultaSQL(consulta)
        Me.ReportViewerCoberturas.LocalReport.DataSources.Clear()
        Me.ReportViewerCoberturas.LocalReport.DataSources.Add(New ReportDataSource("DataSetCobertura", tabla))
        Me.ReportViewerCoberturas.RefreshReport()

    End Sub
End Class