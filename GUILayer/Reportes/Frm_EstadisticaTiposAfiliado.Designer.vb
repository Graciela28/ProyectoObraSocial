﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EstadisticaTiposAfiliado
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet5 = New primeraEntrega.DataSet5()
        Me.Estadistica2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Estadistica2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetEstadistica2"
        ReportDataSource1.Value = Me.Estadistica2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "primeraEntrega.EstadisticaTiposAfiliado.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(592, 356)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet5
        '
        Me.DataSet5.DataSetName = "DataSet5"
        Me.DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Estadistica2BindingSource
        '
        Me.Estadistica2BindingSource.DataMember = "Estadistica2"
        Me.Estadistica2BindingSource.DataSource = Me.DataSet5
        '
        'Frm_EstadisticaTiposAfiliado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 380)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Frm_EstadisticaTiposAfiliado"
        Me.Text = "Estadistica Tipos Afiliado"
        CType(Me.DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Estadistica2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Estadistica2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet5 As primeraEntrega.DataSet5
End Class