Imports System.Text

Public Class Novela
    Private cuerpo As String
    Private habilitado As Boolean
    Private id_novela As Integer
    Private titulo As String
    Private genero As String
    Private descripcion As String
    Private autor As String
    Private id_usuario As Integer


    Dim usuario As New Usuario

    Public Sub New()

    End Sub

    Public Sub New(ByVal titulo As String, ByVal genero As String, ByVal descripcion As String, ByVal autor As String, ByVal cuerpo As String, ByVal id_usuario As Integer)

        Try

            Me.habilitado = False

            Me.setTitulo(titulo)
            Me.setGenero(genero)
            Me.setDescripcion(descripcion)
            Me.setAutor(autor)
            Me.setCuerpo(cuerpo)
            Me.id_usuario = id_usuario

        Catch ex As Exception

            Throw ex

        End Try

    End Sub

    Private Sub setCuerpo(ByVal cuerpo As String)

        Me.cuerpo = cuerpo

    End Sub

    Public Function getCuerpo()

        Return Me.cuerpo

    End Function



    Private Sub setTitulo(ByVal titulo As String)

        Me.titulo = titulo

    End Sub

    Private Sub setGenero(ByVal genero As String)

        Me.genero = genero

    End Sub

    Private Sub setDescripcion(ByVal descripcion As String)

        Me.descripcion = descripcion

    End Sub

    Private Sub setAutor(ByVal autor As String)

        Me.autor = autor

    End Sub

    Public Function getEstado() As Boolean

        Return Me.habilitado

    End Function

    Public Function getId_Novela() As Integer

        Return Me.id_novela

    End Function

    Public Function getTitulo() As String

        Return Me.titulo

    End Function

    Public Function getGenero() As String

        Return Me.genero

    End Function

    Public Function getDescripcion() As String

        Return Me.descripcion

    End Function

    Public Function getAutor() As String

        Return Me.autor

    End Function


    Public Sub agregarNovela()

        Dim xdb As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try


            xdb.Open()


            XSTR.Append("insert into NOVELAS ")
            XSTR.AppendLine()
            XSTR.Append("values ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("('", Me.id_usuario, "','", Me.genero, "', '", Me.descripcion, "', '", Me.autor, "', '", Me.titulo, "', '", Me.cuerpo, "', '", Me.habilitado, "')"))

            xdb.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xdb.Close()

        End Try


    End Sub

    Public Function listarNovelas() As DataTable

        Dim xDB As New AccesoDatos.DAO


        Try

            xDB.Open()

            Return xDB.Leer("Select NOVELAS.*, U.nombre_usuario FROM NOVELAS INNER JOIN USUARIOS AS U ON NOVELAS.id_usuario = U.id_usuario")

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try


    End Function

    Public Function listarNovelasHabilitadas() As DataTable

        Dim xDB As New AccesoDatos.DAO


        Try

            xDB.Open()


            Return xDB.Leer("Select *  from NOVELAS WHERE habilitado=1")

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try


    End Function

    Public Sub eliminarNovela(ByVal id As String)

        Dim xdb As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xdb.Open()

            XSTR.Append("DELETE FROM NOVELAS ")
            XSTR.AppendLine()
            XSTR.Append("WHERE ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("id_novela =", id, ""))

            xdb.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xdb.Close()

        End Try

    End Sub

    Sub habilitarNovela(ByVal id_novela As Integer, ByVal habilitado As Boolean)

        Dim xDB As New AccesoDatos.DAO
        Dim XSTR As New StringBuilder

        Try

            xDB.Open()

            XSTR.Append("UPDATE NOVELAS ")
            XSTR.AppendLine()
            XSTR.Append("SET ")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("habilitado='", habilitado, "'"))
            XSTR.AppendLine()
            XSTR.Append("WHERE")
            XSTR.AppendLine()
            XSTR.Append(String.Concat("id_novela= ", id_novela, ""))

            xDB.Guardar(XSTR.ToString)

        Catch ex As Exception

            Throw ex

        Finally

            xDB.Close()

        End Try

    End Sub

End Class
