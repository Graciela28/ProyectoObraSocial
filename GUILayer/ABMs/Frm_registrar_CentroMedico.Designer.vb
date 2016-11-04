<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_centroMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrar_centroMedico))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbo_esPropio = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_datosCentro = New System.Windows.Forms.Label()
        Me.lbl_esPropio = New System.Windows.Forms.Label()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbo_provincias = New System.Windows.Forms.ComboBox()
        Me.lbl_provincia = New System.Windows.Forms.Label()
        Me.cbo_localidades = New System.Windows.Forms.ComboBox()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.cbo_barrios = New System.Windows.Forms.ComboBox()
        Me.lbl_barrio = New System.Windows.Forms.Label()
        Me.txt_altura = New System.Windows.Forms.TextBox()
        Me.lbl_altura = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.lbl_datosDomicilio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Grabar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.dgv_centros = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Propio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idCentro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_centros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbo_esPropio)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbl_datosCentro)
        Me.Panel1.Controls.Add(Me.lbl_esPropio)
        Me.Panel1.Controls.Add(Me.txt_mail)
        Me.Panel1.Controls.Add(Me.lbl_email)
        Me.Panel1.Controls.Add(Me.txt_telefono)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_nombre)
        Me.Panel1.Controls.Add(Me.lbl_nombre)
        Me.Panel1.Location = New System.Drawing.Point(12, 14)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 179)
        Me.Panel1.TabIndex = 0
        '
        'cbo_esPropio
        '
        Me.cbo_esPropio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_esPropio.FormattingEnabled = True
        Me.cbo_esPropio.Items.AddRange(New Object() {"SI", "NO"})
        Me.cbo_esPropio.Location = New System.Drawing.Point(381, 66)
        Me.cbo_esPropio.Name = "cbo_esPropio"
        Me.cbo_esPropio.Size = New System.Drawing.Size(65, 24)
        Me.cbo_esPropio.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 41)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lbl_datosCentro
        '
        Me.lbl_datosCentro.AutoSize = True
        Me.lbl_datosCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datosCentro.Location = New System.Drawing.Point(65, 22)
        Me.lbl_datosCentro.Name = "lbl_datosCentro"
        Me.lbl_datosCentro.Size = New System.Drawing.Size(152, 20)
        Me.lbl_datosCentro.TabIndex = 8
        Me.lbl_datosCentro.Text = "Datos del Centro"
        '
        'lbl_esPropio
        '
        Me.lbl_esPropio.AutoSize = True
        Me.lbl_esPropio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_esPropio.Location = New System.Drawing.Point(307, 68)
        Me.lbl_esPropio.Name = "lbl_esPropio"
        Me.lbl_esPropio.Size = New System.Drawing.Size(80, 18)
        Me.lbl_esPropio.TabIndex = 6
        Me.lbl_esPropio.Text = "Es propio: "
        '
        'txt_mail
        '
        Me.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mail.Location = New System.Drawing.Point(101, 140)
        Me.txt_mail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(185, 22)
        Me.txt_mail.TabIndex = 3
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(32, 144)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(54, 18)
        Me.lbl_email.TabIndex = 4
        Me.lbl_email.Text = "E-Mail:"
        '
        'txt_telefono
        '
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telefono.Location = New System.Drawing.Point(101, 105)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(185, 22)
        Me.txt_telefono.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Telefono: "
        '
        'txt_nombre
        '
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre.Location = New System.Drawing.Point(101, 68)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(185, 22)
        Me.txt_nombre.TabIndex = 0
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(29, 68)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(66, 18)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cbo_provincias)
        Me.Panel2.Controls.Add(Me.lbl_provincia)
        Me.Panel2.Controls.Add(Me.cbo_localidades)
        Me.Panel2.Controls.Add(Me.lbl_localidad)
        Me.Panel2.Controls.Add(Me.cbo_barrios)
        Me.Panel2.Controls.Add(Me.lbl_barrio)
        Me.Panel2.Controls.Add(Me.txt_altura)
        Me.Panel2.Controls.Add(Me.lbl_altura)
        Me.Panel2.Controls.Add(Me.txt_calle)
        Me.Panel2.Controls.Add(Me.lbl_direccion)
        Me.Panel2.Controls.Add(Me.lbl_datosDomicilio)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 207)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(490, 183)
        Me.Panel2.TabIndex = 1
        '
        'cbo_provincias
        '
        Me.cbo_provincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_provincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_provincias.FormattingEnabled = True
        Me.cbo_provincias.Location = New System.Drawing.Point(83, 98)
        Me.cbo_provincias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_provincias.Name = "cbo_provincias"
        Me.cbo_provincias.Size = New System.Drawing.Size(158, 26)
        Me.cbo_provincias.TabIndex = 2
        '
        'lbl_provincia
        '
        Me.lbl_provincia.AutoSize = True
        Me.lbl_provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_provincia.Location = New System.Drawing.Point(8, 103)
        Me.lbl_provincia.Name = "lbl_provincia"
        Me.lbl_provincia.Size = New System.Drawing.Size(77, 18)
        Me.lbl_provincia.TabIndex = 10
        Me.lbl_provincia.Text = "Provincia: "
        '
        'cbo_localidades
        '
        Me.cbo_localidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_localidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_localidades.FormattingEnabled = True
        Me.cbo_localidades.Location = New System.Drawing.Point(340, 98)
        Me.cbo_localidades.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_localidades.Name = "cbo_localidades"
        Me.cbo_localidades.Size = New System.Drawing.Size(145, 26)
        Me.cbo_localidades.TabIndex = 3
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localidad.Location = New System.Drawing.Point(259, 103)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(75, 18)
        Me.lbl_localidad.TabIndex = 8
        Me.lbl_localidad.Text = "Localidad:"
        '
        'cbo_barrios
        '
        Me.cbo_barrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_barrios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_barrios.FormattingEnabled = True
        Me.cbo_barrios.Location = New System.Drawing.Point(83, 137)
        Me.cbo_barrios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_barrios.Name = "cbo_barrios"
        Me.cbo_barrios.Size = New System.Drawing.Size(158, 26)
        Me.cbo_barrios.TabIndex = 4
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_barrio.Location = New System.Drawing.Point(29, 144)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(56, 18)
        Me.lbl_barrio.TabIndex = 6
        Me.lbl_barrio.Text = "Barrio: "
        '
        'txt_altura
        '
        Me.txt_altura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_altura.Location = New System.Drawing.Point(340, 60)
        Me.txt_altura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_altura.Name = "txt_altura"
        Me.txt_altura.Size = New System.Drawing.Size(66, 22)
        Me.txt_altura.TabIndex = 1
        '
        'lbl_altura
        '
        Me.lbl_altura.AutoSize = True
        Me.lbl_altura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_altura.Location = New System.Drawing.Point(264, 64)
        Me.lbl_altura.Name = "lbl_altura"
        Me.lbl_altura.Size = New System.Drawing.Size(70, 18)
        Me.lbl_altura.TabIndex = 4
        Me.lbl_altura.Text = "Numero: "
        '
        'txt_calle
        '
        Me.txt_calle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_calle.Location = New System.Drawing.Point(83, 60)
        Me.txt_calle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(158, 22)
        Me.txt_calle.TabIndex = 0
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion.Location = New System.Drawing.Point(32, 65)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(45, 18)
        Me.lbl_direccion.TabIndex = 2
        Me.lbl_direccion.Text = "Calle:"
        '
        'lbl_datosDomicilio
        '
        Me.lbl_datosDomicilio.AutoSize = True
        Me.lbl_datosDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datosDomicilio.Location = New System.Drawing.Point(11, 18)
        Me.lbl_datosDomicilio.Name = "lbl_datosDomicilio"
        Me.lbl_datosDomicilio.Size = New System.Drawing.Size(175, 20)
        Me.lbl_datosDomicilio.TabIndex = 1
        Me.lbl_datosDomicilio.Text = "Datos del Domicilio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 0
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.Color.Silver
        Me.btn_Nuevo.BackgroundImage = CType(resources.GetObject("btn_Nuevo.BackgroundImage"), System.Drawing.Image)
        Me.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Nuevo.Location = New System.Drawing.Point(12, 423)
        Me.btn_Nuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(64, 62)
        Me.btn_Nuevo.TabIndex = 2
        Me.btn_Nuevo.UseVisualStyleBackColor = False
        '
        'btn_Modificar
        '
        Me.btn_Modificar.BackColor = System.Drawing.Color.Silver
        Me.btn_Modificar.BackgroundImage = CType(resources.GetObject("btn_Modificar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Modificar.Location = New System.Drawing.Point(82, 424)
        Me.btn_Modificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(61, 60)
        Me.btn_Modificar.TabIndex = 3
        Me.btn_Modificar.UseVisualStyleBackColor = False
        '
        'btn_Grabar
        '
        Me.btn_Grabar.BackColor = System.Drawing.Color.Silver
        Me.btn_Grabar.BackgroundImage = CType(resources.GetObject("btn_Grabar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Grabar.Location = New System.Drawing.Point(150, 423)
        Me.btn_Grabar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Grabar.Name = "btn_Grabar"
        Me.btn_Grabar.Size = New System.Drawing.Size(68, 62)
        Me.btn_Grabar.TabIndex = 4
        Me.btn_Grabar.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.Silver
        Me.btn_Eliminar.BackgroundImage = CType(resources.GetObject("btn_Eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Eliminar.Location = New System.Drawing.Point(223, 424)
        Me.btn_Eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(69, 62)
        Me.btn_Eliminar.TabIndex = 5
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.Silver
        Me.btn_Buscar.BackgroundImage = CType(resources.GetObject("btn_Buscar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Buscar.Location = New System.Drawing.Point(298, 425)
        Me.btn_Buscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(65, 62)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Silver
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_salir.Location = New System.Drawing.Point(903, 426)
        Me.cmd_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(68, 62)
        Me.cmd_salir.TabIndex = 8
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'dgv_centros
        '
        Me.dgv_centros.AllowUserToAddRows = False
        Me.dgv_centros.AllowUserToDeleteRows = False
        Me.dgv_centros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_centros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_centros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.Telefono, Me.Mail, Me.Propio, Me.calle, Me.numero, Me.Barrio, Me.Localidad, Me.Provincia, Me.col_idCentro, Me.col_idDomicilio})
        Me.dgv_centros.Location = New System.Drawing.Point(508, 12)
        Me.dgv_centros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_centros.Name = "dgv_centros"
        Me.dgv_centros.ReadOnly = True
        Me.dgv_centros.RowTemplate.Height = 24
        Me.dgv_centros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_centros.Size = New System.Drawing.Size(463, 391)
        Me.dgv_centros.TabIndex = 7
        '
        'nombre
        '
        Me.nombre.HeaderText = "Denominación"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 300
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Mail
        '
        Me.Mail.HeaderText = "Mail"
        Me.Mail.Name = "Mail"
        Me.Mail.ReadOnly = True
        '
        'Propio
        '
        Me.Propio.HeaderText = "Propio"
        Me.Propio.Name = "Propio"
        Me.Propio.ReadOnly = True
        '
        'calle
        '
        Me.calle.HeaderText = "Calle"
        Me.calle.Name = "calle"
        Me.calle.ReadOnly = True
        '
        'numero
        '
        Me.numero.HeaderText = "Numero"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        '
        'Barrio
        '
        Me.Barrio.HeaderText = "Barrio"
        Me.Barrio.Name = "Barrio"
        Me.Barrio.ReadOnly = True
        '
        'Localidad
        '
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'Provincia
        '
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        Me.Provincia.ReadOnly = True
        '
        'col_idCentro
        '
        Me.col_idCentro.HeaderText = "id_centro"
        Me.col_idCentro.Name = "col_idCentro"
        Me.col_idCentro.ReadOnly = True
        Me.col_idCentro.Visible = False
        '
        'col_idDomicilio
        '
        Me.col_idDomicilio.HeaderText = "Id Domicilio"
        Me.col_idDomicilio.Name = "col_idDomicilio"
        Me.col_idDomicilio.ReadOnly = True
        Me.col_idDomicilio.Visible = False
        '
        'frm_registrar_centroMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(983, 500)
        Me.Controls.Add(Me.dgv_centros)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Grabar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_registrar_centroMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Centro Medico"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_centros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_datosDomicilio As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents lbl_direccion As System.Windows.Forms.Label
    Friend WithEvents lbl_barrio As System.Windows.Forms.Label
    Friend WithEvents txt_altura As System.Windows.Forms.TextBox
    Friend WithEvents lbl_altura As System.Windows.Forms.Label
    Friend WithEvents lbl_provincia As System.Windows.Forms.Label
    Friend WithEvents cbo_localidades As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents cbo_barrios As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_provincias As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_datosCentro As System.Windows.Forms.Label
    Friend WithEvents lbl_esPropio As System.Windows.Forms.Label
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Grabar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_centros As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_esPropio As System.Windows.Forms.ComboBox
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Propio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Barrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idCentro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
