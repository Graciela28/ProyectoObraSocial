Public Class frm_buscar_atencion
    Dim oTablaTipoService As New TablaTipoService
    Dim oAtencionService As New AtencionService
    Dim oAfiliadoService As New AfiliadoService
    Dim row_selected As DataGridViewRow
    Dim fechaInicial As Date
    Dim fechaFinal As Date
    Dim usoFiltrosFecha As Boolean = False
    Dim busqueda As Boolean

    Private Sub frm_buscar_pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Carga de combos 
        cargaCombo(Me.cbo_tiposDocumento, oTablaTipoService.listarTipos("TiposDocumento"), "id", "nombre")
        Me.LimpiarCombos()
        Me.busqueda = True
        Me.LimpiarCampos()
        Me.habilitarControles()

        'Estado inicial de los filtros
        'dtp_fechaInicio.Value = Convert.ToDateTime("02/02/2002")
        'dtp_fechaFinal.Value = Convert.ToDateTime("02/02/2002")
        dtp_fechaInicio.Enabled = False
        dtp_fechaFinal.Enabled = False
        chk_usoFiltros.CheckState = CheckState.Unchecked

        If frm_registrar_Atencion.busqueda = False Then
            cbo_tiposDocumento.SelectedValue = frm_registrar_Atencion.tipoAfiliado
            txt_docAfiliado.Text = frm_registrar_Atencion.documentoAfiliado
            txt_nombreAfiliado.Text = frm_registrar_Atencion.nombreAfiliado
            Me.llenarGrilla(Nothing, Nothing, Nothing, Integer.Parse(cbo_tiposDocumento.SelectedValue), Convert.ToInt32(txt_docAfiliado.Text))
            txt_docAfiliado.Enabled = False
            txt_nombreAfiliado.Enabled = False
            cbo_tiposDocumento.Enabled = False
            btn_limpiarCampos.Enabled = False
            btn_buscar.Enabled = False
        Else
            btn_eliminar.Enabled = False
        End If
    End Sub

    Private Sub habilitarControles()
        txt_docAfiliado.Enabled = True
        txt_nombreAfiliado.Enabled = True
        cbo_tiposDocumento.Enabled = True
        btn_limpiarCampos.Enabled = True
        btn_buscar.Enabled = True
    End Sub

    Private Sub LimpiarCampos()
        txt_docAfiliado.Text = String.Empty
        txt_nombreAfiliado.Text = String.Empty
        cbo_tiposDocumento.SelectedIndex = -1
        dgv_historial.Rows.Clear()
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        frm_registrar_Atencion.busqueda = False
        Me.Close()
    End Sub

    Private Sub LimpiarCombos()
        cbo_tiposDocumento.SelectedIndex = -1
    End Sub

    Private Sub cargaCombo(ByRef combo As ComboBox, ByVal datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Private Sub btn_buscar2_Click(sender As Object, e As EventArgs) Handles btn_buscar2.Click
        'Faltan validar las fechas 
        'Si se cuenta con el tipo y nro de documento llena la grilla 
        If frm_registrar_Atencion.busqueda = False Then
            If usoFiltrosFecha = True Then
                If (cbo_tiposDocumento.SelectedIndex <> -1 And txt_docAfiliado.Text <> String.Empty) = True Then
                    Me.llenarGrilla(Nothing, dtp_fechaInicio.Value.ToString("dd/MM/yyyy"), dtp_fechaFinal.Value.ToString("dd/MM/yyyy"), Integer.Parse(cbo_tiposDocumento.SelectedValue), Convert.ToInt32(txt_docAfiliado.Text))
                Else
                    MessageBox.Show("Debe ingresar el tipo y número de documento del Afiliado", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
                                 , MessageBoxDefaultButton.Button1)
                    Me.dgv_historial.Rows.Clear()
                End If
            Else
                If (cbo_tiposDocumento.SelectedIndex <> -1 And txt_docAfiliado.Text <> String.Empty) = True Then
                    Me.llenarGrilla(Nothing, Nothing, Nothing, Integer.Parse(cbo_tiposDocumento.SelectedValue), Convert.ToInt32(txt_docAfiliado.Text))
                Else
                    MessageBox.Show("Debe ingresar el tipo y número de documento del Afiliado", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
                                 , MessageBoxDefaultButton.Button1)
                    Me.dgv_historial.Rows.Clear()
                End If

            End If
        Else
            'Si no hay datos se llena la grilla con todas las atenciones 
            If frm_registrar_Atencion.busqueda = True And (cbo_tiposDocumento.SelectedIndex <> -1 And txt_docAfiliado.Text <> String.Empty) = True Then
                If usoFiltrosFecha = True Then
                    Me.llenarGrilla(Nothing, dtp_fechaInicio.Value, dtp_fechaFinal.Value, Integer.Parse(cbo_tiposDocumento.SelectedValue), Convert.ToInt32(txt_docAfiliado.Text))
                Else
                    Me.llenarGrilla(Nothing, Nothing, Nothing, Integer.Parse(cbo_tiposDocumento.SelectedValue), Convert.ToInt32(txt_docAfiliado.Text))
                End If
            Else
                If (cbo_tiposDocumento.SelectedIndex <> -1 And txt_docAfiliado.Text <> String.Empty) = True Then
                    Me.llenarGrilla(Nothing, Nothing, Nothing, Integer.Parse(cbo_tiposDocumento.SelectedValue), Convert.ToInt32(txt_docAfiliado.Text))
                Else
                    MessageBox.Show("Debe ingresar el tipo y número de documento del Afiliado", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
                              , MessageBoxDefaultButton.Button1)
                    Me.dgv_historial.Rows.Clear()
                End If
            End If
        End If
    End Sub

    Private Sub llenarGrilla(Optional ByVal lst As List(Of Atencion) = Nothing, Optional ByVal fechaInicio As Date = Nothing, Optional ByVal fechaFin As Date = Nothing, Optional ByVal tipoDoc As Integer = Nothing, Optional ByVal numDoc As Integer = Nothing)
        Dim tabla As New Data.DataTable
        If IsNothing(lst) Then
            lst = oAtencionService.listarAtencionesConFiltro(fechaInicio, fechaFin, tipoDoc, numDoc)
        End If
        Me.dgv_historial.Rows.Clear()
        For Each oAtencion In lst
            With oAtencion
                dgv_historial.Rows.Add(New String() {.fechaAtencion.ToString("dd/MM/yyyy"), .nombreTipoDocumento, .tipoDocAfiliado.ToString(), .nroDocAfiliado.ToString(), _
                                                     .nombreAfiliado, .idTipoAfil.ToString(), .nombreTipoAfiliado, .idCentro.ToString(), .nombreCentro, .matriculaProfesional.ToString(), _
                                                     .nombreProfesional, .idEspecialidad.ToString(), .nombreEspecialidad, .fechaAltaProfesional.ToString(), .idEstado.ToString(), .nombreEstado, _
                                                     .totalSinCobertura.ToString(), .totalConCobertura.ToString(), .total.ToString()})
            End With
        Next
        Me.dgv_historial.ClearSelection()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_limpiarCampos.Click
        If frm_registrar_Atencion.busqueda = True Then
            Me.LimpiarCampos()
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim tabla As New DataTable
        If cbo_tiposDocumento.SelectedIndex = -1 Or txt_docAfiliado.Text = String.Empty Then
            MessageBox.Show("Debe ingresar un tipo y número de documento", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
               , MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        tabla = oAfiliadoService.buscarAfiliado(cbo_tiposDocumento.SelectedValue, txt_docAfiliado.Text.Trim())
        If tabla.Rows.Count > 0 Then
            txt_nombreAfiliado.Text = tabla.Rows(0)("nombreCompleto").ToString
            txt_nombreAfiliado.Tag = tabla.Rows(0)("tipoAfiliado").ToString
        Else
            MessageBox.Show("El tipo y número de documento ingresado no corresponde a un Afiliado", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
               , MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub dgv_historial_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_historial.CellClick
        row_selected = dgv_historial.CurrentRow
        btn_eliminar.Enabled = True
    End Sub

    Private Sub dgv_historial_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_historial.CellDoubleClick
        Dim row As DataGridViewRow
        row = dgv_historial.CurrentRow
        Dim oAtencion As New Atencion
        Dim listaDetalles As New List(Of DetalleAtencion)

        With oAtencion
            .fechaAtencion = Convert.ToDateTime(row.Cells(0).Value.ToString())
            .nombreAfiliado = row.Cells(4).Value.ToString()
            .matriculaProfesional = Convert.ToInt64(row.Cells(9).Value.ToString())
            .idTipoAfil = Convert.ToInt16(row.Cells(5).Value.ToString())
            .idCentro = Convert.ToInt16(row.Cells(7).Value.ToString())
            .idEspecialidad = Convert.ToInt16(row.Cells(11).Value.ToString())
            .tipoDocAfiliado = Convert.ToInt16(row.Cells(2).Value.ToString())
            .nroDocAfiliado = Convert.ToInt64(row.Cells(3).Value.ToString())
            .fechaAltaProfesional = Convert.ToDateTime(row.Cells(13).Value.ToString())
            .idEstado = Convert.ToInt16(row.Cells(14).Value.ToString())
            .totalSinCobertura = Convert.ToDouble(row.Cells(16).Value.ToString())
            .totalConCobertura = Convert.ToDouble(row.Cells(17).Value.ToString())
            .total = Convert.ToDouble(row.Cells(18).Value.ToString())
        End With

        frm_mostrar_atencion.fecha = oAtencion.fechaAtencion
        frm_mostrar_atencion.selected_tipoDoc = oAtencion.tipoDocAfiliado
        frm_mostrar_atencion.selected_nroDoc = oAtencion.nroDocAfiliado
        frm_mostrar_atencion.selected_centro = oAtencion.idCentro
        frm_mostrar_atencion.selected_profesional = oAtencion.matriculaProfesional
        frm_mostrar_atencion.selected_especialidad = oAtencion.idEspecialidad
        frm_mostrar_atencion.fecha_altaProf = oAtencion.fechaAltaProfesional
        frm_mostrar_atencion.nombre_completo = oAtencion.nombreAfiliado
        frm_mostrar_atencion.tipoAfiliado = oAtencion.idTipoAfil
        frm_mostrar_atencion.modificar = False
        frm_mostrar_atencion.listaDetalles = oAtencionService.getDetallesAtencionByFilters(oAtencion)
        frm_mostrar_atencion.totalSinCobertura = oAtencion.totalSinCobertura
        frm_mostrar_atencion.totalConCobertura = oAtencion.totalConCobertura
        frm_mostrar_atencion.total = oAtencion.total
        frm_mostrar_atencion.idEstado = oAtencion.idEstado
        frm_mostrar_atencion.ShowDialog()
    End Sub

    Private Sub txt_docAfiliado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_docAfiliado.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 13, 9, 15, 14
                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Este carater no es un numero ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Convert.ToInt16(row_selected.Cells(14).Value.ToString()) <> 3 Then
            Dim oAtencion As New Atencion
            With oAtencion
                .fechaAtencion = Convert.ToDateTime(row_selected.Cells(0).Value.ToString())
                .tipoDocAfiliado = Convert.ToInt16(row_selected.Cells(2).Value.ToString())
                .nroDocAfiliado = Convert.ToInt64(row_selected.Cells(3).Value.ToString())
                .idCentro = Convert.ToInt16(row_selected.Cells(7).Value.ToString())
                .matriculaProfesional = Convert.ToInt64(row_selected.Cells(9).Value.ToString())
                .idEspecialidad = Convert.ToInt16(row_selected.Cells(11).Value.ToString())
                .fechaAltaProfesional = Convert.ToDateTime(row_selected.Cells(13).Value.ToString())
            End With
            If oAtencionService.eliminarAtencion(oAtencion) = True Then
                MessageBox.Show("La Atención se eliminó con éxito", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
                               , MessageBoxDefaultButton.Button1)
                Me.llenarGrilla(Nothing, Nothing, Nothing, Integer.Parse(cbo_tiposDocumento.SelectedValue), Convert.ToInt32(txt_docAfiliado.Text))
            Else
                MessageBox.Show("Hubo un problema en la eliminación de la Atención", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
                              , MessageBoxDefaultButton.Button1)
            End If
        Else
            MessageBox.Show("La Atención seleccionada ya se encuentra anulada", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Error _
                              , MessageBoxDefaultButton.Button1)
        End If
        
    End Sub

    Private Sub chk_usoFiltros_CheckStateChanged(sender As Object, e As EventArgs) Handles chk_usoFiltros.CheckStateChanged
        If chk_usoFiltros.CheckState = CheckState.Checked Then
            dtp_fechaInicio.Enabled = True
            dtp_fechaFinal.Enabled = True
            usoFiltrosFecha = True
        Else
            dtp_fechaInicio.Enabled = False
            dtp_fechaFinal.Enabled = False
            usoFiltrosFecha = False
        End If
    End Sub

    Private Sub dtp_fechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fechaFinal.ValueChanged
        fechaFinal = Convert.ToDateTime(dtp_fechaFinal.Value.ToString("dd/MM/yyyy"))
    End Sub

    Private Sub dtp_fechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fechaInicio.ValueChanged
        fechaInicial = Convert.ToDateTime(dtp_fechaInicio.Value.ToString("dd/MM/yyyy"))
    End Sub
End Class