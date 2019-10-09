<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarse))
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.dtpFechaReg = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaReg = New System.Windows.Forms.Label()
        Me.lblPassReg = New System.Windows.Forms.Label()
        Me.lblMailReg = New System.Windows.Forms.Label()
        Me.panSexo = New System.Windows.Forms.Panel()
        Me.rbMasculinoReg = New System.Windows.Forms.RadioButton()
        Me.rbFemeninoReg = New System.Windows.Forms.RadioButton()
        Me.lblNombreReg = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.btnCancelarReg = New System.Windows.Forms.Button()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombreYapellido = New System.Windows.Forms.TextBox()
        Me.txtDomicilioReg = New System.Windows.Forms.TextBox()
        Me.txtTelefonoReg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.panSexo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(202, 69)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(100, 23)
        Me.txtContrasena.TabIndex = 6
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(113, 111)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(190, 23)
        Me.txtMail.TabIndex = 5
        '
        'dtpFechaReg
        '
        Me.dtpFechaReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReg.Location = New System.Drawing.Point(203, 151)
        Me.dtpFechaReg.Name = "dtpFechaReg"
        Me.dtpFechaReg.Size = New System.Drawing.Size(100, 23)
        Me.dtpFechaReg.TabIndex = 7
        '
        'lblFechaReg
        '
        Me.lblFechaReg.AutoSize = True
        Me.lblFechaReg.Location = New System.Drawing.Point(7, 158)
        Me.lblFechaReg.Name = "lblFechaReg"
        Me.lblFechaReg.Size = New System.Drawing.Size(190, 16)
        Me.lblFechaReg.TabIndex = 4
        Me.lblFechaReg.Text = "Fecha Nacimiento: "
        '
        'lblPassReg
        '
        Me.lblPassReg.AutoSize = True
        Me.lblPassReg.Location = New System.Drawing.Point(6, 76)
        Me.lblPassReg.Name = "lblPassReg"
        Me.lblPassReg.Size = New System.Drawing.Size(128, 16)
        Me.lblPassReg.TabIndex = 3
        Me.lblPassReg.Text = "Contraseña:"
        '
        'lblMailReg
        '
        Me.lblMailReg.AutoSize = True
        Me.lblMailReg.Location = New System.Drawing.Point(7, 114)
        Me.lblMailReg.Name = "lblMailReg"
        Me.lblMailReg.Size = New System.Drawing.Size(63, 16)
        Me.lblMailReg.TabIndex = 2
        Me.lblMailReg.Text = "Mail: "
        '
        'panSexo
        '
        Me.panSexo.Controls.Add(Me.rbFemeninoReg)
        Me.panSexo.Controls.Add(Me.rbMasculinoReg)
        Me.panSexo.Location = New System.Drawing.Point(414, 137)
        Me.panSexo.Name = "panSexo"
        Me.panSexo.Size = New System.Drawing.Size(255, 59)
        Me.panSexo.TabIndex = 12
        '
        'rbMasculinoReg
        '
        Me.rbMasculinoReg.AutoSize = True
        Me.rbMasculinoReg.Location = New System.Drawing.Point(129, 28)
        Me.rbMasculinoReg.Name = "rbMasculinoReg"
        Me.rbMasculinoReg.Size = New System.Drawing.Size(126, 20)
        Me.rbMasculinoReg.TabIndex = 8
        Me.rbMasculinoReg.TabStop = True
        Me.rbMasculinoReg.Text = "Masculino"
        Me.rbMasculinoReg.UseVisualStyleBackColor = True
        '
        'rbFemeninoReg
        '
        Me.rbFemeninoReg.AutoSize = True
        Me.rbFemeninoReg.Location = New System.Drawing.Point(3, 28)
        Me.rbFemeninoReg.Name = "rbFemeninoReg"
        Me.rbFemeninoReg.Size = New System.Drawing.Size(113, 20)
        Me.rbFemeninoReg.TabIndex = 9
        Me.rbFemeninoReg.TabStop = True
        Me.rbFemeninoReg.Text = "Femenino"
        Me.rbFemeninoReg.UseVisualStyleBackColor = True
        '
        'lblNombreReg
        '
        Me.lblNombreReg.AutoSize = True
        Me.lblNombreReg.Location = New System.Drawing.Point(6, 38)
        Me.lblNombreReg.Name = "lblNombreReg"
        Me.lblNombreReg.Size = New System.Drawing.Size(191, 16)
        Me.lblNombreReg.TabIndex = 1
        Me.lblNombreReg.Text = "Nombre de Usuario:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(353, 158)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(55, 16)
        Me.lblSexo.TabIndex = 13
        Me.lblSexo.Text = "Sexo:"
        '
        'btnCancelarReg
        '
        Me.btnCancelarReg.Location = New System.Drawing.Point(423, 276)
        Me.btnCancelarReg.Name = "btnCancelarReg"
        Me.btnCancelarReg.Size = New System.Drawing.Size(68, 20)
        Me.btnCancelarReg.TabIndex = 11
        Me.btnCancelarReg.Text = "Cancelar"
        Me.btnCancelarReg.UseVisualStyleBackColor = True
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(203, 31)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(100, 23)
        Me.txtNombreUsuario.TabIndex = 0
        '
        'txtNombreYapellido
        '
        Me.txtNombreYapellido.Location = New System.Drawing.Point(506, 111)
        Me.txtNombreYapellido.Name = "txtNombreYapellido"
        Me.txtNombreYapellido.Size = New System.Drawing.Size(146, 23)
        Me.txtNombreYapellido.TabIndex = 14
        '
        'txtDomicilioReg
        '
        Me.txtDomicilioReg.Location = New System.Drawing.Point(506, 69)
        Me.txtDomicilioReg.Name = "txtDomicilioReg"
        Me.txtDomicilioReg.Size = New System.Drawing.Size(146, 23)
        Me.txtDomicilioReg.TabIndex = 15
        '
        'txtTelefonoReg
        '
        Me.txtTelefonoReg.Location = New System.Drawing.Point(506, 31)
        Me.txtTelefonoReg.Name = "txtTelefonoReg"
        Me.txtTelefonoReg.Size = New System.Drawing.Size(146, 23)
        Me.txtTelefonoReg.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre y Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(394, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Domicilio:"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnRegistrar.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegistrar.Location = New System.Drawing.Point(414, 229)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(112, 31)
        Me.btnRegistrar.TabIndex = 20
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnRegistrar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTelefonoReg)
        Me.GroupBox1.Controls.Add(Me.txtDomicilioReg)
        Me.GroupBox1.Controls.Add(Me.txtNombreYapellido)
        Me.GroupBox1.Controls.Add(Me.txtNombreUsuario)
        Me.GroupBox1.Controls.Add(Me.btnCancelarReg)
        Me.GroupBox1.Controls.Add(Me.lblSexo)
        Me.GroupBox1.Controls.Add(Me.lblNombreReg)
        Me.GroupBox1.Controls.Add(Me.panSexo)
        Me.GroupBox1.Controls.Add(Me.lblMailReg)
        Me.GroupBox1.Controls.Add(Me.lblPassReg)
        Me.GroupBox1.Controls.Add(Me.lblFechaReg)
        Me.GroupBox1.Controls.Add(Me.dtpFechaReg)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.txtContrasena)
        Me.GroupBox1.Font = New System.Drawing.Font("Tiza", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 275)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Usuario"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCancelar.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(154, 229)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 31)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmRegistrarse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Interfaz.My.Resources.Resources._6mf
        Me.ClientSize = New System.Drawing.Size(699, 300)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegistrarse"
        Me.Text = "Registro"
        Me.panSexo.ResumeLayout(False)
        Me.panSexo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaReg As System.Windows.Forms.Label
    Friend WithEvents lblPassReg As System.Windows.Forms.Label
    Friend WithEvents lblMailReg As System.Windows.Forms.Label
    Friend WithEvents panSexo As System.Windows.Forms.Panel
    Friend WithEvents rbMasculinoReg As System.Windows.Forms.RadioButton
    Friend WithEvents rbFemeninoReg As System.Windows.Forms.RadioButton
    Friend WithEvents lblNombreReg As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents btnCancelarReg As System.Windows.Forms.Button
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreYapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDomicilioReg As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefonoReg As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
