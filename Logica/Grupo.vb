Imports System.Text

Public Class Grupo

    Private nombre As String
    Private habilitado As Boolean

    Public Sub New()


    End Sub


    Public Sub New(ByVal nombre As String)

        Me.habilitado = True

        Me.setNombre(nombre)

    End Sub

    Public Sub New(ByVal nombre As String, ByVal habilitado As Boolean)

        Me.setHabilitado(habilitado)

        Me.setNombre(nombre)

    End Sub

    Public Sub setNombre(ByVal nombre As String)

        If nombre.Length < 3 Or nombre.Length > 15 Then

            Throw New Exception("Tamaño de nombre invalido")

        Else

            Me.nombre = nombre

        End If

    End Sub

    Public Function getNombre() As String

        Return Me.nombre

    End Function

    Public Sub setHabilitado(ByVal habilitado As Boolean)

        Me.habilitado = habilitado

    End Sub

    Public Sub agregarGrupo()

        Dim xdb As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xdb.Open()

            XSTR.Append("insert into GRUPOS ")
            XSTR.AppendLine()
            XSTR.Append("values ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("('", Me.nombre, "','", Me.habilitado, "')"))

            xdb.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xdb.Close()

        End Try


    End Sub

    Public Function listarGrupos() As DataTable

        Dim xDB As New AccesoDatos.DAO


        Try

            xDB.Open()


            Return xDB.Leer("Select *  from GRUPOS")

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try


    End Function

    Public Function getIdGrupo() As Integer

        Dim xDB As New AccesoDatos.DAO

        Try

            xDB.Open()

            Return xDB.Leer("Select id_grupo from GRUPOS WHERE nombre='" + Me.nombre + "'").Rows.Item(0)("id_grupo")

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try

    End Function

    Public Sub eliminarGrupo(ByVal id As String)

        Dim xdb As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xdb.Open()

            XSTR.Append("DELETE FROM GRUPOS ")
            XSTR.AppendLine()
            XSTR.Append("WHERE ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("id_grupo =", id, ""))

            xdb.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xdb.Close()

        End Try

    End Sub

    Public Function traerPermisos(ByVal id_grupo As Integer) As DataTable

        Dim xDB As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xDB.Open()


            XSTR.Append("select *")
            XSTR.AppendLine()
            XSTR.Append("FROM")
            XSTR.AppendLine()
            XSTR.Append("PERMISOS_GRUPOS")
            XSTR.AppendLine()
            XSTR.Append("WHERE ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("PERMISOS_GRUPOS.id_grupo= ", id_grupo, ""))

            Return xDB.Leer(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try

    End Function

    Public Sub actualizarGrupo(ByVal id_grupo As Integer)

        Dim xDB As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xDB.Open()

            XSTR.Append("UPDATE GRUPOS ")
            XSTR.AppendLine()
            XSTR.Append("SET ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("nombre ='", Me.nombre, "', habilitado='", Me.habilitado, "'"))
            XSTR.AppendLine()
            XSTR.Append("WHERE")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("id_grupo= ", id_grupo, ""))


            xDB.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try

    End Sub

    Sub habilitarGrupo(ByVal id_grupo As Integer, ByVal habilitado As Boolean)

        Dim xDB As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xDB.Open()

            XSTR.Append("UPDATE GRUPOS ")
            XSTR.AppendLine()
            XSTR.Append("SET ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("habilitado='", habilitado, "'"))
            XSTR.AppendLine()
            XSTR.Append("WHERE")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("id_grupo= ", id_grupo, ""))

            xDB.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try

    End Sub

End Class
