Public Class frmCatalogo

    'Private Property frmLogin As New Form

    Public Property usuario As New Usuario
    Public Property novela As New Novela
    Public Property grupo As New Grupo
    Public Property usuarioActual As DataRow

    Enum Listas As Byte

        Novelas = 1
        NovelasUsuarios = 2
        Usuarios = 3
        Grupos = 4

    End Enum

    Private lista As Listas


    Private Sub frmCatalogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.dgvCatalogo.MultiSelect = False

            Me.dgvCatalogo.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            Me.btnGrupos.Enabled = False

            Me.btnNovelas.Enabled = False

            Me.btnUsuarios.Enabled = False

            Me.btnAlta.Enabled = False

            Me.btnBaja.Enabled = False

            Me.btnModificacion.Enabled = False

            Using frmL As New frmLogin

                frmL.usuario = Nothing

                frmL.ShowDialog()

                Me.usuarioActual = frmL.usuario

            End Using

            If Me.usuarioActual("habilitado") = True Then

                lblUsuarioCatalogo.Text = ("Hola " & Me.usuarioActual("nombre_usuario").ToString & "!")

                Me.verificarPermisos()

            Else

                lblUsuarioCatalogo.Text = ("Su usuario se encuentra inhabilitado")

            End If

            

            Me.Visible = True

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al cargar el form")

        End Try



    End Sub

    Public Sub verificarPermisos()

        Me.dgvCatalogo.MultiSelect = False

        Me.Visible = True

        Me.btnGrupos.Enabled = False

        Me.btnNovelas.Enabled = False

        Me.btnUsuarios.Enabled = False

        Me.btnAlta.Enabled = False

        Me.btnBaja.Enabled = False

        Me.btnModificacion.Enabled = False

        For Each DR As DataRow In usuario.traerPermisos(Me.usuarioActual("id_usuario").ToString).Rows

            For Each CTRL As Control In Me.Controls

                If CTRL.GetType = GetType(Button) Then

                    If String.Equals(CTRL.Name, DR("objeto").ToString) = True Then

                        If DR("listar") = True Then

                            CTRL.Enabled = True

                        End If

                    End If

                End If

            Next

        Next


    End Sub

    Private Sub btnNovelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovelas.Click

        Try
            

                dgvCatalogo.DataSource = novela.listarNovelas()

                lista = Listas.Novelas

                Me.btnAlta.Enabled = False

                Me.btnBaja.Enabled = False

                Me.btnModificacion.Enabled = False

                For Each DR As DataRow In usuario.traerPermisos(Me.usuarioActual("id_usuario").ToString).Rows

                    If DR("objeto").ToString = "btnNovelas" Then

                        If DR("alta") = True Then

                            btnAlta.Enabled = True

                        End If

                        If DR("baja") = True Then

                            btnBaja.Enabled = True

                        End If

                        If DR("modificacion") = True Then

                            btnModificacion.Enabled = True

                        End If

                    End If

                Next

           

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al cargar novelas")

        End Try


    End Sub

    Private Sub btnUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuarios.Click

        Try

            dgvCatalogo.DataSource = usuario.listarUsuarios()

            lista = Listas.Usuarios

            Me.btnAlta.Enabled = False

            Me.btnBaja.Enabled = False

            Me.btnModificacion.Enabled = False

            For Each DR As DataRow In usuario.traerPermisos(Me.usuarioActual("id_usuario").ToString).Rows

                If DR("objeto").ToString = "btnUsuarios" Then

                    If DR("alta") = True Then

                        btnAlta.Enabled = True

                    End If

                    If DR("baja") = True Then

                        btnBaja.Enabled = True

                    End If

                    If DR("modificacion") = True Then

                        btnModificacion.Enabled = True

                    End If

                End If

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al cargar usuarios")

        End Try



    End Sub

    Private Sub btnGrupos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrupos.Click

        Try

            dgvCatalogo.DataSource = grupo.listarGrupos()

            lista = Listas.Grupos

            Me.btnAlta.Enabled = False

            Me.btnBaja.Enabled = False

            Me.btnModificacion.Enabled = False

            For Each DR As DataRow In usuario.traerPermisos(Me.usuarioActual("id_usuario").ToString).Rows

                If DR("objeto").ToString = "btnGrupos" Then

                    If DR("alta") = True Then

                        btnAlta.Enabled = True

                    End If

                    If DR("baja") = True Then

                        btnBaja.Enabled = True

                    End If

                    If DR("modificacion") = True Then

                        btnModificacion.Enabled = True

                    End If

                End If

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al cargar grupos")

        End Try

    End Sub



    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click

        Try

            If Me.lista = Listas.Grupos Then

                Using frmG As New frmGrupos

                    frmG.ShowDialog()

                End Using

            End If


            If Me.lista = Listas.Novelas Then

                Using frmP As New frmPublicar

                    frmP.usuarioActual = Me.usuarioActual

                    frmP.ShowDialog()

                End Using

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click

        Try

            If Me.dgvCatalogo.CurrentRow.Selected = False Then

                Throw New Exception("Debe seleccionar una fila")

            Else

                If Me.lista = Listas.Grupos Then

                    If MessageBox.Show("¿Desea eliminar el grupo seleccionado?", "Confirmar acción", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

                        Me.grupo.eliminarGrupo(Me.dgvCatalogo.CurrentRow.Cells("id_grupo").Value)

                        Me.btnGrupos.PerformClick()

                    End If

                End If


                If Me.lista = Listas.Usuarios Then

                    If MessageBox.Show("¿Desea eliminar el usuario seleccionado?", "Confirmar acción", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

                        Me.usuario.eliminarUsuario(Me.dgvCatalogo.CurrentRow.Cells("id_usuario").Value)

                        Me.btnUsuarios.PerformClick()

                    End If

                End If

                If Me.lista = Listas.Novelas Then

                    If MessageBox.Show("¿Desea eliminar la novela seleccionada?", "Confirmar acción", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

                        Me.novela.eliminarNovela(Me.dgvCatalogo.CurrentRow.Cells("id_novela").Value)

                        Me.btnNovelas.PerformClick()

                    End If

                End If

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnModificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificacion.Click


        Try

            If Me.dgvCatalogo.CurrentRow.Selected = False Then

                Throw New Exception("Debe seleccionar una fila")

            End If

            If Me.lista = Listas.Grupos Then

                Using frmG As New frmGrupos

                    frmG.grupoActualizar = (dgvCatalogo.CurrentRow.DataBoundItem).row

                    frmG.ShowDialog()

                End Using

            End If


            If Me.lista = Listas.Usuarios Then

                Using frmU As New frmUsuarios

                    frmU.usuarioActualizar = (dgvCatalogo.CurrentRow.DataBoundItem).row

                    frmU.ShowDialog()

                End Using

            End If

            If Me.lista = Listas.Novelas Then

                Using frmP As New frmPublicar

                    frmP.usuarioActual = Me.usuarioActual

                    frmP.novelaActualizar = (dgvCatalogo.CurrentRow.DataBoundItem).row

                    frmP.ShowDialog()

                End Using

            End If



        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click

        Me.Visible = False

        Me.frmCatalogo_Load(Nothing, Nothing)

    End Sub

    Private Sub dgvCatalogo_RowDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCatalogo.CellContentClick

        Try

            If Me.lista = Listas.Novelas Then

                If Me.dgvCatalogo.CurrentRow.Cells("habilitado").Value = False Then

                    Throw New Exception("La novela debe estar habilitada")

                End If

                Using frmP As New frmPublicar

                    frmP.usuarioActual = Me.usuarioActual

                    frmP.novelaActual = (dgvCatalogo.CurrentRow.DataBoundItem).row

                    frmP.ShowDialog()

                End Using

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al leer novela", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class