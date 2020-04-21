<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VAgregarEmpleado
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
        Me.lblAgregarEmpleado = New System.Windows.Forms.Label()
        Me.lblPNom = New System.Windows.Forms.Label()
        Me.lblSNom = New System.Windows.Forms.Label()
        Me.lblSApe = New System.Windows.Forms.Label()
        Me.lblPApe = New System.Windows.Forms.Label()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.cboEsBis = New System.Windows.Forms.ComboBox()
        Me.txtPNom = New System.Windows.Forms.TextBox()
        Me.txtSNom = New System.Windows.Forms.TextBox()
        Me.txtPApe = New System.Windows.Forms.TextBox()
        Me.txtSApe = New System.Windows.Forms.TextBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.txtNroPuerta = New System.Windows.Forms.TextBox()
        Me.txtSueldoPorMes = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblNroPuerta = New System.Windows.Forms.Label()
        Me.lblSueldoPorMes = New System.Windows.Forms.Label()
        Me.lblPuertaBis = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblGuardado = New System.Windows.Forms.Label()
        Me.cckActivo = New System.Windows.Forms.CheckBox()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.btnTelefonos = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAgregarEmpleado
        '
        Me.lblAgregarEmpleado.AutoSize = True
        Me.lblAgregarEmpleado.Font = New System.Drawing.Font("Corbel", 40.0!)
        Me.lblAgregarEmpleado.Location = New System.Drawing.Point(111, 32)
        Me.lblAgregarEmpleado.Name = "lblAgregarEmpleado"
        Me.lblAgregarEmpleado.Size = New System.Drawing.Size(552, 82)
        Me.lblAgregarEmpleado.TabIndex = 4
        Me.lblAgregarEmpleado.Text = "Agregar empleado"
        '
        'lblPNom
        '
        Me.lblPNom.AutoSize = True
        Me.lblPNom.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblPNom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPNom.Location = New System.Drawing.Point(88, 164)
        Me.lblPNom.Name = "lblPNom"
        Me.lblPNom.Size = New System.Drawing.Size(171, 29)
        Me.lblPNom.TabIndex = 5
        Me.lblPNom.Text = "Primer nombre:"
        '
        'lblSNom
        '
        Me.lblSNom.AutoSize = True
        Me.lblSNom.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblSNom.Location = New System.Drawing.Point(67, 229)
        Me.lblSNom.Name = "lblSNom"
        Me.lblSNom.Size = New System.Drawing.Size(192, 29)
        Me.lblSNom.TabIndex = 7
        Me.lblSNom.Text = "Segundo nombre:"
        '
        'lblSApe
        '
        Me.lblSApe.AutoSize = True
        Me.lblSApe.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblSApe.Location = New System.Drawing.Point(67, 346)
        Me.lblSApe.Name = "lblSApe"
        Me.lblSApe.Size = New System.Drawing.Size(194, 29)
        Me.lblSApe.TabIndex = 11
        Me.lblSApe.Text = "Segundo apellido:"
        '
        'lblPApe
        '
        Me.lblPApe.AutoSize = True
        Me.lblPApe.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblPApe.Location = New System.Drawing.Point(86, 285)
        Me.lblPApe.Name = "lblPApe"
        Me.lblPApe.Size = New System.Drawing.Size(173, 29)
        Me.lblPApe.TabIndex = 9
        Me.lblPApe.Text = "Primer apellido:"
        '
        'cboCargo
        '
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Items.AddRange(New Object() {"Administrativo", "Gerente", "Operario"})
        Me.cboCargo.Location = New System.Drawing.Point(671, 397)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(160, 24)
        Me.cboCargo.TabIndex = 10
        '
        'cboEsBis
        '
        Me.cboEsBis.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEsBis.FormattingEnabled = True
        Me.cboEsBis.Items.AddRange(New Object() {"Si", "No"})
        Me.cboEsBis.Location = New System.Drawing.Point(671, 289)
        Me.cboEsBis.Name = "cboEsBis"
        Me.cboEsBis.Size = New System.Drawing.Size(160, 24)
        Me.cboEsBis.TabIndex = 8
        '
        'txtPNom
        '
        Me.txtPNom.Location = New System.Drawing.Point(256, 168)
        Me.txtPNom.Name = "txtPNom"
        Me.txtPNom.Size = New System.Drawing.Size(160, 22)
        Me.txtPNom.TabIndex = 1
        '
        'txtSNom
        '
        Me.txtSNom.Location = New System.Drawing.Point(256, 232)
        Me.txtSNom.Name = "txtSNom"
        Me.txtSNom.Size = New System.Drawing.Size(160, 22)
        Me.txtSNom.TabIndex = 2
        '
        'txtPApe
        '
        Me.txtPApe.Location = New System.Drawing.Point(256, 289)
        Me.txtPApe.Name = "txtPApe"
        Me.txtPApe.Size = New System.Drawing.Size(160, 22)
        Me.txtPApe.TabIndex = 3
        '
        'txtSApe
        '
        Me.txtSApe.Location = New System.Drawing.Point(256, 350)
        Me.txtSApe.Name = "txtSApe"
        Me.txtSApe.Size = New System.Drawing.Size(160, 22)
        Me.txtSApe.TabIndex = 4
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(256, 401)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(160, 22)
        Me.txtCI.TabIndex = 5
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblCI.Location = New System.Drawing.Point(42, 397)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(219, 29)
        Me.lblCI.TabIndex = 13
        Me.lblCI.Text = "Cédula de identidad:"
        '
        'txtNroPuerta
        '
        Me.txtNroPuerta.Location = New System.Drawing.Point(671, 232)
        Me.txtNroPuerta.Name = "txtNroPuerta"
        Me.txtNroPuerta.Size = New System.Drawing.Size(160, 22)
        Me.txtNroPuerta.TabIndex = 7
        '
        'txtSueldoPorMes
        '
        Me.txtSueldoPorMes.Location = New System.Drawing.Point(671, 350)
        Me.txtSueldoPorMes.Name = "txtSueldoPorMes"
        Me.txtSueldoPorMes.Size = New System.Drawing.Size(160, 22)
        Me.txtSueldoPorMes.TabIndex = 9
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(671, 168)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(160, 22)
        Me.txtCalle.TabIndex = 6
        '
        'lblNroPuerta
        '
        Me.lblNroPuerta.AutoSize = True
        Me.lblNroPuerta.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblNroPuerta.Location = New System.Drawing.Point(475, 229)
        Me.lblNroPuerta.Name = "lblNroPuerta"
        Me.lblNroPuerta.Size = New System.Drawing.Size(201, 29)
        Me.lblNroPuerta.TabIndex = 27
        Me.lblNroPuerta.Text = "Número de puerta:"
        '
        'lblSueldoPorMes
        '
        Me.lblSueldoPorMes.AutoSize = True
        Me.lblSueldoPorMes.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblSueldoPorMes.Location = New System.Drawing.Point(502, 347)
        Me.lblSueldoPorMes.Name = "lblSueldoPorMes"
        Me.lblSueldoPorMes.Size = New System.Drawing.Size(174, 29)
        Me.lblSueldoPorMes.TabIndex = 29
        Me.lblSueldoPorMes.Text = "Sueldo por mes:"
        '
        'lblPuertaBis
        '
        Me.lblPuertaBis.AutoSize = True
        Me.lblPuertaBis.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblPuertaBis.Location = New System.Drawing.Point(501, 285)
        Me.lblPuertaBis.Name = "lblPuertaBis"
        Me.lblPuertaBis.Size = New System.Drawing.Size(175, 29)
        Me.lblPuertaBis.TabIndex = 28
        Me.lblPuertaBis.Text = "La puerta es bis:"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblCargo.Location = New System.Drawing.Point(597, 394)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(79, 29)
        Me.lblCargo.TabIndex = 30
        Me.lblCargo.Text = "Cargo:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblCalle.Location = New System.Drawing.Point(472, 165)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(204, 29)
        Me.lblCalle.TabIndex = 26
        Me.lblCalle.Text = "Calle donde reside:"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Corbel", 22.0!)
        Me.btnRegistrar.Location = New System.Drawing.Point(567, 484)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(264, 81)
        Me.btnRegistrar.TabIndex = 11
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lblGuardado
        '
        Me.lblGuardado.AutoSize = True
        Me.lblGuardado.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblGuardado.ForeColor = System.Drawing.Color.Green
        Me.lblGuardado.Location = New System.Drawing.Point(67, 536)
        Me.lblGuardado.Name = "lblGuardado"
        Me.lblGuardado.Size = New System.Drawing.Size(322, 29)
        Me.lblGuardado.TabIndex = 31
        Me.lblGuardado.Text = "Se ha guardado correctamente"
        Me.lblGuardado.Visible = False
        '
        'cckActivo
        '
        Me.cckActivo.AutoSize = True
        Me.cckActivo.Location = New System.Drawing.Point(263, 446)
        Me.cckActivo.Name = "cckActivo"
        Me.cckActivo.Size = New System.Drawing.Size(18, 17)
        Me.cckActivo.TabIndex = 80
        Me.cckActivo.UseVisualStyleBackColor = True
        '
        'lblActivo
        '
        Me.lblActivo.AutoSize = True
        Me.lblActivo.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblActivo.Location = New System.Drawing.Point(176, 436)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(83, 29)
        Me.lblActivo.TabIndex = 79
        Me.lblActivo.Text = "Activo:"
        '
        'btnTelefonos
        '
        Me.btnTelefonos.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.btnTelefonos.Location = New System.Drawing.Point(493, 436)
        Me.btnTelefonos.Name = "btnTelefonos"
        Me.btnTelefonos.Size = New System.Drawing.Size(338, 42)
        Me.btnTelefonos.TabIndex = 81
        Me.btnTelefonos.Text = "Telefonos"
        Me.btnTelefonos.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAtras.Image = Global.Vista.My.Resources.Resources.icons8_volver_32
        Me.btnAtras.Location = New System.Drawing.Point(730, 26)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(136, 88)
        Me.btnAtras.TabIndex = 12
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'VAgregarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 592)
        Me.Controls.Add(Me.btnTelefonos)
        Me.Controls.Add(Me.cckActivo)
        Me.Controls.Add(Me.lblActivo)
        Me.Controls.Add(Me.lblGuardado)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.cboEsBis)
        Me.Controls.Add(Me.cboCargo)
        Me.Controls.Add(Me.txtNroPuerta)
        Me.Controls.Add(Me.txtSueldoPorMes)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.lblNroPuerta)
        Me.Controls.Add(Me.lblSueldoPorMes)
        Me.Controls.Add(Me.lblPuertaBis)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.txtSNom)
        Me.Controls.Add(Me.txtPApe)
        Me.Controls.Add(Me.txtSApe)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.txtPNom)
        Me.Controls.Add(Me.lblSNom)
        Me.Controls.Add(Me.lblSApe)
        Me.Controls.Add(Me.lblPApe)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.lblPNom)
        Me.Controls.Add(Me.lblAgregarEmpleado)
        Me.Name = "VAgregarEmpleado"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAgregarEmpleado As Windows.Forms.Label
    Friend WithEvents lblPNom As Windows.Forms.Label
    Friend WithEvents lblSNom As Windows.Forms.Label
    Friend WithEvents lblSApe As Windows.Forms.Label
    Friend WithEvents lblPApe As Windows.Forms.Label
    Friend WithEvents cboCargo As Windows.Forms.ComboBox
    Friend WithEvents cboEsBis As Windows.Forms.ComboBox
    Friend WithEvents txtPNom As Windows.Forms.TextBox
    Friend WithEvents txtSNom As Windows.Forms.TextBox
    Friend WithEvents txtPApe As Windows.Forms.TextBox
    Friend WithEvents txtSApe As Windows.Forms.TextBox
    Friend WithEvents txtCI As Windows.Forms.TextBox
    Friend WithEvents lblCI As Windows.Forms.Label
    Friend WithEvents txtNroPuerta As Windows.Forms.TextBox
    Friend WithEvents txtSueldoPorMes As Windows.Forms.TextBox
    Friend WithEvents txtCalle As Windows.Forms.TextBox
    Friend WithEvents lblNroPuerta As Windows.Forms.Label
    Friend WithEvents lblSueldoPorMes As Windows.Forms.Label
    Friend WithEvents lblPuertaBis As Windows.Forms.Label
    Friend WithEvents lblCargo As Windows.Forms.Label
    Friend WithEvents lblCalle As Windows.Forms.Label
    Friend WithEvents btnRegistrar As Windows.Forms.Button
    Friend WithEvents btnAtras As Windows.Forms.Button
    Friend WithEvents lblGuardado As Windows.Forms.Label
    Friend WithEvents cckActivo As Windows.Forms.CheckBox
    Friend WithEvents lblActivo As Windows.Forms.Label
    Friend WithEvents btnTelefonos As Windows.Forms.Button
End Class
