Imports Control
Imports System
Public Class VAgregarTelefonos
    Private vAnterior As Object
    Private control As ControlEmpleados
    Private pos As Integer

    Public Sub New(control As ControlEmpleados, vAnterior As VAgregarEmpleado)
        Me.vAnterior = vAnterior
        Me.control = control
        InitializeComponent()


    End Sub
    Public Sub New(control As ControlEmpleados, vAnterior As VModificarEmpleado)

        Me.vAnterior = vAnterior
        Me.control = control
        InitializeComponent()

    End Sub
    Function agregarProcision(pos As Integer)
        Me.pos = pos
    End Function

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        vAnterior.show()
    End Sub

    Private Sub btnAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click
        'Dim auxEmpleado = control.tomarEmpleado(pos)

        'If Not txtNumero.Equals("") Then
        '    lbNumeros.Items.Add(txtNumero)
        '   auxEmpleado.telefonos(auxEmpleado.telefonos.Length) = txtNumero.Text
        'End If
    End Sub
    Private Sub btnEliminarTelefono_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Dim auxEmpleado = control.tomarEmpleado(pos)
        'If lbNumeros.SelectedIndex > -1 Then
        '   lbNumeros.Items.RemoveAt(lbNumeros.SelectedIndex)
        '    Array.Clear(auxEmpleado.telefonos, lbNumeros.SelectedIndex, 1)
        'End If
    End Sub

    Private Sub VAgregarTelefonos_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        'lbNumeros.Items.Clear()
        'Dim auxEmpleado = control.tomarEmpleado(pos)
        'If auxEmpleado Is Nothing Then

        'End If


        'For Each telefono As String In auxEmpleado.telefonos
        'lbNumeros.Items.Add(telefono)
        'Next
    End Sub
End Class