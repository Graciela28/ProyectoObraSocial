<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_profesional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrar_profesional))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_datosEmpleado = New System.Windows.Forms.Label()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.lbl_mail = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.txt_matricula = New System.Windows.Forms.TextBox()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_fecha_nac = New System.Windows.Forms.Label()
        Me.cbo_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.lbl_tipo_documento = New System.Windows.Forms.Label()
        Me.txt_nro_documento = New System.Windows.Forms.TextBox()
        Me.lbl_nro_documento = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
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
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Grabar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.cmd_Salir = New System.Windows.Forms.Button()
        Me.dgv_profesionales = New System.Windows.Forms.DataGridView()
        Me.col_idTipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombreTipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_eMail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txt_direccion.SuspendLayout()
        CType(Me.dgv_profesionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtp_fecha)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbl_datosEmpleado)
        Me.Panel1.Controls.Add(Me.txt_mail)
        Me.Panel1.Controls.Add(Me.lbl_mail)
        Me.Panel1.Controls.Add(Me.txt_telefono)
        Me.Panel1.Controls.Add(Me.lbl_telefono)
        Me.Panel1.Controls.Add(Me.txt_matricula)
        Me.Panel1.Controls.Add(Me.lbl_matricula)
        Me.Panel1.Controls.Add(Me.lbl_fecha_nac)
        Me.Panel1.Controls.Add(Me.cbo_tipo_documento)
        Me.Panel1.Controls.Add(Me.lbl_tipo_documento)
        Me.Panel1.Controls.Add(Me.txt_nro_documento)
        Me.Panel1.Controls.Add(Me.lbl_nro_documento)
        Me.Panel1.Controls.Add(Me.txt_apellido)
        Me.Panel1.Controls.Add(Me.lbl_apellido)
        Me.Panel1.Controls.Add(Me.txt_nombre)
        Me.Panel1.Controls.Add(Me.lbl_nombre)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 252)
        Me.Panel1.TabIndex = 0
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(110, 148)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(189, 22)
        Me.dtp_fecha.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 50)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'lbl_datosEmpleado
        '
        Me.lbl_datosEmpleado.AutoSize = True
        Me.lbl_datosEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datosEmpleado.Location = New System.Drawing.Point(67, 18)
        Me.lbl_datosEmpleado.Name = "lbl_datosEmpleado"
        Me.lbl_datosEmpleado.Size = New System.Drawing.Size(191, 20)
        Me.lbl_datosEmpleado.TabIndex = 16
        Me.lbl_datosEmpleado.Text = "Datos del Profesional"
        '
        'txt_mail
        '
        Me.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mail.Location = New System.Drawing.Point(110, 217)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(189, 22)
        Me.txt_mail.TabIndex = 7
        '
        'lbl_mail
        '
        Me.lbl_mail.AutoSize = True
        Me.lbl_mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mail.Location = New System.Drawing.Point(50, 221)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(54, 18)
        Me.lbl_mail.TabIndex = 14
        Me.lbl_mail.Text = "E-Mail:"
        '
        'txt_telefono
        '
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telefono.Location = New System.Drawing.Point(110, 184)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(189, 22)
        Me.txt_telefono.TabIndex = 6
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono.Location = New System.Drawing.Point(34, 184)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(70, 18)
        Me.lbl_telefono.TabIndex = 12
        Me.lbl_telefono.Text = "Teléfono:"
        '
        'txt_matricula
        '
        Me.txt_matricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_matricula.Location = New System.Drawing.Point(404, 144)
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(112, 22)
        Me.txt_matricula.TabIndex = 5
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matricula.Location = New System.Drawing.Point(322, 148)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(76, 18)
        Me.lbl_matricula.TabIndex = 10
        Me.lbl_matricula.Text = "Matricula :"
        '
        'lbl_fecha_nac
        '
        Me.lbl_fecha_nac.AutoSize = True
        Me.lbl_fecha_nac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha_nac.Location = New System.Drawing.Point(-1, 151)
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
        Me.cbo_tipo_documento.Location = New System.Drawing.Point(404, 108)
        Me.cbo_tipo_documento.Name = "cbo_tipo_documento"
        Me.cbo_tipo_documento.Size = New System.Drawing.Size(112, 26)
        Me.cbo_tipo_documento.TabIndex = 3
        '
        'lbl_tipo_documento
        '
        Me.lbl_tipo_documento.AutoSize = True
        Me.lbl_tipo_documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_documento.Location = New System.Drawing.Point(321, 112)
        Me.lbl_tipo_documento.Name = "lbl_tipo_documento"
        Me.lbl_tipo_documento.Size = New System.Drawing.Size(77, 18)
        Me.lbl_tipo_documento.TabIndex = 6
        Me.lbl_tipo_documento.Text = "Tipo Doc :"
        '
        'txt_nro_documento
        '
        Me.txt_nro_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nro_documento.Location = New System.Drawing.Point(110, 108)
        Me.txt_nro_documento.Name = "txt_nro_documento"
        Me.txt_nro_documento.Size = New System.Drawing.Size(164, 22)
        Me.txt_nro_documento.TabIndex = 2
        '
        'lbl_nro_documento
        '
        Me.lbl_nro_documento.AutoSize = True
        Me.lbl_nro_documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro_documento.Location = New System.Drawing.Point(14, 110)
        Me.lbl_nro_documento.Name = "lbl_nro_documento"
        Me.lbl_nro_documento.Size = New System.Drawing.Size(90, 18)
        Me.lbl_nro_documento.TabIndex = 4
        Me.lbl_nro_documento.Text = "Documento:"
        '
        'txt_apellido
        '
        Me.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apellido.Location = New System.Drawing.Point(372, 67)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(144, 22)
        Me.txt_apellido.TabIndex = 1
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido.Location = New System.Drawing.Point(303, 68)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(63, 18)
        Me.lbl_apellido.TabIndex = 2
        Me.lbl_apellido.Text = "Apellido:"
        '
        'txt_nombre
        '
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre.Location = New System.Drawing.Point(110, 68)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(164, 22)
        Me.txt_nombre.TabIndex = 0
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(38, 68)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(66, 18)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'txt_direccion
        '
        Me.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.txt_direccion.Location = New System.Drawing.Point(15, 292)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(525, 166)
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
        Me.txt_altura.Location = New System.Drawing.Point(358, 43)
        Me.txt_altura.Name = "txt_altura"
        Me.txt_altura.Size = New System.Drawing.Size(60, 22)
        Me.txt_altura.TabIndex = 1
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.Location = New System.Drawing.Point(286, 47)
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
        Me.cbo_provincias.Location = New System.Drawing.Point(89, 80)
        Me.cbo_provincias.Name = "cbo_provincias"
        Me.cbo_provincias.Size = New System.Drawing.Size(169, 26)
        Me.cbo_provincias.TabIndex = 2
        '
        'lbl_Provincia
        '
        Me.lbl_Provincia.AutoSize = True
        Me.lbl_Provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Provincia.Location = New System.Drawing.Point(14, 83)
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
        Me.cbo_localidades.Location = New System.Drawing.Point(358, 80)
        Me.cbo_localidades.Name = "cbo_localidades"
        Me.cbo_localidades.Size = New System.Drawing.Size(147, 26)
        Me.cbo_localidades.TabIndex = 3
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localidad.Location = New System.Drawing.Point(277, 88)
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
        Me.cbo_barrios.Location = New System.Drawing.Point(89, 112)
        Me.cbo_barrios.Name = "cbo_barrios"
        Me.cbo_barrios.Size = New System.Drawing.Size(169, 26)
        Me.cbo_barrios.TabIndex = 4
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_barrio.Location = New System.Drawing.Point(34, 115)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(52, 18)
        Me.lbl_barrio.TabIndex = 2
        Me.lbl_barrio.Text = "Barrio:"
        '
        'txt_calle
        '
        Me.txt_calle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_calle.Location = New System.Drawing.Point(89, 43)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(169, 22)
        Me.txt_calle.TabIndex = 0
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion.Location = New System.Drawing.Point(38, 47)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(45, 18)
        Me.lbl_direccion.TabIndex = 0
        Me.lbl_direccion.Text = "Calle:"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.Color.Silver
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.Location = New System.Drawing.Point(15, 479)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(62, 61)
        Me.btn_Nuevo.TabIndex = 2
        Me.btn_Nuevo.UseVisualStyleBackColor = False
        '
        'btn_Modificar
        '
        Me.btn_Modificar.BackColor = System.Drawing.Color.Silver
        Me.btn_Modificar.BackgroundImage = CType(resources.GetObject("btn_Modificar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Modificar.Location = New System.Drawing.Point(84, 479)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(60, 61)
        Me.btn_Modificar.TabIndex = 3
        Me.btn_Modificar.UseVisualStyleBackColor = False
        '
        'btn_Grabar
        '
        Me.btn_Grabar.BackColor = System.Drawing.Color.Silver
        Me.btn_Grabar.Image = CType(resources.GetObject("btn_Grabar.Image"), System.Drawing.Image)
        Me.btn_Grabar.Location = New System.Drawing.Point(150, 479)
        Me.btn_Grabar.Name = "btn_Grabar"
        Me.btn_Grabar.Size = New System.Drawing.Size(66, 61)
        Me.btn_Grabar.TabIndex = 4
        Me.btn_Grabar.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.Silver
        Me.btn_Eliminar.BackgroundImage = CType(resources.GetObject("btn_Eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Eliminar.Location = New System.Drawing.Point(222, 479)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(69, 60)
        Me.btn_Eliminar.TabIndex = 5
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.Silver
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(297, 479)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(62, 60)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'cmd_Salir
        '
        Me.cmd_Salir.BackColor = System.Drawing.Color.Silver
        Me.cmd_Salir.Image = CType(resources.GetObject("cmd_Salir.Image"), System.Drawing.Image)
        Me.cmd_Salir.Location = New System.Drawing.Point(954, 480)
        Me.cmd_Salir.Name = "cmd_Salir"
        Me.cmd_Salir.Size = New System.Drawing.Size(73, 63)
        Me.cmd_Salir.TabIndex = 8
        Me.cmd_Salir.UseVisualStyleBackColor = False
        '
        'dgv_profesionales
        '
        Me.dgv_profesionales.AllowUserToAddRows = False
        Me.dgv_profesionales.AllowUserToDeleteRows = False
        Me.dgv_profesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_profesionales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idTipoDoc, Me.col_nombreTipoDoc, Me.col_documento, Me.col_matricula, Me.col_nombre, Me.col_edad, Me.col_telefono, Me.col_eMail, Me.col_direccion, Me.col_barrio, Me.col_localidad, Me.col_provincia, Me.col_activo, Me.nombre})
        Me.dgv_profesionales.Location = New System.Drawing.Point(553, 12)
        Me.dgv_profesionales.Name = "dgv_profesionales"
        Me.dgv_profesionales.ReadOnly = True
        Me.dgv_profesionales.RowTemplate.Height = 24
        Me.dgv_profesionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_profesionales.Size = New System.Drawing.Size(474, 446)
        Me.dgv_profesionales.TabIndex = 7
        '
        'col_idTipoDoc
        '
        Me.col_idTipoDoc.FillWeight = 110.0!
        Me.col_idTipoDoc.HeaderText = "Id Tipo Documento"
        Me.col_idTipoDoc.Name = "col_idTipoDoc"
        Me.col_idTipoDoc.ReadOnly = True
        Me.col_idTipoDoc.Visible = False
        Me.col_idTipoDoc.Width = 110
        '
        'col_nombreTipoDoc
        '
        Me.col_nombreTipoDoc.HeaderText = "Tipo"
        Me.col_nombreTipoDoc.Name = "col_nombreTipoDoc"
        Me.col_nombreTipoDoc.ReadOnly = True
        Me.col_nombreTipoDoc.Width = 50
        '
        'col_documento
        '
        Me.col_documento.HeaderText = "Documento"
        Me.col_documento.Name = "col_documento"
        Me.col_documento.ReadOnly = True
        '
        'col_matricula
        '
        Me.col_matricula.HeaderText = "Matricula"
        Me.col_matricula.Name = "col_matricula"
        Me.col_matricula.ReadOnly = True
        Me.col_matricula.Width = 80
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        Me.col_nombre.Width = 150
        '
        'col_edad
        '
        Me.col_edad.HeaderText = "Edad"
        Me.col_edad.Name = "col_edad"
        Me.col_edad.ReadOnly = True
        Me.col_edad.Width = 50
        '
        'col_telefono
        '
        Me.col_telefono.HeaderText = "Telefono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.ReadOnly = True
        '
        'col_eMail
        '
        Me.col_eMail.HeaderText = "EMail"
        Me.col_eMail.Name = "col_eMail"
        Me.col_eMail.ReadOnly = True
        Me.col_eMail.Width = 200
        '
        'col_direccion
        '
        Me.col_direccion.HeaderText = "Direccion"
        Me.col_direccion.Name = "col_direccion"
        Me.col_direccion.ReadOnly = True
        Me.col_direccion.Width = 160
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
        'col_provincia
        '
        Me.col_provincia.HeaderText = "Provincia"
        Me.col_provincia.Name = "col_provincia"
        Me.col_provincia.ReadOnly = True
        '
        'col_activo
        '
        Me.col_activo.HeaderText = "Activo"
        Me.col_activo.Name = "col_activo"
        Me.col_activo.ReadOnly = True
        Me.col_activo.Width = 50
        '
        'nombre
        '
        Me.nombre.FillWeight = 110.0!
        Me.nombre.HeaderText = "Tipo"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Visible = False
        Me.nombre.Width = 250
        '
        'frm_registrar_profesional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1039, 548)
        Me.Controls.Add(Me.dgv_profesionales)
        Me.Controls.Add(Me.cmd_Salir)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Grabar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "frm_registrar_profesional"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Profesional"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txt_direccion.ResumeLayout(False)
        Me.txt_direccion.PerformLayout()
        CType(Me.dgv_profesionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents lbl_mail As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents txt_matricula As System.Windows.Forms.TextBox
    Friend WithEvents lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_nac As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipo_documento As System.Windows.Forms.Label
    Friend WithEvents txt_nro_documento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nro_documento As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.Panel
    Friend WithEvents lbl_direccion As System.Windows.Forms.Label
    Friend WithEvents lbl_datosEmpleado As System.Windows.Forms.Label
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
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Grabar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_Salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_profesionales As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents col_idTipoDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombreTipoDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_matricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_eMail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_activo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
