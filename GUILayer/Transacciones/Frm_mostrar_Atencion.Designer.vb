<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mostrar_atencion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mostrar_atencion))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_centro = New System.Windows.Forms.Label()
        Me.grp_practicas = New System.Windows.Forms.GroupBox()
        Me.dgv_practicas = New System.Windows.Forms.DataGridView()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.txt_porcenCobertura = New System.Windows.Forms.TextBox()
        Me.lbl_cobertura = New System.Windows.Forms.Label()
        Me.cbo_practicas = New System.Windows.Forms.ComboBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_practica = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.lbl_preciocc = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.MaskedTextBox()
        Me.txt_preciocc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_preciosc = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_total_sc = New System.Windows.Forms.Label()
        Me.lbl_total_cc = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.txt_total_cc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_total_sc = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_nroDocAfil = New System.Windows.Forms.TextBox()
        Me.txt_n_afiliado = New System.Windows.Forms.TextBox()
        Me.lbl_afiliado = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.cbo_centros = New System.Windows.Forms.ComboBox()
        Me.lbl_especialidad = New System.Windows.Forms.Label()
        Me.lbl_profesional = New System.Windows.Forms.Label()
        Me.cbo_especialidades = New System.Windows.Forms.ComboBox()
        Me.cbo_profesionales = New System.Windows.Forms.ComboBox()
        Me.cbo_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.lbl_nombreAfil = New System.Windows.Forms.Label()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_practica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_preciosc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cobertura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_preciocc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_practicas.SuspendLayout()
        CType(Me.dgv_practicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(48, 23)
        Me.lbl_fecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(57, 18)
        Me.lbl_fecha.TabIndex = 0
        Me.lbl_fecha.Text = "Fecha: "
        '
        'lbl_centro
        '
        Me.lbl_centro.AutoSize = True
        Me.lbl_centro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_centro.Location = New System.Drawing.Point(44, 66)
        Me.lbl_centro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_centro.Name = "lbl_centro"
        Me.lbl_centro.Size = New System.Drawing.Size(61, 18)
        Me.lbl_centro.TabIndex = 0
        Me.lbl_centro.Text = "Centro: "
        '
        'grp_practicas
        '
        Me.grp_practicas.Controls.Add(Me.dgv_practicas)
        Me.grp_practicas.Controls.Add(Me.txt_cantidad)
        Me.grp_practicas.Controls.Add(Me.lbl_cantidad)
        Me.grp_practicas.Controls.Add(Me.txt_porcenCobertura)
        Me.grp_practicas.Controls.Add(Me.lbl_cobertura)
        Me.grp_practicas.Controls.Add(Me.cbo_practicas)
        Me.grp_practicas.Controls.Add(Me.btn_agregar)
        Me.grp_practicas.Controls.Add(Me.lbl_practica)
        Me.grp_practicas.Controls.Add(Me.lbl_subtotal)
        Me.grp_practicas.Controls.Add(Me.lbl_preciocc)
        Me.grp_practicas.Controls.Add(Me.lbl_precio)
        Me.grp_practicas.Controls.Add(Me.txt_subtotal)
        Me.grp_practicas.Controls.Add(Me.txt_preciocc)
        Me.grp_practicas.Controls.Add(Me.txt_preciosc)
        Me.grp_practicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp_practicas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp_practicas.Location = New System.Drawing.Point(15, 192)
        Me.grp_practicas.Margin = New System.Windows.Forms.Padding(4)
        Me.grp_practicas.Name = "grp_practicas"
        Me.grp_practicas.Padding = New System.Windows.Forms.Padding(4)
        Me.grp_practicas.Size = New System.Drawing.Size(876, 392)
        Me.grp_practicas.TabIndex = 4
        Me.grp_practicas.TabStop = False
        '
        'dgv_practicas
        '
        Me.dgv_practicas.AllowUserToAddRows = False
        Me.dgv_practicas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_practicas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_practicas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_practicas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_practica, Me.col_preciosc, Me.col_cobertura, Me.col_preciocc, Me.col_cantidad, Me.col_subtotal})
        Me.dgv_practicas.Location = New System.Drawing.Point(9, 120)
        Me.dgv_practicas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_practicas.Name = "dgv_practicas"
        Me.dgv_practicas.RowHeadersWidth = 20
        Me.dgv_practicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_practicas.Size = New System.Drawing.Size(854, 262)
        Me.dgv_practicas.TabIndex = 13
        '
        'txt_cantidad
        '
        Me.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(560, 73)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(81, 24)
        Me.txt_cantidad.TabIndex = 12
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantidad.Location = New System.Drawing.Point(492, 77)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(70, 18)
        Me.lbl_cantidad.TabIndex = 11
        Me.lbl_cantidad.Text = "Cantidad:"
        '
        'txt_porcenCobertura
        '
        Me.txt_porcenCobertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_porcenCobertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_porcenCobertura.Location = New System.Drawing.Point(239, 76)
        Me.txt_porcenCobertura.Name = "txt_porcenCobertura"
        Me.txt_porcenCobertura.Size = New System.Drawing.Size(82, 24)
        Me.txt_porcenCobertura.TabIndex = 10
        '
        'lbl_cobertura
        '
        Me.lbl_cobertura.AutoSize = True
        Me.lbl_cobertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cobertura.Location = New System.Drawing.Point(139, 80)
        Me.lbl_cobertura.Name = "lbl_cobertura"
        Me.lbl_cobertura.Size = New System.Drawing.Size(101, 18)
        Me.lbl_cobertura.TabIndex = 9
        Me.lbl_cobertura.Text = "Cobertura(%):"
        '
        'cbo_practicas
        '
        Me.cbo_practicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_practicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_practicas.FormattingEnabled = True
        Me.cbo_practicas.Location = New System.Drawing.Point(74, 30)
        Me.cbo_practicas.Name = "cbo_practicas"
        Me.cbo_practicas.Size = New System.Drawing.Size(375, 26)
        Me.cbo_practicas.TabIndex = 8
        '
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(773, 69)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(90, 28)
        Me.btn_agregar.TabIndex = 6
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lbl_practica
        '
        Me.lbl_practica.AutoSize = True
        Me.lbl_practica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_practica.Location = New System.Drawing.Point(9, 34)
        Me.lbl_practica.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_practica.Name = "lbl_practica"
        Me.lbl_practica.Size = New System.Drawing.Size(66, 18)
        Me.lbl_practica.TabIndex = 0
        Me.lbl_practica.Text = "Practica:"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(645, 76)
        Me.lbl_subtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(45, 18)
        Me.lbl_subtotal.TabIndex = 0
        Me.lbl_subtotal.Text = "Total:"
        '
        'lbl_preciocc
        '
        Me.lbl_preciocc.AutoSize = True
        Me.lbl_preciocc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preciocc.Location = New System.Drawing.Point(325, 79)
        Me.lbl_preciocc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_preciocc.Name = "lbl_preciocc"
        Me.lbl_preciocc.Size = New System.Drawing.Size(85, 18)
        Me.lbl_preciocc.TabIndex = 0
        Me.lbl_preciocc.Text = "Precio C/C:"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.Location = New System.Drawing.Point(10, 82)
        Me.lbl_precio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(55, 18)
        Me.lbl_precio.TabIndex = 0
        Me.lbl_precio.Text = "Precio:"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.Location = New System.Drawing.Point(688, 71)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(77, 24)
        Me.txt_subtotal.TabIndex = 5
        Me.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_preciocc
        '
        Me.txt_preciocc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_preciocc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preciocc.Location = New System.Drawing.Point(410, 75)
        Me.txt_preciocc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_preciocc.Name = "txt_preciocc"
        Me.txt_preciocc.Size = New System.Drawing.Size(77, 24)
        Me.txt_preciocc.TabIndex = 4
        Me.txt_preciocc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_preciosc
        '
        Me.txt_preciosc.AccessibleDescription = ""
        Me.txt_preciosc.AllowPromptAsInput = False
        Me.txt_preciosc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_preciosc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preciosc.Location = New System.Drawing.Point(65, 77)
        Me.txt_preciosc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_preciosc.Name = "txt_preciosc"
        Me.txt_preciosc.Size = New System.Drawing.Size(70, 24)
        Me.txt_preciosc.SkipLiterals = False
        Me.txt_preciosc.TabIndex = 3
        Me.txt_preciosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_total_sc
        '
        Me.lbl_total_sc.AutoSize = True
        Me.lbl_total_sc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_sc.Location = New System.Drawing.Point(662, 604)
        Me.lbl_total_sc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total_sc.Name = "lbl_total_sc"
        Me.lbl_total_sc.Size = New System.Drawing.Size(69, 18)
        Me.lbl_total_sc.TabIndex = 0
        Me.lbl_total_sc.Text = "Total s/c:"
        '
        'lbl_total_cc
        '
        Me.lbl_total_cc.AutoSize = True
        Me.lbl_total_cc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_cc.Location = New System.Drawing.Point(664, 638)
        Me.lbl_total_cc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total_cc.Name = "lbl_total_cc"
        Me.lbl_total_cc.Size = New System.Drawing.Size(69, 18)
        Me.lbl_total_cc.TabIndex = 0
        Me.lbl_total_cc.Text = "Total c/c:"
        '
        'btn_salir
        '
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(334, 15)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(47, 43)
        Me.btn_salir.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btn_salir, "Salir del Formulario")
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.Location = New System.Drawing.Point(69, 15)
        Me.btn_grabar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(47, 43)
        Me.btn_grabar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btn_grabar, "Grabar")
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.Silver
        Me.btn_modificar.Image = CType(resources.GetObject("btn_modificar.Image"), System.Drawing.Image)
        Me.btn_modificar.Location = New System.Drawing.Point(8, 13)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(53, 48)
        Me.btn_modificar.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btn_modificar, "Grabar")
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'txt_total_cc
        '
        Me.txt_total_cc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_cc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_cc.Location = New System.Drawing.Point(737, 635)
        Me.txt_total_cc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total_cc.Name = "txt_total_cc"
        Me.txt_total_cc.ReadOnly = True
        Me.txt_total_cc.Size = New System.Drawing.Size(140, 24)
        Me.txt_total_cc.TabIndex = 8
        Me.txt_total_cc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_total_sc
        '
        Me.txt_total_sc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_sc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_sc.Location = New System.Drawing.Point(738, 598)
        Me.txt_total_sc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total_sc.Name = "txt_total_sc"
        Me.txt_total_sc.ReadOnly = True
        Me.txt_total_sc.Size = New System.Drawing.Size(140, 24)
        Me.txt_total_sc.TabIndex = 6
        Me.txt_total_sc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_modificar)
        Me.GroupBox2.Controls.Add(Me.btn_salir)
        Me.GroupBox2.Controls.Add(Me.btn_grabar)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 625)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(387, 66)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'txt_nroDocAfil
        '
        Me.txt_nroDocAfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nroDocAfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nroDocAfil.Location = New System.Drawing.Point(186, 146)
        Me.txt_nroDocAfil.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nroDocAfil.Name = "txt_nroDocAfil"
        Me.txt_nroDocAfil.Size = New System.Drawing.Size(184, 24)
        Me.txt_nroDocAfil.TabIndex = 9
        '
        'txt_n_afiliado
        '
        Me.txt_n_afiliado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_n_afiliado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_n_afiliado.Location = New System.Drawing.Point(483, 145)
        Me.txt_n_afiliado.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_n_afiliado.Name = "txt_n_afiliado"
        Me.txt_n_afiliado.Size = New System.Drawing.Size(222, 24)
        Me.txt_n_afiliado.TabIndex = 9
        '
        'lbl_afiliado
        '
        Me.lbl_afiliado.AutoSize = True
        Me.lbl_afiliado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_afiliado.Location = New System.Drawing.Point(44, 148)
        Me.lbl_afiliado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_afiliado.Name = "lbl_afiliado"
        Me.lbl_afiliado.Size = New System.Drawing.Size(59, 18)
        Me.lbl_afiliado.TabIndex = 10
        Me.lbl_afiliado.Text = "Afiliado:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Location = New System.Drawing.Point(104, 19)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(296, 24)
        Me.dtp_fecha.TabIndex = 12
        '
        'cbo_centros
        '
        Me.cbo_centros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_centros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_centros.FormattingEnabled = True
        Me.cbo_centros.Location = New System.Drawing.Point(106, 62)
        Me.cbo_centros.Name = "cbo_centros"
        Me.cbo_centros.Size = New System.Drawing.Size(264, 26)
        Me.cbo_centros.TabIndex = 13
        '
        'lbl_especialidad
        '
        Me.lbl_especialidad.AutoSize = True
        Me.lbl_especialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_especialidad.Location = New System.Drawing.Point(390, 64)
        Me.lbl_especialidad.Name = "lbl_especialidad"
        Me.lbl_especialidad.Size = New System.Drawing.Size(99, 18)
        Me.lbl_especialidad.TabIndex = 14
        Me.lbl_especialidad.Text = "Especialidad: "
        '
        'lbl_profesional
        '
        Me.lbl_profesional.AutoSize = True
        Me.lbl_profesional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profesional.Location = New System.Drawing.Point(21, 106)
        Me.lbl_profesional.Name = "lbl_profesional"
        Me.lbl_profesional.Size = New System.Drawing.Size(91, 18)
        Me.lbl_profesional.TabIndex = 15
        Me.lbl_profesional.Text = "Profesional: "
        '
        'cbo_especialidades
        '
        Me.cbo_especialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_especialidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_especialidades.FormattingEnabled = True
        Me.cbo_especialidades.Location = New System.Drawing.Point(483, 59)
        Me.cbo_especialidades.Name = "cbo_especialidades"
        Me.cbo_especialidades.Size = New System.Drawing.Size(222, 26)
        Me.cbo_especialidades.TabIndex = 16
        '
        'cbo_profesionales
        '
        Me.cbo_profesionales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_profesionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_profesionales.FormattingEnabled = True
        Me.cbo_profesionales.Location = New System.Drawing.Point(106, 100)
        Me.cbo_profesionales.Name = "cbo_profesionales"
        Me.cbo_profesionales.Size = New System.Drawing.Size(264, 26)
        Me.cbo_profesionales.TabIndex = 17
        '
        'cbo_tipoDoc
        '
        Me.cbo_tipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipoDoc.FormattingEnabled = True
        Me.cbo_tipoDoc.Location = New System.Drawing.Point(106, 144)
        Me.cbo_tipoDoc.Name = "cbo_tipoDoc"
        Me.cbo_tipoDoc.Size = New System.Drawing.Size(73, 26)
        Me.cbo_tipoDoc.TabIndex = 18
        '
        'lbl_nombreAfil
        '
        Me.lbl_nombreAfil.AutoSize = True
        Me.lbl_nombreAfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombreAfil.Location = New System.Drawing.Point(397, 147)
        Me.lbl_nombreAfil.Name = "lbl_nombreAfil"
        Me.lbl_nombreAfil.Size = New System.Drawing.Size(70, 18)
        Me.lbl_nombreAfil.TabIndex = 19
        Me.lbl_nombreAfil.Text = "Nombre: "
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_estado.Location = New System.Drawing.Point(724, 17)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(59, 18)
        Me.lbl_estado.TabIndex = 20
        Me.lbl_estado.Text = "Estado:"
        '
        'txt_estado
        '
        Me.txt_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_estado.Location = New System.Drawing.Point(782, 14)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(109, 24)
        Me.txt_estado.TabIndex = 21
        '
        'txt_total
        '
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(737, 667)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(140, 24)
        Me.txt_total.TabIndex = 22
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(680, 669)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(51, 18)
        Me.lbl_total.TabIndex = 23
        Me.lbl_total.Text = "Total:"
        '
        'col_codigo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col_codigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_codigo.HeaderText = "Código"
        Me.col_codigo.Name = "col_codigo"
        Me.col_codigo.Width = 70
        '
        'col_practica
        '
        Me.col_practica.HeaderText = "Práctica"
        Me.col_practica.Name = "col_practica"
        Me.col_practica.Width = 300
        '
        'col_preciosc
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.col_preciosc.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_preciosc.HeaderText = "Precio S/C"
        Me.col_preciosc.Name = "col_preciosc"
        Me.col_preciosc.Width = 62
        '
        'col_cobertura
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.col_cobertura.DefaultCellStyle = DataGridViewCellStyle4
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.col_subtotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_subtotal.HeaderText = "Importe a abonar"
        Me.col_subtotal.Name = "col_subtotal"
        Me.col_subtotal.Width = 130
        '
        'frm_mostrar_atencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(909, 709)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.lbl_nombreAfil)
        Me.Controls.Add(Me.cbo_tipoDoc)
        Me.Controls.Add(Me.cbo_profesionales)
        Me.Controls.Add(Me.cbo_especialidades)
        Me.Controls.Add(Me.lbl_profesional)
        Me.Controls.Add(Me.lbl_especialidad)
        Me.Controls.Add(Me.cbo_centros)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.lbl_afiliado)
        Me.Controls.Add(Me.txt_n_afiliado)
        Me.Controls.Add(Me.txt_nroDocAfil)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_total_cc)
        Me.Controls.Add(Me.txt_total_sc)
        Me.Controls.Add(Me.grp_practicas)
        Me.Controls.Add(Me.lbl_total_cc)
        Me.Controls.Add(Me.lbl_total_sc)
        Me.Controls.Add(Me.lbl_centro)
        Me.Controls.Add(Me.lbl_fecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_mostrar_atencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mostrar Atención"
        Me.grp_practicas.ResumeLayout(False)
        Me.grp_practicas.PerformLayout()
        CType(Me.dgv_practicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_centro As System.Windows.Forms.Label
    Friend WithEvents grp_practicas As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_precio As System.Windows.Forms.Label
    Friend WithEvents lbl_practica As System.Windows.Forms.Label
    Friend WithEvents lbl_subtotal As System.Windows.Forms.Label
    Friend WithEvents lbl_preciocc As System.Windows.Forms.Label
    Friend WithEvents txt_subtotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_preciocc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_preciosc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_total_sc As System.Windows.Forms.Label
    Friend WithEvents lbl_total_cc As System.Windows.Forms.Label
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_total_cc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_total_sc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nroDocAfil As System.Windows.Forms.TextBox
    Friend WithEvents txt_n_afiliado As System.Windows.Forms.TextBox
    Friend WithEvents lbl_afiliado As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_centros As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_especialidad As System.Windows.Forms.Label
    Friend WithEvents lbl_profesional As System.Windows.Forms.Label
    Friend WithEvents cbo_especialidades As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_profesionales As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_nombreAfil As System.Windows.Forms.Label
    Friend WithEvents cbo_practicas As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents txt_porcenCobertura As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cobertura As System.Windows.Forms.Label
    Friend WithEvents dgv_practicas As System.Windows.Forms.DataGridView
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents txt_estado As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_practica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_preciosc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cobertura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_preciocc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_subtotal As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
