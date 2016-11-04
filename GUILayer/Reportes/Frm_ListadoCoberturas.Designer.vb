<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListadoCoberturas
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
        Me.ReportViewerCoberturas = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet3 = New primeraEntrega.DataSet3()
        Me.CoberturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoberturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewerCoberturas
        '
        Me.ReportViewerCoberturas.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetCobertura"
        ReportDataSource1.Value = Me.CoberturasBindingSource
        Me.ReportViewerCoberturas.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerCoberturas.LocalReport.ReportEmbeddedResource = "primeraEntrega.ListadoCoberturas.rdlc"
        Me.ReportViewerCoberturas.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerCoberturas.Name = "ReportViewerCoberturas"
        Me.ReportViewerCoberturas.Size = New System.Drawing.Size(806, 414)
        Me.ReportViewerCoberturas.TabIndex = 0
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CoberturasBindingSource
        '
        Me.CoberturasBindingSource.DataMember = "Coberturas"
        Me.CoberturasBindingSource.DataSource = Me.DataSet3
        '
        'Frm_ListadoCoberturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 414)
        Me.Controls.Add(Me.ReportViewerCoberturas)
        Me.Name = "Frm_ListadoCoberturas"
        Me.Text = "Listado de Coberturas"
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoberturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewerCoberturas As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CoberturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet3 As primeraEntrega.DataSet3
End Class
