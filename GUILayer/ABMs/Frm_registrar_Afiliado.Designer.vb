<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_Afiliado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrar_Afiliado))
        Me.dgv_afiliados = New System.Windows.Forms.DataGridView()
        Me.col_idTipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipoAfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estaActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_Salir = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Grabar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.txt_direccion = New System.Windows.Forms.Panel()
        Me.lbl_datosDomicilio = New System.Windows.Forms.Label()
        Me.txt_altura = New System.Windows.Forms.TextBox()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.cbo_provincias = New System.Windows.Forms.ComboBox()
        Me.lbl_Provincia = New System.Windows.Forms.Label()
        Me.cbo_localidades = New System.Windows.Forms.ComboBox()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.cbo_barrios = New System.Windows.Forms.ComboBox()
        Me.lbl_barrio = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.lbl_empresa = New System.Windows.Forms.Label()
        Me.cbo_tipo_afiliado = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_datosEmpleado = New System.Windows.Forms.Label()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.lbl_mail = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_TipoAfiliado = New System.Windows.Forms.Label()
        Me.lbl_fecha_nac = New System.Windows.Forms.Label()
        Me.cbo_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.lbl_tipo_documento = New System.Windows.Forms.Label()
        Me.txt_nro_documento = New System.Windows.Forms.TextBox()
        Me.lbl_nro_documento = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        CType(Me.dgv_afiliados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txt_direccion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_afiliados
        '
        Me.dgv_afiliados.AllowUserToAddRows = False
        Me.dgv_afiliados.AllowUserToDeleteRows = False
        Me.dgv_afiliados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_afiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_afiliados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idTipoDoc, Me.col_tipo, Me.col_documento, Me.col_nombre, Me.col_edad, Me.col_telefono, Me.col_mail, Me.col_direccion, Me.col_barrio, Me.col_localidad, Me.col_Provincia, Me.col_tipoAfil, Me.col_empresa, Me.col_activo, Me.col_estaActivo})
        Me.dgv_afiliados.Location = New System.Drawing.Point(605, 16)
        Me.dgv_afiliados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_afiliados.Name = "dgv_afiliados"
        Me.dgv_afiliados.ReadOnly = True
        Me.dgv_afiliados.RowTemplate.Height = 24
        Me.dgv_afiliados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_afiliados.Size = New System.Drawing.Size(428, 441)
        Me.dgv_afiliados.TabIndex = 7
        '
        'col_idTipoDoc
        '
        Me.col_idTipoDoc.HeaderText = "Id Tipo Documento"
        Me.col_idTipoDoc.Name = "col_idTipoDoc"
        Me.col_idTipoDoc.ReadOnly = True
        Me.col_idTipoDoc.Visible = False
        '
        'col_tipo
        '
        Me.col_tipo.FillWeight = 110.0!
        Me.col_tipo.HeaderText = "Tipo"
        Me.col_tipo.Name = "col_tipo"
        Me.col_tipo.ReadOnly = True
        Me.col_tipo.Width = 50
        '
        'col_documento
        '
        Me.col_documento.FillWeight = 110.0!
        Me.col_documento.HeaderText = "Documento"
        Me.col_documento.Name = "col_documento"
        Me.col_documento.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        Me.col_nombre.Width = 200
        '
        'col_edad
        '
        Me.col_edad.HeaderText = "Edad"
        Me.col_edad.Name = "col_edad"
        Me.col_edad.ReadOnly = True
        Me.col_edad.Width = 70
        '
        'col_telefono
        '
        Me.col_telefono.HeaderText = "Telefono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.ReadOnly = True
        Me.col_telefono.Width = 80
        '
        'col_mail
        '
        Me.col_mail.HeaderText = "EMail"
        Me.col_mail.Name = "col_mail"
        Me.col_mail.ReadOnly = True
        Me.col_mail.Width = 200
        '
        'col_direccion
        '
        Me.col_direccion.HeaderText = "Direccion"
        Me.col_direccion.Name = "col_direccion"
        Me.col_direccion.ReadOnly = True
        Me.col_direccion.Width = 200
        '
        'col_barrio
        '
        Me.col_barrio.HeaderText = "Barrio"
        Me.col_barrio.Name = "col_barrio"
        Me.col_barrio.ReadOnly = True
        '
        'col_localidad
        '
        Me.col_localidad.HeaderText = "Localidad"
        Me.col_localidad.Name = "col_localidad"
        Me.col_localidad.ReadOnly = True
        '
        'col_Provincia
        '
        Me.col_Provincia.HeaderText = "Provincia"
        Me.col_Provincia.Name = "col_Provincia"
        Me.col_Provincia.ReadOnly = True
        '
        'col_tipoAfil
        '
        Me.col_tipoAfil.HeaderText = "Tipo Afiliado"
        Me.col_tipoAfil.Name = "col_tipoAfil"
        Me.col_tipoAfil.ReadOnly = True
        '
        'col_empresa
        '
        Me.col_empresa.HeaderText = "Empresa"
        Me.col_empresa.Name = "col_empresa"
        Me.col_empresa.ReadOnly = True
        Me.col_empresa.Width = 80
        '
        'col_activo
        '
        Me.col_activo.HeaderText = "Esta Activo"
        Me.col_activo.Name = "col_activo"
        Me.col_activo.ReadOnly = True
        Me.col_activo.Width = 50
        '
        'col_estaActivo
        '
        Me.col_estaActivo.HeaderText = "Activo "
        Me.col_estaActivo.Name = "col_estaActivo"
        Me.col_estaActivo.ReadOnly = True
        Me.col_estaActivo.Visible = False
        '
        'cmd_Salir
        '
        Me.cmd_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_Salir.BackColor = System.Drawing.Color.Silver
        Me.cmd_Salir.Image = CType(resources.GetObject("cmd_Salir.Image"), System.Drawing.Image)
        Me.cmd_Salir.Location = New System.Drawing.Point(970, 483)
        Me.cmd_Salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmd_Salir.Name = "cmd_Salir"
        Me.cmd_Salir.Size = New System.Drawing.Size(63, 51)
        Me.cmd_Salir.TabIndex = 8
        Me.cmd_Salir.UseVisualStyleBackColor = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.BackColor = System.Drawing.Color.Silver
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(292, 477)
        Me.btn_Buscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(61, 55)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.BackColor = System.Drawing.Color.Silver
        Me.btn_Eliminar.BackgroundImage = CType(resources.GetObject("btn_Eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Eliminar.Location = New System.Drawing.Point(217, 477)
        Me.btn_Eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(69, 55)
        Me.btn_Eliminar.TabIndex = 5
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Grabar
        '
        Me.btn_Grabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Grabar.BackColor = System.Drawing.Color.Silver
        Me.btn_Grabar.Image = CType(resources.GetObject("btn_Grabar.Image"), System.Drawing.Image)
        Me.btn_Grabar.Location = New System.Drawing.Point(144, 477)
        Me.btn_Grabar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Grabar.Name = "btn_Grabar"
        Me.btn_Grabar.Size = New System.Drawing.Size(67, 56)
        Me.btn_Grabar.TabIndex = 4
        Me.btn_Grabar.UseVisualStyleBackColor = False
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.BackColor = System.Drawing.Color.Silver
        Me.btn_Modificar.BackgroundImage = CType(resources.GetObject("btn_Modificar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Modificar.Location = New System.Drawing.Point(77, 477)
        Me.btn_Modificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(60, 56)
        Me.btn_Modificar.TabIndex = 3
        Me.btn_Modificar.UseVisualStyleBackColor = False
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Nuevo.BackColor = System.Drawing.Color.Silver
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.Location = New System.Drawing.Point(12, 477)
        Me.btn_Nuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(61, 56)
        Me.btn_Nuevo.TabIndex = 2
        Me.btn_Nuevo.UseVisualStyleBackColor = False
        '
        'txt_direccion
        '
        Me.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_direccion.Controls.Add(Me.btn_new)
        Me.txt_direccion.Controls.Add(Me.lbl_datosDomicilio)
        Me.txt_direccion.Controls.Add(Me.txt_altura)
        Me.txt_direccion.Controls.Add(Me.lbl_numero)
        Me.txt_direccion.Controls.Add(Me.cbo_provincias)
        Me.txt_direccion.Controls.Add(Me.lbl_Provincia)
        Me.txt_direccion.Controls.Add(Me.cbo_localidades)
        Me.txt_direccion.Controls.Add(Me.lbl_localidad)
        Me.txt_direccion.Controls.Add(Me.cbo_barrios)
        Me.txt_direccion.Controls.Add(Me.lbl_barrio)
        Me.txt_direccion.Controls.Add(Me.txt_calle)
        Me.txt_direccion.Controls.Add(Me.lbl_direccion)
        Me.txt_direccion.Location = New System.Drawing.Point(11, 288)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(581, 169)
        Me.txt_direccion.TabIndex = 1
        '
        'lbl_datosDomicilio
        '
        Me.lbl_datosDomicilio.AutoSize = True
        Me.lbl_datosDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datosDomicilio.Location = New System.Drawing.Point(13, 12)
        Me.lbl_datosDomicilio.Name = "lbl_datosDomicilio"
        Me.lbl_datosDomicilio.Size = New System.Drawing.Size(175, 20)
        Me.lbl_datosDomicilio.TabIndex = 10
        Me.lbl_datosDomicilio.Text = "Datos del Domicilio"
        '
        'txt_altura
        '
        Me.txt_altura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_altura.Location = New System.Drawing.Point(379, 44)
        Me.txt_altura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_altura.Name = "txt_altura"
        Me.txt_altura.Size = New System.Drawing.Size(61, 22)
        Me.txt_altura.TabIndex = 1
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.Location = New System.Drawing.Point(307, 48)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(66, 18)
        Me.lbl_numero.TabIndex = 8
        Me.lbl_numero.Text = "Numero:"
        '
        'cbo_provincias
        '
        Me.cbo_provincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_provincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_provincias.FormattingEnabled = True
        Me.cbo_provincias.Location = New System.Drawing.Point(88, 74)
        Me.cbo_provincias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_provincias.Name = "cbo_provincias"
        Me.cbo_provincias.Size = New System.Drawing.Size(181, 26)
        Me.cbo_provincias.TabIndex = 2
        '
        'lbl_Provincia
        '
        Me.lbl_Provincia.AutoSize = True
        Me.lbl_Provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Provincia.Location = New System.Drawing.Point(13, 78)
        Me.lbl_Provincia.Name = "lbl_Provincia"
        Me.lbl_Provincia.Size = New System.Drawing.Size(73, 18)
        Me.lbl_Provincia.TabIndex = 6
        Me.lbl_Provincia.Text = "Provincia:"
        '
        'cbo_localidades
        '
        Me.cbo_localidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_localidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_localidades.FormattingEnabled = True
        Me.cbo_localidades.Location = New System.Drawing.Point(379, 76)
        Me.cbo_localidades.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_localidades.Name = "cbo_localidades"
        Me.cbo_localidades.Size = New System.Drawing.Size(164, 26)
        Me.cbo_localidades.TabIndex = 3
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localidad.Location = New System.Drawing.Point(299, 82)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(75, 18)
        Me.lbl_localidad.TabIndex = 4
        Me.lbl_localidad.Text = "Localidad:"
        '
        'cbo_barrios
        '
        Me.cbo_barrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_barrios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_barrios.FormattingEnabled = True
        Me.cbo_barrios.Location = New System.Drawing.Point(89, 119)
        Me.cbo_barrios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_barrios.Name = "cbo_barrios"
        Me.cbo_barrios.Size = New System.Drawing.Size(181, 26)
        Me.cbo_barrios.TabIndex = 4
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_barrio.Location = New System.Drawing.Point(35, 123)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(52, 18)
        Me.lbl_barrio.TabIndex = 2
        Me.lbl_barrio.Text = "Barrio:"
        '
        'txt_calle
        '
        Me.txt_calle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_calle.Location = New System.Drawing.Point(89, 44)
        Me.txt_calle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(181, 22)
        Me.txt_calle.TabIndex = 0
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion.Location = New System.Drawing.Point(43, 46)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(45, 18)
        Me.lbl_direccion.TabIndex = 0
        Me.lbl_direccion.Text = "Calle:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtp_fecha)
        Me.Panel1.Controls.Add(Me.txt_empresa)
        Me.Panel1.Controls.Add(Me.lbl_empresa)
        Me.Panel1.Controls.Add(Me.cbo_tipo_afiliado)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbl_datosEmpleado)
        Me.Panel1.Controls.Add(Me.txt_mail)
        Me.Panel1.Controls.Add(Me.lbl_mail)
        Me.Panel1.Controls.Add(Me.txt_telefono)
        Me.Panel1.Controls.Add(Me.lbl_telefono)
        Me.Panel1.Controls.Add(Me.lbl_TipoAfiliado)
        Me.Panel1.Controls.Add(Me.lbl_fecha_nac)
        Me.Panel1.Controls.Add(Me.cbo_tipo_documento)
        Me.Panel1.Controls.Add(Me.lbl_tipo_documento)
        Me.Panel1.Controls.Add(Me.txt_nro_documento)
        Me.Panel1.Controls.Add(Me.lbl_nro_documento)
        Me.Panel1.Controls.Add(Me.txt_apellido)
        Me.Panel1.Controls.Add(Me.lbl_apellido)
        Me.Panel1.Controls.Add(Me.txt_nombre)
        Me.Panel1.Controls.Add(Me.lbl_nombre)
        Me.Panel1.Location = New System.Drawing.Point(11, 17)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 258)
        Me.Panel1.TabIndex = 0
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(117, 148)
        Me.dtp_fecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(181, 22)
        Me.dtp_fecha.TabIndex = 26
        '
        'txt_empresa
        '
        Me.txt_empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_empresa.Location = New System.Drawing.Point(413, 183)
        Me.txt_empresa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(151, 22)
        Me.txt_empresa.TabIndex = 7
        '
        'lbl_empresa
        '
        Me.lbl_empresa.AutoSize = True
        Me.lbl_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empresa.Location = New System.Drawing.Point(335, 185)
        Me.lbl_empresa.Name = "lbl_empresa"
        Me.lbl_empresa.Size = New System.Drawing.Size(72, 18)
        Me.lbl_empresa.TabIndex = 25
        Me.lbl_empresa.Text = "Empresa:"
        '
        'cbo_tipo_afiliado
        '
        Me.cbo_tipo_afiliado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_afiliado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipo_afiliado.FormattingEnabled = True
        Me.cbo_tipo_afiliado.Location = New System.Drawing.Point(413, 144)
        Me.cbo_tipo_afiliado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_tipo_afiliado.Name = "cbo_tipo_afiliado"
        Me.cbo_tipo_afiliado.Size = New System.Drawing.Size(151, 26)
        Me.cbo_tipo_afiliado.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 50)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'lbl_datosEmpleado
        '
        Me.lbl_datosEmpleado.AutoSize = True
        Me.lbl_datosEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datosEmpleado.Location = New System.Drawing.Point(67, 27)
        Me.lbl_datosEmpleado.Name = "lbl_datosEmpleado"
        Me.lbl_datosEmpleado.Size = New System.Drawing.Size(159, 20)
        Me.lbl_datosEmpleado.TabIndex = 16
        Me.lbl_datosEmpleado.Text = "Datos del Afiliado"
        '
        'txt_mail
        '
        Me.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mail.Location = New System.Drawing.Point(117, 220)
        Me.txt_mail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(181, 22)
        Me.txt_mail.TabIndex = 8
        '
        'lbl_mail
        '
        Me.lbl_mail.AutoSize = True
        Me.lbl_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mail.Location = New System.Drawing.Point(57, 220)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(54, 18)
        Me.lbl_mail.TabIndex = 14
        Me.lbl_mail.Text = "E-Mail:"
        '
        'txt_telefono
        '
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telefono.Location = New System.Drawing.Point(117, 183)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(181, 22)
        Me.txt_telefono.TabIndex = 6
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono.Location = New System.Drawing.Point(41, 191)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(70, 18)
        Me.lbl_telefono.TabIndex = 12
        Me.lbl_telefono.Text = "Teléfono:"
        '
        'lbl_TipoAfiliado
        '
        Me.lbl_TipoAfiliado.AutoSize = True
        Me.lbl_TipoAfiliado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TipoAfiliado.Location = New System.Drawing.Point(316, 148)
        Me.lbl_TipoAfiliado.Name = "lbl_TipoAfiliado"
        Me.lbl_TipoAfiliado.Size = New System.Drawing.Size(91, 18)
        Me.lbl_TipoAfiliado.TabIndex = 10
        Me.lbl_TipoAfiliado.Text = "Tipo afiliado:"
        '
        'lbl_fecha_nac
        '
        Me.lbl_fecha_nac.AutoSize = True
        Me.lbl_fecha_nac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha_nac.Location = New System.Drawing.Point(3, 148)
        Me.lbl_fecha_nac.Name = "lbl_fecha_nac"
        Me.lbl_fecha_nac.Size = New System.Drawing.Size(108, 18)
        Me.lbl_fecha_nac.TabIndex = 8
        Me.lbl_fecha_nac.Text = "Fecha de Nac :"
        '
        'cbo_tipo_documento
        '
        Me.cbo_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipo_documento.FormattingEnabled = True
        Me.cbo_tipo_documento.Location = New System.Drawing.Point(413, 107)
        Me.cbo_tipo_documento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_tipo_documento.Name = "cbo_tipo_documento"
        Me.cbo_tipo_documento.Size = New System.Drawing.Size(151, 26)
        Me.cbo_tipo_documento.TabIndex = 3
        '
        'lbl_tipo_documento
        '
        Me.lbl_tipo_documento.AutoSize = True
        Me.lbl_tipo_documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_documento.Location = New System.Drawing.Point(331, 113)
        Me.lbl_tipo_documento.Name = "lbl_tipo_documento"
        Me.lbl_tipo_documento.Size = New System.Drawing.Size(77, 18)
        Me.lbl_tipo_documento.TabIndex = 6
        Me.lbl_tipo_documento.Text = "Tipo Doc :"
        '
        'txt_nro_documento
        '
        Me.txt_nro_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nro_documento.Location = New System.Drawing.Point(117, 107)
        Me.txt_nro_documento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nro_documento.MaxLength = 8
        Me.txt_nro_documento.Name = "txt_nro_documento"
        Me.txt_nro_documento.Size = New System.Drawing.Size(157, 22)
        Me.txt_nro_documento.TabIndex = 2
        '
        'lbl_nro_documento
        '
        Me.lbl_nro_documento.AutoSize = True
        Me.lbl_nro_documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro_documento.Location = New System.Drawing.Point(21, 110)
        Me.lbl_nro_documento.Name = "lbl_nro_documento"
        Me.lbl_nro_documento.Size = New System.Drawing.Size(90, 18)
        Me.lbl_nro_documento.TabIndex = 4
        Me.lbl_nro_documento.Text = "Documento:"
        '
        'txt_apellido
        '
        Me.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apellido.Location = New System.Drawing.Point(413, 74)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(151, 22)
        Me.txt_apellido.TabIndex = 1
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido.Location = New System.Drawing.Point(344, 78)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(63, 18)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido:"
        '
        'txt_nombre
        '
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre.Location = New System.Drawing.Point(117, 74)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(157, 22)
        Me.txt_nombre.TabIndex = 0
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(45, 74)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(66, 18)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(280, 117)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(61, 30)
        Me.btn_new.TabIndex = 11
        Me.btn_new.Text = "Nuevo"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'frm_registrar_Afiliado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1045, 545)
        Me.Controls.Add(Me.dgv_afiliados)
        Me.Controls.Add(Me.cmd_Salir)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Grabar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_registrar_Afiliado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Afiliado"
        CType(Me.dgv_afiliados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txt_direccion.ResumeLayout(False)
        Me.txt_direccion.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_afiliados As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Grabar As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_direccion As System.Windows.Forms.Panel
    Friend WithEvents lbl_datosDomicilio As System.Windows.Forms.Label
    Friend WithEvents txt_altura As System.Windows.Forms.TextBox
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents cbo_provincias As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Provincia As System.Windows.Forms.Label
    Friend WithEvents cbo_localidades As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents cbo_barrios As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_barrio As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents lbl_direccion As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_datosEmpleado As System.Windows.Forms.Label
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents lbl_mail As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoAfiliado As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_nac As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipo_documento As System.Windows.Forms.Label
    Friend WithEvents txt_nro_documento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nro_documento As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo_afiliado As System.Windows.Forms.ComboBox
    Friend WithEvents txt_empresa As System.Windows.Forms.TextBox
    Friend WithEvents lbl_empresa As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents col_idTipoDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipoAfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_activo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estaActivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_new As System.Windows.Forms.Button
End Class
