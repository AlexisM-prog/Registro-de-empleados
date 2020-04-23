<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VAgregarTelefonos
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
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblAgregarEmpleado = New System.Windows.Forms.Label()
        Me.lbNumeros = New System.Windows.Forms.ListBox()
        Me.btnAgregarTelefono = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAtras.Image = Global.Vista.My.Resources.Resources.icons8_volver_32
        Me.btnAtras.Location = New System.Drawing.Point(715, 56)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(136, 88)
        Me.btnAtras.TabIndex = 14
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblAgregarEmpleado
        '
        Me.lblAgregarEmpleado.AutoSize = True
        Me.lblAgregarEmpleado.Font = New System.Drawing.Font("Corbel", 40.0!)
        Me.lblAgregarEmpleado.Location = New System.Drawing.Point(96, 62)
        Me.lblAgregarEmpleado.Name = "lblAgregarEmpleado"
        Me.lblAgregarEmpleado.Size = New System.Drawing.Size(571, 82)
        Me.lblAgregarEmpleado.TabIndex = 13
        Me.lblAgregarEmpleado.Text = "Modificar telefonos"
        '
        'lbNumeros
        '
        Me.lbNumeros.FormattingEnabled = True
        Me.lbNumeros.ItemHeight = 16
        Me.lbNumeros.Location = New System.Drawing.Point(57, 197)
        Me.lbNumeros.Name = "lbNumeros"
        Me.lbNumeros.Size = New System.Drawing.Size(794, 324)
        Me.lbNumeros.TabIndex = 15
        '
        'btnAgregarTelefono
        '
        Me.btnAgregarTelefono.Location = New System.Drawing.Point(645, 169)
        Me.btnAgregarTelefono.Name = "btnAgregarTelefono"
        Me.btnAgregarTelefono.Size = New System.Drawing.Size(203, 22)
        Me.btnAgregarTelefono.TabIndex = 16
        Me.btnAgregarTelefono.Text = "+"
        Me.btnAgregarTelefono.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(57, 523)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(794, 37)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "-"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(57, 169)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(582, 22)
        Me.txtNumero.TabIndex = 18
        '
        'VAgregarTelefonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 592)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregarTelefono)
        Me.Controls.Add(Me.lbNumeros)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.lblAgregarEmpleado)
        Me.Name = "VAgregarTelefonos"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Windows.Forms.Button
    Friend WithEvents lblAgregarEmpleado As Windows.Forms.Label
    Friend WithEvents lbNumeros As Windows.Forms.ListBox
    Friend WithEvents btnAgregarTelefono As Windows.Forms.Button
    Friend WithEvents btnEliminar As Windows.Forms.Button
    Friend WithEvents txtNumero As Windows.Forms.TextBox
End Class
