Public Class frm_registrar_Atencion
    Enum estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum

    Dim oAtencionService As New AtencionService
    Dim oProfesionalesxCentroxEspecialidadService As New ProfesionalesxCentroxEspecialidadService
    Dim oAfiliadoService As New AfiliadoService
    Dim oTablaTipoService As New TablaTipoService
    Dim oPracticasxEspecialidadService As New PracticasxEspecialidadService
    Dim oCoberturaService As New CoberturaService
    Dim accion As estado = estado.insertar

    Public Property busqueda As Boolean = False

    Public Property documentoAfiliado() As Integer
        Get
            If Not String.IsNullOrEmpty(txt_docAfiliado.Text) Then
                Return Integer.Parse(txt_docAfiliado.Text)
            End If
            Return 0
        End Get
        Set(ByVal value As Integer)
            txt_docAfiliado.Text = value
        End Set
    End Property

    Public Property tipoAfiliado() As Integer
        Get
            Return txt_n_afiliado.Tag
        End Get
        Set(ByVal value As Integer)
            txt_n_afiliado.Tag = value
        End Set
    End Property

    Public Property nombreAfiliado() As String
        Get
            Return txt_n_afiliado.Text
        End Get
        Set(ByVal value As String)
            txt_n_afiliado.Text = value
        End Set
    End Property

    ' Private Function validar() As Boolean
    'If cbo_centros.SelectedIndex = -1 Then
    '  MessageBox.Show("Debe seleccionar un centro medico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '   Return False
    '    Exit Function
    ' Else
    ' If cbo_especialidades.SelectedIndex = -1 Then
    '  MessageBox.Show("Debe seleccionar una especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '   Return False
    '    Exit Function
    ' Else
    '  If cbo_profesionales.SelectedIndex = -1 Then
    '       MessageBox.Show("Debe seleccionar un profesional", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '         Exit Function
    '      Else
    '           If cbo_tiposDocumento.SelectedIndex = -1 Then
    '                MessageBox.Show("Debe seleccionar un profesional", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                 Return False
    '                  Exit Function
    '               End If
    '            End If
    '         End If
    '      End If
    '   End Function

    Private Sub frm_registrar_Atencion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtp_fecha.Value = oAtencionService.obtenerFechaActual()
        dtp_fecha.Enabled = False

        'Carga de Combos
        cargaCombo(Me.cbo_centros, oProfesionalesxCentroxEspecialidadService.getCentrosMedicos(), "id_centro", "denominacion")
        cargaCombo(Me.cbo_tiposDocumento, oTablaTipoService.ListarTipos("TiposDocumento"), "id", "nombre")
        Me.LimpiarCombos()
        Me.Limpiar_Campos()
        Me.deshabilitarControles()
        'dtp_fecha.Enabled = True 
        btn_grabar.Enabled = False
        Me.txt_estado.Text = "Nueva"
        Me.txt_estado.Enabled = False
    End Sub

    Private Sub LimpiarCombos()
        cbo_centros.SelectedIndex = -1
        cbo_tiposDocumento.SelectedIndex = -1
        cbo_especialidades.SelectedIndex = -1
        cbo_profesionales.SelectedIndex = -1
    End Sub

    Private Sub Limpiar_Campos()
        txt_docAfiliado.Text = ""
        txt_n_afiliado.Text = ""
    End Sub

    Private Sub deshabilitarControles()
        Me.grp_detalles.Enabled = False
        txt_total_sc.Enabled = False
        txt_total_cc.Enabled = False
        txt_total.Enabled = False
    End Sub

    Private Sub habilitarCabecera()
        cbo_centros.Enabled = True
        cbo_especialidades.Enabled = True
        cbo_profesionales.Enabled = True
        cbo_tiposDocumento.Enabled = True
        txt_docAfiliado.Enabled = True
        txt_n_afiliado.Enabled = True
    End Sub

    Private Sub cargaCombo(ByRef combo As ComboBox, ByVal datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
        combo.SelectedIndex = -1
    End Sub

    Private Sub cbo_centros_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_centros.SelectionChangeCommitted
        cbo_profesionales.SelectedIndex = -1
        cbo_especialidades.DataSource = oProfesionalesxCentroxEspecialidadService.getEspecialidadesConFiltro(cbo_centros.SelectedValue)
        cbo_especialidades.ValueMember = "id_especialidad"
        cbo_especialidades.DisplayMember = "nombre"
        cbo_especialidades.SelectedIndex = -1
    End Sub

    Private Sub cbo_especialidades_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_especialidades.SelectionChangeCommitted
        cbo_profesionales.DataSource = oProfesionalesxCentroxEspecialidadService.getProfesionalesConFiltro(cbo_centros.SelectedValue, cbo_especialidades.SelectedValue)
        cbo_profesionales.ValueMember = "matricula"
        cbo_profesionales.DisplayMember = "nombreCompleto"
        cbo_profesionales.SelectedIndex = -1

        cbo_practicas.DataSource = oPracticasxEspecialidadService.getPracticasConFiltro(cbo_especialidades.SelectedValue)
        cbo_practicas.ValueMember = "id"
        cbo_practicas.DisplayMember = "nombre"
        cbo_practicas.SelectedIndex = -1
    End Sub

    Private Sub cbo_practicas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_practicas.SelectionChangeCommitted
        Dim listaCoberturas As New List(Of Cobertura)
        Dim oCobertura As New Cobertura
        listaCoberturas = oCoberturaService.buscarCobertura(CInt(txt_n_afiliado.Tag.ToString), cbo_practicas.SelectedValue, cbo_especialidades.SelectedValue, cbo_centros.SelectedValue)

        For Each oCobertura In listaCoberturas
            With oCobertura
                txt_preciosc.Text = oCobertura.precioPractica
                txt_cobertura.Text = oCobertura.porcentajeCobertura
                txt_preciocc.Text = oCobertura.precioPractica - (oCobertura.precioPractica * oCobertura.porcentajeCobertura / 100)
                txt_cantidad.Text = 1
                txt_subtotal.Text = oCoberturaService.calcularSubTotal(oCobertura.precioPractica, oCobertura.porcentajeCobertura, 1)
            End With
        Next
        Me.btn_agregarAGrilla.Enabled = True
    End Sub

    Private Sub cbo_profesionales_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_profesionales.SelectionChangeCommitted
        Dim tabla As New DataTable
        tabla = oProfesionalesxCentroxEspecialidadService.buscarProfesional(cbo_centros.SelectedValue, cbo_especialidades.SelectedValue, cbo_profesionales.SelectedValue)
        cbo_profesionales.Tag = tabla(0)("fecha_alta").ToString()
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
            txt_n_afiliado.Text = tabla.Rows(0)("nombreCompleto").ToString
            txt_n_afiliado.Enabled = False
            txt_n_afiliado.Tag = tabla.Rows(0)("tipoAfiliado").ToString
        Else
            MessageBox.Show("El tipo y número de documento ingresado no corresponde a un Afiliado", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
               , MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Function validar_Existencia(oAtencion As Atencion) As DataTable
        Return oAtencionService.validarExistenciaAtencion(oAtencion)
    End Function

    Private Sub btn_verHistorial_Click(sender As Object, e As EventArgs) Handles btn_verHistorial.Click
        If cbo_tiposDocumento.SelectedIndex = -1 Or txt_docAfiliado.Text = String.Empty Then
            MessageBox.Show("Debe ingresar el tipo y número de documento del Afiliado", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
               , MessageBoxDefaultButton.Button1)
        Else
            Me.tipoAfiliado = cbo_tiposDocumento.SelectedValue
            Me.documentoAfiliado = txt_docAfiliado.Text
            Me.busqueda = False
            frm_buscar_atencion.ShowDialog()
        End If
    End Sub


    Private Sub btn_agregarAGrilla_Click(sender As Object, e As EventArgs) Handles btn_agregarAGrilla.Click
        If (cbo_practicas.SelectedIndex <> -1) Then
            Dim fila As Integer = Me.buscarPracticaDuplicada()
            If fila > -1 Then
                dgv_practicas.Rows(fila).Cells(5).Value = Convert.ToDouble(dgv_practicas.Rows(fila).Cells(5).Value) + Convert.ToDouble(txt_cantidad.Text)
                dgv_practicas.Rows(fila).Cells(6).Value = Convert.ToDouble(dgv_practicas.Rows(fila).Cells(6).Value) + Convert.ToDouble(txt_subtotal.Text)
            Else
                dgv_practicas.Rows.Add(cbo_practicas.SelectedValue, _
                                       cbo_practicas.Text.ToString, _
                                       txt_preciosc.Text, _
                                       txt_cobertura.Text, _
                                       txt_preciocc.Text, _
                                       txt_cantidad.Text, _
                                       txt_subtotal.Text)
            End If
            Me.txt_total_sc.Text = Me.calcularTotal(2)
            Me.txt_total_cc.Text = Me.calcularTotal(4)

            'Limpia campos para volver a seleccionar una práctica
            Me.txt_preciosc.Text = String.Empty
            Me.txt_cobertura.Text = String.Empty
            Me.txt_preciocc.Text = String.Empty
            Me.txt_cantidad.Text = String.Empty
            Me.txt_subtotal.Text = String.Empty
            Me.btn_agregarAGrilla.Enabled = False
            Me.cbo_practicas.SelectedIndex = -1
        Else
            MessageBox.Show("Debe seleccionar una práctica", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function calcularTotal(ByVal columna As Integer) As Double
        Dim c As Integer
        Dim calculo As Double
        calculo = 0
        For c = 0 To dgv_practicas.RowCount - 1
            calculo = calculo + (Convert.ToDouble(dgv_practicas.Rows(c).Cells(columna).Value) * Convert.ToDouble(dgv_practicas.Rows(c).Cells(5).Value))
        Next
        Return calculo
    End Function

    Private Function buscarPracticaDuplicada() As Integer
        Dim c As Integer
        Dim encontro As Integer = -1

        For c = 0 To dgv_practicas.RowCount - 1
            If dgv_practicas.Rows(c).Cells(1).Value.ToString.Trim = cbo_practicas.Text.Trim Then
                encontro = c
                Exit For
            End If
        Next
        Return encontro
    End Function

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.busqueda = False
        Me.Close()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Me.LimpiarCampos()
        Me.habilitarCabecera()
        Me.deshabilitarControles()
        Me.cbo_centros.Focus()
        Me.accion = estado.insertar
    End Sub

    Private Sub LimpiarCampos()
        'Blanquea todos los objetos que se utilicen para cargar datos 
        cbo_centros.SelectedIndex = -1
        cbo_especialidades.SelectedIndex = -1
        cbo_profesionales.SelectedIndex = -1
        cbo_tiposDocumento.SelectedIndex = -1
        txt_docAfiliado.Text = ""
        txt_n_afiliado.Text = ""
        cbo_practicas.SelectedIndex = -1
        txt_preciosc.Text = ""
        txt_cobertura.Text = ""
        txt_preciocc.Text = ""
        txt_cantidad.Text = ""
        txt_subtotal.Text = ""
        txt_total_sc.Text = ""
        dgv_practicas.Rows.Clear()
        txt_total_cc.Text = ""
        txt_total_sc.Text = ""
    End Sub

    Private Sub btn_buscar2_Click(sender As Object, e As EventArgs) Handles btn_buscar2.Click
        'Permite cargar otro formulario para realizar la búsqueda de una atención 
        Me.busqueda = True
        frm_buscar_atencion.ShowDialog()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If dgv_practicas.Rows.Count > 0 Then
            Dim oAtencion As New Atencion
            Dim listaDetalles As New List(Of DetalleAtencion)

            With oAtencion
                .fechaAtencion = dtp_fecha.Value.ToString("dd/MM/yyyy")
                .tipoDocAfiliado = cbo_tiposDocumento.SelectedValue
                .nroDocAfiliado = txt_docAfiliado.Text.Trim()
                .idCentro = Convert.ToInt16(cbo_centros.SelectedValue.ToString().Trim())
                .matriculaProfesional = Convert.ToInt16(cbo_profesionales.SelectedValue.ToString().Trim())
                .idEspecialidad = Convert.ToInt16(cbo_especialidades.SelectedValue.ToString().Trim())
                .fechaAltaProfesional = Convert.ToDateTime(cbo_profesionales.Tag.ToString().Trim())
                .idEstado = 1
                .totalSinCobertura = Convert.ToDouble(txt_total_sc.Text)
                .totalConCobertura = Convert.ToDouble(txt_total_cc.Text)
                .total = Convert.ToDouble(txt_total.Text)
            End With

            'No se puede grabar dos detalles con el mismo código de práctica
            For Each row As DataGridViewRow In dgv_practicas.Rows()
                listaDetalles.Add(mapToDetalleAtencion(row))
            Next
            Dim resultado As Boolean
            resultado = oAtencionService.registrarAtencion(oAtencion, listaDetalles)

            If resultado = True Then
                MessageBox.Show("La Atención se registró exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frm_mostrar_atencion.fecha = oAtencion.fechaAtencion
                frm_mostrar_atencion.selected_tipoDoc = oAtencion.tipoDocAfiliado
                frm_mostrar_atencion.selected_nroDoc = oAtencion.nroDocAfiliado
                frm_mostrar_atencion.selected_centro = oAtencion.idCentro
                frm_mostrar_atencion.selected_profesional = oAtencion.matriculaProfesional
                frm_mostrar_atencion.selected_especialidad = oAtencion.idEspecialidad
                frm_mostrar_atencion.fecha_altaProf = oAtencion.fechaAltaProfesional
                frm_mostrar_atencion.nombre_completo = txt_n_afiliado.Text
                frm_mostrar_atencion.tipoAfiliado = txt_n_afiliado.Tag
                frm_mostrar_atencion.modificar = False
                frm_mostrar_atencion.listaDetalles = listaDetalles
                frm_mostrar_atencion.totalSinCobertura = Convert.ToDouble(txt_total_sc.Text.ToString())
                frm_mostrar_atencion.totalConCobertura = Convert.ToDouble(txt_total_cc.Text.ToString())
                frm_mostrar_atencion.total = Convert.ToDouble(txt_total.Text.ToString())
                frm_mostrar_atencion.idEstado = 1
                Me.LimpiarCampos()
                Me.habilitarCabecera()
                Me.deshabilitarControles()
                frm_mostrar_atencion.ShowDialog()
            End If
        Else
            MsgBox("Debe seleccionar al menos una práctica para registrar la Atención")
        End If
    End Sub

    Private Function mapToDetalleAtencion(row As DataGridViewRow) As DetalleAtencion
        Dim oDetalleAtencion As New DetalleAtencion
        With oDetalleAtencion
            .idPractica = Convert.ToInt16(row.Cells(0).Value.ToString())
            .nombrePractica = row.Cells(1).Value.ToString()
            .precioPracticaSinCobertura = Convert.ToDouble(row.Cells(2).Value.ToString())
            .cobertura = Convert.ToInt16(row.Cells(3).Value.ToString())
            .precioPracticaConCobertura = Convert.ToDouble(row.Cells(4).Value.ToString())
            .cantidad = Convert.ToInt16(row.Cells(5).Value.ToString())
            .subtotal = Convert.ToDouble(row.Cells(6).Value.ToString())
        End With
        Return oDetalleAtencion
    End Function

    Public Sub mostrarAtencion(ByVal oAtencion As Atencion)
        Me.Text = " Mostrar Atención"
        Me.dtp_fecha.Value = oAtencion.fechaAtencion.ToString()
        Me.cbo_centros.SelectedValue = oAtencion.idCentro

        Me.cbo_especialidades.SelectedValue = oAtencion.idEspecialidad

        Me.cbo_profesionales.SelectedValue = oAtencion.matriculaProfesional

        Me.cbo_tiposDocumento.SelectedValue = oAtencion.tipoDocAfiliado
        Me.txt_docAfiliado.Text = oAtencion.nroDocAfiliado.ToString()
        Me.txt_n_afiliado.Text = oAtencion.nombreAfiliado.ToString()

        Me.txt_total_sc.Text = oAtencion.totalSinCobertura.ToString()
        Me.txt_total_cc.Text = oAtencion.totalConCobertura.ToString()
        Me.txt_total.Text = oAtencion.total.ToString()

        Me.dtp_fecha.Enabled = False
        Me.cbo_centros.Enabled = True
        Me.cbo_especialidades.Enabled = False
        Me.cbo_profesionales.Enabled = False
        Me.cbo_tiposDocumento.Enabled = True
        Me.txt_docAfiliado.Enabled = False
        Me.txt_n_afiliado.Enabled = False
        Me.txt_total_cc.Enabled = False
        Me.txt_total_sc.Enabled = False

    End Sub

    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad.TextChanged
        If (txt_cantidad.Text <> String.Empty) Then
            Me.txt_subtotal.Text = Convert.ToDouble(Me.txt_preciocc.Text) * Convert.ToDouble(Me.txt_cantidad.Text)
        Else
            Me.txt_subtotal.Text = String.Empty
        End If
    End Sub

    Private Sub dgv_practicas_DoubleClick(sender As Object, e As EventArgs) Handles dgv_practicas.DoubleClick
        If MsgBox("Está seguro que desea borrar esta fila de la grilla?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Importante") = MsgBoxResult.Yes Then
            Me.dgv_practicas.Rows.RemoveAt(Me.dgv_practicas.CurrentRow.Index)
            Me.txt_total_sc.Text = Me.calcularTotal(2)
            Me.txt_total_cc.Text = Me.calcularTotal(4)
        End If
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

    Private Sub txt_total_cc_TextChanged(sender As Object, e As EventArgs) Handles txt_total_cc.TextChanged
        Dim total As Double
        If txt_total_cc.Text <> String.Empty Then
            total = Convert.ToDouble(txt_total_cc.Text)
            txt_total.Text = total
        Else
            txt_total.Text = String.Empty
        End If
    End Sub

    Private Sub btn_agregarDetalle_Click(sender As Object, e As EventArgs) Handles btn_agregarDetalle.Click

        If (validarCabeceraCompleta()) Then
            Dim oAtencion As New Atencion
            Dim tabla2 As New DataTable

            oAtencion.fechaAtencion = Convert.ToDateTime(Me.dtp_fecha.Value.ToString("dd/MM/yyyy"))
            oAtencion.tipoDocAfiliado = Convert.ToInt16(cbo_tiposDocumento.SelectedValue)
            oAtencion.nroDocAfiliado = Convert.ToInt32(txt_docAfiliado.Text)
            oAtencion.idCentro = Convert.ToInt16(cbo_centros.SelectedValue)
            oAtencion.matriculaProfesional = Convert.ToInt64(cbo_profesionales.SelectedValue)
            oAtencion.idEspecialidad = Convert.ToInt16(cbo_especialidades.SelectedValue)
            oAtencion.fechaAltaProfesional = Convert.ToDateTime(cbo_profesionales.Tag)
            tabla2 = validar_Existencia(oAtencion)

            If tabla2.Rows.Count() <> 1 Then
                Me.grp_detalles.Enabled = True
                Me.txt_preciosc.Enabled = False
                Me.txt_cobertura.Enabled = False
                Me.txt_preciocc.Enabled = False
                Me.txt_cantidad.Enabled = False
                Me.txt_subtotal.Enabled = False
                Me.btn_agregarAGrilla.Enabled = False
                Me.btn_grabar.Enabled = True
            Else
                If MsgBox("La Atención para ese paciente ya existe, desea modificarla?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Importante") = MsgBoxResult.Yes Then
                    frm_mostrar_atencion.fecha = oAtencion.fechaAtencion
                    frm_mostrar_atencion.selected_tipoDoc = oAtencion.tipoDocAfiliado
                    frm_mostrar_atencion.selected_nroDoc = oAtencion.nroDocAfiliado
                    frm_mostrar_atencion.selected_centro = oAtencion.idCentro
                    frm_mostrar_atencion.selected_profesional = oAtencion.matriculaProfesional
                    frm_mostrar_atencion.selected_especialidad = oAtencion.idEspecialidad
                    frm_mostrar_atencion.fecha_altaProf = oAtencion.fechaAltaProfesional
                    frm_mostrar_atencion.nombre_completo = txt_n_afiliado.Text
                    frm_mostrar_atencion.tipoAfiliado = txt_n_afiliado.Tag
                    frm_mostrar_atencion.modificar = True
                    frm_mostrar_atencion.listaDetalles = oAtencionService.getDetallesAtencionByFilters(oAtencion)
                    frm_mostrar_atencion.totalSinCobertura = Convert.ToDouble(tabla2.Rows(0)("total_sc").ToString)
                    frm_mostrar_atencion.totalConCobertura = Convert.ToDouble(tabla2.Rows(0)("total_cc").ToString)
                    frm_mostrar_atencion.total = Convert.ToDouble(tabla2.Rows(0)("total").ToString)
                    frm_mostrar_atencion.idEstado = 1
                    frm_mostrar_atencion.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Function validarCabeceraCompleta() As Boolean
        Dim estaCompleta As Boolean = True
        If (cbo_centros.SelectedIndex = -1) Then
            MessageBox.Show("Debe seleccionar un centro médico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estaCompleta = False
            Return estaCompleta
        End If

        If (cbo_especialidades.SelectedIndex = -1) Then
            MessageBox.Show("Debe seleccionar una especialidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estaCompleta = False
            Return estaCompleta
        End If

        If (cbo_profesionales.SelectedIndex = -1) Then
            MessageBox.Show("Debe seleccionar un profesional", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estaCompleta = False
            Return estaCompleta
        End If

        If (txt_n_afiliado.Text = String.Empty) Then
            MessageBox.Show("Debe buscar un afiliado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estaCompleta = False
            Return estaCompleta
        End If
        Return estaCompleta
    End Function
End Class
