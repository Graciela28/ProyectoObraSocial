Public Class acceso_a_datos
    'Enumeración, permite generar una lista de clasificación explícita.
    'En este caso una clasificación de motores de base de datos.
    Enum motores
        oracle
        sqlserver
        access
    End Enum

    'Definición de un Objeto no tipificado. Este objeto luego puede recibir las 
    'características de otro en particular.
    Dim conexion As New Object
    Dim cmd As New Object
    'Definición de una variable del tipo enumeración definida anteriormente
    Dim motor As motores = motores.access

    'Definición de una variable de tipo string, que contiene la cadena de conexión 
    Dim string_conexion As String = "Provider=SQLNCLI11;Data Source=VANIA-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DBObraSocialv1"
    Dim tabla As String = ""

    'Definición de propiedades públicas, a través de estas se podrá intercambiar
    'datos con el entorno donde actué el objeto
    Public Property _CadenaConexion() As String
        Get
            Return Me.string_conexion
        End Get
        Set(value As String)
            Me.string_conexion = value
        End Set
    End Property
    Public Property _tabla() As String
        Get
            Return Me.tabla
        End Get
        Set(value As String)
            Me.tabla = value
        End Set
    End Property

    'Constructor de la clase. El constructor es el método que se dispara
    'cuando el objeto se vuelve operable dentro de la aplicación 
    Public Sub New()
        Select Case Me.motor
            Case motores.access
                conexion = New Data.OleDb.OleDbConnection
                cmd = New Data.OleDb.OleDbCommand
            Case motores.sqlserver
                conexion = New Data.SqlClient.SqlConnection
                cmd = New Data.SqlClient.SqlCommand
        End Select
    End Sub

    Public Sub New(ByVal _CadenaConexion As String, ByVal _NombreTabla As String, ByVal _MotorBaseDatos As motores)
        Me.string_conexion = _CadenaConexion
        Me.tabla = _NombreTabla
        Me.motor = _MotorBaseDatos

        'Asignación del tipo de la propiedad privada conexión, la que había sido
        'definida sin tipo específico. Con un tipo según el motor que se seleccionó para trabajar 

        Select Case Me.motor
            Case motores.access
                conexion = New Data.OleDb.OleDbConnection
                cmd = New Data.OleDb.OleDbCommand
            Case motores.sqlserver
                conexion = New Data.SqlClient.SqlConnection
                cmd = New Data.SqlClient.SqlCommand
        End Select
    End Sub

    Public Sub New(ByVal _MotorBaseDatos As motores, ByVal _NombreTabla As String)
        Me.tabla = _NombreTabla
        Me.motor = _MotorBaseDatos
        Select Case Me.motor
            Case motores.access
                conexion = New Data.OleDb.OleDbConnection
                cmd = New Data.OleDb.OleDbCommand
            Case motores.sqlserver
                conexion = New Data.SqlClient.SqlConnection
                cmd = New Data.SqlClient.SqlCommand
        End Select
    End Sub

    Public Sub New(ByVal _MotorBaseDatos As motores)
        Me.motor = _MotorBaseDatos
        Select Case Me.motor
            Case motores.access
                conexion = New Data.OleDb.OleDbConnection
                cmd = New Data.OleDb.OleDbCommand
            Case motores.sqlserver
                conexion = New Data.SqlClient.SqlConnection
                cmd = New Data.SqlClient.SqlCommand
        End Select
    End Sub

    'Método que se utiliza para realizar la conexión de la base de datos.
    Private Sub _conectar()
        Me.conexion.ConnectionString = Me.string_conexion
        Me.conexion.Open()
        Me.cmd.Connection = conexion
        Me.cmd.CommandType = CommandType.Text
    End Sub

    'Lee una tabla de la base, esta tabla es la que definió en la propiedad pública (PP) 
    '_tabla o vía constructor 
    Public Function leo_tabla() As Data.DataTable
        Return Me._consulta("select * from " & Me.tabla)
    End Function

    Public Function leo_tabla(ByVal pk As String, ByVal descripcion As String) As Data.DataTable
        Return Me._consulta("select " & pk & ", " & descripcion & " from " & Me.tabla)
    End Function

    'Sobre carga de leo_tabla
    Public Function leo_tabla(ByVal restriccion As String) As Data.DataTable
        Return Me._consulta("select * from " & Me.tabla & " Where " & restriccion)
    End Function

    Public Function _modificar(ByVal comando As String) As Boolean
        Me._conectar()
        Me.cmd.CommandText = comando
        cmd.ExecuteNonQuery()
        Me.conexion.Close()
        Return True
    End Function

    Public Function _consulta(ByVal comando As String) As Data.DataTable
        'Ejecuta una consulta determinada
        Dim _tabla As New Data.DataTable
        Me._conectar()
        Me.cmd.CommandText = comando
        _tabla.Load(Me.cmd.ExecuteReader())
        Me.conexion.Close()
        Return _tabla
    End Function

    Public Function _borrar(ByVal comando As String) As Boolean
        Me._conectar()
        Me.cmd.CommandText = comando
        cmd.ExecuteNonQuery()
        Me.conexion.Close()
        Return True
    End Function

    'Esta función analiza un conjunto de datos suministrados desde un formulario
    'y construye un comando insert a partur de una tabla determinada. Los datos tienen
    'que venir dentro de un string con el formato: "campo 1= valor, campo2=valor"
    Public Function _insertar(ByVal valores As String) As Boolean
        Dim txt_insert As String = ""
        txt_insert = Me.armo_insert()
        txt_insert += Me.asigno_valores_insert(valores)

        MsgBox(txt_insert)
        Me._conectar()
        Me.cmd.CommandText = txt_insert
        cmd.ExecuteNonQuery()
        Me.conexion.Close()
        Return True
    End Function


    'Construye la cabecera del insert. 
    'INSERT INTO "TABLA" (COLUMNA1, COLUMNA2, ... COLUMNA) VALUES ()
    Private Function armo_insert() As String
        Dim tabla As New Data.DataTable
        Dim contador As Integer = 0
        Dim txt As String = ""

        tabla = Me.leo_tabla()
        txt = "insert into " & Me.tabla & "("

        While tabla.Columns.Count() > contador
            txt += tabla.Columns(contador).Caption
            contador += 1
            If contador < tabla.Columns.Count() Then
                txt += ", "
            End If
        End While
        txt += ") values ("
        Return txt
    End Function

    'Arma el paquete de valores para las columnas, según los datos transferidos
    Private Function asigno_valores_insert(ByVal txt_insertar As String) As String
        'tabla que contiene la estructura en la base 
        Dim objeto_tabla As Data.DataTable
        Dim contador As Integer = 0 'contador de bucle
        Dim campo As Integer = 0 'ubicación del campo
        Dim coma As Integer = 0 'ubicación del ","
        Dim igual As Integer = 0 'ubicación del "="
        Dim txt_origen As String = "" 'texto origen 
        Dim nombre_campo As String = "" 'campo a buscar
        Dim valor As String = "" 'valor del campo
        Dim txt As String = "" 'texto que se va formando para el insert
        Dim tipo_dato As String = ""

        objeto_tabla = Me.leo_tabla()
        'Lleva los datos de entrada a una variable de entrada, y los
        'convierte a mayúscula
        txt_origen = txt_insertar.ToUpper.Trim()

        While objeto_tabla.Columns.Count() > contador
            nombre_campo = objeto_tabla.Columns(contador).Caption.ToUpper.Trim()
            tipo_dato = objeto_tabla.Columns(contador).DataType.ToString

            campo = txt_origen.IndexOf(nombre_campo)
            If campo <> -1 Then
                igual = txt_origen.IndexOf("=", campo)
                coma = txt_origen.IndexOf(",", campo)
                If coma <> -1 Then
                    valor = Me.acomodo_al_tipo_dato(txt_origen.Substring(igual + 1, coma - igual - 1), tipo_dato)
                Else
                    valor = Me.acomodo_al_tipo_dato(txt_origen.Substring(igual + 1), tipo_dato)
                End If
            Else
                igual = -1
                coma = -1
                valor = "null"
            End If
            txt += valor
            contador += 1

            If contador < objeto_tabla.Columns.Count() Then
                txt += ","
            End If
        End While

        txt += ")"
        Return txt
    End Function

    Private Function acomodo_al_tipo_dato(ByVal texto As String, ByVal tipo_dato As String) As String
        Select Case tipo_dato
            Case "System.String"
                Return "'" & texto & "'"
            Case "System.Int16"
                Return texto
            Case "System.Int32"
                Return texto
            Case "System.Int64"
                Return texto
            Case "System.Byte"
                Return texto
            Case "System.Double"
                Return texto
            Case "System.Decimal"
                Return texto
            Case "System.DateTime"
                If motor = motores.access Then
                    Return "#" & texto & "#"
                Else
                    Return "'" & texto & "'"
                End If
            Case "System.DateTimeKind"
                If motor = motores.access Then
                    Return "#" & texto & "#"
                Else
                    Return "'" & texto & "'"
                End If
            Case Else
                Return texto
        End Select
    End Function
End Class
