Imports Control
Imports LogicaDatos

Public Class VImporte
    Private vAnterior As VMenuPrincipal
    Private control As ControlEmpleados
    Public Sub New(control As ControlEmpleados, vAnterior As VMenuPrincipal)
        Me.vAnterior = vAnterior
        Me.control = control

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        Me.vAnterior.Show()
    End Sub
    Private Sub VImporte_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Dim gastoTotal As Integer = 0
        Dim auxEmpleado As Empleado
        Me.dtgTabla.Rows.Clear()

        For i As Integer = 0 To control.nroDeEmpleados - 1
            auxEmpleado = control.tomarEmpleado(i)
            gastoTotal += auxEmpleado.sueldoPorMes
            If i < 20 Then
                If control.nroDeEmpleados > i Then
                    auxEmpleado = control.tomarEmpleado(i)
                    Me.dtgTabla.Rows.Add(
                        New String() {
                            auxEmpleado.CI, auxEmpleado.sueldoPorMes,
                            auxEmpleado.PNom, auxEmpleado.SNom,
                            auxEmpleado.PApe, auxEmpleado.SApe
                        }
                    )
                End If
            End If
        Next
        lblGasto.Text = "Gasto total:" & gastoTotal
    End Sub
End Class