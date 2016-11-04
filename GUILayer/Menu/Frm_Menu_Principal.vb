Public Class frm_Menu_Principal

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_Menu_Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If cierre_ventana() = 1 Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Function cierre_ventana() As Integer
        Dim rpta As Integer = 0
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir del Menú?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            rpta = 1
        End If
        Return rpta
    End Function

    Private Sub RegistrarProfesionalMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarProfesionalMenuItem.Click
        frm_registrar_profesional.ShowDialog()
    End Sub

    Private Sub RegistrarCentroMedicoMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarCentroMedicoMenuItem.Click
        frm_registrar_centroMedico.ShowDialog()
    End Sub

    Private Sub RegistrarEspecialidadMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarEspecialidadMenuItem.Click
        Dim frm_ABM_Especialidades As New frm_registrar_TablasTipo("Especialidades", "id", "nombre")
        frm_ABM_Especialidades.ShowDialog()
    End Sub

    Private Sub RegistrarPracticaMedicaMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarPracticaMedicaMenuItem.Click
        Dim frm_ABM_Practicas As New frm_registrar_TablasTipo("Practicas", "id", "nombre")
        frm_ABM_Practicas.ShowDialog()
    End Sub

    Private Sub RegistrarTipoDeAfiliadoMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarTipoDeAfiliadoMenuItem.Click
        Dim frm_ABM_TipoAfiliado As New frm_registrar_TablasTipo("TiposAfiliado", "id", "nombre")
        frm_ABM_TipoAfiliado.ShowDialog()
    End Sub

    Private Sub RegistrarTipoDeDocumentoMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarTipoDeDocumentoMenuItem.Click
        Dim frm_ABM_TipoDocumento As New frm_registrar_TablasTipo("TiposDocumento", "id", "nombre")
        frm_ABM_TipoDocumento.ShowDialog()
    End Sub

    Private Sub AsignarEspecialidadAProfesionalMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarEspecialidadAProfesionalMenuItem.Click
        frm_registrar_EspecialidadesXCentroXProfesional.ShowDialog()
    End Sub

    Private Sub RegistrarAtencionMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarAtencionMenuItem.Click
        frm_registrar_Atencion.ShowDialog()
    End Sub

    Private Sub RegistrarAfiliadoMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarAfiliadoMenuItem.Click
        frm_registrar_Afiliado.ShowDialog()
    End Sub

    Private Sub ConsultarAtenciónMédicaMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarAtenciónMédicaMenuItem.Click
        frm_registrar_Atencion.busqueda = True
        frm_buscar_atencion.ShowDialog()
    End Sub

    Private Sub ListadoDeProfesionalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProfesionalesToolStripMenuItem.Click
        Frm_ListadoProfesionales.ShowDialog()
    End Sub

    Private Sub ListadoDeAfiliadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeAfiliadosToolStripMenuItem.Click
        Frm_ListadoAfiliados.ShowDialog()
    End Sub

    Private Sub ListadoDeCoberturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeCoberturasToolStripMenuItem.Click
        Frm_ListadoCoberturas.ShowDialog()
    End Sub
End Class
