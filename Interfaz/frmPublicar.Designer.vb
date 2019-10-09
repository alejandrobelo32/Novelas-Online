<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPublicar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPublicar))
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblPrologo = New System.Windows.Forms.Label()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtbPrologo = New System.Windows.Forms.RichTextBox()
        Me.lblCuerpo = New System.Windows.Forms.Label()
        Me.rtbCuerpo = New System.Windows.Forms.RichTextBox()
        Me.btnSubir = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbHabilitado = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.BackColor = System.Drawing.Color.Black
        Me.lblGenero.Font = New System.Drawing.Font("Tiza", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGenero.Location = New System.Drawing.Point(372, 28)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(92, 17)
        Me.lblGenero.TabIndex = 0
        Me.lblGenero.Text = "Genero: "
        '
        'lblPrologo
        '
        Me.lblPrologo.AutoSize = True
        Me.lblPrologo.BackColor = System.Drawing.Color.Black
        Me.lblPrologo.Font = New System.Drawing.Font("Tiza", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrologo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPrologo.Location = New System.Drawing.Point(27, 149)
        Me.lblPrologo.Name = "lblPrologo"
        Me.lblPrologo.Size = New System.Drawing.Size(91, 17)
        Me.lblPrologo.TabIndex = 1
        Me.lblPrologo.Text = "Prologo:"
        '
        'cmbGenero
        '
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Location = New System.Drawing.Point(484, 24)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(100, 21)
        Me.cmbGenero.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Tiza", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(27, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Autor:"
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(120, 92)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(100, 20)
        Me.txtAutor.TabIndex = 7
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(484, 94)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Tiza", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(372, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Usuario:"
        '
        'rtbPrologo
        '
        Me.rtbPrologo.Location = New System.Drawing.Point(120, 149)
        Me.rtbPrologo.Name = "rtbPrologo"
        Me.rtbPrologo.Size = New System.Drawing.Size(464, 56)
        Me.rtbPrologo.TabIndex = 10
        Me.rtbPrologo.Text = ""
        '
        'lblCuerpo
        '
        Me.lblCuerpo.AutoSize = True
        Me.lblCuerpo.BackColor = System.Drawing.Color.Black
        Me.lblCuerpo.Font = New System.Drawing.Font("Tiza", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuerpo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCuerpo.Location = New System.Drawing.Point(23, 235)
        Me.lblCuerpo.Name = "lblCuerpo"
        Me.lblCuerpo.Size = New System.Drawing.Size(83, 17)
        Me.lblCuerpo.TabIndex = 11
        Me.lblCuerpo.Text = "Cuerpo:"
        '
        'rtbCuerpo
        '
        Me.rtbCuerpo.Location = New System.Drawing.Point(120, 235)
        Me.rtbCuerpo.Name = "rtbCuerpo"
        Me.rtbCuerpo.Size = New System.Drawing.Size(464, 216)
        Me.rtbCuerpo.TabIndex = 12
        Me.rtbCuerpo.Text = ""
        '
        'btnSubir
        '
        Me.btnSubir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSubir.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubir.Location = New System.Drawing.Point(505, 478)
        Me.btnSubir.Name = "btnSubir"
        Me.btnSubir.Size = New System.Drawing.Size(79, 23)
        Me.btnSubir.TabIndex = 13
        Me.btnSubir.Text = "Subir"
        Me.btnSubir.UseVisualStyleBackColor = False
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(120, 25)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtTitulo.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Tiza", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(27, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Titulo"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnActualizar.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(307, 478)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(79, 23)
        Me.btnActualizar.TabIndex = 16
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Tiza", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 479)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Habilitado:"
        '
        'cbHabilitado
        '
        Me.cbHabilitado.AutoSize = True
        Me.cbHabilitado.Location = New System.Drawing.Point(146, 482)
        Me.cbHabilitado.Name = "cbHabilitado"
        Me.cbHabilitado.Size = New System.Drawing.Size(15, 14)
        Me.cbHabilitado.TabIndex = 20
        Me.cbHabilitado.UseVisualStyleBackColor = True
        '
        'frmPublicar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Interfaz.My.Resources.Resources._1
        Me.ClientSize = New System.Drawing.Size(596, 510)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbHabilitado)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnSubir)
        Me.Controls.Add(Me.rtbCuerpo)
        Me.Controls.Add(Me.lblCuerpo)
        Me.Controls.Add(Me.rtbPrologo)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbGenero)
        Me.Controls.Add(Me.lblPrologo)
        Me.Controls.Add(Me.lblGenero)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPublicar"
        Me.Text = "frmPublicar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblPrologo As System.Windows.Forms.Label
    Friend WithEvents cmbGenero As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rtbPrologo As System.Windows.Forms.RichTextBox
    Friend WithEvents lblCuerpo As System.Windows.Forms.Label
    Friend WithEvents rtbCuerpo As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSubir As System.Windows.Forms.Button
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbHabilitado As System.Windows.Forms.CheckBox
End Class
