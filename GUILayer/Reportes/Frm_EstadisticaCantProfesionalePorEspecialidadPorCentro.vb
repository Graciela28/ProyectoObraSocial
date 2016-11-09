Imports Microsoft.Reporting.WinForms

Public Class Frm_EstadisticaCantProfesionalePorEspecialidadPorCentro

    Private Sub Frm_EstadisticaCantProfesionalePorEspecialidadPorCentro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaCombo(cbo_centro, BDHelper.ConsultaSQL("SELECT * FROM CentrosMedicos"), "id_centro", "denominacion")
        Me.ReportViewer1.LocalReport.DataSources.Clear()
    End Sub

    Private Sub cargaCombo(ByRef combo As ComboBox, ByVal datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        If (dtp_desde.Value > dtp_hasta.Value) Then
            MsgBox("La fecha desde debe ser previa a la fecha hasta", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If (cbo_centro.SelectedIndex = -1) Then
            MsgBox("Debe elegir un centro médico", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim table As DataTable
        Dim consulta = "SELECT E.nombre AS especialidad, COUNT(PCE.matricula) AS cant_profesionales FROM ProfesionalesxCentroxEspecialidad PCE JOIN Especialidades E ON PCE.id_especialidad = E.id WHERE id_centro = " + cbo_centro.SelectedValue.ToString + " AND fecha_alta between CONVERT(DATETIME, '" + dtp_desde.Value.ToString("dd/MM/yyyy") + "', 103) AND CONVERT(DATETIME, '" + dtp_hasta.Value.ToString("dd/MM/yyyy") + "', 103) GROUP BY E.nombre"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        table = BDHelper.ConsultaSQL(consulta)
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", table))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class