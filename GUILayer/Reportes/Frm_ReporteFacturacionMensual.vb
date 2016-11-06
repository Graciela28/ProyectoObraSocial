Imports Microsoft.Reporting.WinForms

Public Class Frm_ReporteFacturacionMensual

    Private Sub Frm_ReporteFacturacionMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.LocalReport.DataSources.Clear()
    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        If (dtp_desde.Value > dtp_hasta.Value) Then
            MsgBox("Periodo incorrecto", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim consulta As String = ""
        Dim tabla As DataTable
        consulta = "select T7.denominacion as n_centro, "
        consulta += "T8.apellido + ', ' + T8.nombre as n_profesional, "
        consulta += "T5.nombre as n_especialidad, "
        consulta += "T9.apellido + ', ' + T9.nombre as n_afiliado, "
        consulta += "SUM(T1.total)as total "
        consulta += "FROM Atenciones T1 inner join Afiliados T2 on "
        consulta += "        T1.tipo_doc_Afil = T2.id_tipo_doc And "
        consulta += "        T1.nro_doc_Afil = T2.numero_doc "
        consulta += "inner join Personas T9 on "
        consulta += "        T2.id_tipo_doc = T9.id_tipo_doc And "
        consulta += "        T2.numero_doc = T9.numero_doc "
        consulta += "inner join ProfesionalesxCentroxEspecialidad T3 "
        consulta += "on T1.id_centro = T3.id_centro and "
        consulta += "T1.matricula = T3.matricula and "
        consulta += "T1.id_especialidad = T3.id_especialidad and "
        consulta += "T1.fecha_alta = T3.fecha_alta inner join Especialidades T5 "
        consulta += "on T3.id_especialidad = T5.id inner join ProfesionalesxCentro T4 "
        consulta += "on T3.id_centro = T4.id_centro and "
        consulta += "T3.matricula = T4.matricula inner join Profesionales T6 "
        consulta += "on T4.matricula = T6.matricula inner join Personas T8 "
        consulta += "on T6.id_tipo_doc = T8.id_tipo_doc "
        consulta += "and T6.numero_doc = T8.numero_doc inner join CentrosMedicos T7 "
        consulta += "on T4.id_centro = T7.id_centro "
        consulta += "where T1.fecha_atencion BETWEEN CONVERT(datetime, '" + dtp_desde.Value.ToString("dd/MM/yyyy") + "', 103) AND CONVERT(datetime, '" + dtp_hasta.Value.ToString("dd/MM/yyyy") + "',103) "
        consulta += "group by T7.denominacion, T8.apellido, T8.nombre, T5.nombre, T9.apellido, T9.nombre "

        Me.ReportViewer1.RefreshReport()
        tabla = BDHelper.ConsultaSQL(consulta)
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSetFacturacionMensual", tabla))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class