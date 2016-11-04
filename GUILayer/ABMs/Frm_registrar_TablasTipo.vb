Public Class frm_registrar_TablasTipo

    Enum estado
        insertar
        modificar
    End Enum
    Enum valida
        ok
        errores
    End Enum
    Enum respuesta
        si
        no
    End Enum

    Dim oTablaTipoService As New TablaTipoService

    Dim _tabla As String = ""
    Dim _pk As String = ""
    Dim _descripcion As String = ""
    Dim string_conexion As String = BDHelper.string_conexion

    'Creación de variables del tipo Enumeración 
    Dim accion As estado = estado.insertar
    Dim validar As valida = valida.errores
    Dim row_selected As DataGridViewRow

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Sub New(ByVal tabla As String, ByVal nombre_pk As String, ByVal nombre_descripcion As String)

        InitializeComponent()
        _tabla = tabla
        _pk = nombre_pk
        _descripcion = nombre_descripcion
        Me.Text = "ABM - " & Me._tabla
    End Sub

    Private Sub frm_ABM_gener_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga de Grilla 
        Me.cargo_grilla(oTablaTipoService.getAllTipos(_tabla, _pk, _descripcion))
        Grid.ClearSelection()
        'Estado inicial de los controles 
        Me.deshabilitarControles()
    End Sub

    Private Sub deshabilitarControles()
        'Estado inicial de los controles
        txt_codigo.Enabled = False
        txt_nombre.Enabled = False
        btn_grabar.Enabled = False
    End Sub

    Private Sub habilitarControles()
        txt_codigo.Enabled = True
        txt_nombre.Enabled = True
    End Sub

    Private Function leo_tabla(ByVal nombre_tabla As String, ByVal pk As String, ByVal desc As String) As Data.DataTable
        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = string_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select " & pk & " as Nro, " & desc & " as Descripcion from " & nombre_tabla
        tabla.Load(cmd.ExecuteReader())

        Return tabla
        conexion.Close()
    End Function

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Me.LimpiarCampos()
        Me.habilitarControles()
        Me.btn_grabar.Enabled = True
        Me.txt_nombre.Focus()
        Me.accion = estado.insertar
    End Sub

    Private Sub LimpiarCampos()
        Me.txt_nombre.Text = ""
        Me.txt_codigo.Text = ""
        Me.txt_codigo.Enabled = True
    End Sub

    Private Sub cargo_grilla(ByVal tabla As Data.DataTable)
        ' Se le asigna una tabla a la grilla como recurso de datos
        Me.grid.DataSource = tabla
        Me.seteo_grilla()
    End Sub

    'Método para formatear la cabecera de cada columna de la grilla
    Private Sub seteo_grilla()
        Me.Grid.Columns(0).HeaderText = "Nro."
        Me.grid.Columns(1).HeaderText = "Descripción"
        Me.grid.Columns(1).Width = 350
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellClick
        row_selected = Grid.CurrentRow
        btn_modificar.Enabled = True
        btn_eliminar.Enabled = True
    End Sub
    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If validacion() = valida.ok Then
            If Me.accion = estado.insertar Then
                Me.inserta(Me.string_conexion)
                Me.accion = estado.modificar
            Else
                Me.modificar(Me.string_conexion)
            End If
            Me.cargo_grilla(leo_tabla(_tabla, Me._pk, Me._descripcion))
        End If
    End Sub

    Private Function validacion() As valida
        If Me.txt_nombre.Text = "" Then
            MsgBox("El nombre no puede estar vacío", MsgBoxStyle.Critical, "Error")
            Me.txt_nombre.Focus()
            Return valida.errores
        End If
        Return valida.ok
    End Function

    Private Sub inserta(ByVal con As String)
        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim tabla As New Data.DataTable

        Dim sql_insert As String = ""
        Dim sql As String = ""
        Dim valor As Integer = 0

        conexion.ConnectionString = con
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        If Me.txt_codigo.Text = "" Then
            sql = "select max(" & Me._pk & ") as ultimo from " & Me._tabla
            cmd.CommandText = sql
            tabla.Load(cmd.ExecuteReader())
            valor = tabla.Rows(0)("ultimo")
            Me.txt_codigo.Text = valor + 1
        End If
        sql_insert = "insert into " & Me._tabla & " ( "
        sql_insert &= Me._pk
        sql_insert &= ", " & Me._descripcion & ") "
        sql_insert &= "values (" & Me.txt_codigo.Text
        sql_insert &= ", '" & Me.txt_nombre.Text & "')"

        cmd.CommandText = sql_insert
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub

    'Método para modificar en la tabla que estemos, utilizando los datos actuales en formulario
    Private Sub modificar(ByVal con As String)

        'Definición de los objetos que se requieren para lograr acceso a datos con una base de datos Access 
        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim tabla As New Data.DataTable

        Dim sql_update As String = ""
        Dim sql As String = ""
        Dim valor As Integer = 0

        'Asigna el string de conexión al objeto de conexión, luego realiza una conexión con método "Open"
        conexion.ConnectionString = con
        conexion.Open()
        'Asigna al objeto que corre los comando SQL con cual conexión va a trabajar 
        cmd.Connection = conexion
        'Se especifica que se correrá un comando de tipo texto. En otras palabras este comando proviene desde
        'la programación del "Form"
        cmd.CommandType = CommandType.Text

        'Arma el "update" en forma genérica para insertar los datos que están en el "form" dentro de la tabla
        'que se esta operando 
        sql_update = "update " & Me._tabla & " "
        sql_update &= "set nombre = '" & Me.txt_nombre.Text & "'"
        sql_update &= "where id= " & Me.txt_codigo.Text

        'Le asigna al objeto comando "cmd" la instrucción "insert" que debe ejecutar 
        cmd.CommandText = sql_update
        'Ejecuta el comando asignado, con el tipo especial "ExecuteNonQuery" que es para este tipo de 
        'comando que no devuelve información hacia el "form"  
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub

    'Método para eliminar en la tabla que estemos, utilizando los datos actuales en formulario
    Private Sub eliminar(ByVal con As String)

        'Definición de los objetos que se requieren para lograr acceso a datos con una base de datos Access 
        Dim conexion As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim tabla As New Data.DataTable

        Dim sql_delete As String = ""
        Dim sql As String = ""
        Dim valor As Integer = 0

        'Asigna el string de conexión al objeto de conexión, luego realiza una conexión con método "Open"
        conexion.ConnectionString = con
        conexion.Open()
        'Asigna al objeto que corre los comando SQL con cual conexión va a trabajar 
        cmd.Connection = conexion
        'Se especifica que se correrá un comando de tipo texto. En otras palabras este comando proviene desde
        'la programación del "Form"
        cmd.CommandType = CommandType.Text

        'Arma el "update" en forma genérica para insertar los datos que están en el "form" dentro de la tabla
        'que se esta operando 
        sql_delete = "delete from " & Me._tabla & " "
        sql_delete &= "where id= " & Me.txt_codigo.Text

        'Le asigna al objeto comando "cmd" la instrucción "insert" que debe ejecutar 
        cmd.CommandText = sql_delete
        'Ejecuta el comando asignado, con el tipo especial "ExecuteNonQuery" que es para este tipo de 
        'comando que no devuelve información hacia el "form"  
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Me.txt_nombre.Text = Me.grid.CurrentRow.Cells(1).Value
        Me.txt_codigo.Text = Me.grid.CurrentRow.Cells(0).Value
        Me.accion = estado.modificar
        Me.txt_nombre.Focus()
        Me.txt_codigo.Enabled = False
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Me.eliminar(Me.string_conexion)
        MessageBox.Show("Se eliminó exitosamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Me.cargo_grilla(leo_tabla(_tabla, Me._pk, Me._descripcion))
    End Sub

    Private Sub txt_codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_codigo.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 13, 9, 15, 14
                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Este carater no es un numero ( " + e.KeyChar + " )", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub frm_ABM_gener_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Visible = False
    End Sub
End Class