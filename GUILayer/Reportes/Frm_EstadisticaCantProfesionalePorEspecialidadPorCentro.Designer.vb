<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EstadisticaCantProfesionalePorEspecialidadPorCentro
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataTableCantProfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCantProf = New primeraEntrega.DataSetCantProf()
        Me.cbo_centro = New System.Windows.Forms.ComboBox()
        Me.dtp_desde = New System.Windows.Forms.DateTimePicker()
        Me.dtp_hasta = New System.Windows.Forms.DateTimePicker()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DataTableCantProfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCantProf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTableCantProfBindingSource
        '
        Me.DataTableCantProfBindingSource.DataMember = "DataTableCantProf"
        Me.DataTableCantProfBindingSource.DataSource = Me.DataSetCantProf
        '
        'DataSetCantProf
        '
        Me.DataSetCantProf.DataSetName = "DataSetCantProf"
        Me.DataSetCantProf.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbo_centro
        '
        Me.cbo_centro.FormattingEnabled = True
        Me.cbo_centro.Location = New System.Drawing.Point(12, 32)
        Me.cbo_centro.Name = "cbo_centro"
        Me.cbo_centro.Size = New System.Drawing.Size(172, 21)
        Me.cbo_centro.TabIndex = 0
        '
        'dtp_desde
        '
        Me.dtp_desde.Location = New System.Drawing.Point(190, 33)
        Me.dtp_desde.Name = "dtp_desde"
        Me.dtp_desde.Size = New System.Drawing.Size(222, 20)
        Me.dtp_desde.TabIndex = 1
        '
        'dtp_hasta
        '
        Me.dtp_hasta.Location = New System.Drawing.Point(418, 33)
        Me.dtp_hasta.Name = "dtp_hasta"
        Me.dtp_hasta.Size = New System.Drawing.Size(222, 20)
        Me.dtp_hasta.TabIndex = 2
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(646, 32)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar.TabIndex = 3
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Centro médico:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Alta desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(415, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Alta hasta:"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSetCantProf"
        ReportDataSource1.Value = Me.DataTableCantProfBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "primeraEntrega.EstadisticaCantProfxEspxCent.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 60)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(708, 444)
        Me.ReportViewer1.TabIndex = 7
        '
        'Frm_EstadisticaCantProfesionalePorEspecialidadPorCentro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 516)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.dtp_hasta)
        Me.Controls.Add(Me.dtp_desde)
        Me.Controls.Add(Me.cbo_centro)
        Me.Name = "Frm_EstadisticaCantProfesionalePorEspecialidadPorCentro"
        Me.Text = "Cantidad de profesionales por especialidad"
        CType(Me.DataTableCantProfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCantProf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_centro As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTableCantProfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetCantProf As primeraEntrega.DataSetCantProf
End Class
