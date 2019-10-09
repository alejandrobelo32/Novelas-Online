<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecuperarPW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecuperarPW))
        Me.lblMailRPW = New System.Windows.Forms.Label()
        Me.txtMailRPW = New System.Windows.Forms.TextBox()
        Me.txtMensajeRPW = New System.Windows.Forms.TextBox()
        Me.btnAceptarRPW = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMailRPW
        '
        Me.lblMailRPW.AutoSize = True
        Me.lblMailRPW.BackColor = System.Drawing.Color.Transparent
        Me.lblMailRPW.Font = New System.Drawing.Font("Tiza", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailRPW.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMailRPW.Location = New System.Drawing.Point(12, 59)
        Me.lblMailRPW.Name = "lblMailRPW"
        Me.lblMailRPW.Size = New System.Drawing.Size(57, 16)
        Me.lblMailRPW.TabIndex = 0
        Me.lblMailRPW.Text = "Mail:"
        '
        'txtMailRPW
        '
        Me.txtMailRPW.Location = New System.Drawing.Point(107, 55)
        Me.txtMailRPW.Name = "txtMailRPW"
        Me.txtMailRPW.Size = New System.Drawing.Size(234, 20)
        Me.txtMailRPW.TabIndex = 2
        '
        'txtMensajeRPW
        '
        Me.txtMensajeRPW.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMensajeRPW.Font = New System.Drawing.Font("Tiza", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensajeRPW.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMensajeRPW.Location = New System.Drawing.Point(15, 12)
        Me.txtMensajeRPW.Name = "txtMensajeRPW"
        Me.txtMensajeRPW.Size = New System.Drawing.Size(326, 23)
        Me.txtMensajeRPW.TabIndex = 4
        Me.txtMensajeRPW.Text = "Ingrese el mail correspondiente"
        '
        'btnAceptarRPW
        '
        Me.btnAceptarRPW.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAceptarRPW.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarRPW.Location = New System.Drawing.Point(125, 103)
        Me.btnAceptarRPW.Name = "btnAceptarRPW"
        Me.btnAceptarRPW.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarRPW.TabIndex = 5
        Me.btnAceptarRPW.Text = "Aceptar"
        Me.btnAceptarRPW.UseVisualStyleBackColor = False
        '
        'frmRecuperarPW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Interfaz.My.Resources.Resources._6mf
        Me.ClientSize = New System.Drawing.Size(360, 138)
        Me.Controls.Add(Me.btnAceptarRPW)
        Me.Controls.Add(Me.txtMensajeRPW)
        Me.Controls.Add(Me.txtMailRPW)
        Me.Controls.Add(Me.lblMailRPW)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecuperarPW"
        Me.Text = "frmRecuperarPW"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMailRPW As System.Windows.Forms.Label
    Friend WithEvents txtMailRPW As System.Windows.Forms.TextBox
    Friend WithEvents txtMensajeRPW As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarRPW As System.Windows.Forms.Button
End Class
