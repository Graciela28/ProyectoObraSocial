<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListadoAfiliados
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
        Me.ReportViewerAfiliados = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet2 = New primeraEntrega.DataSet2()
        Me.AfiliadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AfiliadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewerAfiliados
        '
        Me.ReportViewerAfiliados.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetAfiliado"
        ReportDataSource1.Value = Me.AfiliadosBindingSource
        Me.ReportViewerAfiliados.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerAfiliados.LocalReport.ReportEmbeddedResource = "primeraEntrega.ListadoAfiliados.rdlc"
        Me.ReportViewerAfiliados.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerAfiliados.Name = "ReportViewerAfiliados"
        Me.ReportViewerAfiliados.Size = New System.Drawing.Size(806, 441)
        Me.ReportViewerAfiliados.TabIndex = 0
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AfiliadosBindingSource
        '
        Me.AfiliadosBindingSource.DataMember = "Afiliados"
        Me.AfiliadosBindingSource.DataSource = Me.DataSet2
        '
        'Frm_ListadoAfiliados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 441)
        Me.Controls.Add(Me.ReportViewerAfiliados)
        Me.Name = "Frm_ListadoAfiliados"
        Me.Text = "Listado de Afiliados"
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AfiliadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewerAfiliados As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AfiliadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet2 As primeraEntrega.DataSet2
End Class
