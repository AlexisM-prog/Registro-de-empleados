<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VModificarEmpleado
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.txtNroPuerta = New System.Windows.Forms.TextBox()
        Me.txtSueldoPorMes = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblNroPuerta = New System.Windows.Forms.Label()
        Me.lblSueldoPorMes = New System.Windows.Forms.Label()
        Me.lblPuertaBis = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.txtSNom = New System.Windows.Forms.TextBox()
        Me.txtPApe = New System.Windows.Forms.TextBox()
        Me.txtSApe = New System.Windows.Forms.TextBox()
        Me.txtPNom = New System.Windows.Forms.TextBox()
        Me.lblSNom = New System.Windows.Forms.Label()
        Me.lblSApe = New System.Windows.Forms.Label()
        Me.lblPApe = New System.Windows.Forms.Label()
        Me.lblPNom = New System.Windows.Forms.Label()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.cboEsBis = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblAgregarEmpleado
        '
        Me.lblAgregarEmpleado.AutoSize = True
        Me.lblAgregarEmpleado.Font = New System.Drawing.Font("Corbel", 34.0!)
        Me.lblAgregarEmpleado.Location = New System.Drawing.Point(153, 46)
        Me.lblAgregarEmpleado.Name = "lblAgregarEmpleado"
        Me.lblAgregarEmpleado.Size = New System.Drawing.Size(500, 69)
        Me.lblAgregarEmpleado.TabIndex = 6
        Me.lblAgregarEmpleado.Text = "Modificar empleado"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Corbel", 22.0!)
        Me.btnGuardar.Location = New System.Drawing.Point(518, 418)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(304, 81)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAtras.Image = Global.Vista.My.Resources.Resources.icons8_volver_32
        Me.btnAtras.Location = New System.Drawing.Point(698, 27)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(136, 88)
        Me.btnAtras.TabIndex = 53
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'txtNroPuerta
        '
        Me.txtNroPuerta.Location = New System.Drawing.Point(647, 138)
        Me.txtNroPuerta.Name = "txtNroPuerta"
        Me.txtNroPuerta.Size = New System.Drawing.Size(160, 22)
        Me.txtNroPuerta.TabIndex = 72
        '
        'txtSueldoPorMes
        '
        Me.txtSueldoPorMes.Location = New System.Drawing.Point(647, 274)
        Me.txtSueldoPorMes.Name = "txtSueldoPorMes"
        Me.txtSueldoPorMes.Size = New System.Drawing.Size(160, 22)
        Me.txtSueldoPorMes.TabIndex = 73
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(251, 424)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(160, 22)
        Me.txtCalle.TabIndex = 71
        '
        'lblNroPuerta
        '
        Me.lblNroPuerta.AutoSize = True
        Me.lblNroPuerta.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblNroPuerta.Location = New System.Drawing.Point(452, 132)
        Me.lblNroPuerta.Name = "lblNroPuerta"
        Me.lblNroPuerta.Size = New System.Drawing.Size(201, 29)
        Me.lblNroPuerta.TabIndex = 67
        Me.lblNroPuerta.Text = "Número de puerta:"
        '
        'lblSueldoPorMes
        '
        Me.lblSueldoPorMes.AutoSize = True
        Me.lblSueldoPorMes.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblSueldoPorMes.Location = New System.Drawing.Point(479, 268)
        Me.lblSueldoPorMes.Name = "lblSueldoPorMes"
        Me.lblSueldoPorMes.Size = New System.Drawing.Size(174, 29)
        Me.lblSueldoPorMes.TabIndex = 69
        Me.lblSueldoPorMes.Text = "Sueldo por mes:"
        '
        'lblPuertaBis
        '
        Me.lblPuertaBis.AutoSize = True
        Me.lblPuertaBis.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblPuertaBis.Location = New System.Drawing.Point(478, 197)
        Me.lblPuertaBis.Name = "lblPuertaBis"
        Me.lblPuertaBis.Size = New System.Drawing.Size(175, 29)
        Me.lblPuertaBis.TabIndex = 68
        Me.lblPuertaBis.Text = "La puerta es bis:"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblCargo.Location = New System.Drawing.Point(572, 341)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(79, 29)
        Me.lblCargo.TabIndex = 70
        Me.lblCargo.Text = "Cargo:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblCalle.Location = New System.Drawing.Point(53, 418)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(204, 29)
        Me.lblCalle.TabIndex = 66
        Me.lblCalle.Text = "Calle donde reside:"
        '
        'txtSNom
        '
        Me.txtSNom.Location = New System.Drawing.Point(253, 212)
        Me.txtSNom.Name = "txtSNom"
        Me.txtSNom.Size = New System.Drawing.Size(160, 22)
        Me.txtSNom.TabIndex = 60
        '
        'txtPApe
        '
        Me.txtPApe.Location = New System.Drawing.Point(253, 278)
        Me.txtPApe.Name = "txtPApe"
        Me.txtPApe.Size = New System.Drawing.Size(160, 22)
        Me.txtPApe.TabIndex = 61
        '
        'txtSApe
        '
        Me.txtSApe.Location = New System.Drawing.Point(251, 346)
        Me.txtSApe.Name = "txtSApe"
        Me.txtSApe.Size = New System.Drawing.Size(160, 22)
        Me.txtSApe.TabIndex = 62
        '
        'txtPNom
        '
        Me.txtPNom.Location = New System.Drawing.Point(253, 139)
        Me.txtPNom.Name = "txtPNom"
        Me.txtPNom.Size = New System.Drawing.Size(160, 22)
        Me.txtPNom.TabIndex = 59
        '
        'lblSNom
        '
        Me.lblSNom.AutoSize = True
        Me.lblSNom.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblSNom.Location = New System.Drawing.Point(65, 206)
        Me.lblSNom.Name = "lblSNom"
        Me.lblSNom.Size = New System.Drawing.Size(192, 29)
        Me.lblSNom.TabIndex = 55
        Me.lblSNom.Text = "Segundo nombre:"
        '
        'lblSApe
        '
        Me.lblSApe.AutoSize = True
        Me.lblSApe.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblSApe.Location = New System.Drawing.Point(63, 339)
        Me.lblSApe.Name = "lblSApe"
        Me.lblSApe.Size = New System.Drawing.Size(194, 29)
        Me.lblSApe.TabIndex = 57
        Me.lblSApe.Text = "Segundo apellido:"
        '
        'lblPApe
        '
        Me.lblPApe.AutoSize = True
        Me.lblPApe.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblPApe.Location = New System.Drawing.Point(84, 271)
        Me.lblPApe.Name = "lblPApe"
        Me.lblPApe.Size = New System.Drawing.Size(173, 29)
        Me.lblPApe.TabIndex = 56
        Me.lblPApe.Text = "Primer apellido:"
        '
        'lblPNom
        '
        Me.lblPNom.AutoSize = True
        Me.lblPNom.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.lblPNom.Location = New System.Drawing.Point(86, 132)
        Me.lblPNom.Name = "lblPNom"
        Me.lblPNom.Size = New System.Drawing.Size(171, 29)
        Me.lblPNom.TabIndex = 54
        Me.lblPNom.Text = "Primer nombre:"
        '
        'cboCargo
        '
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Items.AddRange(New Object() {"Administrativo", "Gerente", "Operario"})
        Me.cboCargo.Location = New System.Drawing.Point(647, 346)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(160, 24)
        Me.cboCargo.TabIndex = 74
        '
        'cboEsBis
        '
        Me.cboEsBis.FormattingEnabled = True
        Me.cboEsBis.Items.AddRange(New Object() {"Si", "No"})
        Me.cboEsBis.Location = New System.Drawing.Point(647, 202)
        Me.cboEsBis.Name = "cboEsBis"
        Me.cboEsBis.Size = New System.Drawing.Size(160, 24)
        Me.cboEsBis.TabIndex = 75
        '
        'VModificarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 592)
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
        Me.Controls.Add(Me.txtPNom)
        Me.Controls.Add(Me.lblSNom)
        Me.Controls.Add(Me.lblSApe)
        Me.Controls.Add(Me.lblPApe)
        Me.Controls.Add(Me.lblPNom)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblAgregarEmpleado)
        Me.Name = "VModificarEmpleado"
        Me.Text = "T"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAgregarEmpleado As Windows.Forms.Label
    Friend WithEvents btnGuardar As Windows.Forms.Button
    Friend WithEvents btnAtras As Windows.Forms.Button
    Friend WithEvents txtNroPuerta As Windows.Forms.TextBox
    Friend WithEvents txtSueldoPorMes As Windows.Forms.TextBox
    Friend WithEvents txtCalle As Windows.Forms.TextBox
    Friend WithEvents lblNroPuerta As Windows.Forms.Label
    Friend WithEvents lblSueldoPorMes As Windows.Forms.Label
    Friend WithEvents lblPuertaBis As Windows.Forms.Label
    Friend WithEvents lblCargo As Windows.Forms.Label
    Friend WithEvents lblCalle As Windows.Forms.Label
    Friend WithEvents txtSNom As Windows.Forms.TextBox
    Friend WithEvents txtPApe As Windows.Forms.TextBox
    Friend WithEvents txtSApe As Windows.Forms.TextBox
    Friend WithEvents txtPNom As Windows.Forms.TextBox
    Friend WithEvents lblSNom As Windows.Forms.Label
    Friend WithEvents lblSApe As Windows.Forms.Label
    Friend WithEvents lblPApe As Windows.Forms.Label
    Friend WithEvents lblPNom As Windows.Forms.Label
    Friend WithEvents cboCargo As Windows.Forms.ComboBox
    Friend WithEvents cboEsBis As Windows.Forms.ComboBox
End Class
