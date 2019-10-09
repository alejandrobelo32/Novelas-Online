<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrupos))
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUsuarios = New System.Windows.Forms.GroupBox()
        Me.cbListarUsuario = New System.Windows.Forms.CheckBox()
        Me.cbModificarUsuario = New System.Windows.Forms.CheckBox()
        Me.cbBajaUsuario = New System.Windows.Forms.CheckBox()
        Me.btnNovelas = New System.Windows.Forms.GroupBox()
        Me.cbListarNovela = New System.Windows.Forms.CheckBox()
        Me.cbModificarNovela = New System.Windows.Forms.CheckBox()
        Me.cbBajaNovela = New System.Windows.Forms.CheckBox()
        Me.cbAltaNovela = New System.Windows.Forms.CheckBox()
        Me.btnGrupos = New System.Windows.Forms.GroupBox()
        Me.cbListarGrupo = New System.Windows.Forms.CheckBox()
        Me.cbModificarGrupo = New System.Windows.Forms.CheckBox()
        Me.cbBajaGrupo = New System.Windows.Forms.CheckBox()
        Me.cbAltaGrupo = New System.Windows.Forms.CheckBox()
        Me.btnCrearGrupo = New System.Windows.Forms.Button()
        Me.btnActualizarGrupo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbHabilitado = New System.Windows.Forms.CheckBox()
        Me.btnUsuarios.SuspendLayout()
        Me.btnNovelas.SuspendLayout()
        Me.btnGrupos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(93, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tiza", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(5, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre:"
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuarios.Controls.Add(Me.cbListarUsuario)
        Me.btnUsuarios.Controls.Add(Me.cbModificarUsuario)
        Me.btnUsuarios.Controls.Add(Me.cbBajaUsuario)
        Me.btnUsuarios.Font = New System.Drawing.Font("Tiza", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUsuarios.Location = New System.Drawing.Point(8, 60)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(127, 121)
        Me.btnUsuarios.TabIndex = 13
        Me.btnUsuarios.TabStop = False
        Me.btnUsuarios.Text = "Usuarios"
        '
        'cbListarUsuario
        '
        Me.cbListarUsuario.AutoSize = True
        Me.cbListarUsuario.Location = New System.Drawing.Point(6, 64)
        Me.cbListarUsuario.Name = "cbListarUsuario"
        Me.cbListarUsuario.Size = New System.Drawing.Size(89, 20)
        Me.cbListarUsuario.TabIndex = 3
        Me.cbListarUsuario.Text = "Listar"
        Me.cbListarUsuario.UseVisualStyleBackColor = True
        '
        'cbModificarUsuario
        '
        Me.cbModificarUsuario.AutoSize = True
        Me.cbModificarUsuario.Location = New System.Drawing.Point(6, 41)
        Me.cbModificarUsuario.Name = "cbModificarUsuario"
        Me.cbModificarUsuario.Size = New System.Drawing.Size(121, 20)
        Me.cbModificarUsuario.TabIndex = 2
        Me.cbModificarUsuario.Text = "Modificar"
        Me.cbModificarUsuario.UseVisualStyleBackColor = True
        '
        'cbBajaUsuario
        '
        Me.cbBajaUsuario.AutoSize = True
        Me.cbBajaUsuario.ForeColor = System.Drawing.Color.White
        Me.cbBajaUsuario.Location = New System.Drawing.Point(6, 19)
        Me.cbBajaUsuario.Name = "cbBajaUsuario"
        Me.cbBajaUsuario.Size = New System.Drawing.Size(73, 20)
        Me.cbBajaUsuario.TabIndex = 1
        Me.cbBajaUsuario.Text = "Baja"
        Me.cbBajaUsuario.UseVisualStyleBackColor = True
        '
        'btnNovelas
        '
        Me.btnNovelas.BackColor = System.Drawing.Color.Transparent
        Me.btnNovelas.Controls.Add(Me.cbListarNovela)
        Me.btnNovelas.Controls.Add(Me.cbModificarNovela)
        Me.btnNovelas.Controls.Add(Me.cbBajaNovela)
        Me.btnNovelas.Controls.Add(Me.cbAltaNovela)
        Me.btnNovelas.Font = New System.Drawing.Font("Tiza", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovelas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNovelas.Location = New System.Drawing.Point(161, 60)
        Me.btnNovelas.Name = "btnNovelas"
        Me.btnNovelas.Size = New System.Drawing.Size(131, 121)
        Me.btnNovelas.TabIndex = 14
        Me.btnNovelas.TabStop = False
        Me.btnNovelas.Text = "Novelas"
        '
        'cbListarNovela
        '
        Me.cbListarNovela.AutoSize = True
        Me.cbListarNovela.Location = New System.Drawing.Point(6, 89)
        Me.cbListarNovela.Name = "cbListarNovela"
        Me.cbListarNovela.Size = New System.Drawing.Size(89, 20)
        Me.cbListarNovela.TabIndex = 7
        Me.cbListarNovela.Text = "Listar"
        Me.cbListarNovela.UseVisualStyleBackColor = True
        '
        'cbModificarNovela
        '
        Me.cbModificarNovela.AutoSize = True
        Me.cbModificarNovela.Location = New System.Drawing.Point(6, 66)
        Me.cbModificarNovela.Name = "cbModificarNovela"
        Me.cbModificarNovela.Size = New System.Drawing.Size(121, 20)
        Me.cbModificarNovela.TabIndex = 6
        Me.cbModificarNovela.Text = "Modificar"
        Me.cbModificarNovela.UseVisualStyleBackColor = True
        '
        'cbBajaNovela
        '
        Me.cbBajaNovela.AutoSize = True
        Me.cbBajaNovela.Location = New System.Drawing.Point(6, 43)
        Me.cbBajaNovela.Name = "cbBajaNovela"
        Me.cbBajaNovela.Size = New System.Drawing.Size(73, 20)
        Me.cbBajaNovela.TabIndex = 5
        Me.cbBajaNovela.Text = "Baja"
        Me.cbBajaNovela.UseVisualStyleBackColor = True
        '
        'cbAltaNovela
        '
        Me.cbAltaNovela.AutoSize = True
        Me.cbAltaNovela.Location = New System.Drawing.Point(6, 20)
        Me.cbAltaNovela.Name = "cbAltaNovela"
        Me.cbAltaNovela.Size = New System.Drawing.Size(75, 20)
        Me.cbAltaNovela.TabIndex = 4
        Me.cbAltaNovela.Text = "Alta"
        Me.cbAltaNovela.UseVisualStyleBackColor = True
        '
        'btnGrupos
        '
        Me.btnGrupos.BackColor = System.Drawing.Color.Transparent
        Me.btnGrupos.Controls.Add(Me.cbListarGrupo)
        Me.btnGrupos.Controls.Add(Me.cbModificarGrupo)
        Me.btnGrupos.Controls.Add(Me.cbBajaGrupo)
        Me.btnGrupos.Controls.Add(Me.cbAltaGrupo)
        Me.btnGrupos.Font = New System.Drawing.Font("Tiza", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGrupos.Location = New System.Drawing.Point(318, 60)
        Me.btnGrupos.Name = "btnGrupos"
        Me.btnGrupos.Size = New System.Drawing.Size(131, 121)
        Me.btnGrupos.TabIndex = 15
        Me.btnGrupos.TabStop = False
        Me.btnGrupos.Text = "Grupos"
        '
        'cbListarGrupo
        '
        Me.cbListarGrupo.AutoSize = True
        Me.cbListarGrupo.Location = New System.Drawing.Point(6, 89)
        Me.cbListarGrupo.Name = "cbListarGrupo"
        Me.cbListarGrupo.Size = New System.Drawing.Size(89, 20)
        Me.cbListarGrupo.TabIndex = 7
        Me.cbListarGrupo.Text = "Listar"
        Me.cbListarGrupo.UseVisualStyleBackColor = True
        '
        'cbModificarGrupo
        '
        Me.cbModificarGrupo.AutoSize = True
        Me.cbModificarGrupo.Location = New System.Drawing.Point(6, 66)
        Me.cbModificarGrupo.Name = "cbModificarGrupo"
        Me.cbModificarGrupo.Size = New System.Drawing.Size(121, 20)
        Me.cbModificarGrupo.TabIndex = 6
        Me.cbModificarGrupo.Text = "Modificar"
        Me.cbModificarGrupo.UseVisualStyleBackColor = True
        '
        'cbBajaGrupo
        '
        Me.cbBajaGrupo.AutoSize = True
        Me.cbBajaGrupo.Location = New System.Drawing.Point(6, 43)
        Me.cbBajaGrupo.Name = "cbBajaGrupo"
        Me.cbBajaGrupo.Size = New System.Drawing.Size(73, 20)
        Me.cbBajaGrupo.TabIndex = 5
        Me.cbBajaGrupo.Text = "Baja"
        Me.cbBajaGrupo.UseVisualStyleBackColor = True
        '
        'cbAltaGrupo
        '
        Me.cbAltaGrupo.AutoSize = True
        Me.cbAltaGrupo.Location = New System.Drawing.Point(6, 20)
        Me.cbAltaGrupo.Name = "cbAltaGrupo"
        Me.cbAltaGrupo.Size = New System.Drawing.Size(75, 20)
        Me.cbAltaGrupo.TabIndex = 4
        Me.cbAltaGrupo.Text = "Alta"
        Me.cbAltaGrupo.UseVisualStyleBackColor = True
        '
        'btnCrearGrupo
        '
        Me.btnCrearGrupo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCrearGrupo.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearGrupo.Location = New System.Drawing.Point(93, 225)
        Me.btnCrearGrupo.Name = "btnCrearGrupo"
        Me.btnCrearGrupo.Size = New System.Drawing.Size(85, 23)
        Me.btnCrearGrupo.TabIndex = 16
        Me.btnCrearGrupo.Text = "Crear grupo"
        Me.btnCrearGrupo.UseVisualStyleBackColor = False
        '
        'btnActualizarGrupo
        '
        Me.btnActualizarGrupo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnActualizarGrupo.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarGrupo.Location = New System.Drawing.Point(268, 225)
        Me.btnActualizarGrupo.Name = "btnActualizarGrupo"
        Me.btnActualizarGrupo.Size = New System.Drawing.Size(85, 23)
        Me.btnActualizarGrupo.TabIndex = 17
        Me.btnActualizarGrupo.Text = "Actualizar"
        Me.btnActualizarGrupo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tiza", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(296, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Habilitado:"
        '
        'cbHabilitado
        '
        Me.cbHabilitado.AutoSize = True
        Me.cbHabilitado.Location = New System.Drawing.Point(430, 17)
        Me.cbHabilitado.Name = "cbHabilitado"
        Me.cbHabilitado.Size = New System.Drawing.Size(15, 14)
        Me.cbHabilitado.TabIndex = 18
        Me.cbHabilitado.UseVisualStyleBackColor = True
        '
        'frmGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Interfaz.My.Resources.Resources._6mf
        Me.ClientSize = New System.Drawing.Size(461, 295)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbHabilitado)
        Me.Controls.Add(Me.btnActualizarGrupo)
        Me.Controls.Add(Me.btnCrearGrupo)
        Me.Controls.Add(Me.btnGrupos)
        Me.Controls.Add(Me.btnNovelas)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGrupos"
        Me.Text = "Grupos"
        Me.btnUsuarios.ResumeLayout(False)
        Me.btnUsuarios.PerformLayout()
        Me.btnNovelas.ResumeLayout(False)
        Me.btnNovelas.PerformLayout()
        Me.btnGrupos.ResumeLayout(False)
        Me.btnGrupos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents btnNovelas As System.Windows.Forms.GroupBox
    Friend WithEvents btnGrupos As System.Windows.Forms.GroupBox
    Friend WithEvents btnCrearGrupo As System.Windows.Forms.Button
    Friend WithEvents cbModificarUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents cbBajaUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents cbListarNovela As System.Windows.Forms.CheckBox
    Friend WithEvents cbModificarNovela As System.Windows.Forms.CheckBox
    Friend WithEvents cbBajaNovela As System.Windows.Forms.CheckBox
    Friend WithEvents cbAltaNovela As System.Windows.Forms.CheckBox
    Friend WithEvents cbListarGrupo As System.Windows.Forms.CheckBox
    Friend WithEvents cbModificarGrupo As System.Windows.Forms.CheckBox
    Friend WithEvents cbBajaGrupo As System.Windows.Forms.CheckBox
    Friend WithEvents cbAltaGrupo As System.Windows.Forms.CheckBox
    Friend WithEvents btnActualizarGrupo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbHabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents cbListarUsuario As System.Windows.Forms.CheckBox
End Class
