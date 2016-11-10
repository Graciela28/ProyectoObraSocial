Public Class Frm_registrar_Barrio
    Enum estado
        insertar
        modificar
    End Enum

    Public Property start_load = False
    Public Property num_Form As Integer = 0

    Dim accion As estado = estado.insertar
    Dim oTablaTipoService As New TablaTipoService
    Dim oLocalidadService As New LocalidadService
    Dim oBarrioService As New BarrioService

    Private Sub Frm_registrar_Barrio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (start_load = True) Then
            cbo_provincias.Enabled = True
            cbo_localidades.Enabled = True
            cargaCombo(Me.cbo_provincias, oTablaTipoService.ListarTipos("Provincias"), "id", "nombre")
            cbo_provincias.SelectedIndex = -1
        End If
    End Sub

    Private Sub cargaCombo(ByRef combo As ComboBox, ByVal datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Friend Sub cargarFiltros(ByVal sender As Object, ByVal idProvincia As Double, ByVal idLocalidad As Double)
        cargaCombo(Me.cbo_provincias, oTablaTipoService.ListarTipos("Provincias"), "id", "nombre")
        cbo_provincias.SelectedValue = idProvincia
        cbo_provincias_SelectionChangeCommitted(sender, Nothing)
        cbo_localidades.SelectedValue = idLocalidad
        cbo_provincias.Enabled = False
        cbo_localidades.Enabled = False
    End Sub

    Private Sub cbo_provincias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_provincias.SelectionChangeCommitted

        cbo_localidades.DataSource = oLocalidadService.getLocalidadesConFiltro(cbo_provincias.SelectedValue)
        If oLocalidadService.getLocalidadesConFiltro(cbo_provincias.SelectedValue).Rows.Count > 0 Then
            cbo_localidades.ValueMember = "id"
            cbo_localidades.DisplayMember = "nombre"
            cbo_localidades.SelectedIndex = -1
        Else
            MessageBox.Show("No hay localidades cargadas para " & cbo_provincias.SelectedItem("nombre").ToString, _
               "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
               , MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        If Me.start_load = False Then
            Select Case num_Form
                Case 1
                    frm_registrar_Afiliado.cbo_localidades_SelectionChangeCommitted(sender, Nothing)
                Case 2
                    frm_registrar_profesional.cbo_localidades_SelectionChangeCommitted(sender, Nothing)
                Case 3
                    frm_registrar_centroMedico.cbo_localidades_SelectionChangeCommitted(sender, Nothing)
            End Select
        End If
        Me.Close()
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        cbo_provincias.SelectedIndex = -1
        cbo_localidades.DataSource = Nothing
        cbo_localidades.Items.Clear()
        txt_barrio.Text = String.Empty
        dgv_barrios.Rows.Clear()
        Me.accion = estado.insertar
    End Sub

    Private Sub llenarGrilla(Optional ByVal lst As List(Of ConsultaDeBarrios) = Nothing)
        If IsNothing(lst) Then
            MessageBox.Show("No existen Barrios cargados para la Localidad Seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Me.dgv_barrios.Rows.Clear()

        For Each oConsultaDeBarrios In lst
            With oConsultaDeBarrios
                'cargar filas del datagridview a partir de un array de Strings
                dgv_barrios.Rows.Add(New String() {.idProvincia.ToString, .nombreProvincia.ToString, .idLocalidad.ToString, .nombreLocalidad.ToString, .idBarrio.ToString, .nombreBarrio.ToString})
            End With
        Next
        Me.dgv_barrios.ClearSelection()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim oConsultaDeBarrios As New ConsultaDeBarrios
        If cbo_provincias.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una provincia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If cbo_localidades.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una Localidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        oConsultaDeBarrios.idProvincia = cbo_provincias.SelectedValue
        oConsultaDeBarrios.idLocalidad = cbo_localidades.SelectedValue
        Me.llenarGrilla(oBarrioService.GetBarriosConFiltro(oConsultaDeBarrios))
        If dgv_barrios.Rows.Count = 0 Then
            MessageBox.Show("No existen barrios registrados para esa Localidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_Grabar_Click(sender As Object, e As EventArgs) Handles btn_Grabar.Click
        If cbo_provincias.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una provincia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If cbo_localidades.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una Localidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txt_barrio.Text = String.Empty Then
            MessageBox.Show("Debe ingresar el nombre del barrio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.accion = estado.insertar Then
            Dim oBarrio As New Barrio
            oBarrio.idLocalidad = cbo_localidades.SelectedValue
            oBarrio.nombre = txt_barrio.Text
            If (oBarrioService.registrarBarrio(oBarrio) = True) Then
                MessageBox.Show("Se registró el Barrio con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim oConsultaDeBarrios As New ConsultaDeBarrios
                oConsultaDeBarrios.idProvincia = cbo_provincias.SelectedValue
                oConsultaDeBarrios.idLocalidad = cbo_localidades.SelectedValue
                Me.llenarGrilla(oBarrioService.GetBarriosConFiltro(oConsultaDeBarrios))
                txt_barrio.Text = String.Empty
            Else
                MessageBox.Show("No se pudo registrar el barrio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Dim oBarrio As New Barrio
            oBarrio.id = txt_barrio.Tag
            oBarrio.nombre = txt_barrio.Text
            oBarrio.idLocalidad = cbo_localidades.SelectedValue
            If oBarrioService.actualizarBarrio(oBarrio) = True Then
                MessageBox.Show("El Barrio se actualizó con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim oConsultaDeBarrios As New ConsultaDeBarrios
                oConsultaDeBarrios.idProvincia = cbo_provincias.SelectedValue
                oConsultaDeBarrios.idLocalidad = cbo_localidades.SelectedValue
                Me.llenarGrilla(oBarrioService.GetBarriosConFiltro(oConsultaDeBarrios))
                txt_barrio.Text = String.Empty
            Else
                MessageBox.Show("No se pudo actualizar el Barrio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click

        If Not IsNothing(dgv_barrios.CurrentRow) Then
            Dim oBarrio As New Barrio
            oBarrio.id = Convert.ToInt16(dgv_barrios.CurrentRow.Cells(4).Value.ToString())
            oBarrio.nombre = dgv_barrios.CurrentRow.Cells(5).Value.ToString
            oBarrio.idLocalidad = Convert.ToInt16(dgv_barrios.CurrentRow.Cells(2).Value.ToString)
            If (oBarrioService.eliminarBarrio(oBarrio) = True) Then
                MessageBox.Show("Se eliminó el Barrio con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim oConsultaDeBarrios As New ConsultaDeBarrios
                oConsultaDeBarrios.idProvincia = cbo_provincias.SelectedValue
                oConsultaDeBarrios.idLocalidad = cbo_localidades.SelectedValue
                Me.llenarGrilla(oBarrioService.GetBarriosConFiltro(oConsultaDeBarrios))
            Else
                MessageBox.Show("No se pudo eliminar el Barrio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe seleccionar un Barrio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        If Not IsNothing(dgv_barrios.CurrentRow) Then
            cbo_provincias.SelectedValue = Convert.ToInt16(dgv_barrios.CurrentRow.Cells(0).Value.ToString)
            cbo_localidades.SelectedValue = Convert.ToInt16(dgv_barrios.CurrentRow.Cells(2).Value.ToString)
            txt_barrio.Text = dgv_barrios.CurrentRow.Cells(5).Value.ToString
            txt_barrio.Tag = Convert.ToInt16(dgv_barrios.CurrentRow.Cells(4).Value.ToString)
            Me.accion = estado.modificar
        Else
            MessageBox.Show("Debe seleccionar un Barrio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class