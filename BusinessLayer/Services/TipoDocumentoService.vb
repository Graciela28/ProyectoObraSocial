Public Class TipoDocumentoService
    Private oTipoDocumentoDao As TipoDocumentoDao

    Public Sub New()
        oTipoDocumentoDao = New TipoDocumentoDao()
    End Sub

    Public Function mostrarTipoDocumento(oTipoDocumento As TipoDocumento) As String
        Dim cadena As String = ""
        Return cadena
    End Function
End Class
