<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VBuscarEmpleado
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
        Me.txtBuscarCI = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dtgTabla = New System.Windows.Forms.DataGridView()
        Me.CI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SueldoPorMes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBusquedaCI = New System.Windows.Forms.Label()
        CType(Me.dtgTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAgregarEmpleado
        '
        Me.lblAgregarEmpleado.AutoSize = True
        Me.lblAgregarEmpleado.Font = New System.Drawing.Font("Corbel", 34.0!)
        Me.lblAgregarEmpleado.Location = New System.Drawing.Point(109, 29)
        Me.lblAgregarEmpleado.Name = "lblAgregarEmpleado"
        Me.lblAgregarEmpleado.Size = New System.Drawing.Size(435, 69)
        Me.lblAgregarEmpleado.TabIndex = 5
        Me.lblAgregarEmpleado.Text = "Buscar empleado"
        '
        'txtBuscarCI
        '
        Me.txtBuscarCI.Location = New System.Drawing.Point(202, 113)
        Me.txtBuscarCI.Name = "txtBuscarCI"
        Me.txtBuscarCI.Size = New System.Drawing.Size(186, 22)
        Me.txtBuscarCI.TabIndex = 9
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Corbel", 22.0!)
        Me.btnModificar.Location = New System.Drawing.Point(603, 499)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(264, 81)
        Me.btnModificar.TabIndex = 36
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Image = Global.Vista.My.Resources.Resources.icons8_volver_32
        Me.Button4.Location = New System.Drawing.Point(731, 29)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 88)
        Me.Button4.TabIndex = 38
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dtgTabla
        '
        Me.dtgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CI, Me.SueldoPorMes, Me.PrimerNombre, Me.SegundoApellido, Me.PrimerApellido, Me.SegundoNombre})
        Me.dtgTabla.Location = New System.Drawing.Point(99, 144)
        Me.dtgTabla.Name = "dtgTabla"
        Me.dtgTabla.RowHeadersWidth = 51
        Me.dtgTabla.RowTemplate.Height = 24
        Me.dtgTabla.Size = New System.Drawing.Size(740, 343)
        Me.dtgTabla.TabIndex = 39
        '
        'CI
        '
        Me.CI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CI.HeaderText = "CI"
        Me.CI.MinimumWidth = 6
        Me.CI.Name = "CI"
        Me.CI.ReadOnly = True
        Me.CI.Width = 49
        '
        'SueldoPorMes
        '
        Me.SueldoPorMes.HeaderText = "Sueldo por mes"
        Me.SueldoPorMes.MinimumWidth = 6
        Me.SueldoPorMes.Name = "SueldoPorMes"
        Me.SueldoPorMes.Width = 125
        '
        'PrimerNombre
        '
        Me.PrimerNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PrimerNombre.HeaderText = "Primer Nombre"
        Me.PrimerNombre.MinimumWidth = 6
        Me.PrimerNombre.Name = "PrimerNombre"
        Me.PrimerNombre.ReadOnly = True
        Me.PrimerNombre.Width = 121
        '
        'SegundoApellido
        '
        Me.SegundoApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.SegundoApellido.HeaderText = "Segundo Nombre"
        Me.SegundoApellido.MinimumWidth = 6
        Me.SegundoApellido.Name = "SegundoApellido"
        Me.SegundoApellido.ReadOnly = True
        Me.SegundoApellido.Width = 136
        '
        'PrimerApellido
        '
        Me.PrimerApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PrimerApellido.HeaderText = "Primer Apellido"
        Me.PrimerApellido.MinimumWidth = 6
        Me.PrimerApellido.Name = "PrimerApellido"
        Me.PrimerApellido.ReadOnly = True
        Me.PrimerApellido.Width = 121
        '
        'SegundoNombre
        '
        Me.SegundoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.SegundoNombre.HeaderText = "Segundo Apellido"
        Me.SegundoNombre.MinimumWidth = 6
        Me.SegundoNombre.Name = "SegundoNombre"
        Me.SegundoNombre.ReadOnly = True
        Me.SegundoNombre.Width = 136
        '
        'lblBusquedaCI
        '
        Me.lblBusquedaCI.AutoSize = True
        Me.lblBusquedaCI.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.lblBusquedaCI.Location = New System.Drawing.Point(95, 115)
        Me.lblBusquedaCI.Name = "lblBusquedaCI"
        Me.lblBusquedaCI.Size = New System.Drawing.Size(113, 21)
        Me.lblBusquedaCI.TabIndex = 40
        Me.lblBusquedaCI.Text = "Ingrese cedula:"
        '
        'VBuscarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 592)
        Me.Controls.Add(Me.dtgTabla)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txtBuscarCI)
        Me.Controls.Add(Me.lblAgregarEmpleado)
        Me.Controls.Add(Me.lblBusquedaCI)
        Me.Name = "VBuscarEmpleado"
        Me.Text = "VBuscarEmpleado"
        CType(Me.dtgTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAgregarEmpleado As Windows.Forms.Label
    Friend WithEvents txtBuscarCI As Windows.Forms.TextBox
    Friend WithEvents btnModificar As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents dtgTabla As Windows.Forms.DataGridView
    Friend WithEvents CI As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SueldoPorMes As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimerNombre As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegundoApellido As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimerApellido As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegundoNombre As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblBusquedaCI As Windows.Forms.Label
End Class
