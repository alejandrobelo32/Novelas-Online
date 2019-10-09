Public Class frmUsuarios

    Public Property usuarioActualizar As DataRow
    Dim usuario As New Usuario
    Dim grupoUsuario As New GrupoUsuario
    Dim grupo As New Grupo

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.lblUsuario.Text = usuarioActualizar("nombre_usuario").ToString

            Me.cbHabilitado.Checked = usuarioActualizar("habilitado")

            Me.dgvGruposUsuarios.DataSource = grupoUsuario.traerUsuariosGrupos(usuarioActualizar("id_usuario").ToString)

            Me.cmbGrupos.DataSource = grupo.listarGrupos()

            Me.cmbGrupos.DisplayMember = ("nombre")

            Me.cmbGrupos.ValueMember = ("id_grupo")

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al cargar usuario")

        End Try
        



    End Sub

    Private Sub cbHabilitado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbHabilitado.CheckedChanged

        Try

            usuario.habilitarUsuario(usuarioActualizar("id_usuario").ToString, Me.cbHabilitado.Checked)

            frmCatalogo.verificarPermisos()

            frmCatalogo.btnUsuarios.PerformClick()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al habilitar usuario")

        End Try


    End Sub

    Private Sub btnAgregarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGrupo.Click

        Try

            grupoUsuario = New GrupoUsuario(Me.cmbGrupos.SelectedValue, usuarioActualizar("id_usuario").ToString)

            grupoUsuario.agregarGrupoUsuario()

            Me.dgvGruposUsuarios.DataSource = grupoUsuario.traerUsuariosGrupos(usuarioActualizar("id_usuario").ToString)

            frmCatalogo.verificarPermisos()

            MessageBox.Show("El usuario se ha agregado al grupo con exito")

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al agregar usuario al grupo")

        End Try


    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click

        Try

            If Me.dgvGruposUsuarios.CurrentRow.Selected = False Then

                Throw New Exception("Debe seleccionar un grupo")

            End If

            grupoUsuario = New GrupoUsuario(Me.dgvGruposUsuarios.CurrentRow.Cells("id_grupo").Value, usuarioActualizar("id_usuario").ToString)

            grupoUsuario.quitarGrupoUsuario()

            Me.dgvGruposUsuarios.DataSource = grupoUsuario.traerUsuariosGrupos(usuarioActualizar("id_usuario").ToString)

            frmCatalogo.verificarPermisos()

            MessageBox.Show("El usuario se ha quitado del grupo con exito")

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al quitar usuario del grupo")

        End Try

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class