Imports Microsoft.Reporting.WinForms

Public Class Frm_ReporteEstadisticoDePracticas

    Private Sub Frm_ReporteEstadisticoDePracticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        If (dtp_desde.Value > dtp_hasta.Value) Then
            MsgBox("Periodo incorrecto", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'ReportViewer1.LocalReport.SetParameters({New ReportParameter("pFechaDesde", dtp_desde.Value), New ReportParameter("pFechaHasta", dtp_hasta.Value)})
        Dim tabla As DataTable
        Dim consulta = "select T1.nombre as n_practica, COUNT(T2.id_practica) as ctd, (SELECT COUNT (T2.id_practica) * 100/ (SELECT COUNT(T3.id_practica) from DetallesAtencion T3)) as porcentaje FROM DetallesAtencion T2, Practicas T1 where T2.id_practica = T1.id AND fecha_alta BETWEEN CONVERT(datetime, '" + dtp_desde.Value.ToString("dd/MM/yyyy") + "', 103) AND CONVERT(datetime, '" + dtp_hasta.Value.ToString("dd/MM/yyyy") + "',103) GROUP BY T1.nombre"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        tabla = BDHelper.ConsultaSQL(consulta)
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSetEstadistica1", tabla))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class