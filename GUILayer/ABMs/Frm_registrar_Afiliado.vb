
Public Class frm_registrar_Afiliado

    Enum termino
        aprobado
        rechazado
    End Enum
    Enum estado
        insertar
        modificar
    End Enum

    Dim oConsultaDeAfiliadoService As New ConsultaDeAfiliadoService
    Dim oAfiliadoService As New AfiliadoService
    Dim oLocalidadService As New LocalidadService
    Dim oBarrioService As New BarrioService
    Dim oPersonaService As New PersonaService

    Dim oTablaTipoService As New TablaTipoService

    'Creación de variable del tipo Enumeración 
    Dim accion As estado = estado.insertar

    'Variables auxiliares
    Dim row_selected As DataGridViewRow
    Dim tipo_documento_id As Integer
    Dim num_documento As Integer

    Private Sub frm_registrar_afiliado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Carga de combos  
        cargaCombo(Me.cbo_tipo_documento, oTablaTipoService.ListarTipos("TiposDocumento"), "id", "nombre")
        cargaCombo(Me.cbo_tipo_afiliado, oTablaTipoService.ListarTipos("TiposAfiliado"), "id", "nombre")
        cargaCombo(Me.cbo_provincias, oTablaTipoService.ListarTipos("Provincias"), "id", "nombre")
        Me.LimpiarCombos()

        'Carga de grilla  
        Me.llenarGrilla()
        dgv_afiliados.ClearSelection()

        'Estado inicial de los controles 
        Me.deshabilitarControles()
        Me.deshabilitarBotones()
    End Sub

    Private Sub deshabilitarBotones()
        btn_Grabar.Enabled = False
        btn_Eliminar.Enabled = False
        btn_Modificar.Enabled = False
    End Sub

    Private Sub LimpiarCombos()
        cbo_tipo_documento.SelectedIndex = -1
        cbo_tipo_afiliado.SelectedIndex = -1
        cbo_provincias.SelectedIndex = -1
    End Sub

    Private Sub cargaCombo(ByRef combo As ComboBox, ByVal datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Private Sub llenarGrilla(Optional ByVal lst As List(Of ConsultaDeAfiliado) = Nothing)
        Dim activo_grilla As String
        Dim empresa_grilla As String
        Dim mail_grilla As String
        Dim telefono_grilla As String

        If IsNothing(lst) Then
            lst = oConsultaDeAfiliadoService.getAllAfiliados()
        End If

        Me.dgv_afiliados.Rows.Clear()

        For Each oConsultaDeAfiliado In lst
            With oConsultaDeAfiliado
                If (.activo = False) Then
                    activo_grilla = "No"
                Else
                    activo_grilla = "Si"
                End If
                If (String.IsNullOrEmpty(.empresaConvenio)) Then
                    empresa_grilla = " - "
                Else
                    empresa_grilla = .empresaConvenio.ToString
                End If
                If (String.IsNullOrEmpty(.mailAfiliado)) Then
                    mail_grilla = " - "
                Else
                    mail_grilla = .mailAfiliado.ToString
                End If
                If (.telefono = 0) Then
                    telefono_grilla = " - "
                Else
                    telefono_grilla = .telefono.ToString
                End If
                'cargar filas del datagridview a partir de un array de Strings
                dgv_afiliados.Rows.Add(New String() {.idTipoDoc.ToString, .nombreTipoDocumento.ToString, .numeroDoc.ToString, .apellidoAfiliado + ", " + .nombreAfiliado, oAfiliadoService.calcularEdad(oConsultaDeAfiliado).ToString, telefono_grilla, mail_grilla, .calle + ", " + .numero.ToString, .nombreBarrio, .nombreLocalidad, .nombreProvincia, .nombreTipoAfiliado, empresa_grilla, activo_grilla, .activo.ToString})
            End With
        Next
        Me.dgv_afiliados.ClearSelection()
    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        lbl_nro_documento.BackColor = Color.CornflowerBlue
        lbl_tipo_documento.BackColor = Color.CornflowerBlue

        Me.LimpiarCampos()
        Me.habilitarControles()
        Me.btn_Grabar.Enabled = True
        Me.txt_nombre.Focus()
        Me.accion = estado.insertar
    End Sub

    Private Sub dgv_afiliados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_afiliados.CellClick
        row_selected = dgv_afiliados.CurrentRow
        btn_Eliminar.Enabled = True
        btn_Modificar.Enabled = True
    End Sub

    Private Function insertarNuevoAfiliado() As termino

        Dim oAfiliado As New ConsultaDeAfiliado
        Dim oDomicilioService As New DomicilioService

        With oAfiliado
            .idTipoDoc = Integer.Parse(cbo_tipo_documento.SelectedValue)
            .numeroDoc = Integer.Parse(txt_nro_documento.Text)
            .nombreAfiliado = txt_nombre.Text
            .apellidoAfiliado = txt_apellido.Text
            .fechaNacimiento = dtp_fecha.Value.ToString("dd/MM/yyyy")
            .activo = True
            .idTipoAfil = cbo_tipo_afiliado.SelectedValue
            .id_domicilio = oDomicilioService.generarCodigoDomicilio()
            .calle = txt_direccion.Text
            .numero = txt_altura.Text
            .codBarrio = cbo_barrios.SelectedValue
            If String.IsNullOrEmpty(txt_telefono.Text) = True Then
                .telefono = 0
            Else
                .telefono = Integer.Parse(txt_telefono.Text)
            End If
            .mailAfiliado = txt_mail.Text
        End With

        If oAfiliadoService.registrarAfiliado(oAfiliado) = True Then
            Return termino.aprobado
        Else
            Return termino.rechazado
        End If
    End Function

    

    Private Sub LimpiarCampos()
        Me.txt_nombre.Text = ""
        Me.txt_apellido.Text = ""
        Me.txt_nro_documento.Text = ""
        Me.cbo_tipo_afiliado.Text = ""
        Me.txt_telefono.Text = ""
        Me.txt_mail.Text = ""
        Me.txt_calle.Text = ""
        Me.txt_altura.Text = ""
        Me.cbo_tipo_afiliado.SelectedIndex = -1
        Me.cbo_tipo_documento.SelectedIndex = -1
        Me.cbo_provincias.SelectedIndex = -1
        Me.cbo_localidades.SelectedIndex = -1
        Me.cbo_barrios.SelectedIndex = -1
    End Sub

    Private Sub txt_mail_Validated(sender As Object, e As EventArgs) Handles txt_mail.Validated
        If Me.ValidateEmail(txt_mail.Text) = False Then
            MsgBox("El mail no tiene el formato correcto.", MsgBoxStyle.Critical, "Importante")
            Exit Sub
        End If
    End Sub

    Private Sub txt_nro_documento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nro_documento.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 13, 9, 15, 14
                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Este carater no es un numero ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 13, 9, 15, 14
                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Este carater no es un numero ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txt_altura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_altura.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 13, 9, 15, 14
                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Este carater no es un numero ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    'Private Sub mtxt_fecha_nac_Validated(sender As Object, e As EventArgs)
    '    If IsDate(sender.Text) Then
    '        If Not sender.Text = Format(CDate(sender.text), "dd/mm/yyyy") Then
    '        Else
    '            MsgBox("Fecha invalida", vbOKOnly + vbCritical, "Atención")
    '            sender.Focus()
    '            Exit Sub
    '        End If
    '    Else
    '        MsgBox("Fecha invalida", vbOKOnly + vbCritical, "Atención")
    '        sender.Focus()
    '        Exit Sub
    '    End If
    'End Sub

    Private Sub cmd_Salir_Click(sender As Object, e As EventArgs) Handles cmd_Salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_Grabar_Click(sender As Object, e As EventArgs) Handles btn_Grabar.Click
        If Me.validarCamposObligatorios() = True Then
            If Me.accion = estado.insertar Then
                tipo_documento_id = Integer.Parse(cbo_tipo_documento.SelectedValue)
                num_documento = Integer.Parse(txt_nro_documento.Text)

                If Me.validarExistenciaAfiliado() = termino.aprobado Then
                    If Me.validarExistenciaPersona() = termino.aprobado Then
                        If Me.insertarNuevoAfiliado() = termino.aprobado Then
                            MessageBox.Show("Se grabó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.llenarGrilla()
                            Me.LimpiarCampos()
                        Else
                            MessageBox.Show("Hubo un error en el registro del Afiliado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.LimpiarCampos()
                        End If
                    Else
                        MessageBox.Show("Ya se encuentra registrada una persona con ese tipo y nro de documento", _
                                    "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'Llenar los campos con los datos de esa persona 
                    End If
                Else
                    MessageBox.Show("Ya se encuentra registrado un Afiliado con ese nro de documento", _
                                    "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                tipo_documento_id = Integer.Parse(Me.dgv_afiliados.CurrentRow.Cells.Item("col_idTipoDoc").Value.ToString)
                num_documento = Integer.Parse(Me.dgv_afiliados.CurrentRow.Cells.Item("col_documento").Value.ToString)

                If Me.actualizarAfiliado(num_documento, tipo_documento_id) = termino.aprobado Then
                    MessageBox.Show("Se modificó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Hubo un error en la actualización", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        End If
    End Sub

    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function


    Private Function validarExistenciaPersona() As termino
        If (oPersonaService.validarExistencia(tipo_documento_id, num_documento) = True) Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function validarExistenciaAfiliado() As termino
        If (oAfiliadoService.validarExistenciaAfiliado(tipo_documento_id, num_documento) = True) Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function actualizarAfiliado(ByVal documento As Integer, ByVal tipo As Integer) As termino
        Dim oAfiliado As New ConsultaDeAfiliado
        Dim oDomicilioService As New DomicilioService
        With oAfiliado
            .idTipoDoc = Integer.Parse(cbo_tipo_documento.SelectedValue)
            .numeroDoc = Integer.Parse(txt_nro_documento.Text)
            .nombreAfiliado = txt_nombre.Text
            .apellidoAfiliado = txt_apellido.Text
            .fechaNacimiento = dtp_fecha.Value.ToString("dd/MM/yyyy")
            .activo = True
            .idTipoAfil = cbo_tipo_afiliado.SelectedValue
            .calle = txt_calle.Text
            .numero = txt_altura.Text
            .codBarrio = cbo_barrios.SelectedValue
            If String.IsNullOrEmpty(txt_telefono.Text) = True Then
                .telefono = 0
            Else
                .telefono = Convert.ToInt32(txt_telefono.Text)
            End If

            .mailAfiliado = txt_mail.Text
            .empresaConvenio = txt_empresa.Text
        End With
        oAfiliadoService.actualizarAfiliado(num_documento, tipo_documento_id, oAfiliado)
        Return termino.aprobado
    End Function

    Private Sub cbo_provincias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_provincias.SelectionChangeCommitted
        'Estado inicial del combo barrios
        cbo_barrios.SelectedIndex = -1

        cbo_localidades.DataSource = oLocalidadService.getLocalidadesConFiltro(cbo_provincias.SelectedValue)
        If oLocalidadService.getLocalidadesConFiltro(cbo_provincias.SelectedValue).Rows.Count > 0 Then
            cbo_localidades.ValueMember = "id"
            cbo_localidades.DisplayMember = "nombre"
        Else
            MessageBox.Show("No hay localidades cargadas para " & cbo_provincias.SelectedItem("nombre").ToString, _
               "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
               , MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub cbo_localidades_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_localidades.SelectionChangeCommitted
        cbo_barrios.DataSource = oBarrioService.GetBarriosConFiltro(cbo_localidades.SelectedValue)
        If oBarrioService.GetBarriosConFiltro(cbo_localidades.SelectedValue).Rows.Count > 0 Then
            cbo_barrios.ValueMember = "id_barrio"
            cbo_barrios.DisplayMember = "nombre"
        Else
            MessageBox.Show("No hay barrios cargados para " & cbo_localidades.SelectedItem("nombre").ToString, _
               "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation _
               , MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub cmd_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        tipo_documento_id = Integer.Parse(Me.dgv_afiliados.CurrentRow.Cells.Item("col_idTipoDoc").Value.ToString)
        num_documento = Integer.Parse(Me.dgv_afiliados.CurrentRow.Cells.Item("col_documento").Value.ToString)

        Dim lista As New List(Of ConsultaDeAfiliado)
        lista = oAfiliadoService.listarAfiliadosConFiltros(tipo_documento_id, num_documento)
        Me.habilitarControles()

        For Each oAfiliado In lista
            With oAfiliado
                txt_nombre.Text = oAfiliado.nombreAfiliado
                txt_apellido.Text = oAfiliado.apellidoAfiliado
                txt_nro_documento.Text = oAfiliado.numeroDoc.ToString
                cbo_tipo_documento.SelectedValue = oAfiliado.idTipoDoc.ToString
                dtp_fecha.Value = oAfiliado.fechaNacimiento.ToString
                cbo_tipo_afiliado.SelectedValue = oAfiliado.idTipoAfil.ToString
                txt_telefono.Text = oAfiliado.telefono.ToString
                txt_mail.Text = oAfiliado.mailAfiliado
                txt_calle.Text = oAfiliado.calle
                txt_altura.Text = oAfiliado.numero.ToString
                cbo_provincias.SelectedValue = oAfiliado.idProvincia
                cbo_provincias_SelectionChangeCommitted(sender, Nothing)
                cbo_localidades.SelectedValue = oAfiliado.idLocalidad
                cbo_localidades_SelectionChangeCommitted(sender, Nothing)
                cbo_barrios.SelectedValue = oAfiliado.codBarrio
            End With
        Next
        btn_Grabar.Enabled = True
        Me.accion = estado.modificar
    End Sub

    Private Sub cmd_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim activo As Boolean = Convert.ToBoolean(dgv_afiliados.CurrentRow.Cells("col_estaActivo").Value)
        Dim oAfiliado As New ConsultaDeAfiliado

        With oAfiliado
            .idTipoDoc = Integer.Parse(dgv_afiliados.CurrentRow.Cells("col_idTipoDoc").Value)
            .numeroDoc = Integer.Parse(dgv_afiliados.CurrentRow.Cells("col_documento").Value)
        End With

        If (activo = True) Then

            If MessageBox.Show("El afiliado [" & dgv_afiliados.CurrentRow.Cells.Item("col_nombre").Value.ToString & "] se encuentra activo. ¿Desea darlo de BAJA?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                oAfiliadoService.registrarBaja(oAfiliado)
                MessageBox.Show("Se eliminó el afiliado con éxito!", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.llenarGrilla()
            End If
        Else
            MessageBox.Show("El Afiliado ya se encuentra inactivo", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Me.deshabilitarControles()
        'Me.LimpiarCampos()
        Dim oAfiliadoService As New AfiliadoService
        Dim tipo_documento As Integer = -1

        If cbo_tipo_documento.SelectedIndex <> -1 Then tipo_documento = cbo_tipo_documento.SelectedValue
        If txt_nro_documento.Text = "" Then
            MessageBox.Show("No se pudo realizar la búsqueda. Ingrese un documento", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lbl_nro_documento.BackColor = Color.AntiqueWhite
            lbl_tipo_documento.BackColor = Color.AntiqueWhite
            txt_nro_documento.Focus()
            Exit Sub
        Else
            lbl_nro_documento.BackColor = Color.CornflowerBlue
            lbl_tipo_documento.BackColor = Color.CornflowerBlue
            Dim documento As Integer = txt_nro_documento.Text

            Me.llenarGrilla(oAfiliadoService.listarAfiliadosConFiltros(tipo_documento, documento))
            If (dgv_afiliados.Rows.Count > 0) Then
                MessageBox.Show("La Búsqueda se realizó con exito!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se encontró ningún Afiliado con ese documento", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If


    End Sub

    Private Sub deshabilitarControles()
        txt_nombre.Enabled = False
        txt_apellido.Enabled = False
        dtp_fecha.Enabled = False
        cbo_tipo_afiliado.Enabled = False
        txt_empresa.Enabled = False
        txt_telefono.Enabled = False
        txt_mail.Enabled = False
        txt_calle.Enabled = False
        txt_altura.Enabled = False
        cbo_provincias.Enabled = False
        cbo_localidades.Enabled = False
        cbo_barrios.Enabled = False
    End Sub

    Private Sub habilitarControles()
        txt_nombre.Enabled = True
        txt_apellido.Enabled = True
        txt_nro_documento.Enabled = True
        cbo_tipo_documento.Enabled = True
        dtp_fecha.Enabled = True
        cbo_tipo_afiliado.Enabled = True
        txt_empresa.Enabled = True
        txt_telefono.Enabled = True
        txt_mail.Enabled = True
        txt_calle.Enabled = True
        txt_altura.Enabled = True
        cbo_provincias.Enabled = True
        cbo_localidades.Enabled = True
        cbo_barrios.Enabled = True
    End Sub

    Private Sub Cbo_Tipo_Afiliado_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim consulta As String = ""
        Dim id As Integer

        Dim row As DataRowView = DirectCast(cbo_tipo_afiliado.SelectedItem, DataRowView)
        If row Is Nothing Then
        Else
            id = CInt(row.Item("id"))
            consulta = "select T.id, T.nombre from TiposAfiliado T '" & id & "'"

            Dim tabla As New Data.DataTable
            tabla = BDHelper.ConsultaSQL(consulta)

            cbo_tipo_afiliado.SelectedIndex = -1
            cbo_tipo_afiliado.DataSource = tabla
            If tabla.Rows.Count > 0 Then
                cbo_tipo_afiliado.ValueMember = "id"
                cbo_tipo_afiliado.DisplayMember = "nombre"
            End If
        End If
    End Sub

    Private Sub dgv_afiliados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_afiliados.CellDoubleClick

        Dim activo As Boolean = Convert.ToBoolean(dgv_afiliados.CurrentRow.Cells("col_estaActivo").Value)
        Dim oAfiliado As New ConsultaDeAfiliado

        With oAfiliado
            .idTipoDoc = Integer.Parse(dgv_afiliados.CurrentRow.Cells("col_idTipoDoc").Value)
            .numeroDoc = Integer.Parse(dgv_afiliados.CurrentRow.Cells("col_documento").Value)
        End With

        If (activo = False) Then

            If MessageBox.Show("El afiliado [" & dgv_afiliados.CurrentRow.Cells.Item("col_nombre").Value.ToString & "] se encuentra inactivo. ¿Desea darlo de ALTA?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                oAfiliadoService.registrarAlta(oAfiliado)
                MessageBox.Show("El Afiliado se dio de ALTA con exito!", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.llenarGrilla()
            End If
        Else
            MessageBox.Show("El Afiliado ya se encuentra ACTIVO", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Function validarCamposObligatorios() As Boolean
        Dim campos_completos As Boolean = True
        Dim mensajeAdvertencia As String = ""

        If txt_nombre.Text = "" Then
            lbl_nombre.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_nombre.ForeColor = Color.Black
        End If
        If txt_apellido.Text = "" Then
            lbl_apellido.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_apellido.ForeColor = Color.Black
        End If
        If txt_nro_documento.Text = "" Then
            lbl_nro_documento.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_nro_documento.ForeColor = Color.Black
        End If

        If dtp_fecha.Value = Now.ToString("dd/MM/yyyy") Then
            lbl_fecha_nac.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_fecha_nac.ForeColor = Color.Black
        End If
       
        If txt_calle.Text = "" Then
            lbl_direccion.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_direccion.ForeColor = Color.Black
        End If

        If txt_altura.Text = "" Then
            lbl_numero.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_numero.ForeColor = Color.Black
        End If

        If cbo_tipo_documento.SelectedIndex = -1 Then
            lbl_tipo_documento.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_tipo_documento.ForeColor = Color.Black
        End If
        If cbo_tipo_afiliado.SelectedIndex = -1 Then
            lbl_TipoAfiliado.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_TipoAfiliado.ForeColor = Color.Black
        End If
        If cbo_provincias.SelectedIndex = -1 Then
            lbl_Provincia.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_Provincia.ForeColor = Color.Black
        End If

        If cbo_localidades.SelectedIndex = -1 Then
            lbl_localidad.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_localidad.ForeColor = Color.Black
        End If

        If cbo_barrios.SelectedIndex = -1 Then
            lbl_barrio.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_barrio.ForeColor = Color.Black
        End If

        If campos_completos = False Then
            mensajeAdvertencia = "Algunos campos no pueden estar vacíos. "
        End If

        If txt_mail.Text <> String.Empty Then
            If ValidateEmail(txt_mail.Text) = False Then
                campos_completos = False
                mensajeAdvertencia += "El mail no tiene el formato correcto! "
            End If
        End If

        If campos_completos = False Or ValidateEmail(txt_mail.Text) = False Then
            MsgBox(mensajeAdvertencia, MsgBoxStyle.Exclamation, "Importante")
        End If
        Return campos_completos
    End Function

    Private Sub frm_registrar_afiliado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Visible = False
    End Sub
End Class