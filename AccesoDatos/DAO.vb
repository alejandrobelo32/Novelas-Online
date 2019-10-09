Imports System.Data.SqlClient

Public Class DAO

    Private Property CN As SqlConnection

    ''' <summary>
    ''' Función para manejar  connection string 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetConnectionString() As String

        Try

            Return "Data Source=.\SQLEXPRESS;Initial Catalog= DB_NOVELAS_ONLINE;Integrated security= true" 'connection string 

        Catch ex As Exception

            Throw ex

        End Try

    End Function


    ''' <summary>
    ''' metodo para abrir conexion 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Open()

        Try

            CN = New SqlConnection 'instancio nuevo objeto connection 

            CN.ConnectionString = GetConnectionString() 'paso connection string desde la funcion 

            If Not CN.State = ConnectionState.Open Then 'chequeo estado 
                CN.Open() 'abro conexion 
            End If

        Catch ex As Exception

            Throw ex

        End Try

    End Sub


    ''' <summary>
    ''' Metodo para cerrar conexion 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Close()

        Try

            If Not CN.State = ConnectionState.Closed Then 'si el estado no es cerrado 
                CN.Close() 'cierro conexion 
            End If

        Catch ex As Exception

            Throw ex

        End Try

    End Sub



    Public Sub Ejecutar()



    End Sub

    Public Sub Guardar(ByVal pQuery As String)
        Try
            Dim CMD As New SqlCommand 'instancio objeto command 

            CMD.Connection = CN 'al command le digo que conexion tiene que usar 

            CMD.CommandText = pQuery 'consulta a ejecutar 

            CMD.CommandType = CommandType.Text 'tipo de command 

            CMD.CommandTimeout = 9000 'timeout 

            CMD.ExecuteNonQuery()

        Catch ex As Exception

            Throw ex

        End Try
    End Sub


    ''' <summary>
    ''' Función para leer datos de la abase de datos 
    ''' </summary>
    ''' <param name="pQuery"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Leer(ByVal pQuery As String) As DataTable

        Try
            Dim CMD As New SqlCommand 'instancio objeto command 

            Dim DT As New DataTable

            Dim DA As SqlDataAdapter = New SqlDataAdapter(CMD) 'isntancio dataadapter 

            CMD.Connection = CN 'al command le digo que conexion tiene que usar 

            CMD.CommandText = pQuery 'consulta a ejecutar 

            CMD.CommandType = CommandType.Text 'tipo de command 

            ' CMD.CommandTimeout = 9000 'timeout 

            DA.Fill(DT) ''lleno el datatable desde dataadapter 

            Return DT

        Catch ex As Exception

            Throw ex

        End Try

    End Function


End Class
