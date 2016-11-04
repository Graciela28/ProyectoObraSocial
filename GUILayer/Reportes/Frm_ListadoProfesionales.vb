Imports Microsoft.Reporting.WinForms
Public Class Frm_ListadoProfesionales

    Private Sub Frm_ListadoProfesionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As String = ""
        Dim tabla As DataTable
        consulta = "select CM.denominacion, PER.apellido + ', ' + PER.nombre As Nombre, PC.matricula from "
        consulta += "ProfesionalesxCentro PC inner join Profesionales PR on PC.matricula = PR.matricula inner join CentrosMedicos CM "
        consulta += "on PC.id_centro = CM.id_centro inner join Personas PER on PR.id_tipo_doc = PER.id_tipo_doc and PR.numero_doc = PER.numero_doc "
        Me.ReportViewerProfesionales.RefreshReport()
        tabla = BDHelper.ConsultaSQL(consulta)
        Me.ReportViewerProfesionales.LocalReport.DataSources.Clear()
        Me.ReportViewerProfesionales.LocalReport.DataSources.Add(New ReportDataSource("DataSetProfesionales", tabla))
        Me.ReportViewerProfesionales.RefreshReport()
    End Sub
End Class