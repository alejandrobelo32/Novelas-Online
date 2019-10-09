Public Class frmPublicar

    Public Property usuarioActual As DataRow
    Public Property novelaActual As DataRow
    Public Property novelaActualizar As DataRow
    Dim novela As New Novela

    Private Sub frmPublicar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            cmbGenero.Items.Add("Accion")
            cmbGenero.Items.Add("Sci-fi")
            cmbGenero.Items.Add("Policial")
            cmbGenero.Items.Add("Suspenso")
            cmbGenero.Items.Add("Aventura")
            cmbGenero.Items.Add("Romance")


            If novelaActual Is Nothing Then

                Me.txtUsuario.Enabled = False

                Me.txtUsuario.Text = Me.usuarioActual("nombre_usuario").ToString

                If Not novelaActualizar Is Nothing Then

                    Me.txtTitulo.Text = novelaActualizar("titulo").ToString
                    Me.txtTitulo.Enabled = False

                    Me.txtUsuario.Text = novelaActualizar("nombre_usuario").ToString
                    Me.txtUsuario.Enabled = False

                    Me.cmbGenero.SelectedText = (novelaActualizar("genero").ToString)
                    Me.cmbGenero.Enabled = False

                    Me.rtbPrologo.Text = novelaActualizar("descripcion").ToString
                    Me.rtbPrologo.Enabled = False

                    Me.txtAutor.Text = novelaActualizar("autor").ToString
                    Me.txtAutor.Enabled = False

                    Me.rtbCuerpo.Text = novelaActualizar("cuerpo").ToString
                    Me.rtbCuerpo.Enabled = False

                    Me.cbHabilitado.Checked = novelaActualizar("habilitado")

                    Me.btnSubir.Enabled = False

                    Me.btnActualizar.Enabled = True

                End If

            Else

                Me.txtTitulo.Text = novelaActual("titulo").ToString
                Me.txtTitulo.Enabled = False

                Me.txtUsuario.Text = novelaActual("nombre_usuario").ToString
                Me.txtUsuario.Enabled = False

                Me.cmbGenero.SelectedText = (novelaActual("genero").ToString)
                Me.cmbGenero.Enabled = False

                Me.rtbPrologo.Text = novelaActual("descripcion").ToString
                Me.rtbPrologo.Enabled = False

                Me.txtAutor.Text = novelaActual("autor").ToString
                Me.txtAutor.Enabled = False

                Me.rtbCuerpo.Text = novelaActual("cuerpo").ToString
                Me.rtbCuerpo.Enabled = False

                Me.cbHabilitado.Enabled = False

                Me.Label4.Enabled = False

                Me.btnSubir.Enabled = False

                Me.btnActualizar.Enabled = False

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al cargar novela", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        

    End Sub




    Private Sub btnSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubir.Click

        Try

            Dim novela As New Novela(Me.txtTitulo.Text, Me.cmbGenero.Text, Me.rtbPrologo.Text, Me.txtAutor.Text, Me.rtbCuerpo.Text, Me.usuarioActual("id_usuario").ToString)

            novela.agregarNovela()

            MessageBox.Show("La novela se ha publicado con exito!")

            frmCatalogo.btnNovelas.PerformClick()

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al agregar novela", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        

    End Sub

    Private Sub cbHabilitado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbHabilitado.CheckedChanged

        Try

            novela.habilitarNovela(novelaActualizar("id_novela").ToString, Me.cbHabilitado.Checked)

            frmCatalogo.verificarPermisos()

            frmCatalogo.btnNovelas.PerformClick()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error al habilitar novela")

        End Try

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class