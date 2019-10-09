Imports System.Text
Imports System.Net.Mail



Public Class Usuario

    Private estado As Boolean
    Private id_usuario As Integer
    Private nombreUsuario As String
    Private contrasena As String
    Private telefono As Long
    Private mail As String
    Private domicilio As String
    Private fechaNacimiento As Date
    Private sexo As Char
    Private nombre_apellido As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal nombreUsuario As String, ByVal contrasena As String, ByVal mail As String,
                   ByVal telefono As Long, ByVal domicilio As String, ByVal fechaNacimiento As Date,
                   ByVal sexo As String, ByVal nombre_apellido As String)

        Try

            Me.estado = True

            Me.setNombreUsuario(nombreUsuario)
            Me.setContrasena(contrasena)
            Me.setTelefono(telefono)
            Me.setMail(mail)
            Me.setDomicilio(domicilio)
            Me.setFechaNacimiento(fechaNacimiento)
            Me.setSexo(sexo)
            Me.setNombre_apellido(nombre_apellido)

        Catch ex As Exception

            Throw ex

        End Try

    End Sub

    Public Sub setNombreUsuario(ByVal nombreUsuario As String)

        If nombreUsuario.Length < 3 Or nombreUsuario.Length > 15 Then

            Throw New Exception("Tamaño de nombre invalido")

        Else

            Me.nombreUsuario = nombreUsuario

        End If

    End Sub

    Public Sub setContrasena(ByVal contrasena As String)

        Dim esValida As Boolean = False

        For Each c As Char In contrasena

            If (Char.IsDigit(c)) Then

                esValida = True

            End If


            If (c = c.ToString().ToUpper()) Then

                esValida = True

            End If

        Next

        If esValida = True Then

            Me.contrasena = contrasena

        Else

            Throw New Exception("La contraseña debe tener numeros y mayúsculas")

        End If


    End Sub

    Public Sub setTelefono(ByVal telefono As Long)

        Try

            If Not IsNumeric(telefono) Then

                Throw New Exception("El telefono ingresado no es un número")

            Else

                If telefono < 9999999 Then

                    Throw New Exception("El telefono ingresado no es válido")

                Else

                    Me.telefono = telefono

                End If

            End If

        Catch ex As Exception

            Throw ex

        End Try

    End Sub

    Public Sub setMail(ByVal mail As String)

        Try

            Me.mail = New MailAddress(mail).Address

        Catch ex As Exception

            Throw ex

        End Try

    End Sub

    Public Sub setDomicilio(ByVal domicilio As String)

        If domicilio.Length < 3 Or domicilio.Length > 15 Then

            Throw New Exception("Tamaño de domicilio invalido")

        Else

            Me.domicilio = domicilio

        End If

    End Sub

    Public Sub setFechaNacimiento(ByVal fechaNacimiento As Date)

        Try

            If Not IsDate(fechaNacimiento) Then

                Throw New Exception("La fecha ingresada no es válida")

            Else

                If DateDiff(DateInterval.Year, fechaNacimiento, Now) < 15 Then

                    Throw New Exception("El usuario debe ser mayor de 15 años")

                Else

                    Me.fechaNacimiento = fechaNacimiento

                End If

            End If

        Catch ex As Exception

            Throw ex

        End Try

        

    End Sub

    Public Sub setSexo(ByVal sexo As Char)

        Me.sexo = sexo

    End Sub

    Public Sub setNombre_apellido(ByVal nombre_apellido As String)

        If nombre_apellido.Length < 3 Or nombre_apellido.Length > 15 Then

            Throw New Exception("Tamaño de nombre y apellido invalido")

        Else

            Me.nombre_apellido = nombre_apellido

        End If

    End Sub

    Public Function getEstado() As Boolean

        Return Me.estado

    End Function


    Public Function getId_Usuario() As Integer

        Return Me.id_usuario

    End Function

    Public Function getNombreUsuario() As String

        Return Me.nombreUsuario

    End Function

    Public Function getContrasena() As String

        Return Me.contrasena

    End Function

    Public Function getTelefono() As Integer

        Return Me.telefono

    End Function

    Public Function getMail() As String

        Return Me.mail

    End Function

    Public Function getDomicilio() As String

        Return Me.domicilio

    End Function

    Public Function getFechaNacimiento() As Date

        Return Me.fechaNacimiento

    End Function

    Public Function getSexo() As Char

        Return Me.sexo

    End Function

    Public Function getNombre_Apellido() As String

        Return Me.nombre_apellido

    End Function

    Public Function iniciarSesion(ByVal usuario As String, ByVal pwd As String) As DataTable

        Dim xDB As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xDB.Open()

            XSTR.Append("SELECT id_usuario, nombre_usuario, mail, habilitado FROM USUARIOS")
            XSTR.AppendLine()
            XSTR.Append("WHERE ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("nombre_usuario= '", usuario, "' AND contrasena='", pwd, "'"))

            Return xDB.Leer(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try

    End Function

    Public Function traerPermisos(ByVal id_usuario As Integer) As DataTable

        Dim xDB As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xDB.Open()


            XSTR.Append("select PERMISOS.objeto, PERMISOS_GRUPOS.alta, PERMISOS_GRUPOS.baja ,PERMISOS_GRUPOS.modificacion, PERMISOS_GRUPOS.listar")
            XSTR.AppendLine()
            XSTR.Append("FROM")
            XSTR.AppendLine()
            XSTR.Append("USUARIOS inner join GRUPOS_USUARIOS on USUARIOS.id_usuario = GRUPOS_USUARIOS.id_usuario ")
            XSTR.AppendLine()
            XSTR.Append("inner join GRUPOS on GRUPOS_USUARIOS.id_grupo = GRUPOS.id_grupo")
            XSTR.AppendLine()
            XSTR.Append("inner join PERMISOS_GRUPOS on GRUPOS.id_grupo= PERMISOS_GRUPOS.id_grupo")
            XSTR.AppendLine()
            XSTR.Append("inner join PERMISOS on PERMISOS_GRUPOS.id_permiso = PERMISOS.id_permiso  ")
            XSTR.AppendLine()
            XSTR.Append("WHERE ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("USUARIOS.id_usuario= ", id_usuario, ""))

            Return xDB.Leer(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try



    End Function


    Public Function listarUsuarios() As DataTable

        Dim xDB As New AccesoDatos.DAO


        Try

            xDB.Open()


            Return xDB.Leer("SELECT id_usuario, nombre_usuario, mail, habilitado FROM USUARIOS")

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try


    End Function

    Public Sub agregarUsuario()

        Dim xdb As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xdb.Open()


            XSTR.Append("insert into USUARIOS ")
            XSTR.AppendLine()
            XSTR.Append("values ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("('", Me.nombre_apellido, "','", Me.telefono, "', '", Me.mail, "', '", Me.domicilio, "','", Format(Me.fechaNacimiento.Date, "yyyy/dd/MM"), "','M','", Me.nombreUsuario, "', '", Me.contrasena, "', '", Me.estado, "')"))

            xdb.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xdb.Close()

        End Try

    End Sub

    Public Sub eliminarUsuario(ByVal id As String)

        Dim xdb As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xdb.Open()

            XSTR.Append("DELETE FROM USUARIOS ")
            XSTR.AppendLine()
            XSTR.Append("WHERE ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("id_usuario =", id, ""))

            xdb.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xdb.Close()

        End Try

    End Sub

    Public Function getIdUsuario() As Integer

        Dim xDB As New AccesoDatos.DAO

        Try

            xDB.Open()

            Return xDB.Leer("Select id_usuario from Usuarios WHERE nombre='" + Me.nombreUsuario + "'").Rows.Item(0)("id_usuario")

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try

    End Function

    Public Sub habilitarUsuario(ByVal id_usuario As Integer, ByVal habilitado As Boolean)

        Dim xDB As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xDB.Open()

            XSTR.Append("UPDATE USUARIOS ")
            XSTR.AppendLine()
            XSTR.Append("SET ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("habilitado='", habilitado, "'"))
            XSTR.AppendLine()
            XSTR.Append("WHERE")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("id_usuario= ", id_usuario, ""))


            xDB.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try


    End Sub

End Class
