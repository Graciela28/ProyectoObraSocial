<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListadoProfesionales
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
        Me.ProfesionalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New primeraEntrega.DataSet1()
        Me.ReportViewerProfesionales = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ProfesionalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfesionalesBindingSource
        '
        Me.ProfesionalesBindingSource.DataMember = "Profesionales"
        Me.ProfesionalesBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewerProfesionales
        '
        Me.ReportViewerProfesionales.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetProfesionales"
        ReportDataSource1.Value = Me.ProfesionalesBindingSource
        Me.ReportViewerProfesionales.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerProfesionales.LocalReport.ReportEmbeddedResource = "primeraEntrega.ListadoProfesionales.rdlc"
        Me.ReportViewerProfesionales.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerProfesionales.Name = "ReportViewerProfesionales"
        Me.ReportViewerProfesionales.Size = New System.Drawing.Size(767, 490)
        Me.ReportViewerProfesionales.TabIndex = 0
        '
        'Frm_ListadoProfesionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 490)
        Me.Controls.Add(Me.ReportViewerProfesionales)
        Me.Name = "Frm_ListadoProfesionales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Profesionales "
        CType(Me.ProfesionalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewerProfesionales As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProfesionalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As primeraEntrega.DataSet1
End Class
