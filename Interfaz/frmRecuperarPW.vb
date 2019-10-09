Public Class frmRecuperarPW

    Private Sub frmRecuperarPW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub txtMailRPW_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMailRPW.Leave

        Try

            If Me.txtMailRPW.Text = String.Empty Then

                Me.txtMailRPW.Focus()
                Throw New Exception("El campo mail no puede estar vacío")

            End If

            Dim m As New System.Net.Mail.MailAddress(txtMailRPW.Text)

        Catch ex As Exception

            Me.txtMailRPW.Focus()
            MessageBox.Show(ex.Message, "Error en el email", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub
End Class