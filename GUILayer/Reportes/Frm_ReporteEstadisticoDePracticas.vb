Imports Microsoft.Reporting.WinForms

Public Class Frm_ReporteEstadisticoDePracticas

    Private Sub Frm_ReporteEstadisticoDePracticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As DataTable
        Dim consulta = "select T1.nombre as n_practica, COUNT(T2.id_practica) as ctd, (SELECT COUNT (T2.id_practica) * 100/ (SELECT COUNT(T3.id_practica) from DetallesAtencion T3)) as porcentaje FROM DetallesAtencion T2, Practicas T1 where T2.id_practica = T1.id GROUP BY T1.nombre"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        tabla = BDHelper.ConsultaSQL(consulta)
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSetEstadistica1", tabla))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class