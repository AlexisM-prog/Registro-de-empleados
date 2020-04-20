<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VImporte
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
        Me.lblGasto = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.dtgTabla = New System.Windows.Forms.DataGridView()
        Me.CI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SueldoPorMes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAgregarEmpleado
        '
        Me.lblAgregarEmpleado.AutoSize = True
        Me.lblAgregarEmpleado.Font = New System.Drawing.Font("Corbel", 40.0!)
        Me.lblAgregarEmpleado.Location = New System.Drawing.Point(103, 34)
        Me.lblAgregarEmpleado.Name = "lblAgregarEmpleado"
        Me.lblAgregarEmpleado.Size = New System.Drawing.Size(476, 82)
        Me.lblAgregarEmpleado.TabIndex = 3
        Me.lblAgregarEmpleado.Text = "Importe a pagar"
        '
        'lblGasto
        '
        Me.lblGasto.AutoSize = True
        Me.lblGasto.Font = New System.Drawing.Font("Corbel", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGasto.Location = New System.Drawing.Point(93, 504)
        Me.lblGasto.Name = "lblGasto"
        Me.lblGasto.Size = New System.Drawing.Size(147, 29)
        Me.lblGasto.TabIndex = 4
        Me.lblGasto.Text = "Gasto total: 0"
        '
        'btnAtras
        '
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAtras.Image = Global.Vista.My.Resources.Resources.icons8_volver_32
        Me.btnAtras.Location = New System.Drawing.Point(729, 28)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(136, 88)
        Me.btnAtras.TabIndex = 39
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'dtgTabla
        '
        Me.dtgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CI, Me.SueldoPorMes, Me.PrimerNombre, Me.SegundoApellido, Me.PrimerApellido, Me.SegundoNombre})
        Me.dtgTabla.Location = New System.Drawing.Point(98, 139)
        Me.dtgTabla.Name = "dtgTabla"
        Me.dtgTabla.RowHeadersWidth = 51
        Me.dtgTabla.RowTemplate.Height = 24
        Me.dtgTabla.Size = New System.Drawing.Size(740, 343)
        Me.dtgTabla.TabIndex = 40
        '
        'CI
        '
        Me.CI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CI.HeaderText = "CI"
        Me.CI.MinimumWidth = 6
        Me.CI.Name = "CI"
        Me.CI.ReadOnly = True
        Me.CI.Width = 50
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
        Me.PrimerNombre.Width = 127
        '
        'SegundoApellido
        '
        Me.SegundoApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.SegundoApellido.HeaderText = "Segundo Nombre"
        Me.SegundoApellido.MinimumWidth = 6
        Me.SegundoApellido.Name = "SegundoApellido"
        Me.SegundoApellido.ReadOnly = True
        Me.SegundoApellido.Width = 137
        '
        'PrimerApellido
        '
        Me.PrimerApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PrimerApellido.HeaderText = "Primer Apellido"
        Me.PrimerApellido.MinimumWidth = 6
        Me.PrimerApellido.Name = "PrimerApellido"
        Me.PrimerApellido.ReadOnly = True
        Me.PrimerApellido.Width = 127
        '
        'SegundoNombre
        '
        Me.SegundoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.SegundoNombre.HeaderText = "Segundo Apellido"
        Me.SegundoNombre.MinimumWidth = 6
        Me.SegundoNombre.Name = "SegundoNombre"
        Me.SegundoNombre.ReadOnly = True
        Me.SegundoNombre.Width = 138
        '
        'VImporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 594)
        Me.Controls.Add(Me.dtgTabla)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.lblGasto)
        Me.Controls.Add(Me.lblAgregarEmpleado)
        Me.Font = New System.Drawing.Font("Bahnschrift", 8.25!)
        Me.Name = "VImporte"
        Me.Text = "Form2"
        CType(Me.dtgTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAgregarEmpleado As Windows.Forms.Label
    Friend WithEvents lblGasto As Windows.Forms.Label
    Friend WithEvents btnAtras As Windows.Forms.Button
    Friend WithEvents dtgTabla As Windows.Forms.DataGridView
    Friend WithEvents CI As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SueldoPorMes As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimerNombre As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegundoApellido As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimerApellido As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SegundoNombre As Windows.Forms.DataGridViewTextBoxColumn
End Class
