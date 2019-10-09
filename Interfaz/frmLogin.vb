Imports System.Linq
Imports System
Imports System.Text
Imports System.Security
Imports System.Security.Cryptography


Public Class frmLogin

    Public Property usuario As DataRow

    Private Sub btnRegistrarse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarse.Click


        Using frmR As New frmRegistrarse

            Me.Visible = False

            frmR.ShowDialog()

            If frmR.usuarioActual Is Nothing Then

                Me.Visible = True

            Else

                Me.usuario = frmR.usuarioActual

            End If

        End Using


    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Try

            Dim contrasena() As Byte
            Dim hashContrasena() As Byte

            contrasena = ASCIIEncoding.ASCII.GetBytes(Me.txtPW.Text)

            hashContrasena = New MD5CryptoServiceProvider().ComputeHash(contrasena)

            Dim usuario As New Usuario

            Dim resultado As DataTable

            resultado = usuario.iniciarSesion(Me.txtUsuario.Text, Convert.ToBase64String(hashContrasena))

            If resultado.Rows.Count() = 0 Then

                Throw New Exception("Usuario o contraseña incorrectos")

            Else

                Me.usuario = resultado.Rows.Item(0)

                Me.Close()

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try




    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmCatalogo.Close()

    End Sub
End Class