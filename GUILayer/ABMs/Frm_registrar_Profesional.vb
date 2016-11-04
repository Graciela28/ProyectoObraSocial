
Public Class frm_registrar_profesional

    Enum termino
        aprobado
        rechazado
    End Enum
    Enum estado
        insertar
        modificar
    End Enum

    Dim oConsultaDeProfesionalService As New ConsultaDeProfesionalService
    Dim oProfesionalService As New ProfesionalService
    Dim oTablaTipoService As New TablaTipoService
    Dim oLocalidadService As New LocalidadService
    Dim oBarrioService As New BarrioService

    'Clave foránea 
    Dim oPersonaService As New PersonaService

    'Creación de variable del tipo Enumeración 
    Dim accion As estado = estado.insertar

    Dim stringConexion As String = BDHelper.string_conexion
    Dim cod_domicilio As Integer = 1
    Dim row_selected As DataGridViewRow
    Dim tipo_documento_id As Integer
    Dim num_documento As Integer

    Private Sub frm_ABM_Profesional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        'Carga de combos 
        cargaCombo(Me.cbo_tipo_documento, oTablaTipoService.listarTipos("TiposDocumento"), "id", "nombre")
        cargaCombo(Me.cbo_provincias, oTablaTipoService.listarTipos("Provincias"), "id", "nombre")
        Me.LimpiarCombos()
        
       
        Me.cargaGrilla()
        dgv_profesionales.ClearSelection()
       
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
        cbo_provincias.SelectedIndex = -1
    End Sub

    Private Sub cargaCombo(ByRef combo As ComboBox, ByVal datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Private Sub cargaGrilla(Optional ByVal lst As List(Of ConsultaDeProfesional) = Nothing)
        Dim activo_grilla As String
        Dim mail_grilla As String
        Dim telefono_grilla As String

        If IsNothing(lst) Then
            lst = oConsultaDeProfesionalService.getAllProfesionales()
        End If

        Me.dgv_profesionales.Rows.Clear()

        For Each oConsultaDeAfiliado In lst
            With oConsultaDeAfiliado
                If (.activo = False) Then
                    activo_grilla = "No"
                Else
                    activo_grilla = "Si"
                End If
               
                If (String.IsNullOrEmpty(.mailProfesional)) Then
                    mail_grilla = " - "
                Else
                    mail_grilla = .mailProfesional.ToString
                End If
                If (.telefono = 0) Then
                    telefono_grilla = " - "
                Else
                    telefono_grilla = .telefono.ToString
                End If
                'cargar filas del datagridview a partir de un array de Strings
                dgv_profesionales.Rows.Add(New String() {.idTipoDoc.ToString, .nombreTipoDocumento.ToString, .numeroDoc.ToString, .matricula.ToString, .apellidoProfesional + ", " + .nombreProfesional, oProfesionalService.calcularEdad(oConsultaDeAfiliado).ToString, telefono_grilla, mail_grilla, .calle + ", " + .numero.ToString, .nombreBarrio, .nombreLocalidad, .nombreProvincia, activo_grilla, .activo.ToString})
            End With
        Next
        Me.dgv_profesionales.ClearSelection()
    End Sub

    Private Sub cbo_provincias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_provincias.SelectionChangeCommitted
        'Blanqueo el combo barrios porque la seleccion empieza de nuevo 
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

    Private Sub dgv_profesionales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_profesionales.CellClick
        row_selected = dgv_profesionales.CurrentRow
        btn_Modificar.Enabled = True
        btn_Eliminar.Enabled = True
    End Sub
    Private Function insertarNuevoProfesional() As termino
        Dim oProfesional As New ConsultaDeProfesional
        Dim oDomicilioService As New DomicilioService
        Me.generarCodigoDomicilio()
        With oProfesional
            .matricula = Convert.ToInt64(txt_matricula.Text)
            .idTipoDoc = Integer.Parse(cbo_tipo_documento.SelectedValue)
            .numeroDoc = Integer.Parse(txt_nro_documento.Text)
            .nombreProfesional = txt_nombre.Text
            .apellidoProfesional = txt_apellido.Text
            .fechaNacimiento = dtp_fecha.Value.ToString("dd/MM/yyyy")
            .id_domicilio = oDomicilioService.generarCodigoDomicilio()
            .activo = True
            .calle = txt_direccion.Text
            .numero = Convert.ToInt16(txt_altura.Text)
            .codBarrio = cbo_barrios.SelectedValue
            If String.IsNullOrEmpty(txt_telefono.Text) = True Then
                .telefono = 0
            Else
                .telefono = Integer.Parse(txt_telefono.Text)
            End If
            .mailProfesional = txt_mail.Text
        End With

        If oProfesionalService.registrarProfesional(oProfesional) = True Then
            Return termino.aprobado
        Else
            Return termino.rechazado
        End If
    End Function

    Private Sub generarCodigoDomicilio()
        Dim tabla As New Data.DataTable
        tabla = BDHelper.ConsultaSQL("select * from Domicilios")

        If tabla.Rows.Count > 0 Then

            tabla = BDHelper.ConsultaSQL("select max(id_domicilio) as codigoDomicilio from Domicilios")
            If tabla.Rows.Count > 0 Then
                Me.cod_domicilio = CInt(tabla.Rows(0)("codigoDomicilio").ToString) + 1
            End If
        Else
            cod_domicilio = 1000
        End If
    End Sub

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Me.LimpiarCampos()
        Me.habilitarControles()
        Me.btn_Grabar.Enabled = True
        Me.txt_nombre.Focus()
        Me.accion = estado.insertar
    End Sub

    Private Sub LimpiarCampos()
        Me.txt_nombre.Text = ""
        Me.txt_apellido.Text = ""
        Me.txt_nro_documento.Text = ""
        Me.txt_matricula.Text = ""
        Me.txt_telefono.Text = ""
        Me.txt_mail.Text = ""
        Me.txt_calle.Text = ""
        Me.txt_altura.Text = ""

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

    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
           emailRegex.Match(email)
        Return emailMatch.Success
    End Function

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

        If txt_matricula.Text = "" Then
            lbl_matricula.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_matricula.ForeColor = Color.Black
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

    Private Sub txt_matricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_matricula.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 13, 9, 15, 14
                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Este caracter no es un numero ( " + e.KeyChar + " )", vbCritical, "Importante")
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


    Private Sub mtxt_fecha_nac_Validated(sender As Object, e As EventArgs)
        If IsDate(sender.Text) Then
            If Not sender.Text = Format(CDate(sender.text), "dd/mm/yyyy") Then
            Else
                MsgBox("Fecha invalida", vbOKOnly + vbCritical, "Atención")
                sender.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Fecha invalida", vbOKOnly + vbCritical, "Atención")
            sender.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub cmd_Grabar_Click(sender As Object, e As EventArgs) Handles btn_Grabar.Click
        If Me.validarCamposObligatorios() = True Then
            If Me.accion = estado.insertar Then
                tipo_documento_id = Integer.Parse(cbo_tipo_documento.SelectedValue)
                num_documento = Integer.Parse(txt_nro_documento.Text)
                If Me.validarExistenciaProfesional() = termino.aprobado Then
                    If Me.validarExistenciaPersona() = termino.aprobado Then
                        If Me.validarExistenciaMatricula() = termino.aprobado Then
                            If Me.insertarNuevoProfesional() = termino.aprobado Then
                                MessageBox.Show("Se grabó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.cargaGrilla()
                                Me.LimpiarCampos()
                            Else
                                MessageBox.Show("Hubo un error al registrar el Profesional", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.LimpiarCampos()
                            End If
                        Else
                            MessageBox.Show("Esa matrícula ya se encuentra registrada", _
                                    "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        'MessageBox.Show("Ya se encuentra registrada una persona con ese tipo y nro de documento", _
                        '          "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'If Me.validarExistenciaMatricula() = termino.aprobado Then
                        '    Me.insertarNuevoProfesional()
                        '    MessageBox.Show("Se grabó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Else
                        '    MessageBox.Show("Esa matrícula ya se encuentra registrada", _
                        '            "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        'End If
                    End If
                Else
                    MessageBox.Show("Ya se encuentra registrado un profesional con ese tipo y nro de documento", _
                                    "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                Dim id As Integer
                Dim row As DataRowView = DirectCast(cbo_tipo_documento.SelectedItem, DataRowView)
                If row Is Nothing Then
                Else
                    id = CInt(row.Item("id"))
                    Me.modificar(txt_nro_documento.Text, id)
                    MessageBox.Show("Se modificó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            Me.cargaGrilla()
        End If
    End Sub

    'valida que no exista una profesional con el tipo y número de documento ingresado
    Private Function validarExistenciaProfesional() As termino
        If (oProfesionalService.validarExistenciaProfesional(tipo_documento_id, num_documento) = True) Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function
   
    'Valida que la matricula ingresada no esté registrada
    Private Function validarExistenciaMatricula() As termino
        If (oProfesionalService.validarExistenciaMatricula(txt_matricula.Text) = True) Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    'Valida que no exista una persona con el nro y tipo de documento ingresado 
    Private Function validarExistenciaPersona() As termino
        If (oPersonaService.validarExistencia(tipo_documento_id, num_documento) = True) Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function modificar(ByVal documento As Integer, ByVal tipo As Integer) As termino
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand

        connection.ConnectionString = Me.stringConexion
        connection.Open()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "stpro_modificar_profesional"
        command.Connection = connection
        Dim tipoDocumento As Integer
        Dim barrio As Integer
        Dim row As DataRowView = DirectCast(cbo_tipo_documento.SelectedItem, DataRowView)
        If row Is Nothing Then
        Else
            tipoDocumento = CInt(row.Item("id"))
        End If
        Dim row2 As DataRowView = DirectCast(cbo_barrios.SelectedItem, DataRowView)
        If row2 Is Nothing Then
        Else
            barrio = CInt(row2.Item("id_barrio"))
        End If
        command.Parameters.AddWithValue("@numeroDocumentoA", documento)
        command.Parameters.AddWithValue("@tipoDocumentoA", tipo)
        command.Parameters.AddWithValue("@matricula", txt_matricula.Text)
        command.Parameters.AddWithValue("@tipoDocumento", tipoDocumento)
        command.Parameters.AddWithValue("@numeroDocumento", txt_nro_documento.Text)
        command.Parameters.AddWithValue("@nombre", txt_nombre.Text)
        command.Parameters.AddWithValue("@apellido", txt_apellido.Text)
        command.Parameters.AddWithValue("@fechaNacimiento", dtp_fecha.Value.ToString("MM/dd/yyyy"))
        command.Parameters.AddWithValue("@codDomicilio", cod_domicilio)
        command.Parameters.AddWithValue("@calle", txt_calle.Text)
        command.Parameters.AddWithValue("@numero", txt_altura.Text)
        command.Parameters.AddWithValue("@barrio", barrio)
        command.Parameters.AddWithValue("@telefono", txt_telefono.Text)
        command.Parameters.AddWithValue("@mail", txt_mail.Text)
        command.ExecuteNonQuery()
        connection.Close()
        Return termino.aprobado
    End Function

   

    Private Sub cmd_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click

        Dim documento As Integer = Me.dgv_profesionales.CurrentRow.Cells(0).Value
        Me.accion = estado.modificar
        Dim tabla As New Data.DataTable
        Dim connection As New Data.OleDb.OleDbConnection
        Dim command As New Data.OleDb.OleDbCommand
        connection.ConnectionString = Me.stringConexion
        connection.Open()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "stpro_consultar_profesional"
        command.Connection = connection
        command.Parameters.AddWithValue("@documento", documento)
        tabla.Load(command.ExecuteReader())
        connection.Close()

        txt_nombre.Text = tabla.Rows(0)("nombre")
        txt_apellido.Text = tabla.Rows(0)("apellido")
        txt_nro_documento.Text = tabla.Rows(0)("numero_doc")
        cbo_tipo_documento.SelectedValue = tabla.Rows(0)("id_tipo_doc")
        dtp_fecha.Value = tabla.Rows(0)("fecha_nacimiento")
        txt_matricula.Text = tabla.Rows(0)("matricula")
        txt_telefono.Text = tabla.Rows(0)("telefono")
        txt_mail.Text = tabla.Rows(0)("mail")
        txt_calle.Text = tabla.Rows(0)("calle")
        txt_altura.Text = tabla.Rows(0)("numero")
        cbo_provincias.SelectedValue = tabla.Rows(0)("id")
        cbo_localidades.SelectedValue = tabla.Rows(0)("id_localidad")
        cbo_barrios.SelectedValue = tabla.Rows(0)("id_barrio")
        Me.habilitarControles()
        txt_nro_documento.Enabled = False
        cbo_tipo_documento.Enabled = False
    End Sub

    Private Sub cmd_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim documento As Integer = Me.dgv_profesionales.CurrentRow.Cells(0).Value
        Me.accion = estado.modificar
        Dim tabla As New Data.DataTable

        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        connection.ConnectionString = Me.stringConexion
        connection.Open()
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "stpro_consultar_profesional"
        command.Connection = connection
        command.Parameters.AddWithValue("@documento", documento)
        tabla.Load(command.ExecuteReader())
        connection.Close()

        txt_nombre.Text = tabla.Rows(0)("nombre")
        txt_apellido.Text = tabla.Rows(0)("apellido")
        txt_nro_documento.Text = tabla.Rows(0)("numero_doc")
        cbo_tipo_documento.SelectedValue = tabla.Rows(0)("id_tipo_doc")
        dtp_fecha.Value = tabla.Rows(0)("fecha_nacimiento")
        txt_matricula.Text = tabla.Rows(0)("matricula")
        txt_telefono.Text = tabla.Rows(0)("telefono")
        txt_mail.Text = tabla.Rows(0)("mail")
        txt_calle.Text = tabla.Rows(0)("calle")
        txt_altura.Text = tabla.Rows(0)("numero")
        cbo_provincias.SelectedValue = tabla.Rows(0)("id")
        cbo_localidades.SelectedValue = tabla.Rows(0)("id_localidad")
        cbo_barrios.SelectedValue = tabla.Rows(0)("id_barrio")
        txt_nro_documento.Enabled = False
        cbo_tipo_documento.Enabled = False
        Dim msg As String = "Está seguro que desea eliminar el Profesional con dni = " & documento.ToString
        Dim rpta As Integer
        rpta = MsgBox(msg, vbOKCancel, "Confirmación")
        If rpta = 1 Then
            connection.ConnectionString = Me.stringConexion
            connection.Open()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_eliminar_profesional"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@numerodocumentoE", documento)
            command.Parameters.AddWithValue("@tipoDocumentoE", tabla.Rows(0)("id_tipo_doc"))
            command.Parameters.AddWithValue("@activo", 0)
            command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Se eliminó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cargaGrilla()
        Else
            End
        End If

    End Sub

    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If txt_nro_documento.Text = "" Then
            MessageBox.Show("No se pudo realizar la búsqueda. Ingrese un documento", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim documento As Integer = txt_nro_documento.Text
            Dim tabla As New Data.DataTable
            Dim connection As New SqlClient.SqlConnection
            Dim command As New SqlClient.SqlCommand
            connection.ConnectionString = Me.stringConexion
            connection.Open()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "stpro_consultar_profesional"
            command.Connection = connection
            command.Parameters.AddWithValue("@documento", documento)
            tabla.Load(command.ExecuteReader())
            connection.Close()
            If tabla.Rows.Count > 0 Then
                txt_nombre.Text = tabla.Rows(0)("nombre")
                txt_apellido.Text = tabla.Rows(0)("apellido")
                txt_nro_documento.Text = tabla.Rows(0)("numero_doc")
                cbo_tipo_documento.SelectedValue = tabla.Rows(0)("id_tipo_doc")
                dtp_fecha.Value = tabla.Rows(0)("fecha_nacimiento")
                txt_matricula.Text = tabla.Rows(0)("matricula")
                txt_telefono.Text = tabla.Rows(0)("telefono")
                txt_mail.Text = tabla.Rows(0)("mail")
                txt_calle.Text = tabla.Rows(0)("calle")
                txt_altura.Text = tabla.Rows(0)("numero")
                cbo_provincias.SelectedValue = tabla.Rows(0)("id")
                cbo_localidades.SelectedValue = tabla.Rows(0)("id_localidad")
                cbo_barrios.SelectedValue = tabla.Rows(0)("id_barrio")
                Dim activo As Integer = tabla.Rows(0)("activo")
                Me.deshabilitarControles()
                If activo = 0 Then
                    Dim msg As String = "El Profesional se encuentra inactivo. ¿Desea volver a activar el Profesional con dni = " & txt_nro_documento.Text & " ?"
                    Dim rpta As Integer
                    rpta = MsgBox(msg, vbOKCancel, "Confirmación")
                    If rpta = 1 Then
                        connection.ConnectionString = Me.stringConexion
                        connection.Open()
                        command.CommandType = CommandType.StoredProcedure
                        command.CommandText = "stpro_eliminar_profesional"
                        command.Parameters.Clear()
                        command.Parameters.AddWithValue("@numerodocumentoE", documento)
                        command.Parameters.AddWithValue("@tipoDocumentoE", tabla.Rows(0)("id_tipo_doc"))
                        command.Parameters.AddWithValue("@activo", 1)
                        command.ExecuteNonQuery()
                        connection.Close()
                        MessageBox.Show("Se activó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.cargaGrilla()
                    End If
                End If
            Else
                MessageBox.Show("No se encontró un profesional con ese documento", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If


    End Sub

    Private Sub deshabilitarControles()
        txt_nombre.Enabled = False
        txt_apellido.Enabled = False
        txt_nro_documento.Enabled = False
        cbo_tipo_documento.Enabled = False
        dtp_fecha.Enabled = False
        txt_matricula.Enabled = False
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
        txt_matricula.Enabled = True
        txt_telefono.Enabled = True
        txt_mail.Enabled = True
        txt_calle.Enabled = True
        txt_altura.Enabled = True
        cbo_provincias.Enabled = True
        cbo_localidades.Enabled = True
        cbo_barrios.Enabled = True
    End Sub

    Private Sub cmd_Salir_Click(sender As Object, e As EventArgs) Handles cmd_Salir.Click
        Me.Close()
    End Sub

    Private Sub frm_ABM_Profesional_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Me.Close()
        Me.Visible = False
        'If cierre_ventana() = 1 Then
        '    frm_Menu_Principal.Show()
        'Else
        '    e.Cancel = True
        'End If
    End Sub

    'Private Function cierre_ventana() As Integer
    '    Dim rpta As Integer = 0
    '    'Confirmación de salida.
    '    If MessageBox.Show("Seguro que desea salir?", _
    '            "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
    '            , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
    '        rpta = 1
    '    End If
    '    Return rpta
    'End Function
End Class
