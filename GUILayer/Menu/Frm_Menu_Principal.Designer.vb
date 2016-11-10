<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Menu_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Menu_Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.abm = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarAfiliadoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarAtencionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarAtenciónMédicaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarProfesionalMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarCentroMedicoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarEspecialidadMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarPracticaMedicaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarTipoDeAfiliadoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarTipoDeDocumentoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarEspecialidadAProfesionalMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeProfesionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeAfiliadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeCoberturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeFacturaciónMensualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteEstadísticoDePrácticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteEstadísticoDeTiposDeAfiliadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteEstadísticoDeCantidadProfesionalesPorEspecialidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarNuevoBarrioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.abm, Me.TransaccionesToolStripMenuItem, Me.AdministradorToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(745, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'abm
        '
        Me.abm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarAfiliadoMenuItem})
        Me.abm.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abm.Name = "abm"
        Me.abm.Size = New System.Drawing.Size(97, 27)
        Me.abm.Text = "Secretaria"
        '
        'RegistrarAfiliadoMenuItem
        '
        Me.RegistrarAfiliadoMenuItem.Name = "RegistrarAfiliadoMenuItem"
        Me.RegistrarAfiliadoMenuItem.Size = New System.Drawing.Size(209, 28)
        Me.RegistrarAfiliadoMenuItem.Text = "Registrar Afiliado"
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarAtencionMenuItem, Me.ConsultarAtenciónMédicaMenuItem})
        Me.TransaccionesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(106, 27)
        Me.TransaccionesToolStripMenuItem.Text = "Profesional"
        '
        'RegistrarAtencionMenuItem
        '
        Me.RegistrarAtencionMenuItem.Name = "RegistrarAtencionMenuItem"
        Me.RegistrarAtencionMenuItem.Size = New System.Drawing.Size(286, 28)
        Me.RegistrarAtencionMenuItem.Text = "Registrar Atención Médica "
        '
        'ConsultarAtenciónMédicaMenuItem
        '
        Me.ConsultarAtenciónMédicaMenuItem.Name = "ConsultarAtenciónMédicaMenuItem"
        Me.ConsultarAtenciónMédicaMenuItem.Size = New System.Drawing.Size(286, 28)
        Me.ConsultarAtenciónMédicaMenuItem.Text = "Consultar Atención Médica"
        '
        'AdministradorToolStripMenuItem
        '
        Me.AdministradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarProfesionalMenuItem, Me.RegistrarCentroMedicoMenuItem, Me.RegistrarEspecialidadMenuItem, Me.RegistrarPracticaMedicaMenuItem, Me.RegistrarTipoDeAfiliadoMenuItem, Me.RegistrarTipoDeDocumentoMenuItem, Me.AsignarEspecialidadAProfesionalMenuItem, Me.RegistrarNuevoBarrioToolStripMenuItem})
        Me.AdministradorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        Me.AdministradorToolStripMenuItem.Size = New System.Drawing.Size(130, 27)
        Me.AdministradorToolStripMenuItem.Text = "Administrador"
        '
        'RegistrarProfesionalMenuItem
        '
        Me.RegistrarProfesionalMenuItem.Name = "RegistrarProfesionalMenuItem"
        Me.RegistrarProfesionalMenuItem.Size = New System.Drawing.Size(338, 28)
        Me.RegistrarProfesionalMenuItem.Text = "Registrar Profesional"
        '
        'RegistrarCentroMedicoMenuItem
        '
        Me.RegistrarCentroMedicoMenuItem.Name = "RegistrarCentroMedicoMenuItem"
        Me.RegistrarCentroMedicoMenuItem.Size = New System.Drawing.Size(338, 28)
        Me.RegistrarCentroMedicoMenuItem.Text = "Registrar Centro Médico"
        '
        'RegistrarEspecialidadMenuItem
        '
        Me.RegistrarEspecialidadMenuItem.Name = "RegistrarEspecialidadMenuItem"
        Me.RegistrarEspecialidadMenuItem.Size = New System.Drawing.Size(338, 28)
        Me.RegistrarEspecialidadMenuItem.Text = "Registrar Especialidad"
        '
        'RegistrarPracticaMedicaMenuItem
        '
        Me.RegistrarPracticaMedicaMenuItem.Name = "RegistrarPracticaMedicaMenuItem"
        Me.RegistrarPracticaMedicaMenuItem.Size = New System.Drawing.Size(338, 28)
        Me.RegistrarPracticaMedicaMenuItem.Text = "Registrar Práctica Médica"
        '
        'RegistrarTipoDeAfiliadoMenuItem
        '
        Me.RegistrarTipoDeAfiliadoMenuItem.Name = "RegistrarTipoDeAfiliadoMenuItem"
        Me.RegistrarTipoDeAfiliadoMenuItem.Size = New System.Drawing.Size(338, 28)
        Me.RegistrarTipoDeAfiliadoMenuItem.Text = "Registrar Tipo de Afiliado"
        '
        'RegistrarTipoDeDocumentoMenuItem
        '
        Me.RegistrarTipoDeDocumentoMenuItem.Name = "RegistrarTipoDeDocumentoMenuItem"
        Me.RegistrarTipoDeDocumentoMenuItem.Size = New System.Drawing.Size(338, 28)
        Me.RegistrarTipoDeDocumentoMenuItem.Text = "Registrar Tipo de Documento"
        '
        'AsignarEspecialidadAProfesionalMenuItem
        '
        Me.AsignarEspecialidadAProfesionalMenuItem.Name = "AsignarEspecialidadAProfesionalMenuItem"
        Me.AsignarEspecialidadAProfesionalMenuItem.Size = New System.Drawing.Size(338, 28)
        Me.AsignarEspecialidadAProfesionalMenuItem.Text = "Asignar Especialidad a Profesional"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeProfesionalesToolStripMenuItem, Me.ListadoDeAfiliadosToolStripMenuItem, Me.ListadoDeCoberturasToolStripMenuItem, Me.ReporteDeFacturaciónMensualToolStripMenuItem, Me.ReporteEstadísticoDePrácticaToolStripMenuItem, Me.ReporteEstadísticoDeTiposDeAfiliadoToolStripMenuItem, Me.ReporteEstadísticoDeCantidadProfesionalesPorEspecialidadToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(89, 27)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ListadoDeProfesionalesToolStripMenuItem
        '
        Me.ListadoDeProfesionalesToolStripMenuItem.Name = "ListadoDeProfesionalesToolStripMenuItem"
        Me.ListadoDeProfesionalesToolStripMenuItem.Size = New System.Drawing.Size(554, 28)
        Me.ListadoDeProfesionalesToolStripMenuItem.Text = "Listado de Profesionales"
        '
        'ListadoDeAfiliadosToolStripMenuItem
        '
        Me.ListadoDeAfiliadosToolStripMenuItem.Name = "ListadoDeAfiliadosToolStripMenuItem"
        Me.ListadoDeAfiliadosToolStripMenuItem.Size = New System.Drawing.Size(554, 28)
        Me.ListadoDeAfiliadosToolStripMenuItem.Text = "Listado de Afiliados"
        '
        'ListadoDeCoberturasToolStripMenuItem
        '
        Me.ListadoDeCoberturasToolStripMenuItem.Name = "ListadoDeCoberturasToolStripMenuItem"
        Me.ListadoDeCoberturasToolStripMenuItem.Size = New System.Drawing.Size(554, 28)
        Me.ListadoDeCoberturasToolStripMenuItem.Text = "Listado de Coberturas"
        '
        'ReporteDeFacturaciónMensualToolStripMenuItem
        '
        Me.ReporteDeFacturaciónMensualToolStripMenuItem.Name = "ReporteDeFacturaciónMensualToolStripMenuItem"
        Me.ReporteDeFacturaciónMensualToolStripMenuItem.Size = New System.Drawing.Size(554, 28)
        Me.ReporteDeFacturaciónMensualToolStripMenuItem.Text = "Reporte de Facturación mensual"
        '
        'ReporteEstadísticoDePrácticaToolStripMenuItem
        '
        Me.ReporteEstadísticoDePrácticaToolStripMenuItem.Name = "ReporteEstadísticoDePrácticaToolStripMenuItem"
        Me.ReporteEstadísticoDePrácticaToolStripMenuItem.Size = New System.Drawing.Size(554, 28)
        Me.ReporteEstadísticoDePrácticaToolStripMenuItem.Text = "Reporte Estadístico de Prácticas"
        '
        'ReporteEstadísticoDeTiposDeAfiliadoToolStripMenuItem
        '
        Me.ReporteEstadísticoDeTiposDeAfiliadoToolStripMenuItem.Name = "ReporteEstadísticoDeTiposDeAfiliadoToolStripMenuItem"
        Me.ReporteEstadísticoDeTiposDeAfiliadoToolStripMenuItem.Size = New System.Drawing.Size(554, 28)
        Me.ReporteEstadísticoDeTiposDeAfiliadoToolStripMenuItem.Text = "Reporte Estadístico de Tipos de Afiliado"
        '
        'ReporteEstadísticoDeCantidadProfesionalesPorEspecialidadToolStripMenuItem
        '
        Me.ReporteEstadísticoDeCantidadProfesionalesPorEspecialidadToolStripMenuItem.Name = "ReporteEstadísticoDeCantidadProfesionalesPorEspecialidadToolStripMenuItem"
        Me.ReporteEstadísticoDeCantidadProfesionalesPorEspecialidadToolStripMenuItem.Size = New System.Drawing.Size(554, 28)
        Me.ReporteEstadísticoDeCantidadProfesionalesPorEspecialidadToolStripMenuItem.Text = "Reporte Estadístico de cantidad Profesionales por Especialidad"
        '
        'RegistrarNuevoBarrioToolStripMenuItem
        '
        Me.RegistrarNuevoBarrioToolStripMenuItem.Name = "RegistrarNuevoBarrioToolStripMenuItem"
        Me.RegistrarNuevoBarrioToolStripMenuItem.Size = New System.Drawing.Size(338, 28)
        Me.RegistrarNuevoBarrioToolStripMenuItem.Text = "Registrar nuevo Barrio"
        '
        'frm_Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(745, 399)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_Menu_Principal"
        Me.Text = "Menú Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents abm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarAfiliadoMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarAtencionMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarProfesionalMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarCentroMedicoMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarEspecialidadMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarPracticaMedicaMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarTipoDeAfiliadoMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarTipoDeDocumentoMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarEspecialidadAProfesionalMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarAtenciónMédicaMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeProfesionalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeAfiliadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeCoberturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeFacturaciónMensualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteEstadísticoDePrácticaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteEstadísticoDeTiposDeAfiliadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteEstadísticoDeCantidadProfesionalesPorEspecialidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarNuevoBarrioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
