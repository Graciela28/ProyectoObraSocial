<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_buscar_atencion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_buscar_atencion))
        Me.dgv_historial = New System.Windows.Forms.DataGridView()
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipoAfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipodoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_numdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_afiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idtipoafiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_n_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idcentro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_centro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_profesional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Idespecialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha_alta_prof = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_idEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total_sc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total_cc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.lbl_fechaInicial = New System.Windows.Forms.Label()
        Me.lbl_fechaFinal = New System.Windows.Forms.Label()
        Me.btn_buscar2 = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_docAfiliado = New System.Windows.Forms.TextBox()
        Me.txt_nombreAfiliado = New System.Windows.Forms.TextBox()
        Me.dtp_fechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.cbo_tiposDocumento = New System.Windows.Forms.ComboBox()
        Me.btn_limpiarCampos = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.panel_filtros = New System.Windows.Forms.Panel()
        Me.chk_usoFiltros = New System.Windows.Forms.CheckBox()
        CType(Me.dgv_historial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_historial
        '
        Me.dgv_historial.AllowUserToAddRows = False
        Me.dgv_historial.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_historial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_historial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_historial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fecha, Me.col_tipoAfil, Me.col_tipodoc, Me.col_numdoc, Me.col_afiliado, Me.col_idtipoafiliado, Me.col_n_tipo, Me.col_idcentro, Me.col_centro, Me.col_matricula, Me.col_profesional, Me.col_Idespecialidad, Me.col_especialidad, Me.col_fecha_alta_prof, Me.col_idEstado, Me.col_estado, Me.col_total_sc, Me.col_total_cc, Me.col_total})
        Me.dgv_historial.Location = New System.Drawing.Point(20, 164)
        Me.dgv_historial.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_historial.Name = "dgv_historial"
        Me.dgv_historial.ReadOnly = True
        Me.dgv_historial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_historial.RowHeadersWidth = 30
        Me.dgv_historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_historial.Size = New System.Drawing.Size(655, 279)
        Me.dgv_historial.TabIndex = 7
        '
        'col_fecha
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.col_fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_fecha.HeaderText = "Fecha"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.ReadOnly = True
        Me.col_fecha.Width = 120
        '
        'col_tipoAfil
        '
        Me.col_tipoAfil.HeaderText = "Tipo"
        Me.col_tipoAfil.Name = "col_tipoAfil"
        Me.col_tipoAfil.ReadOnly = True
        Me.col_tipoAfil.Width = 50
        '
        'col_tipodoc
        '
        Me.col_tipodoc.HeaderText = "Tipo Doc Afil"
        Me.col_tipodoc.Name = "col_tipodoc"
        Me.col_tipodoc.ReadOnly = True
        Me.col_tipodoc.Visible = False
        '
        'col_numdoc
        '
        Me.col_numdoc.HeaderText = "Documento"
        Me.col_numdoc.Name = "col_numdoc"
        Me.col_numdoc.ReadOnly = True
        '
        'col_afiliado
        '
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.col_afiliado.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_afiliado.HeaderText = "Afiliado"
        Me.col_afiliado.Name = "col_afiliado"
        Me.col_afiliado.ReadOnly = True
        Me.col_afiliado.Width = 150
        '
        'col_idtipoafiliado
        '
        Me.col_idtipoafiliado.HeaderText = "Id Tipo Afil "
        Me.col_idtipoafiliado.Name = "col_idtipoafiliado"
        Me.col_idtipoafiliado.ReadOnly = True
        Me.col_idtipoafiliado.Visible = False
        '
        'col_n_tipo
        '
        Me.col_n_tipo.HeaderText = "Tipo "
        Me.col_n_tipo.Name = "col_n_tipo"
        Me.col_n_tipo.ReadOnly = True
        Me.col_n_tipo.Width = 80
        '
        'col_idcentro
        '
        Me.col_idcentro.HeaderText = "Id Centro"
        Me.col_idcentro.Name = "col_idcentro"
        Me.col_idcentro.ReadOnly = True
        Me.col_idcentro.Visible = False
        '
        'col_centro
        '
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.col_centro.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_centro.HeaderText = "Centro"
        Me.col_centro.Name = "col_centro"
        Me.col_centro.ReadOnly = True
        Me.col_centro.Width = 150
        '
        'col_matricula
        '
        Me.col_matricula.HeaderText = "Matricula"
        Me.col_matricula.Name = "col_matricula"
        Me.col_matricula.ReadOnly = True
        '
        'col_profesional
        '
        Me.col_profesional.HeaderText = "Profesional"
        Me.col_profesional.Name = "col_profesional"
        Me.col_profesional.ReadOnly = True
        Me.col_profesional.Width = 150
        '
        'col_Idespecialidad
        '
        Me.col_Idespecialidad.HeaderText = "Id Especialidad"
        Me.col_Idespecialidad.Name = "col_Idespecialidad"
        Me.col_Idespecialidad.ReadOnly = True
        Me.col_Idespecialidad.Visible = False
        '
        'col_especialidad
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.col_especialidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_especialidad.HeaderText = "Especialidad"
        Me.col_especialidad.Name = "col_especialidad"
        Me.col_especialidad.ReadOnly = True
        Me.col_especialidad.Width = 105
        '
        'col_fecha_alta_prof
        '
        Me.col_fecha_alta_prof.HeaderText = "Fecha alta Prof"
        Me.col_fecha_alta_prof.Name = "col_fecha_alta_prof"
        Me.col_fecha_alta_prof.ReadOnly = True
        Me.col_fecha_alta_prof.Visible = False
        '
        'col_idEstado
        '
        Me.col_idEstado.HeaderText = "IdEstado"
        Me.col_idEstado.Name = "col_idEstado"
        Me.col_idEstado.ReadOnly = True
        Me.col_idEstado.Visible = False
        '
        'col_estado
        '
        Me.col_estado.HeaderText = "Estado"
        Me.col_estado.Name = "col_estado"
        Me.col_estado.ReadOnly = True
        '
        'col_total_sc
        '
        Me.col_total_sc.HeaderText = "Total S/C"
        Me.col_total_sc.Name = "col_total_sc"
        Me.col_total_sc.ReadOnly = True
        Me.col_total_sc.Visible = False
        '
        'col_total_cc
        '
        Me.col_total_cc.HeaderText = "Total C/C"
        Me.col_total_cc.Name = "col_total_cc"
        Me.col_total_cc.ReadOnly = True
        Me.col_total_cc.Visible = False
        '
        'col_total
        '
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Silver
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(614, 452)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(63, 53)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'lbl_fechaInicial
        '
        Me.lbl_fechaInicial.AutoSize = True
        Me.lbl_fechaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaInicial.Location = New System.Drawing.Point(45, 9)
        Me.lbl_fechaInicial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_fechaInicial.Name = "lbl_fechaInicial"
        Me.lbl_fechaInicial.Size = New System.Drawing.Size(93, 18)
        Me.lbl_fechaInicial.TabIndex = 2
        Me.lbl_fechaInicial.Text = "Fecha Inicial:"
        '
        'lbl_fechaFinal
        '
        Me.lbl_fechaFinal.AutoSize = True
        Me.lbl_fechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaFinal.Location = New System.Drawing.Point(45, 40)
        Me.lbl_fechaFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_fechaFinal.Name = "lbl_fechaFinal"
        Me.lbl_fechaFinal.Size = New System.Drawing.Size(88, 18)
        Me.lbl_fechaFinal.TabIndex = 3
        Me.lbl_fechaFinal.Text = "Fecha Final:"
        '
        'btn_buscar2
        '
        Me.btn_buscar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar2.Location = New System.Drawing.Point(588, 119)
        Me.btn_buscar2.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_buscar2.Name = "btn_buscar2"
        Me.btn_buscar2.Size = New System.Drawing.Size(87, 28)
        Me.btn_buscar2.TabIndex = 6
        Me.btn_buscar2.Text = "Buscar"
        Me.btn_buscar2.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(309, 108)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(40, 38)
        Me.btn_buscar.TabIndex = 4
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Afiliado:"
        '
        'txt_docAfiliado
        '
        Me.txt_docAfiliado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_docAfiliado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_docAfiliado.Location = New System.Drawing.Point(186, 121)
        Me.txt_docAfiliado.MaxLength = 8
        Me.txt_docAfiliado.Name = "txt_docAfiliado"
        Me.txt_docAfiliado.Size = New System.Drawing.Size(114, 24)
        Me.txt_docAfiliado.TabIndex = 3
        '
        'txt_nombreAfiliado
        '
        Me.txt_nombreAfiliado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombreAfiliado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombreAfiliado.Location = New System.Drawing.Point(360, 120)
        Me.txt_nombreAfiliado.Name = "txt_nombreAfiliado"
        Me.txt_nombreAfiliado.Size = New System.Drawing.Size(225, 24)
        Me.txt_nombreAfiliado.TabIndex = 5
        '
        'dtp_fechaInicio
        '
        Me.dtp_fechaInicio.Location = New System.Drawing.Point(140, 6)
        Me.dtp_fechaInicio.Name = "dtp_fechaInicio"
        Me.dtp_fechaInicio.Size = New System.Drawing.Size(278, 22)
        Me.dtp_fechaInicio.TabIndex = 0
        '
        'dtp_fechaFinal
        '
        Me.dtp_fechaFinal.Location = New System.Drawing.Point(140, 40)
        Me.dtp_fechaFinal.Name = "dtp_fechaFinal"
        Me.dtp_fechaFinal.Size = New System.Drawing.Size(278, 22)
        Me.dtp_fechaFinal.TabIndex = 1
        '
        'cbo_tiposDocumento
        '
        Me.cbo_tiposDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tiposDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tiposDocumento.FormattingEnabled = True
        Me.cbo_tiposDocumento.Location = New System.Drawing.Point(83, 119)
        Me.cbo_tiposDocumento.Name = "cbo_tiposDocumento"
        Me.cbo_tiposDocumento.Size = New System.Drawing.Size(97, 26)
        Me.cbo_tiposDocumento.TabIndex = 2
        '
        'btn_limpiarCampos
        '
        Me.btn_limpiarCampos.BackColor = System.Drawing.Color.Silver
        Me.btn_limpiarCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiarCampos.Location = New System.Drawing.Point(291, 468)
        Me.btn_limpiarCampos.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_limpiarCampos.Name = "btn_limpiarCampos"
        Me.btn_limpiarCampos.Size = New System.Drawing.Size(131, 32)
        Me.btn_limpiarCampos.TabIndex = 14
        Me.btn_limpiarCampos.Text = "Limpiar Campos"
        Me.btn_limpiarCampos.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Silver
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(18, 454)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(53, 48)
        Me.btn_eliminar.TabIndex = 15
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'panel_filtros
        '
        Me.panel_filtros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_filtros.Controls.Add(Me.chk_usoFiltros)
        Me.panel_filtros.Controls.Add(Me.lbl_fechaInicial)
        Me.panel_filtros.Controls.Add(Me.dtp_fechaInicio)
        Me.panel_filtros.Controls.Add(Me.dtp_fechaFinal)
        Me.panel_filtros.Controls.Add(Me.lbl_fechaFinal)
        Me.panel_filtros.Location = New System.Drawing.Point(24, 12)
        Me.panel_filtros.Name = "panel_filtros"
        Me.panel_filtros.Size = New System.Drawing.Size(650, 76)
        Me.panel_filtros.TabIndex = 16
        '
        'chk_usoFiltros
        '
        Me.chk_usoFiltros.AutoSize = True
        Me.chk_usoFiltros.Location = New System.Drawing.Point(7, 5)
        Me.chk_usoFiltros.Name = "chk_usoFiltros"
        Me.chk_usoFiltros.Size = New System.Drawing.Size(18, 17)
        Me.chk_usoFiltros.TabIndex = 4
        Me.chk_usoFiltros.UseVisualStyleBackColor = True
        '
        'frm_buscar_atencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(693, 510)
        Me.Controls.Add(Me.panel_filtros)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_limpiarCampos)
        Me.Controls.Add(Me.cbo_tiposDocumento)
        Me.Controls.Add(Me.txt_nombreAfiliado)
        Me.Controls.Add(Me.txt_docAfiliado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_buscar2)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.dgv_historial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_buscar_atencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de Atenciones"
        CType(Me.dgv_historial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_filtros.ResumeLayout(False)
        Me.panel_filtros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_historial As System.Windows.Forms.DataGridView
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents lbl_fechaInicial As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaFinal As System.Windows.Forms.Label
    Friend WithEvents btn_buscar2 As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_docAfiliado As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombreAfiliado As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_tiposDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents btn_limpiarCampos As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents col_importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents panel_filtros As System.Windows.Forms.Panel
    Friend WithEvents chk_usoFiltros As System.Windows.Forms.CheckBox
    Friend WithEvents col_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipoAfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipodoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_numdoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_afiliado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idtipoafiliado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_n_tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idcentro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_centro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_matricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_profesional As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Idespecialidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_especialidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_alta_prof As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_total_sc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_total_cc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
