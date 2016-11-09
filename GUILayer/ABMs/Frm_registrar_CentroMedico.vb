
Public Class frm_registrar_centroMedico

    Enum termino
        aprobado
        rechazado
    End Enum
    Enum estado
        insertar
        modificar
    End Enum

    Dim oCentroMedicoService As New CentroMedicoService
    Dim oTablaTipoService As New TablaTipoService
    Dim oLocalidadService As New LocalidadService
    Dim oBarrioService As New BarrioService

    'Clave foránea
    Dim oDomicilioService As New DomicilioService

    'Creación de variable del tipo Enumeración
    Dim accion As estado = estado.insertar

    'Variable auxiliar
    Dim selected_centro_id = ""

    Dim stringConexion As String = BDHelper.string_conexion
   
    Private Sub frm_registrar_centroMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.setearLabelsAColorInicial()
        Me.LimpiarCampos()

        'Carga de Combos
        cargaCombo(Me.cbo_provincias, oTablaTipoService.listarTipos("Provincias"), "id", "nombre")
        Me.LimpiarCombos()

        'Carga de Grilla
        cargaGrilla()
        dgv_centros.ClearSelection()

        Me.deshabilitarControles()
        Me.deshabilitarBotones()
    End Sub

    Private Sub deshabilitarBotones()
        btn_Grabar.Enabled = False
        btn_Eliminar.Enabled = False
        btn_Modificar.Enabled = False
    End Sub

    Private Sub LimpiarCombos()
        cbo_provincias.SelectedIndex = -1
        cbo_esPropio.SelectedIndex = -1
    End Sub

    Private Sub cargaGrilla()
        Dim tabla As New Data.DataTable
        Me.dgv_centros.Rows.Clear()

        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        connection.ConnectionString = Me.stringConexion

        connection.Open()
        command.CommandType = CommandType.Text
        command.CommandText = "SELECT * FROM CentrosMedicos C JOIN Domicilios D ON C.id_domicilio = D.id_domicilio JOIN Barrios B ON B.id_barrio = D.id_barrio JOIN Localidades L ON L.id = B.id_localidad JOIN Provincias P ON P.id = L.id_provincia WHERE activo=1"
        command.Connection = connection
        tabla.Load(command.ExecuteReader())

        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_centros.Rows.Add(tabla.Rows(c)("denominacion"), _
                                    tabla.Rows(c)("telefono"), _
                                    tabla.Rows(c)("mail"), _
                                    tabla.Rows(c)("esPropio"), _
                                    tabla.Rows(c)("calle"), _
                                    tabla.Rows(c)("numero"), _
                                    tabla.Rows(c)("nombre"), _
                                    tabla.Rows(c)("nombre1"), _
                                    tabla.Rows(c)("nombre2"), _
                                    tabla.Rows(c)("id_centro"))
        Next
    End Sub

    Private Sub deshabilitarControles()
        Me.txt_nombre.Enabled = False
        cbo_esPropio.Enabled = False
        txt_telefono.Enabled = False
        txt_mail.Enabled = False
        txt_calle.Enabled = False
        txt_altura.Enabled = False
        cbo_provincias.Enabled = False
        cbo_localidades.Enabled = False
        cbo_barrios.Enabled = False
    End Sub

    Private Sub habilitarControles()
        Me.txt_nombre.Enabled = True
        cbo_esPropio.Enabled = True
        txt_telefono.Enabled = True
        txt_mail.Enabled = True
        txt_calle.Enabled = True
        txt_altura.Enabled = True
        cbo_provincias.Enabled = True
        cbo_localidades.Enabled = True
        cbo_barrios.Enabled = True
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Me.setearLabelsAColorInicial()
        Me.LimpiarCampos()
        Me.habilitarControles()
        Me.btn_Grabar.Enabled = True
        Me.txt_nombre.Focus()
        Me.accion = estado.insertar
    End Sub

    Private Sub LimpiarCampos()
        txt_nombre.Text = ""
        txt_telefono.Text = ""
        txt_mail.Text = ""
        txt_calle.Text = ""
        txt_altura.Text = ""

        Me.cbo_esPropio.SelectedIndex = -1
        Me.cbo_provincias.SelectedIndex = -1
        Me.cbo_localidades.SelectedIndex = -1
        Me.cbo_barrios.SelectedIndex = -1
    End Sub

    Private Sub cbo_provincias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_provincias.SelectionChangeCommitted
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

    Private Sub cargaCombo(ByRef combo As ComboBox, ByVal datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)

        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
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

    Private Function validar_CamposObligatorios() As Boolean
        Dim campos_completos As Boolean = True
        Dim mensajeAdvertencia As String = ""

        If txt_nombre.Text = String.Empty Then
            lbl_nombre.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_nombre.ForeColor = Color.Black
        End If

        If txt_calle.Text = String.Empty Then
            lbl_direccion.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_direccion.ForeColor = Color.Black
        End If

        If txt_altura.Text = String.Empty Then
            lbl_altura.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_altura.ForeColor = Color.Black
        End If

        If cbo_provincias.SelectedIndex = -1 Then
            lbl_provincia.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_provincia.ForeColor = Color.Black
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

        If cbo_esPropio.SelectedIndex = -1 Then
            lbl_esPropio.ForeColor = Color.Red
            campos_completos = False
        Else
            lbl_esPropio.ForeColor = Color.Black
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

        If campos_completos = False Then
            MsgBox(mensajeAdvertencia, MsgBoxStyle.Exclamation, "Importante")
        End If
        Return campos_completos
    End Function

    Private Sub cmd_Grabar_Click(sender As Object, e As EventArgs) Handles btn_Grabar.Click
        If Me.validar_CamposObligatorios() = True Then
            If Me.accion = estado.insertar Then
                If Me.insertarNuevoCentroMedico() = termino.aprobado Then
                    MessageBox.Show("Se grabó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.cargaGrilla()
                    Me.LimpiarCampos()
                Else
                    MessageBox.Show("Hubo un error en el registro del Afiliado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.LimpiarCampos()
                End If
            Else
                If Me.actualizarCentroMedico() = termino.aprobado Then
                    MessageBox.Show("Se modificó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_nombre.Tag = ""
                    Me.cargaGrilla()
                    Me.LimpiarCampos()
                Else
                    MessageBox.Show("Hubo un error en la actualización", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Function insertarNuevoCentroMedico() As termino
        Dim oCentroMedico As New CentroMedico
        Dim oDomicilioService As New DomicilioService

        With oCentroMedico
            .idCentro = oCentroMedicoService.generarIdCentro()
            .denominacion = txt_nombre.Text
            .idDomicilio = oDomicilioService.generarCodigoDomicilio()
            .calle = txt_calle.Text
            .numero = txt_altura.Text
            .codBarrio = cbo_barrios.SelectedValue
            If String.IsNullOrEmpty(txt_telefono.Text) = True Then
                .telefonoCentro = 0
            Else
                .telefonoCentro = Convert.ToInt64(txt_telefono.Text)
            End If
            .mail = txt_mail.Text
            If (cbo_esPropio.Text = "SI") Then
                .esPropio = True
            Else
                .esPropio = False
            End If
            .activo = True
        End With

        If oCentroMedicoService.registrarCentroMedico(oCentroMedico) = True Then
            Return termino.aprobado
        Else
            Return termino.rechazado
        End If
    End Function

    Private Function actualizarCentroMedico() As termino
        Dim oCentroMedico As New CentroMedico

        With oCentroMedico
            .idCentro = txt_nombre.Tag
            .denominacion = txt_nombre.Text
            .telefonoCentro = Convert.ToInt64(txt_telefono.Text)
            .mail = txt_mail.Text
            If (cbo_esPropio.SelectedText = "SI") Then
                .esPropio = True
            Else
                .esPropio = False
            End If
            .activo = True
            .calle = txt_calle.Text
            .numero = Integer.Parse(txt_altura.Text)
            .codBarrio = cbo_barrios.SelectedValue
        End With
        If oCentroMedicoService.actualizarCentroMedico(oCentroMedico) = True Then
            Return termino.aprobado
        Else
            Return termino.rechazado
        End If

    End Function

    Private Sub cmd_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If Not IsNothing(dgv_centros.CurrentRow) Then
            If MessageBox.Show("Esta seguro que desea eliminar ese Centro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                Dim conexion As New SqlClient.SqlConnection
                Dim command As New SqlClient.SqlCommand

                conexion.ConnectionString = Me.stringConexion
                conexion.Open()

                command.Connection = conexion
                command.CommandType = CommandType.Text
                command.CommandText = "UPDATE CentrosMedicos SET activo = 0 WHERE id_centro = " + dgv_centros.CurrentRow.Cells("col_idCentro").Value.ToString
                command.ExecuteNonQuery()

                conexion.Close()
                cargaGrilla()
            End If
        Else
            MessageBox.Show("Debe seleccionar un centro de la grilla")
        End If
        
    End Sub

    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If Not IsNothing(dgv_centros.CurrentRow) Then
            Dim connection As New SqlClient.SqlConnection
            Dim command As New SqlClient.SqlCommand
            Dim tabla As New Data.DataTable
            connection.ConnectionString = Me.stringConexion

            connection.Open()
            command.CommandType = CommandType.Text
            command.CommandText = "SELECT * FROM CentrosMedicos C WHERE id_centro = " + dgv_centros.CurrentRow.Cells("col_idCentro").Value.ToString
            command.Connection = connection
            tabla.Load(command.ExecuteReader())

            txt_nombre.Text = tabla.Rows(0)("denominacion").ToString
            txt_telefono.Text = tabla.Rows(0)("telefono").ToString
            txt_mail.Text = tabla.Rows(0)("mail").ToString

            If (tabla.Rows(0)("esPropio").ToString.CompareTo("True")) Then
                cbo_esPropio.Text = "s"
            Else
                cbo_esPropio.Text = "n"
            End If

            'txt_calle.Text = tabla.Rows(0)("calle").ToString
            'txt_altura.Text = tabla.Rows(0)("numero").ToString
            'tabla.Rows(0)("nombre")
            'tabla.Rows(0)("nombre1")
            'tabla.Rows(0)("nombre2")
            'tabla.Rows(0)("id_centro")
            connection.Close()
        Else
            MessageBox.Show("Debe seleccionar un centro de la grilla")
        End If
        
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Me.habilitarControles()
        Dim idCentro As Integer
        idCentro = Integer.Parse(Me.dgv_centros.CurrentRow.Cells.Item("col_idCentro").Value.ToString)

        Dim lista As New List(Of CentroMedico)
        lista = oCentroMedicoService.buscarCentroMedico(idCentro)

        For Each oCentroMedico In lista
            With oCentroMedico
                txt_nombre.Text = oCentroMedico.denominacion
                txt_nombre.Tag = idCentro
                If oCentroMedico.esPropio = True Then
                    cbo_esPropio.Text = "SI"
                Else
                    cbo_esPropio.Text = "NO"
                End If
                txt_telefono.Text = oCentroMedico.telefonoCentro.ToString
                txt_mail.Text = oCentroMedico.mail
                txt_calle.Text = oCentroMedico.calle
                txt_altura.Text = oCentroMedico.numero.ToString
                cbo_provincias.SelectedValue = oCentroMedico.idProvincia
                cbo_provincias_SelectionChangeCommitted(sender, Nothing)
                cbo_localidades.SelectedValue = oCentroMedico.idLocalidad
                cbo_localidades_SelectionChangeCommitted(sender, Nothing)
                cbo_barrios.SelectedValue = oCentroMedico.codBarrio
            End With
        Next
        btn_Grabar.Enabled = True
        Me.accion = estado.modificar
    End Sub

    Private Sub setearLabelsAColorInicial()
        lbl_nombre.ForeColor = Color.Black
        lbl_direccion.ForeColor = Color.Black
        lbl_altura.ForeColor = Color.Black
        lbl_provincia.ForeColor = Color.Black
        lbl_localidad.ForeColor = Color.Black
        lbl_barrio.ForeColor = Color.Black
        lbl_esPropio.ForeColor = Color.Black
    End Sub

    Private Sub dgv_centros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_centros.CellClick
        btn_Modificar.Enabled = True
        btn_Eliminar.Enabled = True
    End Sub

    Private Sub cmd_Salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 13, 127, 9, 15, 14, 8
                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Este carater no es un numero ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txt_altura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_altura.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 13, 9, 15, 14, 8
                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Este carater no es un numero ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub
End Class