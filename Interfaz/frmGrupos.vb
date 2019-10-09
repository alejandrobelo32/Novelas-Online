Public Class frmGrupos

    Public Property grupoActualizar As DataRow
    Public Property grupo As New Grupo
    Dim grupoPermiso As New GrupoPermiso

    Private Sub frmGrupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try

            Me.btnCrearGrupo.Enabled = False
            Me.btnActualizarGrupo.Enabled = False

            If Not grupoActualizar Is Nothing Then

                Me.cbHabilitado.Checked = grupoActualizar("habilitado")

                Me.btnActualizarGrupo.Enabled = True

                Me.txtNombre.Text = grupoActualizar("nombre")

                For Each DR As DataRow In grupo.traerPermisos(Me.grupoActualizar("id_grupo").ToString).Rows

                    If DR("id_permiso") = 3 Then

                        If DR("alta") = True Then

                            Me.cbAltaGrupo.Checked = True

                        End If

                        If DR("baja") = True Then

                            Me.cbBajaGrupo.Checked = True

                        End If

                        If DR("modificacion") = True Then

                            Me.cbModificarGrupo.Checked = True

                        End If

                        If DR("listar") = True Then

                            Me.cbListarGrupo.Checked = True

                        End If

                    End If

                    If DR("id_permiso") = 2 Then

                        If DR("baja") = True Then

                            Me.cbBajaUsuario.Checked = True

                        End If

                        If DR("modificacion") = True Then

                            Me.cbModificarUsuario.Checked = True

                        End If

                        If DR("listar") = True Then

                            Me.cbListarUsuario.Checked = True

                        End If

                    End If

                    If DR("id_permiso") = 1 Then

                        If DR("alta") = True Then

                            Me.cbAltaNovela.Checked = True

                        End If

                        If DR("baja") = True Then

                            Me.cbBajaNovela.Checked = True

                        End If

                        If DR("modificacion") = True Then

                            Me.cbModificarNovela.Checked = True

                        End If

                        If DR("listar") = True Then

                            Me.cbListarNovela.Checked = True

                        End If

                    End If

                Next

            Else

                Me.btnCrearGrupo.Enabled = True

            End If

        Catch ex As Exception

            Windows.Forms.MessageBox.Show(ex.Message, "Error")

        End Try

    End Sub



    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearGrupo.Click

        Try

            grupo = New Grupo(Me.txtNombre.Text, Me.cbHabilitado.Checked)

            grupo.agregarGrupo()

            grupoPermiso = New GrupoPermiso(grupo.getIdGrupo(), 3, Me.cbAltaGrupo.Checked, Me.cbBajaGrupo.Checked, Me.cbModificarGrupo.Checked, Me.cbListarGrupo.Checked)

            grupoPermiso.agregarPermisosGrupos()

            grupoPermiso = New GrupoPermiso(grupo.getIdGrupo(), 2, False, Me.cbBajaUsuario.Checked, Me.cbModificarUsuario.Checked, Me.cbListarUsuario.Checked)

            grupoPermiso.agregarPermisosGrupos()

            grupoPermiso = New GrupoPermiso(grupo.getIdGrupo(), 1, Me.cbAltaNovela.Checked, Me.cbBajaNovela.Checked, Me.cbModificarNovela.Checked, Me.cbListarNovela.Checked)

            grupoPermiso.agregarPermisosGrupos()

            MessageBox.Show("El grupo se ha creado con exito")

            frmCatalogo.btnGrupos.PerformClick()

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al crear grupo")

        End Try


    End Sub


    Private Sub btnActualizarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarGrupo.Click

        Try

            grupo = New Grupo(Me.txtNombre.Text, Me.cbHabilitado.Checked)

            grupo.actualizarGrupo(grupoActualizar("id_grupo"))

            grupoPermiso = New GrupoPermiso(grupoActualizar("id_grupo"), 3, Me.cbAltaGrupo.Checked, Me.cbBajaGrupo.Checked, Me.cbModificarGrupo.Checked, Me.cbListarGrupo.Checked)

            grupoPermiso.actualizarPermisos()

            grupoPermiso = New GrupoPermiso(grupoActualizar("id_grupo"), 2, False, Me.cbBajaUsuario.Checked, Me.cbModificarUsuario.Checked, Me.cbListarUsuario.Checked)

            grupoPermiso.actualizarPermisos()

            grupoPermiso = New GrupoPermiso(grupoActualizar("id_grupo"), 1, Me.cbAltaNovela.Checked, Me.cbBajaNovela.Checked, Me.cbModificarNovela.Checked, Me.cbListarNovela.Checked)

            grupoPermiso.actualizarPermisos()

            MessageBox.Show("El grupo se ha actualizado con exito")

            frmCatalogo.verificarPermisos()

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al actualizar grupo")

        End Try


    End Sub

    Private Sub cbHabilitado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbHabilitado.CheckedChanged

        Try

            grupo.habilitarGrupo(grupoActualizar("id_grupo").ToString, Me.cbHabilitado.Checked)

            frmCatalogo.verificarPermisos()

            frmCatalogo.btnGrupos.PerformClick()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al habilitar grupo")

        End Try

    End Sub

    Private Sub cbBajaUsuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBajaUsuario.CheckedChanged

    End Sub

    Private Sub cbModificarUsuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbModificarUsuario.CheckedChanged

    End Sub

    Private Sub cbListarUsuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbListarUsuario.CheckedChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class