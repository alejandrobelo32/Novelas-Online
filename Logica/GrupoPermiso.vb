Imports System.Text

Public Class GrupoPermiso

    Private id_grupo As Integer
    Private id_permiso As Integer
    Private alta As Boolean
    Private baja As Boolean
    Private modificacion As Boolean
    Private listar As Boolean

    Public Sub New()


    End Sub

    Public Sub New(ByVal id_grupo As Integer, ByVal id_permiso As Integer, ByVal alta As Boolean, ByVal baja As Boolean, ByVal modificacion As Boolean, ByVal listar As Boolean)

        Me.id_permiso = id_permiso
        Me.id_grupo = id_grupo
        Me.alta = alta
        Me.baja = baja
        Me.modificacion = modificacion
        Me.listar = listar

    End Sub

    Public Sub agregarPermisosGrupos()

        Dim xDB As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xDB.Open()


            XSTR.Append("insert into PERMISOS_GRUPOS ")
            XSTR.AppendLine()
            XSTR.Append("values ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("('", Me.id_grupo, "','", Me.id_permiso, "','", Me.alta, "','", Me.baja, "', '", Me.modificacion, "', '", Me.listar, "')"))

            xDB.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try

    End Sub

    Public Sub actualizarPermisos()

        Dim xDB As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xDB.Open()

            XSTR.Append("UPDATE PERMISOS_GRUPOS ")
            XSTR.AppendLine()
            XSTR.Append("SET ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("alta ='", Me.alta, "', baja = '", Me.baja, "', modificacion='", Me.modificacion, "', listar='", Me.listar, "'"))
            XSTR.AppendLine()
            XSTR.Append("WHERE")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("id_grupo= ", Me.id_grupo, " AND id_permiso=", Me.id_permiso, ""))


            xDB.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try

    End Sub

End Class
