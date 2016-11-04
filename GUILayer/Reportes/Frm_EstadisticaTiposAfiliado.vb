Imports Microsoft.Reporting.WinForms

Public Class Frm_EstadisticaTiposAfiliado
    Private Sub Frm_EstadisticaTiposAfiliado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As DataTable
        Dim consulta = "select ta.nombre as Tipo_Afiliado, (COUNT(a.id_tipo_afil)*100/(select count(*) from Afiliados)) as Porcentaje "
        consulta += "from Afiliados a, TiposAfiliado ta "
        consulta += "where a.id_tipo_afil = ta.id "
        consulta += "group by ta.nombre"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        tabla = BDHelper.ConsultaSQL(consulta)
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSetEstadistica2", tabla))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class