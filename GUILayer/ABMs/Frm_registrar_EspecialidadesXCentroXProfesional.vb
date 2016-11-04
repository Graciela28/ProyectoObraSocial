Public Class frm_registrar_EspecialidadesXCentroXProfesional

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        cbo_centro.SelectedIndex = -1
        cbo_especialidad.SelectedIndex = -1
        cbo_profesional.SelectedIndex = -1
    End Sub

    Private Sub frm_registrar_EspecialidadesXCentroXProfesional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaCombo(cbo_centro, BDHelper.ConsultaSQL("SELECT * FROM CentrosMedicos"), "id_centro", "denominacion")
        cargaCombo(cbo_especialidad, BDHelper.ConsultaSQL("SELECT * FROM Especialidades"), "id", "nombre")
        cargaCombo(cbo_profesional, BDHelper.ConsultaSQL("SELECT * FROM Profesionales PR JOIN Personas PE ON PE.id_tipo_doc = PR.id_tipo_doc AND PE.numero_doc = PR.numero_doc"), "matricula", "apellido")
    End Sub

    Private Sub cargaCombo(ByRef combo As ComboBox, ByVal datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
    End Sub

    Private Sub cmd_Grabar_Click(sender As Object, e As EventArgs) Handles cmd_Grabar.Click
        Dim sql = "INSERT INTO ProfesionalesxCentroxEspecialidad(id_centro, id_especialidad, matricula, fecha_alta) VALUES (" + cbo_centro.SelectedValue.ToString + ", " + cbo_especialidad.SelectedValue.ToString + ", " + cbo_profesional.SelectedValue.ToString + ", GETDATE())"
        'BDHelper.EjecutarSQL(sql)
        cargarGrilla()
    End Sub

    Private Sub cargarGrilla()
        dgv_grilla.Rows.Clear()
        For Each row As DataRow In BDHelper.ConsultaSQL("SELECT P.*, CM.*,  FROM ProfesionalesxCentroxEspecialidad PCE JOIN Pofesionales P ON PCE.matricula = P.matricula JOIN CentrosMedicos CM ON CM.id_centro = PCE.id_centro JOIN Especialidades E ON E.id = PCE.id_especialidad").Rows
            'dgv_grilla.Rows.Add(row.Item("denominacion"))
        Next
    End Sub
End Class