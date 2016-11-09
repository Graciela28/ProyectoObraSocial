Imports System.Data.SqlClient

Public Class frm_registrar_EspecialidadesXCentroXProfesional

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        cargar_todos_los_combos_por_defecto()
        limpiar_combos()
    End Sub

    Private Sub limpiar_combos()
        cbo_centro.SelectedIndex = -1
        cbo_especialidad.SelectedIndex = -1
        cbo_profesional.SelectedIndex = -1
    End Sub

    Private Sub frm_registrar_EspecialidadesXCentroXProfesional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_todos_los_combos_por_defecto()
        cargarGrilla()
    End Sub

    Private Sub cargar_todos_los_combos_por_defecto()
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
        If (cbo_centro.SelectedIndex = -1 Or cbo_especialidad.SelectedIndex = -1 Or cbo_profesional.SelectedIndex = -1) Then
            MsgBox("Debe seleccionar un dato", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            Dim consulta = "INSERT INTO ProfesionalesxCentro(matricula, id_centro) VALUES (" + cbo_profesional.SelectedValue.ToString + ", " + cbo_centro.SelectedValue.ToString + ")"
            BDHelper.EjecutarSQL(consulta)
            Dim sql = "INSERT INTO ProfesionalesxCentroxEspecialidad(id_centro, id_especialidad, matricula, fecha_alta) VALUES (" + cbo_centro.SelectedValue.ToString + ", " + cbo_especialidad.SelectedValue.ToString + ", " + cbo_profesional.SelectedValue.ToString + ", GETDATE())"
            BDHelper.EjecutarSQL(sql)
            cargarGrilla()
            cargar_todos_los_combos_por_defecto()
        Catch ex As SqlException
            If (ex.Message.Contains("duplicate key")) Then
                MsgBox("Ya existe el registro que desea grabar", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Error al intentar guardar el registro: " + ex.Message, MsgBoxStyle.Critical)
            End If
        End Try
    End Sub

    Private Sub cargarGrilla()
        dgv_grilla.Rows.Clear()
        For Each row As DataRow In BDHelper.ConsultaSQL("SELECT E.nombre AS especialidad, CM.denominacion AS centro_medico, PE.apellido + ', ' + PE.nombre AS ape_nom, CM.id_centro, E.id AS id_especialidad, P.matricula, PCE.fecha_alta FROM ProfesionalesxCentroxEspecialidad PCE JOIN Profesionales P ON PCE.matricula = P.matricula JOIN CentrosMedicos CM ON CM.id_centro = PCE.id_centro JOIN Especialidades E ON E.id = PCE.id_especialidad JOIN Personas PE ON PE.id_tipo_doc = P.id_tipo_doc AND PE.numero_doc = P.numero_doc").Rows
            dgv_grilla.Rows.Add(New String() {row.Item("especialidad"), row.Item("centro_medico"), row.Item("ape_nom"), row.Item("id_centro"), row.Item("id_especialidad"), row.Item("matricula"), row.Item("fecha_alta")})
        Next
    End Sub

    Private Sub cmd_Eliminar_Click(sender As Object, e As EventArgs) Handles cmd_Eliminar.Click
        If (dgv_grilla.SelectedRows.Count = 0) Then
            MsgBox("Debe seleccionar un registro primero", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If (MsgBox("¿Esta seguro que desea eliminar los registros seleccionados?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel) Then
            Exit Sub
        End If

        Dim listaEliminar As New List(Of EspecialidadXProfesionalXCentro)
        For Each row As DataGridViewRow In dgv_grilla.Rows
            listaEliminar.Add(New EspecialidadXProfesionalXCentro(row.Cells.Item("id_centro").Value.ToString, row.Cells.Item("id_especialidad").Value.ToString, row.Cells.Item("matricula").Value.ToString, row.Cells.Item("fecha_alta").Value.ToString))
        Next
        Try
            If (BDHelper.eliminar_ExPxC(listaEliminar)) Then
                MsgBox("Eliminacion exitoso", MsgBoxStyle.Information)
                cargarGrilla()
            Else
                MsgBox("No se pudieron eliminar los registros seleccionados", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("No se puede eliminar el registro porque tiene atenciones asignadas", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub cbo_profesional_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_profesional.SelectionChangeCommitted
        'If (cbo_centro.SelectedIndex = -1) Then
        'cargaCombo(cbo_centro, BDHelper.ConsultaSQL("SELECT CM.* FROM CentrosMedicos CM JOIN ProfesionalesxCentro PC ON PC.id_centro = CM.id_centro WHERE PC.matricula = " + cbo_profesional.SelectedValue.ToString), "id_centro", "denominacion")
        'End If
    End Sub


    Private Sub cbo_centro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_centro.SelectionChangeCommitted
        'If (cbo_profesional.SelectedIndex = -1) Then
        'cargaCombo(cbo_profesional, BDHelper.ConsultaSQL("SELECT * FROM Profesionales PR JOIN Personas PE ON PE.id_tipo_doc = PR.id_tipo_doc AND PE.numero_doc = PR.numero_doc JOIN ProfesionalesxCentro PC ON PC.matricula = PR.matricula WHERE PC.id_centro = " + cbo_centro.SelectedValue.ToString), "matricula", "apellido")
        'End If
    End Sub
End Class