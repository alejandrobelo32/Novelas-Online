Imports System.Linq
Imports System
Imports System.Text
Imports System.Security
Imports System.Security.Cryptography

Public Class frmRegistrarse

    Public Property usuarioActual As DataRow
    Dim usuario As New Usuario
    Dim grupoUsuario As New GrupoUsuario



    Private Sub btnAgregarReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

        Dim sexo As String
        sexo = Nothing


        Try

            If Me.txtNombreUsuario.Text = String.Empty Then

                Throw New Exception("El campo nombre no puede estar vacío")

            End If

            If (rbMasculinoReg.Checked Or rbFemeninoReg.Checked) = False Then

                Throw New Exception("Seleccionar un sexo")

            Else

                If rbMasculinoReg.Checked = True Then

                    sexo = "M"

                End If

                If rbFemeninoReg.Checked = True Then

                    sexo = "F"

                End If

            End If

            If Me.txtContrasena.Text = String.Empty Then

                Throw New Exception("El campo contraseña no puede estar vacío")

            End If


            If Me.txtMail.Text = String.Empty Then

                Throw New Exception("El campo mail no puede estar vacío")

            End If

            If Me.txtNombreUsuario.Text = String.Empty Then

                Throw New Exception("El campo nombre no puede estar vacío")

            End If


            Dim hashContrasena() As Byte

            hashContrasena = New MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(Me.txtContrasena.Text))

            usuario = New Usuario(Me.txtNombreUsuario.Text, Convert.ToBase64String(hashContrasena), Me.txtMail.Text,
                                       Me.txtTelefonoReg.Text, Me.txtDomicilioReg.Text, Me.dtpFechaReg.Text,
                                       sexo, Me.txtNombreYapellido.Text)


            usuario.agregarUsuario()

            Me.usuarioActual = usuario.iniciarSesion(usuario.getNombreUsuario, usuario.getContrasena).Rows.Item(0)

            Me.grupoUsuario = New GrupoUsuario(usuarioActual("id_usuario"))

            grupoUsuario.agregarGrupoUsuarioNuevo()

            MessageBox.Show("El usuario se ha registrado con éxito")

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al registrar nuevo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmRegistrarse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblSexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSexo.Click

    End Sub
End Class