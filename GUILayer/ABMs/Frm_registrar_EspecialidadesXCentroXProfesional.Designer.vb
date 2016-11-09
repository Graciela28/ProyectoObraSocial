<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_EspecialidadesXCentroXProfesional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrar_EspecialidadesXCentroXProfesional))
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_Eliminar = New System.Windows.Forms.Button()
        Me.cmd_Grabar = New System.Windows.Forms.Button()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.dgv_grilla = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbo_especialidad = New System.Windows.Forms.ComboBox()
        Me.cbo_profesional = New System.Windows.Forms.ComboBox()
        Me.cbo_centro = New System.Windows.Forms.ComboBox()
        Me.lbl_profesional = New System.Windows.Forms.Label()
        Me.lbl_centro = New System.Windows.Forms.Label()
        Me.lbl_especialidad = New System.Windows.Forms.Label()
        Me.Especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.centro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Profesional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_centro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_alta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_salir
        '
        Me.cmd_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_salir.BackColor = System.Drawing.Color.Silver
        Me.cmd_salir.BackgroundImage = CType(resources.GetObject("cmd_salir.BackgroundImage"), System.Drawing.Image)
        Me.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_salir.Location = New System.Drawing.Point(905, 329)
        Me.cmd_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(68, 62)
        Me.cmd_salir.TabIndex = 14
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'cmd_Eliminar
        '
        Me.cmd_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_Eliminar.BackColor = System.Drawing.Color.Silver
        Me.cmd_Eliminar.BackgroundImage = CType(resources.GetObject("cmd_Eliminar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_Eliminar.Location = New System.Drawing.Point(157, 326)
        Me.cmd_Eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmd_Eliminar.Name = "cmd_Eliminar"
        Me.cmd_Eliminar.Size = New System.Drawing.Size(69, 62)
        Me.cmd_Eliminar.TabIndex = 12
        Me.cmd_Eliminar.UseVisualStyleBackColor = False
        '
        'cmd_Grabar
        '
        Me.cmd_Grabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_Grabar.BackColor = System.Drawing.Color.Silver
        Me.cmd_Grabar.BackgroundImage = CType(resources.GetObject("cmd_Grabar.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_Grabar.Location = New System.Drawing.Point(84, 326)
        Me.cmd_Grabar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmd_Grabar.Name = "cmd_Grabar"
        Me.cmd_Grabar.Size = New System.Drawing.Size(68, 62)
        Me.cmd_Grabar.TabIndex = 11
        Me.cmd_Grabar.UseVisualStyleBackColor = False
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd_Nuevo.BackColor = System.Drawing.Color.Silver
        Me.cmd_Nuevo.BackgroundImage = CType(resources.GetObject("cmd_Nuevo.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_Nuevo.Location = New System.Drawing.Point(15, 326)
        Me.cmd_Nuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(64, 62)
        Me.cmd_Nuevo.TabIndex = 9
        Me.cmd_Nuevo.UseVisualStyleBackColor = False
        '
        'dgv_grilla
        '
        Me.dgv_grilla.AllowUserToAddRows = False
        Me.dgv_grilla.AllowUserToDeleteRows = False
        Me.dgv_grilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Especialidad, Me.centro, Me.Profesional, Me.id_especialidad, Me.id_centro, Me.matricula, Me.fecha_alta})
        Me.dgv_grilla.Location = New System.Drawing.Point(487, 15)
        Me.dgv_grilla.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_grilla.Name = "dgv_grilla"
        Me.dgv_grilla.ReadOnly = True
        Me.dgv_grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_grilla.Size = New System.Drawing.Size(487, 308)
        Me.dgv_grilla.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbo_especialidad)
        Me.Panel1.Controls.Add(Me.cbo_profesional)
        Me.Panel1.Controls.Add(Me.cbo_centro)
        Me.Panel1.Controls.Add(Me.lbl_profesional)
        Me.Panel1.Controls.Add(Me.lbl_centro)
        Me.Panel1.Controls.Add(Me.lbl_especialidad)
        Me.Panel1.Location = New System.Drawing.Point(16, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 148)
        Me.Panel1.TabIndex = 19
        '
        'cbo_especialidad
        '
        Me.cbo_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_especialidad.FormattingEnabled = True
        Me.cbo_especialidad.Location = New System.Drawing.Point(132, 95)
        Me.cbo_especialidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbo_especialidad.Name = "cbo_especialidad"
        Me.cbo_especialidad.Size = New System.Drawing.Size(307, 24)
        Me.cbo_especialidad.TabIndex = 23
        '
        'cbo_profesional
        '
        Me.cbo_profesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_profesional.FormattingEnabled = True
        Me.cbo_profesional.Location = New System.Drawing.Point(132, 55)
        Me.cbo_profesional.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbo_profesional.Name = "cbo_profesional"
        Me.cbo_profesional.Size = New System.Drawing.Size(307, 24)
        Me.cbo_profesional.TabIndex = 22
        '
        'cbo_centro
        '
        Me.cbo_centro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_centro.FormattingEnabled = True
        Me.cbo_centro.Location = New System.Drawing.Point(132, 17)
        Me.cbo_centro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbo_centro.Name = "cbo_centro"
        Me.cbo_centro.Size = New System.Drawing.Size(307, 24)
        Me.cbo_centro.TabIndex = 21
        '
        'lbl_profesional
        '
        Me.lbl_profesional.AutoSize = True
        Me.lbl_profesional.Location = New System.Drawing.Point(41, 59)
        Me.lbl_profesional.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_profesional.Name = "lbl_profesional"
        Me.lbl_profesional.Size = New System.Drawing.Size(83, 17)
        Me.lbl_profesional.TabIndex = 20
        Me.lbl_profesional.Text = "Profesional:"
        '
        'lbl_centro
        '
        Me.lbl_centro.AutoSize = True
        Me.lbl_centro.Location = New System.Drawing.Point(19, 21)
        Me.lbl_centro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_centro.Name = "lbl_centro"
        Me.lbl_centro.Size = New System.Drawing.Size(103, 17)
        Me.lbl_centro.TabIndex = 19
        Me.lbl_centro.Text = "Centro Médico:"
        '
        'lbl_especialidad
        '
        Me.lbl_especialidad.AutoSize = True
        Me.lbl_especialidad.Location = New System.Drawing.Point(31, 98)
        Me.lbl_especialidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_especialidad.Name = "lbl_especialidad"
        Me.lbl_especialidad.Size = New System.Drawing.Size(92, 17)
        Me.lbl_especialidad.TabIndex = 18
        Me.lbl_especialidad.Text = "Especialidad:"
        '
        'Especialidad
        '
        Me.Especialidad.HeaderText = "especialidad"
        Me.Especialidad.Name = "Especialidad"
        Me.Especialidad.ReadOnly = True
        '
        'centro
        '
        Me.centro.HeaderText = "Centro Médico"
        Me.centro.Name = "centro"
        Me.centro.ReadOnly = True
        '
        'Profesional
        '
        Me.Profesional.HeaderText = "profesional"
        Me.Profesional.Name = "Profesional"
        Me.Profesional.ReadOnly = True
        Me.Profesional.Width = 200
        '
        'id_especialidad
        '
        Me.id_especialidad.HeaderText = "id_especialidad"
        Me.id_especialidad.Name = "id_especialidad"
        Me.id_especialidad.ReadOnly = True
        Me.id_especialidad.Visible = False
        '
        'id_centro
        '
        Me.id_centro.HeaderText = "id_centro"
        Me.id_centro.Name = "id_centro"
        Me.id_centro.ReadOnly = True
        Me.id_centro.Visible = False
        '
        'matricula
        '
        Me.matricula.HeaderText = "matricula"
        Me.matricula.Name = "matricula"
        Me.matricula.ReadOnly = True
        Me.matricula.Visible = False
        '
        'fecha_alta
        '
        Me.fecha_alta.HeaderText = "fecha_alta"
        Me.fecha_alta.Name = "fecha_alta"
        Me.fecha_alta.ReadOnly = True
        Me.fecha_alta.Visible = False
        '
        'frm_registrar_EspecialidadesXCentroXProfesional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(991, 405)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_grilla)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_Eliminar)
        Me.Controls.Add(Me.cmd_Grabar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_registrar_EspecialidadesXCentroXProfesional"
        Me.Text = "Especialidades x Centro x Profesional"
        CType(Me.dgv_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_Eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_Grabar As System.Windows.Forms.Button
    Friend WithEvents cmd_Nuevo As System.Windows.Forms.Button
    Friend WithEvents dgv_grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbo_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_profesional As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_centro As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_profesional As System.Windows.Forms.Label
    Friend WithEvents lbl_centro As System.Windows.Forms.Label
    Friend WithEvents lbl_especialidad As System.Windows.Forms.Label
    Friend WithEvents Especialidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents centro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Profesional As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_especialidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_centro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents matricula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_alta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
