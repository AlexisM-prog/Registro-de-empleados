<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VRegistroEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnModificarEmpleado = New System.Windows.Forms.Button()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.lblAgregarEmpleado = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnModificarEmpleado
        '
        Me.btnModificarEmpleado.Font = New System.Drawing.Font("Corbel", 36.0!)
        Me.btnModificarEmpleado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnModificarEmpleado.Image = Global.Vista.My.Resources.Resources.icons8_editar_usuario_masculino_32
        Me.btnModificarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarEmpleado.Location = New System.Drawing.Point(242, 364)
        Me.btnModificarEmpleado.Name = "btnModificarEmpleado"
        Me.btnModificarEmpleado.Size = New System.Drawing.Size(539, 200)
        Me.btnModificarEmpleado.TabIndex = 5
        Me.btnModificarEmpleado.Text = "          Modificar empleado"
        Me.btnModificarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificarEmpleado.UseVisualStyleBackColor = True
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.Font = New System.Drawing.Font("Corbel", 36.0!)
        Me.btnAgregarEmpleado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnAgregarEmpleado.Image = Global.Vista.My.Resources.Resources.icons8_añadir_usuario_masculino_32
        Me.btnAgregarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(88, 148)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(539, 200)
        Me.btnAgregarEmpleado.TabIndex = 4
        Me.btnAgregarEmpleado.Text = "       Agregar empleado"
        Me.btnAgregarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'lblAgregarEmpleado
        '
        Me.lblAgregarEmpleado.AutoSize = True
        Me.lblAgregarEmpleado.Font = New System.Drawing.Font("Corbel", 40.0!)
        Me.lblAgregarEmpleado.Location = New System.Drawing.Point(12, 27)
        Me.lblAgregarEmpleado.Name = "lblAgregarEmpleado"
        Me.lblAgregarEmpleado.Size = New System.Drawing.Size(668, 82)
        Me.lblAgregarEmpleado.TabIndex = 3
        Me.lblAgregarEmpleado.Text = "Registro de empleados"
        '
        'btnAtras
        '
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAtras.Image = Global.Vista.My.Resources.Resources.icons8_volver_32
        Me.btnAtras.Location = New System.Drawing.Point(729, 27)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(136, 88)
        Me.btnAtras.TabIndex = 40
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'VRegistroEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 592)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnModificarEmpleado)
        Me.Controls.Add(Me.btnAgregarEmpleado)
        Me.Controls.Add(Me.lblAgregarEmpleado)
        Me.Name = "VRegistroEmpleado"
        Me.Text = "'"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnModificarEmpleado As Windows.Forms.Button
    Friend WithEvents btnAgregarEmpleado As Windows.Forms.Button
    Friend WithEvents lblAgregarEmpleado As Windows.Forms.Label
    Friend WithEvents btnAtras As Windows.Forms.Button
End Class
