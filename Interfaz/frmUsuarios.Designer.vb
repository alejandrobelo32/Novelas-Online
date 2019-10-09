<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.cbHabilitado = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGrupos = New System.Windows.Forms.ComboBox()
        Me.dgvGruposUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnAgregarGrupo = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvGruposUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tiza", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(66, 13)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(0, 13)
        Me.lblUsuario.TabIndex = 1
        '
        'cbHabilitado
        '
        Me.cbHabilitado.AutoSize = True
        Me.cbHabilitado.Location = New System.Drawing.Point(520, 11)
        Me.cbHabilitado.Name = "cbHabilitado"
        Me.cbHabilitado.Size = New System.Drawing.Size(15, 14)
        Me.cbHabilitado.TabIndex = 2
        Me.cbHabilitado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tiza", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(387, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Habilitado:"
        '
        'cmbGrupos
        '
        Me.cmbGrupos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmbGrupos.FormattingEnabled = True
        Me.cmbGrupos.Location = New System.Drawing.Point(16, 263)
        Me.cmbGrupos.Name = "cmbGrupos"
        Me.cmbGrupos.Size = New System.Drawing.Size(121, 21)
        Me.cmbGrupos.TabIndex = 5
        '
        'dgvGruposUsuarios
        '
        Me.dgvGruposUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGruposUsuarios.Location = New System.Drawing.Point(150, 79)
        Me.dgvGruposUsuarios.Name = "dgvGruposUsuarios"
        Me.dgvGruposUsuarios.Size = New System.Drawing.Size(286, 114)
        Me.dgvGruposUsuarios.TabIndex = 6
        '
        'btnAgregarGrupo
        '
        Me.btnAgregarGrupo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAgregarGrupo.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarGrupo.Location = New System.Drawing.Point(250, 261)
        Me.btnAgregarGrupo.Name = "btnAgregarGrupo"
        Me.btnAgregarGrupo.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarGrupo.TabIndex = 7
        Me.btnAgregarGrupo.Text = "Agregar "
        Me.btnAgregarGrupo.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnQuitar.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.Location = New System.Drawing.Point(470, 263)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 8
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tiza", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(13, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Grupos:"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Interfaz.My.Resources.Resources._4m
        Me.ClientSize = New System.Drawing.Size(557, 298)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregarGrupo)
        Me.Controls.Add(Me.dgvGruposUsuarios)
        Me.Controls.Add(Me.cmbGrupos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbHabilitado)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUsuarios"
        Me.Text = "frmUsuarios"
        CType(Me.dgvGruposUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents cbHabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents dgvGruposUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregarGrupo As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
