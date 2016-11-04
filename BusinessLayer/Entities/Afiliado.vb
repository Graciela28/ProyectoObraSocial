Public Class Afiliado : Inherits Persona

    Private _tipoAfiliado As TipoAfiliado
    Private _estaActivo As Boolean
    Private _empresaConvenio As String

    Public Property tipoAfiliado() As TipoAfiliado
        Get
            Return _tipoAfiliado
        End Get
        Set(value As TipoAfiliado)
            _tipoAfiliado = value
        End Set
    End Property

    Public Property estaActivo() As Boolean
        Get
            Return _estaActivo
        End Get
        Set(value As Boolean)
            _estaActivo = value
        End Set
    End Property

    Public Property empresaConvenio() As String
        Get
            Return _empresaConvenio
        End Get
        Set(value As String)
            _empresaConvenio = value
        End Set
    End Property
End Class
