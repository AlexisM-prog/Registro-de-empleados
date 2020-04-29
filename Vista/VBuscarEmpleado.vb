Imports Control
Imports System.Windows.Forms
Imports LogicaDatos

Public Class VBuscarEmpleado
    Private vAnterior As VRegistroEmpleado
    Private vModificarEmpelado As Object
    Private control As ControlEmpleados

    Public Sub New(control As ControlEmpleados, vAnterior As VRegistroEmpleado)

        Me.control = control
        Me.vAnterior = vAnterior
        Me.vModificarEmpelado = New VModificarEmpleado(control, Me)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        Me.vAnterior.Show()
    End Sub
    Private Sub VBuscarEmpleado_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Dim auxEmpleado As Empleado
        Me.dtgTabla.Rows.Clear()

        For i As Integer = 0 To control.nroDeEmpleados - 1
            auxEmpleado = control.tomarEmpleado(i)
            If Not Me.ccbSoloTrabajando.Checked Or auxEmpleado.activo Then
                Me.dtgTabla.Rows.Add(
                    New String() {
                        auxEmpleado.CI, auxEmpleado.sueldoPorMes,
                        auxEmpleado.PNom, auxEmpleado.SNom,
                        auxEmpleado.PApe, auxEmpleado.SApe
                    }
                )
            End If
        Next
    End Sub
    Private Sub dtgTabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgTabla.CellClick
        vModificarEmpelado.nroEmpleado = e.RowIndex
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.Hide()
        vModificarEmpelado.Show()
    End Sub
    Function soloNumeros(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Function
    Private Sub txtBuscarCI_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarCI.KeyUp
        Dim auxEmpleado As Empleado
        Dim ciEntrada, ciGuardado As String
        Me.dtgTabla.Rows.Clear()

        For i As Integer = 0 To control.nroDeEmpleados - 1
            auxEmpleado = control.tomarEmpleado(i)
            If Not Me.ccbSoloTrabajando.Checked Or auxEmpleado.activo Then
                ciGuardado = auxEmpleado.CI
                ciEntrada = txtBuscarCI.Text
                If ciEntrada.Equals(ciGuardado.Substring(0, ciEntrada.Count)) Or ciEntrada.Length <= 0 Then
                    If Not Me.ccbSoloTrabajando.Checked Or auxEmpleado.activo Then
                        Me.dtgTabla.Rows.Add(
                            New String() {
                                auxEmpleado.CI, auxEmpleado.sueldoPorMes,
                                auxEmpleado.PNom, auxEmpleado.SNom,
                                auxEmpleado.PApe, auxEmpleado.SApe
                            }
                        )
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub txtBuscarCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarCI.KeyPress
        soloNumeros(e)
    End Sub
    Private Sub ccbSoloTrabajando_CheckStateChanged(sender As Object, e As EventArgs) Handles ccbSoloTrabajando.CheckStateChanged
        txtBuscarCI_KeyUp(sender, Nothing)

    End Sub
End Class