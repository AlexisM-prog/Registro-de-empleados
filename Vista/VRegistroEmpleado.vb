Imports Control
Public Class VRegistroEmpleado

    Private vAnterior As VMenuPrincipal
    Private vAgregarEmpleado As VAgregarEmpleado
    Private vBuscarEmpleado As VBuscarEmpleado
    Private control As ControlEmpleados

    Public Sub New(control As ControlEmpleados, vAnterior As VMenuPrincipal)
        Me.vAnterior = vAnterior
        Me.control = control
        Me.vAgregarEmpleado = New VAgregarEmpleado(control, Me)
        Me.vBuscarEmpleado = New VBuscarEmpleado(control, Me)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub btnModificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnModificarEmpleado.Click
        Me.Hide()
        Me.vBuscarEmpleado.Show()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        Me.vAnterior.Show()
    End Sub
    Private Sub btnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click
        Me.Hide()
        Me.vAgregarEmpleado.Show()
    End Sub

End Class