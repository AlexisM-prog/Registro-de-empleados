<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VMenuPrincipal
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
        Me.lblAgregarEmpleado = New System.Windows.Forms.Label()
        Me.btnImportePago = New System.Windows.Forms.Button()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAgregarEmpleado
        '
        Me.lblAgregarEmpleado.AutoSize = True
        Me.lblAgregarEmpleado.Font = New System.Drawing.Font("Corbel", 43.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarEmpleado.Location = New System.Drawing.Point(12, 26)
        Me.lblAgregarEmpleado.Name = "lblAgregarEmpleado"
        Me.lblAgregarEmpleado.Size = New System.Drawing.Size(701, 90)
        Me.lblAgregarEmpleado.TabIndex = 0
        Me.lblAgregarEmpleado.Text = "Control de empleados"
        '
        'btnImportePago
        '
        Me.btnImportePago.Font = New System.Drawing.Font("Corbel", 30.0!)
        Me.btnImportePago.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnImportePago.Image = Global.Vista.My.Resources.Resources.icons8_lista_32
        Me.btnImportePago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportePago.Location = New System.Drawing.Point(255, 358)
        Me.btnImportePago.Name = "btnImportePago"
        Me.btnImportePago.Size = New System.Drawing.Size(539, 200)
        Me.btnImportePago.TabIndex = 2
        Me.btnImportePago.Text = "                    Importe de pago"
        Me.btnImportePago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImportePago.UseVisualStyleBackColor = True
        '
        'btnRegistro
        '
        Me.btnRegistro.Font = New System.Drawing.Font("Corbel", 30.0!)
        Me.btnRegistro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnRegistro.Image = Global.Vista.My.Resources.Resources.icons8_grupos_de_usuarios_32
        Me.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistro.Location = New System.Drawing.Point(60, 152)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(539, 200)
        Me.btnRegistro.TabIndex = 1
        Me.btnRegistro.Text = "         Registro de empleados"
        Me.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'VMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 592)
        Me.Controls.Add(Me.btnImportePago)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.lblAgregarEmpleado)
        Me.Name = "VMenuPrincipal"
        Me.Text = "Control de Empleados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAgregarEmpleado As Windows.Forms.Label
    Friend WithEvents btnImportePago As Windows.Forms.Button
    Friend WithEvents btnRegistro As Windows.Forms.Button
End Class
