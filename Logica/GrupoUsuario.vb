Imports System.Text

Public Class GrupoUsuario

    Private id_grupo As Integer
    Private id_usuario As Integer

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Sub New(ByVal id_grupo As Integer, ByVal id_usuario As Integer)

        Me.id_grupo = id_grupo
        Me.id_usuario = id_usuario

    End Sub

    Sub New(ByVal id_usuario As Integer)

        Me.id_usuario = id_usuario

    End Sub

    Public Sub agregarGrupoUsuarioNuevo()

        Dim xdb As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xdb.Open()

            XSTR.Append("INSERT INTO GRUPOS_USUARIOS ")
            XSTR.AppendLine()
            XSTR.Append("SELECT G.id_grupo, U.id_usuario   ")
            XSTR.AppendLine()
            XSTR.Append("FROM")
            XSTR.AppendLine()
            XSTR.Append("GRUPOS AS G, USUARIOS AS U")
            XSTR.AppendLine()
            XSTR.Append(" WHERE")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("G.nombre ='usuarios' AND U.id_usuario=", Me.id_usuario, ""))

            xdb.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xdb.Close()

        End Try

    End Sub

    Public Sub agregarGrupoUsuario()

        Dim xdb As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xdb.Open()

            XSTR.Append("insert into GRUPOS_USUARIOS ")
            XSTR.AppendLine()
            XSTR.Append("values ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("('", Me.id_grupo, "','", Me.id_usuario, "')"))

            xdb.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xdb.Close()

        End Try

    End Sub

    Public Function traerUsuariosGrupos(ByVal id_usuario As Integer) As DataTable

        Dim xDB As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xDB.Open()


            XSTR.Append("SELECT G.nombre, G.id_grupo")
            XSTR.AppendLine()
            XSTR.Append("FROM")
            XSTR.AppendLine()
            XSTR.Append("GRUPOS_USUARIOS AS GU INNER JOIN GRUPOS AS G")
            XSTR.AppendLine()
            XSTR.Append("ON GU.id_grupo = G.id_grupo")
            XSTR.AppendLine()
            XSTR.Append("WHERE ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("GU.id_usuario= ", id_usuario, ""))

            Return xDB.Leer(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try

    End Function

    Public Sub quitarGrupoUsuario()

        Dim xdb As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xdb.Open()

            XSTR.Append("DELETE FROM GRUPOS_USUARIOS ")
            XSTR.AppendLine()
            XSTR.Append("WHERE ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("id_grupo=", Me.id_grupo, "AND id_usuario=", Me.id_usuario, ""))

            xdb.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xdb.Close()

        End Try

    End Sub

End Class
