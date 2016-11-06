Public Class frm_mostrar_atencion
    Public Property fecha As Date
    Public Property selected_centro As Integer
    Public Property selected_especialidad As Integer
    Public Property selected_profesional As Integer
    Public Property selected_tipoDoc As Integer
    Public Property selected_nroDoc As Int32
    Public Property nombre_completo As String
    Public Property fecha_altaProf As Date
    Public Property tipoAfiliado As Integer
    Public Property modificar As Boolean = False
    Public Property listaDetalles As List(Of DetalleAtencion)
    Public Property totalSinCobertura As Double
    Public Property totalConCobertura As Double
    Public Property total As Double
    Public Property idEstado As Integer

    Dim estaEditando As Boolean = False
    Dim oPracticasxEspecialidadService As New PracticasxEspecialidadService
    Dim oProfesionalesxCentroxEspecialidadService As New ProfesionalesxCentroxEspecialidadService
    Dim oTablaTipoService As New TablaTipoService
    Dim oCoberturaService As New CoberturaService

    Private Sub frm_mostrar_atencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga de Combos
        cargaCombo(Me.cbo_centros, oProfesionalesxCentroxEspecialidadService.getCentrosMedicos(), "id_centro", "denominacion")
        cargaCombo(Me.cbo_tipoDoc, oTablaTipoService.ListarTipos("TiposDocumento"), "id", "nombre")
        'Limpiar Grilla 
        Me.dgv_practicas.Rows.Clear()

        Me.cargarCampos()
        If Me.modificar = False Then
            Me.deshabilitarControles()
            btn_grabar.Enabled = False
            If Me.idEstado = 1 Then
                txt_estado.Text = "En Curso"
                btn_modificar.Enabled = True
            End If
            If Me.idEstado = 2 Then
                txt_estado.Text = "Cerrada"
                btn_modificar.Enabled = True
            End If
            If Me.idEstado = 3 Then
                txt_estado.Text = "Anulada"
                btn_modificar.Enabled = False
            End If
        Else
            Me.deshabilitarControlesCabecera()
            dgv_practicas.Enabled = False
            btn_grabar.Enabled = True
            Me.deshabilitarTotales()
        End If
    End Sub

    Private Sub deshabilitarControlesCabecera()
        dtp_fecha.Enabled = False
        cbo_centros.Enabled = False
        cbo_especialidades.Enabled = False
        cbo_profesionales.Enabled = False
        cbo_tipoDoc.Enabled = False
        txt_nroDocAfil.Enabled = False
        txt_n_afiliado.Enabled = False
    End Sub

    Private Sub cargaCombo(ByRef combo As ComboBox, ByVal datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Private Sub cargarCampos()
        dtp_fecha.Value = Me.fecha
        cbo_centros.SelectedValue = Me.selected_centro
        cbo_especialidades.DataSource = oProfesionalesxCentroxEspecialidadService.getEspecialidadesConFiltro(cbo_centros.SelectedValue)
        cbo_especialidades.ValueMember = "id_especialidad"
        cbo_especialidades.DisplayMember = "nombre"
        cbo_especialidades.SelectedValue = Me.selected_especialidad

        cbo_profesionales.DataSource = oProfesionalesxCentroxEspecialidadService.getProfesionalesConFiltro(cbo_centros.SelectedValue, cbo_especialidades.SelectedValue)
        cbo_profesionales.ValueMember = "matricula"
        cbo_profesionales.DisplayMember = "nombreCompleto"
        cbo_profesionales.SelectedValue = Me.selected_profesional

        cbo_practicas.DataSource = oPracticasxEspecialidadService.getPracticasConFiltro(cbo_especialidades.SelectedValue)
        cbo_practicas.ValueMember = "id"
        cbo_practicas.DisplayMember = "nombre"
        cbo_practicas.SelectedIndex = -1

        cbo_tipoDoc.SelectedValue = Me.selected_tipoDoc
        txt_nroDocAfil.Text = selected_nroDoc
        txt_n_afiliado.Text = nombre_completo
        txt_n_afiliado.Tag = tipoAfiliado

        If Me.idEstado = 1 Then
            Me.txt_estado.Text = "En Curso"
        End If
        Me.txt_estado.Enabled = False

        For Each oDetalleAtencion In listaDetalles
            With oDetalleAtencion
                dgv_practicas.Rows.Add(New String() {.idPractica.ToString(), .nombrePractica, .precioPracticaSinCobertura.ToString, .cobertura.ToString, .precioPracticaConCobertura.ToString, .cantidad.ToString, .subtotal.ToString})
            End With
        Next

        txt_total_sc.Text = Me.totalSinCobertura
        txt_total_cc.Text = Me.totalConCobertura
        txt_total.Text = Me.total
    End Sub

    Private Sub deshabilitarControles()
        'Estado inicial de los controles 
        Me.deshabilitarControlesCabecera()
        grp_practicas.Enabled = False
        btn_grabar.Enabled = False
        Me.deshabilitarTotales()
    End Sub

    Private Sub deshabilitarTotales()
        txt_total_sc.Enabled = False
        txt_total_cc.Enabled = False
        txt_total.Enabled = False
    End Sub

    Friend Sub mostrarAtencion(ByVal oAtencion As Atencion)
        Me.deshabilitarControles()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        'Se tendría que poder modificar si es dentro del mismo día 
        Me.modificar = True
        grp_practicas.Enabled = True
        Me.txt_preciosc.Enabled = False
        Me.txt_porcenCobertura.Enabled = False
        Me.txt_preciocc.Enabled = False
        Me.txt_cantidad.Enabled = False
        Me.txt_subtotal.Enabled = False
        Me.btn_agregar.Enabled = False

        btn_grabar.Enabled = True
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If Me.modificar = False Then
            Me.Close()
        Else
            If MessageBox.Show("Seguro que desea salir de la Edición?", _
               "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
               , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                Me.Close()
            End If
        End If

    End Sub

    Private Sub cbo_practicas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_practicas.SelectionChangeCommitted
        Dim listaCoberturas As New List(Of Cobertura)
        Dim oCobertura As New Cobertura
        listaCoberturas = oCoberturaService.buscarCobertura(tipoAfiliado, cbo_practicas.SelectedValue, cbo_especialidades.SelectedValue, cbo_centros.SelectedValue)

        For Each oCobertura In listaCoberturas
            With oCobertura
                txt_preciosc.Text = oCobertura.precioPractica
                txt_porcenCobertura.Text = oCobertura.porcentajeCobertura
                txt_preciocc.Text = oCobertura.precioPractica - (oCobertura.precioPractica * oCobertura.porcentajeCobertura / 100)
                txt_cantidad.Text = 1
                txt_subtotal.Text = oCoberturaService.calcularSubTotal(oCobertura.precioPractica, oCobertura.porcentajeCobertura, 1)
            End With
        Next
        btn_agregar.Enabled = True
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim fila As Integer = Me.buscarPracticaDuplicada()
        If fila > -1 Then
            dgv_practicas.Rows(fila).Cells(5).Value = Convert.ToDouble(dgv_practicas.Rows(fila).Cells(5).Value) + Convert.ToDouble(txt_cantidad.Text)
            dgv_practicas.Rows(fila).Cells(6).Value = Convert.ToDouble(dgv_practicas.Rows(fila).Cells(6).Value) + Convert.ToDouble(txt_subtotal.Text)
        Else
            dgv_practicas.Rows.Add(cbo_practicas.SelectedValue, _
                                   cbo_practicas.Text.ToString, _
                                   txt_preciosc.Text, _
                                   txt_porcenCobertura.Text, _
                                   txt_preciocc.Text, _
                                   txt_cantidad.Text, _
                                   txt_subtotal.Text)
        End If
        Me.txt_total_sc.Text = Me.calcularTotal(2)
        Me.txt_total_cc.Text = Me.calcularTotal(4)

        Me.txt_preciosc.Text = String.Empty
        Me.txt_porcenCobertura.Text = String.Empty
        Me.txt_preciocc.Text = String.Empty
        Me.txt_cantidad.Text = String.Empty
        Me.txt_subtotal.Text = String.Empty
        Me.btn_agregar.Enabled = False
    End Sub

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

    Private Function calcularTotal(ByVal columna As Integer) As Double
        Dim c As Integer
        Dim calculo As Double
        calculo = 0
        For c = 0 To dgv_practicas.RowCount - 1
            calculo = calculo + (Convert.ToDouble(dgv_practicas.Rows(c).Cells(columna).Value) * Convert.ToDouble(dgv_practicas.Rows(c).Cells(5).Value))
        Next
        Return calculo
    End Function

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If dgv_practicas.Rows.Count > 0 Then
            If Me.updateAtencion() > 0 Then
                MsgBox("La Atención se modificó con exito")
                Me.modificar = False
                Me.Visible = False
            Else
                MsgBox("Hubo un error en la actualización de la Atención")
            End If
        Else
            MsgBox("No hay prácticas para grabar. Desea no guardar cambios o desea borrar la cabecera de la Atención?")
        End If
    End Sub

    Private Function updateAtencion() As Integer
        Dim listaDetallesAtencion As New List(Of DetalleAtencion)
        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As SqlClient.SqlCommand = Nothing
        Dim trans As SqlClient.SqlTransaction = Nothing
        Dim status As Integer = 0
        Dim consulta As String = ""

        Try
            conexion.ConnectionString = BDHelper.string_conexion
            conexion.Open()
            trans = conexion.BeginTransaction()

            consulta = "DELETE FROM DetallesAtencion where fecha_atencion = @fecha "
            consulta += "and tipo_doc_Afil = @tipoDoc and nro_doc_Afil = @nroDoc and id_centro = @idCentro "
            consulta += "and matricula = @matricula and id_especialidad = @idEspecialidad "
            consulta += "and fecha_alta = @fechaAlta"
           
            cmd = New SqlClient.SqlCommand(consulta, conexion, trans)
            cmd.Parameters.AddWithValue("@fecha", Me.fecha.ToString())
            cmd.Parameters.AddWithValue("@tipoDoc", selected_tipoDoc.ToString())
            cmd.Parameters.AddWithValue("@nroDoc", selected_nroDoc.ToString())
            cmd.Parameters.AddWithValue("@idCentro", selected_centro.ToString())
            cmd.Parameters.AddWithValue("@matricula", selected_profesional.ToString())
            cmd.Parameters.AddWithValue("@idEspecialidad", selected_especialidad.ToString())
            cmd.Parameters.AddWithValue("@fechaAlta", fecha_altaProf.ToString("dd/MM/yyyy"))
            cmd.ExecuteNonQuery()

            For Each row As DataGridViewRow In dgv_practicas.Rows()
                listaDetallesAtencion.Add(mapToDetalleAtencion(row))
            Next

            For Each oDetalleAtencion As DetalleAtencion In listaDetallesAtencion
                consulta = "INSERT into DetallesAtencion values ( "
                consulta += "@fecha, @tipoDoc, @nroDoc, @idCentro, @matricula, "
                consulta += "@idEspecialidad, @fechaAlta, @idPractica, @precioSinCobertura, @cobertura, @precioConCobertura, @cantidad, @subtotal)"
                cmd = New SqlClient.SqlCommand(consulta, conexion, trans)
                cmd.Parameters.AddWithValue("@fecha", Me.fecha.ToString())
                cmd.Parameters.AddWithValue("@tipoDoc", selected_tipoDoc.ToString())
                cmd.Parameters.AddWithValue("@nroDoc", selected_nroDoc.ToString())
                cmd.Parameters.AddWithValue("@idCentro", selected_centro.ToString())
                cmd.Parameters.AddWithValue("@matricula", selected_profesional.ToString())
                cmd.Parameters.AddWithValue("@idEspecialidad", selected_especialidad.ToString())
                cmd.Parameters.AddWithValue("@fechaAlta", fecha_altaProf.ToString())
                cmd.Parameters.AddWithValue("@idPractica", oDetalleAtencion.idPractica.ToString())
                cmd.Parameters.AddWithValue("@precioSinCobertura", oDetalleAtencion.precioPracticaSinCobertura)
                cmd.Parameters.AddWithValue("@cobertura", oDetalleAtencion.cobertura)
                cmd.Parameters.AddWithValue("@precioConCobertura", oDetalleAtencion.precioPracticaConCobertura)
                cmd.Parameters.AddWithValue("@cantidad", oDetalleAtencion.cantidad)
                cmd.Parameters.AddWithValue("@subtotal", oDetalleAtencion.subtotal)
                status = cmd.ExecuteNonQuery()
            Next
            trans.Commit()
        Catch sqlEx As SqlClient.SqlException
            trans.Rollback()
            Throw sqlEx
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
        Return status
    End Function

    Private Sub txt_total_cc_TextChanged(sender As Object, e As EventArgs) Handles txt_total_cc.TextChanged
        Dim total As Double
        If txt_total_cc.Text <> String.Empty Then
            total = Convert.ToDouble(txt_total_cc.Text)
            txt_total.Text = total
        Else
            txt_total.Text = String.Empty
        End If
    End Sub

    Private Function mapToDetalleAtencion(row As DataGridViewRow) As DetalleAtencion
        Dim oDetalleAtencion As New DetalleAtencion
        With oDetalleAtencion
            .idPractica = Convert.ToInt16(row.Cells(0).Value.ToString())
            .precioPracticaSinCobertura = Convert.ToDouble(row.Cells(2).Value.ToString())
            .cobertura = Convert.ToInt16(row.Cells(3).Value.ToString())
            .precioPracticaConCobertura = Convert.ToDouble(row.Cells(4).Value.ToString())
            .cantidad = Convert.ToInt16(row.Cells(5).Value.ToString())
            .subtotal = Convert.ToDouble(row.Cells(6).Value.ToString())
        End With
        Return oDetalleAtencion
    End Function

    Private Sub dgv_practicas_DoubleClick(sender As Object, e As EventArgs) Handles dgv_practicas.DoubleClick
        If MsgBox("Está seguro que desea borrar esta fila de la grilla?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Importante") = MsgBoxResult.Yes Then
            Me.dgv_practicas.Rows.RemoveAt(Me.dgv_practicas.CurrentRow.Index)
            Me.txt_total_sc.Text = Me.calcularTotal(2)
            Me.txt_total_cc.Text = Me.calcularTotal(4)
        End If
    End Sub
End Class
