<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_registrar_Barrio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_registrar_Barrio))
        Me.cbo_provincias = New System.Windows.Forms.ComboBox()
        Me.lbl_Provincia = New System.Windows.Forms.Label()
        Me.cbo_localidades = New System.Windows.Forms.ComboBox()
        Me.lbl_localidad = New System.Windows.Forms.Label()
        Me.lbl_barrio = New System.Windows.Forms.Label()
        Me.txt_barrio = New System.Windows.Forms.TextBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Grabar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.dgv_barrios = New System.Windows.Forms.DataGridView()
        Me.col_idProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_IdLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_IdBarrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Salir = New System.Windows.Forms.Button()
        CType(Me.dgv_barrios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbo_provincias
        '
        Me.cbo_provincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_provincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_provincias.FormattingEnabled = True
        Me.cbo_provincias.Location = New System.Drawing.Point(81, 11)
        Me.cbo_provincias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_provincias.Name = "cbo_provincias"
        Me.cbo_provincias.Size = New System.Drawing.Size(181, 26)
        Me.cbo_provincias.TabIndex = 8
        '
        'lbl_Provincia
        '
        Me.lbl_Provincia.AutoSize = True
        Me.lbl_Provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Provincia.Location = New System.Drawing.Point(8, 16)
        Me.lbl_Provincia.Name = "lbl_Provincia"
        Me.lbl_Provincia.Size = New System.Drawing.Size(73, 18)
        Me.lbl_Provincia.TabIndex = 12
        Me.lbl_Provincia.Text = "Provincia:"
        '
        'cbo_localidades
        '
        Me.cbo_localidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_localidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_localidades.FormattingEnabled = True
        Me.cbo_localidades.Location = New System.Drawing.Point(389, 11)
        Me.cbo_localidades.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_localidades.Name = "cbo_localidades"
        Me.cbo_localidades.Size = New System.Drawing.Size(187, 26)
        Me.cbo_localidades.TabIndex = 10
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localidad.Location = New System.Drawing.Point(315, 14)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(75, 18)
        Me.lbl_localidad.TabIndex = 11
        Me.lbl_localidad.Text = "Localidad:"
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_barrio.Location = New System.Drawing.Point(150, 79)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(52, 18)
        Me.lbl_barrio.TabIndex = 9
        Me.lbl_barrio.Text = "Barrio:"
        '
        'txt_barrio
        '
        Me.txt_barrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_barrio.Location = New System.Drawing.Point(205, 77)
        Me.txt_barrio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_barrio.Name = "txt_barrio"
        Me.txt_barrio.Size = New System.Drawing.Size(211, 22)
        Me.txt_barrio.TabIndex = 7
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.BackColor = System.Drawing.Color.Silver
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(253, 390)
        Me.btn_Buscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(53, 58)
        Me.btn_Buscar.TabIndex = 17
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.BackColor = System.Drawing.Color.Silver
        Me.btn_Eliminar.BackgroundImage = CType(resources.GetObject("btn_Eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Eliminar.Location = New System.Drawing.Point(193, 390)
        Me.btn_Eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(54, 58)
        Me.btn_Eliminar.TabIndex = 16
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Grabar
        '
        Me.btn_Grabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Grabar.BackColor = System.Drawing.Color.Silver
        Me.btn_Grabar.Image = CType(resources.GetObject("btn_Grabar.Image"), System.Drawing.Image)
        Me.btn_Grabar.Location = New System.Drawing.Point(135, 390)
        Me.btn_Grabar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Grabar.Name = "btn_Grabar"
        Me.btn_Grabar.Size = New System.Drawing.Size(52, 58)
        Me.btn_Grabar.TabIndex = 15
        Me.btn_Grabar.UseVisualStyleBackColor = False
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.BackColor = System.Drawing.Color.Silver
        Me.btn_Modificar.BackgroundImage = CType(resources.GetObject("btn_Modificar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Modificar.Location = New System.Drawing.Point(74, 390)
        Me.btn_Modificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(55, 58)
        Me.btn_Modificar.TabIndex = 14
        Me.btn_Modificar.UseVisualStyleBackColor = False
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Nuevo.BackColor = System.Drawing.Color.Silver
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.Location = New System.Drawing.Point(12, 390)
        Me.btn_Nuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(56, 58)
        Me.btn_Nuevo.TabIndex = 13
        Me.btn_Nuevo.UseVisualStyleBackColor = False
        '
        'dgv_barrios
        '
        Me.dgv_barrios.AllowUserToAddRows = False
        Me.dgv_barrios.AllowUserToDeleteRows = False
        Me.dgv_barrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barrios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idProvincia, Me.col_provincia, Me.col_IdLocalidad, Me.col_localidad, Me.col_IdBarrio, Me.col_barrio})
        Me.dgv_barrios.Location = New System.Drawing.Point(13, 115)
        Me.dgv_barrios.Name = "dgv_barrios"
        Me.dgv_barrios.ReadOnly = True
        Me.dgv_barrios.RowTemplate.Height = 24
        Me.dgv_barrios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_barrios.Size = New System.Drawing.Size(591, 260)
        Me.dgv_barrios.TabIndex = 18
        '
        'col_idProvincia
        '
        Me.col_idProvincia.HeaderText = "Id Provincia"
        Me.col_idProvincia.Name = "col_idProvincia"
        Me.col_idProvincia.ReadOnly = True
        '
        'col_provincia
        '
        Me.col_provincia.HeaderText = "Provincia"
        Me.col_provincia.Name = "col_provincia"
        Me.col_provincia.ReadOnly = True
        '
        'col_IdLocalidad
        '
        Me.col_IdLocalidad.HeaderText = "Id Localidad"
        Me.col_IdLocalidad.Name = "col_IdLocalidad"
        Me.col_IdLocalidad.ReadOnly = True
        '
        'col_localidad
        '
        Me.col_localidad.HeaderText = "Localidad"
        Me.col_localidad.Name = "col_localidad"
        Me.col_localidad.ReadOnly = True
        '
        'col_IdBarrio
        '
        Me.col_IdBarrio.HeaderText = "Id Barrio"
        Me.col_IdBarrio.Name = "col_IdBarrio"
        Me.col_IdBarrio.ReadOnly = True
        '
        'col_barrio
        '
        Me.col_barrio.HeaderText = "Barrio"
        Me.col_barrio.Name = "col_barrio"
        Me.col_barrio.ReadOnly = True
        Me.col_barrio.Width = 300
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_Provincia)
        Me.Panel1.Controls.Add(Me.cbo_provincias)
        Me.Panel1.Controls.Add(Me.lbl_localidad)
        Me.Panel1.Controls.Add(Me.cbo_localidades)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(591, 53)
        Me.Panel1.TabIndex = 19
        '
        'btn_Salir
        '
        Me.btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Salir.BackColor = System.Drawing.Color.Silver
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.Location = New System.Drawing.Point(545, 390)
        Me.btn_Salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(59, 58)
        Me.btn_Salir.TabIndex = 20
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'Frm_registrar_Barrio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(616, 459)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_barrios)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.lbl_barrio)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.txt_barrio)
        Me.Controls.Add(Me.btn_Grabar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Name = "Frm_registrar_Barrio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Barrio"
        CType(Me.dgv_barrios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_provincias As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Provincia As System.Windows.Forms.Label
    Friend WithEvents cbo_localidades As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_barrio As System.Windows.Forms.Label
    Friend WithEvents txt_barrio As System.Windows.Forms.TextBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Grabar As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents dgv_barrios As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents col_idProvincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_IdLocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_IdBarrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_barrio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
