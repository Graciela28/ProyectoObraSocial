<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_Atencion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrar_Atencion))
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_centro = New System.Windows.Forms.Label()
        Me.grp_detalles = New System.Windows.Forms.GroupBox()
        Me.txt_preciocc = New System.Windows.Forms.TextBox()
        Me.lbl_preciocc = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.txt_cobertura = New System.Windows.Forms.TextBox()
        Me.lbl_cobertura = New System.Windows.Forms.Label()
        Me.cbo_practicas = New System.Windows.Forms.ComboBox()
        Me.lbl_Practica = New System.Windows.Forms.Label()
        Me.dgv_practicas = New System.Windows.Forms.DataGridView()
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_practica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_preciosc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cobertura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_preciocc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregarAGrilla = New System.Windows.Forms.Button()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.lbl_preciosc = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.MaskedTextBox()
        Me.txt_preciosc = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_total_cc = New System.Windows.Forms.Label()
        Me.lbl_total_sc = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_buscar2 = New System.Windows.Forms.Button()
        Me.txt_total_sc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_total_cc = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_docAfiliado = New System.Windows.Forms.TextBox()
        Me.txt_n_afiliado = New System.Windows.Forms.TextBox()
        Me.lbl_Afiliado = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.cbo_centros = New System.Windows.Forms.ComboBox()
        Me.lbl_especialidad = New System.Windows.Forms.Label()
        Me.cbo_especialidades = New System.Windows.Forms.ComboBox()
        Me.lbl_profesional = New System.Windows.Forms.Label()
        Me.cbo_profesionales = New System.Windows.Forms.ComboBox()
        Me.btn_verHistorial = New System.Windows.Forms.Button()
        Me.cbo_tiposDocumento = New System.Windows.Forms.ComboBox()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.grp_detalles.SuspendLayout()
        CType(Me.dgv_practicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(48, 29)
        Me.lbl_fecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(53, 18)
        Me.lbl_fecha.TabIndex = 0
        Me.lbl_fecha.Text = "Fecha:"
        '
        'lbl_centro
        '
        Me.lbl_centro.AutoSize = True
        Me.lbl_centro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_centro.Location = New System.Drawing.Point(42, 66)
        Me.lbl_centro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_centro.Name = "lbl_centro"
        Me.lbl_centro.Size = New System.Drawing.Size(57, 18)
        Me.lbl_centro.TabIndex = 0
        Me.lbl_centro.Text = "Centro:"
        '
        'grp_detalles
        '
        Me.grp_detalles.Controls.Add(Me.txt_preciocc)
        Me.grp_detalles.Controls.Add(Me.lbl_preciocc)
        Me.grp_detalles.Controls.Add(Me.txt_cantidad)
        Me.grp_detalles.Controls.Add(Me.lbl_cantidad)
        Me.grp_detalles.Controls.Add(Me.txt_cobertura)
        Me.grp_detalles.Controls.Add(Me.lbl_cobertura)
        Me.grp_detalles.Controls.Add(Me.cbo_practicas)
        Me.grp_detalles.Controls.Add(Me.lbl_Practica)
        Me.grp_detalles.Controls.Add(Me.dgv_practicas)
        Me.grp_detalles.Controls.Add(Me.btn_agregarAGrilla)
        Me.grp_detalles.Controls.Add(Me.lbl_subtotal)
        Me.grp_detalles.Controls.Add(Me.lbl_preciosc)
        Me.grp_detalles.Controls.Add(Me.txt_subtotal)
        Me.grp_detalles.Controls.Add(Me.txt_preciosc)
        Me.grp_detalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp_detalles.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp_detalles.Location = New System.Drawing.Point(15, 189)
        Me.grp_detalles.Margin = New System.Windows.Forms.Padding(4)
        Me.grp_detalles.Name = "grp_detalles"
        Me.grp_detalles.Padding = New System.Windows.Forms.Padding(4)
        Me.grp_detalles.Size = New System.Drawing.Size(835, 390)
        Me.grp_detalles.TabIndex = 10
        Me.grp_detalles.TabStop = False
        '
        'txt_preciocc
        '
        Me.txt_preciocc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_preciocc.Location = New System.Drawing.Point(396, 68)
        Me.txt_preciocc.Name = "txt_preciocc"
        Me.txt_preciocc.Size = New System.Drawing.Size(82, 24)
        Me.txt_preciocc.TabIndex = 14
        '
        'lbl_preciocc
        '
        Me.lbl_preciocc.AutoSize = True
        Me.lbl_preciocc.Location = New System.Drawing.Point(315, 72)
        Me.lbl_preciocc.Name = "lbl_preciocc"
        Me.lbl_preciocc.Size = New System.Drawing.Size(85, 18)
        Me.lbl_preciocc.TabIndex = 13
        Me.lbl_preciocc.Text = "Precio C/C:"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad.Location = New System.Drawing.Point(545, 67)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(58, 24)
        Me.txt_cantidad.TabIndex = 3
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(478, 71)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(70, 18)
        Me.lbl_cantidad.TabIndex = 12
        Me.lbl_cantidad.Text = "Cantidad:"
        '
        'txt_cobertura
        '
        Me.txt_cobertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cobertura.Location = New System.Drawing.Point(251, 68)
        Me.txt_cobertura.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cobertura.Name = "txt_cobertura"
        Me.txt_cobertura.Size = New System.Drawing.Size(62, 24)
        Me.txt_cobertura.TabIndex = 2
        '
        'lbl_cobertura
        '
        Me.lbl_cobertura.AutoSize = True
        Me.lbl_cobertura.Location = New System.Drawing.Point(149, 69)
        Me.lbl_cobertura.Name = "lbl_cobertura"
        Me.lbl_cobertura.Size = New System.Drawing.Size(105, 18)
        Me.lbl_cobertura.TabIndex = 10
        Me.lbl_cobertura.Text = "Cobertura (%):"
        '
        'cbo_practicas
        '
        Me.cbo_practicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_practicas.FormattingEnabled = True
        Me.cbo_practicas.Location = New System.Drawing.Point(93, 24)
        Me.cbo_practicas.Name = "cbo_practicas"
        Me.cbo_practicas.Size = New System.Drawing.Size(369, 26)
        Me.cbo_practicas.TabIndex = 0
        '
        'lbl_Practica
        '
        Me.lbl_Practica.AutoSize = True
        Me.lbl_Practica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Practica.Location = New System.Drawing.Point(20, 32)
        Me.lbl_Practica.Name = "lbl_Practica"
        Me.lbl_Practica.Size = New System.Drawing.Size(66, 18)
        Me.lbl_Practica.TabIndex = 8
        Me.lbl_Practica.Text = "Práctica:"
        '
        'dgv_practicas
        '
        Me.dgv_practicas.AllowUserToAddRows = False
        Me.dgv_practicas.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_practicas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_practicas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_practicas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_practica, Me.col_preciosc, Me.col_cobertura, Me.col_preciocc, Me.col_cantidad, Me.col_subtotal})
        Me.dgv_practicas.Location = New System.Drawing.Point(20, 108)
        Me.dgv_practicas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_practicas.Name = "dgv_practicas"
        Me.dgv_practicas.RowHeadersWidth = 20
        Me.dgv_practicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_practicas.Size = New System.Drawing.Size(798, 269)
        Me.dgv_practicas.TabIndex = 6
        '
        'col_codigo
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col_codigo.DefaultCellStyle = DataGridViewCellStyle12
        Me.col_codigo.HeaderText = "Código"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.Width = 80
        '
        'col_practica
        '
        Me.col_practica.HeaderText = "Práctica"
        Me.col_practica.Name = "col_practica"
        Me.col_practica.Width = 300
        '
        'col_preciosc
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.col_preciosc.DefaultCellStyle = DataGridViewCellStyle13
        Me.col_preciosc.HeaderText = "Precio S/C"
        Me.col_preciosc.Name = "col_preciosc"
        Me.col_preciosc.Width = 62
        '
        'col_cobertura
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.col_cobertura.DefaultCellStyle = DataGridViewCellStyle14
        Me.col_cobertura.HeaderText = "Cobertura (%)"
        Me.col_cobertura.Name = "col_cobertura"
        '
        'col_preciocc
        '
        Me.col_preciocc.HeaderText = "Precio C/C"
        Me.col_preciocc.Name = "col_preciocc"
        '
        'col_cantidad
        '
        Me.col_cantidad.HeaderText = "Cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Width = 70
        '
        'col_subtotal
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.col_subtotal.DefaultCellStyle = DataGridViewCellStyle15
        Me.col_subtotal.HeaderText = "Importe a abonar"
        Me.col_subtotal.Name = "col_subtotal"
        Me.col_subtotal.Width = 200
        '
        'btn_agregarAGrilla
        '
        Me.btn_agregarAGrilla.Location = New System.Drawing.Point(741, 64)
        Me.btn_agregarAGrilla.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agregarAGrilla.Name = "btn_agregarAGrilla"
        Me.btn_agregarAGrilla.Size = New System.Drawing.Size(81, 32)
        Me.btn_agregarAGrilla.TabIndex = 5
        Me.btn_agregarAGrilla.Text = "Agregar"
        Me.btn_agregarAGrilla.UseVisualStyleBackColor = True
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(606, 71)
        Me.lbl_subtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(45, 18)
        Me.lbl_subtotal.TabIndex = 0
        Me.lbl_subtotal.Text = "Total:"
        '
        'lbl_preciosc
        '
        Me.lbl_preciosc.AutoSize = True
        Me.lbl_preciosc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preciosc.Location = New System.Drawing.Point(19, 70)
        Me.lbl_preciosc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_preciosc.Name = "lbl_preciosc"
        Me.lbl_preciosc.Size = New System.Drawing.Size(55, 18)
        Me.lbl_preciosc.TabIndex = 0
        Me.lbl_preciosc.Text = "Precio:"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subtotal.Location = New System.Drawing.Point(651, 67)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(86, 24)
        Me.txt_subtotal.TabIndex = 4
        Me.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_preciosc
        '
        Me.txt_preciosc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_preciosc.Location = New System.Drawing.Point(73, 67)
        Me.txt_preciosc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_preciosc.Name = "txt_preciosc"
        Me.txt_preciosc.Size = New System.Drawing.Size(74, 24)
        Me.txt_preciosc.TabIndex = 1
        Me.txt_preciosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_total_cc
        '
        Me.lbl_total_cc.AutoSize = True
        Me.lbl_total_cc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_cc.Location = New System.Drawing.Point(663, 640)
        Me.lbl_total_cc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total_cc.Name = "lbl_total_cc"
        Me.lbl_total_cc.Size = New System.Drawing.Size(69, 18)
        Me.lbl_total_cc.TabIndex = 0
        Me.lbl_total_cc.Text = "Total c/c:"
        '
        'lbl_total_sc
        '
        Me.lbl_total_sc.AutoSize = True
        Me.lbl_total_sc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_sc.Location = New System.Drawing.Point(662, 607)
        Me.lbl_total_sc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total_sc.Name = "lbl_total_sc"
        Me.lbl_total_sc.Size = New System.Drawing.Size(69, 18)
        Me.lbl_total_sc.TabIndex = 0
        Me.lbl_total_sc.Text = "Total s/c:"
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Silver
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(367, 19)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(53, 48)
        Me.btn_salir.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btn_salir, "Salir del Formulario")
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.Color.Silver
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.Location = New System.Drawing.Point(69, 19)
        Me.btn_grabar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(53, 48)
        Me.btn_grabar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btn_grabar, "Grabar")
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.Silver
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(8, 19)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(53, 48)
        Me.btn_nuevo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btn_nuevo, "Nuevo")
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_buscar2
        '
        Me.btn_buscar2.BackColor = System.Drawing.Color.Silver
        Me.btn_buscar2.Image = CType(resources.GetObject("btn_buscar2.Image"), System.Drawing.Image)
        Me.btn_buscar2.Location = New System.Drawing.Point(130, 18)
        Me.btn_buscar2.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_buscar2.Name = "btn_buscar2"
        Me.btn_buscar2.Size = New System.Drawing.Size(53, 48)
        Me.btn_buscar2.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btn_buscar2, "Grabar")
        Me.btn_buscar2.UseVisualStyleBackColor = False
        '
        'txt_total_sc
        '
        Me.txt_total_sc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_sc.Location = New System.Drawing.Point(736, 603)
        Me.txt_total_sc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total_sc.Name = "txt_total_sc"
        Me.txt_total_sc.ReadOnly = True
        Me.txt_total_sc.Size = New System.Drawing.Size(114, 24)
        Me.txt_total_sc.TabIndex = 13
        Me.txt_total_sc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_total_cc
        '
        Me.txt_total_cc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_cc.Location = New System.Drawing.Point(736, 638)
        Me.txt_total_cc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total_cc.Name = "txt_total_cc"
        Me.txt_total_cc.ReadOnly = True
        Me.txt_total_cc.Size = New System.Drawing.Size(114, 24)
        Me.txt_total_cc.TabIndex = 11
        Me.txt_total_cc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_buscar2)
        Me.GroupBox2.Controls.Add(Me.btn_salir)
        Me.GroupBox2.Controls.Add(Me.btn_grabar)
        Me.GroupBox2.Controls.Add(Me.btn_nuevo)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 626)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(429, 74)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'txt_docAfiliado
        '
        Me.txt_docAfiliado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_docAfiliado.Location = New System.Drawing.Point(205, 147)
        Me.txt_docAfiliado.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_docAfiliado.MaxLength = 8
        Me.txt_docAfiliado.Name = "txt_docAfiliado"
        Me.txt_docAfiliado.Size = New System.Drawing.Size(144, 24)
        Me.txt_docAfiliado.TabIndex = 5
        '
        'txt_n_afiliado
        '
        Me.txt_n_afiliado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_n_afiliado.Location = New System.Drawing.Point(416, 148)
        Me.txt_n_afiliado.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_n_afiliado.Name = "txt_n_afiliado"
        Me.txt_n_afiliado.Size = New System.Drawing.Size(205, 24)
        Me.txt_n_afiliado.TabIndex = 7
        '
        'lbl_Afiliado
        '
        Me.lbl_Afiliado.AutoSize = True
        Me.lbl_Afiliado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Afiliado.Location = New System.Drawing.Point(40, 149)
        Me.lbl_Afiliado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Afiliado.Name = "lbl_Afiliado"
        Me.lbl_Afiliado.Size = New System.Drawing.Size(59, 18)
        Me.lbl_Afiliado.TabIndex = 10
        Me.lbl_Afiliado.Text = "Afiliado:"
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(362, 133)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(41, 39)
        Me.btn_buscar.TabIndex = 6
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(110, 25)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(287, 24)
        Me.dtp_fecha.TabIndex = 0
        '
        'cbo_centros
        '
        Me.cbo_centros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_centros.FormattingEnabled = True
        Me.cbo_centros.Location = New System.Drawing.Point(110, 63)
        Me.cbo_centros.Name = "cbo_centros"
        Me.cbo_centros.Size = New System.Drawing.Size(237, 26)
        Me.cbo_centros.TabIndex = 1
        '
        'lbl_especialidad
        '
        Me.lbl_especialidad.AutoSize = True
        Me.lbl_especialidad.Location = New System.Drawing.Point(413, 71)
        Me.lbl_especialidad.Name = "lbl_especialidad"
        Me.lbl_especialidad.Size = New System.Drawing.Size(95, 18)
        Me.lbl_especialidad.TabIndex = 14
        Me.lbl_especialidad.Text = "Especialidad:"
        '
        'cbo_especialidades
        '
        Me.cbo_especialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_especialidades.FormattingEnabled = True
        Me.cbo_especialidades.Location = New System.Drawing.Point(514, 65)
        Me.cbo_especialidades.Name = "cbo_especialidades"
        Me.cbo_especialidades.Size = New System.Drawing.Size(202, 26)
        Me.cbo_especialidades.TabIndex = 2
        '
        'lbl_profesional
        '
        Me.lbl_profesional.AutoSize = True
        Me.lbl_profesional.Location = New System.Drawing.Point(12, 104)
        Me.lbl_profesional.Name = "lbl_profesional"
        Me.lbl_profesional.Size = New System.Drawing.Size(87, 18)
        Me.lbl_profesional.TabIndex = 16
        Me.lbl_profesional.Text = "Profesional:"
        '
        'cbo_profesionales
        '
        Me.cbo_profesionales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_profesionales.FormattingEnabled = True
        Me.cbo_profesionales.Location = New System.Drawing.Point(110, 101)
        Me.cbo_profesionales.Name = "cbo_profesionales"
        Me.cbo_profesionales.Size = New System.Drawing.Size(237, 26)
        Me.cbo_profesionales.TabIndex = 3
        '
        'btn_verHistorial
        '
        Me.btn_verHistorial.Location = New System.Drawing.Point(628, 137)
        Me.btn_verHistorial.Name = "btn_verHistorial"
        Me.btn_verHistorial.Size = New System.Drawing.Size(106, 37)
        Me.btn_verHistorial.TabIndex = 9
        Me.btn_verHistorial.Text = "Ver Historial"
        Me.btn_verHistorial.UseVisualStyleBackColor = True
        '
        'cbo_tiposDocumento
        '
        Me.cbo_tiposDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tiposDocumento.FormattingEnabled = True
        Me.cbo_tiposDocumento.Location = New System.Drawing.Point(110, 146)
        Me.cbo_tiposDocumento.Name = "cbo_tiposDocumento"
        Me.cbo_tiposDocumento.Size = New System.Drawing.Size(88, 26)
        Me.cbo_tiposDocumento.TabIndex = 4
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(677, 23)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(59, 18)
        Me.lbl_estado.TabIndex = 17
        Me.lbl_estado.Text = "Estado:"
        '
        'txt_estado
        '
        Me.txt_estado.Location = New System.Drawing.Point(736, 19)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(114, 24)
        Me.txt_estado.TabIndex = 18
        '
        'txt_total
        '
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total.Location = New System.Drawing.Point(736, 670)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(114, 24)
        Me.txt_total.TabIndex = 19
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(681, 675)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(51, 18)
        Me.lbl_total.TabIndex = 20
        Me.lbl_total.Text = "Total:"
        '
        'frm_registrar_Atencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(882, 713)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.cbo_tiposDocumento)
        Me.Controls.Add(Me.btn_verHistorial)
        Me.Controls.Add(Me.cbo_profesionales)
        Me.Controls.Add(Me.lbl_profesional)
        Me.Controls.Add(Me.cbo_especialidades)
        Me.Controls.Add(Me.lbl_especialidad)
        Me.Controls.Add(Me.cbo_centros)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lbl_Afiliado)
        Me.Controls.Add(Me.txt_n_afiliado)
        Me.Controls.Add(Me.txt_docAfiliado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_total_sc)
        Me.Controls.Add(Me.txt_total_cc)
        Me.Controls.Add(Me.grp_detalles)
        Me.Controls.Add(Me.lbl_total_sc)
        Me.Controls.Add(Me.lbl_total_cc)
        Me.Controls.Add(Me.lbl_centro)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_registrar_Atencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Atención"
        Me.grp_detalles.ResumeLayout(False)
        Me.grp_detalles.PerformLayout()
        CType(Me.dgv_practicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_centro As System.Windows.Forms.Label
    Friend WithEvents grp_detalles As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_subtotal As System.Windows.Forms.Label
    Friend WithEvents lbl_preciosc As System.Windows.Forms.Label
    Friend WithEvents txt_subtotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_preciosc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dgv_practicas As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_total_cc As System.Windows.Forms.Label
    Friend WithEvents lbl_total_sc As System.Windows.Forms.Label
    Friend WithEvents btn_agregarAGrilla As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_total_sc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_total_cc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_docAfiliado As System.Windows.Forms.TextBox
    Friend WithEvents txt_n_afiliado As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Afiliado As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents cbo_practicas As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Practica As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_centros As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cobertura As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cobertura As System.Windows.Forms.Label
    Friend WithEvents lbl_especialidad As System.Windows.Forms.Label
    Friend WithEvents cbo_especialidades As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_profesional As System.Windows.Forms.Label
    Friend WithEvents cbo_profesionales As System.Windows.Forms.ComboBox
    Friend WithEvents btn_verHistorial As System.Windows.Forms.Button
    Friend WithEvents cbo_tiposDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents btn_buscar2 As System.Windows.Forms.Button
    Friend WithEvents txt_preciocc As System.Windows.Forms.TextBox
    Friend WithEvents lbl_preciocc As System.Windows.Forms.Label
    Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_practica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_preciosc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cobertura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_preciocc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents txt_estado As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_total As System.Windows.Forms.Label

End Class
