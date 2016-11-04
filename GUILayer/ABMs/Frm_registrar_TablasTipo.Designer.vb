<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrar_TablasTipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrar_TablasTipo))
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.btn_modificar = New System.Windows.Forms.Button()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(18, 49)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(62, 17)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Location = New System.Drawing.Point(25, 23)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(56, 17)
        Me.lbl_codigo.TabIndex = 1
        Me.lbl_codigo.Text = "Código:"
        '
        'txt_nombre
        '
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre.Location = New System.Drawing.Point(82, 49)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(320, 22)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_codigo
        '
        Me.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_codigo.Location = New System.Drawing.Point(83, 20)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(90, 22)
        Me.txt_codigo.TabIndex = 3
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.Silver
        Me.btn_nuevo.BackgroundImage = CType(resources.GetObject("btn_nuevo.BackgroundImage"), System.Drawing.Image)
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_nuevo.Location = New System.Drawing.Point(21, 373)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(38, 46)
        Me.btn_nuevo.TabIndex = 5
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.Color.Silver
        Me.btn_grabar.BackgroundImage = CType(resources.GetObject("btn_grabar.BackgroundImage"), System.Drawing.Image)
        Me.btn_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_grabar.Location = New System.Drawing.Point(64, 373)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(53, 46)
        Me.btn_grabar.TabIndex = 6
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Silver
        Me.btn_eliminar.BackgroundImage = CType(resources.GetObject("btn_eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminar.Location = New System.Drawing.Point(184, 373)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(53, 46)
        Me.btn_eliminar.TabIndex = 7
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Silver
        Me.btn_salir.BackgroundImage = CType(resources.GetObject("btn_salir.BackgroundImage"), System.Drawing.Image)
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.Location = New System.Drawing.Point(380, 370)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(55, 46)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Location = New System.Drawing.Point(21, 84)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(414, 270)
        Me.Grid.TabIndex = 9
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.Silver
        Me.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_modificar.Image = CType(resources.GetObject("btn_modificar.Image"), System.Drawing.Image)
        Me.btn_modificar.Location = New System.Drawing.Point(122, 373)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(55, 46)
        Me.btn_modificar.TabIndex = 10
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'frm_registrar_TablasTipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(453, 431)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_codigo)
        Me.Controls.Add(Me.lbl_nombre)
        Me.DoubleBuffered = True
        Me.Name = "frm_registrar_TablasTipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
End Class
