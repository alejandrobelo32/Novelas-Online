<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatalogo))
        Me.dgvCatalogo = New System.Windows.Forms.DataGridView()
        Me.btnModificacion = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.lblUsuarioCatalogo = New System.Windows.Forms.Label()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnNovelas = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnGrupos = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        CType(Me.dgvCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCatalogo
        '
        Me.dgvCatalogo.AllowUserToAddRows = False
        Me.dgvCatalogo.AllowUserToDeleteRows = False
        Me.dgvCatalogo.AllowUserToResizeColumns = False
        Me.dgvCatalogo.AllowUserToResizeRows = False
        Me.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCatalogo.Location = New System.Drawing.Point(119, 112)
        Me.dgvCatalogo.MultiSelect = False
        Me.dgvCatalogo.Name = "dgvCatalogo"
        Me.dgvCatalogo.ReadOnly = True
        Me.dgvCatalogo.Size = New System.Drawing.Size(562, 372)
        Me.dgvCatalogo.TabIndex = 0
        '
        'btnModificacion
        '
        Me.btnModificacion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnModificacion.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificacion.Location = New System.Drawing.Point(585, 509)
        Me.btnModificacion.Name = "btnModificacion"
        Me.btnModificacion.Size = New System.Drawing.Size(96, 23)
        Me.btnModificacion.TabIndex = 1
        Me.btnModificacion.Text = "Modificacion"
        Me.btnModificacion.UseVisualStyleBackColor = False
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAlta.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlta.Location = New System.Drawing.Point(119, 509)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(96, 23)
        Me.btnAlta.TabIndex = 2
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'lblUsuarioCatalogo
        '
        Me.lblUsuarioCatalogo.AutoSize = True
        Me.lblUsuarioCatalogo.Location = New System.Drawing.Point(37, 9)
        Me.lblUsuarioCatalogo.Name = "lblUsuarioCatalogo"
        Me.lblUsuarioCatalogo.Size = New System.Drawing.Size(0, 13)
        Me.lblUsuarioCatalogo.TabIndex = 4
        '
        'btnBaja
        '
        Me.btnBaja.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnBaja.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaja.Location = New System.Drawing.Point(376, 509)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(96, 23)
        Me.btnBaja.TabIndex = 6
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = False
        '
        'btnNovelas
        '
        Me.btnNovelas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnNovelas.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovelas.Location = New System.Drawing.Point(119, 67)
        Me.btnNovelas.Name = "btnNovelas"
        Me.btnNovelas.Size = New System.Drawing.Size(96, 23)
        Me.btnNovelas.TabIndex = 7
        Me.btnNovelas.Text = "Novelas"
        Me.btnNovelas.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnUsuarios.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.Location = New System.Drawing.Point(376, 67)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(96, 23)
        Me.btnUsuarios.TabIndex = 8
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnGrupos
        '
        Me.btnGrupos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnGrupos.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupos.Location = New System.Drawing.Point(585, 67)
        Me.btnGrupos.Name = "btnGrupos"
        Me.btnGrupos.Size = New System.Drawing.Size(96, 23)
        Me.btnGrupos.TabIndex = 9
        Me.btnGrupos.Text = "Grupos"
        Me.btnGrupos.UseVisualStyleBackColor = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.Location = New System.Drawing.Point(697, 12)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(116, 23)
        Me.btnCerrarSesion.TabIndex = 10
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'frmCatalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Interfaz.My.Resources.Resources._5m
        Me.ClientSize = New System.Drawing.Size(823, 556)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnGrupos)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Controls.Add(Me.btnNovelas)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.lblUsuarioCatalogo)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnModificacion)
        Me.Controls.Add(Me.dgvCatalogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCatalogo"
        Me.Text = "frmCatalogo"
        CType(Me.dgvCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCatalogo As System.Windows.Forms.DataGridView
    Friend WithEvents btnModificacion As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents lblUsuarioCatalogo As System.Windows.Forms.Label
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnNovelas As System.Windows.Forms.Button
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnGrupos As System.Windows.Forms.Button
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
End Class
